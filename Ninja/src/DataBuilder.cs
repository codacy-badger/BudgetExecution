using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class DataBuilder : IDataBuilder
    {
        // CONSTRUCTORS
        public DataBuilder()
        {
        }

        public DataBuilder(Query q)
        {
            DataFields = null;
            Source = q.Source;
            Query = new Query(q.Source, q.Provider);
            Table = GetDataTable(q.Source);
            Total = GetTotal(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            Records = GetRecords(Table);
            Columns = GetColumnNames(Table);
            if(q.Source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Where(p => p.Field<string>("BudgetLevel").Equals("8")).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = Table;
                Records = GetRecords(Table);
                Columns = GetColumnNames(Table);
            }
        }

        public DataBuilder(Source source, Provider provider = Provider.SQLite)
        {
            DataFields = null;
            Source = source;
            Query = new Query(source, provider);
            Table = GetDataTable(Source).AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            Columns = Table.GetFields();
            Total = GetTotal(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource(Table.DataSet, Table.TableName);
            Records = GetRecords(Table);
            Columns = Table.GetFields();
            if(source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                                      .Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource(Table.DataSet, Table.TableName);
                Records = GetRecords(Table);
                Columns = Table.GetFields();
            }
        }

        public DataBuilder(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            DataFields = param;
            Query = new Query(source, provider, DataFields);
            Table = GetDataTable(Source).AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
            Total = GetTotal(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource(Table.DataSet, Table.TableName);
            Records = GetRecords(Table);
            Columns = Table.GetFields();
            if(source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                                      .Where(p => p.Field<decimal>("Amount") > 0).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource(Table.DataSet, Table.TableName);
                Records = GetRecords(Table);
                Columns = Table.GetFields();
            }
        }

        // PROPERTIES
        public Source Source { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public string[] Columns { get; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public Dictionary<string, object> DataFields { get; set; }

        public Query Query { get; }

        public DataTable Table { get; }

        public DataRow[] Records { get; }

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
                Query.DataAdapter.Fill(ds, Source.ToString());
                return dt;
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
                DataSet ds = new DataSet("R06");
                ds.DataSetName = "R06";
                DataTable dt = new DataTable();
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, Source.ToString());
                return dt;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

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

        /// <summary>
        /// Gets the sqlite query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private SQLiteQuery GetSQLiteQuery(Source source)
        {
            try
            {
                return new SQLiteQuery(source);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the sq lite query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        private SQLiteQuery GetSQLiteQuery(Source source, SQLiteParameter[] pmr)
        {
            try
            {
                return new SQLiteQuery(source, pmr);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the sq lite query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="dpr">The DPR.</param>
        /// <returns></returns>
        private SQLiteQuery GetSQLiteQuery(Source source, Dictionary<string, object> dpr)
        {
            try
            {
                return new SQLiteQuery(source, dpr);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the excel query.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        public ExcelQuery GetExcelQuery(Dictionary<string, object> pmr)
        {
            try
            {
                if(pmr != null)
                {
                    ExcelQuery eq = new ExcelQuery(Source, pmr);
                    return eq;
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
        /// Gets the excel query.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        public ExcelQuery GetExcelQuery(Source source, Dictionary<string, object> pmr)
        {
            try
            {
                if(pmr != null)
                {
                    ExcelQuery eq = new ExcelQuery(source, pmr);
                    return eq;
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
        /// Gets the parameter array.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <returns></returns>
        public SQLiteParameter[] GetParamArray(DataRow row)
        {
            try
            {
                DataColumnCollection cols = row.Table.Columns;
                object[] item = row.ItemArray;
                SQLiteParameter[] param = new SQLiteParameter[row.ItemArray.Length];
                for(int i = 0; i < row.ItemArray.Length; i++)
                {
                    param[i] = new SQLiteParameter(cols[i].ColumnName, item[i]);
                }

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the parameter list.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public List<SQLiteParameter[]> GetParameterList(DataTable table)
        {
            try
            {
                List<SQLiteParameter[]> paramlist = new List<SQLiteParameter[]>();
                foreach(DataRow row in table.Rows)
                {
                    paramlist.Add(GetParamArray(row));
                }

                return paramlist;
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
        public static DataTable FilterRecords(DataTable table, Field col, string filter)
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
        public static DataTable FilterRecords(DataTable table, Field[] col, string[] filter)
        {
            try
            {
                if(col.Length == 1 && filter.Length == 1)
                {
                    return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                .Select(p => p).CopyToDataTable();
                }

                if(col.Length == 2 && filter.Length == 2)
                {
                    return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                .Select(p => p).CopyToDataTable();
                }

                if(col.Length == 3 && filter.Length == 3)
                {
                    return table.AsEnumerable().Where(p => p.Field<string>(col[0].ToString()).Equals(filter[0]))
                                .Where(p => p.Field<string>(col[1].ToString()).Equals(filter[1]))
                                .Where(p => p.Field<string>(col[2].ToString()).Equals(filter[2]))
                                .Select(p => p).CopyToDataTable();
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
        /// Gets the unique values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public string[] GetUniqueFieldValues(DataTable table, string column)
        {
            try
            {
                if(table.GetFields().Contains(column))
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

        /// <summary>
        /// Gets the unique field values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public static string[] GetUniqueFieldValues(DataTable table, Field column)
        {
            try
            {
                if(table.GetFields().Contains(column.ToString()))
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
        /// Gets the program elements.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                foreach(DataColumn dc in table.Columns)
                {
                    if(dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount") || dc.ColumnName.Contains("Obligation") || dc.ColumnName.Contains("Commitment"))
                    {
                        continue;
                    }

                    data.Add(dc.ColumnName, GetUniqueFieldValues(table, dc.ColumnName));
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

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public int GetCount(DataTable table)
        {
            try
            {
                if(Table.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                }

                return table.Rows.Count;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return 0;
            }
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            try
            {
                DataSet ds = new DataSet("R6");
                DataTable dt = new DataTable(Source.ToString());
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DataSet GetDataSet(Source source)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.DataSetName = "R06";
                DataTable dt = new DataTable(source.ToString());
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                Query.DataAdapter.Fill(ds, dt.TableName);
                return ds;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public decimal GetTotal(DataTable table)
        {
            string[] cols = table.GetFields();
            if(cols.Contains("Amount") ||
               cols.Contains("Obligations") ||
               cols.Contains("Commitments") ||
               cols.Contains("LeaveHours") ||
               cols.Contains("DollarAmount") ||
               cols.Contains("WorkHours"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p.Field<decimal>("Amount")).Sum();
                    if(total > 0)
                    {
                        return total;
                    }
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Gets the fte total.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public decimal GetFteTotal(DataTable table)
        {
            try
            {
                if(Table.Columns.Contains("Amount") && ProgramElements["BOC"].Contains("17"))
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC") == "17").Select(p => p.Field<decimal>("Amount")).Sum();
                }

                return 0;
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
                    return table.GetFields();
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
