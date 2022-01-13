namespace RIS.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgListLage = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.lblWorkStationId = new System.Windows.Forms.Label();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblNetConnectionStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // imgListLage
            // 
            this.imgListLage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListLage.ImageStream")));
            this.imgListLage.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListLage.Images.SetKeyName(0, "images.jpg");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(687, -125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // treeMenu
            // 
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeMenu.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMenu.Location = new System.Drawing.Point(0, 25);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(217, 584);
            this.treeMenu.TabIndex = 10;
            this.treeMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMenu_NodeMouseClick);
            // 
            // lblWorkStationId
            // 
            this.lblWorkStationId.AutoSize = true;
            this.lblWorkStationId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkStationId.ForeColor = System.Drawing.Color.Red;
            this.lblWorkStationId.Location = new System.Drawing.Point(12, 2);
            this.lblWorkStationId.Name = "lblWorkStationId";
            this.lblWorkStationId.Size = new System.Drawing.Size(42, 14);
            this.lblWorkStationId.TabIndex = 12;
            this.lblWorkStationId.Text = "label1";
            // 
            // treeImageList
            // 
            this.treeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblNetConnectionStatus
            // 
            this.lblNetConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetConnectionStatus.AutoSize = true;
            this.lblNetConnectionStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetConnectionStatus.ForeColor = System.Drawing.Color.Green;
            this.lblNetConnectionStatus.Location = new System.Drawing.Point(950, 4);
            this.lblNetConnectionStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lblNetConnectionStatus.Name = "lblNetConnectionStatus";
            this.lblNetConnectionStatus.Size = new System.Drawing.Size(0, 17);
            this.lblNetConnectionStatus.TabIndex = 15;
            this.lblNetConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(12, 12);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RIS.Properties.Resources.Software_Back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.lblNetConnectionStatus);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.lblWorkStationId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIS HOME";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgListLage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView treeMenu;
        public System.Windows.Forms.Label lblWorkStationId;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.Label lblNetConnectionStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}