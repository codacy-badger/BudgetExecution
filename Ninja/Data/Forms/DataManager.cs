using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Grid;
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

                //Constructors
                public DataManager(Source source)
                {
                    InitializeComponent();
                    Data = new DataBuilder(source);
                    Metric = new DataMetric(Data);
                    Table = Data.BudgetTable;
                    Ninja = new FormData(Data, BindingSource, Grid, Navigator);
                    Element = Ninja.GetProgramElements(Table);
                    PrcChart = new BudgetChart(PrcChart, Data, PrcFilter.FundName, Statistic.Total).Activate();
                    GetGridSelectedRowValues();
                }

                //Properties
                public DataBuilder Data { get; }
                public DataMetric Metric { get; }
                public Dictionary<string, string[]> Element { get; set; }
                public FormData Ninja { get; set; }
                public DataTable Table { get; set; }
                public decimal Total { get; }

                //Methods
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

                public Dictionary<string, string[]> ProgramElements { get; set; }

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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }

                private void Form_Load(object sender, EventArgs e)
                {
                    try
                    {
                        ReturnButton.Visible = false;
                        ReturnButton.Click += Ninja.ReturnButton_OnClick;
                        BindingSource.CurrentItemChanged += UpdateDataChart;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }

                private void GetCalculatorValue(DataGridView gridrow)
                {
                    try
                    {
                        var amt = new Syncfusion.Windows.Forms.Tools.CalculatorValue();
                        //amt.SetValue(gridrow.Cells["Amount"].Value.ToString());
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }

                private void GetGridSelectedRowValues()
                {
                    try
                    {
                        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        bfy.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                        fund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                        org.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                        rc.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                        code.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                        boc.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                        amount1.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }

                private void GridRow_DoubleClick(object sender, EventArgs e)
                {
                    try
                    {
                        var am = new AccountManager();
                        am.Show();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }


                private void UpdateDataChart(object sender, EventArgs e)
                {
                   
                }

                private void UpdateGridSelectedRowValues(object sender, EventArgs e)
                {
                    try
                    {
                        bfy.DataBindings.Add(new Binding("Text", Grid.DataSource, "BFY"));
                        fund.DataBindings.Add(new Binding("Text", Grid.DataSource, "Fund"));
                        org.DataBindings.Add(new Binding("Text", Grid.DataSource, "Org"));
                        rc.DataBindings.Add(new Binding("Text", Grid.DataSource, "RC"));
                        code.DataBindings.Add(new Binding("Text", Grid.DataSource, "Code"));
                        boc.DataBindings.Add(new Binding("Text", Grid.DataSource, "BOC"));
                        amount1.DataBindings.Add(new Binding("Text", Grid.DataSource, "Amount"));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }


                private void GetGridColumns(DataGridView dgv)
                {
                    foreach (DataGridViewColumn dc in dgv.Columns)
                        dc.Visible = false;
                    dgv.Columns[0].Visible = true;
                    dgv.Columns[4].Visible = true;
                    dgv.Columns[5].Visible = true;
                    dgv.Columns[6].Visible = true;
                    dgv.Columns[8].Visible = true;
                    dgv.Columns[8].HeaderText = "BOC";
                    dgv.Columns[9].Visible = true;
                    dgv.Columns[11].Visible = true;
                    dgv.Columns[12].Visible = true;
                }

                void GetFundFilterItems()
                {
                    var item = Data.ProgramElements["FundName"];
                    foreach (string i in item)
                        FundFilter.Items.Add(i);
                }

                void FundFilter_ItemSelected(object sender, EventArgs e)
                {
                    BocFilter.Items.Clear();
                    var filter = sender as MetroSetComboBox;
                    FundFilter.Tag = filter;
                    var fund = filter.SelectedItem.ToString();
                    BindingSource.Filter = $"FundName = '{fund}'";
                    var boc = ProgramElements[Budget.Ninja.Data.PrcFilter.BocName.ToString()];
                    foreach (string b in boc)
                        BocFilter.Items.Add(b);
                    BocFilter.Visible = true;
                    BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
                }

                void BocFilter_ItemSelected(object sender, EventArgs e)
                {
                    var boc = sender as MetroSetComboBox;
                    var bocfilter = boc.SelectedItem.ToString();
                    BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";

                }
            }
        }
    }
}