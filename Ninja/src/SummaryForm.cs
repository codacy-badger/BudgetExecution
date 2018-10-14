using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MakarovDev.ExpandCollapsePanel;
using MetroFramework.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using VisualPlus.Toolkit.Controls.Interactivity;

namespace BudgetExecution
{
    public partial class SummaryForm : MetroForm
    {
        // CONSTRUCTORS
        public SummaryForm()
        {
            InitializeComponent();
        }

        public SummaryForm(Source source)
        {
            InitializeComponent();
            if(source == Source.RegionalAccounts || source == Source.DivisionAccounts)
            {
                DbData = new DataBuilder(source);
                Table = DbData.Table;
                ProgramElements = DbData.GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbData.Table;
                Grid.DataSource = BindingSource;
                Source = source;
                GetTabNames();
                Text = @"R6 Summary";
                Metric = new PrcMetric(DbData);
                DatabaseTab.TabVisible = false;
                GridFundFilter.Visible = false;
                lblFund.Visible = false;
                GridBocFilter.Visible = false;
                lblBoc.Visible = false;
                PopulateGridYearFilterItems();
                ChartMainTitle = new[]
                {
                    $"{Source.ToString()} Funding By Appropriation"
                };
                BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.Fund, Stat.Total, ChartSeriesType.Column).Activate();
            }
            else
            {
                Source = source;
                DbData = new DataBuilder(source);
                Table = DbData.Table;
                ProgramElements = DbData.GetProgramElements(Table);
                GetTabNames();
                Text = $@"R6 {Source.ToString()} Summary";
                Metric = new PrcMetric(DbData);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbData.Table;
                Grid.DataSource = BindingSource;
                DatabaseTab.TabVisible = true;
                GridGroupBox.Text = $"{Source.ToString()}";
                lblTotal.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("c");
                lblAve.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblDev.Text = ((double) DbData.Table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                lblVar.Text = ((double) DbData.Table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                lblCount.Text = DbData.GetCount(Table).ToString();
                lblFund.Visible = false;
                GridFundFilter.Visible = false;
                lblBoc.Visible = false;
                GridBocFilter.Visible = false;
                PopulateGridYearFilterItems();
                ConfigureTextBoxBindings();
                DefineVisisbleDataColumns(Grid);
                ChartMainTitle = new[]
                {
                    $"{Source.ToString()} Funding By Appropriation"
                };
                BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.Fund, Stat.Total, ChartSeriesType.Column).Activate();
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

        public int CurrentIndex { get; set; }

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

        public TabPageAdv[] Tab { get; set; }

        // METHODS
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateComboBoxes();
                BocExpander1.Visible = false;
                BocExpander2.Visible = false;
                EditTab.Visible = false;
                AddTab.Visible = false;
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
                GridFilter1 = GridYearFilter?.SelectedItem.ToString();
                BindingSource.Filter = $"BFY = '{GridFilter1}'";
                DataTable table = new DataTable();
                table = ((DataTable) BindingSource.DataSource).AsEnumerable()
                                                              .Where(p => p.Field<decimal>("Amount") > 0)
                                                              .Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString()))
                                                              .Select(p => p)
                                                              .CopyToDataTable();
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                lblDev.Text = ((double) table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                lblVar.Text = ((double) table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                PopulateGridFundFilterItems();
                lblFund.Visible = true;
                GridFundFilter.Visible = true;
                if(GridBocFilter.Visible)
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
                GridFilter2 = GridFundFilter?.SelectedItem.ToString();
                BindingSource.Filter = $"BFY = '{GridYearFilter.SelectedItem}' AND FundName = '{GridFundFilter.SelectedItem}'";
                DataTable table = new DataTable();
                table = ((DataTable) BindingSource.DataSource).AsEnumerable()
                                                              .Where(p => p.Field<decimal>("Amount") > 0)
                                                              .Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString()))
                                                              .Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString()))
                                                              .Select(p => p)
                                                              .CopyToDataTable();
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                if(int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double) table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double) table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if(int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

                PopulateGridBocFilterItems();
                lblBoc.Visible = true;
                GridBocFilter.Visible = true;
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
                BindingSource.Filter = $"BFY = '{GridYearFilter?.SelectedItem}' AND FundName = '{GridFundFilter?.SelectedItem}' AND BocName = '{GridBocFilter?.SelectedItem}'";
                DataTable table = new DataTable();
                table = ((DataTable) BindingSource.DataSource).AsEnumerable()
                                                              .Where(p => p.Field<decimal>("Amount") > 0)
                                                              .Where(p => p.Field<string>("BFY").Equals(GridYearFilter.SelectedItem.ToString()))
                                                              .Where(p => p.Field<string>("FundName").Equals(GridFundFilter.SelectedItem.ToString()))
                                                              .Where(p => p.Field<string>("BocName").Equals(GridBocFilter.SelectedItem.ToString()))
                                                              .Select(p => p)
                                                              .CopyToDataTable();
                lblCount.Text = table.Rows.Count.ToString();
                lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                if(int.Parse(lblCount.Text) >= 4)
                {
                    lblDev.Text = ((double) table.Compute("StDev(Amount)", "Amount > 0")).ToString("N");
                    lblVar.Text = ((double) table.Compute("Var(Amount)", "Amount > 0")).ToString("N");
                }

                if(int.Parse(lblCount.Text) < 4)
                {
                    lblDev.Text = "NA";
                    lblVar.Text = "NA";
                }

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
                DataTable table = new DataTable();
                table = (DataTable) BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Select(p => p).CopyToDataTable();
                foreach(string row in query.AsEnumerable().Select(p => p.Field<string>("FundName")).Distinct().ToArray())
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
                DataTable table = (DataTable) BindingSource.DataSource;
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals(GridFilter1)).Where(p => p.Field<string>("FundName").Equals(GridFilter2)).Select(p => p).CopyToDataTable();
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

        internal void PopulateFilterBoxItems(VisualComboBox cmbox, Field col, string prcfilter)
        {
            try
            {
                if(cmbox.Items.Count > 0)
                {
                    cmbox.Items.Clear();
                }

                DataTable table = (DataTable) BindingSource.DataSource;
                foreach(var row in table.AsEnumerable().Where(p => p.Field<string>(col.ToString()).Equals(prcfilter)).Select(p => p).Distinct().ToArray())
                {
                    cmbox.Items.Add(row["FundName"].ToString());
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterBoxItems(VisualComboBox cmbox, string[] names)
        {
            try
            {
                cmbox.Items.Clear();
                foreach(string t in names)
                {
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
                //dgv.Columns[5].Visible = true;
                dgv.Columns[6].Visible = true;
                //dgv.Columns[7].Visible = true;
                dgv.Columns[8].Visible = true;
                //dgv.Columns[9].Visible = true;
                dgv.Columns[10].Visible = true;
                //dgv.Columns[11].Visible = true;
                //dgv.Columns[12].Visible = true;
                dgv.Columns[13].Visible = true;
                dgv.Columns[14].Visible = true;
                dgv.Columns[14].DefaultCellStyle.Format = "c";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateComboBoxes()
        {
            DataTable table = new DataBuilder(Source.PRC).Table;
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
                Updateid.DataBindings.Add(new Binding("Text", Grid.DataSource, "ID"));
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
                    lblCount.Text = DbData.Table.Rows.Count.ToString();
                    lblAve.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                    lblTotal.Text = DbData.Table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
                    GridBocFilter.Items.Clear();
                    GridYearFilter.Items.Clear();
                    GridFundFilter.Items.Clear();
                    GridFundFilter.Visible = false;
                    lblFund.Visible = false;
                    lblBoc.Visible = false;
                    GridBocFilter.Visible = false;
                    lblYear.Visible = true;
                    GridYearFilter.Visible = true;
                    PopulateGridYearFilterItems();
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

        private string[] GetTabPageTags()
        {
            try
            {
                var filters = new[]
                {
                    "FundName",
                    "BocName",
                    "NPM",
                    "GoalName",
                    "ObjectiveName",
                    "Division",
                    "ProgramArea",
                    "ProgramProjectCode"
                };

                return filters;
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

            if(Expander2.Visible && Expander2.IsExpanded)
            {
                Expander2.IsExpanded = false;
            }
        }

        private void ChartFilterControl2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                ChartFilterControl2 = sender as VisualComboBox;
                if(ChartFilterControl2.SelectedItem != null)
                {
                    Measure = (Stat) Enum.Parse(typeof(Stat), ChartFilterControl2.SelectedItem.ToString());
                }

                if(!Expander2.Visible || Expander2.IsExpanded == false)
                {
                    Expander2.Visible = true;
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
                if(ChartFilterControl3?.SelectedItem != null)
                {
                    ChartFilter = ChartFilterControl3?.SelectedItem.ToString();
                }

                BocFilter4.Items.Clear();
                var filters = new[]
                {
                    "FundName",
                    "BocName",
                    "NPM",
                    "GoalName",
                    "ObjectiveName",
                    "Division",
                    "ProgramArea",
                    "ProgramProjectCode"
                };

                foreach(string s in filters)
                {
                    BocFilter4.Items.Add(s);
                }

                BocFilter4.Items.Remove(PrimaryFilter.SelectedItem.ToString());
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
                    ChartGroup = (Field) Enum.Parse(typeof(Field), ChartFilterControl4.SelectedItem.ToString());
                    ChartMainTitle = new[]
                    {
                        $"{Text} {ChartFilter} By {ChartFilterControl4.SelectedItem} "
                    };
                }

                switch(ChartGroup)
                {
                    case Field.FundName :
                        var fp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var fd = new DataBuilder(Source, Provider, fp);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, fd, Field.FundName, Measure, ChartType).Activate();
                        break;

                    case Field.BocName :
                        var bp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var bd = new DataBuilder(Source, Provider, bp);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, bd, Field.BocName, Measure, ChartType).Activate();
                        break;

                    case Field.NPM :
                        var np = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var nd = new DataBuilder(Source, Provider, np);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, nd, Field.NPM, Measure, ChartType).Activate();
                        break;

                    case Field.GoalName :
                        var gp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var gd = new DataBuilder(Source, Provider, gp);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, gd, Field.GoalName, Measure, ChartType).Activate();
                        break;

                    case Field.ObjectiveName :
                        var op = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var od = new DataBuilder(Source, Provider, op);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, od, Field.ObjectiveName, Measure, ChartType).Activate();
                        break;

                    case Field.Division :
                        var dp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var dd = new DataBuilder(Source, Provider, dp);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, dd, Field.Division, Measure, ChartType).Activate();
                        break;

                    case Field.ProgramArea :
                        var ap = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var ad = new DataBuilder(Source, Provider, ap);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, ad, Field.ProgramArea, Measure, ChartType).Activate();
                        break;

                    case Field.ProgramProjectCode :
                        var pp = new Dictionary<string, object> { [PrimaryFilter.SelectedItem.ToString()] = BocFilter3.SelectedItem.ToString() };
                        var pd = new DataBuilder(Source, Provider, pp);
                        BocChart = new BudgetChart(BocChart, ChartMainTitle, pd, Field.ProgramProjectCode, Measure, ChartType).Activate();
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
            ChartFilterControl2 = filter2;
            ChartFilterControl3 = filter3;
            ChartFilterControl4 = filter4;
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

        internal void PrimaryFilterControl_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                if(BocExpander1.Visible == false || BocExpander1.IsExpanded == false)
                {
                    BocExpander1.Visible = true;
                    BocExpander1.IsExpanded = true;
                }

                PrimaryFilter = sender as VisualComboBox;
                if(PrimaryFilter != null)
                {
                    CurrentIndex = PrimaryFilter.SelectedIndex;
                }

                switch(CurrentIndex)
                {
                    case 0 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["FundName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("FundName");
                        if(Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.FundName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 1 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["BocName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("BocName");
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

                    case 2 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["NPM"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("NPM");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.NPM, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 3 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["GoalName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("GoalName");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.GoalName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 4 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["ObjectiveName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("ObjectiveName");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.ObjectiveName, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 5 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["Division"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("Division");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.Division, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 6 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["ProgramArea"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("ProgramArea");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.ProgramArea, Stat.Total, ChartSeriesType.Column).Activate();
                        break;

                    case 7 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["ProgramProjectCode"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("ProgramProjectCode");
                        if(DbData.Source == Source.RegionalAccounts)
                        {
                            BocFilter4.Items.Remove("RC");
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

                        BocChart = new BudgetChart(BocChart, ChartMainTitle, DbData, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
                        break;
                }
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
                    CurrentIndex = SummaryTabControl.SelectedIndex;
                }

                switch(CurrentIndex)
                {
                    case 0 :
                        AssignChartFilterControls(BocFilter1, BocFilter2, BocFilter3, BocFilter4);
                        AssignChartExpanders(BocExpander1, BocExpander2);
                        PopulateFilterBoxItems(BocFilter3, DbData.ProgramElements["BocName"]);
                        PopulateFilterBoxItems(BocFilter4, GetTabPageTags());
                        BocFilter4.Items.Remove("BocName");
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

                    case 1 :
                        var table = DbData.Table.AsEnumerable().Select(p => p).CopyToDataTable();
                        lblCount.Text = table.Rows.Count.ToString();
                        lblAve.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average().ToString("N");
                        lblTotal.Text = table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum().ToString("N");
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
                string category = tab.TabPages[CurrentIndex].Tag.ToString();
                int index = filter1.SelectedIndex;
                string grouping = filter3.SelectedItem.ToString();
                switch(index)
                {
                    case 0 :
                        return new[]
                        {
                            string.Format("Total {0} Funding by {1}", source, grouping)
                        };

                    case 1 :
                        return new[]
                        {
                            string.Format("{0}  Accounts by {1}", source, grouping)
                        };

                    case 2 :
                        return new[]
                        {
                            string.Format("Average {0} Funding by {1}", source, grouping)
                        };

                    case 3 :
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
                AccountTabControl.SelectedTab = AddTab;
                if(AddTab.Visible == false)
                {
                    AddTab.Visible = true;
                }

                if(GraphTab.Visible)
                {
                    GraphTab.Visible = false;
                }

                if(EditTab.Visible)
                {
                    EditTab.Visible = false;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void EditButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                AccountTabControl.SelectedTab = EditTab;
                if(EditTab.Visible == false)
                {
                    EditTab.Visible = true;
                }

                if(AddTab.Visible)
                {
                    AddTab.Visible = false;
                }

                if(GraphTab.Visible)
                {
                    GraphTab.Visible = false;
                }
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
                string code = drv.Row["Code"].ToString();
                string bfy = drv.Row["BFY"].ToString();
                decimal total = DbData.Table.AsEnumerable()
                                      .Where(p => p.Field<string>("Code").Contains(code))
                                      .Where(p => p.Field<string>("BFY").Equals(bfy))
                                      .Select(p => p.Field<decimal>("Amount"))
                                      .Sum();
                decimal amt = decimal.Parse(drv["Amount"].ToString());
                decimal ratio = amt / total;
                Dictionary<string, double> d = new Dictionary<string, double> { ["Total"] = (double) total, ["Allocation"] = (double) amt };
                ChartMainTitle = new[]
                {
                    $"{ratio.ToString("P")} - {drv["Division"]}  {drv["ProgramProjectName"]} Funding"
                };
                AccountChart = new BudgetChart(AccountChart, ChartMainTitle, d, Field.ProgramProjectCode, Stat.Total, ChartSeriesType.Column).Activate();
            }
            catch(Exception ex)
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

        private void DatabaseSearchButton_OnClick(object sender, EventArgs e)
        {
            var sd = new SQLiteData(Source.PRC);
            sd.Show();
            Close();
        }

        private void LblPrc_Click(object sender, EventArgs e)
        {
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void GetCaption(Source source)
        {
            try
            {
                string division = source.ToString();
                string[] files = Directory.GetFiles(Info.DivisionImages);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
