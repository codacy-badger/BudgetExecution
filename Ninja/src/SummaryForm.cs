// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SummaryForm.cs" company="">
//   
// </copyright>
// <summary>
//   The summary form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using MakarovDev.ExpandCollapsePanel;

    using MetroSet_UI.Controls;

    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// The summary form.
    /// </summary>
    public partial class SummaryForm : MetroForm
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryForm"/> class.
        /// </summary>
        public SummaryForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryForm"/> class.
        /// </summary>
        /// <param name="rc">
        /// The rc.
        /// </param>
        public SummaryForm(string rc)
        {
            this.InitializeComponent();
            this.Division = rc;
            this.Source = Source.DivisionAccounts;
            this.Provider = Provider.SQLite;
            this.Parameter = new Dictionary<string, object> { ["RC"] = rc };
            this.DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, this.Parameter);
            this.Table = this.DbData.DbTable;
            this.DatabaseTab.TabVisible = true;
            this.ProjectTab.TabVisible = true;
            this.DivisionTab.TabVisible = false;
            this.ProgramElements = this.DbData.ProgramElements;
            this.Metric = new PrcMetric(this.DbData);
            this.Text = string.Format("{0} Summary", Info.DivisionName(rc));
            this.CurrentTabIndex = this.SummaryTabControl.SelectedIndex;
            this.SummaryTabControl.SelectedIndexChanged += this.SummaryTabPage_TabSelected;
            this.CurrentTabIndex = 1;
            this.TabNames = this.GetTabNames();
            this.UpdateTab.TabVisible = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryForm"/> class.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        public SummaryForm(Source source)
        {
            this.InitializeComponent();
            this.DbData = new DataBuilder(source, Provider.SQLite);
            this.Table = this.DbData.DbTable;
            this.Source = source;
            this.Provider = Provider.SQLite;
            this.CurrentTabIndex = 0;
            this.TabNames = this.GetTabNames();
            this.Text = $@"R6 {this.Source.ToString()} Summary";
            this.Metric = new PrcMetric(this.DbData);
            this.ProgramElements = this.Metric.ProgramElements;
            this.BindingSource.DataSource = this.Metric.Table;
            this.ProjectTab.TabVisible = true;
            this.DatabaseTab.TabVisible = true;
            this.CurrentTabIndex = this.SummaryTabControl.SelectedIndex;
            this.SummaryTabControl.SelectedIndexChanged += this.SummaryTabPage_TabSelected;
            if (source == Source.RegionalAccounts || source == Source.DivisionAccounts)
            {
                this.DbData = new DataBuilder(source, Provider.SQLite);
                this.Table = this.DbData.DbTable;
                this.Source = source;
                this.CurrentTabIndex = 1;
                this.TabNames = this.GetTabNames();
                this.Text = @"R6 Summary";
                this.Metric = new PrcMetric(this.DbData);
                this.ProgramElements = this.Metric.ProgramElements;
                this.BindingSource.DataSource = this.Metric.Table;
                this.ProjectTab.TabVisible = false;
                this.DatabaseTab.TabVisible = false;
                this.CurrentTabIndex = this.SummaryTabControl.SelectedIndex;
                this.SummaryTabControl.SelectedIndexChanged += this.SummaryTabPage_TabSelected;
            }

            this.UpdateTab.TabVisible = false;
        }

        // PROPERTIES
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// Gets or sets the parameter.
        /// </summary>
        public Dictionary<string, object> Parameter { get; set; }

        /// <summary>
        /// Gets the db data.
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the db row.
        /// </summary>
        public DataRow DbRow { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        public PrcMetric Metric { get; set; }

        /// <summary>
        /// Gets or sets the chart type.
        /// </summary>
        public ChartSeriesType ChartType { get; set; }

        /// <summary>
        /// Gets or sets the chart field.
        /// </summary>
        public Field ChartField { get; set; }

        /// <summary>
        /// Gets or sets the chart filter.
        /// </summary>
        public string ChartFilter { get; set; }

        /// <summary>
        /// Gets or sets the division.
        /// </summary>
        public string Division { get; set; }

        /// <summary>
        /// Gets or sets the chart group.
        /// </summary>
        public Field ChartGroup { get; set; }

        /// <summary>
        /// Gets the program elements.
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; }

        /// <summary>
        /// Gets or sets the chart main title.
        /// </summary>
        public string[] ChartMainTitle { get; set; }

        /// <summary>
        /// Gets or sets the chart axis title.
        /// </summary>
        public string[] ChartAxisTitle { get; set; }

        /// <summary>
        /// Gets or sets the current tab index.
        /// </summary>
        public int CurrentTabIndex { get; set; }

        /// <summary>
        /// Gets or sets the grid filter control 1.
        /// </summary>
        public MetroSetComboBox GridFilterControl1 { get; set; }

        /// <summary>
        /// Gets or sets the grid filter control 2.
        /// </summary>
        public MetroSetComboBox GridFilterControl2 { get; set; }

        /// <summary>
        /// Gets or sets the grid filter control 3.
        /// </summary>
        public MetroSetComboBox GridFilterControl3 { get; set; }

        /// <summary>
        /// Gets or sets the chart filter control 1.
        /// </summary>
        public MetroSetComboBox ChartFilterControl1 { get; set; }

        /// <summary>
        /// Gets or sets the chart filter control 2.
        /// </summary>
        public MetroSetComboBox ChartFilterControl2 { get; set; }

        /// <summary>
        /// Gets or sets the chart filter control 3.
        /// </summary>
        public MetroSetComboBox ChartFilterControl3 { get; set; }

        /// <summary>
        /// Gets or sets the chart filter control 4.
        /// </summary>
        public MetroSetComboBox ChartFilterControl4 { get; set; }

        /// <summary>
        /// Gets or sets the expander 1.
        /// </summary>
        public ExpandCollapsePanel Expander1 { get; set; }

        /// <summary>
        /// Gets or sets the expander 2.
        /// </summary>
        public ExpandCollapsePanel Expander2 { get; set; }

        /// <summary>
        /// Gets or sets the measure.
        /// </summary>
        public Stat Measure { get; set; }

        /// <summary>
        /// Gets or sets the tab.
        /// </summary>
        private TabPageAdv[] Tab { get; set; }

        /// <summary>
        /// Gets the tab names.
        /// </summary>
        private string[] TabNames { get; }

        // METHODS
        /// <summary>
        /// The form_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DbData.Source == Source.FTE)
                {
                    this.BocTab.TabVisible = false;
                }

                if (this.DbData.Source == Source.RegionalAccounts)
                {
                    this.DivisionTab.TabVisible = false;
                    this.DatabaseTab.TabVisible = false;
                    this.ProjectTab.TabVisible = false;
                }

                this.BindingSource.DataSource = this.Table;
                this.AccountNavigator.BindingSource = this.BindingSource;
                this.Grid.DataSource = this.BindingSource;
                this.DefineVisisbleDataColumns(this.Grid);
                this.PopulateFilterBoxItems(this.GridFundFilter, Field.FundName);
                this.ConfigureTextBoxBindings();
                this.label32.Text = this.DbData.GetTotal(this.DbData.DbTable).ToString("c");
                this.label41.Text = this.DbData.GetCount(this.DbData.DbTable).ToString();
                this.GridFundFilter.SelectionChangeCommitted += this.GridFilterControl1_ItemSelected;
                this.GridBocFilter.SelectionChangeCommitted += this.GridFilterControl2_ItemSelected;
                this.SummaryTabControl.SelectedIndexChanged += this.SummaryTabPage_TabSelected;
                this.FundChart = new BudgetChart(this.FundChart, this.DbData, Field.FundName).Activate();
                this.lblPrc.Visible = false;
                this.GridAccountFilter.Visible = false;
                this.lblBoc.Visible = false;
                this.GridBocFilter.Visible = false;
                this.GridRefreshButton.Click += this.GridRefreshButton_OnClick;
                this.ExcelButton.Click += this.ExcelButton_Click;
                this.CalendatButton.Click += this.CalendatButton_Click;
                this.CalculatorButton.Click += this.CalculatorButton_Click;
                this.Grid.SelectionChanged += this.UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The grid filter control 1_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                MetroSetComboBox filter = sender as MetroSetComboBox;
                this.GridFundFilter.Tag = filter.SelectedItem.ToString();
                string fund = filter.SelectedItem.ToString();
                this.BindingSource.Filter = string.Format("FundName = '{0}'", this.GridFundFilter.SelectedItem);
                this.label41.Text = this.GetCount(fund).ToString();
                this.label37.Text = this.CalculateAverage(this.GridFundFilter.SelectedItem.ToString()).ToString("c");
                this.label32.Text = this.CalculateTotal(fund).ToString("c");
                this.PopulateGridBocFilterItems();
                this.lblBoc.Visible = true;
                this.GridBocFilter.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The grid filter control 2_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GridFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                MetroSetComboBox boc = sender as MetroSetComboBox;
                string filter = boc.SelectedItem.ToString();
                this.BindingSource.Filter =
                    $"FundName = '{this.GridFundFilter.SelectedItem}' AND BocName = '{this.GridBocFilter.SelectedItem}'";
                this.label32.Text = this.CalculateTotal(this.GridFundFilter.SelectedItem.ToString(), filter)
                                        .ToString("c");
                this.label37.Text = this.CalculateAverage(this.GridFundFilter.SelectedItem.ToString(), filter)
                                        .ToString("c");
                this.label41.Text = this.GetCount(this.GridFundFilter.SelectedItem.ToString(), filter).ToString();
                this.GridAccountFilter.Visible = true;
                this.lblPrc.Visible = true;
                this.GridAccountFilter.Visible = true;
                this.PopulateGridAccountFilterItems();
                this.GridAccountFilter.SelectionChangeCommitted += this.GridFilterControl3_ItemSelected;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The grid filter control 3_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GridFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                MetroSetComboBox prc = sender as MetroSetComboBox;
                string filter = prc.SelectedItem.ToString();
                this.BindingSource.Filter =
                    $"FundName = '{this.GridFundFilter.SelectedItem}' AND BocName = '{this.GridBocFilter.SelectedItem}' AND Code = '{filter}'";
                this.label32.Text = this.CalculateTotal(this.GridFundFilter.SelectedItem.ToString(), filter)
                                        .ToString("c");
                this.label41.Text = this.GetCount(this.GridFundFilter.SelectedItem.ToString(), filter).ToString();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The filter data grid.
        /// </summary>
        private void FilterDataGrid()
        {
            try
            {
                if (this.GridFundFilter.SelectedItem.ToString() != null)
                {
                    this.BindingSource.Filter = string.Format(
                        "FundName = '{0}' AND BocName = '{1}'",
                        this.GridFundFilter.SelectedItem,
                        this.GridBocFilter.SelectedItem);
                }

                this.BindingSource.Filter = string.Format("FundName = '{0}'", this.GridBocFilter.SelectedItem);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The populate grid boc filter items.
        /// </summary>
        private void PopulateGridBocFilterItems()
        {
            try
            {
                this.GridBocFilter.Items.Clear();
                this.GridBocFilter.Visible = true;
                DataTable table = (DataTable)this.BindingSource.DataSource;
                DataTable query = table.AsEnumerable()
                                       .Where(
                                           p => p.Field<string>("FundName").Equals(
                                               this.GridFundFilter.SelectedItem.ToString())).Select(p => p)
                                       .Distinct().CopyToDataTable();
                foreach (string row in query.AsEnumerable().Select(p => p.Field<string>("BocName")).Distinct()
                                            .ToArray())
                {
                    this.GridBocFilter.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The populate grid account filter items.
        /// </summary>
        private void PopulateGridAccountFilterItems()
        {
            try
            {
                this.GridAccountFilter.Items.Clear();
                DataTable table = (DataTable)this.BindingSource.DataSource;
                DataTable query = table.AsEnumerable()
                                       .Where(
                                           p => p.Field<string>("FundName").Equals(
                                               this.GridFundFilter.SelectedItem.ToString()))
                                       .Where(
                                           p => p.Field<string>("BocName")
                                                 .Equals(this.GridBocFilter.SelectedItem.ToString())).Select(p => p)
                                       .CopyToDataTable();
                foreach (DataRow row in query.Rows)
                {
                    this.GridAccountFilter.Items.Add(row["Code"].ToString());
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The get count.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal GetCount(string filter)
        {
            try
            {
                return this.DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter))
                           .Select(p => p.Field<decimal>("Amount") > 0).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The get count.
        /// </summary>
        /// <param name="filter1">
        /// The filter 1.
        /// </param>
        /// <param name="filter2">
        /// The filter 2.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal GetCount(string filter1, string filter2)
        {
            try
            {
                return this.DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                           .Where(p => p.Field<string>("BocName").Equals(filter2))
                           .Select(p => p.Field<decimal>("Amount")).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The populate filter box items.
        /// </summary>
        /// <param name="cmbox">
        /// The cmbox.
        /// </param>
        /// <param name="prcfilter">
        /// The prcfilter.
        /// </param>
        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, Field prcfilter)
        {
            try
            {
                if (cmbox.Items.Count > 0)
                {
                    cmbox.Items.Clear();
                }

                string[] items = this.DbData.ProgramElements[prcfilter.ToString()];
                foreach (string i in items)
                {
                    cmbox.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The populate filter box items.
        /// </summary>
        /// <param name="cmbox">
        /// The cmbox.
        /// </param>
        /// <param name="i">
        /// The i.
        /// </param>
        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, int i)
        {
            try
            {
                foreach (string t in this.TabNames)
                {
                    cmbox.Items.Clear();
                    cmbox.Items.Add(t);
                    cmbox.Items.Remove(this.SummaryTabControl.TabPages[i].Text);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The define visisble data columns.
        /// </summary>
        /// <param name="dgv">
        /// The dgv.
        /// </param>
        private void DefineVisisbleDataColumns(DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewColumn dc in dgv.Columns)
                {
                    dc.Visible = false;
                }

                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;
                dgv.Columns[6].Visible = true;
                dgv.Columns[8].Visible = true;
                dgv.Columns[9].Visible = true;
                dgv.Columns[11].Visible = true;
                dgv.Columns[12].Visible = true;
                dgv.Columns[12].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The configure grid filter buttons.
        /// </summary>
        /// <param name="panel">
        /// The panel.
        /// </param>
        /// <param name="list">
        /// The list.
        /// </param>
        private void ConfigureGridFilterButtons(FlowLayoutPanel panel, string[] list)
        {
            try
            {
                panel.Controls.Clear();
                foreach (string f in list)
                {
                    MetroSetButton b = new MetroSetButton();
                    b.Text = f;
                    b.Font = new Font("Segoe UI", 8f);
                    b.NormalColor = Color.Black;
                    b.NormalTextColor = SystemColors.MenuHighlight;
                    b.NormalBorderColor = Color.Black;
                    b.HoverBorderColor = Color.SteelBlue;
                    b.HoverColor = Color.SteelBlue;
                    b.HoverTextColor = Color.AntiqueWhite;
                    b.Size = new Size(150, 30);
                    b.Margin = new Padding(3);
                    b.Padding = new Padding(1);
                    panel.Controls.Add(b);
                    panel.AutoSize = true;
                    b.Tag = f;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The configure text box bindings.
        /// </summary>
        private void ConfigureTextBoxBindings()
        {
            try
            {
                this.ID.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "ID"));
                this.BudgetLevel.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "BudgetLevel"));
                this.BFY.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "BFY"));
                this.Fund.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "Fund"));
                this.Org.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "Org"));
                this.RC.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "RC"));
                this.Code.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "Code"));
                this.BOC.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "BOC"));
                this.Amount.DataBindings.Add(new Binding("Text", this.Grid.DataSource, "Amount"));
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The calculate average.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal CalculateAverage(string filter)
        {
            try
            {
                return this.DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter))
                           .Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The calculate average.
        /// </summary>
        /// <param name="filter1">
        /// The filter 1.
        /// </param>
        /// <param name="filter2">
        /// The filter 2.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal CalculateAverage(string filter1, string filter2)
        {
            try
            {
                return this.Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                           .Where(p => p.Field<string>("BocName").Equals(filter2))
                           .Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The calculate total.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal CalculateTotal(string filter)
        {
            try
            {
                return this.DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter))
                           .Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The calculate total.
        /// </summary>
        /// <param name="filter1">
        /// The filter 1.
        /// </param>
        /// <param name="filter2">
        /// The filter 2.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal CalculateTotal(string filter1, string filter2)
        {
            try
            {
                return this.Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                           .Where(p => p.Field<string>("BocName").Equals(filter2))
                           .Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The grid refresh button_ on click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GridRefreshButton_OnClick(object sender, EventArgs e)
        {
            if (this.DbData != null)
            {
                try
                {
                    this.BindingSource.Filter = null;
                    this.AccountNavigator.BindingSource = this.BindingSource;
                    this.Grid.DataSource = this.BindingSource;
                    this.label32.Text = this.DbData.GetTotal(this.DbData.DbTable).ToString("c");
                    this.label41.Text = this.DbData.GetCount(this.DbData.DbTable).ToString();
                    this.GridBocFilter.Items.Clear();
                    this.GridAccountFilter.Items.Clear();
                    this.PopulateFilterBoxItems(this.GridFundFilter, Field.FundName);
                    this.lblBoc.Visible = false;
                    this.GridBocFilter.Visible = false;
                    this.lblPrc.Visible = false;
                    this.GridAccountFilter.Visible = false;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                }
            }
        }

        /// <summary>
        /// The get tab names.
        /// </summary>
        /// <returns>
        /// The <see cref="string[]"/>.
        /// </returns>
        private string[] GetTabNames()
        {
            try
            {
                string[] names = new string[this.SummaryTabControl.TabPages.Count];
                TabPageAdvCollection tabs = this.SummaryTabControl.TabPages;
                for (int i = 0; i < this.SummaryTabControl.TabPages.Count; i++)
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
        /// The get chart type.
        /// </summary>
        /// <param name="ctb">
        /// The ctb.
        /// </param>
        /// <returns>
        /// The <see cref="ChartSeriesType"/>.
        /// </returns>
        private ChartSeriesType GetChartType(MetroSetComboBox ctb)
        {
            if (ctb.SelectedItem == null)
            {
                return ChartSeriesType.Column;
            }

            return (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ctb.SelectedItem.ToString());
        }

        /// <summary>
        /// The chart filter control 1_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ChartFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            this.ChartFilterControl1 = sender as MetroSetComboBox;
            this.ChartType = (ChartSeriesType)Enum.Parse(
                typeof(ChartSeriesType),
                this.ChartFilterControl1.SelectedItem.ToString());
            if (this.Expander2.IsExpanded)
            {
                this.Expander2.IsExpanded = false;
            }
        }

        /// <summary>
        /// The chart filter control 2_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                this.ChartFilterControl2 = sender as MetroSetComboBox;
                this.Measure = (Stat)Enum.Parse(typeof(Stat), this.ChartFilterControl2.SelectedItem.ToString());
                if (this.Expander2.IsExpanded == false)
                {
                    this.Expander2.IsExpanded = true;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The chart filter control 3_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ChartFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                this.ChartFilterControl3 = sender as MetroSetComboBox;
                this.ChartField = (Field)Enum.Parse(typeof(Field), this.ChartFilterControl3.Tag.ToString());
                this.ChartFilter = this.ChartFilterControl3.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The chart filter control 4_ item selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ChartFilterControl4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                this.ChartFilterControl4 = sender as MetroSetComboBox;
                this.ChartGroup = (Field)Enum.Parse(typeof(Field), this.ChartFilterControl4.SelectedItem.ToString());
                this.ChartMainTitle =
                    new[] { $"{this.ChartFilter} Funding By {this.ChartFilterControl4.SelectedItem}" };
                Dictionary<string, object> param =
                    new Dictionary<string, object> { [this.ChartField.ToString()] = this.ChartFilter };
                switch (this.CurrentTabIndex)
                {
                    case 0:
                        this.FundChart = new BudgetChart(
                            this.FundChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 1:
                        this.BocChart = new BudgetChart(
                            this.BocChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 2:
                        this.NpmChart = new BudgetChart(
                            this.NpmChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 3:
                        this.GoalChart = new BudgetChart(
                            this.GoalChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 4:
                        this.ObjectiveChart = new BudgetChart(
                            this.ObjectiveChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 5:
                        this.DivisionChart = new BudgetChart(
                            this.DivisionChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 6:
                        this.AreaChart = new BudgetChart(
                            this.AreaChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                    case 7:
                        this.ProjectChart = new BudgetChart(
                            this.ProjectChart,
                            this.ChartMainTitle,
                            this.Source,
                            param,
                            this.ChartGroup,
                            this.Measure,
                            this.ChartType).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The assign chart f ilter controls.
        /// </summary>
        /// <param name="filter1">
        /// The filter 1.
        /// </param>
        /// <param name="filter2">
        /// The filter 2.
        /// </param>
        /// <param name="filter3">
        /// The filter 3.
        /// </param>
        /// <param name="filter4">
        /// The filter 4.
        /// </param>
        private void AssignChartFIlterControls(
            MetroSetComboBox filter1,
            MetroSetComboBox filter2,
            MetroSetComboBox filter3,
            MetroSetComboBox filter4)
        {
            this.ChartFilterControl1 = filter1;
            this.ChartFilterControl1.SelectionChangeCommitted += this.ChartFilterControl1_ItemSelected;
            this.ChartFilterControl2 = filter2;
            this.ChartFilterControl2.SelectionChangeCommitted += this.ChartFilterControl2_ItemSelected;
            this.ChartFilterControl3 = filter3;
            this.ChartFilterControl3.SelectionChangeCommitted += this.ChartFilterControl3_ItemSelected;
            this.ChartFilterControl4 = filter4;
            this.ChartFilterControl4.SelectionChangeCommitted += this.ChartFilterControl4_ItemSelected;
        }

        /// <summary>
        /// The assign chart expanders.
        /// </summary>
        /// <param name="panel1">
        /// The panel 1.
        /// </param>
        /// <param name="panel2">
        /// The panel 2.
        /// </param>
        private void AssignChartExpanders(ExpandCollapsePanel panel1, ExpandCollapsePanel panel2)
        {
            try
            {
                this.Expander1 = panel1;
                this.Expander2 = panel2;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The expander_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Expander_Click(object sender, EventArgs e)
        {
            ExpandCollapsePanel exp = sender as ExpandCollapsePanel;
            switch (this.CurrentTabIndex)
            {
                case 0:
                    if (this.FundExpander2.IsExpanded)
                    {
                        this.FundExpander2.IsExpanded = false;
                    }

                    break;
                case 1:
                    if (this.BocExpander2.IsExpanded)
                    {
                        this.BocExpander2.IsExpanded = false;
                    }

                    break;
                case 3:
                    if (this.NpmExpander2.IsExpanded)
                    {
                        this.NpmExpander2.IsExpanded = false;
                    }

                    break;
                case 4:
                    if (this.GoalExpander2.IsExpanded)
                    {
                        this.GoalExpander2.IsExpanded = false;
                    }

                    break;
                case 5:
                    if (this.ObjectiveExpander2.IsExpanded)
                    {
                        this.ObjectiveExpander2.IsExpanded = false;
                    }

                    break;
                case 6:
                    if (this.AreaExpander2.IsExpanded)
                    {
                        this.AreaExpander2.IsExpanded = false;
                    }

                    break;
                case 7:
                    if (this.ProjectExpander2.IsExpanded)
                    {
                        this.ProjectExpander2.IsExpanded = false;
                    }

                    break;
            }
        }

        /// <summary>
        /// The summary tab page_ tab selected.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SummaryTabPage_TabSelected(object sender, EventArgs e)
        {
            try
            {
                this.SummaryTabControl = sender as TabControlAdv;
                this.CurrentTabIndex = this.SummaryTabControl.SelectedIndex;
                switch (this.CurrentTabIndex)
                {
                    case 0:
                        this.AssignChartFIlterControls(
                            this.FundFilter1,
                            this.FundFilter2,
                            this.FundFilter3,
                            this.FundFilter4);
                        this.AssignChartExpanders(this.FundExpander1, this.FundExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.FundName);
                        if (this.Source == Source.RegionalAccounts)
                        {
                            this.FundFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Appropriation" };
                        this.FundChart = new BudgetChart(
                            this.FundChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.Fund,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 1:
                        this.AssignChartFIlterControls(
                            this.BocFilter1,
                            this.BocFilter2,
                            this.BocFilter3,
                            this.BocFilter4);
                        this.AssignChartExpanders(this.BocExpander1, this.BocExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.BocName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.BocFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Budget Object Class" };
                        this.BocChart = new BudgetChart(
                            this.BocChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.BocName,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 2:
                        this.AssignChartFIlterControls(
                            this.NpmFilter1,
                            this.NpmFilter2,
                            this.NpmFilter3,
                            this.NpmFilter4);
                        this.AssignChartExpanders(this.NpmExpander1, this.NpmExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.NPM);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.NpmFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By National Program" };
                        this.NpmChart = new BudgetChart(
                            this.NpmChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.NPM,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 3:
                        this.AssignChartFIlterControls(
                            this.GoalFilter1,
                            this.GoalFilter2,
                            this.GoalFilter3,
                            this.GoalFilter4);
                        this.AssignChartExpanders(this.GoalExpander1, this.GoalExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.GoalName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.GoalFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Agency Goal" };
                        this.GoalChart = new BudgetChart(
                            this.GoalChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.GoalName,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 4:
                        this.AssignChartFIlterControls(
                            this.ObjectiveFilter1,
                            this.ObjectiveFilter2,
                            this.ObjectiveFilter3,
                            this.ObjectiveFilter4);
                        this.AssignChartExpanders(this.ObjectiveExpander1, this.ObjectiveExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.ObjectiveName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.ObjectiveFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Agency Objective" };
                        this.ObjectiveChart = new BudgetChart(
                            this.ObjectiveChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.ObjectiveName,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 5:
                        this.AssignChartFIlterControls(
                            this.DivisionFilter1,
                            this.DivisionFilter2,
                            this.DivisionFilter3,
                            this.DivisionFilter4);
                        this.AssignChartExpanders(this.DivisionExpander1, this.DivisionExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.DivisionName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.DivisionFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Division" };
                        this.DivisionChart = new BudgetChart(
                            this.DivisionChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.RC,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 6:
                        this.AssignChartFIlterControls(
                            this.AreaFilter1,
                            this.AreaFilter2,
                            this.AreaFilter3,
                            this.AreaFilter4);
                        this.AssignChartExpanders(this.AreaExpander1, this.AreaExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.ProgramAreaName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.AreaFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Program Area" };
                        this.AreaChart = new BudgetChart(
                            this.AreaChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.ProgramArea,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 7:
                        this.AssignChartFIlterControls(
                            this.ProjectFilter1,
                            this.ProjectFilter2,
                            this.ProjectFilter3,
                            this.ProjectFilter4);
                        this.AssignChartExpanders(this.ProjectExpander1, this.ProjectExpander2);
                        this.PopulateFilterBoxItems(this.ChartFilterControl3, Field.ProgramProjectName);
                        if (this.DbData.Source == Source.RegionalAccounts)
                        {
                            this.ProjectFilter4.Items.Remove("RC");
                        }

                        this.ChartMainTitle = new[] { "Funding By Program Project" };
                        this.ProjectChart = new BudgetChart(
                            this.ProjectChart,
                            this.ChartMainTitle,
                            this.DbData,
                            Field.ProgramProjectCode,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                    case 8:
                        int current = this.BindingSource.Position;
                        DataRowView dvrow = (DataRowView)this.BindingSource.Current;
                        this.DbRow = this.Table.Rows[current];
                        int id = int.Parse(this.DbRow["ID"].ToString());
                        string code = dvrow["Code"].ToString();
                        Dictionary<string, object> p = new Dictionary<string, object> { ["ID"] = id };
                        DataBuilder data = new DataBuilder(this.Source, Provider.SQLite, p);
                        decimal total = this.DbData.GetTotal(this.DbData.DbTable);
                        decimal amt = decimal.Parse(this.DbRow["Amount"].ToString());
                        Dictionary<string, double> d =
                            new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)amt };
                        this.ChartMainTitle = new[]
                                              {
                                                  $"{this.Source.ToString()} {this.DbRow["ProgramProjectName"]} Funding = {amt.ToString("c")}"
                                              };
                        this.AccountChart = new BudgetChart(
                            this.AccountChart,
                            this.ChartMainTitle,
                            d,
                            Field.ProgramProjectCode,
                            Stat.Total,
                            ChartSeriesType.Column).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The get title.
        /// </summary>
        /// <param name="tab">
        /// The tab.
        /// </param>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="string[]"/>.
        /// </returns>
        private string[] GetTitle(TabControlAdv tab, MetroSetComboBox filter)
        {
            try
            {
                string category = tab.TabPages[this.CurrentTabIndex].Tag.ToString();
                int index = filter.SelectedIndex;
                switch (index)
                {
                    case 0:
                        return new[] { string.Format("Total Funding by {0}", category) };
                    case 1:
                        return new[] { string.Format("Total Accounts by {0}", category) };
                    case 2:
                        return new[] { string.Format("Average Funding by {0}", category) };
                    case 3:
                        return new[] { string.Format("Funding Percentage by {0}", category) };
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
        /// The get title.
        /// </summary>
        /// <param name="tab">
        /// The tab.
        /// </param>
        /// <param name="filter1">
        /// The filter 1.
        /// </param>
        /// <param name="filter2">
        /// The filter 2.
        /// </param>
        /// <param name="filter3">
        /// The filter 3.
        /// </param>
        /// <returns>
        /// The <see cref="string[]"/>.
        /// </returns>
        private string[] GetTitle(
            TabControlAdv tab,
            MetroSetComboBox filter1,
            MetroSetComboBox filter2,
            MetroSetComboBox filter3)
        {
            try
            {
                string source = filter2.SelectedItem.ToString();
                string category = tab.TabPages[this.CurrentTabIndex].Tag.ToString();
                int index = filter1.SelectedIndex;
                string grouping = filter3.SelectedItem.ToString();
                switch (index)
                {
                    case 0:
                        return new[] { string.Format("Total {0} Funding by {1}", source, grouping) };
                    case 1:
                        return new[] { string.Format("{0}  Accounts by {1}", source, grouping) };
                    case 2:
                        return new[] { string.Format("Average {0} Funding by {1}", source, grouping) };
                    case 3:
                        return new[] { string.Format("{0} Funding Percentage by {1}", source, grouping) };
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
        /// The get selected row dictionary.
        /// </summary>
        /// <param name="dgv">
        /// The dgv.
        /// </param>
        /// <returns>
        /// The <see cref="Dictionary"/>.
        /// </returns>
        private Dictionary<string, object> GetSelectedRowDictionary(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    DataGridViewRow dgvRow = dgv.CurrentRow;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
                    data.Add("Fund", dgvRow.Cells["Fund"].Value.ToString());
                    data.Add("Org", dgvRow.Cells["Org"].Value.ToString());
                    data.Add("RC", dgvRow.Cells["RC"].ToString());
                    data.Add("Code", dgvRow.Cells["Code"].ToString());
                    data.Add("BOC", dgvRow.Cells["BOC"].ToString());
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
        /// The tab page adv 7_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TabPageAdv7_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The calendat button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CalendatButton_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
        }

        /// <summary>
        /// The calculator button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.Show();
        }

        /// <summary>
        /// The excel button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ExcelButton_Click(object sender, EventArgs e)
        {
            ExcelForm er = new ExcelForm();
            er.Show();
        }

        /// <summary>
        /// The tool strip separator 16_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ToolStripSeparator16_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The metro set label 9_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MetroSetLabel9_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The lbl count_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LblCount_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The add button_ on click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountManager am = new AccountManager(Source.PRC, this.Provider);
                am.AccountNavigator.Visible = false;
                am.UpdateTab.TabVisible = false;
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The copy button_ on click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)this.BindingSource.Current;
                Dictionary<string, object> prc = new PRC(view.Row).GetDataFields();
                AccountManager am = new AccountManager(this.Source, this.Provider, prc);
                am.AccountNavigator.Visible = false;
                am.AddNewTab.TabVisible = false;
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The grid_ on double click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Grid_OnDoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)this.BindingSource.Current;
                Dictionary<string, object> prc = new PRC(view.Row).GetDataFields();
                AccountManager am = new AccountManager(this.Source, Provider.SQLite, prc);
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The reprogram button_ on click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ReprogramButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rp = new Reprogramming();
            rp.Show();
        }

        /// <summary>
        /// The update account chart.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateAccountChart(object sender, EventArgs e)
        {
            int current = this.BindingSource.Position;
            DataRowView dvrow = (DataRowView)this.BindingSource.Current;
            this.DbRow = this.Table.Rows[current];
            int id = int.Parse(this.DbRow["ID"].ToString());
            string code = dvrow["Code"].ToString();
            Dictionary<string, object> p = new Dictionary<string, object> { ["ID"] = id };
            DataBuilder data = new DataBuilder(
                Source.RegionalAccounts,
                Provider.SQLite,
                new Dictionary<string, object> { ["Code"] = code });
            decimal total = data.Total;
            decimal amt = decimal.Parse(this.DbRow["Amount"].ToString());
            Dictionary<string, double> d =
                new Dictionary<string, double> { ["Total"] = (double)total, ["Allocation"] = (double)amt };
            this.ChartMainTitle = new[]
                                  {
                                      $"{this.Source.ToString()} {this.DbRow["ProgramProjectName"]} Funding = {amt.ToString("c")}"
                                  };
            this.AccountChart = new BudgetChart(
                this.AccountChart,
                this.ChartMainTitle,
                d,
                Field.ProgramProjectCode,
                Stat.Total,
                ChartSeriesType.Column).Activate();
        }

        /// <summary>
        /// The account tools button_ on click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AccountToolsButton_OnClick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The account chart_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AccountChart_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button 4_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Button4_Click(object sender, EventArgs e)
        {
            this.BindingSource.MovePrevious();
        }

        /// <summary>
        /// The button 5_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.BindingSource.MoveNext();
        }
    }
}