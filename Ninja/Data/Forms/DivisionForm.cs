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
            public partial class DivisionForm : MetroForm
            {
                #region Properties

                public DivisionAuthority P8 { get; set; }
                public ChartControl PieChart { get; set; }
                public Query P8Query { get; set; }
                private DataBuilder DataBuilder { get; set; }
                public DataTable P8Data { get; set; }
                public decimal Total { get; }
                private Appropriation[] Appropriation { get; }
                public string[] FundCodes { get; }
                public Dictionary<string, decimal> PrcInfo { get; set; }
                public Dictionary<string, decimal> BocInfo { get; set; }
                public Dictionary<string, decimal> FteInfo { get; set; }

                #endregion

                #region Constructors

                public DivisionForm( )
                {
                    InitializeComponent( );
                }

                public DivisionForm(string rc)
                {
                    InitializeComponent( );
                    P8Query = new Query(Source.P8, GetP8QueryParameter(rc));
                    P8 = new DivisionAuthority(rc);
                    P8Data = P8.Data.Table;
                    BindData(P8Data, Grid, P8BindingSource, DataNavigator);
                    Appropriation = P8.Appropriation;
                    FundCodes = P8.DataElement["Fund"];
                    PrcInfo = P8.FundData;
                    BocInfo = P8.BocData;
                    if (P8.FteInfo != null)
                    {
                        FteInfo = P8.FteInfo;
                    }
                    Text = $"{Info.DivisionName(rc)} ";
                    GetFilterButtons( );
                    AssignButtonEvents( );
                    lblTotalAmount.Text = GetTotal(P8Data).ToString("c");
                    lblCount.Text = P8Data.Rows.Count.ToString( );
                }

                #endregion

                #region Form Load Event

                private void DivisionForm_Load(object sender, EventArgs e)
                {
                    Text = "P7 " + P8.Org.Name;
                    AppropChart = new Chart(AppropChart, P8.FundData).CreateColumn( );
                    BocChart = new Chart(BocChart, P8.BocData).CreateColumn( );
                    NpmChart = new Chart(NpmChart, P8.NpmData).CreateColumn( );
                    AreaChart = new Chart(AreaChart, P8.ProgramData).CreateColumn( );
                    ProjectChart = new Chart(ProjectChart, P8.ProjectData).CreateColumn( );
                    DivisionFormTabControl.SelectedIndexChanged += new EventHandler(GetTabPanelTitle);
                    BackButton.Visible = false;
                    PrcChart = GetPieChart(PrcChart, "", P8, P8BindingSource);
                    P8BindingSource.CurrentItemChanged += new EventHandler(UpdatePieChart);
                }

                #endregion

                private string[] GetChartTitles( )
                {
                    var t = new string[6];
                    t[0] = $"{P8.Org.Name} Funds by Appropriation";
                    t[1] = $"{P8.Org.Name} Funds by Object Class";
                    t[2] = $"{P8.Org.Name} FTE by HQ NPM";
                    t[3] = $"{P8.Org.Name} Funds by Program Area";
                    t[4] = $"{P8.Org.Name} Funds by Program Project";
                    t[5] = $"{P8.Org.Name} FTE by Appropriation";
                    return t;
                }

                private void GetGridColumns(DataGridView dgv)
                {
                    foreach (DataGridViewColumn dc in dgv.Columns)
                        dc.Visible = false;
                    dgv.Columns[4].Visible = true;
                    dgv.Columns[6].Visible = true;
                    dgv.Columns[8].Visible = true;
                    dgv.Columns[9].Visible = true;
                    dgv.Columns[11].Visible = true;
                    dgv.Columns[12].Visible = true;
                }

                private void BindData(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
                {
                    bs.DataSource = table;
                    dg.DataSource = bs;
                    bn.BindingSource = bs;
                    GetGridColumns(dg);
                }

                private void GetTabPanelTitle(object sender, EventArgs e)
                {
                    int tabindex = DivisionFormTabControl.TabCount;
                    int tc = DivisionFormTabControl.SelectedIndex;
                    switch (tc)
                    {
                        case 0:
                            Text = $"{P8.Org.Name} Funds by Appropriation";
                            P8Data = P8.Data.Table;
                            break;

                        case 1:
                            Text = $"{P8.Org.Name} Funds by Budget Object Class";
                            P8Data = P8.Data.Table;
                            break;

                        case 2:

                            Text = $"{P8.Org.Name} Funds by National Program";
                            P8Data = P8.Data.Table;
                            break;

                        case 3:
                            Text = $"{P8.Org.Name} Funds by Program Area";
                            P8Data = P8.Data.Table;
                            break;

                        case 4:
                            Text = $"{P8.Org.Name} Funds by Program Project";
                            P8Data = P8.Data.Table;
                            ProjectChart = new Chart(ProjectChart, P8.ProjectData).CreateColumn( );
                            break;

                        case 5:
                            Text = $"{P8.Org.Name} Budget Database";
                            P8Data = P8.Data.Table;
                            break;

                        case 6:
                            Text = $"{P8.Org.Name} Transfers";
                            P8Data = P8.Data.Table;
                            break;

                        default:
                            Text = $"{P8.Org.Name} Status of Funds";
                            P8Data = P8.Data.Table;
                            break;
                    }
                }

                private Dictionary<string, object> GetP8QueryParameter(string rc)
                {
                    var query = new Dictionary<string, object> { ["RC"] = rc };
                    return query;
                }

                #region Button Methods & Event Handlers

                private void GetMetroSetButtons(FlowLayoutPanel panel, string[] list)
                {
                    panel.Controls.Clear( );
                    foreach (string f in list)
                    {
                        var b = new MetroSetButton( );
                        b.Text = f;
                        b.Font = new Font("Segoe UI", 8f);
                        b.NormalColor = Color.Black;
                        b.NormalTextColor = SystemColors.MenuHighlight;
                        b.NormalBorderColor = Color.Black;
                        b.HoverBorderColor = Color.SteelBlue;
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

                private void GetFilterButtons( )
                {
                    GetMetroSetButtons(panel1, GetCodes(P8Data, "FundName"));
                    GetMetroSetButtons(panel2, GetCodes(P8Data, "BocName"));
                    GetMetroSetButtons(panel3, GetCodes(P8Data, "NPM"));
                    GetMetroSetButtons(panel4, GetCodes(P8Data, "ProgramAreaName"));
                    GetMetroSetButtons(panel5, GetCodes(P8Data, "ProgramProjectName"));
                    GetMetroSetButtons(GridFilterPanel, P8.DataElement["FundName"]);
                }

                private void AssignButtonEvents( )
                {
                    foreach (MetroSetButton ab in panel1.Controls)
                        ab.Click += OnAppropButton_Select;
                    foreach (MetroSetButton cd in panel2.Controls)
                        cd.Click += BocButton_OnSelect;
                    foreach (MetroSetButton ef in panel3.Controls)
                        ef.Click += NpmButton_OnSelect;
                    foreach (MetroSetButton gh in panel4.Controls)
                        gh.Click += AreaButton_OnSelect;
                    foreach (MetroSetButton hi in panel5.Controls)
                        hi.Click += ProjectButton_OnSelect;
                    foreach (Control c in GridFilterPanel.Controls)
                        c.Click += OnP8AppropButtonSelect;
                }

                private void OnAppropButton_Select(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "FundName", name);
                    Text = $"Total {P8.Org.Name} Funding by Appropriation";
                    string title = $"Total {button.Tag.ToString( )} Funds: {GetTotal(table).ToString("c")}";
                    if (rb1.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb2.Checked == true)
                    {
                        string[] npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb3.Checked == true)
                    {
                        string[] alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb4.Checked == true)
                    {
                        string[] projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void BocButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "BocName", name);
                    Text = $"Total {P8.Org.Name} Funding by Object Class";
                    string title = $"{P8.Org.Name} {name} Funds: {GetTotal(table).ToString("c")}";
                    if (rb5.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb6.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        BocChart = new Chart(BocChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb7.Checked == true)
                    {
                        var alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb8.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void NpmButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "NPM", button.Tag.ToString( ));
                    Text = $"Total {P8.Org.Name} Funding by Object Class";
                    string title = $"Total {button.Tag.ToString( )} Funds: {GetTotal(table).ToString("c")}";
                    if (rb9.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb10.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb11.Checked == true)
                    {
                        var alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb12.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void AreaButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "ProgramAreaName", button.Tag.ToString( ));
                    Text = $"Total {P8.Org.Name} Funding by Object Class";
                    string title = $"Total {button.Tag.ToString( )} Funds: {GetTotal(table).ToString("c")}";
                    if (rb13.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Appropritaion";
                    }
                    if (rb14.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb15.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb16.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void ProjectButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "ProgramProjectName", button.Tag.ToString( ));
                    Text = $"Total {P8.Org.Name} Funding by Program Project";
                    string title = $"Total {button.Tag.ToString( )} Funds: {GetTotal(table).ToString("c")}";
                    if (rb17.Checked == true)
                    {
                        var objlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, objlist, "FundName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb18.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb19.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb20.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, projlist, "ProgramAreaName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn( );
                        Text = $"Total {P8.Org.Name} {name} Funding by Program Area";
                    }
                }

                private void GetP8AppropFilterBox(DataTable table)
                {
                    GetMetroSetButtons(GridFilterPanel, GetCodes(table, "FundName"));
                    foreach (Control c in GridFilterPanel.Controls) c.Click += OnP8AppropButtonSelect;
                }

                private void OnP8AppropButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8.Data.Table, "FundName", name);
                    BindData(table, DataGrid, P8BindingSource, DataNavigator);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    GetP8BocFilterBox(table);
                    DatabaseGroupBox.Text = $"{P8.Org.Name}  {name} Data";
                    BackButton.Visible = true;
                    BackButton.Text = "Back";
                    P8Data = table;
                    BackButton.Click += ReturnButton_OnAppropriationClick;
                }

                private void GetP8BocFilterBox(DataTable table)
                {
                    GetMetroSetButtons(GridFilterPanel, GetCodes(table, "BocName"));
                    foreach (Control c in GridFilterPanel.Controls) c.Click += OnP8BocButtonSelect;
                }

                private void OnP8BocButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString( );
                    var table = GetTable(P8Data, "BocName", name);
                    BindData(table, DataGrid, P8BindingSource, DataNavigator);
                    BackButton.Text = "Back";
                    DatabaseGroupBox.Text = $"{P8.Org.Name} {name} Data";
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    BackButton.Click += ReturnButton_OnBocClick;
                }

                private void ReturnButton_OnAppropriationClick(object sender, EventArgs e)
                {
                    var table = P8.Data.Table;
                    BindData(table, DataGrid, P8BindingSource, DataNavigator);
                    GetP8AppropFilterBox(table);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    BackButton.Visible = false;
                    DatabaseGroupBox.Text = $"{P8.Org.Name} Database";
                }

                private void ReturnButton_OnBocClick(object sender, EventArgs e)
                {
                    var table = P8.Data.Table;
                    BindData(table, DataGrid, P8BindingSource, DataNavigator);
                    GetP8AppropFilterBox(table);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    BackButton.Visible = false;
                    DatabaseGroupBox.Text = $"{P8.Org.Name} Database";
                }

                #endregion

                private ChartControl GetPieChart(ChartControl chart, string title, DivisionAuthority P8, BindingSource bs)
                {
                    PieChart = new Chart(chart, title, P8, bs).CreateColumn( );
                    return PieChart;
                }

                private void UpdatePieChart(object sender, EventArgs e)
                {
                    P8BindingSource = sender as BindingSource;
                    PrcChart = GetPieChart(PrcChart, "", P8, P8BindingSource);
                }

                #region Excel Form Members

                private void metroButton2_Click(object sender, EventArgs e)
                {
                    var excel = new ExcelForm( );
                    excel.ShowDialog( );
                }

                private void ExcelExportButton_Clicked(object sender, EventArgs e)
                {
                    var excel = new ExcelOp(P8.RC.Code);
                    excel.ExportData(P8.Data.Table);
                }

                #endregion

                #region DataGridView Members

                private DataTable GetFormTable(DataTable table)
                {
                    DataTable viewtable = new DataTable( );
                    var bfy = new DataColumn("BFY");
                    viewtable.Columns.Add(bfy);
                    var fund = new DataColumn("Fund");
                    viewtable.Columns.Add(fund);
                    var org = new DataColumn("Org");
                    viewtable.Columns.Add(org);
                    var rc = new DataColumn("RC");
                    viewtable.Columns.Add(rc);
                    var boc = new DataColumn("BOC");
                    viewtable.Columns.Add(boc);
                    var code = new DataColumn("Code");
                    viewtable.Columns.Add(code);
                    var amt = new DataColumn("Amount");
                    viewtable.Columns.Add(amt);
                    foreach (DataRow row in table.Rows)
                    {
                        var formrow = viewtable.NewRow( );
                        formrow["BFY"] = row["BFY"];
                        formrow["Fund"] = row["Fund"];
                        formrow["Org"] = row["Org"];
                        formrow["RC"] = row["RC"];
                        formrow["BOC"] = row["BOC"];
                        formrow["Code"] = row["Code"];
                        formrow["Amount"] = row["Amount"];
                        viewtable.Rows.Add(formrow);
                    }
                    return viewtable;
                }

                #region Private Methods

                private DataTable GetTable(DataTable table, string column, string filter)
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

                private string[] GetCodes(DataTable table, string column)
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

                private PRC[] GetPrcArray(DataTable table)
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

                private decimal GetCount(DataTable table)
                {
                    try
                    {
                        return (decimal)table.AsEnumerable( ).Select(p => p).Count( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
                    }
                }

                private decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<decimal>("Amount")).Sum( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                private decimal GetAverage(DataTable table)
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

                private decimal[] GetValues(DataTable table)
                {
                    try
                    {
                        return new decimal[] { GetTotal(table), GetCount(table), GetAverage(table) };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return new decimal[] { -1m, -1m, -1m };
                    }
                }

                private decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }

                private Tuple<DataTable, PRC[], decimal> GetData(DataTable table, string column, string filter)
                {
                    try
                    {
                        var query = GetTable(table, column, filter);
                        decimal total = query.AsEnumerable( ).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                        PRC[] prc = query.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                        return new Tuple<DataTable, PRC[], decimal>(query, prc, total);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                private Dictionary<string, decimal> GetDataValues(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string f in filters)
                        {
                            info.Add(f, GetData(table, column, f).Item3);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion

                private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
                {
                }

                private void area_Click(object sender, EventArgs e)
                {
                }

                private void DivisionFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
                {
                }

                private void textBox3_TextChanged(object sender, EventArgs e)
                {
                }

                private void metroTextBox7_Click(object sender, EventArgs e)
                {
                }
            }
        }

        #endregion
    }
}