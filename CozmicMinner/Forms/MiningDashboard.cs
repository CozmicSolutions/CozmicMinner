using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CozmicMinner.Forms
{
    using CozmicMinner.Classes;
    using CozmicMinner.CustomControls;

    using CozmicMinnerSetup;

    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Grid;

    using MinnerDataAccess;

    public partial class MiningDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        WebBrowserControl webBrowser = new WebBrowserControl();
        GridListControl gridList = new GridListControl();
        CommandPromptControl cmdControl = new CommandPromptControl();
        ReportPageControlcs reportControl = new ReportPageControlcs();
        public MiningDashboard()
        {
            InitializeComponent();
        }

        #region Helper
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
        /// SetGridAppearance
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="columnToHide"></param>
        /// <param name="allowEdit"></param>
        void SetGridAppearance(List<string> columnToHide, bool allowEdit)
        {
            this.gridList.HideGridColumns(columnToHide, allowEdit);
            //foreach (GridColumn col in gv.Columns)
            //{
            //    if (columnToHide.Contains(col.FieldName)) col.VisibleIndex = -1;
            //    //if (col.Name.Contains("ID") || col.Name.Contains("Id"))
            //    //    col.VisibleIndex = -1;
            //    //if (col.Name.Contains("Region") || col.Name.Contains("Miner"))
            //    //    col.VisibleIndex = -1;
            //    col.OptionsColumn.AllowEdit = allowEdit;
            //    col.BestFit();
            //}
        }

        /// <summary>
        ///      GetSelectedRowID 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private object GetSelectedRowID(string name)
        {
            return gridList.View.GetFocusedRowCellValue(name);
        }

        /// <summary>
        ///      GetSelectedRowID 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private MiningServer GetSelectedDataRow()
        {
            return this.gridList.View.GetFocusedRow() as MiningServer;
        }

        #endregion Helper

        /// <summary>
        /// ribbon_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbon_Click(object sender, EventArgs e)
        {
            var selectedRibbon = (DevExpress.XtraBars.Ribbon.RibbonControl)sender;

            var selectedPage = selectedRibbon.SelectedPage;

            if (selectedPage.Text.Equals("Live Report", StringComparison.CurrentCultureIgnoreCase))
            {
                this.AddControlToMainPanel(this.webBrowser);
            }
            else if (selectedPage.Text.Equals("Mining Servers", StringComparison.CurrentCultureIgnoreCase))
            {
                this.AddControlToMainPanel(this.gridList);

                this.OnShowServer();
            }
        }

        /// <summary>
        /// menuLiveReport_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLiveReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControlToMainPanel(this.webBrowser);
            this.webBrowser.Navigate("https://coincap.io/");
        }

        #region Mining Servers

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
        /// OnDeleteServer
        /// </summary>
        private void OnDeleteServer()
        {
            var selectedDataRow = this.GetSelectedDataRow();
            var dialogResult = MessageBox.Show(null, @"Are you sure you want to delete selected server ?", @"Delete Server", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
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

        /// <summary>
        /// ShowServerList
        /// </summary>
        private void OnShowServer()
        {
            var RepositoryFactory = new MinnerDataFactory(new MiningDbContext());
            this.gridList.FillGrid<MiningServer>(RepositoryFactory.ServerRepository.GetAll().ToList());
            this.SetGridAppearance(new List<string>() { @"ServerID", @"RegionID", @"MinerID" ,
                    @"ServerStatus",@"ServerCreateDate",@"ServerRegion",@"MinerType",@"ServerLastUpdate"}, false);

        }
       
        /// <summary>
        /// menuServerList_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuServerList_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.OnShowServer(); 
            }
            catch (Exception ex)
            {
                MessageDialog.ShowErrorMessageBox(ex);
            }
          
        }

        /// <summary>
        /// menuEditServer_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditServer_ItemClick(object sender, ItemClickEventArgs e)
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
                this.OnShowServer();
            }
        }

        /// <summary>
        /// menuAddNewServer_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAddNewServer_ItemClick(object sender, ItemClickEventArgs e)
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
                this.OnShowServer();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDeleteServer_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.OnDeleteServer();
            }
            catch (Exception ex)
            {
                MessageDialog.ShowErrorMessageBox(ex);
            }
            finally
            {
                this.OnShowServer();
            }
        }


        #endregion Mining Servers

        #region Reset

        /// <summary>
        /// menuResetServers_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuResetServers_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.OnResetServers();
            }
            catch (Exception exception)
            {
                MessageDialog.ShowErrorMessageBox(exception);
            }
            finally
            {
                this.OnShowServer();
            }
        }

        /// <summary>
        /// OnResetServers
        /// </summary>
        void OnResetServers()
        {
            var dialogResult = MessageBox.Show(null, @"Are you sure you want to reset all servers ?", @"Reset Server", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                if (ResetTableData.ResetServerTable())
                {
                    MessageBox.Show(@"All servers has been reseted to the default.", "Reset Servers");
                }
            }
        }


        #endregion

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
         
            this.AddControlToMainPanel(this.reportControl);
            this.reportControl.CreateReport(@"Credit", ApiQuery.GetCredits());
            this.reportControl.CreateReport(@"Blocks History", ApiQuery.GetBlocksHistory());
            this.reportControl.CreateReport($@"Network Stats", ApiQuery.GetNetworkStats());
            this.reportControl.CreateReport($@"Server HashRate Stats", ApiQuery.GetServerHashRateStats());

            //this.cmdControl.ExecuteAsync(@"X:\Development Projects\CozmicMinner\CozmicMinner\BatchFiles\Test.bat");

            //this.cmdControl.ExecuteAsync(@"dir");
        }
    }
}