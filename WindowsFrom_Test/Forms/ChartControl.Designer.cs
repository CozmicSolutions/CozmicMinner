namespace WindowsFrom_Test.Forms
{
    partial class ChartControl
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(122D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(22D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(124D))}, 2);
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("AA", new object[] {
            ((object)(120D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("CC", new object[] {
            ((object)(19D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("DD", new object[] {
            ((object)(78D))}, 2);
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView3 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ChartCustomControl = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.hashrateStatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCustomControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashrateStatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ChartCustomControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1054, 504);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ChartCustomControl
            // 
            this.ChartCustomControl.Legend.Name = "Default Legend";
            this.ChartCustomControl.Location = new System.Drawing.Point(24, 42);
            this.ChartCustomControl.Name = "ChartCustomControl";
            this.ChartCustomControl.PaletteName = "Flow";
            series1.DataSource = this.hashrateStatsBindingSource;
            series1.Name = "Series1";
            seriesPoint1.ColorSerializable = "#0080FF";
            seriesPoint2.ColorSerializable = "Red";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3});
            series1.View = doughnutSeriesView1;
            series2.DataSource = this.blocksBindingSource;
            series2.Name = "Series2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint4,
            seriesPoint5,
            seriesPoint6});
            series2.View = doughnutSeriesView2;
            this.ChartCustomControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.ChartCustomControl.SeriesTemplate.View = doughnutSeriesView3;
            this.ChartCustomControl.Size = new System.Drawing.Size(1006, 438);
            this.ChartCustomControl.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1054, 504);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1034, 484);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ChartCustomControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1010, 442);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // hashrateStatsBindingSource
            // 
            this.hashrateStatsBindingSource.DataSource = typeof(CozmicMinner.Classes.HashrateStats);
            // 
            // blocksBindingSource
            // 
            this.blocksBindingSource.DataSource = typeof(CozmicMinner.Classes.Blocks);
            // 
            // ChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChartControl";
            this.Size = new System.Drawing.Size(1054, 504);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCustomControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashrateStatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraCharts.ChartControl ChartCustomControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource hashrateStatsBindingSource;
        private System.Windows.Forms.BindingSource blocksBindingSource;
    }
}
