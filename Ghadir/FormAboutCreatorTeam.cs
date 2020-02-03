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
    public partial class FormAboutCreatorTeam : Form
    {
        public FormAboutCreatorTeam()
        {
            InitializeComponent();
        }
        bool click = false;
        int mouseX, mouseY;
        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void FormAboutCreatorTeam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void FormAboutCreatorTeam_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void FormAboutCreatorTeam_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
