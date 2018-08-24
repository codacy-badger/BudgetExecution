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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.BudgetReport = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.BudgetReportRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.metroSetListBox1 = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroSetListBox2 = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetComboBox2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetReportRibbon1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BudgetReport
            // 
            this.BudgetReport.AllowCellContextMenu = true;
            this.BudgetReport.AllowExtendRowColumnCount = true;
            this.BudgetReport.AllowFormulaRangeSelection = true;
            this.BudgetReport.AllowTabItemContextMenu = true;
            this.BudgetReport.AllowZooming = true;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.BudgetReport.CopyPaste = spreadsheetCopyPaste1;
            this.BudgetReport.DefaultColumnCount = 15;
            this.BudgetReport.DefaultRowCount = 60;
            this.BudgetReport.DisplayAlerts = true;
            this.BudgetReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BudgetReport.FileName = "Book1";
            this.BudgetReport.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReport.ForeColor = System.Drawing.Color.Black;
            this.BudgetReport.FormulaBarVisibility = false;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.BudgetReport.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.BudgetReport.IsCustomTabItemContextMenuEnabled = false;
            this.BudgetReport.Location = new System.Drawing.Point(0, 240);
            this.BudgetReport.Name = "BudgetReport";
            this.BudgetReport.SelectedTabIndex = 0;
            this.BudgetReport.SelectedTabItem = null;
            this.BudgetReport.ShowBusyIndicator = true;
            this.BudgetReport.Size = new System.Drawing.Size(1170, 600);
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
            this.metroSetPanel1.Location = new System.Drawing.Point(474, 55);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1170, 840);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // BudgetReportRibbon1
            // 
            this.BudgetReportRibbon1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReportRibbon1.CustomRibbonHeaderImage = ((System.Drawing.Image)(resources.GetObject("BudgetReportRibbon1.CustomRibbonHeaderImage")));
            this.BudgetReportRibbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.BudgetReportRibbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BudgetReportRibbon1.HideMenuButtonToolTip = true;
            this.BudgetReportRibbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.BudgetReportRibbon1.Location = new System.Drawing.Point(0, 0);
            this.BudgetReportRibbon1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReportRibbon1.MenuButtonText = "FILE";
            this.BudgetReportRibbon1.MenuButtonWidth = 56;
            this.BudgetReportRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BudgetReportRibbon1.MinimumSize = new System.Drawing.Size(0, 73);
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
            // metroSetListBox1
            // 
            this.metroSetListBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetListBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetListBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetListBox1.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox1.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox1.ItemHeight = 30;
            this.metroSetListBox1.Location = new System.Drawing.Point(82, 55);
            this.metroSetListBox1.MultiSelect = false;
            this.metroSetListBox1.Name = "metroSetListBox1";
            this.metroSetListBox1.SelectedIndex = -1;
            this.metroSetListBox1.SelectedItem = null;
            this.metroSetListBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox1.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox1.ShowBorder = true;
            this.metroSetListBox1.ShowScrollBar = false;
            this.metroSetListBox1.Size = new System.Drawing.Size(320, 408);
            this.metroSetListBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetListBox1.StyleManager = null;
            this.metroSetListBox1.TabIndex = 42;
            this.metroSetListBox1.ThemeAuthor = "Narwin";
            this.metroSetListBox1.ThemeName = "MetroDark";
            // 
            // metroSetListBox2
            // 
            this.metroSetListBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetListBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetListBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetListBox2.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox2.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox2.ItemHeight = 30;
            this.metroSetListBox2.Location = new System.Drawing.Point(82, 495);
            this.metroSetListBox2.MultiSelect = false;
            this.metroSetListBox2.Name = "metroSetListBox2";
            this.metroSetListBox2.SelectedIndex = -1;
            this.metroSetListBox2.SelectedItem = null;
            this.metroSetListBox2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox2.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox2.ShowBorder = true;
            this.metroSetListBox2.ShowScrollBar = false;
            this.metroSetListBox2.Size = new System.Drawing.Size(320, 378);
            this.metroSetListBox2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetListBox2.StyleManager = null;
            this.metroSetListBox2.TabIndex = 43;
            this.metroSetListBox2.ThemeAuthor = "Narwin";
            this.metroSetListBox2.ThemeName = "MetroDark";
            // 
            // metroSetComboBox1
            // 
            this.metroSetComboBox1.AllowDrop = true;
            this.metroSetComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox1.CausesValidation = false;
            this.metroSetComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox1.FormattingEnabled = true;
            this.metroSetComboBox1.ItemHeight = 20;
            this.metroSetComboBox1.Location = new System.Drawing.Point(135, 695);
            this.metroSetComboBox1.Name = "metroSetComboBox1";
            this.metroSetComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox1.Size = new System.Drawing.Size(224, 26);
            this.metroSetComboBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetComboBox1.StyleManager = null;
            this.metroSetComboBox1.TabIndex = 44;
            this.metroSetComboBox1.ThemeAuthor = "Narwin";
            this.metroSetComboBox1.ThemeName = "MetroDark";
            // 
            // metroSetComboBox2
            // 
            this.metroSetComboBox2.AllowDrop = true;
            this.metroSetComboBox2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox2.CausesValidation = false;
            this.metroSetComboBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox2.FormattingEnabled = true;
            this.metroSetComboBox2.ItemHeight = 20;
            this.metroSetComboBox2.Location = new System.Drawing.Point(135, 562);
            this.metroSetComboBox2.Name = "metroSetComboBox2";
            this.metroSetComboBox2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox2.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox2.Size = new System.Drawing.Size(224, 26);
            this.metroSetComboBox2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetComboBox2.StyleManager = null;
            this.metroSetComboBox2.TabIndex = 45;
            this.metroSetComboBox2.ThemeAuthor = "Narwin";
            this.metroSetComboBox2.ThemeName = "MetroDark";
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 349);
            this.flowLayoutPanel1.TabIndex = 155;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.25444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.74556F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button12, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button11, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.GridRefreshButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(488, 903);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 57);
            this.tableLayoutPanel2.TabIndex = 171;
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
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 162;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(753, 5);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 35);
            this.button12.TabIndex = 168;
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(122, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 35);
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
            this.button11.Location = new System.Drawing.Point(609, 5);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 35);
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
            this.GridRefreshButton.Location = new System.Drawing.Point(226, 5);
            this.GridRefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(98, 35);
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
            this.button9.Location = new System.Drawing.Point(350, 5);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 35);
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
            this.button4.Location = new System.Drawing.Point(479, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 166;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CaptionBarHeight = 45;
            this.CaptionButtonHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(30, 30);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1702, 996);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroSetComboBox2);
            this.Controls.Add(this.metroSetComboBox1);
            this.Controls.Add(this.metroSetListBox2);
            this.Controls.Add(this.metroSetListBox1);
            this.Controls.Add(this.metroSetPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1714, 1047);
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1714, 1047);
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetReportRibbon1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon BudgetReportRibbon1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox1;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox2;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox2;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet BudgetReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button GridRefreshButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
    }
}