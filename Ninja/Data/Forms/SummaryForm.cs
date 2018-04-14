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
                    D6 = new DivisionAuthority();
                    Table = D6.Data.BudgetTable;
                    ProgramElements = D6.Data.ProgramElements;
                    RC = ProgramElements["RC"];
                    BindingSource.DataSource = D6.Data.BudgetTable;
                    Text = $"P7 Status of Funds";
                    GetFilterButtons();
                    FundChart = GetSummaryChart(FundChart, Data, PrcFilter.Fund, "R6 Division Summary");
                    BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BOC, "R6 Division Summary");
                    NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, "R6 Division Summary");
                    GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, "R6 Division Summary");
                    ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, "R6 Division Summary");
                    AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramArea, "R6 Division Summary");
                    ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, "R6 Division Summary");
                }

                public SummaryForm(Source source)
                {
                    InitializeComponent();
                    if (source == Source.P7)
                    {
                        Data = new DataBuilder(Source.P7);
                        BudgetMetric = new DataMetric(Data);
                        DataSet = Data.BudgetData;
                        Table = BudgetMetric.Table;
                        ProgramElements = BudgetMetric.ProgramElements;
                        BindingSource.DataSource = BudgetMetric.Table;
                        GetFilterButtons();
                        Text = "Region 6 Summary";
                    }
                    if (source == Source.P8)
                    {
                        Data = new DataBuilder(Source.P8);
                        BudgetMetric = new DataMetric(Data);
                        DataSet = Data.BudgetData;
                        Table = BudgetMetric.Table;
                        ProgramElements = BudgetMetric.ProgramElements;
                        RC = Data.ProgramElements["RC"];
                        GetFilterButtons();
                        Text = "R6 Division Summary";
                    }
                    FundChart = GetSummaryChart(FundChart, Data, PrcFilter.Fund, "R6 Division Summary");
                    BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BOC, "R6 Division Summary");
                    NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, "R6 Division Summary");
                    GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, "R6 Division Summary");
                    ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, "R6 Division Summary");
                    AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramArea, "R6 Division Summary");
                    ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, "R6 Division Summary");
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent();
                    D6 = new DivisionAuthority(rc);
                    Data = D6.Data;
                    DataSet = D6.BudgetData;
                    Table = D6.Table;
                    BudgetMetric = new DataMetric(Data);
                    GetFilterButtons();
                    Text = $"{D6.Org.Name} Summary";
                    BindingSource.DataSource = Table;
                    FundChart = GetSummaryChart(FundChart, Data, PrcFilter.Fund, "R6 Division Summary");
                    BocChart = GetSummaryChart(BocChart, Data, PrcFilter.BOC, "R6 Division Summary");
                    NpmChart = GetSummaryChart(NpmChart, Data, PrcFilter.NPM, "R6 Division Summary");
                    GoalChart = GetSummaryChart(GoalChart, Data, PrcFilter.GoalName, "R6 Division Summary");
                    ObjectiveChart = GetSummaryChart(ObjectiveChart, Data, PrcFilter.ObjectiveName, "R6 Division Summary");
                    AreaChart = GetSummaryChart(AreaChart, Data, PrcFilter.ProgramArea, "R6 Division Summary");
                    ProjectChart = GetSummaryChart(ProjectChart, Data, PrcFilter.ProgramProjectCode, "R6 Division Summary");
                }


                //Properties
                public IBudgetAuthority Authority { get; set; }
                public DataBuilder Data { get; }
                public DataMetric BudgetMetric { get; }
                public DataSet DataSet { get; }
                private TabPageAdv[] Tab { get; set; }
                public FlowLayoutPanel[] FilterPanel { get; set; }
                public decimal[] Metrics { get; }
                public FormData Ninja { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DivisionAuthority D6 { get; }
                public RegionalAuthority R6 { get; }
                public DataTable Table { get; }
                internal string[] RC { get; set; }
                internal RadioButton[] RadioButton { get; set; }
                internal ChartControl[] Chart { get; set; }
                private ExpandCollapsePanel[] Expander { get; set; }


                //Methods

                private void Form_Load(object sender, EventArgs e)
                {
                    var title = $"R6 Funding" ;
                    SummaryTabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
                }

                private void GetMetroSetButtons(FlowLayoutPanel panel, string[] list)
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

                private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
                {
                    int tabindex = SummaryTabControl.TabCount;
                    int tc = SummaryTabControl.SelectedIndex;
                    switch (tc)
                    {
                        case 0:
                            Text = $"Funding by Appropriation";
                            break;

                        case 1:
                            Text = $"Funding by Budget Object Class";
                            break;

                        case 2:
                            Text = $"Funding by National Program";
                            break;

                        case 3:
                            Text = $"Funding by Agency Goal";
                            break;

                        case 4:
                            Text = $"Funding by Strategic Plan Objective";
                            break;

                        case 5:
                            Text = $"Funding by Division";
                            break;

                        case 6:
                            Text = $"Funding by Program Area";
                            break;

                        case 7:
                            Text = $"Funding by Program Project";
                            break;
                        default:
                            Text = $"Funding Summary";
                            break;
                    }
                }

                private void ListBox_SelectedItemChanged(object sender, EventArgs e)
                {

                }

                ChartControl GetSummaryChart(ChartControl chart, DataBuilder data, PrcFilter filter, string title)
                {
                    var fd = new BudgetChart(chart, data, filter);
                    fd.AxisTitle = new string[] { title };
                    return fd.Activate();
                }

                Dictionary<string, string> GetFilterCategories()
                {
                    try
                    {
                        var filters = new Dictionary<string, string>();
                        filters.Add("Fund", "FundName");
                        filters.Add("BOC", "BocName");
                        filters.Add("NPM", "NPM");
                        filters.Add("Goal", "GoalName");
                        filters.Add("Objective", "ObjectiveName");
                        filters.Add("Division", "RC");
                        filters.Add("Program Area", "ProgramArea");
                        filters.Add("Program Project", "ProgramProjectCode");
                        return filters;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                RadioButton[] GetRadioButtonFiterArray()
                {
                    try
                    {
                        var flowpanel = new FlowLayoutPanel();
                        flowpanel.Location = new Point(351, 3);
                        flowpanel.Size = new Size(778, 35);
                        flowpanel.ForeColor = SystemColors.MenuHighlight;
                        var filters = GetFilterCategories();
                        var array = new RadioButton[filters.Count];
                        var keys = filters.Keys.ToArray();
                        var vals = filters.Values.ToArray();
                        for (int i = 0; i < filters.Count; i++)
                        {
                            array[i] = new RadioButton();
                            array[i].Text = keys[i];
                            array[i].Tag = vals[i];
                            array[i].CheckedChanged += RadioButtonFilter_Click;
                            flowpanel.Controls.Add(array[i]);
                        }
                        Controls.Add(flowpanel);
                        flowpanel.Visible = true;
                        return array;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }
                 
                void RadioButtonFilter_Click(object sender, EventArgs e)
                {
                    var rb = sender as RadioButton;
                    var filter = rb.Tag.ToString();
                }

                private void SummaryTabControl_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

                private void FundExpander_Paint(object sender, PaintEventArgs e)
                {

                }

            }
        }
    }
}