namespace Ghadir
{
    partial class SectionAza
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionAza));
            this.dataGridAza = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.rdoCode = new System.Windows.Forms.RadioButton();
            this.rdoPhone = new System.Windows.Forms.RadioButton();
            this.rdoFatherName = new System.Windows.Forms.RadioButton();
            this.rdoLname = new System.Windows.Forms.RadioButton();
            this.rdoFname = new System.Windows.Forms.RadioButton();
            this.animatorPanelSearch = new AnimatorNS.Animator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAza)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBottomRight.SuspendLayout();
            this.panelBottomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAza
            // 
            this.dataGridAza.AllowUserToAddRows = false;
            this.dataGridAza.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridAza.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAza.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAza.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dataGridAza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAza.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridAza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animatorPanelSearch.SetDecoration(this.dataGridAza, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAza.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAza.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridAza.EnableHeadersVisualStyles = false;
            this.dataGridAza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.dataGridAza.Location = new System.Drawing.Point(16, 0);
            this.dataGridAza.MultiSelect = false;
            this.dataGridAza.Name = "dataGridAza";
            this.dataGridAza.ReadOnly = true;
            this.dataGridAza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridAza.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAza.RowHeadersVisible = false;
            this.dataGridAza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAza.Size = new System.Drawing.Size(1069, 550);
            this.dataGridAza.TabIndex = 0;
            this.dataGridAza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAza_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.panelBottomRight);
            this.panel1.Controls.Add(this.panelBottomLeft);
            this.animatorPanelSearch.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 65);
            this.panel1.TabIndex = 1;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Controls.Add(this.btnRefresh);
            this.panelBottomRight.Controls.Add(this.btnCreate);
            this.panelBottomRight.Controls.Add(this.btnUpdate);
            this.panelBottomRight.Controls.Add(this.btnDelete);
            this.animatorPanelSearch.SetDecoration(this.panelBottomRight, AnimatorNS.DecorationType.None);
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(582, 0);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(503, 65);
            this.panelBottomRight.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Active = false;
            this.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 5;
            this.btnRefresh.ButtonText = "تازه سازی";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorPanelSearch.SetDecoration(this.btnRefresh, AnimatorNS.DecorationType.None);
            this.btnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefresh.Iconimage = null;
            this.btnRefresh.Iconimage_right = null;
            this.btnRefresh.Iconimage_right_Selected = null;
            this.btnRefresh.Iconimage_Selected = null;
            this.btnRefresh.IconMarginLeft = 0;
            this.btnRefresh.IconMarginRight = 0;
            this.btnRefresh.IconRightVisible = true;
            this.btnRefresh.IconRightZoom = 0D;
            this.btnRefresh.IconVisible = true;
            this.btnRefresh.IconZoom = 70D;
            this.btnRefresh.IsTab = false;
            this.btnRefresh.Location = new System.Drawing.Point(19, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(105, 45);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Active = false;
            this.btnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.ButtonText = "ایجاد";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorPanelSearch.SetDecoration(this.btnCreate, AnimatorNS.DecorationType.None);
            this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreate.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreate.Iconimage = null;
            this.btnCreate.Iconimage_right = null;
            this.btnCreate.Iconimage_right_Selected = null;
            this.btnCreate.Iconimage_Selected = null;
            this.btnCreate.IconMarginLeft = 0;
            this.btnCreate.IconMarginRight = 0;
            this.btnCreate.IconRightVisible = true;
            this.btnCreate.IconRightZoom = 0D;
            this.btnCreate.IconVisible = true;
            this.btnCreate.IconZoom = 70D;
            this.btnCreate.IsTab = false;
            this.btnCreate.Location = new System.Drawing.Point(387, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(105, 45);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "ایجاد";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Textcolor = System.Drawing.Color.White;
            this.btnCreate.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Active = false;
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.ButtonText = "ویرایش";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorPanelSearch.SetDecoration(this.btnUpdate, AnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 70D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(264, 10);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(105, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "حذف";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorPanelSearch.SetDecoration(this.btnDelete, AnimatorNS.DecorationType.None);
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("B Koodak", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 70D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(141, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(105, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("B Roya", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.Controls.Add(this.txtSearch);
            this.panelBottomLeft.Controls.Add(this.picSetting);
            this.panelBottomLeft.Controls.Add(this.lblSearch);
            this.animatorPanelSearch.SetDecoration(this.panelBottomLeft, AnimatorNS.DecorationType.None);
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(378, 65);
            this.panelBottomLeft.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animatorPanelSearch.SetDecoration(this.txtSearch, AnimatorNS.DecorationType.None);
            this.txtSearch.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSearch.Location = new System.Drawing.Point(52, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 36);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelSearch.SetDecoration(this.picSetting, AnimatorNS.DecorationType.None);
            this.picSetting.Image = global::Ghadir.Properties.Resources.iconSettingSection;
            this.picSetting.Location = new System.Drawing.Point(16, 12);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(33, 42);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSetting.TabIndex = 0;
            this.picSetting.TabStop = false;
            this.picSetting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSetting_MouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.animatorPanelSearch.SetDecoration(this.lblSearch, AnimatorNS.DecorationType.None);
            this.lblSearch.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(226, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(112, 40);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "جست و جو:";
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.panelSearch.Controls.Add(this.rdoCode);
            this.panelSearch.Controls.Add(this.rdoPhone);
            this.panelSearch.Controls.Add(this.rdoFatherName);
            this.panelSearch.Controls.Add(this.rdoLname);
            this.panelSearch.Controls.Add(this.rdoFname);
            this.animatorPanelSearch.SetDecoration(this.panelSearch, AnimatorNS.DecorationType.None);
            this.panelSearch.Location = new System.Drawing.Point(18, 386);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(129, 161);
            this.panelSearch.TabIndex = 2;
            this.panelSearch.Visible = false;
            // 
            // rdoCode
            // 
            this.rdoCode.AutoSize = true;
            this.rdoCode.Checked = true;
            this.animatorPanelSearch.SetDecoration(this.rdoCode, AnimatorNS.DecorationType.None);
            this.rdoCode.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoCode.ForeColor = System.Drawing.Color.White;
            this.rdoCode.Location = new System.Drawing.Point(19, 3);
            this.rdoCode.Name = "rdoCode";
            this.rdoCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoCode.Size = new System.Drawing.Size(107, 31);
            this.rdoCode.TabIndex = 8;
            this.rdoCode.TabStop = true;
            this.rdoCode.Text = "شماره عضویت";
            this.rdoCode.UseVisualStyleBackColor = true;
            // 
            // rdoPhone
            // 
            this.rdoPhone.AutoSize = true;
            this.animatorPanelSearch.SetDecoration(this.rdoPhone, AnimatorNS.DecorationType.None);
            this.rdoPhone.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoPhone.ForeColor = System.Drawing.Color.White;
            this.rdoPhone.Location = new System.Drawing.Point(37, 130);
            this.rdoPhone.Name = "rdoPhone";
            this.rdoPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoPhone.Size = new System.Drawing.Size(89, 31);
            this.rdoPhone.TabIndex = 7;
            this.rdoPhone.Text = "شماره تلفن";
            this.rdoPhone.UseVisualStyleBackColor = true;
            this.rdoPhone.CheckedChanged += new System.EventHandler(this.rdoFname_CheckedChanged);
            // 
            // rdoFatherName
            // 
            this.rdoFatherName.AutoSize = true;
            this.animatorPanelSearch.SetDecoration(this.rdoFatherName, AnimatorNS.DecorationType.None);
            this.rdoFatherName.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoFatherName.ForeColor = System.Drawing.Color.White;
            this.rdoFatherName.Location = new System.Drawing.Point(59, 99);
            this.rdoFatherName.Name = "rdoFatherName";
            this.rdoFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFatherName.Size = new System.Drawing.Size(67, 31);
            this.rdoFatherName.TabIndex = 6;
            this.rdoFatherName.Text = "نام پدر";
            this.rdoFatherName.UseVisualStyleBackColor = true;
            this.rdoFatherName.CheckedChanged += new System.EventHandler(this.rdoFname_CheckedChanged);
            // 
            // rdoLname
            // 
            this.rdoLname.AutoSize = true;
            this.animatorPanelSearch.SetDecoration(this.rdoLname, AnimatorNS.DecorationType.None);
            this.rdoLname.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLname.ForeColor = System.Drawing.Color.White;
            this.rdoLname.Location = new System.Drawing.Point(29, 64);
            this.rdoLname.Name = "rdoLname";
            this.rdoLname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoLname.Size = new System.Drawing.Size(97, 31);
            this.rdoLname.TabIndex = 5;
            this.rdoLname.Text = "نام خانوادگی";
            this.rdoLname.UseVisualStyleBackColor = true;
            this.rdoLname.CheckedChanged += new System.EventHandler(this.rdoFname_CheckedChanged);
            // 
            // rdoFname
            // 
            this.rdoFname.AutoSize = true;
            this.animatorPanelSearch.SetDecoration(this.rdoFname, AnimatorNS.DecorationType.None);
            this.rdoFname.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoFname.ForeColor = System.Drawing.Color.White;
            this.rdoFname.Location = new System.Drawing.Point(82, 31);
            this.rdoFname.Name = "rdoFname";
            this.rdoFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFname.Size = new System.Drawing.Size(44, 31);
            this.rdoFname.TabIndex = 4;
            this.rdoFname.Text = "نام";
            this.rdoFname.UseVisualStyleBackColor = true;
            this.rdoFname.CheckedChanged += new System.EventHandler(this.rdoFname_CheckedChanged);
            // 
            // animatorPanelSearch
            // 
            this.animatorPanelSearch.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animatorPanelSearch.Cursor = null;
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
            this.animatorPanelSearch.DefaultAnimation = animation1;
            // 
            // SectionAza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridAza);
            this.Controls.Add(this.panel1);
            this.animatorPanelSearch.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "SectionAza";
            this.Size = new System.Drawing.Size(1085, 615);
            this.Load += new System.EventHandler(this.SectionAza_Load);
            this.SizeChanged += new System.EventHandler(this.SectionAza_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAza)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBottomRight.ResumeLayout(false);
            this.panelBottomLeft.ResumeLayout(false);
            this.panelBottomLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.Panel panelSearch;
        private AnimatorNS.Animator animatorPanelSearch;
        private System.Windows.Forms.RadioButton rdoPhone;
        private System.Windows.Forms.RadioButton rdoFatherName;
        private System.Windows.Forms.RadioButton rdoLname;
        private System.Windows.Forms.RadioButton rdoFname;
        private System.Windows.Forms.RadioButton rdoCode;
        public System.Windows.Forms.DataGridView dataGridAza;
    }
}
