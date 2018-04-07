using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
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
            public partial class DivisionForm : MetroForm
            {
                #region Properties

                public Dictionary<string, decimal> BocInfo { get; set; }
                public DivisionAuthority Division { get; set; }
                public DataTable DivisionData { get; set; }
                public Dictionary<string, decimal> FteInfo { get; set; }
                public string[] FundCodes { get; }
                public Query P8Query { get; set; }
                public ChartControl PieChart { get; set; }
                public Dictionary<string, decimal> PrcInfo { get; set; }
                public decimal Total { get; }
                private Appropriation[] Appropriation { get; }
                private DataBuilder DataBuilder { get; set; }

                #endregion

                #region Constructors

                public DivisionForm()
                {
                    InitializeComponent();
                }

                public DivisionForm(string rc)
                {
                    InitializeComponent();
                    P8Query = new Query(Source.P8, GetP8QueryParameter(rc));
                    Division = new DivisionAuthority(rc);
                    DivisionData = Division.Data.BudgetTable;
                    BindData(DivisionData, Grid, P8BindingSource, DataNavigator);
                    FundCodes = Division.ProgramElements["Fund"];
                    PrcInfo = Division.FundData;
                    BocInfo = Division.BocData;
                    if (Division.FTE != null)
                    {
                        FteInfo = Division.FTE.FundData;
                    }
                    Text = $"{Info.DivisionName(rc)} ";
                    GetFilterButtons();
                    AssignButtonEvents();
                    lblTotalAmount.Text = GetTotal(DivisionData).ToString("c");
                    lblCount.Text = DivisionData.Rows.Count.ToString();
                }

                #endregion

                private void AreaButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "ProgramAreaName", button.Tag.ToString());
                    Text = $"Total {Division.Org.Name} Funding by Object Class";
                    string title = $"Total {button.Tag.ToString()} Funds: {GetTotal(table).ToString("c")}";
                    if (rb13.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Appropritaion";
                    }
                    if (rb14.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb15.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb16.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        AreaChart = new Chart(AreaChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void AssignButtonEvents()
                {
                    foreach (MetroSetButton ab in AppropriationTabFilterPanel.Controls)
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

                private void BindData(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
                {
                    bs.DataSource = table;
                    dg.DataSource = bs;
                    bn.BindingSource = bs;
                    GetGridColumns(dg);
                }

                private void BocButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "BocName", name);
                    Text = $"Total {Division.Org.Name} Funding by Object Class";
                    string title = $"{Division.Org.Name} {name} Funds: {GetTotal(table).ToString("c")}";
                    if (rb5.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb6.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        BocChart = new Chart(BocChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb7.Checked == true)
                    {
                        var alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb8.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        BocChart = new Chart(BocChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void DivisionForm_Load(object sender, EventArgs e)
                {
                    Text = "P7 " + Division.Org.Name;
                    AppropChart = new Chart(AppropChart, Division.FundData).CreateColumn();
                    BocChart = new Chart(BocChart, Division.BocData).CreateColumn();
                    NpmChart = new Chart(NpmChart, Division.NpmData).CreateColumn();
                    AreaChart = new Chart(AreaChart, Division.ProgramData).CreateColumn();
                    ProjectChart = new Chart(ProjectChart, Division.ProjectData).CreateColumn();
                    DivisionFormTabControl.SelectedIndexChanged += new EventHandler(GetTabPanelTitle);
                    BackButton.Visible = false;
                    PrcChart = GetPieChart(PrcChart, "", Division, P8BindingSource);
                    P8BindingSource.CurrentItemChanged += new EventHandler(UpdatePieChart);
                }

                private void ExcelExportButton_Clicked(object sender, EventArgs e)
                {
                    var excel = new ExcelOp(Division.RC.Code);
                    excel.ExportData(Division.Data.BudgetTable);
                }

                private string[] GetChartTitles()
                {
                    var t = new string[6];
                    t[0] = $"{Division.Org.Name} Funds by Appropriation";
                    t[1] = $"{Division.Org.Name} Funds by Object Class";
                    t[2] = $"{Division.Org.Name} FTE by HQ NPM";
                    t[3] = $"{Division.Org.Name} Funds by Program Area";
                    t[4] = $"{Division.Org.Name} Funds by Program Project";
                    t[5] = $"{Division.Org.Name} FTE by Appropriation";
                    return t;
                }

                private void GetFilterButtons()
                {
                    GetMetroSetButtons(AppropriationTabFilterPanel, GetCodes(DivisionData, "FundName"));
                    GetMetroSetButtons(panel2, GetCodes(DivisionData, "BocName"));
                    GetMetroSetButtons(panel3, GetCodes(DivisionData, "NPM"));
                    GetMetroSetButtons(panel4, GetCodes(DivisionData, "ProgramAreaName"));
                    GetMetroSetButtons(panel5, GetCodes(DivisionData, "ProgramProjectName"));
                    GetMetroSetButtons(GridFilterPanel, Division.ProgramElements["FundName"]);
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
                        b.Size = new Size(195, 45);
                        b.Margin = new Padding(3);
                        b.Padding = new Padding(1);
                        panel.Controls.Add(b);
                        panel.AutoSize = true;
                        b.Tag = f;
                    }
                }

                private void GetP8AppropFilterBox(DataTable table)
                {
                    GetMetroSetButtons(GridFilterPanel, GetCodes(table, "FundName"));
                    foreach (Control c in GridFilterPanel.Controls) c.Click += OnP8AppropButtonSelect;
                }

                private void GetP8BocFilterBox(DataTable table)
                {
                    GetMetroSetButtons(GridFilterPanel, GetCodes(table, "BocName"));
                    foreach (Control c in GridFilterPanel.Controls) c.Click += OnP8BocButtonSelect;
                }

                private Dictionary<string, object> GetP8QueryParameter(string rc)
                {
                    var query = new Dictionary<string, object> { ["RC"] = rc };
                    return query;
                }

                private ChartControl GetPieChart(ChartControl chart, string title, DivisionAuthority P8, BindingSource bs)
                {
                    PieChart = new Chart(chart, title, P8, bs).CreateColumn();
                    return PieChart;
                }

                private void GetTabPanelTitle(object sender, EventArgs e)
                {
                    int tabindex = DivisionFormTabControl.TabCount;
                    int tc = DivisionFormTabControl.SelectedIndex;
                    switch (tc)
                    {
                        case 0:
                            Text = $"{Division.Org.Name} Funds by Appropriation";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        case 1:
                            Text = $"{Division.Org.Name} Funds by Budget Object Class";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        case 2:

                            Text = $"{Division.Org.Name} Funds by National Program";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        case 3:
                            Text = $"{Division.Org.Name} Funds by Program Area";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        case 4:
                            Text = $"{Division.Org.Name} Funds by Program Project";
                            DivisionData = Division.Data.BudgetTable;
                            ProjectChart = new Chart(ProjectChart, Division.ProjectData).CreateColumn();
                            break;

                        case 5:
                            Text = $"{Division.Org.Name} Budget Database";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        case 6:
                            Text = $"{Division.Org.Name} Transfers";
                            DivisionData = Division.Data.BudgetTable;
                            break;

                        default:
                            Text = $"{Division.Org.Name} Status of Funds";
                            DivisionData = Division.Data.BudgetTable;
                            break;
                    }
                }

                private void metroButton2_Click(object sender, EventArgs e)
                {
                    var excel = new ExcelForm();
                    excel.ShowDialog();
                }

                private void NpmButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "NPM", button.Tag.ToString());
                    Text = $"Total {Division.Org.Name} Funding by Object Class";
                    string title = $"Total {button.Tag.ToString()} Funds: {GetTotal(table).ToString("c")}";
                    if (rb9.Checked == true)
                    {
                        var fundlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, fundlist, "FundName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb10.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb11.Checked == true)
                    {
                        var alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb12.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        NpmChart = new Chart(NpmChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void OnAppropButton_Select(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "FundName", name);
                    Text = $"Total {Division.Org.Name} Funding by Appropriation";
                    string title = $"Total {button.Tag.ToString()} Funds: {GetTotal(table).ToString("c")}";
                    if (rb1.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb2.Checked == true)
                    {
                        string[] npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb3.Checked == true)
                    {
                        string[] alist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, alist, "ProgramAreaName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Area";
                    }
                    if (rb4.Checked == true)
                    {
                        string[] projlist = GetCodes(table, "ProgramProjectName");
                        var data = GetDataValues(table, projlist, "ProgramProjectName");
                        AppropChart = new Chart(AppropChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Project";
                    }
                }

                private void OnP8AppropButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(Division.Data.BudgetTable, "FundName", name);
                    BindData(table, Grid, P8BindingSource, DataNavigator);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString();
                    GetP8BocFilterBox(table);
                    DatabaseGroupBox.Text = $"{Division.Org.Name}  {name} Data";
                    BackButton.Visible = true;
                    BackButton.Text = "Back";
                    DivisionData = table;
                    BackButton.Click += ReturnButton_OnAppropriationClick;
                }

                private void OnP8BocButtonSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "BocName", name);
                    BindData(table, Grid, P8BindingSource, DataNavigator);
                    BackButton.Text = "Back";
                    DatabaseGroupBox.Text = $"{Division.Org.Name} {name} Data";
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString();
                    BackButton.Click += ReturnButton_OnBocClick;
                }

                private void ProjectButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    string name = button.Tag.ToString();
                    var table = GetTable(DivisionData, "ProgramProjectName", button.Tag.ToString());
                    Text = $"Total {Division.Org.Name} Funding by Program Project";
                    string title = $"Total {button.Tag.ToString()} Funds: {GetTotal(table).ToString("c")}";
                    if (rb17.Checked == true)
                    {
                        var objlist = GetCodes(table, "FundName");
                        var data = GetDataValues(table, objlist, "FundName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Appropriation";
                    }
                    if (rb18.Checked == true)
                    {
                        var boclist = GetCodes(table, "BocName");
                        var data = GetDataValues(table, boclist, "BocName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Object Class";
                    }
                    if (rb19.Checked == true)
                    {
                        var npmlist = GetCodes(table, "NPM");
                        var data = GetDataValues(table, npmlist, "NPM");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by HQ National Program";
                    }
                    if (rb20.Checked == true)
                    {
                        var projlist = GetCodes(table, "ProgramAreaName");
                        var data = GetDataValues(table, projlist, "ProgramAreaName");
                        ProjectChart = new Chart(ProjectChart, title, data).CreateColumn();
                        Text = $"Total {Division.Org.Name} {name} Funding by Program Area";
                    }
                }

                private void ReturnButton_OnAppropriationClick(object sender, EventArgs e)
                {
                    var table = Division.Data.BudgetTable;
                    BindData(table, Grid, P8BindingSource, DataNavigator);
                    GetP8AppropFilterBox(table);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString();
                    BackButton.Visible = false;
                    DatabaseGroupBox.Text = $"{Division.Org.Name} Database";
                }

                private void ReturnButton_OnBocClick(object sender, EventArgs e)
                {
                    var table = Division.Data.BudgetTable;
                    BindData(table, Grid, P8BindingSource, DataNavigator);
                    GetP8AppropFilterBox(table);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString();
                    BackButton.Visible = false;
                    DatabaseGroupBox.Text = $"{Division.Org.Name} Database";
                }

                private void UpdatePieChart(object sender, EventArgs e)
                {
                    P8BindingSource = sender as BindingSource;
                    PrcChart = GetPieChart(PrcChart, "", Division, P8BindingSource);
                }

                private void area_Click(object sender, EventArgs e)
                {
                }

                private void DivisionFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
                {
                }

                private decimal GetAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }

                private string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private decimal GetCount(DataTable table)
                {
                    try
                    {
                        return (decimal)table.AsEnumerable().Select(p => p).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
                    }
                }

                private Tuple<DataTable, PRC[], decimal> GetData(DataTable table, string column, string filter)
                {
                    try
                    {
                        var query = GetTable(table, column, filter);
                        decimal total = query.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                        PRC[] prc = query.AsEnumerable().Select(p => new PRC()).ToArray();
                        return new Tuple<DataTable, PRC[], decimal>(query, prc, total);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private Dictionary<string, decimal> GetDataValues(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string f in filters)
                        {
                            info.Add(f, GetData(table, column, f).Item3);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private DataTable GetFormTable(DataTable table)
                {
                    DataTable viewtable = new DataTable();
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
                        var formrow = viewtable.NewRow();
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

                private PRC[] GetPrcArray(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => new PRC()).ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }

                private DataTable GetTable(DataTable table, string column, string filter)
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

                private decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Sum();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return new decimal[] { -1m, -1m, -1m };
                    }
                }

                private void metroTextBox7_Click(object sender, EventArgs e)
                {
                }

                private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
                {
                }

                private void textBox3_TextChanged(object sender, EventArgs e)
                {
                }
            }
        }
    }
}