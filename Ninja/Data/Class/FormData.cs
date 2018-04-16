using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class FormData 
            {
                //Constructors
                public FormData()
                {
                }

                public FormData(DataBuilder data, BindingSource bs, DataGridView dgv, BindingNavigator bn)
                {
                    Data = data;
                    BudgetMetric = new DataMetric(Data);
                    BudgetData = Data.BudgetData;
                    Table = Data.BudgetTable;
                    BindGridAndNavigator(Table, dgv, bs, bn);
                    BindingSource = bs;
                    Navigator = bn;
                    DataGrid = dgv;
                }

                //Properties
                public DataBuilder Data { get; set; }
                public DataMetric BudgetMetric { get; set; }
                public DataSet BudgetData { get; set; }
                public DataTable Table { get; set; }
                public ChartControl Chart { get; set; }
                public ChartDataBindModel ChartModel { get; set; }
                public int Count { get; set; }
                public DataGridView DataGrid { get; set; }
                public decimal[] Metrics { get; set; }
                public BindingNavigator Navigator { get; set; }
                public BindingSource BindingSource { get; set; }
                public FlowLayoutPanel Panel { get; set; }
                private bool Percent { get; set; }


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

                public decimal GetAverage(DataTable table)
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

                public string[] GetCodes(DataTable table, string column)
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
                
                public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string ftr in list)
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                .Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }               

                public PRC[] GetPrcArray(DataTable table)
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

                public Dictionary<string, string[]> GetProgramElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>();
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

                public DataTable GetTable(DataTable table, string column, string filter)
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

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }

                public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string filter in filters)
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                .Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                internal void AppropriationButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var table = GetTable(Table, "FundName", button.Tag.ToString());
                    BindingSource.DataSource = table;
                    GetBocFilterBox(table, Panel);
                    Table = table;
                }

                internal void AppropriationListBoxItem_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetListBox;
                    var table = GetTable(Table, "FundName", button.SelectedItem.ToString());
                    BindingSource.DataSource = table;
                    Table = table;
                }

                internal void BindGridAndNavigator(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
                {
                    bs.DataSource = table;
                    dg.DataSource = bs;
                    bn.BindingSource = bs;
                    GetGridColumns(dg);
                }

                internal void BindTextBox(BindingSource bs, TextBox tb, string field)
                {
                    var table = (DataTable)bs.DataSource;
                    var row = table.Rows[bs.Position];
                    var binding = new Binding("Text", row, field);
                    tb.DataBindings.Add(binding);
                }

                internal void BocButtonSelect_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetListBox;
                    var table = GetTable(Table, "BocName", button.SelectedItem.ToString());
                    BindingSource.DataSource = table;
                    GetBocFilterBox(Table, Panel);
                }

                internal void BocListBoxItem_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetListBox;
                    var table = GetTable(Table, "BocName", button.SelectedItem.ToString());
                    BindingSource.DataSource = table;
                    GetBocFilterBox(Table, Panel);
                }

                internal void ConfigureTabControl(MetroForm form, TabControlAdv tab, DataBuilder Ninja)
                {
                    foreach (TabPageAdv tp in tab.TabPages)
                    {
                        tp.TabForeColor = SystemColors.MenuHighlight;
                        tp.TabBackColor = Color.Black;
                    }
                    tab.TabPages[0].Text = "Summary";
                    tab.TabPages[1].Text = "Appropriation";
                    tab.TabPages[2].Text = "BOC";
                    tab.TabPages[3].Text = "NPM";
                    tab.TabPages[4].Text = "Goal";
                    if (Ninja.Query.Source == Source.P7)
                    {
                        tab.TabPages[5].Text = "Objective";
                        tab.TabPages[6].Text = "Divisions";
                        tab.TabPages[7].Text = "Transfers";
                    }
                    if (Ninja.Query.Source == Source.P8)
                    {
                        tab.TabPages[5].Text = "Program Area";
                        tab.TabPages[6].Text = "Program Project";
                        tab.TabPages[7].Text = "Transfers";
                    }
                }

                internal void GetAppropriationFilterButtonBox(DataTable table, Control filterPanel)
                {
                    GetFilterButtons(filterPanel, GetCodes(table, "FundName"));
                    foreach (Control c in filterPanel.Controls) c.Click += AppropriationButton_OnSelect;
                }

                internal void GetAppropriationFilterListBox(DataTable table, Control filterPanel)
                {
                    var filter = filterPanel as ListBox;
                    GetFilterListItems(filter, GetCodes(table, "FundName"));
                    filter.SelectedIndexChanged += AppropriationListBoxItem_OnSelect;
                }

                internal void GetBocFilterBox(DataTable table, FlowLayoutPanel filterPanel)
                {
                    GetFilterButtons(filterPanel, GetCodes(table, "BocName"));
                    foreach (Control c in filterPanel.Controls) c.Click += BocButtonSelect_OnSelect;
                }

                internal void GetBocListBox(DataTable table, Control filterPanel)
                {
                    var filter = filterPanel as ListBox;
                    GetFilterButtons(filter, GetCodes(table, "BocName"));
                    filter.SelectedIndexChanged += BocListBoxItem_OnSelect;
                }

                internal void GetFilterButtons(Control panel, string[] list)
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
                        b.HoverBorderColor = Color.Blue;
                        b.HoverColor = Color.SteelBlue;
                        b.HoverTextColor = Color.AntiqueWhite;
                        b.Size = new Size(175, 30);
                        b.Margin = new Padding(3);
                        b.Padding = new Padding(1);
                        panel.Controls.Add(b);
                        panel.AutoSize = true;
                        b.Tag = f;
                    }
                }

                internal void GetFilterListItems(Control panel, string[] list)
                {
                    var box = panel as ListBox;
                    box.Controls.Clear();
                    foreach (string f in list)
                    {
                        box.Items.Add(f);
                    }
                }

                internal void GetFormSettings(MetroForm form)
                {
                    form.Size = new Size(1200, 700);
                    form.BackColor = Color.Black;
                    form.BorderColor = SystemColors.MenuHighlight;
                    form.ForeColor = SystemColors.MenuHighlight;
                    form.MetroColor = Color.Black;
                    form.ShowIcon = false;
                    form.ShowInTaskbar = true;
                    form.CaptionBarColor = Color.Black;
                    form.CaptionFont = new Font("Segoe UI", 10f, FontStyle.Regular);
                    form.CaptionForeColor = SystemColors.MenuHighlight;
                    form.BorderThickness = 1;
                    form.Padding = new Padding(1);
                    form.CaptionAlign = HorizontalAlignment.Left;
                }

                internal void GetGridColumns(DataGridView dgv)
                {
                    foreach (DataGridViewColumn dc in dgv.Columns)
                        dc.Visible = false;
                    dgv.Columns[3].Visible = true;
                    dgv.Columns[4].Visible = true;
                    dgv.Columns[6].Visible = true;
                    dgv.Columns[8].Visible = true;
                    dgv.Columns[9].Visible = true;
                    dgv.Columns[11].Visible = true;
                    dgv.Columns[12].Visible = true;
                    dgv.Columns[12].DefaultCellStyle.Format = "c";
                }

                internal void ReturnButton_OnClick(object sender, EventArgs e)
                {
                    Table = Data.BudgetTable;
                    BindingSource.DataSource = Table;
                }

            }
        }
    }
}