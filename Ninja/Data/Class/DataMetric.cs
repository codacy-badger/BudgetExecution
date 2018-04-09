using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class DataMetric 
            {

                //Constructors
                public DataMetric()
                {
                }

                public DataMetric(Source source)
                {
                    Data = new DataBuilder(source);
                    Table = Data.BudgetTable;
                    BudgetData = Data.BudgetData;
                    ProgramElements = Data.GetElements(Table);
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetStats(Table);
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
                    if(source == Source.P8)
                    {
                        DivisionTotals = GetTotals(Table, "RC");
                        DivisionMetrics = GetMetrics(Table, "RC");
                    }
                }

                public DataMetric(DataBuilder data)
                {
                    Data = data;
                    Table = Data.BudgetTable;
                    BudgetData = Table.DataSet;
                    ProgramElements = Data.GetElements(Table);
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetStats(Table);
                    FundTotals = GetTotals(Table, "FundName");
                    FundMetrics = GetMetrics(Table, "FundName");
                    BocTotals = GetTotals(Table, "BocName");
                    BocMetrics = GetMetrics(Table, "BocName");
                    NpmTotals = GetTotals(Table, "NPM");
                    NpmMetrics = GetMetrics(Table, "NPM");
                    ProgramProjectTotals = GetTotals(Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Table, "ProgramArea");
                    ProgramAreaMetrics = GetMetrics(Table, "ProgramArea");
                    GoalTotals = GetTotals(Table, "GoalName");
                    GoalMetrics = GetMetrics(Table, "GoalName");
                    ObjectiveTotals = GetTotals(Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Table, "ObjectiveName");
                }

                public DataMetric(DataBuilder data, string column, string filter)
                {
                    Data = data;
                    Table = FilterTable(Data.BudgetTable, column, filter);
                    BudgetData = Data.BudgetData;
                    ProgramElements = Data.GetElements(Table);
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetStats(Table);
                    FundTotals = GetTotals(Table, "FundName");
                    FundMetrics = GetMetrics(Table, "FundName");
                    BocTotals = GetTotals(Table, "BocName");
                    BocMetrics = GetMetrics(Table, "BocName");
                    NpmTotals = GetTotals(Table, "NPM");
                    NpmMetrics = GetMetrics(Table, "NPM");
                    ProgramProjectTotals = GetTotals(Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Table, "ProgramArea");
                    ProgramAreaMetrics = GetMetrics(Table, "ProgramArea");
                    GoalTotals = GetTotals(Table, "GoalName");
                    GoalMetrics = GetMetrics(Table, "GoalName");
                    ObjectiveTotals = GetTotals(Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Table, "ObjectiveName");
                }



                //Properties
                public DataBuilder Data { get; }
                public DataSet BudgetData { get; }
                public DataTable Table { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; set; }
                public decimal Total { get; }
                public int Count { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public BindingList<IEnumerable<KeyValuePair<string, double>>> BudgetBinding { get; }
                public Dictionary<string, decimal[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> BocTotals { get; set; }
                public Dictionary<string, decimal[]> FundMetrics { get; }
                public Dictionary<string, decimal> FundTotals { get; set; }
                public Dictionary<string, decimal[]> GoalMetrics { get; set; }
                public Dictionary<string, decimal> GoalTotals { get; set; }
                public Dictionary<string, decimal[]> NpmMetrics { get; set; }
                public Dictionary<string, decimal> NpmTotals { get; set; }
                public Dictionary<string, decimal[]> ObjectiveMetrics { get; set; }
                public Dictionary<string, decimal> ObjectiveTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramAreaMetrics { get; set; }
                public Dictionary<string, decimal> ProgramAreaTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }
                public Dictionary<string, decimal[]> DivisionMetrics { get; set; }
                public Dictionary<string, decimal> DivisionTotals { get; set; }


                //Methods
                
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

                public decimal[] GetStats(DataTable table)
                {
                    var count = GetCount(table);
                    return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
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

                public DataTable FilterTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                            .Select(p => p).CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                private Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
                {
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetTotal(table), GetCount(table));
                }

                private Dictionary<string, decimal>[] GetTotalsArray()
                {
                    return new Dictionary<string, decimal>[] {FundTotals, BocTotals, NpmTotals, GoalTotals,
                        ObjectiveTotals, ProgramAreaTotals, ProgramProjectTotals};
                }

                private Dictionary<string, decimal[]> GetMetrics(DataTable table, string column)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        foreach (string filter in GetCodes(table, column))
                        {
                            var query = FilterTable(table, column, filter);
                            decimal[] stat = new decimal[4];
                            stat[0] = GetTotal(query);
                            stat[1] = (decimal)GetCount(query);
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / Total) * 100;
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

                public Dictionary<string, decimal> GetTotals(DataTable table, string column)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        var info = new Dictionary<string, decimal>();
                        foreach (string filter in list)
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                .Select(p => p).CopyToDataTable();
                            info.Add(filter, GetTotal(query));
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                internal Dictionary<string, double> GetChartTotals(DataTable table, string column)
                {

                    try
                    {;
                        var doubledata = new Dictionary<string, double>();
                        foreach (string filter in ProgramElements[column])
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                .Select(p => p).CopyToDataTable();
                            doubledata.Add(filter, (double)GetTotal(query));
                        }
                        return doubledata;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }

                }

                internal Dictionary<string, double[]> GetChartMetrics(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                        foreach (string filter in ProgramElements[column])
                        {
                            var query = FilterTable(table, column, filter);
                            double[] stat = new double[4];
                            stat[0] = (double)Data.GetTotal(query);
                            stat[1] = (double)Data.GetCount(query);
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / (double)Total) * 100;
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


            }
        }
    }
}