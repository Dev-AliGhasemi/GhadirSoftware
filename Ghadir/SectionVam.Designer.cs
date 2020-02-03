namespace Ghadir
{
    partial class SectionVam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionVam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.dataGridVam = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.rdoLoanType = new System.Windows.Forms.RadioButton();
            this.rdoZamenCode = new System.Windows.Forms.RadioButton();
            this.rdoZamen = new System.Windows.Forms.RadioButton();
            this.rdoRecieverCode = new System.Windows.Forms.RadioButton();
            this.rdoReciever = new System.Windows.Forms.RadioButton();
            this.rdoLoanNumber = new System.Windows.Forms.RadioButton();
            this.animatorPanelSearchVam = new AnimatorNS.Animator(this.components);
            this.panel1.SuspendLayout();
            this.panelBottomRight.SuspendLayout();
            this.panelBottomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVam)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.panelBottomRight);
            this.panel1.Controls.Add(this.panelBottomLeft);
            this.animatorPanelSearchVam.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 65);
            this.panel1.TabIndex = 3;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Controls.Add(this.btnRefresh);
            this.panelBottomRight.Controls.Add(this.btnCreate);
            this.panelBottomRight.Controls.Add(this.btnUpdate);
            this.panelBottomRight.Controls.Add(this.btnDelete);
            this.animatorPanelSearchVam.SetDecoration(this.panelBottomRight, AnimatorNS.DecorationType.None);
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
            this.animatorPanelSearchVam.SetDecoration(this.btnRefresh, AnimatorNS.DecorationType.None);
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
            this.btnRefresh.TabIndex = 8;
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
            this.btnCreate.ButtonText = "اعطای وام";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animatorPanelSearchVam.SetDecoration(this.btnCreate, AnimatorNS.DecorationType.None);
            this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnCreate.Text = "اعطای وام";
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
            this.animatorPanelSearchVam.SetDecoration(this.btnUpdate, AnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Enabled = false;
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
            this.animatorPanelSearchVam.SetDecoration(this.btnDelete, AnimatorNS.DecorationType.None);
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Enabled = false;
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
            this.panelBottomLeft.Controls.Add(this.lblSearch);
            this.panelBottomLeft.Controls.Add(this.txtSearch);
            this.panelBottomLeft.Controls.Add(this.picSetting);
            this.animatorPanelSearchVam.SetDecoration(this.panelBottomLeft, AnimatorNS.DecorationType.None);
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(378, 65);
            this.panelBottomLeft.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.animatorPanelSearchVam.SetDecoration(this.lblSearch, AnimatorNS.DecorationType.None);
            this.lblSearch.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(226, 13);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(112, 40);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "جست و جو:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animatorPanelSearchVam.SetDecoration(this.txtSearch, AnimatorNS.DecorationType.None);
            this.txtSearch.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSearch.Location = new System.Drawing.Point(52, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 36);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelSearchVam.SetDecoration(this.picSetting, AnimatorNS.DecorationType.None);
            this.picSetting.Image = global::Ghadir.Properties.Resources.iconSettingSection;
            this.picSetting.Location = new System.Drawing.Point(16, 12);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(33, 42);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSetting.TabIndex = 1;
            this.picSetting.TabStop = false;
            this.picSetting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSetting_MouseClick);
            // 
            // dataGridVam
            // 
            this.dataGridVam.AllowUserToAddRows = false;
            this.dataGridVam.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridVam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dataGridVam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridVam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animatorPanelSearchVam.SetDecoration(this.dataGridVam, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVam.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVam.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridVam.EnableHeadersVisualStyles = false;
            this.dataGridVam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.dataGridVam.Location = new System.Drawing.Point(16, 0);
            this.dataGridVam.MultiSelect = false;
            this.dataGridVam.Name = "dataGridVam";
            this.dataGridVam.ReadOnly = true;
            this.dataGridVam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridVam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridVam.RowHeadersVisible = false;
            this.dataGridVam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVam.Size = new System.Drawing.Size(1069, 550);
            this.dataGridVam.TabIndex = 2;
            this.dataGridVam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVam_CellDoubleClick);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.panelSearch.Controls.Add(this.rdoLoanType);
            this.panelSearch.Controls.Add(this.rdoZamenCode);
            this.panelSearch.Controls.Add(this.rdoZamen);
            this.panelSearch.Controls.Add(this.rdoRecieverCode);
            this.panelSearch.Controls.Add(this.rdoReciever);
            this.panelSearch.Controls.Add(this.rdoLoanNumber);
            this.animatorPanelSearchVam.SetDecoration(this.panelSearch, AnimatorNS.DecorationType.None);
            this.panelSearch.Location = new System.Drawing.Point(18, 323);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(179, 224);
            this.panelSearch.TabIndex = 4;
            this.panelSearch.Visible = false;
            // 
            // rdoLoanType
            // 
            this.rdoLoanType.AutoSize = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoLoanType, AnimatorNS.DecorationType.None);
            this.rdoLoanType.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLoanType.ForeColor = System.Drawing.Color.White;
            this.rdoLoanType.Location = new System.Drawing.Point(104, 187);
            this.rdoLoanType.Name = "rdoLoanType";
            this.rdoLoanType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoLoanType.Size = new System.Drawing.Size(67, 31);
            this.rdoLoanType.TabIndex = 9;
            this.rdoLoanType.Text = "نوع وام";
            this.rdoLoanType.UseVisualStyleBackColor = true;
            this.rdoLoanType.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // rdoZamenCode
            // 
            this.rdoZamenCode.AutoSize = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoZamenCode, AnimatorNS.DecorationType.None);
            this.rdoZamenCode.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoZamenCode.ForeColor = System.Drawing.Color.White;
            this.rdoZamenCode.Location = new System.Drawing.Point(30, 150);
            this.rdoZamenCode.Name = "rdoZamenCode";
            this.rdoZamenCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoZamenCode.Size = new System.Drawing.Size(141, 31);
            this.rdoZamenCode.TabIndex = 8;
            this.rdoZamenCode.Text = "شماره عضویت ضامن";
            this.rdoZamenCode.UseVisualStyleBackColor = true;
            this.rdoZamenCode.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // rdoZamen
            // 
            this.rdoZamen.AutoSize = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoZamen, AnimatorNS.DecorationType.None);
            this.rdoZamen.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoZamen.ForeColor = System.Drawing.Color.White;
            this.rdoZamen.Location = new System.Drawing.Point(93, 113);
            this.rdoZamen.Name = "rdoZamen";
            this.rdoZamen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoZamen.Size = new System.Drawing.Size(78, 31);
            this.rdoZamen.TabIndex = 7;
            this.rdoZamen.Text = "نام ضامن";
            this.rdoZamen.UseVisualStyleBackColor = true;
            this.rdoZamen.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // rdoRecieverCode
            // 
            this.rdoRecieverCode.AutoSize = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoRecieverCode, AnimatorNS.DecorationType.None);
            this.rdoRecieverCode.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoRecieverCode.ForeColor = System.Drawing.Color.White;
            this.rdoRecieverCode.Location = new System.Drawing.Point(3, 76);
            this.rdoRecieverCode.Name = "rdoRecieverCode";
            this.rdoRecieverCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoRecieverCode.Size = new System.Drawing.Size(168, 31);
            this.rdoRecieverCode.TabIndex = 6;
            this.rdoRecieverCode.Text = "شماره عضویت وام گیرنده";
            this.rdoRecieverCode.UseVisualStyleBackColor = true;
            this.rdoRecieverCode.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // rdoReciever
            // 
            this.rdoReciever.AutoSize = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoReciever, AnimatorNS.DecorationType.None);
            this.rdoReciever.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoReciever.ForeColor = System.Drawing.Color.White;
            this.rdoReciever.Location = new System.Drawing.Point(66, 40);
            this.rdoReciever.Name = "rdoReciever";
            this.rdoReciever.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoReciever.Size = new System.Drawing.Size(105, 31);
            this.rdoReciever.TabIndex = 5;
            this.rdoReciever.Text = "نام وام گیرنده";
            this.rdoReciever.UseVisualStyleBackColor = true;
            this.rdoReciever.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // rdoLoanNumber
            // 
            this.rdoLoanNumber.AutoSize = true;
            this.rdoLoanNumber.Checked = true;
            this.animatorPanelSearchVam.SetDecoration(this.rdoLoanNumber, AnimatorNS.DecorationType.None);
            this.rdoLoanNumber.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLoanNumber.ForeColor = System.Drawing.Color.White;
            this.rdoLoanNumber.Location = new System.Drawing.Point(89, 3);
            this.rdoLoanNumber.Name = "rdoLoanNumber";
            this.rdoLoanNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoLoanNumber.Size = new System.Drawing.Size(82, 31);
            this.rdoLoanNumber.TabIndex = 4;
            this.rdoLoanNumber.TabStop = true;
            this.rdoLoanNumber.Text = "شماره وام";
            this.rdoLoanNumber.UseVisualStyleBackColor = true;
            this.rdoLoanNumber.CheckedChanged += new System.EventHandler(this.rdoLoanNumber_CheckedChanged);
            // 
            // animatorPanelSearchVam
            // 
            this.animatorPanelSearchVam.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animatorPanelSearchVam.Cursor = null;
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
            this.animatorPanelSearchVam.DefaultAnimation = animation1;
            // 
            // SectionVam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridVam);
            this.Controls.Add(this.panel1);
            this.animatorPanelSearchVam.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "SectionVam";
            this.Size = new System.Drawing.Size(1085, 615);
            this.Load += new System.EventHandler(this.SectionVam_Load);
            this.SizeChanged += new System.EventHandler(this.SectionVam_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panelBottomRight.ResumeLayout(false);
            this.panelBottomLeft.ResumeLayout(false);
            this.panelBottomLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVam)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottomRight;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.DataGridView dataGridVam;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.RadioButton rdoZamen;
        private System.Windows.Forms.RadioButton rdoRecieverCode;
        private System.Windows.Forms.RadioButton rdoReciever;
        private System.Windows.Forms.RadioButton rdoLoanNumber;
        private System.Windows.Forms.RadioButton rdoLoanType;
        private System.Windows.Forms.RadioButton rdoZamenCode;
        private AnimatorNS.Animator animatorPanelSearchVam;
    }
}
