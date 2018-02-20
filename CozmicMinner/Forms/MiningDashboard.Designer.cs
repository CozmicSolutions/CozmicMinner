namespace CozmicMinner.Forms
{
    partial class MiningDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiningDashboard));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuLiveReport = new DevExpress.XtraBars.BarButtonItem();
            this.menuRefreshReport = new DevExpress.XtraBars.BarButtonItem();
            this.menuAddNewServer = new DevExpress.XtraBars.BarButtonItem();
            this.menuEditServer = new DevExpress.XtraBars.BarButtonItem();
            this.menuDeleteServer = new DevExpress.XtraBars.BarButtonItem();
            this.menuServerList = new DevExpress.XtraBars.BarButtonItem();
            this.menuResetAll = new DevExpress.XtraBars.BarButtonItem();
            this.menuResetServers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageLiveReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageMiningServer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupServer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupResetAll = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupResetServer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.menuLiveReport,
            this.menuRefreshReport,
            this.menuAddNewServer,
            this.menuEditServer,
            this.menuDeleteServer,
            this.menuServerList,
            this.menuResetAll,
            this.menuResetServers,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageLiveReport,
            this.ribbonPageMiningServer,
            this.ribbonPageSystem,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1177, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // menuLiveReport
            // 
            this.menuLiveReport.Caption = "Live Report";
            this.menuLiveReport.Id = 1;
            this.menuLiveReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuLiveReport.ImageOptions.Image")));
            this.menuLiveReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuLiveReport.ImageOptions.LargeImage")));
            this.menuLiveReport.Name = "menuLiveReport";
            this.menuLiveReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuLiveReport_ItemClick);
            // 
            // menuRefreshReport
            // 
            this.menuRefreshReport.Caption = "Refresh";
            this.menuRefreshReport.Id = 2;
            this.menuRefreshReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuRefreshReport.ImageOptions.Image")));
            this.menuRefreshReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuRefreshReport.ImageOptions.LargeImage")));
            this.menuRefreshReport.Name = "menuRefreshReport";
            // 
            // menuAddNewServer
            // 
            this.menuAddNewServer.Caption = "Add New Server";
            this.menuAddNewServer.Id = 3;
            this.menuAddNewServer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuAddNewServer.ImageOptions.Image")));
            this.menuAddNewServer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuAddNewServer.ImageOptions.LargeImage")));
            this.menuAddNewServer.Name = "menuAddNewServer";
            this.menuAddNewServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAddNewServer_ItemClick);
            // 
            // menuEditServer
            // 
            this.menuEditServer.Caption = "Edit Server";
            this.menuEditServer.Id = 4;
            this.menuEditServer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuEditServer.ImageOptions.Image")));
            this.menuEditServer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuEditServer.ImageOptions.LargeImage")));
            this.menuEditServer.Name = "menuEditServer";
            this.menuEditServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuEditServer_ItemClick);
            // 
            // menuDeleteServer
            // 
            this.menuDeleteServer.Caption = "Delete Server";
            this.menuDeleteServer.Id = 5;
            this.menuDeleteServer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuDeleteServer.ImageOptions.Image")));
            this.menuDeleteServer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuDeleteServer.ImageOptions.LargeImage")));
            this.menuDeleteServer.Name = "menuDeleteServer";
            this.menuDeleteServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuDeleteServer_ItemClick_1);
            // 
            // menuServerList
            // 
            this.menuServerList.Caption = "Server List";
            this.menuServerList.Id = 6;
            this.menuServerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuServerList.ImageOptions.Image")));
            this.menuServerList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuServerList.ImageOptions.LargeImage")));
            this.menuServerList.Name = "menuServerList";
            this.menuServerList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuServerList_ItemClick);
            // 
            // menuResetAll
            // 
            this.menuResetAll.Caption = "Reset All to Factory Default";
            this.menuResetAll.Id = 7;
            this.menuResetAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuResetAll.ImageOptions.Image")));
            this.menuResetAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuResetAll.ImageOptions.LargeImage")));
            this.menuResetAll.Name = "menuResetAll";
            // 
            // menuResetServers
            // 
            this.menuResetServers.Caption = "Reset Servers to Factory Default";
            this.menuResetServers.Id = 8;
            this.menuResetServers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuResetServers.ImageOptions.Image")));
            this.menuResetServers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuResetServers.ImageOptions.LargeImage")));
            this.menuResetServers.Name = "menuResetServers";
            this.menuResetServers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuResetServers_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "CreditReport";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageLiveReport
            // 
            this.ribbonPageLiveReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageLiveReport.Name = "ribbonPageLiveReport";
            this.ribbonPageLiveReport.Text = "Live Report";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuLiveReport);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuRefreshReport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Report";
            // 
            // ribbonPageMiningServer
            // 
            this.ribbonPageMiningServer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupServer});
            this.ribbonPageMiningServer.Name = "ribbonPageMiningServer";
            this.ribbonPageMiningServer.Text = "Mining Servers";
            // 
            // ribbonPageGroupServer
            // 
            this.ribbonPageGroupServer.ItemLinks.Add(this.menuServerList);
            this.ribbonPageGroupServer.ItemLinks.Add(this.menuAddNewServer);
            this.ribbonPageGroupServer.ItemLinks.Add(this.menuEditServer);
            this.ribbonPageGroupServer.ItemLinks.Add(this.menuDeleteServer);
            this.ribbonPageGroupServer.Name = "ribbonPageGroupServer";
            this.ribbonPageGroupServer.Text = "Add/Edit/Delete Servers";
            // 
            // ribbonPageSystem
            // 
            this.ribbonPageSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupResetAll,
            this.ribbonPageGroupResetServer});
            this.ribbonPageSystem.Name = "ribbonPageSystem";
            this.ribbonPageSystem.Text = "System";
            // 
            // ribbonPageGroupResetAll
            // 
            this.ribbonPageGroupResetAll.ItemLinks.Add(this.menuResetAll);
            this.ribbonPageGroupResetAll.Name = "ribbonPageGroupResetAll";
            this.ribbonPageGroupResetAll.Text = "Reset All";
            // 
            // ribbonPageGroupResetServer
            // 
            this.ribbonPageGroupResetServer.ItemLinks.Add(this.menuResetServers);
            this.ribbonPageGroupResetServer.Name = "ribbonPageGroupResetServer";
            this.ribbonPageGroupResetServer.Text = "Reset Servers";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 684);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1177, 31);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 143);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1177, 541);
            this.mainPanel.TabIndex = 2;
            // 
            // MiningDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 715);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MiningDashboard";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MiningDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageLiveReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMiningServer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupServer;
        private DevExpress.XtraBars.BarButtonItem menuLiveReport;
        private DevExpress.XtraBars.BarButtonItem menuRefreshReport;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraBars.BarButtonItem menuAddNewServer;
        private DevExpress.XtraBars.BarButtonItem menuEditServer;
        private DevExpress.XtraBars.BarButtonItem menuDeleteServer;
        private DevExpress.XtraBars.BarButtonItem menuServerList;
        private DevExpress.XtraBars.BarButtonItem menuResetAll;
        private DevExpress.XtraBars.BarButtonItem menuResetServers;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupResetAll;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupResetServer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}