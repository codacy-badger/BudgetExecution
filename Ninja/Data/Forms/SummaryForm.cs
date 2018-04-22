using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class SummaryForm : MetroForm
            {
                //Constructors
                public SummaryForm()
                {
                    InitializeComponent();
                }

                public SummaryForm(Source source)
                {
                    InitializeComponent();
                    if (source == Source.P7)
                    {
                        Data = new DataBuilder(Source.P7);
                        Text = "Region 6 Summary";
                        Title = "R6 Funding";
                        ProjectTab.TabVisible = false;
                    }
                    if (source == Source.P8)
                    {
                        Data = new DataBuilder(Source.P8);
                        Text = "R6 Division Summary";
                        Title = "Division Funding";
                    }
                    Metric = new DataMetric(Data);
                    DataSet = Data.QuerySet;
                    PopulateCharts(Title);
                    ProgramElements = Metric.ProgramElements;
                    BindingSource.DataSource = Metric.BaseTable;
                    GetFilterButtons();
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent();
                    DatabaseTab.TabVisible = true;
                    D6 = new DivisionAuthority(rc);
                    Data = D6.Data;
                    DataSet = Data.QuerySet;
                    Metric = new DataMetric(Data);
                    ProgramElements = Metric.ProgramElements;
                    GetFilterButtons();
                    Text = $"{D6.Org.Name} Summary";
                    Title = D6.RC.Name;
                }

                //Properties
                public PrcFilter ButtonFilter { get; set; }
                public DivisionAuthority D6 { get; }
                public DataBuilder Data { get; }
                public DataSet DataSet { get; }
                public DataMetric Metric { get; }
                public decimal[] Metrics { get; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DataTable Table { get; }
                public DataTable Base { get; set; }
                public string Title { get; set; }
                public string Filter1 { get; set; }
                public string Filter2 { get; set; }
                public string TabFilter { get; set; }
                internal ChartControl[] Chart { get; set; }
                internal RadioButton[] RadioButton { get; set; }
                private TabPageAdv[] Tab { get; set; }

                //Delegates
                TableFilter Filter { get; set; }

                //Methods
                private void BocFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        var boc = sender as MetroSetComboBox;
                        var filter = boc.SelectedItem.ToString();
                        BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}' AND BocName = '{BocFilter.SelectedItem.ToString()}'";
                        lblTotal.Text = GetTotal(FundFilter.SelectedItem.ToString(), filter).ToString("c");
                        lblCount.Text = GetCount(FundFilter.SelectedItem.ToString(), filter).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void Form_Load(object sender, EventArgs e)
                {
                    try
                    {
                        BindingSource.DataSource = Data.QueryTable;
                        Navigator.BindingSource = BindingSource;
                        Grid.DataSource = BindingSource;
                        GetGridColumns(Grid);
                        PopulateCharts(Title);
                        GetDatabaseFilterItems(FundFilter, PrcFilter.FundName);
                        GetTextBoxBindings();
                        lblTotal.Text = Data.GetQueryTotal(Data.QueryTable).ToString("c");
                        lblCount.Text = Data.GetQueryCount(Data.QueryTable).ToString();
                        FundFilter.SelectionChangeCommitted += GridFundFilter_ItemSelected;
                        BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
                        BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
                        SummaryTabControl.Click += SummaryTabPage_Selected;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GridFundFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        FundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        GetBocFilterItems();
                        BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}'";
                        lblCount.Text = GetCount(fund).ToString();
                        lblTotal.Text = GetTotal(fund).ToString("c");
                        GetBocFilterItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GetBindingSourceFilter()
                {
                    try
                    {
                        if (FundFilter.SelectedItem.ToString() != null)
                        {
                            BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}' AND BocName = '{BocFilter.SelectedItem.ToString()}'";
                        }
                        BindingSource.Filter = $"FundName = '{BocFilter.SelectedItem.ToString()}'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GetBocFilterItems()
                {
                    try
                    {
                        BocFilter.Items.Clear();
                        BocFilter.Visible = true;
                        foreach (string b in ProgramElements[PrcFilter.BocName.ToString()])
                            BocFilter.Items.Add(b);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private decimal GetCount(string filter)
                {
                    try
                    {
                        return Data.QueryTable.AsEnumerable().Where(p => p.Field<string>("FundName").
                    Equals(filter)).Select(p => p.Field<decimal>("Amount") > 0).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                private decimal GetCount(string filter1, string filter2)
                {
                    try
                    {
                        return Data.QueryTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                           .Where(p => p.Field<string>("BocName").Equals(filter2)).Select(p => p.Field<decimal>("Amount")).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                private void GetFilterButtons()
                {
                    try
                    {
                        GetChartFilterItems(FundFilter1, Metric.ProgramElements["FundName"]);
                        GetChartFilterItems(BocFilter1, Metric.ProgramElements["BocName"]);
                        GetChartFilterItems(NpmFilter1, Metric.ProgramElements["NPM"]);
                        GetChartFilterItems(GoalFilter1, Metric.ProgramElements["GoalName"]);
                        GetChartFilterItems(ObjectiveFilter1, Metric.ProgramElements["ObjectiveName"]);
                        GetChartFilterItems(DivisionFilter1, Metric.ProgramElements["DivisionName"]);
                        GetChartFilterItems(AreaFilter1, Metric.ProgramElements["ProgramAreaName"]);
                        GetChartFilterItems(ProjectFilter1, Metric.ProgramElements["ProgramProjectName"]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }
                private void GetDatabaseFilterItems(MetroSetComboBox cmbox, PrcFilter prcfilter)
                {
                    try
                    {
                        if (cmbox.Items.Count > 0)
                            cmbox.Items.Clear();
                        var items = Data.ProgramElements[prcfilter.ToString()];
                        foreach (string i in items)
                            cmbox.Items.Add(i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GetGridColumns(DataGridView dgv)
                {
                    try
                    {
                        foreach (DataGridViewColumn dc in dgv.Columns)
                            dc.Visible = false;
                        dgv.Columns[0].Visible = true;
                        dgv.Columns[3].Visible = true;
                        dgv.Columns[4].Visible = true;
                        dgv.Columns[6].Visible = true;
                        dgv.Columns[7].Visible = true;
                        dgv.Columns[9].Visible = true;
                        dgv.Columns[11].Visible = true;
                        dgv.Columns[12].Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GetMetroSetButtons(FlowLayoutPanel panel, string[] list)
                {
                    try
                    {
                        panel.Controls.Clear();
                        foreach (string f in list)
                        {
                            var b = new MetroSetButton();
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
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GetChartFilterItems(MetroSetComboBox filterbox, string[] list)
                {
                    try
                    {
                        filterbox.Items.Clear();
                        foreach (string f in list)
                        {
                            filterbox.Items.Add(f);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private ChartControl GetSummaryChart(ChartControl chart, DataBuilder data, PrcFilter filter, string title)
                {
                    try
                    {
                        var fd = new BudgetChart(chart, data, filter, Stat.Total);
                        fd.GetAxisTitle(chart, new string[] { title });
                        return fd.Activate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
                private void GetTextBoxBindings()
                {
                    try
                    {
                        BFY.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                        Fund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                        Org.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                        RC.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                        Code.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                        BOC.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                        Amount.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private decimal GetTotal(string filter)
                {
                    try
                    {
                        return Data.QueryTable.AsEnumerable().Where(p => p.Field<string>("FundName").
                     Equals(filter)).Select(p => p.Field<decimal>("Amount")).Sum();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                private decimal GetTotal(string filter1, string filter2)
                {
                    try
                    {
                        return Data.QueryTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                    .Where(p => p.Field<string>("BocName").Equals(filter2))
                    .Select(p => p.Field<decimal>("Amount")).Sum();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                private void GridFilterFirstItem_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        FundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        GetBocFilterItems();
                        BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void GridFilterSecondItem_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        FundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        GetBocFilterItems();
                        BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void PopulateCharts(string title)
                {
                    FundChart = GetSummaryChart(FundChart, Data, PrcFilter.Fund, string.Format("{0} by Appropriation", title));
                    BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BOC, string.Format("{0} by Object Class", title));
                    NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, string.Format("{0} by HQ Program", title));
                    GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, string.Format("{0} by Agency Goal", title));
                    ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, string.Format("{0} by Strategic Objective", title));
                    AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramArea, string.Format("{0} by Program Area", title));
                    ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, string.Format("{0} by Program Project", title));
                }
                Dictionary<string, string> GetFilters()
                {
                    try
                    {
                        var filters = new Dictionary<string, string>();
                        filters.Add("Fund", "FundName");
                        filters.Add("BOC", "BocName");
                        filters.Add("NPM", "NPM");
                        filters.Add("Goal", "GoalName");
                        filters.Add("Objective", "ObjectiveName");
                        filters.Add("Division", "RC");
                        filters.Add("Program Area", "ProgramArea");
                        filters.Add("Program Project", "ProgramProject");
                        return filters;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
                void ChartFilterFirstItem_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        FundFilter1.Tag = filter;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void ChartFilterSecondItem_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        FundFilter2.Tag = filter;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void SummaryTabPage_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var tab = sender as TabControlAdv;
                        int i = tab.SelectedIndex;
                        TabFilter = tab.TabPages[i].Tag.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                }
            }
        }
    }
}