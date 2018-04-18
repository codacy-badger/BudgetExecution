using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class FTE : IPRC
            {
                public FTE()
                {
                }

                public FTE(DataTable table)
                {
                    E6 = table.DataSet;
                    Table = GetDataValues(table, "BOC", "17").Item1;
                    DataElement = GetDataElements(Table);
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Data = GetPrcArray(Table);
                    AllocationData = new Tuple<DataTable, PRC[], decimal, int>(Table, Data, Total, Count);
                    NpmData = GetTotals(Table, DataElement["NPM"], "NPM");
                    GoalInfo = GetTotals(Table, DataElement["GoalName"], "GoalName");
                    ObjectiveData = GetTotals(Table, DataElement["Objective"], "Objective");
                    ProgramData = GetTotals(Table, DataElement["ProgramAreaName"], "ProgramAreaName");
                    ProjectData = GetTotals(Table, DataElement["ProgramProjectName"], "ProgramProjectName");
                }

                //Properties
                public Account Account { get; }

                public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }
                public decimal Amount { get; set; }
                public decimal Authority { get; set; }
                public decimal Average { get; }
                public string BFY { get; set; }
                public string Code { get; }
                public int Count { get; }
                public PRC[] Data { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public DataSet E6 { get; }
                public Fund Fund { get; set; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> GoalInfo { get; }
                public Dictionary<string, decimal> NpmData { get; }
                public Dictionary<string, decimal> ObjectiveData { get; }
                public Org Org { get; set; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, decimal> ProjectData { get; }
                public RC RC { get; set; }
                public string RPIO { get; set; }
                public DataTable Table { get; }
                public decimal Total { get; }
                BOC IPRC.BOC { get; }
                private decimal[] Metrics { get; }

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

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
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

                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
                {
                    try
                    {
                        var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                        return new Tuple<DataTable, PRC[], decimal, int>(query, GetPrcArray(query), GetTotal(query), GetCount(query));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    var count = GetCount(table);
                    return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
                }

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column, string filter)
                {
                    try
                    {
                        string[] list = GetCodes(table, column);
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
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

                public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
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
            }
        }
    }
}