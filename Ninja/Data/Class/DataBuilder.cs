#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class DataBuilder : IDataBuilder
            {
                #region Properties

                public Query Query { get; }
                public BindingSource BindingSource { get; set; }
                Dictionary<string, object> Parameter { get; set; }
                public DataSet E6 { get; }
                public DataTable Table { get; }
                public DataRow[] Records { get; }
                public PRC[] Accounts { get; }
                public decimal Total { get; }
                public int Count { get; }
                public Tuple<DataTable, DataRow[], decimal, int> SqlData { get; }
                public Tuple<DataSet, DataRow[], decimal[]> QueryData { get; }
                public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }

                #endregion Properties

                #region Constructors

                public DataBuilder( )
                {
                }

                public DataBuilder(Source source)
                {
                    Query = new Query(source);
                    E6 = GetDataSet( );
                    Table = E6.Tables[0];
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Records = GetRecords( );
                    SqlData = GetSqlData( );
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(Table);
                        PrcData = GetPrcData( );
                    }
                }

                public DataBuilder(Source source, Dictionary<string, object> param)
                {
                    Query = new Query(source, param);
                    E6 = GetDataSet( );
                    Table = E6.Tables[0];
                    Total = GetTotal(Table);
                    Records = GetRecords( );
                    SqlData = GetSqlData( );
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(Table);
                        PrcData = GetPrcData( );
                    }
                }

                #endregion Constructors

                #region Methods

                public DataSet GetDataSet( )
                {
                    try
                    {
                        var dataSet = new DataSet("E6");
                        var dataTable = new DataTable(Query.TableName);
                        dataSet.Tables.Add(dataTable);
                        Query.Adapter.Fill(dataSet, Query.TableName);
                        return dataSet;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal DataTable GetDataTable(DataSet dataSet)
                {
                    try
                    {
                        return dataSet.Tables[0];
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }

                public DataRow[] GetRecords( )
                {
                    try
                    {
                        return Table.AsEnumerable( ).Select(p => p).ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Tuple<DataTable, DataRow[], decimal, int> GetSqlData( )
                {
                    var table = E6.Tables[Query.TableName];
                    var array = GetRecords( );
                    var total = GetTotal(table);
                    var count = GetCount(table);
                    return new Tuple<DataTable, DataRow[], decimal, int>(table, array, total, count);
                }

                private Tuple<DataTable, PRC[], decimal, int> GetPrcData( )
                {
                    var table = E6.Tables[Query.TableName];
                    var array = GetPrcArray(table);
                    var total = GetTotal(table);
                    var count = GetCount(table);
                    return new Tuple<DataTable, PRC[], decimal, int>(table, array, total, count);
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

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable( ).Select(p => p).Count( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
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
                        return -1;
                    }
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    try
                    {
                        return new decimal[] { GetTotal(table), (decimal)GetCount(table), GetAverage(table) };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return new decimal[] { -1m, -1m, -1m };
                    }
                }

                private PRC[] GetPrcArray(DataTable table)
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

                internal string[] A6Query( )
                {
                    try
                    {
                        DataSet E6 = new DataSet("E6");
                        DataTable A6 = new DataTable("A6");
                        Query.Adapter.Fill(E6, "A6");
                        E6.Tables.Add(A6);
                        var query = A6.AsEnumerable( ).Select(p => p.Field<string>("ProgramProjectCode"));
                        return query.ToArray( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion Methods
            }
        }
    }
}