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
                    ProgramElements = Data.GetProgramElements(BaseTable);
                    BaseSet = Data.QuerySet;
                    BaseTotal = GetBaseMetrics(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, AccountField.FundName);
                    FundMetrics = GetMetrics(BaseTable, AccountField.FundName);
                    BocTotals = GetTotals(BaseTable, AccountField.BocName);
                    BocMetrics = GetMetrics(BaseTable, AccountField.BocName);
                    NpmTotals = GetTotals(BaseTable, AccountField.NPM);
                    NpmMetrics = GetMetrics(BaseTable, AccountField.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, AccountField.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, AccountField.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, AccountField.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, AccountField.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, AccountField.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, AccountField.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, AccountField.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, AccountField.ObjectiveName);
                    if (source == Source.P8 && Data.Parameter == null)
                    {
                        DivisionTotals = GetTotals(BaseTable, AccountField.Division);
                        DivisionMetrics = GetMetrics(BaseTable, AccountField.Division);
                    }
                    if(source == Source.P6)
                    {
                        var table = new DivisionAuthority().Table;
                        DivisionTotals = GetTotals(table, AccountField.Division);
                        DivisionMetrics = GetMetrics(table, AccountField.Division);
                    }
                }
                public DataMetric(DataBuilder data)
                {
                    Data = data;
                    BaseTable = Data.QueryTable;
                    ProgramElements = Data.GetProgramElements(BaseTable);
                    BaseSet = BaseTable.DataSet;
                    BaseTotal = GetBaseMetrics(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, AccountField.FundName);
                    FundMetrics = GetMetrics(BaseTable, AccountField.FundName);
                    BocTotals = GetTotals(BaseTable, AccountField.BocName);
                    BocMetrics = GetMetrics(BaseTable, AccountField.BocName);
                    NpmTotals = GetTotals(BaseTable, AccountField.NPM);
                    NpmMetrics = GetMetrics(BaseTable, AccountField.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, AccountField.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, AccountField.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, AccountField.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, AccountField.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, AccountField.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, AccountField.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, AccountField.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, AccountField.ObjectiveName);
                    if (Data.Source == Source.P8 && Data.Parameter == null)
                    {
                        DivisionTotals = GetTotals(BaseTable, AccountField.Division);
                        DivisionMetrics = GetMetrics(BaseTable, AccountField.Division);
                    }
                    if (Data.Source == Source.P6)
                    {
                        var table = new DivisionAuthority().Table;
                        DivisionTotals = GetTotals(table, AccountField.Division);
                        DivisionMetrics = GetMetrics(table, AccountField.Division);
                    }
                }
                public DataMetric(DataBuilder data, AccountField prcfilter, string filter)
                {
                    Data = data;
                    BaseTable = FilterTable(Data.QueryTable, prcfilter, filter);
                    ProgramElements = GetProgramElements(BaseTable);
                    BaseSet = Data.QuerySet;
                    BaseTotal = GetBaseMetrics(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, AccountField.FundName);
                    FundMetrics = GetMetrics(BaseTable, AccountField.FundName);
                    BocTotals = GetTotals(BaseTable, AccountField.BocName);
                    BocMetrics = GetMetrics(BaseTable, AccountField.BocName);
                    NpmTotals = GetTotals(BaseTable, AccountField.NPM);
                    NpmMetrics = GetMetrics(BaseTable, AccountField.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, AccountField.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, AccountField.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, AccountField.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, AccountField.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, AccountField.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, AccountField.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, AccountField.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, AccountField.ObjectiveName);
                    if (Data.Source == Source.P8 && Data.Parameter == null)
                    {
                        DivisionTotals = GetTotals(BaseTable, AccountField.Division);
                        DivisionMetrics = GetMetrics(BaseTable, AccountField.Division);
                    }
                    if (Data.Source == Source.P6)
                    {
                        var table = new DivisionAuthority().Table;
                        DivisionTotals = GetTotals(table, AccountField.Division);
                        DivisionMetrics = GetMetrics(table, AccountField.Division);
                    }
                }
                public DataMetric(DataTable table, AccountField prcfilter, string filter)
                {
                    BaseTable = FilterTable(table, prcfilter, filter);
                    BaseSet = table.DataSet;
                    ProgramElements = GetProgramElements(BaseTable);
                    BaseTotal = GetBaseMetrics(BaseTable);
                    BaseCount = BaseTable.Rows.Count;
                    BaseAverage = GetBaseAverage(BaseTable);
                    BaseMetrics = GetMetrics(BaseTable);
                    FundTotals = GetTotals(BaseTable, AccountField.FundName);
                    FundMetrics = GetMetrics(BaseTable, AccountField.FundName);
                    BocTotals = GetTotals(BaseTable, AccountField.BocName);
                    BocMetrics = GetMetrics(BaseTable, AccountField.BocName);
                    NpmTotals = GetTotals(BaseTable, AccountField.NPM);
                    NpmMetrics = GetMetrics(BaseTable, AccountField.NPM);
                    ProgramProjectTotals = GetTotals(BaseTable, AccountField.ProgramProjectCode);
                    ProgramProjectMetrics = GetMetrics(BaseTable, AccountField.ProgramProjectCode);
                    ProgramAreaTotals = GetTotals(BaseTable, AccountField.ProgramArea);
                    ProgramAreaMetrics = GetMetrics(BaseTable, AccountField.ProgramArea);
                    GoalTotals = GetTotals(BaseTable, AccountField.GoalName);
                    GoalMetrics = GetMetrics(BaseTable, AccountField.GoalName);
                    ObjectiveTotals = GetTotals(BaseTable, AccountField.ObjectiveName);
                    ObjectiveMetrics = GetMetrics(BaseTable, AccountField.ObjectiveName);
                    DivisionTotals = GetTotals(table, AccountField.Division);
                    DivisionMetrics = GetMetrics(table, AccountField.Division);
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
                public DataTable FilterTable(DataTable table, AccountField prcfilter, string filter)
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
                public decimal GetBaseMetrics(DataTable table)
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
                    return new double[] { (double)GetBaseMetrics(table), (double)GetQueryCount(table), (double)GetBaseAverage(table), (double)GetBaseMetrics(table) / (double)Data.QueryTotal };
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
                public Dictionary<string, decimal> GetTotals(DataTable table, AccountField prcfilter)
                {
                    try
                    {
                        var info = new Dictionary<string, decimal>();
                        foreach (string filter in GetCodes(table, prcfilter.ToString()))
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                            if (GetBaseMetrics(query) > 0)
                                info.Add(filter, GetBaseMetrics(query));
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }
                internal Dictionary<string, double[]> GetChartMetrics(DataTable table, AccountField prcfilter)
                {
                    try
                    {
                        var info = new Dictionary<string, double[]>();
                        foreach (string filter in GetCodes(table, prcfilter.ToString()))
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                            if (GetBaseMetrics(query) > 0)
                                info.Add(filter, new double[] { (double)GetBaseMetrics(query) });
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }
                internal Dictionary<string, double> GetChartTotals(DataTable table, AccountField prcfilter)
                {
                    try
                    {
                        var doubledata = new Dictionary<string, double>();
                        foreach (string filter in GetCodes(table, prcfilter.ToString()))
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                                .Select(p => p).CopyToDataTable();
                            if (GetBaseMetrics(query) > 0)
                                doubledata.Add(filter, (double)GetBaseMetrics(query));
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
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetBaseMetrics(table), GetQueryCount(table));
                }
                private Dictionary<string, double[]> GetMetrics(DataTable table, AccountField prcfilter)
                {
                    try
                    {
                        var info = new Dictionary<string, double[]>();
                        foreach (string filter in GetCodes(table, prcfilter.ToString()))
                        {
                            var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                            if (GetBaseMetrics(query) > 0)
                                info.Add(filter, new double[] { (double)GetBaseMetrics(query) });
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