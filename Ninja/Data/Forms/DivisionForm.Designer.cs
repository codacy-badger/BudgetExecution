
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
using MetroFramework.Controls;
using MetroSet_UI;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;
#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class DivisionForm : MetroForm
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries5 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo5 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo3 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries6 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo6 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries7 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo7 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo4 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries8 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo8 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries9 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo9 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo5 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries10 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo10 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries11 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo11 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo6 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries12 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo12 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivisionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries13 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo13 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo7 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries14 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo14 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountLabel1 = new System.Windows.Forms.Label();
            this.codeLabel1 = new System.Windows.Forms.Label();
            this.orgLabel = new System.Windows.Forms.Label();
            this.bOCLabel1 = new System.Windows.Forms.Label();
            this.fundLabel1 = new System.Windows.Forms.Label();
            this.bFYLabel1 = new System.Windows.Forms.Label();
            this.rPIOLabel = new System.Windows.Forms.Label();
            this.DivisionFormTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.AppropriationTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.AppropChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel3 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageBox = new System.Windows.Forms.ListBox();
            this.approplistbox = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BocTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel6 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProgramTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rb13 = new System.Windows.Forms.RadioButton();
            this.rb14 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.AreaChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel5 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rb17 = new System.Windows.Forms.RadioButton();
            this.rb18 = new System.Windows.Forms.RadioButton();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.rb19 = new System.Windows.Forms.RadioButton();
            this.ProjectChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel4 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Expander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.P7FilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.OldAmount = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReturnButton = new MetroFramework.Controls.MetroLink();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DatabaseGridPanel = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.DataNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TransferTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.FrRcComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.ReprogrammingTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.amountCurrencyTextBox = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.FrCodeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrOrgComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrBocComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrFundComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrBfyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrRpioComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Old = new MetroFramework.Controls.MetroTextBox();
            this.Code = new MetroFramework.Controls.MetroTextBox();
            this.BOC = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Fund = new MetroFramework.Controls.MetroTextBox();
            this.Org = new MetroFramework.Controls.MetroTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.BFY = new MetroFramework.Controls.MetroTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RC = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Label();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.PrcChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.GridFilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountMangerGroupBox = new System.Windows.Forms.GroupBox();
            this.PrcPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.BackButton = new MetroSet_UI.Controls.MetroSetButton();
            this.DatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.P8GridPanel = new System.Windows.Forms.Panel();
            this.calculatorControl2 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.P8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionFormTabControl)).BeginInit();
            this.DivisionFormTabControl.SuspendLayout();
            this.AppropriationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.expandCollapsePanel3.SuspendLayout();
            this.BocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.NpmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.expandCollapsePanel6.SuspendLayout();
            this.ProgramTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.expandCollapsePanel5.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.expandCollapsePanel4.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Expander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DatabaseGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNavigator)).BeginInit();
            this.DataNavigator.SuspendLayout();
            this.TransferTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountCurrencyTextBox)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.AccountMangerGroupBox.SuspendLayout();
            this.PrcPanel.SuspendLayout();
            this.DatabaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P8BindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(32, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "RC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type:";
            // 
            // amountLabel1
            // 
            this.amountLabel1.AutoSize = true;
            this.amountLabel1.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.amountLabel1.Location = new System.Drawing.Point(2, 366);
            this.amountLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel1.Name = "amountLabel1";
            this.amountLabel1.Size = new System.Drawing.Size(69, 21);
            this.amountLabel1.TabIndex = 16;
            this.amountLabel1.Text = "Amount:";
            // 
            // codeLabel1
            // 
            this.codeLabel1.AutoSize = true;
            this.codeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.codeLabel1.Location = new System.Drawing.Point(22, 315);
            this.codeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel1.Name = "codeLabel1";
            this.codeLabel1.Size = new System.Drawing.Size(49, 21);
            this.codeLabel1.TabIndex = 14;
            this.codeLabel1.Text = "Code:";
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.BackColor = System.Drawing.Color.Transparent;
            this.orgLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orgLabel.Location = new System.Drawing.Point(32, 190);
            this.orgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(40, 21);
            this.orgLabel.TabIndex = 12;
            this.orgLabel.Text = "Org:";
            // 
            // bOCLabel1
            // 
            this.bOCLabel1.AutoSize = true;
            this.bOCLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bOCLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bOCLabel1.Location = new System.Drawing.Point(24, 270);
            this.bOCLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bOCLabel1.Name = "bOCLabel1";
            this.bOCLabel1.Size = new System.Drawing.Size(44, 21);
            this.bOCLabel1.TabIndex = 10;
            this.bOCLabel1.Text = "BOC:";
            // 
            // fundLabel1
            // 
            this.fundLabel1.AutoSize = true;
            this.fundLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fundLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fundLabel1.Location = new System.Drawing.Point(23, 148);
            this.fundLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fundLabel1.Name = "fundLabel1";
            this.fundLabel1.Size = new System.Drawing.Size(48, 21);
            this.fundLabel1.TabIndex = 8;
            this.fundLabel1.Text = "Fund:";
            // 
            // bFYLabel1
            // 
            this.bFYLabel1.AutoSize = true;
            this.bFYLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bFYLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bFYLabel1.Location = new System.Drawing.Point(32, 106);
            this.bFYLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bFYLabel1.Name = "bFYLabel1";
            this.bFYLabel1.Size = new System.Drawing.Size(39, 21);
            this.bFYLabel1.TabIndex = 6;
            this.bFYLabel1.Text = "BFY:";
            // 
            // rPIOLabel
            // 
            this.rPIOLabel.AutoSize = true;
            this.rPIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.rPIOLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rPIOLabel.Location = new System.Drawing.Point(24, 66);
            this.rPIOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPIOLabel.Name = "rPIOLabel";
            this.rPIOLabel.Size = new System.Drawing.Size(48, 21);
            this.rPIOLabel.TabIndex = 2;
            this.rPIOLabel.Text = "RPIO:";
            // 
            // DivisionFormTabControl
            // 
            this.DivisionFormTabControl.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionFormTabControl.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DivisionFormTabControl.BeforeTouchSize = new System.Drawing.Size(1788, 874);
            this.DivisionFormTabControl.BorderVisible = true;
            this.DivisionFormTabControl.BorderWidth = 1;
            this.DivisionFormTabControl.CloseButtonForeColor = System.Drawing.Color.Black;
            this.DivisionFormTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.DivisionFormTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.DivisionFormTabControl.Controls.Add(this.AppropriationTab);
            this.DivisionFormTabControl.Controls.Add(this.BocTab);
            this.DivisionFormTabControl.Controls.Add(this.NpmTab);
            this.DivisionFormTabControl.Controls.Add(this.ProgramTab);
            this.DivisionFormTabControl.Controls.Add(this.ProjectTab);
            this.DivisionFormTabControl.Controls.Add(this.DataTab);
            this.DivisionFormTabControl.Controls.Add(this.TransferTab);
            this.DivisionFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisionFormTabControl.FixedSingleBorderColor = System.Drawing.Color.Transparent;
            this.DivisionFormTabControl.FocusOnTabClick = false;
            this.DivisionFormTabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionFormTabControl.InActiveTabForeColor = System.Drawing.Color.White;
            this.DivisionFormTabControl.ItemSize = new System.Drawing.Size(400, 39);
            this.DivisionFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.DivisionFormTabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DivisionFormTabControl.Name = "DivisionFormTabControl";
            this.DivisionFormTabControl.Padding = new System.Drawing.Point(10, 3);
            this.DivisionFormTabControl.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.DivisionFormTabControl.ShowScroll = false;
            this.DivisionFormTabControl.ShowSeparator = false;
            this.DivisionFormTabControl.Size = new System.Drawing.Size(1788, 874);
            this.DivisionFormTabControl.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.ShrinkToFit;
            this.DivisionFormTabControl.TabIndex = 44;
            this.DivisionFormTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            this.DivisionFormTabControl.SelectedIndexChanged += new System.EventHandler(this.DivisionFormTabControl_SelectedIndexChanged);
            // 
            // AppropriationTab
            // 
            this.AppropriationTab.Controls.Add(this.splitContainer5);
            this.AppropriationTab.Controls.Add(this.ImageBox);
            this.AppropriationTab.Controls.Add(this.approplistbox);
            this.AppropriationTab.Controls.Add(this.metroButton1);
            this.AppropriationTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppropriationTab.Image = null;
            this.AppropriationTab.ImageSize = new System.Drawing.Size(40, 35);
            this.AppropriationTab.Location = new System.Drawing.Point(1, 44);
            this.AppropriationTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AppropriationTab.Name = "AppropriationTab";
            this.AppropriationTab.Padding = new System.Windows.Forms.Padding(1);
            this.AppropriationTab.ShowCloseButton = true;
            this.AppropriationTab.Size = new System.Drawing.Size(1786, 829);
            this.AppropriationTab.TabIndex = 6;
            this.AppropriationTab.Text = "Appropriations";
            this.AppropriationTab.ThemesEnabled = false;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(1, 1);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.panel13);
            this.splitContainer5.Panel1.Controls.Add(this.AppropChart);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer5.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer5.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer5.Size = new System.Drawing.Size(1784, 827);
            this.splitContainer5.SplitterDistance = 1504;
            this.splitContainer5.SplitterWidth = 3;
            this.splitContainer5.TabIndex = 96;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.rb1);
            this.panel13.Controls.Add(this.rb3);
            this.panel13.Controls.Add(this.rb2);
            this.panel13.Controls.Add(this.rb4);
            this.panel13.Location = new System.Drawing.Point(747, 3);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(1);
            this.panel13.Size = new System.Drawing.Size(529, 49);
            this.panel13.TabIndex = 43;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(3, 9);
            this.rb1.Margin = new System.Windows.Forms.Padding(2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(66, 25);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "BOC";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(147, 9);
            this.rb3.Margin = new System.Windows.Forms.Padding(2);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(132, 25);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "Program Area";
            this.rb3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(73, 9);
            this.rb2.Margin = new System.Windows.Forms.Padding(2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(70, 25);
            this.rb2.TabIndex = 2;
            this.rb2.Text = "NPM";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(283, 9);
            this.rb4.Margin = new System.Windows.Forms.Padding(2);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(148, 25);
            this.rb4.TabIndex = 4;
            this.rb4.Text = "Program Project";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // AppropChart
            // 
            this.AppropChart.AllowGradientPalette = true;
            this.AppropChart.AllowUserEditStyles = true;
            this.AppropChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.AppropChart.ChartArea.AutoScale = true;
            this.AppropChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.AppropChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.AppropChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.AppropChart.ChartArea.CursorReDraw = false;
            this.AppropChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.AppropChart.ChartAreaShadow = true;
            this.AppropChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.AppropChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.AppropChart.DataSourceName = "[none]";
            this.AppropChart.Depth = 250F;
            this.AppropChart.DisplayChartContextMenu = false;
            this.AppropChart.DisplaySeriesContextMenu = false;
            this.AppropChart.EnableMouseRotation = true;
            this.AppropChart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppropChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AppropChart.HighlightSymbol = true;
            this.AppropChart.IsWindowLess = false;
            // 
            // 
            // 
            this.AppropChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.AppropChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.AppropChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.AppropChart.Legend.Visible = false;
            this.AppropChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.AppropChart.Localize = null;
            this.AppropChart.Location = new System.Drawing.Point(19, 69);
            this.AppropChart.Margin = new System.Windows.Forms.Padding(2);
            this.AppropChart.Name = "AppropChart";
            this.AppropChart.Padding = new System.Windows.Forms.Padding(1);
            this.AppropChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.AppropChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppropChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AppropChart.PrimaryXAxis.Margin = true;
            this.AppropChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.AppropChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AppropChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppropChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AppropChart.PrimaryYAxis.Margin = true;
            this.AppropChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AppropChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.AppropChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AppropChart.RealMode3D = true;
            this.AppropChart.Rotation = 45F;
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
            this.AppropChart.Series.Add(chartSeries1);
            this.AppropChart.Series.Add(chartSeries2);
            this.AppropChart.Series3D = true;
            this.AppropChart.SeriesHighlight = true;
            this.AppropChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AppropChart.Size = new System.Drawing.Size(1387, 655);
            this.AppropChart.Spacing = 5F;
            this.AppropChart.SpacingBetweenPoints = 5F;
            this.AppropChart.Style3D = true;
            this.AppropChart.TabIndex = 42;
            this.AppropChart.Tilt = 15F;
            // 
            // 
            // 
            this.AppropChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AppropChart.Title.Name = "Default";
            this.AppropChart.ToolBar.EnableDefaultItems = false;
            this.AppropChart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            // 
            // expandCollapsePanel3
            // 
            this.expandCollapsePanel3.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel3.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel3.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel3.Controls.Add(this.panel1);
            this.expandCollapsePanel3.ExpandedHeight = 611;
            this.expandCollapsePanel3.IsExpanded = false;
            this.expandCollapsePanel3.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel3.Name = "expandCollapsePanel3";
            this.expandCollapsePanel3.Size = new System.Drawing.Size(213, 37);
            this.expandCollapsePanel3.TabIndex = 44;
            this.expandCollapsePanel3.Text = "Selection";
            this.expandCollapsePanel3.UseAnimation = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(16, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 347);
            this.panel1.TabIndex = 1;
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ImageBox.FormattingEnabled = true;
            this.ImageBox.ItemHeight = 21;
            this.ImageBox.Location = new System.Drawing.Point(317, 544);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(122, 65);
            this.ImageBox.TabIndex = 93;
            // 
            // approplistbox
            // 
            this.approplistbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approplistbox.BackColor = System.Drawing.Color.Black;
            this.approplistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.approplistbox.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approplistbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.approplistbox.FormattingEnabled = true;
            this.approplistbox.ItemHeight = 29;
            this.approplistbox.Location = new System.Drawing.Point(204, 568);
            this.approplistbox.Margin = new System.Windows.Forms.Padding(0);
            this.approplistbox.Name = "approplistbox";
            this.approplistbox.Size = new System.Drawing.Size(616, 261);
            this.approplistbox.TabIndex = 48;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(25, 567);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(137, 42);
            this.metroButton1.TabIndex = 46;
            this.metroButton1.Text = "Account Detail";
            // 
            // BocTab
            // 
            this.BocTab.Controls.Add(this.splitContainer2);
            this.BocTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BocTab.Image = null;
            this.BocTab.ImageSize = new System.Drawing.Size(40, 35);
            this.BocTab.Location = new System.Drawing.Point(1, 44);
            this.BocTab.Margin = new System.Windows.Forms.Padding(2);
            this.BocTab.Name = "BocTab";
            this.BocTab.ShowCloseButton = true;
            this.BocTab.Size = new System.Drawing.Size(1786, 829);
            this.BocTab.TabIndex = 9;
            this.BocTab.Text = "BOC";
            this.BocTab.ThemesEnabled = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel6);
            this.splitContainer2.Panel1.Controls.Add(this.BocChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer2.Size = new System.Drawing.Size(1786, 829);
            this.splitContainer2.SplitterDistance = 1504;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 97;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rb5);
            this.panel6.Controls.Add(this.rb7);
            this.panel6.Controls.Add(this.rb6);
            this.panel6.Controls.Add(this.rb8);
            this.panel6.Location = new System.Drawing.Point(747, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(676, 48);
            this.panel6.TabIndex = 44;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Checked = true;
            this.rb5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(10, 3);
            this.rb5.Margin = new System.Windows.Forms.Padding(2);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(70, 25);
            this.rb5.TabIndex = 0;
            this.rb5.TabStop = true;
            this.rb5.Text = "Fund";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7.Location = new System.Drawing.Point(158, 3);
            this.rb7.Margin = new System.Windows.Forms.Padding(2);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(132, 25);
            this.rb7.TabIndex = 3;
            this.rb7.Text = "Program Area";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb6.Location = new System.Drawing.Point(84, 3);
            this.rb6.Margin = new System.Windows.Forms.Padding(2);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(70, 25);
            this.rb6.TabIndex = 2;
            this.rb6.Text = "NPM";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8.Location = new System.Drawing.Point(294, 3);
            this.rb8.Margin = new System.Windows.Forms.Padding(2);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(148, 25);
            this.rb8.TabIndex = 4;
            this.rb8.Text = "Program Project";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // BocChart
            // 
            this.BocChart.AllowGradientPalette = true;
            this.BocChart.AllowUserEditStyles = true;
            this.BocChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.BocChart.ChartArea.AutoScale = true;
            this.BocChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.BocChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.BocChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.BocChart.ChartArea.CursorReDraw = false;
            this.BocChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.BocChart.ChartAreaShadow = true;
            this.BocChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.BocChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.BocChart.DataSourceName = "[none]";
            this.BocChart.Depth = 250F;
            this.BocChart.DisplayChartContextMenu = false;
            this.BocChart.DisplaySeriesContextMenu = false;
            this.BocChart.EnableMouseRotation = true;
            this.BocChart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BocChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BocChart.HighlightSymbol = true;
            this.BocChart.IsWindowLess = false;
            // 
            // 
            // 
            this.BocChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.BocChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.BocChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.BocChart.Legend.Visible = false;
            this.BocChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.BocChart.Localize = null;
            this.BocChart.Location = new System.Drawing.Point(19, 69);
            this.BocChart.Margin = new System.Windows.Forms.Padding(2);
            this.BocChart.Name = "BocChart";
            this.BocChart.Padding = new System.Windows.Forms.Padding(1);
            this.BocChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.BocChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BocChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.BocChart.PrimaryXAxis.Margin = true;
            this.BocChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.BocChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.BocChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BocChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.BocChart.PrimaryYAxis.Margin = true;
            this.BocChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.BocChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.BocChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.BocChart.RealMode3D = true;
            this.BocChart.Rotation = 45F;
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
            this.BocChart.Series.Add(chartSeries3);
            this.BocChart.Series.Add(chartSeries4);
            this.BocChart.Series3D = true;
            this.BocChart.SeriesHighlight = true;
            this.BocChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.BocChart.Size = new System.Drawing.Size(1387, 655);
            this.BocChart.Spacing = 5F;
            this.BocChart.SpacingBetweenPoints = 5F;
            this.BocChart.Style3D = true;
            this.BocChart.TabIndex = 45;
            this.BocChart.Tilt = 15F;
            // 
            // 
            // 
            this.BocChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.BocChart.Title.Name = "Default";
            this.BocChart.ToolBar.EnableDefaultItems = false;
            this.BocChart.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarSplitter2);
            this.BocChart.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.panel2);
            this.expandCollapsePanel2.ExpandedHeight = 559;
            this.expandCollapsePanel2.IsExpanded = false;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(210, 37);
            this.expandCollapsePanel2.TabIndex = 46;
            this.expandCollapsePanel2.Text = "Object Class";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(31, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 453);
            this.panel2.TabIndex = 1;
            // 
            // NpmTab
            // 
            this.NpmTab.Controls.Add(this.splitContainer3);
            this.NpmTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmTab.Image = null;
            this.NpmTab.ImageSize = new System.Drawing.Size(16, 16);
            this.NpmTab.Location = new System.Drawing.Point(1, 44);
            this.NpmTab.Margin = new System.Windows.Forms.Padding(2);
            this.NpmTab.Name = "NpmTab";
            this.NpmTab.ShowCloseButton = true;
            this.NpmTab.Size = new System.Drawing.Size(1786, 829);
            this.NpmTab.TabIndex = 10;
            this.NpmTab.Text = "NPM";
            this.NpmTab.ThemesEnabled = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel7);
            this.splitContainer3.Panel1.Controls.Add(this.NpmChart);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer3.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer3.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer3.Size = new System.Drawing.Size(1786, 829);
            this.splitContainer3.SplitterDistance = 1504;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 97;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rb9);
            this.panel7.Controls.Add(this.rb10);
            this.panel7.Controls.Add(this.rb11);
            this.panel7.Controls.Add(this.rb12);
            this.panel7.Location = new System.Drawing.Point(747, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1);
            this.panel7.Size = new System.Drawing.Size(566, 52);
            this.panel7.TabIndex = 44;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Checked = true;
            this.rb9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9.Location = new System.Drawing.Point(10, 3);
            this.rb9.Margin = new System.Windows.Forms.Padding(2);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(70, 25);
            this.rb9.TabIndex = 0;
            this.rb9.TabStop = true;
            this.rb9.Text = "Fund";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10.Location = new System.Drawing.Point(84, 3);
            this.rb10.Margin = new System.Windows.Forms.Padding(2);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(66, 25);
            this.rb10.TabIndex = 1;
            this.rb10.Text = "BOC";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb11.Location = new System.Drawing.Point(154, 3);
            this.rb11.Margin = new System.Windows.Forms.Padding(2);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(132, 25);
            this.rb11.TabIndex = 3;
            this.rb11.Text = "Program Area";
            this.rb11.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb12.Location = new System.Drawing.Point(290, 3);
            this.rb12.Margin = new System.Windows.Forms.Padding(2);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(148, 25);
            this.rb12.TabIndex = 4;
            this.rb12.Text = "Program Project";
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // NpmChart
            // 
            this.NpmChart.AllowGradientPalette = true;
            this.NpmChart.AllowUserEditStyles = true;
            this.NpmChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.NpmChart.ChartArea.AutoScale = true;
            this.NpmChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.NpmChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.NpmChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.NpmChart.ChartArea.CursorReDraw = false;
            this.NpmChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.NpmChart.ChartAreaShadow = true;
            this.NpmChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.NpmChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.NpmChart.DataSourceName = "[none]";
            this.NpmChart.Depth = 250F;
            this.NpmChart.DisplayChartContextMenu = false;
            this.NpmChart.DisplaySeriesContextMenu = false;
            this.NpmChart.EnableMouseRotation = true;
            this.NpmChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NpmChart.HighlightSymbol = true;
            this.NpmChart.IsWindowLess = false;
            // 
            // 
            // 
            this.NpmChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.NpmChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.NpmChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.NpmChart.Legend.Visible = false;
            this.NpmChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.NpmChart.Localize = null;
            this.NpmChart.Location = new System.Drawing.Point(19, 69);
            this.NpmChart.Margin = new System.Windows.Forms.Padding(2);
            this.NpmChart.Name = "NpmChart";
            this.NpmChart.Padding = new System.Windows.Forms.Padding(1);
            this.NpmChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.NpmChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.NpmChart.PrimaryXAxis.Margin = true;
            this.NpmChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.NpmChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.NpmChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.NpmChart.PrimaryYAxis.Margin = true;
            this.NpmChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.NpmChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.NpmChart.RealMode3D = true;
            this.NpmChart.Rotation = 45F;
            chartSeries5.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries5.Name = "Default0";
            chartSeries5.Points.Add(1D, ((double)(55D)));
            chartSeries5.Points.Add(2D, ((double)(70D)));
            chartSeries5.Points.Add(3D, ((double)(80D)));
            chartSeries5.Points.Add(4D, ((double)(65D)));
            chartSeries5.Points.Add(5D, ((double)(75D)));
            chartSeries5.Resolution = 0D;
            chartSeries5.StackingGroup = "Default Group";
            chartSeries5.Style.AltTagFormat = "";
            chartSeries5.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries5.Style.DrawTextShape = false;
            chartSeries5.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo3.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo3.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo3.DashPattern = null;
            chartLineInfo3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo3.Width = 1F;
            chartCustomShapeInfo5.Border = chartLineInfo3;
            chartCustomShapeInfo5.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo5.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries5.Style.TextShape = chartCustomShapeInfo5;
            chartSeries5.Text = "Default0";
            chartSeries6.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries6.Name = "Default1";
            chartSeries6.Points.Add(1D, ((double)(70D)));
            chartSeries6.Points.Add(2D, ((double)(35D)));
            chartSeries6.Points.Add(3D, ((double)(65D)));
            chartSeries6.Points.Add(4D, ((double)(25D)));
            chartSeries6.Points.Add(5D, ((double)(50D)));
            chartSeries6.Resolution = 0D;
            chartSeries6.StackingGroup = "Default Group";
            chartSeries6.Style.AltTagFormat = "";
            chartSeries6.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries6.Style.DrawTextShape = false;
            chartSeries6.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo6.Border = chartLineInfo3;
            chartCustomShapeInfo6.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo6.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries6.Style.TextShape = chartCustomShapeInfo6;
            chartSeries6.Text = "Default1";
            this.NpmChart.Series.Add(chartSeries5);
            this.NpmChart.Series.Add(chartSeries6);
            this.NpmChart.Series3D = true;
            this.NpmChart.SeriesHighlight = true;
            this.NpmChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.NpmChart.Size = new System.Drawing.Size(1387, 655);
            this.NpmChart.Spacing = 5F;
            this.NpmChart.SpacingBetweenPoints = 5F;
            this.NpmChart.Style3D = true;
            this.NpmChart.TabIndex = 42;
            this.NpmChart.Tilt = 15F;
            // 
            // 
            // 
            this.NpmChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.NpmChart.Title.Name = "Default";
            this.NpmChart.ToolBar.EnableDefaultItems = false;
            this.NpmChart.ToolBar.Items.Add(chartToolBarSaveItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarCopyItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPrintItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSplitter3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarStyleItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // expandCollapsePanel6
            // 
            this.expandCollapsePanel6.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel6.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel6.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel6.Controls.Add(this.panel3);
            this.expandCollapsePanel6.ExpandedHeight = 626;
            this.expandCollapsePanel6.IsExpanded = false;
            this.expandCollapsePanel6.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel6.Name = "expandCollapsePanel6";
            this.expandCollapsePanel6.Size = new System.Drawing.Size(222, 37);
            this.expandCollapsePanel6.TabIndex = 105;
            this.expandCollapsePanel6.Text = "Select NPM";
            this.expandCollapsePanel6.UseAnimation = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(33, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 308);
            this.panel3.TabIndex = 1;
            // 
            // ProgramTab
            // 
            this.ProgramTab.Controls.Add(this.splitContainer1);
            this.ProgramTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTab.Image = null;
            this.ProgramTab.ImageSize = new System.Drawing.Size(50, 30);
            this.ProgramTab.Location = new System.Drawing.Point(1, 44);
            this.ProgramTab.Margin = new System.Windows.Forms.Padding(2);
            this.ProgramTab.Name = "ProgramTab";
            this.ProgramTab.ShowCloseButton = true;
            this.ProgramTab.Size = new System.Drawing.Size(1786, 829);
            this.ProgramTab.TabIndex = 8;
            this.ProgramTab.Text = "Program Area";
            this.ProgramTab.ThemesEnabled = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel8);
            this.splitContainer1.Panel1.Controls.Add(this.AreaChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer1.Size = new System.Drawing.Size(1786, 829);
            this.splitContainer1.SplitterDistance = 1504;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 97;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rb13);
            this.panel8.Controls.Add(this.rb14);
            this.panel8.Controls.Add(this.rb15);
            this.panel8.Controls.Add(this.rb16);
            this.panel8.Location = new System.Drawing.Point(747, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(1);
            this.panel8.Size = new System.Drawing.Size(577, 51);
            this.panel8.TabIndex = 44;
            // 
            // rb13
            // 
            this.rb13.AutoSize = true;
            this.rb13.Checked = true;
            this.rb13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb13.Location = new System.Drawing.Point(10, 3);
            this.rb13.Margin = new System.Windows.Forms.Padding(2);
            this.rb13.Name = "rb13";
            this.rb13.Size = new System.Drawing.Size(70, 25);
            this.rb13.TabIndex = 0;
            this.rb13.TabStop = true;
            this.rb13.Text = "Fund";
            this.rb13.UseVisualStyleBackColor = true;
            // 
            // rb14
            // 
            this.rb14.AutoSize = true;
            this.rb14.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb14.Location = new System.Drawing.Point(84, 3);
            this.rb14.Margin = new System.Windows.Forms.Padding(2);
            this.rb14.Name = "rb14";
            this.rb14.Size = new System.Drawing.Size(66, 25);
            this.rb14.TabIndex = 1;
            this.rb14.Text = "BOC";
            this.rb14.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb15.Location = new System.Drawing.Point(154, 4);
            this.rb15.Margin = new System.Windows.Forms.Padding(2);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(70, 25);
            this.rb15.TabIndex = 2;
            this.rb15.Text = "NPM";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb16.Location = new System.Drawing.Point(228, 4);
            this.rb16.Margin = new System.Windows.Forms.Padding(2);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(148, 25);
            this.rb16.TabIndex = 4;
            this.rb16.Text = "Program Project";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // AreaChart
            // 
            this.AreaChart.AllowGradientPalette = true;
            this.AreaChart.AllowUserEditStyles = true;
            this.AreaChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.AreaChart.ChartArea.AutoScale = true;
            this.AreaChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.AreaChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.AreaChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.AreaChart.ChartArea.CursorReDraw = false;
            this.AreaChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.AreaChart.ChartAreaShadow = true;
            this.AreaChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.AreaChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.AreaChart.DataSourceName = "[none]";
            this.AreaChart.Depth = 250F;
            this.AreaChart.DisplayChartContextMenu = false;
            this.AreaChart.DisplaySeriesContextMenu = false;
            this.AreaChart.EnableMouseRotation = true;
            this.AreaChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AreaChart.HighlightSymbol = true;
            this.AreaChart.IsWindowLess = false;
            // 
            // 
            // 
            this.AreaChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.AreaChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.AreaChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.AreaChart.Legend.Visible = false;
            this.AreaChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.AreaChart.Localize = null;
            this.AreaChart.Location = new System.Drawing.Point(19, 69);
            this.AreaChart.Margin = new System.Windows.Forms.Padding(2);
            this.AreaChart.Name = "AreaChart";
            this.AreaChart.Padding = new System.Windows.Forms.Padding(1);
            this.AreaChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.AreaChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AreaChart.PrimaryXAxis.Margin = true;
            this.AreaChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.AreaChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AreaChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AreaChart.PrimaryYAxis.Margin = true;
            this.AreaChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AreaChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.AreaChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AreaChart.RealMode3D = true;
            this.AreaChart.Rotation = 45F;
            chartSeries7.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries7.Name = "Default0";
            chartSeries7.Points.Add(1D, ((double)(55D)));
            chartSeries7.Points.Add(2D, ((double)(70D)));
            chartSeries7.Points.Add(3D, ((double)(80D)));
            chartSeries7.Points.Add(4D, ((double)(65D)));
            chartSeries7.Points.Add(5D, ((double)(75D)));
            chartSeries7.Resolution = 0D;
            chartSeries7.StackingGroup = "Default Group";
            chartSeries7.Style.AltTagFormat = "";
            chartSeries7.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries7.Style.DrawTextShape = false;
            chartSeries7.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo4.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo4.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo4.DashPattern = null;
            chartLineInfo4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo4.Width = 1F;
            chartCustomShapeInfo7.Border = chartLineInfo4;
            chartCustomShapeInfo7.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo7.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries7.Style.TextShape = chartCustomShapeInfo7;
            chartSeries7.Text = "Default0";
            chartSeries8.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries8.Name = "Default1";
            chartSeries8.Points.Add(1D, ((double)(70D)));
            chartSeries8.Points.Add(2D, ((double)(35D)));
            chartSeries8.Points.Add(3D, ((double)(65D)));
            chartSeries8.Points.Add(4D, ((double)(25D)));
            chartSeries8.Points.Add(5D, ((double)(50D)));
            chartSeries8.Resolution = 0D;
            chartSeries8.StackingGroup = "Default Group";
            chartSeries8.Style.AltTagFormat = "";
            chartSeries8.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries8.Style.DrawTextShape = false;
            chartSeries8.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo8.Border = chartLineInfo4;
            chartCustomShapeInfo8.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo8.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries8.Style.TextShape = chartCustomShapeInfo8;
            chartSeries8.Text = "Default1";
            this.AreaChart.Series.Add(chartSeries7);
            this.AreaChart.Series.Add(chartSeries8);
            this.AreaChart.Series3D = true;
            this.AreaChart.SeriesHighlight = true;
            this.AreaChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AreaChart.Size = new System.Drawing.Size(1387, 655);
            this.AreaChart.Spacing = 5F;
            this.AreaChart.SpacingBetweenPoints = 5F;
            this.AreaChart.Style3D = true;
            this.AreaChart.TabIndex = 42;
            this.AreaChart.Tilt = 15F;
            // 
            // 
            // 
            this.AreaChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AreaChart.Title.Name = "Default";
            this.AreaChart.ToolBar.EnableDefaultItems = false;
            this.AreaChart.ToolBar.Items.Add(chartToolBarSaveItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarCopyItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPrintItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarSplitter4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarStyleItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.AreaChart.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // expandCollapsePanel5
            // 
            this.expandCollapsePanel5.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel5.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel5.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel5.Controls.Add(this.panel4);
            this.expandCollapsePanel5.ExpandedHeight = 674;
            this.expandCollapsePanel5.IsExpanded = false;
            this.expandCollapsePanel5.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel5.Name = "expandCollapsePanel5";
            this.expandCollapsePanel5.Size = new System.Drawing.Size(227, 37);
            this.expandCollapsePanel5.TabIndex = 105;
            this.expandCollapsePanel5.Text = "Select Program Area";
            this.expandCollapsePanel5.UseAnimation = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(35, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 544);
            this.panel4.TabIndex = 1;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.splitContainer4);
            this.ProjectTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTab.Image = null;
            this.ProjectTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ProjectTab.Location = new System.Drawing.Point(1, 44);
            this.ProjectTab.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.ShowCloseButton = true;
            this.ProjectTab.Size = new System.Drawing.Size(1786, 829);
            this.ProjectTab.TabIndex = 11;
            this.ProjectTab.Text = "Program Project";
            this.ProjectTab.ThemesEnabled = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.panel9);
            this.splitContainer4.Panel1.Controls.Add(this.ProjectChart);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel8);
            this.splitContainer4.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer4.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer4.Size = new System.Drawing.Size(1786, 829);
            this.splitContainer4.SplitterDistance = 1504;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 98;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.rb17);
            this.panel9.Controls.Add(this.rb18);
            this.panel9.Controls.Add(this.rb20);
            this.panel9.Controls.Add(this.rb19);
            this.panel9.Location = new System.Drawing.Point(747, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(1);
            this.panel9.Size = new System.Drawing.Size(508, 46);
            this.panel9.TabIndex = 44;
            // 
            // rb17
            // 
            this.rb17.AutoSize = true;
            this.rb17.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb17.Location = new System.Drawing.Point(10, 3);
            this.rb17.Margin = new System.Windows.Forms.Padding(2);
            this.rb17.Name = "rb17";
            this.rb17.Size = new System.Drawing.Size(70, 25);
            this.rb17.TabIndex = 0;
            this.rb17.Text = "Fund";
            this.rb17.UseVisualStyleBackColor = true;
            // 
            // rb18
            // 
            this.rb18.AutoSize = true;
            this.rb18.Checked = true;
            this.rb18.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb18.Location = new System.Drawing.Point(84, 4);
            this.rb18.Margin = new System.Windows.Forms.Padding(2);
            this.rb18.Name = "rb18";
            this.rb18.Size = new System.Drawing.Size(66, 25);
            this.rb18.TabIndex = 1;
            this.rb18.TabStop = true;
            this.rb18.Text = "BOC";
            this.rb18.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb20.Location = new System.Drawing.Point(228, 4);
            this.rb20.Margin = new System.Windows.Forms.Padding(2);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(132, 25);
            this.rb20.TabIndex = 3;
            this.rb20.Text = "Program Area";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // rb19
            // 
            this.rb19.AutoSize = true;
            this.rb19.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb19.Location = new System.Drawing.Point(154, 4);
            this.rb19.Margin = new System.Windows.Forms.Padding(2);
            this.rb19.Name = "rb19";
            this.rb19.Size = new System.Drawing.Size(70, 25);
            this.rb19.TabIndex = 2;
            this.rb19.Text = "NPM";
            this.rb19.UseVisualStyleBackColor = true;
            // 
            // ProjectChart
            // 
            this.ProjectChart.AllowGradientPalette = true;
            this.ProjectChart.AllowUserEditStyles = true;
            this.ProjectChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.ProjectChart.ChartArea.AutoScale = true;
            this.ProjectChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.ProjectChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.ProjectChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.ProjectChart.ChartArea.CursorReDraw = false;
            this.ProjectChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.ProjectChart.ChartAreaShadow = true;
            this.ProjectChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.ProjectChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.ProjectChart.DataSourceName = "[none]";
            this.ProjectChart.Depth = 250F;
            this.ProjectChart.DisplayChartContextMenu = false;
            this.ProjectChart.DisplaySeriesContextMenu = false;
            this.ProjectChart.EnableMouseRotation = true;
            this.ProjectChart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProjectChart.HighlightSymbol = true;
            this.ProjectChart.IsWindowLess = false;
            // 
            // 
            // 
            this.ProjectChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.ProjectChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.ProjectChart.Legend.Visible = false;
            this.ProjectChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.ProjectChart.Localize = null;
            this.ProjectChart.Location = new System.Drawing.Point(19, 73);
            this.ProjectChart.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectChart.Name = "ProjectChart";
            this.ProjectChart.Padding = new System.Windows.Forms.Padding(1);
            this.ProjectChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.ProjectChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ProjectChart.PrimaryXAxis.Margin = true;
            this.ProjectChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.ProjectChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ProjectChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ProjectChart.PrimaryYAxis.Margin = true;
            this.ProjectChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProjectChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.ProjectChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ProjectChart.RealMode3D = true;
            this.ProjectChart.Rotation = 45F;
            chartSeries9.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries9.Name = "Default0";
            chartSeries9.Points.Add(1D, ((double)(55D)));
            chartSeries9.Points.Add(2D, ((double)(70D)));
            chartSeries9.Points.Add(3D, ((double)(80D)));
            chartSeries9.Points.Add(4D, ((double)(65D)));
            chartSeries9.Points.Add(5D, ((double)(75D)));
            chartSeries9.Resolution = 0D;
            chartSeries9.StackingGroup = "Default Group";
            chartSeries9.Style.AltTagFormat = "";
            chartSeries9.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries9.Style.DrawTextShape = false;
            chartSeries9.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo5.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo5.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo5.DashPattern = null;
            chartLineInfo5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo5.Width = 1F;
            chartCustomShapeInfo9.Border = chartLineInfo5;
            chartCustomShapeInfo9.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo9.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries9.Style.TextShape = chartCustomShapeInfo9;
            chartSeries9.Text = "Default0";
            chartSeries10.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries10.Name = "Default1";
            chartSeries10.Points.Add(1D, ((double)(70D)));
            chartSeries10.Points.Add(2D, ((double)(35D)));
            chartSeries10.Points.Add(3D, ((double)(65D)));
            chartSeries10.Points.Add(4D, ((double)(25D)));
            chartSeries10.Points.Add(5D, ((double)(50D)));
            chartSeries10.Resolution = 0D;
            chartSeries10.StackingGroup = "Default Group";
            chartSeries10.Style.AltTagFormat = "";
            chartSeries10.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries10.Style.DrawTextShape = false;
            chartSeries10.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo10.Border = chartLineInfo5;
            chartCustomShapeInfo10.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo10.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries10.Style.TextShape = chartCustomShapeInfo10;
            chartSeries10.Text = "Default1";
            this.ProjectChart.Series.Add(chartSeries9);
            this.ProjectChart.Series.Add(chartSeries10);
            this.ProjectChart.Series3D = true;
            this.ProjectChart.SeriesHighlight = true;
            this.ProjectChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ProjectChart.Size = new System.Drawing.Size(1387, 655);
            this.ProjectChart.Spacing = 5F;
            this.ProjectChart.SpacingBetweenPoints = 5F;
            this.ProjectChart.Style3D = true;
            this.ProjectChart.TabIndex = 42;
            this.ProjectChart.Tilt = 15F;
            // 
            // 
            // 
            this.ProjectChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ProjectChart.Title.Name = "Default";
            this.ProjectChart.ToolBar.EnableDefaultItems = false;
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSaveItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarCopyItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPrintItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSplitter5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPaletteItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarStyleItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarTypeItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSeries3DItem5);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarShowLegendItem5);
            // 
            // expandCollapsePanel4
            // 
            this.expandCollapsePanel4.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel4.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel4.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel4.Controls.Add(this.panel5);
            this.expandCollapsePanel4.ExpandedHeight = 655;
            this.expandCollapsePanel4.IsExpanded = false;
            this.expandCollapsePanel4.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel4.Name = "expandCollapsePanel4";
            this.expandCollapsePanel4.Size = new System.Drawing.Size(233, 37);
            this.expandCollapsePanel4.TabIndex = 105;
            this.expandCollapsePanel4.Text = "Select Program Project";
            this.expandCollapsePanel4.UseAnimation = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(30, 53);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 544);
            this.panel5.TabIndex = 1;
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.tableLayoutPanel3);
            this.DataTab.Controls.Add(this.tabControlAdv1);
            this.DataTab.Controls.Add(this.groupBox1);
            this.DataTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTab.Image = null;
            this.DataTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DataTab.Location = new System.Drawing.Point(1, 44);
            this.DataTab.Name = "DataTab";
            this.DataTab.ShowCloseButton = true;
            this.DataTab.Size = new System.Drawing.Size(1786, 829);
            this.DataTab.TabIndex = 12;
            this.DataTab.Text = "Database";
            this.DataTab.ThemesEnabled = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Expander, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(91, 74);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(270, 497);
            this.tableLayoutPanel3.TabIndex = 151;
            // 
            // Expander
            // 
            this.Expander.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Expander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.Expander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.Expander.Controls.Add(this.P7FilterPanel);
            this.Expander.ExpandedHeight = 472;
            this.Expander.IsExpanded = false;
            this.Expander.Location = new System.Drawing.Point(2, 2);
            this.Expander.Margin = new System.Windows.Forms.Padding(2);
            this.Expander.Name = "Expander";
            this.Expander.Padding = new System.Windows.Forms.Padding(1);
            this.Expander.Size = new System.Drawing.Size(256, 37);
            this.Expander.TabIndex = 118;
            this.Expander.Text = "Select";
            this.Expander.UseAnimation = true;
            // 
            // P7FilterPanel
            // 
            this.P7FilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.P7FilterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.P7FilterPanel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P7FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.P7FilterPanel.Location = new System.Drawing.Point(22, 59);
            this.P7FilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.P7FilterPanel.Name = "P7FilterPanel";
            this.P7FilterPanel.Size = new System.Drawing.Size(215, 613);
            this.P7FilterPanel.TabIndex = 136;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(465, 494);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(1297, 76);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(465, 494);
            this.tabControlAdv1.TabIndex = 150;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPageAdv1.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(463, 463);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.OldAmount, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroTextBox7, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(67, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07692F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 221);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(131, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 162;
            this.label13.Text = "New:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldAmount
            // 
            // 
            this.OldAmount.Location = new System.Drawing.Point(2, 171);
            this.OldAmount.Margin = new System.Windows.Forms.Padding(2);
            this.OldAmount.MaxLength = 32767;
            this.OldAmount.Name = "OldAmount";
            this.OldAmount.PasswordChar = '\0';
            this.OldAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldAmount.SelectedText = "";
            this.OldAmount.Size = new System.Drawing.Size(93, 28);
            this.OldAmount.TabIndex = 154;
            this.OldAmount.Text = "metroTextBox1";
            this.OldAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(14, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Amount:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox1
            // 
            // 
            // 
            this.metroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Location = new System.Drawing.Point(212, 88);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(111, 37);
            this.metroTextBox1.TabIndex = 155;
            this.metroTextBox1.Text = "metroTextBox2";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // metroTextBox2
            // 
            // 
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(99, 88);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(30, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 140;
            this.label2.Text = "BFY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox3
            // 
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(129, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fund:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(243, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Code:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox4
            // 
            // 
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(137, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 21);
            this.label11.TabIndex = 63;
            this.label11.Text = "RC:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(245, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 66;
            this.label14.Text = "BOC:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(28, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 21);
            this.label16.TabIndex = 62;
            this.label16.Text = "Org:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox5
            // 
            // 
            // 
            // metroTextBox6
            // 
            // 
            // 
            // metroTextBox7
            // 
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.chartControl1);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(463, 463);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // chartControl1
            // 
            this.chartControl1.AllowGradientPalette = true;
            this.chartControl1.AllowUserEditStyles = true;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.chartControl1.ChartArea.AutoScale = true;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
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
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.Depth = 250F;
            this.chartControl1.DisplayChartContextMenu = false;
            this.chartControl1.DisplaySeriesContextMenu = false;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
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
            this.chartControl1.RealMode3D = true;
            this.chartControl1.Rotation = 45F;
            chartSeries11.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries11.Name = "Default0";
            chartSeries11.Points.Add(1D, ((double)(55D)));
            chartSeries11.Points.Add(2D, ((double)(70D)));
            chartSeries11.Points.Add(3D, ((double)(80D)));
            chartSeries11.Points.Add(4D, ((double)(65D)));
            chartSeries11.Points.Add(5D, ((double)(75D)));
            chartSeries11.Resolution = 0D;
            chartSeries11.StackingGroup = "Default Group";
            chartSeries11.Style.AltTagFormat = "";
            chartSeries11.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries11.Style.DrawTextShape = false;
            chartSeries11.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo6.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo6.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo6.DashPattern = null;
            chartLineInfo6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo6.Width = 1F;
            chartCustomShapeInfo11.Border = chartLineInfo6;
            chartCustomShapeInfo11.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo11.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries11.Style.TextShape = chartCustomShapeInfo11;
            chartSeries11.Text = "Default0";
            chartSeries12.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries12.Name = "Default1";
            chartSeries12.Points.Add(1D, ((double)(70D)));
            chartSeries12.Points.Add(2D, ((double)(35D)));
            chartSeries12.Points.Add(3D, ((double)(65D)));
            chartSeries12.Points.Add(4D, ((double)(25D)));
            chartSeries12.Points.Add(5D, ((double)(50D)));
            chartSeries12.Resolution = 0D;
            chartSeries12.StackingGroup = "Default Group";
            chartSeries12.Style.AltTagFormat = "";
            chartSeries12.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries12.Style.DrawTextShape = false;
            chartSeries12.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo12.Border = chartLineInfo6;
            chartCustomShapeInfo12.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo12.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries12.Style.TextShape = chartCustomShapeInfo12;
            chartSeries12.Text = "Default1";
            this.chartControl1.Series.Add(chartSeries11);
            this.chartControl1.Series.Add(chartSeries12);
            this.chartControl1.Series3D = true;
            this.chartControl1.SeriesHighlight = true;
            this.chartControl1.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.chartControl1.Size = new System.Drawing.Size(463, 463);
            this.chartControl1.Spacing = 5F;
            this.chartControl1.SpacingBetweenPoints = 5F;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 46;
            this.chartControl1.Tilt = 15F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem6);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox1.Controls.Add(this.ReturnButton);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.DatabaseGridPanel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(416, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(818, 496);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regional Database";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Location = new System.Drawing.Point(619, 47);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(34, 26);
            this.ReturnButton.TabIndex = 147;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Info;
            this.label17.Location = new System.Drawing.Point(119, 52);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 21);
            this.label17.TabIndex = 119;
            this.label17.Text = "label46";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Info;
            this.label18.Location = new System.Drawing.Point(492, 52);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 21);
            this.label18.TabIndex = 120;
            this.label18.Text = "label45";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Info;
            this.label19.Location = new System.Drawing.Point(60, 52);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 21);
            this.label19.TabIndex = 121;
            this.label19.Text = "Total: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.Info;
            this.label20.Location = new System.Drawing.Point(401, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 122;
            this.label20.Text = "Accounts: ";
            // 
            // DatabaseGridPanel
            // 
            this.DatabaseGridPanel.Controls.Add(this.Grid);
            this.DatabaseGridPanel.Controls.Add(this.DataNavigator);
            this.DatabaseGridPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseGridPanel.Location = new System.Drawing.Point(57, 86);
            this.DatabaseGridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DatabaseGridPanel.Name = "DatabaseGridPanel";
            this.DatabaseGridPanel.Size = new System.Drawing.Size(711, 349);
            this.DatabaseGridPanel.TabIndex = 123;
            // 
            // Grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(711, 318);
            this.Grid.TabIndex = 153;
            // 
            // DataNavigator
            // 
            this.DataNavigator.AddNewItem = this.toolStripButton1;
            this.DataNavigator.BackColor = System.Drawing.Color.Transparent;
            this.DataNavigator.CountItem = this.toolStripLabel1;
            this.DataNavigator.DeleteItem = this.toolStripButton2;
            this.DataNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataNavigator.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DataNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.toolStripButton5,
            this.toolStripSeparator7,
            this.toolStripButton6,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.toolStripButton2});
            this.DataNavigator.Location = new System.Drawing.Point(0, 318);
            this.DataNavigator.MoveFirstItem = this.toolStripButton3;
            this.DataNavigator.MoveLastItem = this.toolStripButton6;
            this.DataNavigator.MoveNextItem = this.toolStripButton5;
            this.DataNavigator.MovePreviousItem = this.toolStripButton4;
            this.DataNavigator.Name = "DataNavigator";
            this.DataNavigator.PositionItem = this.toolStripTextBox1;
            this.DataNavigator.Size = new System.Drawing.Size(711, 31);
            this.DataNavigator.TabIndex = 152;
            this.DataNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Add New";
            this.toolStripButton1.ToolTipText = "Add New";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(44, 28);
            this.toolStripButton3.Text = "First";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Previous";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(42, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "Next";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(42, 28);
            this.toolStripButton6.Text = "Last";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // TransferTab
            // 
            this.TransferTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransferTab.Controls.Add(this.calculatorControl1);
            this.TransferTab.Controls.Add(this.metroPanel1);
            this.TransferTab.Controls.Add(this.metroPanel3);
            this.TransferTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferTab.Image = null;
            this.TransferTab.ImageSize = new System.Drawing.Size(40, 30);
            this.TransferTab.Location = new System.Drawing.Point(1, 44);
            this.TransferTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransferTab.Name = "TransferTab";
            this.TransferTab.ShowCloseButton = true;
            this.TransferTab.Size = new System.Drawing.Size(1786, 829);
            this.TransferTab.TabIndex = 5;
            this.TransferTab.Text = "Reprogramming";
            this.TransferTab.ThemesEnabled = false;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(273, 250);
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.Location = new System.Drawing.Point(1413, 179);
            this.calculatorControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(273, 250);
            this.calculatorControl1.TabIndex = 78;
            this.calculatorControl1.Text = "calculatorControl1";
            this.calculatorControl1.UseVisualStyle = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.FrRcComboBox1);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.ReprogrammingTypeComboBox);
            this.metroPanel1.Controls.Add(this.amountLabel1);
            this.metroPanel1.Controls.Add(this.amountCurrencyTextBox);
            this.metroPanel1.Controls.Add(this.codeLabel1);
            this.metroPanel1.Controls.Add(this.FrCodeComboBox);
            this.metroPanel1.Controls.Add(this.orgLabel);
            this.metroPanel1.Controls.Add(this.FrOrgComboBox);
            this.metroPanel1.Controls.Add(this.bOCLabel1);
            this.metroPanel1.Controls.Add(this.FrBocComboBox);
            this.metroPanel1.Controls.Add(this.fundLabel1);
            this.metroPanel1.Controls.Add(this.FrFundComboBox);
            this.metroPanel1.Controls.Add(this.bFYLabel1);
            this.metroPanel1.Controls.Add(this.FrBfyComboBox);
            this.metroPanel1.Controls.Add(this.rPIOLabel);
            this.metroPanel1.Controls.Add(this.FrRpioComboBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 9;
            this.metroPanel1.Location = new System.Drawing.Point(26, 51);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(212, 431);
            this.metroPanel1.TabIndex = 70;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // FrRcComboBox1
            // 
            this.FrRcComboBox1.BackColor = System.Drawing.Color.Black;
            this.FrRcComboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.FrRcComboBox1.FormattingEnabled = true;
            this.FrRcComboBox1.ItemHeight = 23;
            this.FrRcComboBox1.Location = new System.Drawing.Point(80, 227);
            this.FrRcComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrRcComboBox1.Name = "FrRcComboBox1";
            this.FrRcComboBox1.Size = new System.Drawing.Size(117, 29);
            this.FrRcComboBox1.TabIndex = 20;
            this.FrRcComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ReprogrammingTypeComboBox
            // 
            this.ReprogrammingTypeComboBox.FormattingEnabled = true;
            this.ReprogrammingTypeComboBox.ItemHeight = 23;
            this.ReprogrammingTypeComboBox.Items.AddRange(new object[] {
            "HQ",
            "BOC",
            "Division"});
            this.ReprogrammingTypeComboBox.Location = new System.Drawing.Point(80, 16);
            this.ReprogrammingTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReprogrammingTypeComboBox.Name = "ReprogrammingTypeComboBox";
            this.ReprogrammingTypeComboBox.Size = new System.Drawing.Size(117, 29);
            this.ReprogrammingTypeComboBox.TabIndex = 18;
            this.ReprogrammingTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // amountCurrencyTextBox
            // 
            this.amountCurrencyTextBox.BackGroundColor = System.Drawing.Color.DimGray;
            this.amountCurrencyTextBox.BeforeTouchSize = new System.Drawing.Size(117, 29);
            this.amountCurrencyTextBox.DecimalValue = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.amountCurrencyTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountCurrencyTextBox.Location = new System.Drawing.Point(75, 360);
            this.amountCurrencyTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.amountCurrencyTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.amountCurrencyTextBox.Name = "amountCurrencyTextBox";
            this.amountCurrencyTextBox.NullString = "";
            this.amountCurrencyTextBox.PositiveColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountCurrencyTextBox.Size = new System.Drawing.Size(117, 29);
            this.amountCurrencyTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.amountCurrencyTextBox.TabIndex = 17;
            this.amountCurrencyTextBox.Text = "$1.00";
            // 
            // FrCodeComboBox
            // 
            this.FrCodeComboBox.FormattingEnabled = true;
            this.FrCodeComboBox.ItemHeight = 23;
            this.FrCodeComboBox.Location = new System.Drawing.Point(80, 317);
            this.FrCodeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrCodeComboBox.Name = "FrCodeComboBox";
            this.FrCodeComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrCodeComboBox.TabIndex = 15;
            this.FrCodeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrOrgComboBox
            // 
            this.FrOrgComboBox.FormattingEnabled = true;
            this.FrOrgComboBox.ItemHeight = 23;
            this.FrOrgComboBox.Location = new System.Drawing.Point(80, 188);
            this.FrOrgComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrOrgComboBox.Name = "FrOrgComboBox";
            this.FrOrgComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrOrgComboBox.TabIndex = 13;
            this.FrOrgComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrBocComboBox
            // 
            this.FrBocComboBox.FormattingEnabled = true;
            this.FrBocComboBox.ItemHeight = 23;
            this.FrBocComboBox.Items.AddRange(new object[] {
            "10",
            "17",
            "21",
            "28",
            "36",
            "37",
            "38",
            "41"});
            this.FrBocComboBox.Location = new System.Drawing.Point(80, 268);
            this.FrBocComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrBocComboBox.Name = "FrBocComboBox";
            this.FrBocComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrBocComboBox.TabIndex = 11;
            this.FrBocComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrFundComboBox
            // 
            this.FrFundComboBox.FormattingEnabled = true;
            this.FrFundComboBox.ItemHeight = 23;
            this.FrFundComboBox.Location = new System.Drawing.Point(80, 146);
            this.FrFundComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrFundComboBox.Name = "FrFundComboBox";
            this.FrFundComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrFundComboBox.TabIndex = 9;
            this.FrFundComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrBfyComboBox
            // 
            this.FrBfyComboBox.FormattingEnabled = true;
            this.FrBfyComboBox.ItemHeight = 23;
            this.FrBfyComboBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "0223",
            "2024",
            "2025"});
            this.FrBfyComboBox.Location = new System.Drawing.Point(80, 104);
            this.FrBfyComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrBfyComboBox.Name = "FrBfyComboBox";
            this.FrBfyComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrBfyComboBox.TabIndex = 7;
            this.FrBfyComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrRpioComboBox
            // 
            this.FrRpioComboBox.FormattingEnabled = true;
            this.FrRpioComboBox.ItemHeight = 23;
            this.FrRpioComboBox.Location = new System.Drawing.Point(80, 64);
            this.FrRpioComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrRpioComboBox.Name = "FrRpioComboBox";
            this.FrRpioComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrRpioComboBox.TabIndex = 3;
            this.FrRpioComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.flowLayoutPanel2);
            this.metroPanel3.Controls.Add(this.flowLayoutPanel5);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 9;
            this.metroPanel3.Location = new System.Drawing.Point(259, 51);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1125, 431);
            this.metroPanel3.TabIndex = 69;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.metroButton3);
            this.flowLayoutPanel2.Controls.Add(this.metroButton4);
            this.flowLayoutPanel2.Controls.Add(this.metroButton5);
            this.flowLayoutPanel2.Controls.Add(this.metroButton6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(591, 347);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(487, 63);
            this.flowLayoutPanel2.TabIndex = 86;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Black;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton3.Location = new System.Drawing.Point(2, 3);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(117, 53);
            this.metroButton3.TabIndex = 78;
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.Black;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton4.Location = new System.Drawing.Point(123, 3);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(116, 56);
            this.metroButton4.TabIndex = 79;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.Black;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton5.Location = new System.Drawing.Point(243, 3);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(114, 56);
            this.metroButton5.TabIndex = 80;
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Black;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton6.Location = new System.Drawing.Point(361, 3);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(115, 53);
            this.metroButton6.TabIndex = 81;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.metroButton11);
            this.flowLayoutPanel5.Controls.Add(this.metroButton12);
            this.flowLayoutPanel5.Controls.Add(this.metroButton13);
            this.flowLayoutPanel5.Controls.Add(this.metroButton14);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(591, 264);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(487, 66);
            this.flowLayoutPanel5.TabIndex = 85;
            // 
            // metroButton11
            // 
            this.metroButton11.BackColor = System.Drawing.Color.Black;
            this.metroButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton11.Location = new System.Drawing.Point(2, 3);
            this.metroButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(115, 53);
            this.metroButton11.TabIndex = 64;
            this.metroButton11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton12
            // 
            this.metroButton12.BackColor = System.Drawing.Color.Black;
            this.metroButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton12.Location = new System.Drawing.Point(121, 3);
            this.metroButton12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(116, 53);
            this.metroButton12.TabIndex = 63;
            this.metroButton12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton13
            // 
            this.metroButton13.BackColor = System.Drawing.Color.Black;
            this.metroButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton13.Location = new System.Drawing.Point(241, 3);
            this.metroButton13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(115, 53);
            this.metroButton13.TabIndex = 65;
            this.metroButton13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton14
            // 
            this.metroButton14.BackColor = System.Drawing.Color.Black;
            this.metroButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton14.Location = new System.Drawing.Point(360, 3);
            this.metroButton14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(114, 53);
            this.metroButton14.TabIndex = 66;
            this.metroButton14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // ReprogrammingGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Controls.Add(this.metroTextBox8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Old, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Code, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BOC, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Fund, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Org, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BFY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label41, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.New, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.95652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 237);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // metroTextBox8
            // 
            // 
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(65, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 140;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Old
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(195, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 60;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fund
            // 
            // 
            // 
            // 
            // 
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label43.Location = new System.Drawing.Point(319, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(0, 20);
            this.label43.TabIndex = 66;
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BFY
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label41.Location = new System.Drawing.Point(65, 89);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 20);
            this.label41.TabIndex = 62;
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(319, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 64;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(195, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 63;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RC
            // 
            // 
            // 
            // 
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(65, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 161;
            // 
            // New
            // 
            this.New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.New.AutoSize = true;
            this.New.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.New.Location = new System.Drawing.Point(195, 171);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(0, 20);
            this.New.TabIndex = 162;
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroSetTabPage2.Controls.Add(this.PrcChart);
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(479, 379);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage2.StyleManager = null;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "metroSetTabPage2";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroDark";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // PrcChart
            // 
            this.PrcChart.AllowGradientPalette = true;
            this.PrcChart.AllowUserEditStyles = true;
            this.PrcChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.PrcChart.ChartArea.AutoScale = true;
            this.PrcChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.PrcChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.PrcChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.PrcChart.ChartArea.CursorReDraw = false;
            this.PrcChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.PrcChart.ChartAreaShadow = true;
            this.PrcChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.PrcChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.PrcChart.DataSourceName = "[none]";
            this.PrcChart.Depth = 250F;
            this.PrcChart.DisplayChartContextMenu = false;
            this.PrcChart.DisplaySeriesContextMenu = false;
            this.PrcChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrcChart.EnableMouseRotation = true;
            this.PrcChart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrcChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrcChart.HighlightSymbol = true;
            this.PrcChart.IsWindowLess = false;
            // 
            // 
            // 
            this.PrcChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.PrcChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.PrcChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.PrcChart.Legend.Visible = false;
            this.PrcChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.PrcChart.Localize = null;
            this.PrcChart.Location = new System.Drawing.Point(0, 0);
            this.PrcChart.Margin = new System.Windows.Forms.Padding(2);
            this.PrcChart.Name = "PrcChart";
            this.PrcChart.Padding = new System.Windows.Forms.Padding(1);
            this.PrcChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.PrcChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrcChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.PrcChart.PrimaryXAxis.Margin = true;
            this.PrcChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.PrcChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.PrcChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrcChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.PrcChart.PrimaryYAxis.Margin = true;
            this.PrcChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.PrcChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.PrcChart.RealMode3D = true;
            this.PrcChart.Rotation = 45F;
            chartSeries13.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries13.Name = "Default0";
            chartSeries13.Points.Add(1D, ((double)(55D)));
            chartSeries13.Points.Add(2D, ((double)(70D)));
            chartSeries13.Points.Add(3D, ((double)(80D)));
            chartSeries13.Points.Add(4D, ((double)(65D)));
            chartSeries13.Points.Add(5D, ((double)(75D)));
            chartSeries13.Resolution = 0D;
            chartSeries13.StackingGroup = "Default Group";
            chartSeries13.Style.AltTagFormat = "";
            chartSeries13.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries13.Style.DrawTextShape = false;
            chartSeries13.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo7.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo7.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo7.DashPattern = null;
            chartLineInfo7.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo7.Width = 1F;
            chartCustomShapeInfo13.Border = chartLineInfo7;
            chartCustomShapeInfo13.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo13.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries13.Style.TextShape = chartCustomShapeInfo13;
            chartSeries13.Text = "Default0";
            chartSeries14.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries14.Name = "Default1";
            chartSeries14.Points.Add(1D, ((double)(70D)));
            chartSeries14.Points.Add(2D, ((double)(35D)));
            chartSeries14.Points.Add(3D, ((double)(65D)));
            chartSeries14.Points.Add(4D, ((double)(25D)));
            chartSeries14.Points.Add(5D, ((double)(50D)));
            chartSeries14.Resolution = 0D;
            chartSeries14.StackingGroup = "Default Group";
            chartSeries14.Style.AltTagFormat = "";
            chartSeries14.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries14.Style.DrawTextShape = false;
            chartSeries14.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo14.Border = chartLineInfo7;
            chartCustomShapeInfo14.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo14.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries14.Style.TextShape = chartCustomShapeInfo14;
            chartSeries14.Text = "Default1";
            this.PrcChart.Series.Add(chartSeries13);
            this.PrcChart.Series.Add(chartSeries14);
            this.PrcChart.Series3D = true;
            this.PrcChart.SeriesHighlight = true;
            this.PrcChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.PrcChart.Size = new System.Drawing.Size(479, 379);
            this.PrcChart.Spacing = 5F;
            this.PrcChart.SpacingBetweenPoints = 5F;
            this.PrcChart.Style3D = true;
            this.PrcChart.TabIndex = 46;
            this.PrcChart.Tilt = 15F;
            // 
            // 
            // 
            this.PrcChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrcChart.Title.Name = "Default";
            this.PrcChart.ToolBar.EnableDefaultItems = false;
            this.PrcChart.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSplitter7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarStyleItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.PrcChart.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.GridFilterPanel);
            this.expandCollapsePanel1.ExpandedHeight = 459;
            this.expandCollapsePanel1.IsExpanded = false;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(138, 74);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(246, 37);
            this.expandCollapsePanel1.TabIndex = 145;
            this.expandCollapsePanel1.Text = "Selection";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // GridFilterPanel
            // 
            this.GridFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.GridFilterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.GridFilterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridFilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.GridFilterPanel.Location = new System.Drawing.Point(25, 75);
            this.GridFilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GridFilterPanel.Name = "GridFilterPanel";
            this.GridFilterPanel.Size = new System.Drawing.Size(214, 271);
            this.GridFilterPanel.TabIndex = 142;
            // 
            // AccountMangerGroupBox
            // 
            this.AccountMangerGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AccountMangerGroupBox.Controls.Add(this.PrcPanel);
            this.AccountMangerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMangerGroupBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AccountMangerGroupBox.Location = new System.Drawing.Point(459, 483);
            this.AccountMangerGroupBox.Name = "AccountMangerGroupBox";
            this.AccountMangerGroupBox.Size = new System.Drawing.Size(813, 167);
            this.AccountMangerGroupBox.TabIndex = 143;
            this.AccountMangerGroupBox.TabStop = false;
            this.AccountMangerGroupBox.Text = "Division Account Data";
            // 
            // PrcPanel
            // 
            this.PrcPanel.ColumnCount = 7;
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.PrcPanel.Controls.Add(this.label6, 6, 0);
            this.PrcPanel.Location = new System.Drawing.Point(23, 50);
            this.PrcPanel.Name = "PrcPanel";
            this.PrcPanel.RowCount = 2;
            this.PrcPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.27523F));
            this.PrcPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.72477F));
            this.PrcPanel.Size = new System.Drawing.Size(721, 73);
            this.PrcPanel.TabIndex = 151;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(560, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Amount:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BackButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BackButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.BackButton.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackButton.HoverTextColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(1069, 50);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.BackButton.NormalColor = System.Drawing.Color.Transparent;
            this.BackButton.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BackButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BackButton.PressTextColor = System.Drawing.Color.White;
            this.BackButton.Size = new System.Drawing.Size(188, 20);
            this.BackButton.Style = MetroSet_UI.Design.Style.Custom;
            this.BackButton.StyleManager = null;
            this.BackButton.TabIndex = 126;
            this.BackButton.Text = "Back";
            this.BackButton.ThemeAuthor = "Narwin";
            this.BackButton.ThemeName = "MetroLite";
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DatabaseGroupBox.Controls.Add(this.lblTotalAmount);
            this.DatabaseGroupBox.Controls.Add(this.lblCount);
            this.DatabaseGroupBox.Controls.Add(this.lblTotal);
            this.DatabaseGroupBox.Controls.Add(this.lblAccounts);
            this.DatabaseGroupBox.Controls.Add(this.P8GridPanel);
            this.DatabaseGroupBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DatabaseGroupBox.Location = new System.Drawing.Point(459, 74);
            this.DatabaseGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DatabaseGroupBox.Size = new System.Drawing.Size(813, 385);
            this.DatabaseGroupBox.TabIndex = 140;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Division Database";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotalAmount.Location = new System.Drawing.Point(115, 48);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(60, 20);
            this.lblTotalAmount.TabIndex = 119;
            this.lblTotalAmount.Text = "label46";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCount.Location = new System.Drawing.Point(578, 48);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(60, 20);
            this.lblCount.TabIndex = 120;
            this.lblCount.Text = "label45";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(52, 48);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 121;
            this.lblTotal.Text = "Total: ";
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAccounts.Location = new System.Drawing.Point(478, 48);
            this.lblAccounts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(84, 20);
            this.lblAccounts.TabIndex = 122;
            this.lblAccounts.Text = "Accounts: ";
            // 
            // P8GridPanel
            // 
            this.P8GridPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8GridPanel.Location = new System.Drawing.Point(49, 71);
            this.P8GridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.P8GridPanel.Name = "P8GridPanel";
            this.P8GridPanel.Size = new System.Drawing.Size(695, 293);
            this.P8GridPanel.TabIndex = 123;
            // 
            // calculatorControl2
            // 
            this.calculatorControl2.AccessibleDescription = "Calculator control";
            this.calculatorControl2.AccessibleName = "Calculator Control";
            this.calculatorControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculatorControl2.BeforeTouchSize = new System.Drawing.Size(361, 308);
            this.calculatorControl2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl2.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl2.DoubleValue = 0D;
            this.calculatorControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl2.Location = new System.Drawing.Point(1386, 135);
            this.calculatorControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculatorControl2.MetroColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculatorControl2.Name = "calculatorControl2";
            this.calculatorControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl2.Size = new System.Drawing.Size(361, 308);
            this.calculatorControl2.TabIndex = 144;
            this.calculatorControl2.Text = "calculatorControl2";
            this.calculatorControl2.UseVisualStyle = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.expandCollapsePanel3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 79);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 669);
            this.tableLayoutPanel4.TabIndex = 104;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.expandCollapsePanel2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(25, 80);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(228, 669);
            this.tableLayoutPanel5.TabIndex = 104;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.expandCollapsePanel6, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(25, 80);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(228, 669);
            this.tableLayoutPanel6.TabIndex = 104;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.expandCollapsePanel5, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(248, 706);
            this.tableLayoutPanel7.TabIndex = 104;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.expandCollapsePanel4, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(20, 43);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(248, 736);
            this.tableLayoutPanel8.TabIndex = 104;
            // 
            // DivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Transparent;
            this.CaptionBarHeight = 120;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1788, 874);
            this.Controls.Add(this.DivisionFormTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "DivisionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Division Operations Detail";
            this.Load += new System.EventHandler(this.DivisionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DivisionFormTabControl)).EndInit();
            this.DivisionFormTabControl.ResumeLayout(false);
            this.AppropriationTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.expandCollapsePanel3.ResumeLayout(false);
            this.expandCollapsePanel3.PerformLayout();
            this.BocTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.NpmTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.expandCollapsePanel6.ResumeLayout(false);
            this.expandCollapsePanel6.PerformLayout();
            this.ProgramTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.expandCollapsePanel5.ResumeLayout(false);
            this.expandCollapsePanel5.PerformLayout();
            this.ProjectTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.expandCollapsePanel4.ResumeLayout(false);
            this.expandCollapsePanel4.PerformLayout();
            this.DataTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.Expander.ResumeLayout(false);
            this.Expander.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DatabaseGridPanel.ResumeLayout(false);
            this.DatabaseGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNavigator)).EndInit();
            this.DataNavigator.ResumeLayout(false);
            this.DataNavigator.PerformLayout();
            this.TransferTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountCurrencyTextBox)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroSetTabPage2.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.AccountMangerGroupBox.ResumeLayout(false);
            this.PrcPanel.ResumeLayout(false);
            this.PrcPanel.PerformLayout();
            this.DatabaseGroupBox.ResumeLayout(false);
            this.DatabaseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P8BindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

                }

                #endregion

                protected internal Syncfusion.Windows.Forms.Tools.TabControlAdv DivisionFormTabControl;
                Syncfusion.Windows.Forms.Tools.TabPageAdv AppropriationTab;
                System.Windows.Forms.ListBox approplistbox;
                MetroFramework.Controls.MetroButton metroButton1;
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv TransferTab;
                MetroFramework.Controls.MetroPanel metroPanel1;
                MetroFramework.Controls.MetroComboBox FrRcComboBox1;
                MetroFramework.Controls.MetroComboBox ReprogrammingTypeComboBox;
                Syncfusion.Windows.Forms.Tools.CurrencyTextBox amountCurrencyTextBox;
                MetroFramework.Controls.MetroComboBox FrCodeComboBox;
                MetroFramework.Controls.MetroComboBox FrOrgComboBox;
                MetroFramework.Controls.MetroComboBox FrBocComboBox;
                MetroFramework.Controls.MetroComboBox FrFundComboBox;
                MetroFramework.Controls.MetroComboBox FrBfyComboBox;
                MetroFramework.Controls.MetroComboBox FrRpioComboBox;
                MetroFramework.Controls.MetroPanel metroPanel3;
                System.Windows.Forms.ListBox ImageBox;
                private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
                protected internal MetroFramework.Controls.MetroButton metroButton11;
                protected internal MetroFramework.Controls.MetroButton metroButton12;
                protected internal MetroFramework.Controls.MetroButton metroButton13;
                protected internal MetroFramework.Controls.MetroButton metroButton14;
                private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
                private MetroFramework.Controls.MetroButton metroButton3;
                private MetroFramework.Controls.MetroButton metroButton4;
                private MetroFramework.Controls.MetroButton metroButton5;
                private MetroFramework.Controls.MetroButton metroButton6;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv ProgramTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv BocTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv NpmTab;
                private System.Windows.Forms.SplitContainer splitContainer5;
                private System.Windows.Forms.RadioButton rb3;
                private System.Windows.Forms.RadioButton rb2;
                private System.Windows.Forms.RadioButton rb1;
                protected Syncfusion.Windows.Forms.Chart.ChartControl AppropChart;
                private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.Label amountLabel1;
                private System.Windows.Forms.Label codeLabel1;
                private System.Windows.Forms.Label orgLabel;
                private System.Windows.Forms.Label bOCLabel1;
                private System.Windows.Forms.Label fundLabel1;
                private System.Windows.Forms.Label bFYLabel1;
                private System.Windows.Forms.Label rPIOLabel;
                private System.Windows.Forms.SplitContainer splitContainer1;
                protected Syncfusion.Windows.Forms.Chart.ChartControl AreaChart;
                private System.Windows.Forms.SplitContainer splitContainer2;
                private System.Windows.Forms.SplitContainer splitContainer3;
                protected Syncfusion.Windows.Forms.Chart.ChartControl NpmChart;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv ProjectTab;
                private System.Windows.Forms.Panel panel13;
                private System.Windows.Forms.RadioButton rb4;
                private System.Windows.Forms.Panel panel6;
                private System.Windows.Forms.RadioButton rb5;
                private System.Windows.Forms.RadioButton rb7;
                private System.Windows.Forms.RadioButton rb6;
                private System.Windows.Forms.RadioButton rb8;
                private System.Windows.Forms.Panel panel7;
                private System.Windows.Forms.RadioButton rb9;
                private System.Windows.Forms.RadioButton rb10;
                private System.Windows.Forms.RadioButton rb11;
                private System.Windows.Forms.RadioButton rb12;
                private System.Windows.Forms.Panel panel8;
                private System.Windows.Forms.RadioButton rb13;
                private System.Windows.Forms.RadioButton rb14;
                private System.Windows.Forms.RadioButton rb15;
                private System.Windows.Forms.RadioButton rb16;
                private System.Windows.Forms.SplitContainer splitContainer4;
                private System.Windows.Forms.Panel panel9;
                private System.Windows.Forms.RadioButton rb17;
                private System.Windows.Forms.RadioButton rb18;
                private System.Windows.Forms.RadioButton rb20;
                private System.Windows.Forms.RadioButton rb19;
                protected Syncfusion.Windows.Forms.Chart.ChartControl ProjectChart;
                private DataSet E6;
                protected Syncfusion.Windows.Forms.Chart.ChartControl BocChart;
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv DatabaseTab;
                private System.Windows.Forms.Label lblTotalAmount;
                private System.Windows.Forms.Label lblTotal;
                private System.Windows.Forms.Label lblCount;
                private System.Windows.Forms.Label lblAccounts;
                private System.Windows.Forms.GroupBox DatabaseGroupBox;
                private System.Windows.Forms.Panel P8GridPanel;
                private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl2;
                private MetroSet_UI.Controls.MetroSetButton BackButton;
                private System.Windows.Forms.FlowLayoutPanel GridFilterPanel;
                private System.Windows.Forms.GroupBox AccountMangerGroupBox;
                private System.Windows.Forms.TableLayoutPanel PrcPanel;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Label label15;
                private System.Windows.Forms.Label label10;
                private System.Windows.Forms.Label label41;
                private System.Windows.Forms.Label label43;
                private MetroFramework.Controls.MetroTextBox RC;
                private MetroFramework.Controls.MetroTextBox Org;
                private MetroFramework.Controls.MetroTextBox BOC;
                private MetroFramework.Controls.MetroTextBox Fund;
                private MetroFramework.Controls.MetroTextBox BFY;
                private MetroFramework.Controls.MetroTextBox Old;
                private MetroFramework.Controls.MetroTextBox Code;
                private System.Windows.Forms.FlowLayoutPanel panel5;
                private System.Windows.Forms.FlowLayoutPanel panel4;
                private System.Windows.Forms.FlowLayoutPanel panel3;
                private System.Windows.Forms.FlowLayoutPanel panel2;
                private System.Windows.Forms.FlowLayoutPanel panel1;
                private DataGridView DataGrid;
                protected ChartControl PrcChart;
                private BindingSource P8BindingSource;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel3;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel6;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel5;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel4;
                private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
                private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
                private MetroTextBox metroTextBox8;
                private TableLayoutPanel tableLayoutPanel1;
                private Label label1;
                private Label New;
                private TabPageAdv DataTab;
                private TabControlAdv tabControlAdv1;
                private TabPageAdv tabPageAdv1;
                private TableLayoutPanel tableLayoutPanel2;
                private Label label13;
                private MetroTextBox OldAmount;
                private Label label12;
                private MetroTextBox metroTextBox1;
                private MetroTextBox metroTextBox2;
                private Label label2;
                private MetroTextBox metroTextBox3;
                private Label label3;
                private Label label9;
                private MetroTextBox metroTextBox4;
                private Label label11;
                private Label label14;
                private Label label16;
                private MetroTextBox metroTextBox5;
                private MetroTextBox metroTextBox6;
                private MetroTextBox metroTextBox7;
                private TabPageAdv tabPageAdv2;
                protected ChartControl chartControl1;
                private GroupBox groupBox1;
                private MetroLink ReturnButton;
                private Label label17;
                private Label label18;
                private Label label19;
                private Label label20;
                private Panel DatabaseGridPanel;
                private BindingNavigator DataNavigator;
                private ToolStripButton toolStripButton1;
                private ToolStripLabel toolStripLabel1;
                private ToolStripButton toolStripButton2;
                private ToolStripButton toolStripButton3;
                private ToolStripSeparator toolStripSeparator4;
                private ToolStripButton toolStripButton4;
                private ToolStripSeparator toolStripSeparator5;
                private ToolStripTextBox toolStripTextBox1;
                private ToolStripSeparator toolStripSeparator6;
                private ToolStripButton toolStripButton5;
                private ToolStripSeparator toolStripSeparator7;
                private ToolStripButton toolStripButton6;
                private ToolStripSeparator toolStripSeparator8;
                private ToolStripSeparator toolStripSeparator9;
                private TableLayoutPanel tableLayoutPanel3;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel Expander;
                private FlowLayoutPanel P7FilterPanel;
                private DataGridView Grid;
                private TableLayoutPanel tableLayoutPanel4;
                private TableLayoutPanel tableLayoutPanel5;
                private TableLayoutPanel tableLayoutPanel6;
                private TableLayoutPanel tableLayoutPanel7;
                private TableLayoutPanel tableLayoutPanel8;
            } 
        }


    }
}