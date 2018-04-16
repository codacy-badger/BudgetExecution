
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem9 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivisionForm));
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
            this.TransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.FundTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.FundExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FundChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BocTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BocExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.NpmExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp3 = new System.Windows.Forms.FlowLayoutPanel();
            this.GoalTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.GoalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.GoalExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ObjectiveTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ObjectiveExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp5 = new System.Windows.Forms.FlowLayoutPanel();
            this.ObjectiveChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DivisionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.DivisionExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp6 = new System.Windows.Forms.FlowLayoutPanel();
            this.DivisionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.AreaTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AreaChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.AreaExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp7 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ProjectChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ProjectExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.fp8 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ReturnButton = new MetroFramework.Controls.MetroLink();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MiniTabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.amount2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.amount1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox3 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox4 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel15 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox5 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox6 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.AccountMangerGroupBox.SuspendLayout();
            this.PrcPanel.SuspendLayout();
            this.DatabaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).BeginInit();
            this.SummaryTabControl.SuspendLayout();
            this.FundTab.SuspendLayout();
            this.panel13.SuspendLayout();
            this.FundExpander.SuspendLayout();
            this.BocTab.SuspendLayout();
            this.BocExpander.SuspendLayout();
            this.NpmTab.SuspendLayout();
            this.NpmExpander.SuspendLayout();
            this.GoalTab.SuspendLayout();
            this.GoalExpander.SuspendLayout();
            this.ObjectiveTab.SuspendLayout();
            this.ObjectiveExpander.SuspendLayout();
            this.DivisionTab.SuspendLayout();
            this.DivisionExpander.SuspendLayout();
            this.AreaTab.SuspendLayout();
            this.AreaExpander.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.ProjectExpander.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).BeginInit();
            this.MiniTabControl1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransferBindingSource
            // 
            this.TransferBindingSource.DataMember = "T7";
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
            this.PrcChart.Series.Add(chartSeries1);
            this.PrcChart.Series.Add(chartSeries2);
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
            this.PrcChart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSplitter1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.PrcChart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
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
            this.SummaryTabControl.Controls.Add(this.tabPageAdv1);
            this.SummaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.Gray;
            this.SummaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.SummaryTabControl.Multiline = true;
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.SummaryTabControl.ShowScroll = false;
            this.SummaryTabControl.ShowSeparator = false;
            this.SummaryTabControl.Size = new System.Drawing.Size(1588, 919);
            this.SummaryTabControl.TabIndex = 1;
            this.SummaryTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            // 
            // FundTab
            // 
            this.FundTab.Controls.Add(this.panel13);
            this.FundTab.Controls.Add(this.FundExpander);
            this.FundTab.Controls.Add(this.FundChart);
            this.FundTab.Image = null;
            this.FundTab.ImageSize = new System.Drawing.Size(16, 16);
            this.FundTab.Location = new System.Drawing.Point(1, 35);
            this.FundTab.Name = "FundTab";
            this.FundTab.ShowCloseButton = true;
            this.FundTab.Size = new System.Drawing.Size(1586, 883);
            this.FundTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundTab.TabIndex = 1;
            this.FundTab.Text = "Appropriation";
            this.FundTab.ThemesEnabled = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.rb1);
            this.panel13.Controls.Add(this.rb3);
            this.panel13.Controls.Add(this.rb2);
            this.panel13.Controls.Add(this.rb4);
            this.panel13.Location = new System.Drawing.Point(470, 132);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(1);
            this.panel13.Size = new System.Drawing.Size(517, 39);
            this.panel13.TabIndex = 109;
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
            // FundExpander
            // 
            this.FundExpander.BackColor = System.Drawing.Color.Black;
            this.FundExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.FundExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.FundExpander.Controls.Add(this.fp1);
            this.FundExpander.ExpandedHeight = 734;
            this.FundExpander.IsExpanded = false;
            this.FundExpander.Location = new System.Drawing.Point(1282, 75);
            this.FundExpander.Name = "FundExpander";
            this.FundExpander.Size = new System.Drawing.Size(229, 37);
            this.FundExpander.TabIndex = 107;
            this.FundExpander.Text = "Filter";
            this.FundExpander.UseAnimation = true;
            // 
            // fp1
            // 
            this.fp1.AutoScroll = true;
            this.fp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp1.Location = new System.Drawing.Point(20, 41);
            this.fp1.Name = "fp1";
            this.fp1.Size = new System.Drawing.Size(192, 507);
            this.fp1.TabIndex = 47;
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
            this.FundChart.Location = new System.Drawing.Point(10, 188);
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
            this.FundChart.Series.Add(chartSeries3);
            this.FundChart.Series.Add(chartSeries4);
            this.FundChart.Series3D = true;
            this.FundChart.SeriesHighlight = true;
            this.FundChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.FundChart.Size = new System.Drawing.Size(1203, 598);
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
            this.FundChart.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.FundChart.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // BocTab
            // 
            this.BocTab.Controls.Add(this.BocChart);
            this.BocTab.Controls.Add(this.BocExpander);
            this.BocTab.Image = null;
            this.BocTab.ImageSize = new System.Drawing.Size(16, 16);
            this.BocTab.Location = new System.Drawing.Point(1, 35);
            this.BocTab.Name = "BocTab";
            this.BocTab.ShowCloseButton = true;
            this.BocTab.Size = new System.Drawing.Size(1586, 883);
            this.BocTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocTab.TabIndex = 2;
            this.BocTab.Text = "BOC";
            this.BocTab.ThemesEnabled = false;
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
            this.BocChart.Location = new System.Drawing.Point(10, 188);
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
            this.BocChart.Series.Add(chartSeries5);
            this.BocChart.Series.Add(chartSeries6);
            this.BocChart.Series3D = true;
            this.BocChart.SeriesHighlight = true;
            this.BocChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.BocChart.Size = new System.Drawing.Size(1203, 598);
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
            this.BocChart.ToolBar.Items.Add(chartToolBarSaveItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarCopyItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarPrintItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.BocChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // BocExpander
            // 
            this.BocExpander.BackColor = System.Drawing.Color.Black;
            this.BocExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.BocExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.BocExpander.Controls.Add(this.fp2);
            this.BocExpander.ExpandedHeight = 734;
            this.BocExpander.IsExpanded = false;
            this.BocExpander.Location = new System.Drawing.Point(1277, 28);
            this.BocExpander.Name = "BocExpander";
            this.BocExpander.Size = new System.Drawing.Size(229, 37);
            this.BocExpander.TabIndex = 107;
            this.BocExpander.Text = "Filter";
            this.BocExpander.UseAnimation = true;
            // 
            // fp2
            // 
            this.fp2.AutoScroll = true;
            this.fp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp2.Location = new System.Drawing.Point(10, 41);
            this.fp2.Name = "fp2";
            this.fp2.Size = new System.Drawing.Size(192, 507);
            this.fp2.TabIndex = 47;
            // 
            // NpmTab
            // 
            this.NpmTab.Controls.Add(this.NpmChart);
            this.NpmTab.Controls.Add(this.NpmExpander);
            this.NpmTab.Image = null;
            this.NpmTab.ImageSize = new System.Drawing.Size(16, 16);
            this.NpmTab.Location = new System.Drawing.Point(1, 35);
            this.NpmTab.Name = "NpmTab";
            this.NpmTab.ShowCloseButton = true;
            this.NpmTab.Size = new System.Drawing.Size(1586, 883);
            this.NpmTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmTab.TabIndex = 3;
            this.NpmTab.Text = "NPM";
            this.NpmTab.ThemesEnabled = false;
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
            this.NpmChart.Location = new System.Drawing.Point(10, 188);
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
            this.NpmChart.Series.Add(chartSeries7);
            this.NpmChart.Series.Add(chartSeries8);
            this.NpmChart.Series3D = true;
            this.NpmChart.SeriesHighlight = true;
            this.NpmChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.NpmChart.Size = new System.Drawing.Size(1203, 598);
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
            this.NpmChart.ToolBar.Items.Add(chartToolBarSaveItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarCopyItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPrintItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.NpmChart.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // NpmExpander
            // 
            this.NpmExpander.BackColor = System.Drawing.Color.Black;
            this.NpmExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.NpmExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.NpmExpander.Controls.Add(this.fp3);
            this.NpmExpander.ExpandedHeight = 750;
            this.NpmExpander.IsExpanded = false;
            this.NpmExpander.Location = new System.Drawing.Point(1277, 28);
            this.NpmExpander.Name = "NpmExpander";
            this.NpmExpander.Size = new System.Drawing.Size(229, 37);
            this.NpmExpander.TabIndex = 107;
            this.NpmExpander.Text = "Filter";
            this.NpmExpander.UseAnimation = true;
            // 
            // fp3
            // 
            this.fp3.AutoScroll = true;
            this.fp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp3.Location = new System.Drawing.Point(10, 41);
            this.fp3.Name = "fp3";
            this.fp3.Size = new System.Drawing.Size(192, 507);
            this.fp3.TabIndex = 47;
            // 
            // GoalTab
            // 
            this.GoalTab.Controls.Add(this.GoalChart);
            this.GoalTab.Controls.Add(this.GoalExpander);
            this.GoalTab.Image = null;
            this.GoalTab.ImageSize = new System.Drawing.Size(16, 16);
            this.GoalTab.Location = new System.Drawing.Point(1, 35);
            this.GoalTab.Name = "GoalTab";
            this.GoalTab.ShowCloseButton = true;
            this.GoalTab.Size = new System.Drawing.Size(1586, 883);
            this.GoalTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalTab.TabIndex = 4;
            this.GoalTab.Text = "Goal";
            this.GoalTab.ThemesEnabled = false;
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
            this.GoalChart.Location = new System.Drawing.Point(10, 188);
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
            this.GoalChart.Series.Add(chartSeries9);
            this.GoalChart.Series.Add(chartSeries10);
            this.GoalChart.Series3D = true;
            this.GoalChart.SeriesHighlight = true;
            this.GoalChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.GoalChart.Size = new System.Drawing.Size(1203, 598);
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
            this.GoalChart.ToolBar.Items.Add(chartToolBarSaveItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarCopyItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPrintItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPaletteItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarTypeItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarSeries3DItem5);
            this.GoalChart.ToolBar.Items.Add(chartToolBarShowLegendItem5);
            // 
            // GoalExpander
            // 
            this.GoalExpander.BackColor = System.Drawing.Color.Black;
            this.GoalExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.GoalExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.GoalExpander.Controls.Add(this.fp4);
            this.GoalExpander.ExpandedHeight = 750;
            this.GoalExpander.IsExpanded = false;
            this.GoalExpander.Location = new System.Drawing.Point(1277, 28);
            this.GoalExpander.Name = "GoalExpander";
            this.GoalExpander.Size = new System.Drawing.Size(229, 37);
            this.GoalExpander.TabIndex = 107;
            this.GoalExpander.Text = "Filter";
            this.GoalExpander.UseAnimation = true;
            // 
            // fp4
            // 
            this.fp4.AutoScroll = true;
            this.fp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp4.Location = new System.Drawing.Point(10, 41);
            this.fp4.Name = "fp4";
            this.fp4.Size = new System.Drawing.Size(192, 507);
            this.fp4.TabIndex = 47;
            // 
            // ObjectiveTab
            // 
            this.ObjectiveTab.Controls.Add(this.ObjectiveExpander);
            this.ObjectiveTab.Controls.Add(this.ObjectiveChart);
            this.ObjectiveTab.Image = null;
            this.ObjectiveTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ObjectiveTab.Location = new System.Drawing.Point(1, 35);
            this.ObjectiveTab.Name = "ObjectiveTab";
            this.ObjectiveTab.ShowCloseButton = true;
            this.ObjectiveTab.Size = new System.Drawing.Size(1586, 883);
            this.ObjectiveTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveTab.TabIndex = 5;
            this.ObjectiveTab.Text = "Objective";
            this.ObjectiveTab.ThemesEnabled = false;
            // 
            // ObjectiveExpander
            // 
            this.ObjectiveExpander.BackColor = System.Drawing.Color.Black;
            this.ObjectiveExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ObjectiveExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ObjectiveExpander.Controls.Add(this.fp5);
            this.ObjectiveExpander.ExpandedHeight = 717;
            this.ObjectiveExpander.IsExpanded = false;
            this.ObjectiveExpander.Location = new System.Drawing.Point(1277, 28);
            this.ObjectiveExpander.Name = "ObjectiveExpander";
            this.ObjectiveExpander.Size = new System.Drawing.Size(229, 37);
            this.ObjectiveExpander.TabIndex = 107;
            this.ObjectiveExpander.Text = "Filter";
            this.ObjectiveExpander.UseAnimation = true;
            // 
            // fp5
            // 
            this.fp5.AutoScroll = true;
            this.fp5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp5.Location = new System.Drawing.Point(10, 56);
            this.fp5.Name = "fp5";
            this.fp5.Size = new System.Drawing.Size(205, 492);
            this.fp5.TabIndex = 47;
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
            this.ObjectiveChart.Location = new System.Drawing.Point(10, 188);
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
            this.ObjectiveChart.Size = new System.Drawing.Size(1203, 598);
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
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.ObjectiveChart.ToolBar.Items.Add(chartToolBarShowLegendItem6);
            // 
            // DivisionTab
            // 
            this.DivisionTab.Controls.Add(this.DivisionExpander);
            this.DivisionTab.Controls.Add(this.DivisionChart);
            this.DivisionTab.Image = null;
            this.DivisionTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DivisionTab.Location = new System.Drawing.Point(1, 35);
            this.DivisionTab.Name = "DivisionTab";
            this.DivisionTab.ShowCloseButton = true;
            this.DivisionTab.Size = new System.Drawing.Size(1586, 883);
            this.DivisionTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionTab.TabIndex = 6;
            this.DivisionTab.Text = "Division";
            this.DivisionTab.ThemesEnabled = false;
            // 
            // DivisionExpander
            // 
            this.DivisionExpander.BackColor = System.Drawing.Color.Black;
            this.DivisionExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DivisionExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DivisionExpander.Controls.Add(this.fp6);
            this.DivisionExpander.ExpandedHeight = 750;
            this.DivisionExpander.IsExpanded = false;
            this.DivisionExpander.Location = new System.Drawing.Point(1277, 28);
            this.DivisionExpander.Name = "DivisionExpander";
            this.DivisionExpander.Size = new System.Drawing.Size(229, 37);
            this.DivisionExpander.TabIndex = 107;
            this.DivisionExpander.Text = "Filter";
            this.DivisionExpander.UseAnimation = true;
            // 
            // fp6
            // 
            this.fp6.AutoScroll = true;
            this.fp6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp6.Location = new System.Drawing.Point(10, 41);
            this.fp6.Name = "fp6";
            this.fp6.Size = new System.Drawing.Size(192, 507);
            this.fp6.TabIndex = 47;
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
            this.DivisionChart.Location = new System.Drawing.Point(10, 188);
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
            this.DivisionChart.Series.Add(chartSeries13);
            this.DivisionChart.Series.Add(chartSeries14);
            this.DivisionChart.Series3D = true;
            this.DivisionChart.SeriesHighlight = true;
            this.DivisionChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.DivisionChart.Size = new System.Drawing.Size(1203, 598);
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
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // AreaTab
            // 
            this.AreaTab.Controls.Add(this.AreaChart);
            this.AreaTab.Controls.Add(this.AreaExpander);
            this.AreaTab.Image = null;
            this.AreaTab.ImageSize = new System.Drawing.Size(16, 16);
            this.AreaTab.Location = new System.Drawing.Point(1, 35);
            this.AreaTab.Name = "AreaTab";
            this.AreaTab.ShowCloseButton = true;
            this.AreaTab.Size = new System.Drawing.Size(1586, 883);
            this.AreaTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaTab.TabIndex = 7;
            this.AreaTab.Text = "Program Area";
            this.AreaTab.ThemesEnabled = false;
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
            this.AreaChart.Location = new System.Drawing.Point(10, 188);
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
            this.AreaChart.Series.Add(chartSeries15);
            this.AreaChart.Series.Add(chartSeries16);
            this.AreaChart.Series3D = true;
            this.AreaChart.SeriesHighlight = true;
            this.AreaChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AreaChart.Size = new System.Drawing.Size(1203, 598);
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
            this.AreaChart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.AreaChart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
            // 
            // AreaExpander
            // 
            this.AreaExpander.BackColor = System.Drawing.Color.Black;
            this.AreaExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.AreaExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AreaExpander.Controls.Add(this.fp7);
            this.AreaExpander.ExpandedHeight = 750;
            this.AreaExpander.IsExpanded = false;
            this.AreaExpander.Location = new System.Drawing.Point(1277, 28);
            this.AreaExpander.Name = "AreaExpander";
            this.AreaExpander.Size = new System.Drawing.Size(229, 37);
            this.AreaExpander.TabIndex = 107;
            this.AreaExpander.Text = "Filter";
            this.AreaExpander.UseAnimation = true;
            // 
            // fp7
            // 
            this.fp7.AutoScroll = true;
            this.fp7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp7.Location = new System.Drawing.Point(10, 56);
            this.fp7.Name = "fp7";
            this.fp7.Size = new System.Drawing.Size(192, 492);
            this.fp7.TabIndex = 47;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.ProjectChart);
            this.ProjectTab.Controls.Add(this.ProjectExpander);
            this.ProjectTab.Image = null;
            this.ProjectTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ProjectTab.Location = new System.Drawing.Point(1, 35);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.ShowCloseButton = true;
            this.ProjectTab.Size = new System.Drawing.Size(1586, 883);
            this.ProjectTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectTab.TabIndex = 8;
            this.ProjectTab.Text = "Program Project";
            this.ProjectTab.ThemesEnabled = false;
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
            this.ProjectChart.Location = new System.Drawing.Point(10, 188);
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
            this.ProjectChart.Series.Add(chartSeries17);
            this.ProjectChart.Series.Add(chartSeries18);
            this.ProjectChart.Series3D = true;
            this.ProjectChart.SeriesHighlight = true;
            this.ProjectChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.ProjectChart.Size = new System.Drawing.Size(1203, 598);
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
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSaveItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarCopyItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPrintItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPaletteItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarTypeItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSeries3DItem9);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarShowLegendItem9);
            // 
            // ProjectExpander
            // 
            this.ProjectExpander.BackColor = System.Drawing.Color.Black;
            this.ProjectExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ProjectExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ProjectExpander.Controls.Add(this.fp8);
            this.ProjectExpander.ExpandedHeight = 750;
            this.ProjectExpander.IsExpanded = false;
            this.ProjectExpander.Location = new System.Drawing.Point(1277, 28);
            this.ProjectExpander.Name = "ProjectExpander";
            this.ProjectExpander.Size = new System.Drawing.Size(229, 37);
            this.ProjectExpander.TabIndex = 107;
            this.ProjectExpander.Text = "Filter";
            this.ProjectExpander.UseAnimation = true;
            // 
            // fp8
            // 
            this.fp8.AutoScroll = true;
            this.fp8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fp8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fp8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.fp8.Location = new System.Drawing.Point(20, 54);
            this.fp8.Name = "fp8";
            this.fp8.Size = new System.Drawing.Size(192, 533);
            this.fp8.TabIndex = 47;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.groupBox1);
            this.tabPageAdv1.Controls.Add(this.groupBox5);
            this.tabPageAdv1.Controls.Add(this.FilterGroupBox);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 35);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1586, 883);
            this.tabPageAdv1.TabIndex = 9;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Controls.Add(this.metroSetLabel2);
            this.groupBox1.Controls.Add(this.ReturnButton);
            this.groupBox1.Controls.Add(this.metroSetLabel1);
            this.groupBox1.Controls.Add(this.metroSetLabel9);
            this.groupBox1.Controls.Add(this.metroSetLabel8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(269, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(825, 504);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.SteelBlue;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.EnableHeadersVisualStyles = false;
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
            this.Grid.Size = new System.Drawing.Size(774, 400);
            this.Grid.TabIndex = 150;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(380, 38);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(150, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 149;
            this.metroSetLabel2.Text = "metroSetLabel2";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
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
            // metroSetLabel1
            // 
            this.metroSetLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(99, 38);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(151, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 148;
            this.metroSetLabel1.Text = "metroSetLabel1";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.Location = new System.Drawing.Point(271, 38);
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
            this.metroSetLabel8.Location = new System.Drawing.Point(19, 38);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(64, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 16;
            this.metroSetLabel8.Text = "Total:";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroDark";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox5.Controls.Add(this.MiniTabControl1);
            this.groupBox5.Controls.Add(this.Navigator);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Location = new System.Drawing.Point(1099, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 508);
            this.groupBox5.TabIndex = 158;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // MiniTabControl1
            // 
            this.MiniTabControl1.ActiveTabColor = System.Drawing.Color.Black;
            this.MiniTabControl1.ActiveTabForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MiniTabControl1.BackColor = System.Drawing.Color.Black;
            this.MiniTabControl1.BeforeTouchSize = new System.Drawing.Size(400, 421);
            this.MiniTabControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiniTabControl1.BorderWidth = 1;
            this.MiniTabControl1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.MiniTabControl1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.Controls.Add(this.tabPageAdv2);
            this.MiniTabControl1.Controls.Add(this.tabPageAdv3);
            this.MiniTabControl1.Controls.Add(this.tabPageAdv4);
            this.MiniTabControl1.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.MiniTabControl1.FocusOnTabClick = false;
            this.MiniTabControl1.InactiveTabColor = System.Drawing.Color.Gray;
            this.MiniTabControl1.InActiveTabForeColor = System.Drawing.Color.Black;
            this.MiniTabControl1.Location = new System.Drawing.Point(29, 42);
            this.MiniTabControl1.Name = "MiniTabControl1";
            this.MiniTabControl1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.MiniTabControl1.ShowSeparator = false;
            this.MiniTabControl1.Size = new System.Drawing.Size(400, 421);
            this.MiniTabControl1.TabIndex = 150;
            this.MiniTabControl1.TabPanelBackColor = System.Drawing.Color.SteelBlue;
            this.MiniTabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.metroSetLabel11);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel7);
            this.tabPageAdv2.Controls.Add(this.amount2);
            this.tabPageAdv2.Controls.Add(this.amount1);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox1);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox2);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel6);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel5);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel4);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel3);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox3);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox4);
            this.tabPageAdv2.Controls.Add(this.metroSetButton2);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel10);
            this.tabPageAdv2.Controls.Add(this.metroSetButton1);
            this.tabPageAdv2.Controls.Add(this.metroSetLabel15);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox5);
            this.tabPageAdv2.Controls.Add(this.metroSetTextBox6);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(398, 390);
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel11.Location = new System.Drawing.Point(243, 129);
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
            this.metroSetLabel7.Location = new System.Drawing.Point(110, 129);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 138;
            this.metroSetLabel7.Text = "BOC";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroDark";
            // 
            // amount2
            // 
            this.amount2.AutoCompleteCustomSource = null;
            this.amount2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.amount2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.amount2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.amount2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.amount2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amount2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.amount2.Image = null;
            this.amount2.Lines = null;
            this.amount2.Location = new System.Drawing.Point(21, 321);
            this.amount2.MaxLength = 32767;
            this.amount2.Multiline = false;
            this.amount2.Name = "amount2";
            this.amount2.ReadOnly = false;
            this.amount2.Size = new System.Drawing.Size(159, 34);
            this.amount2.Style = MetroSet_UI.Design.Style.Dark;
            this.amount2.StyleManager = null;
            this.amount2.TabIndex = 137;
            this.amount2.Text = "metroSetTextBox8";
            this.amount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amount2.ThemeAuthor = "Narwin";
            this.amount2.ThemeName = "MetroDark";
            this.amount2.UseSystemPasswordChar = false;
            this.amount2.WatermarkText = "";
            // 
            // amount1
            // 
            this.amount1.AutoCompleteCustomSource = null;
            this.amount1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.amount1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.amount1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.amount1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.amount1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amount1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.amount1.Image = null;
            this.amount1.Lines = null;
            this.amount1.Location = new System.Drawing.Point(21, 246);
            this.amount1.MaxLength = 32767;
            this.amount1.Multiline = false;
            this.amount1.Name = "amount1";
            this.amount1.ReadOnly = false;
            this.amount1.Size = new System.Drawing.Size(159, 34);
            this.amount1.Style = MetroSet_UI.Design.Style.Dark;
            this.amount1.StyleManager = null;
            this.amount1.TabIndex = 136;
            this.amount1.Text = "metroSetTextBox7";
            this.amount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amount1.ThemeAuthor = "Narwin";
            this.amount1.ThemeName = "MetroDark";
            this.amount1.UseSystemPasswordChar = false;
            this.amount1.WatermarkText = "";
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
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(251, 165);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(132, 34);
            this.metroSetTextBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 135;
            this.metroSetTextBox1.Text = "metroSetTextBox4";
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
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
            this.metroSetTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox2.Image = null;
            this.metroSetTextBox2.Lines = null;
            this.metroSetTextBox2.Location = new System.Drawing.Point(122, 165);
            this.metroSetTextBox2.MaxLength = 32767;
            this.metroSetTextBox2.Multiline = false;
            this.metroSetTextBox2.Name = "metroSetTextBox2";
            this.metroSetTextBox2.ReadOnly = false;
            this.metroSetTextBox2.Size = new System.Drawing.Size(89, 34);
            this.metroSetTextBox2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox2.StyleManager = null;
            this.metroSetTextBox2.TabIndex = 134;
            this.metroSetTextBox2.Text = "metroSetTextBox3";
            this.metroSetTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox2.ThemeAuthor = "Narwin";
            this.metroSetTextBox2.ThemeName = "MetroDark";
            this.metroSetTextBox2.UseSystemPasswordChar = false;
            this.metroSetTextBox2.WatermarkText = "";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.Location = new System.Drawing.Point(13, 294);
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
            this.metroSetLabel5.Location = new System.Drawing.Point(13, 219);
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
            this.metroSetLabel4.Location = new System.Drawing.Point(110, 41);
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
            this.metroSetLabel3.Location = new System.Drawing.Point(13, 129);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 130;
            this.metroSetLabel3.Text = "RC";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // metroSetTextBox3
            // 
            this.metroSetTextBox3.AutoCompleteCustomSource = null;
            this.metroSetTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox3.Image = null;
            this.metroSetTextBox3.Lines = null;
            this.metroSetTextBox3.Location = new System.Drawing.Point(21, 165);
            this.metroSetTextBox3.MaxLength = 32767;
            this.metroSetTextBox3.Multiline = false;
            this.metroSetTextBox3.Name = "metroSetTextBox3";
            this.metroSetTextBox3.ReadOnly = false;
            this.metroSetTextBox3.Size = new System.Drawing.Size(73, 34);
            this.metroSetTextBox3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox3.StyleManager = null;
            this.metroSetTextBox3.TabIndex = 129;
            this.metroSetTextBox3.Text = "metroSetTextBox2";
            this.metroSetTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox3.ThemeAuthor = "Narwin";
            this.metroSetTextBox3.ThemeName = "MetroDark";
            this.metroSetTextBox3.UseSystemPasswordChar = false;
            this.metroSetTextBox3.WatermarkText = "";
            // 
            // metroSetTextBox4
            // 
            this.metroSetTextBox4.AutoCompleteCustomSource = null;
            this.metroSetTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox4.Image = null;
            this.metroSetTextBox4.Lines = null;
            this.metroSetTextBox4.Location = new System.Drawing.Point(118, 77);
            this.metroSetTextBox4.MaxLength = 32767;
            this.metroSetTextBox4.Multiline = false;
            this.metroSetTextBox4.Name = "metroSetTextBox4";
            this.metroSetTextBox4.ReadOnly = false;
            this.metroSetTextBox4.Size = new System.Drawing.Size(93, 34);
            this.metroSetTextBox4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox4.StyleManager = null;
            this.metroSetTextBox4.TabIndex = 128;
            this.metroSetTextBox4.Text = "metroSetTextBox1";
            this.metroSetTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox4.ThemeAuthor = "Narwin";
            this.metroSetTextBox4.ThemeName = "MetroDark";
            this.metroSetTextBox4.UseSystemPasswordChar = false;
            this.metroSetTextBox4.WatermarkText = "";
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
            this.metroSetLabel10.Location = new System.Drawing.Point(13, 41);
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
            this.metroSetLabel15.Location = new System.Drawing.Point(243, 41);
            this.metroSetLabel15.Name = "metroSetLabel15";
            this.metroSetLabel15.Size = new System.Drawing.Size(101, 32);
            this.metroSetLabel15.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel15.StyleManager = null;
            this.metroSetLabel15.TabIndex = 17;
            this.metroSetLabel15.Text = "AH/Org";
            this.metroSetLabel15.ThemeAuthor = "Narwin";
            this.metroSetLabel15.ThemeName = "MetroDark";
            // 
            // metroSetTextBox5
            // 
            this.metroSetTextBox5.AutoCompleteCustomSource = null;
            this.metroSetTextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox5.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox5.Image = null;
            this.metroSetTextBox5.Lines = null;
            this.metroSetTextBox5.Location = new System.Drawing.Point(21, 77);
            this.metroSetTextBox5.MaxLength = 32767;
            this.metroSetTextBox5.Multiline = false;
            this.metroSetTextBox5.Name = "metroSetTextBox5";
            this.metroSetTextBox5.ReadOnly = false;
            this.metroSetTextBox5.Size = new System.Drawing.Size(86, 34);
            this.metroSetTextBox5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox5.StyleManager = null;
            this.metroSetTextBox5.TabIndex = 125;
            this.metroSetTextBox5.Text = "metroSetTextBox6";
            this.metroSetTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox5.ThemeAuthor = "Narwin";
            this.metroSetTextBox5.ThemeName = "MetroDark";
            this.metroSetTextBox5.UseSystemPasswordChar = false;
            this.metroSetTextBox5.WatermarkText = "";
            // 
            // metroSetTextBox6
            // 
            this.metroSetTextBox6.AutoCompleteCustomSource = null;
            this.metroSetTextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox6.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox6.Image = null;
            this.metroSetTextBox6.Lines = null;
            this.metroSetTextBox6.Location = new System.Drawing.Point(251, 77);
            this.metroSetTextBox6.MaxLength = 32767;
            this.metroSetTextBox6.Multiline = false;
            this.metroSetTextBox6.Name = "metroSetTextBox6";
            this.metroSetTextBox6.ReadOnly = false;
            this.metroSetTextBox6.Size = new System.Drawing.Size(89, 34);
            this.metroSetTextBox6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox6.StyleManager = null;
            this.metroSetTextBox6.TabIndex = 124;
            this.metroSetTextBox6.Text = "metroSetTextBox5";
            this.metroSetTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox6.ThemeAuthor = "Narwin";
            this.metroSetTextBox6.ThemeName = "MetroDark";
            this.metroSetTextBox6.UseSystemPasswordChar = false;
            this.metroSetTextBox6.WatermarkText = "";
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.chartControl1);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(398, 390);
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
            this.chartControl1.Size = new System.Drawing.Size(398, 390);
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
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.Black;
            this.tabPageAdv4.Controls.Add(this.calculatorControl1);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(398, 390);
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
            // Navigator
            // 
            this.Navigator.AddNewItem = this.toolStripButton1;
            this.Navigator.BackColor = System.Drawing.Color.Transparent;
            this.Navigator.CountItem = this.toolStripLabel1;
            this.Navigator.DeleteItem = null;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navigator.ImageScalingSize = new System.Drawing.Size(30, 20);
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton8,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.toolStripSeparator1});
            this.Navigator.Location = new System.Drawing.Point(3, 474);
            this.Navigator.MoveFirstItem = this.toolStripButton3;
            this.Navigator.MoveLastItem = this.toolStripButton6;
            this.Navigator.MoveNextItem = this.toolStripButton5;
            this.Navigator.MovePreviousItem = this.toolStripButton4;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.toolStripTextBox1;
            this.Navigator.Size = new System.Drawing.Size(448, 31);
            this.Navigator.TabIndex = 152;
            this.Navigator.Text = "bindingNavigator1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FilterGroupBox.Controls.Add(this.CodeFilter);
            this.FilterGroupBox.Controls.Add(this.BocFilter);
            this.FilterGroupBox.Controls.Add(this.FundFilter);
            this.FilterGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilterGroupBox.Location = new System.Drawing.Point(24, 93);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(240, 506);
            this.FilterGroupBox.TabIndex = 157;
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
            this.CodeFilter.ItemHeight = 20;
            this.CodeFilter.Location = new System.Drawing.Point(28, 242);
            this.CodeFilter.Name = "CodeFilter";
            this.CodeFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CodeFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.CodeFilter.Size = new System.Drawing.Size(126, 26);
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
            this.BocFilter.ItemHeight = 20;
            this.BocFilter.Location = new System.Drawing.Point(28, 165);
            this.BocFilter.Name = "BocFilter";
            this.BocFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter.Size = new System.Drawing.Size(183, 26);
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
            this.FundFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter.FormattingEnabled = true;
            this.FundFilter.ItemHeight = 20;
            this.FundFilter.Location = new System.Drawing.Point(28, 90);
            this.FundFilter.Name = "FundFilter";
            this.FundFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter.Size = new System.Drawing.Size(183, 26);
            this.FundFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter.StyleManager = null;
            this.FundFilter.TabIndex = 2;
            this.FundFilter.ThemeAuthor = "Narwin";
            this.FundFilter.ThemeName = "MetroDark";
            // 
            // DivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Transparent;
            this.CaptionBarHeight = 75;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1588, 919);
            this.Controls.Add(this.SummaryTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "DivisionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Division ";
            this.Load += new System.EventHandler(this.DivisionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.FundTab.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.FundExpander.ResumeLayout(false);
            this.FundExpander.PerformLayout();
            this.BocTab.ResumeLayout(false);
            this.BocExpander.ResumeLayout(false);
            this.BocExpander.PerformLayout();
            this.NpmTab.ResumeLayout(false);
            this.NpmExpander.ResumeLayout(false);
            this.NpmExpander.PerformLayout();
            this.GoalTab.ResumeLayout(false);
            this.GoalExpander.ResumeLayout(false);
            this.GoalExpander.PerformLayout();
            this.ObjectiveTab.ResumeLayout(false);
            this.ObjectiveExpander.ResumeLayout(false);
            this.ObjectiveExpander.PerformLayout();
            this.DivisionTab.ResumeLayout(false);
            this.DivisionExpander.ResumeLayout(false);
            this.DivisionExpander.PerformLayout();
            this.AreaTab.ResumeLayout(false);
            this.AreaExpander.ResumeLayout(false);
            this.AreaExpander.PerformLayout();
            this.ProjectTab.ResumeLayout(false);
            this.ProjectExpander.ResumeLayout(false);
            this.ProjectExpander.PerformLayout();
            this.tabPageAdv1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).EndInit();
            this.MiniTabControl1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.FilterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

                }

                #endregion
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
                protected ChartControl PrcChart;
                private BindingSource BindingSource;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
                private MetroTextBox metroTextBox8;
                private TableLayoutPanel tableLayoutPanel1;
                private Label label1;
                private Label New;
                private BindingSource TransferBindingSource;
                private TabControlAdv SummaryTabControl;
                private TabPageAdv FundTab;
                private Panel panel13;
                private RadioButton rb1;
                private RadioButton rb3;
                private RadioButton rb2;
                private RadioButton rb4;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel FundExpander;
                private FlowLayoutPanel fp1;
                protected ChartControl FundChart;
                private TabPageAdv BocTab;
                protected ChartControl BocChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander;
                private FlowLayoutPanel fp2;
                private TabPageAdv NpmTab;
                protected ChartControl NpmChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel NpmExpander;
                private FlowLayoutPanel fp3;
                private TabPageAdv GoalTab;
                protected ChartControl GoalChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel GoalExpander;
                private FlowLayoutPanel fp4;
                private TabPageAdv ObjectiveTab;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ObjectiveExpander;
                private FlowLayoutPanel fp5;
                protected ChartControl ObjectiveChart;
                private TabPageAdv DivisionTab;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DivisionExpander;
                private FlowLayoutPanel fp6;
                protected ChartControl DivisionChart;
                private TabPageAdv AreaTab;
                protected ChartControl AreaChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel AreaExpander;
                private FlowLayoutPanel fp7;
                private TabPageAdv ProjectTab;
                protected ChartControl ProjectChart;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ProjectExpander;
                private FlowLayoutPanel fp8;
                private TabPageAdv tabPageAdv1;
                private GroupBox groupBox1;
                private DataGridView Grid;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
                private MetroLink ReturnButton;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
                private GroupBox groupBox5;
                private TabControlAdv MiniTabControl1;
                private TabPageAdv tabPageAdv2;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel11;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
                private MetroSet_UI.Controls.MetroSetTextBox amount2;
                private MetroSet_UI.Controls.MetroSetTextBox amount1;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox2;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox3;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox4;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
                private MetroSet_UI.Controls.MetroSetLabel metroSetLabel15;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox5;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox6;
                private TabPageAdv tabPageAdv3;
                protected ChartControl chartControl1;
                private TabPageAdv tabPageAdv4;
                private CalculatorControl calculatorControl1;
                private BindingNavigator Navigator;
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
                private ToolStripSeparator toolStripSeparator1;
                private GroupBox FilterGroupBox;
                private MetroSet_UI.Controls.MetroSetComboBox CodeFilter;
                private MetroSet_UI.Controls.MetroSetComboBox BocFilter;
                private MetroSet_UI.Controls.MetroSetComboBox FundFilter;
            } 
        }


    }
}