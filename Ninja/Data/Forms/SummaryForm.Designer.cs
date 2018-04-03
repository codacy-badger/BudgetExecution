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
            partial class SummaryForm : MetroForm
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection6 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection6 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer6 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection6 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries13 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo13 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo7 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries14 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo14 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection7 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection7 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer7 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection7 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries15 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo15 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo8 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries16 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo16 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.Tab1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.Chart1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.toggleButton1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.expandCollapsePanel4 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.Tab2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Chart2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel3 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toggleButton2 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.Tab3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.Chart3 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.toggleButton3 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.Tab4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContaineEPA = new System.Windows.Forms.SplitContainer();
            this.Chart4 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.toggleButton4 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.Tab5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Chart5 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel6 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.toggleButton6 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.Tab6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.Chart6 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel5 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.toggleButton5 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.Tab7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.Chart7 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel7 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.toggleButton7 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProgramListBox = new System.Windows.Forms.ListBox();
            this.flpanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.obj1 = new MetroFramework.Controls.MetroRadioButton();
            this.obj2 = new MetroFramework.Controls.MetroRadioButton();
            this.obj3 = new MetroFramework.Controls.MetroRadioButton();
            this.obj4 = new MetroFramework.Controls.MetroRadioButton();
            this.obj5 = new MetroFramework.Controls.MetroRadioButton();
            this.ObjectiveChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.Project = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.Objective = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ObjectiveTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).BeginInit();
            this.SummaryTabControl.SuspendLayout();
            this.Tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).BeginInit();
            this.expandCollapsePanel4.SuspendLayout();
            this.Tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.expandCollapsePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton2)).BeginInit();
            this.Tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton3)).BeginInit();
            this.Tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContaineEPA)).BeginInit();
            this.splitContaineEPA.Panel1.SuspendLayout();
            this.splitContaineEPA.Panel2.SuspendLayout();
            this.splitContaineEPA.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton4)).BeginInit();
            this.Tab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.expandCollapsePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton6)).BeginInit();
            this.Tab6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.expandCollapsePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton5)).BeginInit();
            this.Tab7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.expandCollapsePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flpanel5.SuspendLayout();
            this.Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryTabControl
            // 
            this.SummaryTabControl.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTabControl.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SummaryTabControl.BeforeTouchSize = new System.Drawing.Size(1786, 892);
            this.SummaryTabControl.BorderVisible = true;
            this.SummaryTabControl.BorderWidth = 1;
            this.SummaryTabControl.CloseButtonForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.Controls.Add(this.Tab1);
            this.SummaryTabControl.Controls.Add(this.Tab2);
            this.SummaryTabControl.Controls.Add(this.Tab3);
            this.SummaryTabControl.Controls.Add(this.Tab4);
            this.SummaryTabControl.Controls.Add(this.Tab5);
            this.SummaryTabControl.Controls.Add(this.Tab6);
            this.SummaryTabControl.Controls.Add(this.Tab7);
            this.SummaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.Color.Transparent;
            this.SummaryTabControl.FocusOnTabClick = false;
            this.SummaryTabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.SlateGray;
            this.SummaryTabControl.ItemSize = new System.Drawing.Size(400, 39);
            this.SummaryTabControl.Location = new System.Drawing.Point(1, 1);
            this.SummaryTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.Padding = new System.Drawing.Point(10, 3);
            this.SummaryTabControl.RotateTextWhenVertical = true;
            this.SummaryTabControl.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.SummaryTabControl.ShowSeparator = false;
            this.SummaryTabControl.Size = new System.Drawing.Size(1786, 892);
            this.SummaryTabControl.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.ShrinkToFit;
            this.SummaryTabControl.TabGap = 15;
            this.SummaryTabControl.TabIndex = 44;
            this.SummaryTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            // 
            // Tab1
            // 
            this.Tab1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab1.Controls.Add(this.splitContainer5);
            this.Tab1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1.Image = null;
            this.Tab1.ImageSize = new System.Drawing.Size(40, 40);
            this.Tab1.Location = new System.Drawing.Point(1, 44);
            this.Tab1.Margin = new System.Windows.Forms.Padding(2);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(1);
            this.Tab1.ShowCloseButton = true;
            this.Tab1.Size = new System.Drawing.Size(1784, 847);
            this.Tab1.TabIndex = 6;
            this.Tab1.Text = "Appropriations";
            this.Tab1.ThemesEnabled = false;
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
            this.splitContainer5.Panel1.Controls.Add(this.Chart1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.toggleButton1);
            this.splitContainer5.Panel2.Controls.Add(this.expandCollapsePanel4);
            this.splitContainer5.Panel2.Controls.Add(this.rb5);
            this.splitContainer5.Panel2.Controls.Add(this.rb4);
            this.splitContainer5.Panel2.Controls.Add(this.rb1);
            this.splitContainer5.Panel2.Controls.Add(this.rb3);
            this.splitContainer5.Panel2.Controls.Add(this.rb2);
            this.splitContainer5.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer5.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer5.Size = new System.Drawing.Size(1780, 843);
            this.splitContainer5.SplitterDistance = 1491;
            this.splitContainer5.SplitterWidth = 7;
            this.splitContainer5.TabIndex = 96;
            // 
            // Chart1
            // 
            this.Chart1.AllowGradientPalette = true;
            this.Chart1.AllowUserEditStyles = true;
            this.Chart1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart1.ChartArea.AutoScale = true;
            this.Chart1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart1.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart1.ChartArea.CursorReDraw = false;
            this.Chart1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart1.ChartAreaShadow = true;
            this.Chart1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart1.DataSourceName = "[none]";
            this.Chart1.Depth = 250F;
            this.Chart1.DisplayChartContextMenu = false;
            this.Chart1.DisplaySeriesContextMenu = false;
            this.Chart1.EnableMouseRotation = true;
            this.Chart1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart1.HighlightSymbol = true;
            this.Chart1.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart1.Legend.Location = new System.Drawing.Point(7, 7);
            this.Chart1.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.Chart1.Legend.Visible = false;
            this.Chart1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.Chart1.Localize = null;
            this.Chart1.Location = new System.Drawing.Point(23, 79);
            this.Chart1.Margin = new System.Windows.Forms.Padding(2);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart1.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart1.PrimaryXAxis.Margin = true;
            this.Chart1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart1.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart1.PrimaryYAxis.Margin = true;
            this.Chart1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart1.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart1.RealMode3D = true;
            this.Chart1.Rotation = 45F;
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
            this.Chart1.Series.Add(chartSeries1);
            this.Chart1.Series.Add(chartSeries2);
            this.Chart1.Series3D = true;
            this.Chart1.SeriesHighlight = true;
            this.Chart1.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart1.Size = new System.Drawing.Size(1440, 665);
            this.Chart1.Spacing = 5F;
            this.Chart1.SpacingBetweenPoints = 5F;
            this.Chart1.Style3D = true;
            this.Chart1.TabIndex = 42;
            this.Chart1.Tilt = 15F;
            // 
            // 
            // 
            this.Chart1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart1.Title.Name = "Default";
            this.Chart1.ToolBar.EnableDefaultItems = false;
            this.Chart1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.Chart1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
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
            this.toggleButton1.Location = new System.Drawing.Point(2, 2);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Renderer = toggleButtonRenderer1;
            this.toggleButton1.Size = new System.Drawing.Size(66, 36);
            sliderCollection1.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection1.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection1.Width = 30;
            this.toggleButton1.Slider = sliderCollection1;
            this.toggleButton1.TabIndex = 106;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // expandCollapsePanel4
            // 
            this.expandCollapsePanel4.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel4.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel4.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel4.Controls.Add(this.listBox1);
            this.expandCollapsePanel4.ExpandedHeight = 587;
            this.expandCollapsePanel4.IsExpanded = true;
            this.expandCollapsePanel4.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel4.Name = "expandCollapsePanel4";
            this.expandCollapsePanel4.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel4.TabIndex = 105;
            this.expandCollapsePanel4.Text = "Filter";
            this.expandCollapsePanel4.UseAnimation = true;
            this.expandCollapsePanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.expandCollapsePanel4_Paint);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(13, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 378);
            this.listBox1.TabIndex = 43;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(886, 210);
            this.rb5.Margin = new System.Windows.Forms.Padding(2);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(101, 32);
            this.rb5.TabIndex = 4;
            this.rb5.Text = "Division";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(886, 184);
            this.rb4.Margin = new System.Windows.Forms.Padding(2);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(115, 32);
            this.rb4.TabIndex = 3;
            this.rb4.Text = "Objective";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(886, 105);
            this.rb1.Margin = new System.Windows.Forms.Padding(2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(75, 32);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "BOC";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(886, 158);
            this.rb3.Margin = new System.Windows.Forms.Padding(2);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(75, 32);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "Goal";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(886, 131);
            this.rb2.Margin = new System.Windows.Forms.Padding(2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(79, 32);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "NPM";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // Tab2
            // 
            this.Tab2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab2.Controls.Add(this.splitContainer2);
            this.Tab2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2.Image = null;
            this.Tab2.ImageSize = new System.Drawing.Size(50, 40);
            this.Tab2.Location = new System.Drawing.Point(1, 44);
            this.Tab2.Margin = new System.Windows.Forms.Padding(7);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.ShowCloseButton = true;
            this.Tab2.Size = new System.Drawing.Size(1784, 847);
            this.Tab2.TabIndex = 3;
            this.Tab2.Text = "BOC";
            this.Tab2.ThemesEnabled = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Chart2);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.expandCollapsePanel3);
            this.splitContainer2.Panel2.Controls.Add(this.toggleButton2);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Size = new System.Drawing.Size(1776, 839);
            this.splitContainer2.SplitterDistance = 1491;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 98;
            // 
            // Chart2
            // 
            this.Chart2.AllowGradientPalette = true;
            this.Chart2.AllowUserEditStyles = true;
            this.Chart2.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart2.ChartArea.AutoScale = true;
            this.Chart2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart2.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart2.ChartArea.CursorReDraw = false;
            this.Chart2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart2.ChartAreaShadow = true;
            this.Chart2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart2.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart2.DataSourceName = "[none]";
            this.Chart2.Depth = 250F;
            this.Chart2.DisplayChartContextMenu = false;
            this.Chart2.DisplaySeriesContextMenu = false;
            this.Chart2.EnableMouseRotation = true;
            this.Chart2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart2.HighlightSymbol = true;
            this.Chart2.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart2.Legend.Location = new System.Drawing.Point(7, 7);
            this.Chart2.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.Chart2.Legend.Visible = false;
            this.Chart2.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.Chart2.Localize = null;
            this.Chart2.Location = new System.Drawing.Point(23, 79);
            this.Chart2.Margin = new System.Windows.Forms.Padding(2);
            this.Chart2.Name = "Chart2";
            this.Chart2.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart2.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart2.PrimaryXAxis.Margin = true;
            this.Chart2.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart2.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart2.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart2.PrimaryYAxis.Margin = true;
            this.Chart2.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart2.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart2.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart2.RealMode3D = true;
            this.Chart2.Rotation = 45F;
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
            this.Chart2.Series.Add(chartSeries3);
            this.Chart2.Series.Add(chartSeries4);
            this.Chart2.Series3D = true;
            this.Chart2.SeriesHighlight = true;
            this.Chart2.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart2.Size = new System.Drawing.Size(1440, 665);
            this.Chart2.Spacing = 5F;
            this.Chart2.SpacingBetweenPoints = 5F;
            this.Chart2.Style3D = true;
            this.Chart2.TabIndex = 43;
            this.Chart2.Tilt = 15F;
            // 
            // 
            // 
            this.Chart2.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart2.Title.Name = "Default";
            this.Chart2.ToolBar.EnableDefaultItems = false;
            this.Chart2.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.Chart2.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // expandCollapsePanel3
            // 
            this.expandCollapsePanel3.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel3.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel3.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel3.Controls.Add(this.listBox2);
            this.expandCollapsePanel3.ExpandedHeight = 587;
            this.expandCollapsePanel3.IsExpanded = true;
            this.expandCollapsePanel3.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel3.Name = "expandCollapsePanel3";
            this.expandCollapsePanel3.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel3.TabIndex = 107;
            this.expandCollapsePanel3.Text = "Filter";
            this.expandCollapsePanel3.UseAnimation = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(13, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 378);
            this.listBox2.TabIndex = 43;
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
            this.toggleButton2.Location = new System.Drawing.Point(2, 2);
            this.toggleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Renderer = toggleButtonRenderer2;
            this.toggleButton2.Size = new System.Drawing.Size(66, 36);
            sliderCollection2.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection2.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection2.Width = 30;
            this.toggleButton2.Slider = sliderCollection2;
            this.toggleButton2.TabIndex = 106;
            this.toggleButton2.Text = "toggleButton1";
            this.toggleButton2.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // Tab3
            // 
            this.Tab3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab3.Controls.Add(this.splitContainer4);
            this.Tab3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3.Image = null;
            this.Tab3.ImageSize = new System.Drawing.Size(50, 40);
            this.Tab3.Location = new System.Drawing.Point(1, 44);
            this.Tab3.Margin = new System.Windows.Forms.Padding(7);
            this.Tab3.Name = "Tab3";
            this.Tab3.Padding = new System.Windows.Forms.Padding(3);
            this.Tab3.ShowCloseButton = true;
            this.Tab3.Size = new System.Drawing.Size(1784, 847);
            this.Tab3.TabIndex = 7;
            this.Tab3.Text = "NPM";
            this.Tab3.ThemesEnabled = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.Chart3);
            this.splitContainer4.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.expandCollapsePanel2);
            this.splitContainer4.Panel2.Controls.Add(this.toggleButton3);
            this.splitContainer4.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer4.Size = new System.Drawing.Size(1776, 839);
            this.splitContainer4.SplitterDistance = 1491;
            this.splitContainer4.SplitterWidth = 7;
            this.splitContainer4.TabIndex = 98;
            // 
            // Chart3
            // 
            this.Chart3.AllowGradientPalette = true;
            this.Chart3.AllowUserEditStyles = true;
            this.Chart3.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart3.ChartArea.AutoScale = true;
            this.Chart3.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart3.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart3.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart3.ChartArea.CursorReDraw = false;
            this.Chart3.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart3.ChartAreaShadow = true;
            this.Chart3.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart3.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart3.DataSourceName = "[none]";
            this.Chart3.Depth = 250F;
            this.Chart3.DisplayChartContextMenu = false;
            this.Chart3.DisplaySeriesContextMenu = false;
            this.Chart3.EnableMouseRotation = true;
            this.Chart3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart3.HighlightSymbol = true;
            this.Chart3.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart3.Legend.FloatingAutoSize = false;
            this.Chart3.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart3.Legend.Location = new System.Drawing.Point(925, 14);
            this.Chart3.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart3.Legend.OnlyColumnsForFloating = false;
            this.Chart3.Legend.RowsCount = 2;
            this.Chart3.Legend.ShowSymbol = true;
            this.Chart3.Legend.Size = new System.Drawing.Size(112, 59);
            this.Chart3.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Chart3.Legend.Visible = false;
            this.Chart3.Legend.VisibleCheckBox = true;
            this.Chart3.Localize = null;
            this.Chart3.Location = new System.Drawing.Point(23, 79);
            this.Chart3.Margin = new System.Windows.Forms.Padding(2);
            this.Chart3.Name = "Chart3";
            this.Chart3.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart3.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart3.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart3.PrimaryXAxis.Margin = true;
            this.Chart3.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart3.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart3.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart3.PrimaryYAxis.Margin = true;
            this.Chart3.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart3.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart3.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart3.RealMode3D = true;
            this.Chart3.Rotation = 45F;
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
            this.Chart3.Series.Add(chartSeries5);
            this.Chart3.Series.Add(chartSeries6);
            this.Chart3.Series3D = true;
            this.Chart3.SeriesHighlight = true;
            this.Chart3.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart3.Size = new System.Drawing.Size(1440, 665);
            this.Chart3.Spacing = 5F;
            this.Chart3.SpacingBetweenSeries = 15F;
            this.Chart3.Style3D = true;
            this.Chart3.TabIndex = 96;
            this.Chart3.Tilt = 15F;
            // 
            // 
            // 
            this.Chart3.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart3.Title.Name = "Default";
            this.Chart3.ToolBar.EnableDefaultItems = false;
            this.Chart3.ToolBar.Items.Add(chartToolBarSaveItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarCopyItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarPrintItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.Chart3.ToolBar.Items.Add(chartToolBarSplitter1);
            this.Chart3.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.Chart3.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.Chart3.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.listBox3);
            this.expandCollapsePanel2.ExpandedHeight = 587;
            this.expandCollapsePanel2.IsExpanded = true;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel2.TabIndex = 107;
            this.expandCollapsePanel2.Text = "Filter";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Black;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(13, 49);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(226, 378);
            this.listBox3.TabIndex = 43;
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
            this.toggleButton3.Location = new System.Drawing.Point(3, 2);
            this.toggleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton3.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.Renderer = toggleButtonRenderer3;
            this.toggleButton3.Size = new System.Drawing.Size(66, 36);
            sliderCollection3.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection3.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection3.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection3.Width = 30;
            this.toggleButton3.Slider = sliderCollection3;
            this.toggleButton3.TabIndex = 106;
            this.toggleButton3.Text = "toggleButton1";
            this.toggleButton3.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // Tab4
            // 
            this.Tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab4.Controls.Add(this.splitContaineEPA);
            this.Tab4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab4.Image = null;
            this.Tab4.ImageSize = new System.Drawing.Size(40, 40);
            this.Tab4.Location = new System.Drawing.Point(1, 44);
            this.Tab4.Margin = new System.Windows.Forms.Padding(7);
            this.Tab4.Name = "Tab4";
            this.Tab4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tab4.ShowCloseButton = true;
            this.Tab4.Size = new System.Drawing.Size(1784, 847);
            this.Tab4.TabIndex = 9;
            this.Tab4.Text = "Strategic Goal";
            this.Tab4.ThemesEnabled = false;
            // 
            // splitContaineEPA
            // 
            this.splitContaineEPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContaineEPA.Location = new System.Drawing.Point(2, 3);
            this.splitContaineEPA.Margin = new System.Windows.Forms.Padding(2);
            this.splitContaineEPA.Name = "splitContaineEPA";
            // 
            // splitContaineEPA.Panel1
            // 
            this.splitContaineEPA.Panel1.Controls.Add(this.Chart4);
            // 
            // splitContaineEPA.Panel2
            // 
            this.splitContaineEPA.Panel2.Controls.Add(this.expandCollapsePanel1);
            this.splitContaineEPA.Panel2.Controls.Add(this.toggleButton4);
            this.splitContaineEPA.Size = new System.Drawing.Size(1778, 839);
            this.splitContaineEPA.SplitterDistance = 1491;
            this.splitContaineEPA.SplitterWidth = 7;
            this.splitContaineEPA.TabIndex = 99;
            // 
            // Chart4
            // 
            this.Chart4.AllowGradientPalette = true;
            this.Chart4.AllowUserEditStyles = true;
            this.Chart4.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart4.ChartArea.AutoScale = true;
            this.Chart4.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart4.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart4.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart4.ChartArea.CursorReDraw = false;
            this.Chart4.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart4.ChartAreaShadow = true;
            this.Chart4.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart4.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart4.DataSourceName = "[none]";
            this.Chart4.Depth = 250F;
            this.Chart4.DisplayChartContextMenu = false;
            this.Chart4.DisplaySeriesContextMenu = false;
            this.Chart4.EnableMouseRotation = true;
            this.Chart4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart4.HighlightSymbol = true;
            this.Chart4.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart4.Legend.FloatingAutoSize = false;
            this.Chart4.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart4.Legend.Location = new System.Drawing.Point(925, 14);
            this.Chart4.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart4.Legend.OnlyColumnsForFloating = false;
            this.Chart4.Legend.RowsCount = 2;
            this.Chart4.Legend.ShowSymbol = true;
            this.Chart4.Legend.Size = new System.Drawing.Size(112, 59);
            this.Chart4.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Chart4.Legend.Visible = false;
            this.Chart4.Legend.VisibleCheckBox = true;
            this.Chart4.Localize = null;
            this.Chart4.Location = new System.Drawing.Point(23, 79);
            this.Chart4.Margin = new System.Windows.Forms.Padding(2);
            this.Chart4.Name = "Chart4";
            this.Chart4.Padding = new System.Windows.Forms.Padding(1);
            this.Chart4.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart4.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart4.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart4.PrimaryXAxis.Margin = true;
            this.Chart4.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart4.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart4.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart4.PrimaryYAxis.Margin = true;
            this.Chart4.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart4.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart4.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart4.RealMode3D = true;
            this.Chart4.Rotation = 45F;
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
            this.Chart4.Series.Add(chartSeries7);
            this.Chart4.Series.Add(chartSeries8);
            this.Chart4.Series3D = true;
            this.Chart4.SeriesHighlight = true;
            this.Chart4.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart4.Size = new System.Drawing.Size(1440, 665);
            this.Chart4.Spacing = 5F;
            this.Chart4.SpacingBetweenSeries = 15F;
            this.Chart4.Style3D = true;
            this.Chart4.TabIndex = 96;
            this.Chart4.Tilt = 15F;
            // 
            // 
            // 
            this.Chart4.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart4.Title.Name = "Default";
            this.Chart4.ToolBar.EnableDefaultItems = false;
            this.Chart4.ToolBar.Items.Add(chartToolBarSaveItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarCopyItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarPrintItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.Chart4.ToolBar.Items.Add(chartToolBarSplitter2);
            this.Chart4.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.Chart4.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.Chart4.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.listBox4);
            this.expandCollapsePanel1.ExpandedHeight = 587;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel1.TabIndex = 107;
            this.expandCollapsePanel1.Text = "Filter";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Black;
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 21;
            this.listBox4.Location = new System.Drawing.Point(13, 49);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(226, 378);
            this.listBox4.TabIndex = 43;
            // 
            // toggleButton4
            // 
            activeStateCollection4.BackColor = System.Drawing.Color.Black;
            activeStateCollection4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection4.Text = "$";
            this.toggleButton4.ActiveState = activeStateCollection4;
            this.toggleButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton4.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection4.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection4.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection4.Text = "%";
            this.toggleButton4.InactiveState = inactiveStateCollection4;
            this.toggleButton4.Location = new System.Drawing.Point(3, 2);
            this.toggleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton4.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.Renderer = toggleButtonRenderer4;
            this.toggleButton4.Size = new System.Drawing.Size(66, 36);
            sliderCollection4.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection4.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection4.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection4.Width = 30;
            this.toggleButton4.Slider = sliderCollection4;
            this.toggleButton4.TabIndex = 106;
            this.toggleButton4.Text = "toggleButton1";
            this.toggleButton4.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // Tab5
            // 
            this.Tab5.Controls.Add(this.splitContainer3);
            this.Tab5.Image = null;
            this.Tab5.ImageSize = new System.Drawing.Size(16, 16);
            this.Tab5.Location = new System.Drawing.Point(1, 44);
            this.Tab5.Name = "Tab5";
            this.Tab5.ShowCloseButton = true;
            this.Tab5.Size = new System.Drawing.Size(1784, 847);
            this.Tab5.TabIndex = 10;
            this.Tab5.Text = "Agency Objective";
            this.Tab5.ThemesEnabled = false;
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
            this.splitContainer3.Panel1.Controls.Add(this.Chart5);
            this.splitContainer3.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.expandCollapsePanel6);
            this.splitContainer3.Panel2.Controls.Add(this.toggleButton6);
            this.splitContainer3.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer3.Size = new System.Drawing.Size(1784, 847);
            this.splitContainer3.SplitterDistance = 1495;
            this.splitContainer3.SplitterWidth = 7;
            this.splitContainer3.TabIndex = 101;
            // 
            // Chart5
            // 
            this.Chart5.AllowGradientPalette = true;
            this.Chart5.AllowUserEditStyles = true;
            this.Chart5.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart5.ChartArea.AutoScale = true;
            this.Chart5.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart5.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart5.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart5.ChartArea.CursorReDraw = false;
            this.Chart5.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart5.ChartAreaShadow = true;
            this.Chart5.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart5.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart5.DataSourceName = "[none]";
            this.Chart5.Depth = 250F;
            this.Chart5.DisplayChartContextMenu = false;
            this.Chart5.DisplaySeriesContextMenu = false;
            this.Chart5.EnableMouseRotation = true;
            this.Chart5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart5.HighlightSymbol = true;
            this.Chart5.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart5.Legend.FloatingAutoSize = false;
            this.Chart5.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart5.Legend.Location = new System.Drawing.Point(925, 52);
            this.Chart5.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart5.Legend.OnlyColumnsForFloating = false;
            this.Chart5.Legend.RowsCount = 2;
            this.Chart5.Legend.ShowSymbol = true;
            this.Chart5.Legend.Size = new System.Drawing.Size(112, 59);
            this.Chart5.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Chart5.Legend.Visible = false;
            this.Chart5.Legend.VisibleCheckBox = true;
            this.Chart5.Localize = null;
            this.Chart5.Location = new System.Drawing.Point(23, 79);
            this.Chart5.Margin = new System.Windows.Forms.Padding(2);
            this.Chart5.Name = "Chart5";
            this.Chart5.Padding = new System.Windows.Forms.Padding(1);
            this.Chart5.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart5.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart5.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart5.PrimaryXAxis.Margin = true;
            this.Chart5.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart5.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart5.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart5.PrimaryYAxis.Margin = true;
            this.Chart5.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart5.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart5.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart5.RealMode3D = true;
            this.Chart5.Rotation = 45F;
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
            this.Chart5.Series.Add(chartSeries9);
            this.Chart5.Series.Add(chartSeries10);
            this.Chart5.Series3D = true;
            this.Chart5.SeriesHighlight = true;
            this.Chart5.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart5.Size = new System.Drawing.Size(1440, 665);
            this.Chart5.Spacing = 5F;
            this.Chart5.SpacingBetweenSeries = 15F;
            this.Chart5.Style3D = true;
            this.Chart5.TabIndex = 96;
            this.Chart5.Tilt = 15F;
            // 
            // 
            // 
            this.Chart5.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart5.Title.Name = "Default";
            this.Chart5.ToolBar.EnableDefaultItems = false;
            this.Chart5.ToolBar.Items.Add(chartToolBarSaveItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarCopyItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarPrintItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarPrintPreviewItem3);
            this.Chart5.ToolBar.Items.Add(chartToolBarSplitter3);
            this.Chart5.ToolBar.Items.Add(chartToolBarPaletteItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarStyleItem3);
            this.Chart5.ToolBar.Items.Add(chartToolBarTypeItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarSeries3DItem5);
            this.Chart5.ToolBar.Items.Add(chartToolBarShowLegendItem5);
            // 
            // expandCollapsePanel6
            // 
            this.expandCollapsePanel6.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel6.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel6.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel6.Controls.Add(this.listBox6);
            this.expandCollapsePanel6.ExpandedHeight = 587;
            this.expandCollapsePanel6.IsExpanded = true;
            this.expandCollapsePanel6.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel6.Name = "expandCollapsePanel6";
            this.expandCollapsePanel6.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel6.TabIndex = 106;
            this.expandCollapsePanel6.Text = "Filter";
            this.expandCollapsePanel6.UseAnimation = true;
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.Color.Black;
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 21;
            this.listBox6.Location = new System.Drawing.Point(13, 49);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(226, 378);
            this.listBox6.TabIndex = 43;
            // 
            // toggleButton6
            // 
            activeStateCollection5.BackColor = System.Drawing.Color.Black;
            activeStateCollection5.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection5.Text = "$";
            this.toggleButton6.ActiveState = activeStateCollection5;
            this.toggleButton6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton6.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection5.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection5.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection5.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection5.Text = "%";
            this.toggleButton6.InactiveState = inactiveStateCollection5;
            this.toggleButton6.Location = new System.Drawing.Point(3, 2);
            this.toggleButton6.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton6.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton6.Name = "toggleButton6";
            this.toggleButton6.Renderer = toggleButtonRenderer5;
            this.toggleButton6.Size = new System.Drawing.Size(66, 36);
            sliderCollection5.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection5.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection5.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection5.Width = 30;
            this.toggleButton6.Slider = sliderCollection5;
            this.toggleButton6.TabIndex = 97;
            this.toggleButton6.Text = "toggleButton1";
            this.toggleButton6.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // Tab6
            // 
            this.Tab6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab6.Controls.Add(this.splitContainer8);
            this.Tab6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tab6.Image = null;
            this.Tab6.ImageSize = new System.Drawing.Size(50, 40);
            this.Tab6.Location = new System.Drawing.Point(1, 44);
            this.Tab6.Margin = new System.Windows.Forms.Padding(7);
            this.Tab6.Name = "Tab6";
            this.Tab6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tab6.ShowCloseButton = true;
            this.Tab6.Size = new System.Drawing.Size(1784, 847);
            this.Tab6.TabIndex = 8;
            this.Tab6.Text = "Program Area";
            this.Tab6.ThemesEnabled = false;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(2, 3);
            this.splitContainer8.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.Chart6);
            this.splitContainer8.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.expandCollapsePanel5);
            this.splitContainer8.Panel2.Controls.Add(this.toggleButton5);
            this.splitContainer8.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer8.Size = new System.Drawing.Size(1778, 839);
            this.splitContainer8.SplitterDistance = 1491;
            this.splitContainer8.SplitterWidth = 7;
            this.splitContainer8.TabIndex = 100;
            // 
            // Chart6
            // 
            this.Chart6.AllowGradientPalette = true;
            this.Chart6.AllowUserEditStyles = true;
            this.Chart6.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart6.ChartArea.AutoScale = true;
            this.Chart6.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart6.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart6.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart6.ChartArea.CursorReDraw = false;
            this.Chart6.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart6.ChartAreaShadow = true;
            this.Chart6.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart6.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart6.DataSourceName = "[none]";
            this.Chart6.Depth = 250F;
            this.Chart6.DisplayChartContextMenu = false;
            this.Chart6.DisplaySeriesContextMenu = false;
            this.Chart6.EnableMouseRotation = true;
            this.Chart6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart6.HighlightSymbol = true;
            this.Chart6.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart6.Legend.FloatingAutoSize = false;
            this.Chart6.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart6.Legend.Location = new System.Drawing.Point(925, 52);
            this.Chart6.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart6.Legend.OnlyColumnsForFloating = false;
            this.Chart6.Legend.RowsCount = 2;
            this.Chart6.Legend.ShowSymbol = true;
            this.Chart6.Legend.Size = new System.Drawing.Size(112, 59);
            this.Chart6.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Chart6.Legend.Visible = false;
            this.Chart6.Legend.VisibleCheckBox = true;
            this.Chart6.Localize = null;
            this.Chart6.Location = new System.Drawing.Point(23, 79);
            this.Chart6.Margin = new System.Windows.Forms.Padding(2);
            this.Chart6.Name = "Chart6";
            this.Chart6.Padding = new System.Windows.Forms.Padding(1);
            this.Chart6.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart6.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart6.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart6.PrimaryXAxis.Margin = true;
            this.Chart6.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart6.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart6.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart6.PrimaryYAxis.Margin = true;
            this.Chart6.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart6.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart6.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart6.RealMode3D = true;
            this.Chart6.Rotation = 45F;
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
            this.Chart6.Series.Add(chartSeries11);
            this.Chart6.Series.Add(chartSeries12);
            this.Chart6.Series3D = true;
            this.Chart6.SeriesHighlight = true;
            this.Chart6.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart6.Size = new System.Drawing.Size(1440, 665);
            this.Chart6.Spacing = 5F;
            this.Chart6.SpacingBetweenSeries = 15F;
            this.Chart6.Style3D = true;
            this.Chart6.TabIndex = 96;
            this.Chart6.Tilt = 15F;
            // 
            // 
            // 
            this.Chart6.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart6.Title.Name = "Default";
            this.Chart6.ToolBar.EnableDefaultItems = false;
            this.Chart6.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarPrintPreviewItem4);
            this.Chart6.ToolBar.Items.Add(chartToolBarSplitter4);
            this.Chart6.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarStyleItem4);
            this.Chart6.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.Chart6.ToolBar.Items.Add(chartToolBarShowLegendItem6);
            // 
            // expandCollapsePanel5
            // 
            this.expandCollapsePanel5.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel5.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel5.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel5.Controls.Add(this.listBox5);
            this.expandCollapsePanel5.ExpandedHeight = 587;
            this.expandCollapsePanel5.IsExpanded = true;
            this.expandCollapsePanel5.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel5.Name = "expandCollapsePanel5";
            this.expandCollapsePanel5.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel5.TabIndex = 106;
            this.expandCollapsePanel5.Text = "Filter";
            this.expandCollapsePanel5.UseAnimation = true;
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.Black;
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 21;
            this.listBox5.Location = new System.Drawing.Point(13, 49);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(226, 378);
            this.listBox5.TabIndex = 43;
            // 
            // toggleButton5
            // 
            activeStateCollection6.BackColor = System.Drawing.Color.Black;
            activeStateCollection6.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection6.Text = "$";
            this.toggleButton5.ActiveState = activeStateCollection6;
            this.toggleButton5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton5.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection6.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection6.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection6.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection6.Text = "%";
            this.toggleButton5.InactiveState = inactiveStateCollection6;
            this.toggleButton5.Location = new System.Drawing.Point(3, 2);
            this.toggleButton5.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton5.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton5.Name = "toggleButton5";
            this.toggleButton5.Renderer = toggleButtonRenderer6;
            this.toggleButton5.Size = new System.Drawing.Size(66, 36);
            sliderCollection6.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection6.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection6.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection6.Width = 30;
            this.toggleButton5.Slider = sliderCollection6;
            this.toggleButton5.TabIndex = 97;
            this.toggleButton5.Text = "toggleButton1";
            this.toggleButton5.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // Tab7
            // 
            this.Tab7.Controls.Add(this.splitContainer6);
            this.Tab7.Image = null;
            this.Tab7.ImageSize = new System.Drawing.Size(16, 16);
            this.Tab7.Location = new System.Drawing.Point(1, 44);
            this.Tab7.Name = "Tab7";
            this.Tab7.ShowCloseButton = true;
            this.Tab7.Size = new System.Drawing.Size(1784, 847);
            this.Tab7.TabIndex = 11;
            this.Tab7.Text = "Program Project";
            this.Tab7.ThemesEnabled = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.Chart7);
            this.splitContainer6.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.expandCollapsePanel7);
            this.splitContainer6.Panel2.Controls.Add(this.toggleButton7);
            this.splitContainer6.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer6.Size = new System.Drawing.Size(1784, 847);
            this.splitContainer6.SplitterDistance = 1495;
            this.splitContainer6.SplitterWidth = 7;
            this.splitContainer6.TabIndex = 101;
            // 
            // Chart7
            // 
            this.Chart7.AllowGradientPalette = true;
            this.Chart7.AllowUserEditStyles = true;
            this.Chart7.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.Chart7.ChartArea.AutoScale = true;
            this.Chart7.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.Chart7.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.Chart7.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart7.ChartArea.CursorReDraw = false;
            this.Chart7.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.Chart7.ChartAreaShadow = true;
            this.Chart7.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.Chart7.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.Chart7.DataSourceName = "[none]";
            this.Chart7.Depth = 250F;
            this.Chart7.DisplayChartContextMenu = false;
            this.Chart7.DisplaySeriesContextMenu = false;
            this.Chart7.EnableMouseRotation = true;
            this.Chart7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Chart7.HighlightSymbol = true;
            this.Chart7.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart7.Legend.FloatingAutoSize = false;
            this.Chart7.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart7.Legend.Location = new System.Drawing.Point(925, 52);
            this.Chart7.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.Chart7.Legend.OnlyColumnsForFloating = false;
            this.Chart7.Legend.RowsCount = 2;
            this.Chart7.Legend.ShowSymbol = true;
            this.Chart7.Legend.Size = new System.Drawing.Size(112, 59);
            this.Chart7.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Chart7.Legend.Visible = false;
            this.Chart7.Legend.VisibleCheckBox = true;
            this.Chart7.Localize = null;
            this.Chart7.Location = new System.Drawing.Point(23, 79);
            this.Chart7.Margin = new System.Windows.Forms.Padding(2);
            this.Chart7.Name = "Chart7";
            this.Chart7.Padding = new System.Windows.Forms.Padding(1);
            this.Chart7.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart7.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart7.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart7.PrimaryXAxis.Margin = true;
            this.Chart7.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.Chart7.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart7.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart7.PrimaryYAxis.Margin = true;
            this.Chart7.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Chart7.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.Chart7.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart7.RealMode3D = true;
            this.Chart7.Rotation = 45F;
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
            this.Chart7.Series.Add(chartSeries13);
            this.Chart7.Series.Add(chartSeries14);
            this.Chart7.Series3D = true;
            this.Chart7.SeriesHighlight = true;
            this.Chart7.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.Chart7.Size = new System.Drawing.Size(1440, 665);
            this.Chart7.Spacing = 5F;
            this.Chart7.SpacingBetweenSeries = 15F;
            this.Chart7.Style3D = true;
            this.Chart7.TabIndex = 96;
            this.Chart7.Tilt = 15F;
            // 
            // 
            // 
            this.Chart7.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart7.Title.Name = "Default";
            this.Chart7.ToolBar.EnableDefaultItems = false;
            this.Chart7.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarPrintPreviewItem5);
            this.Chart7.ToolBar.Items.Add(chartToolBarSplitter5);
            this.Chart7.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarStyleItem5);
            this.Chart7.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.Chart7.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // expandCollapsePanel7
            // 
            this.expandCollapsePanel7.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel7.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel7.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel7.Controls.Add(this.listBox7);
            this.expandCollapsePanel7.ExpandedHeight = 587;
            this.expandCollapsePanel7.IsExpanded = true;
            this.expandCollapsePanel7.Location = new System.Drawing.Point(10, 105);
            this.expandCollapsePanel7.Name = "expandCollapsePanel7";
            this.expandCollapsePanel7.Size = new System.Drawing.Size(254, 442);
            this.expandCollapsePanel7.TabIndex = 106;
            this.expandCollapsePanel7.Text = "Filter";
            this.expandCollapsePanel7.UseAnimation = true;
            // 
            // listBox7
            // 
            this.listBox7.BackColor = System.Drawing.Color.Black;
            this.listBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 21;
            this.listBox7.Location = new System.Drawing.Point(13, 49);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(226, 378);
            this.listBox7.TabIndex = 43;
            // 
            // toggleButton7
            // 
            activeStateCollection7.BackColor = System.Drawing.Color.Black;
            activeStateCollection7.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            activeStateCollection7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection7.Text = "$";
            this.toggleButton7.ActiveState = activeStateCollection7;
            this.toggleButton7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton7.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection7.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection7.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            inactiveStateCollection7.ForeColor = System.Drawing.Color.Gray;
            inactiveStateCollection7.Text = "%";
            this.toggleButton7.InactiveState = inactiveStateCollection7;
            this.toggleButton7.Location = new System.Drawing.Point(3, 2);
            this.toggleButton7.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton7.MinimumSize = new System.Drawing.Size(36, 14);
            this.toggleButton7.Name = "toggleButton7";
            this.toggleButton7.Renderer = toggleButtonRenderer7;
            this.toggleButton7.Size = new System.Drawing.Size(66, 36);
            sliderCollection7.BackColor = System.Drawing.Color.SteelBlue;
            sliderCollection7.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            sliderCollection7.HoverColor = System.Drawing.Color.SteelBlue;
            sliderCollection7.Width = 30;
            this.toggleButton7.Slider = sliderCollection7;
            this.toggleButton7.TabIndex = 97;
            this.toggleButton7.Text = "toggleButton1";
            this.toggleButton7.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProgramListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpanel5);
            this.splitContainer1.Panel2.Controls.Add(this.ObjectiveChart);
            this.splitContainer1.Size = new System.Drawing.Size(1776, 726);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 99;
            // 
            // ProgramListBox
            // 
            this.ProgramListBox.BackColor = System.Drawing.Color.Black;
            this.ProgramListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProgramListBox.FormattingEnabled = true;
            this.ProgramListBox.ItemHeight = 32;
            this.ProgramListBox.Location = new System.Drawing.Point(19, 44);
            this.ProgramListBox.Name = "ProgramListBox";
            this.ProgramListBox.Size = new System.Drawing.Size(255, 544);
            this.ProgramListBox.TabIndex = 98;
            // 
            // flpanel5
            // 
            this.flpanel5.Controls.Add(this.obj1);
            this.flpanel5.Controls.Add(this.obj2);
            this.flpanel5.Controls.Add(this.obj3);
            this.flpanel5.Controls.Add(this.obj4);
            this.flpanel5.Controls.Add(this.obj5);
            this.flpanel5.Location = new System.Drawing.Point(3, 3);
            this.flpanel5.Name = "flpanel5";
            this.flpanel5.Size = new System.Drawing.Size(408, 32);
            this.flpanel5.TabIndex = 99;
            // 
            // obj1
            // 
            this.obj1.AutoSize = true;
            this.obj1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.obj1.Location = new System.Drawing.Point(3, 3);
            this.obj1.Name = "obj1";
            this.obj1.Size = new System.Drawing.Size(97, 15);
            this.obj1.TabIndex = 54;
            this.obj1.Text = "Appropriation";
            this.obj1.UseCustomForeColor = true;
            this.obj1.UseSelectable = true;
            // 
            // obj2
            // 
            this.obj2.AutoSize = true;
            this.obj2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.obj2.Location = new System.Drawing.Point(106, 3);
            this.obj2.Name = "obj2";
            this.obj2.Size = new System.Drawing.Size(47, 15);
            this.obj2.TabIndex = 51;
            this.obj2.Text = "BOC";
            this.obj2.UseCustomForeColor = true;
            this.obj2.UseSelectable = true;
            // 
            // obj3
            // 
            this.obj3.AutoSize = true;
            this.obj3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.obj3.Location = new System.Drawing.Point(159, 3);
            this.obj3.Name = "obj3";
            this.obj3.Size = new System.Drawing.Size(50, 15);
            this.obj3.TabIndex = 52;
            this.obj3.Text = "NPM";
            this.obj3.UseCustomForeColor = true;
            this.obj3.UseSelectable = true;
            // 
            // obj4
            // 
            this.obj4.AutoSize = true;
            this.obj4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.obj4.Location = new System.Drawing.Point(215, 3);
            this.obj4.Name = "obj4";
            this.obj4.Size = new System.Drawing.Size(47, 15);
            this.obj4.TabIndex = 53;
            this.obj4.Text = "Goal";
            this.obj4.UseCustomForeColor = true;
            this.obj4.UseSelectable = true;
            // 
            // obj5
            // 
            this.obj5.AutoSize = true;
            this.obj5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.obj5.Location = new System.Drawing.Point(268, 3);
            this.obj5.Name = "obj5";
            this.obj5.Size = new System.Drawing.Size(65, 15);
            this.obj5.TabIndex = 55;
            this.obj5.Text = "Division";
            this.obj5.UseCustomForeColor = true;
            this.obj5.UseSelectable = true;
            // 
            // ObjectiveChart
            // 
            this.ObjectiveChart.AllowGradientPalette = true;
            this.ObjectiveChart.AllowUserEditStyles = true;
            this.ObjectiveChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            this.ObjectiveChart.ChartArea.AutoScale = true;
            this.ObjectiveChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.ObjectiveChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.ObjectiveChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.ObjectiveChart.ChartArea.CursorReDraw = false;
            this.ObjectiveChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.ObjectiveChart.ChartAreaShadow = true;
            this.ObjectiveChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.ObjectiveChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.ObjectiveChart.DataSourceName = "[none]";
            this.ObjectiveChart.Depth = 250F;
            this.ObjectiveChart.DisplayChartContextMenu = false;
            this.ObjectiveChart.DisplaySeriesContextMenu = false;
            this.ObjectiveChart.EnableMouseRotation = true;
            this.ObjectiveChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ObjectiveChart.HighlightSymbol = true;
            this.ObjectiveChart.IsWindowLess = false;
            // 
            // 
            // 
            this.ObjectiveChart.Legend.FloatingAutoSize = false;
            this.ObjectiveChart.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.Legend.Location = new System.Drawing.Point(1337, 80);
            this.ObjectiveChart.Legend.OnlyColumnsForFloating = false;
            this.ObjectiveChart.Legend.RowsCount = 2;
            this.ObjectiveChart.Legend.Size = new System.Drawing.Size(107, 32);
            this.ObjectiveChart.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.ObjectiveChart.Legend.Visible = false;
            this.ObjectiveChart.Legend.VisibleCheckBox = true;
            this.ObjectiveChart.Localize = null;
            this.ObjectiveChart.Location = new System.Drawing.Point(0, 53);
            this.ObjectiveChart.Name = "ObjectiveChart";
            this.ObjectiveChart.Padding = new System.Windows.Forms.Padding(1);
            this.ObjectiveChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.ObjectiveChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ObjectiveChart.PrimaryXAxis.Margin = true;
            this.ObjectiveChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.ObjectiveChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ObjectiveChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ObjectiveChart.PrimaryYAxis.Margin = true;
            this.ObjectiveChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.ObjectiveChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.RealMode3D = true;
            this.ObjectiveChart.Rotation = 45F;
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
            this.ObjectiveChart.Series.Add(chartSeries15);
            this.ObjectiveChart.Series.Add(chartSeries16);
            this.ObjectiveChart.Series3D = true;
            this.ObjectiveChart.SeriesHighlight = true;
            this.ObjectiveChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ObjectiveChart.ShadowWidth = 10;
            this.ObjectiveChart.Size = new System.Drawing.Size(1470, 670);
            this.ObjectiveChart.Spacing = 5F;
            this.ObjectiveChart.SpacingBetweenSeries = 15F;
            this.ObjectiveChart.Style3D = true;
            this.ObjectiveChart.TabIndex = 97;
            this.ObjectiveChart.Text = "\r\n";
            this.ObjectiveChart.Tilt = 15F;
            // 
            // 
            // 
            this.ObjectiveChart.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.Title.Name = "Default";
            this.ObjectiveChart.Titles.Add(this.ObjectiveChart.Title);
            this.ObjectiveChart.ToolBar.EnableDefaultItems = false;
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSplitter6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarStyleItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Project.Controls.Add(this.splitContainer1);
            this.Project.Image = null;
            this.Project.ImageSize = new System.Drawing.Size(40, 30);
            this.Project.Location = new System.Drawing.Point(1, 44);
            this.Project.Name = "Project";
            this.Project.Padding = new System.Windows.Forms.Padding(4);
            this.Project.ShowCloseButton = true;
            this.Project.Size = new System.Drawing.Size(1784, 734);
            this.Project.TabFont = null;
            this.Project.TabIndex = 8;
            this.Project.Text = "Objective";
            this.Project.ThemesEnabled = false;
            // 
            // Objective
            // 
            this.Objective.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Objective.Image = null;
            this.Objective.ImageSize = new System.Drawing.Size(40, 30);
            this.Objective.Location = new System.Drawing.Point(1, 44);
            this.Objective.Name = "Objective";
            this.Objective.Padding = new System.Windows.Forms.Padding(4);
            this.Objective.ShowCloseButton = true;
            this.Objective.Size = new System.Drawing.Size(1784, 734);
            this.Objective.TabFont = null;
            this.Objective.TabIndex = 8;
            this.Objective.Text = "Objective";
            this.Objective.ThemesEnabled = false;
            // 
            // ObjectiveTab
            // 
            this.ObjectiveTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ObjectiveTab.Image = null;
            this.ObjectiveTab.ImageSize = new System.Drawing.Size(40, 30);
            this.ObjectiveTab.Location = new System.Drawing.Point(1, 44);
            this.ObjectiveTab.Name = "ObjectiveTab";
            this.ObjectiveTab.Padding = new System.Windows.Forms.Padding(4);
            this.ObjectiveTab.ShowCloseButton = true;
            this.ObjectiveTab.Size = new System.Drawing.Size(1784, 734);
            this.ObjectiveTab.TabFont = null;
            this.ObjectiveTab.TabIndex = 8;
            this.ObjectiveTab.Text = "Objective";
            this.ObjectiveTab.ThemesEnabled = false;
            // 
            // BindingSource
            // 
            this.BindingSource.DataMember = "PRC";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 100;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1788, 894);
            this.Controls.Add(this.SummaryTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "SummaryForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).EndInit();
            this.expandCollapsePanel4.ResumeLayout(false);
            this.expandCollapsePanel4.PerformLayout();
            this.Tab2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.expandCollapsePanel3.ResumeLayout(false);
            this.expandCollapsePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton2)).EndInit();
            this.Tab3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton3)).EndInit();
            this.Tab4.ResumeLayout(false);
            this.splitContaineEPA.Panel1.ResumeLayout(false);
            this.splitContaineEPA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContaineEPA)).EndInit();
            this.splitContaineEPA.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton4)).EndInit();
            this.Tab5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.expandCollapsePanel6.ResumeLayout(false);
            this.expandCollapsePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton6)).EndInit();
            this.Tab6.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.expandCollapsePanel5.ResumeLayout(false);
            this.expandCollapsePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton5)).EndInit();
            this.Tab7.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.expandCollapsePanel7.ResumeLayout(false);
            this.expandCollapsePanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton7)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flpanel5.ResumeLayout(false);
            this.flpanel5.PerformLayout();
            this.Project.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

                }

                #endregion

                protected internal Syncfusion.Windows.Forms.Tools.TabControlAdv SummaryTabControl;
                Syncfusion.Windows.Forms.Tools.TabPageAdv Tab3;
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv Tab2;
                System.Windows.Forms.BindingSource BindingSource;
                System.Windows.Forms.ListBox ProgramListBox;
                protected Syncfusion.Windows.Forms.Chart.ChartControl ObjectiveChart;
                System.Windows.Forms.SplitContainer splitContainer1;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Tab4;
                private MetroFramework.Controls.MetroRadioButton obj5;
                private MetroFramework.Controls.MetroRadioButton obj2;
                private MetroFramework.Controls.MetroRadioButton obj3;
                private MetroFramework.Controls.MetroRadioButton obj4;
                private MetroFramework.Controls.MetroRadioButton obj1;
                private System.Windows.Forms.FlowLayoutPanel flpanel5;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Project;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Objective;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv ObjectiveTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Tab6;
                private TabPageAdv Tab1;
                private SplitContainer splitContainer5;
                private RadioButton rb5;
                private RadioButton rb4;
                private RadioButton rb1;
                private RadioButton rb3;
                private RadioButton rb2;
                protected ChartControl Chart1;
                private SplitContainer splitContainer2;
                private SplitContainer splitContainer4;
                protected ChartControl Chart3;
                private SplitContainer splitContaineEPA;
                protected ChartControl Chart4;
                private SplitContainer splitContainer8;
                protected ChartControl Chart6;
                protected ChartControl Chart2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel4;
                private ToggleButton toggleButton1;
                private ToggleButton toggleButton2;
                private ToggleButton toggleButton3;
                private ToggleButton toggleButton4;
                private ToggleButton toggleButton5;
                private ListBox listBox1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel3;
                private ListBox listBox2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
                private ListBox listBox3;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private ListBox listBox4;
                private TabPageAdv Tab5;
                private SplitContainer splitContainer3;
                protected ChartControl Chart5;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel6;
                private ListBox listBox6;
                private ToggleButton toggleButton6;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel5;
                private ListBox listBox5;
                private TabPageAdv Tab7;
                private SplitContainer splitContainer6;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel7;
                private ListBox listBox7;
                private ToggleButton toggleButton7;
                protected ChartControl Chart7;
            } 
        }
    }
}