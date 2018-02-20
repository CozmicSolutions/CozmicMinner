using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CozmicMinner
{
    using System.Data;

    using CozmicMinner.Forms;
    using DevExpress.XtraGrid.Columns;

    using MinnerDataAccess;

    public partial class MiningControlForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Private Fields

        private MiningDbContext DataBase = new MiningDbContext();

        #endregion Private Fields

        #region Public Constructors

        public MiningControlForm()
        {
            this.InitializeComponent();

            this.ClearMainPanel();

            this.webBrowser.Navigating += this.WebBrowser_Navigating;
            this.webBrowser.DocumentCompleted += this.WebBrowser_DocumentCompleted;
            this.webBrowser.Navigated += this.WebBrowser_Navigated;
            this.gridViewServer.DoubleClick += this.GridViewServer_DoubleClick;
            this.txtwebAddress.EditValue = "https://coincap.io/";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.FillBookmarkCombo();
            this.AddControlToMainPanel(this.webBrowser);
        }

        #endregion Public Constructors

        #region Web Browser

        /// <summary>
        ///      btnWebSearch_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnWebSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.webBrowser.Navigate(this.txtwebAddress.EditValue.ToString());
        }

        /// <summary>
        ///      cmbWebAdress_EditValueChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void cmbWebAdress_EditValueChanged(object sender, EventArgs e)
        {
            this.txtwebAddress.EditValue = this.cmbWebAdress.EditValue;
            this.webBrowser.Navigate(this.txtwebAddress.EditValue.ToString());
        }

        /// <summary>
        ///      MiningControlForm_Load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void MiningControlForm_Load(object sender, EventArgs e)
        {
            this.webBrowser.Navigate(this.txtwebAddress.EditValue.ToString());
        }

        /// <summary>
        ///      WebBrowser_DocumentCompleted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.BrowserLabel.Caption = @"Ready";
            this.repositoryItemMarqueeProgressBar.MarqueeAnimationSpeed = 80;
            this.repositoryItemMarqueeProgressBar.Stopped = true;
        }

        /// <summary>
        ///      WebBrowser_Navigated 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (!this.webBrowser.IsBusy)
            {
                this.repositoryItemMarqueeProgressBar.MarqueeAnimationSpeed = 0;

                // BrowserProgressBar.Style = ProgressBarStyle.Blocks;
                this.BrowserLabel.Caption = "Ready";
            }
        }

        /// <summary>
        ///      WebBrowser_Navigating 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.repositoryItemMarqueeProgressBar.Stopped = false;
            this.BrowserLabel.Caption = @"Loading ... ";
            this.repositoryItemMarqueeProgressBar.MarqueeAnimationSpeed = 80;

            // BrowserProgressBar.Style = ProgressBarStyle.Marquee;
        }

        #endregion Web Browser

        #region Bookmarks

        /// <summary>
        ///      FillBookmarkCombo 
        /// </summary>
        private void FillBookmarkCombo()
        {
            this.repositoryItemComboBox.Items.Clear();
            var RepositoryFactory = new MinnerDataFactory(this.DataBase);
            var bookmarks = RepositoryFactory.BookmarkRepository.GetAll();
            this.repositoryItemComboBox.Items.AddRange(bookmarks.ToList());
        }

        /// <summary>
        ///      menuAddtoFav_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuAddtoFav_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.repositoryItemComboBox.Items.Add(this.txtwebAddress.EditValue);
        }

        /// <summary>
        ///      menuManageBookmarks_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuManageBookmarks_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ClearMainPanel();

            var frm = new AddModifyBookmarkForm
            {
                TopLevel = false
            };
            this.AddControlToMainPanel(frm);
            frm.Show();
        }

        #endregion Bookmarks

        #region MainPanel

        /// <summary>
        ///      AddControlToMainPanel 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contol"></param>
        private void AddControlToMainPanel<T>(T contol)
            where T : Control, new()
        {
            this.ClearMainPanel();

            contol.Visible = true;
            contol.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(contol);
        }

        /// <summary>
        ///      ClearMainPanel 
        /// </summary>
        private void ClearMainPanel()
        {
            foreach (Control ctl in this.mainPanel.Controls)
            {
                ctl.Visible = false;
                this.mainPanel.Controls.Remove(ctl);
            }
        }

        /// <summary>
        ///      menuShowPriceList_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuShowPriceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControlToMainPanel(this.webBrowser);
        }

        /// <summary>
        ///      ribbon_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void ribbon_Click(object sender, EventArgs e)
        {
            var selectedRibbon = (DevExpress.XtraBars.Ribbon.RibbonControl)sender;

            var selectedPage = selectedRibbon.SelectedPage;

            if (selectedPage.Text.Equals("Live Pricing", StringComparison.CurrentCultureIgnoreCase))
            {
                this.AddControlToMainPanel(this.webBrowser);
            }
            else if (selectedPage.Text.Equals("Mining Servers", StringComparison.CurrentCultureIgnoreCase))
            {
                this.AddControlToMainPanel(this.gridControlServer);

                this.FillServer();
            }
        }

        #endregion MainPanel

        #region Mining Servers

        /// <summary>
        ///      FillServer 
        /// </summary>
        private void FillServer()
        {
            this.gridControlServer.DataSource = null;
            var RepositoryFactory = new MinnerDataFactory(new MiningDbContext());
            this.gridControlServer.DataSource = RepositoryFactory.ServerRepository.GetAll();

            foreach (GridColumn col in this.gridViewServer.Columns)
            {
                if (col.Name.Contains("ID") || col.Name.Contains("Id"))
                    col.VisibleIndex = -1;
                if (col.Name.Contains("Region") || col.Name.Contains("Miner"))
                    col.VisibleIndex = -1;
                col.OptionsColumn.AllowEdit = false;
                col.BestFit();
            }
        }

        /// <summary>
        ///      GetSelectedRowID 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private object GetSelectedRowID(string name)
        {
            return this.gridViewServer.GetFocusedRowCellValue(name);
        }

        /// <summary>
        ///      GetSelectedRowID 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private MiningServer GetSelectedDataRow()
        {
            return this.gridViewServer.GetFocusedRow() as MiningServer;
        }


        /// <summary>
        ///      GridViewServer_DoubleClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void GridViewServer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.OpenUpdateDialog();
            }
            catch (Exception ex)
            {
                MessageDialog.ShowErrorMessageBox(ex);
            }
            finally
            {
                this.FillServer();
            }
        }

        /// <summary>
        ///      menuCreateServer_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuCreateServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.OpenNewDialog();
            }
            catch (Exception ex)
            {
                MessageDialog.ShowErrorMessageBox(ex);
            }
            finally
            {
                this.FillServer();
            }
        }

        /// <summary>
        ///OpenNewDialog 
        /// </summary>
        private void OpenNewDialog()
        {
            using (var addModifyForm = new AddModifyMiningServer())
            {
                addModifyForm.ShowDialog();
            }
        }

        /// <summary>
        ///      OpenUpdateDialog 
        /// </summary>
        private void OpenUpdateDialog()
        {
            using (var addModifyForm = new AddModifyMiningServer(new Guid(this.GetSelectedRowID("ServerID").ToString())))
            {
                addModifyForm.ShowDialog();
            }
        }

        /// <summary>
        /// menuDeleteServer_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDeleteServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                OnDeleteServer();
            }
            catch (Exception ex)
            {
                MessageDialog.ShowErrorMessageBox(ex);
            }
            finally
            {
                this.FillServer();
            }
        }

        /// <summary>
        /// OnDeleteServer
        /// </summary>
        private void OnDeleteServer()
        {
            var selectedDataRow = this.GetSelectedDataRow();
            var dialogres = MessageBox.Show(null, @"Are you sure you want to delete selected server ?", @"Delete Server", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogres == DialogResult.Yes)
            {
                try
                {
                    SqlDirect.TryToDelete("MiningServers", "ServerID", selectedDataRow.ServerID);
                }
                catch (Exception exception)
                {
                    MessageDialog.ShowErrorMessageBox(exception);

                }
            }
        }

        #endregion Mining Servers

        #region Private Methods

        private void menuUpdateServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.OpenUpdateDialog();
            }
            catch (Exception exception)
            {
                MessageDialog.ShowErrorMessageBox(exception);
            }
            finally
            {
                this.FillServer();
            }
        }

        #endregion Private Methods
    }
}