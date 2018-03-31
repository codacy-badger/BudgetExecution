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
            public class DivisionAuthority : IBudgetAuthority
            {
                #region Properties

                public static string FiscalYear { get; set; } = "2018";
                public Org Org { get; }
                public RC RC { get; }
                public DataBuilder Data { get; set; }
                public Tuple<DataTable, PRC[], decimal, int> Allocation { get; }
                public DataSet E6 { get; }
                public DataTable Table { get; }
                public BindingSource BindingSource { get; set; }
                public decimal Total { get; }
                public int Count { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> DivisionData { get; }
                public Dictionary<string, decimal> FteInfo { get; }
                public Dictionary<string, decimal> FundData { get; }
                public Dictionary<string, decimal> BocData { get; set; }
                public Dictionary<string, decimal> NpmData { get; }
                public Dictionary<string, decimal> GoalData { get; }
                public Dictionary<string, decimal> ProgramData { get; }
                public Dictionary<string, decimal> ProjectData { get; }
                public Appropriation[] Appropriations { get; }

                #endregion Properties

                #region Constructors

                public DivisionAuthority( )
                {
                    Data = new DataBuilder(Source.P8);
                    Allocation = Data.PrcData;
                    Table = Allocation.Item1;
                    Total = Allocation.Item3;
                    Count = Allocation.Item4;
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = Table;
                    DataElement = GetDataElements(Data.Table);
                    Appropriations = GetAllocation( );
                    DivisionData = GetRcInfo(Data.Table);
                    FundData = GetTotals(Data.Table, DataElement["Fund"], "Fund");
                    BocData = GetTotals(Data.Table, DataElement["BocName"], "BocName");
                    NpmData = GetTotals(Data.Table, DataElement["NPM"], "NPM");
                    GoalData = GetTotals(Data.Table, DataElement["GoalName"], "GoalName");
                    ProgramData = GetTotals(Data.Table, DataElement["ProgramArea"], "ProgramArea");
                    ProjectData = GetTotals(Data.Table, DataElement["ProgramProjectName"], "ProgramProjectName");
                    if (DataElement["BOC"].Contains("17"))
                    {
                        FTE = new FTE(Data.Table);
                        FteInfo = FTE.FundData;
                    }
                }

                public DivisionAuthority(string rc)
                {
                    RC = new RC(rc);
                    Org = new Org(RC.Code);
                    Data = new DataBuilder(Source.P8, new Dictionary<string, object> { ["RC"] = rc });
                    Allocation = Data.PrcData;
                    Table = Allocation.Item1;
                    Total = Allocation.Item3;
                    Count = Allocation.Item4;
                    Average = GetAverage(Table);
                    DataElement = GetDataElements(Table);
                    Appropriations = GetAllocation( );
                    FundData = GetTotals(Table, DataElement["FundName"], "FundName");
                    BocData = GetTotals(Table, DataElement["BocName"], "BocName");
                    NpmData = GetTotals(Table, DataElement["NPM"], "NPM");
                    GoalData = GetTotals(Table, DataElement["GoalName"], "GoalName");
                    ProgramData = GetTotals(Table, DataElement["ProgramAreaName"], "ProgramAreaName");
                    ProjectData = GetTotals(Table, DataElement["ProgramProjectName"], "ProgramProjectName");
                    if (DataElement["BOC"].Contains("17"))
                    {
                        FTE = new FTE(Table);
                        FteInfo = FTE.FundData;
                    }
                }

                #endregion Constructors

                #region Methods

                internal decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }

                internal Dictionary<string, decimal> GetRcInfo(DataTable table)
                {
                    try
                    {
                        string[] rcs = Info.RcCodes;
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string n in rcs)
                            info.Add(Info.GetDivisionMailCode(n), new DivisionAuthority(n).Total);
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal Appropriation[] GetAllocation( )
                {
                    try
                    {
                        string[] funds = DataElement["Fund"];
                        Appropriation[] data = new Appropriation[funds.Length];
                        for (int i = 0; i < funds.Length; i++)
                        {
                            data[i] = new Appropriation(Data.Table, funds[i], FiscalYear);
                        }
                        return data;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal bool VerifyRow(DataTable table, Dictionary<string, object> p)
                {
                    try
                    {
                        int row = table.AsEnumerable( ).Where(r => r.Field<string>("BFY").Equals(p["BFY"].ToString( )))
                            .Where(r => r.Field<string>("Fund").Equals(p["Fund"].ToString( )))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"].ToString( )))
                            .Where(r => r.Field<string>("BOC").Equals(p["BOC"])).Select(r => r.Field<int>("Id")).Single( );
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

                internal int VerifyDataRow(DataTable table, Dictionary<string, object> p)
                {
                    try
                    {
                        var query = table.AsEnumerable( ).Where(r => r.Field<string>("BFY").Equals(p["BFY"]))
                            .Where(r => r.Field<string>("Fund").Equals(p["Fund"]))
                            .Where(r => r.Field<string>("Org").Equals(p["Org"]))
                            .Where(r => r.Field<string>("RC").Equals(p["RC"]))
                            .Where(r => r.Field<string>("Code").Equals(p["Code"]))
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
                        return table.AsEnumerable( ).Sum(p => p.Field<decimal>("Amount"));
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

                public string[] GetCodeElements(DataTable table, string column)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p.Field<string>(column)).Distinct( ).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>( );
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
                        return table.AsEnumerable( ).Select(p => new PRC( )).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
                {
                    try
                    {
                        var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                        return new Tuple<DataTable, PRC[], decimal, int>(query, GetPrcArray(query), GetTotal(query), GetCount(query));
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
                            var query = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
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

                public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string filter in filters)
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

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
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
                        string[] list = GetCodeElements(table, column);
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

                #region IAuthority Explicit Implementation

                DataSet IBudgetAuthority.E6 { get; }

                DataTable IBudgetAuthority.FilterTable(DataTable table, string column, string filter)
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

                #endregion

                #endregion Methods
            }
        }
    }
}