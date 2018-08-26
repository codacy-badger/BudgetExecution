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
            Source = Source.DivisionAccounts;
            Provider = Provider.SQLite;
            Parameter = new Dictionary<string, object> { ["RC"] = rc };
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, Parameter);
            Table = DbData.DbTable;
            DatabaseTab.TabVisible = true;
            ProjectTab.TabVisible = true;
            DivisionTab.TabVisible = false;
            ProgramElements = DbData.ProgramElements;
            Metric = new PrcMetric(DbData);
            Text = string.Format("{0} Summary", Info.DivisionName(rc));
            CurrentTabIndex = SummaryTabControl.SelectedIndex;
            SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
            CurrentTabIndex = 8;
            TabNames = GetTabNames();
            EditTab.TabVisible = false;
        }
        
        public SummaryForm(Source source)
        {
            InitializeComponent();
            DbData = new DataBuilder(source, Provider.SQLite);
            Table = DbData.DbTable;
            Source = source;
            Provider = Provider.SQLite;
            TabNames = GetTabNames();
            Text = $@"R6 {Source.ToString()} Summary";
            Metric = new PrcMetric(DbData);
            ProgramElements = Metric.ProgramElements;
            BindingSource.DataSource = Metric.Table;
            ProjectTab.TabVisible = true;
            DatabaseTab.TabVisible = true;
            SummaryTabControl.SelectedIndex = 8;
            SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
            if (source == Source.RegionalAccounts || source == Source.DivisionAccounts)
            {
                DbData = new DataBuilder(source, Provider.SQLite);
                Table = DbData.DbTable;
                Source = source;
                TabNames = GetTabNames();
                Text = @"R6 Summary";
                Metric = new PrcMetric(DbData);
                ProgramElements = Metric.ProgramElements;
                BindingSource.DataSource = Metric.Table;
                ProjectTab.TabVisible = false;
                DatabaseTab.TabVisible = true;
                CurrentTabIndex = SummaryTabControl.SelectedIndex;
                SummaryTabControl.SelectedIndex = 8;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
            }

        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Dictionary<string, object> Parameter { get; set; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; set; }

        public DataRow DbRow { get; set; }

        public PrcMetric Metric { get; set; }

        public ChartSeriesType ChartType { get; set; }

        public Field ChartField { get; set; }

        public string ChartFilter { get; set; }

        public string Division { get; set; }

        public Field ChartGroup { get; set; }

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

        private string[] TabNames { get; }

        // METHODS
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (DbData.Source == Source.FTE)
                {
                    BocTab.TabVisible = false;
                    EditTab.TabVisible = false;
                }

                if (DbData.Source == Source.RegionalAccounts)
                {
                    DivisionTab.TabVisible = false;
                    DatabaseTab.TabVisible = false;
                    ProjectTab.TabVisible = false;
                    EditTab.TabVisible = false;
                }
                
                if (DbData.Source == Source.DivisionAccounts)
                {
                    DivisionTab.TabVisible = false;
                    DatabaseTab.TabVisible = false;
                    ProjectTab.TabVisible = false;
                    EditTab.TabVisible = false;
                }
                
                EditTab.TabVisible = false;
                DivisionTab.TabVisible = false;
                BindingSource.DataSource = Table;
                Grid.DataSource = BindingSource;
                DefineVisisbleDataColumns(Grid);
                PopulateFilterBoxItems(GridFundFilter, Field.FundName);
                ConfigureTextBoxBindings();
                label32.Text = DbData.GetTotal(DbData.DbTable).ToString("c");
                label37.Text = DbData.DbTable.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                label41.Text = DbData.GetCount(DbData.DbTable).ToString();
                GridFundFilter.SelectionChangeCommitted += GridFilterControl1_ItemSelected;
                GridBocFilter.SelectionChangeCommitted += GridFilterControl2_ItemSelected;
                SummaryTabControl.SelectedIndexChanged += SummaryTabPage_TabSelected;
                FundChart = new BudgetChart(FundChart, DbData, Field.FundName).Activate();
                lblPrc.Visible = false;
                GridAccountFilter.Visible = false;
                lblBoc.Visible = false;
                GridBocFilter.Visible = false;
                GridRefreshButton.Click += GridRefreshButton_OnClick;
                ExcelButton.Click += ExcelButton_Click;
                CalendatButton.Click += CalendarButton_Click;
                CalculatorButton.Click += CalculatorButton_Click;
                Grid.SelectionChanged += UpdateAccountChart;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridFilterControl1 = sender as MetroSetComboBox;
                GridFundFilter.Tag = GridFilterControl1?.SelectedItem.ToString();
                string fund = GridFilterControl1?.SelectedItem.ToString();
                BindingSource.Filter = string.Format("FundName = '{0}'", GridFundFilter.SelectedItem);
                label41.Text = GetCount(fund).ToString();
                label37.Text = CalculateAverage(fund).ToString("N");
                label32.Text = CalculateTotal(fund).ToString("c");
                PopulateGridBocFilterItems();
                lblBoc.Visible = true;
                GridBocFilter.Visible = true;
                GridGroupBox.Text = $"{Source.ToString()} {GridFilterControl1?.SelectedItem} Database";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridFilterControl2 = sender as MetroSetComboBox;
                string filter = GridFilterControl2?.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem}' AND BocName = '{GridBocFilter.SelectedItem}'";
                label32.Text = CalculateTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                label37.Text = CalculateAverage(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                label41.Text = GetCount(GridFundFilter.SelectedItem.ToString(), filter).ToString();
                GridAccountFilter.Visible = true;
                lblPrc.Visible = true;
                GridAccountFilter.Visible = true;
                PopulateGridAccountFilterItems();
                GridAccountFilter.SelectionChangeCommitted += GridFilterControl3_ItemSelected;
                GridGroupBox.Text = $"{Source.ToString()} {GridFilterControl1?.SelectedItem} {GridFilterControl2?.SelectedItem} Database";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                MetroSetComboBox prc = sender as MetroSetComboBox;
                string filter = prc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem}' AND BocName = '{GridBocFilter.SelectedItem}' AND Code = '{filter}'";
                label32.Text = CalculateTotal(GridFundFilter.SelectedItem.ToString(), filter).ToString("c");
                label41.Text = GetCount(GridFundFilter.SelectedItem.ToString(), filter).ToString();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGrid()
        {
            try
            {
                if (GridFundFilter.SelectedItem.ToString() != null)
                {
                    BindingSource.Filter = string.Format("FundName = '{0}' AND BocName = '{1}'", GridFundFilter.SelectedItem, GridBocFilter.SelectedItem);
                }

                BindingSource.Filter = string.Format("FundName = '{0}'", GridBocFilter.SelectedItem);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void PopulateGridBocFilterItems()
        {
            try
            {
                GridBocFilter.Items.Clear();
                GridBocFilter.Visible = true;
                DataTable table = (DataTable)BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString())).Select(p => p).Distinct().CopyToDataTable();
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

        private void PopulateGridAccountFilterItems()
        {
            try
            {
                GridAccountFilter.Items.Clear();
                DataTable table = (DataTable)BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString())).Where(p => p.Field<string>("BocName").Equals(GridBocFilter.SelectedItem.ToString())).Select(p => p).CopyToDataTable();
                foreach (DataRow row in query.Rows)
                {
                    GridAccountFilter.Items.Add(row["Code"].ToString());
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private decimal GetCount(string filter)
        {
            try
            {
                return DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter)).Select(p => p.Field<decimal>("Amount") > 0).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        private decimal GetCount(string filter1, string filter2)
        {
            try
            {
                return DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1)).Where(p => p.Field<string>("BocName").Equals(filter2)).Select(p => p.Field<decimal>("Amount")).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, Field prcfilter)
        {
            try
            {
                if (cmbox.Items.Count > 0)
                {
                    cmbox.Items.Clear();
                }

                string[] items = DbData.ProgramElements[prcfilter.ToString()];
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

        private void PopulateFilterBoxItems(MetroSetComboBox cmbox, int i)
        {
            try
            {
                foreach (string t in TabNames)
                {
                    cmbox.Items.Clear();
                    cmbox.Items.Add(t);
                    cmbox.Items.Remove(SummaryTabControl.TabPages[i].Text);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void DefineVisisbleDataColumns(DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewColumn dc in dgv.Columns)
                {
                    dc.Visible = false;
                }

                dgv.Columns[0].Visible = true;
                
                //dgv.Columns[1].Visible = true;

                //dgv.Columns[2].Visible = true;
                
                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;
                
                //dgv.Columns[5].Visible = true;
                dgv.Columns[6].Visible = true;
                
                //dgv.Columns[7].Visible = true;
                dgv.Columns[8].Visible = true;
                
                //dgv.Columns[9].Visible = true;
                dgv.Columns[10].Visible = true;
                
                //dgv.Columns[11].Visible = true;
                dgv.Columns[12].Visible = true;
                dgv.Columns[13].Visible = true;
                dgv.Columns[13].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

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

        private void ConfigureTextBoxBindings()
        {
            try
            {
                ID.DataBindings.Add(new Binding("Text", Grid.DataSource, "ID"));
                BudgetLevel.DataBindings.Add(new Binding("Text", Grid.DataSource, "BudgetLevel"));
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
                new Error(ex).ShowDialog();
            }
        }

        private decimal CalculateAverage(string filter1)
        {
            try
            {
                return Table.AsEnumerable()
                    .Where(p => p.Field<string>("FundName").Equals(filter1))
                    .Select(p => p.Field<decimal>("Amount"))
                    .Average();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        private decimal CalculateAverage(string filter1, string filter2)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                    .Where(p => p.Field<string>("BocName").Equals(filter2))
                    .Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        private decimal CalculateTotal(string filter)
        {
            try
            {
                return DbData.DbTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter)).Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        private decimal CalculateTotal(string filter1, string filter2)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1)).Where(p => p.Field<string>("BocName").Equals(filter2)).Select(p => p.Field<decimal>("Amount")).Sum();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
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
                    Grid.DataSource = BindingSource;
                    label32.Text = DbData.GetTotal(DbData.DbTable).ToString("c");
                    label41.Text = DbData.GetCount(DbData.DbTable).ToString();
                    GridBocFilter.Items.Clear();
                    GridAccountFilter.Items.Clear();
                    PopulateFilterBoxItems(GridFundFilter, Field.FundName);
                    lblBoc.Visible = false;
                    GridBocFilter.Visible = false;
                    lblPrc.Visible = false;
                    GridAccountFilter.Visible = false;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                }
            }
        }

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

        private ChartSeriesType GetChartType(MetroSetComboBox ctb)
        {
            if (ctb.SelectedItem == null)
            {
                return ChartSeriesType.Column;
            }

            return (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ctb.SelectedItem.ToString());
        }

        private void ChartFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            ChartFilterControl1 = sender as MetroSetComboBox;
            ChartType = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), ChartFilterControl1.SelectedItem.ToString());
            if (Expander2.IsExpanded)
            {
                Expander2.IsExpanded = false;
            }
        }

        private void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl2 = sender as MetroSetComboBox;
                Measure = (Stat)Enum.Parse(typeof(Stat), ChartFilterControl2.SelectedItem.ToString());
                if (Expander2.IsExpanded == false)
                {
                    Expander2.IsExpanded = true;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl3 = sender as MetroSetComboBox;
                ChartField = (Field)Enum.Parse(typeof(Field), ChartFilterControl3.Tag.ToString());
                ChartFilter = ChartFilterControl3.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartFilterControl4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl4 = sender as MetroSetComboBox;
                ChartGroup = (Field)Enum.Parse(typeof(Field), ChartFilterControl4.SelectedItem.ToString());
                ChartMainTitle = new[] { $"{Text} {ChartFilter} By {ChartFilterControl4.SelectedItem} " };
                Dictionary<string, object> param = new Dictionary<string, object> { [ChartField.ToString()] = ChartFilter };
                switch (CurrentTabIndex)
                {
                    case 0:
                        FundChart = new BudgetChart(FundChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 1:
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 2:
                        NpmChart = new BudgetChart(NpmChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 3:
                        GoalChart = new BudgetChart(GoalChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 4:
                        ObjectiveChart = new BudgetChart(ObjectiveChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 5:
                        DivisionChart = new BudgetChart(DivisionChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 6:
                        AreaChart = new BudgetChart(AreaChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;

                    case 7:
                        ProjectChart = new BudgetChart(ProjectChart, ChartMainTitle, Source, param, ChartGroup, Measure, ChartType).Activate();
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void AssignChartFIlterControls(MetroSetComboBox filter1, MetroSetComboBox filter2, MetroSetComboBox filter3, MetroSetComboBox filter4)
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

        private void Expander_Click(object sender, EventArgs e)
        {
            ExpandCollapsePanel exp = sender as ExpandCollapsePanel;
            switch (CurrentTabIndex)
            {
                case 0:
                    if (FundExpander2.IsExpanded)
                    {
                        FundExpander2.IsExpanded = false;
                    }

                    break;

                case 1:
                    if (BocExpander2.IsExpanded)
                    {
                        BocExpander2.IsExpanded = false;
                    }

                    break;

                case 3:
                    if (NpmExpander2.IsExpanded)
                    {
                        NpmExpander2.IsExpanded = false;
                    }

                    break;

                case 4:
                    if (GoalExpander2.IsExpanded)
                    {
                        GoalExpander2.IsExpanded = false;
                    }

                    break;

                case 5:
                    if (ObjectiveExpander2.IsExpanded)
                    {
                        ObjectiveExpander2.IsExpanded = false;
                    }

                    break;

                case 6:
                    if (AreaExpander2.IsExpanded)
                    {
                        AreaExpander2.IsExpanded = false;
                    }

                    break;

                case 7:
                    if (ProjectExpander2.IsExpanded)
                    {
                        ProjectExpander2.IsExpanded = false;
                    }

                    break;
            }
        }

        private void SummaryTabPage_TabSelected(object sender, EventArgs e)
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
                        PopulateFilterBoxItems(ChartFilterControl3, Field.FundName);
                        if (Source == Source.RegionalAccounts)
                        {
                            FundFilter4.Items.Remove("RC");
                        }

                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Appropriation"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Appropriation"};
                        }

                        FundChart = new BudgetChart(FundChart, ChartMainTitle, DbData, Field.Fund, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 1:
                        AssignChartFIlterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.BocName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
                        }

                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Object Class"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Object Class"};
                        }

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.BocName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 2:
                        AssignChartFIlterControls(NpmFilter1, NpmFilter2, NpmFilter3, NpmFilter4);
                        AssignChartExpanders(NpmExpander1, NpmExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.NPM);
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            NpmFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By HQ NPM"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By HQ NPM"};
                        }

                        NpmChart = new BudgetChart(NpmChart, ChartMainTitle, DbData, Field.NPM, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 3:
                        AssignChartFIlterControls(GoalFilter1, GoalFilter2, GoalFilter3, GoalFilter4);
                        AssignChartExpanders(GoalExpander1, GoalExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.GoalName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            GoalFilter4.Items.Remove("RC");
                        }
                        
                        if(Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Agency Goal"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Agency Goal"};
                        }

                        GoalChart = new BudgetChart(GoalChart, ChartMainTitle, DbData, Field.GoalName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 4:
                        AssignChartFIlterControls(ObjectiveFilter1, ObjectiveFilter2, ObjectiveFilter3, ObjectiveFilter4);
                        AssignChartExpanders(ObjectiveExpander1, ObjectiveExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ObjectiveName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            ObjectiveFilter4.Items.Remove("RC");
                        }
                        
                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Objective"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Objective"};
                        }

                        ObjectiveChart = new BudgetChart(ObjectiveChart, ChartMainTitle, DbData, Field.ObjectiveName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 5:
                        AssignChartFIlterControls(DivisionFilter1, DivisionFilter2, DivisionFilter3, DivisionFilter4);
                        AssignChartExpanders(DivisionExpander1, DivisionExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.DivisionName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            DivisionFilter4.Items.Remove("RC");
                        }
                        
                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Division"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Division"};
                        }

                        DivisionChart = new BudgetChart(DivisionChart, ChartMainTitle, DbData, Field.RC, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 6:
                        AssignChartFIlterControls(AreaFilter1, AreaFilter2, AreaFilter3, AreaFilter4);
                        AssignChartExpanders(AreaExpander1, AreaExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ProgramAreaName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            AreaFilter4.Items.Remove("RC");
                        }
                        
                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Program Area"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Program Area"};
                        }

                        AreaChart = new BudgetChart(AreaChart, ChartMainTitle, DbData, Field.ProgramArea, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 7:
                        AssignChartFIlterControls(ProjectFilter1, ProjectFilter2, ProjectFilter3, ProjectFilter4);
                        AssignChartExpanders(ProjectExpander1, ProjectExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ProgramProjectName);
                        if (DbData.Source == Source.RegionalAccounts)
                        {
                            ProjectFilter4.Items.Remove("RC");
                        }
                        
                        if (Division != null)
                        {
                            ChartMainTitle = new[] {$"{Division} Funding By Program Project"};
                        }
                        else
                        {
                            ChartMainTitle = new[] {$"{Source.ToString()} Funding By Program Project"};
                        }

                        ProjectChart = new BudgetChart(ProjectChart, ChartMainTitle, DbData, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 8:
                        UpdateAccountChart();
                        break;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private string[] GetTitle(TabControlAdv tab, MetroSetComboBox filter)
        {
            try
            {
                string category = tab.TabPages[CurrentTabIndex].Tag.ToString();
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

        private string[] GetTitle(TabControlAdv tab, MetroSetComboBox filter1, MetroSetComboBox filter2, MetroSetComboBox filter3)
        {
            try
            {
                string source = filter2.SelectedItem.ToString();
                string category = tab.TabPages[CurrentTabIndex].Tag.ToString();
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

        private Dictionary<string, object> GetSelectedRowPrcDictionary()
        {
            try
            {
                if (Grid.CurrentRow != null)
                {
                    DataGridViewRow dgvRow = Grid.CurrentRow;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
                    //data.Add("Fund", dgvRow.Cells["Fund"].Value.ToString());
                    //data.Add("AH", dgvRow.Cells["AH"].Value.ToString());
                    //data.Add("Org", dgvRow.Cells["Org"].Value.ToString());
                    //data.Add("RC", dgvRow.Cells["RC"].ToString());
                    //data.Add("Code", dgvRow.Cells["Code"].ToString());
                    //data.Add("BOC", dgvRow.Cells["BOC"].ToString());
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

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.Show();
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            ExcelForm er = new ExcelForm();
            er.Show();
        }

        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountManager am = new AccountManager(Source.PRC, Provider);
                am.Update.TabVisible = false;
                am.AccountTabControl.SelectedIndex = 1;
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (EditTab.Visible == false)
                {
                    EditTab.Visible = true;
                }
                else
                {
                    EditTab.Visible = false;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Grid_OnDoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)BindingSource.Current;
                Dictionary<string, object> prc = new PRC(view.Row).GetDataFields();
                AccountManager am = new AccountManager(Source, Provider.SQLite, prc);
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ReprogramButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rp = new Reprogramming();
            rp.Show();
        }

        private void UpdateAccountChart()
        {           
            try
            {
                var drv = (DataRowView)BindingSource.Current;
                var code = drv["Code"].ToString();
                var total = drv.DataView.Table.AsEnumerable().Where(p => p.Field<string>("Code").Equals(code)).Select(p => p.Field<decimal>("Amount")).Sum();
                var current = drv.Row;
                decimal amt = decimal.Parse(current["Amount"].ToString());
                var ratio = amt / total;
                Dictionary<string, double> d = new Dictionary<string, double>{["Total"] = (double)total, ["Allocation"] = (double)amt};
                ChartMainTitle = new[] {$"{ratio.ToString("P")} PRC {current["Code"]} Funding"};
                AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void UpdateAccountChart(object sender, EventArgs e)
        {
            try
            {
                UpdateAccountChart();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }

        }

        private void AccountChart_Click(object sender, EventArgs e)
        {
        }

        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void BocExpander1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}