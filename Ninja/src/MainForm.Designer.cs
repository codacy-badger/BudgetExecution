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
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem();
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
            this.DataTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.SummaryTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.MainChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.RegionSummaryButton = new System.Windows.Forms.Button();
            this.DataButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.DocumentButton = new System.Windows.Forms.Button();
            this.DivisionSummaryButton = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataTile
            // 
            this.DataTile.BackColor = System.Drawing.Color.Black;
            textItem1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem1.HubTile = this.DataTile;
            textItem1.Text = "Database | Budgets | Transfers";
            this.DataTile.Banner = textItem1;
            this.DataTile.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DataTile.BannerHeight = 25;
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.DataTile;
            this.DataTile.Body = textItem2;
            this.DataTile.EnableSelectionMarker = false;
            this.DataTile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem3.HubTile = this.DataTile;
            textItem3.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataTile.Footer = textItem3;
            this.DataTile.HoveredBorderColor = System.Drawing.Color.LightSteelBlue;
            this.DataTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("DataTile.ImageSource")));
            this.DataTile.Location = new System.Drawing.Point(980, 480);
            this.DataTile.Margin = new System.Windows.Forms.Padding(1);
            this.DataTile.MinimumSize = new System.Drawing.Size(70, 66);
            this.DataTile.Name = "DataTile";
            this.DataTile.PulseScale = 2;
            this.DataTile.ShowBanner = true;
            this.DataTile.Size = new System.Drawing.Size(531, 171);
            this.DataTile.TabIndex = 20;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem4.HubTile = this.DataTile;
            this.DataTile.Title = textItem4;
            this.DataTile.Click += new System.EventHandler(this.DataTile_OnClick);
            // 
            // SummaryTile
            // 
            this.SummaryTile.BackColor = System.Drawing.Color.Black;
            textItem5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem5.HubTile = this.SummaryTile;
            textItem5.Text = "Summary | Status of Funds";
            this.SummaryTile.Banner = textItem5;
            this.SummaryTile.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SummaryTile.BannerHeight = 25;
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.SummaryTile;
            this.SummaryTile.Body = textItem6;
            this.SummaryTile.EnableSelectionMarker = false;
            this.SummaryTile.EnableTileSlideEffect = false;
            this.SummaryTile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem7.HubTile = this.SummaryTile;
            this.SummaryTile.Footer = textItem7;
            this.SummaryTile.HoveredBorderColor = System.Drawing.Color.LightSteelBlue;
            this.SummaryTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("SummaryTile.ImageSource")));
            this.SummaryTile.Location = new System.Drawing.Point(981, 124);
            this.SummaryTile.Margin = new System.Windows.Forms.Padding(1);
            this.SummaryTile.MinimumSize = new System.Drawing.Size(70, 66);
            this.SummaryTile.Name = "SummaryTile";
            this.SummaryTile.PulseDuration = 2;
            this.SummaryTile.PulseScale = 4;
            this.SummaryTile.ShowBanner = true;
            this.SummaryTile.ShowRotateTileBanner = true;
            this.SummaryTile.Size = new System.Drawing.Size(531, 169);
            this.SummaryTile.TabIndex = 23;
            textItem8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem8.HubTile = this.SummaryTile;
            this.SummaryTile.Title = textItem8;
            this.SummaryTile.Click += new System.EventHandler(this.SummaryTile_OnClick);
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
            this.MainChart.Legend.Location = new System.Drawing.Point(7, 6);
            this.MainChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.MainChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.MainChart.Legend.Visible = false;
            this.MainChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.MainChart.Localize = null;
            this.MainChart.Location = new System.Drawing.Point(9, 161);
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
            this.MainChart.Size = new System.Drawing.Size(934, 665);
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
            // RegionSummaryButton
            // 
            this.RegionSummaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionSummaryButton.BackColor = System.Drawing.Color.Black;
            this.RegionSummaryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegionSummaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.RegionSummaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.RegionSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegionSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionSummaryButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RegionSummaryButton.Image = ((System.Drawing.Image)(resources.GetObject("RegionSummaryButton.Image")));
            this.RegionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RegionSummaryButton.Location = new System.Drawing.Point(980, 296);
            this.RegionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegionSummaryButton.Name = "RegionSummaryButton";
            this.RegionSummaryButton.Size = new System.Drawing.Size(171, 102);
            this.RegionSummaryButton.TabIndex = 53;
            this.RegionSummaryButton.Text = "\r\n\r\nRegion Summary";
            this.RegionSummaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegionSummaryButton.UseCompatibleTextRendering = true;
            this.RegionSummaryButton.UseVisualStyleBackColor = false;
            // 
            // DataButton
            // 
            this.DataButton.BackColor = System.Drawing.Color.Black;
            this.DataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DataButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.DataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DataButton.Image = ((System.Drawing.Image)(resources.GetObject("DataButton.Image")));
            this.DataButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DataButton.Location = new System.Drawing.Point(981, 665);
            this.DataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(170, 104);
            this.DataButton.TabIndex = 57;
            this.DataButton.Text = "\r\nData Server";
            this.DataButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataButton.UseVisualStyleBackColor = false;
            this.DataButton.Click += new System.EventHandler(this.DataButton_OnClick);
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.Black;
            this.TransferButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransferButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.TransferButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TransferButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferButton.Image")));
            this.TransferButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TransferButton.Location = new System.Drawing.Point(1342, 665);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(170, 104);
            this.TransferButton.TabIndex = 56;
            this.TransferButton.Text = "\r\nTranfers";
            this.TransferButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TransferButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // DocumentButton
            // 
            this.DocumentButton.BackColor = System.Drawing.Color.Black;
            this.DocumentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DocumentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.DocumentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DocumentButton.Image = ((System.Drawing.Image)(resources.GetObject("DocumentButton.Image")));
            this.DocumentButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DocumentButton.Location = new System.Drawing.Point(1166, 667);
            this.DocumentButton.Margin = new System.Windows.Forms.Padding(2);
            this.DocumentButton.Name = "DocumentButton";
            this.DocumentButton.Size = new System.Drawing.Size(170, 102);
            this.DocumentButton.TabIndex = 66;
            this.DocumentButton.Text = "\r\n\r\nBudget Documents";
            this.DocumentButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DocumentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DocumentButton.UseVisualStyleBackColor = false;
            this.DocumentButton.Click += new System.EventHandler(this.DocumentButton_OnClick);
            // 
            // DivisionSummaryButton
            // 
            this.DivisionSummaryButton.BackColor = System.Drawing.Color.Black;
            this.DivisionSummaryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DivisionSummaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionSummaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DivisionSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionSummaryButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionSummaryButton.Image = ((System.Drawing.Image)(resources.GetObject("DivisionSummaryButton.Image")));
            this.DivisionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DivisionSummaryButton.Location = new System.Drawing.Point(1166, 296);
            this.DivisionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionSummaryButton.Name = "DivisionSummaryButton";
            this.DivisionSummaryButton.Size = new System.Drawing.Size(170, 102);
            this.DivisionSummaryButton.TabIndex = 54;
            this.DivisionSummaryButton.Text = "\r\n\r\nDivision Summary";
            this.DivisionSummaryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DivisionSummaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionSummaryButton.UseVisualStyleBackColor = false;
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.BackColor = System.Drawing.Color.Black;
            this.DivisionBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DivisionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionBtn.Image = ((System.Drawing.Image)(resources.GetObject("DivisionBtn.Image")));
            this.DivisionBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DivisionBtn.Location = new System.Drawing.Point(1353, 296);
            this.DivisionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(165, 102);
            this.DivisionBtn.TabIndex = 55;
            this.DivisionBtn.Text = "\r\n\r\nDivision Allocations";
            this.DivisionBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DivisionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1588, 953);
            this.Controls.Add(this.DocumentButton);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.DataTile);
            this.Controls.Add(this.DivisionSummaryButton);
            this.Controls.Add(this.SummaryTile);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.DataButton);
            this.Controls.Add(this.RegionSummaryButton);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected Syncfusion.Windows.Forms.Chart.ChartControl MainChart;
        private Syncfusion.Windows.Forms.Tools.HubTile SummaryTile;
        private Syncfusion.Windows.Forms.Tools.HubTile DataTile;
        private System.Windows.Forms.Button RegionSummaryButton;
        private System.Windows.Forms.Button DataButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button DocumentButton;
        private System.Windows.Forms.Button DivisionSummaryButton;
        private System.Windows.Forms.Button DivisionBtn;
    }
}