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
                    Metrics = GetMetrics(Table);
                    FundTotals = GetTotals(Table, PrcFilter.FundName);
                    FundMetrics = GetMetrics(Table, PrcFilter.FundName);
                    BocTotals = GetTotals(Table, PrcFilter.FundName);
                    BocMetrics = GetMetrics(Table, PrcFilter.FundName);
                    NpmTotals = GetTotals(Table, PrcFilter.FundName);
                    NpmMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramProjectTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramProjectMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramAreaTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramAreaMetrics = GetMetrics(Table, PrcFilter.FundName);
                    GoalTotals = GetTotals(Table, PrcFilter.FundName);
                    GoalMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ObjectiveTotals = GetTotals(Table, PrcFilter.FundName);
                    ObjectiveMetrics = GetMetrics(Table, PrcFilter.FundName);
                    if (source == Source.P8)
                    {
                        DivisionTotals = GetTotals(Table, PrcFilter.RC);
                        DivisionMetrics = GetMetrics(Table, PrcFilter.RC);
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
                    Metrics = GetMetrics(Table);
                    FundTotals = GetTotals(Table, PrcFilter.FundName);
                    FundMetrics = GetMetrics(Table, PrcFilter.FundName);
                    BocTotals = GetTotals(Table, PrcFilter.BocName);
                    BocMetrics = GetMetrics(Table, PrcFilter.FundName);
                    NpmTotals = GetTotals(Table, PrcFilter.FundName);
                    NpmMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramProjectTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramProjectMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramAreaTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramAreaMetrics = GetMetrics(Table, PrcFilter.FundName);
                    GoalTotals = GetTotals(Table, PrcFilter.FundName);
                    GoalMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ObjectiveTotals = GetTotals(Table, PrcFilter.FundName);
                    ObjectiveMetrics = GetMetrics(Table, PrcFilter.FundName);
                }

                public DataMetric(DataBuilder data, PrcFilter prcfilter, string filter)
                {
                    Data = data;
                    Table = FilterTable(Data.BudgetTable, prcfilter, filter);
                    BudgetData = Data.BudgetData;
                    ProgramElements = GetProgramElements(Table);
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetMetrics(Table);
                    FundTotals = GetTotals(Table, PrcFilter.FundName);
                    FundMetrics = GetMetrics(Table, PrcFilter.FundName);
                    BocTotals = GetTotals(Table, PrcFilter.FundName);
                    BocMetrics = GetMetrics(Table, PrcFilter.FundName);
                    NpmTotals = GetTotals(Table, PrcFilter.FundName);
                    NpmMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramProjectTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramProjectMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ProgramAreaTotals = GetTotals(Table, PrcFilter.FundName);
                    ProgramAreaMetrics = GetMetrics(Table, PrcFilter.FundName);
                    GoalTotals = GetTotals(Table, PrcFilter.FundName);
                    GoalMetrics = GetMetrics(Table, PrcFilter.FundName);
                    ObjectiveTotals = GetTotals(Table, PrcFilter.FundName);
                    ObjectiveMetrics = GetMetrics(Table, PrcFilter.FundName);
                }

                //Properties
                public DataBuilder Data { get; }
                public DataSet BudgetData { get; }
                public DataTable Table { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public decimal Total { get; }
                public int Count { get; }
                public decimal Average { get; set; }
                public double[] Metrics { get; }
                public BindingList<IEnumerable<KeyValuePair<string, double>>> BudgetBinding { get; set; }
                public Dictionary<string, double[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> BocTotals { get; set; }
                public Dictionary<string, double[]> FundMetrics { get; set; }
                public Dictionary<string, decimal> FundTotals { get; set; }
                public Dictionary<string, double[]> GoalMetrics { get; set; }
                public Dictionary<string, decimal> GoalTotals { get; set; }
                public Dictionary<string, double[]> NpmMetrics { get; set; }
                public Dictionary<string, decimal> NpmTotals { get; set; }
                public Dictionary<string, double[]> ObjectiveMetrics { get; set; }
                public Dictionary<string, decimal> ObjectiveTotals { get; set; }
                public Dictionary<string, double[]> ProgramAreaMetrics { get; set; }
                public Dictionary<string, decimal> ProgramAreaTotals { get; set; }
                public Dictionary<string, double[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }
                public Dictionary<string, double[]> DivisionMetrics { get; set; }
                public Dictionary<string, decimal> DivisionTotals { get; set; }

                //Methods
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
                        return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p=>p).Count();
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

                public double[] GetMetrics(DataTable table)
                {
                    return new double[] { (double)GetTotal(table), (double)GetCount(table), (double)GetAverage(table), (double)GetTotal(table)/(double)Data.Total };
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

                public DataTable FilterTable(DataTable table, PrcFilter prcfilter, string filter)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                            .Select(p => p).CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
                {
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetTotal(table), GetCount(table));
                }

                Dictionary<string, decimal>[] GetTotals()
                {
                    return new Dictionary<string, decimal>[] {FundTotals, BocTotals, NpmTotals, GoalTotals,
                    ObjectiveTotals, ProgramAreaTotals, ProgramProjectTotals};
                }

                Dictionary<string, double[]> GetMetrics(DataTable table, PrcFilter prcfilter)
                {
                    try
                    {
                        Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = FilterTable(table, prcfilter, filter);
                            if(GetTotal(query) > 0)
                            {
                                info.Add(filter, GetMetrics(query));
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetTotals(DataTable table, PrcFilter prcfilter)
                {
                    try
                    {
                        var info = new Dictionary<string, decimal>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                            if(GetTotal(query)> 0 )
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

                internal Dictionary<string, double> GetChartTotals(DataTable table, PrcFilter prcfilter)
                {

                    try
                    {
                        var doubledata = new Dictionary<string, double>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                                .Select(p => p).CopyToDataTable();
                            if(GetTotal(query) > 0)
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

                internal Dictionary<string, double[]> GetChartMetrics(DataTable table, PrcFilter prcfilter)
                {
                    try
                    {
                        Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = FilterTable(table, prcfilter, filter);
                            if (GetTotal(query) > 0)
                            {
                                info.Add(filter, GetMetrics(query));
                            }
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