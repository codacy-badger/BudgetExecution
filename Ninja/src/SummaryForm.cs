// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SummaryForm.cs" company="">
//
// </copyright>
// <summary>
//   The summary form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MakarovDev.ExpandCollapsePanel;
using MetroFramework.Controls;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using VisualPlus.Toolkit.Controls.Interactivity;
using DataTable = System.Data.DataTable;

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
            Source = Source.DivisionAccounts;
            Provider = Provider.SQLite;
            Parameter = new Dictionary<string, object> { ["RC"] = rc };
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, Parameter);
            Table = DbData.Table;
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            Grid.DataSource = BindingSource;
            DatabaseTab.TabVisible = true;
            ProjectTab.TabVisible = true;
            DivisionTab.TabVisible = false;
            Metric = new PrcMetric(DbData);
            Text = string.Format("{0} Summary", Info.DivisionName(rc));
            TabNames = GetTabNames();
            EditTab.TabVisible = false;
        }

        public SummaryForm(Source source)
        {
            InitializeComponent();
            if(source == Source.RegionalAccounts || source == Source.DivisionAccounts)
            {
                DbData = new DataBuilder(source);
                Table = DbData.Table;
                ProgramElements = DbData.GetProgramElements(Table);
                BFY = ProgramElements["BFY"];
                BudgetLevel = ProgramElements["BudgetLevel"];
                Org = ProgramElements["Org"];
                AH = ProgramElements["AH"];
                RC = ProgramElements["RC"];
                BOC = ProgramElements["BOC"];
                Code = ProgramElements["Code"];
                SubProject = ProgramElements["SubProject"];
                BindingSource.DataSource = DbData.Table;
                Grid.DataSource = BindingSource;
                Source = source;
                TabNames = GetTabNames();
                Text = @"R6 Summary";
                Metric = new PrcMetric(DbData);
                ProjectTab.TabVisible = false;
                DatabaseTab.TabVisible = false;
                GridFundFilter.Visible = false;
                lblFund.Visible = false;
                GridBocFilter.Visible = false;
                lblBoc.Visible = false;
                PopulateGridYearFilterItems();
            }
            else
            {
                Source = source;
                DbData = new DataBuilder(source);
                Table = DbData.Table;
                ProgramElements = DbData.GetProgramElements(Table);
                BFY = ProgramElements["BFY"];
                BudgetLevel = ProgramElements["BudgetLevel"];
                Org = ProgramElements["Org"];
                AH = ProgramElements["AH"];
                RC = ProgramElements["RC"];
                BOC = ProgramElements["BOC"];
                Code = ProgramElements["Code"];
                SubProject = ProgramElements["SubProject"];
                TabNames = GetTabNames();
                Text = $@"R6 {Source.ToString()} Summary";
                Metric = new PrcMetric(DbData);
                BindingSource.DataSource = DbData.Table;
                Grid.DataSource = BindingSource;
                ProjectTab.TabVisible = true;
                DatabaseTab.TabVisible = true;
                DivisionTab.TabVisible = false;
                GoalTab.TabVisible = false;
                ObjectiveTab.TabVisible = false;
                GridGroupBox.Text = $"{Source.ToString()}";                
                label32.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("c");
                label37.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                label41.Text = DbData.GetCount(Table).ToString();
                lblFund.Visible = false;
                GridFundFilter.Visible = false;
                lblBoc.Visible = false;
                GridBocFilter.Visible = false;
                PopulateGridYearFilterItems();
                ConfigureTextBoxBindings();
            }
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Dictionary<string, object> Parameter { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow DbRow { get; set; }

        public PrcMetric Metric { get; set; }

        public ChartSeriesType ChartType { get; set; }

        public string[] BudgetLevel { get; set; }

        public string[] BFY { get; set; }

        public string[] Org { get; set; }

        public string[] RC { get; set; }

        public string[] AH { get; set; }

        public string[] Code { get; set; }

        public string[] BOC { get; set; }

        public string[] Fund { get; set; }

        public string[] SubProject { get; set; }

        public Field ChartField { get; set; }

        public string ChartFilter { get; set; }

        public string GridFilter1 { get; set; }

        public string GridFilter2 { get; set; }

        public string GridFilter3 { get; set; }

        public string Division { get; set; }

        public Field ChartGroup { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public string[] ChartMainTitle { get; set; }

        public string[] ChartAxisTitle { get; set; }

        public int CurrentTabIndex { get; set; }

        public VisualComboBox GridFilterControl1 { get; set; }

        public VisualComboBox GridFilterControl2 { get; set; }

        public VisualComboBox GridFilterControl3 { get; set; }

        public VisualComboBox ChartFilterControl1 { get; set; }

        public VisualComboBox ChartFilterControl2 { get; set; }

        public VisualComboBox ChartFilterControl3 { get; set; }

        public VisualComboBox ChartFilterControl4 { get; set; }

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
                PopulateComboBoxes();
                PopulateGridFundFilterItems();
            }

            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridYearFilter = sender as VisualComboBox;
                GridFilter1 = GridYearFilter?.SelectedItem.ToString();
                BindingSource.Filter = $"BFY = '{GridFilter1}'";
                var table = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Select(p => p).CopyToDataTable();
                label41.Text = table.Rows.Count.ToString();
                label37.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                label32.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                PopulateGridFundFilterItems();
                lblBoc.Visible = true;
                GridFundFilter.Visible = true;
                if(GridBocFilter.Visible == true)
                {
                    GridBocFilter.Items.Clear();
                }

                GridGroupBox.Text = $"{Source.ToString()} {GridFilter1}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridFundFilter = sender as VisualComboBox;
                GridFilter1 = GridYearFilter?.SelectedItem.ToString();
                GridFilter2 = GridFundFilter?.SelectedItem.ToString();
                BindingSource.Filter = $"BFY = '{GridFilter1}' AND FundName = '{GridFilter2}'";
                var table = DbData.Table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFilter1)).Where(p => p.Field<string>("BocName").Equals(GridFilter2)).Select(p => p).CopyToDataTable();
                label41.Text = table.Rows.Count.ToString();
                label37.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                label32.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                PopulateGridBocFilterItems();
                GridBocFilter.Visible = true;
                GridBocFilter.SelectionChangeCommitted += GridFilterControl3_ItemSelected;
                GridGroupBox.Text = $"{Source.ToString()} {GridFilter1} {GridFilter2}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                GridBocFilter = sender as VisualComboBox;
                GridFilter1 = GridYearFilter?.SelectedItem.ToString();
                GridFilter2 = GridFundFilter?.SelectedItem.ToString();
                GridFilter3 = GridBocFilter?.SelectedItem.ToString();
                BindingSource.Filter = $"BFY = '{GridFilter1}' AND FundName = '{GridFilter2}' AND BocName = '{GridFilter3}'";
                var table = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Where(p => p.Field<string>("FundName").Equals(GridFilter2))
                                  .Where(p => p.Field<string>("BocName").Equals(GridFilter3)).Select(p => p).CopyToDataTable();
                label41.Text = table.Rows.Count.ToString();
                label37.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                label32.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                GridGroupBox.Text = $"{Source.ToString()} {GridFilter2} {GridFilter1} {GridFilter3} ";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FilterDataGrid()
        {
            try
            {
                BindingSource.Filter = $"FundName = '{GridFundFilter.SelectedItem}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
        
        internal void PopulateGridFundFilterItems()
        {
            try
            {
                GridFundFilter.Items.Clear();
                GridFundFilter.Visible = true;
                DataTable table = (DataTable) BindingSource.DataSource;
                foreach(string row in table.AsEnumerable().Select(p => p.Field<string>("FundName")).Distinct().ToArray())
                {
                    GridFundFilter.Items.Add(row);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateGridBocFilterItems()
        {
            try
            {
                GridBocFilter.Items.Clear();
                GridBocFilter.Visible = true;
                DataTable table = new DataTable();
                table = (DataTable) BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString())).Select(p => p).Distinct().CopyToDataTable();
                foreach(string row in query.AsEnumerable().Select(p => p.Field<string>("BocName")).Distinct().ToArray())
                {
                    GridBocFilter.Items.Add(row);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateGridYearFilterItems()
        {
            try
            {
                GridYearFilter.Items.Clear();
                DataTable table = new DataTable();
                table = (DataTable) BindingSource.DataSource;
                var query = table.AsEnumerable().Select(p => p.Field<string>("BFY")).Distinct().ToArray();
                foreach(string row in query)
                {
                    GridYearFilter.Items.Add(row);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
       
        internal void PopulateFilterBoxItems(VisualComboBox cmbox, string prcfilter)
        {
            try
            {
                if(cmbox.Items.Count > 0)
                {
                    cmbox.Items.Clear();
                }               
                
                DataTable table = (DataTable) BindingSource.DataSource;
                foreach(var row in table.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(prcfilter)).Select(p => p).Distinct().ToArray())
                {
                    cmbox.Items.Add(row["FundName"].ToString());
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterBoxItems(ComboBox cmbox, string[] names)
        {
            try
            {
                foreach(string t in names)
                {
                    cmbox.Items.Clear();
                    cmbox.Items.Add(t);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void DefineVisisbleDataColumns(DataGridView dgv)
        {
            try
            {
                foreach(DataGridViewColumn dc in dgv.Columns)
                {
                    dc.Visible = false;
                }

                //dgv.Columns[0].Visible = true;

                //dgv.Columns[1].Visible = true;

                //dgv.Columns[2].Visible = true;

                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;

                dgv.Columns[5].Visible = true;
                //dgv.Columns[6].Visible = true;

                dgv.Columns[7].Visible = true;
                dgv.Columns[8].Visible = true;

                dgv.Columns[9].Visible = true;
                dgv.Columns[10].Visible = true;

                //dgv.Columns[11].Visible = true;
                dgv.Columns[12].Visible = true;
                dgv.Columns[13].Visible = true;
                dgv.Columns[13].DefaultCellStyle.Format = "c";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateComboBoxes()
        {
            DataTable table = new DataTable();
            table = (DataTable) BindingSource.DataSource;
            var query = table.AsEnumerable().Select(p => p.Field<string>("SubProject")).Distinct().ToArray();
            foreach(string row in query)
            {
                AddSub.Items.Add(row);
            }

            var year = table.AsEnumerable().Select(p => p.Field<string>("BFY")).Distinct().ToArray();
            foreach(string s in year)
            {
                AddYear.Items.Add(s);
            }
           
            var code = table.AsEnumerable().Select(p => p.Field<string>("Code")).Distinct().ToArray();
            foreach(string c in code)
            {
                AddCode.Items.Add(c);
            }
            
            var fund = table.AsEnumerable().Select(p => p.Field<string>("Fund")).Distinct().ToArray();
            foreach(string f in fund)
            {
                AddFund.Items.Add(f);
            }
            
            var rc = table.AsEnumerable().Select(p => p.Field<string>("RC")).Distinct().ToArray();
            foreach(string r in rc)
            {
                AddRc.Items.Add(r);
            }
            
            var bl = table.AsEnumerable().Select(p => p.Field<string>("BudgetLevel")).Distinct().ToArray();
            foreach(string r in bl)
            {
                AddLevel.Items.Add(r);
            }
            
            var org = table.AsEnumerable().Select(p => p.Field<string>("Org")).Distinct().ToArray();
            foreach(string o in org)
            {
                AddOrg.Items.Add(o);
            }          
            
            var ah = table.AsEnumerable().Select(p => p.Field<string>("AH")).Distinct().ToArray();
            foreach(string a in ah)
            {
                AddAh.Items.Add(a);
            }
            
            var boc = table.AsEnumerable().Select(p => p.Field<string>("BOC")).Distinct().ToArray();
            foreach(string b in boc)
            {
                AddBoc.Items.Add(b);
            }
        }
       
        private void ConfigureTextBoxBindings()
        {
            try
            {
                Updateid.DataBindings.Add(new Binding("Text", Grid.DataSource, "PrcID"));
                UpdateBudgetLevel.DataBindings.Add(new Binding("Text", Grid.DataSource, "BudgetLevel"));
                UpdateBFY.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                UpdateFund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                UpdateAH.DataBindings.Add(new Binding("Text", Grid.DataSource, "AH"));
                UpdateOrg.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                UpdateRC.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                UpdateCode.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                UpdateBOC.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                Amount.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GridRefreshButton_OnClick(object sender, EventArgs e)
        {
            if(DbData != null)
            {
                try
                {
                    BindingSource.Filter = null;
                    Grid.DataSource = BindingSource;
                    var table = DbData.Table.AsEnumerable().Select(p => p).CopyToDataTable();
                    label41.Text = table.Rows.Count.ToString();
                    label37.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                    label32.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                    GridBocFilter.Items.Clear();
                    GridYearFilter.Items.Clear();
                    lblBoc.Visible = false;
                    GridBocFilter.Visible = false;
                    lblPrc.Visible = false;
                    GridYearFilter.Visible = false;
                    PopulateGridFundFilterItems();
                    GridGroupBox.Text = $"{Source.ToString()}";
                }
                catch(Exception ex)
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
                for(int i = 0; i < SummaryTabControl.TabPages.Count; i++)
                {
                    names[i] = tabs[i].Text;
                }

                return names;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private void ChartFilterControl1_ItemSelected(object sender, EventArgs e)
        {
            ChartFilterControl1 = sender as VisualComboBox;
            if(ChartFilterControl1 != null)
            {
                ChartType = (ChartSeriesType) Enum.Parse(typeof(ChartSeriesType), ChartFilterControl1.SelectedItem.ToString());
            }

            if(Expander2.IsExpanded)
            {
                Expander2.IsExpanded = false;
            }
        }

        private void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl2 = sender as VisualComboBox;
                if(ChartFilterControl2?.SelectedItem != null)
                {
                    Measure = (Stat) Enum.Parse(typeof(Stat), ChartFilterControl2?.SelectedItem.ToString());
                }

                if(Expander2.IsExpanded == false)
                {
                    Expander2.IsExpanded = true;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartFilterControl3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl3 = sender as VisualComboBox;
                ChartField = (Field) Enum.Parse(typeof(Field), ChartFilterControl3?.Tag.ToString() ?? throw new InvalidOperationException());
                ChartFilter = ChartFilterControl3.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ChartFilterControl4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl4 = sender as VisualComboBox;
                if(ChartFilterControl4 != null)
                {
                    ChartGroup = (Field) Enum.Parse(typeof(Field), ChartFilterControl4?.SelectedItem.ToString());
                    ChartMainTitle = new[]
                    {
                        $"{Text} {ChartFilter} By {ChartFilterControl4.SelectedItem} "
                    };
                }

                Dictionary<string, object> param = new Dictionary<string, object> { [ChartField.ToString()] = ChartFilter };
                switch(CurrentTabIndex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void AssignChartFilterControls(VisualComboBox filter1, VisualComboBox filter2, VisualComboBox filter3, VisualComboBox filter4)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
        
        internal void SummaryTabPage_TabSelected(object sender, EventArgs e)
        {
            try
            {
                SummaryTabControl = sender as TabControlAdv;
                if(SummaryTabControl != null)
                {
                    CurrentTabIndex = SummaryTabControl.SelectedIndex;
                }

                switch(CurrentTabIndex)
                {
                    case 0:
                        AssignChartFilterControls(FundFilter1, FundFilter2, FundFilter3, FundFilter4);
                        AssignChartExpanders(FundExpander1, FundExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, "FundName");
                        if(Source == Source.RegionalAccounts)
                        {
                            FundFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Appropriation"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Appropriation"
                            };
                        }

                        FundChart = new BudgetChart(FundChart, ChartMainTitle, DbData, Field.Fund, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 1:
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, "BocName");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Object Class"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Object Class"
                            };
                        }

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.BocName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 2:
                        AssignChartFilterControls(NpmFilter1, NpmFilter2, NpmFilter3, NpmFilter4);
                        AssignChartExpanders(NpmExpander1, NpmExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.NPM.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            NpmFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By HQ NPM"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By HQ NPM"
                            };
                        }

                        NpmChart = new BudgetChart(NpmChart, ChartMainTitle, DbData, Field.NPM, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 3:
                        AssignChartFilterControls(GoalFilter1, GoalFilter2, GoalFilter3, GoalFilter4);
                        AssignChartExpanders(GoalExpander1, GoalExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.GoalName.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            GoalFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Agency Goal"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Agency Goal"
                            };
                        }

                        GoalChart = new BudgetChart(GoalChart, ChartMainTitle, DbData, Field.GoalName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 4:
                        AssignChartFilterControls(ObjectiveFilter1, ObjectiveFilter2, ObjectiveFilter3, ObjectiveFilter4);
                        AssignChartExpanders(ObjectiveExpander1, ObjectiveExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ObjectiveName.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            ObjectiveFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Objective"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Objective"
                            };
                        }

                        ObjectiveChart = new BudgetChart(ObjectiveChart, ChartMainTitle, DbData, Field.ObjectiveName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 5:
                        AssignChartFilterControls(DivisionFilter1, DivisionFilter2, DivisionFilter3, DivisionFilter4);
                        AssignChartExpanders(DivisionExpander1, DivisionExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.DivisionName.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            DivisionFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Division"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Division"
                            };
                        }

                        DivisionChart = new BudgetChart(DivisionChart, ChartMainTitle, DbData, Field.DivisionName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 6:
                        AssignChartFilterControls(AreaFilter1, AreaFilter2, AreaFilter3, AreaFilter4);
                        AssignChartExpanders(AreaExpander1, AreaExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ProgramAreaName.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            AreaFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Program Area"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Program Area"
                            };
                        }

                        AreaChart = new BudgetChart(AreaChart, ChartMainTitle, DbData, Field.ProgramAreaName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 7:
                        AssignChartFilterControls(ProjectFilter1, ProjectFilter2, ProjectFilter3, ProjectFilter4);
                        AssignChartExpanders(ProjectExpander1, ProjectExpander2);
                        PopulateFilterBoxItems(ChartFilterControl3, Field.ProgramProjectCode.ToString());
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            ProjectFilter4.Items.Remove("RC");
                        }

                        if(Division != null)
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Division} Funding By Program Project"
                            };
                        }
                        else
                        {
                            ChartMainTitle = new[]
                            {
                                $"{Source.ToString()} Funding By Program Project"
                            };
                        }

                        ProjectChart = new BudgetChart(ProjectChart, ChartMainTitle, DbData, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 8:
                        DefineVisisbleDataColumns(Grid);
                        var table = DbData.Table.AsEnumerable().Select(p => p).CopyToDataTable();
                        label41.Text = table.Rows.Count.ToString();
                        label37.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                        label32.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                        GridGroupBox.Text = $"{Source.ToString()}";
                        UpdateAccountChart();
                        break;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
        
        private string[] GetTitle(TabControlAdv tab, VisualComboBox filter1, VisualComboBox filter2, VisualComboBox filter3)
        {
            try
            {
                string source = filter2.SelectedItem.ToString();
                string category = tab.TabPages[CurrentTabIndex].Tag.ToString();
                int index = filter1.SelectedIndex;
                string grouping = filter3.SelectedItem.ToString();
                switch(index)
                {
                    case 0:
                        return new[]
                        {
                            string.Format("Total {0} Funding by {1}", source, grouping)
                        };

                    case 1:
                        return new[]
                        {
                            string.Format("{0}  Accounts by {1}", source, grouping)
                        };

                    case 2:
                        return new[]
                        {
                            string.Format("Average {0} Funding by {1}", source, grouping)
                        };

                    case 3:
                        return new[]
                        {
                            string.Format("{0} Funding Percentage by {1}", source, grouping)
                        };
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private Dictionary<string, object> GetSelectedRowPrcDictionary()
        {
            try
            {
                if(Grid.CurrentRow != null)
                {
                    DataGridViewRow dgvRow = Grid.CurrentRow;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    //data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
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
            catch(Exception ex)
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
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Grid_OnDoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView) BindingSource.Current;
                Dictionary<string, object> prc = new PRC(view.Row).GetDataFields();
                AccountManager am = new AccountManager(Source, Provider.SQLite, prc);
                am.Show();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void ReprogramButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rp = new Reprogramming();
            rp.Show();
        }

        internal void UpdateAccountChart()
        {
            try
            {
                DataRowView drv = (DataRowView) BindingSource.Current;
                string code = drv["Code"].ToString();
                decimal total = DbData.Table.AsEnumerable().Where(p => p.Field<string>("Code").Contains(code)).Select(p => p.Field<decimal>("Amount")).Sum();
                DataRow current = drv.Row;
                decimal amt = decimal.Parse(current["Amount"].ToString());
                decimal ratio = amt / total;
                Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double) total, ["Allocation"] = (double) amt };
                ChartMainTitle = new[]
                {
                    $"{ratio.ToString("P")} {Source.ToString()} PRC {current["Code"]} Funding"
                };
                AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void UpdateAccountChart(object sender, EventArgs e)
        {
            try
            {
                Grid = sender as MetroGrid;
                DataRowView drv = (DataRowView) BindingSource.Current;
                string code = drv["Code"].ToString();
                decimal total = DbData.Table.AsEnumerable().Where(p => p.Field<string>("Code").Contains(code)).Select(p => p.Field<decimal>("Amount")).Sum();
                DataRow current = drv.Row;
                decimal amt = decimal.Parse(current["Amount"].ToString());
                decimal ratio = amt / total;
                Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double) total, ["Allocation"] = (double) amt };
                ChartMainTitle = new[]
                {
                    $"{ratio.ToString("P")} PRC {current["Code"]} Funding"
                };
                AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void AccountChart_Click(object sender, EventArgs e) { }

        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void BocExpander1_Paint(object sender, PaintEventArgs e) { }

        private void lblPrc_Click(object sender, EventArgs e)
        {

        }
    }
}
