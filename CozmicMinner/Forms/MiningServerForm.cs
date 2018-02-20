using System;
using DevExpress.XtraBars;

namespace CozmicMinner.Forms
{
    using DevExpress.XtraGrid.Columns;

    using MinnerDataAccess;

    public partial class MiningServerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Public Constructors

        public MiningServerForm()
        {
            InitializeComponent();
            this.gridViewServer.DoubleClick += GridViewServer_DoubleClick;
            FillServer();
        }

        #endregion Public Constructors

        #region Private Methods

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
        ///      menuCreate_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuCreate_ItemClick(object sender, ItemClickEventArgs e)
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
        ///      menuEdit_ItemClick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void menuEdit_ItemClick(object sender, ItemClickEventArgs e)
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
        ///      OpenNewDialog 
        /// </summary>
        private void OpenNewDialog()
        {
            var addModifyForm = new AddModifyMiningServer();
            addModifyForm.ShowDialog();
        }

        /// <summary>
        ///      OpenUpdateDialog 
        /// </summary>
        private void OpenUpdateDialog()
        {
            var addModifyForm = new AddModifyMiningServer(new Guid(GetSelectedRowID("ServerID").ToString()));
            addModifyForm.ShowDialog();
        }

        #endregion Private Methods
    }
}