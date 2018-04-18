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
            public class DataBuilder : IDataBuilder
            {
                //Constructors
                public DataBuilder()
                {
                }

                public DataBuilder(Source source)
                {
                    Query = new Query(source);
                    QuerySet = GetQuerySet();
                    QueryTable = QuerySet.Tables[0];
                    QueryTotal = GetQueryTotal(QueryTable);
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = QueryTable;
                    ProgramElements = GetElements(QueryTable);
                    Records = GetRecords(QueryTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(QueryTable);
                    }
                }

                public DataBuilder(Source source, Dictionary<string, object> param)
                {
                    Query = new Query(source, param);
                    QuerySet = GetQuerySet();
                    QueryTable = QuerySet.Tables[0];
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = QueryTable;
                    ProgramElements = GetElements(QueryTable);
                    Records = GetRecords(QueryTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(QueryTable);
                    }
                }

                public PRC[] Accounts { get; }

                public BindingSource BindingSource { get; }

                public Dictionary<string, string[]> ProgramElements { get; }

                //Properties
                public Query Query { get; }

                public DataSet QuerySet { get; }
                public DataTable QueryTable { get; }
                public decimal QueryTotal { get; }
                public DataRow[] Records { get; }
                private Dictionary<string, object> Parameter { get; set; }

                //Methods
                public static DataTable FilterTable(DataTable table, PrcFilter prcfilter, string filter)
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

                public Dictionary<string, string[]> GetElements(DataTable table)
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

                public decimal GetQueryAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1;
                    }
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

                public decimal[] GetQueryMetrics(DataTable table)
                {
                    try
                    {
                        return new decimal[] { GetQueryTotal(table), (decimal)GetQueryCount(table), GetQueryAverage(table) };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return new decimal[] { -1m, -1m, -1m };
                    }
                }

                public DataSet GetQuerySet()
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
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                public decimal GetQueryTotal(DataTable table)
                {
                    try
                    {
                        if (QueryTable.Columns.Contains("Amount"))
                            return table.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                        return -1M;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
                    }
                }

                public DataRow[] GetRecords(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p).ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                internal DataTable GetDataTable(DataSet dataSet)
                {
                    try
                    {
                        return dataSet.Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }

                private PRC[] GetPrcArray(DataTable table)
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
            }
        }
    }
}