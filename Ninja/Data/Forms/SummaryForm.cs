using MakarovDev.ExpandCollapsePanel;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
                    BudgetMetric = new DataMetric(Data);
                    DataSet = Data.BudgetData;
                    PopulateCharts(Title);
                    ProgramElements = BudgetMetric.ProgramElements;
                    BindingSource.DataSource = BudgetMetric.Table;
                    GetFilterButtons();
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent();
                    DatabaseTab.TabVisible = true;
                    D6 = new DivisionAuthority(rc);
                    Data = new DataBuilder(Source.P8, new Dictionary<string, object> { ["RC"] = rc });
                    DataSet = Data.BudgetData;
                    BudgetMetric = new DataMetric(Data);
                    ProgramElements = BudgetMetric.ProgramElements;
                    GetFilterButtons();
                    Text = $"{D6.Org.Name} Summary";
                    Title = D6.RC.Name;
                }

                //Properties
                public DataBuilder Data { get; }
                public DataMetric BudgetMetric { get; }
                public DataSet DataSet { get; }
                public string Title { get; }
                public DataTable Table { get; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public decimal[] Metrics { get; }
                public DivisionAuthority D6 { get; }
                public PrcFilter ButtonFilter { get; set; }
                private TabPageAdv[] Tab { get; set; }
                public DataTable Base { get; set; }
                internal RadioButton[] RadioButton { get; set; }
                internal ChartControl[] Chart { get; set; }

                //Methods
                private void Form_Load(object sender, EventArgs e)
                {
                    try
                    {
                        BindingSource.DataSource = Data.BudgetTable;
                        Navigator.BindingSource = BindingSource;
                        Grid.DataSource = BindingSource;
                        GetGridColumns(Grid);
                        PopulateCharts(Title);
                        GetFundFilterItems();
                        GetTextBoxBindings();
                        lblTotal.Text = Data.GetTotal(Data.BudgetTable).ToString("c");
                        lblCount.Text = Data.GetCount(Data.BudgetTable).ToString();
                        FundFilter.SelectionChangeCommitted += FundFilter_ItemSelected;
                        BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
                        BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
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
                private void GetFilterButtons()
                {
                    try
                    {
                        GetMetroSetButtons(fp1, BudgetMetric.ProgramElements["FundName"]);
                        GetMetroSetButtons(fp1, BudgetMetric.ProgramElements["BocName"]);
                        GetMetroSetButtons(fp3, BudgetMetric.ProgramElements["NPM"]);
                        GetMetroSetButtons(fp4, BudgetMetric.ProgramElements["GoalName"]);
                        GetMetroSetButtons(fp5, BudgetMetric.ProgramElements["ObjectiveName"]);
                        GetMetroSetButtons(fp6, BudgetMetric.ProgramElements["DivisionName"]);
                        GetMetroSetButtons(fp7, BudgetMetric.ProgramElements["ProgramAreaName"]);
                        GetMetroSetButtons(fp8, BudgetMetric.ProgramElements["ProgramProjectName"]);
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }
                ChartControl GetSummaryChart(ChartControl chart, DataBuilder data, PrcFilter filter, string title)
                {
                    try
                    {
                        var fd = new BudgetChart(chart, data, filter, Statistic.Total);
                        fd.GetAxisTitle(chart, new string[] { title });
                        return fd.Activate();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
                void PopulateCharts(string title)
                {
                    FundChart = GetSummaryChart(FundChart, Data, PrcFilter.Fund, string.Format("{0} by Appropriation", title));
                    BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BOC, string.Format("{0} by Object Class", title));
                    NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, string.Format("{0} by HQ Program", title));
                    GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, string.Format("{0} by Agency Goal", title));
                    ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, string.Format("{0} by Strategic Objective", title));
                    AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramArea, string.Format("{0} by Program Area", title));
                    ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, string.Format("{0} by Program Project", title));
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
                        dgv.Columns[5].Visible = true;
                        dgv.Columns[6].Visible = true;
                        dgv.Columns[8].Visible = true;
                        dgv.Columns[10].Visible = true;
                        dgv.Columns[11].Visible = true;
                        dgv.Columns[12].Visible = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void GetFundFilterItems()
                {
                    try
                    {
                        var item = Data.ProgramElements["FundName"];
                        foreach (string i in item)
                            FundFilter.Items.Add(i);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                void GetBocFilterItems()
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
                void GetTextBoxBindings()
                {
                    try
                    {
                        bfy.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                        Fund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                        Org.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                        AHRC.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                        Code.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                        BOC.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                        Amount1.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                }
                void FundFilter_ItemSelected(object sender, EventArgs e)
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
                void GetBindingSourceFilter()
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
                void BocFilter_ItemSelected(object sender, EventArgs e)
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
                decimal GetTotal(string filter)
                {
                    try
                    {
                        return Data.BudgetTable.AsEnumerable().Where(p => p.Field<string>("FundName").
                     Equals(filter)).Select(p => p.Field<decimal>("Amount")).Sum();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                decimal GetTotal(string filter1, string filter2)
                {
                    try
                    {
                        return Data.BudgetTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                    .Where(p => p.Field<string>("BocName").Equals(filter2))
                    .Select(p => p.Field<decimal>("Amount")).Sum();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                decimal GetCount(string filter)
                {
                    try
                    {
                        return Data.BudgetTable.AsEnumerable().Where(p => p.Field<string>("FundName").
                    Equals(filter)).Select(p => p.Field<decimal>("Amount") > 0).Count();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
                decimal GetCount(string filter1, string filter2)
                {
                    try
                    {
                        return Data.BudgetTable.AsEnumerable().Where(p => p.Field<string>("FundName").Equals(filter1))
                           .Where(p => p.Field<string>("BocName").Equals(filter2)).Select(p => p.Field<decimal>("Amount")).Count();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return -1;
                    }
                }
            }
        }
    }
}