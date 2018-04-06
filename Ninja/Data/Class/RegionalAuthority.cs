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
                #region Properties

                public static string FiscalYear { get; set; } = "2018";
                public Appropriation[] Appropriation { get; }
                public decimal Average { get; }
                public BindingSource BindingSource { get; set; }
                public Dictionary<string, decimal> BocData { get; }
                public int Count { get; }
                public DataBuilder Data { get; set; }
                public Dictionary<string, string[]> DataElement { get; }
                public Metric DataMetric { get; set; }
                public DataSet E6 { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> FteInfo { get; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> GoalInfo { get; }
                public decimal[] Metrics { get; }
                public Dictionary<string, decimal> NpmData { get; }
                public Dictionary<string, decimal> ObjectiveData { get; }
                public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, decimal> ProjectData { get; }
                public DataTable Table { get; }
                public decimal Total { get; }

                #endregion Properties

                #region Constructors

                public RegionalAuthority()
                {
                    Data = new DataBuilder(Source.P7, new Dictionary<string, object> { ["BFY"] = FiscalYear });
                    E6 = Data.E6;
                    PrcData = Data.PrcData;
                    Table = PrcData.Item1;
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = Table;
                    Total = PrcData.Item3;
                    Count = PrcData.Item4;
                    Average = GetAverage(Table);
                    DataElement = GetDataElement();
                    Appropriation = GetAllocation();
                    FundData = GetTotals(Table, DataElement["Fund"], "Fund");
                    BocData = GetTotals(Table, DataElement["BocName"], "BocName");
                    NpmData = GetTotals(Table, DataElement["NPM"], "NPM");
                    GoalInfo = GetTotals(Table, DataElement["GoalName"], "GoalName");
                    ObjectiveData = GetTotals(Table, DataElement["Objective"], "Objective");
                    ProgramData = GetTotals(Table, DataElement["ProgramAreaName"], "ProgramAreaName");
                    ProjectData = GetTotals(Table, DataElement["ProgramProjectName"], "ProgramProjectName");
                    if (DataElement["BOC"].Contains("17"))
                    {
                        var fte = FilterTable(Table, "BOC", "17");
                        FteInfo = GetTotals(fte, DataElement["Fund"], "Fund");
                    }
                }

                #endregion Constructors

                #region Methods

                public DataTable FilterTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
                        return -1M;
                    }
                }

                public string[] GetCodes(string filter)
                {
                    try
                    {
                        return Data.Table.AsEnumerable().Select(p => p.Field<string>(filter)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
                        return -1;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
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

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        foreach (string ftr in list)
                        {
                            decimal[] stat = new decimal[4];
                            stat[0] = GetDataValues(table, column, filter).Item3;
                            stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / Total) * 100;
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                        foreach (string ftr in list)
                        {
                            var query = PrcData.Item1.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                .Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
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
                            stat[3] = (stat[0] / Total) * 100;
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
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
                        MessageBox.Show(ex.Message.ToString());
                        return -1M;
                    }
                }

                public Dictionary<string, decimal> GetTotals(DataTable table, string[] list, string column)
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
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                internal Appropriation[] GetAllocation()
                {
                    var fund = DataElement["Fund"];
                    var data = new Appropriation[fund.Length];
                    for (int i = 0; i < fund.Length; i++)
                    {
                        data[i] = new Appropriation(Data.Table, fund[i], FiscalYear);
                    }
                    return data;
                }

                internal Dictionary<string, string[]> GetDataElement()
                {
                    try
                    {
                        var data = new Dictionary<string, string[]>();
                        foreach (DataColumn dc in Data.Table.Columns)
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

                internal decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
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

                #endregion Methods
            }
        }
    }
}