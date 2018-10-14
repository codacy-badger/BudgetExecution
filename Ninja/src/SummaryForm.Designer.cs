

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
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
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
            VisualPlus.Structure.TextStyle textStyle13 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle9 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle8 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle10 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle11 = new VisualPlus.Structure.TextStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            VisualPlus.Structure.TextStyle textStyle12 = new VisualPlus.Structure.TextStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            VisualPlus.Structure.TextStyle textStyle43 = new VisualPlus.Structure.TextStyle();
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
            VisualPlus.Structure.TextStyle textStyle14 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle15 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle16 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle17 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle18 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle19 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle20 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle21 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle22 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle23 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle24 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle25 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle26 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle27 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle28 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle29 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle30 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle31 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle32 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle33 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle34 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle35 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle36 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle37 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle38 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle39 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle40 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle41 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle42 = new VisualPlus.Structure.TextStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.AllocationTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.PrimaryFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocExpander2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.BocFilter4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocFilter3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.BocExpander1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.BocFilter2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BocFilter1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.BocChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SummaryTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.DatabaseTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.GridGroupBox = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.visualGroupBox5 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.GridYearFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.lblBoc = new System.Windows.Forms.Label();
            this.GridBocFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.lblFund = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.GridFundFilter = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.visualGroupBox3 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblAve = new System.Windows.Forms.Label();
            this.visualGroupBox4 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.visualGroupBox2 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.GridRefreshButton = new System.Windows.Forms.Button();
            this.DatabaseSearchButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.GraphTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.AccountChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.EditTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.visualLabel11 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.UpdateOrg = new MetroSet_UI.Controls.MetroSetTextBox();
            this.visualLabel10 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel9 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel8 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel7 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel6 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.UpdateBudgetLevel = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Updateid = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Amount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateCode = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateBOC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateRC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateFund = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateBFY = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UpdateAH = new MetroSet_UI.Controls.MetroSetTextBox();
            this.AddTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.visualLabel20 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel19 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel18 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel17 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel16 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel15 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel14 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel13 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel12 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.AddCode = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddBoc = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddSub = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddRc = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddOrg = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddAh = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddFund = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddYear = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.AddLevel = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.Grid222 = new MetroFramework.Controls.MetroGrid();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroSetToolTip1 = new MetroSet_UI.Components.MetroSetToolTip();
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.chartControl1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).BeginInit();
            this.MiniTabControl1.SuspendLayout();
            this.AllocationTab.SuspendLayout();
            this.BocExpander2.SuspendLayout();
            this.BocExpander1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).BeginInit();
            this.SummaryTabControl.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            this.GridGroupBox.SuspendLayout();
            this.visualGroupBox5.SuspendLayout();
            this.visualGroupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.visualGroupBox4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.visualGroupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).BeginInit();
            this.AccountTabControl.SuspendLayout();
            this.GraphTab.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.AddTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid222)).BeginInit();
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
            // AllocationTab
            // 
            this.AllocationTab.Controls.Add(this.PrimaryFilter);
            this.AllocationTab.Controls.Add(this.BocExpander2);
            this.AllocationTab.Controls.Add(this.BocExpander1);
            this.AllocationTab.Controls.Add(this.BocChart);
            this.AllocationTab.Image = null;
            this.AllocationTab.ImageSize = new System.Drawing.Size(16, 16);
            this.AllocationTab.Location = new System.Drawing.Point(0, 32);
            this.AllocationTab.Name = "AllocationTab";
            this.AllocationTab.ShowCloseButton = true;
            this.AllocationTab.Size = new System.Drawing.Size(1788, 971);
            this.AllocationTab.TabBackColor = System.Drawing.Color.Black;
            this.AllocationTab.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.AllocationTab.TabIndex = 2;
            this.AllocationTab.Tag = "BocName";
            this.AllocationTab.Text = "Authority";
            this.AllocationTab.ThemesEnabled = false;
            // 
            // PrimaryFilter
            // 
            this.PrimaryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PrimaryFilter.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrimaryFilter.BackColorState.Enabled = System.Drawing.Color.Black;
            this.PrimaryFilter.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrimaryFilter.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.PrimaryFilter.Border.HoverVisible = true;
            this.PrimaryFilter.Border.Rounding = 6;
            this.PrimaryFilter.Border.Thickness = 1;
            this.PrimaryFilter.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.PrimaryFilter.Border.Visible = true;
            this.PrimaryFilter.ButtonColor = System.Drawing.Color.SteelBlue;
            this.PrimaryFilter.ButtonImage = null;
            this.PrimaryFilter.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.PrimaryFilter.ButtonWidth = 30;
            this.PrimaryFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PrimaryFilter.DropDownHeight = 100;
            this.PrimaryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrimaryFilter.DropDownWidth = 181;
            this.PrimaryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrimaryFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PrimaryFilter.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PrimaryFilter.FormattingEnabled = true;
            this.PrimaryFilter.ImageList = null;
            this.PrimaryFilter.ImageVisible = false;
            this.PrimaryFilter.Index = 0;
            this.PrimaryFilter.IntegralHeight = false;
            this.PrimaryFilter.ItemHeight = 30;
            this.PrimaryFilter.ItemImageVisible = true;
            this.PrimaryFilter.Items.AddRange(new object[] {
            "FundName",
            "BocName",
            "NPM",
            "GoalName",
            "Objective",
            "Division",
            "ProgramArea",
            "ProgramProjectCode"});
            this.PrimaryFilter.Location = new System.Drawing.Point(1525, 69);
            this.PrimaryFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.PrimaryFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.PrimaryFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.PrimaryFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.PrimaryFilter.Name = "PrimaryFilter";
            this.PrimaryFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrimaryFilter.SeparatorVisible = false;
            this.PrimaryFilter.Size = new System.Drawing.Size(192, 36);
            this.PrimaryFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.PrimaryFilter.TabIndex = 172;
            this.PrimaryFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.PrimaryFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.PrimaryFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrimaryFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.PrimaryFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PrimaryFilter.TextStyle = textStyle1;
            this.PrimaryFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PrimaryFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PrimaryFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.PrimaryFilter.Watermark.Text = "Watermark text";
            this.PrimaryFilter.Watermark.Visible = false;
            this.PrimaryFilter.SelectedIndexChanged += new System.EventHandler(this.PrimaryFilterControl_ItemSelected);
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
            this.BocExpander2.ExpandedHeight = 254;
            this.BocExpander2.IsExpanded = false;
            this.BocExpander2.Location = new System.Drawing.Point(1502, 468);
            this.BocExpander2.Name = "BocExpander2";
            this.BocExpander2.Size = new System.Drawing.Size(230, 37);
            this.BocExpander2.TabIndex = 109;
            this.BocExpander2.Text = "Chart Filters";
            this.BocExpander2.UseAnimation = true;
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
            this.BocFilter4.ItemHeight = 30;
            this.BocFilter4.ItemImageVisible = true;
            this.BocFilter4.Location = new System.Drawing.Point(23, 193);
            this.BocFilter4.MaxDropDownItems = 30;
            this.BocFilter4.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter4.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter4.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter4.Name = "BocFilter4";
            this.BocFilter4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter4.SeparatorVisible = false;
            this.BocFilter4.Size = new System.Drawing.Size(194, 36);
            this.BocFilter4.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter4.TabIndex = 174;
            this.BocFilter4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter4.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter4.TextStyle = textStyle2;
            this.BocFilter4.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter4.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter4.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter4.Watermark.Text = "Watermark text";
            this.BocFilter4.Watermark.Visible = false;
            this.BocFilter4.SelectedIndexChanged += new System.EventHandler(this.ChartFilterControl4_ItemSelected);
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
            this.BocFilter3.ItemHeight = 30;
            this.BocFilter3.ItemImageVisible = true;
            this.BocFilter3.Location = new System.Drawing.Point(23, 85);
            this.BocFilter3.MaxDropDownItems = 30;
            this.BocFilter3.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter3.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter3.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter3.Name = "BocFilter3";
            this.BocFilter3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter3.SeparatorVisible = false;
            this.BocFilter3.Size = new System.Drawing.Size(194, 36);
            this.BocFilter3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter3.TabIndex = 173;
            this.BocFilter3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter3.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter3.TextStyle = textStyle3;
            this.BocFilter3.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter3.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter3.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter3.Watermark.Text = "Watermark text";
            this.BocFilter3.Watermark.Visible = false;
            this.BocFilter3.SelectedIndexChanged += new System.EventHandler(this.ChartFilterControl3_ItemSelected);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label35.Location = new System.Drawing.Point(24, 60);
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
            this.label36.Location = new System.Drawing.Point(19, 168);
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
            this.BocExpander1.ExpandedHeight = 245;
            this.BocExpander1.IsExpanded = false;
            this.BocExpander1.Location = new System.Drawing.Point(1502, 162);
            this.BocExpander1.Name = "BocExpander1";
            this.BocExpander1.Size = new System.Drawing.Size(230, 37);
            this.BocExpander1.TabIndex = 108;
            this.BocExpander1.Text = "Chart Configuration";
            this.BocExpander1.UseAnimation = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Measure";
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
            this.BocFilter2.ItemHeight = 30;
            this.BocFilter2.ItemImageVisible = true;
            this.BocFilter2.Items.AddRange(new object[] {
            "Total",
            "Count",
            "Average",
            "Ratio"});
            this.BocFilter2.Location = new System.Drawing.Point(23, 180);
            this.BocFilter2.MaxDropDownItems = 30;
            this.BocFilter2.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter2.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter2.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter2.Name = "BocFilter2";
            this.BocFilter2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter2.SeparatorVisible = false;
            this.BocFilter2.Size = new System.Drawing.Size(195, 36);
            this.BocFilter2.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter2.TabIndex = 172;
            this.BocFilter2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter2.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter2.TextStyle = textStyle4;
            this.BocFilter2.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter2.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter2.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter2.Watermark.Text = "Watermark text";
            this.BocFilter2.Watermark.Visible = false;
            this.BocFilter2.SelectedIndexChanged += new System.EventHandler(this.ChartFilterControl2_ItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.label6.Location = new System.Drawing.Point(24, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 118;
            this.label6.Text = "Chart Type";
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
            this.BocFilter1.ItemHeight = 30;
            this.BocFilter1.ItemImageVisible = true;
            this.BocFilter1.Items.AddRange(new object[] {
            "Column",
            "Area"});
            this.BocFilter1.Location = new System.Drawing.Point(23, 86);
            this.BocFilter1.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.BocFilter1.MenuItemNormal = System.Drawing.Color.Black;
            this.BocFilter1.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.BocFilter1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter1.Name = "BocFilter1";
            this.BocFilter1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BocFilter1.SeparatorVisible = false;
            this.BocFilter1.Size = new System.Drawing.Size(195, 36);
            this.BocFilter1.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.BocFilter1.TabIndex = 171;
            this.BocFilter1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter1.TextDisabledColor = System.Drawing.Color.Empty;
            this.BocFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BocFilter1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BocFilter1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BocFilter1.TextStyle = textStyle5;
            this.BocFilter1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BocFilter1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BocFilter1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BocFilter1.Watermark.Text = "Watermark text";
            this.BocFilter1.Watermark.Visible = false;
            this.BocFilter1.SelectedIndexChanged += new System.EventHandler(this.ChartFilterControl1_ItemSelected);
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
            this.BocChart.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.BocChart.Localize = null;
            this.BocChart.Location = new System.Drawing.Point(20, 22);
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
            this.BocChart.Rotation = 10F;
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
            this.BocChart.ShowToolTips = true;
            this.BocChart.Size = new System.Drawing.Size(1465, 798);
            this.BocChart.Spacing = 5F;
            this.BocChart.SpacingBetweenPoints = 5F;
            this.BocChart.SpacingBetweenSeries = 5F;
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
            // SummaryTabControl
            // 
            this.SummaryTabControl.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.SummaryTabControl.ActiveTabForeColor = System.Drawing.SystemColors.HighlightText;
            this.SummaryTabControl.AdjustTopGap = 3;
            this.SummaryTabControl.BeforeTouchSize = new System.Drawing.Size(1788, 1003);
            this.SummaryTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummaryTabControl.BorderWidth = 0;
            this.SummaryTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.SummaryTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.SummaryTabControl.Controls.Add(this.AllocationTab);
            this.SummaryTabControl.Controls.Add(this.DatabaseTab);
            this.SummaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTabControl.FixedSingleBorderColor = System.Drawing.Color.Black;
            this.SummaryTabControl.FocusOnTabClick = false;
            this.SummaryTabControl.InactiveTabColor = System.Drawing.Color.Black;
            this.SummaryTabControl.InActiveTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SummaryTabControl.ItemSize = new System.Drawing.Size(150, 30);
            this.SummaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.SummaryTabControl.Name = "SummaryTabControl";
            this.SummaryTabControl.Padding = new System.Drawing.Point(15, 3);
            this.SummaryTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.SummaryTabControl.ShowScroll = false;
            this.SummaryTabControl.ShowSeparator = false;
            this.SummaryTabControl.Size = new System.Drawing.Size(1788, 1003);
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
            this.DatabaseTab.Location = new System.Drawing.Point(0, 32);
            this.DatabaseTab.MaximumSize = new System.Drawing.Size(1900, 1000);
            this.DatabaseTab.MinimumSize = new System.Drawing.Size(1900, 1000);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(2);
            this.DatabaseTab.ShowCloseButton = true;
            this.DatabaseTab.Size = new System.Drawing.Size(1788, 971);
            this.DatabaseTab.TabBackColor = System.Drawing.Color.Black;
            this.DatabaseTab.TabIndex = 9;
            this.DatabaseTab.Tag = "Database";
            this.DatabaseTab.Text = "Account Manager";
            this.DatabaseTab.ThemesEnabled = false;
            // 
            // GridGroupBox
            // 
            this.GridGroupBox.BackColor = System.Drawing.Color.Black;
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
            this.GridGroupBox.Controls.Add(this.visualGroupBox5);
            this.GridGroupBox.Controls.Add(this.visualGroupBox3);
            this.GridGroupBox.Controls.Add(this.visualGroupBox4);
            this.GridGroupBox.Controls.Add(this.visualGroupBox2);
            this.GridGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridGroupBox.Image = null;
            this.GridGroupBox.Location = new System.Drawing.Point(12, 56);
            this.GridGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridGroupBox.Name = "GridGroupBox";
            this.GridGroupBox.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GridGroupBox.Separator = false;
            this.GridGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridGroupBox.Size = new System.Drawing.Size(1178, 844);
            this.GridGroupBox.TabIndex = 162;
            this.GridGroupBox.Text = "Database";
            this.GridGroupBox.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle13.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle13.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle13.Hover = System.Drawing.Color.Empty;
            textStyle13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridGroupBox.TextStyle = textStyle13;
            this.GridGroupBox.TitleBoxHeight = 35;
            // 
            // visualGroupBox5
            // 
            this.visualGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.visualGroupBox5.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox5.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.visualGroupBox5.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox5.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualGroupBox5.Border.HoverVisible = true;
            this.visualGroupBox5.Border.Rounding = 6;
            this.visualGroupBox5.Border.Thickness = 1;
            this.visualGroupBox5.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox5.Border.Visible = true;
            this.visualGroupBox5.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox5.Controls.Add(this.GridYearFilter);
            this.visualGroupBox5.Controls.Add(this.lblBoc);
            this.visualGroupBox5.Controls.Add(this.GridBocFilter);
            this.visualGroupBox5.Controls.Add(this.lblFund);
            this.visualGroupBox5.Controls.Add(this.lblYear);
            this.visualGroupBox5.Controls.Add(this.GridFundFilter);
            this.visualGroupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.visualGroupBox5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox5.Image = null;
            this.visualGroupBox5.Location = new System.Drawing.Point(27, 114);
            this.visualGroupBox5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox5.Name = "visualGroupBox5";
            this.visualGroupBox5.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox5.Separator = false;
            this.visualGroupBox5.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox5.Size = new System.Drawing.Size(177, 406);
            this.visualGroupBox5.TabIndex = 176;
            this.visualGroupBox5.Text = "Filters";
            this.visualGroupBox5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox5.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle9.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle9.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle9.Hover = System.Drawing.Color.Empty;
            textStyle9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox5.TextStyle = textStyle9;
            this.visualGroupBox5.TitleBoxHeight = 25;
            // 
            // GridYearFilter
            // 
            this.GridYearFilter.BackColor = System.Drawing.Color.Transparent;
            this.GridYearFilter.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridYearFilter.BackColorState.Enabled = System.Drawing.Color.Black;
            this.GridYearFilter.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridYearFilter.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridYearFilter.Border.HoverVisible = true;
            this.GridYearFilter.Border.Rounding = 6;
            this.GridYearFilter.Border.Thickness = 1;
            this.GridYearFilter.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GridYearFilter.Border.Visible = true;
            this.GridYearFilter.ButtonColor = System.Drawing.Color.SteelBlue;
            this.GridYearFilter.ButtonImage = null;
            this.GridYearFilter.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.GridYearFilter.ButtonWidth = 30;
            this.GridYearFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GridYearFilter.DropDownHeight = 100;
            this.GridYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GridYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridYearFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridYearFilter.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GridYearFilter.FormattingEnabled = true;
            this.GridYearFilter.ImageList = null;
            this.GridYearFilter.ImageVisible = false;
            this.GridYearFilter.Index = 0;
            this.GridYearFilter.IntegralHeight = false;
            this.GridYearFilter.ItemHeight = 24;
            this.GridYearFilter.ItemImageVisible = true;
            this.GridYearFilter.Location = new System.Drawing.Point(14, 79);
            this.GridYearFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridYearFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridYearFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridYearFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridYearFilter.Name = "GridYearFilter";
            this.GridYearFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridYearFilter.SeparatorVisible = false;
            this.GridYearFilter.Size = new System.Drawing.Size(149, 30);
            this.GridYearFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridYearFilter.TabIndex = 172;
            this.GridYearFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridYearFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridYearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridYearFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridYearFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridYearFilter.TextStyle = textStyle6;
            this.GridYearFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridYearFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridYearFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridYearFilter.Watermark.Text = "Watermark text";
            this.GridYearFilter.Watermark.Visible = false;
            this.GridYearFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl1_ItemSelected);
            this.GridYearFilter.SelectedValueChanged += new System.EventHandler(this.GridFilterControl1_ItemSelected);
            // 
            // lblBoc
            // 
            this.lblBoc.AutoSize = true;
            this.lblBoc.BackColor = System.Drawing.Color.Transparent;
            this.lblBoc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoc.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblBoc.Location = new System.Drawing.Point(18, 249);
            this.lblBoc.Name = "lblBoc";
            this.lblBoc.Size = new System.Drawing.Size(41, 21);
            this.lblBoc.TabIndex = 6;
            this.lblBoc.Text = "BOC";
            // 
            // GridBocFilter
            // 
            this.GridBocFilter.BackColor = System.Drawing.Color.Transparent;
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
            this.GridBocFilter.Location = new System.Drawing.Point(14, 279);
            this.GridBocFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridBocFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridBocFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridBocFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridBocFilter.Name = "GridBocFilter";
            this.GridBocFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridBocFilter.SeparatorVisible = false;
            this.GridBocFilter.Size = new System.Drawing.Size(149, 30);
            this.GridBocFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridBocFilter.TabIndex = 171;
            this.GridBocFilter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridBocFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridBocFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridBocFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridBocFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridBocFilter.TextStyle = textStyle7;
            this.GridBocFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridBocFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridBocFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridBocFilter.Watermark.Text = "Watermark text";
            this.GridBocFilter.Watermark.Visible = false;
            this.GridBocFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl3_ItemSelected);
            this.GridBocFilter.SelectedValueChanged += new System.EventHandler(this.GridFilterControl3_ItemSelected);
            // 
            // lblFund
            // 
            this.lblFund.AutoSize = true;
            this.lblFund.BackColor = System.Drawing.Color.Transparent;
            this.lblFund.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFund.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblFund.Location = new System.Drawing.Point(14, 140);
            this.lblFund.Name = "lblFund";
            this.lblFund.Size = new System.Drawing.Size(107, 21);
            this.lblFund.TabIndex = 5;
            this.lblFund.Text = "Appropriation";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblYear.Location = new System.Drawing.Point(10, 50);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 21);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.LblPrc_Click);
            // 
            // GridFundFilter
            // 
            this.GridFundFilter.BackColor = System.Drawing.Color.Transparent;
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
            this.GridFundFilter.Location = new System.Drawing.Point(14, 176);
            this.GridFundFilter.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.GridFundFilter.MenuItemNormal = System.Drawing.Color.Black;
            this.GridFundFilter.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.GridFundFilter.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridFundFilter.Name = "GridFundFilter";
            this.GridFundFilter.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridFundFilter.SeparatorVisible = false;
            this.GridFundFilter.Size = new System.Drawing.Size(145, 30);
            this.GridFundFilter.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridFundFilter.TabIndex = 170;
            this.GridFundFilter.TextAlignment = System.Drawing.StringAlignment.Near;
            this.GridFundFilter.TextDisabledColor = System.Drawing.Color.Empty;
            this.GridFundFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GridFundFilter.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridFundFilter.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle8.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle8.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle8.Hover = System.Drawing.Color.Empty;
            textStyle8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridFundFilter.TextStyle = textStyle8;
            this.GridFundFilter.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridFundFilter.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridFundFilter.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.GridFundFilter.Watermark.Text = "Watermark text";
            this.GridFundFilter.Watermark.Visible = false;
            this.GridFundFilter.SelectedIndexChanged += new System.EventHandler(this.GridFilterControl2_ItemSelected);
            this.GridFundFilter.SelectedValueChanged += new System.EventHandler(this.GridFilterControl2_ItemSelected);
            // 
            // visualGroupBox3
            // 
            this.visualGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.visualGroupBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox3.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.visualGroupBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualGroupBox3.Border.HoverVisible = true;
            this.visualGroupBox3.Border.Rounding = 6;
            this.visualGroupBox3.Border.Thickness = 1;
            this.visualGroupBox3.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox3.Border.Visible = true;
            this.visualGroupBox3.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox3.Controls.Add(this.tableLayoutPanel1);
            this.visualGroupBox3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualGroupBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox3.Image = null;
            this.visualGroupBox3.Location = new System.Drawing.Point(27, 551);
            this.visualGroupBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox3.Name = "visualGroupBox3";
            this.visualGroupBox3.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox3.Separator = false;
            this.visualGroupBox3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox3.Size = new System.Drawing.Size(178, 263);
            this.visualGroupBox3.TabIndex = 174;
            this.visualGroupBox3.Text = "Statistics";
            this.visualGroupBox3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle10.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle10.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle10.Hover = System.Drawing.Color.Empty;
            textStyle10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox3.TextStyle = textStyle10;
            this.visualGroupBox3.TitleBoxHeight = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7907F));
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDev, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label40, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAve, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 174);
            this.tableLayoutPanel1.TabIndex = 174;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label31.Location = new System.Drawing.Point(1, 9);
            this.label31.Margin = new System.Windows.Forms.Padding(1);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 21);
            this.label31.TabIndex = 153;
            this.label31.Text = "Total: ";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDev
            // 
            this.lblDev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDev.AutoSize = true;
            this.lblDev.BackColor = System.Drawing.Color.Transparent;
            this.lblDev.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(64, 141);
            this.lblDev.Margin = new System.Windows.Forms.Padding(1);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(61, 21);
            this.lblDev.TabIndex = 162;
            this.lblDev.Text = "label38";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(64, 93);
            this.lblCount.Margin = new System.Windows.Forms.Padding(1);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 21);
            this.lblCount.TabIndex = 160;
            this.lblCount.Text = "label41";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(1, 141);
            this.label33.Margin = new System.Windows.Forms.Padding(1);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 21);
            this.label33.TabIndex = 161;
            this.label33.Text = "StDev";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label40.Location = new System.Drawing.Point(1, 93);
            this.label40.Margin = new System.Windows.Forms.Padding(1);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 21);
            this.label40.TabIndex = 159;
            this.label40.Text = "Count";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(64, 9);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 21);
            this.lblTotal.TabIndex = 154;
            this.lblTotal.Text = "label32";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label34.Location = new System.Drawing.Point(1, 48);
            this.label34.Margin = new System.Windows.Forms.Padding(1);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 21);
            this.label34.TabIndex = 155;
            this.label34.Text = "Ave";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAve
            // 
            this.lblAve.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAve.AutoSize = true;
            this.lblAve.BackColor = System.Drawing.Color.Transparent;
            this.lblAve.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAve.Location = new System.Drawing.Point(64, 48);
            this.lblAve.Margin = new System.Windows.Forms.Padding(1);
            this.lblAve.Name = "lblAve";
            this.lblAve.Size = new System.Drawing.Size(61, 21);
            this.lblAve.TabIndex = 156;
            this.lblAve.Text = "label37";
            this.lblAve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // visualGroupBox4
            // 
            this.visualGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.visualGroupBox4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox4.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.visualGroupBox4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualGroupBox4.Border.HoverVisible = true;
            this.visualGroupBox4.Border.Rounding = 6;
            this.visualGroupBox4.Border.Thickness = 1;
            this.visualGroupBox4.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox4.Border.Visible = true;
            this.visualGroupBox4.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox4.Controls.Add(this.metroPanel1);
            this.visualGroupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.visualGroupBox4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox4.Image = null;
            this.visualGroupBox4.Location = new System.Drawing.Point(221, 114);
            this.visualGroupBox4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox4.Name = "visualGroupBox4";
            this.visualGroupBox4.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox4.Separator = false;
            this.visualGroupBox4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox4.Size = new System.Drawing.Size(937, 406);
            this.visualGroupBox4.TabIndex = 175;
            this.visualGroupBox4.Text = "Database";
            this.visualGroupBox4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle11.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle11.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle11.Hover = System.Drawing.Color.Empty;
            textStyle11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox4.TextStyle = textStyle11;
            this.visualGroupBox4.TitleBoxHeight = 25;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.Grid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(887, 304);
            this.metroPanel1.TabIndex = 173;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.Grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(887, 304);
            this.Grid.TabIndex = 2;
            this.Grid.SelectionChanged += new System.EventHandler(this.UpdateAccountChart);
            // 
            // visualGroupBox2
            // 
            this.visualGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.visualGroupBox2.BackColorState.Disabled = System.Drawing.Color.Black;
            this.visualGroupBox2.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.visualGroupBox2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualGroupBox2.Border.HoverVisible = true;
            this.visualGroupBox2.Border.Rounding = 6;
            this.visualGroupBox2.Border.Thickness = 1;
            this.visualGroupBox2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox2.Border.Visible = true;
            this.visualGroupBox2.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox2.Controls.Add(this.tableLayoutPanel2);
            this.visualGroupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.visualGroupBox2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox2.Image = null;
            this.visualGroupBox2.Location = new System.Drawing.Point(221, 551);
            this.visualGroupBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox2.Name = "visualGroupBox2";
            this.visualGroupBox2.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox2.Separator = false;
            this.visualGroupBox2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualGroupBox2.Size = new System.Drawing.Size(937, 245);
            this.visualGroupBox2.TabIndex = 173;
            this.visualGroupBox2.Text = "Navigation";
            this.visualGroupBox2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle12.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle12.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle12.Hover = System.Drawing.Color.Empty;
            textStyle12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox2.TextStyle = textStyle12;
            this.visualGroupBox2.TitleBoxHeight = 25;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GridRefreshButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DatabaseSearchButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.CopyButton, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 92);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(887, 67);
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
            this.button6.Size = new System.Drawing.Size(91, 57);
            this.button6.TabIndex = 162;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetToolTip1.SetToolTip(this.button6, "Previous Account");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PreviousButton_OnClick);
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
            this.button7.Location = new System.Drawing.Point(103, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 57);
            this.button7.TabIndex = 163;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.button7, "Next Account");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NextButton_OnClick);
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
            this.GridRefreshButton.Location = new System.Drawing.Point(189, 5);
            this.GridRefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridRefreshButton.Name = "GridRefreshButton";
            this.GridRefreshButton.Size = new System.Drawing.Size(119, 57);
            this.GridRefreshButton.TabIndex = 164;
            this.GridRefreshButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.GridRefreshButton, "Refresh Data");
            this.GridRefreshButton.UseVisualStyleBackColor = false;
            this.GridRefreshButton.Click += new System.EventHandler(this.GridRefreshButton_OnClick);
            // 
            // DatabaseSearchButton
            // 
            this.DatabaseSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatabaseSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.DatabaseSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.DatabaseSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseSearchButton.Image")));
            this.DatabaseSearchButton.Location = new System.Drawing.Point(709, 5);
            this.DatabaseSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatabaseSearchButton.Name = "DatabaseSearchButton";
            this.DatabaseSearchButton.Size = new System.Drawing.Size(174, 57);
            this.DatabaseSearchButton.TabIndex = 167;
            this.DatabaseSearchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.DatabaseSearchButton, "Search Database");
            this.DatabaseSearchButton.UseVisualStyleBackColor = false;
            this.DatabaseSearchButton.Click += new System.EventHandler(this.DatabaseSearchButton_OnClick);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(316, 5);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 57);
            this.EditButton.TabIndex = 165;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.EditButton, "Edit Account");
            this.EditButton.UseCompatibleTextRendering = true;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_OnClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(447, 5);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 57);
            this.AddButton.TabIndex = 166;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.AddButton, "Add  Account");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_OnClick);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.Location = new System.Drawing.Point(574, 5);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(127, 57);
            this.CopyButton.TabIndex = 168;
            this.CopyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSetToolTip1.SetToolTip(this.CopyButton, "Transfer Funds");
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.ReprogramButton_OnClick);
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
            this.visualGroupBox1.Controls.Add(this.tableLayoutPanel3);
            this.visualGroupBox1.Controls.Add(this.panel1);
            this.visualGroupBox1.Controls.Add(this.label39);
            this.visualGroupBox1.Controls.Add(this.lblVar);
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(1215, 56);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = false;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.Transparent;
            this.visualGroupBox1.Size = new System.Drawing.Size(570, 844);
            this.visualGroupBox1.TabIndex = 161;
            this.visualGroupBox1.Text = "Allocation";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle43.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle43.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle43.Hover = System.Drawing.Color.Empty;
            textStyle43.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle43;
            this.visualGroupBox1.TitleBoxHeight = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.9854F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0146F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(65, 648);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(473, 62);
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
            this.button4.Size = new System.Drawing.Size(89, 56);
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
            this.button5.Location = new System.Drawing.Point(98, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 56);
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
            this.button3.Location = new System.Drawing.Point(328, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 56);
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
            this.button1.Location = new System.Drawing.Point(210, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 56);
            this.button1.TabIndex = 157;
            this.metroSetToolTip1.SetToolTip(this.button1, "Upload Changes ");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AccountTabControl);
            this.panel1.Location = new System.Drawing.Point(18, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 523);
            this.panel1.TabIndex = 1;
            // 
            // AccountTabControl
            // 
            this.AccountTabControl.ActiveTabColor = System.Drawing.Color.Black;
            this.AccountTabControl.ActiveTabForeColor = System.Drawing.SystemColors.Highlight;
            this.AccountTabControl.AdjustTopGap = 3;
            this.AccountTabControl.BackColor = System.Drawing.Color.Black;
            this.AccountTabControl.BeforeTouchSize = new System.Drawing.Size(528, 491);
            this.AccountTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountTabControl.BorderWidth = 0;
            this.AccountTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.AccountTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.Controls.Add(this.GraphTab);
            this.AccountTabControl.Controls.Add(this.EditTab);
            this.AccountTabControl.Controls.Add(this.AddTab);
            this.AccountTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountTabControl.FocusOnTabClick = false;
            this.AccountTabControl.ImageOffset = 1;
            this.AccountTabControl.InactiveTabColor = System.Drawing.Color.Black;
            this.AccountTabControl.InActiveTabForeColor = System.Drawing.Color.Black;
            this.AccountTabControl.ItemSize = new System.Drawing.Size(150, 30);
            this.AccountTabControl.LevelTextAndImage = true;
            this.AccountTabControl.Location = new System.Drawing.Point(12, 18);
            this.AccountTabControl.Name = "AccountTabControl";
            this.AccountTabControl.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.AccountTabControl.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.AccountTabControl.Padding = new System.Drawing.Point(15, 3);
            this.AccountTabControl.SeparatorColor = System.Drawing.Color.Black;
            this.AccountTabControl.ShowSeparator = false;
            this.AccountTabControl.Size = new System.Drawing.Size(528, 491);
            this.AccountTabControl.TabGap = 5;
            this.AccountTabControl.TabIndex = 150;
            this.AccountTabControl.TabPanelBackColor = System.Drawing.Color.Black;
            this.AccountTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.AccountTabControl.VSLikeScrollButton = true;
            // 
            // GraphTab
            // 
            this.GraphTab.Controls.Add(this.AccountChart);
            this.GraphTab.Image = null;
            this.GraphTab.ImageSize = new System.Drawing.Size(20, 20);
            this.GraphTab.Location = new System.Drawing.Point(0, -1);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.ShowCloseButton = true;
            this.GraphTab.Size = new System.Drawing.Size(528, 492);
            this.GraphTab.TabBackColor = System.Drawing.Color.Black;
            this.GraphTab.TabIndex = 2;
            this.GraphTab.Text = "Account Graph";
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
            this.AccountChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 0, 0, 0);
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
            this.AccountChart.PrimaryXAxis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountChart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.AccountChart.PrimaryXAxis.Margin = true;
            this.AccountChart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.AccountChart.PrimaryXAxis.TitleColor = System.Drawing.Color.White;
            this.AccountChart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.AccountChart.PrimaryXAxis.TitleSpacing = 2F;
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
            this.AccountChart.Series.Add(chartSeries5);
            this.AccountChart.Series.Add(chartSeries6);
            this.AccountChart.Series3D = true;
            this.AccountChart.SeriesHighlight = true;
            this.AccountChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver);
            this.AccountChart.Size = new System.Drawing.Size(528, 492);
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
            this.AccountChart.ToolBar.Items.Add(chartToolBarSaveItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarCopyItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarPrintItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarPaletteItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarTypeItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarSeries3DItem3);
            this.AccountChart.ToolBar.Items.Add(chartToolBarShowLegendItem3);
            this.AccountChart.Click += new System.EventHandler(this.AccountChart_Click);
            // 
            // EditTab
            // 
            this.EditTab.BackColor = System.Drawing.Color.Transparent;
            this.EditTab.Controls.Add(this.visualLabel11);
            this.EditTab.Controls.Add(this.UpdateOrg);
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
            this.EditTab.Controls.Add(this.CalculatorButton);
            this.EditTab.Controls.Add(this.UpdateBudgetLevel);
            this.EditTab.Controls.Add(this.Updateid);
            this.EditTab.Controls.Add(this.metroSetTextBox1);
            this.EditTab.Controls.Add(this.Amount);
            this.EditTab.Controls.Add(this.UpdateCode);
            this.EditTab.Controls.Add(this.UpdateBOC);
            this.EditTab.Controls.Add(this.UpdateRC);
            this.EditTab.Controls.Add(this.UpdateFund);
            this.EditTab.Controls.Add(this.UpdateBFY);
            this.EditTab.Controls.Add(this.UpdateAH);
            this.EditTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTab.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.EditTab.Image = null;
            this.EditTab.ImageSize = new System.Drawing.Size(20, 20);
            this.EditTab.Location = new System.Drawing.Point(0, -1);
            this.EditTab.Name = "EditTab";
            this.EditTab.ShowCloseButton = true;
            this.EditTab.Size = new System.Drawing.Size(528, 492);
            this.EditTab.TabBackColor = System.Drawing.Color.Transparent;
            this.EditTab.TabForeColor = System.Drawing.Color.LightSkyBlue;
            this.EditTab.TabIndex = 4;
            this.EditTab.Text = "Edit Account";
            this.EditTab.ThemesEnabled = false;
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
            textStyle14.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle14.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle14.Hover = System.Drawing.Color.Empty;
            textStyle14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel11.TextStyle = textStyle14;
            // 
            // UpdateOrg
            // 
            this.UpdateOrg.AutoCompleteCustomSource = null;
            this.UpdateOrg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateOrg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateOrg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateOrg.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateOrg.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateOrg.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOrg.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateOrg.Image = null;
            this.UpdateOrg.Lines = null;
            this.UpdateOrg.Location = new System.Drawing.Point(245, 160);
            this.UpdateOrg.MaxLength = 32767;
            this.UpdateOrg.Multiline = false;
            this.UpdateOrg.Name = "UpdateOrg";
            this.UpdateOrg.ReadOnly = false;
            this.UpdateOrg.Size = new System.Drawing.Size(105, 40);
            this.UpdateOrg.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateOrg.StyleManager = null;
            this.UpdateOrg.TabIndex = 174;
            this.UpdateOrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateOrg.ThemeAuthor = "Narwin";
            this.UpdateOrg.ThemeName = "MetroDark";
            this.UpdateOrg.UseSystemPasswordChar = false;
            this.UpdateOrg.WatermarkText = "";
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
            textStyle15.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle15.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle15.Hover = System.Drawing.Color.Empty;
            textStyle15.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel10.TextStyle = textStyle15;
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
            textStyle16.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle16.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle16.Hover = System.Drawing.Color.Empty;
            textStyle16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel9.TextStyle = textStyle16;
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
            textStyle17.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle17.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle17.Hover = System.Drawing.Color.Empty;
            textStyle17.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel8.TextStyle = textStyle17;
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
            textStyle18.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle18.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle18.Hover = System.Drawing.Color.Empty;
            textStyle18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel7.TextStyle = textStyle18;
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
            this.visualLabel6.Size = new System.Drawing.Size(115, 23);
            this.visualLabel6.TabIndex = 169;
            this.visualLabel6.Text = "RC";
            this.visualLabel6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel6.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle19.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle19.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle19.Hover = System.Drawing.Color.Empty;
            textStyle19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel6.TextStyle = textStyle19;
            // 
            // visualLabel5
            // 
            this.visualLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel5.Location = new System.Drawing.Point(136, 122);
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
            textStyle20.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle20.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle20.Hover = System.Drawing.Color.Empty;
            textStyle20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel5.TextStyle = textStyle20;
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
            textStyle21.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle21.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle21.Hover = System.Drawing.Color.Empty;
            textStyle21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel4.TextStyle = textStyle21;
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
            textStyle22.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle22.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle22.Hover = System.Drawing.Color.Empty;
            textStyle22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel3.TextStyle = textStyle22;
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
            textStyle23.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle23.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle23.Hover = System.Drawing.Color.Empty;
            textStyle23.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel2.TextStyle = textStyle23;
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
            textStyle24.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle24.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle24.Hover = System.Drawing.Color.Empty;
            textStyle24.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle24;
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
            this.CalculatorButton.Location = new System.Drawing.Point(222, 353);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(70, 78);
            this.CalculatorButton.TabIndex = 162;
            this.metroSetToolTip1.SetToolTip(this.CalculatorButton, "Budget Calculator");
            this.CalculatorButton.UseVisualStyleBackColor = false;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // UpdateBudgetLevel
            // 
            this.UpdateBudgetLevel.AutoCompleteCustomSource = null;
            this.UpdateBudgetLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateBudgetLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateBudgetLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateBudgetLevel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateBudgetLevel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBudgetLevel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBudgetLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBudgetLevel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateBudgetLevel.Image = null;
            this.UpdateBudgetLevel.Lines = null;
            this.UpdateBudgetLevel.Location = new System.Drawing.Point(200, 66);
            this.UpdateBudgetLevel.MaxLength = 32767;
            this.UpdateBudgetLevel.Multiline = false;
            this.UpdateBudgetLevel.Name = "UpdateBudgetLevel";
            this.UpdateBudgetLevel.ReadOnly = false;
            this.UpdateBudgetLevel.Size = new System.Drawing.Size(62, 40);
            this.UpdateBudgetLevel.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateBudgetLevel.StyleManager = null;
            this.UpdateBudgetLevel.TabIndex = 155;
            this.UpdateBudgetLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBudgetLevel.ThemeAuthor = "Narwin";
            this.UpdateBudgetLevel.ThemeName = "MetroDark";
            this.UpdateBudgetLevel.UseSystemPasswordChar = false;
            this.UpdateBudgetLevel.WatermarkText = "";
            // 
            // Updateid
            // 
            this.Updateid.AutoCompleteCustomSource = null;
            this.Updateid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Updateid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Updateid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Updateid.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Updateid.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Updateid.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Updateid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updateid.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Updateid.Image = null;
            this.Updateid.Lines = null;
            this.Updateid.Location = new System.Drawing.Point(33, 66);
            this.Updateid.MaxLength = 32767;
            this.Updateid.Multiline = false;
            this.Updateid.Name = "Updateid";
            this.Updateid.ReadOnly = false;
            this.Updateid.Size = new System.Drawing.Size(62, 40);
            this.Updateid.Style = MetroSet_UI.Design.Style.Dark;
            this.Updateid.StyleManager = null;
            this.Updateid.TabIndex = 153;
            this.Updateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Updateid.ThemeAuthor = "Narwin";
            this.Updateid.ThemeName = "MetroDark";
            this.Updateid.UseSystemPasswordChar = false;
            this.Updateid.WatermarkText = "";
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
            // UpdateCode
            // 
            this.UpdateCode.AutoCompleteCustomSource = null;
            this.UpdateCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateCode.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateCode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateCode.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateCode.Image = null;
            this.UpdateCode.Lines = null;
            this.UpdateCode.Location = new System.Drawing.Point(127, 263);
            this.UpdateCode.MaxLength = 32767;
            this.UpdateCode.Multiline = false;
            this.UpdateCode.Name = "UpdateCode";
            this.UpdateCode.ReadOnly = false;
            this.UpdateCode.Size = new System.Drawing.Size(165, 40);
            this.UpdateCode.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateCode.StyleManager = null;
            this.UpdateCode.TabIndex = 135;
            this.UpdateCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateCode.ThemeAuthor = "Narwin";
            this.UpdateCode.ThemeName = "MetroDark";
            this.UpdateCode.UseSystemPasswordChar = false;
            this.UpdateCode.WatermarkText = "";
            // 
            // UpdateBOC
            // 
            this.UpdateBOC.AutoCompleteCustomSource = null;
            this.UpdateBOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateBOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateBOC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateBOC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateBOC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBOC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBOC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateBOC.Image = null;
            this.UpdateBOC.Lines = null;
            this.UpdateBOC.Location = new System.Drawing.Point(33, 263);
            this.UpdateBOC.MaxLength = 32767;
            this.UpdateBOC.Multiline = false;
            this.UpdateBOC.Name = "UpdateBOC";
            this.UpdateBOC.ReadOnly = false;
            this.UpdateBOC.Size = new System.Drawing.Size(62, 40);
            this.UpdateBOC.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateBOC.StyleManager = null;
            this.UpdateBOC.TabIndex = 134;
            this.UpdateBOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBOC.ThemeAuthor = "Narwin";
            this.UpdateBOC.ThemeName = "MetroDark";
            this.UpdateBOC.UseSystemPasswordChar = false;
            this.UpdateBOC.WatermarkText = "";
            // 
            // UpdateRC
            // 
            this.UpdateRC.AutoCompleteCustomSource = null;
            this.UpdateRC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateRC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateRC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateRC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateRC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateRC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateRC.Image = null;
            this.UpdateRC.Lines = null;
            this.UpdateRC.Location = new System.Drawing.Point(390, 160);
            this.UpdateRC.MaxLength = 32767;
            this.UpdateRC.Multiline = false;
            this.UpdateRC.Name = "UpdateRC";
            this.UpdateRC.ReadOnly = false;
            this.UpdateRC.Size = new System.Drawing.Size(62, 40);
            this.UpdateRC.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateRC.StyleManager = null;
            this.UpdateRC.TabIndex = 129;
            this.UpdateRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateRC.ThemeAuthor = "Narwin";
            this.UpdateRC.ThemeName = "MetroDark";
            this.UpdateRC.UseSystemPasswordChar = false;
            this.UpdateRC.WatermarkText = "";
            // 
            // UpdateFund
            // 
            this.UpdateFund.AutoCompleteCustomSource = null;
            this.UpdateFund.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateFund.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateFund.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateFund.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateFund.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateFund.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFund.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateFund.Image = null;
            this.UpdateFund.Lines = null;
            this.UpdateFund.Location = new System.Drawing.Point(29, 160);
            this.UpdateFund.MaxLength = 32767;
            this.UpdateFund.Multiline = false;
            this.UpdateFund.Name = "UpdateFund";
            this.UpdateFund.ReadOnly = false;
            this.UpdateFund.Size = new System.Drawing.Size(75, 40);
            this.UpdateFund.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateFund.StyleManager = null;
            this.UpdateFund.TabIndex = 128;
            this.UpdateFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateFund.ThemeAuthor = "Narwin";
            this.UpdateFund.ThemeName = "MetroDark";
            this.UpdateFund.UseSystemPasswordChar = false;
            this.UpdateFund.WatermarkText = "";
            // 
            // UpdateBFY
            // 
            this.UpdateBFY.AutoCompleteCustomSource = null;
            this.UpdateBFY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateBFY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateBFY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateBFY.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateBFY.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBFY.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateBFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBFY.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateBFY.Image = null;
            this.UpdateBFY.Lines = null;
            this.UpdateBFY.Location = new System.Drawing.Point(359, 66);
            this.UpdateBFY.MaxLength = 32767;
            this.UpdateBFY.Multiline = false;
            this.UpdateBFY.Name = "UpdateBFY";
            this.UpdateBFY.ReadOnly = false;
            this.UpdateBFY.Size = new System.Drawing.Size(93, 40);
            this.UpdateBFY.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateBFY.StyleManager = null;
            this.UpdateBFY.TabIndex = 125;
            this.UpdateBFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBFY.ThemeAuthor = "Narwin";
            this.UpdateBFY.ThemeName = "MetroDark";
            this.UpdateBFY.UseSystemPasswordChar = false;
            this.UpdateBFY.WatermarkText = "";
            // 
            // UpdateAH
            // 
            this.UpdateAH.AutoCompleteCustomSource = null;
            this.UpdateAH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpdateAH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpdateAH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.UpdateAH.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UpdateAH.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateAH.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UpdateAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAH.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.UpdateAH.Image = null;
            this.UpdateAH.Lines = null;
            this.UpdateAH.Location = new System.Drawing.Point(136, 160);
            this.UpdateAH.MaxLength = 32767;
            this.UpdateAH.Multiline = false;
            this.UpdateAH.Name = "UpdateAH";
            this.UpdateAH.ReadOnly = false;
            this.UpdateAH.Size = new System.Drawing.Size(74, 40);
            this.UpdateAH.Style = MetroSet_UI.Design.Style.Dark;
            this.UpdateAH.StyleManager = null;
            this.UpdateAH.TabIndex = 124;
            this.UpdateAH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateAH.ThemeAuthor = "Narwin";
            this.UpdateAH.ThemeName = "MetroDark";
            this.UpdateAH.UseSystemPasswordChar = false;
            this.UpdateAH.WatermarkText = "";
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.visualLabel20);
            this.AddTab.Controls.Add(this.visualLabel19);
            this.AddTab.Controls.Add(this.visualLabel18);
            this.AddTab.Controls.Add(this.visualLabel17);
            this.AddTab.Controls.Add(this.visualLabel16);
            this.AddTab.Controls.Add(this.visualLabel15);
            this.AddTab.Controls.Add(this.visualLabel14);
            this.AddTab.Controls.Add(this.visualLabel13);
            this.AddTab.Controls.Add(this.visualLabel12);
            this.AddTab.Controls.Add(this.AddCode);
            this.AddTab.Controls.Add(this.AddBoc);
            this.AddTab.Controls.Add(this.AddSub);
            this.AddTab.Controls.Add(this.AddRc);
            this.AddTab.Controls.Add(this.AddOrg);
            this.AddTab.Controls.Add(this.AddAh);
            this.AddTab.Controls.Add(this.AddFund);
            this.AddTab.Controls.Add(this.AddYear);
            this.AddTab.Controls.Add(this.AddLevel);
            this.AddTab.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddTab.Image = null;
            this.AddTab.ImageSize = new System.Drawing.Size(16, 16);
            this.AddTab.Location = new System.Drawing.Point(0, -1);
            this.AddTab.Name = "AddTab";
            this.AddTab.ShowCloseButton = true;
            this.AddTab.Size = new System.Drawing.Size(528, 492);
            this.AddTab.TabIndex = 5;
            this.AddTab.Text = "Add Account";
            this.AddTab.ThemesEnabled = false;
            // 
            // visualLabel20
            // 
            this.visualLabel20.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel20.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel20.Location = new System.Drawing.Point(203, 297);
            this.visualLabel20.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel20.Name = "visualLabel20";
            this.visualLabel20.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel20.Outline = false;
            this.visualLabel20.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel20.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel20.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel20.ReflectionSpacing = 0;
            this.visualLabel20.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel20.ShadowDirection = 315;
            this.visualLabel20.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel20.ShadowOpacity = 100;
            this.visualLabel20.Size = new System.Drawing.Size(115, 32);
            this.visualLabel20.TabIndex = 188;
            this.visualLabel20.Text = "Object Class";
            this.visualLabel20.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel20.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle25.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle25.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle25.Hover = System.Drawing.Color.Empty;
            textStyle25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel20.TextStyle = textStyle25;
            // 
            // visualLabel19
            // 
            this.visualLabel19.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel19.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel19.Location = new System.Drawing.Point(21, 297);
            this.visualLabel19.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel19.Name = "visualLabel19";
            this.visualLabel19.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel19.Outline = false;
            this.visualLabel19.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel19.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel19.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel19.ReflectionSpacing = 0;
            this.visualLabel19.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel19.ShadowDirection = 315;
            this.visualLabel19.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel19.ShadowOpacity = 100;
            this.visualLabel19.Size = new System.Drawing.Size(115, 32);
            this.visualLabel19.TabIndex = 187;
            this.visualLabel19.Text = "Activity Code";
            this.visualLabel19.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel19.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle26.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle26.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle26.Hover = System.Drawing.Color.Empty;
            textStyle26.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel19.TextStyle = textStyle26;
            // 
            // visualLabel18
            // 
            this.visualLabel18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel18.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel18.Location = new System.Drawing.Point(369, 165);
            this.visualLabel18.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel18.Name = "visualLabel18";
            this.visualLabel18.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel18.Outline = false;
            this.visualLabel18.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel18.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel18.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel18.ReflectionSpacing = 0;
            this.visualLabel18.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel18.ShadowDirection = 315;
            this.visualLabel18.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel18.ShadowOpacity = 100;
            this.visualLabel18.Size = new System.Drawing.Size(115, 32);
            this.visualLabel18.TabIndex = 186;
            this.visualLabel18.Text = "RC Code";
            this.visualLabel18.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel18.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle27.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle27.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle27.Hover = System.Drawing.Color.Empty;
            textStyle27.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel18.TextStyle = textStyle27;
            // 
            // visualLabel17
            // 
            this.visualLabel17.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel17.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel17.Location = new System.Drawing.Point(203, 165);
            this.visualLabel17.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel17.Name = "visualLabel17";
            this.visualLabel17.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel17.Outline = false;
            this.visualLabel17.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel17.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel17.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel17.ReflectionSpacing = 0;
            this.visualLabel17.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel17.ShadowDirection = 315;
            this.visualLabel17.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel17.ShadowOpacity = 100;
            this.visualLabel17.Size = new System.Drawing.Size(115, 32);
            this.visualLabel17.TabIndex = 185;
            this.visualLabel17.Text = "Org Code";
            this.visualLabel17.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel17.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle28.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle28.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle28.Hover = System.Drawing.Color.Empty;
            textStyle28.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel17.TextStyle = textStyle28;
            // 
            // visualLabel16
            // 
            this.visualLabel16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel16.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel16.Location = new System.Drawing.Point(14, 165);
            this.visualLabel16.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel16.Name = "visualLabel16";
            this.visualLabel16.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel16.Outline = false;
            this.visualLabel16.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel16.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel16.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel16.ReflectionSpacing = 0;
            this.visualLabel16.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel16.ShadowDirection = 315;
            this.visualLabel16.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel16.ShadowOpacity = 100;
            this.visualLabel16.Size = new System.Drawing.Size(143, 32);
            this.visualLabel16.TabIndex = 184;
            this.visualLabel16.Text = "Allowance Holder";
            this.visualLabel16.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel16.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle29.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle29.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle29.Hover = System.Drawing.Color.Empty;
            textStyle29.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel16.TextStyle = textStyle29;
            // 
            // visualLabel15
            // 
            this.visualLabel15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel15.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel15.Location = new System.Drawing.Point(369, 16);
            this.visualLabel15.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel15.Name = "visualLabel15";
            this.visualLabel15.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel15.Outline = false;
            this.visualLabel15.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel15.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel15.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel15.ReflectionSpacing = 0;
            this.visualLabel15.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel15.ShadowDirection = 315;
            this.visualLabel15.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel15.ShadowOpacity = 100;
            this.visualLabel15.Size = new System.Drawing.Size(115, 32);
            this.visualLabel15.TabIndex = 183;
            this.visualLabel15.Text = "Fund";
            this.visualLabel15.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel15.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle30.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle30.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle30.Hover = System.Drawing.Color.Empty;
            textStyle30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel15.TextStyle = textStyle30;
            // 
            // visualLabel14
            // 
            this.visualLabel14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel14.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel14.Location = new System.Drawing.Point(200, 16);
            this.visualLabel14.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel14.Name = "visualLabel14";
            this.visualLabel14.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel14.Outline = false;
            this.visualLabel14.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel14.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel14.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel14.ReflectionSpacing = 0;
            this.visualLabel14.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel14.ShadowDirection = 315;
            this.visualLabel14.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel14.ShadowOpacity = 100;
            this.visualLabel14.Size = new System.Drawing.Size(115, 32);
            this.visualLabel14.TabIndex = 182;
            this.visualLabel14.Text = "Fiscal Year";
            this.visualLabel14.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel14.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle31.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle31.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle31.Hover = System.Drawing.Color.Empty;
            textStyle31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel14.TextStyle = textStyle31;
            // 
            // visualLabel13
            // 
            this.visualLabel13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel13.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel13.Location = new System.Drawing.Point(14, 16);
            this.visualLabel13.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel13.Name = "visualLabel13";
            this.visualLabel13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel13.Outline = false;
            this.visualLabel13.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel13.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel13.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel13.ReflectionSpacing = 0;
            this.visualLabel13.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel13.ShadowDirection = 315;
            this.visualLabel13.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel13.ShadowOpacity = 100;
            this.visualLabel13.Size = new System.Drawing.Size(115, 32);
            this.visualLabel13.TabIndex = 181;
            this.visualLabel13.Text = "Budget Level";
            this.visualLabel13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel13.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle32.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle32.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle32.Hover = System.Drawing.Color.Empty;
            textStyle32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel13.TextStyle = textStyle32;
            // 
            // visualLabel12
            // 
            this.visualLabel12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel12.Location = new System.Drawing.Point(369, 297);
            this.visualLabel12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel12.Name = "visualLabel12";
            this.visualLabel12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel12.Outline = false;
            this.visualLabel12.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel12.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel12.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel12.ReflectionSpacing = 0;
            this.visualLabel12.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel12.ShadowDirection = 315;
            this.visualLabel12.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel12.ShadowOpacity = 100;
            this.visualLabel12.Size = new System.Drawing.Size(115, 32);
            this.visualLabel12.TabIndex = 180;
            this.visualLabel12.Text = "PRC Code";
            this.visualLabel12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel12.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle33.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle33.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle33.Hover = System.Drawing.Color.Empty;
            textStyle33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel12.TextStyle = textStyle33;
            // 
            // AddCode
            // 
            this.AddCode.BackColor = System.Drawing.Color.Transparent;
            this.AddCode.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCode.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddCode.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCode.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddCode.Border.HoverVisible = true;
            this.AddCode.Border.Rounding = 6;
            this.AddCode.Border.Thickness = 1;
            this.AddCode.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddCode.Border.Visible = true;
            this.AddCode.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddCode.ButtonImage = null;
            this.AddCode.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddCode.ButtonWidth = 30;
            this.AddCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddCode.DropDownHeight = 100;
            this.AddCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddCode.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddCode.FormattingEnabled = true;
            this.AddCode.ImageList = null;
            this.AddCode.ImageVisible = false;
            this.AddCode.Index = 0;
            this.AddCode.IntegralHeight = false;
            this.AddCode.ItemHeight = 30;
            this.AddCode.ItemImageVisible = true;
            this.AddCode.Location = new System.Drawing.Point(356, 335);
            this.AddCode.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddCode.MenuItemNormal = System.Drawing.Color.Black;
            this.AddCode.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddCode.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddCode.Name = "AddCode";
            this.AddCode.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCode.SeparatorVisible = false;
            this.AddCode.Size = new System.Drawing.Size(160, 36);
            this.AddCode.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddCode.TabIndex = 179;
            this.AddCode.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddCode.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCode.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddCode.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle34.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle34.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle34.Hover = System.Drawing.Color.Empty;
            textStyle34.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddCode.TextStyle = textStyle34;
            this.AddCode.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddCode.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddCode.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddCode.Watermark.Text = "Watermark text";
            this.AddCode.Watermark.Visible = false;
            // 
            // AddBoc
            // 
            this.AddBoc.BackColor = System.Drawing.Color.Transparent;
            this.AddBoc.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBoc.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddBoc.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBoc.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddBoc.Border.HoverVisible = true;
            this.AddBoc.Border.Rounding = 6;
            this.AddBoc.Border.Thickness = 1;
            this.AddBoc.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddBoc.Border.Visible = true;
            this.AddBoc.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddBoc.ButtonImage = null;
            this.AddBoc.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddBoc.ButtonWidth = 30;
            this.AddBoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddBoc.DropDownHeight = 100;
            this.AddBoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddBoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBoc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddBoc.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddBoc.FormattingEnabled = true;
            this.AddBoc.ImageList = null;
            this.AddBoc.ImageVisible = false;
            this.AddBoc.Index = 0;
            this.AddBoc.IntegralHeight = false;
            this.AddBoc.ItemHeight = 30;
            this.AddBoc.ItemImageVisible = true;
            this.AddBoc.Location = new System.Drawing.Point(187, 335);
            this.AddBoc.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddBoc.MenuItemNormal = System.Drawing.Color.Black;
            this.AddBoc.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddBoc.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddBoc.Name = "AddBoc";
            this.AddBoc.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBoc.SeparatorVisible = false;
            this.AddBoc.Size = new System.Drawing.Size(148, 36);
            this.AddBoc.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddBoc.TabIndex = 178;
            this.AddBoc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddBoc.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddBoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBoc.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddBoc.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle35.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle35.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle35.Hover = System.Drawing.Color.Empty;
            textStyle35.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddBoc.TextStyle = textStyle35;
            this.AddBoc.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddBoc.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddBoc.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddBoc.Watermark.Text = "Watermark text";
            this.AddBoc.Watermark.Visible = false;
            // 
            // AddSub
            // 
            this.AddSub.BackColor = System.Drawing.Color.Transparent;
            this.AddSub.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSub.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddSub.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSub.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddSub.Border.HoverVisible = true;
            this.AddSub.Border.Rounding = 6;
            this.AddSub.Border.Thickness = 1;
            this.AddSub.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddSub.Border.Visible = true;
            this.AddSub.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddSub.ButtonImage = null;
            this.AddSub.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddSub.ButtonWidth = 30;
            this.AddSub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddSub.DropDownHeight = 100;
            this.AddSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddSub.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddSub.FormattingEnabled = true;
            this.AddSub.ImageList = null;
            this.AddSub.ImageVisible = false;
            this.AddSub.Index = 0;
            this.AddSub.IntegralHeight = false;
            this.AddSub.ItemHeight = 30;
            this.AddSub.ItemImageVisible = true;
            this.AddSub.Location = new System.Drawing.Point(14, 335);
            this.AddSub.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddSub.MenuItemNormal = System.Drawing.Color.Black;
            this.AddSub.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddSub.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddSub.Name = "AddSub";
            this.AddSub.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSub.SeparatorVisible = false;
            this.AddSub.Size = new System.Drawing.Size(150, 36);
            this.AddSub.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddSub.TabIndex = 177;
            this.AddSub.TextAlignment = System.Drawing.StringAlignment.Near;
            this.AddSub.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddSub.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddSub.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle36.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle36.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle36.Hover = System.Drawing.Color.Empty;
            textStyle36.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddSub.TextStyle = textStyle36;
            this.AddSub.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddSub.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddSub.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddSub.Watermark.Text = "Watermark text";
            this.AddSub.Watermark.Visible = false;
            // 
            // AddRc
            // 
            this.AddRc.BackColor = System.Drawing.Color.Transparent;
            this.AddRc.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRc.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddRc.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRc.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddRc.Border.HoverVisible = true;
            this.AddRc.Border.Rounding = 6;
            this.AddRc.Border.Thickness = 1;
            this.AddRc.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddRc.Border.Visible = true;
            this.AddRc.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddRc.ButtonImage = null;
            this.AddRc.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddRc.ButtonWidth = 30;
            this.AddRc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddRc.DropDownHeight = 100;
            this.AddRc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddRc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddRc.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddRc.FormattingEnabled = true;
            this.AddRc.ImageList = null;
            this.AddRc.ImageVisible = false;
            this.AddRc.Index = 0;
            this.AddRc.IntegralHeight = false;
            this.AddRc.ItemHeight = 30;
            this.AddRc.ItemImageVisible = true;
            this.AddRc.Location = new System.Drawing.Point(356, 203);
            this.AddRc.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddRc.MenuItemNormal = System.Drawing.Color.Black;
            this.AddRc.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddRc.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddRc.Name = "AddRc";
            this.AddRc.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRc.SeparatorVisible = false;
            this.AddRc.Size = new System.Drawing.Size(160, 36);
            this.AddRc.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddRc.TabIndex = 176;
            this.AddRc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddRc.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddRc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRc.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddRc.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle37.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle37.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle37.Hover = System.Drawing.Color.Empty;
            textStyle37.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddRc.TextStyle = textStyle37;
            this.AddRc.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddRc.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddRc.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddRc.Watermark.Text = "Watermark text";
            this.AddRc.Watermark.Visible = false;
            // 
            // AddOrg
            // 
            this.AddOrg.BackColor = System.Drawing.Color.Transparent;
            this.AddOrg.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddOrg.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddOrg.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddOrg.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddOrg.Border.HoverVisible = true;
            this.AddOrg.Border.Rounding = 6;
            this.AddOrg.Border.Thickness = 1;
            this.AddOrg.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddOrg.Border.Visible = true;
            this.AddOrg.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddOrg.ButtonImage = null;
            this.AddOrg.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddOrg.ButtonWidth = 30;
            this.AddOrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddOrg.DropDownHeight = 100;
            this.AddOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrg.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddOrg.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddOrg.FormattingEnabled = true;
            this.AddOrg.ImageList = null;
            this.AddOrg.ImageVisible = false;
            this.AddOrg.Index = 0;
            this.AddOrg.IntegralHeight = false;
            this.AddOrg.ItemHeight = 30;
            this.AddOrg.ItemImageVisible = true;
            this.AddOrg.Location = new System.Drawing.Point(187, 203);
            this.AddOrg.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddOrg.MenuItemNormal = System.Drawing.Color.Black;
            this.AddOrg.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddOrg.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddOrg.Name = "AddOrg";
            this.AddOrg.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddOrg.SeparatorVisible = false;
            this.AddOrg.Size = new System.Drawing.Size(148, 36);
            this.AddOrg.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddOrg.TabIndex = 175;
            this.AddOrg.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddOrg.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddOrg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrg.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddOrg.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle38.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle38.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle38.Hover = System.Drawing.Color.Empty;
            textStyle38.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddOrg.TextStyle = textStyle38;
            this.AddOrg.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddOrg.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddOrg.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddOrg.Watermark.Text = "Watermark text";
            this.AddOrg.Watermark.Visible = false;
            // 
            // AddAh
            // 
            this.AddAh.BackColor = System.Drawing.Color.Transparent;
            this.AddAh.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddAh.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddAh.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddAh.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddAh.Border.HoverVisible = true;
            this.AddAh.Border.Rounding = 6;
            this.AddAh.Border.Thickness = 1;
            this.AddAh.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddAh.Border.Visible = true;
            this.AddAh.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddAh.ButtonImage = null;
            this.AddAh.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddAh.ButtonWidth = 30;
            this.AddAh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddAh.DropDownHeight = 100;
            this.AddAh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddAh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAh.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddAh.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddAh.FormattingEnabled = true;
            this.AddAh.ImageList = null;
            this.AddAh.ImageVisible = false;
            this.AddAh.Index = 0;
            this.AddAh.IntegralHeight = false;
            this.AddAh.ItemHeight = 30;
            this.AddAh.ItemImageVisible = true;
            this.AddAh.Location = new System.Drawing.Point(14, 203);
            this.AddAh.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddAh.MenuItemNormal = System.Drawing.Color.Black;
            this.AddAh.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddAh.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddAh.Name = "AddAh";
            this.AddAh.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddAh.SeparatorVisible = false;
            this.AddAh.Size = new System.Drawing.Size(150, 36);
            this.AddAh.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddAh.TabIndex = 174;
            this.AddAh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddAh.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddAh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddAh.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddAh.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle39.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle39.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle39.Hover = System.Drawing.Color.Empty;
            textStyle39.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddAh.TextStyle = textStyle39;
            this.AddAh.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddAh.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddAh.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddAh.Watermark.Text = "Watermark text";
            this.AddAh.Watermark.Visible = false;
            // 
            // AddFund
            // 
            this.AddFund.BackColor = System.Drawing.Color.Transparent;
            this.AddFund.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFund.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddFund.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFund.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddFund.Border.HoverVisible = true;
            this.AddFund.Border.Rounding = 6;
            this.AddFund.Border.Thickness = 1;
            this.AddFund.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddFund.Border.Visible = true;
            this.AddFund.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddFund.ButtonImage = null;
            this.AddFund.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddFund.ButtonWidth = 30;
            this.AddFund.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddFund.DropDownHeight = 100;
            this.AddFund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFund.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddFund.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddFund.FormattingEnabled = true;
            this.AddFund.ImageList = null;
            this.AddFund.ImageVisible = false;
            this.AddFund.Index = 0;
            this.AddFund.IntegralHeight = false;
            this.AddFund.ItemHeight = 30;
            this.AddFund.ItemImageVisible = true;
            this.AddFund.Location = new System.Drawing.Point(356, 58);
            this.AddFund.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddFund.MenuItemNormal = System.Drawing.Color.Black;
            this.AddFund.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddFund.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddFund.Name = "AddFund";
            this.AddFund.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFund.SeparatorVisible = false;
            this.AddFund.Size = new System.Drawing.Size(160, 36);
            this.AddFund.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddFund.TabIndex = 173;
            this.AddFund.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddFund.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddFund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddFund.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddFund.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle40.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle40.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle40.Hover = System.Drawing.Color.Empty;
            textStyle40.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddFund.TextStyle = textStyle40;
            this.AddFund.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddFund.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddFund.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddFund.Watermark.Text = "Watermark text";
            this.AddFund.Watermark.Visible = false;
            // 
            // AddYear
            // 
            this.AddYear.BackColor = System.Drawing.Color.Transparent;
            this.AddYear.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddYear.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddYear.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddYear.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddYear.Border.HoverVisible = true;
            this.AddYear.Border.Rounding = 6;
            this.AddYear.Border.Thickness = 1;
            this.AddYear.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddYear.Border.Visible = true;
            this.AddYear.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddYear.ButtonImage = null;
            this.AddYear.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddYear.ButtonWidth = 30;
            this.AddYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddYear.DropDownHeight = 100;
            this.AddYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddYear.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddYear.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddYear.FormattingEnabled = true;
            this.AddYear.ImageList = null;
            this.AddYear.ImageVisible = false;
            this.AddYear.Index = 0;
            this.AddYear.IntegralHeight = false;
            this.AddYear.ItemHeight = 30;
            this.AddYear.ItemImageVisible = true;
            this.AddYear.Location = new System.Drawing.Point(187, 58);
            this.AddYear.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddYear.MenuItemNormal = System.Drawing.Color.Black;
            this.AddYear.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddYear.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddYear.Name = "AddYear";
            this.AddYear.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddYear.SeparatorVisible = false;
            this.AddYear.Size = new System.Drawing.Size(148, 36);
            this.AddYear.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddYear.TabIndex = 172;
            this.AddYear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddYear.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddYear.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddYear.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle41.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle41.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle41.Hover = System.Drawing.Color.Empty;
            textStyle41.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddYear.TextStyle = textStyle41;
            this.AddYear.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddYear.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddYear.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddYear.Watermark.Text = "Watermark text";
            this.AddYear.Watermark.Visible = false;
            // 
            // AddLevel
            // 
            this.AddLevel.BackColor = System.Drawing.Color.Transparent;
            this.AddLevel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddLevel.BackColorState.Enabled = System.Drawing.Color.Black;
            this.AddLevel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddLevel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AddLevel.Border.HoverVisible = true;
            this.AddLevel.Border.Rounding = 6;
            this.AddLevel.Border.Thickness = 1;
            this.AddLevel.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.AddLevel.Border.Visible = true;
            this.AddLevel.ButtonColor = System.Drawing.Color.SteelBlue;
            this.AddLevel.ButtonImage = null;
            this.AddLevel.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.AddLevel.ButtonWidth = 30;
            this.AddLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddLevel.DropDownHeight = 100;
            this.AddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLevel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddLevel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddLevel.FormattingEnabled = true;
            this.AddLevel.ImageList = null;
            this.AddLevel.ImageVisible = false;
            this.AddLevel.Index = 0;
            this.AddLevel.IntegralHeight = false;
            this.AddLevel.ItemHeight = 30;
            this.AddLevel.ItemImageVisible = true;
            this.AddLevel.Location = new System.Drawing.Point(14, 58);
            this.AddLevel.MenuItemHover = System.Drawing.Color.SteelBlue;
            this.AddLevel.MenuItemNormal = System.Drawing.Color.Black;
            this.AddLevel.MenuTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddLevel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddLevel.Name = "AddLevel";
            this.AddLevel.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddLevel.SeparatorVisible = false;
            this.AddLevel.Size = new System.Drawing.Size(150, 36);
            this.AddLevel.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.AddLevel.TabIndex = 171;
            this.AddLevel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AddLevel.TextDisabledColor = System.Drawing.Color.Empty;
            this.AddLevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddLevel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AddLevel.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textStyle42.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle42.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle42.Hover = System.Drawing.Color.Empty;
            textStyle42.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AddLevel.TextStyle = textStyle42;
            this.AddLevel.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddLevel.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddLevel.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.AddLevel.Watermark.Text = "Watermark text";
            this.AddLevel.Watermark.Visible = false;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(47, 792);
            this.label39.Margin = new System.Windows.Forms.Padding(1);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 21);
            this.label39.TabIndex = 163;
            this.label39.Text = "Var";
            // 
            // lblVar
            // 
            this.lblVar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVar.AutoSize = true;
            this.lblVar.BackColor = System.Drawing.Color.Transparent;
            this.lblVar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblVar.Location = new System.Drawing.Point(112, 792);
            this.lblVar.Margin = new System.Windows.Forms.Padding(1);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(64, 23);
            this.lblVar.TabIndex = 164;
            this.lblVar.Text = "label42";
            this.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grid222
            // 
            this.Grid222.AllowUserToResizeRows = false;
            this.Grid222.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid222.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid222.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid222.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid222.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid222.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid222.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid222.ColumnHeadersHeight = 25;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid222.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grid222.EnableHeadersVisualStyles = false;
            this.Grid222.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid222.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid222.Location = new System.Drawing.Point(1, 1);
            this.Grid222.MultiSelect = false;
            this.Grid222.Name = "Grid222";
            this.Grid222.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid222.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid222.RowHeadersWidth = 15;
            this.Grid222.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.Grid222.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid222.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Grid222.RowTemplate.Height = 28;
            this.Grid222.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid222.Size = new System.Drawing.Size(100, 100);
            this.Grid222.TabIndex = 170;
            this.Grid222.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Grid222.UseCustomBackColor = true;
            this.Grid222.UseCustomForeColor = true;
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
            // BindingSource
            // 
            this.BindingSource.CurrentChanged += new System.EventHandler(this.UpdateAccountChart);
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
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 65;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Top;
            this.ClientSize = new System.Drawing.Size(1788, 1003);
            this.Controls.Add(this.SummaryTabControl);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Right;
            this.MaximumSize = new System.Drawing.Size(1800, 1074);
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1769, 1074);
            this.Name = "SummaryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniTabControl1)).EndInit();
            this.MiniTabControl1.ResumeLayout(false);
            this.AllocationTab.ResumeLayout(false);
            this.BocExpander2.ResumeLayout(false);
            this.BocExpander2.PerformLayout();
            this.BocExpander1.ResumeLayout(false);
            this.BocExpander1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTabControl)).EndInit();
            this.SummaryTabControl.ResumeLayout(false);
            this.DatabaseTab.ResumeLayout(false);
            this.GridGroupBox.ResumeLayout(false);
            this.visualGroupBox5.ResumeLayout(false);
            this.visualGroupBox5.PerformLayout();
            this.visualGroupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.visualGroupBox4.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.visualGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.visualGroupBox1.ResumeLayout(false);
            this.visualGroupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTabControl)).EndInit();
            this.AccountTabControl.ResumeLayout(false);
            this.GraphTab.ResumeLayout(false);
            this.EditTab.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid222)).EndInit();
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
        private ButtonEditChildButton buttonEditChildButton1;
        private TabPageAdv AllocationTab;
        protected ChartControl BocChart;
        private TabControlAdv SummaryTabControl;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander1;
        private Label label5;
        private Label label6;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel BocExpander2;
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
        private MetroSetTextBox UpdateBudgetLevel;
        private MetroSetTextBox Updateid;
        private MetroSetTextBox metroSetTextBox1;
        private MetroSetTextBox Amount;
        private MetroSetTextBox UpdateCode;
        private MetroSetTextBox UpdateBOC;
        private MetroSetTextBox UpdateRC;
        private MetroSetTextBox UpdateFund;
        private MetroSetTextBox UpdateBFY;
        private MetroSetTextBox UpdateAH;
        private TabPageAdv GraphTab;
        protected ChartControl AccountChart;
        private Label label31;
        private Label lblTotal;
        private Label label34;
        private Label lblAve;
        private Label label40;
        private Label lblCount;
        private Label lblYear;
        private Label lblBoc;
        private Label lblFund;
        private Button button7;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CopyButton;
        private Button DatabaseSearchButton;
        private Button GridRefreshButton;
        private Button AddButton;
        private Button EditButton;
        private MetroSet_UI.Components.MetroSetToolTip metroSetToolTip1;
        private Button CalculatorButton;
        private MetroFramework.Controls.MetroGrid Grid222;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GridGroupBox;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridBocFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridFundFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter4;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox BocFilter1;
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
        private MetroSetTextBox UpdateOrg;
        private TabPageAdv AddTab;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddCode;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddBoc;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddSub;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddRc;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddOrg;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddAh;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddFund;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddYear;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox AddLevel;
        private Panel panel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox GridYearFilter;
        private Label label33;
        private Label lblDev;
        private Label label39;
        private Label lblVar;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox2;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox4;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView Grid;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox PrimaryFilter;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel20;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel19;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel18;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel17;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel16;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel15;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel14;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel13;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel12;
    }
}