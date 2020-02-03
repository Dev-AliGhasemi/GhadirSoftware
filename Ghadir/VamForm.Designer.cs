namespace Ghadir
{
    partial class VamForm
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
            this.cboRecieverVam = new System.Windows.Forms.ComboBox();
            this.cboZamen = new System.Windows.Forms.ComboBox();
            this.cboTypeVam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMonthEnd = new System.Windows.Forms.TextBox();
            this.txtYearEnd = new System.Windows.Forms.TextBox();
            this.txtDayEnd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumberAghsat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDateBack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkKarmozd = new System.Windows.Forms.CheckBox();
            this.txtPercentKarmozd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMablagh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeZamen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNumberVam = new System.Windows.Forms.TextBox();
            this.txtCodeVamReciever = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboRecieverVam
            // 
            this.cboRecieverVam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cboRecieverVam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecieverVam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRecieverVam.Font = new System.Drawing.Font("B Roya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboRecieverVam.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboRecieverVam.FormattingEnabled = true;
            this.cboRecieverVam.Location = new System.Drawing.Point(464, 38);
            this.cboRecieverVam.Name = "cboRecieverVam";
            this.cboRecieverVam.Size = new System.Drawing.Size(210, 28);
            this.cboRecieverVam.TabIndex = 0;
            this.cboRecieverVam.SelectedIndexChanged += new System.EventHandler(this.cboRecieverVam_SelectedIndexChanged);
            // 
            // cboZamen
            // 
            this.cboZamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cboZamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboZamen.Font = new System.Drawing.Font("B Roya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboZamen.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboZamen.FormattingEnabled = true;
            this.cboZamen.Location = new System.Drawing.Point(464, 82);
            this.cboZamen.Name = "cboZamen";
            this.cboZamen.Size = new System.Drawing.Size(210, 28);
            this.cboZamen.TabIndex = 2;
            this.cboZamen.SelectedIndexChanged += new System.EventHandler(this.cboZamen_SelectedIndexChanged);
            // 
            // cboTypeVam
            // 
            this.cboTypeVam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cboTypeVam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeVam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTypeVam.Font = new System.Drawing.Font("B Roya", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboTypeVam.ForeColor = System.Drawing.Color.OrangeRed;
            this.cboTypeVam.FormattingEnabled = true;
            this.cboTypeVam.Items.AddRange(new object[] {
            "عادی",
            "زیارت",
            "ازدواج",
            "اضطراری",
            "مسکن",
            "درمان"});
            this.cboTypeVam.Location = new System.Drawing.Point(464, 130);
            this.cboTypeVam.Name = "cboTypeVam";
            this.cboTypeVam.Size = new System.Drawing.Size(210, 28);
            this.cboTypeVam.TabIndex = 4;
            this.cboTypeVam.SelectedIndexChanged += new System.EventHandler(this.cboTypeVam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ویرایش و اعطای وام";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::Ghadir.Properties.Resources.close2;
            this.picClose.Location = new System.Drawing.Point(761, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(41, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtMonthEnd);
            this.groupBox1.Controls.Add(this.txtYearEnd);
            this.groupBox1.Controls.Add(this.txtDayEnd);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNumberAghsat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDateBack);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkKarmozd);
            this.groupBox1.Controls.Add(this.txtPercentKarmozd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMablagh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodeZamen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboRecieverVam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cboTypeVam);
            this.groupBox1.Controls.Add(this.txtNumberVam);
            this.groupBox1.Controls.Add(this.txtCodeVamReciever);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cboZamen);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(778, 387);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(199, 271);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(25, 29);
            this.label18.TabIndex = 116;
            this.label18.Text = "/";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(258, 271);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(25, 29);
            this.label19.TabIndex = 115;
            this.label19.Text = "/";
            // 
            // txtMonthEnd
            // 
            this.txtMonthEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtMonthEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonthEnd.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMonthEnd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtMonthEnd.Location = new System.Drawing.Point(225, 271);
            this.txtMonthEnd.MaxLength = 2;
            this.txtMonthEnd.Name = "txtMonthEnd";
            this.txtMonthEnd.Size = new System.Drawing.Size(32, 29);
            this.txtMonthEnd.TabIndex = 113;
            this.txtMonthEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonthEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // txtYearEnd
            // 
            this.txtYearEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtYearEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYearEnd.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYearEnd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtYearEnd.Location = new System.Drawing.Point(139, 271);
            this.txtYearEnd.MaxLength = 4;
            this.txtYearEnd.Name = "txtYearEnd";
            this.txtYearEnd.Size = new System.Drawing.Size(58, 29);
            this.txtYearEnd.TabIndex = 114;
            this.txtYearEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // txtDayEnd
            // 
            this.txtDayEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtDayEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDayEnd.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDayEnd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDayEnd.Location = new System.Drawing.Point(283, 271);
            this.txtDayEnd.MaxLength = 2;
            this.txtDayEnd.Name = "txtDayEnd";
            this.txtDayEnd.Size = new System.Drawing.Size(32, 29);
            this.txtDayEnd.TabIndex = 112;
            this.txtDayEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDayEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(315, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 35);
            this.label17.TabIndex = 111;
            this.label17.Text = "تاریخ پایان:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(536, 270);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(25, 29);
            this.label15.TabIndex = 110;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(595, 270);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(25, 29);
            this.label16.TabIndex = 109;
            this.label16.Text = "/";
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMonth.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtMonth.Location = new System.Drawing.Point(562, 270);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(32, 29);
            this.txtMonth.TabIndex = 12;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYear.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtYear.Location = new System.Drawing.Point(476, 270);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(58, 29);
            this.txtYear.TabIndex = 13;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDay.Location = new System.Drawing.Point(620, 270);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(32, 29);
            this.txtDay.TabIndex = 11;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(655, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 35);
            this.label11.TabIndex = 105;
            this.label11.Text = "تاریخ شروع:";
            // 
            // txtNumberAghsat
            // 
            this.txtNumberAghsat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtNumberAghsat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberAghsat.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumberAghsat.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNumberAghsat.Location = new System.Drawing.Point(74, 224);
            this.txtNumberAghsat.MaxLength = 9;
            this.txtNumberAghsat.Name = "txtNumberAghsat";
            this.txtNumberAghsat.Size = new System.Drawing.Size(242, 29);
            this.txtNumberAghsat.TabIndex = 10;
            this.txtNumberAghsat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberAghsat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(315, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 35);
            this.label10.TabIndex = 103;
            this.label10.Text = "تعداد اقساط:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(423, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 26);
            this.label9.TabIndex = 101;
            this.label9.Text = "ماهه";
            // 
            // txtDateBack
            // 
            this.txtDateBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtDateBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateBack.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDateBack.Location = new System.Drawing.Point(464, 224);
            this.txtDateBack.Name = "txtDateBack";
            this.txtDateBack.Size = new System.Drawing.Size(192, 29);
            this.txtDateBack.TabIndex = 9;
            this.txtDateBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateBack.TextChanged += new System.EventHandler(this.txtDateBack_TextChanged);
            this.txtDateBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(653, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 35);
            this.label8.TabIndex = 100;
            this.label8.Text = "مدت بازگشت:";
            // 
            // chkKarmozd
            // 
            this.chkKarmozd.AutoSize = true;
            this.chkKarmozd.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkKarmozd.ForeColor = System.Drawing.Color.White;
            this.chkKarmozd.Location = new System.Drawing.Point(4, 176);
            this.chkKarmozd.Name = "chkKarmozd";
            this.chkKarmozd.Size = new System.Drawing.Size(66, 31);
            this.chkKarmozd.TabIndex = 8;
            this.chkKarmozd.Text = "کارمزد";
            this.chkKarmozd.UseVisualStyleBackColor = true;
            this.chkKarmozd.CheckedChanged += new System.EventHandler(this.chkKarmozd_CheckedChanged_1);
            // 
            // txtPercentKarmozd
            // 
            this.txtPercentKarmozd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtPercentKarmozd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercentKarmozd.Enabled = false;
            this.txtPercentKarmozd.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPercentKarmozd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtPercentKarmozd.Location = new System.Drawing.Point(74, 177);
            this.txtPercentKarmozd.MaxLength = 3;
            this.txtPercentKarmozd.Name = "txtPercentKarmozd";
            this.txtPercentKarmozd.Size = new System.Drawing.Size(242, 29);
            this.txtPercentKarmozd.TabIndex = 7;
            this.txtPercentKarmozd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPercentKarmozd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(316, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 35);
            this.label7.TabIndex = 97;
            this.label7.Text = "درصد کارمزد:";
            // 
            // txtMablagh
            // 
            this.txtMablagh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtMablagh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMablagh.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMablagh.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtMablagh.Location = new System.Drawing.Point(464, 177);
            this.txtMablagh.MaxLength = 18;
            this.txtMablagh.Name = "txtMablagh";
            this.txtMablagh.Size = new System.Drawing.Size(210, 29);
            this.txtMablagh.TabIndex = 6;
            this.txtMablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(681, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 35);
            this.label4.TabIndex = 94;
            this.label4.Text = "مبلغ:";
            // 
            // txtCodeZamen
            // 
            this.txtCodeZamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtCodeZamen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeZamen.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeZamen.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCodeZamen.Location = new System.Drawing.Point(74, 84);
            this.txtCodeZamen.Name = "txtCodeZamen";
            this.txtCodeZamen.Size = new System.Drawing.Size(242, 29);
            this.txtCodeZamen.TabIndex = 3;
            this.txtCodeZamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodeZamen.TextChanged += new System.EventHandler(this.txtCodeZamen_TextChanged);
            this.txtCodeZamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(325, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 92;
            this.label3.Text = "شماره عضویت:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "وام گیرنده:";
            // 
            // btnCancel
            // 
            this.btnCancel.Active = true;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "انصراف";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = global::Ghadir.Properties.Resources.iconCancel;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(232, 323);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(141, 45);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNumberVam
            // 
            this.txtNumberVam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtNumberVam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberVam.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumberVam.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNumberVam.Location = new System.Drawing.Point(74, 130);
            this.txtNumberVam.Name = "txtNumberVam";
            this.txtNumberVam.ReadOnly = true;
            this.txtNumberVam.Size = new System.Drawing.Size(242, 29);
            this.txtNumberVam.TabIndex = 5;
            this.txtNumberVam.Text = "100000";
            this.txtNumberVam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodeVamReciever
            // 
            this.txtCodeVamReciever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtCodeVamReciever.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeVamReciever.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeVamReciever.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCodeVamReciever.Location = new System.Drawing.Point(74, 38);
            this.txtCodeVamReciever.Name = "txtCodeVamReciever";
            this.txtCodeVamReciever.Size = new System.Drawing.Size(242, 29);
            this.txtCodeVamReciever.TabIndex = 1;
            this.txtCodeVamReciever.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodeVamReciever.TextChanged += new System.EventHandler(this.txtCodeVamReciever_TextChanged);
            this.txtCodeVamReciever.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVamReciever_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "ذخیره";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = global::Ghadir.Properties.Resources.iconAdd;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(405, 323);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(141, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(325, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 35);
            this.label14.TabIndex = 26;
            this.label14.Text = "شماره عضویت:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(321, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 35);
            this.label5.TabIndex = 90;
            this.label5.Text = "شماره وام:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(684, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 35);
            this.label13.TabIndex = 25;
            this.label13.Text = "ضامن:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(684, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 35);
            this.label12.TabIndex = 24;
            this.label12.Text = "نوع وام:";
            // 
            // VamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(802, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VamForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VamForm";
            this.Load += new System.EventHandler(this.VamForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodeVamReciever;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.TextBox txtNumberVam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeZamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkKarmozd;
        private System.Windows.Forms.TextBox txtPercentKarmozd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMablagh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumberAghsat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDateBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMonthEnd;
        private System.Windows.Forms.TextBox txtYearEnd;
        private System.Windows.Forms.TextBox txtDayEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.ComboBox cboRecieverVam;
        private System.Windows.Forms.ComboBox cboZamen;
        private System.Windows.Forms.ComboBox cboTypeVam;
    }
}