
namespace RIS.HtmlEditor
{
    partial class frmAddEditDeleteTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditDeleteTemplate));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbConsultant = new System.Windows.Forms.ComboBox();
            this.lvTemplates = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label22 = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 10210;
            this.label4.Text = "Select Consultant";
            // 
            // cmbConsultant
            // 
            this.cmbConsultant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultant.FormattingEnabled = true;
            this.cmbConsultant.Location = new System.Drawing.Point(30, 27);
            this.cmbConsultant.Name = "cmbConsultant";
            this.cmbConsultant.Size = new System.Drawing.Size(415, 25);
            this.cmbConsultant.TabIndex = 10209;
            // 
            // lvTemplates
            // 
            this.lvTemplates.AllColumns.Add(this.olvColumn2);
            this.lvTemplates.AllowColumnReorder = true;
            this.lvTemplates.AllowDrop = true;
            this.lvTemplates.CheckBoxes = true;
            this.lvTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2});
            this.lvTemplates.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvTemplates.FullRowSelect = true;
            this.lvTemplates.HeaderWordWrap = true;
            this.lvTemplates.HideSelection = false;
            this.lvTemplates.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.lvTemplates.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.lvTemplates.IncludeColumnHeadersInCopy = true;
            this.lvTemplates.IsSimpleDragSource = true;
            this.lvTemplates.IsSimpleDropSink = true;
            this.lvTemplates.Location = new System.Drawing.Point(30, 107);
            this.lvTemplates.Name = "lvTemplates";
            this.lvTemplates.RowHeight = 25;
            this.lvTemplates.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.lvTemplates.ShowCommandMenuOnRightClick = true;
            this.lvTemplates.ShowGroups = false;
            this.lvTemplates.ShowHeaderInAllViews = false;
            this.lvTemplates.ShowItemToolTips = true;
            this.lvTemplates.Size = new System.Drawing.Size(452, 467);
            this.lvTemplates.SortGroupItemsByPrimaryColumn = false;
            this.lvTemplates.TabIndex = 10211;
            this.lvTemplates.TriStateCheckBoxes = true;
            this.lvTemplates.UseAlternatingBackColors = true;
            this.lvTemplates.UseCellFormatEvents = true;
            this.lvTemplates.UseCompatibleStateImageBehavior = false;
            this.lvTemplates.UseFilterIndicator = true;
            this.lvTemplates.UseFiltering = true;
            this.lvTemplates.UseHotItem = true;
            this.lvTemplates.View = System.Windows.Forms.View.Details;
            this.lvTemplates.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTemplates_ItemCheck);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "TemplateName";
            this.olvColumn2.Text = "Template Name";
            this.olvColumn2.Width = 425;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(27, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 17);
            this.label22.TabIndex = 10213;
            this.label22.Text = "Search Template";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplate.Location = new System.Drawing.Point(30, 75);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(415, 25);
            this.txtTemplate.TabIndex = 10212;
            this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(488, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 47);
            this.btnDelete.TabIndex = 10215;
            this.btnDelete.Text = "Delete (-)";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Green;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(488, 107);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(173, 47);
            this.btnAddNew.TabIndex = 10214;
            this.btnAddNew.Text = "(+) Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(488, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 47);
            this.btnUpdate.TabIndex = 10216;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAddEditDeleteTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 601);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.lvTemplates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbConsultant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEditDeleteTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit/Delete Template";
            this.Load += new System.EventHandler(this.frmAddEditDeleteTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbConsultant;
        private BrightIdeasSoftware.ObjectListView lvTemplates;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
    }
}