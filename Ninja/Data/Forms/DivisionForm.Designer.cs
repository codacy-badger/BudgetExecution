
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection2 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection2 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection2 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection3 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection3 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer3 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection3 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection4 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection4 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer4 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection4 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection5 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection5 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer5 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection5 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivisionForm));
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries15 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo15 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo8 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries16 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo16 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
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
            this.AppriopriationTabExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.AppropriationTabFilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toggleButton1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
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
            this.toggleButton2 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.toggleButton3 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
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
            this.Percent = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
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
            this.toggleButton4 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.expandCollapsePanel4 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Expander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.P7FilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MiniTabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
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
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransferGrid = new System.Windows.Forms.DataGridView();
            this.TransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransferNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MiniTabControl2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.metroTextBox14 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox15 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox16 = new MetroFramework.Controls.MetroTextBox();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.TransferExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.TransferFilterPanel = new MetroFramework.Controls.MetroPanel();
            this.FrRcComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.ReprogrammingTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.amountCurrencyTextBox = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.FrCodeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrOrgComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrBocComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrFundComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrBfyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FrRpioComboBox = new MetroFramework.Controls.MetroComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.expandCollapsePanel7 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.DivisionFormTabControl)).BeginInit();
            this.DivisionFormTabControl.SuspendLayout();
            this.AppropriationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.AppriopriationTabExpander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).BeginInit();
            this.BocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton2)).BeginInit();
            this.NpmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton3)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.expandCollapsePanel6.SuspendLayout();
            this.ProgramTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percent)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.expandCollapsePanel5.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton4)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.expandCollapsePanel4.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.Expander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).BeginInit();
            this.MiniTabControl1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DatabaseGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNavigator)).BeginInit();
            this.DataNavigator.SuspendLayout();
            this.TransferTab.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferNavigator)).BeginInit();
            this.TransferNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl2)).BeginInit();
            this.MiniTabControl2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            this.TransferExpander.SuspendLayout();
            this.TransferFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountCurrencyTextBox)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.AccountMangerGroupBox.SuspendLayout();
            this.PrcPanel.SuspendLayout();
            this.DatabaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(22, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "RC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
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
            this.amountLabel1.Size = new System.Drawing.Size(76, 22);
            this.amountLabel1.TabIndex = 16;
            this.amountLabel1.Text = "Amount:";
            // 
            // codeLabel1
            // 
            this.codeLabel1.AutoSize = true;
            this.codeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.codeLabel1.Location = new System.Drawing.Point(13, 317);
            this.codeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel1.Name = "codeLabel1";
            this.codeLabel1.Size = new System.Drawing.Size(58, 22);
            this.codeLabel1.TabIndex = 14;
            this.codeLabel1.Text = "Code:";
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.BackColor = System.Drawing.Color.Transparent;
            this.orgLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orgLabel.Location = new System.Drawing.Point(22, 188);
            this.orgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(45, 22);
            this.orgLabel.TabIndex = 12;
            this.orgLabel.Text = "Org:";
            // 
            // bOCLabel1
            // 
            this.bOCLabel1.AutoSize = true;
            this.bOCLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bOCLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bOCLabel1.Location = new System.Drawing.Point(9, 271);
            this.bOCLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bOCLabel1.Name = "bOCLabel1";
            this.bOCLabel1.Size = new System.Drawing.Size(54, 22);
            this.bOCLabel1.TabIndex = 10;
            this.bOCLabel1.Text = "BOC:";
            // 
            // fundLabel1
            // 
            this.fundLabel1.AutoSize = true;
            this.fundLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fundLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fundLabel1.Location = new System.Drawing.Point(15, 149);
            this.fundLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fundLabel1.Name = "fundLabel1";
            this.fundLabel1.Size = new System.Drawing.Size(56, 22);
            this.fundLabel1.TabIndex = 8;
            this.fundLabel1.Text = "Fund:";
            // 
            // bFYLabel1
            // 
            this.bFYLabel1.AutoSize = true;
            this.bFYLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bFYLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bFYLabel1.Location = new System.Drawing.Point(15, 107);
            this.bFYLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bFYLabel1.Name = "bFYLabel1";
            this.bFYLabel1.Size = new System.Drawing.Size(50, 22);
            this.bFYLabel1.TabIndex = 6;
            this.bFYLabel1.Text = "BFY:";
            // 
            // rPIOLabel
            // 
            this.rPIOLabel.AutoSize = true;
            this.rPIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.rPIOLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rPIOLabel.Location = new System.Drawing.Point(15, 71);
            this.rPIOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPIOLabel.Name = "rPIOLabel";
            this.rPIOLabel.Size = new System.Drawing.Size(58, 22);
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
            this.DivisionFormTabControl.InActiveTabForeColor = System.Drawing.Color.Gray;
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
            this.splitContainer5.Panel2.Controls.Add(this.AppriopriationTabExpander);
            this.splitContainer5.Panel2.Controls.Add(this.toggleButton1);
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
            this.panel13.Size = new System.Drawing.Size(456, 39);
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
            // AppriopriationTabExpander
            // 
            this.AppriopriationTabExpander.BackColor = System.Drawing.Color.Black;
            this.AppriopriationTabExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.AppriopriationTabExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AppriopriationTabExpander.Controls.Add(this.AppropriationTabFilterPanel);
            this.AppriopriationTabExpander.ExpandedHeight = 611;
            this.AppriopriationTabExpander.IsExpanded = false;
            this.AppriopriationTabExpander.Location = new System.Drawing.Point(20, 69);
            this.AppriopriationTabExpander.Name = "AppriopriationTabExpander";
            this.AppriopriationTabExpander.Size = new System.Drawing.Size(227, 37);
            this.AppriopriationTabExpander.TabIndex = 44;
            this.AppriopriationTabExpander.Text = "Selection";
            this.AppriopriationTabExpander.UseAnimation = true;
            // 
            // AppropriationTabFilterPanel
            // 
            this.AppropriationTabFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AppropriationTabFilterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AppropriationTabFilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AppropriationTabFilterPanel.Location = new System.Drawing.Point(15, 57);
            this.AppropriationTabFilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AppropriationTabFilterPanel.Name = "AppropriationTabFilterPanel";
            this.AppropriationTabFilterPanel.Size = new System.Drawing.Size(197, 656);
            this.AppropriationTabFilterPanel.TabIndex = 1;
            // 
            // toggleButton1
            // 
            activeStateCollection1.BackColor = System.Drawing.Color.Black;
            activeStateCollection1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection1.Text = "$";
            this.toggleButton1.ActiveState = activeStateCollection1;
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection1.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection1.Text = "%";
            this.toggleButton1.InactiveState = inactiveStateCollection1;
            this.toggleButton1.Location = new System.Drawing.Point(20, 6);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Renderer = toggleButtonRenderer1;
            this.toggleButton1.Size = new System.Drawing.Size(73, 36);
            sliderCollection1.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection1.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection1.Width = 30;
            this.toggleButton1.Slider = sliderCollection1;
            this.toggleButton1.TabIndex = 50;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
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
            this.approplistbox.Size = new System.Drawing.Size(616, 203);
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
            this.metroButton1.UseSelectable = true;
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
            this.splitContainer2.Panel2.Controls.Add(this.expandCollapsePanel2);
            this.splitContainer2.Panel2.Controls.Add(this.toggleButton2);
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
            this.panel6.Size = new System.Drawing.Size(460, 48);
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
            this.expandCollapsePanel2.Location = new System.Drawing.Point(20, 69);
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
            // toggleButton2
            // 
            activeStateCollection2.BackColor = System.Drawing.Color.Black;
            activeStateCollection2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection2.Text = "$";
            this.toggleButton2.ActiveState = activeStateCollection2;
            this.toggleButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton2.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection2.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection2.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection2.Text = "%";
            this.toggleButton2.InactiveState = inactiveStateCollection2;
            this.toggleButton2.Location = new System.Drawing.Point(20, 6);
            this.toggleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Renderer = toggleButtonRenderer2;
            this.toggleButton2.Size = new System.Drawing.Size(73, 36);
            sliderCollection2.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection2.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection2.Width = 30;
            this.toggleButton2.Slider = sliderCollection2;
            this.toggleButton2.TabIndex = 105;
            this.toggleButton2.Text = "toggleButton2";
            this.toggleButton2.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
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
            this.splitContainer3.Panel2.Controls.Add(this.toggleButton3);
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
            this.panel7.Size = new System.Drawing.Size(471, 39);
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
            // toggleButton3
            // 
            activeStateCollection3.BackColor = System.Drawing.Color.Black;
            activeStateCollection3.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection3.Text = "$";
            this.toggleButton3.ActiveState = activeStateCollection3;
            this.toggleButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton3.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection3.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection3.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection3.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection3.Text = "%";
            this.toggleButton3.InactiveState = inactiveStateCollection3;
            this.toggleButton3.Location = new System.Drawing.Point(20, 6);
            this.toggleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton3.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.Renderer = toggleButtonRenderer3;
            this.toggleButton3.Size = new System.Drawing.Size(73, 36);
            sliderCollection3.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection3.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection3.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection3.Width = 30;
            this.toggleButton3.Slider = sliderCollection3;
            this.toggleButton3.TabIndex = 105;
            this.toggleButton3.Text = "toggleButton3";
            this.toggleButton3.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
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
            this.splitContainer1.Panel2.Controls.Add(this.Percent);
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
            this.panel8.Size = new System.Drawing.Size(397, 39);
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
            // Percent
            // 
            activeStateCollection4.BackColor = System.Drawing.Color.Black;
            activeStateCollection4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection4.Text = "$";
            this.Percent.ActiveState = activeStateCollection4;
            this.Percent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection4.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection4.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection4.Text = "%";
            this.Percent.InactiveState = inactiveStateCollection4;
            this.Percent.Location = new System.Drawing.Point(20, 6);
            this.Percent.Margin = new System.Windows.Forms.Padding(2);
            this.Percent.MinimumSize = new System.Drawing.Size(36, 14);
            this.Percent.Name = "Percent";
            this.Percent.Renderer = toggleButtonRenderer4;
            this.Percent.Size = new System.Drawing.Size(73, 36);
            sliderCollection4.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection4.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection4.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection4.Width = 30;
            this.Percent.Slider = sliderCollection4;
            this.Percent.TabIndex = 50;
            this.Percent.Text = "toggleButton1";
            this.Percent.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
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
            this.splitContainer4.Panel2.Controls.Add(this.toggleButton4);
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
            this.panel9.Size = new System.Drawing.Size(389, 46);
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
            // toggleButton4
            // 
            activeStateCollection5.BackColor = System.Drawing.Color.Black;
            activeStateCollection5.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection5.Text = "$";
            this.toggleButton4.ActiveState = activeStateCollection5;
            this.toggleButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton4.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection5.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection5.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection5.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection5.Text = "%";
            this.toggleButton4.InactiveState = inactiveStateCollection5;
            this.toggleButton4.Location = new System.Drawing.Point(20, 6);
            this.toggleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton4.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.Renderer = toggleButtonRenderer5;
            this.toggleButton4.Size = new System.Drawing.Size(73, 36);
            sliderCollection5.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection5.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection5.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection5.Width = 30;
            this.toggleButton4.Slider = sliderCollection5;
            this.toggleButton4.TabIndex = 105;
            this.toggleButton4.Text = "toggleButton4";
            this.toggleButton4.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.expandCollapsePanel4, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(20, 73);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(248, 736);
            this.tableLayoutPanel8.TabIndex = 104;
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
            this.DataTab.Controls.Add(this.tableLayoutPanel10);
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
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.26435F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.73565F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.tableLayoutPanel10.Controls.Add(this.Expander, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.MiniTabControl1, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(11, 46);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1752, 517);
            this.tableLayoutPanel10.TabIndex = 152;
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
            this.Expander.Size = new System.Drawing.Size(294, 37);
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
            this.P7FilterPanel.Size = new System.Drawing.Size(252, 410);
            this.P7FilterPanel.TabIndex = 136;
            // 
            // MiniTabControl1
            // 
            this.MiniTabControl1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl1.BeforeTouchSize = new System.Drawing.Size(487, 494);
            this.MiniTabControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiniTabControl1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.Controls.Add(this.tabPageAdv1);
            this.MiniTabControl1.Controls.Add(this.tabPageAdv2);
            this.MiniTabControl1.FixedSingleBorderColor = System.Drawing.SystemColors.ControlDark;
            this.MiniTabControl1.FocusOnTabClick = false;
            this.MiniTabControl1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl1.Location = new System.Drawing.Point(1238, 3);
            this.MiniTabControl1.Name = "MiniTabControl1";
            this.MiniTabControl1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.MiniTabControl1.ShowSeparator = false;
            this.MiniTabControl1.Size = new System.Drawing.Size(487, 494);
            this.MiniTabControl1.TabIndex = 150;
            this.MiniTabControl1.TabPanelBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MiniTabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
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
            this.tabPageAdv1.Size = new System.Drawing.Size(485, 463);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 221);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(149, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 162;
            this.label13.Text = "New:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldAmount
            // 
            // 
            // 
            // 
            this.OldAmount.CustomButton.Image = null;
            this.OldAmount.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.OldAmount.CustomButton.Name = "";
            this.OldAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.OldAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OldAmount.CustomButton.TabIndex = 1;
            this.OldAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OldAmount.CustomButton.UseSelectable = true;
            this.OldAmount.CustomButton.Visible = false;
            this.OldAmount.Lines = new string[] {
        "metroTextBox1"};
            this.OldAmount.Location = new System.Drawing.Point(2, 171);
            this.OldAmount.Margin = new System.Windows.Forms.Padding(2);
            this.OldAmount.MaxLength = 32767;
            this.OldAmount.Name = "OldAmount";
            this.OldAmount.PasswordChar = '\0';
            this.OldAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldAmount.SelectedText = "";
            this.OldAmount.SelectionLength = 0;
            this.OldAmount.SelectionStart = 0;
            this.OldAmount.ShortcutsEnabled = true;
            this.OldAmount.Size = new System.Drawing.Size(91, 28);
            this.OldAmount.TabIndex = 154;
            this.OldAmount.Text = "metroTextBox1";
            this.OldAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OldAmount.UseSelectable = true;
            this.OldAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OldAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(19, 148);
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
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox2"};
            this.metroTextBox1.Location = new System.Drawing.Point(237, 88);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(116, 37);
            this.metroTextBox1.TabIndex = 155;
            this.metroTextBox1.Text = "metroTextBox2";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(110, 88);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox2.TabIndex = 163;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(36, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 140;
            this.label2.Text = "BFY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(3, 89);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox3.TabIndex = 164;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(147, 3);
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
            this.label9.Location = new System.Drawing.Point(270, 65);
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
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(238, 27);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox4.TabIndex = 165;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(155, 65);
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
            this.label14.Location = new System.Drawing.Point(273, 3);
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
            this.label16.Location = new System.Drawing.Point(34, 65);
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
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(111, 27);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox5.TabIndex = 166;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(3, 27);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox6.TabIndex = 167;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[0];
            this.metroTextBox7.Location = new System.Drawing.Point(111, 172);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox7.TabIndex = 168;
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.chartControl1);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(485, 463);
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
            this.chartControl1.Size = new System.Drawing.Size(485, 463);
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
            this.groupBox1.Location = new System.Drawing.Point(363, 2);
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
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Location = new System.Drawing.Point(619, 47);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(34, 26);
            this.ReturnButton.TabIndex = 147;
            this.ReturnButton.UseSelectable = true;
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
            this.Grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.TransferTab.Controls.Add(this.tableLayoutPanel11);
            this.TransferTab.Controls.Add(this.flowLayoutPanel5);
            this.TransferTab.Controls.Add(this.expandCollapsePanel7);
            this.TransferTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferTab.Image = null;
            this.TransferTab.ImageSize = new System.Drawing.Size(40, 30);
            this.TransferTab.Location = new System.Drawing.Point(1, 44);
            this.TransferTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransferTab.Name = "TransferTab";
            this.TransferTab.ShowCloseButton = true;
            this.TransferTab.Size = new System.Drawing.Size(1786, 829);
            this.TransferTab.TabIndex = 5;
            this.TransferTab.Text = "Transfers";
            this.TransferTab.ThemesEnabled = false;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.99237F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.00764F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel11.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.MiniTabControl2, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.TransferExpander, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(11, 46);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1747, 519);
            this.tableLayoutPanel11.TabIndex = 152;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox2.Controls.Add(this.TransferGrid);
            this.groupBox2.Controls.Add(this.TransferNavigator);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(272, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 448);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // TransferGrid
            // 
            this.TransferGrid.AutoGenerateColumns = false;
            this.TransferGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransferGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TransferGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransferGrid.DataSource = this.TransferBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransferGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.TransferGrid.EnableHeadersVisualStyles = false;
            this.TransferGrid.Location = new System.Drawing.Point(32, 52);
            this.TransferGrid.Name = "TransferGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransferGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransferGrid.RowTemplate.Height = 28;
            this.TransferGrid.Size = new System.Drawing.Size(951, 347);
            this.TransferGrid.TabIndex = 2;
            // 
            // TransferBindingSource
            // 
            this.TransferBindingSource.DataMember = "T7";
            // 
            // TransferNavigator
            // 
            this.TransferNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.TransferNavigator.BackColor = System.Drawing.Color.Transparent;
            this.TransferNavigator.BindingSource = this.TransferBindingSource;
            this.TransferNavigator.CountItem = this.bindingNavigatorCountItem;
            this.TransferNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.TransferNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TransferNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TransferNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.TransferNavigator.Location = new System.Drawing.Point(3, 414);
            this.TransferNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.TransferNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.TransferNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.TransferNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.TransferNavigator.Name = "TransferNavigator";
            this.TransferNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.TransferNavigator.Size = new System.Drawing.Size(989, 31);
            this.TransferNavigator.TabIndex = 3;
            this.TransferNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // MiniTabControl2
            // 
            this.MiniTabControl2.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl2.BeforeTouchSize = new System.Drawing.Size(439, 442);
            this.MiniTabControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiniTabControl2.BorderVisible = true;
            this.MiniTabControl2.BorderWidth = 1;
            this.MiniTabControl2.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl2.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.MiniTabControl2.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.MiniTabControl2.Controls.Add(this.tabPageAdv3);
            this.MiniTabControl2.Controls.Add(this.tabPageAdv4);
            this.MiniTabControl2.FixedSingleBorderColor = System.Drawing.Color.DarkGray;
            this.MiniTabControl2.FocusOnTabClick = false;
            this.MiniTabControl2.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl2.Location = new System.Drawing.Point(1284, 3);
            this.MiniTabControl2.Name = "MiniTabControl2";
            this.MiniTabControl2.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.MiniTabControl2.ShowSeparator = false;
            this.MiniTabControl2.Size = new System.Drawing.Size(439, 442);
            this.MiniTabControl2.TabIndex = 151;
            this.MiniTabControl2.TabPanelBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniTabControl2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPageAdv3.Controls.Add(this.tableLayoutPanel9);
            this.tabPageAdv3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(437, 411);
            this.tabPageAdv3.TabIndex = 1;
            this.tabPageAdv3.Text = "tabPageAdv3";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.02913F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.97087F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel9.Controls.Add(this.label21, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox9, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox10, 2, 3);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox11, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox12, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.label24, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label25, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox13, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.label26, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.label28, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox14, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox15, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.metroTextBox16, 1, 5);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(52, 47);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 6;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92308F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07692F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(355, 221);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(152, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 21);
            this.label21.TabIndex = 162;
            this.label21.Text = "New:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox9.Location = new System.Drawing.Point(2, 171);
            this.metroTextBox9.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.ShortcutsEnabled = true;
            this.metroTextBox9.Size = new System.Drawing.Size(91, 28);
            this.metroTextBox9.TabIndex = 154;
            this.metroTextBox9.Text = "metroTextBox1";
            this.metroTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(23, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 21);
            this.label22.TabIndex = 65;
            this.label22.Text = "Amount:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox10
            // 
            // 
            // 
            // 
            this.metroTextBox10.CustomButton.Image = null;
            this.metroTextBox10.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.metroTextBox10.CustomButton.Name = "";
            this.metroTextBox10.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox10.CustomButton.TabIndex = 1;
            this.metroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox10.CustomButton.UseSelectable = true;
            this.metroTextBox10.CustomButton.Visible = false;
            this.metroTextBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox10.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox10.Lines = new string[] {
        "metroTextBox2"};
            this.metroTextBox10.Location = new System.Drawing.Point(237, 88);
            this.metroTextBox10.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox10.MaxLength = 32767;
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.PasswordChar = '\0';
            this.metroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox10.SelectedText = "";
            this.metroTextBox10.SelectionLength = 0;
            this.metroTextBox10.SelectionStart = 0;
            this.metroTextBox10.ShortcutsEnabled = true;
            this.metroTextBox10.Size = new System.Drawing.Size(116, 37);
            this.metroTextBox10.TabIndex = 155;
            this.metroTextBox10.Text = "metroTextBox2";
            this.metroTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox10.UseSelectable = true;
            this.metroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox11
            // 
            // 
            // 
            // 
            this.metroTextBox11.CustomButton.Image = null;
            this.metroTextBox11.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox11.CustomButton.Name = "";
            this.metroTextBox11.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox11.CustomButton.TabIndex = 1;
            this.metroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox11.CustomButton.UseSelectable = true;
            this.metroTextBox11.CustomButton.Visible = false;
            this.metroTextBox11.Lines = new string[0];
            this.metroTextBox11.Location = new System.Drawing.Point(117, 88);
            this.metroTextBox11.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox11.MaxLength = 32767;
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.PasswordChar = '\0';
            this.metroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox11.SelectedText = "";
            this.metroTextBox11.SelectionLength = 0;
            this.metroTextBox11.SelectionStart = 0;
            this.metroTextBox11.ShortcutsEnabled = true;
            this.metroTextBox11.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox11.TabIndex = 163;
            this.metroTextBox11.UseSelectable = true;
            this.metroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Location = new System.Drawing.Point(39, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 21);
            this.label23.TabIndex = 140;
            this.label23.Text = "BFY";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox12
            // 
            // 
            // 
            // 
            this.metroTextBox12.CustomButton.Image = null;
            this.metroTextBox12.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox12.CustomButton.Name = "";
            this.metroTextBox12.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox12.CustomButton.TabIndex = 1;
            this.metroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox12.CustomButton.UseSelectable = true;
            this.metroTextBox12.CustomButton.Visible = false;
            this.metroTextBox12.Lines = new string[0];
            this.metroTextBox12.Location = new System.Drawing.Point(3, 89);
            this.metroTextBox12.MaxLength = 32767;
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.PasswordChar = '\0';
            this.metroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox12.SelectedText = "";
            this.metroTextBox12.SelectionLength = 0;
            this.metroTextBox12.SelectionStart = 0;
            this.metroTextBox12.ShortcutsEnabled = true;
            this.metroTextBox12.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox12.TabIndex = 164;
            this.metroTextBox12.UseSelectable = true;
            this.metroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label24.Location = new System.Drawing.Point(151, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 21);
            this.label24.TabIndex = 60;
            this.label24.Text = "Fund:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(270, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 21);
            this.label25.TabIndex = 64;
            this.label25.Text = "Code:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox13
            // 
            // 
            // 
            // 
            this.metroTextBox13.CustomButton.Image = null;
            this.metroTextBox13.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox13.CustomButton.Name = "";
            this.metroTextBox13.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox13.CustomButton.TabIndex = 1;
            this.metroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox13.CustomButton.UseSelectable = true;
            this.metroTextBox13.CustomButton.Visible = false;
            this.metroTextBox13.Lines = new string[0];
            this.metroTextBox13.Location = new System.Drawing.Point(238, 27);
            this.metroTextBox13.MaxLength = 32767;
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.PasswordChar = '\0';
            this.metroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox13.SelectedText = "";
            this.metroTextBox13.SelectionLength = 0;
            this.metroTextBox13.SelectionStart = 0;
            this.metroTextBox13.ShortcutsEnabled = true;
            this.metroTextBox13.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox13.TabIndex = 165;
            this.metroTextBox13.UseSelectable = true;
            this.metroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label26.Location = new System.Drawing.Point(158, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 21);
            this.label26.TabIndex = 63;
            this.label26.Text = "RC:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Location = new System.Drawing.Point(273, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 21);
            this.label27.TabIndex = 66;
            this.label27.Text = "BOC:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(37, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 21);
            this.label28.TabIndex = 62;
            this.label28.Text = "Org:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox14
            // 
            // 
            // 
            // 
            this.metroTextBox14.CustomButton.Image = null;
            this.metroTextBox14.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox14.CustomButton.Name = "";
            this.metroTextBox14.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox14.CustomButton.TabIndex = 1;
            this.metroTextBox14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox14.CustomButton.UseSelectable = true;
            this.metroTextBox14.CustomButton.Visible = false;
            this.metroTextBox14.Lines = new string[0];
            this.metroTextBox14.Location = new System.Drawing.Point(118, 27);
            this.metroTextBox14.MaxLength = 32767;
            this.metroTextBox14.Name = "metroTextBox14";
            this.metroTextBox14.PasswordChar = '\0';
            this.metroTextBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox14.SelectedText = "";
            this.metroTextBox14.SelectionLength = 0;
            this.metroTextBox14.SelectionStart = 0;
            this.metroTextBox14.ShortcutsEnabled = true;
            this.metroTextBox14.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox14.TabIndex = 166;
            this.metroTextBox14.UseSelectable = true;
            this.metroTextBox14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox15
            // 
            // 
            // 
            // 
            this.metroTextBox15.CustomButton.Image = null;
            this.metroTextBox15.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox15.CustomButton.Name = "";
            this.metroTextBox15.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox15.CustomButton.TabIndex = 1;
            this.metroTextBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox15.CustomButton.UseSelectable = true;
            this.metroTextBox15.CustomButton.Visible = false;
            this.metroTextBox15.Lines = new string[0];
            this.metroTextBox15.Location = new System.Drawing.Point(3, 27);
            this.metroTextBox15.MaxLength = 32767;
            this.metroTextBox15.Name = "metroTextBox15";
            this.metroTextBox15.PasswordChar = '\0';
            this.metroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox15.SelectedText = "";
            this.metroTextBox15.SelectionLength = 0;
            this.metroTextBox15.SelectionStart = 0;
            this.metroTextBox15.ShortcutsEnabled = true;
            this.metroTextBox15.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox15.TabIndex = 167;
            this.metroTextBox15.UseSelectable = true;
            this.metroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox16
            // 
            // 
            // 
            // 
            this.metroTextBox16.CustomButton.Image = null;
            this.metroTextBox16.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox16.CustomButton.Name = "";
            this.metroTextBox16.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox16.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox16.CustomButton.TabIndex = 1;
            this.metroTextBox16.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox16.CustomButton.UseSelectable = true;
            this.metroTextBox16.CustomButton.Visible = false;
            this.metroTextBox16.Lines = new string[0];
            this.metroTextBox16.Location = new System.Drawing.Point(118, 172);
            this.metroTextBox16.MaxLength = 32767;
            this.metroTextBox16.Name = "metroTextBox16";
            this.metroTextBox16.PasswordChar = '\0';
            this.metroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox16.SelectedText = "";
            this.metroTextBox16.SelectionLength = 0;
            this.metroTextBox16.SelectionStart = 0;
            this.metroTextBox16.ShortcutsEnabled = true;
            this.metroTextBox16.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox16.TabIndex = 168;
            this.metroTextBox16.UseSelectable = true;
            this.metroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox16.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.chartControl2);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(437, 411);
            this.tabPageAdv4.TabIndex = 2;
            this.tabPageAdv4.Text = "tabPageAdv4";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // chartControl2
            // 
            this.chartControl2.AllowGradientPalette = true;
            this.chartControl2.AllowUserEditStyles = true;
            this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.chartControl2.ChartArea.AutoScale = true;
            this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl2.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.chartControl2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl2.ChartArea.CursorReDraw = false;
            this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.chartControl2.ChartAreaShadow = true;
            this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.chartControl2.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.chartControl2.DataSourceName = "[none]";
            this.chartControl2.Depth = 250F;
            this.chartControl2.DisplayChartContextMenu = false;
            this.chartControl2.DisplaySeriesContextMenu = false;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.EnableMouseRotation = true;
            this.chartControl2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartControl2.HighlightSymbol = true;
            this.chartControl2.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl2.Legend.Location = new System.Drawing.Point(8, 8);
            this.chartControl2.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl2.Legend.Visible = false;
            this.chartControl2.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl2.Localize = null;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.Padding = new System.Windows.Forms.Padding(1);
            this.chartControl2.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartControl2.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl2.PrimaryXAxis.Margin = true;
            this.chartControl2.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.chartControl2.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl2.PrimaryYAxis.Margin = true;
            this.chartControl2.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl2.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.chartControl2.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.chartControl2.RealMode3D = true;
            this.chartControl2.Rotation = 45F;
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
            this.chartControl2.Series.Add(chartSeries13);
            this.chartControl2.Series.Add(chartSeries14);
            this.chartControl2.Series3D = true;
            this.chartControl2.SeriesHighlight = true;
            this.chartControl2.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.chartControl2.Size = new System.Drawing.Size(437, 411);
            this.chartControl2.Spacing = 5F;
            this.chartControl2.SpacingBetweenPoints = 5F;
            this.chartControl2.Style3D = true;
            this.chartControl2.TabIndex = 46;
            this.chartControl2.Tilt = 15F;
            // 
            // 
            // 
            this.chartControl2.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl2.Title.Name = "Default";
            this.chartControl2.ToolBar.EnableDefaultItems = false;
            this.chartControl2.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarPrintPreviewItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarSplitter7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarStyleItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.chartControl2.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // TransferExpander
            // 
            this.TransferExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.TransferExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.TransferExpander.Controls.Add(this.TransferFilterPanel);
            this.TransferExpander.ExpandedHeight = 493;
            this.TransferExpander.IsExpanded = false;
            this.TransferExpander.Location = new System.Drawing.Point(3, 3);
            this.TransferExpander.Name = "TransferExpander";
            this.TransferExpander.Size = new System.Drawing.Size(242, 37);
            this.TransferExpander.TabIndex = 152;
            this.TransferExpander.Text = "Select";
            this.TransferExpander.UseAnimation = true;
            // 
            // TransferFilterPanel
            // 
            this.TransferFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TransferFilterPanel.Controls.Add(this.label5);
            this.TransferFilterPanel.Controls.Add(this.FrRcComboBox1);
            this.TransferFilterPanel.Controls.Add(this.label4);
            this.TransferFilterPanel.Controls.Add(this.ReprogrammingTypeComboBox);
            this.TransferFilterPanel.Controls.Add(this.amountLabel1);
            this.TransferFilterPanel.Controls.Add(this.amountCurrencyTextBox);
            this.TransferFilterPanel.Controls.Add(this.codeLabel1);
            this.TransferFilterPanel.Controls.Add(this.FrCodeComboBox);
            this.TransferFilterPanel.Controls.Add(this.orgLabel);
            this.TransferFilterPanel.Controls.Add(this.FrOrgComboBox);
            this.TransferFilterPanel.Controls.Add(this.bOCLabel1);
            this.TransferFilterPanel.Controls.Add(this.FrBocComboBox);
            this.TransferFilterPanel.Controls.Add(this.fundLabel1);
            this.TransferFilterPanel.Controls.Add(this.FrFundComboBox);
            this.TransferFilterPanel.Controls.Add(this.bFYLabel1);
            this.TransferFilterPanel.Controls.Add(this.FrBfyComboBox);
            this.TransferFilterPanel.Controls.Add(this.rPIOLabel);
            this.TransferFilterPanel.Controls.Add(this.FrRpioComboBox);
            this.TransferFilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.TransferFilterPanel.HorizontalScrollbarBarColor = true;
            this.TransferFilterPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TransferFilterPanel.HorizontalScrollbarSize = 9;
            this.TransferFilterPanel.Location = new System.Drawing.Point(18, 60);
            this.TransferFilterPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransferFilterPanel.Name = "TransferFilterPanel";
            this.TransferFilterPanel.Size = new System.Drawing.Size(227, 430);
            this.TransferFilterPanel.TabIndex = 70;
            this.TransferFilterPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransferFilterPanel.VerticalScrollbarBarColor = true;
            this.TransferFilterPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TransferFilterPanel.VerticalScrollbarSize = 8;
            // 
            // FrRcComboBox1
            // 
            this.FrRcComboBox1.BackColor = System.Drawing.Color.Black;
            this.FrRcComboBox1.DataSource = this.TransferBindingSource;
            this.FrRcComboBox1.DisplayMember = "RC";
            this.FrRcComboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.FrRcComboBox1.FormattingEnabled = true;
            this.FrRcComboBox1.ItemHeight = 23;
            this.FrRcComboBox1.Location = new System.Drawing.Point(80, 227);
            this.FrRcComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrRcComboBox1.Name = "FrRcComboBox1";
            this.FrRcComboBox1.Size = new System.Drawing.Size(117, 29);
            this.FrRcComboBox1.TabIndex = 20;
            this.FrRcComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrRcComboBox1.UseSelectable = true;
            // 
            // ReprogrammingTypeComboBox
            // 
            this.ReprogrammingTypeComboBox.DataSource = this.TransferBindingSource;
            this.ReprogrammingTypeComboBox.DisplayMember = "DocType";
            this.ReprogrammingTypeComboBox.FormattingEnabled = true;
            this.ReprogrammingTypeComboBox.ItemHeight = 23;
            this.ReprogrammingTypeComboBox.Location = new System.Drawing.Point(80, 16);
            this.ReprogrammingTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReprogrammingTypeComboBox.Name = "ReprogrammingTypeComboBox";
            this.ReprogrammingTypeComboBox.Size = new System.Drawing.Size(117, 29);
            this.ReprogrammingTypeComboBox.TabIndex = 18;
            this.ReprogrammingTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReprogrammingTypeComboBox.UseSelectable = true;
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
            this.amountCurrencyTextBox.Location = new System.Drawing.Point(82, 359);
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
            this.FrCodeComboBox.DataSource = this.TransferBindingSource;
            this.FrCodeComboBox.DisplayMember = "ProgramProjectCode";
            this.FrCodeComboBox.FormattingEnabled = true;
            this.FrCodeComboBox.ItemHeight = 23;
            this.FrCodeComboBox.Location = new System.Drawing.Point(80, 317);
            this.FrCodeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrCodeComboBox.Name = "FrCodeComboBox";
            this.FrCodeComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrCodeComboBox.TabIndex = 15;
            this.FrCodeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrCodeComboBox.UseSelectable = true;
            // 
            // FrOrgComboBox
            // 
            this.FrOrgComboBox.DataSource = this.TransferBindingSource;
            this.FrOrgComboBox.DisplayMember = "Org";
            this.FrOrgComboBox.FormattingEnabled = true;
            this.FrOrgComboBox.ItemHeight = 23;
            this.FrOrgComboBox.Location = new System.Drawing.Point(80, 188);
            this.FrOrgComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrOrgComboBox.Name = "FrOrgComboBox";
            this.FrOrgComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrOrgComboBox.TabIndex = 13;
            this.FrOrgComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrOrgComboBox.UseSelectable = true;
            // 
            // FrBocComboBox
            // 
            this.FrBocComboBox.DataSource = this.TransferBindingSource;
            this.FrBocComboBox.DisplayMember = "BOC";
            this.FrBocComboBox.FormattingEnabled = true;
            this.FrBocComboBox.ItemHeight = 23;
            this.FrBocComboBox.Location = new System.Drawing.Point(80, 268);
            this.FrBocComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrBocComboBox.Name = "FrBocComboBox";
            this.FrBocComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrBocComboBox.TabIndex = 11;
            this.FrBocComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrBocComboBox.UseSelectable = true;
            // 
            // FrFundComboBox
            // 
            this.FrFundComboBox.DataSource = this.TransferBindingSource;
            this.FrFundComboBox.DisplayMember = "Fund";
            this.FrFundComboBox.FormattingEnabled = true;
            this.FrFundComboBox.ItemHeight = 23;
            this.FrFundComboBox.Location = new System.Drawing.Point(80, 146);
            this.FrFundComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrFundComboBox.Name = "FrFundComboBox";
            this.FrFundComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrFundComboBox.TabIndex = 9;
            this.FrFundComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrFundComboBox.UseSelectable = true;
            // 
            // FrBfyComboBox
            // 
            this.FrBfyComboBox.DataSource = this.TransferBindingSource;
            this.FrBfyComboBox.DisplayMember = "BBFY";
            this.FrBfyComboBox.FormattingEnabled = true;
            this.FrBfyComboBox.ItemHeight = 23;
            this.FrBfyComboBox.Location = new System.Drawing.Point(80, 104);
            this.FrBfyComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrBfyComboBox.Name = "FrBfyComboBox";
            this.FrBfyComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrBfyComboBox.TabIndex = 7;
            this.FrBfyComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrBfyComboBox.UseSelectable = true;
            // 
            // FrRpioComboBox
            // 
            this.FrRpioComboBox.DataSource = this.TransferBindingSource;
            this.FrRpioComboBox.DisplayMember = "RPIO";
            this.FrRpioComboBox.FormattingEnabled = true;
            this.FrRpioComboBox.ItemHeight = 23;
            this.FrRpioComboBox.Location = new System.Drawing.Point(80, 64);
            this.FrRpioComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FrRpioComboBox.Name = "FrRpioComboBox";
            this.FrRpioComboBox.Size = new System.Drawing.Size(117, 29);
            this.FrRpioComboBox.TabIndex = 3;
            this.FrRpioComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FrRpioComboBox.UseSelectable = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.metroButton11);
            this.flowLayoutPanel5.Controls.Add(this.metroButton12);
            this.flowLayoutPanel5.Controls.Add(this.metroButton13);
            this.flowLayoutPanel5.Controls.Add(this.metroButton14);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(853, 606);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(439, 66);
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
            this.metroButton11.UseSelectable = true;
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
            this.metroButton12.UseSelectable = true;
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
            this.metroButton13.UseSelectable = true;
            // 
            // metroButton14
            // 
            this.metroButton14.BackColor = System.Drawing.Color.Black;
            this.metroButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton14.Location = new System.Drawing.Point(2, 62);
            this.metroButton14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(114, 53);
            this.metroButton14.TabIndex = 66;
            this.metroButton14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton14.UseSelectable = true;
            // 
            // expandCollapsePanel7
            // 
            this.expandCollapsePanel7.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel7.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel7.ExpandedHeight = 508;
            this.expandCollapsePanel7.IsExpanded = true;
            this.expandCollapsePanel7.Location = new System.Drawing.Point(30, 60);
            this.expandCollapsePanel7.Name = "expandCollapsePanel7";
            this.expandCollapsePanel7.Size = new System.Drawing.Size(280, 508);
            this.expandCollapsePanel7.TabIndex = 86;
            this.expandCollapsePanel7.Text = "expandCollapsePanel7";
            this.expandCollapsePanel7.UseAnimation = true;
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
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(133, 194);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox8.TabIndex = 0;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
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
            // 
            // 
            // 
            // 
            this.Old.CustomButton.Image = null;
            this.Old.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.Old.CustomButton.Name = "";
            this.Old.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Old.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Old.CustomButton.TabIndex = 1;
            this.Old.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Old.CustomButton.UseSelectable = true;
            this.Old.CustomButton.Visible = false;
            this.Old.Lines = new string[0];
            this.Old.Location = new System.Drawing.Point(3, 194);
            this.Old.MaxLength = 32767;
            this.Old.Name = "Old";
            this.Old.PasswordChar = '\0';
            this.Old.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Old.SelectedText = "";
            this.Old.SelectionLength = 0;
            this.Old.SelectionStart = 0;
            this.Old.ShortcutsEnabled = true;
            this.Old.Size = new System.Drawing.Size(0, 22);
            this.Old.TabIndex = 141;
            this.Old.UseSelectable = true;
            this.Old.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Old.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Code
            // 
            // 
            // 
            // 
            this.Code.CustomButton.Image = null;
            this.Code.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.Code.CustomButton.Name = "";
            this.Code.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Code.CustomButton.TabIndex = 1;
            this.Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Code.CustomButton.UseSelectable = true;
            this.Code.CustomButton.Visible = false;
            this.Code.Lines = new string[0];
            this.Code.Location = new System.Drawing.Point(263, 112);
            this.Code.MaxLength = 32767;
            this.Code.Name = "Code";
            this.Code.PasswordChar = '\0';
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Code.SelectedText = "";
            this.Code.SelectionLength = 0;
            this.Code.SelectionStart = 0;
            this.Code.ShortcutsEnabled = true;
            this.Code.Size = new System.Drawing.Size(0, 22);
            this.Code.TabIndex = 142;
            this.Code.UseSelectable = true;
            this.Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BOC
            // 
            // 
            // 
            // 
            this.BOC.CustomButton.Image = null;
            this.BOC.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.BOC.CustomButton.Name = "";
            this.BOC.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.BOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BOC.CustomButton.TabIndex = 1;
            this.BOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BOC.CustomButton.UseSelectable = true;
            this.BOC.CustomButton.Visible = false;
            this.BOC.Lines = new string[0];
            this.BOC.Location = new System.Drawing.Point(263, 30);
            this.BOC.MaxLength = 32767;
            this.BOC.Name = "BOC";
            this.BOC.PasswordChar = '\0';
            this.BOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BOC.SelectedText = "";
            this.BOC.SelectionLength = 0;
            this.BOC.SelectionStart = 0;
            this.BOC.ShortcutsEnabled = true;
            this.BOC.Size = new System.Drawing.Size(0, 22);
            this.BOC.TabIndex = 143;
            this.BOC.UseSelectable = true;
            this.BOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
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
            this.Fund.CustomButton.Image = null;
            this.Fund.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.Fund.CustomButton.Name = "";
            this.Fund.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Fund.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Fund.CustomButton.TabIndex = 1;
            this.Fund.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Fund.CustomButton.UseSelectable = true;
            this.Fund.CustomButton.Visible = false;
            this.Fund.Lines = new string[0];
            this.Fund.Location = new System.Drawing.Point(133, 30);
            this.Fund.MaxLength = 32767;
            this.Fund.Name = "Fund";
            this.Fund.PasswordChar = '\0';
            this.Fund.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Fund.SelectedText = "";
            this.Fund.SelectionLength = 0;
            this.Fund.SelectionStart = 0;
            this.Fund.ShortcutsEnabled = true;
            this.Fund.Size = new System.Drawing.Size(0, 22);
            this.Fund.TabIndex = 144;
            this.Fund.UseSelectable = true;
            this.Fund.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fund.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Org
            // 
            // 
            // 
            // 
            this.Org.CustomButton.Image = null;
            this.Org.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.Org.CustomButton.Name = "";
            this.Org.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Org.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Org.CustomButton.TabIndex = 1;
            this.Org.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Org.CustomButton.UseSelectable = true;
            this.Org.CustomButton.Visible = false;
            this.Org.Lines = new string[0];
            this.Org.Location = new System.Drawing.Point(3, 112);
            this.Org.MaxLength = 32767;
            this.Org.Name = "Org";
            this.Org.PasswordChar = '\0';
            this.Org.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Org.SelectedText = "";
            this.Org.SelectionLength = 0;
            this.Org.SelectionStart = 0;
            this.Org.ShortcutsEnabled = true;
            this.Org.Size = new System.Drawing.Size(0, 22);
            this.Org.TabIndex = 145;
            this.Org.UseSelectable = true;
            this.Org.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Org.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label43
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
            // 
            // 
            // 
            // 
            this.BFY.CustomButton.Image = null;
            this.BFY.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.BFY.CustomButton.Name = "";
            this.BFY.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.BFY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BFY.CustomButton.TabIndex = 1;
            this.BFY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BFY.CustomButton.UseSelectable = true;
            this.BFY.CustomButton.Visible = false;
            this.BFY.Lines = new string[0];
            this.BFY.Location = new System.Drawing.Point(3, 30);
            this.BFY.MaxLength = 32767;
            this.BFY.Name = "BFY";
            this.BFY.PasswordChar = '\0';
            this.BFY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BFY.SelectedText = "";
            this.BFY.SelectionLength = 0;
            this.BFY.SelectionStart = 0;
            this.BFY.ShortcutsEnabled = true;
            this.BFY.Size = new System.Drawing.Size(0, 22);
            this.BFY.TabIndex = 146;
            this.BFY.UseSelectable = true;
            this.BFY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BFY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
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
            this.RC.CustomButton.Image = null;
            this.RC.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.RC.CustomButton.Name = "";
            this.RC.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.RC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RC.CustomButton.TabIndex = 1;
            this.RC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RC.CustomButton.UseSelectable = true;
            this.RC.CustomButton.Visible = false;
            this.RC.Lines = new string[0];
            this.RC.Location = new System.Drawing.Point(133, 112);
            this.RC.MaxLength = 32767;
            this.RC.Name = "RC";
            this.RC.PasswordChar = '\0';
            this.RC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RC.SelectedText = "";
            this.RC.SelectionLength = 0;
            this.RC.SelectionStart = 0;
            this.RC.ShortcutsEnabled = true;
            this.RC.Size = new System.Drawing.Size(0, 22);
            this.RC.TabIndex = 147;
            this.RC.UseSelectable = true;
            this.RC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
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
            chartSeries15.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries15.Name = "Default0";
            chartSeries15.Points.Add(1D, ((double)(55D)));
            chartSeries15.Points.Add(2D, ((double)(70D)));
            chartSeries15.Points.Add(3D, ((double)(80D)));
            chartSeries15.Points.Add(4D, ((double)(65D)));
            chartSeries15.Points.Add(5D, ((double)(75D)));
            chartSeries15.Resolution = 0D;
            chartSeries15.StackingGroup = "Default Group";
            chartSeries15.Style.AltTagFormat = "";
            chartSeries15.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries15.Style.DrawTextShape = false;
            chartSeries15.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo8.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo8.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo8.DashPattern = null;
            chartLineInfo8.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo8.Width = 1F;
            chartCustomShapeInfo15.Border = chartLineInfo8;
            chartCustomShapeInfo15.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo15.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries15.Style.TextShape = chartCustomShapeInfo15;
            chartSeries15.Text = "Default0";
            chartSeries16.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries16.Name = "Default1";
            chartSeries16.Points.Add(1D, ((double)(70D)));
            chartSeries16.Points.Add(2D, ((double)(35D)));
            chartSeries16.Points.Add(3D, ((double)(65D)));
            chartSeries16.Points.Add(4D, ((double)(25D)));
            chartSeries16.Points.Add(5D, ((double)(50D)));
            chartSeries16.Resolution = 0D;
            chartSeries16.StackingGroup = "Default Group";
            chartSeries16.Style.AltTagFormat = "";
            chartSeries16.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries16.Style.DrawTextShape = false;
            chartSeries16.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo16.Border = chartLineInfo8;
            chartCustomShapeInfo16.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo16.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries16.Style.TextShape = chartCustomShapeInfo16;
            chartSeries16.Text = "Default1";
            this.PrcChart.Series.Add(chartSeries15);
            this.PrcChart.Series.Add(chartSeries16);
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
            this.PrcChart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSplitter8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarStyleItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.PrcChart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
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
            this.Text = "Division ";
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
            this.AppriopriationTabExpander.ResumeLayout(false);
            this.AppriopriationTabExpander.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).EndInit();
            this.BocTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton2)).EndInit();
            this.NpmTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton3)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.expandCollapsePanel6.ResumeLayout(false);
            this.expandCollapsePanel6.PerformLayout();
            this.ProgramTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percent)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.expandCollapsePanel5.ResumeLayout(false);
            this.expandCollapsePanel5.PerformLayout();
            this.ProjectTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton4)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.expandCollapsePanel4.ResumeLayout(false);
            this.expandCollapsePanel4.PerformLayout();
            this.DataTab.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.Expander.ResumeLayout(false);
            this.Expander.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).EndInit();
            this.MiniTabControl1.ResumeLayout(false);
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
            this.tableLayoutPanel11.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferNavigator)).EndInit();
            this.TransferNavigator.ResumeLayout(false);
            this.TransferNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl2)).EndInit();
            this.MiniTabControl2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tabPageAdv4.ResumeLayout(false);
            this.TransferExpander.ResumeLayout(false);
            this.TransferExpander.PerformLayout();
            this.TransferFilterPanel.ResumeLayout(false);
            this.TransferFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountCurrencyTextBox)).EndInit();
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
            this.ResumeLayout(false);

                }

                #endregion

                protected internal Syncfusion.Windows.Forms.Tools.TabControlAdv DivisionFormTabControl;
                Syncfusion.Windows.Forms.Tools.TabPageAdv AppropriationTab;
                System.Windows.Forms.ListBox approplistbox;
                MetroFramework.Controls.MetroButton metroButton1;
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv TransferTab;
                MetroFramework.Controls.MetroPanel TransferFilterPanel;
                MetroFramework.Controls.MetroComboBox FrRcComboBox1;
                MetroFramework.Controls.MetroComboBox ReprogrammingTypeComboBox;
                Syncfusion.Windows.Forms.Tools.CurrencyTextBox amountCurrencyTextBox;
                MetroFramework.Controls.MetroComboBox FrCodeComboBox;
                MetroFramework.Controls.MetroComboBox FrOrgComboBox;
                MetroFramework.Controls.MetroComboBox FrBocComboBox;
                MetroFramework.Controls.MetroComboBox FrFundComboBox;
                MetroFramework.Controls.MetroComboBox FrBfyComboBox;
                MetroFramework.Controls.MetroComboBox FrRpioComboBox;
                System.Windows.Forms.ListBox ImageBox;
                private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
                protected internal MetroFramework.Controls.MetroButton metroButton11;
                protected internal MetroFramework.Controls.MetroButton metroButton12;
                protected internal MetroFramework.Controls.MetroButton metroButton13;
                protected internal MetroFramework.Controls.MetroButton metroButton14;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv ProgramTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv BocTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv NpmTab;
                private System.Windows.Forms.SplitContainer splitContainer5;
                private System.Windows.Forms.RadioButton rb3;
                private System.Windows.Forms.RadioButton rb2;
                private System.Windows.Forms.RadioButton rb1;
                protected Syncfusion.Windows.Forms.Chart.ChartControl AppropChart;
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
                private System.Windows.Forms.FlowLayoutPanel AppropriationTabFilterPanel;
                private DataGridView DataGrid;
                protected ChartControl PrcChart;
                private BindingSource P8BindingSource;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel AppriopriationTabExpander;
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
                private TabControlAdv MiniTabControl1;
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
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel Expander;
                private FlowLayoutPanel P7FilterPanel;
                private DataGridView Grid;
                private TableLayoutPanel tableLayoutPanel6;
                private TableLayoutPanel tableLayoutPanel7;
                private TableLayoutPanel tableLayoutPanel8;
                private ToggleButton toggleButton1;
                private ToggleButton toggleButton2;
                private ToggleButton toggleButton3;
                private ToggleButton Percent;
                private ToggleButton toggleButton4;
                private DataGridView TransferGrid;
                private BindingSource TransferBindingSource;
                private BindingNavigator TransferNavigator;
                private ToolStripButton bindingNavigatorAddNewItem;
                private ToolStripLabel bindingNavigatorCountItem;
                private ToolStripButton bindingNavigatorDeleteItem;
                private ToolStripButton bindingNavigatorMoveFirstItem;
                private ToolStripButton bindingNavigatorMovePreviousItem;
                private ToolStripSeparator bindingNavigatorSeparator;
                private ToolStripTextBox bindingNavigatorPositionItem;
                private ToolStripSeparator bindingNavigatorSeparator1;
                private ToolStripButton bindingNavigatorMoveNextItem;
                private ToolStripButton bindingNavigatorMoveLastItem;
                private ToolStripSeparator bindingNavigatorSeparator2;
                private DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn docTypeDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn rPIODataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn rCDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn fundDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn programProjectCodeDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn bOCDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn programProjectNameDataGridViewTextBoxColumn;
                private DataGridViewTextBoxColumn npmCodeDataGridViewTextBoxColumn;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel7;
                private TabControlAdv MiniTabControl2;
                private TabPageAdv tabPageAdv3;
                private TableLayoutPanel tableLayoutPanel9;
                private Label label21;
                private MetroTextBox metroTextBox9;
                private Label label22;
                private MetroTextBox metroTextBox10;
                private MetroTextBox metroTextBox11;
                private Label label23;
                private MetroTextBox metroTextBox12;
                private Label label24;
                private Label label25;
                private MetroTextBox metroTextBox13;
                private Label label26;
                private Label label27;
                private Label label28;
                private MetroTextBox metroTextBox14;
                private MetroTextBox metroTextBox15;
                private MetroTextBox metroTextBox16;
                private TabPageAdv tabPageAdv4;
                protected ChartControl chartControl2;
                private TableLayoutPanel tableLayoutPanel10;
                private TableLayoutPanel tableLayoutPanel11;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel TransferExpander;
                private GroupBox groupBox2;
            } 
        }


    }
}