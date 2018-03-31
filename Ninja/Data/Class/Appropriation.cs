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
            public class Appropriation : IBudgetAuthority
            {
                #region Properties

                public Fund Fund { get; set; }
                public string FiscalYear { get; set; }
                public Tuple<DataTable, PRC[], decimal, int> Allocation { get; }
                public DataTable Table { get; }
                public BindingSource BindingSource { get; set; }
                public Dictionary<string, string[]> DataElement { get; }
                public Tuple<string[], string[], string[], string[], string[]> Codes  { get; set; }
                public string[] BocCodes { get; }
                public string[] BOC { get; }
                public string[] NPM { get; }
                public string[] Program { get; }
                public string[] Project { get; }
                public string[] Goal { get; }
                public int Count { get; }
                public decimal Total { get; }
                public decimal Average { get; }
                public decimal[] Metrics { get; }
                public FTE FTE { get; }
                public Dictionary<string, decimal> BocData { get; set; }
                public Dictionary<string, decimal> NpmData { get; set; }
                public Dictionary<string, decimal> ProgramData { get; set; }
                public Dictionary<string, decimal> ProjectData { get; set; }
                public Dictionary<string, decimal> GoalData { get; set; }
                public Dictionary<string, decimal> ObjectiveData { get; set; }

                #endregion

                #region Constructors

                public Appropriation( )
                {
                }

                public Appropriation(string fundcode, string bfy)
                {
                    Fund = new Fund(fundcode, bfy);
                    FiscalYear = Fund.FiscalYear;
                }

                public Appropriation(DataTable table, string fundcode, string bfy) : this(fundcode, bfy)
                {
                    Allocation = GetDataValues(table, "Fund", Fund.Code);
                    Table = Allocation.Item1;
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = Table;
                    Total = GetTotal(Allocation.Item1);
                    Average = GetAverage(Allocation.Item1);
                    DataElement = GetDataElements(Allocation.Item1);
                    BocCodes = DataElement["BOC"];
                    BOC = DataElement["BocName"];
                    NPM = DataElement["NPM"];
                    Program = DataElement["ProgramAreaName"];
                    Goal = DataElement["GoalName"];
                    Count = Allocation.Item1.Rows.Count;
                    BocData = GetTotals(Allocation.Item1, BOC, "BocName");
                    if (BocCodes.Contains("17"))
                    {
                        FTE = new FTE(table);
                    }
                    NpmData = GetTotals(Allocation.Item1, NPM, "NPM");
                    ProgramData = GetTotals(Allocation.Item1, Program, "ProgramAreaName");
                    GoalData = GetTotals(Allocation.Item1, Goal, "GoalName");
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
                        return table.AsEnumerable( ).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1M;
                    }
                }

                public decimal GetFTE()
                {
                    return Allocation.Item1.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
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

                public Tuple<string[], string[], string[], string[], string[]> GetCodes()
                {
                    return new Tuple<string[], string[], string[], string[], string[]>(DataElement["BOC"],
                        DataElement["Code"], DataElement["NPM"], DataElement["ProgramArea"], DataElement["ProgramProjectCode"]);
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

                public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
                {
                    try
                    {
                        var list = GetCodeElements(table, column);
                        Dictionary<string, decimal> info = new Dictionary<string, decimal>( );
                        foreach (string ftr in list)
                        {
                            var query = Allocation.Item1.AsEnumerable( ).Where(p => p.Field<string>(column).Equals(filter))
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
                        foreach (string f in filters)
                        {
                            if (GetTotal(table) > 0)
                                info.Add(f, GetTotal(table));
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

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column, string filter)
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

                #endregion
            }
        }
    }
}