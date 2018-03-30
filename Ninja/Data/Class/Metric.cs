#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Metric : IMetric
            {
                #region Properties
                DataTable table;
                string[] fields { get; set; }
                public decimal Total { get; set; }
                public int Count { get; set; }
                public decimal Average { get; set; }
                public decimal Ratio { get; set; }
                public decimal[] Metrics { get; set; }
                public Dictionary<string, decimal> DataTotals { get; set; }
                public Dictionary<string, decimal[]> DataMetrics { get; set; }
                #endregion Properties

                #region Constructors
                public Metric()
                {
                }

                public Metric(DataTable table)
                {
                    this.table = table;
                    fields = table.GetFields();
                    Total = GetTotal(table);
                    Count = GetCount(table);
                    Average = GetAverage(table);
                    Metrics = GetMetrics(table);
                }
                #endregion

                #region Methods
                public decimal GetAverage(decimal total, decimal count)
                {
                    try
                    {
                        return total / count;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                        return -1m;
                    }
                }

                public decimal GetAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average(p => p);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!\n" + ex.TargetSite + ex.StackTrace);
                        return -1M;
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
                        MessageBox.Show("ERROR!\n" + ex.TargetSite + ex.StackTrace);
                        return -1M;
                    }
                }

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!\n" + ex.TargetSite + ex.StackTrace);
                        return -1;
                    }
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    try
                    {
                        decimal[] stat = new decimal[4];
                        stat[0] = GetTotal(table);
                        stat[1] = (decimal)GetCount(table);
                        stat[2] = GetAverage(table);
                        stat[3] = (stat[0] / Total) * 100;
                        return stat;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!\n" + ex.TargetSite + ex.StackTrace);
                        return new decimal[] { -1m, -1m, -1m, -1m };
                    }
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string filter in list)
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        foreach (string filter in list)
                        {
                            decimal[] stat = new decimal[4];
                            stat[0] = GetTotal(table);
                            stat[1] = (decimal)GetCount(table);
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / Total) * 100;
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
