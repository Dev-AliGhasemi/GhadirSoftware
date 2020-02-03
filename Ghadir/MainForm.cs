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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        PictureBox picControlButton;
        Button buttonMenu;
        int mouseX,mouseY,gam = 13,gamRectangle=13;
        bool click = false, clickMenu = false;
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picControlButton = (PictureBox)sender;
            int x = picControlButton.Left + (picControlButton.Width/2);
            picControlButton.Width += 5;
            picControlButton.Height += 5;
            picControlButton.Left -= ((picControlButton.Width / 2) + picControlButton.Left) - x;
            picControlButton.Top = ((panelBorder.Height - picControlButton.Height) / 2);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picControlButton = (PictureBox)sender;
            int x = picControlButton.Left + (picControlButton.Width / 2);
            picControlButton.Width = 31;
            picControlButton.Height = 29;
            picControlButton.Left += x-((picControlButton.Width / 2) + picControlButton.Left);
            picControlButton.Top = ((panelBorder.Height - picControlButton.Height) / 2);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            panelControlButton.Left = panelBorder.Width-panelControlButton.Width;
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            ExitForm frmExit = new ExitForm();
            frmExit.ShowDialog();
        }

        private void picMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picMaximize.Image = Properties.Resources.Maximize;
            }
            else
            {  
                this.WindowState = FormWindowState.Maximized;
                picMaximize.Image = Properties.Resources.Restore;
            }
        }
        private void picMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void panelBorder_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelMenuNavigation.Width = 0;
        }

        private void picShowMenu_MouseEnter(object sender, EventArgs e)
        {
            picShowMenu.BackColor = Color.FromArgb(27, 30, 51);
        }

        private void picShowMenu_MouseLeave(object sender, EventArgs e)
        {
            picShowMenu.BackColor = Color.FromArgb(70, 79, 134);
        }

        private void picShowMenu_MouseClick(object sender, MouseEventArgs e)
        {
            picShowMenu.Visible = false;
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    // sectionFirst1.Left = 250;
            //}
            if (panelMenuNavigation.Width == 250)
            {
                if (this.WindowState != FormWindowState.Maximized)
                {
                    sectionFirst1.Left = 0;
                }
                picLogoMenu.Visible = false;
                panelMenuNavigation.Width = 0;
                panelBackMenu.Left = -239;
                picShowMenu.Image = Properties.Resources.showMenu;
                picShowMenu.Visible = true;
            }
            else
            {
                panelMenuNavigation.Width = 250;
                picShowMenu.Image = Properties.Resources.hideMenu;
                timerMenuNavigation.Start();
            }
        }
        private void btnUser_MouseClick(object sender, MouseEventArgs e)
        {
            buttonMenu = (Button)sender;
            if (buttonMenu.Top < lblRectangle.Top)
            {
                timerRectangleUp.Start();
            }
            else
            {
                timerRectangleDown.Start();
            }
            if (buttonMenu.Text == "منوی اعضا")
            {
                //clickMenu = true;
                sectionAza1.Visible = true;
                panelMenuNavigation.Width = 0;
                picShowMenu.Image = Properties.Resources.showMenu;
                panelBackMenu.Left = -239;
                sectionAza1.BringToFront();
            }
            else if (buttonMenu.Text == "وام ها")
            {
                //clickMenu = true;
                sectionVam1.Visible = true;
                panelMenuNavigation.Width = 0;
                picShowMenu.Image = Properties.Resources.showMenu;
                panelBackMenu.Left = -239;
                sectionVam1.BringToFront();
            }
            else if (buttonMenu.Text == "سرمایه")
            {
                //clickMenu = true;
                panelMenuNavigation.Width = 0;
                picShowMenu.Image = Properties.Resources.showMenu;
                panelBackMenu.Left = -239;
                sectionSarmaye1.Visible = true;
                sectionSarmaye1.BringToFront();
            }
            else if (buttonMenu.Text == "وضعیت صندوق")
            {
                //clickMenu = true;
                sectionStatusOfSandoogh1.Visible = true;
                sectionStatusOfSandoogh1.BringToFront();
            }
            else if (buttonMenu.Text == "امکانات")
            {
                //clickMenu = true;
                panelMenuNavigation.Width = 0;
                picShowMenu.Image = Properties.Resources.showMenu;
                panelBackMenu.Left = -239;
                sectionFeatures1.Visible = true;
                sectionFeatures1.BringToFront();
            }
            else if (buttonMenu.Text == "کاربری")
            {
                //clickMenu = true;
                sectionKarbary1.Visible = true;
                sectionKarbary1.BringToFront();
            }
            else if (buttonMenu.Text == "تنظیمات")
            {
                //clickMenu = true;
                sectionSetting1.Visible = true;
                sectionSetting1.BringToFront();
            }
        }
        private void picLogoMenu_MouseClick_1(object sender, MouseEventArgs e)
        {
            sectionFirst1.BringToFront();
            sectionAza1.Visible = false;
            sectionFeatures1.Visible = false;
            sectionKarbary1.Visible = false;
            sectionSarmaye1.Visible = false;
            sectionSetting1.Visible = false;
            sectionStatusOfSandoogh1.Visible = false;
            sectionVam1.Visible = false;
        }
        private void timerRectangleUp_Tick(object sender, EventArgs e)
        {
            if (buttonMenu.Top+20 >= lblRectangle.Top)
            {
                gamRectangle = 2;
            }
            if (lblRectangle.Top <= buttonMenu.Top)
            {
                timerRectangleUp.Stop();
                lblRectangle.Top = buttonMenu.Top + 14;
                gamRectangle = 13;
            }
            lblRectangle.Top -= gamRectangle;
        }

        private void timerRectangle_Tick(object sender, EventArgs e)
        {
                if (buttonMenu.Top - 12 <= lblRectangle.Top)
                {
                    gamRectangle = 2;
                }
                if (lblRectangle.Top >= buttonMenu.Top)
                {
                    timerRectangleDown.Stop();
                    lblRectangle.Top = buttonMenu.Top - 10;
                    gamRectangle = 13;
                }
                lblRectangle.Top += gamRectangle;

        }

        private void timerMenuNavigation_Tick(object sender, EventArgs e)
        {
            if (panelBackMenu.Left >= -50)
            {
                gam = 5;
            }
            if (panelBackMenu.Left >=12)
            {
                timerMenuNavigation.Stop();
                animatorLogo.ShowSync(picLogoMenu);
                panelBackMenu.Left = 3;
                picShowMenu.Visible = true;
                gam = 13;
            }
            panelBackMenu.Left += gam;
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
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
