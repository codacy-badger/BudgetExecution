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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DataManagerFilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DataManagerExpander = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnButton = new MetroFramework.Controls.MetroLink();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.DatabaseGridPanel = new System.Windows.Forms.Panel();
            this.DatabaseNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DataManagerGrid = new System.Windows.Forms.DataGridView();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RC = new MetroFramework.Controls.MetroTextBox();
            this.Org = new MetroFramework.Controls.MetroTextBox();
            this.BOC = new MetroFramework.Controls.MetroTextBox();
            this.Fund = new MetroFramework.Controls.MetroTextBox();
            this.BFY = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.Code = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OldAmount = new MetroFramework.Controls.MetroTextBox();
            this.PrcChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DataManagerTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.BudgetTab.SuspendLayout();
            this.BudgetDataGroup.SuspendLayout();
            this.MainGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.BudgetAccountGroup.SuspendLayout();
            this.QueryDataEntryPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.DataManagerExpander.SuspendLayout();
            this.DatabaseGroupBox.SuspendLayout();
            this.DatabaseGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseNavigator)).BeginInit();
            this.DatabaseNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataManagerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataManagerTabControl)).BeginInit();
            this.DataManagerTabControl.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
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
            // DataManagerFilterPanel
            // 
            this.DataManagerFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DataManagerFilterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DataManagerFilterPanel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataManagerFilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DataManagerFilterPanel.Location = new System.Drawing.Point(3, 52);
            this.DataManagerFilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DataManagerFilterPanel.Name = "DataManagerFilterPanel";
            this.DataManagerFilterPanel.Size = new System.Drawing.Size(234, 500);
            this.DataManagerFilterPanel.TabIndex = 136;
            // 
            // DataManagerExpander
            // 
            this.DataManagerExpander.BackColor = System.Drawing.Color.Black;
            this.DataManagerExpander.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.DataManagerExpander.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DataManagerExpander.Controls.Add(this.DataManagerFilterPanel);
            this.DataManagerExpander.ExpandedHeight = 582;
            this.DataManagerExpander.IsExpanded = false;
            this.DataManagerExpander.Location = new System.Drawing.Point(2, 2);
            this.DataManagerExpander.Margin = new System.Windows.Forms.Padding(2);
            this.DataManagerExpander.Name = "DataManagerExpander";
            this.DataManagerExpander.Padding = new System.Windows.Forms.Padding(1);
            this.DataManagerExpander.Size = new System.Drawing.Size(256, 37);
            this.DataManagerExpander.TabIndex = 118;
            this.DataManagerExpander.Text = "Select";
            this.DataManagerExpander.UseAnimation = true;
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DatabaseGroupBox.Controls.Add(this.ReturnButton);
            this.DatabaseGroupBox.Controls.Add(this.lblTotalAmount);
            this.DatabaseGroupBox.Controls.Add(this.lblCount);
            this.DatabaseGroupBox.Controls.Add(this.lblTotal);
            this.DatabaseGroupBox.Controls.Add(this.lblAccounts);
            this.DatabaseGroupBox.Controls.Add(this.DatabaseGridPanel);
            this.DatabaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatabaseGroupBox.Location = new System.Drawing.Point(317, 2);
            this.DatabaseGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DatabaseGroupBox.Size = new System.Drawing.Size(849, 504);
            this.DatabaseGroupBox.TabIndex = 141;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Regional Database";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Black;
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Location = new System.Drawing.Point(619, 47);
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
            this.lblTotalAmount.Location = new System.Drawing.Point(119, 52);
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
            this.lblCount.Location = new System.Drawing.Point(492, 52);
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
            this.lblTotal.Location = new System.Drawing.Point(60, 52);
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
            this.lblAccounts.Location = new System.Drawing.Point(401, 52);
            this.lblAccounts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(80, 21);
            this.lblAccounts.TabIndex = 122;
            this.lblAccounts.Text = "Accounts: ";
            // 
            // DatabaseGridPanel
            // 
            this.DatabaseGridPanel.Controls.Add(this.DatabaseNavigator);
            this.DatabaseGridPanel.Controls.Add(this.DataManagerGrid);
            this.DatabaseGridPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseGridPanel.Location = new System.Drawing.Point(57, 86);
            this.DatabaseGridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DatabaseGridPanel.Name = "DatabaseGridPanel";
            this.DatabaseGridPanel.Size = new System.Drawing.Size(711, 349);
            this.DatabaseGridPanel.TabIndex = 123;
            // 
            // DatabaseNavigator
            // 
            this.DatabaseNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.DatabaseNavigator.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseNavigator.CountItem = this.bindingNavigatorCountItem;
            this.DatabaseNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.DatabaseNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatabaseNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DatabaseNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.DatabaseNavigator.Location = new System.Drawing.Point(0, 318);
            this.DatabaseNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DatabaseNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DatabaseNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DatabaseNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DatabaseNavigator.Name = "DatabaseNavigator";
            this.DatabaseNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.DatabaseNavigator.Size = new System.Drawing.Size(711, 31);
            this.DatabaseNavigator.TabIndex = 1;
            this.DatabaseNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
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
            this.bindingNavigatorDeleteItem.Image = global::Ninja.Properties.Resources.Trash;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Ninja.Properties.Resources.Add_New;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // DataManagerGrid
            // 
            this.DataManagerGrid.AutoGenerateColumns = false;
            this.DataManagerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataManagerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataManagerGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataManagerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataManagerGrid.DataSource = this.BindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataManagerGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataManagerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataManagerGrid.EnableHeadersVisualStyles = false;
            this.DataManagerGrid.Location = new System.Drawing.Point(0, 0);
            this.DataManagerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataManagerGrid.Name = "DataManagerGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataManagerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DataManagerGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataManagerGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataManagerGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataManagerGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataManagerGrid.RowTemplate.Height = 28;
            this.DataManagerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataManagerGrid.Size = new System.Drawing.Size(711, 349);
            this.DataManagerGrid.TabIndex = 0;
            // 
            // RC
            // 
            // 
            // 
            // 
            this.RC.CustomButton.Image = null;
            this.RC.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.RC.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.RC.CustomButton.Name = "";
            this.RC.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.RC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RC.CustomButton.TabIndex = 1;
            this.RC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RC.CustomButton.UseSelectable = true;
            this.RC.CustomButton.Visible = false;
            this.RC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RC.Lines = new string[] {
        "metroTextBox7"};
            this.RC.Location = new System.Drawing.Point(96, 106);
            this.RC.Margin = new System.Windows.Forms.Padding(2);
            this.RC.MaxLength = 32767;
            this.RC.Name = "RC";
            this.RC.PasswordChar = '\0';
            this.RC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RC.SelectedText = "";
            this.RC.SelectionLength = 0;
            this.RC.SelectionStart = 0;
            this.RC.ShortcutsEnabled = true;
            this.RC.Size = new System.Drawing.Size(107, 35);
            this.RC.TabIndex = 160;
            this.RC.Text = "metroTextBox7";
            this.RC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RC.UseSelectable = true;
            this.RC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Org
            // 
            // 
            // 
            // 
            this.Org.CustomButton.Image = null;
            this.Org.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.Org.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.Org.CustomButton.Name = "";
            this.Org.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.Org.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Org.CustomButton.TabIndex = 1;
            this.Org.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Org.CustomButton.UseSelectable = true;
            this.Org.CustomButton.Visible = false;
            this.Org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Org.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Org.Lines = new string[] {
        "metroTextBox6"};
            this.Org.Location = new System.Drawing.Point(2, 106);
            this.Org.Margin = new System.Windows.Forms.Padding(2);
            this.Org.MaxLength = 32767;
            this.Org.Name = "Org";
            this.Org.PasswordChar = '\0';
            this.Org.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Org.SelectedText = "";
            this.Org.SelectionLength = 0;
            this.Org.SelectionStart = 0;
            this.Org.ShortcutsEnabled = true;
            this.Org.Size = new System.Drawing.Size(90, 35);
            this.Org.TabIndex = 159;
            this.Org.Text = "metroTextBox6";
            this.Org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Org.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Org.UseSelectable = true;
            this.Org.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Org.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BOC
            // 
            // 
            // 
            // 
            this.BOC.CustomButton.Image = null;
            this.BOC.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.BOC.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.BOC.CustomButton.Name = "";
            this.BOC.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.BOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BOC.CustomButton.TabIndex = 1;
            this.BOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BOC.CustomButton.UseSelectable = true;
            this.BOC.CustomButton.Visible = false;
            this.BOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BOC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BOC.Lines = new string[] {
        "metroTextBox5"};
            this.BOC.Location = new System.Drawing.Point(207, 32);
            this.BOC.Margin = new System.Windows.Forms.Padding(2);
            this.BOC.MaxLength = 32767;
            this.BOC.Name = "BOC";
            this.BOC.PasswordChar = '\0';
            this.BOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BOC.SelectedText = "";
            this.BOC.SelectionLength = 0;
            this.BOC.SelectionStart = 0;
            this.BOC.ShortcutsEnabled = true;
            this.BOC.Size = new System.Drawing.Size(116, 47);
            this.BOC.TabIndex = 158;
            this.BOC.Text = "metroTextBox5";
            this.BOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BOC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BOC.UseSelectable = true;
            this.BOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Fund
            // 
            // 
            // 
            // 
            this.Fund.CustomButton.Image = null;
            this.Fund.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.Fund.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.Fund.CustomButton.Name = "";
            this.Fund.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.Fund.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Fund.CustomButton.TabIndex = 1;
            this.Fund.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Fund.CustomButton.UseSelectable = true;
            this.Fund.CustomButton.Visible = false;
            this.Fund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fund.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Fund.Lines = new string[] {
        "metroTextBox4"};
            this.Fund.Location = new System.Drawing.Point(96, 32);
            this.Fund.Margin = new System.Windows.Forms.Padding(2);
            this.Fund.MaxLength = 32767;
            this.Fund.Name = "Fund";
            this.Fund.PasswordChar = '\0';
            this.Fund.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Fund.SelectedText = "";
            this.Fund.SelectionLength = 0;
            this.Fund.SelectionStart = 0;
            this.Fund.ShortcutsEnabled = true;
            this.Fund.Size = new System.Drawing.Size(107, 47);
            this.Fund.TabIndex = 157;
            this.Fund.Text = "metroTextBox4";
            this.Fund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fund.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Fund.UseSelectable = true;
            this.Fund.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fund.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BFY
            // 
            // 
            // 
            // 
            this.BFY.CustomButton.Image = null;
            this.BFY.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.BFY.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.BFY.CustomButton.Name = "";
            this.BFY.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.BFY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BFY.CustomButton.TabIndex = 1;
            this.BFY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BFY.CustomButton.UseSelectable = true;
            this.BFY.CustomButton.Visible = false;
            this.BFY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BFY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BFY.Lines = new string[] {
        "metroTextBox3"};
            this.BFY.Location = new System.Drawing.Point(2, 32);
            this.BFY.Margin = new System.Windows.Forms.Padding(2);
            this.BFY.MaxLength = 32767;
            this.BFY.Name = "BFY";
            this.BFY.PasswordChar = '\0';
            this.BFY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BFY.SelectedText = "";
            this.BFY.SelectionLength = 0;
            this.BFY.SelectionStart = 0;
            this.BFY.ShortcutsEnabled = true;
            this.BFY.Size = new System.Drawing.Size(90, 47);
            this.BFY.TabIndex = 156;
            this.BFY.Text = "metroTextBox3";
            this.BFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BFY.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BFY.UseSelectable = true;
            this.BFY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BFY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BFY.Click += new System.EventHandler(this.P7BFY_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(29, 9);
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
            this.label4.Location = new System.Drawing.Point(240, 83);
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
            this.label15.Location = new System.Drawing.Point(125, 9);
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
            this.label6.Location = new System.Drawing.Point(133, 83);
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
            this.label11.Location = new System.Drawing.Point(27, 83);
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
            this.label43.Location = new System.Drawing.Point(243, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 21);
            this.label43.TabIndex = 66;
            this.label43.Text = "BOC:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Code
            // 
            // 
            // 
            // 
            this.Code.CustomButton.Image = null;
            this.Code.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Code.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.Code.CustomButton.Name = "";
            this.Code.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Code.CustomButton.TabIndex = 1;
            this.Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Code.CustomButton.UseSelectable = true;
            this.Code.CustomButton.Visible = false;
            this.Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Code.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Code.Lines = new string[] {
        "metroTextBox2"};
            this.Code.Location = new System.Drawing.Point(207, 106);
            this.Code.Margin = new System.Windows.Forms.Padding(2);
            this.Code.MaxLength = 32767;
            this.Code.Name = "Code";
            this.Code.PasswordChar = '\0';
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Code.SelectedText = "";
            this.Code.SelectionLength = 0;
            this.Code.SelectionStart = 0;
            this.Code.ShortcutsEnabled = true;
            this.Code.Size = new System.Drawing.Size(116, 35);
            this.Code.TabIndex = 155;
            this.Code.Text = "metroTextBox2";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Code.UseSelectable = true;
            this.Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(12, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Amount:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldAmount
            // 
            // 
            // 
            // 
            this.OldAmount.CustomButton.Image = null;
            this.OldAmount.CustomButton.Location = new System.Drawing.Point(64, 2);
            this.OldAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.OldAmount.CustomButton.Name = "";
            this.OldAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.OldAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OldAmount.CustomButton.TabIndex = 1;
            this.OldAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OldAmount.CustomButton.UseSelectable = true;
            this.OldAmount.CustomButton.Visible = false;
            this.OldAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.OldAmount.Lines = new string[] {
        "metroTextBox1"};
            this.OldAmount.Location = new System.Drawing.Point(2, 178);
            this.OldAmount.Margin = new System.Windows.Forms.Padding(2);
            this.OldAmount.MaxLength = 32767;
            this.OldAmount.Name = "OldAmount";
            this.OldAmount.PasswordChar = '\0';
            this.OldAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldAmount.SelectedText = "";
            this.OldAmount.SelectionLength = 0;
            this.OldAmount.SelectionStart = 0;
            this.OldAmount.ShortcutsEnabled = true;
            this.OldAmount.Size = new System.Drawing.Size(90, 28);
            this.OldAmount.TabIndex = 154;
            this.OldAmount.Text = "metroTextBox1";
            this.OldAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OldAmount.UseSelectable = true;
            this.OldAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OldAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.PrcChart.Size = new System.Drawing.Size(463, 476);
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
            // DataManagerTabControl
            // 
            this.DataManagerTabControl.ActiveTabFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataManagerTabControl.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.DataManagerTabControl.BeforeTouchSize = new System.Drawing.Size(465, 507);
            this.DataManagerTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataManagerTabControl.CloseButtonBackColor = System.Drawing.Color.DimGray;
            this.DataManagerTabControl.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.DataManagerTabControl.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.DataManagerTabControl.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.DataManagerTabControl.Controls.Add(this.tabPageAdv1);
            this.DataManagerTabControl.Controls.Add(this.tabPageAdv2);
            this.DataManagerTabControl.Controls.Add(this.tabPageAdv3);
            this.DataManagerTabControl.FixedSingleBorderColor = System.Drawing.SystemColors.ControlDark;
            this.DataManagerTabControl.FocusOnTabClick = false;
            this.DataManagerTabControl.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.DataManagerTabControl.Location = new System.Drawing.Point(1204, 3);
            this.DataManagerTabControl.Name = "DataManagerTabControl";
            this.DataManagerTabControl.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.DataManagerTabControl.ShowSeparator = false;
            this.DataManagerTabControl.Size = new System.Drawing.Size(465, 507);
            this.DataManagerTabControl.TabIndex = 148;
            this.DataManagerTabControl.TabPanelBackColor = System.Drawing.Color.DarkGray;
            this.DataManagerTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPageAdv1.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(463, 476);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OldAmount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Code, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.RC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Org, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BOC, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Fund, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BFY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroTextBox1, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(127, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 162;
            this.label13.Text = "New:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(81, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(96, 178);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(107, 28);
            this.metroTextBox1.TabIndex = 161;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.PrcChart);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(463, 476);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26766F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.73234F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.Controls.Add(this.DataManagerExpander, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DatabaseGroupBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DataManagerTabControl, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1702, 586);
            this.tableLayoutPanel3.TabIndex = 150;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPageAdv3.Controls.Add(this.calculatorControl1);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(463, 476);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "tabPageAdv3";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(388, 360);
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.Location = new System.Drawing.Point(39, 55);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.Size = new System.Drawing.Size(388, 360);
            this.calculatorControl1.TabIndex = 0;
            this.calculatorControl1.Text = "calculatorControl1";
            this.calculatorControl1.UseVisualStyle = true;
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
            this.ClientSize = new System.Drawing.Size(1720, 680);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
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
            this.DataManagerExpander.ResumeLayout(false);
            this.DataManagerExpander.PerformLayout();
            this.DatabaseGroupBox.ResumeLayout(false);
            this.DatabaseGroupBox.PerformLayout();
            this.DatabaseGridPanel.ResumeLayout(false);
            this.DatabaseGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseNavigator)).EndInit();
            this.DatabaseNavigator.ResumeLayout(false);
            this.DatabaseNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataManagerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataManagerTabControl)).EndInit();
            this.DataManagerTabControl.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
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
                private System.Windows.Forms.FlowLayoutPanel DataManagerFilterPanel;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DataManagerExpander;
                private GroupBox DatabaseGroupBox;
                private Label lblTotalAmount;
                private Label lblCount;
                private Label lblTotal;
                private Label lblAccounts;
                private Panel DatabaseGridPanel;
                private DataGridView DataManagerGrid;
                private MetroTextBox RC;
                private MetroTextBox Org;
                private MetroTextBox BOC;
                private MetroTextBox Fund;
                private MetroTextBox BFY;
                private Label label1;
                private Label label4;
                private Label label15;
                private Label label6;
                private Label label11;
                private Label label43;
                private MetroTextBox OldAmount;
                private MetroTextBox Code;
                private Label label12;
                protected ChartControl PrcChart;
                private MetroLink ReturnButton;
                private TabControlAdv DataManagerTabControl;
                private TabPageAdv tabPageAdv1;
                private TabPageAdv tabPageAdv2;
                private TableLayoutPanel tableLayoutPanel1;
                private Label label13;
                private MetroTextBox metroTextBox1;
                private BindingNavigator DatabaseNavigator;
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
                private BindingSource BindingSource;
                private TableLayoutPanel tableLayoutPanel3;
                private ToolStripSeparator toolStripSeparator1;
                private TabPageAdv tabPageAdv3;
                private CalculatorControl calculatorControl1;
            } 
        }
    }
}