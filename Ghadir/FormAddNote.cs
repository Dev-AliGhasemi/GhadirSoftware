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
    public partial class FormAddNote : Form
    {
        bool isAddNoteForm;
        int ID;
        public FormAddNote(bool isAddNoteForm,int ID)
        {
            InitializeComponent();
            this.isAddNoteForm = isAddNoteForm;
            this.ID = ID;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        bool click = false;
        int mouseX, mouseY;
        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void FormAddNote_Load(object sender, EventArgs e)
        {
            if (!isAddNoteForm)
            {
                com.Connection = con;
                com.CommandText = "select Title from tbl_note where ID = "+ID;
                con.Open();
                txtTitle.Text = com.ExecuteScalar().ToString();
                com.CommandText = "select Text from tbl_note  where ID = "+ID;
                txtText.Text = com.ExecuteScalar().ToString();
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNoteForm)
          {
            if (txtTitle.TextLength == 0 || txtText.TextLength == 0)
            {
                MessageBox.Show(".بعضی از فیلد ها پر نشده است", "!!هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                com.Connection = con;
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                com.Parameters.AddWithValue("@Text", txtText.Text.Trim());
                com.CommandText = "insert into tbl_note (Title , Text ) values(@Title,@Text)";
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(".یادداشت با موفقیت ثبت شد", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtText.Clear();
                txtTitle.Clear();
            }
          }
            else
            {
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                com.Parameters.AddWithValue("@Text", txtText.Text.Trim());
                com.CommandText = "update tbl_note set Title = @Title , Text = @Text where ID ="+ID;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(".یادداشت با موفقیت ویرایش شد", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Right && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Space && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
