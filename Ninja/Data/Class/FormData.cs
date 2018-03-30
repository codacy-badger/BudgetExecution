#region Using Directives

using MetroSet_UI.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Chart;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class FormData : IAuthority
            {
                #region Properties

                public DataBuilder Data { get; set; }
                public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; set; }
                bool Percent { get; set; }
                public DataSet E6 { get; set; }
                public DataTable Table { get; set; }
                public decimal Total { get; set; }
                public decimal Average { get; set; }
                public int Count { get; set; }
                public Dictionary<string, string[]> DataElement { get; set; }
                public FlowLayoutPanel Panel { get; set; }
                public BindingSource BindingSource { get; set; }
                public DataGridView DataGrid { get; set; }
                public BindingNavigator Navigator { get; set; }
                public decimal[] Metrics { get; set; }
                public ChartControl Chart { get; set;}  
                public ChartDataBindModel ChartModel { get; set; }

                #endregion

                #region Constructors

                public FormData( )
                {
                }

                public FormData(Source source, FlowLayoutPanel panel, BindingSource bs, DataGridView dgv, BindingNavigator bn)
                {
                    Data = new DataBuilder(source);
                    E6 = Data.GetDataSet();
                    Table = Data.Table;
                    BindFormData(Table, dgv, bs, bn);
                    DataElement = GetDataElements(Table);
                    Panel = panel;
                    BindingSource = bs;
                    Navigator = bn;
                    DataGrid = dgv;
                    GetAppropriationFilterBox(Table, Panel);
                }

                #endregion

                #region Methods

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

                internal void BindTextBox(BindingSource bs, TextBox tb, string field)
                {
                    var table = (DataTable)bs.DataSource;
                    var row = table.Rows[bs.Position];
                    var binding = new Binding("Text", row, field);
                    tb.DataBindings.Add(binding);
                }

                internal void BindFormData(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
                {
                    bs.DataSource = table;
                    dg.DataSource = bs;
                    bn.BindingSource = bs;
                    GetGridColumns(dg);
                }

                internal void GetFilterButtons(FlowLayoutPanel panel, string[] list)
                {
                    panel.Controls.Clear();
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
                        b.Size = new Size(175,30);
                        b.Margin = new Padding(3);
                        b.Padding = new Padding(1);
                        panel.Controls.Add(b);
                        panel.AutoSize = true;
                        b.Tag = f;                        
                    }
                }

                internal void GetAppropriationFilterBox(DataTable table, FlowLayoutPanel filterPanel)
                {
                    GetFilterButtons(filterPanel, GetCodeElements(table, "FundName"));
                    foreach (Control c in filterPanel.Controls) c.Click += AppropriationButton_OnSelect;
                }

                internal void AppropriationButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var table = GetTable(Table, "FundName", button.Tag.ToString( ));
                    BindingSource.DataSource = table;
                    GetBocFilterBox(table, Panel);
                    Table = table;
                }

                internal void GetBocFilterBox(DataTable table, FlowLayoutPanel filterPanel)
                {
                    GetFilterButtons(filterPanel, GetCodeElements(table, "BocName"));
                    foreach (Control c in filterPanel.Controls) c.Click += BocButtonSelect_OnSelect;
                }

                internal void BocButtonSelect_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var table = GetTable(Table, "BocName", button.Tag.ToString( ));
                    BindingSource.DataSource = table;
                    GetBocFilterBox(Table, Panel);
                }

                internal void ReturnButton_OnClick(object sender, EventArgs e)
                {
                    Table = Data.Table;
                    BindingSource.DataSource = Table;
                    GetAppropriationFilterBox(Table, Panel);
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
                            stat[3] = (stat[0] / stat[1]) * 100;
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
                            stat[3] = (stat[0] / stat[1]) * 100;
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

                public DataTable GetTable(DataTable table, string column, string filter)
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

                #endregion
            }
        }
    }
}