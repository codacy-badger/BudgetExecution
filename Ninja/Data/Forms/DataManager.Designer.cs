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
            partial class DataManager
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
                        components.Dispose( );
                    }
                    base.Dispose(disposing);
                }

                #region Windows Form Designer generated code

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent( )
                {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetLevelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFYDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOCDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetLevelDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFYDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOCDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subProjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BudgetDataGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainGridPanel = new System.Windows.Forms.Panel();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.BudgetAccountGroup = new System.Windows.Forms.GroupBox();
            this.QueryDataEntryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetTextBox2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox6 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroSetTextBox4 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.metroSetTextBox7 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.metroSetTextBox3 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTextBox5 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetButton19 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton20 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton21 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton22 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton23 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton24 = new MetroSet_UI.Controls.MetroSetButton();
            this.BudgetFilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnButton = new MetroFramework.Controls.MetroLink();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.DataMgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rc = new MetroFramework.Controls.MetroTextBox();
            this.org = new MetroFramework.Controls.MetroTextBox();
            this.boc = new MetroFramework.Controls.MetroTextBox();
            this.fund = new MetroFramework.Controls.MetroTextBox();
            this.bfy = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.code = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.amount1 = new MetroFramework.Controls.MetroTextBox();
            this.PrcChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.amount2 = new MetroFramework.Controls.MetroTextBox();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DataMgrFiterPanel = new MakarovDev.ExpandCollapsePanel.AdvancedFlowLayoutPanel();
            this.DataMgrNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DataMgrGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BudgetTab.SuspendLayout();
            this.BudgetDataGroup.SuspendLayout();
            this.MainGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.BudgetAccountGroup.SuspendLayout();
            this.QueryDataEntryPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrNavigator)).BeginInit();
            this.DataMgrNavigator.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(40, 56);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // budgetLevelDataGridViewTextBoxColumn2
            // 
            this.budgetLevelDataGridViewTextBoxColumn2.DataPropertyName = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn2.HeaderText = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn2.Name = "budgetLevelDataGridViewTextBoxColumn2";
            // 
            // rPIODataGridViewTextBoxColumn
            // 
            this.rPIODataGridViewTextBoxColumn.DataPropertyName = "RPIO";
            this.rPIODataGridViewTextBoxColumn.HeaderText = "RPIO";
            this.rPIODataGridViewTextBoxColumn.Name = "rPIODataGridViewTextBoxColumn";
            // 
            // bFYDataGridViewTextBoxColumn2
            // 
            this.bFYDataGridViewTextBoxColumn2.DataPropertyName = "BFY";
            this.bFYDataGridViewTextBoxColumn2.HeaderText = "BFY";
            this.bFYDataGridViewTextBoxColumn2.Name = "bFYDataGridViewTextBoxColumn2";
            // 
            // fundDataGridViewTextBoxColumn2
            // 
            this.fundDataGridViewTextBoxColumn2.DataPropertyName = "Fund";
            this.fundDataGridViewTextBoxColumn2.HeaderText = "Fund";
            this.fundDataGridViewTextBoxColumn2.Name = "fundDataGridViewTextBoxColumn2";
            // 
            // fundNameDataGridViewTextBoxColumn
            // 
            this.fundNameDataGridViewTextBoxColumn.DataPropertyName = "FundName";
            this.fundNameDataGridViewTextBoxColumn.HeaderText = "FundName";
            this.fundNameDataGridViewTextBoxColumn.Name = "fundNameDataGridViewTextBoxColumn";
            // 
            // bOCDataGridViewTextBoxColumn2
            // 
            this.bOCDataGridViewTextBoxColumn2.DataPropertyName = "BOC";
            this.bOCDataGridViewTextBoxColumn2.HeaderText = "BOC";
            this.bOCDataGridViewTextBoxColumn2.Name = "bOCDataGridViewTextBoxColumn2";
            // 
            // bocNameDataGridViewTextBoxColumn
            // 
            this.bocNameDataGridViewTextBoxColumn.DataPropertyName = "BocName";
            this.bocNameDataGridViewTextBoxColumn.HeaderText = "BocName";
            this.bocNameDataGridViewTextBoxColumn.Name = "bocNameDataGridViewTextBoxColumn";
            // 
            // orgDataGridViewTextBoxColumn2
            // 
            this.orgDataGridViewTextBoxColumn2.DataPropertyName = "Org";
            this.orgDataGridViewTextBoxColumn2.HeaderText = "Org";
            this.orgDataGridViewTextBoxColumn2.Name = "orgDataGridViewTextBoxColumn2";
            // 
            // rCDataGridViewTextBoxColumn2
            // 
            this.rCDataGridViewTextBoxColumn2.DataPropertyName = "RC";
            this.rCDataGridViewTextBoxColumn2.HeaderText = "RC";
            this.rCDataGridViewTextBoxColumn2.Name = "rCDataGridViewTextBoxColumn2";
            // 
            // divisionNameDataGridViewTextBoxColumn
            // 
            this.divisionNameDataGridViewTextBoxColumn.DataPropertyName = "DivisionName";
            this.divisionNameDataGridViewTextBoxColumn.HeaderText = "DivisionName";
            this.divisionNameDataGridViewTextBoxColumn.Name = "divisionNameDataGridViewTextBoxColumn";
            // 
            // subProjectDataGridViewTextBoxColumn
            // 
            this.subProjectDataGridViewTextBoxColumn.DataPropertyName = "SubProject";
            this.subProjectDataGridViewTextBoxColumn.HeaderText = "SubProject";
            this.subProjectDataGridViewTextBoxColumn.Name = "subProjectDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn2
            // 
            this.codeDataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn2.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn2.Name = "codeDataGridViewTextBoxColumn2";
            // 
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            // 
            // nPMDataGridViewTextBoxColumn
            // 
            this.nPMDataGridViewTextBoxColumn.DataPropertyName = "NPM";
            this.nPMDataGridViewTextBoxColumn.HeaderText = "NPM";
            this.nPMDataGridViewTextBoxColumn.Name = "nPMDataGridViewTextBoxColumn";
            // 
            // npmCodeDataGridViewTextBoxColumn
            // 
            this.npmCodeDataGridViewTextBoxColumn.DataPropertyName = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn.HeaderText = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn.Name = "npmCodeDataGridViewTextBoxColumn";
            // 
            // programProjectNameDataGridViewTextBoxColumn
            // 
            this.programProjectNameDataGridViewTextBoxColumn.DataPropertyName = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn.HeaderText = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn.Name = "programProjectNameDataGridViewTextBoxColumn";
            // 
            // programProjectCodeDataGridViewTextBoxColumn
            // 
            this.programProjectCodeDataGridViewTextBoxColumn.DataPropertyName = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn.HeaderText = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn.Name = "programProjectCodeDataGridViewTextBoxColumn";
            // 
            // programAreaDataGridViewTextBoxColumn
            // 
            this.programAreaDataGridViewTextBoxColumn.DataPropertyName = "ProgramArea";
            this.programAreaDataGridViewTextBoxColumn.HeaderText = "ProgramArea";
            this.programAreaDataGridViewTextBoxColumn.Name = "programAreaDataGridViewTextBoxColumn";
            // 
            // programAreaNameDataGridViewTextBoxColumn
            // 
            this.programAreaNameDataGridViewTextBoxColumn.DataPropertyName = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn.HeaderText = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn.Name = "programAreaNameDataGridViewTextBoxColumn";
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "Goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "Goal";
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            // 
            // goalNameDataGridViewTextBoxColumn
            // 
            this.goalNameDataGridViewTextBoxColumn.DataPropertyName = "GoalName";
            this.goalNameDataGridViewTextBoxColumn.HeaderText = "GoalName";
            this.goalNameDataGridViewTextBoxColumn.Name = "goalNameDataGridViewTextBoxColumn";
            // 
            // objectiveDataGridViewTextBoxColumn
            // 
            this.objectiveDataGridViewTextBoxColumn.DataPropertyName = "Objective";
            this.objectiveDataGridViewTextBoxColumn.HeaderText = "Objective";
            this.objectiveDataGridViewTextBoxColumn.Name = "objectiveDataGridViewTextBoxColumn";
            // 
            // objectiveNameDataGridViewTextBoxColumn
            // 
            this.objectiveNameDataGridViewTextBoxColumn.DataPropertyName = "ObjectiveName";
            this.objectiveNameDataGridViewTextBoxColumn.HeaderText = "ObjectiveName";
            this.objectiveNameDataGridViewTextBoxColumn.Name = "objectiveNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // budgetLevelDataGridViewTextBoxColumn3
            // 
            this.budgetLevelDataGridViewTextBoxColumn3.DataPropertyName = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn3.HeaderText = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn3.Name = "budgetLevelDataGridViewTextBoxColumn3";
            // 
            // rPIODataGridViewTextBoxColumn1
            // 
            this.rPIODataGridViewTextBoxColumn1.DataPropertyName = "RPIO";
            this.rPIODataGridViewTextBoxColumn1.HeaderText = "RPIO";
            this.rPIODataGridViewTextBoxColumn1.Name = "rPIODataGridViewTextBoxColumn1";
            // 
            // bFYDataGridViewTextBoxColumn3
            // 
            this.bFYDataGridViewTextBoxColumn3.DataPropertyName = "BFY";
            this.bFYDataGridViewTextBoxColumn3.HeaderText = "BFY";
            this.bFYDataGridViewTextBoxColumn3.Name = "bFYDataGridViewTextBoxColumn3";
            // 
            // fundDataGridViewTextBoxColumn3
            // 
            this.fundDataGridViewTextBoxColumn3.DataPropertyName = "Fund";
            this.fundDataGridViewTextBoxColumn3.HeaderText = "Fund";
            this.fundDataGridViewTextBoxColumn3.Name = "fundDataGridViewTextBoxColumn3";
            // 
            // fundNameDataGridViewTextBoxColumn1
            // 
            this.fundNameDataGridViewTextBoxColumn1.DataPropertyName = "FundName";
            this.fundNameDataGridViewTextBoxColumn1.HeaderText = "FundName";
            this.fundNameDataGridViewTextBoxColumn1.Name = "fundNameDataGridViewTextBoxColumn1";
            // 
            // bOCDataGridViewTextBoxColumn3
            // 
            this.bOCDataGridViewTextBoxColumn3.DataPropertyName = "BOC";
            this.bOCDataGridViewTextBoxColumn3.HeaderText = "BOC";
            this.bOCDataGridViewTextBoxColumn3.Name = "bOCDataGridViewTextBoxColumn3";
            // 
            // bocNameDataGridViewTextBoxColumn1
            // 
            this.bocNameDataGridViewTextBoxColumn1.DataPropertyName = "BocName";
            this.bocNameDataGridViewTextBoxColumn1.HeaderText = "BocName";
            this.bocNameDataGridViewTextBoxColumn1.Name = "bocNameDataGridViewTextBoxColumn1";
            // 
            // orgDataGridViewTextBoxColumn3
            // 
            this.orgDataGridViewTextBoxColumn3.DataPropertyName = "Org";
            this.orgDataGridViewTextBoxColumn3.HeaderText = "Org";
            this.orgDataGridViewTextBoxColumn3.Name = "orgDataGridViewTextBoxColumn3";
            // 
            // rCDataGridViewTextBoxColumn3
            // 
            this.rCDataGridViewTextBoxColumn3.DataPropertyName = "RC";
            this.rCDataGridViewTextBoxColumn3.HeaderText = "RC";
            this.rCDataGridViewTextBoxColumn3.Name = "rCDataGridViewTextBoxColumn3";
            // 
            // divisionNameDataGridViewTextBoxColumn1
            // 
            this.divisionNameDataGridViewTextBoxColumn1.DataPropertyName = "DivisionName";
            this.divisionNameDataGridViewTextBoxColumn1.HeaderText = "DivisionName";
            this.divisionNameDataGridViewTextBoxColumn1.Name = "divisionNameDataGridViewTextBoxColumn1";
            // 
            // subProjectDataGridViewTextBoxColumn1
            // 
            this.subProjectDataGridViewTextBoxColumn1.DataPropertyName = "SubProject";
            this.subProjectDataGridViewTextBoxColumn1.HeaderText = "SubProject";
            this.subProjectDataGridViewTextBoxColumn1.Name = "subProjectDataGridViewTextBoxColumn1";
            // 
            // codeDataGridViewTextBoxColumn3
            // 
            this.codeDataGridViewTextBoxColumn3.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn3.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn3.Name = "codeDataGridViewTextBoxColumn3";
            // 
            // amountDataGridViewTextBoxColumn3
            // 
            this.amountDataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn3.Name = "amountDataGridViewTextBoxColumn3";
            // 
            // nPMDataGridViewTextBoxColumn1
            // 
            this.nPMDataGridViewTextBoxColumn1.DataPropertyName = "NPM";
            this.nPMDataGridViewTextBoxColumn1.HeaderText = "NPM";
            this.nPMDataGridViewTextBoxColumn1.Name = "nPMDataGridViewTextBoxColumn1";
            // 
            // npmCodeDataGridViewTextBoxColumn1
            // 
            this.npmCodeDataGridViewTextBoxColumn1.DataPropertyName = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn1.HeaderText = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn1.Name = "npmCodeDataGridViewTextBoxColumn1";
            // 
            // programProjectNameDataGridViewTextBoxColumn1
            // 
            this.programProjectNameDataGridViewTextBoxColumn1.DataPropertyName = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn1.HeaderText = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn1.Name = "programProjectNameDataGridViewTextBoxColumn1";
            // 
            // programProjectCodeDataGridViewTextBoxColumn1
            // 
            this.programProjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn1.HeaderText = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn1.Name = "programProjectCodeDataGridViewTextBoxColumn1";
            // 
            // programAreaDataGridViewTextBoxColumn1
            // 
            this.programAreaDataGridViewTextBoxColumn1.DataPropertyName = "ProgramArea";
            this.programAreaDataGridViewTextBoxColumn1.HeaderText = "ProgramArea";
            this.programAreaDataGridViewTextBoxColumn1.Name = "programAreaDataGridViewTextBoxColumn1";
            // 
            // programAreaNameDataGridViewTextBoxColumn1
            // 
            this.programAreaNameDataGridViewTextBoxColumn1.DataPropertyName = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn1.HeaderText = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn1.Name = "programAreaNameDataGridViewTextBoxColumn1";
            // 
            // goalDataGridViewTextBoxColumn1
            // 
            this.goalDataGridViewTextBoxColumn1.DataPropertyName = "Goal";
            this.goalDataGridViewTextBoxColumn1.HeaderText = "Goal";
            this.goalDataGridViewTextBoxColumn1.Name = "goalDataGridViewTextBoxColumn1";
            // 
            // goalNameDataGridViewTextBoxColumn1
            // 
            this.goalNameDataGridViewTextBoxColumn1.DataPropertyName = "GoalName";
            this.goalNameDataGridViewTextBoxColumn1.HeaderText = "GoalName";
            this.goalNameDataGridViewTextBoxColumn1.Name = "goalNameDataGridViewTextBoxColumn1";
            // 
            // objectiveDataGridViewTextBoxColumn1
            // 
            this.objectiveDataGridViewTextBoxColumn1.DataPropertyName = "Objective";
            this.objectiveDataGridViewTextBoxColumn1.HeaderText = "Objective";
            this.objectiveDataGridViewTextBoxColumn1.Name = "objectiveDataGridViewTextBoxColumn1";
            // 
            // objectiveNameDataGridViewTextBoxColumn1
            // 
            this.objectiveNameDataGridViewTextBoxColumn1.DataPropertyName = "ObjectiveName";
            this.objectiveNameDataGridViewTextBoxColumn1.HeaderText = "ObjectiveName";
            this.objectiveNameDataGridViewTextBoxColumn1.Name = "objectiveNameDataGridViewTextBoxColumn1";
            // 
            // BudgetTab
            // 
            this.BudgetTab.Controls.Add(this.BudgetDataGroup);
            this.BudgetTab.Controls.Add(this.BudgetAccountGroup);
            this.BudgetTab.Image = null;
            this.BudgetTab.ImageSize = new System.Drawing.Size(16, 16);
            this.BudgetTab.Location = new System.Drawing.Point(0, 0);
            this.BudgetTab.Name = "BudgetTab";
            this.BudgetTab.ShowCloseButton = true;
            this.BudgetTab.Size = new System.Drawing.Size(200, 100);
            this.BudgetTab.TabFont = null;
            this.BudgetTab.TabIndex = 0;
            this.BudgetTab.ThemesEnabled = false;
            // 
            // BudgetDataGroup
            // 
            this.BudgetDataGroup.Controls.Add(this.label2);
            this.BudgetDataGroup.Controls.Add(this.MainGridPanel);
            this.BudgetDataGroup.Controls.Add(this.label3);
            this.BudgetDataGroup.Controls.Add(this.label41);
            this.BudgetDataGroup.Controls.Add(this.label38);
            this.BudgetDataGroup.ForeColor = System.Drawing.SystemColors.Info;
            this.BudgetDataGroup.Location = new System.Drawing.Point(322, 30);
            this.BudgetDataGroup.Name = "BudgetDataGroup";
            this.BudgetDataGroup.Size = new System.Drawing.Size(888, 292);
            this.BudgetDataGroup.TabIndex = 140;
            this.BudgetDataGroup.TabStop = false;
            this.BudgetDataGroup.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(122, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "label2";
            // 
            // MainGridPanel
            // 
            this.MainGridPanel.Controls.Add(this.MainGrid);
            this.MainGridPanel.Location = new System.Drawing.Point(41, 95);
            this.MainGridPanel.Name = "MainGridPanel";
            this.MainGridPanel.Size = new System.Drawing.Size(683, 171);
            this.MainGridPanel.TabIndex = 123;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToOrderColumns = true;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MainGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.EnableHeadersVisualStyles = false;
            this.MainGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainGrid.Location = new System.Drawing.Point(0, 0);
            this.MainGrid.Name = "MainGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MainGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MainGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.MainGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.MainGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowTemplate.Height = 28;
            this.MainGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(683, 171);
            this.MainGrid.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(632, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "label3";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.Info;
            this.label41.Location = new System.Drawing.Point(35, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 20);
            this.label41.TabIndex = 121;
            this.label41.Text = "Total: ";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.Info;
            this.label38.Location = new System.Drawing.Point(502, 51);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(84, 20);
            this.label38.TabIndex = 122;
            this.label38.Text = "Accounts: ";
            // 
            // BudgetAccountGroup
            // 
            this.BudgetAccountGroup.Controls.Add(this.QueryDataEntryPanel);
            this.BudgetAccountGroup.Controls.Add(this.tableLayoutPanel4);
            this.BudgetAccountGroup.ForeColor = System.Drawing.SystemColors.Info;
            this.BudgetAccountGroup.Location = new System.Drawing.Point(322, 335);
            this.BudgetAccountGroup.Name = "BudgetAccountGroup";
            this.BudgetAccountGroup.Size = new System.Drawing.Size(888, 296);
            this.BudgetAccountGroup.TabIndex = 139;
            this.BudgetAccountGroup.TabStop = false;
            this.BudgetAccountGroup.Text = "Account Data";
            // 
            // QueryDataEntryPanel
            // 
            this.QueryDataEntryPanel.ColumnCount = 7;
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.QueryDataEntryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox2, 5, 2);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox6, 6, 2);
            this.QueryDataEntryPanel.Controls.Add(this.label7, 5, 0);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox4, 4, 2);
            this.QueryDataEntryPanel.Controls.Add(this.label39, 6, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label8, 1, 0);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox7, 3, 2);
            this.QueryDataEntryPanel.Controls.Add(this.label9, 4, 0);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox3, 1, 2);
            this.QueryDataEntryPanel.Controls.Add(this.label40, 0, 1);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox1, 0, 2);
            this.QueryDataEntryPanel.Controls.Add(this.metroSetTextBox5, 2, 2);
            this.QueryDataEntryPanel.Controls.Add(this.label32, 3, 0);
            this.QueryDataEntryPanel.Controls.Add(this.label10, 2, 0);
            this.QueryDataEntryPanel.Controls.Add(this.label45, 5, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label46, 6, 0);
            this.QueryDataEntryPanel.Controls.Add(this.label49, 4, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label50, 1, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label51, 3, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label54, 2, 1);
            this.QueryDataEntryPanel.Controls.Add(this.label5, 0, 0);
            this.QueryDataEntryPanel.Location = new System.Drawing.Point(31, 52);
            this.QueryDataEntryPanel.Name = "QueryDataEntryPanel";
            this.QueryDataEntryPanel.RowCount = 3;
            this.QueryDataEntryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QueryDataEntryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QueryDataEntryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.QueryDataEntryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.QueryDataEntryPanel.Size = new System.Drawing.Size(828, 133);
            this.QueryDataEntryPanel.TabIndex = 151;
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
            this.metroSetTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox2.Image = null;
            this.metroSetTextBox2.Lines = null;
            this.metroSetTextBox2.Location = new System.Drawing.Point(563, 87);
            this.metroSetTextBox2.MaxLength = 32767;
            this.metroSetTextBox2.Multiline = false;
            this.metroSetTextBox2.Name = "metroSetTextBox2";
            this.metroSetTextBox2.ReadOnly = false;
            this.metroSetTextBox2.Size = new System.Drawing.Size(124, 43);
            this.metroSetTextBox2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox2.StyleManager = null;
            this.metroSetTextBox2.TabIndex = 137;
            this.metroSetTextBox2.Text = "Code";
            this.metroSetTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox2.ThemeAuthor = "Narwin";
            this.metroSetTextBox2.ThemeName = "MetroDark";
            this.metroSetTextBox2.UseSystemPasswordChar = false;
            this.metroSetTextBox2.WatermarkText = "";
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
            this.metroSetTextBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox6.Image = null;
            this.metroSetTextBox6.Lines = null;
            this.metroSetTextBox6.Location = new System.Drawing.Point(693, 87);
            this.metroSetTextBox6.MaxLength = 32767;
            this.metroSetTextBox6.Multiline = false;
            this.metroSetTextBox6.Name = "metroSetTextBox6";
            this.metroSetTextBox6.ReadOnly = false;
            this.metroSetTextBox6.Size = new System.Drawing.Size(132, 43);
            this.metroSetTextBox6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox6.StyleManager = null;
            this.metroSetTextBox6.TabIndex = 135;
            this.metroSetTextBox6.Text = "Amount";
            this.metroSetTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox6.ThemeAuthor = "Narwin";
            this.metroSetTextBox6.ThemeName = "MetroDark";
            this.metroSetTextBox6.UseSystemPasswordChar = false;
            this.metroSetTextBox6.WatermarkText = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(563, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Code:";
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
            this.metroSetTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox4.Image = null;
            this.metroSetTextBox4.Lines = null;
            this.metroSetTextBox4.Location = new System.Drawing.Point(450, 87);
            this.metroSetTextBox4.MaxLength = 32767;
            this.metroSetTextBox4.Multiline = false;
            this.metroSetTextBox4.Name = "metroSetTextBox4";
            this.metroSetTextBox4.ReadOnly = false;
            this.metroSetTextBox4.Size = new System.Drawing.Size(97, 43);
            this.metroSetTextBox4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox4.StyleManager = null;
            this.metroSetTextBox4.TabIndex = 136;
            this.metroSetTextBox4.Text = "RC";
            this.metroSetTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox4.ThemeAuthor = "Narwin";
            this.metroSetTextBox4.ThemeName = "MetroDark";
            this.metroSetTextBox4.UseSystemPasswordChar = false;
            this.metroSetTextBox4.WatermarkText = "";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(693, 42);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 20);
            this.label39.TabIndex = 149;
            this.label39.Text = "label39";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(111, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Fund:";
            // 
            // metroSetTextBox7
            // 
            this.metroSetTextBox7.AutoCompleteCustomSource = null;
            this.metroSetTextBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox7.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox7.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox7.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox7.Image = null;
            this.metroSetTextBox7.Lines = null;
            this.metroSetTextBox7.Location = new System.Drawing.Point(332, 87);
            this.metroSetTextBox7.MaxLength = 32767;
            this.metroSetTextBox7.Multiline = false;
            this.metroSetTextBox7.Name = "metroSetTextBox7";
            this.metroSetTextBox7.ReadOnly = false;
            this.metroSetTextBox7.Size = new System.Drawing.Size(94, 43);
            this.metroSetTextBox7.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox7.StyleManager = null;
            this.metroSetTextBox7.TabIndex = 139;
            this.metroSetTextBox7.Text = "Org";
            this.metroSetTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox7.ThemeAuthor = "Narwin";
            this.metroSetTextBox7.ThemeName = "MetroDark";
            this.metroSetTextBox7.UseSystemPasswordChar = false;
            this.metroSetTextBox7.WatermarkText = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(450, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "RC:";
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
            this.metroSetTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox3.Image = null;
            this.metroSetTextBox3.Lines = null;
            this.metroSetTextBox3.Location = new System.Drawing.Point(111, 87);
            this.metroSetTextBox3.MaxLength = 32767;
            this.metroSetTextBox3.Multiline = false;
            this.metroSetTextBox3.Name = "metroSetTextBox3";
            this.metroSetTextBox3.ReadOnly = false;
            this.metroSetTextBox3.Size = new System.Drawing.Size(88, 43);
            this.metroSetTextBox3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox3.StyleManager = null;
            this.metroSetTextBox3.TabIndex = 137;
            this.metroSetTextBox3.Text = "Fund";
            this.metroSetTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox3.ThemeAuthor = "Narwin";
            this.metroSetTextBox3.ThemeName = "MetroDark";
            this.metroSetTextBox3.UseSystemPasswordChar = false;
            this.metroSetTextBox3.WatermarkText = "";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 42);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(51, 20);
            this.label40.TabIndex = 143;
            this.label40.Text = "label1";
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
            this.metroSetTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(3, 87);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(88, 43);
            this.metroSetTextBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 141;
            this.metroSetTextBox1.Text = "BFY";
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
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
            this.metroSetTextBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox5.Image = null;
            this.metroSetTextBox5.Lines = null;
            this.metroSetTextBox5.Location = new System.Drawing.Point(219, 87);
            this.metroSetTextBox5.MaxLength = 32767;
            this.metroSetTextBox5.Multiline = false;
            this.metroSetTextBox5.Name = "metroSetTextBox5";
            this.metroSetTextBox5.ReadOnly = false;
            this.metroSetTextBox5.Size = new System.Drawing.Size(91, 43);
            this.metroSetTextBox5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTextBox5.StyleManager = null;
            this.metroSetTextBox5.TabIndex = 138;
            this.metroSetTextBox5.Text = "BOC";
            this.metroSetTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBox5.ThemeAuthor = "Narwin";
            this.metroSetTextBox5.ThemeName = "MetroDark";
            this.metroSetTextBox5.UseSystemPasswordChar = false;
            this.metroSetTextBox5.WatermarkText = "";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label32.Location = new System.Drawing.Point(332, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 20);
            this.label32.TabIndex = 62;
            this.label32.Text = "Org:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(219, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "BOC:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(563, 42);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(60, 20);
            this.label45.TabIndex = 148;
            this.label45.Text = "label37";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label46.Location = new System.Drawing.Point(693, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(69, 20);
            this.label46.TabIndex = 65;
            this.label46.Text = "Amount:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(450, 42);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 20);
            this.label49.TabIndex = 147;
            this.label49.Text = "label36";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(111, 42);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(51, 20);
            this.label50.TabIndex = 144;
            this.label50.Text = "label4";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(332, 42);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 20);
            this.label51.TabIndex = 146;
            this.label51.Text = "label51";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(219, 42);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(60, 20);
            this.label54.TabIndex = 145;
            this.label54.Text = "label54";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 140;
            this.label5.Text = "BFY";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5535F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton19, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton20, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton21, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton22, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton23, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroSetButton24, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(31, 222);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19231F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(799, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // metroSetButton19
            // 
            this.metroSetButton19.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton19.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton19.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton19.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton19.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton19.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton19.Location = new System.Drawing.Point(660, 3);
            this.metroSetButton19.Name = "metroSetButton19";
            this.metroSetButton19.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton19.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton19.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton19.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton19.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton19.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton19.Size = new System.Drawing.Size(118, 40);
            this.metroSetButton19.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton19.StyleManager = null;
            this.metroSetButton19.TabIndex = 6;
            this.metroSetButton19.Text = "Delete";
            this.metroSetButton19.ThemeAuthor = "Narwin";
            this.metroSetButton19.ThemeName = "MetroLite";
            // 
            // metroSetButton20
            // 
            this.metroSetButton20.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton20.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton20.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton20.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton20.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton20.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton20.Location = new System.Drawing.Point(522, 3);
            this.metroSetButton20.Name = "metroSetButton20";
            this.metroSetButton20.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton20.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton20.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton20.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton20.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton20.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton20.Size = new System.Drawing.Size(118, 40);
            this.metroSetButton20.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton20.StyleManager = null;
            this.metroSetButton20.TabIndex = 5;
            this.metroSetButton20.Text = "Save";
            this.metroSetButton20.ThemeAuthor = "Narwin";
            this.metroSetButton20.ThemeName = "MetroLite";
            // 
            // metroSetButton21
            // 
            this.metroSetButton21.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton21.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton21.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton21.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton21.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton21.Location = new System.Drawing.Point(386, 3);
            this.metroSetButton21.Name = "metroSetButton21";
            this.metroSetButton21.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton21.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton21.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton21.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton21.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton21.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton21.Size = new System.Drawing.Size(118, 40);
            this.metroSetButton21.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton21.StyleManager = null;
            this.metroSetButton21.TabIndex = 4;
            this.metroSetButton21.Text = "Copy";
            this.metroSetButton21.ThemeAuthor = "Narwin";
            this.metroSetButton21.ThemeName = "MetroLite";
            // 
            // metroSetButton22
            // 
            this.metroSetButton22.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton22.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton22.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton22.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton22.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton22.Location = new System.Drawing.Point(128, 3);
            this.metroSetButton22.Name = "metroSetButton22";
            this.metroSetButton22.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton22.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton22.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton22.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton22.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton22.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton22.Size = new System.Drawing.Size(118, 40);
            this.metroSetButton22.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton22.StyleManager = null;
            this.metroSetButton22.TabIndex = 2;
            this.metroSetButton22.Text = "Previous";
            this.metroSetButton22.ThemeAuthor = "Narwin";
            this.metroSetButton22.ThemeName = "MetroLite";
            // 
            // metroSetButton23
            // 
            this.metroSetButton23.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton23.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton23.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton23.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton23.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton23.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton23.Location = new System.Drawing.Point(3, 3);
            this.metroSetButton23.Name = "metroSetButton23";
            this.metroSetButton23.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton23.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton23.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton23.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton23.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton23.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton23.Size = new System.Drawing.Size(114, 40);
            this.metroSetButton23.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton23.StyleManager = null;
            this.metroSetButton23.TabIndex = 1;
            this.metroSetButton23.Text = "Next";
            this.metroSetButton23.ThemeAuthor = "Narwin";
            this.metroSetButton23.ThemeName = "MetroLite";
            // 
            // metroSetButton24
            // 
            this.metroSetButton24.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton24.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton24.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton24.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton24.HoverColor = System.Drawing.Color.SteelBlue;
            this.metroSetButton24.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton24.Location = new System.Drawing.Point(260, 3);
            this.metroSetButton24.Name = "metroSetButton24";
            this.metroSetButton24.NormalBorderColor = System.Drawing.Color.Black;
            this.metroSetButton24.NormalColor = System.Drawing.Color.Black;
            this.metroSetButton24.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetButton24.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton24.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton24.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton24.Size = new System.Drawing.Size(118, 40);
            this.metroSetButton24.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetButton24.StyleManager = null;
            this.metroSetButton24.TabIndex = 3;
            this.metroSetButton24.Text = "Add";
            this.metroSetButton24.ThemeAuthor = "Narwin";
            this.metroSetButton24.ThemeName = "MetroLite";
            // 
            // BudgetFilterPanel
            // 
            this.BudgetFilterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BudgetFilterPanel.Location = new System.Drawing.Point(3, 15);
            this.BudgetFilterPanel.Name = "BudgetFilterPanel";
            this.BudgetFilterPanel.Size = new System.Drawing.Size(306, 633);
            this.BudgetFilterPanel.TabIndex = 138;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Black;
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Location = new System.Drawing.Point(26, 356);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(65, 26);
            this.ReturnButton.TabIndex = 147;
            this.ReturnButton.UseSelectable = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotalAmount.Location = new System.Drawing.Point(63, 19);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(61, 21);
            this.lblTotalAmount.TabIndex = 119;
            this.lblTotalAmount.Text = "label46";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCount.Location = new System.Drawing.Point(316, 19);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 21);
            this.lblCount.TabIndex = 120;
            this.lblCount.Text = "label45";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(5, 19);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 21);
            this.lblTotal.TabIndex = 121;
            this.lblTotal.Text = "Total: ";
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAccounts.Location = new System.Drawing.Point(232, 19);
            this.lblAccounts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(80, 21);
            this.lblAccounts.TabIndex = 122;
            this.lblAccounts.Text = "Accounts: ";
            // 
            // rc
            // 
            // 
            // 
            // 
            this.rc.CustomButton.Image = null;
            this.rc.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.rc.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.rc.CustomButton.Name = "";
            this.rc.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.rc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rc.CustomButton.TabIndex = 1;
            this.rc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rc.CustomButton.UseSelectable = true;
            this.rc.CustomButton.Visible = false;
            this.rc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.rc.Lines = new string[] {
        "metroTextBox7"};
            this.rc.Location = new System.Drawing.Point(132, 110);
            this.rc.Margin = new System.Windows.Forms.Padding(2);
            this.rc.MaxLength = 32767;
            this.rc.Name = "rc";
            this.rc.PasswordChar = '\0';
            this.rc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rc.SelectedText = "";
            this.rc.SelectionLength = 0;
            this.rc.SelectionStart = 0;
            this.rc.ShortcutsEnabled = true;
            this.rc.Size = new System.Drawing.Size(148, 39);
            this.rc.TabIndex = 160;
            this.rc.Text = "metroTextBox7";
            this.rc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rc.UseSelectable = true;
            this.rc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // org
            // 
            // 
            // 
            // 
            this.org.CustomButton.Image = null;
            this.org.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.org.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.org.CustomButton.Name = "";
            this.org.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.org.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.org.CustomButton.TabIndex = 1;
            this.org.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.org.CustomButton.UseSelectable = true;
            this.org.CustomButton.Visible = false;
            this.org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.org.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.org.Lines = new string[] {
        "metroTextBox6"};
            this.org.Location = new System.Drawing.Point(3, 110);
            this.org.Margin = new System.Windows.Forms.Padding(2);
            this.org.MaxLength = 32767;
            this.org.Name = "org";
            this.org.PasswordChar = '\0';
            this.org.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.org.SelectedText = "";
            this.org.SelectionLength = 0;
            this.org.SelectionStart = 0;
            this.org.ShortcutsEnabled = true;
            this.org.Size = new System.Drawing.Size(125, 39);
            this.org.TabIndex = 159;
            this.org.Text = "metroTextBox6";
            this.org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.org.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.org.UseSelectable = true;
            this.org.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.org.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // boc
            // 
            // 
            // 
            // 
            this.boc.CustomButton.Image = null;
            this.boc.CustomButton.Location = new System.Drawing.Point(87, 2);
            this.boc.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.boc.CustomButton.Name = "";
            this.boc.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.boc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.boc.CustomButton.TabIndex = 1;
            this.boc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.boc.CustomButton.UseSelectable = true;
            this.boc.CustomButton.Visible = false;
            this.boc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.boc.Lines = new string[] {
        "metroTextBox5"};
            this.boc.Location = new System.Drawing.Point(284, 24);
            this.boc.Margin = new System.Windows.Forms.Padding(2);
            this.boc.MaxLength = 32767;
            this.boc.Name = "boc";
            this.boc.PasswordChar = '\0';
            this.boc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boc.SelectedText = "";
            this.boc.SelectionLength = 0;
            this.boc.SelectionStart = 0;
            this.boc.ShortcutsEnabled = true;
            this.boc.Size = new System.Drawing.Size(123, 38);
            this.boc.TabIndex = 158;
            this.boc.Text = "metroTextBox5";
            this.boc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.boc.UseSelectable = true;
            this.boc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.boc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fund
            // 
            // 
            // 
            // 
            this.fund.CustomButton.Image = null;
            this.fund.CustomButton.Location = new System.Drawing.Point(112, 2);
            this.fund.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.fund.CustomButton.Name = "";
            this.fund.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.fund.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fund.CustomButton.TabIndex = 1;
            this.fund.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fund.CustomButton.UseSelectable = true;
            this.fund.CustomButton.Visible = false;
            this.fund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fund.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.fund.Lines = new string[] {
        "metroTextBox4"};
            this.fund.Location = new System.Drawing.Point(132, 24);
            this.fund.Margin = new System.Windows.Forms.Padding(2);
            this.fund.MaxLength = 32767;
            this.fund.Name = "fund";
            this.fund.PasswordChar = '\0';
            this.fund.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fund.SelectedText = "";
            this.fund.SelectionLength = 0;
            this.fund.SelectionStart = 0;
            this.fund.ShortcutsEnabled = true;
            this.fund.Size = new System.Drawing.Size(148, 38);
            this.fund.TabIndex = 157;
            this.fund.Text = "metroTextBox4";
            this.fund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fund.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fund.UseSelectable = true;
            this.fund.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fund.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bfy
            // 
            // 
            // 
            // 
            this.bfy.CustomButton.Image = null;
            this.bfy.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.bfy.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.bfy.CustomButton.Name = "";
            this.bfy.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.bfy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bfy.CustomButton.TabIndex = 1;
            this.bfy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bfy.CustomButton.UseSelectable = true;
            this.bfy.CustomButton.Visible = false;
            this.bfy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfy.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bfy.Lines = new string[] {
        "metroTextBox3"};
            this.bfy.Location = new System.Drawing.Point(3, 24);
            this.bfy.Margin = new System.Windows.Forms.Padding(2);
            this.bfy.MaxLength = 32767;
            this.bfy.Name = "bfy";
            this.bfy.PasswordChar = '\0';
            this.bfy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bfy.SelectedText = "";
            this.bfy.SelectionLength = 0;
            this.bfy.SelectionStart = 0;
            this.bfy.ShortcutsEnabled = true;
            this.bfy.Size = new System.Drawing.Size(125, 38);
            this.bfy.TabIndex = 156;
            this.bfy.Text = "metroTextBox3";
            this.bfy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bfy.UseSelectable = true;
            this.bfy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bfy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.bfy.Click += new System.EventHandler(this.P7BFY_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(47, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 140;
            this.label1.Text = "BFY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(321, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Code:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(182, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 21);
            this.label15.TabIndex = 60;
            this.label15.Text = "Fund:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(189, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "RC:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(45, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 62;
            this.label11.Text = "Org:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label43.Location = new System.Drawing.Point(323, 1);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 21);
            this.label43.TabIndex = 66;
            this.label43.Text = "BOC:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // code
            // 
            // 
            // 
            // 
            this.code.CustomButton.Image = null;
            this.code.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.code.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.code.CustomButton.Name = "";
            this.code.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code.CustomButton.TabIndex = 1;
            this.code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code.CustomButton.UseSelectable = true;
            this.code.CustomButton.Visible = false;
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.code.Lines = new string[] {
        "metroTextBox2"};
            this.code.Location = new System.Drawing.Point(284, 110);
            this.code.Margin = new System.Windows.Forms.Padding(2);
            this.code.MaxLength = 32767;
            this.code.Name = "code";
            this.code.PasswordChar = '\0';
            this.code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code.SelectedText = "";
            this.code.SelectionLength = 0;
            this.code.SelectionStart = 0;
            this.code.ShortcutsEnabled = true;
            this.code.Size = new System.Drawing.Size(123, 39);
            this.code.TabIndex = 155;
            this.code.Text = "metroTextBox2";
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.code.UseSelectable = true;
            this.code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(31, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Amount:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount1
            // 
            // 
            // 
            // 
            this.amount1.CustomButton.Image = null;
            this.amount1.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.amount1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.amount1.CustomButton.Name = "";
            this.amount1.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.amount1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amount1.CustomButton.TabIndex = 1;
            this.amount1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amount1.CustomButton.UseSelectable = true;
            this.amount1.CustomButton.Visible = false;
            this.amount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amount1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.amount1.Lines = new string[] {
        "metroTextBox1"};
            this.amount1.Location = new System.Drawing.Point(3, 189);
            this.amount1.Margin = new System.Windows.Forms.Padding(2);
            this.amount1.MaxLength = 32767;
            this.amount1.Name = "amount1";
            this.amount1.PasswordChar = '\0';
            this.amount1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amount1.SelectedText = "";
            this.amount1.SelectionLength = 0;
            this.amount1.SelectionStart = 0;
            this.amount1.ShortcutsEnabled = true;
            this.amount1.Size = new System.Drawing.Size(125, 45);
            this.amount1.TabIndex = 154;
            this.amount1.Text = "metroTextBox1";
            this.amount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.amount1.UseSelectable = true;
            this.amount1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.PrcChart.Size = new System.Drawing.Size(453, 322);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.amount1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.code, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.rc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.org, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.boc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fund, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bfy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.amount2, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.80282F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.19718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(183, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 162;
            this.label13.Text = "New:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount2
            // 
            // 
            // 
            // 
            this.amount2.CustomButton.Image = null;
            this.amount2.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.amount2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.amount2.CustomButton.Name = "";
            this.amount2.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.amount2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amount2.CustomButton.TabIndex = 1;
            this.amount2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amount2.CustomButton.UseSelectable = true;
            this.amount2.CustomButton.Visible = false;
            this.amount2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amount2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.amount2.Lines = new string[] {
        "metroTextBox1"};
            this.amount2.Location = new System.Drawing.Point(132, 189);
            this.amount2.Margin = new System.Windows.Forms.Padding(2);
            this.amount2.MaxLength = 32767;
            this.amount2.Name = "amount2";
            this.amount2.PasswordChar = '\0';
            this.amount2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amount2.SelectedText = "";
            this.amount2.SelectionLength = 0;
            this.amount2.SelectionStart = 0;
            this.amount2.ShortcutsEnabled = true;
            this.amount2.Size = new System.Drawing.Size(148, 45);
            this.amount2.TabIndex = 161;
            this.amount2.Text = "metroTextBox1";
            this.amount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.amount2.UseSelectable = true;
            this.amount2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(456, 359);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv7);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Gray;
            this.tabControlAdv1.Location = new System.Drawing.Point(946, 4);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(456, 359);
            this.tabControlAdv1.TabIndex = 149;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2010);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAdv5.Controls.Add(this.lblTotal);
            this.tabPageAdv5.Controls.Add(this.ReturnButton);
            this.tabPageAdv5.Controls.Add(this.lblCount);
            this.tabPageAdv5.Controls.Add(this.lblTotalAmount);
            this.tabPageAdv5.Controls.Add(this.lblAccounts);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 35);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(453, 322);
            this.tabPageAdv5.TabIndex = 1;
            this.tabPageAdv5.Text = "tabPageAdv5";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.Controls.Add(this.PrcChart);
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv6.Location = new System.Drawing.Point(1, 35);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(453, 322);
            this.tabPageAdv6.TabIndex = 2;
            this.tabPageAdv6.Text = "tabPageAdv6";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.Image = null;
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv7.Location = new System.Drawing.Point(1, 35);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(453, 322);
            this.tabPageAdv7.TabIndex = 3;
            this.tabPageAdv7.Text = "tabPageAdv7";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.DataMgrFiterPanel);
            this.expandCollapsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(4, 4);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(247, 389);
            this.expandCollapsePanel1.TabIndex = 151;
            this.expandCollapsePanel1.Text = "Select";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // DataMgrFiterPanel
            // 
            this.DataMgrFiterPanel.Location = new System.Drawing.Point(29, 79);
            this.DataMgrFiterPanel.Name = "DataMgrFiterPanel";
            this.DataMgrFiterPanel.Size = new System.Drawing.Size(186, 197);
            this.DataMgrFiterPanel.TabIndex = 1;
            // 
            // DataMgrNavigator
            // 
            this.DataMgrNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.DataMgrNavigator.BackColor = System.Drawing.Color.Transparent;
            this.DataMgrNavigator.CountItem = this.bindingNavigatorCountItem;
            this.DataMgrNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.DataMgrNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.DataMgrNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DataMgrNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.DataMgrNavigator.Location = new System.Drawing.Point(1, 1);
            this.DataMgrNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DataMgrNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DataMgrNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DataMgrNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DataMgrNavigator.Name = "DataMgrNavigator";
            this.DataMgrNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.DataMgrNavigator.Size = new System.Drawing.Size(304, 31);
            this.DataMgrNavigator.TabIndex = 152;
            this.DataMgrNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DataMgrNavigator, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(959, 422);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.56522F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(408, 39);
            this.tableLayoutPanel3.TabIndex = 152;
            // 
            // DataMgrGrid
            // 
            this.DataMgrGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMgrGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataMgrGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataMgrGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataMgrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataMgrGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataMgrGrid.EnableHeadersVisualStyles = false;
            this.DataMgrGrid.Location = new System.Drawing.Point(256, 3);
            this.DataMgrGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataMgrGrid.Name = "DataMgrGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataMgrGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DataMgrGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataMgrGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataMgrGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataMgrGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataMgrGrid.RowTemplate.Height = 28;
            this.DataMgrGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataMgrGrid.Size = new System.Drawing.Size(589, 331);
            this.DataMgrGrid.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93055F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.1825F));
            this.tableLayoutPanel2.Controls.Add(this.tabControlAdv1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataMgrGrid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.expandCollapsePanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1413, 397);
            this.tableLayoutPanel2.TabIndex = 151;
            // 
            // DataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1437, 503);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaximumSize = new System.Drawing.Size(1599, 550);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "DataManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.P7DataManager_Load);
            this.BudgetTab.ResumeLayout(false);
            this.BudgetDataGroup.ResumeLayout(false);
            this.BudgetDataGroup.PerformLayout();
            this.MainGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.BudgetAccountGroup.ResumeLayout(false);
            this.QueryDataEntryPanel.ResumeLayout(false);
            this.QueryDataEntryPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            this.tabPageAdv6.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrNavigator)).EndInit();
            this.DataMgrNavigator.ResumeLayout(false);
            this.DataMgrNavigator.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMgrGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

                }

                #endregion
                private DataSet e6;
                private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn rPIODataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn fundDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn fundNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn bOCDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn bocNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn rCDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn divisionNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn subProjectDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn nPMDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn npmCodeDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn programProjectNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn programProjectCodeDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn programAreaDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn programAreaNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn goalNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn objectiveNameDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn rPIODataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn fundDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn fundNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn bOCDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn bocNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn rCDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn divisionNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn subProjectDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn nPMDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn npmCodeDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn programProjectNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn programProjectCodeDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn programAreaDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn programAreaNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn goalNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn objectiveNameDataGridViewTextBoxColumn1;
                private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
                private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
                private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
                private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
                private System.Windows.Forms.ToolStripContentPanel ContentPanel;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv BudgetTab;
                private System.Windows.Forms.GroupBox BudgetDataGroup;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Panel MainGridPanel;
                private System.Windows.Forms.DataGridView MainGrid;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.Label label41;
                private System.Windows.Forms.Label label38;
                private System.Windows.Forms.GroupBox BudgetAccountGroup;
                private System.Windows.Forms.TableLayoutPanel QueryDataEntryPanel;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox2;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox6;
                private System.Windows.Forms.Label label7;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox4;
                private System.Windows.Forms.Label label39;
                private System.Windows.Forms.Label label8;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox7;
                private System.Windows.Forms.Label label9;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox3;
                private System.Windows.Forms.Label label40;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
                private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox5;
                private System.Windows.Forms.Label label32;
                private System.Windows.Forms.Label label10;
                private System.Windows.Forms.Label label45;
                private System.Windows.Forms.Label label46;
                private System.Windows.Forms.Label label49;
                private System.Windows.Forms.Label label50;
                private System.Windows.Forms.Label label51;
                private System.Windows.Forms.Label label54;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton19;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton20;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton21;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton22;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton23;
                private MetroSet_UI.Controls.MetroSetButton metroSetButton24;
                private System.Windows.Forms.FlowLayoutPanel BudgetFilterPanel;
                private Label lblTotalAmount;
                private Label lblCount;
                private Label lblTotal;
                private Label lblAccounts;
                private MetroTextBox rc;
                private MetroTextBox org;
                private MetroTextBox boc;
                private MetroTextBox fund;
                private MetroTextBox bfy;
                private Label label1;
                private Label label4;
                private Label label15;
                private Label label6;
                private Label label11;
                private Label label43;
                private MetroTextBox amount1;
                private MetroTextBox code;
                private Label label12;
                protected ChartControl PrcChart;
                private MetroLink ReturnButton;
                private TableLayoutPanel tableLayoutPanel1;
                private Label label13;
                private MetroTextBox amount2;
                private BindingSource DataMgrBindingSource;
                private TabControlAdv tabControlAdv1;
                private TabPageAdv tabPageAdv5;
                private TabPageAdv tabPageAdv6;
                private TabPageAdv tabPageAdv7;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private MakarovDev.ExpandCollapsePanel.AdvancedFlowLayoutPanel DataMgrFiterPanel;
                private BindingNavigator DataMgrNavigator;
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
                private TableLayoutPanel tableLayoutPanel3;
                private DataGridView DataMgrGrid;
                private TableLayoutPanel tableLayoutPanel2;
            } 
        }
    }
}