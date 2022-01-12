using RIS;

namespace DicomServer
{
    partial class PreviewForm
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
            this.previewListView = new DoubleBufferedCollapsibleGroupListView();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // previewListView
            // 
            this.previewListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewListView.HideSelection = false;
            this.previewListView.Location = new System.Drawing.Point(0, 0);
            this.previewListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewListView.Name = "previewListView";
            this.previewListView.Size = new System.Drawing.Size(949, 592);
            this.previewListView.TabIndex = 0;
            this.previewListView.UseCompatibleStateImageBehavior = false;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 610);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(951, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(951, 632);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.previewListView);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(964, 662);
            this.Name = "PreviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preview Studies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnPreviewFormClosing);
            this.Load += new System.EventHandler(this.OnPreviewFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DoubleBufferedCollapsibleGroupListView previewListView;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
    }
}