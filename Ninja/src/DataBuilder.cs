// <copyright file="DataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Syncfusion.Data.Extensions;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
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
            DataFields = null;
            Source = q.Source;
            DbQuery = new Query(q.Source, q.Provider);
            DbTable = GetDataTable(q.Source);
            Total = GetTotal(DbTable);
            ProgramElements = GetProgramElements(DbTable);
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            DbRow = GetRecords(DbTable);
            Columns = GetColumnNames(DbTable);
            if (q.Source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Where(p => p.Field<string>("BudgetLevel").Equals("8")).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetRecords(DbTable);
                Columns = GetColumnNames(DbTable);
            }
        }

        public DataBuilder(Source source, Provider provider)
        {
            DataFields = null;
            Source = source;
            DbQuery = new Query(source, provider);
            DbTable = GetDataTable(Source);
            Total = GetTotal(DbTable);
            ProgramElements = GetProgramElements(DbTable);
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            DbRow = GetRecords(DbTable);
            Columns = GetColumnNames(DbTable);
            if (source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Where(p => p.Field<string>("BudgetLevel").Equals("8")).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetRecords(DbTable);
                Columns = GetColumnNames(DbTable);
            }
        }

        public DataBuilder(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            DataFields = param;
            DbQuery = new Query(source, provider, DataFields);
            DbTable = GetDataTable(Source);
            Total = GetTotal(DbTable);
            ProgramElements = GetProgramElements(DbTable);
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            DbRow = GetRecords(DbTable);
            Columns = GetColumnNames(DbTable);
            if (source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetRecords(DbTable);
                Columns = GetColumnNames(DbTable);
            }
        }

        // PROPERTIES
        public Source Source { get; }

        public Query DbQuery { get; }

        public DataTable DbTable { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public string[] Columns { get; }

        public DataRow[] DbRow { get; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public Dictionary<string, object> DataFields { get; set; }

        // DELEGATES

        // METHODS
        private SQLiteQuery GetSQLiteQuery(Source source, Provider provider)
        {
            try
            {
                if (provider == Provider.SQLite)
                    return new SQLiteQuery(source);
                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private SQLiteQuery GetSQLiteQuery(Source source, Provider provider, SQLiteParameter[] pmr)
        {
            try
            {
                if (provider == Provider.SQLite)
                    return new SQLiteQuery(source);
                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private SQLiteQuery GetSQLiteQuery(Source source, Provider provider, Dictionary<string, object> dpr)
        {
            try
            {
                if (provider == Provider.SQLite)
                    return new SQLiteQuery(source, provider, dpr);
                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public ExcelQuery GetExcelQuery(Source source, Provider provider, OleDbParameter[] pmr)
        {
            try
            {
                if (provider == Provider.OleDb)
                {
                    ExcelQuery eq = new ExcelQuery(source);
                    eq.Parameters = pmr;
                    return eq;
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public ExcelQuery GetExcelQuery(Source source, Provider provider, Dictionary<string, object> dpr)
        {
            try
            {
                if (provider == Provider.OleDb)
                    return new ExcelQuery(source);
                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteParameter[] GetParamArray(DataRow row)
        {
            try
            {
                var cols = row.Table.Columns;
                var item = row.ItemArray;
                SQLiteParameter[] param = new SQLiteParameter[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    param[i] = new SQLiteParameter(cols[i].ColumnName, item[i]);
                }

                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public List<SQLiteParameter[]> GetParamList(DataTable table)
        {
            try
            {
                var paramlist = new List<SQLiteParameter[]>();
                foreach (DataRow row in table.Rows)
                {
                    paramlist.Add(GetParamArray(row));
                }

                return paramlist;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static DataTable FilterTable(DataTable table, Field prcfilter, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                if (table.Columns.Contains(column))
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

        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                foreach (DataColumn dc in table.Columns)
                {
                    if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount") || dc.ColumnName.Contains("Obligation") || dc.ColumnName.Contains("Commitment"))
                    {
                        continue;
                    }

                    data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
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

        public Dictionary<string, object> GetParamVals(DataTable table)
        {
            try
            {
                int ct = table.Columns.Count;
                string[] dc = table.Columns.ToList<string>().ToArray();
                int dr = table.Rows.Count;
                Dictionary<string, object> data = new Dictionary<string, object>();
                foreach (DataRow r in table.Rows)
                {
                    foreach (string c in dc)
                    {
                        if (c.Equals("Amount") || c.Contains("Obligation") || c.Contains("Commitment") || c.Contains("WorkHour") || c.Contains("LeaveHour"))
                        {
                            continue;
                        }

                        data.Add(c, r[c]);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public int GetCount(DataTable table)
        {
            try
            {
                if (DbTable.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                }

                return table.Rows.Count;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        public DataSet GetDataSet()
        {
            try
            {
                DataSet ds = new DataSet("R6");
                DataTable dt = new DataTable(Source.ToString());
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                DbQuery.DataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DataSet GetDataSet(string dataset, Source source)
        {
            try
            {
                DataSet ds = new DataSet(dataset);
                ds.DataSetName = dataset;
                DataTable dt = new DataTable(source.ToString());
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                DbQuery.DataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DataTable GetDataTable()
        {
            try
            {
                DataSet ds = new DataSet("R06");
                ds.DataSetName = "R06";
                DataTable dt = new DataTable(Source.ToString());
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                DbQuery.DataAdapter.Fill(ds, Source.ToString());
                return dt;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DataTable GetDataTable(Source source)
        {
            try
            {
                DataTable dt = new DataTable(source.ToString());
                dt.TableName = source.ToString();
                DbQuery.DataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public decimal GetTotal(DataTable table)
        {
            if (DbTable.Columns.Contains("Amount"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p.Field<decimal>("Amount")).Sum();
                    if (total > 0)
                    {
                        return total;
                    }
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }
            
            if (DbTable.Columns.Contains("DollarAmount"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Select(p => p.Field<decimal>("DollarAmount")).Sum();
                    if (total > 0)
                    {
                        return total;
                    }
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }

            if (DbTable.Columns.Contains("Obligataions"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Select(p => p.Field<decimal>("Obligations")).Sum();
                    if (total > 0)
                        return total;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }

            if (DbTable.Columns.Contains("Commitments"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Select(p => p.Field<decimal>("Commitments")).Sum();
                    if (total > 0)
                    {
                        return total;
                    }
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }

            if (DbTable.Columns.Contains("LeaveHours"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Select(p => p.Field<decimal>("LeaveHours")).Sum();
                    if (total > 0)
                    {
                        return total;
                    }
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }

            if (DbTable.Columns.Contains("WorkHours"))
            {
                try
                {
                    decimal total = table.AsEnumerable().Select(p => p.Field<decimal>("WorkHours")).Sum();
                    if (total > 0)
                    {
                        return total;
                    }
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return -1M;
                }
            }

            return -1;
        }

        public decimal GetFteTotal(DataTable table)
        {
            try
            {
                if (DbTable.Columns.Contains("Amount") && ProgramElements["BOC"].Contains("17"))
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC") == "17").Select(p => p.Field<decimal>("Amount")).Sum();
                }

                return 0m;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string[] GetColumnNames(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                try
                {
                    return Info.GetFields(table);
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