using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghadir
{
    public partial class FormIntroduceLaws : Form
    {
        public FormIntroduceLaws()
        {
            InitializeComponent();
        }
        bool click = false;
        int mouseX, mouseY;
        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void FormIntroduceLaws_Load(object sender, EventArgs e)
        {
            txtText.Select(txtText.TextLength, txtText.TextLength);
        }

        private void FormIntroduceLaws_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void FormIntroduceLaws_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }

        private void FormIntroduceLaws_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }
    }
}
