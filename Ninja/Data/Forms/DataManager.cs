#region Using Directives

using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class DataManager : Syncfusion.Windows.Forms.MetroForm
            {
                #region Properties

                public Source Source { get; set; }
                public DataBuilder Data { get; set; }
                public RegionalAuthority Regional { get; set; }
                public DivisionAuthority Division { get; set; }
                public DataTable Table { get; set; }
                public ChartControl PieChart { get; set; }
                public Query P7Query { get; set; }
                public CurrencyManager Currency { get; set; }
                public decimal Total { get; }

                #endregion

                #region Constructors

                public DataManager( )
                {
                    InitializeComponent( );
                }

                public DataManager(Source source)
                {
                    InitializeComponent( );
                    if (source == Source.P7)
                    {
                        Source = Source.P7;
                        Regional = new RegionalAuthority( );
                        Data = Regional.Data;
                        Table = Regional.Data.Table;
                    }
                    if (source == Source.P8)
                    {
                        Source = Source.P8;
                        Division = new DivisionAuthority( );
                        Data = Division.Data;
                        Table = Division.Data.Table;
                    }
                    BindData(Table, DataManagerGrid, BindingSource, DatabaseNavigator);
                    PrcChart = GetPieChart(PrcChart, "", Source, BindingSource);
                    BindingSource.CurrentItemChanged += new EventHandler(UpdatePieChart);
                    DataManagerGrid.RowHeaderMouseDoubleClick += GridRow_DoubleClick;
                    GetAppropFilterBox(Table);
                    ReturnButton.Visible = false;
                    DatabaseGroupBox.Text = $"{Table.TableName} Database";
                }

                #endregion

                #region Form Load EventHandler and Methods

                private void Form_Load(object sender, EventArgs e)
                {
                    GetAppropFilterBox(Table);
                    ReturnButton.Visible = false;
                    PrcChart = GetPieChart(PrcChart, "", Source, BindingSource);
                    BindingSource.CurrentItemChanged += new EventHandler(UpdatePieChart);
                }

                private void P7Grid_SelectionChanged(object sender, EventArgs e)
                {
                    GetGridSelectedRowValues(sender, e);
                }

                #endregion

                #region Filter Button Methods

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

                private void GetAppropFilterBox(DataTable table)
                {
                    GetMetroSetButtons(DataManagerFilterPanel, GetCodes(table, "FundName"));
                    foreach (Control c in DataManagerFilterPanel.Controls) c.Click += AppropriationButton_OnSelect;
                }

                private void AppropriationButton_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var table = GetTable(Table, "FundName", button.Tag.ToString( ));
                    BindData(table, DataManagerGrid, BindingSource, DatabaseNavigator);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    DatabaseGroupBox.Text = $"{table.TableName} Data";
                    ReturnButton.Visible = true;
                    GetBocFilterBox(table);
                    ReturnButton.Click += OnReturnButtonAppropriationSelect;
                    DatabaseGroupBox.Text = $"{button.Tag.ToString( )} Database";
                    Table = table;
                }

                private void GetBocFilterBox(DataTable table)
                {
                    GetMetroSetButtons(DataManagerFilterPanel, GetCodes(table, "BocName"));
                    foreach (Control c in DataManagerFilterPanel.Controls) c.Click += BocButtonSelect_OnSelect;
                }

                private void BocButtonSelect_OnSelect(object sender, EventArgs e)
                {
                    var button = sender as MetroSetButton;
                    var table = GetTable(Table, "BocName", button.Tag.ToString( ));
                    BindData(table, DataManagerGrid, BindingSource, DatabaseNavigator);
                    lblTotalAmount.Text = GetTotal(table).ToString("c");
                    lblCount.Text = table.Rows.Count.ToString( );
                    DatabaseGroupBox.Text = $"{table.TableName} Data";
                    ReturnButton.Visible = true;
                    ReturnButton.Click += OnReturnButtonAppropriationSelect;
                    DatabaseGroupBox.Text = $"{button.Tag.ToString( )} Database";
                }

                #endregion

                #region ReturnPanel Methods

                private void OnReturnButtonAppropriationSelect(object sender, EventArgs e)
                {
                    GetAppropFilterBox(Table);
                    BindingSource.DataSource = Table;
                    ReturnButton.Visible = false;
                    DatabaseGroupBox.Text = $"{Table.TableName} Database";
                }

                private void ReturnButton_OnClick(object sender, EventArgs e)
                {
                    var r6 = new SummarySelector( );
                    r6.ShowDialog( );
                }

                #endregion

                #region DataGridView Members

                private void GetGridColumns(DataGridView dgv)
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

                private void BindData(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
                {
                    bs.DataSource = table;
                    dg.DataSource = bs;
                    bn.BindingSource = bs;
                    GetGridColumns(dg);
                }

                private ChartControl GetPieChart(ChartControl chart, string title, Source source, BindingSource bs)
                {
                    if (source == Source.P7)
                        PieChart = new Chart(chart, title, Regional, bs).CreateColumn( );
                    if (source == Source.P8)
                        PieChart = new Chart(chart, title, Division, bs).CreateColumn( );
                    return PieChart;
                }

                private void UpdatePieChart(object sender, EventArgs e)
                {
                    BindingSource = sender as BindingSource;
                    PrcChart = GetPieChart(PrcChart, "", Source, BindingSource);
                }

                private void GetGridSelectedRowValues(object sender, EventArgs e)
                {
                    DataManagerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    var gridrow = DataManagerGrid.CurrentRow;
                    var bfy = DataManagerGrid.CurrentRow.Cells["BFY"].Value;
                    BFY.Text = bfy.ToString( );
                    var fund = gridrow.Cells["Fund"].Value;
                    Fund.Text = fund.ToString( );
                    var org = gridrow.Cells["Org"].Value;
                    Org.Text = org.ToString( );
                    var rc = gridrow.Cells["RC"].Value;
                    RC.Text = rc.ToString( );
                    var code = gridrow.Cells["Code"].Value;
                    Code.Text = code.ToString( );
                    var boc = gridrow.Cells["BOC"].Value;
                    BOC.Text = boc.ToString( );
                    var funding = gridrow.Cells["Amount"].Value;
                    OldAmount.Text = gridrow.Cells["Amount"].Value.ToString( );
                }

                private void GetCalculatorValue(DataGridViewRow gridrow)
                {
                    var amt = new Syncfusion.Windows.Forms.Tools.CalculatorValue( );
                    amt.SetValue(gridrow.Cells["Amount"].Value.ToString( ));
                }

                private void GridRow_DoubleClick(object sender, EventArgs e)
                {
                    var am = new AccountManager( );
                    am.Show( );
                }

                #endregion

                #region IAuthority Implementation Methods

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
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

                public Tuple<DataTable, PRC[], decimal, int> GetData(DataTable table, string column, string filter)
                {
                    try
                    {
                        DataTable qtable = GetTable(table, column, filter);
                        PRC[] prc = qtable.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                        int count = qtable.Rows.Count;
                        return new Tuple<DataTable, PRC[], decimal, int>(qtable, prc, GetTotal(qtable), count);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetData(DataTable table, string[] filters, string column)
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

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>( );
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
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion

                private void P7DataManager_Load(object sender, EventArgs e)
                {
                }

                private void P7BFY_Click(object sender, EventArgs e)
                {
                }
            }
        }
    }
}