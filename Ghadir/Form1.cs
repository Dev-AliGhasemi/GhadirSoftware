using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace Ghadir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox textBox;
        bool click = false;
        int mousex, mousey;
        bool left = false, right;
        int count;
        SoundPlayer musicError = new SoundPlayer(Properties.Resources.error);
        string username = "admin",password="admin";
        private void connection()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename="+Application.StartupPath+"\\db_ghadir.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            con.Open();
            com.CommandText = "select username from tbl_login";
            username = com.ExecuteScalar().ToString();
            com.CommandText = "select password from tbl_login";
            password = com.ExecuteScalar().ToString();
            con.Close();
        }
        private void timerTextBox_Tick(object sender, EventArgs e)
        {
            int half;
            switch (textBox.Name)
            {
                case "txtUsername":
                    half = lblAnimation.Left + lblAnimation.Width / 2;
                    lblAnimation.Width += 20;
                    half = lblAnimation.Left + lblAnimation.Width / 2 - (half);
                    lblAnimation.Left -= half;
                    if (lblAnimation.Width >= txtUsername.Width)
                    {
                        timerTextBox.Stop();
                        lblAnimation.Width = txtUsername.Width;
                        lblAnimation.Left = txtUsername.Left;
                    }
                    break;
                case "txtPassword":
                    half = lblAnimation2.Left + lblAnimation2.Width / 2;
                    lblAnimation2.Width += 20;
                    half = lblAnimation2.Left + lblAnimation2.Width / 2 - (half);
                    lblAnimation2.Left -= half;
                    if (lblAnimation2.Width >= txtPassword.Width)
                    {
                        timerTextBox.Stop();
                        lblAnimation2.Width = txtPassword.Width;
                        lblAnimation2.Left = txtPassword.Left;
                    }
                    break;
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            textBox = (TextBox)sender;
            timerTextBox.Start();
        }

        private void timerLive_Tick(object sender, EventArgs e)
        {
            if (txtUsername.Focused==true)
            {
                lblAnimation2.Width = 0;
                lblAnimation2.Left = lblBase2.Width / 2 + lblBase2.Left;
                textBox = txtUsername;
                timerTextBox.Start();
            }
           else if (txtPassword.Focused == true)
            {
                lblAnimation.Width = 0;
                lblAnimation.Left = lblBase1.Width / 2+lblBase1.Left;
                textBox = txtPassword;
                timerTextBox.Start();
            }
            else if (txtPassword.Focused == false || txtUsername.Focused == false)
            {
                if (txtPassword.Text.Length==0)
                {
                    lblAnimation2.BackColor = Color.DodgerBlue;
                }
                if (txtUsername.Text.Length==0)
                {
                    lblAnimation.BackColor = Color.DodgerBlue;
                }
                lblAnimation.Width = 0;
                lblAnimation.Left = lblBase1.Width / 2 + lblBase1.Left;
                lblAnimation2.Width = 0;
                lblAnimation2.Left = lblBase2.Width / 2 + lblBase2.Left;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            if (txtUsername.Text !=username)
            {
                lblAnimation.BackColor = Color.Red;
            }
            else
            {
                lblAnimation.BackColor = Color.Green;
            }
            if (txtUsername.TextLength == 0)
            {
                lblAnimation.BackColor = Color.DodgerBlue;
            }
            
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            if (txtPassword.Text != password)
            {
                lblAnimation2.BackColor = Color.Red;
            }
            else
            {
                lblAnimation2.BackColor = Color.Green;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                click = true;
                mousex = e.X;
                mousey = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click==true)
            {
                this.Left += e.X - mousex;
                this.Top += e.Y - mousey;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                click = false;
            }
        }

        private void btnlogin_MouseClick(object sender, EventArgs e)
        {
         
            if (txtPassword.Text == password && txtUsername.Text==username)
            {
                this.Hide();
                FormCurrentDate currentDate = new FormCurrentDate();
                currentDate.Show();
            }
            else
            {
                count = 0;
                lblWarning.Visible = true;
                musicError.Play();
                timerError.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnlogin_MouseClick(null, null);
            }
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            if (left == false)
            {
                panel1.Left -= 10;
                left = true;
                right = false;
            }
            else if (right == false)
            {
                count++;
                if (count==10)
                {
                    timerError.Stop();
                }
                panel1.Left += 10;
                right = true;
                left = false;
            }
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
      
    }
}
