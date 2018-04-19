﻿using System;
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
            public class DivisionAuthority : IBudgetAuthority
            {
                //Constructors
                public DivisionAuthority()
                {
                    Data = new DataBuilder(Source.P8);
                    BudgetMetric = new DataMetric(Data);
                    Table = Data.QueryTable;
                    Total = BudgetMetric.BaseTotal;
                    Count = BudgetMetric.BaseCount;
                    Average = BudgetMetric.BaseAverage;
                    ProgramElements = GetProgramElements(Table);
                    FundData = BudgetMetric.FundTotals;
                    BocData = BudgetMetric.BocTotals;
                    NpmData = BudgetMetric.NpmTotals;
                    GoalData = BudgetMetric.GoalTotals;
                    ProgramData = BudgetMetric.ProgramAreaTotals;
                    ProjectData = BudgetMetric.ProgramProjectTotals;
                    if (ProgramElements["BOC"].Contains("17"))
                    {
                        FTE = new FTE(Data.QueryTable);
                        FteData = FTE.FundData;
                    }
                }

                public DivisionAuthority(string rc)
                {
                    RC = new RC(rc);
                    Org = new Org(RC.Code);
                    Data = new DataBuilder(Source.P8, new Dictionary<string, object> { ["RC"] = rc });
                    BudgetMetric = new DataMetric(Data);
                    Table = Data.QueryTable;
                    Total = BudgetMetric.BaseTotal;
                    Count = BudgetMetric.BaseCount;
                    Average = BudgetMetric.BaseAverage;
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
                public decimal Average { get; }
                public Dictionary<string, decimal> BocData { get; set; }
                public DataSet BudgetData { get; }
                public DataMetric BudgetMetric { get; }
                public int Count { get; }
                public DataBuilder Data { get; set; }
                public Dictionary<string, decimal> DivisionData { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> FteData { get; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> GoalData { get; }
                public decimal[] Metrics { get; }
                public Dictionary<string, decimal> NpmData { get; }
                public Org Org { get; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public Dictionary<string, decimal> ProjectData { get; }
                public RC RC { get; }
                public DataTable Table { get; }
                public decimal Total { get; }

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
                        return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
                    }
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
                    try
                    {
                        var count = GetCount(table);
                        return new decimal[] { GetTotal(table), (decimal)table.Rows.Count, GetAverage(table) };
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
                public Dictionary<string, string[]> GetProgramElements(DataTable table)
                {
                    try
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
                        return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }
                internal decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }
                internal Dictionary<string, decimal> GetRcInfo(DataTable table)
                {
                    try
                    {
                        string[] rcs = Info.RcCodes;
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string n in rcs)
                            info.Add(Info.GetDivisionMailCode(n), new DivisionAuthority(n).Total);
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                            .Where(r => r.Field<string>("Org").Equals(p["Org"]))
                            .Where(r => r.Field<string>("RC").Equals(p["RC"]))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"]))
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
                internal bool VerifyRow(DataTable table, Dictionary<string, object> p)
                {
                    try
                    {
                        int row = table.AsEnumerable().Where(r => r.Field<string>("BFY").Equals(p["BFY"].ToString()))
                            .Where(r => r.Field<string>("Fund").Equals(p["Fund"].ToString()))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"].ToString()))
                            .Where(r => r.Field<string>("BOC").Equals(p["BOC"])).Select(r => r.Field<int>("Id")).Single();
                        if (row < 0)
                            return false;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                        return false;
                    }
                }
            }
        }
    }
}