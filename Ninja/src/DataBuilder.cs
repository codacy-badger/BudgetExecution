// <copyright file="DataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// Defines the <see cref="T:BudgetExecution.DataBuilder" />
    /// </summary>
    public class DataBuilder : IDataBuilder
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        public DataBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
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
            }

            if(source == Source.FTE)
            {
                Table = GetDataTable(Source)
                        .AsEnumerable()
                        .Where(p => p.Field<string>("BOC").Equals("17"))
                        .Where(p => p.Field<decimal>("Amount") > 0)
                        .Select(p => p)
                        .CopyToDataTable();
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
            Data = Table.AsEnumerable().Select(p => p).First();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public DataBuilder(Source source, Provider provider, Dictionary<string, object> param) : this(source, provider)
        {
            Input = param;
            Query = new Query(Source, Provider, Sql.SELECT, Input);
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// Gets or sets the BindingSource
        /// </summary>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets the Total
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Gets or sets the Input
        /// </summary>
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// Gets or sets the Schema
        /// </summary>
        public Dictionary<string, Type> Schema { get; set; }

        /// <summary>
        /// Gets or sets the R6
        /// </summary>
        public DataSet R6 { get; set; }

        /// <summary>
        /// Gets the Query
        /// </summary>
        public Query Query { get; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Gets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the records in the table as an Array of DataRows.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the unique values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the program elements.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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
                           dc.ColumnName.Contains("OpenCommitments") ||
                           dc.ColumnName.Contains("ULO") ||
                           dc.ColumnName.Equals("Obligations") ||
                           dc.ColumnName.Equals("Commitments") ||
                           dc.ColumnName.Equals("Authority") ||
                           dc.ColumnName.Equals("Budgeted") ||
                           dc.ColumnName.Equals("Posted") ||
                           dc.ColumnName.Equals("CarryIn") ||
                           dc.ColumnName.Equals("CarryOut") ||
                           dc.ColumnName.Equals("Balance"))
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

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
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
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the data table.
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
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The Filter
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="p">The p<see cref="Tuple{string, string}"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
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

        /// <summary>
        /// Filters the records.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="col">The col.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Filters the records.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="col">The col.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
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

        /// <summary>
        /// The Filter
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the unique field values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the column names.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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
