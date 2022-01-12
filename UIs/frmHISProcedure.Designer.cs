
namespace RIS.UIs
{
    partial class frmHISProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHISProcedure));
            this.cmbModality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHISProcedure = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvHISProcedures = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterSimple = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvHISProcedures)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModality
            // 
            this.cmbModality.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModality.FormattingEnabled = true;
            this.cmbModality.Location = new System.Drawing.Point(69, 69);
            this.cmbModality.Name = "cmbModality";
            this.cmbModality.Size = new System.Drawing.Size(297, 25);
            this.cmbModality.TabIndex = 132;
            this.cmbModality.SelectedIndexChanged += new System.EventHandler(this.cmbModality_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 129;
            this.label1.Text = "Select Modality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 134;
            this.label3.Text = "HIS Procedure Name";
            // 
            // txtHISProcedure
            // 
            this.txtHISProcedure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHISProcedure.Location = new System.Drawing.Point(69, 132);
            this.txtHISProcedure.Name = "txtHISProcedure";
            this.txtHISProcedure.Size = new System.Drawing.Size(334, 27);
            this.txtHISProcedure.TabIndex = 133;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(70, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 135;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvHISProcedures
            // 
            this.lvHISProcedures.AllColumns.Add(this.olvColumn2);
            this.lvHISProcedures.AllColumns.Add(this.olvColumn1);
            this.lvHISProcedures.AllowColumnReorder = true;
            this.lvHISProcedures.AllowDrop = true;
            this.lvHISProcedures.CheckBoxes = true;
            this.lvHISProcedures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn1});
            this.lvHISProcedures.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvHISProcedures.FullRowSelect = true;
            this.lvHISProcedures.HeaderWordWrap = true;
            this.lvHISProcedures.HideSelection = false;
            this.lvHISProcedures.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.lvHISProcedures.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.lvHISProcedures.HotItemStyle = this.hotItemStyle1;
            this.lvHISProcedures.IncludeColumnHeadersInCopy = true;
            this.lvHISProcedures.IsSimpleDragSource = true;
            this.lvHISProcedures.IsSimpleDropSink = true;
            this.lvHISProcedures.Location = new System.Drawing.Point(464, 69);
            this.lvHISProcedures.Name = "lvHISProcedures";
            this.lvHISProcedures.OverlayImage.Image = global::RIS.Properties.Resources.logo_emedical;
            this.lvHISProcedures.RowHeight = 25;
            this.lvHISProcedures.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.lvHISProcedures.ShowCommandMenuOnRightClick = true;
            this.lvHISProcedures.ShowGroups = false;
            this.lvHISProcedures.ShowHeaderInAllViews = false;
            this.lvHISProcedures.ShowItemToolTips = true;
            this.lvHISProcedures.Size = new System.Drawing.Size(482, 501);
            this.lvHISProcedures.SortGroupItemsByPrimaryColumn = false;
            this.lvHISProcedures.TabIndex = 136;
            this.lvHISProcedures.TriStateCheckBoxes = true;
            this.lvHISProcedures.UseAlternatingBackColors = true;
            this.lvHISProcedures.UseCellFormatEvents = true;
            this.lvHISProcedures.UseCompatibleStateImageBehavior = false;
            this.lvHISProcedures.UseFilterIndicator = true;
            this.lvHISProcedures.UseFiltering = true;
            this.lvHISProcedures.UseHotItem = true;
            this.lvHISProcedures.View = System.Windows.Forms.View.Details;
            this.lvHISProcedures.DoubleClick += new System.EventHandler(this.lvHISProcedures_DoubleClick);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Modality";
            this.olvColumn2.Text = "Modality";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ProcName";
            this.olvColumn1.Text = "Procedure Name";
            this.olvColumn1.Width = 450;
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.Crimson;
            this.hotItemStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "user");
            this.imageList2.Images.SetKeyName(1, "compass");
            this.imageList2.Images.SetKeyName(2, "down");
            this.imageList2.Images.SetKeyName(3, "find");
            this.imageList2.Images.SetKeyName(4, "folder");
            this.imageList2.Images.SetKeyName(5, "movie");
            this.imageList2.Images.SetKeyName(6, "music");
            this.imageList2.Images.SetKeyName(7, "no");
            this.imageList2.Images.SetKeyName(8, "readonly");
            this.imageList2.Images.SetKeyName(9, "public");
            this.imageList2.Images.SetKeyName(10, "recycle");
            this.imageList2.Images.SetKeyName(11, "spanner");
            this.imageList2.Images.SetKeyName(12, "star");
            this.imageList2.Images.SetKeyName(13, "tick");
            this.imageList2.Images.SetKeyName(14, "archive");
            this.imageList2.Images.SetKeyName(15, "system");
            this.imageList2.Images.SetKeyName(16, "hidden");
            this.imageList2.Images.SetKeyName(17, "temporary");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "wl.png");
            this.imageList3.Images.SetKeyName(1, "REPORT.png");
            this.imageList3.Images.SetKeyName(2, "OrderEntry copy.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "compass");
            this.imageList1.Images.SetKeyName(1, "down");
            this.imageList1.Images.SetKeyName(2, "user");
            this.imageList1.Images.SetKeyName(3, "find");
            this.imageList1.Images.SetKeyName(4, "folder");
            this.imageList1.Images.SetKeyName(5, "movie");
            this.imageList1.Images.SetKeyName(6, "music");
            this.imageList1.Images.SetKeyName(7, "no");
            this.imageList1.Images.SetKeyName(8, "readonly");
            this.imageList1.Images.SetKeyName(9, "public");
            this.imageList1.Images.SetKeyName(10, "recycle");
            this.imageList1.Images.SetKeyName(11, "spanner");
            this.imageList1.Images.SetKeyName(12, "star");
            this.imageList1.Images.SetKeyName(13, "tick");
            this.imageList1.Images.SetKeyName(14, "archive");
            this.imageList1.Images.SetKeyName(15, "system");
            this.imageList1.Images.SetKeyName(16, "hidden");
            this.imageList1.Images.SetKeyName(17, "temporary");
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.textBoxFilterSimple);
            this.groupBox10.Location = new System.Drawing.Point(464, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(228, 44);
            this.groupBox10.TabIndex = 137;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Filter";
            // 
            // textBoxFilterSimple
            // 
            this.textBoxFilterSimple.Location = new System.Drawing.Point(7, 20);
            this.textBoxFilterSimple.Name = "textBoxFilterSimple";
            this.textBoxFilterSimple.Size = new System.Drawing.Size(215, 20);
            this.textBoxFilterSimple.TabIndex = 0;
            this.textBoxFilterSimple.TextChanged += new System.EventHandler(this.textBoxFilterSimple_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 22);
            this.statusStrip1.TabIndex = 138;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(1028, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 54);
            this.button1.TabIndex = 139;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHISProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.lvHISProcedures);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHISProcedure);
            this.Controls.Add(this.cmbModality);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHISProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit HIS Procedure";
            this.Load += new System.EventHandler(this.frmHISProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvHISProcedures)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHISProcedure;
        private System.Windows.Forms.Button btnSave;
        private BrightIdeasSoftware.ObjectListView lvHISProcedures;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxFilterSimple;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button button1;
    }
}