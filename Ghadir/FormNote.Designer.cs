namespace Ghadir
{
    partial class FormNote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picNewNote = new System.Windows.Forms.PictureBox();
            this.flowListNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "یادداشت ها";
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::Ghadir.Properties.Resources.close2;
            this.picClose.Location = new System.Drawing.Point(658, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(41, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Roya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitle.Location = new System.Drawing.Point(249, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(0, 44);
            this.lblTitle.TabIndex = 59;
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(8, 74);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(520, 394);
            this.txtText.TabIndex = 60;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.picRefresh);
            this.panelTools.Controls.Add(this.picDelete);
            this.panelTools.Controls.Add(this.picSave);
            this.panelTools.Controls.Add(this.picNewNote);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 474);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(699, 32);
            this.panelTools.TabIndex = 61;
            // 
            // picRefresh
            // 
            this.picRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picRefresh.Image = global::Ghadir.Properties.Resources.iconRefreshNote;
            this.picRefresh.Location = new System.Drawing.Point(579, 4);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Padding = new System.Windows.Forms.Padding(200000);
            this.picRefresh.Size = new System.Drawing.Size(30, 24);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 3;
            this.picRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.picRefresh, "تازه سازی");
            this.picRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picRefresh_MouseClick);
            // 
            // picDelete
            // 
            this.picDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picDelete.Image = global::Ghadir.Properties.Resources.iconDeleteNote;
            this.picDelete.Location = new System.Drawing.Point(609, 4);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(30, 24);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 2;
            this.picDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picDelete, "پاک کردن");
            this.picDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDelete_MouseClick);
            // 
            // picSave
            // 
            this.picSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picSave.Image = global::Ghadir.Properties.Resources.iconEditNote;
            this.picSave.Location = new System.Drawing.Point(639, 4);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(30, 24);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSave.TabIndex = 1;
            this.picSave.TabStop = false;
            this.toolTip1.SetToolTip(this.picSave, "ویرایش");
            this.picSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSave_MouseClick);
            // 
            // picNewNote
            // 
            this.picNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picNewNote.Image = global::Ghadir.Properties.Resources.iconCreateNote;
            this.picNewNote.Location = new System.Drawing.Point(669, 4);
            this.picNewNote.Name = "picNewNote";
            this.picNewNote.Size = new System.Drawing.Size(30, 24);
            this.picNewNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewNote.TabIndex = 0;
            this.picNewNote.TabStop = false;
            this.toolTip1.SetToolTip(this.picNewNote, "جدید");
            this.picNewNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picNewNote_MouseClick);
            // 
            // flowListNotes
            // 
            this.flowListNotes.AutoScroll = true;
            this.flowListNotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowListNotes.Location = new System.Drawing.Point(535, 32);
            this.flowListNotes.Name = "flowListNotes";
            this.flowListNotes.Size = new System.Drawing.Size(164, 442);
            this.flowListNotes.TabIndex = 62;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.flowListNotes);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNote";
            this.Load += new System.EventHandler(this.FormNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.FlowLayoutPanel flowListNotes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox picNewNote;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}