using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace WindowsFrom_Test.Forms
{
    using CozmicMinner.Classes;

    public partial class MiningDashboardPanel : DevExpress.DashboardCommon.Dashboard
    {
        public MiningDashboardPanel()
        {
            InitializeComponent();


            var data  = ApiQuery.GetBlocksHistory();
            SetBlocksData(data);
        }

        public void SetBlocksData(List<Blocks> data)
        {
            IDashboardDataSource dt = new DashboardObjectDataSource(data);
            this.BlockChart.DataSource = dt;
           
        }
    }
}
