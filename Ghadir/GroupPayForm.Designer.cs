namespace Ghadir
{
    partial class GroupPayForm
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
            this.cboMemberName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupMembers = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.listMembers = new System.Windows.Forms.ListBox();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.groupMembers.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMemberName
            // 
            this.cboMemberName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMemberName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cboMemberName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMemberName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboMemberName.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboMemberName.FormattingEnabled = true;
            this.cboMemberName.Location = new System.Drawing.Point(14, 215);
            this.cboMemberName.Name = "cboMemberName";
            this.cboMemberName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboMemberName.Size = new System.Drawing.Size(397, 41);
            this.cboMemberName.TabIndex = 87;
            this.cboMemberName.SelectedIndexChanged += new System.EventHandler(this.cboMemberName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::Ghadir.Properties.Resources.close2;
            this.picClose.Location = new System.Drawing.Point(836, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(41, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("B Roya", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(272, 33);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(333, 51);
            this.label2.TabIndex = 92;
            this.label2.Text = "پرداخت گروهی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupMembers
            // 
            this.groupMembers.Controls.Add(this.btnPay);
            this.groupMembers.Controls.Add(this.listMembers);
            this.groupMembers.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupMembers.ForeColor = System.Drawing.Color.Lime;
            this.groupMembers.Location = new System.Drawing.Point(12, 87);
            this.groupMembers.Name = "groupMembers";
            this.groupMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupMembers.Size = new System.Drawing.Size(423, 311);
            this.groupMembers.TabIndex = 93;
            this.groupMembers.TabStop = false;
            this.groupMembers.Text = "اعضا انتخاب شده";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(10, 257);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(403, 49);
            this.btnPay.TabIndex = 90;
            this.btnPay.Text = "پرداخت گروهی";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPay_MouseClick);
            // 
            // listMembers
            // 
            this.listMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.listMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMembers.ForeColor = System.Drawing.Color.White;
            this.listMembers.FormattingEnabled = true;
            this.listMembers.ItemHeight = 35;
            this.listMembers.Location = new System.Drawing.Point(10, 33);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(403, 210);
            this.listMembers.TabIndex = 0;
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.label3);
            this.groupContact.Controls.Add(this.btnAddToList);
            this.groupContact.Controls.Add(this.label1);
            this.groupContact.Controls.Add(this.cboMemberName);
            this.groupContact.Controls.Add(this.btnSearch);
            this.groupContact.Controls.Add(this.label10);
            this.groupContact.Controls.Add(this.txtCode);
            this.groupContact.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupContact.ForeColor = System.Drawing.Color.Lime;
            this.groupContact.Location = new System.Drawing.Point(441, 87);
            this.groupContact.Name = "groupContact";
            this.groupContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupContact.Size = new System.Drawing.Size(423, 311);
            this.groupContact.TabIndex = 94;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "افراد";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 173);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(423, 1);
            this.label3.TabIndex = 90;
            this.label3.Text = "شماره عضویت";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToList.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddToList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddToList.FlatAppearance.BorderSize = 0;
            this.btnAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToList.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.Location = new System.Drawing.Point(14, 266);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(397, 39);
            this.btnAddToList.TabIndex = 89;
            this.btnAddToList.Text = "افزودن به لیست";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddToList_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(178, 175);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 88;
            this.label1.Text = "نام عضو";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(14, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(397, 39);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(155, 29);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(110, 33);
            this.label10.TabIndex = 68;
            this.label10.Text = "شماره عضویت";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCode.Location = new System.Drawing.Point(14, 70);
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCode.Size = new System.Drawing.Size(397, 34);
            this.txtCode.TabIndex = 67;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // GroupPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(877, 410);
            this.Controls.Add(this.groupContact);
            this.Controls.Add(this.groupMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupPayForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupPayForm";
            this.Load += new System.EventHandler(this.GroupPayForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.groupMembers.ResumeLayout(false);
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox groupMembers;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListBox listMembers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMemberName;
    }
}