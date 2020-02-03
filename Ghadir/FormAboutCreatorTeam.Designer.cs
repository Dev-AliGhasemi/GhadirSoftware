namespace Ghadir
{
    partial class FormAboutCreatorTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutCreatorTeam));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIntroduceTeam = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Roya", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitle.Location = new System.Drawing.Point(378, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(172, 66);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "تیم سازنده";
            // 
            // lblIntroduceTeam
            // 
            this.lblIntroduceTeam.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIntroduceTeam.ForeColor = System.Drawing.Color.White;
            this.lblIntroduceTeam.Location = new System.Drawing.Point(4, 64);
            this.lblIntroduceTeam.Name = "lblIntroduceTeam";
            this.lblIntroduceTeam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIntroduceTeam.Size = new System.Drawing.Size(905, 193);
            this.lblIntroduceTeam.TabIndex = 73;
            this.lblIntroduceTeam.Text = resources.GetString("lblIntroduceTeam.Text");
            this.lblIntroduceTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(395, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 39);
            this.btnOK.TabIndex = 72;
            this.btnOK.Text = "تایید";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ghadir.Properties.Resources.gorjLogo;
            this.pictureBox1.Location = new System.Drawing.Point(418, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 341);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 36);
            this.label1.TabIndex = 75;
            this.label1.Text = "گُرج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAboutCreatorTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(913, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIntroduceTeam);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAboutCreatorTeam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAboutCreatorTeam";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAboutCreatorTeam_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAboutCreatorTeam_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAboutCreatorTeam_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblIntroduceTeam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}