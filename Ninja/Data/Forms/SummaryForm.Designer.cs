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
            public partial class SummaryForm
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries13 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo13 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo7 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries14 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo14 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem7 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem8 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries17 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo17 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo9 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries18 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo18 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries19 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo19 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo10 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries20 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo20 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.FundTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.FundExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.FundFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BocTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.BocFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.NpmFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.GoalTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel3 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.GoalFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ObjectiveTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel4 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.ObjectiveFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DivisionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel5 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DivisionFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.AreaTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel6 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.AreaFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ProjectTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel7 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.ProjectFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DatabaseTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Amount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Code = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BOC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel12 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel13 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel14 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel16 = new MetroSet_UI.Controls.MetroSetLabel();
            this.RC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Fund = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton3 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel18 = new MetroSet_UI.Controls.MetroSetLabel();
            this.BFY = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Org = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.PrcChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl2 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblCount = new MetroSet_UI.Controls.MetroSetLabel();
            this.ReturnButton = new MetroFramework.Controls.MetroLink();
            this.lblTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem2 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dd = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.rcc = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Amount2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Amount1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cd = new MetroSet_UI.Controls.MetroSetTextBox();
            this.bb = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ff = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel15 = new MetroSet_UI.Controls.MetroSetLabel();
            this.yy = new MetroSet_UI.Controls.MetroSetTextBox();
            this.o = new MetroSet_UI.Controls.MetroSetTextBox();
            this.MiniTabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).BeginInit();
            this.SummaryTabControl.SuspendLayout();
            this.FundTab.SuspendLayout();
            this.FundExpander.SuspendLayout();
            this.BocTab.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.NpmTab.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.GoalTab.SuspendLayout();
            this.expandCollapsePanel3.SuspendLayout();
            this.ObjectiveTab.SuspendLayout();
            this.expandCollapsePanel4.SuspendLayout();
            this.DivisionTab.SuspendLayout();
            this.expandCollapsePanel5.SuspendLayout();
            this.AreaTab.SuspendLayout();
            this.expandCollapsePanel6.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.expandCollapsePanel7.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.chartControl1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).BeginInit();
            this.MiniTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummaryTabControl
            // 
            this.SummaryTabControl.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SummaryTabControl.BeforeTouchSize = new System.Drawing.Size(1588, 919);
            this.SummaryTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryTabControl.BorderWidth = 1;
            this.SummaryTabControl.CloseButtonForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.Controls.Add(this.FundTab);
            this.SummaryTabControl.Controls.Add(this.BocTab);
            this.SummaryTabControl.Controls.Add(this.NpmTab);
            this.SummaryTabControl.Controls.Add(this.GoalTab);
            this.SummaryTabControl.Controls.Add(this.ObjectiveTab);
            this.SummaryTabControl.Controls.Add(this.DivisionTab);
            this.SummaryTabControl.Controls.Add(this.AreaTab);
            this.SummaryTabControl.Controls.Add(this.ProjectTab);
            this.SummaryTabControl.Controls.Add(this.DatabaseTab);
            this.SummaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.Gray;
            this.SummaryTabControl.ItemSize = new System.Drawing.Size(80, 50);
            this.SummaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.SummaryTabControl.Multiline = true;
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.SummaryTabControl.ShowScroll = false;
            this.SummaryTabControl.ShowSeparator = false;
            this.SummaryTabControl.Size = new System.Drawing.Size(1588, 919);
            this.SummaryTabControl.TabIndex = 0;
            this.SummaryTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            // 
            // FundTab
            // 
            this.FundTab.Controls.Add(this.FundExpander);
            this.FundTab.Controls.Add(this.FundChart);
            this.FundTab.Image = null;
            this.FundTab.ImageSize = new System.Drawing.Size(16, 16);
            this.FundTab.Location = new System.Drawing.Point(1, 34);
            this.FundTab.Name = "FundTab";
            this.FundTab.ShowCloseButton = true;
            this.FundTab.Size = new System.Drawing.Size(1586, 884);
            this.FundTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundTab.TabIndex = 1;
            this.FundTab.Tag = "FundName";
            this.FundTab.Text = "Appropriation";
            this.FundTab.ThemesEnabled = false;
            // 
            // FundExpander
            // 
            this.FundExpander.BackColor = System.Drawing.Color.Black;
            this.FundExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.FundExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.FundExpander.Controls.Add(this.FundFilter2);
            this.FundExpander.Controls.Add(this.FundFilter1);
            this.FundExpander.ExpandedHeight = 421;
            this.FundExpander.IsExpanded = false;
            this.FundExpander.Location = new System.Drawing.Point(1229, 100);
            this.FundExpander.Name = "FundExpander";
            this.FundExpander.Size = new System.Drawing.Size(333, 37);
            this.FundExpander.TabIndex = 107;
            this.FundExpander.Text = "Filter";
            this.FundExpander.UseAnimation = true;
            // 
            // FundFilter2
            // 
            this.FundFilter2.AllowDrop = true;
            this.FundFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter2.BackColor = System.Drawing.Color.Transparent;
            this.FundFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FundFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter2.CausesValidation = false;
            this.FundFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FundFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FundFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter2.FormattingEnabled = true;
            this.FundFilter2.ItemHeight = 30;
            this.FundFilter2.Location = new System.Drawing.Point(32, 267);
            this.FundFilter2.Name = "FundFilter2";
            this.FundFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter2.Size = new System.Drawing.Size(276, 36);
            this.FundFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter2.StyleManager = null;
            this.FundFilter2.TabIndex = 0;
            this.FundFilter2.ThemeAuthor = "Narwin";
            this.FundFilter2.ThemeName = "MetroDark";
            // 
            // FundFilter1
            // 
            this.FundFilter1.AllowDrop = true;
            this.FundFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter1.BackColor = System.Drawing.Color.Transparent;
            this.FundFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FundFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter1.CausesValidation = false;
            this.FundFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FundFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FundFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter1.FormattingEnabled = true;
            this.FundFilter1.ItemHeight = 30;
            this.FundFilter1.Location = new System.Drawing.Point(32, 113);
            this.FundFilter1.MaxDropDownItems = 20;
            this.FundFilter1.Name = "FundFilter1";
            this.FundFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter1.Size = new System.Drawing.Size(276, 36);
            this.FundFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter1.StyleManager = null;
            this.FundFilter1.TabIndex = 0;
            this.FundFilter1.Tag = "FundName";
            this.FundFilter1.ThemeAuthor = "Narwin";
            this.FundFilter1.ThemeName = "MetroDark";
            // 
            // FundChart
            // 
            this.FundChart.AllowGradientPalette = true;
            this.FundChart.AllowUserEditStyles = true;
            this.FundChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.FundChart.ChartArea.AutoScale = true;
            this.FundChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.FundChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.FundChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.FundChart.ChartArea.CursorReDraw = false;
            this.FundChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.FundChart.ChartAreaShadow = true;
            this.FundChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.FundChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.FundChart.DataSourceName = "FundBindingSource";
            this.FundChart.Depth = 250F;
            this.FundChart.DisplayChartContextMenu = false;
            this.FundChart.DisplaySeriesContextMenu = false;
            this.FundChart.EnableMouseRotation = true;
            this.FundChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FundChart.HighlightSymbol = true;
            this.FundChart.IsWindowLess = false;
            // 
            // 
            // 
            this.FundChart.Legend.Location = new System.Drawing.Point(1052, 10);
            this.FundChart.Legend.Visible = false;
            this.FundChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.FundChart.Localize = null;
            this.FundChart.Location = new System.Drawing.Point(20, 100);
            this.FundChart.Margin = new System.Windows.Forms.Padding(2);
            this.FundChart.Name = "FundChart";
            this.FundChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.FundChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.FundChart.PrimaryXAxis.Margin = true;
            this.FundChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.FundChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.FundChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.FundChart.PrimaryYAxis.Margin = true;
            this.FundChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.FundChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.FundChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.FundChart.RealMode3D = true;
            this.FundChart.Rotation = 20F;
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
            this.FundChart.Series.Add(chartSeries1);
            this.FundChart.Series.Add(chartSeries2);
            this.FundChart.Series3D = true;
            this.FundChart.SeriesHighlight = true;
            this.FundChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.FundChart.Size = new System.Drawing.Size(1204, 720);
            this.FundChart.Spacing = 5F;
            this.FundChart.SpacingBetweenPoints = 5F;
            this.FundChart.Style3D = true;
            this.FundChart.TabIndex = 43;
            this.FundChart.Tilt = 5F;
            // 
            // 
            // 
            this.FundChart.Title.Name = "Default";
            this.FundChart.ToolBar.EnableDefaultItems = false;
            this.FundChart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.FundChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            // 
            // BocTab
            // 
            this.BocTab.Controls.Add(this.expandCollapsePanel1);
            this.BocTab.Controls.Add(this.BocChart);
            this.BocTab.Image = null;
            this.BocTab.ImageSize = new System.Drawing.Size(16, 16);
            this.BocTab.Location = new System.Drawing.Point(1, 34);
            this.BocTab.Name = "BocTab";
            this.BocTab.ShowCloseButton = true;
            this.BocTab.Size = new System.Drawing.Size(1586, 884);
            this.BocTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocTab.TabIndex = 2;
            this.BocTab.Tag = "BocName";
            this.BocTab.Text = "BOC";
            this.BocTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.BocFilter2);
            this.expandCollapsePanel1.Controls.Add(this.BocFilter1);
            this.expandCollapsePanel1.ExpandedHeight = 421;
            this.expandCollapsePanel1.IsExpanded = false;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(1251, 100);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(311, 37);
            this.expandCollapsePanel1.TabIndex = 108;
            this.expandCollapsePanel1.Text = "Filter";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // BocFilter2
            // 
            this.BocFilter2.AllowDrop = true;
            this.BocFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter2.BackColor = System.Drawing.Color.Transparent;
            this.BocFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BocFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter2.CausesValidation = false;
            this.BocFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BocFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BocFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter2.FormattingEnabled = true;
            this.BocFilter2.ItemHeight = 30;
            this.BocFilter2.Location = new System.Drawing.Point(23, 271);
            this.BocFilter2.Name = "BocFilter2";
            this.BocFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter2.Size = new System.Drawing.Size(273, 36);
            this.BocFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter2.StyleManager = null;
            this.BocFilter2.TabIndex = 0;
            this.BocFilter2.ThemeAuthor = "Narwin";
            this.BocFilter2.ThemeName = "MetroDark";
            // 
            // BocFilter1
            // 
            this.BocFilter1.AllowDrop = true;
            this.BocFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter1.BackColor = System.Drawing.Color.Transparent;
            this.BocFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BocFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter1.CausesValidation = false;
            this.BocFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BocFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BocFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter1.FormattingEnabled = true;
            this.BocFilter1.ItemHeight = 30;
            this.BocFilter1.Location = new System.Drawing.Point(23, 113);
            this.BocFilter1.MaxDropDownItems = 20;
            this.BocFilter1.Name = "BocFilter1";
            this.BocFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter1.Size = new System.Drawing.Size(273, 36);
            this.BocFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter1.StyleManager = null;
            this.BocFilter1.TabIndex = 0;
            this.BocFilter1.Tag = "BocName";
            this.BocFilter1.ThemeAuthor = "Narwin";
            this.BocFilter1.ThemeName = "MetroDark";
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
            this.BocChart.DataSourceName = "FundBindingSource";
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
            this.BocChart.Location = new System.Drawing.Point(20, 100);
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
            this.BocChart.Size = new System.Drawing.Size(1204, 720);
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
            // NpmTab
            // 
            this.NpmTab.Controls.Add(this.expandCollapsePanel2);
            this.NpmTab.Controls.Add(this.NpmChart);
            this.NpmTab.Image = null;
            this.NpmTab.ImageSize = new System.Drawing.Size(16, 16);
            this.NpmTab.Location = new System.Drawing.Point(1, 34);
            this.NpmTab.Name = "NpmTab";
            this.NpmTab.ShowCloseButton = true;
            this.NpmTab.Size = new System.Drawing.Size(1586, 884);
            this.NpmTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmTab.TabIndex = 3;
            this.NpmTab.Tag = "NPM";
            this.NpmTab.Text = "NPM";
            this.NpmTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.NpmFilter2);
            this.expandCollapsePanel2.Controls.Add(this.NpmFilter1);
            this.expandCollapsePanel2.ExpandedHeight = 421;
            this.expandCollapsePanel2.IsExpanded = false;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(1247, 100);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(315, 37);
            this.expandCollapsePanel2.TabIndex = 108;
            this.expandCollapsePanel2.Text = "Filter";
            this.expandCollapsePanel2.UseAnimation = true;
            // 
            // NpmFilter2
            // 
            this.NpmFilter2.AllowDrop = true;
            this.NpmFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter2.BackColor = System.Drawing.Color.Transparent;
            this.NpmFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NpmFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter2.CausesValidation = false;
            this.NpmFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NpmFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NpmFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter2.FormattingEnabled = true;
            this.NpmFilter2.ItemHeight = 30;
            this.NpmFilter2.Location = new System.Drawing.Point(48, 267);
            this.NpmFilter2.Name = "NpmFilter2";
            this.NpmFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter2.Size = new System.Drawing.Size(252, 36);
            this.NpmFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter2.StyleManager = null;
            this.NpmFilter2.TabIndex = 0;
            this.NpmFilter2.ThemeAuthor = "Narwin";
            this.NpmFilter2.ThemeName = "MetroDark";
            // 
            // NpmFilter1
            // 
            this.NpmFilter1.AllowDrop = true;
            this.NpmFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter1.BackColor = System.Drawing.Color.Transparent;
            this.NpmFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NpmFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter1.CausesValidation = false;
            this.NpmFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NpmFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NpmFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter1.FormattingEnabled = true;
            this.NpmFilter1.ItemHeight = 30;
            this.NpmFilter1.Location = new System.Drawing.Point(48, 113);
            this.NpmFilter1.MaxDropDownItems = 20;
            this.NpmFilter1.Name = "NpmFilter1";
            this.NpmFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter1.Size = new System.Drawing.Size(252, 36);
            this.NpmFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter1.StyleManager = null;
            this.NpmFilter1.TabIndex = 0;
            this.NpmFilter1.Tag = "NPM";
            this.NpmFilter1.ThemeAuthor = "Narwin";
            this.NpmFilter1.ThemeName = "MetroDark";
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
            this.NpmChart.DataSourceName = "FundBindingSource";
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
            this.NpmChart.Location = new System.Drawing.Point(20, 100);
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
            this.NpmChart.Size = new System.Drawing.Size(1204, 720);
            this.NpmChart.Spacing = 5F;
            this.NpmChart.SpacingBetweenPoints = 5F;
            this.NpmChart.Style3D = true;
            this.NpmChart.TabIndex = 43;
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
            this.NpmChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.NpmChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // GoalTab
            // 
            this.GoalTab.Controls.Add(this.expandCollapsePanel3);
            this.GoalTab.Controls.Add(this.GoalChart);
            this.GoalTab.Image = null;
            this.GoalTab.ImageSize = new System.Drawing.Size(16, 16);
            this.GoalTab.Location = new System.Drawing.Point(1, 34);
            this.GoalTab.Name = "GoalTab";
            this.GoalTab.ShowCloseButton = true;
            this.GoalTab.Size = new System.Drawing.Size(1586, 884);
            this.GoalTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalTab.TabIndex = 4;
            this.GoalTab.Tag = "GoalName";
            this.GoalTab.Text = "Goal";
            this.GoalTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel3
            // 
            this.expandCollapsePanel3.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel3.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel3.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel3.Controls.Add(this.GoalFilter2);
            this.expandCollapsePanel3.Controls.Add(this.GoalFilter1);
            this.expandCollapsePanel3.ExpandedHeight = 421;
            this.expandCollapsePanel3.IsExpanded = false;
            this.expandCollapsePanel3.Location = new System.Drawing.Point(1223, 100);
            this.expandCollapsePanel3.Name = "expandCollapsePanel3";
            this.expandCollapsePanel3.Size = new System.Drawing.Size(339, 37);
            this.expandCollapsePanel3.TabIndex = 108;
            this.expandCollapsePanel3.Text = "Filter";
            this.expandCollapsePanel3.UseAnimation = true;
            // 
            // GoalFilter2
            // 
            this.GoalFilter2.AllowDrop = true;
            this.GoalFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter2.BackColor = System.Drawing.Color.Transparent;
            this.GoalFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GoalFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter2.CausesValidation = false;
            this.GoalFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GoalFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GoalFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GoalFilter2.FormattingEnabled = true;
            this.GoalFilter2.ItemHeight = 30;
            this.GoalFilter2.Location = new System.Drawing.Point(18, 267);
            this.GoalFilter2.Name = "GoalFilter2";
            this.GoalFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter2.Size = new System.Drawing.Size(306, 36);
            this.GoalFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter2.StyleManager = null;
            this.GoalFilter2.TabIndex = 0;
            this.GoalFilter2.ThemeAuthor = "Narwin";
            this.GoalFilter2.ThemeName = "MetroDark";
            // 
            // GoalFilter1
            // 
            this.GoalFilter1.AllowDrop = true;
            this.GoalFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter1.BackColor = System.Drawing.Color.Transparent;
            this.GoalFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GoalFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter1.CausesValidation = false;
            this.GoalFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GoalFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GoalFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GoalFilter1.FormattingEnabled = true;
            this.GoalFilter1.ItemHeight = 30;
            this.GoalFilter1.Location = new System.Drawing.Point(18, 113);
            this.GoalFilter1.MaxDropDownItems = 20;
            this.GoalFilter1.Name = "GoalFilter1";
            this.GoalFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter1.Size = new System.Drawing.Size(306, 36);
            this.GoalFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter1.StyleManager = null;
            this.GoalFilter1.TabIndex = 0;
            this.GoalFilter1.Tag = "GoalName";
            this.GoalFilter1.ThemeAuthor = "Narwin";
            this.GoalFilter1.ThemeName = "MetroDark";
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
            this.GoalChart.DataSourceName = "FundBindingSource";
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
            this.GoalChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.GoalChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.GoalChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.GoalChart.Legend.Visible = false;
            this.GoalChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.GoalChart.Localize = null;
            this.GoalChart.Location = new System.Drawing.Point(20, 100);
            this.GoalChart.Margin = new System.Windows.Forms.Padding(2);
            this.GoalChart.Name = "GoalChart";
            this.GoalChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.GoalChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.GoalChart.PrimaryXAxis.Margin = true;
            this.GoalChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.GoalChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.GoalChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.GoalChart.PrimaryYAxis.Margin = true;
            this.GoalChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.GoalChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.GoalChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
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
            this.GoalChart.Size = new System.Drawing.Size(1204, 720);
            this.GoalChart.Spacing = 5F;
            this.GoalChart.SpacingBetweenPoints = 5F;
            this.GoalChart.Style3D = true;
            this.GoalChart.TabIndex = 43;
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
            this.GoalChart.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.GoalChart.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // ObjectiveTab
            // 
            this.ObjectiveTab.Controls.Add(this.expandCollapsePanel4);
            this.ObjectiveTab.Controls.Add(this.ObjectiveChart);
            this.ObjectiveTab.Image = null;
            this.ObjectiveTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ObjectiveTab.Location = new System.Drawing.Point(1, 34);
            this.ObjectiveTab.Name = "ObjectiveTab";
            this.ObjectiveTab.ShowCloseButton = true;
            this.ObjectiveTab.Size = new System.Drawing.Size(1586, 884);
            this.ObjectiveTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveTab.TabIndex = 5;
            this.ObjectiveTab.Tag = "ObjectiveName";
            this.ObjectiveTab.Text = "Objective";
            this.ObjectiveTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel4
            // 
            this.expandCollapsePanel4.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel4.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel4.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel4.Controls.Add(this.ObjectiveFilter2);
            this.expandCollapsePanel4.Controls.Add(this.ObjectiveFilter1);
            this.expandCollapsePanel4.ExpandedHeight = 421;
            this.expandCollapsePanel4.IsExpanded = false;
            this.expandCollapsePanel4.Location = new System.Drawing.Point(1221, 100);
            this.expandCollapsePanel4.Name = "expandCollapsePanel4";
            this.expandCollapsePanel4.Size = new System.Drawing.Size(341, 37);
            this.expandCollapsePanel4.TabIndex = 108;
            this.expandCollapsePanel4.Text = "Filter";
            this.expandCollapsePanel4.UseAnimation = true;
            // 
            // ObjectiveFilter2
            // 
            this.ObjectiveFilter2.AllowDrop = true;
            this.ObjectiveFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter2.BackColor = System.Drawing.Color.Transparent;
            this.ObjectiveFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ObjectiveFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter2.CausesValidation = false;
            this.ObjectiveFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ObjectiveFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ObjectiveFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ObjectiveFilter2.FormattingEnabled = true;
            this.ObjectiveFilter2.ItemHeight = 30;
            this.ObjectiveFilter2.Location = new System.Drawing.Point(26, 267);
            this.ObjectiveFilter2.Name = "ObjectiveFilter2";
            this.ObjectiveFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter2.Size = new System.Drawing.Size(297, 36);
            this.ObjectiveFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter2.StyleManager = null;
            this.ObjectiveFilter2.TabIndex = 0;
            this.ObjectiveFilter2.ThemeAuthor = "Narwin";
            this.ObjectiveFilter2.ThemeName = "MetroDark";
            // 
            // ObjectiveFilter1
            // 
            this.ObjectiveFilter1.AllowDrop = true;
            this.ObjectiveFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ObjectiveFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ObjectiveFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter1.CausesValidation = false;
            this.ObjectiveFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ObjectiveFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ObjectiveFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ObjectiveFilter1.FormattingEnabled = true;
            this.ObjectiveFilter1.ItemHeight = 30;
            this.ObjectiveFilter1.Location = new System.Drawing.Point(26, 113);
            this.ObjectiveFilter1.MaxDropDownItems = 20;
            this.ObjectiveFilter1.Name = "ObjectiveFilter1";
            this.ObjectiveFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter1.Size = new System.Drawing.Size(297, 36);
            this.ObjectiveFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter1.StyleManager = null;
            this.ObjectiveFilter1.TabIndex = 0;
            this.ObjectiveFilter1.Tag = "ObjectiveName";
            this.ObjectiveFilter1.ThemeAuthor = "Narwin";
            this.ObjectiveFilter1.ThemeName = "MetroDark";
            // 
            // ObjectiveChart
            // 
            this.ObjectiveChart.AllowGradientPalette = true;
            this.ObjectiveChart.AllowUserEditStyles = true;
            this.ObjectiveChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
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
            this.ObjectiveChart.DataSourceName = "FundBindingSource";
            this.ObjectiveChart.Depth = 250F;
            this.ObjectiveChart.DisplayChartContextMenu = false;
            this.ObjectiveChart.DisplaySeriesContextMenu = false;
            this.ObjectiveChart.EnableMouseRotation = true;
            this.ObjectiveChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ObjectiveChart.HighlightSymbol = true;
            this.ObjectiveChart.IsWindowLess = false;
            // 
            // 
            // 
            this.ObjectiveChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.ObjectiveChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.ObjectiveChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.ObjectiveChart.Legend.Visible = false;
            this.ObjectiveChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.ObjectiveChart.Localize = null;
            this.ObjectiveChart.Location = new System.Drawing.Point(20, 100);
            this.ObjectiveChart.Margin = new System.Windows.Forms.Padding(2);
            this.ObjectiveChart.Name = "ObjectiveChart";
            this.ObjectiveChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.ObjectiveChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ObjectiveChart.PrimaryXAxis.Margin = true;
            this.ObjectiveChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.ObjectiveChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ObjectiveChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ObjectiveChart.PrimaryYAxis.Margin = true;
            this.ObjectiveChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ObjectiveChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.ObjectiveChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.ObjectiveChart.RealMode3D = true;
            this.ObjectiveChart.Rotation = 45F;
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
            this.ObjectiveChart.Series.Add(chartSeries9);
            this.ObjectiveChart.Series.Add(chartSeries10);
            this.ObjectiveChart.Series3D = true;
            this.ObjectiveChart.SeriesHighlight = true;
            this.ObjectiveChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ObjectiveChart.Size = new System.Drawing.Size(1196, 720);
            this.ObjectiveChart.Spacing = 5F;
            this.ObjectiveChart.SpacingBetweenPoints = 5F;
            this.ObjectiveChart.Style3D = true;
            this.ObjectiveChart.TabIndex = 43;
            this.ObjectiveChart.Tilt = 15F;
            // 
            // 
            // 
            this.ObjectiveChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ObjectiveChart.Title.Name = "Default";
            this.ObjectiveChart.ToolBar.EnableDefaultItems = false;
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSaveItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarCopyItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPaletteItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarTypeItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSeries3DItem5);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarShowLegendItem5);
            // 
            // DivisionTab
            // 
            this.DivisionTab.Controls.Add(this.expandCollapsePanel5);
            this.DivisionTab.Controls.Add(this.DivisionChart);
            this.DivisionTab.Image = null;
            this.DivisionTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DivisionTab.Location = new System.Drawing.Point(1, 34);
            this.DivisionTab.Name = "DivisionTab";
            this.DivisionTab.ShowCloseButton = true;
            this.DivisionTab.Size = new System.Drawing.Size(1586, 884);
            this.DivisionTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionTab.TabIndex = 6;
            this.DivisionTab.Tag = "RC";
            this.DivisionTab.Text = "Division";
            this.DivisionTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel5
            // 
            this.expandCollapsePanel5.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel5.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel5.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel5.Controls.Add(this.DivisionFilter2);
            this.expandCollapsePanel5.Controls.Add(this.DivisionFilter1);
            this.expandCollapsePanel5.ExpandedHeight = 421;
            this.expandCollapsePanel5.IsExpanded = false;
            this.expandCollapsePanel5.Location = new System.Drawing.Point(1241, 100);
            this.expandCollapsePanel5.Name = "expandCollapsePanel5";
            this.expandCollapsePanel5.Size = new System.Drawing.Size(334, 37);
            this.expandCollapsePanel5.TabIndex = 108;
            this.expandCollapsePanel5.Text = "Filter";
            this.expandCollapsePanel5.UseAnimation = true;
            // 
            // DivisionFilter2
            // 
            this.DivisionFilter2.AllowDrop = true;
            this.DivisionFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter2.BackColor = System.Drawing.Color.Transparent;
            this.DivisionFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DivisionFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter2.CausesValidation = false;
            this.DivisionFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DivisionFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DivisionFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DivisionFilter2.FormattingEnabled = true;
            this.DivisionFilter2.ItemHeight = 30;
            this.DivisionFilter2.Location = new System.Drawing.Point(11, 267);
            this.DivisionFilter2.Name = "DivisionFilter2";
            this.DivisionFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter2.Size = new System.Drawing.Size(307, 36);
            this.DivisionFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter2.StyleManager = null;
            this.DivisionFilter2.TabIndex = 0;
            this.DivisionFilter2.ThemeAuthor = "Narwin";
            this.DivisionFilter2.ThemeName = "MetroDark";
            // 
            // DivisionFilter1
            // 
            this.DivisionFilter1.AllowDrop = true;
            this.DivisionFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter1.BackColor = System.Drawing.Color.Transparent;
            this.DivisionFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DivisionFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter1.CausesValidation = false;
            this.DivisionFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DivisionFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DivisionFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DivisionFilter1.FormattingEnabled = true;
            this.DivisionFilter1.ItemHeight = 30;
            this.DivisionFilter1.Location = new System.Drawing.Point(11, 113);
            this.DivisionFilter1.MaxDropDownItems = 20;
            this.DivisionFilter1.Name = "DivisionFilter1";
            this.DivisionFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter1.Size = new System.Drawing.Size(307, 36);
            this.DivisionFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter1.StyleManager = null;
            this.DivisionFilter1.TabIndex = 0;
            this.DivisionFilter1.Tag = "RC";
            this.DivisionFilter1.ThemeAuthor = "Narwin";
            this.DivisionFilter1.ThemeName = "MetroDark";
            // 
            // DivisionChart
            // 
            this.DivisionChart.AllowGradientPalette = true;
            this.DivisionChart.AllowUserEditStyles = true;
            this.DivisionChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.DivisionChart.ChartArea.AutoScale = true;
            this.DivisionChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.DivisionChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.DivisionChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.DivisionChart.ChartArea.CursorReDraw = false;
            this.DivisionChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.DivisionChart.ChartAreaShadow = true;
            this.DivisionChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.DivisionChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            this.DivisionChart.DataSourceName = "FundBindingSource";
            this.DivisionChart.Depth = 250F;
            this.DivisionChart.DisplayChartContextMenu = false;
            this.DivisionChart.DisplaySeriesContextMenu = false;
            this.DivisionChart.EnableMouseRotation = true;
            this.DivisionChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DivisionChart.HighlightSymbol = true;
            this.DivisionChart.IsWindowLess = false;
            // 
            // 
            // 
            this.DivisionChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.DivisionChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.DivisionChart.Legend.Visible = false;
            this.DivisionChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.DivisionChart.Localize = null;
            this.DivisionChart.Location = new System.Drawing.Point(20, 100);
            this.DivisionChart.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionChart.Name = "DivisionChart";
            this.DivisionChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.DivisionChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DivisionChart.PrimaryXAxis.Margin = true;
            this.DivisionChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.DivisionChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.DivisionChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DivisionChart.PrimaryYAxis.Margin = true;
            this.DivisionChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DivisionChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.DivisionChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.DivisionChart.RealMode3D = true;
            this.DivisionChart.Rotation = 45F;
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
            this.DivisionChart.Series.Add(chartSeries11);
            this.DivisionChart.Series.Add(chartSeries12);
            this.DivisionChart.Series3D = true;
            this.DivisionChart.SeriesHighlight = true;
            this.DivisionChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.DivisionChart.Size = new System.Drawing.Size(1204, 720);
            this.DivisionChart.Spacing = 5F;
            this.DivisionChart.SpacingBetweenPoints = 5F;
            this.DivisionChart.Style3D = true;
            this.DivisionChart.TabIndex = 43;
            this.DivisionChart.Tilt = 15F;
            // 
            // 
            // 
            this.DivisionChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.DivisionChart.Title.Name = "Default";
            this.DivisionChart.ToolBar.EnableDefaultItems = false;
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarShowLegendItem6);
            // 
            // AreaTab
            // 
            this.AreaTab.Controls.Add(this.expandCollapsePanel6);
            this.AreaTab.Controls.Add(this.AreaChart);
            this.AreaTab.Image = null;
            this.AreaTab.ImageSize = new System.Drawing.Size(16, 16);
            this.AreaTab.Location = new System.Drawing.Point(1, 34);
            this.AreaTab.Name = "AreaTab";
            this.AreaTab.ShowCloseButton = true;
            this.AreaTab.Size = new System.Drawing.Size(1586, 884);
            this.AreaTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaTab.TabIndex = 7;
            this.AreaTab.Tag = "ProgramAreaName";
            this.AreaTab.Text = "Program Area";
            this.AreaTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel6
            // 
            this.expandCollapsePanel6.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel6.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel6.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel6.Controls.Add(this.AreaFilter2);
            this.expandCollapsePanel6.Controls.Add(this.AreaFilter1);
            this.expandCollapsePanel6.ExpandedHeight = 421;
            this.expandCollapsePanel6.IsExpanded = false;
            this.expandCollapsePanel6.Location = new System.Drawing.Point(1247, 100);
            this.expandCollapsePanel6.Name = "expandCollapsePanel6";
            this.expandCollapsePanel6.Size = new System.Drawing.Size(315, 37);
            this.expandCollapsePanel6.TabIndex = 108;
            this.expandCollapsePanel6.Text = "Filter";
            this.expandCollapsePanel6.UseAnimation = true;
            // 
            // AreaFilter2
            // 
            this.AreaFilter2.AllowDrop = true;
            this.AreaFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter2.BackColor = System.Drawing.Color.Transparent;
            this.AreaFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AreaFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter2.CausesValidation = false;
            this.AreaFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AreaFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AreaFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AreaFilter2.FormattingEnabled = true;
            this.AreaFilter2.ItemHeight = 30;
            this.AreaFilter2.Location = new System.Drawing.Point(0, 267);
            this.AreaFilter2.Name = "AreaFilter2";
            this.AreaFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter2.Size = new System.Drawing.Size(312, 36);
            this.AreaFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter2.StyleManager = null;
            this.AreaFilter2.TabIndex = 0;
            this.AreaFilter2.ThemeAuthor = "Narwin";
            this.AreaFilter2.ThemeName = "MetroDark";
            // 
            // AreaFilter1
            // 
            this.AreaFilter1.AllowDrop = true;
            this.AreaFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter1.BackColor = System.Drawing.Color.Transparent;
            this.AreaFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AreaFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter1.CausesValidation = false;
            this.AreaFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AreaFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AreaFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AreaFilter1.FormattingEnabled = true;
            this.AreaFilter1.ItemHeight = 30;
            this.AreaFilter1.Location = new System.Drawing.Point(3, 113);
            this.AreaFilter1.MaxDropDownItems = 20;
            this.AreaFilter1.Name = "AreaFilter1";
            this.AreaFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter1.Size = new System.Drawing.Size(309, 36);
            this.AreaFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter1.StyleManager = null;
            this.AreaFilter1.TabIndex = 0;
            this.AreaFilter1.Tag = "ProgramAreaName";
            this.AreaFilter1.ThemeAuthor = "Narwin";
            this.AreaFilter1.ThemeName = "MetroDark";
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
            this.AreaChart.DataSourceName = "FundBindingSource";
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
            this.AreaChart.Location = new System.Drawing.Point(20, 100);
            this.AreaChart.Margin = new System.Windows.Forms.Padding(2);
            this.AreaChart.Name = "AreaChart";
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
            this.AreaChart.Series.Add(chartSeries13);
            this.AreaChart.Series.Add(chartSeries14);
            this.AreaChart.Series3D = true;
            this.AreaChart.SeriesHighlight = true;
            this.AreaChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AreaChart.Size = new System.Drawing.Size(1204, 720);
            this.AreaChart.Spacing = 5F;
            this.AreaChart.SpacingBetweenPoints = 5F;
            this.AreaChart.Style3D = true;
            this.AreaChart.TabIndex = 43;
            this.AreaChart.Tilt = 15F;
            // 
            // 
            // 
            this.AreaChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AreaChart.Title.Name = "Default";
            this.AreaChart.ToolBar.EnableDefaultItems = false;
            this.AreaChart.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.AreaChart.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.expandCollapsePanel7);
            this.ProjectTab.Controls.Add(this.ProjectChart);
            this.ProjectTab.Image = null;
            this.ProjectTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ProjectTab.Location = new System.Drawing.Point(1, 34);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.ShowCloseButton = true;
            this.ProjectTab.Size = new System.Drawing.Size(1586, 884);
            this.ProjectTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectTab.TabIndex = 8;
            this.ProjectTab.Tag = "ProgramProjectTab";
            this.ProjectTab.Text = "Program Project";
            this.ProjectTab.ThemesEnabled = false;
            // 
            // expandCollapsePanel7
            // 
            this.expandCollapsePanel7.BackColor = System.Drawing.Color.Black;
            this.expandCollapsePanel7.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel7.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel7.Controls.Add(this.ProjectFilter2);
            this.expandCollapsePanel7.Controls.Add(this.ProjectFilter1);
            this.expandCollapsePanel7.ExpandedHeight = 421;
            this.expandCollapsePanel7.IsExpanded = false;
            this.expandCollapsePanel7.Location = new System.Drawing.Point(1244, 100);
            this.expandCollapsePanel7.Name = "expandCollapsePanel7";
            this.expandCollapsePanel7.Size = new System.Drawing.Size(318, 37);
            this.expandCollapsePanel7.TabIndex = 108;
            this.expandCollapsePanel7.Text = "Filter";
            this.expandCollapsePanel7.UseAnimation = true;
            // 
            // ProjectFilter2
            // 
            this.ProjectFilter2.AllowDrop = true;
            this.ProjectFilter2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter2.BackColor = System.Drawing.Color.Transparent;
            this.ProjectFilter2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ProjectFilter2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter2.CausesValidation = false;
            this.ProjectFilter2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ProjectFilter2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectFilter2.FormattingEnabled = true;
            this.ProjectFilter2.ItemHeight = 30;
            this.ProjectFilter2.Location = new System.Drawing.Point(15, 267);
            this.ProjectFilter2.Name = "ProjectFilter2";
            this.ProjectFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter2.Size = new System.Drawing.Size(286, 36);
            this.ProjectFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter2.StyleManager = null;
            this.ProjectFilter2.TabIndex = 0;
            this.ProjectFilter2.ThemeAuthor = "Narwin";
            this.ProjectFilter2.ThemeName = "MetroDark";
            // 
            // ProjectFilter1
            // 
            this.ProjectFilter1.AllowDrop = true;
            this.ProjectFilter1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ProjectFilter1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ProjectFilter1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter1.CausesValidation = false;
            this.ProjectFilter1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ProjectFilter1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectFilter1.FormattingEnabled = true;
            this.ProjectFilter1.ItemHeight = 30;
            this.ProjectFilter1.Location = new System.Drawing.Point(15, 113);
            this.ProjectFilter1.MaxDropDownItems = 20;
            this.ProjectFilter1.Name = "ProjectFilter1";
            this.ProjectFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter1.Size = new System.Drawing.Size(286, 36);
            this.ProjectFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter1.StyleManager = null;
            this.ProjectFilter1.TabIndex = 0;
            this.ProjectFilter1.Tag = "ProgramProjectName";
            this.ProjectFilter1.ThemeAuthor = "Narwin";
            this.ProjectFilter1.ThemeName = "MetroDark";
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
            this.ProjectChart.DataSourceName = "FundBindingSource";
            this.ProjectChart.Depth = 250F;
            this.ProjectChart.DisplayChartContextMenu = false;
            this.ProjectChart.DisplaySeriesContextMenu = false;
            this.ProjectChart.EnableMouseRotation = true;
            this.ProjectChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ProjectChart.Location = new System.Drawing.Point(20, 100);
            this.ProjectChart.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectChart.Name = "ProjectChart";
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
            this.ProjectChart.Series.Add(chartSeries15);
            this.ProjectChart.Series.Add(chartSeries16);
            this.ProjectChart.Series3D = true;
            this.ProjectChart.SeriesHighlight = true;
            this.ProjectChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ProjectChart.Size = new System.Drawing.Size(1204, 720);
            this.ProjectChart.Spacing = 5F;
            this.ProjectChart.SpacingBetweenPoints = 5F;
            this.ProjectChart.Style3D = true;
            this.ProjectChart.TabIndex = 43;
            this.ProjectChart.Tilt = 15F;
            // 
            // 
            // 
            this.ProjectChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ProjectChart.Title.Name = "Default";
            this.ProjectChart.ToolBar.EnableDefaultItems = false;
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.Controls.Add(this.groupBox5);
            this.DatabaseTab.Controls.Add(this.groupBox1);
            this.DatabaseTab.Controls.Add(this.FilterGroupBox);
            this.DatabaseTab.Image = null;
            this.DatabaseTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DatabaseTab.Location = new System.Drawing.Point(1, 34);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.ShowCloseButton = true;
            this.DatabaseTab.Size = new System.Drawing.Size(1586, 884);
            this.DatabaseTab.TabIndex = 9;
            this.DatabaseTab.Tag = "Database";
            this.DatabaseTab.Text = "Database";
            this.DatabaseTab.ThemesEnabled = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox5.Controls.Add(this.tabControlAdv1);
            this.groupBox5.Controls.Add(this.Navigator);
            this.groupBox5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox5.Location = new System.Drawing.Point(1129, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 508);
            this.groupBox5.TabIndex = 161;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account Manager";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.Black;
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlAdv1.AdjustTopGap = 5;
            this.tabControlAdv1.BackColor = System.Drawing.Color.Black;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(437, 396);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.BorderWidth = 1;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Gray;
            this.tabControlAdv1.Location = new System.Drawing.Point(6, 52);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.tabControlAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(437, 396);
            this.tabControlAdv1.TabIndex = 150;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.Black;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.metroSetLabel1);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel2);
            this.tabPageAdv1.Controls.Add(this.metroSetTextBox1);
            this.tabPageAdv1.Controls.Add(this.Amount);
            this.tabPageAdv1.Controls.Add(this.Code);
            this.tabPageAdv1.Controls.Add(this.BOC);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel12);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel13);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel14);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel16);
            this.tabPageAdv1.Controls.Add(this.RC);
            this.tabPageAdv1.Controls.Add(this.Fund);
            this.tabPageAdv1.Controls.Add(this.metroSetButton3);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel17);
            this.tabPageAdv1.Controls.Add(this.metroSetButton4);
            this.tabPageAdv1.Controls.Add(this.metroSetLabel18);
            this.tabPageAdv1.Controls.Add(this.BFY);
            this.tabPageAdv1.Controls.Add(this.Org);
            this.tabPageAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(433, 393);
            this.tabPageAdv1.TabIndex = 4;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(254, 99);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 139;
            this.metroSetLabel1.Text = "Code";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(137, 99);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 138;
            this.metroSetLabel2.Text = "BOC";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(14, 297);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(185, 30);
            this.metroSetTextBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 137;
            this.metroSetTextBox1.Text = "metroSetTextBox8";
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
            // 
            // Amount
            // 
            this.Amount.AutoCompleteCustomSource = null;
            this.Amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Amount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Amount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Amount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Amount.Image = null;
            this.Amount.Lines = null;
            this.Amount.Location = new System.Drawing.Point(14, 217);
            this.Amount.MaxLength = 32767;
            this.Amount.Multiline = false;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = false;
            this.Amount.Size = new System.Drawing.Size(185, 30);
            this.Amount.Style = MetroSet_UI.Design.Style.Dark;
            this.Amount.StyleManager = null;
            this.Amount.TabIndex = 136;
            this.Amount.Text = "metroSetTextBox7";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Amount.ThemeAuthor = "Narwin";
            this.Amount.ThemeName = "MetroDark";
            this.Amount.UseSystemPasswordChar = false;
            this.Amount.WatermarkText = "";
            // 
            // Code
            // 
            this.Code.AutoCompleteCustomSource = null;
            this.Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Code.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Code.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Code.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Code.Image = null;
            this.Code.Lines = null;
            this.Code.Location = new System.Drawing.Point(254, 128);
            this.Code.MaxLength = 32767;
            this.Code.Multiline = false;
            this.Code.Name = "Code";
            this.Code.ReadOnly = false;
            this.Code.Size = new System.Drawing.Size(145, 30);
            this.Code.Style = MetroSet_UI.Design.Style.Dark;
            this.Code.StyleManager = null;
            this.Code.TabIndex = 135;
            this.Code.Text = "metroSetTextBox4";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Code.ThemeAuthor = "Narwin";
            this.Code.ThemeName = "MetroDark";
            this.Code.UseSystemPasswordChar = false;
            this.Code.WatermarkText = "";
            // 
            // BOC
            // 
            this.BOC.AutoCompleteCustomSource = null;
            this.BOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BOC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BOC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BOC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BOC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BOC.Image = null;
            this.BOC.Lines = null;
            this.BOC.Location = new System.Drawing.Point(137, 128);
            this.BOC.MaxLength = 32767;
            this.BOC.Multiline = false;
            this.BOC.Name = "BOC";
            this.BOC.ReadOnly = false;
            this.BOC.Size = new System.Drawing.Size(89, 30);
            this.BOC.Style = MetroSet_UI.Design.Style.Dark;
            this.BOC.StyleManager = null;
            this.BOC.TabIndex = 134;
            this.BOC.Text = "metroSetTextBox3";
            this.BOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BOC.ThemeAuthor = "Narwin";
            this.BOC.ThemeName = "MetroDark";
            this.BOC.UseSystemPasswordChar = false;
            this.BOC.WatermarkText = "";
            // 
            // metroSetLabel12
            // 
            this.metroSetLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel12.Location = new System.Drawing.Point(14, 268);
            this.metroSetLabel12.Name = "metroSetLabel12";
            this.metroSetLabel12.Size = new System.Drawing.Size(146, 23);
            this.metroSetLabel12.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel12.StyleManager = null;
            this.metroSetLabel12.TabIndex = 133;
            this.metroSetLabel12.Text = "New Amount\r\n\r\n";
            this.metroSetLabel12.ThemeAuthor = "Narwin";
            this.metroSetLabel12.ThemeName = "MetroDark";
            // 
            // metroSetLabel13
            // 
            this.metroSetLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel13.Location = new System.Drawing.Point(14, 191);
            this.metroSetLabel13.Name = "metroSetLabel13";
            this.metroSetLabel13.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel13.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel13.StyleManager = null;
            this.metroSetLabel13.TabIndex = 132;
            this.metroSetLabel13.Text = "Amount\r\n";
            this.metroSetLabel13.ThemeAuthor = "Narwin";
            this.metroSetLabel13.ThemeName = "MetroDark";
            // 
            // metroSetLabel14
            // 
            this.metroSetLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel14.Location = new System.Drawing.Point(146, 17);
            this.metroSetLabel14.Name = "metroSetLabel14";
            this.metroSetLabel14.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel14.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel14.StyleManager = null;
            this.metroSetLabel14.TabIndex = 131;
            this.metroSetLabel14.Text = "Fund";
            this.metroSetLabel14.ThemeAuthor = "Narwin";
            this.metroSetLabel14.ThemeName = "MetroDark";
            // 
            // metroSetLabel16
            // 
            this.metroSetLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel16.Location = new System.Drawing.Point(14, 99);
            this.metroSetLabel16.Name = "metroSetLabel16";
            this.metroSetLabel16.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel16.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel16.StyleManager = null;
            this.metroSetLabel16.TabIndex = 130;
            this.metroSetLabel16.Text = "RC";
            this.metroSetLabel16.ThemeAuthor = "Narwin";
            this.metroSetLabel16.ThemeName = "MetroDark";
            // 
            // RC
            // 
            this.RC.AutoCompleteCustomSource = null;
            this.RC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.RC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.RC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.RC.Image = null;
            this.RC.Lines = null;
            this.RC.Location = new System.Drawing.Point(14, 128);
            this.RC.MaxLength = 32767;
            this.RC.Multiline = false;
            this.RC.Name = "RC";
            this.RC.ReadOnly = false;
            this.RC.Size = new System.Drawing.Size(84, 30);
            this.RC.Style = MetroSet_UI.Design.Style.Dark;
            this.RC.StyleManager = null;
            this.RC.TabIndex = 129;
            this.RC.Text = "metroSetTextBox2";
            this.RC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RC.ThemeAuthor = "Narwin";
            this.RC.ThemeName = "MetroDark";
            this.RC.UseSystemPasswordChar = false;
            this.RC.WatermarkText = "";
            // 
            // Fund
            // 
            this.Fund.AutoCompleteCustomSource = null;
            this.Fund.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Fund.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Fund.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Fund.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Fund.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fund.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fund.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Fund.Image = null;
            this.Fund.Lines = null;
            this.Fund.Location = new System.Drawing.Point(146, 43);
            this.Fund.MaxLength = 32767;
            this.Fund.Multiline = false;
            this.Fund.Name = "Fund";
            this.Fund.ReadOnly = false;
            this.Fund.Size = new System.Drawing.Size(94, 30);
            this.Fund.Style = MetroSet_UI.Design.Style.Dark;
            this.Fund.StyleManager = null;
            this.Fund.TabIndex = 128;
            this.Fund.Text = "metroSetTextBox1";
            this.Fund.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Fund.ThemeAuthor = "Narwin";
            this.Fund.ThemeName = "MetroDark";
            this.Fund.UseSystemPasswordChar = false;
            this.Fund.WatermarkText = "";
            // 
            // metroSetButton3
            // 
            this.metroSetButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Location = new System.Drawing.Point(275, 297);
            this.metroSetButton3.Name = "metroSetButton3";
            this.metroSetButton3.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton3.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton3.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton3.Size = new System.Drawing.Size(101, 45);
            this.metroSetButton3.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton3.StyleManager = null;
            this.metroSetButton3.TabIndex = 127;
            this.metroSetButton3.Text = "Update";
            this.metroSetButton3.ThemeAuthor = "Narwin";
            this.metroSetButton3.ThemeName = "MetroLite";
            // 
            // metroSetLabel17
            // 
            this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel17.Location = new System.Drawing.Point(14, 17);
            this.metroSetLabel17.Name = "metroSetLabel17";
            this.metroSetLabel17.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel17.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel17.StyleManager = null;
            this.metroSetLabel17.TabIndex = 16;
            this.metroSetLabel17.Text = "Year";
            this.metroSetLabel17.ThemeAuthor = "Narwin";
            this.metroSetLabel17.ThemeName = "MetroDark";
            // 
            // metroSetButton4
            // 
            this.metroSetButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton4.Location = new System.Drawing.Point(275, 217);
            this.metroSetButton4.Name = "metroSetButton4";
            this.metroSetButton4.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton4.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton4.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton4.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton4.Size = new System.Drawing.Size(101, 42);
            this.metroSetButton4.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton4.StyleManager = null;
            this.metroSetButton4.TabIndex = 126;
            this.metroSetButton4.Text = "Delete";
            this.metroSetButton4.ThemeAuthor = "Narwin";
            this.metroSetButton4.ThemeName = "MetroLite";
            // 
            // metroSetLabel18
            // 
            this.metroSetLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel18.Location = new System.Drawing.Point(287, 17);
            this.metroSetLabel18.Name = "metroSetLabel18";
            this.metroSetLabel18.Size = new System.Drawing.Size(89, 23);
            this.metroSetLabel18.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel18.StyleManager = null;
            this.metroSetLabel18.TabIndex = 17;
            this.metroSetLabel18.Text = "AH/Org";
            this.metroSetLabel18.ThemeAuthor = "Narwin";
            this.metroSetLabel18.ThemeName = "MetroDark";
            // 
            // BFY
            // 
            this.BFY.AutoCompleteCustomSource = null;
            this.BFY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BFY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BFY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BFY.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BFY.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BFY.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFY.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BFY.Image = null;
            this.BFY.Lines = null;
            this.BFY.Location = new System.Drawing.Point(14, 43);
            this.BFY.MaxLength = 32767;
            this.BFY.Multiline = false;
            this.BFY.Name = "BFY";
            this.BFY.ReadOnly = false;
            this.BFY.Size = new System.Drawing.Size(83, 30);
            this.BFY.Style = MetroSet_UI.Design.Style.Dark;
            this.BFY.StyleManager = null;
            this.BFY.TabIndex = 125;
            this.BFY.Text = "metroSetTextBox6";
            this.BFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BFY.ThemeAuthor = "Narwin";
            this.BFY.ThemeName = "MetroDark";
            this.BFY.UseSystemPasswordChar = false;
            this.BFY.WatermarkText = "";
            // 
            // Org
            // 
            this.Org.AutoCompleteCustomSource = null;
            this.Org.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Org.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Org.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Org.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Org.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Org.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Org.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Org.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Org.Image = null;
            this.Org.Lines = null;
            this.Org.Location = new System.Drawing.Point(287, 43);
            this.Org.MaxLength = 32767;
            this.Org.Multiline = false;
            this.Org.Name = "Org";
            this.Org.ReadOnly = false;
            this.Org.Size = new System.Drawing.Size(89, 30);
            this.Org.Style = MetroSet_UI.Design.Style.Dark;
            this.Org.StyleManager = null;
            this.Org.TabIndex = 124;
            this.Org.Text = "metroSetTextBox5";
            this.Org.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Org.ThemeAuthor = "Narwin";
            this.Org.ThemeName = "MetroDark";
            this.Org.UseSystemPasswordChar = false;
            this.Org.WatermarkText = "";
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.PrcChart);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(433, 393);
            this.tabPageAdv5.TabIndex = 2;
            this.tabPageAdv5.Text = "tabPageAdv5";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // PrcChart
            // 
            this.PrcChart.AllowGradientPalette = true;
            this.PrcChart.AllowUserEditStyles = true;
            this.PrcChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.PrcChart.ChartArea.AutoScale = true;
            this.PrcChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
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
            this.PrcChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrcChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrcChart.HighlightSymbol = true;
            this.PrcChart.IsWindowLess = false;
            // 
            // 
            // 
            this.PrcChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.PrcChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrcChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.PrcChart.PrimaryXAxis.Margin = true;
            this.PrcChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.PrcChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.PrcChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            chartSeries17.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries17.Name = "Default0";
            chartSeries17.Points.Add(1D, ((double)(55D)));
            chartSeries17.Points.Add(2D, ((double)(70D)));
            chartSeries17.Points.Add(3D, ((double)(80D)));
            chartSeries17.Points.Add(4D, ((double)(65D)));
            chartSeries17.Points.Add(5D, ((double)(75D)));
            chartSeries17.Resolution = 0D;
            chartSeries17.StackingGroup = "Default Group";
            chartSeries17.Style.AltTagFormat = "";
            chartSeries17.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries17.Style.DrawTextShape = false;
            chartSeries17.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo9.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo9.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo9.DashPattern = null;
            chartLineInfo9.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo9.Width = 1F;
            chartCustomShapeInfo17.Border = chartLineInfo9;
            chartCustomShapeInfo17.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo17.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries17.Style.TextShape = chartCustomShapeInfo17;
            chartSeries17.Text = "Default0";
            chartSeries17.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            chartSeries18.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries18.Name = "Default1";
            chartSeries18.Points.Add(1D, ((double)(70D)));
            chartSeries18.Points.Add(2D, ((double)(35D)));
            chartSeries18.Points.Add(3D, ((double)(65D)));
            chartSeries18.Points.Add(4D, ((double)(25D)));
            chartSeries18.Points.Add(5D, ((double)(50D)));
            chartSeries18.Resolution = 0D;
            chartSeries18.StackingGroup = "Default Group";
            chartSeries18.Style.AltTagFormat = "";
            chartSeries18.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries18.Style.DrawTextShape = false;
            chartSeries18.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo18.Border = chartLineInfo9;
            chartCustomShapeInfo18.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo18.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries18.Style.TextShape = chartCustomShapeInfo18;
            chartSeries18.Text = "Default1";
            chartSeries18.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            this.PrcChart.Series.Add(chartSeries17);
            this.PrcChart.Series.Add(chartSeries18);
            this.PrcChart.Series3D = true;
            this.PrcChart.SeriesHighlight = true;
            this.PrcChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.PrcChart.Size = new System.Drawing.Size(433, 393);
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
            this.PrcChart.ToolBar.Items.Add(chartToolBarSaveItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarCopyItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPaletteItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarTypeItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSeries3DItem9);
            this.PrcChart.ToolBar.Items.Add(chartToolBarShowLegendItem9);
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.Black;
            this.tabPageAdv6.Controls.Add(this.calculatorControl2);
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv6.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(433, 393);
            this.tabPageAdv6.TabIndex = 3;
            this.tabPageAdv6.Text = "tabPageAdv6";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // calculatorControl2
            // 
            this.calculatorControl2.AccessibleDescription = "Calculator control";
            this.calculatorControl2.AccessibleName = "Calculator Control";
            this.calculatorControl2.BeforeTouchSize = new System.Drawing.Size(325, 288);
            this.calculatorControl2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl2.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl2.DisplayTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calculatorControl2.DoubleValue = 0D;
            this.calculatorControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl2.HorizontalSpacing = 8;
            this.calculatorControl2.Location = new System.Drawing.Point(41, 50);
            this.calculatorControl2.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl2.Name = "calculatorControl2";
            this.calculatorControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl2.Size = new System.Drawing.Size(325, 288);
            this.calculatorControl2.TabIndex = 0;
            this.calculatorControl2.Text = "calculatorControl2";
            this.calculatorControl2.UseVisualStyle = true;
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = this.toolStripButton7;
            this.Navigator.BackColor = System.Drawing.Color.Transparent;
            this.Navigator.CountItem = this.toolStripLabel2;
            this.Navigator.DeleteItem = null;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navigator.ImageScalingSize = new System.Drawing.Size(30, 20);
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripSeparator3,
            this.toolStripButton10,
            this.toolStripSeparator10,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripSeparator12,
            this.toolStripButton12,
            this.toolStripSeparator13,
            this.toolStripButton13,
            this.toolStripSeparator14,
            this.toolStripButton7,
            this.toolStripSeparator15,
            this.toolStripSeparator16});
            this.Navigator.Location = new System.Drawing.Point(3, 474);
            this.Navigator.MoveFirstItem = this.toolStripButton9;
            this.Navigator.MoveLastItem = this.toolStripButton12;
            this.Navigator.MoveNextItem = this.toolStripButton11;
            this.Navigator.MovePreviousItem = this.toolStripButton10;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.toolStripTextBox2;
            this.Navigator.Size = new System.Drawing.Size(440, 31);
            this.Navigator.TabIndex = 152;
            this.Navigator.Text = "bindingNavigator1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton7.Text = "Add New";
            this.toolStripButton7.ToolTipText = "Add New";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 28);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(44, 28);
            this.toolStripButton9.Text = "First";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton10.Text = "Previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(42, 31);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton11.Text = "Next";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(42, 28);
            this.toolStripButton12.Text = "Last";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton13.Text = "toolStripButton8";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 31);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.ReturnButton);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.metroSetLabel9);
            this.groupBox1.Controls.Add(this.metroSetLabel8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(258, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(850, 504);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid.Location = new System.Drawing.Point(19, 88);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(810, 342);
            this.Grid.TabIndex = 150;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCount.Location = new System.Drawing.Point(393, 38);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(102, 23);
            this.lblCount.Style = MetroSet_UI.Design.Style.Dark;
            this.lblCount.StyleManager = null;
            this.lblCount.TabIndex = 149;
            this.lblCount.Text = "metroSetLabel2";
            this.lblCount.ThemeAuthor = "Narwin";
            this.lblCount.ThemeName = "MetroDark";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Image")));
            this.ReturnButton.Location = new System.Drawing.Point(729, 23);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(42, 32);
            this.ReturnButton.TabIndex = 147;
            this.ReturnButton.UseSelectable = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(102, 38);
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
            this.metroSetLabel9.Location = new System.Drawing.Point(284, 38);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(103, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 17;
            this.metroSetLabel9.Text = "Accounts:";
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroDark";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.Location = new System.Drawing.Point(32, 38);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(64, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 16;
            this.metroSetLabel8.Text = "Total:";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroDark";
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FilterGroupBox.Controls.Add(this.CodeFilter);
            this.FilterGroupBox.Controls.Add(this.BocFilter);
            this.FilterGroupBox.Controls.Add(this.FundFilter);
            this.FilterGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FilterGroupBox.Location = new System.Drawing.Point(11, 125);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(233, 506);
            this.FilterGroupBox.TabIndex = 160;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // CodeFilter
            // 
            this.CodeFilter.AllowDrop = true;
            this.CodeFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.CodeFilter.BackColor = System.Drawing.Color.Transparent;
            this.CodeFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CodeFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.CodeFilter.CausesValidation = false;
            this.CodeFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CodeFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CodeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CodeFilter.FormattingEnabled = true;
            this.CodeFilter.ItemHeight = 30;
            this.CodeFilter.Location = new System.Drawing.Point(15, 281);
            this.CodeFilter.MaxDropDownItems = 50;
            this.CodeFilter.Name = "CodeFilter";
            this.CodeFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CodeFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.CodeFilter.Size = new System.Drawing.Size(197, 36);
            this.CodeFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.CodeFilter.StyleManager = null;
            this.CodeFilter.TabIndex = 4;
            this.CodeFilter.ThemeAuthor = "Narwin";
            this.CodeFilter.ThemeName = "MetroDark";
            // 
            // BocFilter
            // 
            this.BocFilter.AllowDrop = true;
            this.BocFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter.BackColor = System.Drawing.Color.Transparent;
            this.BocFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BocFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter.CausesValidation = false;
            this.BocFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BocFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BocFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter.FormattingEnabled = true;
            this.BocFilter.ItemHeight = 30;
            this.BocFilter.Location = new System.Drawing.Point(15, 180);
            this.BocFilter.Name = "BocFilter";
            this.BocFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter.Size = new System.Drawing.Size(197, 36);
            this.BocFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter.StyleManager = null;
            this.BocFilter.TabIndex = 3;
            this.BocFilter.ThemeAuthor = "Narwin";
            this.BocFilter.ThemeName = "MetroDark";
            // 
            // FundFilter
            // 
            this.FundFilter.AllowDrop = true;
            this.FundFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter.BackColor = System.Drawing.Color.Transparent;
            this.FundFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FundFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter.CausesValidation = false;
            this.FundFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FundFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FundFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter.FormattingEnabled = true;
            this.FundFilter.ItemHeight = 30;
            this.FundFilter.Location = new System.Drawing.Point(15, 90);
            this.FundFilter.MaxDropDownItems = 15;
            this.FundFilter.Name = "FundFilter";
            this.FundFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter.Size = new System.Drawing.Size(197, 36);
            this.FundFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter.StyleManager = null;
            this.FundFilter.TabIndex = 2;
            this.FundFilter.ThemeAuthor = "Narwin";
            this.FundFilter.ThemeName = "MetroDark";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
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
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
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
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(42, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.toolStripButton5.Size = new System.Drawing.Size(34, 28);
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
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Ninja.Properties.Resources.Save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolstripitem1
            // 
            this.toolstripitem1.Name = "toolstripitem1";
            this.toolstripitem1.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem1.Text = "toolstripitem1";
            // 
            // toolstripitem2
            // 
            this.toolstripitem2.Name = "toolstripitem2";
            this.toolstripitem2.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem2.Text = "toolstripitem2";
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.Black;
            this.tabPageAdv4.Controls.Add(this.calculatorControl1);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(0, -1);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(400, 422);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "tabPageAdv4";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(325, 288);
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DisplayTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.HorizontalSpacing = 8;
            this.calculatorControl1.Location = new System.Drawing.Point(41, 50);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(325, 288);
            this.calculatorControl1.TabIndex = 0;
            this.calculatorControl1.Text = "calculatorControl1";
            this.calculatorControl1.UseVisualStyle = true;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.chartControl1);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(0, -1);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(400, 422);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "tabPageAdv3";
            this.tabPageAdv3.ThemesEnabled = false;
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
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.Depth = 250F;
            this.chartControl1.DisplayChartContextMenu = false;
            this.chartControl1.DisplaySeriesContextMenu = false;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.EnableMouseRotation = true;
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.Color.LightSteelBlue;
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
            this.chartControl1.Rotation = 20F;
            chartSeries19.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries19.Name = "Default0";
            chartSeries19.Points.Add(1D, ((double)(55D)));
            chartSeries19.Points.Add(2D, ((double)(70D)));
            chartSeries19.Points.Add(3D, ((double)(80D)));
            chartSeries19.Points.Add(4D, ((double)(65D)));
            chartSeries19.Points.Add(5D, ((double)(75D)));
            chartSeries19.Resolution = 0D;
            chartSeries19.StackingGroup = "Default Group";
            chartSeries19.Style.AltTagFormat = "";
            chartSeries19.Style.Border.Color = System.Drawing.Color.Transparent;
            chartSeries19.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries19.Style.DrawTextShape = false;
            chartSeries19.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo10.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo10.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo10.DashPattern = null;
            chartLineInfo10.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo10.Width = 1F;
            chartCustomShapeInfo19.Border = chartLineInfo10;
            chartCustomShapeInfo19.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo19.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries19.Style.TextShape = chartCustomShapeInfo19;
            chartSeries19.Text = "Default0";
            chartSeries19.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            chartSeries20.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries20.Name = "Default1";
            chartSeries20.Points.Add(1D, ((double)(70D)));
            chartSeries20.Points.Add(2D, ((double)(35D)));
            chartSeries20.Points.Add(3D, ((double)(65D)));
            chartSeries20.Points.Add(4D, ((double)(25D)));
            chartSeries20.Points.Add(5D, ((double)(50D)));
            chartSeries20.Resolution = 0D;
            chartSeries20.StackingGroup = "Default Group";
            chartSeries20.Style.AltTagFormat = "";
            chartSeries20.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries20.Style.DrawTextShape = false;
            chartSeries20.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo20.Border = chartLineInfo10;
            chartCustomShapeInfo20.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo20.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries20.Style.TextShape = chartCustomShapeInfo20;
            chartSeries20.Text = "Default1";
            chartSeries20.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            this.chartControl1.Series.Add(chartSeries19);
            this.chartControl1.Series.Add(chartSeries20);
            this.chartControl1.Series3D = true;
            this.chartControl1.SeriesHighlight = true;
            this.chartControl1.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.chartControl1.Size = new System.Drawing.Size(400, 422);
            this.chartControl1.Spacing = 5F;
            this.chartControl1.SpacingBetweenPoints = 5F;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 46;
            this.chartControl1.Tilt = 25F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem10);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem10);
            // 
            // chartTitle1
            // 
            this.chartTitle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.Text = "chartTitle1";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.dd);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox2);
            this.tabPageAdv2.Controls.Add(this.rcc);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel11);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel7);
            this.tabPageAdv2.Controls.Add(this.Amount2);
            this.tabPageAdv2.Controls.Add(this.Amount1);
            this.tabPageAdv2.Controls.Add(this.cd);
            this.tabPageAdv2.Controls.Add(this.bb);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel6);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel5);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel4);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel3);
            this.tabPageAdv2.Controls.Add(this.ff);
            this.tabPageAdv2.Controls.Add(this.metroSetButton2);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel10);
            this.tabPageAdv2.Controls.Add(this.metroSetButton1);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel15);
            this.tabPageAdv2.Controls.Add(this.yy);
            this.tabPageAdv2.Controls.Add(this.o);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(0, -1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(400, 422);
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // dd
            // 
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dd.Location = new System.Drawing.Point(21, 42);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(62, 23);
            this.dd.Style = MetroSet_UI.Design.Style.Dark;
            this.dd.StyleManager = null;
            this.dd.TabIndex = 142;
            this.dd.Text = "ID";
            this.dd.ThemeAuthor = "Narwin";
            this.dd.ThemeName = "MetroDark";
            // 
            // metroSetTextBox2
            // 
            this.metroSetTextBox2.AutoCompleteCustomSource = null;
            this.metroSetTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox2.Image = null;
            this.metroSetTextBox2.Lines = null;
            this.metroSetTextBox2.Location = new System.Drawing.Point(21, 76);
            this.metroSetTextBox2.MaxLength = 32767;
            this.metroSetTextBox2.Multiline = false;
            this.metroSetTextBox2.Name = "metroSetTextBox2";
            this.metroSetTextBox2.ReadOnly = false;
            this.metroSetTextBox2.Size = new System.Drawing.Size(66, 30);
            this.metroSetTextBox2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox2.StyleManager = null;
            this.metroSetTextBox2.TabIndex = 141;
            this.metroSetTextBox2.Text = "metroSetTextBox2";
            this.metroSetTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox2.ThemeAuthor = "Narwin";
            this.metroSetTextBox2.ThemeName = "MetroDark";
            this.metroSetTextBox2.UseSystemPasswordChar = false;
            this.metroSetTextBox2.WatermarkText = "";
            // 
            // rcc
            // 
            this.rcc.AutoCompleteCustomSource = null;
            this.rcc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rcc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.rcc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rcc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rcc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcc.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rcc.Image = null;
            this.rcc.Lines = null;
            this.rcc.Location = new System.Drawing.Point(21, 165);
            this.rcc.MaxLength = 32767;
            this.rcc.Multiline = false;
            this.rcc.Name = "rcc";
            this.rcc.ReadOnly = false;
            this.rcc.Size = new System.Drawing.Size(86, 30);
            this.rcc.Style = MetroSet_UI.Design.Style.Dark;
            this.rcc.StyleManager = null;
            this.rcc.TabIndex = 140;
            this.rcc.Text = "metroSetTextBox1";
            this.rcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rcc.ThemeAuthor = "Narwin";
            this.rcc.ThemeName = "MetroDark";
            this.rcc.UseSystemPasswordChar = false;
            this.rcc.WatermarkText = "";
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel11.Location = new System.Drawing.Point(244, 161);
            this.metroSetLabel11.Name = "metroSetLabel11";
            this.metroSetLabel11.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel11.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel11.StyleManager = null;
            this.metroSetLabel11.TabIndex = 139;
            this.metroSetLabel11.Text = "Code";
            this.metroSetLabel11.ThemeAuthor = "Narwin";
            this.metroSetLabel11.ThemeName = "MetroDark";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.Location = new System.Drawing.Point(136, 161);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 138;
            this.metroSetLabel7.Text = "BOC";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroDark";
            // 
            // Amount2
            // 
            this.Amount2.AutoCompleteCustomSource = null;
            this.Amount2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Amount2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Amount2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Amount2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Amount2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Amount2.Image = null;
            this.Amount2.Lines = null;
            this.Amount2.Location = new System.Drawing.Point(21, 321);
            this.Amount2.MaxLength = 32767;
            this.Amount2.Multiline = false;
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = false;
            this.Amount2.Size = new System.Drawing.Size(159, 30);
            this.Amount2.Style = MetroSet_UI.Design.Style.Dark;
            this.Amount2.StyleManager = null;
            this.Amount2.TabIndex = 137;
            this.Amount2.Text = "metroSetTextBox8";
            this.Amount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Amount2.ThemeAuthor = "Narwin";
            this.Amount2.ThemeName = "MetroDark";
            this.Amount2.UseSystemPasswordChar = false;
            this.Amount2.WatermarkText = "";
            // 
            // Amount1
            // 
            this.Amount1.AutoCompleteCustomSource = null;
            this.Amount1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Amount1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Amount1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Amount1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Amount1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Amount1.Image = null;
            this.Amount1.Lines = null;
            this.Amount1.Location = new System.Drawing.Point(21, 246);
            this.Amount1.MaxLength = 32767;
            this.Amount1.Multiline = false;
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = false;
            this.Amount1.Size = new System.Drawing.Size(159, 30);
            this.Amount1.Style = MetroSet_UI.Design.Style.Dark;
            this.Amount1.StyleManager = null;
            this.Amount1.TabIndex = 136;
            this.Amount1.Text = "metroSetTextBox7";
            this.Amount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Amount1.ThemeAuthor = "Narwin";
            this.Amount1.ThemeName = "MetroDark";
            this.Amount1.UseSystemPasswordChar = false;
            this.Amount1.WatermarkText = "";
            // 
            // cd
            // 
            this.cd.AutoCompleteCustomSource = null;
            this.cd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cd.Image = null;
            this.cd.Lines = null;
            this.cd.Location = new System.Drawing.Point(251, 165);
            this.cd.MaxLength = 32767;
            this.cd.Multiline = false;
            this.cd.Name = "cd";
            this.cd.ReadOnly = false;
            this.cd.Size = new System.Drawing.Size(132, 30);
            this.cd.Style = MetroSet_UI.Design.Style.Dark;
            this.cd.StyleManager = null;
            this.cd.TabIndex = 135;
            this.cd.Text = "metroSetTextBox4";
            this.cd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cd.ThemeAuthor = "Narwin";
            this.cd.ThemeName = "MetroDark";
            this.cd.UseSystemPasswordChar = false;
            this.cd.WatermarkText = "";
            // 
            // bb
            // 
            this.bb.AutoCompleteCustomSource = null;
            this.bb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bb.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bb.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bb.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bb.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bb.Image = null;
            this.bb.Lines = null;
            this.bb.Location = new System.Drawing.Point(136, 165);
            this.bb.MaxLength = 32767;
            this.bb.Multiline = false;
            this.bb.Name = "bb";
            this.bb.ReadOnly = false;
            this.bb.Size = new System.Drawing.Size(89, 30);
            this.bb.Style = MetroSet_UI.Design.Style.Dark;
            this.bb.StyleManager = null;
            this.bb.TabIndex = 134;
            this.bb.Text = "metroSetTextBox3";
            this.bb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bb.ThemeAuthor = "Narwin";
            this.bb.ThemeName = "MetroDark";
            this.bb.UseSystemPasswordChar = false;
            this.bb.WatermarkText = "";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.Location = new System.Drawing.Point(14, 326);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(146, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 133;
            this.metroSetLabel6.Text = "New Amount\r\n\r\n";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.Location = new System.Drawing.Point(14, 251);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 132;
            this.metroSetLabel5.Text = "Amount\r\n";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(194, 73);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 131;
            this.metroSetLabel4.Text = "Fund";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(14, 161);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 130;
            this.metroSetLabel3.Text = "RC";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // ff
            // 
            this.ff.AutoCompleteCustomSource = null;
            this.ff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ff.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ff.Image = null;
            this.ff.Lines = null;
            this.ff.Location = new System.Drawing.Point(185, 77);
            this.ff.MaxLength = 32767;
            this.ff.Multiline = false;
            this.ff.Name = "ff";
            this.ff.ReadOnly = false;
            this.ff.Size = new System.Drawing.Size(93, 30);
            this.ff.Style = MetroSet_UI.Design.Style.Dark;
            this.ff.StyleManager = null;
            this.ff.TabIndex = 128;
            this.ff.Text = "metroSetTextBox1";
            this.ff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ff.ThemeAuthor = "Narwin";
            this.ff.ThemeName = "MetroDark";
            this.ff.UseSystemPasswordChar = false;
            this.ff.WatermarkText = "";
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
            this.metroSetButton2.Location = new System.Drawing.Point(251, 310);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton2.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton2.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(101, 45);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 127;
            this.metroSetButton2.Text = "Update";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.Location = new System.Drawing.Point(93, 110);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 16;
            this.metroSetLabel10.Text = "Year";
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroDark";
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
            this.metroSetButton1.Location = new System.Drawing.Point(251, 238);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton1.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton1.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(101, 42);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 126;
            this.metroSetButton1.Text = "Delete";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            // 
            // metroSetLabel15
            // 
            this.metroSetLabel15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel15.Location = new System.Drawing.Point(294, 76);
            this.metroSetLabel15.Name = "metroSetLabel15";
            this.metroSetLabel15.Size = new System.Drawing.Size(101, 32);
            this.metroSetLabel15.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel15.StyleManager = null;
            this.metroSetLabel15.TabIndex = 17;
            this.metroSetLabel15.Text = "AH/Org";
            this.metroSetLabel15.ThemeAuthor = "Narwin";
            this.metroSetLabel15.ThemeName = "MetroDark";
            // 
            // yy
            // 
            this.yy.AutoCompleteCustomSource = null;
            this.yy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.yy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.yy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.yy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.yy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.yy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.yy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yy.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.yy.Image = null;
            this.yy.Lines = null;
            this.yy.Location = new System.Drawing.Point(93, 77);
            this.yy.MaxLength = 32767;
            this.yy.Multiline = false;
            this.yy.Name = "yy";
            this.yy.ReadOnly = false;
            this.yy.Size = new System.Drawing.Size(86, 30);
            this.yy.Style = MetroSet_UI.Design.Style.Dark;
            this.yy.StyleManager = null;
            this.yy.TabIndex = 125;
            this.yy.Text = "metroSetTextBox6";
            this.yy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.yy.ThemeAuthor = "Narwin";
            this.yy.ThemeName = "MetroDark";
            this.yy.UseSystemPasswordChar = false;
            this.yy.WatermarkText = "";
            // 
            // o
            // 
            this.o.AutoCompleteCustomSource = null;
            this.o.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.o.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.o.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.o.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.o.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.o.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.o.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.o.Image = null;
            this.o.Lines = null;
            this.o.Location = new System.Drawing.Point(294, 77);
            this.o.MaxLength = 32767;
            this.o.Multiline = false;
            this.o.Name = "o";
            this.o.ReadOnly = false;
            this.o.Size = new System.Drawing.Size(89, 30);
            this.o.Style = MetroSet_UI.Design.Style.Dark;
            this.o.StyleManager = null;
            this.o.TabIndex = 124;
            this.o.Text = "metroSetTextBox5";
            this.o.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.o.ThemeAuthor = "Narwin";
            this.o.ThemeName = "MetroDark";
            this.o.UseSystemPasswordChar = false;
            this.o.WatermarkText = "";
            // 
            // MiniTabControl1
            // 
            this.MiniTabControl1.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MiniTabControl1.BackColor = System.Drawing.Color.Black;
            this.MiniTabControl1.BeforeTouchSize = new System.Drawing.Size(400, 421);
            this.MiniTabControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiniTabControl1.BorderWidth = 1;
            this.MiniTabControl1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.Controls.Add(this.tabPageAdv2);
            this.MiniTabControl1.Controls.Add(this.tabPageAdv3);
            this.MiniTabControl1.Controls.Add(this.tabPageAdv4);
            this.MiniTabControl1.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.MiniTabControl1.FocusOnTabClick = false;
            this.MiniTabControl1.InActiveTabForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.Location = new System.Drawing.Point(29, 42);
            this.MiniTabControl1.Name = "MiniTabControl1";
            this.MiniTabControl1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.MiniTabControl1.ShowSeparator = false;
            this.MiniTabControl1.Size = new System.Drawing.Size(400, 421);
            this.MiniTabControl1.TabIndex = 150;
            this.MiniTabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 75;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1588, 919);
            this.Controls.Add(this.SummaryTabControl);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "SummaryForm";
            this.ShowIcon = false;
            this.Text = "SumForm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.FundTab.ResumeLayout(false);
            this.FundExpander.ResumeLayout(false);
            this.FundExpander.PerformLayout();
            this.BocTab.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.NpmTab.ResumeLayout(false);
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.GoalTab.ResumeLayout(false);
            this.expandCollapsePanel3.ResumeLayout(false);
            this.expandCollapsePanel3.PerformLayout();
            this.ObjectiveTab.ResumeLayout(false);
            this.expandCollapsePanel4.ResumeLayout(false);
            this.expandCollapsePanel4.PerformLayout();
            this.DivisionTab.ResumeLayout(false);
            this.expandCollapsePanel5.ResumeLayout(false);
            this.expandCollapsePanel5.PerformLayout();
            this.AreaTab.ResumeLayout(false);
            this.expandCollapsePanel6.ResumeLayout(false);
            this.expandCollapsePanel6.PerformLayout();
            this.ProjectTab.ResumeLayout(false);
            this.expandCollapsePanel7.ResumeLayout(false);
            this.expandCollapsePanel7.PerformLayout();
            this.DatabaseTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.FilterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).EndInit();
            this.MiniTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

                }

                #endregion

                private TabControlAdv SummaryTabControl;
                private TabPageAdv FundTab;
                private TabPageAdv BocTab;
                private TabPageAdv NpmTab;
                private TabPageAdv GoalTab;
                private TabPageAdv ObjectiveTab;
                private TabPageAdv DivisionTab;
                private TabPageAdv AreaTab;
                private TabPageAdv ProjectTab;
                protected ChartControl FundChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel FundExpander;
                protected ChartControl GoalChart;
                protected ChartControl ObjectiveChart;
                protected ChartControl DivisionChart;
                protected ChartControl AreaChart;
                protected ChartControl ProjectChart;
                private BindingSource BindingSource;
                protected ChartControl BocChart;
                protected ChartControl NpmChart;
                private toolstripitem toolstripitem1;
                private toolstripitem toolstripitem2;
                private TabPageAdv DatabaseTab;
                private GroupBox groupBox1;
                private DataGridView Grid;
                private MetroSetLabel lblCount;
                private MetroLink ReturnButton;
                private MetroSetLabel lblTotal;
                private MetroSetLabel metroSetLabel9;
                private MetroSetLabel metroSetLabel8;
                private ToolStripButton toolStripButton1;
                private ToolStripLabel toolStripLabel1;
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
                private ToolStripButton toolStripButton8;
                private ToolStripSeparator toolStripSeparator2;
                private ToolStripSeparator toolStripSeparator9;
                private GroupBox FilterGroupBox;
                private MetroSetComboBox CodeFilter;
                private MetroSetComboBox BocFilter;
                private MetroSetComboBox FundFilter;
                private ToolStripButton toolStripButton2;
                private ToolStripSeparator toolStripSeparator1;
                private TabPageAdv tabPageAdv4;
                private CalculatorControl calculatorControl1;
                private TabPageAdv tabPageAdv3;
                protected ChartControl chartControl1;
                private ChartTitle chartTitle1;
                private TabPageAdv tabPageAdv2;
                private MetroSetLabel dd;
                private MetroSetTextBox metroSetTextBox2;
                private MetroSetTextBox rcc;
                private MetroSetLabel metroSetLabel11;
                private MetroSetLabel metroSetLabel7;
                private MetroSetTextBox Amount2;
                private MetroSetTextBox Amount1;
                private MetroSetTextBox cd;
                private MetroSetTextBox bb;
                private MetroSetLabel metroSetLabel6;
                private MetroSetLabel metroSetLabel5;
                private MetroSetLabel metroSetLabel4;
                private MetroSetLabel metroSetLabel3;
                private MetroSetTextBox ff;
                private MetroSetButton metroSetButton2;
                private MetroSetLabel metroSetLabel10;
                private MetroSetButton metroSetButton1;
                private MetroSetLabel metroSetLabel15;
                private MetroSetTextBox yy;
                private MetroSetTextBox o;
                private TabControlAdv MiniTabControl1;
                private MetroSetComboBox FundFilter1;
                private MetroSetComboBox FundFilter2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MetroSetComboBox BocFilter2;
                private MetroSetComboBox BocFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
                private MetroSetComboBox NpmFilter2;
                private MetroSetComboBox NpmFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel3;
                private MetroSetComboBox GoalFilter2;
                private MetroSetComboBox GoalFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel4;
                private MetroSetComboBox ObjectiveFilter2;
                private MetroSetComboBox ObjectiveFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel5;
                private MetroSetComboBox DivisionFilter2;
                private MetroSetComboBox DivisionFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel6;
                private MetroSetComboBox AreaFilter2;
                private MetroSetComboBox AreaFilter1;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel7;
                private MetroSetComboBox ProjectFilter2;
                private MetroSetComboBox ProjectFilter1;
                private GroupBox groupBox5;
                private TabControlAdv tabControlAdv1;
                private TabPageAdv tabPageAdv1;
                private MetroSetLabel metroSetLabel1;
                private MetroSetLabel metroSetLabel2;
                private MetroSetTextBox metroSetTextBox1;
                private MetroSetTextBox Amount;
                private MetroSetTextBox Code;
                private MetroSetTextBox BOC;
                private MetroSetLabel metroSetLabel12;
                private MetroSetLabel metroSetLabel13;
                private MetroSetLabel metroSetLabel14;
                private MetroSetLabel metroSetLabel16;
                private MetroSetTextBox RC;
                private MetroSetTextBox Fund;
                private MetroSetButton metroSetButton3;
                private MetroSetLabel metroSetLabel17;
                private MetroSetButton metroSetButton4;
                private MetroSetLabel metroSetLabel18;
                private MetroSetTextBox BFY;
                private MetroSetTextBox Org;
                private TabPageAdv tabPageAdv5;
                protected ChartControl PrcChart;
                private TabPageAdv tabPageAdv6;
                private CalculatorControl calculatorControl2;
                private BindingNavigator Navigator;
                private ToolStripButton toolStripButton7;
                private ToolStripLabel toolStripLabel2;
                private ToolStripButton toolStripButton9;
                private ToolStripSeparator toolStripSeparator3;
                private ToolStripButton toolStripButton10;
                private ToolStripSeparator toolStripSeparator10;
                private ToolStripTextBox toolStripTextBox2;
                private ToolStripSeparator toolStripSeparator11;
                private ToolStripButton toolStripButton11;
                private ToolStripSeparator toolStripSeparator12;
                private ToolStripButton toolStripButton12;
                private ToolStripSeparator toolStripSeparator13;
                private ToolStripButton toolStripButton13;
                private ToolStripSeparator toolStripSeparator14;
                private ToolStripSeparator toolStripSeparator15;
                private ToolStripSeparator toolStripSeparator16;
            }
        }
    }
}