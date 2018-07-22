

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;
using MetroSet_UI.Controls;


namespace BudgetExecution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries19 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo19 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo10 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries20 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo20 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem10 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.ProjectTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ProjectExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ProjectFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ProjectFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ProjectChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.AreaTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AreaExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.AreaFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.AreaFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.AreaChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DivisionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.DivisionExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.DivisionFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DivisionFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.DivisionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ObjectiveTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ObjectiveExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ObjectiveFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ObjectiveFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ObjectiveChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.GoalTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.GoalExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GoalFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GoalFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GoalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.NpmExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.NpmFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NpmFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BocTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BocExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.BocFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BocFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.FundTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.FundExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.FundFilter4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundFilter3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FundFilter1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundFilter2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.FundChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.DatabaseTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AccountTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.UpdateTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroSetLabel20 = new MetroSet_UI.Controls.MetroSetLabel();
            this.BudgetLevel = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel19 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ID = new MetroSet_UI.Controls.MetroSetTextBox();
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
            this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel18 = new MetroSet_UI.Controls.MetroSetLabel();
            this.BFY = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Org = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AccountChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.button2 = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.CalendatButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.ResetButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.AccountToolsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCount = new MetroSet_UI.Controls.MetroSetLabel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.lblBoc = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.GridAccountFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.GridBocFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.GridFundFilter = new MetroSet_UI.Controls.MetroSetComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.chartControl1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).BeginInit();
            this.MiniTabControl1.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.ProjectExpander2.SuspendLayout();
            this.ProjectExpander1.SuspendLayout();
            this.AreaTab.SuspendLayout();
            this.AreaExpander2.SuspendLayout();
            this.AreaExpander1.SuspendLayout();
            this.DivisionTab.SuspendLayout();
            this.DivisionExpander2.SuspendLayout();
            this.DivisionExpander1.SuspendLayout();
            this.ObjectiveTab.SuspendLayout();
            this.ObjectiveExpander2.SuspendLayout();
            this.ObjectiveExpander1.SuspendLayout();
            this.GoalTab.SuspendLayout();
            this.GoalExpander2.SuspendLayout();
            this.GoalExpander1.SuspendLayout();
            this.NpmTab.SuspendLayout();
            this.NpmExpander2.SuspendLayout();
            this.NpmExpander1.SuspendLayout();
            this.BocTab.SuspendLayout();
            this.BocExpander2.SuspendLayout();
            this.BocExpander1.SuspendLayout();
            this.FundTab.SuspendLayout();
            this.FundExpander2.SuspendLayout();
            this.FundExpander1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).BeginInit();
            this.SummaryTabControl.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).BeginInit();
            this.AccountTabControl.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
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
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.ProjectExpander2);
            this.ProjectTab.Controls.Add(this.ProjectExpander1);
            this.ProjectTab.Controls.Add(this.ProjectChart);
            this.ProjectTab.Image = null;
            this.ProjectTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ProjectTab.Location = new System.Drawing.Point(0, 39);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.ShowCloseButton = true;
            this.ProjectTab.Size = new System.Drawing.Size(1679, 895);
            this.ProjectTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectTab.TabIndex = 8;
            this.ProjectTab.Tag = "Program Project";
            this.ProjectTab.Text = "ProgramProject";
            this.ProjectTab.ThemesEnabled = false;
            // 
            // ProjectExpander2
            // 
            this.ProjectExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectExpander2.BackColor = System.Drawing.Color.Black;
            this.ProjectExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ProjectExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ProjectExpander2.Controls.Add(this.label22);
            this.ProjectExpander2.Controls.Add(this.label30);
            this.ProjectExpander2.Controls.Add(this.ProjectFilter4);
            this.ProjectExpander2.Controls.Add(this.ProjectFilter3);
            this.ProjectExpander2.ExpandedHeight = 292;
            this.ProjectExpander2.IsExpanded = false;
            this.ProjectExpander2.Location = new System.Drawing.Point(1371, 417);
            this.ProjectExpander2.Name = "ProjectExpander2";
            this.ProjectExpander2.Size = new System.Drawing.Size(262, 37);
            this.ProjectExpander2.TabIndex = 110;
            this.ProjectExpander2.Text = "Chart Filters";
            this.ProjectExpander2.UseAnimation = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label22.Location = new System.Drawing.Point(42, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 22);
            this.label22.TabIndex = 117;
            this.label22.Text = "Filter";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label30.Location = new System.Drawing.Point(45, 197);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 22);
            this.label30.TabIndex = 118;
            this.label30.Text = "Grouping";
            // 
            // ProjectFilter4
            // 
            this.ProjectFilter4.AllowDrop = true;
            this.ProjectFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter4.BackColor = System.Drawing.Color.Transparent;
            this.ProjectFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ProjectFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter4.CausesValidation = false;
            this.ProjectFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ProjectFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectFilter4.FormattingEnabled = true;
            this.ProjectFilter4.ItemHeight = 30;
            this.ProjectFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "NPM",
            "Goal",
            "Objective",
            "RC"});
            this.ProjectFilter4.Location = new System.Drawing.Point(24, 229);
            this.ProjectFilter4.MaxDropDownItems = 20;
            this.ProjectFilter4.Name = "ProjectFilter4";
            this.ProjectFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter4.Size = new System.Drawing.Size(173, 36);
            this.ProjectFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter4.StyleManager = null;
            this.ProjectFilter4.TabIndex = 108;
            this.ProjectFilter4.Tag = "RC";
            this.ProjectFilter4.ThemeAuthor = "Narwin";
            this.ProjectFilter4.ThemeName = "MetroDark";
            // 
            // ProjectFilter3
            // 
            this.ProjectFilter3.AllowDrop = true;
            this.ProjectFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter3.BackColor = System.Drawing.Color.Transparent;
            this.ProjectFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ProjectFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ProjectFilter3.CausesValidation = false;
            this.ProjectFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ProjectFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectFilter3.FormattingEnabled = true;
            this.ProjectFilter3.ItemHeight = 30;
            this.ProjectFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.ProjectFilter3.Location = new System.Drawing.Point(24, 91);
            this.ProjectFilter3.MaxDropDownItems = 20;
            this.ProjectFilter3.Name = "ProjectFilter3";
            this.ProjectFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter3.Size = new System.Drawing.Size(173, 36);
            this.ProjectFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter3.StyleManager = null;
            this.ProjectFilter3.TabIndex = 108;
            this.ProjectFilter3.Tag = "ProgramProjectName";
            this.ProjectFilter3.ThemeAuthor = "Narwin";
            this.ProjectFilter3.ThemeName = "MetroDark";
            // 
            // ProjectExpander1
            // 
            this.ProjectExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectExpander1.BackColor = System.Drawing.Color.Black;
            this.ProjectExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ProjectExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ProjectExpander1.Controls.Add(this.label23);
            this.ProjectExpander1.Controls.Add(this.label24);
            this.ProjectExpander1.Controls.Add(this.ProjectFilter1);
            this.ProjectExpander1.Controls.Add(this.ProjectFilter2);
            this.ProjectExpander1.ExpandedHeight = 268;
            this.ProjectExpander1.IsExpanded = false;
            this.ProjectExpander1.Location = new System.Drawing.Point(1371, 100);
            this.ProjectExpander1.Name = "ProjectExpander1";
            this.ProjectExpander1.Size = new System.Drawing.Size(262, 37);
            this.ProjectExpander1.TabIndex = 108;
            this.ProjectExpander1.Text = "Chart Configuration";
            this.ProjectExpander1.UseAnimation = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label23.Location = new System.Drawing.Point(20, 187);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 22);
            this.label23.TabIndex = 119;
            this.label23.Text = "Measure";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label24.Location = new System.Drawing.Point(20, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 22);
            this.label24.TabIndex = 118;
            this.label24.Text = "Chart Type";
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
            this.ProjectFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectFilter1.FormattingEnabled = true;
            this.ProjectFilter1.ItemHeight = 30;
            this.ProjectFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.ProjectFilter1.Location = new System.Drawing.Point(24, 99);
            this.ProjectFilter1.MaxDropDownItems = 20;
            this.ProjectFilter1.Name = "ProjectFilter1";
            this.ProjectFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter1.Size = new System.Drawing.Size(173, 36);
            this.ProjectFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter1.StyleManager = null;
            this.ProjectFilter1.TabIndex = 113;
            this.ProjectFilter1.Tag = "Division";
            this.ProjectFilter1.ThemeAuthor = "Narwin";
            this.ProjectFilter1.ThemeName = "MetroDark";
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
            this.ProjectFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.ProjectFilter2.Location = new System.Drawing.Point(24, 212);
            this.ProjectFilter2.MaxDropDownItems = 20;
            this.ProjectFilter2.Name = "ProjectFilter2";
            this.ProjectFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProjectFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.ProjectFilter2.Size = new System.Drawing.Size(173, 36);
            this.ProjectFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.ProjectFilter2.StyleManager = null;
            this.ProjectFilter2.TabIndex = 1;
            this.ProjectFilter2.Tag = "Division";
            this.ProjectFilter2.ThemeAuthor = "Narwin";
            this.ProjectFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.ProjectChart.Series.Add(chartSeries3);
            this.ProjectChart.Series.Add(chartSeries4);
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
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.ProjectChart.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 23);
            this.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.ComboXPDown;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            // 
            // AreaTab
            // 
            this.AreaTab.Controls.Add(this.AreaExpander2);
            this.AreaTab.Controls.Add(this.AreaExpander1);
            this.AreaTab.Controls.Add(this.AreaChart);
            this.AreaTab.Image = null;
            this.AreaTab.ImageSize = new System.Drawing.Size(16, 16);
            this.AreaTab.Location = new System.Drawing.Point(0, 39);
            this.AreaTab.Name = "AreaTab";
            this.AreaTab.ShowCloseButton = true;
            this.AreaTab.Size = new System.Drawing.Size(1679, 895);
            this.AreaTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaTab.TabIndex = 7;
            this.AreaTab.Tag = "Program Area";
            this.AreaTab.Text = "ProgramArea";
            this.AreaTab.ThemesEnabled = false;
            // 
            // AreaExpander2
            // 
            this.AreaExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaExpander2.BackColor = System.Drawing.Color.Black;
            this.AreaExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.AreaExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AreaExpander2.Controls.Add(this.label19);
            this.AreaExpander2.Controls.Add(this.label29);
            this.AreaExpander2.Controls.Add(this.AreaFilter4);
            this.AreaExpander2.Controls.Add(this.AreaFilter3);
            this.AreaExpander2.ExpandedHeight = 292;
            this.AreaExpander2.IsExpanded = false;
            this.AreaExpander2.Location = new System.Drawing.Point(1407, 417);
            this.AreaExpander2.Name = "AreaExpander2";
            this.AreaExpander2.Size = new System.Drawing.Size(220, 37);
            this.AreaExpander2.TabIndex = 110;
            this.AreaExpander2.Text = "Chart Filters";
            this.AreaExpander2.UseAnimation = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label19.Location = new System.Drawing.Point(29, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 22);
            this.label19.TabIndex = 117;
            this.label19.Text = "Filter";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label29.Location = new System.Drawing.Point(32, 188);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 22);
            this.label29.TabIndex = 118;
            this.label29.Text = "Grouping";
            // 
            // AreaFilter4
            // 
            this.AreaFilter4.AllowDrop = true;
            this.AreaFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter4.BackColor = System.Drawing.Color.Transparent;
            this.AreaFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AreaFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter4.CausesValidation = false;
            this.AreaFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AreaFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AreaFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AreaFilter4.FormattingEnabled = true;
            this.AreaFilter4.ItemHeight = 30;
            this.AreaFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "NPM",
            "Goal",
            "Objective",
            "RC"});
            this.AreaFilter4.Location = new System.Drawing.Point(23, 215);
            this.AreaFilter4.MaxDropDownItems = 20;
            this.AreaFilter4.Name = "AreaFilter4";
            this.AreaFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter4.Size = new System.Drawing.Size(173, 36);
            this.AreaFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter4.StyleManager = null;
            this.AreaFilter4.TabIndex = 108;
            this.AreaFilter4.Tag = "RC";
            this.AreaFilter4.ThemeAuthor = "Narwin";
            this.AreaFilter4.ThemeName = "MetroDark";
            // 
            // AreaFilter3
            // 
            this.AreaFilter3.AllowDrop = true;
            this.AreaFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter3.BackColor = System.Drawing.Color.Transparent;
            this.AreaFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AreaFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AreaFilter3.CausesValidation = false;
            this.AreaFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AreaFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AreaFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AreaFilter3.FormattingEnabled = true;
            this.AreaFilter3.ItemHeight = 30;
            this.AreaFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.AreaFilter3.Location = new System.Drawing.Point(23, 82);
            this.AreaFilter3.MaxDropDownItems = 20;
            this.AreaFilter3.Name = "AreaFilter3";
            this.AreaFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter3.Size = new System.Drawing.Size(173, 36);
            this.AreaFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter3.StyleManager = null;
            this.AreaFilter3.TabIndex = 108;
            this.AreaFilter3.Tag = "ProgramAreaName";
            this.AreaFilter3.ThemeAuthor = "Narwin";
            this.AreaFilter3.ThemeName = "MetroDark";
            // 
            // AreaExpander1
            // 
            this.AreaExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaExpander1.BackColor = System.Drawing.Color.Black;
            this.AreaExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.AreaExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AreaExpander1.Controls.Add(this.label20);
            this.AreaExpander1.Controls.Add(this.label21);
            this.AreaExpander1.Controls.Add(this.AreaFilter1);
            this.AreaExpander1.Controls.Add(this.AreaFilter2);
            this.AreaExpander1.ExpandedHeight = 260;
            this.AreaExpander1.IsExpanded = false;
            this.AreaExpander1.Location = new System.Drawing.Point(1407, 100);
            this.AreaExpander1.Name = "AreaExpander1";
            this.AreaExpander1.Size = new System.Drawing.Size(220, 37);
            this.AreaExpander1.TabIndex = 108;
            this.AreaExpander1.Text = "Chart Configuration";
            this.AreaExpander1.UseAnimation = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label20.Location = new System.Drawing.Point(19, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 22);
            this.label20.TabIndex = 119;
            this.label20.Text = "Measure";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label21.Location = new System.Drawing.Point(19, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 22);
            this.label21.TabIndex = 118;
            this.label21.Text = "Chart Type";
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
            this.AreaFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AreaFilter1.FormattingEnabled = true;
            this.AreaFilter1.ItemHeight = 30;
            this.AreaFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.AreaFilter1.Location = new System.Drawing.Point(23, 82);
            this.AreaFilter1.MaxDropDownItems = 20;
            this.AreaFilter1.Name = "AreaFilter1";
            this.AreaFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter1.Size = new System.Drawing.Size(155, 36);
            this.AreaFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter1.StyleManager = null;
            this.AreaFilter1.TabIndex = 113;
            this.AreaFilter1.Tag = "Division";
            this.AreaFilter1.ThemeAuthor = "Narwin";
            this.AreaFilter1.ThemeName = "MetroDark";
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
            this.AreaFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.AreaFilter2.Location = new System.Drawing.Point(23, 194);
            this.AreaFilter2.MaxDropDownItems = 20;
            this.AreaFilter2.Name = "AreaFilter2";
            this.AreaFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AreaFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.AreaFilter2.Size = new System.Drawing.Size(155, 36);
            this.AreaFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.AreaFilter2.StyleManager = null;
            this.AreaFilter2.TabIndex = 1;
            this.AreaFilter2.Tag = "Division";
            this.AreaFilter2.ThemeAuthor = "Narwin";
            this.AreaFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.AreaChart.Series.Add(chartSeries5);
            this.AreaChart.Series.Add(chartSeries6);
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
            this.AreaChart.ToolBar.Items.Add(chartToolBarSaveItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarCopyItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPrintItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.AreaChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            // 
            // DivisionTab
            // 
            this.DivisionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DivisionTab.Controls.Add(this.DivisionExpander2);
            this.DivisionTab.Controls.Add(this.DivisionExpander1);
            this.DivisionTab.Controls.Add(this.DivisionChart);
            this.DivisionTab.Image = null;
            this.DivisionTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DivisionTab.Location = new System.Drawing.Point(0, 39);
            this.DivisionTab.Name = "DivisionTab";
            this.DivisionTab.ShowCloseButton = true;
            this.DivisionTab.Size = new System.Drawing.Size(1679, 895);
            this.DivisionTab.TabBackColor = System.Drawing.Color.Black;
            this.DivisionTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionTab.TabIndex = 6;
            this.DivisionTab.Tag = "RC";
            this.DivisionTab.Text = "Division";
            this.DivisionTab.ThemesEnabled = false;
            // 
            // DivisionExpander2
            // 
            this.DivisionExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionExpander2.BackColor = System.Drawing.Color.Black;
            this.DivisionExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DivisionExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DivisionExpander2.Controls.Add(this.label16);
            this.DivisionExpander2.Controls.Add(this.label28);
            this.DivisionExpander2.Controls.Add(this.DivisionFilter4);
            this.DivisionExpander2.Controls.Add(this.DivisionFilter3);
            this.DivisionExpander2.ExpandedHeight = 292;
            this.DivisionExpander2.IsExpanded = false;
            this.DivisionExpander2.Location = new System.Drawing.Point(1371, 412);
            this.DivisionExpander2.Name = "DivisionExpander2";
            this.DivisionExpander2.Size = new System.Drawing.Size(231, 37);
            this.DivisionExpander2.TabIndex = 110;
            this.DivisionExpander2.Text = "Chart Filters";
            this.DivisionExpander2.UseAnimation = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label16.Location = new System.Drawing.Point(27, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 22);
            this.label16.TabIndex = 117;
            this.label16.Text = "Filter";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label28.Location = new System.Drawing.Point(27, 202);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 22);
            this.label28.TabIndex = 118;
            this.label28.Text = "Grouping";
            // 
            // DivisionFilter4
            // 
            this.DivisionFilter4.AllowDrop = true;
            this.DivisionFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter4.BackColor = System.Drawing.Color.Transparent;
            this.DivisionFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DivisionFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter4.CausesValidation = false;
            this.DivisionFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DivisionFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DivisionFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DivisionFilter4.FormattingEnabled = true;
            this.DivisionFilter4.ItemHeight = 30;
            this.DivisionFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "NPM",
            "Goal",
            "Objective",
            "ProgramArea",
            "ProgramProject"});
            this.DivisionFilter4.Location = new System.Drawing.Point(23, 239);
            this.DivisionFilter4.MaxDropDownItems = 20;
            this.DivisionFilter4.Name = "DivisionFilter4";
            this.DivisionFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter4.Size = new System.Drawing.Size(173, 36);
            this.DivisionFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter4.StyleManager = null;
            this.DivisionFilter4.TabIndex = 108;
            this.DivisionFilter4.Tag = "RC";
            this.DivisionFilter4.ThemeAuthor = "Narwin";
            this.DivisionFilter4.ThemeName = "MetroDark";
            // 
            // DivisionFilter3
            // 
            this.DivisionFilter3.AllowDrop = true;
            this.DivisionFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter3.BackColor = System.Drawing.Color.Transparent;
            this.DivisionFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DivisionFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DivisionFilter3.CausesValidation = false;
            this.DivisionFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DivisionFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DivisionFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DivisionFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DivisionFilter3.FormattingEnabled = true;
            this.DivisionFilter3.ItemHeight = 30;
            this.DivisionFilter3.Location = new System.Drawing.Point(23, 105);
            this.DivisionFilter3.MaxDropDownItems = 20;
            this.DivisionFilter3.Name = "DivisionFilter3";
            this.DivisionFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter3.Size = new System.Drawing.Size(173, 36);
            this.DivisionFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter3.StyleManager = null;
            this.DivisionFilter3.TabIndex = 108;
            this.DivisionFilter3.Tag = "DivisionName";
            this.DivisionFilter3.ThemeAuthor = "Narwin";
            this.DivisionFilter3.ThemeName = "MetroDark";
            // 
            // DivisionExpander1
            // 
            this.DivisionExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionExpander1.BackColor = System.Drawing.Color.Black;
            this.DivisionExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DivisionExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DivisionExpander1.Controls.Add(this.label17);
            this.DivisionExpander1.Controls.Add(this.label18);
            this.DivisionExpander1.Controls.Add(this.DivisionFilter1);
            this.DivisionExpander1.Controls.Add(this.DivisionFilter2);
            this.DivisionExpander1.ExpandedHeight = 266;
            this.DivisionExpander1.IsExpanded = false;
            this.DivisionExpander1.Location = new System.Drawing.Point(1371, 100);
            this.DivisionExpander1.Name = "DivisionExpander1";
            this.DivisionExpander1.Size = new System.Drawing.Size(231, 37);
            this.DivisionExpander1.TabIndex = 108;
            this.DivisionExpander1.Text = "Chart Configuration";
            this.DivisionExpander1.UseAnimation = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label17.Location = new System.Drawing.Point(23, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 119;
            this.label17.Text = "Measure";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label18.Location = new System.Drawing.Point(23, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 22);
            this.label18.TabIndex = 118;
            this.label18.Text = "Chart Type";
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
            this.DivisionFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DivisionFilter1.FormattingEnabled = true;
            this.DivisionFilter1.ItemHeight = 30;
            this.DivisionFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.DivisionFilter1.Location = new System.Drawing.Point(27, 85);
            this.DivisionFilter1.MaxDropDownItems = 20;
            this.DivisionFilter1.Name = "DivisionFilter1";
            this.DivisionFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter1.Size = new System.Drawing.Size(173, 36);
            this.DivisionFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter1.StyleManager = null;
            this.DivisionFilter1.TabIndex = 113;
            this.DivisionFilter1.Tag = "RC";
            this.DivisionFilter1.ThemeAuthor = "Narwin";
            this.DivisionFilter1.ThemeName = "MetroDark";
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
            this.DivisionFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.DivisionFilter2.Location = new System.Drawing.Point(27, 196);
            this.DivisionFilter2.MaxDropDownItems = 20;
            this.DivisionFilter2.Name = "DivisionFilter2";
            this.DivisionFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DivisionFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.DivisionFilter2.Size = new System.Drawing.Size(173, 36);
            this.DivisionFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.DivisionFilter2.StyleManager = null;
            this.DivisionFilter2.TabIndex = 0;
            this.DivisionFilter2.Tag = "RC";
            this.DivisionFilter2.ThemeAuthor = "Narwin";
            this.DivisionFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.DivisionChart.Series.Add(chartSeries7);
            this.DivisionChart.Series.Add(chartSeries8);
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
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSaveItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarCopyItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPrintItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarPaletteItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarTypeItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarSeries3DItem4);
            this.DivisionChart.ToolBar.Items.Add(chartToolBarShowLegendItem4);
            // 
            // ObjectiveTab
            // 
            this.ObjectiveTab.Controls.Add(this.ObjectiveExpander2);
            this.ObjectiveTab.Controls.Add(this.ObjectiveExpander1);
            this.ObjectiveTab.Controls.Add(this.ObjectiveChart);
            this.ObjectiveTab.Image = null;
            this.ObjectiveTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ObjectiveTab.Location = new System.Drawing.Point(0, 39);
            this.ObjectiveTab.Name = "ObjectiveTab";
            this.ObjectiveTab.ShowCloseButton = true;
            this.ObjectiveTab.Size = new System.Drawing.Size(1679, 895);
            this.ObjectiveTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveTab.TabIndex = 5;
            this.ObjectiveTab.Tag = "Agency Objective";
            this.ObjectiveTab.Text = "Objective";
            this.ObjectiveTab.ThemesEnabled = false;
            // 
            // ObjectiveExpander2
            // 
            this.ObjectiveExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveExpander2.BackColor = System.Drawing.Color.Black;
            this.ObjectiveExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ObjectiveExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ObjectiveExpander2.Controls.Add(this.label13);
            this.ObjectiveExpander2.Controls.Add(this.label26);
            this.ObjectiveExpander2.Controls.Add(this.ObjectiveFilter4);
            this.ObjectiveExpander2.Controls.Add(this.ObjectiveFilter3);
            this.ObjectiveExpander2.ExpandedHeight = 292;
            this.ObjectiveExpander2.IsExpanded = false;
            this.ObjectiveExpander2.Location = new System.Drawing.Point(1371, 417);
            this.ObjectiveExpander2.Name = "ObjectiveExpander2";
            this.ObjectiveExpander2.Size = new System.Drawing.Size(264, 37);
            this.ObjectiveExpander2.TabIndex = 110;
            this.ObjectiveExpander2.Text = "Chart Filters";
            this.ObjectiveExpander2.UseAnimation = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label13.Location = new System.Drawing.Point(38, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 22);
            this.label13.TabIndex = 117;
            this.label13.Text = "Filter";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label26.Location = new System.Drawing.Point(41, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 22);
            this.label26.TabIndex = 118;
            this.label26.Text = "Grouping";
            // 
            // ObjectiveFilter4
            // 
            this.ObjectiveFilter4.AllowDrop = true;
            this.ObjectiveFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter4.BackColor = System.Drawing.Color.Transparent;
            this.ObjectiveFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ObjectiveFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter4.CausesValidation = false;
            this.ObjectiveFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ObjectiveFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ObjectiveFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ObjectiveFilter4.FormattingEnabled = true;
            this.ObjectiveFilter4.ItemHeight = 30;
            this.ObjectiveFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "NPM",
            "Goal",
            "RC",
            "ProgramArea"});
            this.ObjectiveFilter4.Location = new System.Drawing.Point(25, 216);
            this.ObjectiveFilter4.MaxDropDownItems = 20;
            this.ObjectiveFilter4.Name = "ObjectiveFilter4";
            this.ObjectiveFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter4.Size = new System.Drawing.Size(220, 36);
            this.ObjectiveFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter4.StyleManager = null;
            this.ObjectiveFilter4.TabIndex = 108;
            this.ObjectiveFilter4.Tag = "RC";
            this.ObjectiveFilter4.ThemeAuthor = "Narwin";
            this.ObjectiveFilter4.ThemeName = "MetroDark";
            // 
            // ObjectiveFilter3
            // 
            this.ObjectiveFilter3.AllowDrop = true;
            this.ObjectiveFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter3.BackColor = System.Drawing.Color.Transparent;
            this.ObjectiveFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ObjectiveFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ObjectiveFilter3.CausesValidation = false;
            this.ObjectiveFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ObjectiveFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObjectiveFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ObjectiveFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ObjectiveFilter3.FormattingEnabled = true;
            this.ObjectiveFilter3.ItemHeight = 30;
            this.ObjectiveFilter3.Location = new System.Drawing.Point(25, 83);
            this.ObjectiveFilter3.MaxDropDownItems = 20;
            this.ObjectiveFilter3.Name = "ObjectiveFilter3";
            this.ObjectiveFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter3.Size = new System.Drawing.Size(220, 36);
            this.ObjectiveFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter3.StyleManager = null;
            this.ObjectiveFilter3.TabIndex = 108;
            this.ObjectiveFilter3.Tag = "ObjectiveName";
            this.ObjectiveFilter3.ThemeAuthor = "Narwin";
            this.ObjectiveFilter3.ThemeName = "MetroDark";
            // 
            // ObjectiveExpander1
            // 
            this.ObjectiveExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveExpander1.BackColor = System.Drawing.Color.Black;
            this.ObjectiveExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ObjectiveExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ObjectiveExpander1.Controls.Add(this.label14);
            this.ObjectiveExpander1.Controls.Add(this.label15);
            this.ObjectiveExpander1.Controls.Add(this.ObjectiveFilter1);
            this.ObjectiveExpander1.Controls.Add(this.ObjectiveFilter2);
            this.ObjectiveExpander1.ExpandedHeight = 268;
            this.ObjectiveExpander1.IsExpanded = false;
            this.ObjectiveExpander1.Location = new System.Drawing.Point(1371, 100);
            this.ObjectiveExpander1.Name = "ObjectiveExpander1";
            this.ObjectiveExpander1.Size = new System.Drawing.Size(264, 37);
            this.ObjectiveExpander1.TabIndex = 108;
            this.ObjectiveExpander1.Text = "Chart Configuration";
            this.ObjectiveExpander1.UseAnimation = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label14.Location = new System.Drawing.Point(25, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 119;
            this.label14.Text = "Measure";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label15.Location = new System.Drawing.Point(25, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 22);
            this.label15.TabIndex = 118;
            this.label15.Text = "Chart Type";
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
            this.ObjectiveFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ObjectiveFilter1.FormattingEnabled = true;
            this.ObjectiveFilter1.ItemHeight = 30;
            this.ObjectiveFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.ObjectiveFilter1.Location = new System.Drawing.Point(29, 91);
            this.ObjectiveFilter1.MaxDropDownItems = 20;
            this.ObjectiveFilter1.Name = "ObjectiveFilter1";
            this.ObjectiveFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter1.Size = new System.Drawing.Size(173, 36);
            this.ObjectiveFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter1.StyleManager = null;
            this.ObjectiveFilter1.TabIndex = 113;
            this.ObjectiveFilter1.Tag = "Division";
            this.ObjectiveFilter1.ThemeAuthor = "Narwin";
            this.ObjectiveFilter1.ThemeName = "MetroDark";
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
            this.ObjectiveFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.ObjectiveFilter2.Location = new System.Drawing.Point(29, 202);
            this.ObjectiveFilter2.MaxDropDownItems = 20;
            this.ObjectiveFilter2.Name = "ObjectiveFilter2";
            this.ObjectiveFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ObjectiveFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.ObjectiveFilter2.Size = new System.Drawing.Size(173, 36);
            this.ObjectiveFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.ObjectiveFilter2.StyleManager = null;
            this.ObjectiveFilter2.TabIndex = 1;
            this.ObjectiveFilter2.Tag = "Division";
            this.ObjectiveFilter2.ThemeAuthor = "Narwin";
            this.ObjectiveFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.ObjectiveChart.Size = new System.Drawing.Size(1204, 720);
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
            // GoalTab
            // 
            this.GoalTab.Controls.Add(this.GoalExpander2);
            this.GoalTab.Controls.Add(this.GoalExpander1);
            this.GoalTab.Controls.Add(this.GoalChart);
            this.GoalTab.Image = null;
            this.GoalTab.ImageSize = new System.Drawing.Size(16, 16);
            this.GoalTab.Location = new System.Drawing.Point(0, 39);
            this.GoalTab.Name = "GoalTab";
            this.GoalTab.ShowCloseButton = true;
            this.GoalTab.Size = new System.Drawing.Size(1679, 895);
            this.GoalTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalTab.TabIndex = 4;
            this.GoalTab.Tag = "Agency Goal";
            this.GoalTab.Text = "Goal";
            this.GoalTab.ThemesEnabled = false;
            // 
            // GoalExpander2
            // 
            this.GoalExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalExpander2.BackColor = System.Drawing.Color.Black;
            this.GoalExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.GoalExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.GoalExpander2.Controls.Add(this.label4);
            this.GoalExpander2.Controls.Add(this.label10);
            this.GoalExpander2.Controls.Add(this.GoalFilter4);
            this.GoalExpander2.Controls.Add(this.GoalFilter3);
            this.GoalExpander2.ExpandedHeight = 292;
            this.GoalExpander2.IsExpanded = false;
            this.GoalExpander2.Location = new System.Drawing.Point(1371, 417);
            this.GoalExpander2.Name = "GoalExpander2";
            this.GoalExpander2.Size = new System.Drawing.Size(227, 37);
            this.GoalExpander2.TabIndex = 110;
            this.GoalExpander2.Text = "Chart Filters";
            this.GoalExpander2.UseAnimation = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(28, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "Filter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label10.Location = new System.Drawing.Point(31, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 118;
            this.label10.Text = "Grouping";
            // 
            // GoalFilter4
            // 
            this.GoalFilter4.AllowDrop = true;
            this.GoalFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter4.BackColor = System.Drawing.Color.Transparent;
            this.GoalFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GoalFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter4.CausesValidation = false;
            this.GoalFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GoalFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GoalFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GoalFilter4.FormattingEnabled = true;
            this.GoalFilter4.ItemHeight = 30;
            this.GoalFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "NPM",
            "RC",
            "Objective",
            "ProgramArea"});
            this.GoalFilter4.Location = new System.Drawing.Point(21, 218);
            this.GoalFilter4.MaxDropDownItems = 20;
            this.GoalFilter4.Name = "GoalFilter4";
            this.GoalFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter4.Size = new System.Drawing.Size(173, 36);
            this.GoalFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter4.StyleManager = null;
            this.GoalFilter4.TabIndex = 108;
            this.GoalFilter4.Tag = "RC";
            this.GoalFilter4.ThemeAuthor = "Narwin";
            this.GoalFilter4.ThemeName = "MetroDark";
            // 
            // GoalFilter3
            // 
            this.GoalFilter3.AllowDrop = true;
            this.GoalFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter3.BackColor = System.Drawing.Color.Transparent;
            this.GoalFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GoalFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GoalFilter3.CausesValidation = false;
            this.GoalFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GoalFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GoalFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GoalFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GoalFilter3.FormattingEnabled = true;
            this.GoalFilter3.ItemHeight = 30;
            this.GoalFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.GoalFilter3.Location = new System.Drawing.Point(21, 85);
            this.GoalFilter3.MaxDropDownItems = 20;
            this.GoalFilter3.Name = "GoalFilter3";
            this.GoalFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter3.Size = new System.Drawing.Size(173, 36);
            this.GoalFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter3.StyleManager = null;
            this.GoalFilter3.TabIndex = 108;
            this.GoalFilter3.Tag = "GoalName";
            this.GoalFilter3.ThemeAuthor = "Narwin";
            this.GoalFilter3.ThemeName = "MetroDark";
            // 
            // GoalExpander1
            // 
            this.GoalExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalExpander1.BackColor = System.Drawing.Color.Black;
            this.GoalExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.GoalExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.GoalExpander1.Controls.Add(this.label11);
            this.GoalExpander1.Controls.Add(this.label12);
            this.GoalExpander1.Controls.Add(this.GoalFilter1);
            this.GoalExpander1.Controls.Add(this.GoalFilter2);
            this.GoalExpander1.ExpandedHeight = 281;
            this.GoalExpander1.IsExpanded = false;
            this.GoalExpander1.Location = new System.Drawing.Point(1371, 100);
            this.GoalExpander1.Name = "GoalExpander1";
            this.GoalExpander1.Size = new System.Drawing.Size(227, 37);
            this.GoalExpander1.TabIndex = 108;
            this.GoalExpander1.Text = "Chart Configuration";
            this.GoalExpander1.UseAnimation = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label11.Location = new System.Drawing.Point(17, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 119;
            this.label11.Text = "Measure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label12.Location = new System.Drawing.Point(17, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 118;
            this.label12.Text = "Chart Type";
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
            this.GoalFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GoalFilter1.FormattingEnabled = true;
            this.GoalFilter1.ItemHeight = 30;
            this.GoalFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.GoalFilter1.Location = new System.Drawing.Point(20, 83);
            this.GoalFilter1.MaxDropDownItems = 20;
            this.GoalFilter1.Name = "GoalFilter1";
            this.GoalFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter1.Size = new System.Drawing.Size(174, 36);
            this.GoalFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter1.StyleManager = null;
            this.GoalFilter1.TabIndex = 113;
            this.GoalFilter1.Tag = "Division";
            this.GoalFilter1.ThemeAuthor = "Narwin";
            this.GoalFilter1.ThemeName = "MetroDark";
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
            this.GoalFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.GoalFilter2.Location = new System.Drawing.Point(21, 195);
            this.GoalFilter2.MaxDropDownItems = 20;
            this.GoalFilter2.Name = "GoalFilter2";
            this.GoalFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GoalFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.GoalFilter2.Size = new System.Drawing.Size(173, 36);
            this.GoalFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.GoalFilter2.StyleManager = null;
            this.GoalFilter2.TabIndex = 1;
            this.GoalFilter2.Tag = "Division";
            this.GoalFilter2.ThemeAuthor = "Narwin";
            this.GoalFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.GoalChart.Series.Add(chartSeries11);
            this.GoalChart.Series.Add(chartSeries12);
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
            this.GoalChart.ToolBar.Items.Add(chartToolBarSaveItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarCopyItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPrintItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarPaletteItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarTypeItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarSeries3DItem6);
            this.GoalChart.ToolBar.Items.Add(chartToolBarShowLegendItem6);
            // 
            // NpmTab
            // 
            this.NpmTab.Controls.Add(this.NpmExpander2);
            this.NpmTab.Controls.Add(this.NpmExpander1);
            this.NpmTab.Controls.Add(this.NpmChart);
            this.NpmTab.Image = null;
            this.NpmTab.ImageSize = new System.Drawing.Size(16, 16);
            this.NpmTab.Location = new System.Drawing.Point(0, 39);
            this.NpmTab.Name = "NpmTab";
            this.NpmTab.ShowCloseButton = true;
            this.NpmTab.Size = new System.Drawing.Size(1679, 895);
            this.NpmTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmTab.TabIndex = 3;
            this.NpmTab.Tag = "HQ National Program Office";
            this.NpmTab.Text = "NPM";
            this.NpmTab.ThemesEnabled = false;
            // 
            // NpmExpander2
            // 
            this.NpmExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NpmExpander2.BackColor = System.Drawing.Color.Black;
            this.NpmExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.NpmExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.NpmExpander2.Controls.Add(this.label7);
            this.NpmExpander2.Controls.Add(this.label27);
            this.NpmExpander2.Controls.Add(this.NpmFilter4);
            this.NpmExpander2.Controls.Add(this.NpmFilter3);
            this.NpmExpander2.ExpandedHeight = 292;
            this.NpmExpander2.IsExpanded = false;
            this.NpmExpander2.Location = new System.Drawing.Point(1371, 417);
            this.NpmExpander2.Name = "NpmExpander2";
            this.NpmExpander2.Size = new System.Drawing.Size(220, 37);
            this.NpmExpander2.TabIndex = 110;
            this.NpmExpander2.Text = "Chart Filters";
            this.NpmExpander2.UseAnimation = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label7.Location = new System.Drawing.Point(27, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 116;
            this.label7.Text = " Filter";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label27.Location = new System.Drawing.Point(27, 182);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 22);
            this.label27.TabIndex = 116;
            this.label27.Text = "Grouping";
            // 
            // NpmFilter4
            // 
            this.NpmFilter4.AllowDrop = true;
            this.NpmFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter4.BackColor = System.Drawing.Color.Transparent;
            this.NpmFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NpmFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter4.CausesValidation = false;
            this.NpmFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NpmFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NpmFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter4.FormattingEnabled = true;
            this.NpmFilter4.ItemHeight = 30;
            this.NpmFilter4.Items.AddRange(new object[] {
            "Fund",
            "BOC",
            "Goal",
            "RC",
            "Objective",
            "ProgramArea"});
            this.NpmFilter4.Location = new System.Drawing.Point(27, 216);
            this.NpmFilter4.MaxDropDownItems = 20;
            this.NpmFilter4.Name = "NpmFilter4";
            this.NpmFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter4.Size = new System.Drawing.Size(173, 36);
            this.NpmFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter4.StyleManager = null;
            this.NpmFilter4.TabIndex = 108;
            this.NpmFilter4.Tag = "RC";
            this.NpmFilter4.ThemeAuthor = "Narwin";
            this.NpmFilter4.ThemeName = "MetroDark";
            // 
            // NpmFilter3
            // 
            this.NpmFilter3.AllowDrop = true;
            this.NpmFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter3.BackColor = System.Drawing.Color.Transparent;
            this.NpmFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NpmFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.NpmFilter3.CausesValidation = false;
            this.NpmFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NpmFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NpmFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NpmFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter3.FormattingEnabled = true;
            this.NpmFilter3.ItemHeight = 30;
            this.NpmFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.NpmFilter3.Location = new System.Drawing.Point(27, 110);
            this.NpmFilter3.MaxDropDownItems = 20;
            this.NpmFilter3.Name = "NpmFilter3";
            this.NpmFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter3.Size = new System.Drawing.Size(173, 36);
            this.NpmFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter3.StyleManager = null;
            this.NpmFilter3.TabIndex = 108;
            this.NpmFilter3.Tag = "NPM";
            this.NpmFilter3.ThemeAuthor = "Narwin";
            this.NpmFilter3.ThemeName = "MetroDark";
            // 
            // NpmExpander1
            // 
            this.NpmExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NpmExpander1.BackColor = System.Drawing.Color.Black;
            this.NpmExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.NpmExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.NpmExpander1.Controls.Add(this.label8);
            this.NpmExpander1.Controls.Add(this.label9);
            this.NpmExpander1.Controls.Add(this.NpmFilter2);
            this.NpmExpander1.Controls.Add(this.NpmFilter1);
            this.NpmExpander1.ExpandedHeight = 275;
            this.NpmExpander1.IsExpanded = false;
            this.NpmExpander1.Location = new System.Drawing.Point(1371, 100);
            this.NpmExpander1.Name = "NpmExpander1";
            this.NpmExpander1.Size = new System.Drawing.Size(220, 37);
            this.NpmExpander1.TabIndex = 108;
            this.NpmExpander1.Text = "Chart Configuration";
            this.NpmExpander1.UseAnimation = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label8.Location = new System.Drawing.Point(34, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 119;
            this.label8.Text = "Measure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label9.Location = new System.Drawing.Point(34, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 118;
            this.label9.Text = "Chart Type";
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
            this.NpmFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter2.FormattingEnabled = true;
            this.NpmFilter2.ItemHeight = 30;
            this.NpmFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.NpmFilter2.Location = new System.Drawing.Point(27, 197);
            this.NpmFilter2.MaxDropDownItems = 20;
            this.NpmFilter2.Name = "NpmFilter2";
            this.NpmFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter2.Size = new System.Drawing.Size(162, 36);
            this.NpmFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter2.StyleManager = null;
            this.NpmFilter2.TabIndex = 110;
            this.NpmFilter2.Tag = "Division";
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
            this.NpmFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NpmFilter1.FormattingEnabled = true;
            this.NpmFilter1.ItemHeight = 30;
            this.NpmFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.NpmFilter1.Location = new System.Drawing.Point(27, 91);
            this.NpmFilter1.MaxDropDownItems = 20;
            this.NpmFilter1.Name = "NpmFilter1";
            this.NpmFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NpmFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.NpmFilter1.Size = new System.Drawing.Size(162, 36);
            this.NpmFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.NpmFilter1.StyleManager = null;
            this.NpmFilter1.TabIndex = 113;
            this.NpmFilter1.Tag = "Division";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.NpmChart.Series.Add(chartSeries13);
            this.NpmChart.Series.Add(chartSeries14);
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
            this.NpmChart.ToolBar.Items.Add(chartToolBarSaveItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarCopyItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPrintItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarPaletteItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarTypeItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarSeries3DItem7);
            this.NpmChart.ToolBar.Items.Add(chartToolBarShowLegendItem7);
            // 
            // BocTab
            // 
            this.BocTab.Controls.Add(this.BocExpander2);
            this.BocTab.Controls.Add(this.BocExpander1);
            this.BocTab.Controls.Add(this.BocChart);
            this.BocTab.Image = null;
            this.BocTab.ImageSize = new System.Drawing.Size(16, 16);
            this.BocTab.Location = new System.Drawing.Point(0, 39);
            this.BocTab.Name = "BocTab";
            this.BocTab.ShowCloseButton = true;
            this.BocTab.Size = new System.Drawing.Size(1679, 895);
            this.BocTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocTab.TabIndex = 2;
            this.BocTab.Tag = "Budget Object Class";
            this.BocTab.Text = "BOC";
            this.BocTab.ThemesEnabled = false;
            // 
            // BocExpander2
            // 
            this.BocExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BocExpander2.BackColor = System.Drawing.Color.Black;
            this.BocExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.BocExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.BocExpander2.Controls.Add(this.label35);
            this.BocExpander2.Controls.Add(this.label36);
            this.BocExpander2.Controls.Add(this.BocFilter4);
            this.BocExpander2.Controls.Add(this.BocFilter3);
            this.BocExpander2.ExpandedHeight = 292;
            this.BocExpander2.IsExpanded = false;
            this.BocExpander2.Location = new System.Drawing.Point(1371, 417);
            this.BocExpander2.Name = "BocExpander2";
            this.BocExpander2.Size = new System.Drawing.Size(232, 37);
            this.BocExpander2.TabIndex = 109;
            this.BocExpander2.Text = "Chart Filters";
            this.BocExpander2.UseAnimation = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label35.Location = new System.Drawing.Point(21, 66);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 22);
            this.label35.TabIndex = 117;
            this.label35.Text = "Filter";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label36.Location = new System.Drawing.Point(24, 197);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(84, 22);
            this.label36.TabIndex = 118;
            this.label36.Text = "Grouping";
            // 
            // BocFilter4
            // 
            this.BocFilter4.AllowDrop = true;
            this.BocFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter4.BackColor = System.Drawing.Color.Transparent;
            this.BocFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BocFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter4.CausesValidation = false;
            this.BocFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BocFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BocFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter4.FormattingEnabled = true;
            this.BocFilter4.ItemHeight = 30;
            this.BocFilter4.Items.AddRange(new object[] {
            "Fund",
            "NPM",
            "Goal",
            "RC",
            "Objective",
            "ProgramArea"});
            this.BocFilter4.Location = new System.Drawing.Point(24, 220);
            this.BocFilter4.MaxDropDownItems = 20;
            this.BocFilter4.Name = "BocFilter4";
            this.BocFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter4.Size = new System.Drawing.Size(173, 36);
            this.BocFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter4.StyleManager = null;
            this.BocFilter4.TabIndex = 108;
            this.BocFilter4.Tag = "RC";
            this.BocFilter4.ThemeAuthor = "Narwin";
            this.BocFilter4.ThemeName = "MetroDark";
            // 
            // BocFilter3
            // 
            this.BocFilter3.AllowDrop = true;
            this.BocFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter3.BackColor = System.Drawing.Color.Transparent;
            this.BocFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BocFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BocFilter3.CausesValidation = false;
            this.BocFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BocFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BocFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BocFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter3.FormattingEnabled = true;
            this.BocFilter3.ItemHeight = 30;
            this.BocFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.BocFilter3.Location = new System.Drawing.Point(24, 91);
            this.BocFilter3.MaxDropDownItems = 20;
            this.BocFilter3.Name = "BocFilter3";
            this.BocFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter3.Size = new System.Drawing.Size(173, 36);
            this.BocFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter3.StyleManager = null;
            this.BocFilter3.TabIndex = 108;
            this.BocFilter3.Tag = "BocName";
            this.BocFilter3.ThemeAuthor = "Narwin";
            this.BocFilter3.ThemeName = "MetroDark";
            // 
            // BocExpander1
            // 
            this.BocExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BocExpander1.BackColor = System.Drawing.Color.Black;
            this.BocExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.BocExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.BocExpander1.Controls.Add(this.label5);
            this.BocExpander1.Controls.Add(this.label6);
            this.BocExpander1.Controls.Add(this.BocFilter1);
            this.BocExpander1.Controls.Add(this.BocFilter2);
            this.BocExpander1.ExpandedHeight = 258;
            this.BocExpander1.IsExpanded = false;
            this.BocExpander1.Location = new System.Drawing.Point(1371, 100);
            this.BocExpander1.Name = "BocExpander1";
            this.BocExpander1.Size = new System.Drawing.Size(232, 37);
            this.BocExpander1.TabIndex = 108;
            this.BocExpander1.Text = "Chart Configuration";
            this.BocExpander1.UseAnimation = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Measure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 118;
            this.label6.Text = "Chart Type";
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
            this.BocFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter1.FormattingEnabled = true;
            this.BocFilter1.ItemHeight = 30;
            this.BocFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.BocFilter1.Location = new System.Drawing.Point(28, 84);
            this.BocFilter1.MaxDropDownItems = 20;
            this.BocFilter1.Name = "BocFilter1";
            this.BocFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter1.Size = new System.Drawing.Size(173, 36);
            this.BocFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter1.StyleManager = null;
            this.BocFilter1.TabIndex = 112;
            this.BocFilter1.Tag = "Division";
            this.BocFilter1.ThemeAuthor = "Narwin";
            this.BocFilter1.ThemeName = "MetroDark";
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
            this.BocFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BocFilter2.FormattingEnabled = true;
            this.BocFilter2.ItemHeight = 30;
            this.BocFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.BocFilter2.Location = new System.Drawing.Point(28, 189);
            this.BocFilter2.MaxDropDownItems = 20;
            this.BocFilter2.Name = "BocFilter2";
            this.BocFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BocFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.BocFilter2.Size = new System.Drawing.Size(173, 36);
            this.BocFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.BocFilter2.StyleManager = null;
            this.BocFilter2.TabIndex = 1;
            this.BocFilter2.Tag = "Division";
            this.BocFilter2.ThemeAuthor = "Narwin";
            this.BocFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
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
            this.BocChart.Series.Add(chartSeries15);
            this.BocChart.Series.Add(chartSeries16);
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
            this.BocChart.ToolBar.Items.Add(chartToolBarSaveItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarCopyItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarPrintItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarPaletteItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarTypeItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarSeries3DItem8);
            this.BocChart.ToolBar.Items.Add(chartToolBarShowLegendItem8);
            // 
            // FundTab
            // 
            this.FundTab.Controls.Add(this.FundExpander2);
            this.FundTab.Controls.Add(this.FundExpander1);
            this.FundTab.Controls.Add(this.FundChart);
            this.FundTab.Image = null;
            this.FundTab.ImageSize = new System.Drawing.Size(16, 16);
            this.FundTab.Location = new System.Drawing.Point(0, 39);
            this.FundTab.Name = "FundTab";
            this.FundTab.ShowCloseButton = true;
            this.FundTab.Size = new System.Drawing.Size(1679, 895);
            this.FundTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundTab.TabIndex = 1;
            this.FundTab.Tag = "Appropriation";
            this.FundTab.Text = "Fund";
            this.FundTab.ThemesEnabled = false;
            // 
            // FundExpander2
            // 
            this.FundExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundExpander2.BackColor = System.Drawing.Color.Black;
            this.FundExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.FundExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.FundExpander2.Controls.Add(this.label3);
            this.FundExpander2.Controls.Add(this.label25);
            this.FundExpander2.Controls.Add(this.FundFilter4);
            this.FundExpander2.Controls.Add(this.FundFilter3);
            this.FundExpander2.ExpandedHeight = 292;
            this.FundExpander2.IsExpanded = false;
            this.FundExpander2.Location = new System.Drawing.Point(1371, 417);
            this.FundExpander2.Name = "FundExpander2";
            this.FundExpander2.Size = new System.Drawing.Size(229, 37);
            this.FundExpander2.TabIndex = 108;
            this.FundExpander2.Text = "Chart Filters";
            this.FundExpander2.UseAnimation = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 116;
            this.label3.Text = "Filter";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label25.Location = new System.Drawing.Point(34, 195);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 22);
            this.label25.TabIndex = 116;
            this.label25.Text = "Grouping";
            // 
            // FundFilter4
            // 
            this.FundFilter4.AllowDrop = true;
            this.FundFilter4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter4.BackColor = System.Drawing.Color.Transparent;
            this.FundFilter4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FundFilter4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter4.CausesValidation = false;
            this.FundFilter4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FundFilter4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FundFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter4.FormattingEnabled = true;
            this.FundFilter4.ItemHeight = 30;
            this.FundFilter4.Items.AddRange(new object[] {
            "BOC",
            "NPM",
            "Goal",
            "Objective",
            "RC",
            "ProgramArea"});
            this.FundFilter4.Location = new System.Drawing.Point(35, 229);
            this.FundFilter4.MaxDropDownItems = 20;
            this.FundFilter4.Name = "FundFilter4";
            this.FundFilter4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter4.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter4.Size = new System.Drawing.Size(173, 36);
            this.FundFilter4.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter4.StyleManager = null;
            this.FundFilter4.TabIndex = 108;
            this.FundFilter4.Tag = "RC";
            this.FundFilter4.ThemeAuthor = "Narwin";
            this.FundFilter4.ThemeName = "MetroDark";
            // 
            // FundFilter3
            // 
            this.FundFilter3.AllowDrop = true;
            this.FundFilter3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter3.BackColor = System.Drawing.Color.Transparent;
            this.FundFilter3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FundFilter3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.FundFilter3.CausesValidation = false;
            this.FundFilter3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FundFilter3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FundFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FundFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter3.FormattingEnabled = true;
            this.FundFilter3.ItemHeight = 30;
            this.FundFilter3.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.FundFilter3.Location = new System.Drawing.Point(35, 99);
            this.FundFilter3.MaxDropDownItems = 20;
            this.FundFilter3.Name = "FundFilter3";
            this.FundFilter3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter3.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter3.Size = new System.Drawing.Size(173, 36);
            this.FundFilter3.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter3.StyleManager = null;
            this.FundFilter3.TabIndex = 108;
            this.FundFilter3.Tag = "FundName";
            this.FundFilter3.ThemeAuthor = "Narwin";
            this.FundFilter3.ThemeName = "MetroDark";
            // 
            // FundExpander1
            // 
            this.FundExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundExpander1.BackColor = System.Drawing.Color.Black;
            this.FundExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.FundExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.FundExpander1.Controls.Add(this.label2);
            this.FundExpander1.Controls.Add(this.label1);
            this.FundExpander1.Controls.Add(this.FundFilter1);
            this.FundExpander1.Controls.Add(this.FundFilter2);
            this.FundExpander1.ExpandedHeight = 283;
            this.FundExpander1.IsExpanded = false;
            this.FundExpander1.Location = new System.Drawing.Point(1371, 100);
            this.FundExpander1.Name = "FundExpander1";
            this.FundExpander1.Size = new System.Drawing.Size(229, 37);
            this.FundExpander1.TabIndex = 107;
            this.FundExpander1.Text = "Chart Configuration";
            this.FundExpander1.UseAnimation = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(31, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 115;
            this.label2.Text = "Measure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 114;
            this.label1.Text = "Chart Type";
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
            this.FundFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FundFilter1.FormattingEnabled = true;
            this.FundFilter1.ItemHeight = 30;
            this.FundFilter1.Items.AddRange(new object[] {
            "Pie ",
            "Column"});
            this.FundFilter1.Location = new System.Drawing.Point(32, 90);
            this.FundFilter1.MaxDropDownItems = 20;
            this.FundFilter1.Name = "FundFilter1";
            this.FundFilter1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter1.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter1.Size = new System.Drawing.Size(173, 36);
            this.FundFilter1.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter1.StyleManager = null;
            this.FundFilter1.TabIndex = 113;
            this.FundFilter1.Tag = "Division";
            this.FundFilter1.ThemeAuthor = "Narwin";
            this.FundFilter1.ThemeName = "MetroDark";
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
            this.FundFilter2.Items.AddRange(new object[] {
            "Total ",
            "Count",
            "Average",
            "Ratio"});
            this.FundFilter2.Location = new System.Drawing.Point(32, 198);
            this.FundFilter2.MaxDropDownItems = 20;
            this.FundFilter2.Name = "FundFilter2";
            this.FundFilter2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FundFilter2.SelectedItemForeColor = System.Drawing.Color.White;
            this.FundFilter2.Size = new System.Drawing.Size(173, 36);
            this.FundFilter2.Style = MetroSet_UI.Design.Style.Dark;
            this.FundFilter2.StyleManager = null;
            this.FundFilter2.TabIndex = 1;
            this.FundFilter2.Tag = "Division";
            this.FundFilter2.ThemeAuthor = "Narwin";
            this.FundFilter2.ThemeName = "MetroDark";
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
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
            this.FundChart.DataSourceName = "FundBindingSource";
            this.FundChart.Depth = 250F;
            this.FundChart.DisplayChartContextMenu = false;
            this.FundChart.DisplaySeriesContextMenu = false;
            this.FundChart.EnableMouseRotation = true;
            this.FundChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FundChart.HighlightSymbol = true;
            this.FundChart.Indexed = true;
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
            this.FundChart.PrimaryXAxis.ShowCrosshairTooltip = true;
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
            this.FundChart.Series.Add(chartSeries17);
            this.FundChart.Series.Add(chartSeries18);
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
            this.FundChart.ToolBar.Items.Add(chartToolBarSaveItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarCopyItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarPrintItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarPaletteItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarTypeItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarSeries3DItem9);
            this.FundChart.ToolBar.Items.Add(chartToolBarShowLegendItem9);
            // 
            // SummaryTabControl
            // 
            this.SummaryTabControl.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.SummaryTabControl.ActiveTabForeColor = System.Drawing.SystemColors.HighlightText;
            this.SummaryTabControl.AdjustTopGap = 5;
            this.SummaryTabControl.BeforeTouchSize = new System.Drawing.Size(1679, 934);
            this.SummaryTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummaryTabControl.BorderWidth = 0;
            this.SummaryTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
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
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.Color.Black;
            this.SummaryTabControl.FocusOnTabClick = false;
            this.SummaryTabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.DimGray;
            this.SummaryTabControl.ItemSize = new System.Drawing.Size(150, 45);
            this.SummaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.SummaryTabControl.Multiline = true;
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.Padding = new System.Drawing.Point(10, 6);
            this.SummaryTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.SummaryTabControl.ShowScroll = false;
            this.SummaryTabControl.ShowSeparator = true;
            this.SummaryTabControl.Size = new System.Drawing.Size(1679, 934);
            this.SummaryTabControl.TabGap = 5;
            this.SummaryTabControl.TabIndex = 0;
            this.SummaryTabControl.TabPanelBackColor = System.Drawing.Color.Black;
            this.SummaryTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.SummaryTabControl.SelectedIndexChanged += new System.EventHandler(this.SummaryTabPage_TabSelected);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.BackColor = System.Drawing.Color.Black;
            this.DatabaseTab.Controls.Add(this.groupBox5);
            this.DatabaseTab.Controls.Add(this.groupBox1);
            this.DatabaseTab.Controls.Add(this.FilterGroupBox);
            this.DatabaseTab.Image = null;
            this.DatabaseTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DatabaseTab.Location = new System.Drawing.Point(0, 39);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(1);
            this.DatabaseTab.ShowCloseButton = true;
            this.DatabaseTab.Size = new System.Drawing.Size(1679, 895);
            this.DatabaseTab.TabIndex = 9;
            this.DatabaseTab.Tag = "Database";
            this.DatabaseTab.Text = "Account Manager";
            this.DatabaseTab.ThemesEnabled = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox5.Controls.Add(this.AccountTabControl);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Location = new System.Drawing.Point(1170, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 526);
            this.groupBox5.TabIndex = 161;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Allocation";
            // 
            // AccountTabControl
            // 
            this.AccountTabControl.ActiveTabForeColor = System.Drawing.Color.White;
            this.AccountTabControl.AdjustTopGap = 10;
            this.AccountTabControl.BackColor = System.Drawing.Color.Black;
            this.AccountTabControl.BeforeTouchSize = new System.Drawing.Size(464, 501);
            this.AccountTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountTabControl.BorderWidth = 1;
            this.AccountTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.AccountTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.Controls.Add(this.UpdateTab);
            this.AccountTabControl.Controls.Add(this.tabPageAdv5);
            this.AccountTabControl.Controls.Add(this.tabPageAdv6);
            this.AccountTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountTabControl.FocusOnTabClick = false;
            this.AccountTabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountTabControl.InActiveTabForeColor = System.Drawing.Color.DarkGray;
            this.AccountTabControl.ItemSize = new System.Drawing.Size(150, 25);
            this.AccountTabControl.LevelTextAndImage = true;
            this.AccountTabControl.Location = new System.Drawing.Point(3, 22);
            this.AccountTabControl.Multiline = true;
            this.AccountTabControl.Name = "AccountTabControl";
            this.AccountTabControl.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.AccountTabControl.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.AccountTabControl.Padding = new System.Drawing.Point(6, 1);
            this.AccountTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.AccountTabControl.ShowSeparator = true;
            this.AccountTabControl.Size = new System.Drawing.Size(464, 501);
            this.AccountTabControl.TabGap = 7;
            this.AccountTabControl.TabIndex = 150;
            this.AccountTabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccountTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.AccountTabControl.VSLikeScrollButton = true;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.button5);
            this.UpdateTab.Controls.Add(this.button4);
            this.UpdateTab.Controls.Add(this.button3);
            this.UpdateTab.Controls.Add(this.button1);
            this.UpdateTab.Controls.Add(this.metroSetLabel20);
            this.UpdateTab.Controls.Add(this.BudgetLevel);
            this.UpdateTab.Controls.Add(this.metroSetLabel19);
            this.UpdateTab.Controls.Add(this.ID);
            this.UpdateTab.Controls.Add(this.metroSetLabel1);
            this.UpdateTab.Controls.Add(this.metroSetLabel2);
            this.UpdateTab.Controls.Add(this.metroSetTextBox1);
            this.UpdateTab.Controls.Add(this.Amount);
            this.UpdateTab.Controls.Add(this.Code);
            this.UpdateTab.Controls.Add(this.BOC);
            this.UpdateTab.Controls.Add(this.metroSetLabel12);
            this.UpdateTab.Controls.Add(this.metroSetLabel13);
            this.UpdateTab.Controls.Add(this.metroSetLabel14);
            this.UpdateTab.Controls.Add(this.metroSetLabel16);
            this.UpdateTab.Controls.Add(this.RC);
            this.UpdateTab.Controls.Add(this.Fund);
            this.UpdateTab.Controls.Add(this.metroSetLabel17);
            this.UpdateTab.Controls.Add(this.metroSetLabel18);
            this.UpdateTab.Controls.Add(this.BFY);
            this.UpdateTab.Controls.Add(this.Org);
            this.UpdateTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTab.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.UpdateTab.Image = ((System.Drawing.Image)(resources.GetObject("UpdateTab.Image")));
            this.UpdateTab.ImageSize = new System.Drawing.Size(30, 30);
            this.UpdateTab.Location = new System.Drawing.Point(0, 44);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.ShowCloseButton = true;
            this.UpdateTab.Size = new System.Drawing.Size(464, 457);
            this.UpdateTab.TabIndex = 4;
            this.UpdateTab.ThemesEnabled = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(256, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 160;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(256, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 159;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(359, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 158;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(359, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 157;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroSetLabel20
            // 
            this.metroSetLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel20.Location = new System.Drawing.Point(110, 17);
            this.metroSetLabel20.Name = "metroSetLabel20";
            this.metroSetLabel20.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel20.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel20.StyleManager = null;
            this.metroSetLabel20.TabIndex = 156;
            this.metroSetLabel20.Text = "Level";
            this.metroSetLabel20.ThemeAuthor = "Narwin";
            this.metroSetLabel20.ThemeName = "MetroDark";
            // 
            // BudgetLevel
            // 
            this.BudgetLevel.AutoCompleteCustomSource = null;
            this.BudgetLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BudgetLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BudgetLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BudgetLevel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BudgetLevel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BudgetLevel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BudgetLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLevel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BudgetLevel.Image = null;
            this.BudgetLevel.Lines = null;
            this.BudgetLevel.Location = new System.Drawing.Point(111, 43);
            this.BudgetLevel.MaxLength = 32767;
            this.BudgetLevel.Multiline = false;
            this.BudgetLevel.Name = "BudgetLevel";
            this.BudgetLevel.ReadOnly = false;
            this.BudgetLevel.Size = new System.Drawing.Size(61, 40);
            this.BudgetLevel.Style = MetroSet_UI.Design.Style.Dark;
            this.BudgetLevel.StyleManager = null;
            this.BudgetLevel.TabIndex = 155;
            this.BudgetLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BudgetLevel.ThemeAuthor = "Narwin";
            this.BudgetLevel.ThemeName = "MetroDark";
            this.BudgetLevel.UseSystemPasswordChar = false;
            this.BudgetLevel.WatermarkText = "";
            // 
            // metroSetLabel19
            // 
            this.metroSetLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel19.Location = new System.Drawing.Point(14, 17);
            this.metroSetLabel19.Name = "metroSetLabel19";
            this.metroSetLabel19.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel19.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel19.StyleManager = null;
            this.metroSetLabel19.TabIndex = 154;
            this.metroSetLabel19.Text = "ID";
            this.metroSetLabel19.ThemeAuthor = "Narwin";
            this.metroSetLabel19.ThemeName = "MetroDark";
            // 
            // ID
            // 
            this.ID.AutoCompleteCustomSource = null;
            this.ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ID.Image = null;
            this.ID.Lines = null;
            this.ID.Location = new System.Drawing.Point(14, 43);
            this.ID.MaxLength = 32767;
            this.ID.Multiline = false;
            this.ID.Name = "ID";
            this.ID.ReadOnly = false;
            this.ID.Size = new System.Drawing.Size(61, 40);
            this.ID.Style = MetroSet_UI.Design.Style.Dark;
            this.ID.StyleManager = null;
            this.ID.TabIndex = 153;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.ThemeAuthor = "Narwin";
            this.ID.ThemeName = "MetroDark";
            this.ID.UseSystemPasswordChar = false;
            this.ID.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(300, 99);
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
            this.metroSetLabel2.Location = new System.Drawing.Point(192, 99);
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
            this.metroSetTextBox1.Location = new System.Drawing.Point(26, 310);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(165, 40);
            this.metroSetTextBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 137;
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
            this.Amount.Location = new System.Drawing.Point(26, 226);
            this.Amount.MaxLength = 32767;
            this.Amount.Multiline = false;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = false;
            this.Amount.Size = new System.Drawing.Size(165, 40);
            this.Amount.Style = MetroSet_UI.Design.Style.Dark;
            this.Amount.StyleManager = null;
            this.Amount.TabIndex = 136;
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
            this.Code.Location = new System.Drawing.Point(279, 128);
            this.Code.MaxLength = 32767;
            this.Code.Multiline = false;
            this.Code.Name = "Code";
            this.Code.ReadOnly = false;
            this.Code.Size = new System.Drawing.Size(155, 40);
            this.Code.Style = MetroSet_UI.Design.Style.Dark;
            this.Code.StyleManager = null;
            this.Code.TabIndex = 135;
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BOC.Location = new System.Drawing.Point(192, 128);
            this.BOC.MaxLength = 32767;
            this.BOC.Multiline = false;
            this.BOC.Name = "BOC";
            this.BOC.ReadOnly = false;
            this.BOC.Size = new System.Drawing.Size(62, 40);
            this.BOC.Style = MetroSet_UI.Design.Style.Dark;
            this.BOC.StyleManager = null;
            this.BOC.TabIndex = 134;
            this.BOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BOC.ThemeAuthor = "Narwin";
            this.BOC.ThemeName = "MetroDark";
            this.BOC.UseSystemPasswordChar = false;
            this.BOC.WatermarkText = "";
            // 
            // metroSetLabel12
            // 
            this.metroSetLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel12.Location = new System.Drawing.Point(26, 284);
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
            this.metroSetLabel13.Location = new System.Drawing.Point(26, 200);
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
            this.metroSetLabel14.Location = new System.Drawing.Point(334, 17);
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
            this.metroSetLabel16.Location = new System.Drawing.Point(111, 102);
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
            this.RC.Location = new System.Drawing.Point(111, 128);
            this.RC.MaxLength = 32767;
            this.RC.Multiline = false;
            this.RC.Name = "RC";
            this.RC.ReadOnly = false;
            this.RC.Size = new System.Drawing.Size(62, 40);
            this.RC.Style = MetroSet_UI.Design.Style.Dark;
            this.RC.StyleManager = null;
            this.RC.TabIndex = 129;
            this.RC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Fund.Location = new System.Drawing.Point(334, 43);
            this.Fund.MaxLength = 32767;
            this.Fund.Multiline = false;
            this.Fund.Name = "Fund";
            this.Fund.ReadOnly = false;
            this.Fund.Size = new System.Drawing.Size(84, 40);
            this.Fund.Style = MetroSet_UI.Design.Style.Dark;
            this.Fund.StyleManager = null;
            this.Fund.TabIndex = 128;
            this.Fund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fund.ThemeAuthor = "Narwin";
            this.Fund.ThemeName = "MetroDark";
            this.Fund.UseSystemPasswordChar = false;
            this.Fund.WatermarkText = "";
            // 
            // metroSetLabel17
            // 
            this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel17.Location = new System.Drawing.Point(197, 17);
            this.metroSetLabel17.Name = "metroSetLabel17";
            this.metroSetLabel17.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel17.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel17.StyleManager = null;
            this.metroSetLabel17.TabIndex = 16;
            this.metroSetLabel17.Text = "Year";
            this.metroSetLabel17.ThemeAuthor = "Narwin";
            this.metroSetLabel17.ThemeName = "MetroDark";
            // 
            // metroSetLabel18
            // 
            this.metroSetLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel18.Location = new System.Drawing.Point(14, 102);
            this.metroSetLabel18.Name = "metroSetLabel18";
            this.metroSetLabel18.Size = new System.Drawing.Size(74, 23);
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
            this.BFY.Location = new System.Drawing.Point(197, 43);
            this.BFY.MaxLength = 32767;
            this.BFY.Multiline = false;
            this.BFY.Name = "BFY";
            this.BFY.ReadOnly = false;
            this.BFY.Size = new System.Drawing.Size(93, 40);
            this.BFY.Style = MetroSet_UI.Design.Style.Dark;
            this.BFY.StyleManager = null;
            this.BFY.TabIndex = 125;
            this.BFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Org.Location = new System.Drawing.Point(14, 128);
            this.Org.MaxLength = 32767;
            this.Org.Multiline = false;
            this.Org.Name = "Org";
            this.Org.ReadOnly = false;
            this.Org.Size = new System.Drawing.Size(74, 40);
            this.Org.Style = MetroSet_UI.Design.Style.Dark;
            this.Org.StyleManager = null;
            this.Org.TabIndex = 124;
            this.Org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Org.ThemeAuthor = "Narwin";
            this.Org.ThemeName = "MetroDark";
            this.Org.UseSystemPasswordChar = false;
            this.Org.WatermarkText = "";
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.AccountChart);
            this.tabPageAdv5.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv5.Image")));
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(30, 30);
            this.tabPageAdv5.Location = new System.Drawing.Point(0, 44);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(464, 457);
            this.tabPageAdv5.TabIndex = 2;
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // AccountChart
            // 
            this.AccountChart.AllowGradientPalette = true;
            this.AccountChart.AllowUserEditStyles = true;
            this.AccountChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.AccountChart.ChartArea.AutoScale = true;
            this.AccountChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.AccountChart.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.AccountChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.AccountChart.ChartArea.CursorReDraw = false;
            this.AccountChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 10);
            this.AccountChart.ChartAreaShadow = true;
            this.AccountChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, new System.Drawing.Color[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DimGray});
            this.AccountChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy};
            this.AccountChart.DataSourceName = "FundBindingSource";
            this.AccountChart.Depth = 250F;
            this.AccountChart.DisplayChartContextMenu = false;
            this.AccountChart.DisplaySeriesContextMenu = false;
            this.AccountChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountChart.EnableMouseRotation = true;
            this.AccountChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountChart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountChart.HighlightSymbol = true;
            this.AccountChart.IsWindowLess = false;
            // 
            // 
            // 
            this.AccountChart.Legend.Location = new System.Drawing.Point(7, 7);
            this.AccountChart.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.AccountChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.AccountChart.Legend.Visible = false;
            this.AccountChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.AccountChart.Localize = null;
            this.AccountChart.Location = new System.Drawing.Point(0, 0);
            this.AccountChart.Margin = new System.Windows.Forms.Padding(2);
            this.AccountChart.Name = "AccountChart";
            this.AccountChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.AccountChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AccountChart.PrimaryXAxis.Margin = true;
            this.AccountChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.AccountChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AccountChart.PrimaryYAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountChart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AccountChart.PrimaryYAxis.Margin = true;
            this.AccountChart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryYAxis.TitleColor = System.Drawing.Color.White;
            this.AccountChart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.AccountChart.RealMode3D = true;
            this.AccountChart.Rotation = 45F;
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
            this.AccountChart.Series.Add(chartSeries19);
            this.AccountChart.Series.Add(chartSeries20);
            this.AccountChart.Series3D = true;
            this.AccountChart.SeriesHighlight = true;
            this.AccountChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AccountChart.Size = new System.Drawing.Size(464, 457);
            this.AccountChart.Spacing = 5F;
            this.AccountChart.SpacingBetweenPoints = 5F;
            this.AccountChart.Style3D = true;
            this.AccountChart.TabIndex = 44;
            this.AccountChart.Tilt = 15F;
            // 
            // 
            // 
            this.AccountChart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AccountChart.Title.Name = "Default";
            this.AccountChart.ToolBar.EnableDefaultItems = false;
            this.AccountChart.ToolBar.Items.Add(chartToolBarSaveItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarCopyItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarPrintItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarPaletteItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarTypeItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarSeries3DItem10);
            this.AccountChart.ToolBar.Items.Add(chartToolBarShowLegendItem10);
            this.AccountChart.Click += new System.EventHandler(this.AccountChart_Click);
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.Black;
            this.tabPageAdv6.Controls.Add(this.button2);
            this.tabPageAdv6.Controls.Add(this.ExcelButton);
            this.tabPageAdv6.Controls.Add(this.CalculatorButton);
            this.tabPageAdv6.Controls.Add(this.CalendatButton);
            this.tabPageAdv6.Image = ((System.Drawing.Image)(resources.GetObject("tabPageAdv6.Image")));
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(30, 30);
            this.tabPageAdv6.Location = new System.Drawing.Point(0, 44);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(464, 457);
            this.tabPageAdv6.TabIndex = 3;
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(68, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reprogram";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReprogramButton_OnClick);
            // 
            // ExcelButton
            // 
            this.ExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExcelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExcelButton.FlatAppearance.BorderSize = 0;
            this.ExcelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.ExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExcelButton.Location = new System.Drawing.Point(278, 71);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(128, 85);
            this.ExcelButton.TabIndex = 3;
            this.ExcelButton.Text = "Worksheet";
            this.ExcelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExcelButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CalculatorButton.Location = new System.Drawing.Point(68, 283);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(121, 100);
            this.CalculatorButton.TabIndex = 2;
            this.CalculatorButton.Text = "Calculator";
            this.CalculatorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalculatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalculatorButton.UseVisualStyleBackColor = true;
            // 
            // CalendatButton
            // 
            this.CalendatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CalendatButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalendatButton.FlatAppearance.BorderSize = 0;
            this.CalendatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.CalendatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CalendatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendatButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CalendatButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendatButton.Image")));
            this.CalendatButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CalendatButton.Location = new System.Drawing.Point(297, 283);
            this.CalendatButton.Name = "CalendatButton";
            this.CalendatButton.Size = new System.Drawing.Size(97, 71);
            this.CalendatButton.TabIndex = 1;
            this.CalendatButton.Text = "Calendar";
            this.CalendatButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalendatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalendatButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.Navigator);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(296, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(830, 526);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.89888F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.10112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label32, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label37, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label40, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 33);
            this.tableLayoutPanel1.TabIndex = 159;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Right;
            this.label31.Location = new System.Drawing.Point(5, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 33);
            this.label31.TabIndex = 153;
            this.label31.Text = "Total: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Left;
            this.label32.Location = new System.Drawing.Point(59, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 33);
            this.label32.TabIndex = 154;
            this.label32.Text = "label32";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(278, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(76, 20);
            this.label34.TabIndex = 155;
            this.label34.Text = "Average: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Left;
            this.label37.Location = new System.Drawing.Point(360, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 33);
            this.label37.TabIndex = 156;
            this.label37.Text = "label37";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Right;
            this.label40.Location = new System.Drawing.Point(590, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 33);
            this.label40.TabIndex = 159;
            this.label40.Text = "Accounts: ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Left;
            this.label41.Location = new System.Drawing.Point(680, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 33);
            this.label41.TabIndex = 160;
            this.label41.Text = "label41";
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = null;
            this.Navigator.BackColor = System.Drawing.Color.Transparent;
            this.Navigator.CountItem = this.toolStripLabel2;
            this.Navigator.DeleteItem = null;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navigator.ImageScalingSize = new System.Drawing.Size(20, 15);
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButton10,
            this.toolStripSeparator10,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripSeparator13,
            this.CopyButton,
            this.toolStripSeparator15,
            this.AddButton,
            this.toolStripSeparator18,
            this.ResetButton,
            this.toolStripSeparator16,
            this.AccountToolsButton,
            this.toolStripSeparator12});
            this.Navigator.Location = new System.Drawing.Point(2, 499);
            this.Navigator.MoveFirstItem = null;
            this.Navigator.MoveLastItem = null;
            this.Navigator.MoveNextItem = this.toolStripButton11;
            this.Navigator.MovePreviousItem = this.toolStripButton10;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.toolStripTextBox2;
            this.Navigator.Size = new System.Drawing.Size(826, 25);
            this.Navigator.TabIndex = 152;
            this.Navigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton10.Text = "Previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BackColor = System.Drawing.Color.Black;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(42, 24);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton11.Text = "Next";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(24, 22);
            this.CopyButton.Text = "toolStripButton7";
            this.CopyButton.ToolTipText = "Copy Data Into New Account";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_OnClick);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(24, 22);
            this.AddButton.Text = "toolStripButton7";
            this.AddButton.Click += new System.EventHandler(this.AddButton_OnClick);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // ResetButton
            // 
            this.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(24, 22);
            this.ResetButton.Text = "toolStripButton7";
            this.ResetButton.ToolTipText = "Reset DataTable and Filters";
            this.ResetButton.Click += new System.EventHandler(this.GridRefreshButton_OnClick);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator16.Click += new System.EventHandler(this.ToolStripSeparator16_Click);
            // 
            // AccountToolsButton
            // 
            this.AccountToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AccountToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountToolsButton.Image")));
            this.AccountToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccountToolsButton.Name = "AccountToolsButton";
            this.AccountToolsButton.Size = new System.Drawing.Size(24, 22);
            this.AccountToolsButton.Text = "toolStripButton7";
            this.AccountToolsButton.Click += new System.EventHandler(this.AccountToolsButton_OnClick);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCount.Location = new System.Drawing.Point(640, 45);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(111, 23);
            this.lblCount.Style = MetroSet_UI.Design.Style.Dark;
            this.lblCount.StyleManager = null;
            this.lblCount.TabIndex = 149;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCount.ThemeAuthor = "Narwin";
            this.lblCount.ThemeName = "MetroDark";
            this.lblCount.Click += new System.EventHandler(this.LblCount_Click);
            // 
            // Grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid.Location = new System.Drawing.Point(30, 101);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.RowTemplate.Height = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(759, 370);
            this.Grid.TabIndex = 150;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_OnDoubleClick);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.Black;
            this.FilterGroupBox.Controls.Add(this.lblPrc);
            this.FilterGroupBox.Controls.Add(this.lblBoc);
            this.FilterGroupBox.Controls.Add(this.label33);
            this.FilterGroupBox.Controls.Add(this.GridAccountFilter);
            this.FilterGroupBox.Controls.Add(this.GridRefreshButton);
            this.FilterGroupBox.Controls.Add(this.GridBocFilter);
            this.FilterGroupBox.Controls.Add(this.GridFundFilter);
            this.FilterGroupBox.ForeColor = System.Drawing.SystemColors.Info;
            this.FilterGroupBox.Location = new System.Drawing.Point(36, 131);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(207, 526);
            this.FilterGroupBox.TabIndex = 160;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrc.Location = new System.Drawing.Point(45, 273);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(105, 20);
            this.lblPrc.TabIndex = 7;
            this.lblPrc.Text = "PRC Account\r\n";
            // 
            // lblBoc
            // 
            this.lblBoc.AutoSize = true;
            this.lblBoc.ForeColor = System.Drawing.SystemColors.Info;
            this.lblBoc.Location = new System.Drawing.Point(22, 163);
            this.lblBoc.Name = "lblBoc";
            this.lblBoc.Size = new System.Drawing.Size(154, 20);
            this.lblBoc.TabIndex = 6;
            this.lblBoc.Text = "Budget Object Class";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.Info;
            this.label33.Location = new System.Drawing.Point(45, 47);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 20);
            this.label33.TabIndex = 5;
            this.label33.Text = "Appropriation";
            // 
            // GridAccountFilter
            // 
            this.GridAccountFilter.AllowDrop = true;
            this.GridAccountFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridAccountFilter.BackColor = System.Drawing.Color.Transparent;
            this.GridAccountFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GridAccountFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridAccountFilter.CausesValidation = false;
            this.GridAccountFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GridAccountFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridAccountFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridAccountFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GridAccountFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridAccountFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GridAccountFilter.FormattingEnabled = true;
            this.GridAccountFilter.ItemHeight = 30;
            this.GridAccountFilter.Location = new System.Drawing.Point(15, 311);
            this.GridAccountFilter.MaxDropDownItems = 50;
            this.GridAccountFilter.Name = "GridAccountFilter";
            this.GridAccountFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GridAccountFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.GridAccountFilter.Size = new System.Drawing.Size(173, 36);
            this.GridAccountFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.GridAccountFilter.StyleManager = null;
            this.GridAccountFilter.TabIndex = 4;
            this.GridAccountFilter.ThemeAuthor = "Narwin";
            this.GridAccountFilter.ThemeName = "MetroDark";
            // 
            // GridRefreshButton
            // 
            this.GridRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.GridRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GridRefreshButton.FlatAppearance.BorderSize = 0;
            this.GridRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.GridRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridRefreshButton.ForeColor = System.Drawing.SystemColors.Info;
            this.GridRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("GridRefreshButton.Image")));
            this.GridRefreshButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GridRefreshButton.Location = new System.Drawing.Point(39, 447);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(124, 43);
            this.GridRefreshButton.TabIndex = 2;
            this.GridRefreshButton.Text = "Refresh";
            this.GridRefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GridRefreshButton.UseVisualStyleBackColor = false;
            // 
            // GridBocFilter
            // 
            this.GridBocFilter.AllowDrop = true;
            this.GridBocFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridBocFilter.BackColor = System.Drawing.Color.Transparent;
            this.GridBocFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GridBocFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridBocFilter.CausesValidation = false;
            this.GridBocFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GridBocFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridBocFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridBocFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GridBocFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridBocFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GridBocFilter.FormattingEnabled = true;
            this.GridBocFilter.ItemHeight = 30;
            this.GridBocFilter.Location = new System.Drawing.Point(15, 193);
            this.GridBocFilter.Name = "GridBocFilter";
            this.GridBocFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GridBocFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.GridBocFilter.Size = new System.Drawing.Size(173, 36);
            this.GridBocFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.GridBocFilter.StyleManager = null;
            this.GridBocFilter.TabIndex = 3;
            this.GridBocFilter.ThemeAuthor = "Narwin";
            this.GridBocFilter.ThemeName = "MetroDark";
            // 
            // GridFundFilter
            // 
            this.GridFundFilter.AllowDrop = true;
            this.GridFundFilter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridFundFilter.BackColor = System.Drawing.Color.Transparent;
            this.GridFundFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GridFundFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.GridFundFilter.CausesValidation = false;
            this.GridFundFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GridFundFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridFundFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GridFundFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GridFundFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridFundFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridFundFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GridFundFilter.FormattingEnabled = true;
            this.GridFundFilter.ItemHeight = 30;
            this.GridFundFilter.Location = new System.Drawing.Point(15, 78);
            this.GridFundFilter.MaxDropDownItems = 15;
            this.GridFundFilter.Name = "GridFundFilter";
            this.GridFundFilter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GridFundFilter.SelectedItemForeColor = System.Drawing.Color.White;
            this.GridFundFilter.Size = new System.Drawing.Size(173, 36);
            this.GridFundFilter.Style = MetroSet_UI.Design.Style.Dark;
            this.GridFundFilter.StyleManager = null;
            this.GridFundFilter.TabIndex = 2;
            this.GridFundFilter.ThemeAuthor = "Narwin";
            this.GridFundFilter.ThemeName = "MetroDark";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton4.Text = "Previous";
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
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 60;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Top;
            this.ClientSize = new System.Drawing.Size(1679, 934);
            this.Controls.Add(this.SummaryTabControl);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Right;
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "SummaryForm";
            this.ShowIcon = false;
            this.Text = "SumForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).EndInit();
            this.MiniTabControl1.ResumeLayout(false);
            this.ProjectTab.ResumeLayout(false);
            this.ProjectExpander2.ResumeLayout(false);
            this.ProjectExpander2.PerformLayout();
            this.ProjectExpander1.ResumeLayout(false);
            this.ProjectExpander1.PerformLayout();
            this.AreaTab.ResumeLayout(false);
            this.AreaExpander2.ResumeLayout(false);
            this.AreaExpander2.PerformLayout();
            this.AreaExpander1.ResumeLayout(false);
            this.AreaExpander1.PerformLayout();
            this.DivisionTab.ResumeLayout(false);
            this.DivisionExpander2.ResumeLayout(false);
            this.DivisionExpander2.PerformLayout();
            this.DivisionExpander1.ResumeLayout(false);
            this.DivisionExpander1.PerformLayout();
            this.ObjectiveTab.ResumeLayout(false);
            this.ObjectiveExpander2.ResumeLayout(false);
            this.ObjectiveExpander2.PerformLayout();
            this.ObjectiveExpander1.ResumeLayout(false);
            this.ObjectiveExpander1.PerformLayout();
            this.GoalTab.ResumeLayout(false);
            this.GoalExpander2.ResumeLayout(false);
            this.GoalExpander2.PerformLayout();
            this.GoalExpander1.ResumeLayout(false);
            this.GoalExpander1.PerformLayout();
            this.NpmTab.ResumeLayout(false);
            this.NpmExpander2.ResumeLayout(false);
            this.NpmExpander2.PerformLayout();
            this.NpmExpander1.ResumeLayout(false);
            this.NpmExpander1.PerformLayout();
            this.BocTab.ResumeLayout(false);
            this.BocExpander2.ResumeLayout(false);
            this.BocExpander2.PerformLayout();
            this.BocExpander1.ResumeLayout(false);
            this.BocExpander1.PerformLayout();
            this.FundTab.ResumeLayout(false);
            this.FundExpander2.ResumeLayout(false);
            this.FundExpander2.PerformLayout();
            this.FundExpander1.ResumeLayout(false);
            this.FundExpander1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.DatabaseTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).EndInit();
            this.AccountTabControl.ResumeLayout(false);
            this.UpdateTab.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        private toolstripitem toolstripitem1;
        private toolstripitem toolstripitem2;
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
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private TabPageAdv tabPageAdv4;
        private CalculatorControl calculatorControl1;
        private TabPageAdv tabPageAdv3;
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
        private TabPageAdv ProjectTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ProjectExpander1;
        protected ChartControl ProjectChart;
        private ButtonEditChildButton buttonEditChildButton1;
        private TabPageAdv AreaTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel AreaExpander1;
        protected ChartControl AreaChart;
        private TabPageAdv DivisionTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DivisionExpander1;
        private MetroSetComboBox DivisionFilter2;
        protected ChartControl DivisionChart;
        private TabPageAdv ObjectiveTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ObjectiveExpander1;
        protected ChartControl ObjectiveChart;
        private TabPageAdv GoalTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel GoalExpander1;
        protected ChartControl GoalChart;
        private TabPageAdv NpmTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel NpmExpander1;
        protected ChartControl NpmChart;
        private TabPageAdv BocTab;
        protected ChartControl BocChart;
        private TabPageAdv FundTab;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel FundExpander1;
        protected ChartControl FundChart;
        private TabControlAdv SummaryTabControl;
        private MetroSetComboBox ObjectiveFilter2;
        private MetroSetComboBox GoalFilter2;
        private MetroSetComboBox FundFilter2;
        private MetroSetComboBox ProjectFilter2;
        private MetroSetComboBox AreaFilter2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander1;
        private MetroSetComboBox BocFilter2;
        private MetroSetComboBox BocFilter1;
        private MetroSetComboBox NpmFilter2;
        private MetroSetComboBox NpmFilter1;
        private MetroSetComboBox ProjectFilter1;
        private MetroSetComboBox AreaFilter1;
        private MetroSetComboBox DivisionFilter1;
        private MetroSetComboBox ObjectiveFilter1;
        private MetroSetComboBox GoalFilter1;
        private MetroSetComboBox FundFilter1;
        private Label label23;
        private Label label24;
        private Label label20;
        private Label label21;
        private Label label17;
        private Label label18;
        private Label label14;
        private Label label15;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private MetroSetComboBox FundFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander2;
        private MetroSetComboBox BocFilter4;
        private MetroSetComboBox BocFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel FundExpander2;
        private Label label25;
        private MetroSetComboBox FundFilter4;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ProjectExpander2;
        private MetroSetComboBox ProjectFilter4;
        private MetroSetComboBox ProjectFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel AreaExpander2;
        private MetroSetComboBox AreaFilter4;
        private MetroSetComboBox AreaFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DivisionExpander2;
        private MetroSetComboBox DivisionFilter4;
        private MetroSetComboBox DivisionFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ObjectiveExpander2;
        private MetroSetComboBox ObjectiveFilter4;
        private MetroSetComboBox ObjectiveFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel GoalExpander2;
        private MetroSetComboBox GoalFilter4;
        private MetroSetComboBox GoalFilter3;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel NpmExpander2;
        private Label label7;
        private Label label27;
        private MetroSetComboBox NpmFilter4;
        private MetroSetComboBox NpmFilter3;
        private Label label22;
        private Label label30;
        private Label label19;
        private Label label29;
        private Label label16;
        private Label label28;
        private Label label13;
        private Label label26;
        private Label label4;
        private Label label10;
        private Label label35;
        private Label label36;
        private BindingSource BindingSource;
        private ChartControl chartControl1;
        private TabPageAdv DatabaseTab;
        private GroupBox groupBox5;
        private TabControlAdv AccountTabControl;
        private TabPageAdv UpdateTab;
        private BindingNavigator Navigator;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton10;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton toolStripButton11;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton CopyButton;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton AddButton;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripButton ResetButton;
        private ToolStripSeparator toolStripSeparator16;
        private MetroSetLabel metroSetLabel20;
        private MetroSetTextBox BudgetLevel;
        private MetroSetLabel metroSetLabel19;
        private MetroSetTextBox ID;
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
        private MetroSetLabel metroSetLabel17;
        private MetroSetLabel metroSetLabel18;
        private MetroSetTextBox BFY;
        private MetroSetTextBox Org;
        private TabPageAdv tabPageAdv5;
        private TabPageAdv tabPageAdv6;
        private GroupBox groupBox1;
        private MetroSetLabel lblCount;
        private DataGridView Grid;
        private GroupBox FilterGroupBox;
        private Label lblPrc;
        private Label lblBoc;
        private Label label33;
        private MetroSetComboBox GridAccountFilter;
        private Button GridRefreshButton;
        private MetroSetComboBox GridBocFilter;
        private MetroSetComboBox GridFundFilter;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label31;
        private Label label32;
        private Label label34;
        private Label label37;
        private Label label40;
        private Label label41;
        private Button ExcelButton;
        private Button CalculatorButton;
        private Button CalendatButton;
        private Button button2;
        private ToolStripButton AccountToolsButton;
        private ToolStripSeparator toolStripSeparator12;
        private Button button3;
        private Button button1;
        private Button button5;
        private Button button4;
        protected ChartControl AccountChart;
    }
}