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
                    BaseTable = Data.QueryTable;
                    BaseSet = Data.QuerySet;
                    ProgramElements = Data.GetProgramElements(BaseTable);
                    BaseTotal = GetBaseTotal(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, PrcFilter.FundName);
                    FundMetrics = GetMetrics(BaseTable, PrcFilter.FundName);
                    BocTotals = GetTotals(BaseTable, PrcFilter.BocName);
                    BocMetrics = GetMetrics(BaseTable, PrcFilter.BocName);
                    NpmTotals = GetTotals(BaseTable, PrcFilter.NPM);
                    NpmMetrics = GetMetrics(BaseTable, PrcFilter.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, PrcFilter.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, PrcFilter.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, PrcFilter.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, PrcFilter.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, PrcFilter.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, PrcFilter.ObjectiveName);
                    if (source == Source.P8)
                    {
                        DivisionTotals = GetTotals(BaseTable, PrcFilter.RC);
                        DivisionMetrics = GetMetrics(BaseTable, PrcFilter.RC);
                    }
                }
                public DataMetric(DataBuilder data)
                {
                    Data = data;
                    BaseTable = Data.QueryTable;
                    BaseSet = BaseTable.DataSet;
                    ProgramElements = Data.GetProgramElements(BaseTable);
                    BaseTotal = GetBaseTotal(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, PrcFilter.FundName);
                    FundMetrics = GetMetrics(BaseTable, PrcFilter.FundName);
                    BocTotals = GetTotals(BaseTable, PrcFilter.BocName);
                    BocMetrics = GetMetrics(BaseTable, PrcFilter.BocName);
                    NpmTotals = GetTotals(BaseTable, PrcFilter.NPM);
                    NpmMetrics = GetMetrics(BaseTable, PrcFilter.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, PrcFilter.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, PrcFilter.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, PrcFilter.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, PrcFilter.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, PrcFilter.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, PrcFilter.ObjectiveName);
                }
                public DataMetric(DataBuilder data, PrcFilter prcfilter, string filter)
                {
                    Data = data;
                    BaseTable = FilterTable(Data.QueryTable, prcfilter, filter);
                    BaseSet = Data.QuerySet;
                    ProgramElements = GetProgramElements(BaseTable);
                    BaseTotal = GetBaseTotal(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, PrcFilter.FundName);
                    FundMetrics = GetMetrics(BaseTable, PrcFilter.FundName);
                    BocTotals = GetTotals(BaseTable, PrcFilter.BocName);
                    BocMetrics = GetMetrics(BaseTable, PrcFilter.BocName);
                    NpmTotals = GetTotals(BaseTable, PrcFilter.NPM);
                    NpmMetrics = GetMetrics(BaseTable, PrcFilter.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, PrcFilter.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, PrcFilter.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, PrcFilter.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, PrcFilter.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, PrcFilter.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, PrcFilter.ObjectiveName);
                }
                public DataMetric(DataTable table, PrcFilter prcfilter, string filter)
                {
                    BaseTable = FilterTable(table, prcfilter, filter);
                    BaseSet = table.DataSet;
                    ProgramElements = GetProgramElements(BaseTable);
                    BaseTotal = GetBaseTotal(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, PrcFilter.FundName);
                    FundMetrics = GetMetrics(BaseTable, PrcFilter.FundName);
                    BocTotals = GetTotals(BaseTable, PrcFilter.BocName);
                    BocMetrics = GetMetrics(BaseTable, PrcFilter.BocName);
                    NpmTotals = GetTotals(BaseTable, PrcFilter.NPM);
                    NpmMetrics = GetMetrics(BaseTable, PrcFilter.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, PrcFilter.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, PrcFilter.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, PrcFilter.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, PrcFilter.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, PrcFilter.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, PrcFilter.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, PrcFilter.ObjectiveName);
                }

                //Properties
                public decimal BaseAverage { get; set; }
                public int BaseCount { get; }
                public double[] BaseMetrics { get; }
                public DataSet BaseSet { get; }
                public DataTable BaseTable { get; set; }
                public decimal BaseTotal { get; }
                public Dictionary<string, double[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> BocTotals { get; }
                public DataBuilder Data { get; }
                public Dictionary<string, double[]> DivisionMetrics { get; set; }
                public Dictionary<string, decimal> DivisionTotals { get; set; }
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
                public Dictionary<string, string[]> ProgramElements { get; set; }
                public Dictionary<string, double[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }

                //Methods
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
                public decimal GetBaseAverage(DataTable table)
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
                public decimal GetBaseTotal(DataTable table)
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
                public double[] GetMetrics(DataTable table)
                {
                    return new double[] { (double)GetBaseTotal(table), (double)GetQueryCount(table), (double)GetBaseAverage(table), (double)GetBaseTotal(table) / (double)Data.QueryTotal };
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
                public int GetQueryCount(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
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
                            if (GetBaseTotal(query) > 0)
                                info.Add(filter, GetBaseTotal(query));
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                            if (GetBaseTotal(query) > 0)
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
                internal Dictionary<string, double> GetChartTotals(DataTable table, PrcFilter prcfilter)
                {
                    try
                    {
                        var doubledata = new Dictionary<string, double>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                                .Select(p => p).CopyToDataTable();
                            if (GetBaseTotal(query) > 0)
                                doubledata.Add(filter, (double)GetBaseTotal(query));
                        }
                        return doubledata;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }
                private Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
                {
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetBaseTotal(table), GetQueryCount(table));
                }
                private Dictionary<string, double[]> GetMetrics(DataTable table, PrcFilter prcfilter)
                {
                    try
                    {
                        Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                        foreach (string filter in ProgramElements[prcfilter.ToString()])
                        {
                            var query = FilterTable(table, prcfilter, filter);
                            if (GetBaseTotal(query) > 0)
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
                private Dictionary<string, decimal>[] GetTotals()
                {
                    return new Dictionary<string, decimal>[] {FundTotals, BocTotals, NpmTotals, GoalTotals,
                    ObjectiveTotals, ProgramAreaTotals, ProgramProjectTotals};
                }
            }
        }
    }
}