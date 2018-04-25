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
                        Source = Data.Source;
                        Table = Data.QueryTable;
                        Text = "Region 6 Summary";
                        Title = "R6 Funding";
                    }
                    if (source == Source.P8)
                    {
                        Data = new DataBuilder(Source.P8);
                        Source = Data.Source;
                        Table = Data.QueryTable;
                        Text = "R6 Division Summary";
                        Title = "Division Funding";
                    }
                    Metric = new DataMetric(Data);
                    DataSet = Data.QuerySet;
                    PopulateCharts(Title);
                    ProgramElements = Metric.ProgramElements;
                    Divisions = ProgramElements["RC"];
                    BindingSource.DataSource = Metric.BaseTable;
                    GetChartPrimaryFilterBox();
                    ProjectTab.TabVisible = false;
                    DatabaseTab.TabVisible = false;
                    TabNames = GetTabNames();
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent();
                    DatabaseTab.TabVisible = true;
                    ProjectTab.TabVisible = true;
                    DivisionTab.TabVisible = false;
                    Data = new DataBuilder(Source.P8, new Dictionary<string, object>() { ["RC"] = rc });
                    Source = Data.Source;
                    Table = Data.QueryTable;
                    Source = Data.Source;
                    DataSet = Data.QuerySet;
                    Metric = new DataMetric(Data);
                    ProgramElements = Metric.ProgramElements;
                    GetChartPrimaryFilterBox();
                    Text = string.Format("{0} Summary", Info.DivisionName(rc));
                    Title = Info.DivisionName(rc);
                    SummaryTabControl.SelectedIndexChanged += TabPage_OnClick;
                    TabNames = GetTabNames();
                }

                //Properties
                public DivisionAuthority D6 { get; }
                public DataBuilder Data { get; }
                public Source Source { get; }
                public string[] Divisions { get; }
                public DataSet DataSet { get; }
                public DataMetric Metric { get; }
                public decimal[] Metrics { get; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DataTable Table { get; }
                public DataTable Base { get; set; }
                public string Title { get; set; }
                public int CurrentTabIndex { get; set; }
                public MetroSetComboBox PrimaryFilterBox { get; set; }
                public MetroSetComboBox SecondaryFilterBox { get; set; }
                public string ChartPrimaryFilter { get; set; }
                public PrcFilter ChartSecondaryFilter { get; set; }
                public string TabFilter { get; set; }
                internal ChartControl[] Chart { get; set; }
                private TabPageAdv[] Tab { get; set; }
                private string[] TabNames { get; set; }

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
                        ConfigureGridColumns(Grid);
                        PopulateCharts(Title);
                        PopulateGridFilterItems(FundFilter, PrcFilter.FundName);
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
                private void PopulateGridFilterItems(MetroSetComboBox cmbox, PrcFilter prcfilter)
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
                private void ConfigureGridColumns(DataGridView dgv)
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
                private void PopulateMetroSetButtons(FlowLayoutPanel panel, string[] list)
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
                private ChartControl GetSummaryChart(ChartControl chart, DataBuilder data, PrcFilter filter, string title)
                {
                    try
                    {
                        var fd = new BudgetChart(chart, data, filter, Stat.Total);
                        fd.UpdateAxisTitle(chart, new string[] { title });
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
                string[] GetTabNames()
                {
                    var names = new string[SummaryTabControl.TabPages.Count];
                    var tabs = SummaryTabControl.TabPages;
                    for (int i = 0; i < SummaryTabControl.TabPages.Count; i++)
                    {
                        names[i] = tabs[i].Text;
                    }
                    return names;
                }
                Dictionary<string, string> GetFilters()
                {
                    try
                    {
                        var filters = new Dictionary<string, string>();
                        foreach (string n in TabNames)
                        {
                            if (n.Contains("Fund"))
                                filters.Add("Fund", "FundName");
                            if (n.Contains("BOC"))
                                filters.Add("BOC", "BocName");
                            if (n.Contains("NPM"))
                                filters.Add("NPM", "NPM");
                            if (n.Contains("Goal"))
                                filters.Add("Goal", "GoalName");
                            if (n.Contains("Division"))
                                filters.Add("Division", "RC");
                            if (n.Contains("Objective"))
                                filters.Add("Objective", "ObjectiveName");
                            if (n.Contains("ProgramArea"))
                                filters.Add("ProgramArea", "ProgramArea");
                            if (n.Contains("ProgramProjectCode"))
                                filters.Add("ProgramProjectCode", "ProgramProjectCode");
                        }
                        return filters;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
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
                void SummaryTabPage_Selected(object sender, EventArgs e)
                {
                    try
                    {
                        var tab = sender as TabControlAdv;
                        CurrentTabIndex = tab.SelectedIndex;
                        TabFilter = tab.TabPages[CurrentTabIndex].Tag.ToString();
                        switch(CurrentTabIndex)
                        {
                            case 0:
                                FundFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 1:
                                BocFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 2:
                                NpmFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 3:
                                GoalFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 4:
                                ObjectiveFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 5:
                                DivisionFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 6:
                                AreaFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                            case 7:
                                ProjectFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                }
                private void GetChartPrimaryFilterItems(MetroSetComboBox filterbox, string[] list)
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
                private void GetChartPrimaryFilterBox()
                {
                    try
                    {
                        GetChartPrimaryFilterItems(FundFilter1, Metric.ProgramElements["FundName"]);
                        GetChartPrimaryFilterItems(BocFilter1, Metric.ProgramElements["BocName"]);
                        GetChartPrimaryFilterItems(NpmFilter1, Metric.ProgramElements["NPM"]);
                        GetChartPrimaryFilterItems(GoalFilter1, Metric.ProgramElements["GoalName"]);
                        GetChartPrimaryFilterItems(ObjectiveFilter1, Metric.ProgramElements["ObjectiveName"]);
                        GetChartPrimaryFilterItems(DivisionFilter1, Divisions ?? Metric.ProgramElements["RC"]);
                        GetChartPrimaryFilterItems(AreaFilter1, Metric.ProgramElements["ProgramAreaName"]);
                        GetChartPrimaryFilterItems(ProjectFilter1, Metric.ProgramElements["ProgramProjectName"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                    }
                }
                private Dictionary<string, string> GetChartSecondaryFilterItems()
                {
                    try
                    {
                        return GetFilters();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
                private void GetChartSecondaryFilterBox(MetroSetComboBox filterbox, TabPageAdv page)
                {
                    try
                    {
                        filterbox.Items?.Clear();
                        var items = GetChartSecondaryFilterItems();
                        foreach (KeyValuePair<string, string> kvp in items)
                        {
                            filterbox.Items.Add(kvp.Key);
                            filterbox.ValueMember = kvp.Value;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void ChartPrimaryFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        PrimaryFilterBox = sender as MetroSetComboBox;
                        ChartPrimaryFilter = PrimaryFilterBox.SelectedItem.ToString();
                        if (CurrentTabIndex == 0)
                        {
                            SecondaryFilterBox = FundFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 1)
                        {
                            SecondaryFilterBox = BocFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 2)
                        {
                            SecondaryFilterBox = NpmFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 3)
                        {
                            SecondaryFilterBox = GoalFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 4)
                        {
                            SecondaryFilterBox = ObjectiveFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 5)
                        {
                            SecondaryFilterBox = DivisionFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 6)
                        {
                            SecondaryFilterBox = AreaFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 7)
                        {
                            SecondaryFilterBox = ProjectFilter2;
                            SecondaryFilterBox.Items.Clear();
                            GetChartSecondaryFilterBox(SecondaryFilterBox, SummaryTabControl.TabPages[CurrentTabIndex]);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                }
                void ChartSecondaryFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        SecondaryFilterBox = sender as MetroSetComboBox;
                        var secondaryfilter = SecondaryFilterBox.SelectedItem.ToString();
                        ChartSecondaryFilter = (PrcFilter)Enum.Parse(typeof(PrcFilter), secondaryfilter);
                        var data = new DataMetric(Data);
                        switch(CurrentTabIndex)
                        {
                            case 0:
                                FundChart = new BudgetChart(FundChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 1:
                                BocChart = new BudgetChart(BocChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 2:
                                NpmChart = new BudgetChart(NpmChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 3:
                                GoalChart = new BudgetChart(GoalChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 4:
                                ObjectiveChart = new BudgetChart(ObjectiveChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 5:
                                DivisionChart = new BudgetChart(DivisionChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 6:
                                AreaChart = new BudgetChart(AreaChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            case 7:
                                ProjectChart = new BudgetChart(ProjectChart, data, ChartSecondaryFilter, Stat.Total).Activate();
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void TabPage_OnClick(object sender, EventArgs e)
                {
                    try
                    {
                        SummaryTabControl = sender as TabControlAdv;
                        int i = SummaryTabControl.SelectedIndex;
                        switch (i)
                        {
                            case 0:
                                FundChart = GetSummaryChart(FundChart, Data, PrcFilter.FundName, string.Format("{0} by Appropriation", Title));
                                break;
                            case 1:
                                BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BocName, string.Format("{0} by Object Class", Title));
                                break;
                            case 2:
                                NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, string.Format("{0} by HQ Program Office", Title));
                                break;
                            case 3:
                                GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, string.Format("{0} by Agency Goal", Title));
                                break;
                            case 4:
                                ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, string.Format("{0} by Strategic Objective", Title));
                                break;
                            case 5:
                                DivisionChart = GetSummaryChart(DivisionChart, Data, PrcFilter.Division, string.Format("{0} by Division", Title));
                                break;
                            case 6:
                                AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramAreaName, string.Format("{0} by Program Area", Title));
                                break;
                            case 7:
                                ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, string.Format("{0} by Program Project", Title));
                                break;
                            default:
                                FundChart = GetSummaryChart(FundChart, Data, PrcFilter.FundName, string.Format("{0} by Appropriation", Title));
                                break;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
        }
    }
}