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
using Budget.Ninja.Data;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;


namespace BudgetExecution
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
            if (source == Source.RegionAccount)
            {
                Data = new DataBuilder(Source.RegionAccount);
                DataSet = Data.DataSet;
                BaseTable = Data.GetData();
                DivisionTab.TabVisible = false;
                Source = Data.Source;
                CurrentTabIndex = 0;
                TabNames = GetTabNames();
                Text = "Region 6 Summary";
            }
            if (source == Source.DivisionAccount)
            {
                Data = new DataBuilder(Source.DivisionAccount);
                DataSet = Data.DataSet;
                BaseTable = Data.GetData();
                Source = Data.Source;
                CurrentTabIndex = 0;
                TabNames = GetTabNames();
                Text = "R6 Division Summary";
            }
            Metric = new PrcMetric(Data);
            DataSet = Data.DataSet;
            ProgramElements = Metric.ProgramElements;
            BindingSource.DataSource = Metric.Table;
            ProjectTab.TabVisible = false;
            DatabaseTab.TabVisible = false;
            CurrentTabIndex = SummaryTabControl.SelectedIndex;
            SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
        }
        public SummaryForm(string rc)
        {
            InitializeComponent();
            Source = Source.DivisionAccount;
            Parameter = new Dictionary<string, object>() { ["RC"] = rc };
            DatabaseTab.TabVisible = true;
            ProjectTab.TabVisible = true;
            DivisionTab.TabVisible = false;
            Data = new DataBuilder(Source, Parameter);
            DataSet = Data.DataSet;
            BaseTable = Data.GetData();
            ProgramElements = Data.ProgramElements;
            Metric = new PrcMetric(Data);
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
        public ChartSeriesType ChartType { get; set; }
        public string[] Divisions { get; }
        public DataSet DataSet { get; }
        public PrcMetric Metric { get; set; }
        public decimal[] Metrics { get; }
        public Dictionary<string, string[]> ProgramElements { get; }
        public DataTable BaseTable { get; }
        public string[] MainTitle { get; set; }
        public string[] AxisTitle { get; set; }
        public int CurrentTabIndex { get; set; }
        public MetroSetComboBox GridPrimaryFilter { get; set; }
        public MetroSetComboBox GridSecondaryFilter { get; set; }
        public MetroSetComboBox ChartPrimaryFilterControl { get; set; }
        public MetroSetComboBox ChartTypeFilterControl { get; set; }
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
                PopulateFilterBoxItems(GridFundFilter, PrcField.FundName);
                ConfigureTextBoxBindings();
                lblTotal.Text = Data.GetQueryTotal(Data.QueryTable).ToString("c");
                lblCount.Text = Data.GetQueryCount(Data.QueryTable).ToString();
                GridFundFilter.SelectionChangeCommitted += GridFundFilter_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                FundChart = new BudgetChart(FundChart, Data, PrcField.FundName).Activate();
                SummaryTabControl.SelectedIndex = 1;

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
        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, PrcField prcfilter)
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
        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, int i)
        {
            try
            {
                foreach(string t in TabNames)
                {
                    cmbox.Items.Clear();
                    cmbox.Items.Add(t);
                    cmbox.Items.Remove(SummaryTabControl.TabPages[i].Text);
                }
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
        private void ConfigureTextBoxBindings()
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
        void ChartTypeFilter_ItemSelected(object sender, EventArgs e)
        {
            var tb = sender as MetroSetComboBox;
            ChartType = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), tb.SelectedItem.ToString());
        }
        ChartSeriesType GetChartType(MetroSetComboBox ctb)
        {
            if (ctb.SelectedItem == null)
                return ChartSeriesType.Column;
            return (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ctb.SelectedItem.ToString());
        }
        void SummaryTabPage_TabSelected(object sender, EventArgs e)
        {
            try
            {
                SummaryTabControl = sender as TabControlAdv;
                CurrentTabIndex = SummaryTabControl.SelectedIndex;
                switch (CurrentTabIndex)
                {
                    case 0:
                        GetChartType(ChartTypeFilter1);
                        FundFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(FundFilter2, PrcField.FundName);
                        FundExpander2.Visible = false;
                        FundChart = new BudgetChart(FundChart, Data, PrcField.Fund).Activate();
                        break;
                    case 1:
                        GetChartType(ChartTypeFilter2);
                        BocFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(BocFilter2, PrcField.BocName);
                        BocExpander2.Visible = false;
                        BocChart = new BudgetChart(BocChart, Data, PrcField.BocName).Activate();
                        break;
                    case 2:
                        GetChartType(ChartTypeFilter3);
                        NpmFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(NpmFilter2, PrcField.NPM);
                        NpmTab.Visible = false;
                        NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM).Activate();
                        break;
                    case 3:
                        GetChartType(ChartTypeFilter4);
                        GoalFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(GoalFilter2, PrcField.GoalName);
                        GoalExpander2.Visible = false;
                        GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName).Activate();
                        break;
                    case 4:
                        GetChartType(ChartTypeFilter5);
                        ObjectiveFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(ObjectiveFilter2, PrcField.ObjectiveName);
                        ObjectiveExpander2.Visible = false;
                        ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName).Activate();
                        break;
                    case 5:
                        GetChartType(ChartTypeFilter6);
                        DivisionFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(DivisionFilter2, PrcField.DivisionName);
                        DivisionExpander2.Visible = false;
                        DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.RC).Activate();
                        break;
                    case 6:
                        GetChartType(ChartTypeFilter7);
                        AreaFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(AreaFilter2, PrcField.ProgramAreaName);
                        AreaExpander2.Visible = false;
                        AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea).Activate();
                        break;
                    case 7:
                        GetChartType(ChartTypeFilter8);
                        ProjectFilter.SelectedIndexChanged += ChartPrimaryFilter_ItemSelected;
                        PopulateFilterBoxItems(ProjectFilter2, PrcField.ProgramProjectName);
                        ProjectExpander2.Visible = false;
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
                        ChartType = GetChartType(ChartTypeFilter1);
                        Measure = (Stat)Enum.Parse(typeof(Stat), FundFilter.SelectedItem.ToString());
                        FundChart = new BudgetChart(FundChart, Data, PrcField.Fund, Measure, ChartType).Activate();
                        FundExpander2.Visible = true;
                        FundExpander2.Visible = true;
                        if (FundExpander2.IsExpanded)
                            FundExpander2.IsExpanded = false;
                        if (!FundExpander2.IsExpanded)
                            FundExpander2.IsExpanded = true;
                        var a = new ChartTitle();
                        FundChart.Titles.Add(a);
                        break;
                    case 1:
                        BocFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter2);
                        Measure = (Stat)Enum.Parse(typeof(Stat), BocFilter.SelectedItem.ToString());
                        BocExpander2.Visible = true;
                        if (BocExpander2.IsExpanded)
                            BocExpander2.IsExpanded = false;
                        if(!BocExpander2.IsExpanded)
                            BocExpander2.IsExpanded = true;
                        BocChart = new BudgetChart(BocChart, Data, PrcField.BocName, Measure, ChartType).Activate();
                        break;
                    case 2:
                        NpmFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter3);
                        Measure = (Stat)Enum.Parse(typeof(Stat), NpmFilter.SelectedItem.ToString());
                        NpmExpander2.Visible = true;
                        if (NpmExpander2.IsExpanded)
                            NpmExpander2.IsExpanded = false;
                        if (!NpmExpander2.IsExpanded)
                            NpmExpander2.IsExpanded = true;
                        NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM, Measure, ChartType).Activate();
                        break;
                    case 3:
                        GoalFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter4);
                        Measure = (Stat)Enum.Parse(typeof(Stat), GoalFilter.SelectedItem.ToString());
                        GoalExpander2.Visible = true;
                        if (GoalExpander2.IsExpanded)
                            GoalExpander2.IsExpanded = false;
                        if (!GoalExpander2.IsExpanded)
                            GoalExpander2.IsExpanded = true;
                        GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName, Measure, ChartType).Activate();
                        break;
                    case 4:
                        ObjectiveFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter5);
                        Measure = (Stat)Enum.Parse(typeof(Stat), ObjectiveFilter.SelectedItem.ToString());
                        ObjectiveExpander2.Visible = true;
                        if (ObjectiveExpander2.IsExpanded)
                            ObjectiveExpander2.IsExpanded = false;
                        if (!ObjectiveExpander2.IsExpanded)
                            ObjectiveExpander2.IsExpanded = true;
                        ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName, Measure, ChartType).Activate();
                        break;
                    case 5:
                        DivisionFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter6);
                        Measure = (Stat)Enum.Parse(typeof(Stat), DivisionFilter.SelectedItem.ToString());
                        DivisionExpander2.Visible = true;
                        if (DivisionExpander2.IsExpanded)
                            DivisionExpander2.IsExpanded = false;
                        if (!DivisionExpander2.IsExpanded)
                            DivisionExpander2.IsExpanded = true;
                        DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.DivisionName, Measure, ChartType).Activate();
                        break;
                    case 6:
                        AreaFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter7);
                        Measure = (Stat)Enum.Parse(typeof(Stat), AreaFilter.SelectedItem.ToString());
                        AreaExpander2.Visible = true;
                        if (AreaExpander2.IsExpanded)
                            AreaExpander2.IsExpanded = false;
                        if (!AreaExpander2.IsExpanded)
                            AreaExpander2.IsExpanded = true;
                        AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea, Measure, ChartType).Activate();
                        break;
                    case 7:
                        ProjectFilter = ChartPrimaryFilterControl;
                        ChartType = GetChartType(ChartTypeFilter8);
                        Measure = (Stat)Enum.Parse(typeof(Stat), ProjectFilter.SelectedItem.ToString());
                        ProjectExpander2.Visible = true;
                        if (ProjectExpander2.IsExpanded)
                            ProjectExpander2.IsExpanded = false;
                        if (!ProjectExpander2.IsExpanded)
                            ProjectExpander2.IsExpanded = true;
                        ProjectChart = new BudgetChart(ProjectChart, Data, PrcField.ProgramProjectCode, Measure, ChartType).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        Dictionary<string, object> GetCurrentRowParameter(DataGridView dgv)
        {
            try
            {
                if(dgv.CurrentRow != null)
                {
                    var dgvRow = dgv.CurrentRow;
                    var data = new Dictionary<string, object>();
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

                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

    }      
}