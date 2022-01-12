
namespace RIS.UIs
{
    partial class frmMapRadProcedureAndTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapRadProcedureAndTemplate));
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvTemplates = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.ctrlHISProcedureSearch = new RIS.Controls.HISProcedureSearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTemplates)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 10202;
            this.label7.Text = "Procedure";
            // 
            // txtProcedure
            // 
            this.txtProcedure.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedure.Location = new System.Drawing.Point(161, 102);
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(307, 25);
            this.txtProcedure.TabIndex = 10203;
            this.txtProcedure.TextChanged += new System.EventHandler(this.txtProcedure_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 10206;
            this.label1.Text = "Select Consultant";
            // 
            // cmbConsultant
            // 
            this.cmbConsultant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultant.FormattingEnabled = true;
            this.cmbConsultant.Location = new System.Drawing.Point(161, 58);
            this.cmbConsultant.Name = "cmbConsultant";
            this.cmbConsultant.Size = new System.Drawing.Size(390, 28);
            this.cmbConsultant.TabIndex = 10205;
            this.cmbConsultant.SelectedIndexChanged += new System.EventHandler(this.cmbConsultant_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(34, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 10210;
            this.label4.Text = "Select File";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(34, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 10209;
            this.label2.Text = "Template Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtFileName.Location = new System.Drawing.Point(161, 191);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(277, 24);
            this.txtFileName.TabIndex = 10208;
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTemplateName.Location = new System.Drawing.Point(161, 149);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(277, 24);
            this.txtTemplateName.TabIndex = 10207;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnBrowse.Image = global::RIS.Properties.Resources.browseiconbmp;
            this.btnBrowse.Location = new System.Drawing.Point(444, 191);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 34);
            this.btnBrowse.TabIndex = 10211;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(161, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 39);
            this.btnSave.TabIndex = 10212;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvTemplates
            // 
            this.lvTemplates.AllColumns.Add(this.olvColumn1);
            this.lvTemplates.AllColumns.Add(this.olvColumn4);
            this.lvTemplates.AllColumns.Add(this.olvColumn3);
            this.lvTemplates.AllColumns.Add(this.olvColumn2);
            this.lvTemplates.AllowColumnReorder = true;
            this.lvTemplates.AllowDrop = true;
            this.lvTemplates.CheckBoxes = true;
            this.lvTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn4,
            this.olvColumn3,
            this.olvColumn2});
            this.lvTemplates.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvTemplates.FullRowSelect = true;
            this.lvTemplates.HeaderWordWrap = true;
            this.lvTemplates.HideSelection = false;
            this.lvTemplates.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.lvTemplates.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.lvTemplates.HotItemStyle = this.hotItemStyle1;
            this.lvTemplates.IncludeColumnHeadersInCopy = true;
            this.lvTemplates.IsSimpleDragSource = true;
            this.lvTemplates.IsSimpleDropSink = true;
            this.lvTemplates.Location = new System.Drawing.Point(557, 58);
            this.lvTemplates.Name = "lvTemplates";
            this.lvTemplates.OverlayImage.Image = global::RIS.Properties.Resources.logo_emedical;
            this.lvTemplates.RowHeight = 25;
            this.lvTemplates.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.lvTemplates.ShowCommandMenuOnRightClick = true;
            this.lvTemplates.ShowGroups = false;
            this.lvTemplates.ShowHeaderInAllViews = false;
            this.lvTemplates.ShowItemToolTips = true;
            this.lvTemplates.Size = new System.Drawing.Size(606, 483);
            this.lvTemplates.SortGroupItemsByPrimaryColumn = false;
            this.lvTemplates.TabIndex = 10213;
            this.lvTemplates.TriStateCheckBoxes = true;
            this.lvTemplates.UseAlternatingBackColors = true;
            this.lvTemplates.UseCellFormatEvents = true;
            this.lvTemplates.UseCompatibleStateImageBehavior = false;
            this.lvTemplates.UseFilterIndicator = true;
            this.lvTemplates.UseFiltering = true;
            this.lvTemplates.UseHotItem = true;
            this.lvTemplates.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.HeaderCheckBox = true;
            this.olvColumn1.Text = "T. Id";
            this.olvColumn1.Width = 80;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "ProcedureName";
            this.olvColumn4.Text = "Procedure Name";
            this.olvColumn4.Width = 250;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Modality";
            this.olvColumn3.Text = "Modality";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "TemplateName";
            this.olvColumn2.Text = "Template Name";
            this.olvColumn2.Width = 250;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1183, 22);
            this.statusStrip1.TabIndex = 10215;
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(1168, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(34, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 10216;
            this.label3.Text = "Is Default Template?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Location = new System.Drawing.Point(179, 232);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 10217;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(239, 232);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 10218;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // ctrlHISProcedureSearch
            // 
            this.ctrlHISProcedureSearch.Location = new System.Drawing.Point(99, 365);
            this.ctrlHISProcedureSearch.Name = "ctrlHISProcedureSearch";
            this.ctrlHISProcedureSearch.Size = new System.Drawing.Size(604, 472);
            this.ctrlHISProcedureSearch.TabIndex = 10214;
            this.ctrlHISProcedureSearch.Visible = false;
            this.ctrlHISProcedureSearch.SearchEsacaped += new RIS.SearchResultListControl<RIS.Models.HISProcedure>.SearchEscapeEventHandler(this.ctrlHISProcedureSearch_SearchEsacaped);
            // 
            // frmMapRadProcedureAndTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 629);
            this.Controls.Add(this.ctrlHISProcedureSearch);
            this.Controls.Add(this.radNo);
            this.Controls.Add(this.radYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvTemplates);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConsultant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProcedure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMapRadProcedureAndTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Radiologist-Procedure-And-Template";
            this.Load += new System.EventHandler(this.frmMapRadProcedureAndTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTemplates)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private ProcedureSearchControl ctrlProcedureSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultant;
        private System.Windows.Forms.PictureBox btnBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private BrightIdeasSoftware.ObjectListView lvTemplates;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private Controls.HISProcedureSearchControl ctrlHISProcedureSearch;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
    }
}