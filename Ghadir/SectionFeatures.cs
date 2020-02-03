using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Ghadir
{
    public partial class SectionFeatures : UserControl
    {
        public SectionFeatures()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True;");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string addressBackup;
        private void picCalculator_MouseEnter(object sender, EventArgs e)
        {
            picCalculator.Image = Properties.Resources.iconCalculatorMouseHover;
        }

        private void picCalculator_MouseLeave(object sender, EventArgs e)
        {
            picCalculator.Image = Properties.Resources.iconCalculatorMouseLeave;
        }
        private void picSetDate_MouseEnter(object sender, EventArgs e)
        {
            picSetDate.Image = Properties.Resources.iconSetClockMouseHover;
        }

        private void picSetDate_MouseLeave(object sender, EventArgs e)
        {
            picSetDate.Image = Properties.Resources.iconSetClockMouseLeave;
        }

        private void picHelp_MouseEnter(object sender, EventArgs e)
        {
            picHelp.Image = Properties.Resources.iconHelpSoftwareMouseHover;
        }

        private void picHelp_MouseLeave(object sender, EventArgs e)
        {
            picHelp.Image = Properties.Resources.iconHelpSoftwareMouseLeave;
        }

        private void picNote_MouseEnter(object sender, EventArgs e)
        {
            picNote.Image = Properties.Resources.iconNoteMouseHover;
        }

        private void picNote_MouseLeave(object sender, EventArgs e)
        {
            picNote.Image = Properties.Resources.iconNoteMouseLeave;
        }
        private void picBackup_MouseLeave(object sender, EventArgs e)
        {
            picBackup.Image = Properties.Resources.iconBackupMouseleave;
        }

        private void picBackup_MouseEnter(object sender, EventArgs e)
        {
            picBackup.Image = Properties.Resources.iconBackupMouseHover;
        }

        private void picCalculator_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process.Start(@"C:\Windows\system32\calc.exe");
            }
            catch 
            {
                MessageBox.Show("خطا در بازکردن ماشین حساب ویندوز", "!!خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void picSetDate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process.Start("timedate.cpl");
            }
            catch 
            {
                MessageBox.Show("خطا در بازکردن تنظیمات ویندوز", "!!خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void picNote_MouseClick(object sender, MouseEventArgs e)
        {
            FormNote frm = new FormNote();
            frm.Show();
        }

        private void picBackup_MouseClick(object sender, MouseEventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select AddressBackup from tbl_setting";
            con.Open();
            addressBackup =  com.ExecuteScalar().ToString();
            if (addressBackup.Length != 0)
            {
                try
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string[] date = ClassCurrentDate.currentDate.Split('/');
                    addressBackup = addressBackup.Insert(addressBackup.LastIndexOf(".bak"), " " + date[0]+"_"+date[1]+"_"+date[2] + "  " + dateTime.Hour + "-" + dateTime.Minute + "-" + dateTime.Second);
                    com.CommandText = "backup database ["+Application.StartupPath+"\\db_ghadir.mdf] to disk = '" + addressBackup + "'";
                    com.ExecuteNonQuery();
                    MessageBox.Show(".پشتیبان گیری با موفقیت انجام شد", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(".پشتیبان گیری با موفقیت انجام نشد", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(".لطفا ادرس فایل پشتیبان را در تنظیمات وارد کنید", "!!خطا", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void picRestore_MouseClick(object sender, MouseEventArgs e)
        {
            com.Connection = con;
            con.Open();
            try
            {
                openFileDialog1.Filter = "backup (*.bak) | *.bak";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        com.CommandText = "alter database ["+Application.StartupPath+ "\\db_ghadir.mdf] set single_user with rollback immediate use master restore database [" + Application.StartupPath + "\\db_ghadir.mdf] from disk = '" + openFileDialog1.FileName + "' with replace";
                        com.ExecuteNonQuery();
                        MessageBox.Show(". بازیابی با موفقیت انجام شد", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch
            {
                MessageBox.Show(". بازیابی با موفقیت انجام نشد", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void picRestore_MouseEnter(object sender, EventArgs e)
        {
            picRestore.Image = Properties.Resources.iconRestoreMouseHover;
        }

        private void picRestore_MouseLeave(object sender, EventArgs e)
        {
            picRestore.Image = Properties.Resources.iconRestoreMouseLeave;
        }

        private void picHelp_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + @"\help\Help.mp4");
            }
            catch 
            {
            }
        }
    }
}
