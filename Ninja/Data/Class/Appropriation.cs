#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Appropriation : IAuthority
            {
                #region Properties

                public Fund Fund { get; set; }
                public string Code { get; set; }
                public string FiscalYear { get; set; }
                public Bitmap Image { get; set; }
                public PRC[] Allocation { get; }
                public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public string[] BocCodes { get; }
                public string[] BOC { get; }
                public string[] Codes { get; }
                public string[] NPM { get; }
                public string[] Program { get; }
                public string[] Goal { get; }
                public int Count { get; }
                public decimal Total { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public DataTable FteData { get; set; }
                public decimal FTE { get; }
                public Dictionary<string, decimal> BocInfo { get; set; }
                public Dictionary<string, decimal> NpmInfo { get; set; }
                public Dictionary<string, decimal> FteInfo { get; set; }
                public Dictionary<string, decimal> ProgramInfo { get; set; }
                public Dictionary<string, decimal> GoalInfo { get; set; }

                #endregion

                #region Constructors

                public Appropriation( )
                {
                }

                public Appropriation(string fundcode, string bfy)
                {
                    Fund = new Fund(fundcode, bfy);
                    FiscalYear = Fund.FiscalYear;
                    Code = Fund.Code;
                }

                public Appropriation(DataTable table, string fundcode, string bfy) : this(fundcode, bfy)
                {
                    PrcData = GetDataValues(table, "Fund", Code);
                    Allocation = PrcData.Item2;
                    Total = GetTotal(PrcData.Item1);
                    Average = GetAverage(PrcData.Item1);
                    DataElement = GetDataElements(PrcData.Item1);
                    BocCodes = DataElement["BOC"];
                    BOC = DataElement["BocName"];
                    NPM = DataElement["NPM"];
                    Program = DataElement["ProgramAreaName"];
                    Goal = DataElement["GoalName"];
                    Count = PrcData.Item1.Rows.Count;
                    BocInfo = GetDataTotals(PrcData.Item1, BOC, "BocName");
                    if (BocCodes.Contains("17"))
                    {
                        FTE = GetTotal(PrcData.Item1, "BOC", "17");
                        FteData = GetTable(PrcData.Item1, "BOC", "17");
                        FteInfo = GetDataTotals(FteData, Program, "ProgramAreaName");
                    }
                    NpmInfo = GetDataTotals(PrcData.Item1, NPM, "NPM");
                    ProgramInfo = GetDataTotals(PrcData.Item1, Program, "ProgramAreaName");
                    GoalInfo = GetDataTotals(PrcData.Item1, Goal, "GoalName");
                    Image = GetImageFile( );
                }

                #endregion

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

                public string[] GetCodes(DataTable table, string column)
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
                        data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
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
                        var qtable = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
                            .Select(p => p).CopyToDataTable( );
                        return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string[] list, string column)
                {
                    foreach (string filter in list)
                    {
                        try
                        {
                            var qtable = table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable( );
                            return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                            return null;
                        }
                    }
                    return null;
                }

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodes(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string ftr in list)
                        {
                            var query = PrcData.Item1.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
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

                public Dictionary<string, decimal> GetDataTotals(DataTable table, string[] filters, string column)
                {
                    try
                    {
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string f in filters)
                        {
                            var total = GetTotal(table, column, f);
                            if (total > 0)
                                info.Add(f, total);
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
                        var list = GetCodes(table, column);
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

                internal Bitmap GetImageFile( )
                {
                    DirectoryInfo imgfolder = new DirectoryInfo(@"C:\Users\terry\Documents\Visual Studio 2015\Projects\Budget\Resources\fundlabel");
                    var files = imgfolder.GetFiles("*.png");
                    foreach (var f in files)
                    {
                        string imgname = Path.GetFileNameWithoutExtension(f.FullName);
                        if (imgname.Equals(Fund.Code))
                            return new Bitmap(f.FullName);
                    }
                    return null;
                }

                #region Private Methods

                private DataTable GetTable(DataTable table, string fund)
                {
                    try
                    {
                        return table.AsEnumerable( ).Where(p => p.Field<string>("Fund").Equals(fund)).Select(p => p).CopyToDataTable( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                private DataTable GetTable(DataTable table, string column, string filter)
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

                private decimal GetTotal(DataTable table, string column, string filter)
                {
                    return table.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                }

                private decimal GetRatio(decimal t1, decimal t2)
                {
                    return t1 / t2;
                }

                #endregion Private Methods

                #region IAuthority Explicit Implementation

                DataSet IAuthority.E6 { get; }

                DataTable IAuthority.FilterTable(DataTable table, string column, string filter)
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

                #endregion
            }
        }
    }
}