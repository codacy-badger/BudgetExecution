#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Ninja.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem();
            this.MainChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.TransferButton = new System.Windows.Forms.Button();
            this.DataButton = new System.Windows.Forms.Button();
            this.DataTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.DivisionSummaryButton = new System.Windows.Forms.Button();
            this.RegionSummaryButton = new System.Windows.Forms.Button();
            this.SummaryTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.tableLayoutPanel2.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89003F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.10997F));
            this.tableLayoutPanel2.Controls.Add(this.expandCollapsePanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataTile, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(994, 552);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 389);
            this.tableLayoutPanel2.TabIndex = 63;
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.TransferButton);
            this.expandCollapsePanel2.Controls.Add(this.DataButton);
            this.expandCollapsePanel2.ExpandedHeight = 383;
            this.expandCollapsePanel2.IsExpanded = false;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(304, 3);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(259, 37);
            this.expandCollapsePanel2.TabIndex = 65;
            this.expandCollapsePanel2.Text = "Data";
            this.expandCollapsePanel2.UseAnimation = true;
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
            this.expandCollapsePanel1.Controls.Add(this.DivisionBtn);
            this.expandCollapsePanel1.Controls.Add(this.DivisionSummaryButton);
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
            this.TransferButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TransferButton.Location = new System.Drawing.Point(40, 185);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(173, 73);
            this.TransferButton.TabIndex = 56;
            this.TransferButton.Text = "    Tranfers";
            this.TransferButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.DataButton.Location = new System.Drawing.Point(27, 88);
            this.DataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(196, 76);
            this.DataButton.TabIndex = 57;
            this.DataButton.Text = "Data Server";
            this.DataButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataButton.UseVisualStyleBackColor = false;
            this.DataButton.Click += new System.EventHandler(this.DataButton_OnClick);
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
            this.DataTile.Size = new System.Drawing.Size(290, 231);
            this.DataTile.TabIndex = 20;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem4.HubTile = this.DataTile;
            this.DataTile.Title = textItem4;
            this.DataTile.Click += new System.EventHandler(this.DataTile_Click);
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
            this.DivisionBtn.Location = new System.Drawing.Point(19, 282);
            this.DivisionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(232, 64);
            this.DivisionBtn.TabIndex = 55;
            this.DivisionBtn.Text = "Budget Allocations";
            this.DivisionBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DivisionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionBtn.UseVisualStyleBackColor = false;
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
            this.DivisionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DivisionSummaryButton.Location = new System.Drawing.Point(19, 179);
            this.DivisionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionSummaryButton.Name = "DivisionSummaryButton";
            this.DivisionSummaryButton.Size = new System.Drawing.Size(232, 77);
            this.DivisionSummaryButton.TabIndex = 54;
            this.DivisionSummaryButton.Text = "Division Summary";
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
            this.RegionSummaryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RegionSummaryButton.Location = new System.Drawing.Point(15, 85);
            this.RegionSummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegionSummaryButton.Name = "RegionSummaryButton";
            this.RegionSummaryButton.Size = new System.Drawing.Size(236, 68);
            this.RegionSummaryButton.TabIndex = 53;
            this.RegionSummaryButton.Text = "Region Summary";
            this.RegionSummaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegionSummaryButton.UseCompatibleTextRendering = true;
            this.RegionSummaryButton.UseVisualStyleBackColor = false;
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
            this.SummaryTile.Size = new System.Drawing.Size(291, 219);
            this.SummaryTile.TabIndex = 23;
            textItem8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem8.HubTile = this.SummaryTile;
            this.SummaryTile.Title = textItem8;
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
    }
}