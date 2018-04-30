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
    namespace Ninja.Data
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
                    BaseTable = Data.QueryTable;
                    CurrentTabIndex = 0;
                    TabNames = GetTabNames();
                    Text = "Region 6 Summary";
                }
                if (source == Source.P8)
                {
                    Data = new DataBuilder(Source.P8);
                    Source = Data.Source;
                    BaseTable = Data.QueryTable;
                    TabNames = GetTabNames();
                    Text = "R6 Division Summary";
                }
                Metric = new DataMetric(Data);
                DataSet = Data.QuerySet;
                ProgramElements = Metric.ProgramElements;
                BindingSource.DataSource = Metric.BaseTable;
                ProjectTab.TabVisible = false;
                DatabaseTab.TabVisible = false;
                CurrentTabIndex = SummaryTabControl.SelectedIndex;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                SummaryTabControl.TabIndex = 0;
            }

            public SummaryForm(string rc)
            {
                InitializeComponent();
                Source = Source.P8;
                Parameter = new Dictionary<string, object>() { ["RC"] = rc };
                DatabaseTab.TabVisible = true;
                ProjectTab.TabVisible = true;
                DivisionTab.TabVisible = false;
                Data = new DataBuilder(Source, Parameter);
                ProgramElements = Data.ProgramElements;
                BaseTable = Data.QueryTable;
                DataSet = Data.QuerySet;
                Metric = new DataMetric(Data);
                Text = string.Format("{0} Summary", Info.DivisionName(rc));
                CurrentTabIndex = SummaryTabControl.SelectedIndex;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                TabNames = GetTabNames();
            }

            //Properties
            public DivisionAuthority D6 { get; }
            public DataBuilder Data { get; }
            public Dictionary<string, object> Parameter { get; set; }
            public Source Source { get; }
            public string[] Divisions { get; }
            public DataSet DataSet { get; }
            public DataMetric Metric { get; set; }
            public decimal[] Metrics { get; }
            public Dictionary<string, string[]> ProgramElements { get; }
            public DataTable BaseTable { get; }
            public DataTable Base1 { get; set; }
            public DataTable Base2 { get; set; }
            public string[] MainTitle { get; set; }
            public string[] AxisTitle { get; set; }
            public int CurrentTabIndex { get; set; }
            public MetroSetComboBox GridPrimaryFilter { get; set; }
            public MetroSetComboBox GridSecondaryFilter { get; set; }
            public MetroSetComboBox ChartPrimaryFilterControl { get; set; }
            public Stat Measure { get; set; }
            private TabPageAdv[] Tab { get; set; }
            private string[] TabNames { get; set; }

            //Methods

            private void Form_Load(object sender, EventArgs e)
            {
                try
                {
                    BindingSource.DataSource = Data.QueryTable;
                    Navigator.BindingSource = BindingSource;
                    Grid.DataSource = BindingSource;
                    DefineVisisbleDataColumns(Grid);
                    PopulateGridDatabaseFilterItems(GridFundFilter, PrcField.FundName);
                    InitializeTextBoxBindings();
                    lblTotal.Text = Data.GetQueryTotal(Data.QueryTable).ToString("c");
                    lblCount.Text = Data.GetQueryCount(Data.QueryTable).ToString();
                    GridFundFilter.SelectionChangeCommitted += GridFundFilter_ItemSelected;
                    GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                    GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                    SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                    FundChart = new BudgetChart(FundChart, Data, PrcField.FundName).Activate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
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
                    foreach (string b in ProgramElements[PrcField.BocName.ToString()])
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
            private void PopulateGridDatabaseFilterItems(MetroSetComboBox cmbox, PrcField prcfilter)
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
            private void DefineVisisbleDataColumns(DataGridView dgv)
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
            private void InitializeTextBoxBindings()
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
                    return BaseTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
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
            private void PopulateChartFilterControlItems(MetroSetComboBox filterbox, string[] list)
            {
                try
                {
                    if (filterbox.Items != null)
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
            void SummaryTabPage_TabSelected(object sender, EventArgs e)
            {
                try
                {
                    SummaryTabControl = sender as TabControlAdv;
                    switch (SummaryTabControl.SelectedIndex)
                    {
                        case 0:
                            FundFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            FundChart = new BudgetChart(FundChart, Data, PrcField.Fund).Activate();
                            break;
                        case 1:
                            BocFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            BocChart = new BudgetChart(BocChart, Data, PrcField.BocName).Activate();
                            break;
                        case 2:
                            NpmFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM).Activate();
                            break;
                        case 3:
                            GoalFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName).Activate();
                            break;
                        case 4:
                            ObjectiveFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName).Activate();
                            break;
                        case 5:
                            DivisionFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.Division).Activate();
                            break;
                        case 6:
                            AreaFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea).Activate();
                            break;
                        case 7:
                            ProjectFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                            ProjectChart = new BudgetChart(ProjectChart, Data, PrcField.ProgramProjectCode).Activate();
                            break;
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
                    ChartPrimaryFilterControl = sender as MetroSetComboBox;
                    switch (SummaryTabControl.SelectedIndex)
                    {
                        case 0:
                            FundFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), FundFilter.SelectedItem.ToString());
                            FundChart = new BudgetChart(FundChart, Data, PrcField.Fund, Measure).Activate();
                            break;
                        case 1:
                            BocFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), BocFilter.SelectedItem.ToString());
                            BocChart = new BudgetChart(BocChart, Data, PrcField.BocName, Measure).Activate();
                            break;
                        case 2:
                            NpmFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), NpmFilter.SelectedItem.ToString());
                            NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM, Measure).Activate();
                            break;
                        case 3:
                            GoalFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), GoalFilter.SelectedItem.ToString());
                            GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName, Measure).Activate();
                            break;
                        case 4:
                            ObjectiveFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), ObjectiveFilter.SelectedItem.ToString());
                            ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName, Measure).Activate();
                            break;
                        case 5:
                            DivisionFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), DivisionFilter.SelectedItem.ToString());
                            DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.Division, Measure).Activate();
                            break;
                        case 6:
                            AreaFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), AreaFilter.SelectedItem.ToString());
                            AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea, Measure).Activate();
                            break;
                        case 7:
                            ProjectFilter = ChartPrimaryFilterControl;
                            Measure = (Stat)Enum.Parse(typeof(Stat), ProjectFilter.SelectedItem.ToString());
                            ProjectChart = new BudgetChart(ProjectChart, Data, PrcField.ProgramProjectCode, Measure).Activate();
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