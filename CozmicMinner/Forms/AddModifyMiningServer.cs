using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CozmicMinner.Forms
{
    using MinnerDataAccess;

    using Telerik.WinControls;
    using Telerik.WinControls.UI;

    public enum FormMode
    {
        Display = 0 ,
        Create = 1 ,
        Update = 2,
    }
    public partial class AddModifyMiningServer : XtraForm
    {
        #region Private Fields
        FormMode Mode = FormMode.Display;

        private MiningDbContext DataBase = new MiningDbContext();

        private MiningServer miningServer = null;

        private MinnerDataFactory RepositoryFactory = null;

        private ServerRegion miningRegion = null;

        private MinerType miningType = null;

        private Guid Serverid = Guid.Empty;
        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// AddModifyServerForm
        /// </summary>
        /// <param name="serverID"></param>
        public AddModifyMiningServer()
        {
            this.InitializeComponent();

            this.RepositoryFactory = new MinnerDataFactory(this.DataBase);
            this.Mode = FormMode.Create;
            this.FillMinnerType();
            this.FillMinnerRegion();
            this.InitializeEvents();

        }

        /// <summary>
        /// AddModifyServerForm
        /// </summary>
        /// <param name="serverID"></param>
        public AddModifyMiningServer(Guid serverID)
        {
            this.InitializeComponent();
            this.Mode = FormMode.Update;
            this.Serverid = serverID;
            this.RepositoryFactory = new MinnerDataFactory(this.DataBase);
            this.FillMinnerType();
            this.FillMinnerRegion();
            this.InitializeEvents();
            this.SetInitialValues(serverID);
        }

        /// <summary>
        /// InitializeEvents
        /// </summary>
        private void InitializeEvents()
        {
            this.txtServerPort.TextChanged += this.TextChanged;
            this.txtServerName.TextChanged += this.TextChanged;
            this.txtServerDesc.TextChanged += this.TextChanged;
            this.drpMinnerType.SelectedIndexChanged += this.TextChanged;
            this.drpServerRegion.SelectedIndexChanged += this.TextChanged;
            this.txtServerName.Leave += this.TxtServerName_Leave;
        }

        /// <summary>
        /// SetValues
        /// </summary>
        /// <param name="serverid"></param>
        private void SetInitialValues(Guid serverid)
        {
            this.miningServer = this.RepositoryFactory.ServerRepository.Find(x => x.ServerID == serverid);
            this.miningRegion = this.miningServer.ServerRegion;
            this.miningType = this.miningServer.MinerType;
            this.txtServerName.Text = this.miningServer.ServerName;
            this.txtServerDesc.Text = this.miningServer.ServerDescription;
            this.txtServerAddress.Text = this.miningServer.ServerAddress;
            this.txtServerPort.Text = this.miningServer.ServerPort.Value.ToString();
            this.drpMinnerType.Items.Add(new RadListDataItem(this.miningType.MinerDescription, this.miningType));
            this.drpMinnerType.Items.Add(new RadListDataItem(this.miningType.MinerDescription, this.miningType));

        }

        /// <summary>
        /// SetValues
        /// </summary>
        /// <param name="serverid"></param>
        private MiningServer UpdateServer()
        {
            if (this.miningServer.IsNull())
                this.miningServer = this.RepositoryFactory.ServerRepository.Find(x => x.ServerID == this.Serverid);

            this.miningRegion = this.miningServer.ServerRegion;
            this.miningType = this.miningServer.MinerType;

            this.miningServer.ServerName = this.txtServerName.Text;
            this.miningServer.ServerDescription = this.txtServerDesc.Text;
            this.miningServer.ServerAddress = this.txtServerAddress.Text;
            this.miningServer.ServerPort = int.Parse(this.txtServerPort.Text);
            return this.miningServer;


        }

        /// <summary>
        /// CheckNameAlreadyExist
        /// </summary>
        /// <returns></returns>
        private bool CheckNameAlreadyExist()
        {
            if (this.Mode == FormMode.Update) return false;

            var data = this.RepositoryFactory.ServerRepository.Find(x => x.ServerName.Equals(this.txtServerName.Text));

            if (data != null)
            {
                this.errorProvider.SetError(this.txtServerName, "Server already exist.");
                return true;
            }

            return false;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// FillMinnerRegion
        /// </summary>
        public void FillMinnerRegion()
        {
            this.drpServerRegion.Items.Clear();
            var minnerTypeCollection = this.RepositoryFactory.RegionRepository.GetAll();
            foreach (var data in minnerTypeCollection)
            {
                this.drpServerRegion.Items.Add(new RadListDataItem(data.RegionName, data));
            }

            this.drpServerRegion.SelectedIndex = 0;
            this.drpServerRegion.DropDownStyle = RadDropDownStyle.DropDownList;
        }

        /// <summary>
        /// FillMinnerType
        /// </summary>
        public void FillMinnerType()
        {
            this.drpMinnerType.Items.Clear();
            var minnerTypeCollection = this.RepositoryFactory.MinerTypeRepository.GetAll();
            foreach (var data in minnerTypeCollection)
            {
                this.drpMinnerType.Items.Add(new RadListDataItem(data.MinerDescription, data));
            }

            this.drpMinnerType.SelectedIndex = 0;
            this.drpMinnerType.DropDownStyle = RadDropDownStyle.DropDownList;
        }

        /// <summary>
        /// PopulateAddress
        /// </summary>
        /// <returns></returns>
        public string PopulateAddress()
        {
            if (this.drpServerRegion.SelectedIndex < 0) return string.Empty;
            var regionTypeId = this.drpServerRegion.GetValue<ServerRegion>().RegionTypeID;
            if (regionTypeId != null)
            {
                Regions reg = (Regions)regionTypeId;

                // ethminer.exe
                var minerTypeId = this.drpMinnerType.GetValue<MinerType>().MinerTypeID;
                if (minerTypeId != null)
                {
                    Types type = (Types)minerTypeId;

                    return ServerAddressGenerator.PopulateAddress(reg, int.Parse(this.txtServerPort.Text));
                }
            }

            return string.Empty;
        }

        /// <summary>
        ///      Save 
        /// </summary>
        public void Save()
        {
            if (this.Mode == FormMode.Create)
            {
                this.miningServer = this.CreateServer();
                this.RepositoryFactory.ServerRepository.Add(this.miningServer);
            }
            else if (this.Mode == FormMode.Update)
            {
                this.miningServer = this.UpdateServer();
                this.RepositoryFactory.ServerRepository.Update(this.miningServer);
            }



        }

        /// <summary>
        /// CreateServer
        /// </summary>
        /// <returns></returns>
        MiningServer CreateServer()
        {
            if (this.miningServer.IsNull()) this.miningServer = new MiningServer();
            var minnerID = this.drpMinnerType.GetValue<MinerType>().MinerID;
            this.miningServer.MinerType = this.RepositoryFactory.MinerTypeRepository.Find(
                x => x.MinerID == minnerID);
            var regionId = this.drpServerRegion.GetValue<ServerRegion>().RegionID;
            this.miningServer.ServerRegion = this.RepositoryFactory.RegionRepository.Find(x => x.RegionID == regionId);
            this.miningServer.ServerID = Guid.NewGuid();
            this.miningServer.RegionID = this.miningServer.ServerRegion.RegionID;
            this.miningServer.MinerID = this.miningServer.MinerType.MinerID;
            this.miningServer.ServerAddress = this.txtServerAddress.Text;
            this.miningServer.ServerName = this.txtServerName.Text;
            this.miningServer.ServerDescription = this.txtServerDesc.Text;
            this.miningServer.ServerCreateDate = DateTime.Now;
            this.miningServer.ServerLastUpdate = DateTime.Now;
            this.miningServer.ServerStatus = 1;
            this.miningServer.ServerPort = int.Parse(this.txtServerPort.Text);

            return this.miningServer;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// btnCancel_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.btnCancel.Text != @"Close")
            {
                if (MessageDialog.ShowYesNoMessageBox(TextStatic.CancelText, "Cancel", MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// btnSave_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.CheckNameAlreadyExist()) return;
            if (MessageDialog.ShowYesNoMessageBox(TextStatic.SaveText, @"Save", MessageBoxIcon.Question)
                == DialogResult.No) return;
            try
            {
                this.Save();
                this.btnSave.Enabled = false;
                this.btnCancel.Text = @"Close";
            }
            catch (Exception exception)
            {
                MessageDialog.ShowErrorMessageBox(exception);

            }

        }

        /// <summary>
        /// TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void TextChanged(object sender, EventArgs eventArgs)
        {
            this.txtServerAddress.Text = this.PopulateAddress();
        }

        /// <summary>
        /// TxtServerName_Leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtServerName_Leave(object sender, EventArgs e)
        {
            if (this.btnCancel.Text == @"Close") return;
            if (string.IsNullOrEmpty(this.txtServerName.Text)) return;
            this.CheckNameAlreadyExist();
        }

        /// <summary>
        /// txtServerName_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            this.TextChanged(sender, e);
        }


        #endregion Private Methods
    }
}