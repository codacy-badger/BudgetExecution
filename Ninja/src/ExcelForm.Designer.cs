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
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.BudgetReport = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.CarryOverButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton();
            this.CurrentYearButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton();
            this.visualGroupBox3 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.spreadsheetRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.visualGroupBox3.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).BeginInit();
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
            this.BudgetReport.FileName = "Book2";
            this.BudgetReport.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetReport.ForeColor = System.Drawing.Color.Black;
            this.BudgetReport.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.BudgetReport.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.BudgetReport.IsCustomTabItemContextMenuEnabled = false;
            this.BudgetReport.Location = new System.Drawing.Point(0, 0);
            this.BudgetReport.Name = "BudgetReport";
            this.BudgetReport.SelectedTabIndex = 0;
            this.BudgetReport.SelectedTabItem = null;
            this.BudgetReport.ShowBusyIndicator = true;
            this.BudgetReport.Size = new System.Drawing.Size(1170, 1011);
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
            this.metroSetPanel1.Controls.Add(this.spreadsheetRibbon1);
            this.metroSetPanel1.Controls.Add(this.BudgetReport);
            this.metroSetPanel1.Location = new System.Drawing.Point(465, 12);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1170, 1011);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
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
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // spreadsheetRibbon1
            // 
            this.spreadsheetRibbon1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.spreadsheetRibbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.spreadsheetRibbon1.HideMenuButtonToolTip = true;
            this.spreadsheetRibbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.spreadsheetRibbon1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetRibbon1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.MenuButtonText = "FILE";
            this.spreadsheetRibbon1.MenuButtonWidth = 56;
            this.spreadsheetRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.spreadsheetRibbon1.Name = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.spreadsheetRibbon1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            office2016ColorTable1.DropDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            office2016ColorTable1.GalleryItemNormalColor = System.Drawing.SystemColors.AppWorkspace;
            office2016ColorTable1.QuickDropDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            office2016ColorTable1.ToolStripCheckBoxBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.spreadsheetRibbon1.Office2016ColorTable.Add(office2016ColorTable1);
            this.spreadsheetRibbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // spreadsheetRibbon1.OfficeMenu
            // 
            this.spreadsheetRibbon1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.spreadsheetRibbon1.OfficeMenu.Name = "OfficeMenu";
            this.spreadsheetRibbon1.OfficeMenu.ShowItemToolTips = true;
            this.spreadsheetRibbon1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.spreadsheetRibbon1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spreadsheetRibbon1.QuickPanelVisible = false;
            this.spreadsheetRibbon1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.spreadsheetRibbon1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.spreadsheetRibbon1.ShowQuickItemsDropDownButton = false;
            this.spreadsheetRibbon1.ShowRibbonDisplayOptionButton = true;
            this.spreadsheetRibbon1.Size = new System.Drawing.Size(1170, 220);
            this.spreadsheetRibbon1.Spreadsheet = this.BudgetReport;
            this.spreadsheetRibbon1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.spreadsheetRibbon1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.spreadsheetRibbon1.TabIndex = 0;
            this.spreadsheetRibbon1.Text = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.ThemeName = "Default";
            this.spreadsheetRibbon1.TitleColor = System.Drawing.Color.White;
            this.spreadsheetRibbon1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ClientSize = new System.Drawing.Size(1647, 1025);
            this.Controls.Add(this.visualGroupBox1);
            this.Controls.Add(this.visualGroupBox3);
            this.Controls.Add(this.CurrentYearButton);
            this.Controls.Add(this.CarryOverButton);
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
            this.visualGroupBox3.ResumeLayout(false);
            this.visualGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet BudgetReport;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton CurrentYearButton;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualRadioButton CarryOverButton;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon spreadsheetRibbon1;
    }
}