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
            public class RegionalAuthority : IBudgetAuthority
            {

                //Constructors
                public RegionalAuthority()
                {
                    Data = new DataBuilder(Source.P7, new Dictionary<string, object> { ["BFY"] = FiscalYear });
                    BudgetMetric = new DataMetric(Data);
                    Table = Data.BudgetTable;
                    Total = BudgetMetric.Total;
                    Count = BudgetMetric.Count;
                    Average = BudgetMetric.Average;
                    ProgramElements = GetProgramElements(Table);
                    FundData = BudgetMetric.FundTotals;
                    BocData = BudgetMetric.BocTotals;
                    NpmData = BudgetMetric.NpmTotals;
                    GoalData = BudgetMetric.GoalTotals;
                    ProgramData = BudgetMetric.ProgramAreaTotals;
                    ProjectData = BudgetMetric.ProgramProjectTotals;
                    if (ProgramElements["BOC"].Contains("17"))
                    {
                        FTE = new FTE(Table);
                        FteData = FTE.FundData;
                    }
                }


                //Properties
                public static string FiscalYear { get; set; } = "2018";
                public DataBuilder Data { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DataMetric BudgetMetric { get; }
                public DataSet BudgetData { get; }
                public DataTable Table { get; }
                public decimal Total { get; }
                public int Count { get; }
                public decimal Average { get; }
                public Dictionary<string, decimal> BocData { get; }
                public decimal[] Metrics { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> FteData { get; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> GoalData { get; }
                public Dictionary<string, decimal> NpmData { get; }
                public Dictionary<string, decimal> ObjectiveData { get; }
                public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, decimal> ProjectData { get; }


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
                public string[] GetCodes(string filter)
                {
                    try
                    {
                        return Data.BudgetTable.AsEnumerable().Select(p => p.Field<string>(filter)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }
                public string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        var list = table.AsEnumerable().Select(p => p.Field<string>(column)).ToArray();
                        return list.Select(p => p).Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
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
                        return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
                    }
                }
                public Dictionary<string, string[]> GetProgramElements(DataTable table)
                {
                    try
                    {
                        var data = new Dictionary<string, string[]>();
                        foreach (DataColumn dc in table.Columns)
                        {
                            if (dc.ColumnName.Equals("Id") || dc.ColumnName.Equals("Amount"))
                                continue;
                            data.Add(dc.ColumnName, GetCodes(dc.ColumnName));
                        }
                        if (data.ContainsKey("Id")) data.Remove("Id");
                        if (data.ContainsKey("Amount")) data.Remove("Amount");
                        if (data.ContainsKey("P6_Id")) data.Remove("P6_Id");
                        return data;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
                {
                    try
                    {
                        var qtable = FilterTable(table, column, filter);
                        return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }
                public decimal[] GetMetrics(DataTable table)
                {
                    try
                    {
                        var count = GetCount(table);
                        return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return new decimal[] { -1m };
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
                        return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }
                internal decimal GetRatio(decimal t1, decimal t2)
                {
                    try
                    {
                        return t1 / t2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }
                internal Dictionary<string, object> GetSupplemental(int time, decimal awards, decimal ot, PRC training)
                {
                    try
                    {
                        Dictionary<string, object> allocation = new Dictionary<string, object>();
                        allocation.Add("TimeOff", time);
                        allocation.Add("Awards", awards);
                        allocation.Add("OverTime", ot);
                        allocation.Add("Training", training);
                        return allocation;
                    }
                    catch (System.Exception)
                    {
                        return null;
                    }
                }
                internal void UpdateAmount(DataRow row, decimal amount2)
                {
                    try
                    {
                        var parameter = new Dictionary<string, object>();
                        parameter.Add("Id", row["Id"]);
                        parameter.Add("Amount", amount2);
                        var query = new Query(Source.P7, parameter);
                        var update = query.UpdateCommand;
                        update.ExecuteNonQuery();
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                internal void UpdateAmount(Dictionary<string, object> p, decimal amount2)
                {
                    try
                    {
                        if (p.ContainsKey("Amount"))
                            p.Remove("Amount");
                        p.Add("Amount", amount2);
                        var query = new Query(Source.P7, p);
                        var update = query.UpdateCommand;
                        update.ExecuteNonQuery();
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                internal int VerifyDataRow(DataTable table, Dictionary<string, object> p)
                {
                    try
                    {
                        var query = table.AsEnumerable().Where(r => r.Field<string>("BFY").Equals(p["BFY"]))
                            .Where(r => r.Field<string>("Fund").Equals(p["Fund"]))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"]))
                            .Where(r => r.Field<string>("Org").Equals(p["Org"]))
                            .Where(r => r.Field<string>("BOC").Equals(p["BOC"]))
                            .Select(r => r).CopyToDataTable();
                        DataRow row = query.Rows[0];
                        return (int)row["Id"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                        return -1;
                    }
                }

            }
        }
    }
}