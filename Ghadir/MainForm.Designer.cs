namespace Ghadir
{
    partial class MainForm
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelControlButton = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMenuNavigation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.panelBackMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnKarbary = new System.Windows.Forms.Button();
            this.btnEmkanat = new System.Windows.Forms.Button();
            this.btnSandoogh = new System.Windows.Forms.Button();
            this.btnSarmaye = new System.Windows.Forms.Button();
            this.btnVam = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.picLogoMenu = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sectionFirst1 = new Ghadir.SectionFirst();
            this.sectionAza1 = new Ghadir.SectionAza();
            this.sectionVam1 = new Ghadir.SectionVam();
            this.sectionSarmaye1 = new Ghadir.SectionSarmaye();
            this.sectionStatusOfSandoogh1 = new Ghadir.SectionStatusOfSandoogh();
            this.sectionFeatures1 = new Ghadir.SectionFeatures();
            this.sectionKarbary1 = new Ghadir.SectionKarbary();
            this.sectionSetting1 = new Ghadir.SectionSetting();
            this.timerRectangleDown = new System.Windows.Forms.Timer(this.components);
            this.timerMenuNavigation = new System.Windows.Forms.Timer(this.components);
            this.timerRectangleUp = new System.Windows.Forms.Timer(this.components);
            this.animatorLogo = new AnimatorNS.Animator(this.components);
            this.picShowMenu = new System.Windows.Forms.PictureBox();
            this.panelBorder.SuspendLayout();
            this.panelControlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelMenuNavigation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMenu)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.panelBorder.Controls.Add(this.panelControlButton);
            this.panelBorder.Controls.Add(this.lblTitle);
            this.animatorLogo.SetDecoration(this.panelBorder, AnimatorNS.DecorationType.None);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1084, 35);
            this.panelBorder.TabIndex = 2;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            this.panelBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseMove);
            this.panelBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseUp);
            // 
            // panelControlButton
            // 
            this.panelControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.panelControlButton.Controls.Add(this.picMinimize);
            this.panelControlButton.Controls.Add(this.picMaximize);
            this.panelControlButton.Controls.Add(this.picClose);
            this.animatorLogo.SetDecoration(this.panelControlButton, AnimatorNS.DecorationType.None);
            this.panelControlButton.Location = new System.Drawing.Point(991, 0);
            this.panelControlButton.Name = "panelControlButton";
            this.panelControlButton.Size = new System.Drawing.Size(93, 35);
            this.panelControlButton.TabIndex = 5;
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorLogo.SetDecoration(this.picMinimize, AnimatorNS.DecorationType.None);
            this.picMinimize.Image = global::Ghadir.Properties.Resources.Minimize;
            this.picMinimize.Location = new System.Drawing.Point(0, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(31, 29);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 7;
            this.picMinimize.TabStop = false;
            this.picMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMinimize_MouseClick);
            this.picMinimize.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picMaximize
            // 
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorLogo.SetDecoration(this.picMaximize, AnimatorNS.DecorationType.None);
            this.picMaximize.Image = global::Ghadir.Properties.Resources.Maximize;
            this.picMaximize.Location = new System.Drawing.Point(31, 3);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(31, 29);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaximize.TabIndex = 6;
            this.picMaximize.TabStop = false;
            this.picMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMaximize_MouseClick);
            this.picMaximize.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picMaximize.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorLogo.SetDecoration(this.picClose, AnimatorNS.DecorationType.None);
            this.picClose.Image = global::Ghadir.Properties.Resources.closeMain;
            this.picClose.Location = new System.Drawing.Point(62, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(31, 29);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 5;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.animatorLogo.SetDecoration(this.lblTitle, AnimatorNS.DecorationType.None);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "نرم افزار صندوق قرض الحسنه غدیر";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseUp);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelMenuNavigation
            // 
            this.panelMenuNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panelMenuNavigation.Controls.Add(this.panel1);
            this.panelMenuNavigation.Controls.Add(this.picLogoMenu);
            this.animatorLogo.SetDecoration(this.panelMenuNavigation, AnimatorNS.DecorationType.None);
            this.panelMenuNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuNavigation.Location = new System.Drawing.Point(0, 35);
            this.panelMenuNavigation.Name = "panelMenuNavigation";
            this.panelMenuNavigation.Size = new System.Drawing.Size(250, 576);
            this.panelMenuNavigation.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRectangle);
            this.panel1.Controls.Add(this.panelBackMenu);
            this.animatorLogo.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 430);
            this.panel1.TabIndex = 2;
            // 
            // lblRectangle
            // 
            this.lblRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.animatorLogo.SetDecoration(this.lblRectangle, AnimatorNS.DecorationType.None);
            this.lblRectangle.Location = new System.Drawing.Point(0, 5);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(10, 40);
            this.lblRectangle.TabIndex = 0;
            // 
            // panelBackMenu
            // 
            this.panelBackMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.panelBackMenu.Controls.Add(this.label1);
            this.panelBackMenu.Controls.Add(this.btnSetting);
            this.panelBackMenu.Controls.Add(this.btnKarbary);
            this.panelBackMenu.Controls.Add(this.btnEmkanat);
            this.panelBackMenu.Controls.Add(this.btnSandoogh);
            this.panelBackMenu.Controls.Add(this.btnSarmaye);
            this.panelBackMenu.Controls.Add(this.btnVam);
            this.panelBackMenu.Controls.Add(this.btnUser);
            this.animatorLogo.SetDecoration(this.panelBackMenu, AnimatorNS.DecorationType.None);
            this.panelBackMenu.Location = new System.Drawing.Point(-239, 0);
            this.panelBackMenu.Name = "panelBackMenu";
            this.panelBackMenu.Size = new System.Drawing.Size(238, 430);
            this.panelBackMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 91);
            this.label1.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnSetting, AnimatorNS.DecorationType.None);
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Ghadir.Properties.Resources.iconSetting;
            this.btnSetting.Location = new System.Drawing.Point(0, 291);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(277, 45);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnKarbary
            // 
            this.btnKarbary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnKarbary, AnimatorNS.DecorationType.None);
            this.btnKarbary.FlatAppearance.BorderSize = 0;
            this.btnKarbary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarbary.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnKarbary.ForeColor = System.Drawing.Color.White;
            this.btnKarbary.Image = global::Ghadir.Properties.Resources.iconUser;
            this.btnKarbary.Location = new System.Drawing.Point(0, 243);
            this.btnKarbary.Name = "btnKarbary";
            this.btnKarbary.Size = new System.Drawing.Size(282, 45);
            this.btnKarbary.TabIndex = 6;
            this.btnKarbary.Text = "کاربری";
            this.btnKarbary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKarbary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKarbary.UseVisualStyleBackColor = false;
            this.btnKarbary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnEmkanat
            // 
            this.btnEmkanat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnEmkanat, AnimatorNS.DecorationType.None);
            this.btnEmkanat.FlatAppearance.BorderSize = 0;
            this.btnEmkanat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmkanat.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEmkanat.ForeColor = System.Drawing.Color.White;
            this.btnEmkanat.Image = global::Ghadir.Properties.Resources.iconEmkanat;
            this.btnEmkanat.Location = new System.Drawing.Point(0, 195);
            this.btnEmkanat.Name = "btnEmkanat";
            this.btnEmkanat.Size = new System.Drawing.Size(282, 45);
            this.btnEmkanat.TabIndex = 5;
            this.btnEmkanat.Text = "امکانات";
            this.btnEmkanat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmkanat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmkanat.UseVisualStyleBackColor = false;
            this.btnEmkanat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnSandoogh
            // 
            this.btnSandoogh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnSandoogh, AnimatorNS.DecorationType.None);
            this.btnSandoogh.FlatAppearance.BorderSize = 0;
            this.btnSandoogh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSandoogh.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSandoogh.ForeColor = System.Drawing.Color.White;
            this.btnSandoogh.Image = global::Ghadir.Properties.Resources.iconSandoogh;
            this.btnSandoogh.Location = new System.Drawing.Point(0, 147);
            this.btnSandoogh.Name = "btnSandoogh";
            this.btnSandoogh.Size = new System.Drawing.Size(260, 45);
            this.btnSandoogh.TabIndex = 3;
            this.btnSandoogh.Text = "وضعیت صندوق";
            this.btnSandoogh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSandoogh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSandoogh.UseVisualStyleBackColor = false;
            this.btnSandoogh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnSarmaye
            // 
            this.btnSarmaye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnSarmaye, AnimatorNS.DecorationType.None);
            this.btnSarmaye.FlatAppearance.BorderSize = 0;
            this.btnSarmaye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarmaye.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSarmaye.ForeColor = System.Drawing.Color.White;
            this.btnSarmaye.Image = global::Ghadir.Properties.Resources.iconSarmayeh;
            this.btnSarmaye.Location = new System.Drawing.Point(0, 99);
            this.btnSarmaye.Name = "btnSarmaye";
            this.btnSarmaye.Size = new System.Drawing.Size(282, 45);
            this.btnSarmaye.TabIndex = 2;
            this.btnSarmaye.Text = "سرمایه";
            this.btnSarmaye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSarmaye.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSarmaye.UseVisualStyleBackColor = false;
            this.btnSarmaye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnVam
            // 
            this.btnVam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnVam, AnimatorNS.DecorationType.None);
            this.btnVam.FlatAppearance.BorderSize = 0;
            this.btnVam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVam.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnVam.ForeColor = System.Drawing.Color.White;
            this.btnVam.Image = global::Ghadir.Properties.Resources.iconVam;
            this.btnVam.Location = new System.Drawing.Point(0, 51);
            this.btnVam.Name = "btnVam";
            this.btnVam.Size = new System.Drawing.Size(286, 45);
            this.btnVam.TabIndex = 1;
            this.btnVam.Text = "وام ها";
            this.btnVam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVam.UseVisualStyleBackColor = false;
            this.btnVam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.btnUser, AnimatorNS.DecorationType.None);
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::Ghadir.Properties.Resources.userIcon;
            this.btnUser.Location = new System.Drawing.Point(0, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(277, 45);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "منوی اعضا";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_MouseClick);
            // 
            // picLogoMenu
            // 
            this.animatorLogo.SetDecoration(this.picLogoMenu, AnimatorNS.DecorationType.None);
            this.picLogoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoMenu.Image = global::Ghadir.Properties.Resources.logo;
            this.picLogoMenu.Location = new System.Drawing.Point(0, 0);
            this.picLogoMenu.Name = "picLogoMenu";
            this.picLogoMenu.Size = new System.Drawing.Size(250, 145);
            this.picLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMenu.TabIndex = 0;
            this.picLogoMenu.TabStop = false;
            this.picLogoMenu.Visible = false;
            this.picLogoMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picLogoMenu_MouseClick_1);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panelMain.Controls.Add(this.sectionFirst1);
            this.panelMain.Controls.Add(this.sectionAza1);
            this.panelMain.Controls.Add(this.sectionVam1);
            this.panelMain.Controls.Add(this.sectionSarmaye1);
            this.panelMain.Controls.Add(this.sectionStatusOfSandoogh1);
            this.panelMain.Controls.Add(this.sectionFeatures1);
            this.panelMain.Controls.Add(this.sectionKarbary1);
            this.panelMain.Controls.Add(this.sectionSetting1);
            this.animatorLogo.SetDecoration(this.panelMain, AnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(834, 576);
            this.panelMain.TabIndex = 0;
            // 
            // sectionFirst1
            // 
            this.sectionFirst1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionFirst1, AnimatorNS.DecorationType.None);
            this.sectionFirst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionFirst1.Location = new System.Drawing.Point(0, 0);
            this.sectionFirst1.Name = "sectionFirst1";
            this.sectionFirst1.Size = new System.Drawing.Size(834, 576);
            this.sectionFirst1.TabIndex = 1;
            // 
            // sectionAza1
            // 
            this.sectionAza1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionAza1, AnimatorNS.DecorationType.None);
            this.sectionAza1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionAza1.Location = new System.Drawing.Point(0, 0);
            this.sectionAza1.Name = "sectionAza1";
            this.sectionAza1.Size = new System.Drawing.Size(834, 576);
            this.sectionAza1.TabIndex = 0;
            // 
            // sectionVam1
            // 
            this.sectionVam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionVam1, AnimatorNS.DecorationType.None);
            this.sectionVam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionVam1.Location = new System.Drawing.Point(0, 0);
            this.sectionVam1.Name = "sectionVam1";
            this.sectionVam1.Size = new System.Drawing.Size(834, 576);
            this.sectionVam1.TabIndex = 0;
            // 
            // sectionSarmaye1
            // 
            this.sectionSarmaye1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionSarmaye1, AnimatorNS.DecorationType.None);
            this.sectionSarmaye1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionSarmaye1.ForeColor = System.Drawing.Color.White;
            this.sectionSarmaye1.Location = new System.Drawing.Point(0, 0);
            this.sectionSarmaye1.Name = "sectionSarmaye1";
            this.sectionSarmaye1.Size = new System.Drawing.Size(834, 576);
            this.sectionSarmaye1.TabIndex = 2;
            // 
            // sectionStatusOfSandoogh1
            // 
            this.sectionStatusOfSandoogh1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionStatusOfSandoogh1, AnimatorNS.DecorationType.None);
            this.sectionStatusOfSandoogh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionStatusOfSandoogh1.Location = new System.Drawing.Point(0, 0);
            this.sectionStatusOfSandoogh1.Name = "sectionStatusOfSandoogh1";
            this.sectionStatusOfSandoogh1.Size = new System.Drawing.Size(834, 576);
            this.sectionStatusOfSandoogh1.TabIndex = 3;
            // 
            // sectionFeatures1
            // 
            this.sectionFeatures1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionFeatures1, AnimatorNS.DecorationType.None);
            this.sectionFeatures1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionFeatures1.Location = new System.Drawing.Point(0, 0);
            this.sectionFeatures1.Name = "sectionFeatures1";
            this.sectionFeatures1.Size = new System.Drawing.Size(834, 576);
            this.sectionFeatures1.TabIndex = 4;
            // 
            // sectionKarbary1
            // 
            this.sectionKarbary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionKarbary1, AnimatorNS.DecorationType.None);
            this.sectionKarbary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionKarbary1.Location = new System.Drawing.Point(0, 0);
            this.sectionKarbary1.Name = "sectionKarbary1";
            this.sectionKarbary1.Size = new System.Drawing.Size(834, 576);
            this.sectionKarbary1.TabIndex = 5;
            // 
            // sectionSetting1
            // 
            this.sectionSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.animatorLogo.SetDecoration(this.sectionSetting1, AnimatorNS.DecorationType.None);
            this.sectionSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionSetting1.Location = new System.Drawing.Point(0, 0);
            this.sectionSetting1.Name = "sectionSetting1";
            this.sectionSetting1.Size = new System.Drawing.Size(834, 576);
            this.sectionSetting1.TabIndex = 6;
            // 
            // timerRectangleDown
            // 
            this.timerRectangleDown.Interval = 10;
            this.timerRectangleDown.Tick += new System.EventHandler(this.timerRectangle_Tick);
            // 
            // timerMenuNavigation
            // 
            this.timerMenuNavigation.Interval = 10;
            this.timerMenuNavigation.Tick += new System.EventHandler(this.timerMenuNavigation_Tick);
            // 
            // timerRectangleUp
            // 
            this.timerRectangleUp.Interval = 10;
            this.timerRectangleUp.Tick += new System.EventHandler(this.timerRectangleUp_Tick);
            // 
            // animatorLogo
            // 
            this.animatorLogo.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animatorLogo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animatorLogo.DefaultAnimation = animation1;
            // 
            // picShowMenu
            // 
            this.picShowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.picShowMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorLogo.SetDecoration(this.picShowMenu, AnimatorNS.DecorationType.None);
            this.picShowMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.picShowMenu.Image = global::Ghadir.Properties.Resources.showMenu;
            this.picShowMenu.Location = new System.Drawing.Point(250, 35);
            this.picShowMenu.Name = "picShowMenu";
            this.picShowMenu.Size = new System.Drawing.Size(15, 576);
            this.picShowMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowMenu.TabIndex = 0;
            this.picShowMenu.TabStop = false;
            this.picShowMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picShowMenu_MouseClick);
            this.picShowMenu.MouseEnter += new System.EventHandler(this.picShowMenu_MouseEnter);
            this.picShowMenu.MouseLeave += new System.EventHandler(this.picShowMenu_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.picShowMenu);
            this.Controls.Add(this.panelMenuNavigation);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBorder);
            this.animatorLogo.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.panelControlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelMenuNavigation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelBackMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMenu)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.Panel panelControlButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenuNavigation;
        private System.Windows.Forms.PictureBox picShowMenu;
        private System.Windows.Forms.Panel panelBackMenu;
        private System.Windows.Forms.PictureBox picLogoMenu;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnVam;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnKarbary;
        private System.Windows.Forms.Button btnEmkanat;
        private System.Windows.Forms.Button btnSandoogh;
        private System.Windows.Forms.Button btnSarmaye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerRectangleDown;
        private System.Windows.Forms.Timer timerMenuNavigation;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerRectangleUp;
        private AnimatorNS.Animator animatorLogo;
        private SectionAza sectionAza1;
        private SectionFirst sectionFirst1;
        private SectionVam sectionVam1;
        private SectionSarmaye sectionSarmaye1;
        private SectionStatusOfSandoogh sectionStatusOfSandoogh1;
        private SectionFeatures sectionFeatures1;
        private SectionKarbary sectionKarbary1;
        private SectionSetting sectionSetting1;
    }
}