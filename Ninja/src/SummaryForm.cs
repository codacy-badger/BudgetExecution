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
        // CONSTRUCTORS
        public SummaryForm()
        {
            InitializeComponent();
        }
        public SummaryForm(string rc)
        {
            InitializeComponent();
            Division = rc;
            Source = Source.DivisionAccount;
            Parameter = new Dictionary<string, object>() { ["RC"] = rc };
            DbData = new DataBuilder(Source.DivisionAccount, Provider.SQLite, Parameter);
            Table = DbData.Table;
            DatabaseTab.TabVisible = true;
            ProjectTab.TabVisible = true;
            DivisionTab.TabVisible = false;
            ProgramElements = DbData.ProgramElements;
            Metric = new PrcMetric(DbData);
            Text = string.Format("{0} Summary", Info.DivisionName(rc));
            CurrentTabIndex = SummaryTabControl.SelectedIndex;
            SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
            TabNames = GetTabNames();
            GridRefreshButton.Click += GridRefreshButton_OnClick;
        }
        public SummaryForm(Source source)
        {
            InitializeComponent();
            if (source == Source.RegionAccount)
            {
                DbData = new DataBuilder(Source.RegionAccount, Provider.SQLite);
                Table = DbData.Table;
                DivisionTab.TabVisible = false;
                Source = DbData.Source;
                CurrentTabIndex = 0;
                TabNames = GetTabNames();
                Text = "Region 6 Summary";
            }
            if (source == Source.DivisionAccount)
            {
                DbData = new DataBuilder(Source.DivisionAccount, Provider.SQLite);
                Table = DbData.Table;
                Source = DbData.Source;
                CurrentTabIndex = 0;
                TabNames = GetTabNames();
                Text = "R6 Division Summary";
            }
            Metric = new PrcMetric(DbData);
            ProgramElements = Metric.ProgramElements;
            BindingSource.DataSource = Metric.Table;
            ProjectTab.TabVisible = false;
            DatabaseTab.TabVisible = false;
            CurrentTabIndex = SummaryTabControl.SelectedIndex;
            SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
        }
        // PROPERTIES
        public Source Source { get; }
        public Dictionary<string, object> Parameter { get; set; }
        public DivisionAuthority D6 { get; }
        public DataBuilder DbData { get; }
        public DataTable Table { get; set; }
        public PrcMetric Metric { get; set; }
        public ChartSeriesType ChartType { get; set; }
        public PrcField ChartPrcField { get; set; }
        public string ChartFilter { get; set; }
        public string Division { get; set; }
        public PrcField ChartGroup { get; set; }
        public Dictionary<string, string[]> ProgramElements { get; }
        public string[] ChartMainTitle { get; set; }
        public string[] ChartAxisTitle { get; set; }
        public int CurrentTabIndex { get; set; }
        public MetroSetComboBox GridFilterControl1 { get; set; }
        public MetroSetComboBox GridFilterControl2 { get; set; }
        public MetroSetComboBox GridFilterControl3 { get; set; }
        public MetroSetComboBox ChartFilterControl1 { get; set; }
        public MetroSetComboBox ChartFilterControl2 { get; set; }
        public MetroSetComboBox ChartFilterControl3 { get; set; }
        public MetroSetComboBox ChartFilterControl4 { get; set; }
        public ExpandCollapsePanel Expander1 { get; set; }
        public ExpandCollapsePanel Expander2 { get; set; }
        public Stat Measure { get; set; }
        private TabPageAdv[] Tab { get; set; }
        private string[] TabNames { get; set; }

        // METHODS
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource.DataSource = DbData.Table;
                Navigator.BindingSource = BindingSource;
                Grid.DataSource = BindingSource;
                DefineVisisbleDataColumns(Grid);
                PopulateFilterBoxItems(GridFundFilter, PrcField.FundName);
                ConfigureTextBoxBindings();
                lblTotal.Text = DbData.GetTotal(DbData.Table).ToString("c");
                lblCount.Text = DbData.GetCount(DbData.Table).ToString();
                GridFundFilter.SelectionChangeCommitted += GridFilterControl1_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridFilterControl2_ItemSelected;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                FundChart = new BudgetChart(FundChart, DbData, PrcField.FundName).Activate();
                SummaryTabControl.SelectedIndex = 1;
                lblPrc.Visible = false;
                GridAccountFilter.Visible = false;
                lblBoc.Visible = false;
                GridBocFilter.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                GridFundFilter.Tag = filter;
                var fund = filter.SelectedItem.ToString();
                BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem.ToString());
                lblCount.Text = GetCount(fund).ToString();
                lblTotal.Text = CalculateTotal(fund).ToString("c");
                PopulateGridBocFilterItems();
                lblBoc.Visible = true;
                GridBocFilter.Visible = true;
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
                var boc = sender as MetroSetComboBox;
                var filter = boc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem.ToString()}' AND BocName = '{GridBocFilter.SelectedItem.ToString()}'";
                lblTotal.Text = CalculateTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                lblCount.Text = GetCount(GridFundFilter.SelectedItem.ToString(), filter).ToString();
                GridAccountFilter.Visible = true;
                lblPrc.Visible = true;
                GridAccountFilter.Visible = true;
                PopulateGridAccountFilterItems();
                GridAccountFilter.SelectionChangeCommitted += GridFilterControl3_ItemSelected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void GridFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var prc = sender as MetroSetComboBox;
                var filter = prc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem.ToString()}' AND BocName = '{GridBocFilter.SelectedItem.ToString()}' AND Code = '{filter}'";
                lblTotal.Text = CalculateTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
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
                var table = (DataTable)BindingSource.DataSource;
                var query = table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString()))
                        .Select(p => p).Distinct().CopyToDataTable();
                foreach (var row in query.AsEnumerable().Select(p => p.Field<string>("BocName")).Distinct().ToArray())
                    GridBocFilter.Items.Add(row);
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
                return DbData.Table.AsEnumerable().Where(p => p.Field<string>("FundName").
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
                return DbData.Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
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
                var items = DbData.ProgramElements[prcfilter.ToString()];
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
                return DbData.Table.AsEnumerable().Where(p => p.Field<string>("FundName").
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
                return Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
            .Where(p => p.Field<string>("BocName").Equals(filter2))
            .Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return -1;
            }
        }
        private void GridRefreshButton_OnClick(object sender, EventArgs e)
        {
            if (DbData != null)
            {
                try
                {
                    BindingSource.Filter = null;
                    Navigator.BindingSource = BindingSource;
                    Grid.DataSource = BindingSource;
                    lblTotal.Text = DbData.GetTotal(DbData.Table).ToString("c");
                    lblCount.Text = DbData.GetCount(DbData.Table).ToString();
                    GridBocFilter.Items.Clear();
                    GridAccountFilter.Items.Clear();
                    PopulateFilterBoxItems(GridFundFilter, PrcField.FundName);
                    lblBoc.Visible = false;
                    GridBocFilter.Visible = false;
                    lblPrc.Visible = false;
                    GridAccountFilter.Visible = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
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
        ChartSeriesType GetChartType(MetroSetComboBox ctb)
        {
            if (ctb.SelectedItem == null)
                return ChartSeriesType.Column;
            return (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ctb.SelectedItem.ToString());
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
        void ChartFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            ChartFilterControl1 = sender as MetroSetComboBox;
            ChartType = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ChartFilterControl1.SelectedItem.ToString());
            if (Expander2.IsExpanded == true)
                Expander2.IsExpanded = false;
        }
        void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl2 = sender as MetroSetComboBox;
                Measure = (Stat)Enum.Parse(typeof(Stat), ChartFilterControl2.SelectedItem.ToString());
                if (Expander2.IsExpanded == false)
                    Expander2.IsExpanded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void ChartFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl3 = sender as MetroSetComboBox;
                ChartPrcField = (PrcField)Enum.Parse(typeof(PrcField), ChartFilterControl3.Tag.ToString());
                ChartFilter = ChartFilterControl3.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void ChartFilterControl4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl4 = sender as MetroSetComboBox;
                ChartGroup = (PrcField)Enum.Parse(typeof(PrcField), ChartFilterControl4.SelectedItem.ToString());
                ChartMainTitle = new string[] { $"{ChartFilter} Funding By {ChartFilterControl4.SelectedItem.ToString()}" };
                var param = new Dictionary<string, object>();
                switch (CurrentTabIndex)
                {
                    case 0:
                        if(Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        FundChart = new BudgetChart(FundChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 1:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 2:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        NpmChart = new BudgetChart(NpmChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 3:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        GoalChart = new BudgetChart(GoalChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 4:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        ObjectiveChart = new BudgetChart(ObjectiveChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 5:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        DivisionChart = new BudgetChart(DivisionChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 6:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        AreaChart = new BudgetChart(AreaChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                    case 7:
                        if (Division != null)
                            param = new Dictionary<string, object>() { ["RC"] = Division, [ChartPrcField.ToString()] = ChartFilter };
                        else
                            param = new Dictionary<string, object>() { [ChartPrcField.ToString()] = ChartFilter };
                        ProjectChart = new BudgetChart(ProjectChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        void AssignChartFIlterControls(MetroSetComboBox filter1, MetroSetComboBox filter2, MetroSetComboBox filter3, MetroSetComboBox filter4)
        {
            ChartFilterControl1 = filter1;
            ChartFilterControl1.SelectionChangeCommitted += ChartFilterControl1_ItemSelected;
            ChartFilterControl2 = filter2;
            ChartFilterControl2.SelectionChangeCommitted += ChartFilterControl2_ItemSelected;
            ChartFilterControl3 = filter3;
            ChartFilterControl3.SelectionChangeCommitted += ChartFilterControl3_ItemSelected;
            ChartFilterControl4 = filter4;
            ChartFilterControl4.SelectionChangeCommitted += ChartFilterControl4_ItemSelected;
        }
        void AssignChartExpanders(ExpandCollapsePanel panel1, ExpandCollapsePanel panel2)
        {
            try
            {
                Expander1 = panel1;
                Expander2 = panel2;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

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
                        AssignChartFIlterControls(FundFilter1, FundFilter2, FundFilter3, FundFilter4);
                        AssignChartExpanders(FundExpander1, FundExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.FundName);
                        if (Source == Source.RegionAccount)
                            FundFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Appropriation" };
                        FundChart = new BudgetChart(FundChart, ChartMainTitle, DbData, PrcField.Fund, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 1:
                        AssignChartFIlterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.BocName);
                        if (DbData.Source == Source.RegionAccount)
                            BocFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Budget Object Class" };
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, PrcField.BocName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 2:
                        AssignChartFIlterControls(NpmFilter1, NpmFilter2, NpmFilter3, NpmFilter4);
                        AssignChartExpanders(NpmExpander1, NpmExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.NPM);
                        if (DbData.Source == Source.RegionAccount)
                            NpmFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By National Program" };
                        NpmChart = new BudgetChart(NpmChart, ChartMainTitle, DbData, PrcField.NPM, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 3:
                        AssignChartFIlterControls(GoalFilter1, GoalFilter2, GoalFilter3, GoalFilter4);
                        AssignChartExpanders(GoalExpander1, GoalExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.GoalName);
                        if (DbData.Source == Source.RegionAccount)
                            GoalFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Agency Goal" };
                        GoalChart = new BudgetChart(GoalChart, ChartMainTitle, DbData, PrcField.GoalName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 4:
                        AssignChartFIlterControls(ObjectiveFilter1, ObjectiveFilter2, ObjectiveFilter3, ObjectiveFilter4);
                        AssignChartExpanders(ObjectiveExpander1, ObjectiveExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.ObjectiveName);
                        if (DbData.Source == Source.RegionAccount)
                            ObjectiveFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Agency Objective" };
                        ObjectiveChart = new BudgetChart(ObjectiveChart, ChartMainTitle, DbData, PrcField.ObjectiveName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 5:
                        AssignChartFIlterControls(DivisionFilter1, DivisionFilter2, DivisionFilter3, DivisionFilter4);
                        AssignChartExpanders(DivisionExpander1, DivisionExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.DivisionName);
                        if (DbData.Source == Source.RegionAccount)
                            DivisionFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Division" };
                        DivisionChart = new BudgetChart(DivisionChart, ChartMainTitle, DbData, PrcField.RC, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 6:
                        AssignChartFIlterControls(AreaFilter1, AreaFilter2, AreaFilter3, AreaFilter4);
                        AssignChartExpanders(AreaExpander1, AreaExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.ProgramAreaName);
                        if (DbData.Source == Source.RegionAccount)
                            AreaFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Program Area" };
                        AreaChart = new BudgetChart(AreaChart, ChartMainTitle, DbData, PrcField.ProgramArea, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                    case 7:
                        AssignChartFIlterControls(ProjectFilter1, ProjectFilter2, ProjectFilter3, ProjectFilter4);
                        AssignChartExpanders(ProjectExpander1, ProjectExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, PrcField.ProgramProjectName);
                        if (DbData.Source == Source.RegionAccount)
                            ProjectFilter4.Items.Remove("RC");
                        ChartMainTitle = new string[] { "Funding By Program Project" };
                        ProjectChart = new BudgetChart(ProjectChart, ChartMainTitle, DbData, PrcField.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        string[] GetTitle(TabControlAdv tab, MetroSetComboBox filter)
        {
            try
            {
                var category = tab.TabPages[CurrentTabIndex].Tag.ToString();
                var index = filter.SelectedIndex;
                switch (index)
                {
                    case 0:
                        return new string[] { string.Format("Total Funding by {0}", category) };
                    case 1:
                        return new string[] { string.Format("Total Accounts by {0}", category) };
                    case 2:
                        return new string[] { string.Format("Average Funding by {0}", category) };
                    case 3:
                        return new string[] { string.Format("Funding Percentage by {0}", category) };
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        string[] GetTitle(TabControlAdv tab, MetroSetComboBox filter1, MetroSetComboBox filter2, MetroSetComboBox filter3)
        {
            try
            {
                var source = filter2.SelectedItem.ToString();
                var category = tab.TabPages[CurrentTabIndex].Tag.ToString();
                var index = filter1.SelectedIndex;
                var grouping = filter3.SelectedItem.ToString();
                switch (index)
                {
                    case 0:
                        return new string[] { string.Format("Total {0} Funding by {1}", source, grouping) };
                    case 1:
                        return new string[] { string.Format("{0}  Accounts by {1}", source, grouping) };
                    case 2:
                        return new string[] { string.Format("Average {0} Funding by {1}", source, grouping)};
                    case 3:
                        return new string[] { string.Format("{0} Funding Percentage by {1}", source, grouping)};
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        private Dictionary<string, object> GetSelectedRowParameter(DataGridView dgv)
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