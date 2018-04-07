using MakarovDev.ExpandCollapsePanel;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
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
                    GetAllFilters(FilterBox);
                }

                public SummaryForm(Source source)
                {
                    InitializeComponent();
                    if (source == Source.P7)
                    {
                        R6 = new RegionalAuthority();
                        Data = R6.Data;
                        DataSet = R6.BudgetData;
                        Table = R6.Table;
                        ProgramElements = R6.ProgramElements;
                        BindingSource.DataSource = R6.Table;
                        Text = "Region 6 Summary";
                    }
                    if (source == Source.P8)
                    {
                        D6 = new DivisionAuthority();
                        Data = D6.Data;
                        DataSet = D6.BudgetData;
                        Table = D6.Table;
                        ProgramElements = D6.ProgramElements;
                        RC = D6.Data.ProgramElements["RC"];
                        BindingSource.DataSource = D6.Table;
                        Text = "R6 Division Summary";
                    }
                    FilterBox = GetFilterBox();
                    GetAllFilters(FilterBox);
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent();
                    D6 = new DivisionAuthority(rc);
                    Data = D6.Data;
                    BudgetMetric = new DataMetric(Data);
                    DataSet = D6.BudgetData;
                    Table = D6.Table;
                    Text = $"{D6.Org.Name} Summary";
                    BindingSource.DataSource = Table;
                    FilterBox = GetFilterBox();
                    GetAllFilters(FilterBox);
                }


                //Properties
                public IBudgetAuthority Authority { get; set; }
                public DataBuilder Data { get; }
                public DataMetric BudgetMetric { get; }
                public DataSet DataSet { get; }
                public ListBox[] FilterBox { get; set; }
                public decimal[] Metrics { get; }
                public FormData Ninja { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DivisionAuthority D6 { get; }
                public RegionalAuthority R6 { get; }
                public DataTable Table { get; }
                internal string[] RC { get; set; }
                private ChartControl[] Chart { get; set; }
                private string[] DivName { get; set; }
                private ExpandCollapsePanel[] Expander { get; set; }
                private TabPageAdv[] Tab { get; set; }


                //Methods
                public DataTable FilterTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private void Form_Load(object sender, EventArgs e)
                {
                    Chart = GetChartArray();
                    FundChart = new Chart(FundChart, D6.FundData).CreateColumn();
                    BocChart = new Chart(BocChart, D6.BocData).CreateColumn();
                    NpmChart = new Chart(NpmChart, D6.NpmData).CreateColumn();
                    GoalChart = new Chart(GoalChart, D6.GoalData).CreateColumn();
                    ObjChart = new Chart(ObjChart, R6.ObjectiveData).CreateColumn();
                    AreaChart = new Chart(AreaChart, D6.ProgramData).CreateColumn();
                    ProjectChart = new Chart(ProjectChart, D6.ProgramData).CreateColumn();
                    SummaryTabControl.SelectedIndexChanged += new EventHandler(GetTabPanelTitle);
                }

                private void GetAllFilters(ListBox[] listbox)
                {
                    GetListBoxItems(listbox[0], ProgramElements["FundName"]);
                    GetListBoxItems(listbox[1], ProgramElements["BocName"]);
                    GetListBoxItems(listbox[2], ProgramElements["NPM"]);
                    GetListBoxItems(listbox[3], ProgramElements["GoalName"]);
                    GetListBoxItems(listbox[4], ProgramElements["ObjectiveName"]);
                    GetListBoxItems(listbox[5], ProgramElements["ProgramAreaName"]);
                    GetListBoxItems(listbox[6], ProgramElements["ProgramProjectName"]);
                }

                private ChartControl[] GetChartArray()
                {
                    return new ChartControl[] { FundChart, BocChart, NpmChart, GoalChart, ObjChart, DivisionChart, AreaChart, ProjectChart };
                }

                private ExpandCollapsePanel[] GetExpanders()
                {
                    try
                    {
                        var expander = new ExpandCollapsePanel[Tab.Length];
                        for (int i = 0; i < Tab.Length; i++)
                            Expander[i] = new ExpandCollapsePanel();
                        return Expander;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }

                private ListBox[] GetFilterBox()
                {
                    var arrary = new ListBox[] { listBox1, listBox2, listBox3, listBox4, listBox5, listBox6, listBox7 };
                    return arrary;
                }

                private void GetListBoxItems(ListBox listbox, string[] list)
                {
                    foreach (string f in list)
                    {
                        listbox.Items.Add(f);
                    }
                }

                private void GetTabPanelTitle(object sender, EventArgs e)
                {
                    int tabindex = SummaryTabControl.TabCount;
                    int tc = SummaryTabControl.SelectedIndex;
                    switch (tc)
                    {
                        case 1:
                            Text = $"Division Funding by Appropriation";
                            break;

                        case 2:
                            Text = $"Division Funding by Budget Object Class";
                            break;

                        case 3:
                            Text = $"Division Funding by National Program";
                            break;

                        case 4:
                            Text = $"Division Funding by Agency Goal";
                            break;

                        case 5:
                            Text = $"Division Funding by Strategic Plan Objective";
                            break;

                        case 6:
                            Text = $"Division Funding by Division Allowance Holder";
                            break;

                        case 7:
                            Text = $"Division Transfers";
                            break;

                        default:
                            Text = $"Division Status of Funds";
                            break;
                    }
                }

                private TabPageAdv[] GetTabs()
                {
                    try
                    {
                        var tabs = SummaryTabControl.TabPages;
                        var tab = new TabPageAdv[tabs.Count];
                        for (int i = 0; i < tabs.Count; i++)
                        {
                            tab[i] = tabs[i];
                        }
                        return tab;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
            }
        }
    }
}