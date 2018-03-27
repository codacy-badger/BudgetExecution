using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Metro = Syncfusion.Windows.Forms.MetroForm;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class DataManager : Metro
            {
                #region Properties
                public Source Source { get; set; }
                public DataBuilder Data { get; set; }
                public RegionalAuthority Regional { get; set; }
                public DivisionAuthority Division { get; set; }
                FormData FormNinja { get; set; }
                public DataTable Table { get; set; }
                public ChartControl DataChart { get; set; }
                public Query DataManagerQuery { get; set; }
                public decimal Total { get; }
                #endregion

                #region Constructors
                public DataManager(Source source)
                {
                    InitializeComponent();
                    FormNinja = new FormData(source, DataMgrBindingSource, DataMgrGrid, DataMgrNavigator);
                    FormNinja.GetGridColumns(DataMgrGrid);
                    Data = FormNinja.NinjaData;
                }

                #endregion

                #region Form Load EventHandler and Methods

                private void Form_Load(object sender, EventArgs e)
                {
                    ReturnButton.Visible = false;
                    PrcChart = GetPieChart(PrcChart, "", Source, DataMgrBindingSource);
                    DataMgrBindingSource.CurrentItemChanged += new EventHandler(UpdatePieChart);
                }

                private void P7Grid_SelectionChanged(object sender, EventArgs e)
                {
                    GetGridSelectedRowValues(sender, e);
                }

                #endregion

                private ChartControl GetPieChart(ChartControl chart, string title, Source source, BindingSource bs)
                {
                    if (source == Source.P7)
                        DataChart = new Chart(chart, title, Regional, bs).CreateColumn();
                    if (source == Source.P8)
                        DataChart = new Chart(chart, title, Division, bs).CreateColumn();
                    return DataChart;
                }

                private void UpdatePieChart(object sender, EventArgs e)
                {
                    DataMgrBindingSource = sender as BindingSource;
                    PrcChart = GetPieChart(PrcChart, "", Source, DataMgrBindingSource);
                }

                private void GetGridSelectedRowValues(object sender, EventArgs e)
                {
                    DataMgrGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    var gridrow = DataMgrGrid.CurrentRow;
                    var bfy = DataMgrGrid.CurrentRow.Cells["BFY"].Value;
                    this.bfy.Text = bfy.ToString();
                    var fund = gridrow.Cells["Fund"].Value;
                    this.fund.Text = fund.ToString();
                    var org = gridrow.Cells["Org"].Value;
                    this.org.Text = org.ToString();
                    var rc = gridrow.Cells["RC"].Value;
                    this.rc.Text = rc.ToString();
                    var code = gridrow.Cells["Code"].Value;
                    this.code.Text = code.ToString();
                    var boc = gridrow.Cells["BOC"].Value;
                    this.boc.Text = boc.ToString();
                    var funding = gridrow.Cells["Amount"].Value;
                    amount1.Text = gridrow.Cells["Amount"].Value.ToString();
                }

                private void GetCalculatorValue(DataGridViewRow gridrow)
                {
                    var amt = new Syncfusion.Windows.Forms.Tools.CalculatorValue();
                    amt.SetValue(gridrow.Cells["Amount"].Value.ToString());
                }

                private void GridRow_DoubleClick(object sender, EventArgs e)
                {
                    var am = new AccountManager();
                    am.Show();
                }


                #region IAuthority Implementation Methods

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public DataTable GetTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Tuple<DataTable, PRC[], decimal, int> GetData(DataTable table, string column, string filter)
                {
                    try
                    {
                        DataTable qtable = GetTable(table, column, filter);
                        PRC[] prc = qtable.AsEnumerable().Select(p => new PRC()).ToArray();
                        int count = qtable.Rows.Count;
                        return new Tuple<DataTable, PRC[], decimal, int>(qtable, prc, GetTotal(qtable), count);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetData(DataTable table, string[] filters, string column)
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        foreach (string filter in list)
                        {
                            decimal[] stat = new decimal[4];
                            stat[0] = GetTotal(table);
                            stat[1] = (decimal)(table.Rows.Count);
                            stat[2] = stat[0] / stat[1];
                            stat[3] = stat[0] / GetTotal(table);
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion


  
            }
        }
    }
}