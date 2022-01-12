
namespace RIS.UIs
{
    partial class frmAddEditModalityProceduresMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditModalityProceduresMapping));
            this.btnSave = new System.Windows.Forms.Button();
            this.dgProcedures = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIdentityLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIdentityLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHISProcedure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModalityProcedure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.ctrlProcedureSearch = new RIS.Controls.HISProcedureSearchControl();
            this.ctrlHospitalSearch = new RIS.HospitalSearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(54, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 55);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgProcedures
            // 
            this.dgProcedures.AllowUserToAddRows = false;
            this.dgProcedures.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcedures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DIdentityLine1,
            this.DIdentityLine2,
            this.CName});
            this.dgProcedures.Location = new System.Drawing.Point(416, 48);
            this.dgProcedures.Name = "dgProcedures";
            this.dgProcedures.Size = new System.Drawing.Size(627, 505);
            this.dgProcedures.TabIndex = 126;
            this.dgProcedures.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProcedures_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "RCId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // DIdentityLine1
            // 
            this.DIdentityLine1.DataPropertyName = "DIdentityLine1";
            this.DIdentityLine1.HeaderText = "Modality Procedure";
            this.DIdentityLine1.Name = "DIdentityLine1";
            this.DIdentityLine1.Width = 180;
            // 
            // DIdentityLine2
            // 
            this.DIdentityLine2.DataPropertyName = "DIdentityLine2";
            this.DIdentityLine2.HeaderText = "HIS Procedure";
            this.DIdentityLine2.Name = "DIdentityLine2";
            this.DIdentityLine2.Width = 200;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Modality";
            this.CName.Name = "CName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "Select HIS Procedure";
            // 
            // txtHISProcedure
            // 
            this.txtHISProcedure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHISProcedure.Location = new System.Drawing.Point(54, 128);
            this.txtHISProcedure.Name = "txtHISProcedure";
            this.txtHISProcedure.Size = new System.Drawing.Size(334, 27);
            this.txtHISProcedure.TabIndex = 124;
            this.txtHISProcedure.TextChanged += new System.EventHandler(this.txtHISProcedure_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "Modality Procedure Name";
            // 
            // txtModalityProcedure
            // 
            this.txtModalityProcedure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalityProcedure.Location = new System.Drawing.Point(54, 188);
            this.txtModalityProcedure.Name = "txtModalityProcedure";
            this.txtModalityProcedure.Size = new System.Drawing.Size(333, 27);
            this.txtModalityProcedure.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 130;
            this.label4.Text = "Select Hospital";
            // 
            // txtHospital
            // 
            this.txtHospital.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospital.Location = new System.Drawing.Point(54, 61);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(334, 27);
            this.txtHospital.TabIndex = 129;
            this.txtHospital.TextChanged += new System.EventHandler(this.txtHospital_TextChanged);
            // 
            // ctrlProcedureSearch
            // 
            this.ctrlProcedureSearch.Location = new System.Drawing.Point(624, 166);
            this.ctrlProcedureSearch.Name = "ctrlProcedureSearch";
            this.ctrlProcedureSearch.Size = new System.Drawing.Size(606, 466);
            this.ctrlProcedureSearch.TabIndex = 131;
            this.ctrlProcedureSearch.Visible = false;
            // 
            // ctrlHospitalSearch
            // 
            this.ctrlHospitalSearch.Location = new System.Drawing.Point(308, 106);
            this.ctrlHospitalSearch.Name = "ctrlHospitalSearch";
            this.ctrlHospitalSearch.Size = new System.Drawing.Size(601, 556);
            this.ctrlHospitalSearch.TabIndex = 132;
            this.ctrlHospitalSearch.Visible = false;
            // 
            // frmAddEditModalityProceduresMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 619);
            this.Controls.Add(this.ctrlHospitalSearch);
            this.Controls.Add(this.ctrlProcedureSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHospital);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgProcedures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHISProcedure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModalityProcedure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEditModalityProceduresMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit HIS-Modality Procedures Mapping";
            this.Load += new System.EventHandler(this.frmAddEditProcedures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgProcedures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHISProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModalityProcedure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHospital;
        private Controls.HISProcedureSearchControl ctrlProcedureSearch;
        private HospitalSearchControl ctrlHospitalSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIdentityLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIdentityLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
    }
}