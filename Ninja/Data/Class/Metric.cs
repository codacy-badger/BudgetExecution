#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Metric 
            {
                #region Properties
                public IBudgetAuthority Data { get; }
                public DataTable Table { get; set; }
                public DataSet E6 { get; }
                public int Count { get; }
                public decimal Total { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public Tuple<DataTable, PRC[], decimal, int> Allocation { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public Dictionary<string, decimal> FundTotals{ get; }
                public Dictionary<string, decimal[]> FundMetrics { get; }
                public Dictionary<string, decimal> BocTotals { get; set; }
                public Dictionary<string, decimal[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> NpmTotals { get; set; }
                public Dictionary<string, decimal[]> NpmMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramAreaTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramAreaMetrics { get; set; }
                public Dictionary<string, decimal> GoalTotals { get; set; }
                public Dictionary<string, decimal[]> GoalMetrics { get; set; }
                public Dictionary<string, decimal> ObjectiveTotals { get; set; }
                public Dictionary<string, decimal[]> ObjectiveMetrics { get; set; }
                #endregion Properties

                #region Constructors
                public Metric()
                {
                }

                public Metric(IBudgetAuthority data)
                {
                    Data = data;
                    Table = Data.Table;
                    E6 = Data.E6;
                    Allocation = Data.Allocation;
                    FundTotals = GetTotals(Data.Table, "FundName");
                    FundMetrics = GetMetrics(Data.Table, "FundName");
                    BocTotals = GetTotals(Data.Table, "BocName");
                    BocMetrics = GetMetrics(Data.Table, "BocName");
                    NpmTotals = GetTotals(Data.Table, "NPM");
                    NpmMetrics = GetMetrics(Data.Table, "NPM");
                    ProgramProjectTotals = GetTotals(Data.Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Data.Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Data.Table, "ProgramAreaCode");
                    ProgramAreaMetrics = GetMetrics(Data.Table, "ProgramAreaCode");
                    GoalTotals = GetTotals(Data.Table, "GoalName");
                    GoalMetrics = GetMetrics(Data.Table, "GoalName");
                    ObjectiveTotals = GetTotals(Data.Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Data.Table, "ObjectiveName");
                }

                public Metric(DataTable table)
                {
                    Table = table;
                    E6 = Table.DataSet;
                    Allocation = GetAllocation(Table);
                    FundTotals = GetTotals(Table, "FundName");
                    FundMetrics = GetMetrics(Table, "FundName");
                    BocTotals = GetTotals(Table, "BocName");
                    BocMetrics = GetMetrics(Table, "BocName");
                    NpmTotals = GetTotals(Table, "NPM");
                    NpmMetrics = GetMetrics(Table, "NPM");
                    ProgramProjectTotals = GetTotals(Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Table, "ProgramAreaCode");
                    ProgramAreaMetrics = GetMetrics(Table, "ProgramAreaCode");
                    GoalTotals = GetTotals(Table, "GoalName");
                    GoalMetrics = GetMetrics(Table, "GoalName");
                    ObjectiveTotals = GetTotals(Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Table, "ObjectiveName");
                }
                #endregion

                #region Methods

                Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
                {
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetTotal(table), GetCount(table));
                }

                Dictionary<string, decimal> GetTotals(DataTable table, string column)
                {
                    try
                    {
                        var info = new Dictionary<string, decimal>();
                        if (table.GetFields().Contains(column))
                        {
                            foreach(string filter in DataElement[column])
                            {
                                var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                    .Select(p => p.Field<decimal>("Amount")).Sum();
                                if (query > 0)
                                    info.Add(filter, query);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                Dictionary<string, decimal[]> GetMetrics(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        if(table.GetFields().Contains(column))
                        {
                            foreach (string filter in DataElement[column])
                            {
                                decimal[] stat = new decimal[4];
                                stat[0] = GetTotal(table);
                                stat[1] = (decimal)GetCount(table);
                                stat[2] = stat[0] / stat[1];
                                stat[3] = (stat[0] / Total) * 100;
                                info.Add(filter, stat);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
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
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
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
                        return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>();
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
                        return table.AsEnumerable().Select(p => new PRC()).ToArray();
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
