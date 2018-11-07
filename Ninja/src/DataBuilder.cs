// <copyright file="DataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections.Specialized;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Windows.Forms;

    public class DataBuilder : IDataBuilder
    {
        // CONSTRUCTORS
        public DataBuilder()
        {
        }

        public DataBuilder(Query q)
        {
            Input = null;
            Source = q.Source;
            Query = new Query(q.Source, q.Provider, q.Sql);

            if (q.Source == Source.PRC)
            {
                Table = GetDataTable(Source).AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            }

            if (q.Source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            }
            else
            {
                Table = GetDataTable();
            }

            Total = GetTotal(Source, Table);
            Columns = GetColumnNames(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            Records = GetRecords(Table);
        }

        public DataBuilder(Source source, Provider provider = Provider.SQLite)
        {
            Input = null;
            Source = source;
            Query = new Query(source, provider);

            if (source == Source.PRC)
            {
                Table = GetDataTable(Source).AsEnumerable()
                                            .Where(p => p.Field<string>("BOC") != "17")
                                            .Where(p => p.Field<decimal>("Amount") > 0)
                                            .Select(p => p).CopyToDataTable();
            }

            if (source == Source.FTE)
            {
                Table = GetDataTable(Source).AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                                            .Where(p => p.Field<decimal>("Amount") > 0)
                                            .Select(p => p).CopyToDataTable();
            }
            else
            {
                Table = GetDataTable();
            }

            Total = GetTotal(Source, Table);
            Columns = GetColumnNames(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource(Table.DataSet, Table.TableName);
            Records = GetRecords(Table);
        }

        public DataBuilder(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            Input = param;
            Query = new Query(source, provider, Sql.SELECT, Input);
            if (source == Source.PRC)
            {
                Table = GetDataTable(Source).AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            }

            if (source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            }
            else
            {
                Table = GetDataTable();
            }

            Total = GetTotal(Source, Table);
            Columns = GetColumnNames(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource(Table.DataSet, Table.TableName);
            Records = GetRecords(Table);
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public string[] Columns { get; set; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public Dictionary<string, object> Input { get; set; }

        public Dictionary<string, Type> Schema { get; set; }

        public DataSet R6 { get; set; }

        public Query Query { get; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        // METHODS

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            try
            {
                DataSet ds = new DataSet("R06");
                ds.DataSetName = "R06";
                DataTable dt = new DataTable();
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, dt.TableName);
                return dt;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the records in the table as an Array of DataRows.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public DataRow[] GetRecords(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p).ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data set.
        /// </summary>
        /// <returns></returns>
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
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data table.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
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
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the sqlite query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private SQLiteQuery GetSQLiteQuery(Source source, Provider provider, Sql sql)
        {
            try
            {
                return new SQLiteQuery(source, provider, sql);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the sq lite query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        private SQLiteQuery GetSQLiteQuery(Source source, Provider provider, Sql sql, Dictionary<string, object> pmr)
        {
            try
            {
                return new SQLiteQuery(source, provider, sql, pmr);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
        

        public static DataTable FilterRecords(DataTable table, Tuple<string, string> p)
        {
            try
            {
                return table.AsEnumerable()
                            .Where(prc => prc.Field<string>(p.Item1.ToString()).Equals(p.Item2.ToString(), StringComparison.CurrentCultureIgnoreCase))
                            .Select(prc => prc).CopyToDataTable();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Filters the records.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="col">The col.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public static DataTable FilterRecords(DataTable table, Field col, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(col.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Filters the records.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="col">The col.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public static DataTable FilterRecords(DataTable table, Field[] col, string[] filter)
        {
            try
            {
                switch (col.Length)
                {
                    case 1 when filter.Length == 1:
                        return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0])).Select(p => p).CopyToDataTable();
                    case 2 when filter.Length == 2:
                        return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0])).Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1])).Select(p => p).CopyToDataTable();
                    case 3 when filter.Length == 3:
                        return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0])).Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1])).Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2])).Select(p => p).CopyToDataTable();
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the unique values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public string[] GetUniqueFieldValues(DataTable table, string column)
        {
            try
            {
                if (table.GetColumnNames().Contains(column))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the unique field values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public static string[] GetUniqueFieldValues(DataTable table, Field column)
        {
            try
            {
                if (table.GetColumnNames().Contains(column.ToString()))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column.ToString())).Distinct().ToArray();
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the program elements.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            if (table != null)
            {
                try
                {
                    Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                    foreach (DataColumn dc in table.Columns)
                    {
                        if (dc.ColumnName.Equals("ID")
                           || dc.ColumnName.Equals("Amount")
                           || dc.ColumnName.Equals("Hours")
                           || dc.ColumnName.Contains("Obligations")
                           || dc.ColumnName.Contains("Commitments")
                           || dc.ColumnName.Contains("OpenCommitments")
                           || dc.ColumnName.Contains("ULO"))
                        {
                            continue;
                        }

                        data.Add(dc.ColumnName, table.AsEnumerable().Select(p => p.Field<string>(dc)).Distinct().ToArray());
                    }

                    if (data.ContainsKey("ID"))
                    {
                        data.Remove("ID");
                    }

                    if (data.ContainsKey("Amount"))
                    {
                        data.Remove("Amount");
                    }

                    return data;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public int GetCount(DataTable table)
        {
            try
            {
                return table.Rows.Count;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return 0;
            }
        }

        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public decimal GetTotal(Source source, DataTable table)
        {
            try
            {
                switch(source)
                {
                    case Source.PRC:
                        return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p.Field<decimal>("Amount")).Sum();
                    case Source.FTE:
                        return table.AsEnumerable().Where(p => p.Field<string>("BOC") == "17").Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p.Field<decimal>("Amount")).Sum();
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

        /// <summary>
        ///     Gets the column names.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public string[] GetColumnNames(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                try
                {
                    return table.GetColumnNames();
                }
                catch (SystemException ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }
    }
}
