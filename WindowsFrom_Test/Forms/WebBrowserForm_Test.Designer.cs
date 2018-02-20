namespace CozmicAPI.Tests
{
    partial class WebBrowserForm_Test
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
            this.MainPanel = new DevExpress.XtraEditors.PanelControl();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dashboardViewer1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(954, 452);
            this.MainPanel.TabIndex = 0;
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.DashboardSource = typeof(WindowsFrom_Test.Forms.MiningDashboardPanel);
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(2, 2);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(950, 448);
            this.dashboardViewer1.TabIndex = 0;
            this.dashboardViewer1.Load += new System.EventHandler(this.dashboardViewer1_Load);
            // 
            // WebBrowserForm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 452);
            this.Controls.Add(this.MainPanel);
            this.Name = "WebBrowserForm_Test";
            this.Text = "WebBrowserForm_Test";
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl MainPanel;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
    }
}