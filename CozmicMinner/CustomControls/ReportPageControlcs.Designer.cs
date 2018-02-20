namespace CozmicMinner.CustomControls
{
    partial class ReportPageControlcs
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
            this.topPanel = new DevExpress.XtraEditors.PanelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.filterPanel = new DevExpress.XtraEditors.PanelControl();
            this.tabPanel = new DevExpress.XtraBars.Navigation.TabPane();
            this.lblReports = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblReports);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1004, 34);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 34);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1004, 615);
            this.mainPanel.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterPanel.Location = new System.Drawing.Point(0, 500);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1004, 149);
            this.filterPanel.TabIndex = 2;
            // 
            // tabPanel
            // 
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(2, 2);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.RegularSize = new System.Drawing.Size(1000, 611);
            this.tabPanel.SelectedPage = null;
            this.tabPanel.Size = new System.Drawing.Size(1000, 611);
            this.tabPanel.TabIndex = 1;
            this.tabPanel.Text = "tabPane1";
            // 
            // lblReports
            // 
            this.lblReports.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Appearance.Options.UseFont = true;
            this.lblReports.Location = new System.Drawing.Point(5, 9);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(64, 19);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";
            // 
            // ReportPageControlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ReportPageControlcs";
            this.Size = new System.Drawing.Size(1004, 649);
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PanelControl filterPanel;
        private DevExpress.XtraBars.Navigation.TabPane tabPanel;
        private DevExpress.XtraEditors.LabelControl lblReports;
    }
}
