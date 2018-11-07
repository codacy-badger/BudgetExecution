// <copyright file="SummaryForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using MakarovDev.ExpandCollapsePanel;

    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;

    using MetroSet_UI;

    using VisualPlus.Toolkit.Controls.Interactivity;

    /// <summary>
    ///     Defines the <see cref="SummaryForm" />
    /// </summary>
    public partial class SummaryForm : MetroForm
    {
        // CONSTRUCTORS

        /// <summary>
        ///     Initializes a new instance of the <see cref="SummaryForm" /> class.
        /// </summary>
        public SummaryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SummaryForm" /> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source" /></param>
        /// <param name="provider">The provider<see cref="Provider" /></param>
        public SummaryForm(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            ProgramElements = DbData.ProgramElements;
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbData.Table;
            Grid.DataSource = BindingSource;
            Metric = new PrcMetric(DbData);
            ChartMainTitle = new[] { $"{Source.ToString()} Funding By Appropriation" };
            lblTotal.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("c");
            lblAve.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
            lblDev.Text = ((double)DbData.Table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
            lblVar.Text = ((double)DbData.Table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
            lblCount.Text = DbData.GetCount(Table).ToString();
            ChartMainTitle = new[] { $"{Source.ToString()} Resources" };
            BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.FundName, Stat.Total, ChartSeriesType.Column).Activate();
        }

        // PROPERTIES

        /// <summary>
        ///     Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <summary>
        ///     Gets the Provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        ///     Gets or sets the ChartType
        /// </summary>
        public ChartSeriesType ChartType { get; set; }

        /// <summary>
        ///     Gets or sets the ChartField
        /// </summary>
        public Field PrimaryGrouping { get; set; }

        /// <summary>
        ///     Gets or sets the ChartGroup
        /// </summary>
        public Field SecondaryGrouping { get; set; }

        /// <summary>
        ///     Gets or sets the Measure
        /// </summary>
        public Stat Measure { get; set; }

        /// <summary>
        ///     Gets or sets the Parameter
        /// </summary>
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        ///     Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        ///     Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        ///     Gets or sets the DbRow
        /// </summary>
        public DataRow DbRow { get; set; }

        /// <summary>
        ///     Gets or sets the Metric
        /// </summary>
        public PrcMetric Metric { get; set; }

        /// <summary>
        ///     Gets or sets the BudgetLevel
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        ///     Gets or sets the BudgetLevel
        /// </summary>
        public string[] BudgetLevel { get; set; }

        /// <summary>
        ///     Gets or sets the BFY
        /// </summary>
        public string[] BFY { get; set; }

        /// <summary>
        ///     Gets or sets the Org
        /// </summary>
        public string[] Org { get; set; }

        /// <summary>
        ///     Gets or sets the RC
        /// </summary>
        public string[] RC { get; set; }

        /// <summary>
        ///     Gets or sets the AH
        /// </summary>
        public string[] AH { get; set; }

        /// <summary>
        ///     Gets or sets the Code
        /// </summary>
        public string[] Code { get; set; }

        /// <summary>
        ///     Gets or sets the BOC
        /// </summary>
        public string[] BOC { get; set; }

        /// <summary>
        ///     Gets or sets the Fund
        /// </summary>
        public string[] Fund { get; set; }

        /// <summary>
        ///     Gets or sets the SubProject
        /// </summary>
        public string[] SubProject { get; set; }

        /// <summary>
        ///     Gets or sets the ChartFilter
        /// </summary>
        public string ChartFilter { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilter1
        /// </summary>
        public string GridFilter1 { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilter2
        /// </summary>
        public string GridFilter2 { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilter3
        /// </summary>
        public string GridFilter3 { get; set; }

        /// <summary>
        ///     Gets or sets the Division
        /// </summary>
        public string Division { get; set; }

        /// <summary>
        ///     Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        ///     Gets or sets the ChartMainTitle
        /// </summary>
        public string[] ChartMainTitle { get; set; }

        /// <summary>
        ///     Gets or sets the ChartAxisTitle
        /// </summary>
        public string[] ChartAxisTitle { get; set; }

        /// <summary>
        ///     Gets or sets the CurrentIndex
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilterControl1
        /// </summary>
        public VisualComboBox GridFilterControl1 { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilterControl2
        /// </summary>
        public VisualComboBox GridFilterControl2 { get; set; }

        /// <summary>
        ///     Gets or sets the GridFilterControl3
        /// </summary>
        public VisualComboBox GridFilterControl3 { get; set; }

        /// <summary>
        ///     Gets or sets the ChartFilterControl1
        /// </summary>
        public VisualComboBox ChartFilterControl1 { get; set; }

        /// <summary>
        ///     Gets or sets the ChartFilterControl2
        /// </summary>
        public VisualComboBox ChartFilterControl2 { get; set; }

        /// <summary>
        ///     Gets or sets the ChartFilterControl3
        /// </summary>
        public VisualComboBox ChartFilterControl3 { get; set; }

        /// <summary>
        ///     Gets or sets the ChartFilterControl4
        /// </summary>
        public VisualComboBox ChartFilterControl4 { get; set; }

        /// <summary>
        ///     Gets or sets the Expander1
        /// </summary>
        public ExpandCollapsePanel Expander1 { get; set; }

        /// <summary>
        ///     Gets or sets the Expander2
        /// </summary>
        public ExpandCollapsePanel Expander2 { get; set; }

        /// <summary>
        ///     Gets or sets the Tab
        /// </summary>
        public TabPageAdv[] Tab { get; set; }

        // METHODS

        /// <summary>
        ///     The Form_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                BocExpander1.Visible = false;
                BocExpander2.Visible = false;
                EditTab.Visible = false;
                AddTab.Visible = false;
                PopulateAddTabComboBoxes();
                PopulateGridYearFilterItems();
                ConfigureEditTabTextBoxBindings();
                DefineVisisbleDataColumns(Grid);
                DatabaseTab.TabVisible = true;
                GridFundFilter.Visible = false;
                GridBocFilter.Visible = false;

                switch (Source)
                {
                    case Source.PRC:
                        SetPrcConfiguration();
                        break;

                    case Source.CONTRACTS:
                        SetContractsConfiguration();
                        break;

                    case Source.DWH:
                        SetDWHConfiguration();
                        break;

                    case Source.EPM:
                        SetEPMConfiguration();
                        break;

                    case Source.EXPENSES:
                        SetExpensesConfigurations();
                        break;

                    case Source.GRANTS:
                        SetGrantsConfiguration();
                        break;

                    case Source.LUST:
                        SetLUSTConfiguration();
                        break;

                    case Source.SF6A:
                        SetSF6AConfiguration();
                        break;

                    case Source.STAG:
                        SetSTAGConfiguration();
                        break;

                    case Source.SUPERFUND:
                        SetSuperfundConfiguration();
                        break;

                    case Source.OIL:
                        SetOilSpillConfiguration();
                        break;

                    case Source.TRAVEL:
                        SetTravelConfiguration();
                        break;

                    case Source.FTE:
                        SetFTEConfiguration();
                        break;

                    case Source.MD:
                    case Source.SF:
                    case Source.RC:
                    case Source.RA:
                    case Source.EJ:
                    case Source.XA:
                    case Source.WQ:
                    case Source.MM:
                    case Source.WSA:
                    case Source.WCF:
                    case Source.MDR:
                    case Source.EN:
                        SetDivisionConfiguration();
                        break;

                    default:
                        GridLevel7.Visible = false;
                        GridLevel8.Visible = false;
                        ChartLevel7.Visible = false;
                        ChartLevel8.Visible = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetPrcConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetRegionalAccountsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Visible = true;
                DatabaseTab.Visible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetDivisionAccountsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Visible = true;
                DatabaseTab.Visible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetContractsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                bL7.Checked = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetExpensesConfigurations()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetTravelConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetWCFConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetFTEConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                PrimaryFilter.Items.Remove("BocName");
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetPayrollConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetAwardsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetGrantsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetEPMConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Visible = true;
                PrimaryFilter.Items.Remove("FundName");
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetSuperfundConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetLUSTConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetOilSpillConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetSTAGConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetDWHConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetBudgetLevelsConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetSF6AConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel7.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[1].TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void SetDivisionConfiguration()
        {
            try
            {
                GridLevel7.Visible = true;
                GridLevel8.Visible = true;
                ChartLevel7.Visible = true;
                ChartLevel8.Checked = true;
                ChartLevel8.Visible = true;
                SummaryTabControl.TabPages[0].TabVisible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartLevel7Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Level = "7";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartLevel8Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Level = "8";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridLevel7Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Level = "7";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridLevel8Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Level = "8";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The FilterDataGrid
        /// </summary>
        private void FilterDataGridYear()
        {
            try
            {
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BFY = '{GridFilter1}'";
                DataTable table = ((DataTable)BindingSource.DataSource).AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                PopulateGridFundFilterItems();
                GridFundFilter.Visible = true;
                if (GridBocFilter.Visible)
                {
                    GridBocFilter.Items.Clear();
                }

                GridGroupBox.Text = $"{Source.ToString()} {GridFilter1}";
                TransitionChart(table);
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGridYear(VisualRadioButton rb)
        {
            try
            {
                string level = rb.Tag.ToString();
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BudgetLevel = '{level}' AND BFY = '{GridYearFilter.SelectedItem}'";
                DataTable table = ((DataTable)BindingSource.DataSource).AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Where(p => p.Field<string>("BudgetLevel").Equals(level)).Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString())).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                PopulateGridFundFilterItems();
                GridFundFilter.Visible = true;
                if (GridBocFilter.Visible)
                {
                    GridBocFilter.Items.Clear();
                }

                GridGroupBox.Text = $"{Source.ToString()} Level-{level} {GridYearFilter.SelectedItem}";
                TransitionChart(table);
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGridFund()
        {
            try
            {
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BFY = '{GridYearFilter.SelectedItem}' AND FundName = '{GridFundFilter.SelectedItem}'";
                DataTable table = Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString())).Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString())).Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                if (int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if (int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

                PopulateGridBocFilterItems();
                GridBocFilter.Visible = true;
                GridGroupBox.Text = $"{Source.ToString()} {GridYearFilter.SelectedItem} {GridFundFilter.SelectedItem}";
                TransitionChart(table);
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGridFund(VisualRadioButton rb)
        {
            try
            {
                string level = rb.Tag.ToString();
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BudgetLevel = '{level}' AND BFY = '{GridYearFilter.SelectedItem}' AND FundName = '{GridFundFilter.SelectedItem}'";
                DataTable table = Table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Where(p => p.Field<string>("BudgetLevel").Equals(level)).Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString())).Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString())).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                if (int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if (int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

                PopulateGridBocFilterItems();
                GridBocFilter.Visible = true;
                GridGroupBox.Text = $"{Source.ToString()} Level-{level} {GridYearFilter.SelectedItem} {GridFundFilter.SelectedItem}";
                TransitionChart(table);
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGridBoc()
        {
            try
            {
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BFY = '{GridFilter1}' AND FundName = '{GridFilter2}' AND BocName = '{GridFilter3}'";
                DataTable table = ((DataTable)BindingSource.DataSource).AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Where(p => p.Field<string>("FundName").Equals(GridFilter2)).Where(p => p.Field<string>("BocName").Equals(GridFilter3)).Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");

                if (int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if (int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

                GridGroupBox.Text = $"{Source.ToString()} {GridFilter2} {GridFilter1} {GridFilter3} ";
                TransitionChart(table);
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGridBoc(VisualRadioButton rb)
        {
            try
            {
                string level = rb.Tag.ToString();
                Grid.SelectionChanged -= UpdateAccountChart;
                BindingSource.Filter = $"BFY = '{GridFilter1}' AND BudgetLevel = '{level}' AND FundName = '{GridFilter2}' AND BocName = '{GridFilter3}'";
                DataTable table = ((DataTable)BindingSource.DataSource).AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Where(p => p.Field<string>("BudgetLevel").Equals(level)).Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Where(p => p.Field<string>("FundName").Equals(GridFilter2)).Where(p => p.Field<string>("BocName").Equals(GridFilter3)).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                if (int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double)table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double)table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if (int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

                TransitionChart(table);
                GridGroupBox.Text = $"{Source.ToString()} Level-{level} {GridFilter1} {GridFilter2} {GridFilter3}";
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The GridFilterControl1_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                BindingSource.DataSource = Table;
                GridFilterControl1 = sender as VisualComboBox;
                GridFilter1 = GridFilterControl1?.SelectedItem.ToString();
                if (GridLevel7.Checked)
                {
                    FilterDataGridYear(GridLevel7);
                }

                if (GridLevel8.Checked)
                {
                    FilterDataGridYear(GridLevel8);
                }
                else
                {
                    FilterDataGridYear();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The GridFilterControl2_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void GridFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (GridBocFilter.Items.Count > 0)
                {
                    GridBocFilter.Items.Clear();
                }

                GridFilterControl2 = sender as VisualComboBox;
                GridFilter2 = GridFilterControl2?.SelectedItem.ToString();
                if (GridLevel7.Checked)
                {
                    FilterDataGridFund(GridLevel7);
                }

                if (GridLevel8.Checked)
                {
                    FilterDataGridFund(GridLevel8);
                }
                else
                {
                    FilterDataGridFund();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The GridFilterControl3_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void GridFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridFilterControl3 = sender as VisualComboBox;
                GridFilter3 = GridFilterControl3?.SelectedItem.ToString();
                if (GridLevel7.Checked)
                {
                    FilterDataGridBoc(GridLevel7);
                }

                if (GridLevel8.Checked)
                {
                    FilterDataGridBoc(GridLevel8);
                }
                else
                {
                    FilterDataGridBoc();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateGridFundFilterItems
        /// </summary>
        internal void PopulateGridFundFilterItems()
        {
            try
            {
                GridFundFilter.Items.Clear();
                DataTable table = (DataTable)BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Select(p => p).CopyToDataTable();
                foreach (string row in query.AsEnumerable().Select(p => p.Field<string>("FundName")).Distinct().ToArray())
                {
                    GridFundFilter.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateGridBocFilterItems
        /// </summary>
        internal void PopulateGridBocFilterItems()
        {
            try
            {
                GridBocFilter.Items.Clear();
                DataTable table = (DataTable)BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Where(p => p.Field<string>("FundName").Equals(GridFilter2)).Select(p => p).CopyToDataTable();
                foreach (string row in query.AsEnumerable().Select(p => p.Field<string>("BocName")).Distinct().ToArray())
                {
                    GridBocFilter.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateGridYearFilterItems
        /// </summary>
        internal void PopulateGridYearFilterItems()
        {
            try
            {
                GridYearFilter.Items.Clear();
                string[] query = Table.AsEnumerable().Select(p => p.Field<string>("BFY")).Distinct().ToArray();
                foreach (string row in query)
                {
                    GridYearFilter.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateFilterBoxItems
        /// </summary>
        /// <param name="cmbox">The cmbox<see cref="VisualComboBox" /></param>
        /// <param name="col">The col<see cref="Field" /></param>
        /// <param name="prcfilter">The prcfilter<see cref="string" /></param>
        internal void PopulateFilterBoxItems(VisualComboBox cmbox, Field col, string prcfilter)
        {
            try
            {
                if (cmbox.Items.Count > 0)
                {
                    cmbox.Items.Clear();
                }

                DataTable table = (DataTable)BindingSource.DataSource;
                foreach (DataRow row in table.AsEnumerable()
                                             .Where(p => p.Field<string>(col.ToString()).Equals(prcfilter))
                                             .Select(p => p).Distinct().ToArray())
                {
                    cmbox.Items.Add(row["FundName"].ToString());
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateFilterBoxItems
        /// </summary>
        /// <param name="cmbox">The cmbox<see cref="VisualComboBox" /></param>
        /// <param name="names">
        ///     The names
        ///     <see>
        ///         <cref>string[]</cref>
        ///     </see>
        /// </param>
        internal void PopulateFilterBoxItems(VisualComboBox cmbox, string[] names)
        {
            try
            {
                cmbox.Items.Clear();
                foreach (string t in names)
                {
                    cmbox.Items.Add(t);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The DefineVisisbleDataColumns
        /// </summary>
        /// <param name="dgv">The dgv<see cref="DataGridView" /></param>
        private void DefineVisisbleDataColumns(DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewColumn dc in dgv.Columns)
                {
                    dc.Visible = false;
                }

                // dgv.Columns[0].Visible = true;
                dgv.Columns[1].Visible = true;

                // dgv.Columns[2].Visible = true;
                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;

                // dgv.Columns[5].Visible = true;
                dgv.Columns[6].Visible = true;

                // dgv.Columns[7].Visible = true;
                dgv.Columns[8].Visible = true;

                // dgv.Columns[9].Visible = true;
                dgv.Columns[10].Visible = true;

                // dgv.Columns[11].Visible = true;
                // dgv.Columns[12].Visible = true;
                dgv.Columns[13].Visible = true;
                dgv.Columns[14].Visible = true;
                dgv.Columns[14].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PopulateComboBoxes
        /// </summary>
        internal void PopulateAddTabComboBoxes()
        {
            DataTable table = new DataBuilder(Source.PRC).Table;
            string[] query = table.AsEnumerable().Select(p => p.Field<string>("SubProject")).Distinct().ToArray();
            foreach (string row in query)
            {
                AddSub.Items.Add(row);
            }

            string[] year = table.AsEnumerable().Select(p => p.Field<string>("BFY")).Distinct().ToArray();
            foreach (string s in year)
            {
                AddYear.Items.Add(s);
            }

            string[] code = table.AsEnumerable().Select(p => p.Field<string>("Code")).Distinct().ToArray();
            foreach (string c in code)
            {
                AddCode.Items.Add(c);
            }

            string[] fund = table.AsEnumerable().Select(p => p.Field<string>("Fund")).Distinct().ToArray();
            foreach (string f in fund)
            {
                AddFund.Items.Add(f);
            }

            string[] rc = table.AsEnumerable().Select(p => p.Field<string>("RC")).Distinct().ToArray();
            foreach (string r in rc)
            {
                AddRc.Items.Add(r);
            }

            string[] bl = table.AsEnumerable().Select(p => p.Field<string>("BudgetLevel")).Distinct().ToArray();
            foreach (string r in bl)
            {
                AddLevel.Items.Add(r);
            }

            string[] org = table.AsEnumerable().Select(p => p.Field<string>("Org")).Distinct().ToArray();
            foreach (string oo in org)
            {
                AddOrg.Items.Add(oo);
            }

            string[] ah = table.AsEnumerable().Select(p => p.Field<string>("AH")).Distinct().ToArray();
            foreach (string a in ah)
            {
                AddAh.Items.Add(a);
            }

            string[] boc = table.AsEnumerable().Select(p => p.Field<string>("BOC")).Distinct().ToArray();
            foreach (string b in boc)
            {
                AddBoc.Items.Add(b);
            }
        }

        /// <summary>
        ///     The ConfigureTextBoxBindings
        /// </summary>
        private void ConfigureEditTabTextBoxBindings()
        {
            try
            {
                editID.DataBindings.Add(new Binding("Text", Grid.DataSource, "ID"));
                EditBudgetLevel.DataBindings.Add(new Binding("Text", Grid.DataSource, "BudgetLevel"));
                EditBFY.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                EditFund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                EditAH.DataBindings.Add(new Binding("Text", Grid.DataSource, "AH"));
                EditOrg.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                EditRC.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                EditCode.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                EditBOC.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                OriginalAmount.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The GridRefreshButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void GridRefreshButton_OnClick(object sender, EventArgs e)
        {
            if (DbData != null)
            {
                try
                {
                    BindingSource.Filter = null;
                    BindingSource.DataSource = Table;
                    lblCount.Text = DbData.Table.Rows.Count.ToString();
                    lblAve.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                    lblTotal.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                    GridBocFilter.Items.Clear();
                    GridYearFilter.Items.Clear();
                    GridFundFilter.Items.Clear();
                    GridFundFilter.Visible = false;
                    GridBocFilter.Visible = false;
                    GridYearFilter.Visible = true;
                    PopulateGridYearFilterItems();
                    GridGroupBox.Text = $"{Source.ToString()}";
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                }
            }
        }

        /// <summary>
        ///     The GetTabNames
        /// </summary>
        /// <returns>The <see /></returns>
        private string[] GetTabNames()
        {
            try
            {
                string[] names = new string[SummaryTabControl.TabPages.Count];
                TabPageAdvCollection tabs = SummaryTabControl.TabPages;
                for (int i = 0; i < SummaryTabControl.TabPages.Count; i++)
                {
                    names[i] = tabs[i].Text;
                }

                return names;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     The GetTabPageTags
        /// </summary>
        /// <returns>
        ///     The
        ///     <see>
        ///         <cref>string[]</cref>
        ///     </see>
        /// </returns>
        private string[] GetTabPageTags()
        {
            try
            {
                string[] filters = { "FundName", "BocName", "NPM", "GoalName", "ObjectiveName", "Division", "ProgramArea", "ProgramProjectCode" };

                return filters;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private void GetPrimarySummaryChart(Field field)
        {
            try
            {
                ChartMainTitle = new[] { $"{Source.ToString()} Resources By {field.ToString()} " };
                BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, field, Measure, ChartType).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetPrimaryGroupSummaryChart(Field field, string level)
        {
            try
            {
                Dictionary<string, object> fp = new Dictionary<string, object> { ["BudgetLevel"] = level };
                ChartMainTitle = new[] { $"{Source.ToString()} Level-{level} Resources By {field.ToString()} " };
                DataBuilder fd = new DataBuilder(Source, Provider, fp);
                BocChart = new BudgetChart(BocChart, ChartMainTitle, fd, field, Measure, ChartType).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetSecondaryGroupSummaryChart(Field field)
        {
            try
            {
                Dictionary<string, object> fp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                ChartMainTitle = new[] { $"{Source.ToString()} {ChartFilter} Resources By {field.ToString()} " };
                DataBuilder fd = new DataBuilder(Source, Provider, fp);
                BocChart = new BudgetChart(BocChart, ChartMainTitle, fd, field, Measure, ChartType).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetSecondaryGroupSummaryChart(Field field, string level)
        {
            try
            {
                Dictionary<string, object> fp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = ChartFilter, ["BudgetLevel"] = level };
                ChartMainTitle = new[] { $"{Source.ToString()} {ChartFilter} Level-{level} Resources By {field.ToString()} " };
                DataBuilder fd = new DataBuilder(Source, Provider, fp);
                BocChart = new BudgetChart(BocChart, ChartMainTitle, fd, field, Measure, ChartType).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The ChartFilterControl1_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ChartFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            ChartFilterControl1 = sender as VisualComboBox;
            ChartFilter = ChartFilterControl1?.SelectedItem.ToString();
            if (ChartFilterControl1 != null)
            {
                if (ChartFilter != null)
                {
                    ChartType = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ChartFilter);
                }
            }

            if (Expander2.Visible && Expander2.IsExpanded)
            {
                Expander2.IsExpanded = false;
            }
        }

        /// <summary>
        ///     The ChartFilterControl2_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl2 = sender as VisualComboBox;
                filter3label.Text = $"Filter {PrimaryGrouping.ToString()} By";
                if (ChartFilterControl2 != null && ChartFilterControl2.SelectedItem != null)
                {
                    Measure = (Stat)Enum.Parse(typeof(Stat), ChartFilterControl2.SelectedItem.ToString());
                }

                if (!Expander2.Visible || Expander2.IsExpanded == false)
                {
                    Expander2.Visible = true;
                    Expander2.IsExpanded = true;
                }

                if (ChartLevel7.Checked)
                {
                    GetPrimaryGroupSummaryChart(PrimaryGrouping, ChartLevel7.Tag.ToString());
                }

                if (ChartLevel8.Checked)
                {
                    GetPrimaryGroupSummaryChart(PrimaryGrouping, ChartLevel8.Tag.ToString());
                }
                else
                {
                    GetPrimarySummaryChart(PrimaryGrouping);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The ChartFilterControl3_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ChartFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl3 = sender as VisualComboBox;
                if (ChartFilterControl3?.SelectedItem != null)
                {
                    ChartFilter = ChartFilterControl3?.SelectedItem.ToString();
                }

                BocFilter4.Items.Clear();
                string[] filters = { "FundName", "BocName", "NPM", "GoalName", "ObjectiveName", "Division", "ProgramArea", "ProgramProjectCode" };

                if(filters.Contains(ChartFilter))
                {
                    var filt = filters.Where(s => !s.Equals(ChartFilter))
                                      .Select(s => s).ToArray();
                    foreach(string s in filt)
                    {
                        BocFilter4.Items.Add(s);
                    }
                }
                else
                {
                    foreach(string s in filters)
                    {
                        BocFilter4.Items.Add(s);
                    }

                    BocFilter4.Items.Remove(PrimaryFilter.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The ChartFilterControl4_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ChartFilterControl4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl4 = sender as VisualComboBox;
                if (ChartFilterControl4 != null)
                {
                    SecondaryGrouping = (Field)Enum.Parse(typeof(Field), ChartFilterControl4.SelectedItem.ToString());
                }

                switch (SecondaryGrouping)
                {
                    case Field.FundName:
                    case Field.BocName:
                    case Field.NPM:
                    case Field.GoalName:
                    case Field.ObjectiveName:
                    case Field.Division:
                    case Field.ProgramArea:
                    case Field.ProgramProjectCode:
                        if (ChartLevel7.Checked)
                        {
                            GetSecondaryGroupSummaryChart(SecondaryGrouping, ChartLevel7.Tag.ToString());
                        }

                        if (ChartLevel8.Checked)
                        {
                            GetSecondaryGroupSummaryChart(SecondaryGrouping, ChartLevel8.Tag.ToString());
                        }
                        else
                        {
                            GetSecondaryGroupSummaryChart(SecondaryGrouping);
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The AssignChartFilterControls
        /// </summary>
        /// <param name="filter1">The filter1<see cref="VisualComboBox" /></param>
        /// <param name="filter2">The filter2<see cref="VisualComboBox" /></param>
        /// <param name="filter3">The filter3<see cref="VisualComboBox" /></param>
        /// <param name="filter4">The filter4<see cref="VisualComboBox" /></param>
        private void AssignChartFilterControls(VisualComboBox filter1, VisualComboBox filter2, VisualComboBox filter3, VisualComboBox filter4)
        {
            ChartFilterControl1 = filter1;
            ChartFilterControl2 = filter2;
            ChartFilterControl3 = filter3;
            ChartFilterControl4 = filter4;
        }

        /// <summary>
        ///     The AssignChartExpanders
        /// </summary>
        /// <param name="panel1">The panel1<see cref="ExpandCollapsePanel" /></param>
        /// <param name="panel2">The panel2<see cref="ExpandCollapsePanel" /></param>
        private void AssignChartExpanders(ExpandCollapsePanel panel1, ExpandCollapsePanel panel2)
        {
            try
            {
                Expander1 = panel1;
                Expander2 = panel2;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PrimaryFilterControl_ItemSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        internal void PrimaryChartFilterControl_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                PrimaryFilter = sender as VisualComboBox;
                PrimaryGrouping = (Field)Enum.Parse(typeof(Field), PrimaryFilter?.SelectedItem.ToString());
                if (BocExpander1.Visible == false || BocExpander1.IsExpanded == false)
                {
                    BocExpander1.Visible = true;
                    BocExpander1.IsExpanded = true;
                }

                AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                AssignChartExpanders(BocExpander1, BocExpander2);
                PopulateFilterBoxItems(BocFilter3, ProgramElements[PrimaryGrouping.ToString()]);
                PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                BocFilter4.Items.Remove(PrimaryGrouping.ToString());
                if (Source == Source.RegionalAccounts)
                {
                    BocFilter4.Items.Remove("RC");
                }

                if (Division != null)
                {
                    ChartMainTitle = new[] { $"{Division} Funding By Appropriation" };
                }
                else
                {
                    ChartMainTitle = new[] { $"{Source.ToString()} Funding By {PrimaryGrouping}" };
                }

                BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, PrimaryGrouping, Stat.Total, ChartSeriesType.Column).Activate();                      
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The SummaryTabPage_TabSelected
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        internal void SummaryTabPage_TabSelected(object sender, EventArgs e)
        {
            try
            {
                SummaryTabControl = sender as TabControlAdv;
                if (SummaryTabControl != null)
                {
                    CurrentIndex = SummaryTabControl.SelectedIndex;
                }

                switch (CurrentIndex)
                {
                    case 0:
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["BocName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("BocName");
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
                        }

                        if (Division != null)
                        {
                            ChartMainTitle = new[] { $"{Division} Funding By Object Class" };
                        }
                        else
                        {
                            ChartMainTitle = new[] { $"{Source.ToString()} Funding By Object Class" };
                        }

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.BocName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 1:
                        DataTable table = DbData.Table.AsEnumerable().Select(p => p).CopyToDataTable();
                        lblCount.Text = table.Rows.Count.ToString();
                        lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                        lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                        GridGroupBox.Text = $"{Source.ToString()}";
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The GetTitle
        /// </summary>
        /// <param name="filter1">The filter1<see cref="VisualComboBox" /></param>
        /// <param name="filter2">The filter2<see cref="VisualComboBox" /></param>
        /// <param name="filter3">The filter3<see cref="VisualComboBox" /></param>
        /// <returns>The <see cref="string[]" /></returns>
        private string[] GetTitle(VisualComboBox filter1, VisualComboBox filter2, VisualComboBox filter3)
        {
            try
            {
                string source = filter2.SelectedItem.ToString();
                int index = filter1.SelectedIndex;
                string grouping = filter3.SelectedItem.ToString();
                switch (index)
                {
                    case 0:
                        return new[] { $"Total {source} Funding by {grouping}" };

                    case 1:
                        return new[] { $"{source}  Accounts by {grouping}" };

                    case 2:
                        return new[] { $"Average {source} Funding by {grouping}" };

                    case 3:
                        return new[] { $"{source} Funding Percentage by {grouping}" };
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     The GetSelectedRowPrcDictionary
        /// </summary>
        /// <returns>The <see cref="Dictionary{string, object}" /></returns>
        private Dictionary<string, object> GetSelectedRowPrcDictionary()
        {
            try
            {
                if (Grid.CurrentRow != null)
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();

                    // data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
                    // data.Add("Fund", dgvRow.Cells["Fund"].Value.ToString());
                    // data.Add("AH", dgvRow.Cells["AH"].Value.ToString());
                    // data.Add("Org", dgvRow.Cells["Org"].Value.ToString());
                    // data.Add("RC", dgvRow.Cells["RC"].ToString());
                    // data.Add("Code", dgvRow.Cells["Code"].ToString());
                    // data.Add("BOC", dgvRow.Cells["BOC"].ToString());
                    return data;
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     The CalculatorButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.Show();
        }

        /// <summary>
        ///     The ExcelButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ExcelButton_Click(object sender, EventArgs e)
        {
            ExcelDocument er = new ExcelDocument();
        }

        /// <summary>
        ///     The AddButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountTabControl.SelectedTab = AddTab;
                if (AddTab.Visible == false)
                {
                    AddTab.Visible = true;
                }

                if (GraphTab.Visible)
                {
                    GraphTab.Visible = false;
                }

                if (EditTab.Visible)
                {
                    EditTab.Visible = false;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The EditButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void EditButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountTabControl.SelectedTab = EditTab;
                if (EditTab.Visible == false)
                {
                    EditTab.Visible = true;
                }

                if (AddTab.Visible)
                {
                    AddTab.Visible = false;
                }

                if (GraphTab.Visible)
                {
                    GraphTab.Visible = false;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The Grid_OnDoubleClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void Grid_OnDoubleClick(object sender, EventArgs e)
        {
            try
            {
                AccountTabControl.SelectedTab = EditTab;
                if (EditTab.Visible == false)
                {
                    EditTab.Visible = true;
                }

                if (AddTab.Visible)
                {
                    AddTab.Visible = false;
                }

                if (GraphTab.Visible)
                {
                    GraphTab.Visible = false;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The ReprogramButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void ReprogramButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rp = new Reprogramming();
            rp.Show();
        }

        /// <summary>
        ///     The UpdateAccountChart
        /// </summary>
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        internal void UpdateAccountChart(object sender, EventArgs e)
        {
            try
            {
                Grid = sender as DataGridView;
                DataGridViewRow drv = Grid?.CurrentRow;
                if (GridLevel7.Checked)
                {
                    decimal total = Table.AsEnumerable().Where(p => p.Field<string>("BudgetLevel").Equals(GridLevel7.Tag.ToString())).Where(p => p.Field<string>("BFY").Equals(drv?.Cells["BFY"].Value.ToString())).Where(p => p.Field<string>("Code").Contains(drv?.Cells["Code"].Value.ToString())).Select(p => p.Field<decimal>("Amount")).Sum();
                    decimal ratio = (decimal)drv.Cells["Amount"].Value / total;
                    Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)(decimal)drv.Cells["Amount"].Value };
                    ChartMainTitle = new[] { $"{ratio.ToString("P")} {Source.ToString()} PRC {drv.Cells["Code"].Value} Funding" };
                    AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                }

                if (GridLevel8.Checked)
                {
                    decimal total = Table.AsEnumerable().Where(p => p.Field<string>("BudgetLevel").Equals(GridLevel8.Tag.ToString())).Where(p => p.Field<string>("BFY").Equals(drv?.Cells["BFY"].Value.ToString())).Where(p => p.Field<string>("Code").Contains(drv?.Cells["Code"].Value.ToString())).Select(p => p.Field<decimal>("Amount")).Sum();
                    decimal ratio = (decimal)drv.Cells["Amount"].Value / total;
                    Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)(decimal)drv.Cells["Amount"].Value };
                    ChartMainTitle = new[] { $"{ratio.ToString("P")} {Source.ToString()} PRC {drv.Cells["Code"].Value} Funding" };
                    AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                }
                else
                {
                    decimal total = Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(drv?.Cells["BFY"].Value.ToString())).Where(p => p.Field<string>("Code").Contains(drv?.Cells["Code"].Value.ToString())).Select(p => p.Field<decimal>("Amount")).Sum();
                    decimal ratio = (decimal)drv.Cells["Amount"].Value / total;
                    Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)(decimal)drv.Cells["Amount"].Value };
                    ChartMainTitle = new[] { $"{ratio.ToString("P")} {Source.ToString()} PRC {drv.Cells["Code"].Value} Funding" };
                    AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        internal void TransitionChart(DataTable table)
        {
            try
            {
                DataRow row = table?.Rows[0];
                decimal total = table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(row?["BFY"].ToString())).Where(p => p.Field<string>("Code").Contains(row?["Code"].ToString())).Select(p => p.Field<decimal>("Amount")).Sum();
                decimal ratio = decimal.Parse(row?["Amount"].ToString()) / total;
                Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)decimal.Parse(row?["Amount"].ToString()) };
                ChartMainTitle = new[] { $"{ratio.ToString("P")} {Source.ToString()} PRC {row?["Code"]} Funding" };
                AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The AccountChart_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void AccountChartButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountTabControl.SelectedTab = GraphTab;
                GraphTab.Visible = true;
                EditTab.Visible = false;
                AddTab.Visible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     The PreviousButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        /// <summary>
        ///     The NextButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        /// <summary>
        ///     The DatabaseSearchButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void DatabaseSearchButton_OnClick(object sender, EventArgs e)
        {
            SQLiteData sd = new SQLiteData(Source.PRC);
            sd.Show();
            Close();
        }

        /// <summary>
        ///     The GetCaption
        /// </summary>
        private void GetCaption()
        {
            try
            {
                Directory.GetFiles(Info.DivisionImages);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
