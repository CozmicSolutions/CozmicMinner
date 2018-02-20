namespace CozmicMinner.CustomControls
{
    partial class WebBrowserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserControl));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.pcMain = new DevExpress.XtraEditors.PanelControl();
            this.pcTop = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).BeginInit();
            this.pcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(2, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1067, 547);
            this.webBrowser.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressbarStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 560);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1071, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Status : ";
            // 
            // progressbarStatus
            // 
            this.progressbarStatus.AutoSize = false;
            this.progressbarStatus.Name = "progressbarStatus";
            this.progressbarStatus.Size = new System.Drawing.Size(250, 16);
            // 
            // pcMain
            // 
            this.pcMain.Controls.Add(this.webBrowser);
            this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMain.Location = new System.Drawing.Point(0, 31);
            this.pcMain.Name = "pcMain";
            this.pcMain.Size = new System.Drawing.Size(1071, 551);
            this.pcMain.TabIndex = 2;
            // 
            // pcTop
            // 
            this.pcTop.Controls.Add(this.btnRefresh);
            this.pcTop.Controls.Add(this.txtAddress);
            this.pcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcTop.Location = new System.Drawing.Point(0, 0);
            this.pcTop.Name = "pcTop";
            this.pcTop.Size = new System.Drawing.Size(1071, 31);
            this.pcTop.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefresh.Location = new System.Drawing.Point(1005, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.AutoHeight = false;
            this.txtAddress.Size = new System.Drawing.Size(1067, 27);
            this.txtAddress.TabIndex = 1;
            // 
            // WebBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.pcTop);
            this.Controls.Add(this.statusStrip);
            this.Name = "WebBrowserControl";
            this.Size = new System.Drawing.Size(1071, 582);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).EndInit();
            this.pcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressbarStatus;
        private DevExpress.XtraEditors.PanelControl pcMain;
        private DevExpress.XtraEditors.PanelControl pcTop;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.TextEdit txtAddress;
    }
}
