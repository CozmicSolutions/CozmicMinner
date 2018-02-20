namespace WindowsFrom_Test.Forms
{
    partial class MiningDashboardPanel
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
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.ChartPane chartPane3 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.BlockChart = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.gaugeDashboardItem1 = new DevExpress.DashboardCommon.GaugeDashboardItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.BlockChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // BlockChart
            // 
            this.BlockChart.AxisX.TitleVisible = false;
            this.BlockChart.ComponentName = "BlockChart";
            this.BlockChart.DataItemRepository.Clear();
            this.BlockChart.InteractivityOptions.IgnoreMasterFilters = false;
            this.BlockChart.Name = "BlocksChart";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            chartPane2.Name = "Pane 2";
            chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.TitleVisible = true;
            chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            this.BlockChart.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1,
            chartPane2});
            this.BlockChart.ShowCaption = true;
            // 
            // gaugeDashboardItem1
            // 
            this.gaugeDashboardItem1.ComponentName = "gaugeDashboardItem1";
            this.gaugeDashboardItem1.DataItemRepository.Clear();
            this.gaugeDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gaugeDashboardItem1.Name = "Gauges 1";
            this.gaugeDashboardItem1.ShowCaption = true;
            // 
            // chartDashboardItem1
            // 
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane3.Name = "Pane 1";
            chartPane3.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.PrimaryAxisY.ShowGridLines = true;
            chartPane3.PrimaryAxisY.TitleVisible = true;
            chartPane3.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.SecondaryAxisY.ShowGridLines = false;
            chartPane3.SecondaryAxisY.TitleVisible = true;
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane3});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // pieDashboardItem1
            // 
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure1.Name = "A";
            measure2.Name = "B";
            dimension1.Name = "S1";
            dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            dimension2.Name = "S2";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem1");
            this.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2");
            this.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem3");
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Pies 1";
            this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.ShowPieCaptions = false;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            // 
            // MiningDashboardPanel
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gaugeDashboardItem1,
            this.BlockChart,
            this.chartDashboardItem1,
            this.pieDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem1.Weight = 24.890190336749633D;
            dashboardLayoutItem2.DashboardItem = this.BlockChart;
            dashboardLayoutItem2.Weight = 25.036603221083457D;
            dashboardLayoutItem3.DashboardItem = this.gaugeDashboardItem1;
            dashboardLayoutItem3.Weight = 50D;
            dashboardLayoutItem4.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem4.Weight = 50D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 50.073206442166914D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2,
            dashboardLayoutGroup2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.BlockChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.GaugeDashboardItem gaugeDashboardItem1;
        private DevExpress.DashboardCommon.ChartDashboardItem BlockChart;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
    }
}
