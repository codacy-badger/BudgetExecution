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
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.hubTile2 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.MainChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hubTile2
            // 
            this.hubTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem5.HubTile = this.hubTile2;
            this.hubTile2.Banner = textItem5;
            this.hubTile2.BannerColor = System.Drawing.Color.Transparent;
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.hubTile2;
            this.hubTile2.Body = textItem6;
            this.hubTile2.EnableSelectionMarker = false;
            this.hubTile2.EnableTileSlideEffect = false;
            this.hubTile2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem7.HubTile = this.hubTile2;
            this.hubTile2.Footer = textItem7;
            this.hubTile2.ForeColor = System.Drawing.SystemColors.Info;
            this.hubTile2.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile2.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile2.ImageSource")));
            this.hubTile2.Location = new System.Drawing.Point(1490, 73);
            this.hubTile2.Margin = new System.Windows.Forms.Padding(2);
            this.hubTile2.MinimumSize = new System.Drawing.Size(70, 66);
            this.hubTile2.Name = "hubTile2";
            this.hubTile2.PulseScale = 4;
            this.hubTile2.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile2.ShowBanner = true;
            this.hubTile2.ShowBannerIcon = true;
            this.hubTile2.ShowRotateTileBanner = true;
            this.hubTile2.Size = new System.Drawing.Size(257, 153);
            this.hubTile2.SwitchRotateTileBannerVisibility = true;
            this.hubTile2.TabIndex = 73;
            textItem8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem8.HubTile = this.hubTile2;
            this.hubTile2.Title = textItem8;
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
            this.MainChart.Location = new System.Drawing.Point(91, 199);
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
            this.MainChart.Size = new System.Drawing.Size(1177, 695);
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
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.Color.Transparent;
            this.TestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TestButton.FlatAppearance.BorderSize = 0;
            this.TestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.TestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton.Image = ((System.Drawing.Image)(resources.GetObject("TestButton.Image")));
            this.TestButton.Location = new System.Drawing.Point(1677, 930);
            this.TestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(50, 52);
            this.TestButton.TabIndex = 166;
            this.TestButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1788, 1053);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.hubTile2);
            this.Controls.Add(this.MainChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1800, 1100);
            this.MinimumSize = new System.Drawing.Size(1800, 1078);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected Syncfusion.Windows.Forms.Chart.ChartControl MainChart;
        private Syncfusion.Windows.Forms.Tools.HubTile hubTile2;
        private System.Windows.Forms.Button TestButton;
    }
}