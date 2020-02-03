using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ghadir
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string addressBackup;
        bool click = false;
        int mouseX, mouseY;
        private void btnNo_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ExitForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void ExitForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void btnYes_MouseClick(object sender, MouseEventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select AddressBackup from tbl_setting";
            con.Open();
            addressBackup = com.ExecuteScalar().ToString();
            if (addressBackup.Length != 0)
            {
                try
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string[] date = ClassCurrentDate.currentDate.Split('/');
                    addressBackup = addressBackup.Insert(addressBackup.LastIndexOf(".bak"), " " + date[0] + "_" + date[1] + "_" + date[2] + "  " + dateTime.Hour + "-" + dateTime.Minute + "-" + dateTime.Second);
                    com.CommandText = "backup database [" + Application.StartupPath + "\\db_ghadir.mdf] to disk = '" + addressBackup + "'";
                    com.ExecuteNonQuery();
                    Application.Exit();
                }
                catch
                {
                    MessageBox.Show(".پشتیبان گیری با موفقیت انجام نشد ", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(".لطفا ادرس فایل پشتیبان را در تنظیمات وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void ExitForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnYes_MouseClick(null, null);
            }
        }

        private void ExitForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
