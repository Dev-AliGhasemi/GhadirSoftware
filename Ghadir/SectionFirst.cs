using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghadir
{
    public partial class SectionFirst : UserControl
    {
        public SectionFirst()
        {
            InitializeComponent();
        }

        private void picLawsButton_MouseEnter(object sender, EventArgs e)
        {
            picLawsButton.Image = Properties.Resources.iconLawsMouseHover;
        }

        private void picLawsButton_MouseLeave(object sender, EventArgs e)
        {
            picLawsButton.Image = Properties.Resources.iconLawsMouseLeave;
        }

        private void picTeamButton_MouseEnter(object sender, EventArgs e)
        {
            picTeamButton.Image = Properties.Resources.iconTeamMouseHover;
        }

        private void picTeamButton_MouseLeave(object sender, EventArgs e)
        {
            picTeamButton.Image = Properties.Resources.iconTeamMouseLeave;
        }

        private void picLawsButton_MouseClick(object sender, MouseEventArgs e)
        {
            FormIntroduceLaws frm = new FormIntroduceLaws();
            frm.ShowDialog();
        }

        private void picTeamButton_MouseClick(object sender, MouseEventArgs e)
        {
            FormAboutCreatorTeam frm = new FormAboutCreatorTeam();
            frm.ShowDialog();
        }

        private void SectionFirst_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 1084)
            {
                lblTitle.Left = (this.Width - lblTitle.Width) / 2;
                lblProviderGorj.Left = 10;
                panelPics.Top = (this.Height - panelPics.Height) / 2 +20;
                panelPics.Left = (this.Width - panelPics.Width) / 2;
            }
            else
            {
                lblTitle.Left = (this.Width - lblTitle.Width) / 2;
                lblProviderGorj.Left = 10;
                panelPics.Top = (this.Height - panelPics.Height) / 2+20;
                panelPics.Left = (this.Width - panelPics.Width) / 2;
            }
        }
    }
}
