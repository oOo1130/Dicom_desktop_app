
namespace RIS.UIs
{
    partial class frmAddEditRemoteNode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditRemoteNode));
            this.dgRemoteNodes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIdentityLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIdentityLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTenant = new System.Windows.Forms.ComboBox();
            this.lbTenant = new System.Windows.Forms.Label();
            this.tbNodeAet = new System.Windows.Forms.TextBox();
            this.lbNodeAet = new System.Windows.Forms.Label();
            this.lbNodePort = new System.Windows.Forms.Label();
            this.nuNodePort = new System.Windows.Forms.NumericUpDown();
            this.tbNodeHost = new System.Windows.Forms.TextBox();
            this.lbNodeHost = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbNodeName = new System.Windows.Forms.TextBox();
            this.lbNodeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoteNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNodePort)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRemoteNodes
            // 
            this.dgRemoteNodes.AllowUserToAddRows = false;
            this.dgRemoteNodes.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgRemoteNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemoteNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CName,
            this.DIdentityLine1,
            this.DIdentityLine2,
            this.Tenant});
            this.dgRemoteNodes.Location = new System.Drawing.Point(443, 27);
            this.dgRemoteNodes.Name = "dgRemoteNodes";
            this.dgRemoteNodes.Size = new System.Drawing.Size(670, 530);
            this.dgRemoteNodes.TabIndex = 126;
            this.dgRemoteNodes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRemoteNodes_RowHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "RCId";
            this.Id.HeaderText = "Name";
            this.Id.Name = "Id";
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Host";
            this.CName.Name = "CName";
            this.CName.Width = 120;
            // 
            // DIdentityLine1
            // 
            this.DIdentityLine1.DataPropertyName = "DIdentityLine1";
            this.DIdentityLine1.HeaderText = "Port";
            this.DIdentityLine1.Name = "DIdentityLine1";
            this.DIdentityLine1.Width = 80;
            // 
            // DIdentityLine2
            // 
            this.DIdentityLine2.DataPropertyName = "DIdentityLine2";
            this.DIdentityLine2.HeaderText = "AE. Title";
            this.DIdentityLine2.Name = "DIdentityLine2";
            this.DIdentityLine2.Width = 120;
            // 
            // Tenant
            // 
            this.Tenant.HeaderText = "Tenant";
            this.Tenant.Name = "Tenant";
            this.Tenant.Width = 280;
            // 
            // cbTenant
            // 
            this.cbTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenant.FormattingEnabled = true;
            this.cbTenant.Location = new System.Drawing.Point(108, 178);
            this.cbTenant.Margin = new System.Windows.Forms.Padding(2);
            this.cbTenant.Name = "cbTenant";
            this.cbTenant.Size = new System.Drawing.Size(310, 25);
            this.cbTenant.TabIndex = 136;
            // 
            // lbTenant
            // 
            this.lbTenant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenant.Location = new System.Drawing.Point(32, 177);
            this.lbTenant.Name = "lbTenant";
            this.lbTenant.Size = new System.Drawing.Size(70, 13);
            this.lbTenant.TabIndex = 127;
            this.lbTenant.Text = "Tenant:";
            // 
            // tbNodeAet
            // 
            this.tbNodeAet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNodeAet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodeAet.Location = new System.Drawing.Point(108, 140);
            this.tbNodeAet.MaxLength = 16;
            this.tbNodeAet.Name = "tbNodeAet";
            this.tbNodeAet.Size = new System.Drawing.Size(310, 25);
            this.tbNodeAet.TabIndex = 135;
            this.tbNodeAet.Text = "NODE_SCU";
            // 
            // lbNodeAet
            // 
            this.lbNodeAet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodeAet.Location = new System.Drawing.Point(32, 140);
            this.lbNodeAet.Name = "lbNodeAet";
            this.lbNodeAet.Size = new System.Drawing.Size(70, 13);
            this.lbNodeAet.TabIndex = 128;
            this.lbNodeAet.Text = "AE Title:";
            // 
            // lbNodePort
            // 
            this.lbNodePort.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodePort.Location = new System.Drawing.Point(32, 104);
            this.lbNodePort.Name = "lbNodePort";
            this.lbNodePort.Size = new System.Drawing.Size(49, 13);
            this.lbNodePort.TabIndex = 129;
            this.lbNodePort.Text = "Port:";
            // 
            // nuNodePort
            // 
            this.nuNodePort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nuNodePort.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuNodePort.Location = new System.Drawing.Point(108, 104);
            this.nuNodePort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nuNodePort.Name = "nuNodePort";
            this.nuNodePort.Size = new System.Drawing.Size(310, 25);
            this.nuNodePort.TabIndex = 134;
            this.nuNodePort.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nuNodePort.Value = new decimal(new int[] {
            104,
            0,
            0,
            0});
            // 
            // tbNodeHost
            // 
            this.tbNodeHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNodeHost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodeHost.Location = new System.Drawing.Point(108, 67);
            this.tbNodeHost.Name = "tbNodeHost";
            this.tbNodeHost.Size = new System.Drawing.Size(310, 25);
            this.tbNodeHost.TabIndex = 133;
            this.tbNodeHost.Text = "192.168.101.1";
            // 
            // lbNodeHost
            // 
            this.lbNodeHost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodeHost.Location = new System.Drawing.Point(32, 66);
            this.lbNodeHost.Name = "lbNodeHost";
            this.lbNodeHost.Size = new System.Drawing.Size(49, 13);
            this.lbNodeHost.TabIndex = 130;
            this.lbNodeHost.Text = "Host:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(200, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 33);
            this.btnCancel.TabIndex = 138;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(108, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 33);
            this.btnOK.TabIndex = 137;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbNodeName
            // 
            this.tbNodeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNodeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodeName.Location = new System.Drawing.Point(108, 27);
            this.tbNodeName.Name = "tbNodeName";
            this.tbNodeName.Size = new System.Drawing.Size(310, 25);
            this.tbNodeName.TabIndex = 131;
            this.tbNodeName.Text = "New Node";
            // 
            // lbNodeName
            // 
            this.lbNodeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodeName.Location = new System.Drawing.Point(32, 27);
            this.lbNodeName.Name = "lbNodeName";
            this.lbNodeName.Size = new System.Drawing.Size(49, 13);
            this.lbNodeName.TabIndex = 132;
            this.lbNodeName.Text = "Name:";
            // 
            // frmAddEditRemoteNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 618);
            this.Controls.Add(this.cbTenant);
            this.Controls.Add(this.lbTenant);
            this.Controls.Add(this.tbNodeAet);
            this.Controls.Add(this.lbNodeAet);
            this.Controls.Add(this.lbNodePort);
            this.Controls.Add(this.nuNodePort);
            this.Controls.Add(this.tbNodeHost);
            this.Controls.Add(this.lbNodeHost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNodeName);
            this.Controls.Add(this.lbNodeName);
            this.Controls.Add(this.dgRemoteNodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditRemoteNode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Remote Node";
            this.Load += new System.EventHandler(this.frmAddEditRemoteNode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoteNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNodePort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRemoteNodes;
        private System.Windows.Forms.ComboBox cbTenant;
        private System.Windows.Forms.Label lbTenant;
        private System.Windows.Forms.TextBox tbNodeAet;
        private System.Windows.Forms.Label lbNodeAet;
        private System.Windows.Forms.Label lbNodePort;
        private System.Windows.Forms.NumericUpDown nuNodePort;
        private System.Windows.Forms.TextBox tbNodeHost;
        private System.Windows.Forms.Label lbNodeHost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbNodeName;
        private System.Windows.Forms.Label lbNodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIdentityLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIdentityLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenant;
    }
}