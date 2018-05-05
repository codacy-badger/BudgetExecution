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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries3 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo3 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo2 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo4 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.DataTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.SummaryTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.MainChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DocumentButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.DataButton = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DivisionSummaryButton = new System.Windows.Forms.Button();
            this.RegionSummaryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTile
            // 
            this.DataTile.BackColor = System.Drawing.Color.Black;
            textItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem1.HubTile = this.DataTile;
            textItem1.Text = "Database | Budgets | Transfers";
            this.DataTile.Banner = textItem1;
            this.DataTile.BannerColor = System.Drawing.Color.Black;
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
            this.DataTile.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("DataTile.ImageSource")));
            this.DataTile.Location = new System.Drawing.Point(1, 1);
            this.DataTile.Margin = new System.Windows.Forms.Padding(1);
            this.DataTile.MinimumSize = new System.Drawing.Size(70, 66);
            this.DataTile.Name = "DataTile";
            this.DataTile.PulseScale = 2;
            this.DataTile.ShowBanner = true;
            this.DataTile.Size = new System.Drawing.Size(290, 246);
            this.DataTile.TabIndex = 20;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem4.HubTile = this.DataTile;
            this.DataTile.Title = textItem4;
            this.DataTile.Click += new System.EventHandler(this.DataTile_OnClick);
            // 
            // SummaryTile
            // 
            this.SummaryTile.BackColor = System.Drawing.Color.Black;
            textItem5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem5.HubTile = this.SummaryTile;
            textItem5.Text = "Summary | Status of Funds";
            this.SummaryTile.Banner = textItem5;
            this.SummaryTile.BannerColor = System.Drawing.Color.Black;
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
            this.SummaryTile.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.SummaryTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("SummaryTile.ImageSource")));
            this.SummaryTile.Location = new System.Drawing.Point(1, 1);
            this.SummaryTile.Margin = new System.Windows.Forms.Padding(1);
            this.SummaryTile.MinimumSize = new System.Drawing.Size(70, 66);
            this.SummaryTile.Name = "SummaryTile";
            this.SummaryTile.ShowBanner = true;
            this.SummaryTile.ShowRotateTileBanner = true;
            this.SummaryTile.Size = new System.Drawing.Size(291, 249);
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
            this.MainChart.Location = new System.Drawing.Point(9, 175);
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
            chartSeries3.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries3.Name = "Default0";
            chartSeries3.Points.Add(1D, ((double)(55D)));
            chartSeries3.Points.Add(2D, ((double)(70D)));
            chartSeries3.Points.Add(3D, ((double)(80D)));
            chartSeries3.Points.Add(4D, ((double)(65D)));
            chartSeries3.Points.Add(5D, ((double)(75D)));
            chartSeries3.Resolution = 0D;
            chartSeries3.StackingGroup = "Default Group";
            chartSeries3.Style.AltTagFormat = "";
            chartSeries3.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries3.Style.DrawTextShape = false;
            chartSeries3.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo2.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo2.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo2.DashPattern = null;
            chartLineInfo2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo2.Width = 1F;
            chartCustomShapeInfo3.Border = chartLineInfo2;
            chartCustomShapeInfo3.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo3.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries3.Style.TextShape = chartCustomShapeInfo3;
            chartSeries3.Text = "Default0";
            chartSeries4.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries4.Name = "Default1";
            chartSeries4.Points.Add(1D, ((double)(70D)));
            chartSeries4.Points.Add(2D, ((double)(35D)));
            chartSeries4.Points.Add(3D, ((double)(65D)));
            chartSeries4.Points.Add(4D, ((double)(25D)));
            chartSeries4.Points.Add(5D, ((double)(50D)));
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.AltTagFormat = "";
            chartSeries4.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries4.Style.DrawTextShape = false;
            chartSeries4.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo4.Border = chartLineInfo2;
            chartCustomShapeInfo4.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo4.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries4.Style.TextShape = chartCustomShapeInfo4;
            chartSeries4.Text = "Default1";
            this.MainChart.Series.Add(chartSeries3);
            this.MainChart.Series.Add(chartSeries4);
            this.MainChart.Series3D = true;
            this.MainChart.SeriesHighlight = true;
            this.MainChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.MainChart.Size = new System.Drawing.Size(967, 665);
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
            this.MainChart.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarSplitter2);
            this.MainChart.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.MainChart.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89003F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.10997F));
            this.tableLayoutPanel2.Controls.Add(this.expandCollapsePanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataTile, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(994, 552);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 389);
            this.tableLayoutPanel2.TabIndex = 63;
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.DocumentButton);
            this.expandCollapsePanel2.Controls.Add(this.TransferButton);
            this.expandCollapsePanel2.Controls.Add(this.DataButton);
            this.expandCollapsePanel2.ExpandedHeight = 363;
            this.expandCollapsePanel2.IsExpanded = false;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(304, 3);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(259, 37);
            this.expandCollapsePanel2.TabIndex = 65;
            this.expandCollapsePanel2.Text = "Data";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // DocumentButton
            // 
            this.DocumentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DocumentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DocumentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DocumentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.DocumentButton.Image = ((System.Drawing.Image)(resources.GetObject("DocumentButton.Image")));
            this.DocumentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentButton.Location = new System.Drawing.Point(27, 218);
            this.DocumentButton.Margin = new System.Windows.Forms.Padding(2);
            this.DocumentButton.Name = "DocumentButton";
            this.DocumentButton.Size = new System.Drawing.Size(200, 67);
            this.DocumentButton.TabIndex = 66;
            this.DocumentButton.Text = "Budget \r\nDocuments";
            this.DocumentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DocumentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DocumentButton.UseVisualStyleBackColor = false;
            this.DocumentButton.Click += new System.EventHandler(this.DocumentButton_OnClick);
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TransferButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TransferButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TransferButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.TransferButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferButton.Image")));
            this.TransferButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferButton.Location = new System.Drawing.Point(27, 139);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(196, 64);
            this.TransferButton.TabIndex = 56;
            this.TransferButton.Text = "    Tranfers";
            this.TransferButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransferButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // DataButton
            // 
            this.DataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DataButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.DataButton.Image = ((System.Drawing.Image)(resources.GetObject("DataButton.Image")));
            this.DataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataButton.Location = new System.Drawing.Point(27, 65);
            this.DataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(196, 57);
            this.DataButton.TabIndex = 57;
            this.DataButton.Text = "Data Server";
            this.DataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataButton.UseVisualStyleBackColor = false;
            this.DataButton.Click += new System.EventHandler(this.DataButton_OnClick);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DivisionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DivisionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DivisionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.DivisionBtn.Image = ((System.Drawing.Image)(resources.GetObject("DivisionBtn.Image")));
            this.DivisionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DivisionBtn.Location = new System.Drawing.Point(29, 229);
            this.DivisionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(196, 55);
            this.DivisionBtn.TabIndex = 55;
            this.DivisionBtn.Text = "Division Allocations";
            this.DivisionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DivisionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3705F));
            this.tableLayoutPanel1.Controls.Add(this.expandCollapsePanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SummaryTile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(993, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 422);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.DivisionSummaryButton);
            this.expandCollapsePanel1.Controls.Add(this.DivisionBtn);
            this.expandCollapsePanel1.Controls.Add(this.RegionSummaryButton);
            this.expandCollapsePanel1.ExpandedHeight = 386;
            this.expandCollapsePanel1.IsExpanded = false;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(303, 3);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(264, 37);
            this.expandCollapsePanel1.TabIndex = 64;
            this.expandCollapsePanel1.Text = "Summary";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // DivisionSummaryButton
            // 
            this.DivisionSummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DivisionSummaryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DivisionSummaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DivisionSummaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DivisionSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionSummaryButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionSummaryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.DivisionSummaryButton.Image = ((System.Drawing.Image)(resources.GetObject("DivisionSummaryButton.Image")));
            this.DivisionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DivisionSummaryButton.Location = new System.Drawing.Point(19, 146);
            this.DivisionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionSummaryButton.Name = "DivisionSummaryButton";
            this.DivisionSummaryButton.Size = new System.Drawing.Size(206, 67);
            this.DivisionSummaryButton.TabIndex = 54;
            this.DivisionSummaryButton.Text = "Division Summary";
            this.DivisionSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DivisionSummaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionSummaryButton.UseVisualStyleBackColor = false;
            // 
            // RegionSummaryButton
            // 
            this.RegionSummaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionSummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegionSummaryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegionSummaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegionSummaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.RegionSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegionSummaryButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionSummaryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.RegionSummaryButton.Image = ((System.Drawing.Image)(resources.GetObject("RegionSummaryButton.Image")));
            this.RegionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegionSummaryButton.Location = new System.Drawing.Point(19, 65);
            this.RegionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegionSummaryButton.Name = "RegionSummaryButton";
            this.RegionSummaryButton.Size = new System.Drawing.Size(206, 58);
            this.RegionSummaryButton.TabIndex = 53;
            this.RegionSummaryButton.Text = "Region Summary";
            this.RegionSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegionSummaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegionSummaryButton.UseCompatibleTextRendering = true;
            this.RegionSummaryButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1588, 953);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected Syncfusion.Windows.Forms.Chart.ChartControl MainChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.HubTile SummaryTile;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button DivisionSummaryButton;
        private System.Windows.Forms.Button RegionSummaryButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.HubTile DataTile;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button DataButton;
        private System.Windows.Forms.Button DocumentButton;
    }
}