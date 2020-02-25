namespace Ghadir
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerTextBox = new System.Windows.Forms.Timer(this.components);
            this.timerLive = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnimation2 = new System.Windows.Forms.Label();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBase1 = new System.Windows.Forms.Label();
            this.lblBase2 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(85, 455);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(204, 36);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "خطا در وارد کردن اطلاعات";
            this.lblWarning.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(135, 503);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(105, 42);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "ورود";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.btnlogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnlogin_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timerTextBox
            // 
            this.timerTextBox.Interval = 10;
            this.timerTextBox.Tick += new System.EventHandler(this.timerTextBox_Tick);
            // 
            // timerLive
            // 
            this.timerLive.Interval = 10;
            this.timerLive.Tick += new System.EventHandler(this.timerLive_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnimation2);
            this.panel1.Controls.Add(this.lblAnimation);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblBase1);
            this.panel1.Controls.Add(this.lblBase2);
            this.panel1.Location = new System.Drawing.Point(12, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 238);
            this.panel1.TabIndex = 0;
            // 
            // lblAnimation2
            // 
            this.lblAnimation2.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAnimation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAnimation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.lblAnimation2.Location = new System.Drawing.Point(171, 197);
            this.lblAnimation2.Name = "lblAnimation2";
            this.lblAnimation2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAnimation2.Size = new System.Drawing.Size(0, 2);
            this.lblAnimation2.TabIndex = 20;
            this.lblAnimation2.Text = "نام کاربری:";
            // 
            // lblAnimation
            // 
            this.lblAnimation.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.lblAnimation.Location = new System.Drawing.Point(171, 113);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAnimation.Size = new System.Drawing.Size(0, 2);
            this.lblAnimation.TabIndex = 18;
            this.lblAnimation.Text = "نام کاربری:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(26, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(290, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(26, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(238, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(81, 36);
            this.lblPass.TabIndex = 16;
            this.lblPass.Text = "رمز عبور:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(233, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(94, 36);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "نام کاربری:";
            // 
            // lblBase1
            // 
            this.lblBase1.BackColor = System.Drawing.Color.Silver;
            this.lblBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBase1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.lblBase1.Location = new System.Drawing.Point(26, 113);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBase1.Size = new System.Drawing.Size(290, 2);
            this.lblBase1.TabIndex = 17;
            this.lblBase1.Text = "نام کاربری:";
            // 
            // lblBase2
            // 
            this.lblBase2.BackColor = System.Drawing.Color.Silver;
            this.lblBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.lblBase2.Location = new System.Drawing.Point(26, 197);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBase2.Size = new System.Drawing.Size(290, 2);
            this.lblBase2.TabIndex = 19;
            this.lblBase2.Text = "نام کاربری:";
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Ghadir.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(341, 8);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 21);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Ghadir.Properties.Resources.logo;
            this.picIcon.Location = new System.Drawing.Point(81, 32);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(212, 149);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // timerError
            // 
            this.timerError.Interval = 10;
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(374, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timerTextBox;
        private System.Windows.Forms.Timer timerLive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnimation2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblBase2;
        private System.Windows.Forms.Label lblAnimation;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBase1;
        private System.Windows.Forms.Timer timerError;
    }
}

