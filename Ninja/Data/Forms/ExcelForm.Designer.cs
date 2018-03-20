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

namespace Budget
{
    namespace Ninja
    {
        namespace Data
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
                        components.Dispose( );
                    }
                    base.Dispose(disposing);
                }

                #region Windows Form Designer generated code

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                void InitializeComponent( )
                {
                    this.components = new System.ComponentModel.Container( );
                    Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste( );
                    Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController( );
                    Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage( );
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
                    this.ExcelRibbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon( );
                    this.ExcelSpreadSheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet( );
                    this.panel1 = new System.Windows.Forms.Panel( );
                    this.splitContainer1 = new System.Windows.Forms.SplitContainer( );
                    ((System.ComponentModel.ISupportInitialize)(this.ExcelRibbon)).BeginInit( );
                    this.panel1.SuspendLayout( );
                    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit( );
                    this.splitContainer1.Panel1.SuspendLayout( );
                    this.splitContainer1.Panel2.SuspendLayout( );
                    this.splitContainer1.SuspendLayout( );
                    this.SuspendLayout( );
                    // 
                    // ExcelRibbon
                    // 
                    this.ExcelRibbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.ExcelRibbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
                    this.ExcelRibbon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
                    this.ExcelRibbon.HideMenuButtonToolTip = true;
                    this.ExcelRibbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
                    this.ExcelRibbon.Location = new System.Drawing.Point(0, 0);
                    this.ExcelRibbon.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.ExcelRibbon.MenuButtonText = "FILE";
                    this.ExcelRibbon.MenuButtonWidth = 60;
                    this.ExcelRibbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
                    this.ExcelRibbon.Name = "ExcelRibbon";
                    this.ExcelRibbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
                    this.ExcelRibbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.DarkGray;
                    this.ExcelRibbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
                    // 
                    // ExcelRibbon.OfficeMenu
                    // 
                    this.ExcelRibbon.OfficeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
                    this.ExcelRibbon.OfficeMenu.Name = "OfficeMenu";
                    this.ExcelRibbon.OfficeMenu.ShowItemToolTips = true;
                    this.ExcelRibbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
                    this.ExcelRibbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.ExcelRibbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
                    this.ExcelRibbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
                    this.ExcelRibbon.ShowQuickItemsDropDownButton = false;
                    this.ExcelRibbon.ShowRibbonDisplayOptionButton = false;
                    this.ExcelRibbon.Size = new System.Drawing.Size(1234, 147);
                    this.ExcelRibbon.Spreadsheet = this.ExcelSpreadSheet;
                    this.ExcelRibbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
                    this.ExcelRibbon.SystemText.RenameDisplayLabelText = "&Display Name:";
                    this.ExcelRibbon.TabIndex = 0;
                    this.ExcelRibbon.Text = "spreadsheetRibbon1";
                    this.ExcelRibbon.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
                    this.ExcelRibbon.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    // 
                    // ExcelSpreadSheet
                    // 
                    this.ExcelSpreadSheet.AllowCellContextMenu = true;
                    this.ExcelSpreadSheet.AllowExtendRowColumnCount = true;
                    this.ExcelSpreadSheet.AllowFormulaRangeSelection = true;
                    this.ExcelSpreadSheet.AllowTabItemContextMenu = true;
                    this.ExcelSpreadSheet.AllowZooming = true;
                    spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
                    spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
                    this.ExcelSpreadSheet.CopyPaste = spreadsheetCopyPaste1;
                    this.ExcelSpreadSheet.DefaultColumnCount = 101;
                    this.ExcelSpreadSheet.DefaultRowCount = 101;
                    this.ExcelSpreadSheet.DisplayAlerts = true;
                    this.ExcelSpreadSheet.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.ExcelSpreadSheet.FileName = "Book3";
                    this.ExcelSpreadSheet.FormulaBarVisibility = true;
                    formulaRangeSelectionController1.AllowMouseSelection = true;
                    formulaRangeSelectionController1.AllowSelectionOnEditing = true;
                    this.ExcelSpreadSheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
                    this.ExcelSpreadSheet.IsCustomTabItemContextMenuEnabled = false;
                    this.ExcelSpreadSheet.Location = new System.Drawing.Point(0, 0);
                    this.ExcelSpreadSheet.Name = "ExcelSpreadSheet";
                    this.ExcelSpreadSheet.SelectedTabIndex = 0;
                    this.ExcelSpreadSheet.SelectedTabItem = null;
                    this.ExcelSpreadSheet.ShowBusyIndicator = true;
                    this.ExcelSpreadSheet.Size = new System.Drawing.Size(1234, 465);
                    this.ExcelSpreadSheet.TabIndex = 1;
                    this.ExcelSpreadSheet.TabItemContextMenu = null;
                    this.ExcelSpreadSheet.Text = "spreadsheet1";
                    // 
                    // panel1
                    // 
                    this.panel1.Controls.Add(this.splitContainer1);
                    this.panel1.Location = new System.Drawing.Point(229, 98);
                    this.panel1.Name = "panel1";
                    this.panel1.Size = new System.Drawing.Size(1234, 613);
                    this.panel1.TabIndex = 2;
                    // 
                    // splitContainer1
                    // 
                    this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.splitContainer1.Location = new System.Drawing.Point(0, 0);
                    this.splitContainer1.Name = "splitContainer1";
                    this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                    // 
                    // splitContainer1.Panel1
                    // 
                    this.splitContainer1.Panel1.Controls.Add(this.ExcelRibbon);
                    // 
                    // splitContainer1.Panel2
                    // 
                    this.splitContainer1.Panel2.Controls.Add(this.ExcelSpreadSheet);
                    this.splitContainer1.Size = new System.Drawing.Size(1234, 613);
                    this.splitContainer1.SplitterDistance = 144;
                    this.splitContainer1.TabIndex = 0;
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
                    captionImage1.BackColor = System.Drawing.Color.Black;
                    captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
                    captionImage1.Location = new System.Drawing.Point(30, 10);
                    captionImage1.Name = "CaptionImage1";
                    captionImage1.Size = new System.Drawing.Size(175, 60);
                    this.CaptionImages.Add(captionImage1);
                    this.ClientSize = new System.Drawing.Size(1688, 794);
                    this.Controls.Add(this.panel1);
                    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                    this.MetroColor = System.Drawing.Color.Black;
                    this.Name = "ExcelForm";
                    this.ShowIcon = false;
                    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    this.Text = "Excel Report";
                    this.Load += new System.EventHandler(this.GetReport);
                    ((System.ComponentModel.ISupportInitialize)(this.ExcelRibbon)).EndInit( );
                    this.panel1.ResumeLayout(false);
                    this.splitContainer1.Panel1.ResumeLayout(false);
                    this.splitContainer1.Panel2.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit( );
                    this.splitContainer1.ResumeLayout(false);
                    this.ResumeLayout(false);

                }

                #endregion

                Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon ExcelRibbon;
                Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet ExcelSpreadSheet;
                System.Windows.Forms.Panel panel1;
                System.Windows.Forms.SplitContainer splitContainer1;
            } 
        }
    }
}