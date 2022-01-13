
namespace RIS.UIs
{
    partial class frmUpdateWorkListInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateWorkListInfo));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClinicalHistory = new System.Windows.Forms.TextBox();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.Procedure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.ctrlProcedureSearch = new RIS.Controls.HISProcedureSearchControl();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHISProcedure = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReferral = new System.Windows.Forms.Button();
            this.txtReferralPhysician = new System.Windows.Forms.TextBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "Referral Physician";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Clinical History";
            // 
            // txtClinicalHistory
            // 
            this.txtClinicalHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalHistory.Location = new System.Drawing.Point(166, 188);
            this.txtClinicalHistory.Multiline = true;
            this.txtClinicalHistory.Name = "txtClinicalHistory";
            this.txtClinicalHistory.Size = new System.Drawing.Size(517, 60);
            this.txtClinicalHistory.TabIndex = 110;
            // 
            // txtProcedure
            // 
            this.txtProcedure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedure.Location = new System.Drawing.Point(166, 150);
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(397, 27);
            this.txtProcedure.TabIndex = 109;
            this.txtProcedure.TextChanged += new System.EventHandler(this.txtProcedure_TextChanged);
            // 
            // Procedure
            // 
            this.Procedure.AutoSize = true;
            this.Procedure.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procedure.Location = new System.Drawing.Point(45, 150);
            this.Procedure.Name = "Procedure";
            this.Procedure.Size = new System.Drawing.Size(113, 19);
            this.Procedure.TabIndex = 108;
            this.Procedure.Text = "Select Procedure";
            this.Procedure.Click += new System.EventHandler(this.Procedure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 123;
            this.label1.Text = "Status";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(166, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 45);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "UnAssigned",
            "Assigned",
            "Completed",
            "Urgent",
            "Addentum",
            "Cancel"});
            this.cmbStatus.Location = new System.Drawing.Point(166, 304);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 25);
            this.cmbStatus.TabIndex = 122;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // ctrlProcedureSearch
            // 
            this.ctrlProcedureSearch.Location = new System.Drawing.Point(166, 467);
            this.ctrlProcedureSearch.Name = "ctrlProcedureSearch";
            this.ctrlProcedureSearch.Size = new System.Drawing.Size(606, 466);
            this.ctrlProcedureSearch.TabIndex = 132;
            this.ctrlProcedureSearch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 133;
            this.label4.Text = "Modality Procedure";
            // 
            // lblHISProcedure
            // 
            this.lblHISProcedure.AutoSize = true;
            this.lblHISProcedure.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHISProcedure.Location = new System.Drawing.Point(583, 154);
            this.lblHISProcedure.Name = "lblHISProcedure";
            this.lblHISProcedure.Size = new System.Drawing.Size(0, 18);
            this.lblHISProcedure.TabIndex = 134;
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(166, 344);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(517, 27);
            this.txtFileName.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 136;
            this.label5.Text = "File Name";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(166, 14);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(237, 27);
            this.txtPatientId.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 137;
            this.label6.Text = "Patient Id";
            // 
            // btnAddReferral
            // 
            this.btnAddReferral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddReferral.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReferral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddReferral.Location = new System.Drawing.Point(689, 261);
            this.btnAddReferral.Name = "btnAddReferral";
            this.btnAddReferral.Size = new System.Drawing.Size(113, 32);
            this.btnAddReferral.TabIndex = 140;
            this.btnAddReferral.Text = "(+) Add to DB";
            this.btnAddReferral.UseVisualStyleBackColor = false;
            this.btnAddReferral.Click += new System.EventHandler(this.btnAddReferral_Click);
            // 
            // txtReferralPhysician
            // 
            this.txtReferralPhysician.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferralPhysician.Location = new System.Drawing.Point(166, 263);
            this.txtReferralPhysician.Name = "txtReferralPhysician";
            this.txtReferralPhysician.Size = new System.Drawing.Size(517, 27);
            this.txtReferralPhysician.TabIndex = 141;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnable.Location = new System.Drawing.Point(367, 304);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(120, 23);
            this.chkEnable.TabIndex = 142;
            this.chkEnable.Text = "Enable Status";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.Click += new System.EventHandler(this.chkEnable_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(166, 47);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(397, 27);
            this.txtPatientName.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 143;
            this.label7.Text = "Patient Name";
            // 
            // txtHospital
            // 
            this.txtHospital.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospital.Location = new System.Drawing.Point(166, 80);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(497, 27);
            this.txtHospital.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 145;
            this.label8.Text = "Hospital/Imaging Centre";
            // 
            // frmUpdateWorkListInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 611);
            this.Controls.Add(this.txtHospital);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.ctrlProcedureSearch);
            this.Controls.Add(this.txtReferralPhysician);
            this.Controls.Add(this.btnAddReferral);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblHISProcedure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClinicalHistory);
            this.Controls.Add(this.txtProcedure);
            this.Controls.Add(this.Procedure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateWorkListInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update WorkList Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateWorkListInfo_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateWorkListInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClinicalHistory;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label Procedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private Controls.HISProcedureSearchControl ctrlProcedureSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHISProcedure;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddReferral;
        private System.Windows.Forms.TextBox txtReferralPhysician;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label label8;
        //private ProcedureSearchControl ctrlProcedureSearch;
    }
}