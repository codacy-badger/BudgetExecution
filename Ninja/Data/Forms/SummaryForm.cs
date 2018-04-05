#region Using Directives

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

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class SummaryForm : MetroForm, IBudgetAuthority
            {
                #region Properties
                public FormData Ninja { get; set; }
                TabPageAdv[] Tab { get; set; }
                ExpandCollapsePanel[] Expander { get; set; }
                ChartControl[] Chart { get; set; }
                public ListBox[] FilterBox { get; set; }
                public IBudgetAuthority Authority { get; set; }
                public DataBuilder Data { get; }
                public DataSet DataSet { get; }
                public DataTable Table { get; }
                public decimal Total { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                public DivisionAuthority Division { get; }
                public RegionalAuthority R6 { get; }
                public int Count { get; }
                public Dictionary<string, string[]> DataElement { get; }
                internal string[] RC { get; set; }
                private string[] DivName { get; set; }

                #endregion

                #region Constructor

                public SummaryForm( )
                {
                    InitializeComponent( );
                    Division = new DivisionAuthority( );
                    Table = Division.Data.Table;
                    Total = GetTotal(Table);
                    RC = GetCodes(Table, "RC");
                    BindingSource.DataSource = Division.Data.Table;
                    Text = $"P7 Status of Funds";
                    GetAllFilters(FilterBox);
                }

                public SummaryForm(Source source)
                {
                    InitializeComponent( );
                    if (source == Source.P7)
                    {
                        R6 = new RegionalAuthority();
                        Data = R6.Data;
                        DataSet = R6.E6;
                        Table = R6.Table;
                        Total = R6.Total;
                        BindingSource.DataSource = R6.Table;
                        Text = "Region 6 Summary";
                    }
                    if (source == Source.P8)
                    {
                        Division = new DivisionAuthority();
                        Data = Division.Data;
                        DataSet = Division.E6;
                        Table = Division.Table;
                        Total = Division.Total;
                        RC = GetCodes(Table, "RC");
                        BindingSource.DataSource = Division.Table;
                        Text = "R6 Division Summary";
                    }
                    FilterBox = GetFilterBox();
                    GetAllFilters(FilterBox);
                }

                public SummaryForm(string rc)
                {
                    InitializeComponent( );
                    Authority = new DivisionAuthority(rc);
                    Data = Division.Data;
                    DataSet = Division.E6;
                    Table = Division.Table;
                    Total = Division.Total;
                    Text = "Division Summary";
                    BindingSource.DataSource = Table;
                    FilterBox = GetFilterBox();
                    GetAllFilters(FilterBox);
                }

                #endregion

                #region Form Load Event

                private void Form_Load(object sender, EventArgs e)
                {
                    Chart = GetChartArray();
                    FundChart = new Chart(FundChart, Division.FundData).CreateColumn( );
                    BocChart = new Chart(BocChart, Division.BocData).CreateColumn( );
                    NpmChart = new Chart(NpmChart, Division.NpmData).CreateColumn( );
                    GoalChart = new Chart(GoalChart, Division.GoalData).CreateColumn( );
                    AreaChart1 = new Chart(AreaChart1, R6.ObjectiveData).CreateColumn( );
                    AreaChart = new Chart(AreaChart, Division.ProgramData).CreateColumn();
                    ProjectChart = new Chart(ProjectChart, Division.ProgramData).CreateColumn();
                    SummaryTabControl.SelectedIndexChanged += new EventHandler(GetTabPanelTitle);
                }

                #endregion

                #region Control Arrays

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

                ChartControl[] GetChartArray()
                {
                    return new ChartControl[] { FundChart, BocChart, NpmChart, GoalChart, AreaChart1, AreaChart, ProjectChart };
                }

                ListBox[] GetFilterBox()
                {
                    var arrary = new ListBox[] { listBox1, listBox2, listBox3, listBox4, listBox5, listBox6, listBox7 };
                    return arrary;
                } 
                #endregion

                #region MetroSet Buttons Methods

                private void GetListBoxItems(ListBox listbox, string[] list)
                {
                    foreach (string f in list)
                    {
                        listbox.Items.Add(f);
                    }
                }

                private void GetAllFilters(ListBox[] listbox )
                {
                    GetListBoxItems(listbox[0], GetCodes(Table, "FundName"));
                    GetListBoxItems(listbox[1], GetCodes(Table, "BocName"));
                    GetListBoxItems(listbox[2], GetCodes(Table, "NPM"));
                    GetListBoxItems(listbox[3], GetCodes(Table, "GoalName"));
                    GetListBoxItems(listbox[4], GetCodes(Table, "ObjectiveName"));
                    GetListBoxItems(listbox[5], GetCodes(Table, "ProgramAreaName"));
                    GetListBoxItems(listbox[6], GetCodes(Table, "ProgramProjectName"));
                }

                #endregion

                #region IAuthority Interface Implementation

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
                    }
                }

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public decimal GetAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<decimal>("Amount")).Average( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    var count = GetCount(table);
                    return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
                }

                public string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<string>(column)).Distinct( ).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>( );
                    foreach (DataColumn dc in table.Columns)
                    {
                        if (dc.ColumnName.Equals("Id") || dc.ColumnName.Equals("Amount"))
                            continue;
                        data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
                    }
                    if (data.ContainsKey("Id")) data.Remove("Id");
                    if (data.ContainsKey("Amount")) data.Remove("Amount");
                    if (data.ContainsKey("P6_Id")) data.Remove("P6_Id");
                    return data;
                }

                public PRC[] GetPrcArray(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
                {
                    try
                    {
                        var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                        return new Tuple<DataTable, PRC[], decimal, int>(query, GetPrcArray(query), GetTotal(query), GetCount(query));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string ftr in list)
                        {
                            var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
                                .Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string filter in filters)
                        {
                            var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
                                .Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>( );
                        foreach (string filter in list)
                        {
                            decimal[] stat = new decimal[4];
                            stat[0] = GetDataValues(table, column, filter).Item3;
                            stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / Total) * 100;
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string column, string filter)
                {
                    try
                    {
                        string[] list = GetCodes(table, column);
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>( );
                        foreach (string ftr in list)
                        {
                            decimal[] stat = new decimal[4];
                            stat[0] = GetDataValues(table, column, filter).Item3;
                            stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / Total) * 100;
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                DataSet IBudgetAuthority.E6 { get; }

                public DataTable FilterTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion

                private void expandCollapsePanel4_Paint(object sender, PaintEventArgs e)
                {

                }
            }
        }
    }
}