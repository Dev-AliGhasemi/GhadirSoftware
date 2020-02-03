namespace Ghadir
{
    partial class FormCurrentDate
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = ".لطفا تاریخ امروز را وارد کنید";
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDay.Location = new System.Drawing.Point(333, 89);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(47, 32);
            this.txtDay.TabIndex = 1;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMonth.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtMonth.Location = new System.Drawing.Point(258, 89);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(47, 32);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYear.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtYear.Location = new System.Drawing.Point(162, 89);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(66, 32);
            this.txtYear.TabIndex = 3;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(474, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "دقت داشته باشید وارد کردن تاریخ غلط باعث ایجاد اختلال در محاسبات برنامه می شود.";
            // 
            // btnEnter
            // 
            this.btnEnter.Active = false;
            this.btnEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.BorderRadius = 5;
            this.btnEnter.ButtonText = "ورود";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnter.Iconimage = null;
            this.btnEnter.Iconimage_right = null;
            this.btnEnter.Iconimage_right_Selected = null;
            this.btnEnter.Iconimage_Selected = null;
            this.btnEnter.IconMarginLeft = 0;
            this.btnEnter.IconMarginRight = 0;
            this.btnEnter.IconRightVisible = true;
            this.btnEnter.IconRightZoom = 0D;
            this.btnEnter.IconVisible = true;
            this.btnEnter.IconZoom = 50D;
            this.btnEnter.IsTab = false;
            this.btnEnter.Location = new System.Drawing.Point(221, 177);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(100, 45);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "ورود";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // FormCurrentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(542, 239);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormCurrentDate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCurrentDate";
            this.Load += new System.EventHandler(this.FormCurrentDate_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCurrentDate_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCurrentDate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCurrentDate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCurrentDate_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        public System.Windows.Forms.TextBox txtDay;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtMonth;
    }
}