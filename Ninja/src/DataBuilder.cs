﻿// <copyright file="DataBuilder.cs" company="PlaceholderCompany">
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
            Query = query;
            if (Source == Source.PRC || Source == Source.RegionalAccounts || Source == Source.DivisionAccounts)
            {
                Table = GetDataTable(Source);
                Total = GetTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = Table;
                DataRecords = GetDataRecords(Table);
            }

            if (Source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Where(p => p.Field<string>("BudgetLevel").Equals("8"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = Table;
                DataRecords = GetDataRecords(Table);
            }

        }

        public DataBuilder(Source source, Provider provider)
        {
            Parameter = null;
            Source = source;
            Query = new Query(source, provider);
            Table = GetDataTable(Source);
            Total = GetTotal(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            DataRecords = GetDataRecords(Table);
            if (source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Where(p => p.Field<string>("BudgetLevel").Equals("8"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = Table;
                DataRecords = GetDataRecords(Table);
            }
        }

        public DataBuilder(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Parameter = param;
            Query = new Query(source, provider, Parameter);
            Table = GetDataTable(Source);
            Total = GetTotal(Table);
            ProgramElements = GetProgramElements(Table);
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            DataRecords = GetDataRecords(Table);
            if (source == Source.FTE)
            {
                Table = GetDataTable().AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17"))
                    .Select(p => p).CopyToDataTable();
                Total = GetFteTotal(Table);
                ProgramElements = GetProgramElements(Table);
                BindingSource = new BindingSource();
                BindingSource.DataSource = Table;
                DataRecords = GetDataRecords(Table);
            }
        }

        // PROPERTIES
        public Source Source { get; }

        public Query Query { get; }

        public DataTable Table { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public DataRow[] DataRecords { get; }

        public BindingSource BindingSource { get; set; }

        public decimal Total { get; }

        public Dictionary<string, object> Parameter { get; set; }

        // METHODS
        private Dictionary<string, object> GetParameter(string rc)
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

        public DataTable FilterTable(DataTable table, PrcField prcfilter, string filter)
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
                if (Table.Columns.Contains("Amount"))
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
                if (Table.Columns.Contains("Amount"))
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

        public decimal[] GetMetrics(DataTable table)
        {
            try
            {
                if (Table.Columns.Contains("Amount"))
                {
                    return new decimal[] { GetTotal(table), (decimal)GetCount(table), GetAverage(table) };
                }

                return new decimal[] { 0m };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return new decimal[] { -1m, -1m, -1m };
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
                Query.DataAdapter.Fill(ds);
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
                this.Query.DataAdapter.Fill(ds);
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
                this.Query.DataAdapter.Fill(ds, Source.ToString());
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
                Query.DataAdapter.Fill(dt);
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
            try
            {
                if (Table.Columns.Contains("Amount"))
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p.Field<decimal>("Amount")).Sum();
                }

                return 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }

        public decimal GetFteTotal(DataTable table)
        {
            try
            {
                if (Table.Columns.Contains("Amount"))
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