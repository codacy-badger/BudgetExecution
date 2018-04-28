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
                        DivisionTab.TabVisible = false;
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
                    ProgramElements = Metric.ProgramElements;
                    BindingSource.DataSource = Metric.BaseTable;
                    PopulateChartPrimaryFilter();
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
                    Source = Source.P8;
                    Table = Data.QueryTable;
                    DataSet = Data.QuerySet;
                    ProgramElements = Data.ProgramElements;
                    Metric = new DataMetric(Data);
                    PopulateChartPrimaryFilter();
                    Text = string.Format("{0} Summary", Info.DivisionName(rc));
                    Title = Info.DivisionName(rc);
                    SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                    TabNames = GetTabNames();
                }

                //Properties
                public DivisionAuthority D6 { get; }
                public DataBuilder Data { get; set; }
                public Dictionary<string, object> Parameter { get; set; }
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
                public AccountField ChartSecondaryFilter { get; set; }
                public string TabFilter { get; set; }
                internal ChartControl[] Chart { get; set; }
                private TabPageAdv[] Tab { get; set; }
                private string[] TabNames { get; set; }

                //Methods
                private void GridBocFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        var boc = sender as MetroSetComboBox;
                        var filter = boc.SelectedItem.ToString();
                        BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem.ToString()}' AND BocName = '{GridBocFilter.SelectedItem.ToString()}'";
                        lblTotal.Text = GetTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                        lblCount.Text = GetCount(GridFundFilter.SelectedItem.ToString(), filter).ToString();
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
                        ConfigureDataGridColumns(Grid);
                        PopulateGridDatabaseFilterItems(GridFundFilter, AccountField.FundName);
                        SetTextBoxBindings();
                        lblTotal.Text = Data.GetQueryTotal(Data.QueryTable).ToString("c");
                        lblCount.Text = Data.GetQueryCount(Data.QueryTable).ToString();
                        GridFundFilter.SelectionChangeCommitted += GridFundFilter_ItemSelected;
                        GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                        GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                        SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
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
                        GridFundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        PopulateGridBocFilterItems();
                        BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem.ToString());
                        lblCount.Text = GetCount(fund).ToString();
                        lblTotal.Text = GetTotal(fund).ToString("c");
                        PopulateGridBocFilterItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void ConfigureGridBindingFilter()
                {
                    try
                    {
                        if (GridFundFilter.SelectedItem.ToString() != null)
                        {
                            BindingSource.Filter = string.Format("FundName = '{0}' AND BocName = '{1}'",
                                    GridFundFilter.SelectedItem.ToString(), GridBocFilter.SelectedItem.ToString());
                        }
                        BindingSource.Filter = string.Format("FundName = '{0}'", GridBocFilter.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void PopulateGridBocFilterItems()
                {
                    try
                    {
                        GridBocFilter.Items.Clear();
                        GridBocFilter.Visible = true;
                        foreach (string b in ProgramElements[AccountField.BocName.ToString()])
                            GridBocFilter.Items.Add(b);
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
                private void PopulateGridDatabaseFilterItems(MetroSetComboBox cmbox, AccountField prcfilter)
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
                private void ConfigureDataGridColumns(DataGridView dgv)
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
                private void ConfigureGridFilterButtons(FlowLayoutPanel panel, string[] list)
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
                private void SetTextBoxBindings()
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
                                filters.Add("Division", "Division");
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
                private void PrimaryGridFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        GridFundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        PopulateGridBocFilterItems();
                        BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                private void SecondaryGridFilter_ItemSelected(object sender, EventArgs e)
                {
                    try
                    {
                        var filter = sender as MetroSetComboBox;
                        GridFundFilter.Tag = filter;
                        var fund = filter.SelectedItem.ToString();
                        PopulateGridBocFilterItems();
                        BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void SummaryTabPage_TabSelected(object sender, EventArgs e)
                {
                    try
                    {
                        CurrentTabIndex = SummaryTabControl.SelectedIndex;
                        TabFilter = SummaryTabControl.TabPages[CurrentTabIndex].Tag.ToString();
                        switch (CurrentTabIndex)
                        {
                            case 0:
                                PopulateChartPrimaryFilter();
                                FundFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                FundChart = new BudgetChart(FundChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[0].Text)).Activate();
                                break;
                            case 1:
                                PopulateChartPrimaryFilter();
                                BocFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                BocChart = new BudgetChart(BocChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[1].Text)).Activate();
                                break;
                            case 2:
                                PopulateChartPrimaryFilter();
                                NpmFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                NpmChart = new BudgetChart(NpmChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[2].Text)).Activate();
                                break;
                            case 3:
                                PopulateChartPrimaryFilter();
                                GoalFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                GoalChart = new BudgetChart(GoalChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[3].Text)).Activate();
                                break;
                            case 4:
                                PopulateChartPrimaryFilter();
                                ObjectiveFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                ObjectiveChart = new BudgetChart(ObjectiveChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[4].Text)).Activate();
                                break;
                            case 5:
                                PopulateChartPrimaryFilter();
                                DivisionFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                DivisionChart = new BudgetChart(DivisionChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[5].Text)).Activate();
                                break;
                            case 6:
                                PopulateChartPrimaryFilter();
                                AreaFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                AreaChart = new BudgetChart(AreaChart, Data, (AccountField)Enum.Parse(typeof(AccountField), SummaryTabControl.TabPages[6].Text)).Activate();
                                break;
                            case 7:
                                PopulateChartPrimaryFilter();
                                ProjectFilter1.SelectionChangeCommitted += ChartPrimaryFilter_ItemSelected;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                }
                private void ConfigureChartPrimaryFilter(MetroSetComboBox filterbox, string[] list)
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
                private void PopulateChartPrimaryFilter()
                {
                    try
                    {
                        ConfigureChartPrimaryFilter(FundFilter1, Data.ProgramElements["FundName"]);
                        ConfigureChartPrimaryFilter(BocFilter1, Data.ProgramElements["BocName"]);
                        ConfigureChartPrimaryFilter(NpmFilter1, Data.ProgramElements["NPM"]);
                        ConfigureChartPrimaryFilter(GoalFilter1, Data.ProgramElements["GoalName"]);
                        ConfigureChartPrimaryFilter(ObjectiveFilter1, Data.ProgramElements["ObjectiveName"]);
                        ConfigureChartPrimaryFilter(DivisionFilter1, Data.ProgramElements["RC"]);
                        ConfigureChartPrimaryFilter(AreaFilter1, Data.ProgramElements["ProgramAreaName"]);
                        ConfigureChartPrimaryFilter(ProjectFilter1, Data.ProgramElements["ProgramProjectName"]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }
                private Dictionary<string, string> GetChartSecondaryFilterItems()
                {
                    try
                    {
                        var filters = new Dictionary<string, string>();
                        foreach (string n in TabNames)
                        {
                            if (n.Contains("Fund"))
                                filters.Add("Fund", "FundName");
                            if (n.Contains("BOC"))
                                filters.Add("BOC", "BOC");
                            if (n.Contains("NPM"))
                                filters.Add("NPM", "NPM");
                            if (n.Contains("Goal"))
                                filters.Add("Goal", "GoalName");
                            if (n.Contains("Division"))
                                filters.Add("Division", "RC");
                            if (n.Contains("Objective"))
                                filters.Add("Objective", "ObjectiveName");
                            if (n.Contains("ProgramArea"))
                                filters.Add("ProgramArea", "ProgramAreaName");
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
                private void ConfigureSecondaryChartFilter(MetroSetComboBox filterbox)
                {
                    try
                    {
                        filterbox.Items.Clear();
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
                        Base = Table.AsEnumerable().Where(p=>p.Field<string>(TabFilter).Equals(ChartPrimaryFilter)).Select(p => p).CopyToDataTable();
                        if (CurrentTabIndex == 0)
                        {
                            SecondaryFilterBox = FundFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[0].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 1)
                        {
                            SecondaryFilterBox = BocFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[1].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 2)
                        {
                            SecondaryFilterBox = NpmFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[2].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 3)
                        {
                            SecondaryFilterBox = GoalFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[3].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 4)
                        {
                            SecondaryFilterBox = ObjectiveFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[4].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 5)
                        {
                            SecondaryFilterBox = DivisionFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[5].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 6)
                        {
                            SecondaryFilterBox = AreaFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[6].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
                            SecondaryFilterBox.SelectionChangeCommitted += ChartSecondaryFilter_ItemSelected;
                        }
                        if (CurrentTabIndex == 7)
                        {
                            SecondaryFilterBox = ProjectFilter2;
                            ConfigureSecondaryChartFilter(SecondaryFilterBox);
                            var tabname = SummaryTabControl.TabPages[7].Text;
                            SecondaryFilterBox.Items.Remove(tabname);
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
                        ChartSecondaryFilter = (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter);
                        var param = new Dictionary<string, object>();
                        if (Source == Source.P8 && Parameter != null)
                        {
                            Parameter.Add(TabFilter, ChartPrimaryFilter);
                            Data = new DataBuilder(Source, Parameter);
                        }
                        param.Add(TabFilter, ChartPrimaryFilter);
                        Data = new DataBuilder(Source, param);
                        switch (CurrentTabIndex)
                        {
                            case 0:
                                FundChart = new BudgetChart(FundChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 1:
                                BocChart = new BudgetChart(BocChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 2:
                                NpmChart = new BudgetChart(NpmChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 3:
                                GoalChart = new BudgetChart(GoalChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 4:
                                ObjectiveChart = new BudgetChart(ObjectiveChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 5:
                                DivisionChart = new BudgetChart(DivisionChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 6:
                                AreaChart = new BudgetChart(AreaChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                            case 7:
                                ProjectChart = new BudgetChart(ProjectChart, Data, (AccountField)Enum.Parse(typeof(AccountField), secondaryfilter)).Activate();
                                break;
                        }
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