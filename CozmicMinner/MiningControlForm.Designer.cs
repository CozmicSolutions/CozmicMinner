namespace CozmicMinner
{
    using System.ComponentModel;
    using System.Windows.Forms;

    using DevExpress.LookAndFeel;
    using DevExpress.XtraBars;
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.Grid;

    partial class MiningControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MiningControlForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BrowserProgressBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar =
                new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.BrowserLabel = new DevExpress.XtraBars.BarStaticItem();
            this.txtwebAddress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnWebSearch = new DevExpress.XtraBars.BarButtonItem();
            this.cmbWebAdress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.menuAddtoFav = new DevExpress.XtraBars.BarButtonItem();
            this.menuManageBookmarks = new DevExpress.XtraBars.BarButtonItem();
            this.menuShowPriceList = new DevExpress.XtraBars.BarButtonItem();
            this.menuCreateServer = new DevExpress.XtraBars.BarButtonItem();
            this.menuUpdateServer = new DevExpress.XtraBars.BarButtonItem();
            this.menuDeleteServer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageLivePricing = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonBookPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageServers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemMarqueeProgressBar1 =
                new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.gridControlServer = new DevExpress.XtraGrid.GridControl();
            this.gridViewServer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)this.ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemMarqueeProgressBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemMarqueeProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.mainPanel).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.gridControlServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gridViewServer).BeginInit();
            this.SuspendLayout();

            // ribbon
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(
                new BarItem[]
                    {
                        this.ribbon.ExpandCollapseItem, this.BrowserProgressBar, this.BrowserLabel, this.txtwebAddress,
                        this.btnWebSearch, this.cmbWebAdress, this.menuAddtoFav, this.menuManageBookmarks,
                        this.menuShowPriceList, this.menuCreateServer, this.menuUpdateServer, this.menuDeleteServer
                    });
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new[] { this.ribbonPageCategory1 });
            this.ribbon.RepositoryItems.AddRange(
                new RepositoryItem[]
                    {
                        this.repositoryItemProgressBar1, this.repositoryItemMarqueeProgressBar1,
                        this.repositoryItemMarqueeProgressBar, this.repositoryItemTextEdit, this.repositoryItemComboBox
                    });
            this.ribbon.Size = new System.Drawing.Size(1318, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);

            // BrowserProgressBar
            this.BrowserProgressBar.Edit = this.repositoryItemMarqueeProgressBar;
            this.BrowserProgressBar.EditWidth = 200;
            this.BrowserProgressBar.Id = 3;
            this.BrowserProgressBar.Name = "BrowserProgressBar";
            this.BrowserProgressBar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            // repositoryItemMarqueeProgressBar
            this.repositoryItemMarqueeProgressBar.Name = "repositoryItemMarqueeProgressBar";
            this.repositoryItemMarqueeProgressBar.ProgressAnimationMode =
                DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;

            // BrowserLabel
            this.BrowserLabel.Caption = "Loading";
            this.BrowserLabel.Id = 4;
            this.BrowserLabel.Name = "BrowserLabel";

            // txtwebAddress
            this.txtwebAddress.Caption = "Address : ";
            this.txtwebAddress.Edit = this.repositoryItemTextEdit;
            this.txtwebAddress.EditWidth = 350;
            this.txtwebAddress.Id = 6;
            this.txtwebAddress.Name = "txtwebAddress";

            // repositoryItemTextEdit
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";

            // btnWebSearch
            this.btnWebSearch.Caption = "GO";
            this.btnWebSearch.Id = 7;
            this.btnWebSearch.Name = "btnWebSearch";
            this.btnWebSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWebSearch_ItemClick);

            // cmbWebAdress
            this.cmbWebAdress.Edit = this.repositoryItemComboBox;
            this.cmbWebAdress.EditValue = "https://coincap.io/";
            this.cmbWebAdress.EditWidth = 150;
            this.cmbWebAdress.Id = 8;
            this.cmbWebAdress.Name = "cmbWebAdress";
            this.cmbWebAdress.EditValueChanged += new System.EventHandler(this.cmbWebAdress_EditValueChanged);

            // repositoryItemComboBox
            this.repositoryItemComboBox.AutoHeight = false;
            this.repositoryItemComboBox.Buttons.AddRange(
                new[]
                    {
                        new DevExpress.XtraEditors.Controls.EditorButton(
                            DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
                    });
            this.repositoryItemComboBox.Items.AddRange(
                new object[]
                    {
                        "https://coincap.io/", "https://cryptoreport.com/", "https://www.livecoinwatch.com/",
                        "https://www.cryptocompare.com/"
                    });
            this.repositoryItemComboBox.Name = "repositoryItemComboBox";
            this.repositoryItemComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles
                .DisableTextEditor;

            // menuAddtoFav
            this.menuAddtoFav.Caption = "Bookmark This Page";
            this.menuAddtoFav.Id = 9;
            this.menuAddtoFav.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuAddtoFav.ImageOptions.Image"));
            this.menuAddtoFav.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuAddtoFav.ImageOptions.LargeImage"));
            this.menuAddtoFav.Name = "menuAddtoFav";
            this.menuAddtoFav.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAddtoFav_ItemClick);

            // menuManageBookmarks
            this.menuManageBookmarks.Caption = "Manage Bookmarks";
            this.menuManageBookmarks.Id = 10;
            this.menuManageBookmarks.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuManageBookmarks.ImageOptions.Image"));
            this.menuManageBookmarks.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuManageBookmarks.ImageOptions.LargeImage"));
            this.menuManageBookmarks.Name = "menuManageBookmarks";
            this.menuManageBookmarks.ItemClick +=
                new DevExpress.XtraBars.ItemClickEventHandler(this.menuManageBookmarks_ItemClick);

            // menuShowPriceList
            this.menuShowPriceList.Caption = "Live Report";
            this.menuShowPriceList.Id = 11;
            this.menuShowPriceList.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuShowPriceList.ImageOptions.Image"));
            this.menuShowPriceList.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuShowPriceList.ImageOptions.LargeImage"));
            this.menuShowPriceList.Name = "menuShowPriceList";
            this.menuShowPriceList.ItemClick +=
                new DevExpress.XtraBars.ItemClickEventHandler(this.menuShowPriceList_ItemClick);

            // menuCreateServer
            this.menuCreateServer.Caption = "Create Server";
            this.menuCreateServer.Id = 12;
            this.menuCreateServer.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuCreateServer.ImageOptions.Image"));
            this.menuCreateServer.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuCreateServer.ImageOptions.LargeImage"));
            this.menuCreateServer.Name = "menuCreateServer";
            this.menuCreateServer.ItemClick +=
                new DevExpress.XtraBars.ItemClickEventHandler(this.menuCreateServer_ItemClick);

            // menuUpdateServer
            this.menuUpdateServer.Caption = "Edit Server";
            this.menuUpdateServer.Id = 13;
            this.menuUpdateServer.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuUpdateServer.ImageOptions.Image"));
            this.menuUpdateServer.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuUpdateServer.ImageOptions.LargeImage"));
            this.menuUpdateServer.Name = "menuUpdateServer";
            this.menuUpdateServer.ItemClick +=
                new DevExpress.XtraBars.ItemClickEventHandler(this.menuUpdateServer_ItemClick);

            // menuDeleteServer
            this.menuDeleteServer.Caption = "Delete Server";
            this.menuDeleteServer.Id = 14;
            this.menuDeleteServer.ImageOptions.Image =
                (System.Drawing.Image)(resources.GetObject("menuDeleteServer.ImageOptions.Image"));
            this.menuDeleteServer.ImageOptions.LargeImage =
                (System.Drawing.Image)(resources.GetObject("menuDeleteServer.ImageOptions.LargeImage"));
            this.menuDeleteServer.Name = "menuDeleteServer";
            this.menuDeleteServer.ItemClick +=
                new DevExpress.XtraBars.ItemClickEventHandler(this.menuDeleteServer_ItemClick);

            // ribbonPageCategory1
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new[] { this.ribbonPageLivePricing, this.ribbonPageServers });
            this.ribbonPageCategory1.Text = "Control Panel";

            // ribbonPageLivePricing
            this.ribbonPageLivePricing.Groups.AddRange(new[] { this.ribbonBookPageGroup });
            this.ribbonPageLivePricing.Name = "ribbonPageLivePricing";
            this.ribbonPageLivePricing.Text = "Live Pricing";

            // ribbonBookPageGroup
            this.ribbonBookPageGroup.ItemLinks.Add(this.menuShowPriceList);
            this.ribbonBookPageGroup.ItemLinks.Add(this.menuAddtoFav);
            this.ribbonBookPageGroup.ItemLinks.Add(this.menuManageBookmarks);
            this.ribbonBookPageGroup.Name = "ribbonBookPageGroup";
            this.ribbonBookPageGroup.Text = "Bookmarks";

            // ribbonPageServers
            this.ribbonPageServers.Groups.AddRange(new[] { this.ribbonPageGroup2 });
            this.ribbonPageServers.Name = "ribbonPageServers";
            this.ribbonPageServers.Text = "Mining Servers";

            // ribbonPageGroup2
            this.ribbonPageGroup2.ItemLinks.Add(this.menuCreateServer);
            this.ribbonPageGroup2.ItemLinks.Add(this.menuUpdateServer);
            this.ribbonPageGroup2.ItemLinks.Add(this.menuDeleteServer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Mining Server";

            // repositoryItemProgressBar1
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";

            // repositoryItemMarqueeProgressBar1
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";

            // ribbonStatusBar
            this.ribbonStatusBar.ItemLinks.Add(this.BrowserLabel);
            this.ribbonStatusBar.ItemLinks.Add(this.BrowserProgressBar);
            this.ribbonStatusBar.ItemLinks.Add(this.txtwebAddress);
            this.ribbonStatusBar.ItemLinks.Add(this.cmbWebAdress);
            this.ribbonStatusBar.ItemLinks.Add(this.btnWebSearch);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 599);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1318, 21);

            // webBrowser
            this.webBrowser.Location = new System.Drawing.Point(2, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(717, 440);
            this.webBrowser.TabIndex = 2;

            // mainPanel
            this.mainPanel.Controls.Add(this.gridControlServer);
            this.mainPanel.Controls.Add(this.webBrowser);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 146);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1318, 453);
            this.mainPanel.TabIndex = 5;

            // gridControlServer
            this.gridControlServer.Location = new System.Drawing.Point(725, 6);
            this.gridControlServer.MainView = this.gridViewServer;
            this.gridControlServer.Name = "gridControlServer";
            this.gridControlServer.Size = new System.Drawing.Size(567, 438);
            this.gridControlServer.TabIndex = 3;
            this.gridControlServer.ViewCollection.AddRange(new BaseView[] { this.gridViewServer });

            // gridViewServer
            this.gridViewServer.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(
                (int)(((byte)(255))),
                (int)(((byte)(255))),
                (int)(((byte)(192))));
            this.gridViewServer.Appearance.FocusedRow.Font =
                new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.gridViewServer.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewServer.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewServer.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(
                (int)(((byte)(224))),
                (int)(((byte)(224))),
                (int)(((byte)(224))));
            this.gridViewServer.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridViewServer.Appearance.Row.Options.UseBackColor = true;
            this.gridViewServer.Appearance.Row.Options.UseFont = true;
            this.gridViewServer.GridControl = this.gridControlServer;
            this.gridViewServer.Name = "gridViewServer";

            // defaultLookAndFeel
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Dark";

            // MiningControlForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 620);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MiningControlForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MiningControlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MiningControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)this.ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemMarqueeProgressBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.repositoryItemMarqueeProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.mainPanel).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.gridControlServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gridViewServer).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPageLivePricing;
        private RibbonPageGroup ribbonBookPageGroup;
        private RibbonStatusBar ribbonStatusBar;
        private WebBrowser webBrowser;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private BarEditItem BrowserProgressBar;
        private RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar;
        private BarStaticItem BrowserLabel;
        private BarEditItem txtwebAddress;
        private RepositoryItemTextEdit repositoryItemTextEdit;
        private BarButtonItem btnWebSearch;
        private BarEditItem cmbWebAdress;
        private RepositoryItemComboBox repositoryItemComboBox;
        private BarButtonItem menuAddtoFav;
        private BarButtonItem menuManageBookmarks;
        private PanelControl mainPanel;
        private BarButtonItem menuShowPriceList;
        private BarButtonItem menuCreateServer;
        private RibbonPageCategory ribbonPageCategory1;
        private RibbonPage ribbonPageServers;
        private RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem menuUpdateServer;
        private BarButtonItem menuDeleteServer;
        private GridControl gridControlServer;
        private GridView gridViewServer;
        private DefaultLookAndFeel defaultLookAndFeel;
    }
}