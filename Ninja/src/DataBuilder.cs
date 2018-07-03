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

    public class DataBuilder : IDataBuilder
    {
        // CONSTRUCTORS
        public DataBuilder()
        {
        }

        public DataBuilder(Query query)
        {
            Source = query.Source;
            DbQuery = query;
            if (Source == Source.PRC || Source == Source.RegionalAccounts || Source == Source.DivisionAccounts)
            {
                DbTable = GetDataTable(Source);
                Total = GetTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetDataRecords(DbTable);
            }

            if (Source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Where(p => p.Field<string>("BudgetLevel").Equals("8"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetDataRecords(DbTable);
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
            DbRow = GetDataRecords(DbTable);
            if (source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Where(p => p.Field<string>("BudgetLevel").Equals("8"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetDataRecords(DbTable);
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
            DbRow = GetDataRecords(DbTable);
            if (source == Source.FTE)
            {
                DbTable = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(DbTable);
                ProgramElements = GetProgramElements(DbTable);
                BindingSource = new BindingSource();
                BindingSource.DataSource = DbTable;
                DbRow = GetDataRecords(DbTable);
            }
        }

        // PROPERTIES
        public Source Source { get; }

        public Query DbQuery { get; }

        public DataTable DbTable { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public DataRow[] DbRow { get; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public Dictionary<string, object> DataFields { get; set; }

        // METHODS
        private Dictionary<string, object> GetDataFields(DataTable table)
        {
            try
            {
                var row = table.Rows[0];
                var col = table.GetFields();
                var val = row.ItemArray;
                var cct = table.Columns.Count;
                var rct = table.Rows.Count;
                var param = new Dictionary<string, object>();
                for(int i = 0; i < cct; i++)
                    param.Add(col[i], val[i]);
                return param;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }

        public static DataTable FilterTable(DataTable table, PrcField prcfilter, string filter)
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
                if (table.Columns.Contains(column))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                }

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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }

        public decimal GetAverage(DataTable table)
        {
            try
            {
                if (DbTable.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                }

                return 0m;
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
                if (DbTable.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
                }

                return table.Rows.Count;
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
                var ds = new DataSet("R6");
                var dt = new DataTable(Source.ToString());
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                DbQuery.DataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }

        public DataSet GetDataSet(string dataset, Source source)
        {
            try
            {
                var ds = new DataSet(dataset);
                ds.DataSetName = dataset;
                var dt = new DataTable(source.ToString());
                dt.TableName = source.ToString();
                ds.Tables.Add(dt);
                this.DbQuery.DataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }

        public DataTable GetDataTable()
        {
            try
            {
                var ds = new DataSet("R06");
                ds.DataSetName = "R06";
                var dt = new DataTable(Source.ToString());
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                this.DbQuery.DataAdapter.Fill(ds, Source.ToString());
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable GetDataTable(Source source)
        {
            try
            {
                var ds = new DataSet("R06");
                var dt = new DataTable(source.ToString());
                dt.TableName = source.ToString();
                DbQuery.DataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            } 
        }

        public decimal GetTotal(DataTable table)
        {
            if (DbTable.Columns.Contains("Amount"))
            {
                try
                {
                    var total = table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p.Field<decimal>("Amount")).Sum();
                    if(total > 0)
                        return total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                    return -1M;
                }
            }
            return -1;
        }

        public decimal GetFteTotal(DataTable table)
        {
            try
            {
                if (DbTable.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC") == "17").Select(p => p.Field<decimal>("Amount")).Sum();
                }

                return 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }

        public DataRow[] GetDataRecords(DataTable table)
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

        public string[] GetColumnNames(DataTable table)
        {
            if(table.Rows.Count > 0)
            {
                try
                {
                    return Info.GetFields(table);
                }
                catch(SystemException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return null;
                }
            }
            return null;
        }
    }
}