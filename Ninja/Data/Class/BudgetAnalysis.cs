#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class RegAnalysis
            {
                #region Properties

                public RegionalAuthority EPA { get; }
                public decimal Ratio { get; set; }
                public decimal Total { get; set; }
                public decimal Average { get; set; }
                public decimal Deviation { get; set; }
                public decimal Difference { get; set; }
                public DataTable Data { get; set; }
                public Dictionary<string, decimal> Value { get; set; }
                public Dictionary<string, decimal> Percent { get; set; }
                public ChartControl ColChart { get; set; }
                public ChartControl PieChart { get; set; }

                #endregion

                #region Constructors

                public RegAnalysis( )
                {
                    EPA = new RegionalAuthority( );
                    Total = EPA.Total;
                    Data = EPA.Data.Table;
                }

                #endregion

                #region Methods

                internal DataTable GetTable(Dictionary<string, string> filter)
                {
                    foreach (KeyValuePair<string, string> kvp in filter)
                    {
                        try
                        {
                            return Data.AsEnumerable( ).Where(p => p.Field<string>(kvp.Key).Equals(kvp.Value))
                                .Select(p => p).CopyToDataTable( );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                            return null;
                        }
                    }
                    return null;
                }

                internal DataTable GetTable(DataTable table, Dictionary<string, string> filter)
                {
                    foreach (KeyValuePair<string, string> kvp in filter)
                    {
                        try
                        {
                            return table.AsEnumerable( ).Where(p => p.Field<string>(kvp.Key).Equals(kvp.Value))
                                .Select(p => p).CopyToDataTable( );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                            return null;
                        }
                    }
                    return null;
                }

                private decimal GetTotal(DataTable table)
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

                internal decimal GetTotal(DataTable table, string column, string filter)
                {
                    return table.AsEnumerable( ).Where(p => p.Field<string>(column)
                       .Equals(filter)).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
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

                private int GetCount(DataTable table)
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

                private string[] GetCodes(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<string>("BOC")).Distinct( ).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal string[] GetCodes(DataTable table, string column)
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

                internal DivisionAuthority[] GetDivision( )
                {
                    string[] rc = Info.RcCodes;
                    DivisionAuthority[] division = new DivisionAuthority[rc.Length];
                    for (int i = 0; i < rc.Length; i++)
                        division[i] = new DivisionAuthority(rc[i]);
                    return division;
                }

                internal decimal GetPercentage(decimal sample, decimal population)
                {
                    return ((sample / population) * 100M);
                }

                internal Tuple<DataTable, PRC[], decimal, int> GetData(DataTable table, Dictionary<string, string> filter)
                {
                    try
                    {
                        DataTable filtered = GetTable(table, filter);
                        return new Tuple<DataTable, PRC[], decimal, int>(filtered, GetPrcArray(filtered),
                            GetTotal(filtered), GetCount(filtered));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal Tuple<DataTable, PRC[], decimal, int> GetData(DataTable table, string column, string filter)
                {
                    try
                    {
                        var filtered = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                        return new Tuple<DataTable, PRC[], decimal, int>(filtered, GetPrcArray(filtered),
                            GetTotal(filtered), GetCount(filtered));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal Dictionary<string, decimal> GetData(DataTable table, string[] filters, string column)
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

                private Dictionary<string, decimal> GetP8Info( )
                {
                    var info = new Dictionary<string, decimal>( );
                    foreach (DivisionAuthority d in GetDivision( ))
                        info.Add(d.Org.Name, d.Data.Total);
                    return info;
                }

                #region Chart Members

                internal ChartControl GetColChart(ChartControl chart, Dictionary<string, decimal> a)
                {
                    var aseries = new ChartSeries("BOC", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, decimal> kvp in a)
                    {
                        aseries.Points.Add(kvp.Key, (double)(kvp.Value));
                    }
                    chart.Series.Clear( );
                    chart.Series.Add(aseries);
                    chart.Series[0].Style.Font.FontStyle = FontStyle.Bold;
                    chart.Series[0].Style.DisplayShadow = true;
                    chart.Series[0].Style.TextColor = Color.White;
                    chart.Series[0].Style.Font.Size = 12;
                    chart.Series[0].Style.Font.Facename = "Consolas";
                    chart.Series[0].DrawSeriesNameInDepth = false;
                    chart.Series[0].ConfigItems.ColumnItem.PhongAlpha = 2;
                    chart.Series[0].LegendItemUseSeriesStyle = true;
                    chart.ChartArea.Series3D = true;
                    chart.Tilt = 5;
                    chart.Depth = 250;
                    chart.Rotation = 25;
                    chart.RealMode3D = true;
                    chart.Style3D = true;
                    chart.Legends[0].VisibleCheckBox = true;
                    aseries.SmartLabels = true;
                    aseries.SortPoints = true;
                    aseries.Style.DisplayText = true;
                    aseries.Style.TextFormat = "${0:N}";
                    aseries.Style.TextOffset = 15.0F;
                    aseries.Style.TextOrientation = ChartTextOrientation.Up;
                    return chart;
                }

                internal ChartControl GetColChart(ChartControl chart, Dictionary<string, decimal> a, Dictionary<string, decimal> b)
                {
                    var aseries = new ChartSeries("BOC", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, decimal> kvp in a)
                    {
                        aseries.Points.Add(kvp.Key, (double)(kvp.Value));
                    }
                    var bseries = new ChartSeries("NPM", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, decimal> kp in b)
                    {
                        bseries.Points.Add(kp.Key, (double)(kp.Value));
                    }
                    chart.Series.Clear( );
                    chart.Series.Add(aseries);
                    chart.Series.Add(bseries);
                    chart.Series[0].Style.Font.FontStyle = FontStyle.Bold;
                    chart.Series[0].Style.DisplayShadow = true;
                    chart.Series[0].Style.TextColor = Color.White;
                    chart.Series[0].Style.Font.Size = 12;
                    chart.Series[0].Style.Font.Facename = "Consolas";
                    chart.Series[0].DrawSeriesNameInDepth = false;
                    chart.Series[0].ConfigItems.ColumnItem.PhongAlpha = 2;
                    chart.Series[0].LegendItemUseSeriesStyle = true;
                    chart.Series[1].Style.Font.FontStyle = FontStyle.Bold;
                    chart.Series[1].Style.DisplayShadow = true;
                    chart.Series[1].Style.TextColor = Color.White;
                    chart.Series[1].Style.Font.Size = 12;
                    chart.Series[1].Style.Font.Facename = "Consolas";
                    chart.Series[1].DrawSeriesNameInDepth = false;
                    chart.Series[1].ConfigItems.ColumnItem.PhongAlpha = 2;
                    chart.Series[1].LegendItemUseSeriesStyle = true;
                    chart.ChartArea.Series3D = true;
                    chart.Tilt = 5;
                    chart.Depth = 250;
                    chart.Rotation = 25;
                    chart.RealMode3D = true;
                    chart.Style3D = true;
                    chart.Legends[0].VisibleCheckBox = true;
                    aseries.SmartLabels = true;
                    aseries.SortPoints = true;
                    aseries.Style.DisplayText = true;
                    aseries.Style.TextFormat = "${0:N}";
                    aseries.Style.TextOffset = 15.0F;
                    aseries.Style.TextOrientation = ChartTextOrientation.Up;
                    bseries.SmartLabels = true;
                    bseries.SortPoints = true;
                    bseries.Style.DisplayText = true;
                    bseries.Style.TextFormat = "${0:N}";
                    bseries.Style.TextOffset = 15.0F;
                    bseries.Style.TextOrientation = ChartTextOrientation.Up;
                    return chart;
                }

                #endregion

                #endregion
            }
        }
    }
}