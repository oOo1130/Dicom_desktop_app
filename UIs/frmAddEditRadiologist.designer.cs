namespace HDMS.Windows.Forms.UI.Diagonstics
{
    partial class frmAddEditRadiologist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditRadiologist));
            this.btnClose = new System.Windows.Forms.Button();
            this.chkUS = new System.Windows.Forms.CheckBox();
            this.chkCR = new System.Windows.Forms.CheckBox();
            this.chkMRI = new System.Windows.Forms.CheckBox();
            this.chkCT = new System.Windows.Forms.CheckBox();
            this.chkDR = new System.Windows.Forms.CheckBox();
            this.chkDX = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdentityLine6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdentityLine5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdentityLine4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdentityLine3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdentityLine2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFontSizeforIdentity1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentityLine1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameFontSize = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkECG = new System.Windows.Forms.CheckBox();
            this.dgvConsultants = new System.Windows.Forms.DataGridView();
            this.btnClearSignature = new System.Windows.Forms.LinkLabel();
            this.lnkBtnUploadSignature = new System.Windows.Forms.LinkLabel();
            this.sgnbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label16 = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDicomPath = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIdentityLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgnbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(283, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 36);
            this.btnClose.TabIndex = 100;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // chkUS
            // 
            this.chkUS.AutoSize = true;
            this.chkUS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUS.Location = new System.Drawing.Point(140, 433);
            this.chkUS.Name = "chkUS";
            this.chkUS.Size = new System.Drawing.Size(43, 22);
            this.chkUS.TabIndex = 99;
            this.chkUS.Tag = "US";
            this.chkUS.Text = "US";
            this.chkUS.UseVisualStyleBackColor = true;
            // 
            // chkCR
            // 
            this.chkCR.AutoSize = true;
            this.chkCR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCR.Location = new System.Drawing.Point(254, 377);
            this.chkCR.Name = "chkCR";
            this.chkCR.Size = new System.Drawing.Size(43, 22);
            this.chkCR.TabIndex = 98;
            this.chkCR.Tag = "CR";
            this.chkCR.Text = "CR";
            this.chkCR.UseVisualStyleBackColor = true;
            // 
            // chkMRI
            // 
            this.chkMRI.AutoSize = true;
            this.chkMRI.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMRI.Location = new System.Drawing.Point(203, 405);
            this.chkMRI.Name = "chkMRI";
            this.chkMRI.Size = new System.Drawing.Size(51, 22);
            this.chkMRI.TabIndex = 97;
            this.chkMRI.Tag = "MRI";
            this.chkMRI.Text = "MRI";
            this.chkMRI.UseVisualStyleBackColor = true;
            // 
            // chkCT
            // 
            this.chkCT.AutoSize = true;
            this.chkCT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCT.Location = new System.Drawing.Point(138, 405);
            this.chkCT.Name = "chkCT";
            this.chkCT.Size = new System.Drawing.Size(42, 22);
            this.chkCT.TabIndex = 96;
            this.chkCT.Tag = "CT";
            this.chkCT.Text = "CT";
            this.chkCT.UseVisualStyleBackColor = true;
            // 
            // chkDR
            // 
            this.chkDR.AutoSize = true;
            this.chkDR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDR.Location = new System.Drawing.Point(203, 377);
            this.chkDR.Name = "chkDR";
            this.chkDR.Size = new System.Drawing.Size(44, 22);
            this.chkDR.TabIndex = 95;
            this.chkDR.Tag = "DR";
            this.chkDR.Text = "DR";
            this.chkDR.UseVisualStyleBackColor = true;
            // 
            // chkDX
            // 
            this.chkDX.AutoSize = true;
            this.chkDX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDX.Location = new System.Drawing.Point(138, 377);
            this.chkDX.Name = "chkDX";
            this.chkDX.Size = new System.Drawing.Size(44, 22);
            this.chkDX.TabIndex = 94;
            this.chkDX.Tag = "DX";
            this.chkDX.Text = "DX";
            this.chkDX.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 93;
            this.label10.Text = "Font Size";
            // 
            // txtFontSizeforIdentity6
            // 
            this.txtFontSizeforIdentity6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity6.Location = new System.Drawing.Point(525, 297);
            this.txtFontSizeforIdentity6.Name = "txtFontSizeforIdentity6";
            this.txtFontSizeforIdentity6.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity6.TabIndex = 92;
            this.txtFontSizeforIdentity6.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 91;
            this.label11.Text = "Identity-6";
            // 
            // txtIdentityLine6
            // 
            this.txtIdentityLine6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine6.Location = new System.Drawing.Point(141, 297);
            this.txtIdentityLine6.Name = "txtIdentityLine6";
            this.txtIdentityLine6.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine6.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(454, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 89;
            this.label12.Text = "Font Size";
            // 
            // txtFontSizeforIdentity5
            // 
            this.txtFontSizeforIdentity5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity5.Location = new System.Drawing.Point(524, 254);
            this.txtFontSizeforIdentity5.Name = "txtFontSizeforIdentity5";
            this.txtFontSizeforIdentity5.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity5.TabIndex = 88;
            this.txtFontSizeforIdentity5.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 87;
            this.label13.Text = "Identity-5";
            // 
            // txtIdentityLine5
            // 
            this.txtIdentityLine5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine5.Location = new System.Drawing.Point(140, 254);
            this.txtIdentityLine5.Name = "txtIdentityLine5";
            this.txtIdentityLine5.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine5.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 85;
            this.label14.Text = "Font Size";
            // 
            // txtFontSizeforIdentity4
            // 
            this.txtFontSizeforIdentity4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity4.Location = new System.Drawing.Point(524, 209);
            this.txtFontSizeforIdentity4.Name = "txtFontSizeforIdentity4";
            this.txtFontSizeforIdentity4.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity4.TabIndex = 84;
            this.txtFontSizeforIdentity4.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 83;
            this.label15.Text = "Identity-4";
            // 
            // txtIdentityLine4
            // 
            this.txtIdentityLine4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine4.Location = new System.Drawing.Point(140, 209);
            this.txtIdentityLine4.Name = "txtIdentityLine4";
            this.txtIdentityLine4.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine4.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 81;
            this.label8.Text = "Font Size";
            // 
            // txtFontSizeforIdentity3
            // 
            this.txtFontSizeforIdentity3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity3.Location = new System.Drawing.Point(525, 164);
            this.txtFontSizeforIdentity3.Name = "txtFontSizeforIdentity3";
            this.txtFontSizeforIdentity3.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity3.TabIndex = 80;
            this.txtFontSizeforIdentity3.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Identity-3";
            // 
            // txtIdentityLine3
            // 
            this.txtIdentityLine3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine3.Location = new System.Drawing.Point(141, 164);
            this.txtIdentityLine3.Name = "txtIdentityLine3";
            this.txtIdentityLine3.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine3.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Font Size";
            // 
            // txtFontSizeforIdentity2
            // 
            this.txtFontSizeforIdentity2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity2.Location = new System.Drawing.Point(524, 121);
            this.txtFontSizeforIdentity2.Name = "txtFontSizeforIdentity2";
            this.txtFontSizeforIdentity2.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity2.TabIndex = 76;
            this.txtFontSizeforIdentity2.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Identity-2";
            // 
            // txtIdentityLine2
            // 
            this.txtIdentityLine2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine2.Location = new System.Drawing.Point(140, 121);
            this.txtIdentityLine2.Name = "txtIdentityLine2";
            this.txtIdentityLine2.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine2.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Font Size";
            // 
            // txtFontSizeforIdentity1
            // 
            this.txtFontSizeforIdentity1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeforIdentity1.Location = new System.Drawing.Point(524, 76);
            this.txtFontSizeforIdentity1.Name = "txtFontSizeforIdentity1";
            this.txtFontSizeforIdentity1.Size = new System.Drawing.Size(76, 27);
            this.txtFontSizeforIdentity1.TabIndex = 72;
            this.txtFontSizeforIdentity1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Identity-1";
            // 
            // txtIdentityLine1
            // 
            this.txtIdentityLine1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityLine1.Location = new System.Drawing.Point(140, 76);
            this.txtIdentityLine1.Name = "txtIdentityLine1";
            this.txtIdentityLine1.Size = new System.Drawing.Size(297, 27);
            this.txtIdentityLine1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Font Size";
            // 
            // txtNameFontSize
            // 
            this.txtNameFontSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFontSize.Location = new System.Drawing.Point(524, 34);
            this.txtNameFontSize.Name = "txtNameFontSize";
            this.txtNameFontSize.Size = new System.Drawing.Size(76, 27);
            this.txtNameFontSize.TabIndex = 68;
            this.txtNameFontSize.Text = "10";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(140, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 27);
            this.txtName.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Consultant Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(141, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 101;
            this.label5.Text = "Aloowed Modalities :";
            // 
            // chkECG
            // 
            this.chkECG.AutoSize = true;
            this.chkECG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkECG.Location = new System.Drawing.Point(203, 433);
            this.chkECG.Name = "chkECG";
            this.chkECG.Size = new System.Drawing.Size(51, 22);
            this.chkECG.TabIndex = 102;
            this.chkECG.Tag = "ECG";
            this.chkECG.Text = "ECG";
            this.chkECG.UseVisualStyleBackColor = true;
            // 
            // dgvConsultants
            // 
            this.dgvConsultants.AllowUserToAddRows = false;
            this.dgvConsultants.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvConsultants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.DIdentityLine1});
            this.dgvConsultants.Location = new System.Drawing.Point(640, 29);
            this.dgvConsultants.Name = "dgvConsultants";
            this.dgvConsultants.Size = new System.Drawing.Size(565, 530);
            this.dgvConsultants.TabIndex = 103;
            this.dgvConsultants.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsultants_RowHeaderMouseDoubleClick);
            // 
            // btnClearSignature
            // 
            this.btnClearSignature.AutoSize = true;
            this.btnClearSignature.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSignature.Location = new System.Drawing.Point(490, 451);
            this.btnClearSignature.Name = "btnClearSignature";
            this.btnClearSignature.Size = new System.Drawing.Size(99, 17);
            this.btnClearSignature.TabIndex = 10042;
            this.btnClearSignature.TabStop = true;
            this.btnClearSignature.Text = "Clear Signature";
            this.btnClearSignature.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClearSignature_LinkClicked);
            // 
            // lnkBtnUploadSignature
            // 
            this.lnkBtnUploadSignature.AutoSize = true;
            this.lnkBtnUploadSignature.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBtnUploadSignature.Location = new System.Drawing.Point(358, 451);
            this.lnkBtnUploadSignature.Name = "lnkBtnUploadSignature";
            this.lnkBtnUploadSignature.Size = new System.Drawing.Size(109, 17);
            this.lnkBtnUploadSignature.TabIndex = 10041;
            this.lnkBtnUploadSignature.TabStop = true;
            this.lnkBtnUploadSignature.Text = "Upload Signature";
            this.lnkBtnUploadSignature.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBtnUploadSignature_LinkClicked);
            // 
            // sgnbox
            // 
            this.sgnbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sgnbox.Location = new System.Drawing.Point(325, 343);
            this.sgnbox.Name = "sgnbox";
            this.sgnbox.Size = new System.Drawing.Size(275, 105);
            this.sgnbox.TabIndex = 10040;
            this.sgnbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(262, 19);
            this.label16.TabIndex = 10043;
            this.label16.Text = "Will Viewer Open With Default Template?";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(138, 490);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(49, 23);
            this.radYes.TabIndex = 10044;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(230, 490);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 23);
            this.radNo.TabIndex = 10045;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(50, 520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 19);
            this.label17.TabIndex = 10047;
            this.label17.Text = "Dicom Path";
            // 
            // txtDicomPath
            // 
            this.txtDicomPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDicomPath.Location = new System.Drawing.Point(141, 520);
            this.txtDicomPath.Name = "txtDicomPath";
            this.txtDicomPath.Size = new System.Drawing.Size(297, 27);
            this.txtDicomPath.TabIndex = 10046;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "SrlNo";
            this.CName.Name = "CName";
            this.CName.Width = 70;
            // 
            // DIdentityLine1
            // 
            this.DIdentityLine1.DataPropertyName = "DIdentityLine1";
            this.DIdentityLine1.HeaderText = "Name";
            this.DIdentityLine1.Name = "DIdentityLine1";
            this.DIdentityLine1.Width = 450;
            // 
            // frmAddEditRadiologist
            // 
            this.ClientSize = new System.Drawing.Size(1294, 652);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDicomPath);
            this.Controls.Add(this.radNo);
            this.Controls.Add(this.radYes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClearSignature);
            this.Controls.Add(this.lnkBtnUploadSignature);
            this.Controls.Add(this.sgnbox);
            this.Controls.Add(this.dgvConsultants);
            this.Controls.Add(this.chkECG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkUS);
            this.Controls.Add(this.chkCR);
            this.Controls.Add(this.chkMRI);
            this.Controls.Add(this.chkCT);
            this.Controls.Add(this.chkDR);
            this.Controls.Add(this.chkDX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFontSizeforIdentity6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIdentityLine6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFontSizeforIdentity5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdentityLine5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFontSizeforIdentity4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdentityLine4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFontSizeforIdentity3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdentityLine3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFontSizeforIdentity2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdentityLine2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFontSizeforIdentity1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentityLine1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameFontSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEditRadiologist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Radiologist";
            this.Load += new System.EventHandler(this.frmAddEditRadiologist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgnbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkUS;
        private System.Windows.Forms.CheckBox chkCR;
        private System.Windows.Forms.CheckBox chkMRI;
        private System.Windows.Forms.CheckBox chkCT;
        private System.Windows.Forms.CheckBox chkDR;
        private System.Windows.Forms.CheckBox chkDX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdentityLine6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdentityLine5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdentityLine4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdentityLine3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdentityLine2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFontSizeforIdentity1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentityLine1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameFontSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkECG;
        private System.Windows.Forms.DataGridView dgvConsultants;
        private System.Windows.Forms.LinkLabel btnClearSignature;
        private System.Windows.Forms.LinkLabel lnkBtnUploadSignature;
        private System.Windows.Forms.PictureBox sgnbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDicomPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIdentityLine1;
    }
}