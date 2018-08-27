

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
            VisualPlus.Structure.TextStyle textStyle36 = new VisualPlus.Structure.TextStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            VisualPlus.Structure.TextStyle textStyle48 = new VisualPlus.Structure.TextStyle();
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
            VisualPlus.Structure.TextStyle textStyle35 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle34 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle33 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle32 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle31 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle30 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle29 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle28 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle27 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle26 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle25 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle24 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle23 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle22 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle21 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle19 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle20 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle17 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle18 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle15 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle16 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle13 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle14 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle11 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle12 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle9 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle10 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle8 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle47 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle46 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle45 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle44 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle43 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle42 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle41 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle40 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle39 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle38 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle37 = new VisualPlus.Structure.TextStyle();
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
            this.ProjectExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ProjectChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.AreaTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AreaExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.AreaExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.AreaChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DivisionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.DivisionExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.DivisionExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DivisionChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ObjectiveTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ObjectiveExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ObjectiveExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ObjectiveChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.GoalTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.GoalExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GoalExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GoalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.NpmTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.NpmExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.NpmExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NpmChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BocTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BocExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.BocExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.FundTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.FundExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.FundExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FundChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.DatabaseTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.GridGroupBox = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.lblBoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.EditTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.BudgetLevel = new MetroSet_UI.Controls.MetroSetTextBox();
            this.ID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Amount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Code = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BOC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.RC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Fund = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BFY = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Org = new MetroSet_UI.Controls.MetroSetTextBox();
            this.GraphTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AccountChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.ToolNavTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroSetToolTip1 = new MetroSet_UI.Components.MetroSetToolTip();
            this.GridFundFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GridBocFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GridAccountFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.FundFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.FundFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.FundFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.FundFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.NpmFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.NpmFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.NpmFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.NpmFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GoalFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GoalFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GoalFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.GoalFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ObjectiveFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ObjectiveFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ObjectiveFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ObjectiveFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.DivisionFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.DivisionFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.DivisionFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.DivisionFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AreaFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AreaFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AreaFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AreaFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ProjectFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ProjectFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ProjectFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.ProjectFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel6 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel7 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel8 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel9 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel10 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.metroSetTextBox3 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.visualLabel11 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
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
            this.GridGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).BeginInit();
            this.AccountTabControl.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GraphTab.SuspendLayout();
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
            this.ProjectTab.Location = new System.Drawing.Point(0, 34);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.ShowCloseButton = true;
            this.ProjectTab.Size = new System.Drawing.Size(1843, 987);
            this.ProjectTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectTab.TabIndex = 8;
            this.ProjectTab.Tag = "ProgramProjectName";
            this.ProjectTab.Text = "ProgramProject";
            this.ProjectTab.ThemesEnabled = false;
            // 
            // ProjectExpander2
            // 
            this.ProjectExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectExpander2.BackColor = System.Drawing.Color.Black;
            this.ProjectExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ProjectExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ProjectExpander2.Controls.Add(this.ProjectFilter3);
            this.ProjectExpander2.Controls.Add(this.ProjectFilter4);
            this.ProjectExpander2.Controls.Add(this.label22);
            this.ProjectExpander2.Controls.Add(this.label30);
            this.ProjectExpander2.ExpandedHeight = 292;
            this.ProjectExpander2.IsExpanded = true;
            this.ProjectExpander2.Location = new System.Drawing.Point(1542, 412);
            this.ProjectExpander2.Name = "ProjectExpander2";
            this.ProjectExpander2.Size = new System.Drawing.Size(230, 292);
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
            // ProjectExpander1
            // 
            this.ProjectExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectExpander1.BackColor = System.Drawing.Color.Black;
            this.ProjectExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ProjectExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ProjectExpander1.Controls.Add(this.ProjectFilter1);
            this.ProjectExpander1.Controls.Add(this.ProjectFilter2);
            this.ProjectExpander1.Controls.Add(this.label23);
            this.ProjectExpander1.Controls.Add(this.label24);
            this.ProjectExpander1.ExpandedHeight = 268;
            this.ProjectExpander1.IsExpanded = true;
            this.ProjectExpander1.Location = new System.Drawing.Point(1542, 115);
            this.ProjectExpander1.Name = "ProjectExpander1";
            this.ProjectExpander1.Size = new System.Drawing.Size(230, 268);
            this.ProjectExpander1.TabIndex = 108;
            this.ProjectExpander1.Text = "Chart Configuration";
            this.ProjectExpander1.UseAnimation = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label23.Location = new System.Drawing.Point(20, 188);
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
            this.ProjectChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.ProjectChart.Size = new System.Drawing.Size(1490, 720);
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
            this.AreaTab.Location = new System.Drawing.Point(0, 34);
            this.AreaTab.Name = "AreaTab";
            this.AreaTab.ShowCloseButton = true;
            this.AreaTab.Size = new System.Drawing.Size(1843, 987);
            this.AreaTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaTab.TabIndex = 7;
            this.AreaTab.Tag = "ProgramAreaName";
            this.AreaTab.Text = "ProgramArea";
            this.AreaTab.ThemesEnabled = false;
            // 
            // AreaExpander2
            // 
            this.AreaExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaExpander2.BackColor = System.Drawing.Color.Black;
            this.AreaExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.AreaExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AreaExpander2.Controls.Add(this.AreaFilter3);
            this.AreaExpander2.Controls.Add(this.AreaFilter4);
            this.AreaExpander2.Controls.Add(this.label19);
            this.AreaExpander2.Controls.Add(this.label29);
            this.AreaExpander2.ExpandedHeight = 292;
            this.AreaExpander2.IsExpanded = true;
            this.AreaExpander2.Location = new System.Drawing.Point(1542, 404);
            this.AreaExpander2.Name = "AreaExpander2";
            this.AreaExpander2.Size = new System.Drawing.Size(221, 292);
            this.AreaExpander2.TabIndex = 110;
            this.AreaExpander2.Text = "Chart Filters";
            this.AreaExpander2.UseAnimation = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label19.Location = new System.Drawing.Point(28, 57);
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
            // AreaExpander1
            // 
            this.AreaExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaExpander1.BackColor = System.Drawing.Color.Black;
            this.AreaExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.AreaExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.AreaExpander1.Controls.Add(this.AreaFilter1);
            this.AreaExpander1.Controls.Add(this.AreaFilter2);
            this.AreaExpander1.Controls.Add(this.label20);
            this.AreaExpander1.Controls.Add(this.label21);
            this.AreaExpander1.ExpandedHeight = 260;
            this.AreaExpander1.IsExpanded = true;
            this.AreaExpander1.Location = new System.Drawing.Point(1542, 115);
            this.AreaExpander1.Name = "AreaExpander1";
            this.AreaExpander1.Size = new System.Drawing.Size(221, 260);
            this.AreaExpander1.TabIndex = 108;
            this.AreaExpander1.Text = "Chart Configuration";
            this.AreaExpander1.UseAnimation = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label20.Location = new System.Drawing.Point(20, 169);
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
            this.label21.Location = new System.Drawing.Point(20, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 22);
            this.label21.TabIndex = 118;
            this.label21.Text = "Chart Type";
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
            this.AreaChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.AreaChart.Size = new System.Drawing.Size(1500, 720);
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
            this.DivisionTab.Location = new System.Drawing.Point(0, 34);
            this.DivisionTab.Name = "DivisionTab";
            this.DivisionTab.ShowCloseButton = true;
            this.DivisionTab.Size = new System.Drawing.Size(1843, 987);
            this.DivisionTab.TabBackColor = System.Drawing.Color.Black;
            this.DivisionTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionTab.TabIndex = 6;
            this.DivisionTab.Tag = "Division";
            this.DivisionTab.Text = "Division";
            this.DivisionTab.ThemesEnabled = false;
            // 
            // DivisionExpander2
            // 
            this.DivisionExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionExpander2.BackColor = System.Drawing.Color.Black;
            this.DivisionExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DivisionExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DivisionExpander2.Controls.Add(this.DivisionFilter3);
            this.DivisionExpander2.Controls.Add(this.DivisionFilter4);
            this.DivisionExpander2.Controls.Add(this.label16);
            this.DivisionExpander2.Controls.Add(this.label28);
            this.DivisionExpander2.ExpandedHeight = 292;
            this.DivisionExpander2.IsExpanded = true;
            this.DivisionExpander2.Location = new System.Drawing.Point(1542, 387);
            this.DivisionExpander2.Name = "DivisionExpander2";
            this.DivisionExpander2.Size = new System.Drawing.Size(230, 292);
            this.DivisionExpander2.TabIndex = 110;
            this.DivisionExpander2.Text = "Chart Filters";
            this.DivisionExpander2.UseAnimation = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label16.Location = new System.Drawing.Point(27, 72);
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
            // DivisionExpander1
            // 
            this.DivisionExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionExpander1.BackColor = System.Drawing.Color.Black;
            this.DivisionExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DivisionExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DivisionExpander1.Controls.Add(this.DivisionFilter1);
            this.DivisionExpander1.Controls.Add(this.DivisionFilter2);
            this.DivisionExpander1.Controls.Add(this.label17);
            this.DivisionExpander1.Controls.Add(this.label18);
            this.DivisionExpander1.ExpandedHeight = 266;
            this.DivisionExpander1.IsExpanded = true;
            this.DivisionExpander1.Location = new System.Drawing.Point(1542, 115);
            this.DivisionExpander1.Name = "DivisionExpander1";
            this.DivisionExpander1.Size = new System.Drawing.Size(230, 266);
            this.DivisionExpander1.TabIndex = 108;
            this.DivisionExpander1.Text = "Chart Configuration";
            this.DivisionExpander1.UseAnimation = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label17.Location = new System.Drawing.Point(22, 171);
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
            this.label18.Location = new System.Drawing.Point(22, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 22);
            this.label18.TabIndex = 118;
            this.label18.Text = "Chart Type";
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
            this.DivisionChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.DivisionChart.Size = new System.Drawing.Size(1500, 720);
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
            this.ObjectiveTab.Location = new System.Drawing.Point(0, 34);
            this.ObjectiveTab.Name = "ObjectiveTab";
            this.ObjectiveTab.ShowCloseButton = true;
            this.ObjectiveTab.Size = new System.Drawing.Size(1843, 987);
            this.ObjectiveTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveTab.TabIndex = 5;
            this.ObjectiveTab.Tag = "ObjectiveName";
            this.ObjectiveTab.Text = "Objective";
            this.ObjectiveTab.ThemesEnabled = false;
            // 
            // ObjectiveExpander2
            // 
            this.ObjectiveExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveExpander2.BackColor = System.Drawing.Color.Black;
            this.ObjectiveExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ObjectiveExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ObjectiveExpander2.Controls.Add(this.ObjectiveFilter3);
            this.ObjectiveExpander2.Controls.Add(this.ObjectiveFilter4);
            this.ObjectiveExpander2.Controls.Add(this.label13);
            this.ObjectiveExpander2.Controls.Add(this.label26);
            this.ObjectiveExpander2.ExpandedHeight = 292;
            this.ObjectiveExpander2.IsExpanded = true;
            this.ObjectiveExpander2.Location = new System.Drawing.Point(1542, 404);
            this.ObjectiveExpander2.Name = "ObjectiveExpander2";
            this.ObjectiveExpander2.Size = new System.Drawing.Size(230, 292);
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
            this.label26.Location = new System.Drawing.Point(40, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 22);
            this.label26.TabIndex = 118;
            this.label26.Text = "Grouping";
            // 
            // ObjectiveExpander1
            // 
            this.ObjectiveExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveExpander1.BackColor = System.Drawing.Color.Black;
            this.ObjectiveExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ObjectiveExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ObjectiveExpander1.Controls.Add(this.ObjectiveFilter1);
            this.ObjectiveExpander1.Controls.Add(this.ObjectiveFilter2);
            this.ObjectiveExpander1.Controls.Add(this.label14);
            this.ObjectiveExpander1.Controls.Add(this.label15);
            this.ObjectiveExpander1.ExpandedHeight = 268;
            this.ObjectiveExpander1.IsExpanded = true;
            this.ObjectiveExpander1.Location = new System.Drawing.Point(1542, 115);
            this.ObjectiveExpander1.Name = "ObjectiveExpander1";
            this.ObjectiveExpander1.Size = new System.Drawing.Size(230, 268);
            this.ObjectiveExpander1.TabIndex = 108;
            this.ObjectiveExpander1.Text = "Chart Configuration";
            this.ObjectiveExpander1.UseAnimation = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label14.Location = new System.Drawing.Point(26, 174);
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
            this.label15.Location = new System.Drawing.Point(26, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 22);
            this.label15.TabIndex = 118;
            this.label15.Text = "Chart Type";
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
            this.ObjectiveChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.ObjectiveChart.Size = new System.Drawing.Size(1500, 720);
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
            this.GoalTab.Location = new System.Drawing.Point(0, 34);
            this.GoalTab.Name = "GoalTab";
            this.GoalTab.ShowCloseButton = true;
            this.GoalTab.Size = new System.Drawing.Size(1843, 987);
            this.GoalTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalTab.TabIndex = 4;
            this.GoalTab.Tag = "GoalName";
            this.GoalTab.Text = "Goal";
            this.GoalTab.ThemesEnabled = false;
            // 
            // GoalExpander2
            // 
            this.GoalExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalExpander2.BackColor = System.Drawing.Color.Black;
            this.GoalExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.GoalExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.GoalExpander2.Controls.Add(this.GoalFilter3);
            this.GoalExpander2.Controls.Add(this.GoalFilter4);
            this.GoalExpander2.Controls.Add(this.label4);
            this.GoalExpander2.Controls.Add(this.label10);
            this.GoalExpander2.ExpandedHeight = 292;
            this.GoalExpander2.IsExpanded = true;
            this.GoalExpander2.Location = new System.Drawing.Point(1542, 402);
            this.GoalExpander2.Name = "GoalExpander2";
            this.GoalExpander2.Size = new System.Drawing.Size(230, 292);
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
            this.label10.Location = new System.Drawing.Point(32, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 118;
            this.label10.Text = "Grouping";
            // 
            // GoalExpander1
            // 
            this.GoalExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalExpander1.BackColor = System.Drawing.Color.Black;
            this.GoalExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.GoalExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.GoalExpander1.Controls.Add(this.GoalFilter1);
            this.GoalExpander1.Controls.Add(this.GoalFilter2);
            this.GoalExpander1.Controls.Add(this.label11);
            this.GoalExpander1.Controls.Add(this.label12);
            this.GoalExpander1.ExpandedHeight = 281;
            this.GoalExpander1.IsExpanded = true;
            this.GoalExpander1.Location = new System.Drawing.Point(1542, 115);
            this.GoalExpander1.Name = "GoalExpander1";
            this.GoalExpander1.Size = new System.Drawing.Size(230, 281);
            this.GoalExpander1.TabIndex = 108;
            this.GoalExpander1.Text = "Chart Configuration";
            this.GoalExpander1.UseAnimation = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label11.Location = new System.Drawing.Point(16, 168);
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
            this.label12.Location = new System.Drawing.Point(16, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 118;
            this.label12.Text = "Chart Type";
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
            this.GoalChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.GoalChart.Size = new System.Drawing.Size(1500, 720);
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
            this.NpmTab.Location = new System.Drawing.Point(0, 34);
            this.NpmTab.Name = "NpmTab";
            this.NpmTab.ShowCloseButton = true;
            this.NpmTab.Size = new System.Drawing.Size(1843, 987);
            this.NpmTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmTab.TabIndex = 3;
            this.NpmTab.Tag = "NpmName";
            this.NpmTab.Text = "NPM";
            this.NpmTab.ThemesEnabled = false;
            // 
            // NpmExpander2
            // 
            this.NpmExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NpmExpander2.BackColor = System.Drawing.Color.Black;
            this.NpmExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.NpmExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.NpmExpander2.Controls.Add(this.NpmFilter4);
            this.NpmExpander2.Controls.Add(this.NpmFilter3);
            this.NpmExpander2.Controls.Add(this.label7);
            this.NpmExpander2.Controls.Add(this.label27);
            this.NpmExpander2.ExpandedHeight = 292;
            this.NpmExpander2.IsExpanded = true;
            this.NpmExpander2.Location = new System.Drawing.Point(1542, 405);
            this.NpmExpander2.Name = "NpmExpander2";
            this.NpmExpander2.Size = new System.Drawing.Size(230, 292);
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
            // NpmExpander1
            // 
            this.NpmExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NpmExpander1.BackColor = System.Drawing.Color.Black;
            this.NpmExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.NpmExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.NpmExpander1.Controls.Add(this.label8);
            this.NpmExpander1.Controls.Add(this.NpmFilter2);
            this.NpmExpander1.Controls.Add(this.label9);
            this.NpmExpander1.Controls.Add(this.NpmFilter1);
            this.NpmExpander1.ExpandedHeight = 275;
            this.NpmExpander1.IsExpanded = true;
            this.NpmExpander1.Location = new System.Drawing.Point(1542, 115);
            this.NpmExpander1.Name = "NpmExpander1";
            this.NpmExpander1.Size = new System.Drawing.Size(230, 275);
            this.NpmExpander1.TabIndex = 108;
            this.NpmExpander1.Text = "Chart Configuration";
            this.NpmExpander1.UseAnimation = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label8.Location = new System.Drawing.Point(34, 165);
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
            this.label9.Location = new System.Drawing.Point(34, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 118;
            this.label9.Text = "Chart Type";
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
            this.NpmChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.NpmChart.Size = new System.Drawing.Size(1500, 720);
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
            this.BocTab.Location = new System.Drawing.Point(0, 34);
            this.BocTab.Name = "BocTab";
            this.BocTab.ShowCloseButton = true;
            this.BocTab.Size = new System.Drawing.Size(1843, 987);
            this.BocTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocTab.TabIndex = 2;
            this.BocTab.Tag = "BocName";
            this.BocTab.Text = "BOC";
            this.BocTab.ThemesEnabled = false;
            // 
            // BocExpander2
            // 
            this.BocExpander2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BocExpander2.BackColor = System.Drawing.Color.Black;
            this.BocExpander2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.BocExpander2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.BocExpander2.Controls.Add(this.BocFilter4);
            this.BocExpander2.Controls.Add(this.BocFilter3);
            this.BocExpander2.Controls.Add(this.label35);
            this.BocExpander2.Controls.Add(this.label36);
            this.BocExpander2.ExpandedHeight = 292;
            this.BocExpander2.IsExpanded = true;
            this.BocExpander2.Location = new System.Drawing.Point(1542, 402);
            this.BocExpander2.Name = "BocExpander2";
            this.BocExpander2.Size = new System.Drawing.Size(230, 292);
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
            // BocExpander1
            // 
            this.BocExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BocExpander1.BackColor = System.Drawing.Color.Black;
            this.BocExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.BocExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.BocExpander1.Controls.Add(this.label5);
            this.BocExpander1.Controls.Add(this.BocFilter2);
            this.BocExpander1.Controls.Add(this.label6);
            this.BocExpander1.Controls.Add(this.BocFilter1);
            this.BocExpander1.ExpandedHeight = 258;
            this.BocExpander1.IsExpanded = true;
            this.BocExpander1.Location = new System.Drawing.Point(1542, 115);
            this.BocExpander1.Name = "BocExpander1";
            this.BocExpander1.Size = new System.Drawing.Size(230, 258);
            this.BocExpander1.TabIndex = 108;
            this.BocExpander1.Text = "Chart Configuration";
            this.BocExpander1.UseAnimation = true;
            this.BocExpander1.Paint += new System.Windows.Forms.PaintEventHandler(this.BocExpander1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(20, 162);
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
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 118;
            this.label6.Text = "Chart Type";
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
            this.BocChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.BocChart.Size = new System.Drawing.Size(1500, 720);
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
            this.FundTab.Location = new System.Drawing.Point(0, 34);
            this.FundTab.Name = "FundTab";
            this.FundTab.ShowCloseButton = true;
            this.FundTab.Size = new System.Drawing.Size(1843, 987);
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
            this.FundExpander2.Controls.Add(this.FundFilter4);
            this.FundExpander2.Controls.Add(this.FundFilter3);
            this.FundExpander2.Controls.Add(this.label3);
            this.FundExpander2.Controls.Add(this.label25);
            this.FundExpander2.ExpandedHeight = 292;
            this.FundExpander2.IsExpanded = true;
            this.FundExpander2.Location = new System.Drawing.Point(1542, 404);
            this.FundExpander2.Name = "FundExpander2";
            this.FundExpander2.Size = new System.Drawing.Size(230, 292);
            this.FundExpander2.TabIndex = 108;
            this.FundExpander2.Text = "Chart Filters";
            this.FundExpander2.UseAnimation = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(32, 65);
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
            // FundExpander1
            // 
            this.FundExpander1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundExpander1.BackColor = System.Drawing.Color.Black;
            this.FundExpander1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.FundExpander1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.FundExpander1.Controls.Add(this.FundFilter2);
            this.FundExpander1.Controls.Add(this.FundFilter1);
            this.FundExpander1.Controls.Add(this.label2);
            this.FundExpander1.Controls.Add(this.label1);
            this.FundExpander1.ExpandedHeight = 283;
            this.FundExpander1.IsExpanded = true;
            this.FundExpander1.Location = new System.Drawing.Point(1542, 115);
            this.FundExpander1.Name = "FundExpander1";
            this.FundExpander1.Size = new System.Drawing.Size(230, 283);
            this.FundExpander1.TabIndex = 107;
            this.FundExpander1.Text = "Chart Configuration";
            this.FundExpander1.UseAnimation = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(32, 172);
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
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 114;
            this.label1.Text = "Chart Type";
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
            this.FundChart.Legend.Location = new System.Drawing.Point(1052, 9);
            this.FundChart.Legend.Visible = false;
            this.FundChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.FundChart.Localize = null;
            this.FundChart.Location = new System.Drawing.Point(2, 100);
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
            this.FundChart.Size = new System.Drawing.Size(1500, 720);
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
            this.SummaryTabControl.BeforeTouchSize = new System.Drawing.Size(1843, 1021);
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
            this.SummaryTabControl.InactiveTabColor = System.Drawing.Color.Black;
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.DarkGray;
            this.SummaryTabControl.ItemSize = new System.Drawing.Size(150, 45);
            this.SummaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.SummaryTabControl.Multiline = true;
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.Padding = new System.Drawing.Point(15, 6);
            this.SummaryTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.SummaryTabControl.ShowScroll = false;
            this.SummaryTabControl.ShowSeparator = true;
            this.SummaryTabControl.Size = new System.Drawing.Size(1843, 1021);
            this.SummaryTabControl.TabGap = 5;
            this.SummaryTabControl.TabIndex = 0;
            this.SummaryTabControl.TabPanelBackColor = System.Drawing.Color.Black;
            this.SummaryTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.SummaryTabControl.SelectedIndexChanged += new System.EventHandler(this.SummaryTabPage_TabSelected);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.BackColor = System.Drawing.Color.Black;
            this.DatabaseTab.Controls.Add(this.GridGroupBox);
            this.DatabaseTab.Controls.Add(this.visualGroupBox1);
            this.DatabaseTab.Image = null;
            this.DatabaseTab.ImageSize = new System.Drawing.Size(20, 20);
            this.DatabaseTab.Location = new System.Drawing.Point(0, 34);
            this.DatabaseTab.MaximumSize = new System.Drawing.Size(1843, 969);
            this.DatabaseTab.MinimumSize = new System.Drawing.Size(1843, 969);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(2);
            this.DatabaseTab.ShowCloseButton = true;
            this.DatabaseTab.Size = new System.Drawing.Size(1843, 969);
            this.DatabaseTab.TabIndex = 9;
            this.DatabaseTab.Tag = "Database";
            this.DatabaseTab.Text = "Account Manager";
            this.DatabaseTab.ThemesEnabled = false;
            // 
            // GridGroupBox
            // 
            this.GridGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.GridGroupBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridGroupBox.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.GridGroupBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridGroupBox.Border.HoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.GridGroupBox.Border.HoverVisible = true;
            this.GridGroupBox.Border.Rounding = 6;
            this.GridGroupBox.Border.Thickness = 1;
            this.GridGroupBox.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GridGroupBox.Border.Visible = true;
            this.GridGroupBox.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.GridGroupBox.Controls.Add(this.GridAccountFilter);
            this.GridGroupBox.Controls.Add(this.GridBocFilter);
            this.GridGroupBox.Controls.Add(this.GridFundFilter);
            this.GridGroupBox.Controls.Add(this.lblPrc);
            this.GridGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.GridGroupBox.Controls.Add(this.panel2);
            this.GridGroupBox.Controls.Add(this.lblBoc);
            this.GridGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.GridGroupBox.Controls.Add(this.label33);
            this.GridGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridGroupBox.Image = null;
            this.GridGroupBox.Location = new System.Drawing.Point(28, 109);
            this.GridGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridGroupBox.Name = "GridGroupBox";
            this.GridGroupBox.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GridGroupBox.Separator = false;
            this.GridGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridGroupBox.Size = new System.Drawing.Size(1160, 739);
            this.GridGroupBox.TabIndex = 162;
            this.GridGroupBox.Text = "vcbs";
            this.GridGroupBox.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle36.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle36.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle36.Hover = System.Drawing.Color.Empty;
            textStyle36.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridGroupBox.TextStyle = textStyle36;
            this.GridGroupBox.TitleBoxHeight = 35;
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.BackColor = System.Drawing.Color.Transparent;
            this.lblPrc.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrc.Location = new System.Drawing.Point(27, 412);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(109, 23);
            this.lblPrc.TabIndex = 7;
            this.lblPrc.Text = "PRC Account\r\n";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.25444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.74556F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button12, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button11, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.GridRefreshButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button10, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(220, 600);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 52);
            this.tableLayoutPanel2.TabIndex = 169;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(4, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 42);
            this.button6.TabIndex = 162;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetToolTip1.SetToolTip(this.button6, "Previous Account");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PreviousButton_OnClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(768, 5);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 42);
            this.button12.TabIndex = 168;
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button12, "Remove Account");
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(134, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 42);
            this.button7.TabIndex = 163;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button7, "Next Account");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NextButton_OnClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(633, 5);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(127, 42);
            this.button11.TabIndex = 167;
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button11, "Copy Account\r\n");
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.CopyButton_OnClick);
            // 
            // GridRefreshButton
            // 
            this.GridRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.GridRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GridRefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.GridRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.GridRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("GridRefreshButton.Image")));
            this.GridRefreshButton.Location = new System.Drawing.Point(248, 5);
            this.GridRefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(119, 42);
            this.GridRefreshButton.TabIndex = 164;
            this.GridRefreshButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.GridRefreshButton, "Refresh Data");
            this.GridRefreshButton.UseVisualStyleBackColor = false;
            this.GridRefreshButton.Click += new System.EventHandler(this.GridRefreshButton_OnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(375, 5);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 42);
            this.button9.TabIndex = 165;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button9, "Edit Account");
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CopyButton_OnClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(506, 5);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 42);
            this.button10.TabIndex = 166;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button10, "Add  Account");
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.AddButton_OnClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Grid);
            this.panel2.Location = new System.Drawing.Point(207, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 460);
            this.panel2.TabIndex = 160;
            // 
            // Grid
            // 
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.Gray;
            this.Grid.Location = new System.Drawing.Point(13, 15);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersWidth = 25;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(899, 391);
            this.Grid.TabIndex = 170;
            this.Grid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Grid.UseCustomBackColor = true;
            this.Grid.UseCustomForeColor = true;
            // 
            // lblBoc
            // 
            this.lblBoc.AutoSize = true;
            this.lblBoc.BackColor = System.Drawing.Color.Transparent;
            this.lblBoc.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblBoc.Location = new System.Drawing.Point(27, 280);
            this.lblBoc.Name = "lblBoc";
            this.lblBoc.Size = new System.Drawing.Size(44, 23);
            this.lblBoc.TabIndex = 6;
            this.lblBoc.Text = "BOC";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.89888F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.10112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label32, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label37, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label40, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(207, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 33);
            this.tableLayoutPanel1.TabIndex = 159;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Right;
            this.label31.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label31.Location = new System.Drawing.Point(28, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 33);
            this.label31.TabIndex = 153;
            this.label31.Text = "Total: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Left;
            this.label32.Location = new System.Drawing.Point(89, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 33);
            this.label32.TabIndex = 154;
            this.label32.Text = "label32";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label34.Location = new System.Drawing.Point(383, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 23);
            this.label34.TabIndex = 155;
            this.label34.Text = "Average: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Left;
            this.label37.Location = new System.Drawing.Point(470, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 33);
            this.label37.TabIndex = 156;
            this.label37.Text = "label37";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Right;
            this.label40.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label40.Location = new System.Drawing.Point(714, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 33);
            this.label40.TabIndex = 159;
            this.label40.Text = "Accounts: ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Left;
            this.label41.Location = new System.Drawing.Point(809, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 33);
            this.label41.TabIndex = 160;
            this.label41.Text = "label41";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label33.Location = new System.Drawing.Point(27, 153);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 23);
            this.label33.TabIndex = 5;
            this.label33.Text = "Appropriation";
            // 
            // visualGroupBox1
            // 
            this.visualGroupBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox1.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.visualGroupBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox1.Border.HoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.visualGroupBox1.Border.HoverVisible = true;
            this.visualGroupBox1.Border.Rounding = 6;
            this.visualGroupBox1.Border.Thickness = 1;
            this.visualGroupBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox1.Border.Visible = true;
            this.visualGroupBox1.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox1.Controls.Add(this.panel1);
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(1238, 109);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = false;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox1.Size = new System.Drawing.Size(574, 739);
            this.visualGroupBox1.TabIndex = 161;
            this.visualGroupBox1.Text = "Allocation";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle48.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle48.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle48.Hover = System.Drawing.Color.Empty;
            textStyle48.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle48;
            this.visualGroupBox1.TitleBoxHeight = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AccountTabControl);
            this.panel1.Location = new System.Drawing.Point(13, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 640);
            this.panel1.TabIndex = 1;
            // 
            // AccountTabControl
            // 
            this.AccountTabControl.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.AccountTabControl.ActiveTabForeColor = System.Drawing.Color.White;
            this.AccountTabControl.BackColor = System.Drawing.Color.Black;
            this.AccountTabControl.BeforeTouchSize = new System.Drawing.Size(512, 625);
            this.AccountTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountTabControl.BorderWidth = 0;
            this.AccountTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.AccountTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.Controls.Add(this.EditTab);
            this.AccountTabControl.Controls.Add(this.GraphTab);
            this.AccountTabControl.Controls.Add(this.ToolNavTab);
            this.AccountTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountTabControl.FocusOnTabClick = false;
            this.AccountTabControl.ImageOffset = 1;
            this.AccountTabControl.InactiveTabColor = System.Drawing.Color.Black;
            this.AccountTabControl.InActiveTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountTabControl.ItemSize = new System.Drawing.Size(150, 35);
            this.AccountTabControl.LevelTextAndImage = true;
            this.AccountTabControl.Location = new System.Drawing.Point(12, 12);
            this.AccountTabControl.Name = "AccountTabControl";
            this.AccountTabControl.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.AccountTabControl.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.AccountTabControl.Padding = new System.Drawing.Point(15, 6);
            this.AccountTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.AccountTabControl.ShowSeparator = true;
            this.AccountTabControl.Size = new System.Drawing.Size(512, 625);
            this.AccountTabControl.TabGap = 10;
            this.AccountTabControl.TabIndex = 150;
            this.AccountTabControl.TabPanelBackColor = System.Drawing.Color.Transparent;
            this.AccountTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.AccountTabControl.VSLikeScrollButton = true;
            // 
            // EditTab
            // 
            this.EditTab.BackColor = System.Drawing.Color.Transparent;
            this.EditTab.Controls.Add(this.visualLabel11);
            this.EditTab.Controls.Add(this.metroSetTextBox3);
            this.EditTab.Controls.Add(this.visualLabel10);
            this.EditTab.Controls.Add(this.visualLabel9);
            this.EditTab.Controls.Add(this.visualLabel8);
            this.EditTab.Controls.Add(this.visualLabel7);
            this.EditTab.Controls.Add(this.visualLabel6);
            this.EditTab.Controls.Add(this.visualLabel5);
            this.EditTab.Controls.Add(this.visualLabel4);
            this.EditTab.Controls.Add(this.visualLabel3);
            this.EditTab.Controls.Add(this.visualLabel2);
            this.EditTab.Controls.Add(this.visualLabel1);
            this.EditTab.Controls.Add(this.tableLayoutPanel3);
            this.EditTab.Controls.Add(this.CalculatorButton);
            this.EditTab.Controls.Add(this.BudgetLevel);
            this.EditTab.Controls.Add(this.ID);
            this.EditTab.Controls.Add(this.metroSetTextBox1);
            this.EditTab.Controls.Add(this.Amount);
            this.EditTab.Controls.Add(this.Code);
            this.EditTab.Controls.Add(this.BOC);
            this.EditTab.Controls.Add(this.RC);
            this.EditTab.Controls.Add(this.Fund);
            this.EditTab.Controls.Add(this.BFY);
            this.EditTab.Controls.Add(this.Org);
            this.EditTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTab.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.EditTab.Image = null;
            this.EditTab.ImageSize = new System.Drawing.Size(20, 20);
            this.EditTab.Location = new System.Drawing.Point(0, 34);
            this.EditTab.Name = "EditTab";
            this.EditTab.ShowCloseButton = true;
            this.EditTab.Size = new System.Drawing.Size(512, 591);
            this.EditTab.TabBackColor = System.Drawing.Color.Transparent;
            this.EditTab.TabForeColor = System.Drawing.Color.LightSkyBlue;
            this.EditTab.TabIndex = 4;
            this.EditTab.Text = "Edit";
            this.EditTab.ThemesEnabled = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.9854F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0146F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(32, 468);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(473, 50);
            this.tableLayoutPanel3.TabIndex = 163;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 44);
            this.button4.TabIndex = 159;
            this.metroSetToolTip1.SetToolTip(this.button4, "Previous Account");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.PreviousButton_OnClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(118, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 44);
            this.button5.TabIndex = 160;
            this.metroSetToolTip1.SetToolTip(this.button5, "Next Account");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NextButton_OnClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(371, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 158;
            this.metroSetToolTip1.SetToolTip(this.button3, "Remove Account");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(253, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 157;
            this.metroSetToolTip1.SetToolTip(this.button1, "Upload Changes ");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.Black;
            this.CalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.CalculatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.Location = new System.Drawing.Point(200, 364);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(51, 71);
            this.CalculatorButton.TabIndex = 162;
            this.metroSetToolTip1.SetToolTip(this.CalculatorButton, "Budget Calculator");
            this.CalculatorButton.UseVisualStyleBackColor = false;
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
            this.BudgetLevel.Location = new System.Drawing.Point(200, 66);
            this.BudgetLevel.MaxLength = 32767;
            this.BudgetLevel.Multiline = false;
            this.BudgetLevel.Name = "BudgetLevel";
            this.BudgetLevel.ReadOnly = false;
            this.BudgetLevel.Size = new System.Drawing.Size(62, 40);
            this.BudgetLevel.Style = MetroSet_UI.Design.Style.Dark;
            this.BudgetLevel.StyleManager = null;
            this.BudgetLevel.TabIndex = 155;
            this.BudgetLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BudgetLevel.ThemeAuthor = "Narwin";
            this.BudgetLevel.ThemeName = "MetroDark";
            this.BudgetLevel.UseSystemPasswordChar = false;
            this.BudgetLevel.WatermarkText = "";
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
            this.ID.Location = new System.Drawing.Point(33, 66);
            this.ID.MaxLength = 32767;
            this.ID.Multiline = false;
            this.ID.Name = "ID";
            this.ID.ReadOnly = false;
            this.ID.Size = new System.Drawing.Size(62, 40);
            this.ID.Style = MetroSet_UI.Design.Style.Dark;
            this.ID.StyleManager = null;
            this.ID.TabIndex = 153;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.ThemeAuthor = "Narwin";
            this.ID.ThemeName = "MetroDark";
            this.ID.UseSystemPasswordChar = false;
            this.ID.WatermarkText = "";
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
            this.metroSetTextBox1.Location = new System.Drawing.Point(32, 376);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(162, 40);
            this.metroSetTextBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 137;
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetToolTip1.SetToolTip(this.metroSetTextBox1, "Enter New Amount");
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
            this.Amount.Location = new System.Drawing.Point(325, 263);
            this.Amount.MaxLength = 32767;
            this.Amount.Multiline = false;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = false;
            this.Amount.Size = new System.Drawing.Size(146, 40);
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
            this.Code.Location = new System.Drawing.Point(136, 263);
            this.Code.MaxLength = 32767;
            this.Code.Multiline = false;
            this.Code.Name = "Code";
            this.Code.ReadOnly = false;
            this.Code.Size = new System.Drawing.Size(156, 40);
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
            this.BOC.Location = new System.Drawing.Point(33, 259);
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
            this.RC.Location = new System.Drawing.Point(380, 160);
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
            this.Fund.Location = new System.Drawing.Point(29, 160);
            this.Fund.MaxLength = 32767;
            this.Fund.Multiline = false;
            this.Fund.Name = "Fund";
            this.Fund.ReadOnly = false;
            this.Fund.Size = new System.Drawing.Size(75, 40);
            this.Fund.Style = MetroSet_UI.Design.Style.Dark;
            this.Fund.StyleManager = null;
            this.Fund.TabIndex = 128;
            this.Fund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fund.ThemeAuthor = "Narwin";
            this.Fund.ThemeName = "MetroDark";
            this.Fund.UseSystemPasswordChar = false;
            this.Fund.WatermarkText = "";
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
            this.BFY.Location = new System.Drawing.Point(359, 66);
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
            this.Org.Location = new System.Drawing.Point(147, 160);
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
            // GraphTab
            // 
            this.GraphTab.Controls.Add(this.AccountChart);
            this.GraphTab.Image = null;
            this.GraphTab.ImageSize = new System.Drawing.Size(20, 20);
            this.GraphTab.Location = new System.Drawing.Point(0, 34);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.ShowCloseButton = true;
            this.GraphTab.Size = new System.Drawing.Size(512, 591);
            this.GraphTab.TabBackColor = System.Drawing.Color.Black;
            this.GraphTab.TabIndex = 2;
            this.GraphTab.Text = "Graph";
            this.GraphTab.ThemesEnabled = false;
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
            this.AccountChart.Legend.Location = new System.Drawing.Point(8, 8);
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
            this.AccountChart.Size = new System.Drawing.Size(512, 591);
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
            // ToolNavTab
            // 
            this.ToolNavTab.BackColor = System.Drawing.Color.Black;
            this.ToolNavTab.Image = null;
            this.ToolNavTab.ImageSize = new System.Drawing.Size(20, 20);
            this.ToolNavTab.Location = new System.Drawing.Point(0, 34);
            this.ToolNavTab.Name = "ToolNavTab";
            this.ToolNavTab.ShowCloseButton = true;
            this.ToolNavTab.Size = new System.Drawing.Size(512, 591);
            this.ToolNavTab.TabBackColor = System.Drawing.Color.Transparent;
            this.ToolNavTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolNavTab.TabIndex = 3;
            this.ToolNavTab.Text = "Tools";
            this.ToolNavTab.ThemesEnabled = false;
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
            // metroSetToolTip1
            // 
            this.metroSetToolTip1.AutoPopDelay = 2000;
            this.metroSetToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroSetToolTip1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetToolTip1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.metroSetToolTip1.InitialDelay = 500;
            this.metroSetToolTip1.OwnerDraw = true;
            this.metroSetToolTip1.ReshowDelay = 100;
            this.metroSetToolTip1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetToolTip1.StyleManager = null;
            this.metroSetToolTip1.ThemeAuthor = "Narwin";
            this.metroSetToolTip1.ThemeName = "MetroDark";
            // 
            // GridFundFilter
            // 
            this.GridFundFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridFundFilter.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridFundFilter.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GridFundFilter.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridFundFilter.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridFundFilter.Border.HoverVisible = true;
            this.GridFundFilter.Border.Rounding = 6;
            this.GridFundFilter.Border.Thickness = 1;
            this.GridFundFilter.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GridFundFilter.Border.Visible = true;
            this.GridFundFilter.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GridFundFilter.ButtonImage = null;
            this.GridFundFilter.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GridFundFilter.ButtonWidth = 30;
            this.GridFundFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GridFundFilter.DropDownHeight = 100;
            this.GridFundFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridFundFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridFundFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridFundFilter.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridFundFilter.FormattingEnabled = true;
            this.GridFundFilter.ImageList = null;
            this.GridFundFilter.ImageVisible = false;
            this.GridFundFilter.Index = 0;
            this.GridFundFilter.IntegralHeight = false;
            this.GridFundFilter.ItemHeight = 24;
            this.GridFundFilter.ItemImageVisible = true;
            this.GridFundFilter.Location = new System.Drawing.Point(31, 181);
            this.GridFundFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridFundFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridFundFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridFundFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridFundFilter.Name = "GridFundFilter";
            this.GridFundFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridFundFilter.SeparatorVisible = false;
            this.GridFundFilter.Size = new System.Drawing.Size(147, 30);
            this.GridFundFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridFundFilter.TabIndex = 170;
            this.GridFundFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridFundFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridFundFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridFundFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridFundFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle35.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle35.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle35.Hover = System.Drawing.Color.Empty;
            textStyle35.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridFundFilter.TextStyle = textStyle35;
            this.GridFundFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridFundFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridFundFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridFundFilter.Watermark.Text = "Watermark text";
            this.GridFundFilter.Watermark.Visible = false;
            this.GridFundFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl1_ItemSelected);
            // 
            // GridBocFilter
            // 
            this.GridBocFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridBocFilter.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridBocFilter.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GridBocFilter.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridBocFilter.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridBocFilter.Border.HoverVisible = true;
            this.GridBocFilter.Border.Rounding = 6;
            this.GridBocFilter.Border.Thickness = 1;
            this.GridBocFilter.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GridBocFilter.Border.Visible = true;
            this.GridBocFilter.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GridBocFilter.ButtonImage = null;
            this.GridBocFilter.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GridBocFilter.ButtonWidth = 30;
            this.GridBocFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GridBocFilter.DropDownHeight = 100;
            this.GridBocFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridBocFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridBocFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridBocFilter.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridBocFilter.FormattingEnabled = true;
            this.GridBocFilter.ImageList = null;
            this.GridBocFilter.ImageVisible = false;
            this.GridBocFilter.Index = 0;
            this.GridBocFilter.IntegralHeight = false;
            this.GridBocFilter.ItemHeight = 24;
            this.GridBocFilter.ItemImageVisible = true;
            this.GridBocFilter.Location = new System.Drawing.Point(31, 308);
            this.GridBocFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridBocFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridBocFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridBocFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridBocFilter.Name = "GridBocFilter";
            this.GridBocFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridBocFilter.SeparatorVisible = false;
            this.GridBocFilter.Size = new System.Drawing.Size(147, 30);
            this.GridBocFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridBocFilter.TabIndex = 171;
            this.GridBocFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridBocFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridBocFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridBocFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridBocFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle34.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle34.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle34.Hover = System.Drawing.Color.Empty;
            textStyle34.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridBocFilter.TextStyle = textStyle34;
            this.GridBocFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridBocFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridBocFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridBocFilter.Watermark.Text = "Watermark text";
            this.GridBocFilter.Watermark.Visible = false;
            this.GridBocFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl2_ItemSelected);
            // 
            // GridAccountFilter
            // 
            this.GridAccountFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridAccountFilter.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridAccountFilter.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GridAccountFilter.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridAccountFilter.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridAccountFilter.Border.HoverVisible = true;
            this.GridAccountFilter.Border.Rounding = 6;
            this.GridAccountFilter.Border.Thickness = 1;
            this.GridAccountFilter.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GridAccountFilter.Border.Visible = true;
            this.GridAccountFilter.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GridAccountFilter.ButtonImage = null;
            this.GridAccountFilter.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GridAccountFilter.ButtonWidth = 30;
            this.GridAccountFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GridAccountFilter.DropDownHeight = 100;
            this.GridAccountFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridAccountFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridAccountFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridAccountFilter.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridAccountFilter.FormattingEnabled = true;
            this.GridAccountFilter.ImageList = null;
            this.GridAccountFilter.ImageVisible = false;
            this.GridAccountFilter.Index = 0;
            this.GridAccountFilter.IntegralHeight = false;
            this.GridAccountFilter.ItemHeight = 24;
            this.GridAccountFilter.ItemImageVisible = true;
            this.GridAccountFilter.Location = new System.Drawing.Point(31, 438);
            this.GridAccountFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridAccountFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridAccountFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridAccountFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridAccountFilter.Name = "GridAccountFilter";
            this.GridAccountFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridAccountFilter.SeparatorVisible = false;
            this.GridAccountFilter.Size = new System.Drawing.Size(147, 30);
            this.GridAccountFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridAccountFilter.TabIndex = 172;
            this.GridAccountFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridAccountFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridAccountFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridAccountFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridAccountFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle33.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle33.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle33.Hover = System.Drawing.Color.Empty;
            textStyle33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridAccountFilter.TextStyle = textStyle33;
            this.GridAccountFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridAccountFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridAccountFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridAccountFilter.Watermark.Text = "Watermark text";
            this.GridAccountFilter.Watermark.Visible = false;
            this.GridAccountFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl3_ItemSelected);
            // 
            // FundFilter1
            // 
            this.FundFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FundFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.FundFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.FundFilter1.Border.HoverVisible = true;
            this.FundFilter1.Border.Rounding = 6;
            this.FundFilter1.Border.Thickness = 1;
            this.FundFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.FundFilter1.Border.Visible = true;
            this.FundFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.FundFilter1.ButtonImage = null;
            this.FundFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.FundFilter1.ButtonWidth = 30;
            this.FundFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FundFilter1.DropDownHeight = 100;
            this.FundFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter1.DropDownWidth = 83;
            this.FundFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter1.FormattingEnabled = true;
            this.FundFilter1.ImageList = null;
            this.FundFilter1.ImageVisible = false;
            this.FundFilter1.Index = 0;
            this.FundFilter1.IntegralHeight = false;
            this.FundFilter1.ItemHeight = 24;
            this.FundFilter1.ItemImageVisible = true;
            this.FundFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.FundFilter1.Location = new System.Drawing.Point(38, 99);
            this.FundFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.FundFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.FundFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter1.Name = "FundFilter1";
            this.FundFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter1.SeparatorVisible = false;
            this.FundFilter1.Size = new System.Drawing.Size(147, 30);
            this.FundFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter1.TabIndex = 171;
            this.FundFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.FundFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FundFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle32.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle32.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle32.Hover = System.Drawing.Color.Empty;
            textStyle32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.FundFilter1.TextStyle = textStyle32;
            this.FundFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FundFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FundFilter1.Watermark.Text = "Watermark text";
            this.FundFilter1.Watermark.Visible = false;
            // 
            // FundFilter2
            // 
            this.FundFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FundFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.FundFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.FundFilter2.Border.HoverVisible = true;
            this.FundFilter2.Border.Rounding = 6;
            this.FundFilter2.Border.Thickness = 1;
            this.FundFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.FundFilter2.Border.Visible = true;
            this.FundFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.FundFilter2.ButtonImage = null;
            this.FundFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.FundFilter2.ButtonWidth = 30;
            this.FundFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FundFilter2.DropDownHeight = 100;
            this.FundFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter2.DropDownWidth = 86;
            this.FundFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter2.FormattingEnabled = true;
            this.FundFilter2.ImageList = null;
            this.FundFilter2.ImageVisible = false;
            this.FundFilter2.Index = 0;
            this.FundFilter2.IntegralHeight = false;
            this.FundFilter2.ItemHeight = 24;
            this.FundFilter2.ItemImageVisible = true;
            this.FundFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.FundFilter2.Location = new System.Drawing.Point(36, 197);
            this.FundFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.FundFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.FundFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter2.Name = "FundFilter2";
            this.FundFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter2.SeparatorVisible = false;
            this.FundFilter2.Size = new System.Drawing.Size(147, 30);
            this.FundFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter2.TabIndex = 172;
            this.FundFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.FundFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FundFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle31.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle31.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle31.Hover = System.Drawing.Color.Empty;
            textStyle31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.FundFilter2.TextStyle = textStyle31;
            this.FundFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FundFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FundFilter2.Watermark.Text = "Watermark text";
            this.FundFilter2.Watermark.Visible = false;
            // 
            // FundFilter3
            // 
            this.FundFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FundFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.FundFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.FundFilter3.Border.HoverVisible = true;
            this.FundFilter3.Border.Rounding = 6;
            this.FundFilter3.Border.Thickness = 1;
            this.FundFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.FundFilter3.Border.Visible = true;
            this.FundFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.FundFilter3.ButtonImage = null;
            this.FundFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.FundFilter3.ButtonWidth = 30;
            this.FundFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FundFilter3.DropDownHeight = 100;
            this.FundFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter3.FormattingEnabled = true;
            this.FundFilter3.ImageList = null;
            this.FundFilter3.ImageVisible = false;
            this.FundFilter3.Index = 0;
            this.FundFilter3.IntegralHeight = false;
            this.FundFilter3.ItemHeight = 24;
            this.FundFilter3.ItemImageVisible = true;
            this.FundFilter3.Location = new System.Drawing.Point(38, 90);
            this.FundFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.FundFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.FundFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter3.Name = "FundFilter3";
            this.FundFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter3.SeparatorVisible = false;
            this.FundFilter3.Size = new System.Drawing.Size(147, 30);
            this.FundFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter3.TabIndex = 171;
            this.FundFilter3.Tag = "FundName";
            this.FundFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.FundFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FundFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle30.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle30.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle30.Hover = System.Drawing.Color.Empty;
            textStyle30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.FundFilter3.TextStyle = textStyle30;
            this.FundFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FundFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FundFilter3.Watermark.Text = "Watermark text";
            this.FundFilter3.Watermark.Visible = false;
            // 
            // FundFilter4
            // 
            this.FundFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FundFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.FundFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.FundFilter4.Border.HoverVisible = true;
            this.FundFilter4.Border.Rounding = 6;
            this.FundFilter4.Border.Thickness = 1;
            this.FundFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.FundFilter4.Border.Visible = true;
            this.FundFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.FundFilter4.ButtonImage = null;
            this.FundFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.FundFilter4.ButtonWidth = 30;
            this.FundFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FundFilter4.DropDownHeight = 100;
            this.FundFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter4.FormattingEnabled = true;
            this.FundFilter4.ImageList = null;
            this.FundFilter4.ImageVisible = false;
            this.FundFilter4.Index = 0;
            this.FundFilter4.IntegralHeight = false;
            this.FundFilter4.ItemHeight = 24;
            this.FundFilter4.ItemImageVisible = true;
            this.FundFilter4.Location = new System.Drawing.Point(36, 220);
            this.FundFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.FundFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.FundFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.FundFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter4.Name = "FundFilter4";
            this.FundFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FundFilter4.SeparatorVisible = false;
            this.FundFilter4.Size = new System.Drawing.Size(147, 30);
            this.FundFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.FundFilter4.TabIndex = 172;
            this.FundFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.FundFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FundFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.FundFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle29.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle29.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle29.Hover = System.Drawing.Color.Empty;
            textStyle29.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.FundFilter4.TextStyle = textStyle29;
            this.FundFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FundFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FundFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FundFilter4.Watermark.Text = "Watermark text";
            this.FundFilter4.Watermark.Visible = false;
            // 
            // BocFilter1
            // 
            this.BocFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BocFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.BocFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BocFilter1.Border.HoverVisible = true;
            this.BocFilter1.Border.Rounding = 6;
            this.BocFilter1.Border.Thickness = 1;
            this.BocFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BocFilter1.Border.Visible = true;
            this.BocFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.BocFilter1.ButtonImage = null;
            this.BocFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.BocFilter1.ButtonWidth = 30;
            this.BocFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BocFilter1.DropDownHeight = 100;
            this.BocFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter1.DropDownWidth = 83;
            this.BocFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter1.FormattingEnabled = true;
            this.BocFilter1.ImageList = null;
            this.BocFilter1.ImageVisible = false;
            this.BocFilter1.Index = 0;
            this.BocFilter1.IntegralHeight = false;
            this.BocFilter1.ItemHeight = 24;
            this.BocFilter1.ItemImageVisible = true;
            this.BocFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.BocFilter1.Location = new System.Drawing.Point(24, 88);
            this.BocFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter1.Name = "BocFilter1";
            this.BocFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter1.SeparatorVisible = false;
            this.BocFilter1.Size = new System.Drawing.Size(147, 30);
            this.BocFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter1.TabIndex = 171;
            this.BocFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle28.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle28.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle28.Hover = System.Drawing.Color.Empty;
            textStyle28.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter1.TextStyle = textStyle28;
            this.BocFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter1.Watermark.Text = "Watermark text";
            this.BocFilter1.Watermark.Visible = false;
            // 
            // BocFilter2
            // 
            this.BocFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BocFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.BocFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BocFilter2.Border.HoverVisible = true;
            this.BocFilter2.Border.Rounding = 6;
            this.BocFilter2.Border.Thickness = 1;
            this.BocFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BocFilter2.Border.Visible = true;
            this.BocFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.BocFilter2.ButtonImage = null;
            this.BocFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.BocFilter2.ButtonWidth = 30;
            this.BocFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BocFilter2.DropDownHeight = 100;
            this.BocFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter2.DropDownWidth = 86;
            this.BocFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter2.FormattingEnabled = true;
            this.BocFilter2.ImageList = null;
            this.BocFilter2.ImageVisible = false;
            this.BocFilter2.Index = 0;
            this.BocFilter2.IntegralHeight = false;
            this.BocFilter2.ItemHeight = 24;
            this.BocFilter2.ItemImageVisible = true;
            this.BocFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.BocFilter2.Location = new System.Drawing.Point(24, 187);
            this.BocFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter2.Name = "BocFilter2";
            this.BocFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter2.SeparatorVisible = false;
            this.BocFilter2.Size = new System.Drawing.Size(147, 30);
            this.BocFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter2.TabIndex = 172;
            this.BocFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle27.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle27.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle27.Hover = System.Drawing.Color.Empty;
            textStyle27.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter2.TextStyle = textStyle27;
            this.BocFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter2.Watermark.Text = "Watermark text";
            this.BocFilter2.Watermark.Visible = false;
            // 
            // BocFilter3
            // 
            this.BocFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BocFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.BocFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BocFilter3.Border.HoverVisible = true;
            this.BocFilter3.Border.Rounding = 6;
            this.BocFilter3.Border.Thickness = 1;
            this.BocFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BocFilter3.Border.Visible = true;
            this.BocFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.BocFilter3.ButtonImage = null;
            this.BocFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.BocFilter3.ButtonWidth = 30;
            this.BocFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BocFilter3.DropDownHeight = 100;
            this.BocFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter3.FormattingEnabled = true;
            this.BocFilter3.ImageList = null;
            this.BocFilter3.ImageVisible = false;
            this.BocFilter3.Index = 0;
            this.BocFilter3.IntegralHeight = false;
            this.BocFilter3.ItemHeight = 24;
            this.BocFilter3.ItemImageVisible = true;
            this.BocFilter3.Location = new System.Drawing.Point(24, 91);
            this.BocFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter3.Name = "BocFilter3";
            this.BocFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter3.SeparatorVisible = false;
            this.BocFilter3.Size = new System.Drawing.Size(147, 30);
            this.BocFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter3.TabIndex = 173;
            this.BocFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle26.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle26.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle26.Hover = System.Drawing.Color.Empty;
            textStyle26.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter3.TextStyle = textStyle26;
            this.BocFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter3.Watermark.Text = "Watermark text";
            this.BocFilter3.Watermark.Visible = false;
            // 
            // BocFilter4
            // 
            this.BocFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BocFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.BocFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BocFilter4.Border.HoverVisible = true;
            this.BocFilter4.Border.Rounding = 6;
            this.BocFilter4.Border.Thickness = 1;
            this.BocFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BocFilter4.Border.Visible = true;
            this.BocFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.BocFilter4.ButtonImage = null;
            this.BocFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.BocFilter4.ButtonWidth = 30;
            this.BocFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BocFilter4.DropDownHeight = 100;
            this.BocFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BocFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BocFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter4.FormattingEnabled = true;
            this.BocFilter4.ImageList = null;
            this.BocFilter4.ImageVisible = false;
            this.BocFilter4.Index = 0;
            this.BocFilter4.IntegralHeight = false;
            this.BocFilter4.ItemHeight = 24;
            this.BocFilter4.ItemImageVisible = true;
            this.BocFilter4.Location = new System.Drawing.Point(25, 222);
            this.BocFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter4.Name = "BocFilter4";
            this.BocFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter4.SeparatorVisible = false;
            this.BocFilter4.Size = new System.Drawing.Size(147, 30);
            this.BocFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter4.TabIndex = 174;
            this.BocFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle25.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle25.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle25.Hover = System.Drawing.Color.Empty;
            textStyle25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter4.TextStyle = textStyle25;
            this.BocFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter4.Watermark.Text = "Watermark text";
            this.BocFilter4.Watermark.Visible = false;
            // 
            // NpmFilter1
            // 
            this.NpmFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NpmFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.NpmFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter1.Border.HoverVisible = true;
            this.NpmFilter1.Border.Rounding = 6;
            this.NpmFilter1.Border.Thickness = 1;
            this.NpmFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.NpmFilter1.Border.Visible = true;
            this.NpmFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter1.ButtonImage = null;
            this.NpmFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.NpmFilter1.ButtonWidth = 30;
            this.NpmFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NpmFilter1.DropDownHeight = 100;
            this.NpmFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter1.DropDownWidth = 83;
            this.NpmFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter1.FormattingEnabled = true;
            this.NpmFilter1.ImageList = null;
            this.NpmFilter1.ImageVisible = false;
            this.NpmFilter1.Index = 0;
            this.NpmFilter1.IntegralHeight = false;
            this.NpmFilter1.ItemHeight = 24;
            this.NpmFilter1.ItemImageVisible = true;
            this.NpmFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.NpmFilter1.Location = new System.Drawing.Point(31, 90);
            this.NpmFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.NpmFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.NpmFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter1.Name = "NpmFilter1";
            this.NpmFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter1.SeparatorVisible = false;
            this.NpmFilter1.Size = new System.Drawing.Size(147, 30);
            this.NpmFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter1.TabIndex = 171;
            this.NpmFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.NpmFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NpmFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle24.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle24.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle24.Hover = System.Drawing.Color.Empty;
            textStyle24.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NpmFilter1.TextStyle = textStyle24;
            this.NpmFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NpmFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.NpmFilter1.Watermark.Text = "Watermark text";
            this.NpmFilter1.Watermark.Visible = false;
            // 
            // NpmFilter2
            // 
            this.NpmFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NpmFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.NpmFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter2.Border.HoverVisible = true;
            this.NpmFilter2.Border.Rounding = 6;
            this.NpmFilter2.Border.Thickness = 1;
            this.NpmFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.NpmFilter2.Border.Visible = true;
            this.NpmFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter2.ButtonImage = null;
            this.NpmFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.NpmFilter2.ButtonWidth = 30;
            this.NpmFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NpmFilter2.DropDownHeight = 100;
            this.NpmFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter2.DropDownWidth = 86;
            this.NpmFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter2.FormattingEnabled = true;
            this.NpmFilter2.ImageList = null;
            this.NpmFilter2.ImageVisible = false;
            this.NpmFilter2.Index = 0;
            this.NpmFilter2.IntegralHeight = false;
            this.NpmFilter2.ItemHeight = 24;
            this.NpmFilter2.ItemImageVisible = true;
            this.NpmFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.NpmFilter2.Location = new System.Drawing.Point(38, 199);
            this.NpmFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.NpmFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.NpmFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter2.Name = "NpmFilter2";
            this.NpmFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter2.SeparatorVisible = false;
            this.NpmFilter2.Size = new System.Drawing.Size(147, 30);
            this.NpmFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter2.TabIndex = 172;
            this.NpmFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.NpmFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NpmFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle23.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle23.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle23.Hover = System.Drawing.Color.Empty;
            textStyle23.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NpmFilter2.TextStyle = textStyle23;
            this.NpmFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NpmFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.NpmFilter2.Watermark.Text = "Watermark text";
            this.NpmFilter2.Watermark.Visible = false;
            // 
            // NpmFilter3
            // 
            this.NpmFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NpmFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.NpmFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter3.Border.HoverVisible = true;
            this.NpmFilter3.Border.Rounding = 6;
            this.NpmFilter3.Border.Thickness = 1;
            this.NpmFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.NpmFilter3.Border.Visible = true;
            this.NpmFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter3.ButtonImage = null;
            this.NpmFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.NpmFilter3.ButtonWidth = 30;
            this.NpmFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NpmFilter3.DropDownHeight = 100;
            this.NpmFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter3.FormattingEnabled = true;
            this.NpmFilter3.ImageList = null;
            this.NpmFilter3.ImageVisible = false;
            this.NpmFilter3.Index = 0;
            this.NpmFilter3.IntegralHeight = false;
            this.NpmFilter3.ItemHeight = 24;
            this.NpmFilter3.ItemImageVisible = true;
            this.NpmFilter3.Location = new System.Drawing.Point(31, 100);
            this.NpmFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.NpmFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.NpmFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter3.Name = "NpmFilter3";
            this.NpmFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter3.SeparatorVisible = false;
            this.NpmFilter3.Size = new System.Drawing.Size(147, 30);
            this.NpmFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter3.TabIndex = 173;
            this.NpmFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.NpmFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NpmFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle22.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle22.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle22.Hover = System.Drawing.Color.Empty;
            textStyle22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NpmFilter3.TextStyle = textStyle22;
            this.NpmFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NpmFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.NpmFilter3.Watermark.Text = "Watermark text";
            this.NpmFilter3.Watermark.Visible = false;
            // 
            // NpmFilter4
            // 
            this.NpmFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NpmFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.NpmFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter4.Border.HoverVisible = true;
            this.NpmFilter4.Border.Rounding = 6;
            this.NpmFilter4.Border.Thickness = 1;
            this.NpmFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.NpmFilter4.Border.Visible = true;
            this.NpmFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.NpmFilter4.ButtonImage = null;
            this.NpmFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.NpmFilter4.ButtonWidth = 30;
            this.NpmFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NpmFilter4.DropDownHeight = 100;
            this.NpmFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NpmFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NpmFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter4.FormattingEnabled = true;
            this.NpmFilter4.ImageList = null;
            this.NpmFilter4.ImageVisible = false;
            this.NpmFilter4.Index = 0;
            this.NpmFilter4.IntegralHeight = false;
            this.NpmFilter4.ItemHeight = 24;
            this.NpmFilter4.ItemImageVisible = true;
            this.NpmFilter4.Location = new System.Drawing.Point(31, 218);
            this.NpmFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.NpmFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.NpmFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.NpmFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter4.Name = "NpmFilter4";
            this.NpmFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NpmFilter4.SeparatorVisible = false;
            this.NpmFilter4.Size = new System.Drawing.Size(147, 30);
            this.NpmFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.NpmFilter4.TabIndex = 174;
            this.NpmFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.NpmFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NpmFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.NpmFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle21.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle21.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle21.Hover = System.Drawing.Color.Empty;
            textStyle21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NpmFilter4.TextStyle = textStyle21;
            this.NpmFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NpmFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NpmFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.NpmFilter4.Watermark.Text = "Watermark text";
            this.NpmFilter4.Watermark.Visible = false;
            // 
            // GoalFilter1
            // 
            this.GoalFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GoalFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GoalFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter1.Border.HoverVisible = true;
            this.GoalFilter1.Border.Rounding = 6;
            this.GoalFilter1.Border.Thickness = 1;
            this.GoalFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GoalFilter1.Border.Visible = true;
            this.GoalFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter1.ButtonImage = null;
            this.GoalFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GoalFilter1.ButtonWidth = 30;
            this.GoalFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GoalFilter1.DropDownHeight = 100;
            this.GoalFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter1.DropDownWidth = 83;
            this.GoalFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter1.FormattingEnabled = true;
            this.GoalFilter1.ImageList = null;
            this.GoalFilter1.ImageVisible = false;
            this.GoalFilter1.Index = 0;
            this.GoalFilter1.IntegralHeight = false;
            this.GoalFilter1.ItemHeight = 24;
            this.GoalFilter1.ItemImageVisible = true;
            this.GoalFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.GoalFilter1.Location = new System.Drawing.Point(20, 82);
            this.GoalFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GoalFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.GoalFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter1.Name = "GoalFilter1";
            this.GoalFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter1.SeparatorVisible = false;
            this.GoalFilter1.Size = new System.Drawing.Size(147, 30);
            this.GoalFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter1.TabIndex = 171;
            this.GoalFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.GoalFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GoalFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle19.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle19.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle19.Hover = System.Drawing.Color.Empty;
            textStyle19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GoalFilter1.TextStyle = textStyle19;
            this.GoalFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoalFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GoalFilter1.Watermark.Text = "Watermark text";
            this.GoalFilter1.Watermark.Visible = false;
            // 
            // GoalFilter2
            // 
            this.GoalFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GoalFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GoalFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter2.Border.HoverVisible = true;
            this.GoalFilter2.Border.Rounding = 6;
            this.GoalFilter2.Border.Thickness = 1;
            this.GoalFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GoalFilter2.Border.Visible = true;
            this.GoalFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter2.ButtonImage = null;
            this.GoalFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GoalFilter2.ButtonWidth = 30;
            this.GoalFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GoalFilter2.DropDownHeight = 100;
            this.GoalFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter2.DropDownWidth = 86;
            this.GoalFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter2.FormattingEnabled = true;
            this.GoalFilter2.ImageList = null;
            this.GoalFilter2.ImageVisible = false;
            this.GoalFilter2.Index = 0;
            this.GoalFilter2.IntegralHeight = false;
            this.GoalFilter2.ItemHeight = 24;
            this.GoalFilter2.ItemImageVisible = true;
            this.GoalFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.GoalFilter2.Location = new System.Drawing.Point(20, 193);
            this.GoalFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GoalFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.GoalFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter2.Name = "GoalFilter2";
            this.GoalFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter2.SeparatorVisible = false;
            this.GoalFilter2.Size = new System.Drawing.Size(147, 30);
            this.GoalFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter2.TabIndex = 172;
            this.GoalFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.GoalFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GoalFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle20.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle20.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle20.Hover = System.Drawing.Color.Empty;
            textStyle20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GoalFilter2.TextStyle = textStyle20;
            this.GoalFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoalFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GoalFilter2.Watermark.Text = "Watermark text";
            this.GoalFilter2.Watermark.Visible = false;
            // 
            // GoalFilter3
            // 
            this.GoalFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GoalFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GoalFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter3.Border.HoverVisible = true;
            this.GoalFilter3.Border.Rounding = 6;
            this.GoalFilter3.Border.Thickness = 1;
            this.GoalFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GoalFilter3.Border.Visible = true;
            this.GoalFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter3.ButtonImage = null;
            this.GoalFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GoalFilter3.ButtonWidth = 30;
            this.GoalFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GoalFilter3.DropDownHeight = 100;
            this.GoalFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter3.FormattingEnabled = true;
            this.GoalFilter3.ImageList = null;
            this.GoalFilter3.ImageVisible = false;
            this.GoalFilter3.Index = 0;
            this.GoalFilter3.IntegralHeight = false;
            this.GoalFilter3.ItemHeight = 24;
            this.GoalFilter3.ItemImageVisible = true;
            this.GoalFilter3.Location = new System.Drawing.Point(20, 85);
            this.GoalFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GoalFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.GoalFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter3.Name = "GoalFilter3";
            this.GoalFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter3.SeparatorVisible = false;
            this.GoalFilter3.Size = new System.Drawing.Size(147, 30);
            this.GoalFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter3.TabIndex = 173;
            this.GoalFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.GoalFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GoalFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle17.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle17.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle17.Hover = System.Drawing.Color.Empty;
            textStyle17.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GoalFilter3.TextStyle = textStyle17;
            this.GoalFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoalFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GoalFilter3.Watermark.Text = "Watermark text";
            this.GoalFilter3.Watermark.Visible = false;
            // 
            // GoalFilter4
            // 
            this.GoalFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GoalFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GoalFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter4.Border.HoverVisible = true;
            this.GoalFilter4.Border.Rounding = 6;
            this.GoalFilter4.Border.Thickness = 1;
            this.GoalFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GoalFilter4.Border.Visible = true;
            this.GoalFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GoalFilter4.ButtonImage = null;
            this.GoalFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GoalFilter4.ButtonWidth = 30;
            this.GoalFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GoalFilter4.DropDownHeight = 100;
            this.GoalFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter4.FormattingEnabled = true;
            this.GoalFilter4.ImageList = null;
            this.GoalFilter4.ImageVisible = false;
            this.GoalFilter4.Index = 0;
            this.GoalFilter4.IntegralHeight = false;
            this.GoalFilter4.ItemHeight = 24;
            this.GoalFilter4.ItemImageVisible = true;
            this.GoalFilter4.Location = new System.Drawing.Point(20, 216);
            this.GoalFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GoalFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.GoalFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GoalFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter4.Name = "GoalFilter4";
            this.GoalFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalFilter4.SeparatorVisible = false;
            this.GoalFilter4.Size = new System.Drawing.Size(147, 30);
            this.GoalFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GoalFilter4.TabIndex = 174;
            this.GoalFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.GoalFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GoalFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GoalFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle18.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle18.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle18.Hover = System.Drawing.Color.Empty;
            textStyle18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GoalFilter4.TextStyle = textStyle18;
            this.GoalFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoalFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GoalFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GoalFilter4.Watermark.Text = "Watermark text";
            this.GoalFilter4.Watermark.Visible = false;
            // 
            // ObjectiveFilter1
            // 
            this.ObjectiveFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ObjectiveFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ObjectiveFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter1.Border.HoverVisible = true;
            this.ObjectiveFilter1.Border.Rounding = 6;
            this.ObjectiveFilter1.Border.Thickness = 1;
            this.ObjectiveFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ObjectiveFilter1.Border.Visible = true;
            this.ObjectiveFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter1.ButtonImage = null;
            this.ObjectiveFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ObjectiveFilter1.ButtonWidth = 30;
            this.ObjectiveFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ObjectiveFilter1.DropDownHeight = 100;
            this.ObjectiveFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter1.DropDownWidth = 83;
            this.ObjectiveFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter1.FormattingEnabled = true;
            this.ObjectiveFilter1.ImageList = null;
            this.ObjectiveFilter1.ImageVisible = false;
            this.ObjectiveFilter1.Index = 0;
            this.ObjectiveFilter1.IntegralHeight = false;
            this.ObjectiveFilter1.ItemHeight = 24;
            this.ObjectiveFilter1.ItemImageVisible = true;
            this.ObjectiveFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.ObjectiveFilter1.Location = new System.Drawing.Point(30, 87);
            this.ObjectiveFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.ObjectiveFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter1.Name = "ObjectiveFilter1";
            this.ObjectiveFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter1.SeparatorVisible = false;
            this.ObjectiveFilter1.Size = new System.Drawing.Size(147, 30);
            this.ObjectiveFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter1.TabIndex = 171;
            this.ObjectiveFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.ObjectiveFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ObjectiveFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle15.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle15.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle15.Hover = System.Drawing.Color.Empty;
            textStyle15.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ObjectiveFilter1.TextStyle = textStyle15;
            this.ObjectiveFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ObjectiveFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ObjectiveFilter1.Watermark.Text = "Watermark text";
            this.ObjectiveFilter1.Watermark.Visible = false;
            // 
            // ObjectiveFilter2
            // 
            this.ObjectiveFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ObjectiveFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ObjectiveFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter2.Border.HoverVisible = true;
            this.ObjectiveFilter2.Border.Rounding = 6;
            this.ObjectiveFilter2.Border.Thickness = 1;
            this.ObjectiveFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ObjectiveFilter2.Border.Visible = true;
            this.ObjectiveFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter2.ButtonImage = null;
            this.ObjectiveFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ObjectiveFilter2.ButtonWidth = 30;
            this.ObjectiveFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ObjectiveFilter2.DropDownHeight = 100;
            this.ObjectiveFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter2.DropDownWidth = 86;
            this.ObjectiveFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter2.FormattingEnabled = true;
            this.ObjectiveFilter2.ImageList = null;
            this.ObjectiveFilter2.ImageVisible = false;
            this.ObjectiveFilter2.Index = 0;
            this.ObjectiveFilter2.IntegralHeight = false;
            this.ObjectiveFilter2.ItemHeight = 24;
            this.ObjectiveFilter2.ItemImageVisible = true;
            this.ObjectiveFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.ObjectiveFilter2.Location = new System.Drawing.Point(30, 199);
            this.ObjectiveFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.ObjectiveFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter2.Name = "ObjectiveFilter2";
            this.ObjectiveFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter2.SeparatorVisible = false;
            this.ObjectiveFilter2.Size = new System.Drawing.Size(147, 30);
            this.ObjectiveFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter2.TabIndex = 172;
            this.ObjectiveFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.ObjectiveFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ObjectiveFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle16.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle16.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle16.Hover = System.Drawing.Color.Empty;
            textStyle16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ObjectiveFilter2.TextStyle = textStyle16;
            this.ObjectiveFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ObjectiveFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ObjectiveFilter2.Watermark.Text = "Watermark text";
            this.ObjectiveFilter2.Watermark.Visible = false;
            // 
            // ObjectiveFilter3
            // 
            this.ObjectiveFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ObjectiveFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ObjectiveFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter3.Border.HoverVisible = true;
            this.ObjectiveFilter3.Border.Rounding = 6;
            this.ObjectiveFilter3.Border.Thickness = 1;
            this.ObjectiveFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ObjectiveFilter3.Border.Visible = true;
            this.ObjectiveFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter3.ButtonImage = null;
            this.ObjectiveFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ObjectiveFilter3.ButtonWidth = 30;
            this.ObjectiveFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ObjectiveFilter3.DropDownHeight = 100;
            this.ObjectiveFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter3.FormattingEnabled = true;
            this.ObjectiveFilter3.ImageList = null;
            this.ObjectiveFilter3.ImageVisible = false;
            this.ObjectiveFilter3.Index = 0;
            this.ObjectiveFilter3.IntegralHeight = false;
            this.ObjectiveFilter3.ItemHeight = 24;
            this.ObjectiveFilter3.ItemImageVisible = true;
            this.ObjectiveFilter3.Location = new System.Drawing.Point(30, 83);
            this.ObjectiveFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.ObjectiveFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter3.Name = "ObjectiveFilter3";
            this.ObjectiveFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter3.SeparatorVisible = false;
            this.ObjectiveFilter3.Size = new System.Drawing.Size(147, 30);
            this.ObjectiveFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter3.TabIndex = 173;
            this.ObjectiveFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.ObjectiveFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ObjectiveFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle13.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle13.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle13.Hover = System.Drawing.Color.Empty;
            textStyle13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ObjectiveFilter3.TextStyle = textStyle13;
            this.ObjectiveFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ObjectiveFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ObjectiveFilter3.Watermark.Text = "Watermark text";
            this.ObjectiveFilter3.Watermark.Visible = false;
            // 
            // ObjectiveFilter4
            // 
            this.ObjectiveFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ObjectiveFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ObjectiveFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter4.Border.HoverVisible = true;
            this.ObjectiveFilter4.Border.Rounding = 6;
            this.ObjectiveFilter4.Border.Thickness = 1;
            this.ObjectiveFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ObjectiveFilter4.Border.Visible = true;
            this.ObjectiveFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter4.ButtonImage = null;
            this.ObjectiveFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ObjectiveFilter4.ButtonWidth = 30;
            this.ObjectiveFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ObjectiveFilter4.DropDownHeight = 100;
            this.ObjectiveFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectiveFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter4.FormattingEnabled = true;
            this.ObjectiveFilter4.ImageList = null;
            this.ObjectiveFilter4.ImageVisible = false;
            this.ObjectiveFilter4.Index = 0;
            this.ObjectiveFilter4.IntegralHeight = false;
            this.ObjectiveFilter4.ItemHeight = 24;
            this.ObjectiveFilter4.ItemImageVisible = true;
            this.ObjectiveFilter4.Location = new System.Drawing.Point(30, 214);
            this.ObjectiveFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ObjectiveFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.ObjectiveFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ObjectiveFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter4.Name = "ObjectiveFilter4";
            this.ObjectiveFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjectiveFilter4.SeparatorVisible = false;
            this.ObjectiveFilter4.Size = new System.Drawing.Size(147, 30);
            this.ObjectiveFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ObjectiveFilter4.TabIndex = 174;
            this.ObjectiveFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.ObjectiveFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ObjectiveFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ObjectiveFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle14.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle14.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle14.Hover = System.Drawing.Color.Empty;
            textStyle14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ObjectiveFilter4.TextStyle = textStyle14;
            this.ObjectiveFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ObjectiveFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ObjectiveFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ObjectiveFilter4.Watermark.Text = "Watermark text";
            this.ObjectiveFilter4.Watermark.Visible = false;
            // 
            // DivisionFilter1
            // 
            this.DivisionFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DivisionFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.DivisionFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter1.Border.HoverVisible = true;
            this.DivisionFilter1.Border.Rounding = 6;
            this.DivisionFilter1.Border.Thickness = 1;
            this.DivisionFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DivisionFilter1.Border.Visible = true;
            this.DivisionFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter1.ButtonImage = null;
            this.DivisionFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.DivisionFilter1.ButtonWidth = 30;
            this.DivisionFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DivisionFilter1.DropDownHeight = 100;
            this.DivisionFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter1.DropDownWidth = 83;
            this.DivisionFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter1.FormattingEnabled = true;
            this.DivisionFilter1.ImageList = null;
            this.DivisionFilter1.ImageVisible = false;
            this.DivisionFilter1.Index = 0;
            this.DivisionFilter1.IntegralHeight = false;
            this.DivisionFilter1.ItemHeight = 24;
            this.DivisionFilter1.ItemImageVisible = true;
            this.DivisionFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.DivisionFilter1.Location = new System.Drawing.Point(26, 85);
            this.DivisionFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.DivisionFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.DivisionFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter1.Name = "DivisionFilter1";
            this.DivisionFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter1.SeparatorVisible = false;
            this.DivisionFilter1.Size = new System.Drawing.Size(147, 30);
            this.DivisionFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter1.TabIndex = 171;
            this.DivisionFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.DivisionFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle11.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle11.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle11.Hover = System.Drawing.Color.Empty;
            textStyle11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DivisionFilter1.TextStyle = textStyle11;
            this.DivisionFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DivisionFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DivisionFilter1.Watermark.Text = "Watermark text";
            this.DivisionFilter1.Watermark.Visible = false;
            // 
            // DivisionFilter2
            // 
            this.DivisionFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DivisionFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.DivisionFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter2.Border.HoverVisible = true;
            this.DivisionFilter2.Border.Rounding = 6;
            this.DivisionFilter2.Border.Thickness = 1;
            this.DivisionFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DivisionFilter2.Border.Visible = true;
            this.DivisionFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter2.ButtonImage = null;
            this.DivisionFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.DivisionFilter2.ButtonWidth = 30;
            this.DivisionFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DivisionFilter2.DropDownHeight = 100;
            this.DivisionFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter2.DropDownWidth = 86;
            this.DivisionFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter2.FormattingEnabled = true;
            this.DivisionFilter2.ImageList = null;
            this.DivisionFilter2.ImageVisible = false;
            this.DivisionFilter2.Index = 0;
            this.DivisionFilter2.IntegralHeight = false;
            this.DivisionFilter2.ItemHeight = 24;
            this.DivisionFilter2.ItemImageVisible = true;
            this.DivisionFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.DivisionFilter2.Location = new System.Drawing.Point(26, 196);
            this.DivisionFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.DivisionFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.DivisionFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter2.Name = "DivisionFilter2";
            this.DivisionFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter2.SeparatorVisible = false;
            this.DivisionFilter2.Size = new System.Drawing.Size(147, 30);
            this.DivisionFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter2.TabIndex = 172;
            this.DivisionFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.DivisionFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle12.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle12.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle12.Hover = System.Drawing.Color.Empty;
            textStyle12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DivisionFilter2.TextStyle = textStyle12;
            this.DivisionFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DivisionFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DivisionFilter2.Watermark.Text = "Watermark text";
            this.DivisionFilter2.Watermark.Visible = false;
            // 
            // DivisionFilter3
            // 
            this.DivisionFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DivisionFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.DivisionFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter3.Border.HoverVisible = true;
            this.DivisionFilter3.Border.Rounding = 6;
            this.DivisionFilter3.Border.Thickness = 1;
            this.DivisionFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DivisionFilter3.Border.Visible = true;
            this.DivisionFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter3.ButtonImage = null;
            this.DivisionFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.DivisionFilter3.ButtonWidth = 30;
            this.DivisionFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DivisionFilter3.DropDownHeight = 100;
            this.DivisionFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter3.FormattingEnabled = true;
            this.DivisionFilter3.ImageList = null;
            this.DivisionFilter3.ImageVisible = false;
            this.DivisionFilter3.Index = 0;
            this.DivisionFilter3.IntegralHeight = false;
            this.DivisionFilter3.ItemHeight = 24;
            this.DivisionFilter3.ItemImageVisible = true;
            this.DivisionFilter3.Location = new System.Drawing.Point(26, 97);
            this.DivisionFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.DivisionFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.DivisionFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter3.Name = "DivisionFilter3";
            this.DivisionFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter3.SeparatorVisible = false;
            this.DivisionFilter3.Size = new System.Drawing.Size(147, 30);
            this.DivisionFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter3.TabIndex = 173;
            this.DivisionFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.DivisionFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle9.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle9.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle9.Hover = System.Drawing.Color.Empty;
            textStyle9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DivisionFilter3.TextStyle = textStyle9;
            this.DivisionFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DivisionFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DivisionFilter3.Watermark.Text = "Watermark text";
            this.DivisionFilter3.Watermark.Visible = false;
            // 
            // DivisionFilter4
            // 
            this.DivisionFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DivisionFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.DivisionFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter4.Border.HoverVisible = true;
            this.DivisionFilter4.Border.Rounding = 6;
            this.DivisionFilter4.Border.Thickness = 1;
            this.DivisionFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DivisionFilter4.Border.Visible = true;
            this.DivisionFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.DivisionFilter4.ButtonImage = null;
            this.DivisionFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.DivisionFilter4.ButtonWidth = 30;
            this.DivisionFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DivisionFilter4.DropDownHeight = 100;
            this.DivisionFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter4.FormattingEnabled = true;
            this.DivisionFilter4.ImageList = null;
            this.DivisionFilter4.ImageVisible = false;
            this.DivisionFilter4.Index = 0;
            this.DivisionFilter4.IntegralHeight = false;
            this.DivisionFilter4.ItemHeight = 24;
            this.DivisionFilter4.ItemImageVisible = true;
            this.DivisionFilter4.Location = new System.Drawing.Point(26, 227);
            this.DivisionFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.DivisionFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.DivisionFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.DivisionFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter4.Name = "DivisionFilter4";
            this.DivisionFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionFilter4.SeparatorVisible = false;
            this.DivisionFilter4.Size = new System.Drawing.Size(147, 30);
            this.DivisionFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.DivisionFilter4.TabIndex = 174;
            this.DivisionFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.DivisionFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DivisionFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DivisionFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle10.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle10.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle10.Hover = System.Drawing.Color.Empty;
            textStyle10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DivisionFilter4.TextStyle = textStyle10;
            this.DivisionFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DivisionFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DivisionFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DivisionFilter4.Watermark.Text = "Watermark text";
            this.DivisionFilter4.Watermark.Visible = false;
            // 
            // AreaFilter1
            // 
            this.AreaFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AreaFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AreaFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter1.Border.HoverVisible = true;
            this.AreaFilter1.Border.Rounding = 6;
            this.AreaFilter1.Border.Thickness = 1;
            this.AreaFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AreaFilter1.Border.Visible = true;
            this.AreaFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter1.ButtonImage = null;
            this.AreaFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AreaFilter1.ButtonWidth = 30;
            this.AreaFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AreaFilter1.DropDownHeight = 100;
            this.AreaFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter1.DropDownWidth = 83;
            this.AreaFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter1.FormattingEnabled = true;
            this.AreaFilter1.ImageList = null;
            this.AreaFilter1.ImageVisible = false;
            this.AreaFilter1.Index = 0;
            this.AreaFilter1.IntegralHeight = false;
            this.AreaFilter1.ItemHeight = 24;
            this.AreaFilter1.ItemImageVisible = true;
            this.AreaFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.AreaFilter1.Location = new System.Drawing.Point(24, 82);
            this.AreaFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AreaFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.AreaFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter1.Name = "AreaFilter1";
            this.AreaFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter1.SeparatorVisible = false;
            this.AreaFilter1.Size = new System.Drawing.Size(147, 30);
            this.AreaFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter1.TabIndex = 171;
            this.AreaFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.AreaFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AreaFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AreaFilter1.TextStyle = textStyle7;
            this.AreaFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AreaFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AreaFilter1.Watermark.Text = "Watermark text";
            this.AreaFilter1.Watermark.Visible = false;
            // 
            // AreaFilter2
            // 
            this.AreaFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AreaFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AreaFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter2.Border.HoverVisible = true;
            this.AreaFilter2.Border.Rounding = 6;
            this.AreaFilter2.Border.Thickness = 1;
            this.AreaFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AreaFilter2.Border.Visible = true;
            this.AreaFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter2.ButtonImage = null;
            this.AreaFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AreaFilter2.ButtonWidth = 30;
            this.AreaFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AreaFilter2.DropDownHeight = 100;
            this.AreaFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter2.DropDownWidth = 86;
            this.AreaFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter2.FormattingEnabled = true;
            this.AreaFilter2.ImageList = null;
            this.AreaFilter2.ImageVisible = false;
            this.AreaFilter2.Index = 0;
            this.AreaFilter2.IntegralHeight = false;
            this.AreaFilter2.ItemHeight = 24;
            this.AreaFilter2.ItemImageVisible = true;
            this.AreaFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.AreaFilter2.Location = new System.Drawing.Point(24, 194);
            this.AreaFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AreaFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.AreaFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter2.Name = "AreaFilter2";
            this.AreaFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter2.SeparatorVisible = false;
            this.AreaFilter2.Size = new System.Drawing.Size(147, 30);
            this.AreaFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter2.TabIndex = 172;
            this.AreaFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.AreaFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AreaFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle8.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle8.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle8.Hover = System.Drawing.Color.Empty;
            textStyle8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AreaFilter2.TextStyle = textStyle8;
            this.AreaFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AreaFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AreaFilter2.Watermark.Text = "Watermark text";
            this.AreaFilter2.Watermark.Visible = false;
            // 
            // AreaFilter3
            // 
            this.AreaFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AreaFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AreaFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter3.Border.HoverVisible = true;
            this.AreaFilter3.Border.Rounding = 6;
            this.AreaFilter3.Border.Thickness = 1;
            this.AreaFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AreaFilter3.Border.Visible = true;
            this.AreaFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter3.ButtonImage = null;
            this.AreaFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AreaFilter3.ButtonWidth = 30;
            this.AreaFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AreaFilter3.DropDownHeight = 100;
            this.AreaFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter3.FormattingEnabled = true;
            this.AreaFilter3.ImageList = null;
            this.AreaFilter3.ImageVisible = false;
            this.AreaFilter3.Index = 0;
            this.AreaFilter3.IntegralHeight = false;
            this.AreaFilter3.ItemHeight = 24;
            this.AreaFilter3.ItemImageVisible = true;
            this.AreaFilter3.Location = new System.Drawing.Point(24, 82);
            this.AreaFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AreaFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.AreaFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter3.Name = "AreaFilter3";
            this.AreaFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter3.SeparatorVisible = false;
            this.AreaFilter3.Size = new System.Drawing.Size(147, 30);
            this.AreaFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter3.TabIndex = 173;
            this.AreaFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.AreaFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AreaFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AreaFilter3.TextStyle = textStyle5;
            this.AreaFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AreaFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AreaFilter3.Watermark.Text = "Watermark text";
            this.AreaFilter3.Watermark.Visible = false;
            // 
            // AreaFilter4
            // 
            this.AreaFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AreaFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AreaFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter4.Border.HoverVisible = true;
            this.AreaFilter4.Border.Rounding = 6;
            this.AreaFilter4.Border.Thickness = 1;
            this.AreaFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AreaFilter4.Border.Visible = true;
            this.AreaFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AreaFilter4.ButtonImage = null;
            this.AreaFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AreaFilter4.ButtonWidth = 30;
            this.AreaFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AreaFilter4.DropDownHeight = 100;
            this.AreaFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter4.FormattingEnabled = true;
            this.AreaFilter4.ImageList = null;
            this.AreaFilter4.ImageVisible = false;
            this.AreaFilter4.Index = 0;
            this.AreaFilter4.IntegralHeight = false;
            this.AreaFilter4.ItemHeight = 24;
            this.AreaFilter4.ItemImageVisible = true;
            this.AreaFilter4.Location = new System.Drawing.Point(24, 213);
            this.AreaFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AreaFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.AreaFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AreaFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter4.Name = "AreaFilter4";
            this.AreaFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaFilter4.SeparatorVisible = false;
            this.AreaFilter4.Size = new System.Drawing.Size(147, 30);
            this.AreaFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AreaFilter4.TabIndex = 174;
            this.AreaFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.AreaFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AreaFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AreaFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AreaFilter4.TextStyle = textStyle6;
            this.AreaFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AreaFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AreaFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AreaFilter4.Watermark.Text = "Watermark text";
            this.AreaFilter4.Watermark.Visible = false;
            // 
            // ProjectFilter1
            // 
            this.ProjectFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ProjectFilter1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter1.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ProjectFilter1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter1.Border.HoverVisible = true;
            this.ProjectFilter1.Border.Rounding = 6;
            this.ProjectFilter1.Border.Thickness = 1;
            this.ProjectFilter1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ProjectFilter1.Border.Visible = true;
            this.ProjectFilter1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter1.ButtonImage = null;
            this.ProjectFilter1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ProjectFilter1.ButtonWidth = 30;
            this.ProjectFilter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProjectFilter1.DropDownHeight = 100;
            this.ProjectFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter1.DropDownWidth = 83;
            this.ProjectFilter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter1.FormattingEnabled = true;
            this.ProjectFilter1.ImageList = null;
            this.ProjectFilter1.ImageVisible = false;
            this.ProjectFilter1.Index = 0;
            this.ProjectFilter1.IntegralHeight = false;
            this.ProjectFilter1.ItemHeight = 24;
            this.ProjectFilter1.ItemImageVisible = true;
            this.ProjectFilter1.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.ProjectFilter1.Location = new System.Drawing.Point(24, 99);
            this.ProjectFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ProjectFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.ProjectFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter1.Name = "ProjectFilter1";
            this.ProjectFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter1.Size = new System.Drawing.Size(147, 30);
            this.ProjectFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter1.TabIndex = 172;
            this.ProjectFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.ProjectFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ProjectFilter1.TextStyle = textStyle3;
            this.ProjectFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ProjectFilter1.Watermark.Text = "Watermark text";
            this.ProjectFilter1.Watermark.Visible = false;
            // 
            // ProjectFilter2
            // 
            this.ProjectFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ProjectFilter2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter2.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ProjectFilter2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter2.Border.HoverVisible = true;
            this.ProjectFilter2.Border.Rounding = 6;
            this.ProjectFilter2.Border.Thickness = 1;
            this.ProjectFilter2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ProjectFilter2.Border.Visible = true;
            this.ProjectFilter2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter2.ButtonImage = null;
            this.ProjectFilter2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ProjectFilter2.ButtonWidth = 30;
            this.ProjectFilter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProjectFilter2.DropDownHeight = 100;
            this.ProjectFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter2.DropDownWidth = 86;
            this.ProjectFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter2.FormattingEnabled = true;
            this.ProjectFilter2.ImageList = null;
            this.ProjectFilter2.ImageVisible = false;
            this.ProjectFilter2.Index = 0;
            this.ProjectFilter2.IntegralHeight = false;
            this.ProjectFilter2.ItemHeight = 24;
            this.ProjectFilter2.ItemImageVisible = true;
            this.ProjectFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.ProjectFilter2.Location = new System.Drawing.Point(24, 213);
            this.ProjectFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ProjectFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.ProjectFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter2.Name = "ProjectFilter2";
            this.ProjectFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter2.Size = new System.Drawing.Size(147, 30);
            this.ProjectFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter2.TabIndex = 173;
            this.ProjectFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.ProjectFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ProjectFilter2.TextStyle = textStyle4;
            this.ProjectFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ProjectFilter2.Watermark.Text = "Watermark text";
            this.ProjectFilter2.Watermark.Visible = false;
            // 
            // ProjectFilter3
            // 
            this.ProjectFilter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ProjectFilter3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter3.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ProjectFilter3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter3.Border.HoverVisible = true;
            this.ProjectFilter3.Border.Rounding = 6;
            this.ProjectFilter3.Border.Thickness = 1;
            this.ProjectFilter3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ProjectFilter3.Border.Visible = true;
            this.ProjectFilter3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter3.ButtonImage = null;
            this.ProjectFilter3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ProjectFilter3.ButtonWidth = 30;
            this.ProjectFilter3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProjectFilter3.DropDownHeight = 100;
            this.ProjectFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter3.FormattingEnabled = true;
            this.ProjectFilter3.ImageList = null;
            this.ProjectFilter3.ImageVisible = false;
            this.ProjectFilter3.Index = 0;
            this.ProjectFilter3.IntegralHeight = false;
            this.ProjectFilter3.ItemHeight = 24;
            this.ProjectFilter3.ItemImageVisible = true;
            this.ProjectFilter3.Location = new System.Drawing.Point(24, 91);
            this.ProjectFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ProjectFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.ProjectFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter3.Name = "ProjectFilter3";
            this.ProjectFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter3.Size = new System.Drawing.Size(147, 30);
            this.ProjectFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter3.TabIndex = 174;
            this.ProjectFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.ProjectFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ProjectFilter3.TextStyle = textStyle1;
            this.ProjectFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ProjectFilter3.Watermark.Text = "Watermark text";
            this.ProjectFilter3.Watermark.Visible = false;
            // 
            // ProjectFilter4
            // 
            this.ProjectFilter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ProjectFilter4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter4.BackColorState.Enabled = System.Drawing.Color.Black;
            this.ProjectFilter4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter4.Border.HoverVisible = true;
            this.ProjectFilter4.Border.Rounding = 6;
            this.ProjectFilter4.Border.Thickness = 1;
            this.ProjectFilter4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ProjectFilter4.Border.Visible = true;
            this.ProjectFilter4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.ProjectFilter4.ButtonImage = null;
            this.ProjectFilter4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ProjectFilter4.ButtonWidth = 30;
            this.ProjectFilter4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProjectFilter4.DropDownHeight = 100;
            this.ProjectFilter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter4.FormattingEnabled = true;
            this.ProjectFilter4.ImageList = null;
            this.ProjectFilter4.ImageVisible = false;
            this.ProjectFilter4.Index = 0;
            this.ProjectFilter4.IntegralHeight = false;
            this.ProjectFilter4.ItemHeight = 24;
            this.ProjectFilter4.ItemImageVisible = true;
            this.ProjectFilter4.Location = new System.Drawing.Point(24, 222);
            this.ProjectFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.ProjectFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.ProjectFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.ProjectFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter4.Name = "ProjectFilter4";
            this.ProjectFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectFilter4.Size = new System.Drawing.Size(147, 30);
            this.ProjectFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ProjectFilter4.TabIndex = 175;
            this.ProjectFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.ProjectFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ProjectFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ProjectFilter4.TextStyle = textStyle2;
            this.ProjectFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProjectFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ProjectFilter4.Watermark.Text = "Watermark text";
            this.ProjectFilter4.Watermark.Visible = false;
            // 
            // visualLabel1
            // 
            this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel1.Location = new System.Drawing.Point(19, 24);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(85, 32);
            this.visualLabel1.TabIndex = 164;
            this.visualLabel1.Text = "ID";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle47.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle47.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle47.Hover = System.Drawing.Color.Empty;
            textStyle47.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle47;
            // 
            // visualLabel2
            // 
            this.visualLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel2.Location = new System.Drawing.Point(177, 24);
            this.visualLabel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel2.Name = "visualLabel2";
            this.visualLabel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel2.Outline = false;
            this.visualLabel2.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel2.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.ReflectionSpacing = 0;
            this.visualLabel2.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel2.ShadowDirection = 315;
            this.visualLabel2.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ShadowOpacity = 100;
            this.visualLabel2.Size = new System.Drawing.Size(115, 32);
            this.visualLabel2.TabIndex = 165;
            this.visualLabel2.Text = "Budget Level";
            this.visualLabel2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle46.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle46.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle46.Hover = System.Drawing.Color.Empty;
            textStyle46.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel2.TextStyle = textStyle46;
            // 
            // visualLabel3
            // 
            this.visualLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel3.Location = new System.Drawing.Point(356, 28);
            this.visualLabel3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel3.Name = "visualLabel3";
            this.visualLabel3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel3.Outline = false;
            this.visualLabel3.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel3.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.ReflectionSpacing = 0;
            this.visualLabel3.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel3.ShadowDirection = 315;
            this.visualLabel3.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ShadowOpacity = 100;
            this.visualLabel3.Size = new System.Drawing.Size(115, 32);
            this.visualLabel3.TabIndex = 166;
            this.visualLabel3.Text = "Fiscal Year";
            this.visualLabel3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle45.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle45.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle45.Hover = System.Drawing.Color.Empty;
            textStyle45.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel3.TextStyle = textStyle45;
            // 
            // visualLabel4
            // 
            this.visualLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel4.Location = new System.Drawing.Point(3, 122);
            this.visualLabel4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel4.Name = "visualLabel4";
            this.visualLabel4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel4.Outline = false;
            this.visualLabel4.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel4.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel4.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel4.ReflectionSpacing = 0;
            this.visualLabel4.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel4.ShadowDirection = 315;
            this.visualLabel4.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel4.ShadowOpacity = 100;
            this.visualLabel4.Size = new System.Drawing.Size(115, 32);
            this.visualLabel4.TabIndex = 167;
            this.visualLabel4.Text = "Fund";
            this.visualLabel4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle44.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle44.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle44.Hover = System.Drawing.Color.Empty;
            textStyle44.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel4.TextStyle = textStyle44;
            // 
            // visualLabel5
            // 
            this.visualLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel5.Location = new System.Drawing.Point(150, 122);
            this.visualLabel5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel5.Name = "visualLabel5";
            this.visualLabel5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel5.Outline = false;
            this.visualLabel5.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel5.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel5.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel5.ReflectionSpacing = 0;
            this.visualLabel5.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel5.ShadowDirection = 315;
            this.visualLabel5.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel5.ShadowOpacity = 100;
            this.visualLabel5.Size = new System.Drawing.Size(58, 32);
            this.visualLabel5.TabIndex = 168;
            this.visualLabel5.Text = "AH ";
            this.visualLabel5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel5.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle43.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle43.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle43.Hover = System.Drawing.Color.Empty;
            textStyle43.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel5.TextStyle = textStyle43;
            // 
            // visualLabel6
            // 
            this.visualLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel6.Location = new System.Drawing.Point(356, 131);
            this.visualLabel6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel6.Name = "visualLabel6";
            this.visualLabel6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel6.Outline = false;
            this.visualLabel6.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel6.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel6.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel6.ReflectionSpacing = 0;
            this.visualLabel6.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel6.ShadowDirection = 315;
            this.visualLabel6.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel6.ShadowOpacity = 100;
            this.visualLabel6.Size = new System.Drawing.Size(115, 32);
            this.visualLabel6.TabIndex = 169;
            this.visualLabel6.Text = "RC";
            this.visualLabel6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel6.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle42.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle42.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle42.Hover = System.Drawing.Color.Empty;
            textStyle42.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel6.TextStyle = textStyle42;
            // 
            // visualLabel7
            // 
            this.visualLabel7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel7.Location = new System.Drawing.Point(3, 221);
            this.visualLabel7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel7.Name = "visualLabel7";
            this.visualLabel7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel7.Outline = false;
            this.visualLabel7.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel7.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel7.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel7.ReflectionSpacing = 0;
            this.visualLabel7.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel7.ShadowDirection = 315;
            this.visualLabel7.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel7.ShadowOpacity = 100;
            this.visualLabel7.Size = new System.Drawing.Size(115, 32);
            this.visualLabel7.TabIndex = 170;
            this.visualLabel7.Text = "BOC";
            this.visualLabel7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel7.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle41.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle41.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle41.Hover = System.Drawing.Color.Empty;
            textStyle41.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel7.TextStyle = textStyle41;
            // 
            // visualLabel8
            // 
            this.visualLabel8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel8.Location = new System.Drawing.Point(147, 225);
            this.visualLabel8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel8.Name = "visualLabel8";
            this.visualLabel8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel8.Outline = false;
            this.visualLabel8.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel8.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel8.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel8.ReflectionSpacing = 0;
            this.visualLabel8.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel8.ShadowDirection = 315;
            this.visualLabel8.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel8.ShadowOpacity = 100;
            this.visualLabel8.Size = new System.Drawing.Size(115, 32);
            this.visualLabel8.TabIndex = 171;
            this.visualLabel8.Text = "PRC Code";
            this.visualLabel8.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel8.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle40.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle40.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle40.Hover = System.Drawing.Color.Empty;
            textStyle40.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel8.TextStyle = textStyle40;
            // 
            // visualLabel9
            // 
            this.visualLabel9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel9.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel9.Location = new System.Drawing.Point(325, 225);
            this.visualLabel9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel9.Name = "visualLabel9";
            this.visualLabel9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel9.Outline = false;
            this.visualLabel9.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel9.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel9.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel9.ReflectionSpacing = 0;
            this.visualLabel9.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel9.ShadowDirection = 315;
            this.visualLabel9.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel9.ShadowOpacity = 100;
            this.visualLabel9.Size = new System.Drawing.Size(146, 32);
            this.visualLabel9.TabIndex = 172;
            this.visualLabel9.Text = "Original Amount";
            this.visualLabel9.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel9.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle39.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle39.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle39.Hover = System.Drawing.Color.Empty;
            textStyle39.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel9.TextStyle = textStyle39;
            // 
            // visualLabel10
            // 
            this.visualLabel10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel10.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel10.Location = new System.Drawing.Point(35, 338);
            this.visualLabel10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel10.Name = "visualLabel10";
            this.visualLabel10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel10.Outline = false;
            this.visualLabel10.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel10.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel10.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel10.ReflectionSpacing = 0;
            this.visualLabel10.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel10.ShadowDirection = 315;
            this.visualLabel10.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel10.ShadowOpacity = 100;
            this.visualLabel10.Size = new System.Drawing.Size(115, 32);
            this.visualLabel10.TabIndex = 173;
            this.visualLabel10.Text = "New Amount";
            this.visualLabel10.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel10.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle38.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle38.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle38.Hover = System.Drawing.Color.Empty;
            textStyle38.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel10.TextStyle = textStyle38;
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
            this.metroSetTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox3.Image = null;
            this.metroSetTextBox3.Lines = null;
            this.metroSetTextBox3.Location = new System.Drawing.Point(256, 160);
            this.metroSetTextBox3.MaxLength = 32767;
            this.metroSetTextBox3.Multiline = false;
            this.metroSetTextBox3.Name = "metroSetTextBox3";
            this.metroSetTextBox3.ReadOnly = false;
            this.metroSetTextBox3.Size = new System.Drawing.Size(74, 40);
            this.metroSetTextBox3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox3.StyleManager = null;
            this.metroSetTextBox3.TabIndex = 174;
            this.metroSetTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox3.ThemeAuthor = "Narwin";
            this.metroSetTextBox3.ThemeName = "MetroDark";
            this.metroSetTextBox3.UseSystemPasswordChar = false;
            this.metroSetTextBox3.WatermarkText = "";
            // 
            // visualLabel11
            // 
            this.visualLabel11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel11.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel11.Location = new System.Drawing.Point(256, 131);
            this.visualLabel11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel11.Name = "visualLabel11";
            this.visualLabel11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel11.Outline = false;
            this.visualLabel11.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel11.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel11.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel11.ReflectionSpacing = 0;
            this.visualLabel11.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel11.ShadowDirection = 315;
            this.visualLabel11.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel11.ShadowOpacity = 100;
            this.visualLabel11.Size = new System.Drawing.Size(58, 23);
            this.visualLabel11.TabIndex = 175;
            this.visualLabel11.Text = "ORG";
            this.visualLabel11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel11.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle37.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle37.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle37.Hover = System.Drawing.Color.Empty;
            textStyle37.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel11.TextStyle = textStyle37;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 40;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Top;
            this.ClientSize = new System.Drawing.Size(1843, 1021);
            this.Controls.Add(this.SummaryTabControl);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Right;
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1769, 1074);
            this.Name = "SummaryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            this.GridGroupBox.ResumeLayout(false);
            this.GridGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.visualGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).EndInit();
            this.AccountTabControl.ResumeLayout(false);
            this.EditTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.GraphTab.ResumeLayout(false);
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
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander1;
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
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel FundExpander2;
        private Label label25;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ProjectExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel AreaExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DivisionExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ObjectiveExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel GoalExpander2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel NpmExpander2;
        private Label label7;
        private Label label27;
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
        private TabControlAdv AccountTabControl;
        private TabPageAdv EditTab;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private MetroSetTextBox BudgetLevel;
        private MetroSetTextBox ID;
        private MetroSetTextBox metroSetTextBox1;
        private MetroSetTextBox Amount;
        private MetroSetTextBox Code;
        private MetroSetTextBox BOC;
        private MetroSetTextBox RC;
        private MetroSetTextBox Fund;
        private MetroSetTextBox BFY;
        private MetroSetTextBox Org;
        private TabPageAdv GraphTab;
        protected ChartControl AccountChart;
        private TabPageAdv ToolNavTab;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label31;
        private Label label32;
        private Label label34;
        private Label label37;
        private Label label40;
        private Label label41;
        private Label lblPrc;
        private Label lblBoc;
        private Label label33;
        private Button button7;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button12;
        private Button button11;
        private Button GridRefreshButton;
        private Button button10;
        private Button button9;
        private MetroSet_UI.Components.MetroSetToolTip metroSetToolTip1;
        private Button CalculatorButton;
        private MetroFramework.Controls.MetroGrid Grid;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GridGroupBox;
        private Panel panel2;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridAccountFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridBocFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridFundFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ProjectFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ProjectFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ProjectFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ProjectFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AreaFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AreaFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AreaFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AreaFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox DivisionFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox DivisionFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox DivisionFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox DivisionFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ObjectiveFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ObjectiveFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ObjectiveFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox ObjectiveFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GoalFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GoalFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GoalFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GoalFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox NpmFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox NpmFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox NpmFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox NpmFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox FundFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox FundFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox FundFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox FundFilter1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel10;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel9;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel8;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel7;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel6;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel5;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel11;
        private MetroSetTextBox metroSetTextBox3;
    }
}