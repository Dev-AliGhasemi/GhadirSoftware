using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ghadir
{
    public partial class SectionKarbary : UserControl
    {
        public SectionKarbary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader dataReader;
        string password;
        private void SectionKarbary_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select username from tbl_login";
            con.Open();
            txtUsername.Text = com.ExecuteScalar().ToString();
            com.CommandText = "select password from tbl_login";
            password = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar>='a' && e.KeyChar<='z') || (e.KeyChar>='A' && e.KeyChar<='Z') || (e.KeyChar >= '1' && e.KeyChar <= '9')) && e.KeyChar!='\b' )
            {
                e.Handled = true;
                lblWarning.Visible = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtConfirmNewPassword.TextLength == 0 || txtLastPassword.TextLength==0 || txtNewPassword.TextLength ==0)
            {
                MessageBox.Show(".بعضی از فیلد ها پر نشده است", "!!هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!txtNewPassword.Text.Equals(txtConfirmNewPassword.Text))
            {
                MessageBox.Show(".رمز جدید با تکرار رمز برابر نیست", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txtLastPassword.Text.Equals(password))
            {
                MessageBox.Show(".رمزعبور قبلی درست نمی باشد", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com.CommandText = "update tbl_login set username ='" + txtUsername.Text.Trim() + "' , password ='" + txtNewPassword.Text.Trim() + "'";
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(".رمز و نام کاربری ثبت شد", "!!پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();
                chkShowPass.Checked = false;
                com.CommandText = "select username from tbl_login";
                con.Open();
                txtUsername.Text = com.ExecuteScalar().ToString();
                com.CommandText = "select password from tbl_login";
                password = com.ExecuteScalar().ToString();
                con.Close();
            }
        }
    }
}
