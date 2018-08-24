using Ninja.Data.Forms;


namespace BudgetExecution
{
    partial class MainForm
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
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.hubTile2 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.MainChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            // 
            // hubTile2
            // 
            this.hubTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem1.HubTile = this.hubTile2;
            this.hubTile2.Banner = textItem1;
            this.hubTile2.BannerColor = System.Drawing.Color.Transparent;
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.hubTile2;
            this.hubTile2.Body = textItem2;
            this.hubTile2.EnableSelectionMarker = false;
            this.hubTile2.EnableTileSlideEffect = false;
            this.hubTile2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem3.HubTile = this.hubTile2;
            this.hubTile2.Footer = textItem3;
            this.hubTile2.ForeColor = System.Drawing.SystemColors.Info;
            this.hubTile2.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile2.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile2.ImageSource")));
            this.hubTile2.Location = new System.Drawing.Point(1530, 886);
            this.hubTile2.Margin = new System.Windows.Forms.Padding(2);
            this.hubTile2.MinimumSize = new System.Drawing.Size(70, 66);
            this.hubTile2.Name = "hubTile2";
            this.hubTile2.PulseScale = 4;
            this.hubTile2.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile2.ShowBanner = true;
            this.hubTile2.ShowBannerIcon = true;
            this.hubTile2.ShowRotateTileBanner = true;
            this.hubTile2.Size = new System.Drawing.Size(134, 66);
            this.hubTile2.SwitchRotateTileBannerVisibility = true;
            this.hubTile2.TabIndex = 73;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem4.HubTile = this.hubTile2;
            this.hubTile2.Title = textItem4;
            this.hubTile2.Click += new System.EventHandler(this.EnterTile_OnClick);
            // 
            // MainChart
            // 
            this.MainChart.AllowGradientPalette = true;
            this.MainChart.AllowUserEditStyles = true;
            this.MainChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.MainChart.ChartArea.AutoScale = true;
            this.MainChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.MainChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.MainChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.MainChart.ChartArea.CursorReDraw = false;
            this.MainChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.MainChart.ChartAreaShadow = true;
            this.MainChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.MainChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.MainChart.DataSourceName = "[none]";
            this.MainChart.Depth = 250F;
            this.MainChart.DisplayChartContextMenu = false;
            this.MainChart.DisplaySeriesContextMenu = false;
            this.MainChart.EnableMouseRotation = true;
            this.MainChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainChart.HighlightSymbol = true;
            this.MainChart.IsWindowLess = false;
            // 
            // 
            // 
            this.MainChart.Legend.Location = new System.Drawing.Point(8, 6);
            this.MainChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.MainChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.MainChart.Legend.Visible = false;
            this.MainChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.MainChart.Localize = null;
            this.MainChart.Location = new System.Drawing.Point(34, 100);
            this.MainChart.Margin = new System.Windows.Forms.Padding(0);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.MainChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.MainChart.PrimaryXAxis.Margin = true;
            this.MainChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.MainChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.MainChart.PrimaryYAxis.Margin = true;
            this.MainChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.MainChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.MainChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.MainChart.RealMode3D = true;
            this.MainChart.Rotation = 0.1F;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Points.Add(1D, ((double)(55D)));
            chartSeries1.Points.Add(2D, ((double)(70D)));
            chartSeries1.Points.Add(3D, ((double)(80D)));
            chartSeries1.Points.Add(4D, ((double)(65D)));
            chartSeries1.Points.Add(5D, ((double)(75D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries1.Style.DrawTextShape = false;
            chartSeries1.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Points.Add(1D, ((double)(70D)));
            chartSeries2.Points.Add(2D, ((double)(35D)));
            chartSeries2.Points.Add(3D, ((double)(65D)));
            chartSeries2.Points.Add(4D, ((double)(25D)));
            chartSeries2.Points.Add(5D, ((double)(50D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries2.Style.DrawTextShape = false;
            chartSeries2.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            this.MainChart.Series.Add(chartSeries1);
            this.MainChart.Series.Add(chartSeries2);
            this.MainChart.Series3D = true;
            this.MainChart.SeriesHighlight = true;
            this.MainChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.MainChart.Size = new System.Drawing.Size(1370, 707);
            this.MainChart.Spacing = 5F;
            this.MainChart.SpacingBetweenPoints = 5F;
            this.MainChart.Style3D = true;
            this.MainChart.TabIndex = 44;
            this.MainChart.Tilt = 5F;
            // 
            // 
            // 
            this.MainChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.MainChart.Title.Name = "Default";
            this.MainChart.ToolBar.EnableDefaultItems = false;
            this.MainChart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.MainChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.MainChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1702, 1017);
            this.Controls.Add(this.hubTile2);
            this.Controls.Add(this.MainChart);
            this.MaximumSize = new System.Drawing.Size(1714, 1064);
            this.MinimumSize = new System.Drawing.Size(1714, 1064);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected Syncfusion.Windows.Forms.Chart.ChartControl MainChart;
        private Syncfusion.Windows.Forms.Tools.HubTile hubTile2;
    }
}