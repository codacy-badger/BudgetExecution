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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection2 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection2 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection2 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
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
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.summary = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.P8chart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SummaryExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.metroSetButton5 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton6 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton3 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.PercentOrValue1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.fund = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.AppropChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel4 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.boc = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel3 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.npm = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.goal = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContaineEPA = new System.Windows.Forms.SplitContainer();
            this.GoalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Program = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.ProgramChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.expandCollapsePanel5 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.panel5 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SummaryExpander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentOrValue1)).BeginInit();
            this.fund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.expandCollapsePanel4.SuspendLayout();
            this.boc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.expandCollapsePanel3.SuspendLayout();
            this.npm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.goal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContaineEPA)).BeginInit();
            this.splitContaineEPA.Panel1.SuspendLayout();
            this.splitContaineEPA.Panel2.SuspendLayout();
            this.splitContaineEPA.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.Program.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.expandCollapsePanel5.SuspendLayout();
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
            this.SummaryTabControl.Controls.Add(this.summary);
            this.SummaryTabControl.Controls.Add(this.fund);
            this.SummaryTabControl.Controls.Add(this.boc);
            this.SummaryTabControl.Controls.Add(this.npm);
            this.SummaryTabControl.Controls.Add(this.goal);
            this.SummaryTabControl.Controls.Add(this.Program);
            this.SummaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.Color.Transparent;
            this.SummaryTabControl.FocusOnTabClick = false;
            this.SummaryTabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.SystemColors.GrayText;
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
            // summary
            // 
            this.summary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summary.Controls.Add(this.splitContainerAdv1);
            this.summary.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.Image = null;
            this.summary.ImageSize = new System.Drawing.Size(40, 40);
            this.summary.Location = new System.Drawing.Point(1, 44);
            this.summary.Margin = new System.Windows.Forms.Padding(2);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(1);
            this.summary.ShowCloseButton = true;
            this.summary.Size = new System.Drawing.Size(1784, 847);
            this.summary.TabIndex = 2;
            this.summary.Text = "Summary ";
            this.summary.ThemesEnabled = false;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(1, 1);
            this.splitContainerAdv1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.P8chart);
            this.splitContainerAdv1.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerAdv1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.SummaryExpander);
            this.splitContainerAdv1.Panel2.Controls.Add(this.PercentOrValue1);
            this.splitContainerAdv1.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1780, 843);
            this.splitContainerAdv1.SplitterDistance = 1490;
            this.splitContainerAdv1.TabIndex = 50;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // P8chart
            // 
            this.P8chart.AllowGradientPalette = true;
            this.P8chart.AllowUserEditStyles = true;
            this.P8chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P8chart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.P8chart.ChartArea.AutoScale = true;
            this.P8chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.P8chart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.P8chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.P8chart.ChartArea.CursorReDraw = false;
            this.P8chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.P8chart.ChartAreaShadow = true;
            this.P8chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.P8chart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.P8chart.DataSourceName = "[none]";
            this.P8chart.Depth = 250F;
            this.P8chart.DisplayChartContextMenu = false;
            this.P8chart.DisplaySeriesContextMenu = false;
            this.P8chart.EnableMouseRotation = true;
            this.P8chart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8chart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P8chart.HighlightSymbol = true;
            this.P8chart.IsWindowLess = false;
            // 
            // 
            // 
            this.P8chart.Legend.Location = new System.Drawing.Point(7, 7);
            this.P8chart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.P8chart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.P8chart.Legend.Visible = false;
            this.P8chart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.P8chart.Localize = null;
            this.P8chart.Location = new System.Drawing.Point(46, 73);
            this.P8chart.Margin = new System.Windows.Forms.Padding(2);
            this.P8chart.Name = "P8chart";
            this.P8chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.P8chart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.P8chart.PrimaryXAxis.Margin = true;
            this.P8chart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.P8chart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.P8chart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.P8chart.PrimaryYAxis.Margin = true;
            this.P8chart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.P8chart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.P8chart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.P8chart.RealMode3D = true;
            this.P8chart.Rotation = 45F;
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
            this.P8chart.Series.Add(chartSeries15);
            this.P8chart.Series.Add(chartSeries16);
            this.P8chart.Series3D = true;
            this.P8chart.SeriesHighlight = true;
            this.P8chart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.P8chart.Size = new System.Drawing.Size(1376, 562);
            this.P8chart.Spacing = 5F;
            this.P8chart.SpacingBetweenPoints = 5F;
            this.P8chart.Style3D = true;
            this.P8chart.TabIndex = 41;
            this.P8chart.Tilt = 15F;
            // 
            // 
            // 
            this.P8chart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.P8chart.Title.Name = "Default";
            this.P8chart.ToolBar.EnableDefaultItems = false;
            this.P8chart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarPrintPreviewItem6);
            this.P8chart.ToolBar.Items.Add(chartToolBarSplitter6);
            this.P8chart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarStyleItem6);
            this.P8chart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.P8chart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
            // 
            // SummaryExpander
            // 
            this.SummaryExpander.BackColor = System.Drawing.Color.Black;
            this.SummaryExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.SummaryExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.SummaryExpander.Controls.Add(this.metroSetButton5);
            this.SummaryExpander.Controls.Add(this.metroSetButton4);
            this.SummaryExpander.Controls.Add(this.metroSetButton6);
            this.SummaryExpander.Controls.Add(this.metroSetButton3);
            this.SummaryExpander.Controls.Add(this.metroSetButton2);
            this.SummaryExpander.Controls.Add(this.metroSetButton1);
            this.SummaryExpander.ExpandedHeight = 636;
            this.SummaryExpander.IsExpanded = false;
            this.SummaryExpander.Location = new System.Drawing.Point(16, 103);
            this.SummaryExpander.Name = "SummaryExpander";
            this.SummaryExpander.Size = new System.Drawing.Size(244, 37);
            this.SummaryExpander.TabIndex = 42;
            this.SummaryExpander.Text = "Selection";
            this.SummaryExpander.UseAnimation = true;
            // 
            // metroSetButton5
            // 
            this.metroSetButton5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton5.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton5.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton5.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton5.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton5.Location = new System.Drawing.Point(32, 534);
            this.metroSetButton5.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton5.Name = "metroSetButton5";
            this.metroSetButton5.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton5.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton5.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton5.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton5.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton5.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton5.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton5.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton5.StyleManager = null;
            this.metroSetButton5.TabIndex = 54;
            this.metroSetButton5.Text = "Division ";
            this.metroSetButton5.ThemeAuthor = "Narwin";
            this.metroSetButton5.ThemeName = "MetroLite";
            this.metroSetButton5.Click += new System.EventHandler(this.DivisionButton_OnClick);
            // 
            // metroSetButton4
            // 
            this.metroSetButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton4.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton4.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton4.Location = new System.Drawing.Point(34, 443);
            this.metroSetButton4.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton4.Name = "metroSetButton4";
            this.metroSetButton4.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton4.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton4.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton4.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton4.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton4.StyleManager = null;
            this.metroSetButton4.TabIndex = 53;
            this.metroSetButton4.Text = "Agency Goal";
            this.metroSetButton4.ThemeAuthor = "Narwin";
            this.metroSetButton4.ThemeName = "MetroLite";
            this.metroSetButton4.Click += new System.EventHandler(this.GoalButton_OnClick);
            // 
            // metroSetButton6
            // 
            this.metroSetButton6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton6.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton6.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton6.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton6.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton6.Location = new System.Drawing.Point(32, 346);
            this.metroSetButton6.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton6.Name = "metroSetButton6";
            this.metroSetButton6.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton6.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton6.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton6.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton6.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton6.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton6.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton6.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton6.StyleManager = null;
            this.metroSetButton6.TabIndex = 55;
            this.metroSetButton6.Text = "Full Time Equivalent";
            this.metroSetButton6.ThemeAuthor = "Narwin";
            this.metroSetButton6.ThemeName = "MetroLite";
            this.metroSetButton6.Click += new System.EventHandler(this.FteButton_OnClick);
            // 
            // metroSetButton3
            // 
            this.metroSetButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton3.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton3.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Location = new System.Drawing.Point(32, 250);
            this.metroSetButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton3.Name = "metroSetButton3";
            this.metroSetButton3.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton3.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton3.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton3.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton3.StyleManager = null;
            this.metroSetButton3.TabIndex = 51;
            this.metroSetButton3.Text = "National Program Office";
            this.metroSetButton3.ThemeAuthor = "Narwin";
            this.metroSetButton3.ThemeName = "MetroLite";
            this.metroSetButton3.Click += new System.EventHandler(this.NpmButton_OnClick);
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton2.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Location = new System.Drawing.Point(34, 153);
            this.metroSetButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton2.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton2.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 52;
            this.metroSetButton2.Text = "Budget Object Class";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            this.metroSetButton2.Click += new System.EventHandler(this.BocButton_OnClick);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton1.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(32, 62);
            this.metroSetButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton1.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton1.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(164, 57);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 50;
            this.metroSetButton1.Text = "Appropriation";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.AppropriationButton_OnClick);
            // 
            // PercentOrValue1
            // 
            activeStateCollection2.BackColor = System.Drawing.Color.Black;
            activeStateCollection2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            activeStateCollection2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            activeStateCollection2.Text = "$";
            this.PercentOrValue1.ActiveState = activeStateCollection2;
            this.PercentOrValue1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentOrValue1.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection2.BackColor = System.Drawing.Color.Black;
            inactiveStateCollection2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            inactiveStateCollection2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            inactiveStateCollection2.Text = "%";
            this.PercentOrValue1.InactiveState = inactiveStateCollection2;
            this.PercentOrValue1.Location = new System.Drawing.Point(92, 26);
            this.PercentOrValue1.Margin = new System.Windows.Forms.Padding(2);
            this.PercentOrValue1.MinimumSize = new System.Drawing.Size(36, 14);
            this.PercentOrValue1.Name = "PercentOrValue1";
            this.PercentOrValue1.Renderer = toggleButtonRenderer2;
            this.PercentOrValue1.Size = new System.Drawing.Size(85, 32);
            sliderCollection2.BackColor = System.Drawing.Color.Gray;
            sliderCollection2.HoverColor = System.Drawing.Color.SteelBlue;
            this.PercentOrValue1.Slider = sliderCollection2;
            this.PercentOrValue1.TabIndex = 49;
            this.PercentOrValue1.Text = "toggleButton1";
            this.PercentOrValue1.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            // 
            // fund
            // 
            this.fund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fund.Controls.Add(this.splitContainer5);
            this.fund.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fund.Image = null;
            this.fund.ImageSize = new System.Drawing.Size(40, 40);
            this.fund.Location = new System.Drawing.Point(1, 44);
            this.fund.Margin = new System.Windows.Forms.Padding(2);
            this.fund.Name = "fund";
            this.fund.Padding = new System.Windows.Forms.Padding(1);
            this.fund.ShowCloseButton = true;
            this.fund.Size = new System.Drawing.Size(1784, 847);
            this.fund.TabIndex = 6;
            this.fund.Text = "Appropriations";
            this.fund.ThemesEnabled = false;
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
            this.splitContainer5.Panel1.Controls.Add(this.AppropChart);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.expandCollapsePanel4);
            this.splitContainer5.Panel2.Controls.Add(this.rb5);
            this.splitContainer5.Panel2.Controls.Add(this.rb4);
            this.splitContainer5.Panel2.Controls.Add(this.rb1);
            this.splitContainer5.Panel2.Controls.Add(this.rb3);
            this.splitContainer5.Panel2.Controls.Add(this.rb2);
            this.splitContainer5.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer5.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer5.Size = new System.Drawing.Size(1780, 843);
            this.splitContainer5.SplitterDistance = 1505;
            this.splitContainer5.SplitterWidth = 2;
            this.splitContainer5.TabIndex = 96;
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
            this.AppropChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.AppropChart.Location = new System.Drawing.Point(35, 82);
            this.AppropChart.Margin = new System.Windows.Forms.Padding(2);
            this.AppropChart.Name = "AppropChart";
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
            this.AppropChart.Size = new System.Drawing.Size(1383, 629);
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
            this.AppropChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.AppropChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            // 
            // expandCollapsePanel4
            // 
            this.expandCollapsePanel4.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel4.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel4.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel4.Controls.Add(this.panel1);
            this.expandCollapsePanel4.ExpandedHeight = 827;
            this.expandCollapsePanel4.IsExpanded = false;
            this.expandCollapsePanel4.Location = new System.Drawing.Point(19, 13);
            this.expandCollapsePanel4.Name = "expandCollapsePanel4";
            this.expandCollapsePanel4.Size = new System.Drawing.Size(236, 37);
            this.expandCollapsePanel4.TabIndex = 105;
            this.expandCollapsePanel4.Text = "Select Appropriation";
            this.expandCollapsePanel4.UseAnimation = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 758);
            this.panel1.TabIndex = 1;
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
            // boc
            // 
            this.boc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boc.Controls.Add(this.splitContainer2);
            this.boc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boc.Image = null;
            this.boc.ImageSize = new System.Drawing.Size(50, 40);
            this.boc.Location = new System.Drawing.Point(1, 44);
            this.boc.Margin = new System.Windows.Forms.Padding(7);
            this.boc.Name = "boc";
            this.boc.Padding = new System.Windows.Forms.Padding(3);
            this.boc.ShowCloseButton = true;
            this.boc.Size = new System.Drawing.Size(1784, 847);
            this.boc.TabIndex = 3;
            this.boc.Text = "BOC";
            this.boc.ThemesEnabled = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.BocChart);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.expandCollapsePanel3);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Size = new System.Drawing.Size(1776, 839);
            this.splitContainer2.SplitterDistance = 1503;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 98;
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
            this.BocChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BocChart.Location = new System.Drawing.Point(23, 79);
            this.BocChart.Margin = new System.Windows.Forms.Padding(2);
            this.BocChart.Name = "BocChart";
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
            this.BocChart.Size = new System.Drawing.Size(1407, 618);
            this.BocChart.Spacing = 5F;
            this.BocChart.SpacingBetweenPoints = 5F;
            this.BocChart.Style3D = true;
            this.BocChart.TabIndex = 43;
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
            this.BocChart.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.BocChart.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // expandCollapsePanel3
            // 
            this.expandCollapsePanel3.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel3.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel3.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel3.Controls.Add(this.panel2);
            this.expandCollapsePanel3.ExpandedHeight = 723;
            this.expandCollapsePanel3.IsExpanded = false;
            this.expandCollapsePanel3.Location = new System.Drawing.Point(18, 101);
            this.expandCollapsePanel3.Name = "expandCollapsePanel3";
            this.expandCollapsePanel3.Size = new System.Drawing.Size(236, 37);
            this.expandCollapsePanel3.TabIndex = 105;
            this.expandCollapsePanel3.Text = "Select ";
            this.expandCollapsePanel3.UseAnimation = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panel2.Location = new System.Drawing.Point(23, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 628);
            this.panel2.TabIndex = 0;
            // 
            // npm
            // 
            this.npm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.npm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npm.Controls.Add(this.splitContainer4);
            this.npm.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npm.Image = null;
            this.npm.ImageSize = new System.Drawing.Size(50, 40);
            this.npm.Location = new System.Drawing.Point(1, 44);
            this.npm.Margin = new System.Windows.Forms.Padding(7);
            this.npm.Name = "npm";
            this.npm.Padding = new System.Windows.Forms.Padding(3);
            this.npm.ShowCloseButton = true;
            this.npm.Size = new System.Drawing.Size(1784, 847);
            this.npm.TabIndex = 7;
            this.npm.Text = "NPM";
            this.npm.ThemesEnabled = false;
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
            this.splitContainer4.Panel1.Controls.Add(this.NpmChart);
            this.splitContainer4.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.expandCollapsePanel2);
            this.splitContainer4.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer4.Size = new System.Drawing.Size(1776, 839);
            this.splitContainer4.SplitterDistance = 1503;
            this.splitContainer4.SplitterWidth = 2;
            this.splitContainer4.TabIndex = 98;
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
            this.NpmChart.Legend.FloatingAutoSize = false;
            this.NpmChart.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmChart.Legend.Location = new System.Drawing.Point(925, 14);
            this.NpmChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.NpmChart.Legend.OnlyColumnsForFloating = false;
            this.NpmChart.Legend.RowsCount = 2;
            this.NpmChart.Legend.ShowSymbol = true;
            this.NpmChart.Legend.Size = new System.Drawing.Size(112, 59);
            this.NpmChart.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.NpmChart.Legend.Visible = false;
            this.NpmChart.Legend.VisibleCheckBox = true;
            this.NpmChart.Localize = null;
            this.NpmChart.Location = new System.Drawing.Point(23, 79);
            this.NpmChart.Margin = new System.Windows.Forms.Padding(2);
            this.NpmChart.Name = "NpmChart";
            this.NpmChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.NpmChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpmChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.NpmChart.PrimaryXAxis.Margin = true;
            this.NpmChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.NpmChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.NpmChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.NpmChart.PrimaryYAxis.Margin = true;
            this.NpmChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.NpmChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.NpmChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.NpmChart.Size = new System.Drawing.Size(1450, 645);
            this.NpmChart.Spacing = 5F;
            this.NpmChart.SpacingBetweenSeries = 15F;
            this.NpmChart.Style3D = true;
            this.NpmChart.TabIndex = 96;
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
            this.NpmChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.NpmChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.panel3);
            this.expandCollapsePanel2.ExpandedHeight = 667;
            this.expandCollapsePanel2.IsExpanded = false;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(17, 43);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(242, 37);
            this.expandCollapsePanel2.TabIndex = 105;
            this.expandCollapsePanel2.Text = "Select NPM";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panel3.Location = new System.Drawing.Point(17, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 572);
            this.panel3.TabIndex = 0;
            // 
            // goal
            // 
            this.goal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goal.Controls.Add(this.splitContaineEPA);
            this.goal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal.Image = null;
            this.goal.ImageSize = new System.Drawing.Size(40, 40);
            this.goal.Location = new System.Drawing.Point(1, 44);
            this.goal.Margin = new System.Windows.Forms.Padding(7);
            this.goal.Name = "goal";
            this.goal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.goal.ShowCloseButton = true;
            this.goal.Size = new System.Drawing.Size(1784, 847);
            this.goal.TabIndex = 9;
            this.goal.Text = "Agency Goal";
            this.goal.ThemesEnabled = false;
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
            this.splitContaineEPA.Panel1.Controls.Add(this.GoalChart);
            // 
            // splitContaineEPA.Panel2
            // 
            this.splitContaineEPA.Panel2.Controls.Add(this.expandCollapsePanel1);
            this.splitContaineEPA.Size = new System.Drawing.Size(1778, 839);
            this.splitContaineEPA.SplitterDistance = 1504;
            this.splitContaineEPA.SplitterWidth = 2;
            this.splitContaineEPA.TabIndex = 99;
            // 
            // GoalChart
            // 
            this.GoalChart.AllowGradientPalette = true;
            this.GoalChart.AllowUserEditStyles = true;
            this.GoalChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.GoalChart.ChartArea.AutoScale = true;
            this.GoalChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.GoalChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.GoalChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.GoalChart.ChartArea.CursorReDraw = false;
            this.GoalChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.GoalChart.ChartAreaShadow = true;
            this.GoalChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.GoalChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.GoalChart.DataSourceName = "[none]";
            this.GoalChart.Depth = 250F;
            this.GoalChart.DisplayChartContextMenu = false;
            this.GoalChart.DisplaySeriesContextMenu = false;
            this.GoalChart.EnableMouseRotation = true;
            this.GoalChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GoalChart.HighlightSymbol = true;
            this.GoalChart.IsWindowLess = false;
            // 
            // 
            // 
            this.GoalChart.Legend.FloatingAutoSize = false;
            this.GoalChart.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.Legend.Location = new System.Drawing.Point(925, 14);
            this.GoalChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.GoalChart.Legend.OnlyColumnsForFloating = false;
            this.GoalChart.Legend.RowsCount = 2;
            this.GoalChart.Legend.ShowSymbol = true;
            this.GoalChart.Legend.Size = new System.Drawing.Size(112, 59);
            this.GoalChart.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.GoalChart.Legend.Visible = false;
            this.GoalChart.Legend.VisibleCheckBox = true;
            this.GoalChart.Localize = null;
            this.GoalChart.Location = new System.Drawing.Point(34, 62);
            this.GoalChart.Margin = new System.Windows.Forms.Padding(2);
            this.GoalChart.Name = "GoalChart";
            this.GoalChart.Padding = new System.Windows.Forms.Padding(1);
            this.GoalChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.GoalChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.GoalChart.PrimaryXAxis.Margin = true;
            this.GoalChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.GoalChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.GoalChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.GoalChart.PrimaryYAxis.Margin = true;
            this.GoalChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.GoalChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.RealMode3D = true;
            this.GoalChart.Rotation = 45F;
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
            this.GoalChart.Series.Add(chartSeries7);
            this.GoalChart.Series.Add(chartSeries8);
            this.GoalChart.Series3D = true;
            this.GoalChart.SeriesHighlight = true;
            this.GoalChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.GoalChart.Size = new System.Drawing.Size(1442, 589);
            this.GoalChart.Spacing = 5F;
            this.GoalChart.SpacingBetweenSeries = 15F;
            this.GoalChart.Style3D = true;
            this.GoalChart.TabIndex = 96;
            this.GoalChart.Tilt = 15F;
            // 
            // 
            // 
            this.GoalChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.GoalChart.Title.Name = "Default";
            this.GoalChart.ToolBar.EnableDefaultItems = false;
            this.GoalChart.ToolBar.Items.Add(chartToolBarSaveItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarCopyItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPrintItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.GoalChart.ToolBar.Items.Add(chartToolBarSplitter2);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.GoalChart.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.panel4);
            this.expandCollapsePanel1.ExpandedHeight = 487;
            this.expandCollapsePanel1.IsExpanded = false;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(13, 62);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(244, 37);
            this.expandCollapsePanel1.TabIndex = 105;
            this.expandCollapsePanel1.Text = "Select Goal";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panel4.Location = new System.Drawing.Point(16, 83);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 366);
            this.panel4.TabIndex = 0;
            // 
            // Program
            // 
            this.Program.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Program.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Program.Controls.Add(this.splitContainer8);
            this.Program.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Program.Image = null;
            this.Program.ImageSize = new System.Drawing.Size(50, 40);
            this.Program.Location = new System.Drawing.Point(1, 44);
            this.Program.Margin = new System.Windows.Forms.Padding(7);
            this.Program.Name = "Program";
            this.Program.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Program.ShowCloseButton = true;
            this.Program.Size = new System.Drawing.Size(1784, 847);
            this.Program.TabIndex = 8;
            this.Program.Text = "Program Area";
            this.Program.ThemesEnabled = false;
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
            this.splitContainer8.Panel1.Controls.Add(this.ProgramChart);
            this.splitContainer8.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.expandCollapsePanel5);
            this.splitContainer8.Panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer8.Size = new System.Drawing.Size(1778, 839);
            this.splitContainer8.SplitterDistance = 1504;
            this.splitContainer8.SplitterWidth = 2;
            this.splitContainer8.TabIndex = 100;
            // 
            // ProgramChart
            // 
            this.ProgramChart.AllowGradientPalette = true;
            this.ProgramChart.AllowUserEditStyles = true;
            this.ProgramChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.ProgramChart.ChartArea.AutoScale = true;
            this.ProgramChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.ProgramChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.ProgramChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.ProgramChart.ChartArea.CursorReDraw = false;
            this.ProgramChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.ProgramChart.ChartAreaShadow = true;
            this.ProgramChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.ProgramChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.ProgramChart.DataSourceName = "[none]";
            this.ProgramChart.Depth = 250F;
            this.ProgramChart.DisplayChartContextMenu = false;
            this.ProgramChart.DisplaySeriesContextMenu = false;
            this.ProgramChart.EnableMouseRotation = true;
            this.ProgramChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProgramChart.HighlightSymbol = true;
            this.ProgramChart.IsWindowLess = false;
            // 
            // 
            // 
            this.ProgramChart.Legend.FloatingAutoSize = false;
            this.ProgramChart.Legend.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramChart.Legend.Location = new System.Drawing.Point(925, 52);
            this.ProgramChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.ProgramChart.Legend.OnlyColumnsForFloating = false;
            this.ProgramChart.Legend.RowsCount = 2;
            this.ProgramChart.Legend.ShowSymbol = true;
            this.ProgramChart.Legend.Size = new System.Drawing.Size(112, 59);
            this.ProgramChart.Legend.TextAlignment = System.Drawing.StringAlignment.Near;
            this.ProgramChart.Legend.Visible = false;
            this.ProgramChart.Legend.VisibleCheckBox = true;
            this.ProgramChart.Localize = null;
            this.ProgramChart.Location = new System.Drawing.Point(23, 79);
            this.ProgramChart.Margin = new System.Windows.Forms.Padding(2);
            this.ProgramChart.Name = "ProgramChart";
            this.ProgramChart.Padding = new System.Windows.Forms.Padding(1);
            this.ProgramChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.ProgramChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ProgramChart.PrimaryXAxis.Margin = true;
            this.ProgramChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.ProgramChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ProgramChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ProgramChart.PrimaryYAxis.Margin = true;
            this.ProgramChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ProgramChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.ProgramChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramChart.RealMode3D = true;
            this.ProgramChart.Rotation = 45F;
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
            this.ProgramChart.Series.Add(chartSeries9);
            this.ProgramChart.Series.Add(chartSeries10);
            this.ProgramChart.Series3D = true;
            this.ProgramChart.SeriesHighlight = true;
            this.ProgramChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ProgramChart.Size = new System.Drawing.Size(1440, 665);
            this.ProgramChart.Spacing = 5F;
            this.ProgramChart.SpacingBetweenSeries = 15F;
            this.ProgramChart.Style3D = true;
            this.ProgramChart.TabIndex = 96;
            this.ProgramChart.Tilt = 15F;
            // 
            // 
            // 
            this.ProgramChart.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramChart.Title.Name = "Default";
            this.ProgramChart.ToolBar.EnableDefaultItems = false;
            this.ProgramChart.ToolBar.Items.Add(chartToolBarSaveItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarCopyItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarPrintItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem3);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarSplitter3);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarPaletteItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarStyleItem3);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarTypeItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarSeries3DItem5);
            this.ProgramChart.ToolBar.Items.Add(chartToolBarShowLegendItem5);
            // 
            // expandCollapsePanel5
            // 
            this.expandCollapsePanel5.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel5.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel5.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel5.Controls.Add(this.panel5);
            this.expandCollapsePanel5.ExpandedHeight = 793;
            this.expandCollapsePanel5.IsExpanded = false;
            this.expandCollapsePanel5.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel5.Name = "expandCollapsePanel5";
            this.expandCollapsePanel5.Size = new System.Drawing.Size(248, 37);
            this.expandCollapsePanel5.TabIndex = 105;
            this.expandCollapsePanel5.Text = "Select Program Area";
            this.expandCollapsePanel5.UseAnimation = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panel5.Location = new System.Drawing.Point(13, 71);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 695);
            this.panel5.TabIndex = 0;
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
            this.ObjectiveChart.Series.Add(chartSeries11);
            this.ObjectiveChart.Series.Add(chartSeries12);
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
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem4);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSplitter4);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarStyleItem4);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarShowLegendItem6);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "SummaryForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Region 6 Division Summary";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.summary.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.SummaryExpander.ResumeLayout(false);
            this.SummaryExpander.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentOrValue1)).EndInit();
            this.fund.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.expandCollapsePanel4.ResumeLayout(false);
            this.expandCollapsePanel4.PerformLayout();
            this.boc.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.expandCollapsePanel3.ResumeLayout(false);
            this.expandCollapsePanel3.PerformLayout();
            this.npm.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.goal.ResumeLayout(false);
            this.splitContaineEPA.Panel1.ResumeLayout(false);
            this.splitContaineEPA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContaineEPA)).EndInit();
            this.splitContaineEPA.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.Program.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.expandCollapsePanel5.ResumeLayout(false);
            this.expandCollapsePanel5.PerformLayout();
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
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv summary;
                protected Syncfusion.Windows.Forms.Chart.ChartControl P8chart;
                Syncfusion.Windows.Forms.Tools.TabPageAdv npm;
                protected internal Syncfusion.Windows.Forms.Tools.TabPageAdv boc;
                System.Windows.Forms.BindingSource BindingSource;
                System.Windows.Forms.ListBox ProgramListBox;
                protected Syncfusion.Windows.Forms.Chart.ChartControl ObjectiveChart;
                System.Windows.Forms.SplitContainer splitContainer1;
                private Syncfusion.Windows.Forms.Tools.ToggleButton PercentOrValue1;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv goal;
                private MetroFramework.Controls.MetroRadioButton obj5;
                private MetroFramework.Controls.MetroRadioButton obj2;
                private MetroFramework.Controls.MetroRadioButton obj3;
                private MetroFramework.Controls.MetroRadioButton obj4;
                private MetroFramework.Controls.MetroRadioButton obj1;
                private System.Windows.Forms.FlowLayoutPanel flpanel5;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Project;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Objective;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv ObjectiveTab;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv Program;
                private TabPageAdv fund;
                private SplitContainer splitContainer5;
                private FlowLayoutPanel panel1;
                private RadioButton rb5;
                private RadioButton rb4;
                private RadioButton rb1;
                private RadioButton rb3;
                private RadioButton rb2;
                protected ChartControl AppropChart;
                private SplitContainer splitContainer2;
                private FlowLayoutPanel panel2;
                private SplitContainer splitContainer4;
                private FlowLayoutPanel panel3;
                protected ChartControl NpmChart;
                private SplitContainer splitContaineEPA;
                private FlowLayoutPanel panel4;
                protected ChartControl GoalChart;
                private SplitContainer splitContainer8;
                private FlowLayoutPanel panel5;
                protected ChartControl ProgramChart;
                private SplitContainerAdv splitContainerAdv1;
                protected ChartControl BocChart;
                private MetroSetButton metroSetButton1;
                private MetroSetButton metroSetButton2;
                private MetroSetButton metroSetButton3;
                private MetroSetButton metroSetButton4;
                private MetroSetButton metroSetButton5;
                private MetroSetButton metroSetButton6;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel SummaryExpander;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel4;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel3;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel5;
            } 
        }
    }
}