
namespace RIS.UIs
{
    partial class frmWorkListNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkListNew));
            this.studiesToolStrip = new System.Windows.Forms.ToolStrip();
            this.ShowAssignedToRadiologistPanel = new System.Windows.Forms.ToolStripDropDownButton();
            this.previewStudiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RadiologistPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAssingToRad = new System.Windows.Forms.Button();
            this.txtTemplateDescription = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAddEditTitleText = new System.Windows.Forms.Label();
            this.btnHideRadiologistPanel = new System.Windows.Forms.Button();
            this.lvRadiologist = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvWorklist = new RIS.ListViewDoubleBuffered();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbStudiesSearchCriteria = new RIS.HeaderGroupBox();
            this.comboBoxStudiesTenants = new System.Windows.Forms.ComboBox();
            this.searchStudiesButton = new System.Windows.Forms.Button();
            this.labelStudiesPatientId = new System.Windows.Forms.Label();
            this.textBoxStudiesPatientId = new System.Windows.Forms.TextBox();
            this.labelStudyDateFrom = new System.Windows.Forms.Label();
            this.textBoxStudiesPatientName = new System.Windows.Forms.TextBox();
            this.dateTimePickerStudyFrom = new System.Windows.Forms.DateTimePicker();
            this.labelStudiesPatientName = new System.Windows.Forms.Label();
            this.labelStudyDateTo = new System.Windows.Forms.Label();
            this.checkBoxStudyDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerStudyTo = new System.Windows.Forms.DateTimePicker();
            this.studiesToolStrip.SuspendLayout();
            this.RadiologistPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gbStudiesSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // studiesToolStrip
            // 
            this.studiesToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studiesToolStrip.AutoSize = false;
            this.studiesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.studiesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.studiesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAssignedToRadiologistPanel,
            this.previewStudiesToolStripButton});
            this.studiesToolStrip.Location = new System.Drawing.Point(1, 180);
            this.studiesToolStrip.Name = "studiesToolStrip";
            this.studiesToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.studiesToolStrip.Size = new System.Drawing.Size(1342, 25);
            this.studiesToolStrip.TabIndex = 10;
            // 
            // ShowAssignedToRadiologistPanel
            // 
            this.ShowAssignedToRadiologistPanel.Enabled = false;
            this.ShowAssignedToRadiologistPanel.Image = global::RIS.Properties.Resources.Move;
            this.ShowAssignedToRadiologistPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAssignedToRadiologistPanel.Name = "ShowAssignedToRadiologistPanel";
            this.ShowAssignedToRadiologistPanel.Size = new System.Drawing.Size(156, 22);
            this.ShowAssignedToRadiologistPanel.Text = "Assign To Radiologist";
            this.ShowAssignedToRadiologistPanel.Click += new System.EventHandler(this.SetRadiologistPanelVisible);
            // 
            // previewStudiesToolStripButton
            // 
            this.previewStudiesToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.previewStudiesToolStripButton.Image = global::RIS.Properties.Resources.Preview;
            this.previewStudiesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewStudiesToolStripButton.Name = "previewStudiesToolStripButton";
            this.previewStudiesToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.previewStudiesToolStripButton.Text = "Preview";
            this.previewStudiesToolStripButton.Click += new System.EventHandler(this.previewStudiesToolStripButton_Click);
            // 
            // RadiologistPanel
            // 
            this.RadiologistPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RadiologistPanel.Controls.Add(this.tableLayoutPanel5);
            this.RadiologistPanel.Location = new System.Drawing.Point(-1800, 55);
            this.RadiologistPanel.Name = "RadiologistPanel";
            this.RadiologistPanel.Size = new System.Drawing.Size(479, 516);
            this.RadiologistPanel.TabIndex = 10198;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanel5.Controls.Add(this.btnAssingToRad, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtTemplateDescription, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lvRadiologist, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(479, 516);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // btnAssingToRad
            // 
            this.btnAssingToRad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAssingToRad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssingToRad.Location = new System.Drawing.Point(3, 483);
            this.btnAssingToRad.Name = "btnAssingToRad";
            this.btnAssingToRad.Size = new System.Drawing.Size(111, 30);
            this.btnAssingToRad.TabIndex = 24;
            this.btnAssingToRad.Text = "Assign";
            this.btnAssingToRad.UseVisualStyleBackColor = false;
            // 
            // txtTemplateDescription
            // 
            this.txtTemplateDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplateDescription.Location = new System.Drawing.Point(3, 40);
            this.txtTemplateDescription.Multiline = true;
            this.txtTemplateDescription.Name = "txtTemplateDescription";
            this.txtTemplateDescription.Size = new System.Drawing.Size(470, 24);
            this.txtTemplateDescription.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Controls.Add(this.lblAddEditTitleText);
            this.panel7.Controls.Add(this.btnHideRadiologistPanel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(473, 31);
            this.panel7.TabIndex = 22;
            // 
            // lblAddEditTitleText
            // 
            this.lblAddEditTitleText.AutoSize = true;
            this.lblAddEditTitleText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitleText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddEditTitleText.Location = new System.Drawing.Point(8, 5);
            this.lblAddEditTitleText.Name = "lblAddEditTitleText";
            this.lblAddEditTitleText.Size = new System.Drawing.Size(103, 15);
            this.lblAddEditTitleText.TabIndex = 21;
            this.lblAddEditTitleText.Text = "Select Radiologist";
            this.lblAddEditTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHideRadiologistPanel
            // 
            this.btnHideRadiologistPanel.BackgroundImage = global::RIS.Properties.Resources.next_btn24x24_06;
            this.btnHideRadiologistPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHideRadiologistPanel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideRadiologistPanel.ForeColor = System.Drawing.Color.Red;
            this.btnHideRadiologistPanel.Location = new System.Drawing.Point(449, 0);
            this.btnHideRadiologistPanel.Name = "btnHideRadiologistPanel";
            this.btnHideRadiologistPanel.Size = new System.Drawing.Size(24, 31);
            this.btnHideRadiologistPanel.TabIndex = 20;
            this.btnHideRadiologistPanel.UseVisualStyleBackColor = true;
            this.btnHideRadiologistPanel.Click += new System.EventHandler(this.btnHideRadiologistPanel_Click);
            // 
            // lvRadiologist
            // 
            this.lvRadiologist.CheckBoxes = true;
            this.lvRadiologist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
            this.lvRadiologist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRadiologist.GridLines = true;
            this.lvRadiologist.HideSelection = false;
            this.lvRadiologist.Location = new System.Drawing.Point(3, 70);
            this.lvRadiologist.Name = "lvRadiologist";
            this.lvRadiologist.Size = new System.Drawing.Size(473, 407);
            this.lvRadiologist.TabIndex = 23;
            this.lvRadiologist.UseCompatibleStateImageBehavior = false;
            this.lvRadiologist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "";
            this.columnHeader14.Width = 40;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Radiologist Name";
            this.columnHeader15.Width = 350;
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
            // lvWorklist
            // 
            this.lvWorklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWorklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWorklist.CheckBoxes = true;
            this.lvWorklist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvWorklist.FullRowSelect = true;
            this.lvWorklist.GridLines = true;
            this.lvWorklist.HideSelection = false;
            this.lvWorklist.HoverSelection = true;
            this.lvWorklist.LabelEdit = true;
            this.lvWorklist.Location = new System.Drawing.Point(536, 197);
            this.lvWorklist.Name = "lvWorklist";
            this.lvWorklist.OwnerDraw = true;
            this.lvWorklist.Size = new System.Drawing.Size(544, 403);
            this.lvWorklist.TabIndex = 11;
            this.lvWorklist.UseCompatibleStateImageBehavior = false;
            this.lvWorklist.View = System.Windows.Forms.View.Details;
            this.lvWorklist.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvWorklist_ColumnClick);
            this.lvWorklist.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvWorklist_DrawColumnHeader);
            this.lvWorklist.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvWorklist_DrawItem);
            this.lvWorklist.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvWorklist_DrawSubItem);
            this.lvWorklist.DoubleClick += new System.EventHandler(this.lvWorklist_DoubleClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "";
            this.columnHeader13.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Patient Id";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Patient Name";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Procedure";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Clinical History";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No of Image";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Arrival Date Time";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hospital/Tenant";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Modality";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Radiologist";
            this.columnHeader10.Width = 180;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Physician";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Order Time";
            this.columnHeader12.Width = 100;
            // 
            // gbStudiesSearchCriteria
            // 
            this.gbStudiesSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudiesSearchCriteria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbStudiesSearchCriteria.Controls.Add(this.comboBoxStudiesTenants);
            this.gbStudiesSearchCriteria.Controls.Add(this.searchStudiesButton);
            this.gbStudiesSearchCriteria.Controls.Add(this.labelStudiesPatientId);
            this.gbStudiesSearchCriteria.Controls.Add(this.textBoxStudiesPatientId);
            this.gbStudiesSearchCriteria.Controls.Add(this.labelStudyDateFrom);
            this.gbStudiesSearchCriteria.Controls.Add(this.textBoxStudiesPatientName);
            this.gbStudiesSearchCriteria.Controls.Add(this.dateTimePickerStudyFrom);
            this.gbStudiesSearchCriteria.Controls.Add(this.labelStudiesPatientName);
            this.gbStudiesSearchCriteria.Controls.Add(this.labelStudyDateTo);
            this.gbStudiesSearchCriteria.Controls.Add(this.checkBoxStudyDate);
            this.gbStudiesSearchCriteria.Controls.Add(this.dateTimePickerStudyTo);
            this.gbStudiesSearchCriteria.Location = new System.Drawing.Point(1, 12);
            this.gbStudiesSearchCriteria.Name = "gbStudiesSearchCriteria";
            this.gbStudiesSearchCriteria.Size = new System.Drawing.Size(1366, 165);
            this.gbStudiesSearchCriteria.TabIndex = 0;
            this.gbStudiesSearchCriteria.TabStop = false;
            this.gbStudiesSearchCriteria.Text = "Search Criteria";
            // 
            // comboBoxStudiesTenants
            // 
            this.comboBoxStudiesTenants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudiesTenants.FormattingEnabled = true;
            this.comboBoxStudiesTenants.Location = new System.Drawing.Point(494, 90);
            this.comboBoxStudiesTenants.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStudiesTenants.Name = "comboBoxStudiesTenants";
            this.comboBoxStudiesTenants.Size = new System.Drawing.Size(203, 21);
            this.comboBoxStudiesTenants.TabIndex = 20;
            // 
            // searchStudiesButton
            // 
            this.searchStudiesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchStudiesButton.Location = new System.Drawing.Point(494, 121);
            this.searchStudiesButton.Name = "searchStudiesButton";
            this.searchStudiesButton.Size = new System.Drawing.Size(203, 23);
            this.searchStudiesButton.TabIndex = 21;
            this.searchStudiesButton.Text = "Search Studies";
            this.searchStudiesButton.UseVisualStyleBackColor = true;
            // 
            // labelStudiesPatientId
            // 
            this.labelStudiesPatientId.Location = new System.Drawing.Point(123, 36);
            this.labelStudiesPatientId.Name = "labelStudiesPatientId";
            this.labelStudiesPatientId.Size = new System.Drawing.Size(58, 13);
            this.labelStudiesPatientId.TabIndex = 9;
            this.labelStudiesPatientId.Text = "Patient ID:";
            // 
            // textBoxStudiesPatientId
            // 
            this.textBoxStudiesPatientId.Location = new System.Drawing.Point(187, 34);
            this.textBoxStudiesPatientId.Name = "textBoxStudiesPatientId";
            this.textBoxStudiesPatientId.Size = new System.Drawing.Size(203, 20);
            this.textBoxStudiesPatientId.TabIndex = 10;
            // 
            // labelStudyDateFrom
            // 
            this.labelStudyDateFrom.Enabled = false;
            this.labelStudyDateFrom.Location = new System.Drawing.Point(148, 64);
            this.labelStudyDateFrom.Name = "labelStudyDateFrom";
            this.labelStudyDateFrom.Size = new System.Drawing.Size(33, 13);
            this.labelStudyDateFrom.TabIndex = 11;
            this.labelStudyDateFrom.Text = "From:";
            // 
            // textBoxStudiesPatientName
            // 
            this.textBoxStudiesPatientName.Location = new System.Drawing.Point(494, 34);
            this.textBoxStudiesPatientName.Name = "textBoxStudiesPatientName";
            this.textBoxStudiesPatientName.Size = new System.Drawing.Size(203, 20);
            this.textBoxStudiesPatientName.TabIndex = 14;
            // 
            // dateTimePickerStudyFrom
            // 
            this.dateTimePickerStudyFrom.Enabled = false;
            this.dateTimePickerStudyFrom.Location = new System.Drawing.Point(187, 61);
            this.dateTimePickerStudyFrom.Name = "dateTimePickerStudyFrom";
            this.dateTimePickerStudyFrom.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerStudyFrom.TabIndex = 16;
            // 
            // labelStudiesPatientName
            // 
            this.labelStudiesPatientName.Location = new System.Drawing.Point(413, 38);
            this.labelStudiesPatientName.Name = "labelStudiesPatientName";
            this.labelStudiesPatientName.Size = new System.Drawing.Size(78, 13);
            this.labelStudiesPatientName.TabIndex = 12;
            this.labelStudiesPatientName.Text = "Patient Name:";
            // 
            // labelStudyDateTo
            // 
            this.labelStudyDateTo.Enabled = false;
            this.labelStudyDateTo.Location = new System.Drawing.Point(465, 64);
            this.labelStudyDateTo.Name = "labelStudyDateTo";
            this.labelStudyDateTo.Size = new System.Drawing.Size(23, 13);
            this.labelStudyDateTo.TabIndex = 13;
            this.labelStudyDateTo.Text = "To:";
            // 
            // checkBoxStudyDate
            // 
            this.checkBoxStudyDate.AutoSize = true;
            this.checkBoxStudyDate.Location = new System.Drawing.Point(39, 63);
            this.checkBoxStudyDate.Name = "checkBoxStudyDate";
            this.checkBoxStudyDate.Size = new System.Drawing.Size(79, 17);
            this.checkBoxStudyDate.TabIndex = 15;
            this.checkBoxStudyDate.Text = "Study Date";
            this.checkBoxStudyDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStudyTo
            // 
            this.dateTimePickerStudyTo.Enabled = false;
            this.dateTimePickerStudyTo.Location = new System.Drawing.Point(494, 61);
            this.dateTimePickerStudyTo.Name = "dateTimePickerStudyTo";
            this.dateTimePickerStudyTo.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerStudyTo.TabIndex = 17;
            // 
            // frmWorkListNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 612);
            this.Controls.Add(this.RadiologistPanel);
            this.Controls.Add(this.lvWorklist);
            this.Controls.Add(this.studiesToolStrip);
            this.Controls.Add(this.gbStudiesSearchCriteria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWorkListNew";
            this.Text = "WorkList";
            this.Load += new System.EventHandler(this.frmWorkListNew_Load);
            this.studiesToolStrip.ResumeLayout(false);
            this.studiesToolStrip.PerformLayout();
            this.RadiologistPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.gbStudiesSearchCriteria.ResumeLayout(false);
            this.gbStudiesSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderGroupBox gbStudiesSearchCriteria;
        private System.Windows.Forms.ComboBox comboBoxStudiesTenants;
        private System.Windows.Forms.Button searchStudiesButton;
        private System.Windows.Forms.Label labelStudiesPatientId;
        private System.Windows.Forms.TextBox textBoxStudiesPatientId;
        private System.Windows.Forms.Label labelStudyDateFrom;
        private System.Windows.Forms.TextBox textBoxStudiesPatientName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStudyFrom;
        private System.Windows.Forms.Label labelStudiesPatientName;
        private System.Windows.Forms.Label labelStudyDateTo;
        private System.Windows.Forms.CheckBox checkBoxStudyDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStudyTo;
        private System.Windows.Forms.ToolStrip studiesToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton ShowAssignedToRadiologistPanel;
        private System.Windows.Forms.ToolStripButton previewStudiesToolStripButton;
        private ListViewDoubleBuffered lvWorklist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Panel RadiologistPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnAssingToRad;
        private System.Windows.Forms.TextBox txtTemplateDescription;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAddEditTitleText;
        private System.Windows.Forms.Button btnHideRadiologistPanel;
        private System.Windows.Forms.ListView lvRadiologist;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ImageList imageList1;
    }
}