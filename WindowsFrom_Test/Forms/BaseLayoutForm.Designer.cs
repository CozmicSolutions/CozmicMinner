namespace WindowsFrom_Test.Forms
{
    partial class BaseLayoutForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel2 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.ucSalesDashboardlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartSalesbySecor = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLabelControl1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChartSalesbySecor = new DevExpress.XtraLayout.LayoutControlItem();
            this.blocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucSalesDashboardlayoutControl1ConvertedLayout)).BeginInit();
            this.ucSalesDashboardlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesbySecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartSalesbySecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ucSalesDashboardlayoutControl1ConvertedLayout
            // 
            this.ucSalesDashboardlayoutControl1ConvertedLayout.AllowCustomization = false;
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Controls.Add(this.labelControl1);
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Controls.Add(this.chartSalesbySecor);
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Name = "ucSalesDashboardlayoutControl1ConvertedLayout";
            this.ucSalesDashboardlayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(269, 162, 650, 400);
            this.ucSalesDashboardlayoutControl1ConvertedLayout.OptionsView.EnableIndentsInGroupsWithoutBorders = true;
            this.ucSalesDashboardlayoutControl1ConvertedLayout.OptionsView.UseParentAutoScaleFactor = true;
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ucSalesDashboardlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(1144, 690);
            this.ucSalesDashboardlayoutControl1ConvertedLayout.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(1116, 30);
            this.labelControl1.StyleController = this.ucSalesDashboardlayoutControl1ConvertedLayout;
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "SALES BY SECTOR ";
            // 
            // chartSalesbySecor
            // 
            this.chartSalesbySecor.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartSalesbySecor.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartSalesbySecor.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.chartSalesbySecor.Legend.EquallySpacedItems = false;
            this.chartSalesbySecor.Legend.MarkerSize = new System.Drawing.Size(18, 18);
            this.chartSalesbySecor.Legend.Name = "Default Legend";
            this.chartSalesbySecor.Legend.TextOffset = 8;
            this.chartSalesbySecor.Location = new System.Drawing.Point(14, 48);
            this.chartSalesbySecor.Name = "chartSalesbySecor";
            this.chartSalesbySecor.Padding.Right = 0;
            series1.ArgumentDataMember = "difficulty";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.DataSource = this.blocksBindingSource;
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesLabel1.TextPattern = "{V:F0}";
            series1.Label = doughnutSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            doughnutSeriesView1.HoleRadiusPercent = 55;
            series1.View = doughnutSeriesView1;
            this.chartSalesbySecor.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            doughnutSeriesLabel2.TextPattern = "{VP:G2}";
            this.chartSalesbySecor.SeriesTemplate.Label = doughnutSeriesLabel2;
            this.chartSalesbySecor.SeriesTemplate.View = doughnutSeriesView2;
            this.chartSalesbySecor.Size = new System.Drawing.Size(1116, 628);
            this.chartSalesbySecor.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1144, 690);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLabelControl1,
            this.lciChartSalesbySecor});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1144, 690);
            // 
            // lciLabelControl1
            // 
            this.lciLabelControl1.Control = this.labelControl1;
            this.lciLabelControl1.Location = new System.Drawing.Point(0, 0);
            this.lciLabelControl1.Name = "lciLabelControl1";
            this.lciLabelControl1.Size = new System.Drawing.Size(1120, 34);
            this.lciLabelControl1.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelControl1.TextVisible = false;
            // 
            // lciChartSalesbySecor
            // 
            this.lciChartSalesbySecor.Control = this.chartSalesbySecor;
            this.lciChartSalesbySecor.Location = new System.Drawing.Point(0, 34);
            this.lciChartSalesbySecor.MinSize = new System.Drawing.Size(104, 24);
            this.lciChartSalesbySecor.Name = "lciChartSalesbySecor";
            this.lciChartSalesbySecor.OptionsTableLayoutItem.RowIndex = 1;
            this.lciChartSalesbySecor.Size = new System.Drawing.Size(1120, 632);
            this.lciChartSalesbySecor.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciChartSalesbySecor.Text = "SALES BY SECTOR ";
            this.lciChartSalesbySecor.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciChartSalesbySecor.TextSize = new System.Drawing.Size(0, 0);
            this.lciChartSalesbySecor.TextVisible = false;
            // 
            // blocksBindingSource
            // 
            this.blocksBindingSource.DataSource = typeof(CozmicMinner.Classes.Blocks);
            // 
            // BaseLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 690);
            this.Controls.Add(this.ucSalesDashboardlayoutControl1ConvertedLayout);
            this.Name = "BaseLayoutForm";
            this.Text = "BaseLayoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.ucSalesDashboardlayoutControl1ConvertedLayout)).EndInit();
            this.ucSalesDashboardlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesbySecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartSalesbySecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl ucSalesDashboardlayoutControl1ConvertedLayout;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartSalesbySecor;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lciLabelControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciChartSalesbySecor;
        private System.Windows.Forms.BindingSource blocksBindingSource;
    }
}