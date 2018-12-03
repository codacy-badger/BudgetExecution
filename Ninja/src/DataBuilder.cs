// <copyright file="DataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public class DataBuilder : IDataBuilder
    {
        // CONSTRUCTORS
        public DataBuilder()
        {
        }

        public DataBuilder(Source source, Provider provider = Provider.SQLite)
        {
            Input = null;
            Source = source;
            Provider = provider;
            Query = new Query(Source, Provider);

            if(source == Source.PRC)
            {
                Table = GetDataTable(Source)
                        .AsEnumerable()
                        .Where(p => p.Field<string>("BOC") != "17")
                        .Where(p => p.Field<decimal>("Amount") > 0)
                        .Select(p => p)
                        .CopyToDataTable();

                Total = GetTotal(Source, Table);
                Columns = GetColumnNames(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource(Table.DataSet, Table.TableName);
                Records = GetRecords(Table);
                Data = Table.Rows[0];
            }

            if(source == Source.FTE)
            {
                Table = GetDataTable(Source)
                        .AsEnumerable()
                        .Where(p => p.Field<string>("BOC").Equals("17"))
                        .Where(p => p.Field<decimal>("Amount") > 0)
                        .Select(p => p)
                        .CopyToDataTable();

                Total = GetTotal(Source, Table);
                Columns = GetColumnNames(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource(Table.DataSet, Table.TableName);
                Records = GetRecords(Table);
                Data = Table.Rows[0];
            }
            else
            {
                Table = GetDataTable(Source);
                Total = GetTotal(Source, Table);
                Columns = GetColumnNames(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource(Table.DataSet, Table.TableName);
                Records = GetRecords(Table);
                Data = Table.Rows[0];
            }
        }

        public DataBuilder(Source source, Provider provider, IDictionary<string, object> param) : this(source, provider)
        {
            Source = source;
            Provider = provider;
            Input = param;
            Query = new Query(Source, Provider, Sql.SELECT, Input);
        }
        
        public DataBuilder(Source source, IDictionary<string, object> param) : this(source)
        {
            Source = source;
            Input = param;
            Query = new Query(Source, Provider, Sql.SELECT, Input);
            Table = GetDataTable(Source);
            Total = GetTotal(Source, Table);
            Columns = GetColumnNames(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource(Table.DataSet, Table.TableName);
            Records = GetRecords(Table);
            Data = Table.Rows[0];
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public IDictionary<string, object> Input { get; set; }

        public IDictionary<string, Type> Schema { get; set; }

        public DataSet R6 { get; set; }

        public Query Query { get; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public string[] Columns { get; set; }

        public DataRow Data { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataTable GetDataTable()
        {
            try
            {
                DataSet ds = new DataSet("R6");
                ds.DataSetName = "R6";
                DataTable dt = new DataTable();
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, dt.TableName);
                return dt;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DataRow[] GetRecords(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p).ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string[] GetUniqueValues(DataTable table, string column)
        {
            try
            {
                if(table.GetColumnNames().Contains(column))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            if(table != null)
            {
                try
                {
                    Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                    foreach(DataColumn dc in table.Columns)
                    {
                        if(dc.ColumnName.Equals("ID") ||
                           dc.ColumnName.Equals("Amount") ||
                           dc.ColumnName.Equals("Hours") ||
                           dc.ColumnName.Equals("OpenCommitments") ||
                           dc.ColumnName.Contains("ULO") ||
                           dc.ColumnName.Equals("Obligations") ||
                           dc.ColumnName.Contains("Commitments") ||
                           dc.ColumnName.Equals("Authority") ||
                           dc.ColumnName.Equals("Budgeted") ||
                           dc.ColumnName.Equals("Posted") ||
                           dc.ColumnName.Equals("CarryIn") ||
                           dc.ColumnName.Equals("CarryOut") ||
                           dc.ColumnName.Contains("Balance"))
                        {
                            continue;
                        }

                        data.Add(dc.ColumnName, table.AsEnumerable().Select(p => p.Field<string>(dc)).Distinct().ToArray());
                    }

                    if(data.ContainsKey("ID"))
                    {
                        data.Remove("ID");
                    }

                    if(data.ContainsKey("Amount"))
                    {
                        data.Remove("Amount");
                    }

                    return data;
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        public DataSet GetDataSet(Source source)
        {
            try
            {
                DataSet ds = new DataSet("R6");
                ds.DataSetName = "R6";
                DataTable dt = new DataTable();
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, Source.ToString());
                return ds;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DataTable GetDataTable(Source source)
        {
            try
            {
                DataSet ds = new DataSet("R6");
                ds.DataSetName = "R6";
                DataTable dt = new DataTable();
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, dt.TableName);
                return dt;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public static DataTable Filter(DataTable table, Tuple<string, string> p)
        {
            try
            {
                return table.AsEnumerable()
                            .Where(prc => prc.Field<string>(p.Item1.ToString()).Equals(p.Item2.ToString(), StringComparison.CurrentCultureIgnoreCase))
                            .Select(prc => prc)
                            .CopyToDataTable();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static DataTable Filter(DataTable table, Field col, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(col.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static DataTable Filter(DataTable table, Field[] col, string[] filter)
        {
            try
            {
                switch(col.Length)
                {
                    case 1 when filter.Length == 1:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 2 when filter.Length == 2:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 3 when filter.Length == 3:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 4 when filter.Length == 4:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3].ToString()).Equals(filter[3]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 5 when filter.Length == 5:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3].ToString()).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4].ToString()).Equals(filter[4]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 6 when filter.Length == 6:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3].ToString()).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4].ToString()).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5].ToString()).Equals(filter[5]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 7 when filter.Length == 7:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3].ToString()).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4].ToString()).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5].ToString()).Equals(filter[5]))
                                    .Where(p => p.Field<string>(col[6].ToString()).Equals(filter[6]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 8 when filter.Length == 8:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3].ToString()).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4].ToString()).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5].ToString()).Equals(filter[5]))
                                    .Where(p => p.Field<string>(col[6].ToString()).Equals(filter[6]))
                                    .Where(p => p.Field<string>(col[7].ToString()).Equals(filter[7]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static DataTable Filter(DataTable table, string[] col, string[] filter)
        {
            try
            {
                switch(col.Length)
                {
                    case 1 when filter.Length == 1:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 2 when filter.Length == 2:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 3 when filter.Length == 3:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 4 when filter.Length == 4:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3]).Equals(filter[3]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 5 when filter.Length == 5:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3]).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4]).Equals(filter[4]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 6 when filter.Length == 6:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3]).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4]).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5]).Equals(filter[5]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 7 when filter.Length == 7:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3]).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4]).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5]).Equals(filter[5]))
                                    .Where(p => p.Field<string>(col[6]).Equals(filter[6]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    case 8 when filter.Length == 8:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>(col[0]).Equals(filter[0]))
                                    .Where(p => p.Field<string>(col[1]).Equals(filter[1]))
                                    .Where(p => p.Field<string>(col[2]).Equals(filter[2]))
                                    .Where(p => p.Field<string>(col[3]).Equals(filter[3]))
                                    .Where(p => p.Field<string>(col[4]).Equals(filter[4]))
                                    .Where(p => p.Field<string>(col[5]).Equals(filter[5]))
                                    .Where(p => p.Field<string>(col[6]).Equals(filter[6]))
                                    .Where(p => p.Field<string>(col[7]).Equals(filter[7]))
                                    .Select(p => p)
                                    .CopyToDataTable();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static string[] GetUniqueValues(DataTable table, Field column)
        {
            try
            {
                if(table.GetColumnNames().Contains(column.ToString()))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column.ToString())).Distinct().ToArray();
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public int GetCount(DataTable table)
        {
            try
            {
                return table.Rows.Count;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return 0;
            }
        }

        public decimal GetTotal(Source source, DataTable table)
        {
            try
            {
                switch(source)
                {
                    case Source.PRC:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>("BOC") != "17")
                                    .Where(p => p.Field<decimal>("Amount") > 0m)
                                    .Select(p => p.Field<decimal>("Amount"))
                                    .Sum();
                    case Source.FTE:
                        return table.AsEnumerable()
                                    .Where(p => p.Field<string>("BOC") == "17")
                                    .Where(p => p.Field<decimal>("Amount") > 0m)
                                    .Select(p => p.Field<decimal>("Amount"))
                                    .Sum();
                    case Source.ProgramObligations:
                    case Source.TravelObligations:
                    case Source.PayrollObligations:
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Obligations")).Sum();
                    default:
                        return 0m;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return 0;
            }
        }

        public string[] GetColumnNames(DataTable table)
        {
            if(table.Rows.Count > 0)
            {
                try
                {
                    return table.GetColumnNames();
                }
                catch(SystemException ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }
    }
}
