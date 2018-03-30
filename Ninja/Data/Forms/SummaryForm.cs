#region Using Directives

using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
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
            public partial class SummaryForm : MetroForm, IAuthority
            {
                #region Properties
                public FormData Ninja { get; set; }
                ChartControl[] TabChart { get; set; }
                public DivisionAuthority Division { get; }
                public DataBuilder Data { get; }
                public DataSet E6 { get; }
                public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }
                public DataTable Table { get; }
                public decimal Total { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public int Count { get; }
                public Dictionary<string, string[]> DataElement { get; }
                internal string[] FundCodes { get; set; }
                internal string[] RC { get; set; }
                private string[] DivName { get; set; }

                #endregion

                #region Constructor

                public SummaryForm( )
                {
                    InitializeComponent( );
                    Division = new DivisionAuthority( );
                    Table = Division.Data.Table;
                    Total = Division.Data.Total;
                    RC = GetCodeElements(Table, "RC");
                    BindingSource.DataSource = Division.Data.Table;
                    Text = $"P7 Status of Funds";
                    GetAllButtons( );
                    AssignButtonEvents( );
                }

                public SummaryForm(Source source)
                {
                    InitializeComponent( );
                    Data = new DataBuilder(source);
                    E6 = Data.Data;
                    Table = Data.Table;
                    Total = Data.Total;
                    RC = GetCodeElements(Table, "RC");
                    BindingSource.DataSource = Data.Table;
                    Text = "P7 Division Allocation Summary";
                    GetAllButtons( );
                    AssignButtonEvents( );
                }

                public SummaryForm(Source source, Dictionary<string, object> param)
                {
                    InitializeComponent( );
                    Data = new DataBuilder(source, param);
                    E6 = Data.Data;
                    Table = Data.Table;
                    Total = Data.Total;
                    RC = GetCodeElements(Table, "RC");
                    BindingSource.DataSource = Table;
                    Text = "Status of Funds";
                    GetAllButtons( );
                    AssignButtonEvents( );
                }

                #endregion

                #region Form Load Event

                private void Form_Load(object sender, EventArgs e)
                {
                    TabChart = GetChartArray();
                    TabChart1 = new Chart(TabChart1, "Fund", Division.FundData).CreateColumn( );
                    TabChart2 = new Chart(TabChart2, Division.FundData).CreateColumn( );
                    TabChart3 = new Chart(TabChart3, Division.BocData).CreateColumn( );
                    TabChart4 = new Chart(TabChart4, Division.NpmData).CreateColumn( );
                    TabChart5 = new Chart(TabChart5, Division.GoalData).CreateColumn( );
                    TabChart6 = new Chart(TabChart6, Division.ProgramData).CreateColumn( );
                    SummaryTabControl.SelectedIndexChanged += new EventHandler(GetTabPanelTitle);
                }

                #endregion

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
                    return new ChartControl[] { TabChart1, TabChart2, TabChart3, TabChart4, TabChart5, TabChart6 };
                }

                #region MetroSet Buttons Methods

                private void GetAllButtons( )
                {
                    GetMetroSetButtons(panel1, GetCodeElements(Table, "FundName"));
                    GetMetroSetButtons(panel2, GetCodeElements(Table, "BocName"));
                    GetMetroSetButtons(panel3, GetCodeElements(Table, "NPM"));
                    GetMetroSetButtons(panel4, GetCodeElements(Table, "GoalName"));
                    GetMetroSetButtons(panel5, GetCodeElements(Table, "ObjectiveName"));
                }

                private void GetMetroSetButtons(FlowLayoutPanel panel, string[] list)
                {
                    foreach (string f in list)
                    {
                        var b = new MetroSetButton( );
                        b.Text = f;
                        b.Font = new Font("Segoe UI", 8f);
                        b.NormalColor = Color.Black;
                        b.NormalTextColor = SystemColors.MenuHighlight;
                        b.NormalBorderColor = Color.Black;
                        b.HoverBorderColor = Color.Blue;
                        b.HoverColor = Color.SteelBlue;
                        b.HoverTextColor = Color.AntiqueWhite;
                        b.Size = new Size(195, 45);
                        b.Margin = new Padding(3);
                        b.Padding = new Padding(1);
                        panel.Controls.Add(b);
                        panel.AutoSize = true;
                        b.Tag = f;
                    }
                }

                private void AssignButtonEvents( )
                {
                    foreach (MetroSetButton ab in panel1.Controls)
                        ab.Click += OnAppropButtonSelect;
                    foreach (MetroSetButton cd in panel2.Controls)
                        cd.Click += OnBocButtonSelect;
                    foreach (MetroSetButton ef in panel3.Controls)
                        ef.Click += OnNpmButtonSelect;
                    foreach (MetroSetButton gh in panel4.Controls)
                        gh.Click += OnGoalButtonSelect;
                    foreach (MetroSetButton hi in panel5.Controls)
                        hi.Click += ObjectiveButton_OnSelect;
                }

                private void OnAppropButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var name = button.Tag.ToString( );
                    var table = FilterTable(Table, "FundName", button.Tag.ToString( ));
                    var div = GetCodeElements(table, "RC");
                    var data = GetDataTotals(table, div, "RC");
                    Text = $"Total P7 Division {name} Funding";
                    string title = $"Total P7 Division  {name} Funding: {GetTotal(table).ToString("c")}";
                    TabChart2 = new Chart(TabChart2, title, data).CreateColumn( );
                }

                private void OnBocButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var name = button.Tag.ToString( );
                    var table = FilterTable(Table, "BocName", button.Tag.ToString( ));
                    var div = GetCodeElements(table, "RC");
                    var data = GetDataTotals(table, div, "RC");
                    Text = $"Total P7 Division {name} Funding";
                    string title = $"Total P7 Division  {name} Funding: {GetTotal(table).ToString("c")}";
                    TabChart3 = new Chart(TabChart3, title, data).CreateColumn( );
                }

                private void OnNpmButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var name = button.Tag.ToString( );
                    var table = FilterTable(Table, "NPM", button.Tag.ToString( ));
                    var div = GetCodeElements(table, "RC");
                    var data = GetDataTotals(table, div, "RC");
                    Text = $"Total P7 Division {name} Funding";
                    string title = $"Total P7 Division  {name} Funding: {GetTotal(table).ToString("c")}";
                    TabChart4 = new Chart(TabChart4, title, data).CreateColumn( );
                }

                private void OnGoalButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var name = button.Tag.ToString( );
                    var table = FilterTable(Table, "GoalName", button.Tag.ToString( ));
                    var div = GetCodeElements(table, "RC");
                    var data = GetDataTotals(table, div, "RC");
                    Text = $"Total P7 Division {name} Funding";
                    string title = $"Total P7 Division  {name} Funding: {GetTotal(table).ToString("c")}";
                    TabChart5 = new Chart(TabChart5, title, data).CreateColumn( );
                }

                private void ObjectiveButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var name = button.Tag.ToString( );
                    var table = FilterTable(Table, "ObjectiveName", button.Tag.ToString( ));
                    var div = GetCodeElements(table, "RC");
                    var data = GetDataTotals(table, div, "RC");
                    Text = $"Total P7 Division {name} Funding";
                    string title = $"Total P7 Division {name} Funding: {GetTotal(table).ToString("c")}";
                    TabChart6 = new Chart(TabChart6, title, data).CreateColumn( );
                }

                #endregion

                #region SummaryTab Button Eventhandlers

                public void AppropriationButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "Fund", Division.FundData).CreateColumn( );
                    Text = "P7 Division Funding by Appropriation";
                }

                public void BocButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "BOC", Division.BocData).CreateColumn( );
                    Text = $"P7 Division by Object Class";
                }

                public void FteButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "FTE", Division.FteInfo).CreateColumn( );
                    Text = $"P7 Division FTE by Appropriation";
                }

                public void NpmButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "NPM", Division.NpmData).CreateColumn( );
                    Text = $"P7 Division Funding by HQ Program Office";
                }

                public void DivisionButton_OnClick(object sender, EventArgs e)
                {
                    var data = new DivisionAuthority( );
                    TabChart1 = new Chart(TabChart1, "Division", data.DivisionData).CreateColumn( );
                    Text = $"P7 Division Funding by Division/Allowance Holder";
                }

                public void GoalButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "GoalName", Division.GoalData).CreateColumn( );
                    Text = $"P7 Division Funding by Agency Goal";
                }

                public void AreaButton_OnClick(object sender, System.EventArgs e)
                {
                    TabChart1 = new Chart(TabChart1, "ProgramAreaName", Division.ProgramData).CreateColumn( );
                    Text = $"P7 Division Funding by Program Area";
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

                public string[] GetCodeElements(DataTable table, string column)
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
                        data.Add(dc.ColumnName, GetCodeElements(table, dc.ColumnName));
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
                        var list = GetCodeElements(table, column);
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

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string[] filters, string column)
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

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string[] list, string column)
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
                        string[] list = GetCodeElements(table, column);
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

                DataSet IAuthority.E6 { get; }

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
            }
        }
    }
}