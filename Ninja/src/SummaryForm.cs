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
using MakarovDev.ExpandCollapsePanel;

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
        public MetroSetComboBox GridFilterControl1 { get; set; }
        public MetroSetComboBox GridFilterControl2 { get; set; }
        public MetroSetComboBox ChartMeasureFilterControl { get; set; }
        public MetroSetComboBox ChartTypeFilterControl { get; set; }
        public ExpandCollapsePanel Expander1 { get; set; }
        public ExpandCollapsePanel Expander2 { get; set; }
        public Stat Measure { get; set; }
        private TabPageAdv[] Tab { get; set; }
        private string[] TabNames { get; set; }

        //Methods
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource.DataSource = Data.Table;
                Navigator.BindingSource = BindingSource;
                Grid.DataSource = BindingSource;
                DefineVisisbleDataColumns(Grid);
                PopulateFilterBoxItems(GridFundFilter, PrcField.FundName);
                ConfigureTextBoxBindings();
                lblTotal.Text = Data.GetQueryTotal(Data.Table).ToString("c");
                lblCount.Text = Data.GetQueryCount(Data.Table).ToString();
                GridFundFilter.SelectionChangeCommitted += GridFundFilter_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridBocFilter_ItemSelected;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                FundChart = new BudgetChart(FundChart, Data, PrcField.FundName).Activate();
                SummaryTabControl.SelectedIndex = 1;
                GridAccountFilter.Visible = false;
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
                lblTotal.Text = CalculateTotal(fund).ToString("c");
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
                lblTotal.Text = CalculateTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                lblCount.Text = GetCount(GridFundFilter.SelectedItem.ToString(), filter).ToString();
                GridAccountFilter.Visible = true;
                PopulateGridAccountFilterItems();
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
        private void PopulateGridAccountFilterItems()
        {
            try
            {
                GridAccountFilter.Items.Clear();
                var table = (DataTable)BindingSource.DataSource;
                var query = table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString()))
                    .Where(p => p.Field<string>("BocName").Equals(GridBocFilter.SelectedItem.ToString())).Select(p => p).CopyToDataTable();
                foreach (DataRow row in query.Rows)
                    GridAccountFilter.Items.Add(row["Code"].ToString());
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
                return Data.Table.AsEnumerable().Where(p => p.Field<string>("FundName").
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
                return Data.Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
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
        private decimal CalculateTotal(string filter)
        {
            try
            {
                return Data.Table.AsEnumerable().Where(p => p.Field<string>("FundName").
                Equals(filter)).Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return -1;
            }
        }
        private decimal CalculateTotal(string filter1, string filter2)
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
            try
            {
                var names = new string[SummaryTabControl.TabPages.Count];
                var tabs = SummaryTabControl.TabPages;
                for (int i = 0; i < SummaryTabControl.TabPages.Count; i++)
                {
                    names[i] = tabs[i].Text;
                }
                return names;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
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
        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
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
        private void GridFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                GridFundFilter.Tag = filter;
                var fund = filter.SelectedItem.ToString();
                BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void ChartTypeFilterControl_ItemSelected(object sender, EventArgs e)
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
        void Expander_Click(object sender, EventArgs e)
        {
            var exp = sender as ExpandCollapsePanel;
            switch(CurrentTabIndex)
            {
                case 0:
                    if (FundExpander2.IsExpanded == true)
                        FundExpander2.IsExpanded = false;
                    break;
                case 1:
                    if (BocExpander2.IsExpanded == true)
                        BocExpander2.IsExpanded = false;
                    break;
                case 3:
                    if (NpmExpander2.IsExpanded == true)
                        NpmExpander2.IsExpanded = false;
                    break;
                case 4:
                    if (GoalExpander2.IsExpanded == true)
                        GoalExpander2.IsExpanded = false;
                    break;
                case 5:
                    if (ObjectiveExpander2.IsExpanded == true)
                        ObjectiveExpander2.IsExpanded = false;
                    break;
                case 6:
                    if (AreaExpander2.IsExpanded == true)
                        AreaExpander2.IsExpanded = false;
                    break;
                case 7:
                    if (ProjectExpander2.IsExpanded == true)
                        ProjectExpander2.IsExpanded = false;
                    break;
            }
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
                        FundFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(FundFilter2, PrcField.FundName);
                        FundExpander2.Visible = false;
                        FundExpander1.ExpandCollapse += Expander_Click;
                        FundFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        FundChart = new BudgetChart(FundChart, Data, PrcField.Fund).Activate();
                        break;
                    case 1:
                        GetChartType(ChartTypeFilter2);
                        BocFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(BocFilter2, PrcField.BocName);
                        BocExpander2.Visible = false;
                        BocExpander1.ExpandCollapse += Expander_Click;
                        BocFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        BocChart = new BudgetChart(BocChart, Data, PrcField.BocName).Activate();
                        break;
                    case 2:
                        GetChartType(ChartTypeFilter3);
                        NpmFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(NpmFilter2, PrcField.NPM);
                        NpmExpander2.Visible = false;
                        NpmExpander1.ExpandCollapse += Expander_Click;
                        NpmFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM).Activate();
                        break;
                    case 3:
                        GetChartType(ChartTypeFilter4);
                        GoalFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(GoalFilter2, PrcField.GoalName);
                        GoalExpander2.Visible = false;
                        GoalExpander1.ExpandCollapse += Expander_Click;
                        GoalFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName).Activate();
                        break;
                    case 4:
                        GetChartType(ChartTypeFilter5);
                        ObjectiveFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(ObjectiveFilter2, PrcField.ObjectiveName);
                        ObjectiveExpander2.Visible = false;
                        ObjectiveExpander1.ExpandCollapse += Expander_Click;
                        ObjectiveFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName).Activate();
                        break;
                    case 5:
                        GetChartType(ChartTypeFilter6);
                        DivisionFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(DivisionFilter2, PrcField.DivisionName);
                        DivisionExpander2.Visible = false;
                        DivisionExpander1.ExpandCollapse += Expander_Click;
                        DivisionFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.RC).Activate();
                        break;
                    case 6:
                        GetChartType(ChartTypeFilter7);
                        AreaFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(AreaFilter2, PrcField.ProgramAreaName);
                        AreaExpander2.Visible = false;
                        AreaExpander1.ExpandCollapse += Expander_Click;
                        AreaFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea).Activate();
                        break;
                    case 7:
                        GetChartType(ChartTypeFilter8);
                        ProjectFilter.SelectedIndexChanged += ChartMeasureFilterControl_ItemSelected;
                        PopulateFilterBoxItems(ProjectFilter2, PrcField.ProgramProjectName);
                        ProjectExpander2.Visible = false;
                        ProjectExpander1.ExpandCollapse += Expander_Click;
                        ProjectFilter3.SelectedIndexChanged += ChartSqlCommandFilter_ItemSelected;
                        ProjectChart = new BudgetChart(ProjectChart, Data, PrcField.ProgramProjectCode).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void ChartMeasureFilterControl_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartMeasureFilterControl = sender as MetroSetComboBox;
                switch (SummaryTabControl.SelectedIndex)
                {
                    case 0:
                        FundFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter1);
                        Measure = (Stat)Enum.Parse(typeof(Stat), FundFilter.SelectedItem.ToString());
                        FundChart = new BudgetChart(FundChart, Data, PrcField.Fund, Measure, ChartType).Activate();
                        FundExpander2.Visible = true;
                        var a = new ChartTitle();
                        FundChart.Titles.Add(a);
                        break;
                    case 1:
                        BocFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter2);
                        Measure = (Stat)Enum.Parse(typeof(Stat), BocFilter.SelectedItem.ToString());
                        BocExpander2.Visible = true;
                        BocChart = new BudgetChart(BocChart, Data, PrcField.BocName, Measure, ChartType).Activate();
                        break;
                    case 2:
                        NpmFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter3);
                        Measure = (Stat)Enum.Parse(typeof(Stat), NpmFilter.SelectedItem.ToString());
                        NpmExpander2.Visible = true;
                        NpmChart = new BudgetChart(NpmChart, Data, PrcField.NPM, Measure, ChartType).Activate();
                        break;
                    case 3:
                        GoalFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter4);
                        Measure = (Stat)Enum.Parse(typeof(Stat), GoalFilter.SelectedItem.ToString());
                        GoalExpander2.Visible = true;
                        GoalChart = new BudgetChart(GoalChart, Data, PrcField.GoalName, Measure, ChartType).Activate();
                        break;
                    case 4:
                        ObjectiveFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter5);
                        Measure = (Stat)Enum.Parse(typeof(Stat), ObjectiveFilter.SelectedItem.ToString());
                        ObjectiveExpander2.Visible = true;
                        ObjectiveChart = new BudgetChart(ObjectiveChart, Data, PrcField.ObjectiveName, Measure, ChartType).Activate();
                        break;
                    case 5:
                        DivisionFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter6);
                        Measure = (Stat)Enum.Parse(typeof(Stat), DivisionFilter.SelectedItem.ToString());
                        DivisionExpander2.Visible = true;
                        DivisionChart = new BudgetChart(DivisionChart, Data, PrcField.DivisionName, Measure, ChartType).Activate();
                        break;
                    case 6:
                        AreaFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter7);
                        Measure = (Stat)Enum.Parse(typeof(Stat), AreaFilter.SelectedItem.ToString());
                        AreaExpander2.Visible = true;
                        AreaChart = new BudgetChart(AreaChart, Data, PrcField.ProgramArea, Measure, ChartType).Activate();
                        break;
                    case 7:
                        ProjectFilter = ChartMeasureFilterControl;
                        ChartType = GetChartType(ChartTypeFilter8);
                        Measure = (Stat)Enum.Parse(typeof(Stat), ProjectFilter.SelectedItem.ToString());
                        ProjectExpander2.Visible = true;
                        ProjectChart = new BudgetChart(ProjectChart, Data, PrcField.ProgramProjectCode, Measure, ChartType).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void ChartSqlCommandFilter_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartMeasureFilterControl = sender as MetroSetComboBox;
                var param = new Dictionary<string, object>();
                switch (SummaryTabControl.SelectedIndex)
                {
                    case 0:
                        if(FundFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), FundFilter3.SelectedItem.ToString());
                            param.Add(FundFilter2.Tag.ToString(), FundFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            FundChart = new BudgetChart(FundChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 1:
                        if (BocFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), BocFilter3.SelectedItem.ToString());
                            param.Add(BocFilter2.Tag.ToString(), BocFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            BocChart = new BudgetChart(BocChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 2:
                        if (NpmFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), NpmFilter3.SelectedItem.ToString());
                            param.Add(NpmFilter2.Tag.ToString(), NpmFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            NpmChart = new BudgetChart(NpmChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 3:
                        if (GoalFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), GoalFilter3.SelectedItem.ToString());
                            param.Add(GoalFilter2.Tag.ToString(), GoalFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            GoalChart = new BudgetChart(GoalChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 4:
                        if (ObjectiveFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), ObjectiveFilter3.SelectedItem.ToString());
                            param.Add(ObjectiveFilter2.Tag.ToString(), ObjectiveFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            ObjectiveChart = new BudgetChart(ObjectiveChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 5:
                        if (DivisionFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), DivisionFilter3.SelectedItem.ToString());
                            param.Add(DivisionFilter2.Tag.ToString(), DivisionFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            DivisionChart = new BudgetChart(DivisionChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 6:
                        if (AreaFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), AreaFilter3.SelectedItem.ToString());
                            param.Add(AreaFilter2.Tag.ToString(), AreaFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            AreaChart = new BudgetChart(AreaChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
                        break;
                    case 7:
                        if (ProjectFilter2.SelectedItem != null)
                        {
                            var sqlfilter = (PrcField)Enum.Parse(typeof(PrcField), ProjectFilter3.SelectedItem.ToString());
                            param.Add(ProjectFilter2.Tag.ToString(), ProjectFilter2.SelectedItem.ToString());
                            var data = new DataBuilder(Data.Source, param);
                            ProjectChart = new BudgetChart(ProjectChart, data, sqlfilter, Measure, ChartType).Activate();
                        }
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