using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ghadir
{
    public partial class FormCurrentDate : Form
    {
        public FormCurrentDate()
        {
            InitializeComponent();
        }
        int mouseX, mouseY;
        bool click = false;
        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (txtDay.TextLength == 2 )
            {
                txtMonth.Focus();
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtMonth.TextLength == 2)
            {
                txtYear.Focus();
            }
        }

        private void FormCurrentDate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void FormCurrentDate_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtDay.TextLength == 0 || txtMonth.TextLength == 0 || txtYear.TextLength == 0)
            {
                MessageBox.Show(".لطفا فیلد های تاریخ را پر کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (txtYear.TextLength != 4  || byte.Parse(txtDay.Text) > 31 || byte.Parse(txtMonth.Text)>12)
            {
                MessageBox.Show(".لطفا فیلد های تاریخ را درست وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                ClassCurrentDate.currentDate = txtYear.Text + "/" + txtMonth.Text + "/" + txtDay.Text;
                MainForm frm = new MainForm();
                frm.Show();
            }
        }

        private void FormCurrentDate_Load(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            PersianCalendar persianCalendar = new PersianCalendar();
            txtYear.Text  = persianCalendar.GetYear(dateTime).ToString();
            txtMonth.Text = persianCalendar.GetMonth(dateTime).ToString();
            txtDay.Text = persianCalendar.GetDayOfMonth(dateTime).ToString();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtMonth.TextLength == 4)
            {
                btnEnter.Focus();
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void FormCurrentDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEnter_Click(null, null);
            }
        }

        private void FormCurrentDate_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
