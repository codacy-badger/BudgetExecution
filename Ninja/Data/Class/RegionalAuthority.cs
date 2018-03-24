#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class RegionalAuthority : IAuthority
            {
                #region Properties

                public static string FiscalYear { get; set; } = "2018";
                public DataBuilder Data { get; set; }
                public DataSet E6 { get; }
                public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public PRC[] Allocation { get; }
                public decimal Total { get; }
                public int Count { get; }
                public decimal Average { get; }
                public decimal[] FundMetrics { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> FteInfo { get; }
                public Dictionary<string, decimal> BocData { get; }
                public Dictionary<string, decimal> NpmData { get; }
                public Dictionary<string, decimal> GoalInfo { get; }
                public Dictionary<string, decimal> ObjectiveData { get; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, decimal> ProjectData { get; }
                public Appropriation[] Appropriation { get; }

                #endregion Properties

                #region Constructors

                public RegionalAuthority( )
                {
                    Data = new DataBuilder(Source.P7, new Dictionary<string, object> { ["BFY"] = FiscalYear });
                    E6 = Data.Data;
                    Allocation = Data.Accounts;
                    Total = Data.Total;
                    Count = Data.Table.Rows.Count;
                    Average = GetAverage(Data.Table);
                    DataElement = GetDataElement( );
                    Appropriation = GetAllocation( );
                    FTE = GetFTE(Data.Table);
                    FundData = GetDataTotals(Data.Table, DataElement["Fund"], "Fund");
                    FteInfo = GetDataTotals(FTE.Data, DataElement["Fund"], "Fund");
                    BocData = GetDataTotals(Data.Table, DataElement["BocName"], "BocName");
                    NpmData = GetDataTotals(Data.Table, DataElement["NPM"], "NPM");
                    GoalInfo = GetDataTotals(Data.Table, DataElement["GoalName"], "GoalName");
                    ObjectiveData = GetDataTotals(Data.Table, DataElement["Objective"], "Objective");
                    ProgramData = GetDataTotals(Data.Table, DataElement["ProgramAreaName"], "ProgramAreaName");
                    ProjectData = GetDataTotals(Data.Table, DataElement["ProgramProjectName"], "ProgramProjectName");
                }

                #endregion Constructors

                #region Methods

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
                    }
                }

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Where(p =>p.Field<string>("BOC") != "17").Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public decimal GetAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<decimal>("Amount")).Average( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    var count = GetCount(table);
                    return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
                }

                internal decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }

                public string[] GetCodes(string filter)
                {
                    try
                    {
                        return Data.Table.AsEnumerable( ).Select(p => p.Field<string>(filter)).Distinct( ).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public string[] GetCodeElements(DataTable table, string column)
                {
                    try
                    {
                        var list = table.AsEnumerable( ).Select(p => p.Field<string>(column)).ToArray( );
                        return list.Select(p => p).Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                FTE GetFTE(DataTable table)
                {
                    string[] code = GetCodeElements(table, "BOC");
                    if(code.Contains("17"))
                        return new FTE(table);
                    return null;
                }

                internal Dictionary<string, string[]> GetDataElement( )
                {
                    var data = new Dictionary<string, string[]>( );
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

                public Dictionary<string, string[]> GetDataElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>( );
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

                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
                {
                    try
                    {
                        var qtable = FilterTable(table, column, filter);
                        return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodeElements(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string ftr in list)
                        {
                            var query = AllocationData.Item1.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
                                .Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string filter in list)
                        {
                            var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
                                .Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                            if (query > 0)
                                info.Add(filter, query);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string[] list, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>( );
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
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodeElements(table, column);
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>( );
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
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal Dictionary<string, object> GetSupplemental(int time, decimal awards, decimal ot, PRC training)
                {
                    try
                    {
                        Dictionary<string, object> allocation = new Dictionary<string, object>( );
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

                internal int VerifyDataRow(DataTable table, Dictionary<string, object> p)
                {
                    try
                    {
                        var query = table.AsEnumerable( ).Where(r => r.Field<string>("BFY").Equals(p["BFY"]))
                            .Where(r => r.Field<string>("Fund").Equals(p["Fund"]))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"]))
                            .Where(r => r.Field<string>("Org").Equals(p["Org"]))
                            .Where(r => r.Field<string>("BOC").Equals(p["BOC"]))
                            .Select(r => r).CopyToDataTable( );
                        DataRow row = query.Rows[0];
                        return (int)row["Id"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                        return -1;
                    }
                }

                #region Private Methods

                internal DataTable GetFteTable( )
                {
                    try
                    {
                        return Data.Table.AsEnumerable( ).Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal PRC[] GetPrcArray(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal Appropriation[] GetAllocation( )
                {
                    var fund = DataElement["Fund"];
                    var data = new Appropriation[fund.Length];
                    for (int i = 0; i < fund.Length; i++)
                    {
                        data[i] = new Appropriation(Data.Table, fund[i], FiscalYear);
                    }
                    return data;
                }

                #endregion

                #region IAuthority Explicit Implementation

                DataSet IAuthority.E6 { get; }

                public DataTable FilterTable(DataTable table, string column, string filter)
                {
                    try
                    {
                        return table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                PRC[] IAuthority.GetPrcArray(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion

                #endregion Methods
            }
        }
    }
}