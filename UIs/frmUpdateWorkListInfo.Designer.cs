
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
            this.txtReferralPhysician = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "Referral Physician";
            // 
            // txtReferralPhysician
            // 
            this.txtReferralPhysician.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferralPhysician.Location = new System.Drawing.Point(140, 160);
            this.txtReferralPhysician.Multiline = true;
            this.txtReferralPhysician.Name = "txtReferralPhysician";
            this.txtReferralPhysician.Size = new System.Drawing.Size(517, 43);
            this.txtReferralPhysician.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Clinical History";
            // 
            // txtClinicalHistory
            // 
            this.txtClinicalHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalHistory.Location = new System.Drawing.Point(140, 68);
            this.txtClinicalHistory.Multiline = true;
            this.txtClinicalHistory.Name = "txtClinicalHistory";
            this.txtClinicalHistory.Size = new System.Drawing.Size(517, 82);
            this.txtClinicalHistory.TabIndex = 110;
            // 
            // txtProcedure
            // 
            this.txtProcedure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedure.Location = new System.Drawing.Point(140, 30);
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(397, 27);
            this.txtProcedure.TabIndex = 109;
            this.txtProcedure.TextChanged += new System.EventHandler(this.txtProcedure_TextChanged);
            // 
            // Procedure
            // 
            this.Procedure.AutoSize = true;
            this.Procedure.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procedure.Location = new System.Drawing.Point(19, 30);
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
            this.label1.Location = new System.Drawing.Point(88, 218);
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
            this.btnUpdate.Location = new System.Drawing.Point(140, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 45);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "UnAssigned",
            "Assigned",
            "Completed",
            "Urgent",
            "Addentum",
            "Cancel"});
            this.cmbStatus.Location = new System.Drawing.Point(140, 218);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 25);
            this.cmbStatus.TabIndex = 122;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // ctrlProcedureSearch
            // 
            this.ctrlProcedureSearch.Location = new System.Drawing.Point(51, 342);
            this.ctrlProcedureSearch.Name = "ctrlProcedureSearch";
            this.ctrlProcedureSearch.Size = new System.Drawing.Size(606, 466);
            this.ctrlProcedureSearch.TabIndex = 132;
            this.ctrlProcedureSearch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 133;
            this.label4.Text = "Modality Procedure";
            // 
            // lblHISProcedure
            // 
            this.lblHISProcedure.AutoSize = true;
            this.lblHISProcedure.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHISProcedure.Location = new System.Drawing.Point(557, 34);
            this.lblHISProcedure.Name = "lblHISProcedure";
            this.lblHISProcedure.Size = new System.Drawing.Size(0, 18);
            this.lblHISProcedure.TabIndex = 134;
            // 
            // frmUpdateWorkListInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 513);
            this.Controls.Add(this.lblHISProcedure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlProcedureSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReferralPhysician);
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
        private System.Windows.Forms.TextBox txtReferralPhysician;
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
        //private ProcedureSearchControl ctrlProcedureSearch;
    }
}