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

                public DivisionAuthority D6 { get; set; }
                public Dictionary<string, string[]> Element { get; set; }
                public FormData Ninja { get; set; }
                public RegionalAuthority R6 { get; set; }
                public Source Source { get; set; }
                public DataTable Table { get; set; }
                public decimal Total { get; }

                #endregion

                #region Constructors

                public DataManager(Source source)
                {
                    InitializeComponent();
                    if (source == Source.P7)
                    {
                        this.R6 = new RegionalAuthority();
                    }
                    if (source == Source.P8)
                    {
                        D6 = new DivisionAuthority();
                    }
                    Ninja = new FormData(source, FilterPanel, BindingSource, DataMgrGrid, Navigator);
                    Ninja.GetGridColumns(DataMgrGrid);
                    Table = Ninja.Table;
                    Element = Ninja.GetDataElements(Table);
                    Ninja.GetFilterButtons(FilterPanel, Element["FundName"]);
                    Ninja.GetAppropriationFilterListBox(Table, FilterPanel);
                    PrcChart = GetDataChart(PrcChart, "", source, BindingSource);
                    GetGridSelectedRowValues();
                }

                #endregion

                public string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
                        return null;
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
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1M;
                    }
                }

                private void Form_Load(object sender, EventArgs e)
                {
                    ReturnButton.Visible = false;
                    ReturnButton.Click += Ninja.ReturnButton_OnClick;
                    BindingSource.CurrentItemChanged += UpdateDataChart;
                }

                private void GetCalculatorValue(DataGridViewRow gridrow)
                {
                    var amt = new Syncfusion.Windows.Forms.Tools.CalculatorValue();
                    amt.SetValue(gridrow.Cells["Amount"].Value.ToString());
                }

                private ChartControl GetDataChart(ChartControl chart, string title, Source source, BindingSource bs)
                {
                    if (source == Source.P7)
                        chart = new Chart(chart, title, R6, bs).CreateColumn();
                    if (source == Source.P8)
                        chart = new Chart(chart, title, D6, bs).CreateColumn();
                    return chart;
                }

                private void GetGridSelectedRowValues()
                {
                    DataMgrGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    bfy.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "BFY"));
                    fund.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Fund"));
                    org.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Org"));
                    rc.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "RC"));
                    code.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Code"));
                    boc.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "BOC"));
                    amount1.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Amount"));
                }

                private void GridRow_DoubleClick(object sender, EventArgs e)
                {
                    var am = new AccountManager();
                    am.Show();
                }

                private void groupBox2_Enter(object sender, EventArgs e)
                {
                }

                private void UpdateDataChart(object sender, EventArgs e)
                {
                    BindingSource = sender as BindingSource;
                    PrcChart = GetDataChart(PrcChart, "", Source, BindingSource);
                }

                private void UpdateGridSelectedRowValues(object sender, EventArgs e)
                {
                    var current = DataMgrGrid.CurrentRow;
                    bfy.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "BFY"));
                    fund.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Fund"));
                    org.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Org"));
                    rc.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "RC"));
                    code.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Code"));
                    boc.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "BOC"));
                    amount1.DataBindings.Add(new Binding("Text", DataMgrGrid.DataSource, "Amount"));
                }
            }
        }
    }
}