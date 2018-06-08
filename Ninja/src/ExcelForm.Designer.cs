#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using MetroFramework.Controls;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

#endregion




namespace BudgetExecution
{
    partial class ExcelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

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
        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
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
            Syncfusion.Windows.Forms.CaptionImage captionImage5 = new Syncfusion.Windows.Forms.CaptionImage();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.spreadsheetRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblCount = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabPageAdv8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.monthCalendarAdv1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.metroSetButton3 = new MetroSet_UI.Controls.MetroSetButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.NavigationTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl2 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripTabItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroSetPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).BeginInit();
            this.spreadsheetRibbon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPageAdv7.SuspendLayout();
            this.tabPageAdv8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(3, 3);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton1.NormalColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(261, 50);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 1;
            this.metroSetButton1.Text = "metroSetButton1";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Location = new System.Drawing.Point(3, 59);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton2.NormalColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(261, 50);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 2;
            this.metroSetButton2.Text = "metroSetButton2";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.AutoScroll = true;
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.spreadsheetRibbon1);
            this.metroSetPanel1.Controls.Add(this.spreadsheet1);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1199, 709);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // spreadsheetRibbon1
            // 
            this.spreadsheetRibbon1.BackColor = System.Drawing.Color.Black;
            this.spreadsheetRibbon1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.spreadsheetRibbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.spreadsheetRibbon1.Header.AddMainItem(toolStripTabItem1);
            this.spreadsheetRibbon1.Header.AddMainItem(toolStripTabItem2);
            this.spreadsheetRibbon1.Header.AddMainItem(toolStripTabItem3);
            this.spreadsheetRibbon1.HideMenuButtonToolTip = true;
            this.spreadsheetRibbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.spreadsheetRibbon1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetRibbon1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.MenuButtonImage = ((System.Drawing.Image)(resources.GetObject("spreadsheetRibbon1.MenuButtonImage")));
            this.spreadsheetRibbon1.MenuButtonText = "FILE";
            this.spreadsheetRibbon1.MenuButtonWidth = 56;
            this.spreadsheetRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.spreadsheetRibbon1.Name = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.spreadsheetRibbon1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            this.spreadsheetRibbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            // 
            // spreadsheetRibbon1.OfficeMenu
            // 
            this.spreadsheetRibbon1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.spreadsheetRibbon1.OfficeMenu.Name = "OfficeMenu";
            this.spreadsheetRibbon1.OfficeMenu.ShowItemToolTips = true;
            this.spreadsheetRibbon1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.spreadsheetRibbon1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spreadsheetRibbon1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.spreadsheetRibbon1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.spreadsheetRibbon1.SelectedTab = this.toolStripTabItem1;
            this.spreadsheetRibbon1.ShowQuickItemsDropDownButton = false;
            this.spreadsheetRibbon1.ShowRibbonDisplayOptionButton = false;
            this.spreadsheetRibbon1.Size = new System.Drawing.Size(1199, 100);
            this.spreadsheetRibbon1.Spreadsheet = this.spreadsheet1;
            this.spreadsheetRibbon1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.spreadsheetRibbon1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.spreadsheetRibbon1.TabIndex = 0;
            this.spreadsheetRibbon1.Text = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.spreadsheetRibbon1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.AllowCellContextMenu = true;
            this.spreadsheet1.AllowExtendRowColumnCount = true;
            this.spreadsheet1.AllowFormulaRangeSelection = true;
            this.spreadsheet1.AllowTabItemContextMenu = true;
            this.spreadsheet1.AllowZooming = true;
            this.spreadsheet1.BackColor = System.Drawing.Color.Black;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet1.DefaultColumnCount = 101;
            this.spreadsheet1.DefaultRowCount = 50;
            this.spreadsheet1.DisplayAlerts = true;
            this.spreadsheet1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spreadsheet1.FileName = "Book1";
            this.spreadsheet1.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet1.Location = new System.Drawing.Point(0, 113);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.SelectedTabIndex = 0;
            this.spreadsheet1.SelectedTabItem = null;
            this.spreadsheet1.ShowBusyIndicator = true;
            this.spreadsheet1.Size = new System.Drawing.Size(1199, 596);
            this.spreadsheet1.TabIndex = 1;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.Click += new System.EventHandler(this.Spreadsheet1_Click);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.White;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1201, 750);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv7);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv8);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.Black;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.DarkGray;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(121, 40);
            this.tabControlAdv1.Location = new System.Drawing.Point(375, 69);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.tabControlAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(1201, 750);
            this.tabControlAdv1.TabIndex = 3;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.Black;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.metroSetPanel1);
            this.tabPageAdv1.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv1.Image")));
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(50, 40);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1199, 709);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.groupBox2);
            this.tabPageAdv2.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv2.Image")));
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(50, 40);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(1199, 709);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox2.Controls.Add(this.Grid);
            this.groupBox2.Controls.Add(this.GridRefreshButton);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.metroSetLabel9);
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Controls.Add(this.metroSetLabel8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(59, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1063, 456);
            this.groupBox2.TabIndex = 160;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // Grid
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle23;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid.Location = new System.Drawing.Point(32, 74);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.Grid.RowHeadersWidth = 30;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.NullValue = null;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.RowTemplate.Height = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(994, 340);
            this.Grid.TabIndex = 150;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCount.Location = new System.Drawing.Point(543, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(102, 23);
            this.lblCount.Style = MetroSet_UI.Design.Style.Dark;
            this.lblCount.StyleManager = null;
            this.lblCount.TabIndex = 149;
            this.lblCount.Text = "metroSetLabel2";
            this.lblCount.ThemeAuthor = "Narwin";
            this.lblCount.ThemeName = "MetroDark";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(186, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(151, 23);
            this.lblTotal.Style = MetroSet_UI.Design.Style.Dark;
            this.lblTotal.StyleManager = null;
            this.lblTotal.TabIndex = 148;
            this.lblTotal.Text = "metroSetLabel1";
            this.lblTotal.ThemeAuthor = "Narwin";
            this.lblTotal.ThemeName = "MetroDark";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.Location = new System.Drawing.Point(434, 37);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(103, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 17;
            this.metroSetLabel9.Text = "Accounts:";
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroDark";
            // 
            // GridRefreshButton
            // 
            this.GridRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.GridRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GridRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.GridRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridRefreshButton.ForeColor = System.Drawing.SystemColors.Info;
            this.GridRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("GridRefreshButton.Image")));
            this.GridRefreshButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GridRefreshButton.Location = new System.Drawing.Point(880, 25);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(119, 32);
            this.GridRefreshButton.TabIndex = 2;
            this.GridRefreshButton.Text = "Refresh";
            this.GridRefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GridRefreshButton.UseVisualStyleBackColor = false;
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.Location = new System.Drawing.Point(103, 37);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(64, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 16;
            this.metroSetLabel8.Text = "Total:";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroDark";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton4,
            this.toolStripSeparator6});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 427);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1059, 27);
            this.bindingNavigator1.TabIndex = 153;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(44, 24);
            this.toolStripButton1.Text = "First";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(28, 24);
            this.toolStripButton2.Text = "Previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(42, 24);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(28, 24);
            this.toolStripButton3.Text = "Next";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(44, 24);
            this.toolStripButton4.Text = "Last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.Controls.Add(this.splitContainer1);
            this.tabPageAdv7.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv7.Image")));
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(40, 40);
            this.tabPageAdv7.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(1199, 709);
            this.tabPageAdv7.TabIndex = 4;
            this.tabPageAdv7.Text = "tabPageAdv7";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // chartControl1
            // 
            this.chartControl1.AllowGradientPalette = true;
            this.chartControl1.AllowUserEditStyles = true;
            this.chartControl1.AutoHighlight = true;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.chartControl1.ChartArea.AutoScale = true;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.chartControl1.ChartAreaShadow = true;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.DarkOliveGreen,
        System.Drawing.Color.DarkBlue};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.Depth = 250F;
            this.chartControl1.DisplayChartContextMenu = false;
            this.chartControl1.DisplaySeriesContextMenu = false;
            this.chartControl1.EnableMouseRotation = true;
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartControl1.HighlightSymbol = true;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(8, 8);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(47, 110);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Padding = new System.Windows.Forms.Padding(1);
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl1.Rotation = 45F;
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
            chartSeries1.Style.Border.Color = System.Drawing.Color.Transparent;
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
            chartSeries1.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
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
            chartSeries2.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Series.Add(chartSeries2);
            this.chartControl1.Series3D = true;
            this.chartControl1.SeriesHighlight = true;
            this.chartControl1.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.chartControl1.Size = new System.Drawing.Size(528, 427);
            this.chartControl1.Spacing = 5F;
            this.chartControl1.SpacingBetweenPoints = 5F;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 47;
            this.chartControl1.Tilt = 15F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            // 
            // tabPageAdv8
            // 
            this.tabPageAdv8.Controls.Add(this.monthCalendarAdv1);
            this.tabPageAdv8.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv8.Image")));
            this.tabPageAdv8.ImageSize = new System.Drawing.Size(40, 40);
            this.tabPageAdv8.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv8.Name = "tabPageAdv8";
            this.tabPageAdv8.ShowCloseButton = true;
            this.tabPageAdv8.Size = new System.Drawing.Size(1199, 709);
            this.tabPageAdv8.TabIndex = 5;
            this.tabPageAdv8.Text = "tabPageAdv8";
            this.tabPageAdv8.ThemesEnabled = false;
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.monthCalendarAdv1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv1.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarAdv1.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarAdv1.HighlightColor = System.Drawing.Color.Black;
            this.monthCalendarAdv1.Iso8601CalenderFormat = false;
            this.monthCalendarAdv1.Location = new System.Drawing.Point(86, 156);
            this.monthCalendarAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            this.monthCalendarAdv1.Size = new System.Drawing.Size(671, 440);
            this.monthCalendarAdv1.TabIndex = 2;
            this.monthCalendarAdv1.WeekFont = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.monthCalendarAdv1.NoneButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.monthCalendarAdv1.NoneButton.IsBackStageButton = false;
            this.monthCalendarAdv1.NoneButton.Location = new System.Drawing.Point(599, 0);
            this.monthCalendarAdv1.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.monthCalendarAdv1.NoneButton.Text = "None";
            // 
            // 
            // 
            this.monthCalendarAdv1.TodayButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.monthCalendarAdv1.TodayButton.IsBackStageButton = false;
            this.monthCalendarAdv1.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv1.TodayButton.Size = new System.Drawing.Size(599, 20);
            this.monthCalendarAdv1.TodayButton.Text = "Today";
            // 
            // metroSetButton3
            // 
            this.metroSetButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Location = new System.Drawing.Point(3, 115);
            this.metroSetButton3.Name = "metroSetButton3";
            this.metroSetButton3.NormalBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton3.NormalColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Size = new System.Drawing.Size(261, 50);
            this.metroSetButton3.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton3.StyleManager = null;
            this.metroSetButton3.TabIndex = 3;
            this.metroSetButton3.Text = "metroSetButton3";
            this.metroSetButton3.ThemeAuthor = "Narwin";
            this.metroSetButton3.ThemeName = "MetroLite";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroSetButton1);
            this.flowLayoutPanel1.Controls.Add(this.metroSetButton2);
            this.flowLayoutPanel1.Controls.Add(this.metroSetButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 659);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.tabControlAdv2.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.BeforeTouchSize = new System.Drawing.Size(330, 752);
            this.tabControlAdv2.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Controls.Add(this.NavigationTab);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv2.FocusOnTabClick = false;
            this.tabControlAdv2.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControlAdv2.InActiveTabForeColor = System.Drawing.Color.DarkGray;
            this.tabControlAdv2.ItemSize = new System.Drawing.Size(121, 40);
            this.tabControlAdv2.Location = new System.Drawing.Point(12, 66);
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.tabControlAdv2.SeparatorColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlAdv2.ShowSeparator = false;
            this.tabControlAdv2.Size = new System.Drawing.Size(330, 752);
            this.tabControlAdv2.TabIndex = 4;
            this.tabControlAdv2.TabPanelBackColor = System.Drawing.Color.Black;
            this.tabControlAdv2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv2.SelectedIndexChanged += new System.EventHandler(this.TabControlAdv2_SelectedIndexChanged);
            // 
            // NavigationTab
            // 
            this.NavigationTab.Image = null;
            this.NavigationTab.ImageSize = new System.Drawing.Size(16, 16);
            this.NavigationTab.Location = new System.Drawing.Point(1, 40);
            this.NavigationTab.Name = "NavigationTab";
            this.NavigationTab.ShowCloseButton = true;
            this.NavigationTab.Size = new System.Drawing.Size(327, 710);
            this.NavigationTab.TabBackColor = System.Drawing.Color.Black;
            this.NavigationTab.TabIndex = 2;
            this.NavigationTab.Text = "Navigation";
            this.NavigationTab.ThemesEnabled = false;
            // 
            // toolStripTabItem1
            // 
            this.spreadsheetRibbon1.SetDescription(this.toolStripTabItem1, "");
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // spreadsheetRibbon1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 5;
            this.toolStripTabItem1.Panel.Text = "toolStripTabItem1";
            this.toolStripTabItem1.Position = 3;
            this.toolStripTabItem1.Size = new System.Drawing.Size(174, 40);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "toolStripTabItem1";
            this.spreadsheetRibbon1.SetUseInCustomQuickAccessDialog(this.toolStripTabItem1, true);
            this.spreadsheetRibbon1.SetUseInQuickAccessMenu(this.toolStripTabItem1, false);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.calculatorControl2);
            this.tabPageAdv5.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv5.Image")));
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(25, 25);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(1199, 709);
            this.tabPageAdv5.TabIndex = 6;
            this.tabPageAdv5.Text = "tabPageAdv5";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // calculatorControl2
            // 
            this.calculatorControl2.AccessibleDescription = "Calculator control";
            this.calculatorControl2.AccessibleName = "Calculator Control";
            this.calculatorControl2.BackColor = System.Drawing.Color.Black;
            this.calculatorControl2.BeforeTouchSize = new System.Drawing.Size(465, 515);
            this.calculatorControl2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl2.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl2.DisplayTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calculatorControl2.DoubleValue = 0D;
            this.calculatorControl2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl2.HorizontalSpacing = 8;
            this.calculatorControl2.Location = new System.Drawing.Point(353, 139);
            this.calculatorControl2.MetroColor = System.Drawing.Color.AliceBlue;
            this.calculatorControl2.Name = "calculatorControl2";
            this.calculatorControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl2.Size = new System.Drawing.Size(465, 515);
            this.calculatorControl2.TabIndex = 2;
            this.calculatorControl2.Text = "calculatorControl2";
            this.calculatorControl2.ThemesEnabled = false;
            this.calculatorControl2.UseVisualStyle = true;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.flowLayoutPanel1);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(317, 710);
            this.tabPageAdv3.TabFont = null;
            this.tabPageAdv3.TabIndex = 1;
            this.tabPageAdv3.Text = "Filters";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(317, 710);
            this.tabPageAdv4.TabFont = null;
            this.tabPageAdv4.TabIndex = 2;
            this.tabPageAdv4.Text = "Navigation";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // toolStripTabItem2
            // 
            this.spreadsheetRibbon1.SetDescription(this.toolStripTabItem2, "");
            this.toolStripTabItem2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // spreadsheetRibbon1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 6;
            this.toolStripTabItem2.Panel.Text = "toolStripTabItem2";
            this.toolStripTabItem2.Position = 4;
            this.toolStripTabItem2.Size = new System.Drawing.Size(174, 40);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "toolStripTabItem2";
            this.spreadsheetRibbon1.SetUseInCustomQuickAccessDialog(this.toolStripTabItem2, true);
            this.spreadsheetRibbon1.SetUseInQuickAccessMenu(this.toolStripTabItem2, false);
            // 
            // toolStripTabItem3
            // 
            this.spreadsheetRibbon1.SetDescription(this.toolStripTabItem3, "");
            this.toolStripTabItem3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem3.Name = "toolStripTabItem3";
            // 
            // spreadsheetRibbon1.ribbonPanel3
            // 
            this.toolStripTabItem3.Panel.Name = "ribbonPanel3";
            this.toolStripTabItem3.Panel.ScrollPosition = 0;
            this.toolStripTabItem3.Panel.TabIndex = 7;
            this.toolStripTabItem3.Panel.Text = "toolStripTabItem3";
            this.toolStripTabItem3.Position = 5;
            this.toolStripTabItem3.Size = new System.Drawing.Size(174, 40);
            this.toolStripTabItem3.Tag = "3";
            this.toolStripTabItem3.Text = "toolStripTabItem3";
            this.spreadsheetRibbon1.SetUseInCustomQuickAccessDialog(this.toolStripTabItem3, true);
            this.spreadsheetRibbon1.SetUseInQuickAccessMenu(this.toolStripTabItem3, false);
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv6.Image")));
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(40, 40);
            this.tabPageAdv6.Location = new System.Drawing.Point(1, 40);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(327, 710);
            this.tabPageAdv6.TabBackColor = System.Drawing.Color.Black;
            this.tabPageAdv6.TabForeColor = System.Drawing.Color.Black;
            this.tabPageAdv6.TabIndex = 3;
            this.tabPageAdv6.Text = "tabPageAdv6";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 709);
            this.splitContainer1.SplitterDistance = 642;
            this.splitContainer1.TabIndex = 48;
            // 
            // ExcelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 100;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage5.BackColor = System.Drawing.Color.Black;
            captionImage5.Image = ((System.Drawing.Image)(resources.GetObject("captionImage5.Image")));
            captionImage5.Location = new System.Drawing.Point(25, 20);
            captionImage5.Name = "CaptionImage1";
            captionImage5.Size = new System.Drawing.Size(225, 60);
            this.CaptionImages.Add(captionImage5);
            this.ClientSize = new System.Drawing.Size(1588, 866);
            this.Controls.Add(this.tabControlAdv2);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1400);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.GetReport);
            this.metroSetPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).EndInit();
            this.spreadsheetRibbon1.ResumeLayout(false);
            this.spreadsheetRibbon1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPageAdv7.ResumeLayout(false);
            this.tabPageAdv8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSetButton metroSetButton1;
        private MetroSetButton metroSetButton2;
        private MetroSetPanel metroSetPanel1;
        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon spreadsheetRibbon1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private GroupBox groupBox2;
        private DataGridView Grid;
        private MetroSetLabel lblCount;
        private MetroSetLabel lblTotal;
        private MetroSetLabel metroSetLabel9;
        private Button GridRefreshButton;
        private MetroSetLabel metroSetLabel8;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator6;
        private TabPageAdv tabPageAdv7;
        protected ChartControl chartControl1;
        private TabPageAdv tabPageAdv8;
        private MonthCalendarAdv monthCalendarAdv1;
        private MetroSetButton metroSetButton3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabControlAdv tabControlAdv2;
        private TabPageAdv NavigationTab;
        private ToolStripTabItem toolStripTabItem1;
        private TabPageAdv tabPageAdv5;
        private CalculatorControl calculatorControl2;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private SplitContainer splitContainer1;
        private TabPageAdv tabPageAdv6;
        private ToolStripTabItem toolStripTabItem2;
        private ToolStripTabItem toolStripTabItem3;
    }
}
