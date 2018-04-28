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
                    Parameter = null;
                    Query = new Query(source);
                    Source = Query.Source;
                    QuerySet = GetQuerySet();
                    QueryTable = QuerySet.Tables[0];
                    ProgramElements = GetProgramElements(QueryTable);
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = QueryTable;
                    Records = GetRecords(QueryTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(QueryTable);
                        QueryTotal = GetQueryTotal(QueryTable);
                    }
                }

                public DataBuilder(Source source, Dictionary<string, object> param)
                {
                    Parameter = param;
                    Query = new Query(source, param);
                    Source = Query.Source;
                    QuerySet = GetQuerySet();
                    QueryTable = QuerySet.Tables[0];
                    ProgramElements = GetProgramElements(QueryTable);
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = QueryTable;
                    Records = GetRecords(QueryTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                            Accounts = GetPrcArray(QueryTable);
                            QueryTotal = GetQueryTotal(QueryTable);
                    }
                }

                //Properties
                public Source Source { get; }
                public Query Query { get; }
                public DataSet QuerySet { get; }
                public DataTable QueryTable { get; }
                public PRC[] Accounts { get; }
                public DataRow[] Records { get; }
                public BindingSource BindingSource { get; set; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public decimal QueryTotal { get; }
                public Dictionary<string, object> Parameter { get; set; }

                //Methods
                Dictionary<string, object> GetParameter(string rc)
                {
                    try
                    {
                        var param = new Dictionary<string, object>();
                        param.Add("RC", rc);
                        return param;
    
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }
                public Dictionary<string, object>GetParameter(string rc, AccountField prcfilter, string filter)
                {
                    try
                    {
                        if (Parameter.ContainsKey(rc))
                        {
                            Parameter.Add(prcfilter.ToString(), filter);
                        }
                        return Parameter;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
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
                public string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        if(table.Columns.Contains(column))
                            return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                        return null;
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
                            if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount"))
                                continue;
                            data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
                        }
                        if (data.ContainsKey("ID")) data.Remove("ID");
                        if (data.ContainsKey("Amount")) data.Remove("Amount");
                        if (data.ContainsKey("P6.ID")) data.Remove("P6.ID");
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
                        if (QueryTable.Columns.Contains("Amount"))
                            return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                        return 0m;
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
                        if (QueryTable.Columns.Contains("Amount"))
                            return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                        return table.Rows.Count;
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
                        if (QueryTable.Columns.Contains("Amount"))
                            return new decimal[] { GetQueryTotal(table), (decimal)GetQueryCount(table), GetQueryAverage(table) };
                        return new decimal[] { 0m };
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
                        return 0m;
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