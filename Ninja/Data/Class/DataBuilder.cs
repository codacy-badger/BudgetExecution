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
                    BudgetData = GetDataSet();
                    BudgetTable = BudgetData.Tables[0];
                    Total = GetTotal(BudgetTable);
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = BudgetTable; 
                    ProgramElements = GetElements(BudgetTable);
                    Records = GetRecords(BudgetTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(BudgetTable);
                    }
                }

                public DataBuilder(Source source, Dictionary<string, object> param)
                {
                    Query = new Query(source, param);
                    BudgetData = GetDataSet();
                    BudgetTable = BudgetData.Tables[0];
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = BudgetTable;
                    ProgramElements = GetElements(BudgetTable);
                    Records = GetRecords(BudgetTable);
                    if (source == Source.P6 || source == Source.P7 || source == Source.P8)
                    {
                        Accounts = GetPrcArray(BudgetTable);
                    }
                }

                //Properties
                public Query Query { get; }
                public DataSet BudgetData { get; }
                public DataTable BudgetTable { get; }
                public decimal Total { get; }
                public Dictionary<string, string[]> ProgramElements { get; }
                public DataRow[] Records { get; }
                public PRC[] Accounts { get; }
                public BindingSource BindingSource { get; set; }
                Dictionary<string, object> Parameter { get; set; }

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
                public decimal GetAverage(DataTable table)
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
                public DataSet GetDataSet()
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
                public decimal[] GetMetrics(DataTable table)
                {
                    try
                    {
                        return new decimal[] { GetTotal(table), (decimal)GetCount(table), GetAverage(table) };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return new decimal[] { -1m, -1m, -1m };
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
                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        if(BudgetTable.Columns.Contains("Amount"))
                            return table.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                        return -1M;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return -1M;
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