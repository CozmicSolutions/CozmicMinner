namespace CozmicMinner.Forms
{
    partial class MiningServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiningServerForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuCreate = new DevExpress.XtraBars.BarButtonItem();
            this.menuEdit = new DevExpress.XtraBars.BarButtonItem();
            this.menuDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlServer = new DevExpress.XtraGrid.GridControl();
            this.gridViewServer = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServer)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.menuCreate,
            this.menuEdit,
            this.menuDelete});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(972, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // menuCreate
            // 
            this.menuCreate.Caption = "Create";
            this.menuCreate.Id = 1;
            this.menuCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuCreate.ImageOptions.Image")));
            this.menuCreate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuCreate.ImageOptions.LargeImage")));
            this.menuCreate.Name = "menuCreate";
            this.menuCreate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuCreate_ItemClick);
            // 
            // menuEdit
            // 
            this.menuEdit.Caption = "Edit";
            this.menuEdit.Id = 2;
            this.menuEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuEdit.ImageOptions.Image")));
            this.menuEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuEdit.ImageOptions.LargeImage")));
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuEdit_ItemClick);
            // 
            // menuDelete
            // 
            this.menuDelete.Caption = "Delete";
            this.menuDelete.Id = 3;
            this.menuDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuDelete.ImageOptions.Image")));
            this.menuDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuDelete.ImageOptions.LargeImage")));
            this.menuDelete.Name = "menuDelete";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Server";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.menuCreate);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 417);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(972, 32);
            // 
            // gridControlServer
            // 
            this.gridControlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServer.Location = new System.Drawing.Point(0, 144);
            this.gridControlServer.MainView = this.gridViewServer;
            this.gridControlServer.Name = "gridControlServer";
            this.gridControlServer.Size = new System.Drawing.Size(972, 273);
            this.gridControlServer.TabIndex = 2;
            this.gridControlServer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServer});
            // 
            // gridViewServer
            // 
            this.gridViewServer.GridControl = this.gridControlServer;
            this.gridViewServer.Name = "gridViewServer";
            // 
            // MiningServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 449);
            this.Controls.Add(this.gridControlServer);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MiningServerForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MiningServerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem menuCreate;
        private DevExpress.XtraBars.BarButtonItem menuEdit;
        private DevExpress.XtraBars.BarButtonItem menuDelete;
        private DevExpress.XtraGrid.GridControl gridControlServer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServer;
    }
}