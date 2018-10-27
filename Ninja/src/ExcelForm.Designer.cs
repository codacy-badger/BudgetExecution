#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    partial class ExcelForm
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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.BudgetReport = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.BudgetReportRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CarryOverButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton();
            this.CurrentYearButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton();
            this.visualGroupBox3 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetReportRibbon1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.visualGroupBox3.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BudgetReport
            // 
            this.BudgetReport.AllowCellContextMenu = true;
            this.BudgetReport.AllowExtendRowColumnCount = true;
            this.BudgetReport.AllowFormulaRangeSelection = true;
            this.BudgetReport.AllowTabItemContextMenu = true;
            this.BudgetReport.AllowZooming = true;
            this.BudgetReport.BackColor = System.Drawing.SystemColors.ScrollBar;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.BudgetReport.CopyPaste = spreadsheetCopyPaste1;
            this.BudgetReport.DefaultColumnCount = 15;
            this.BudgetReport.DefaultRowCount = 60;
            this.BudgetReport.DisplayAlerts = true;
            this.BudgetReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BudgetReport.FileName = "Book4";
            this.BudgetReport.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReport.ForeColor = System.Drawing.Color.Black;
            this.BudgetReport.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.BudgetReport.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.BudgetReport.IsCustomTabItemContextMenuEnabled = false;
            this.BudgetReport.Location = new System.Drawing.Point(0, 234);
            this.BudgetReport.Name = "BudgetReport";
            this.BudgetReport.SelectedTabIndex = 0;
            this.BudgetReport.SelectedTabItem = null;
            this.BudgetReport.ShowBusyIndicator = true;
            this.BudgetReport.Size = new System.Drawing.Size(1170, 652);
            this.BudgetReport.TabIndex = 1;
            this.BudgetReport.TabItemContextMenu = null;
            this.BudgetReport.ThemeName = "Default";
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // 
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Name = "";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 5;
            this.toolStripTabItem1.Panel.Text = "toolStripTabItem1";
            this.toolStripTabItem1.Position = -1;
            this.toolStripTabItem1.Size = new System.Drawing.Size(174, 40);
            this.toolStripTabItem1.Text = "toolStripTabItem1";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Size = new System.Drawing.Size(100, 25);
            this.toolStripEx1.TabIndex = 0;
            // 
            // toolStripTabItem2
            // 
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // 
            // 
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem2.Panel.Name = "";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 5;
            this.toolStripTabItem2.Panel.Text = "toolStripTabItem2";
            this.toolStripTabItem2.Position = -1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(174, 40);
            this.toolStripTabItem2.Text = "toolStripTabItem2";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.AutoSize = false;
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Size = new System.Drawing.Size(100, 25);
            this.toolStripEx2.TabIndex = 0;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.BudgetReport);
            this.metroSetPanel1.Controls.Add(this.BudgetReportRibbon1);
            this.metroSetPanel1.Location = new System.Drawing.Point(468, 51);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1170, 886);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // BudgetReportRibbon1
            // 
            this.BudgetReportRibbon1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReportRibbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.BudgetReportRibbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BudgetReportRibbon1.HideMenuButtonToolTip = true;
            this.BudgetReportRibbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.BudgetReportRibbon1.Location = new System.Drawing.Point(0, 0);
            this.BudgetReportRibbon1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReportRibbon1.MenuButtonText = "FILE";
            this.BudgetReportRibbon1.MenuButtonWidth = 56;
            this.BudgetReportRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BudgetReportRibbon1.Name = "BudgetReportRibbon1";
            this.BudgetReportRibbon1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.DarkGray;
            this.BudgetReportRibbon1.Office2016ColorTable.Add(office2016ColorTable1);
            this.BudgetReportRibbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // BudgetReportRibbon1.OfficeMenu
            // 
            this.BudgetReportRibbon1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BudgetReportRibbon1.OfficeMenu.Name = "OfficeMenu";
            this.BudgetReportRibbon1.OfficeMenu.ShowItemToolTips = true;
            this.BudgetReportRibbon1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.BudgetReportRibbon1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BudgetReportRibbon1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.BudgetReportRibbon1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.BudgetReportRibbon1.ShowQuickItemsDropDownButton = false;
            this.BudgetReportRibbon1.ShowRibbonDisplayOptionButton = false;
            this.BudgetReportRibbon1.Size = new System.Drawing.Size(1170, 234);
            this.BudgetReportRibbon1.Spreadsheet = this.BudgetReport;
            this.BudgetReportRibbon1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.BudgetReportRibbon1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.BudgetReportRibbon1.TabIndex = 0;
            this.BudgetReportRibbon1.Text = "spreadsheetRibbon1";
            this.BudgetReportRibbon1.ThemeName = "Default";
            this.BudgetReportRibbon1.TitleColor = System.Drawing.Color.White;
            this.BudgetReportRibbon1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReportRibbon1.Click += new System.EventHandler(this.CalculatorButton_OnClick);
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.GridRefreshButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 748);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 187);
            this.tableLayoutPanel2.TabIndex = 173;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(4, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 162;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(160, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 40);
            this.button3.TabIndex = 163;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(160, 130);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 40);
            this.button11.TabIndex = 167;
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // GridRefreshButton
            // 
            this.GridRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.GridRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GridRefreshButton.FlatAppearance.BorderSize = 0;
            this.GridRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.GridRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.GridRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("GridRefreshButton.Image")));
            this.GridRefreshButton.Location = new System.Drawing.Point(4, 73);
            this.GridRefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(101, 40);
            this.GridRefreshButton.TabIndex = 164;
            this.GridRefreshButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GridRefreshButton.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(160, 73);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 40);
            this.button9.TabIndex = 165;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(4, 130);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 40);
            this.button4.TabIndex = 166;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // CarryOverButton
            // 
            this.CarryOverButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CarryOverButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.CarryOverButton.Border.HoverVisible = true;
            this.CarryOverButton.Border.Rounding = 12;
            this.CarryOverButton.Border.Thickness = 1;
            this.CarryOverButton.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.CarryOverButton.Border.Visible = true;
            this.CarryOverButton.Box = new System.Drawing.Size(14, 14);
            this.CarryOverButton.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarryOverButton.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CarryOverButton.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarryOverButton.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CarryOverButton.BoxSpacing = 2;
            this.CarryOverButton.CheckStyle.AutoSize = true;
            this.CarryOverButton.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 8, 8);
            this.CarryOverButton.CheckStyle.Character = '✔';
            this.CarryOverButton.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.CarryOverButton.CheckStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CarryOverButton.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.CarryOverButton.CheckStyle.ShapeRounding = 6;
            this.CarryOverButton.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeType.Rounded;
            this.CarryOverButton.CheckStyle.Style = VisualPlus.Structure.CheckStyle.CheckType.Shape;
            this.CarryOverButton.CheckStyle.Thickness = 2F;
            this.CarryOverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarryOverButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CarryOverButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CarryOverButton.IsBoxLarger = false;
            this.CarryOverButton.Location = new System.Drawing.Point(256, 86);
            this.CarryOverButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CarryOverButton.Name = "CarryOverButton";
            this.CarryOverButton.Size = new System.Drawing.Size(125, 23);
            this.CarryOverButton.TabIndex = 175;
            this.CarryOverButton.Text = "CarryOver";
            this.CarryOverButton.TextSize = new System.Drawing.Size(80, 24);
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CarryOverButton.TextStyle = textStyle4;
            // 
            // CurrentYearButton
            // 
            this.CurrentYearButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CurrentYearButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.CurrentYearButton.Border.HoverVisible = true;
            this.CurrentYearButton.Border.Rounding = 12;
            this.CurrentYearButton.Border.Thickness = 1;
            this.CurrentYearButton.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.CurrentYearButton.Border.Visible = true;
            this.CurrentYearButton.Box = new System.Drawing.Size(14, 14);
            this.CurrentYearButton.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CurrentYearButton.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CurrentYearButton.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CurrentYearButton.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentYearButton.BoxSpacing = 2;
            this.CurrentYearButton.CheckStyle.AutoSize = true;
            this.CurrentYearButton.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 8, 8);
            this.CurrentYearButton.CheckStyle.Character = '✔';
            this.CurrentYearButton.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.CurrentYearButton.CheckStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentYearButton.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.CurrentYearButton.CheckStyle.ShapeRounding = 6;
            this.CurrentYearButton.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeType.Rounded;
            this.CurrentYearButton.CheckStyle.Style = VisualPlus.Structure.CheckStyle.CheckType.Shape;
            this.CurrentYearButton.CheckStyle.Thickness = 2F;
            this.CurrentYearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentYearButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentYearButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CurrentYearButton.IsBoxLarger = false;
            this.CurrentYearButton.Location = new System.Drawing.Point(65, 86);
            this.CurrentYearButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CurrentYearButton.Name = "CurrentYearButton";
            this.CurrentYearButton.Size = new System.Drawing.Size(125, 23);
            this.CurrentYearButton.TabIndex = 176;
            this.CurrentYearButton.Text = "CurrentYear";
            this.CurrentYearButton.TextSize = new System.Drawing.Size(95, 24);
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CurrentYearButton.TextStyle = textStyle3;
            // 
            // visualGroupBox3
            // 
            this.visualGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualGroupBox3.BackColorState.Disabled = System.Drawing.Color.Black;
            this.visualGroupBox3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.visualGroupBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox3.Border.HoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.visualGroupBox3.Border.HoverVisible = true;
            this.visualGroupBox3.Border.Rounding = 6;
            this.visualGroupBox3.Border.Thickness = 1;
            this.visualGroupBox3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox3.Border.Visible = true;
            this.visualGroupBox3.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox3.Controls.Add(this.flowLayoutPanel3);
            this.visualGroupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox3.Image = null;
            this.visualGroupBox3.Location = new System.Drawing.Point(61, 152);
            this.visualGroupBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox3.Name = "visualGroupBox3";
            this.visualGroupBox3.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox3.Separator = true;
            this.visualGroupBox3.SeparatorColor = System.Drawing.Color.Black;
            this.visualGroupBox3.Size = new System.Drawing.Size(320, 287);
            this.visualGroupBox3.TabIndex = 177;
            this.visualGroupBox3.Text = "Division";
            this.visualGroupBox3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox3.TextStyle = textStyle2;
            this.visualGroupBox3.TitleBoxHeight = 25;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(30, 52);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(268, 178);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // visualGroupBox1
            // 
            this.visualGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualGroupBox1.BackColorState.Disabled = System.Drawing.Color.Black;
            this.visualGroupBox1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.visualGroupBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox1.Border.HoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.visualGroupBox1.Border.HoverVisible = true;
            this.visualGroupBox1.Border.Rounding = 6;
            this.visualGroupBox1.Border.Thickness = 1;
            this.visualGroupBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox1.Border.Visible = true;
            this.visualGroupBox1.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(61, 463);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = true;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.Black;
            this.visualGroupBox1.Size = new System.Drawing.Size(320, 258);
            this.visualGroupBox1.TabIndex = 178;
            this.visualGroupBox1.Text = "Division";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle1;
            this.visualGroupBox1.TitleBoxHeight = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 178);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 45;
            this.CaptionButtonHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(100, 30);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1702, 949);
            this.Controls.Add(this.visualGroupBox1);
            this.Controls.Add(this.visualGroupBox3);
            this.Controls.Add(this.CurrentYearButton);
            this.Controls.Add(this.CarryOverButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.metroSetPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetReportRibbon1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.visualGroupBox3.ResumeLayout(false);
            this.visualGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon BudgetReportRibbon1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet BudgetReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button GridRefreshButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton CurrentYearButton;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton CarryOverButton;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}