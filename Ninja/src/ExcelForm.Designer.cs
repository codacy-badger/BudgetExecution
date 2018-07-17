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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.spreadsheetRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
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
            this.toolStripEx2.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Size = new System.Drawing.Size(100, 25);
            this.toolStripEx2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spreadsheet1);
            this.panel1.Controls.Add(this.spreadsheetRibbon1);
            this.panel1.Location = new System.Drawing.Point(271, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 832);
            this.panel1.TabIndex = 1;
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.AllowCellContextMenu = true;
            this.spreadsheet1.AllowExtendRowColumnCount = true;
            this.spreadsheet1.AllowFormulaRangeSelection = true;
            this.spreadsheet1.AllowTabItemContextMenu = true;
            this.spreadsheet1.AllowZooming = true;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet1.DefaultColumnCount = 14;
            this.spreadsheet1.DefaultRowCount = 50;
            this.spreadsheet1.DisplayAlerts = true;
            this.spreadsheet1.FileName = "Book4";
            this.spreadsheet1.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet1.Location = new System.Drawing.Point(0, 220);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.SelectedTabIndex = 0;
            this.spreadsheet1.SelectedTabItem = null;
            this.spreadsheet1.ShowBusyIndicator = true;
            this.spreadsheet1.Size = new System.Drawing.Size(1163, 609);
            this.spreadsheet1.TabIndex = 1;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.ThemeName = "Default";
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
            this.spreadsheetRibbon1.MenuButtonWidth = 60;
            this.spreadsheetRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.spreadsheetRibbon1.Name = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
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
            this.spreadsheetRibbon1.ShowQuickItemsDropDownButton = false;
            this.spreadsheetRibbon1.ShowRibbonDisplayOptionButton = false;
            this.spreadsheetRibbon1.Size = new System.Drawing.Size(1163, 222);
            this.spreadsheetRibbon1.Spreadsheet = null;
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
            this.CaptionBarHeight = 40;
            this.CaptionButtonHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(150, 50);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1517, 953);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MetroForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon spreadsheetRibbon1;
    }
}