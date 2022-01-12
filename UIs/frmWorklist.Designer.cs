
namespace RIS
{
    partial class frmWorklist
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAssignToRAD = new System.Windows.Forms.Button();
            this.RadiologistPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTemplateDescription = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAddEditTitleText = new System.Windows.Forms.Label();
            this.btnHideRadiologistPanel = new System.Windows.Forms.Button();
            this.lvRadiologist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyPatientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyPatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyPatientDateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyPatientSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyAccessionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyModality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyImages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyReceptionDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyIncomingAet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyTenant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudyInstanceUid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RadiologistPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 251);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(946, 183);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // btnAssignToRAD
            // 
            this.btnAssignToRAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAssignToRAD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignToRAD.Location = new System.Drawing.Point(33, 178);
            this.btnAssignToRAD.Name = "btnAssignToRAD";
            this.btnAssignToRAD.Size = new System.Drawing.Size(129, 30);
            this.btnAssignToRAD.TabIndex = 1;
            this.btnAssignToRAD.Text = "Assign to RAD";
            this.btnAssignToRAD.UseVisualStyleBackColor = false;
            this.btnAssignToRAD.Visible = false;
            this.btnAssignToRAD.Click += new System.EventHandler(this.btnAssignToRAD_Click);
            // 
            // RadiologistPanel
            // 
            this.RadiologistPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RadiologistPanel.Controls.Add(this.tableLayoutPanel5);
            this.RadiologistPanel.Location = new System.Drawing.Point(100, 33);
            this.RadiologistPanel.Name = "RadiologistPanel";
            this.RadiologistPanel.Size = new System.Drawing.Size(479, 516);
            this.RadiologistPanel.TabIndex = 10197;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 3);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
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
            this.columnHeader1,
            this.columnHeader2});
            this.lvRadiologist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRadiologist.FullRowSelect = true;
            this.lvRadiologist.GridLines = true;
            this.lvRadiologist.HideSelection = false;
            this.lvRadiologist.Location = new System.Drawing.Point(3, 70);
            this.lvRadiologist.Name = "lvRadiologist";
            this.lvRadiologist.OwnerDraw = true;
            this.lvRadiologist.Size = new System.Drawing.Size(473, 407);
            this.lvRadiologist.TabIndex = 23;
            this.lvRadiologist.UseCompatibleStateImageBehavior = false;
            this.lvRadiologist.View = System.Windows.Forms.View.Details;
            this.lvRadiologist.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvRadiologist_DrawItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Radiologist Name";
            this.columnHeader2.Width = 350;
            // 
            // columnHeaderStudyPatientId
            // 
            this.columnHeaderStudyPatientId.Text = "Patient ID";
            this.columnHeaderStudyPatientId.Width = 80;
            // 
            // columnHeaderStudyPatientName
            // 
            this.columnHeaderStudyPatientName.Text = "Patient Name";
            this.columnHeaderStudyPatientName.Width = 200;
            // 
            // columnHeaderStudyPatientDateOfBirth
            // 
            this.columnHeaderStudyPatientDateOfBirth.Text = "Date of Birth";
            this.columnHeaderStudyPatientDateOfBirth.Width = 80;
            // 
            // columnHeaderStudyPatientSex
            // 
            this.columnHeaderStudyPatientSex.Text = "Patient Sex";
            this.columnHeaderStudyPatientSex.Width = 80;
            // 
            // columnHeaderStudyAccessionNumber
            // 
            this.columnHeaderStudyAccessionNumber.Text = "Accession Number";
            this.columnHeaderStudyAccessionNumber.Width = 110;
            // 
            // columnHeaderStudyDate
            // 
            this.columnHeaderStudyDate.Text = "Study Date";
            this.columnHeaderStudyDate.Width = 120;
            // 
            // columnHeaderStudyDescription
            // 
            this.columnHeaderStudyDescription.Text = "Study Description";
            this.columnHeaderStudyDescription.Width = 150;
            // 
            // columnHeaderStudyModality
            // 
            this.columnHeaderStudyModality.DisplayIndex = 8;
            this.columnHeaderStudyModality.Text = "Modality";
            this.columnHeaderStudyModality.Width = 70;
            // 
            // columnHeaderStudyImages
            // 
            this.columnHeaderStudyImages.DisplayIndex = 7;
            this.columnHeaderStudyImages.Text = "Study Datasets";
            this.columnHeaderStudyImages.Width = 80;
            // 
            // columnHeaderStudyReceptionDateTime
            // 
            this.columnHeaderStudyReceptionDateTime.Text = "Reception Date";
            this.columnHeaderStudyReceptionDateTime.Width = 120;
            // 
            // columnHeaderStudyIncomingAet
            // 
            this.columnHeaderStudyIncomingAet.Text = "Incoming AE Title";
            this.columnHeaderStudyIncomingAet.Width = 100;
            // 
            // columnHeaderStudyTenant
            // 
            this.columnHeaderStudyTenant.Text = "Tenant";
            this.columnHeaderStudyTenant.Width = 100;
            // 
            // columnHeaderStudyInstanceUid
            // 
            this.columnHeaderStudyInstanceUid.Text = "Study Instance UID";
            this.columnHeaderStudyInstanceUid.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Patient ID";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Patient Name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date of Birth";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Patient Sex";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Accession Number";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Study Date";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Study Description";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 8;
            this.columnHeader10.Text = "Modality";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 7;
            this.columnHeader11.Text = "Study Datasets";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Reception Date";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Incoming AE Title";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tenant";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Study Instance UID";
            this.columnHeader15.Width = 300;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Patient ID";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Patient Name";
            this.columnHeader17.Width = 200;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Date of Birth";
            this.columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Patient Sex";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Accession Number";
            this.columnHeader20.Width = 110;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Study Date";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Study Description";
            this.columnHeader22.Width = 150;
            // 
            // columnHeader23
            // 
            this.columnHeader23.DisplayIndex = 8;
            this.columnHeader23.Text = "Modality";
            this.columnHeader23.Width = 70;
            // 
            // columnHeader24
            // 
            this.columnHeader24.DisplayIndex = 7;
            this.columnHeader24.Text = "Study Datasets";
            this.columnHeader24.Width = 80;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Reception Date";
            this.columnHeader25.Width = 120;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Incoming AE Title";
            this.columnHeader26.Width = 100;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Tenant";
            this.columnHeader27.Width = 100;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Study Instance UID";
            this.columnHeader28.Width = 300;
            // 
            // frmWorklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 615);
            this.Controls.Add(this.RadiologistPanel);
            this.Controls.Add(this.btnAssignToRAD);
            this.Controls.Add(this.listView1);
            this.Name = "frmWorklist";
            this.Text = "WorkList";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.RadiologistPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAssignToRAD;
        private System.Windows.Forms.Panel RadiologistPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtTemplateDescription;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAddEditTitleText;
        private System.Windows.Forms.Button btnHideRadiologistPanel;
        private System.Windows.Forms.ListView lvRadiologist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyPatientId;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyPatientName;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyPatientDateOfBirth;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyPatientSex;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyAccessionNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyDate;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyModality;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyImages;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyReceptionDateTime;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyIncomingAet;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyTenant;
        private System.Windows.Forms.ColumnHeader columnHeaderStudyInstanceUid;
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
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
    }
}

