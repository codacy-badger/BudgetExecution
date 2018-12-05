// <copyright file="ControlNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace BudgetExecution
{
    public class ControlNumber : IDataBuilder
    {
        // CONSTRUCTORS
        public ControlNumber()
        {
            Source = Source.ControlNumbers;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public ControlNumber(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                Region = "R6";
                BFY = Table.AsEnumerable().Select(c => c.Field<string>("BFY")).First();
                RegionControlNumber = GetRegionCount() + 1;
                FundControlNumber = RegionControlNumber + 1;
                BudgetControlNumber = FundControlNumber + 1;
            }
        }

        public ControlNumber(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                Region = "R6";
                BFY = Table.AsEnumerable().Select(c => c.Field<string>("BFY")).First();
                RegionControlNumber = GetRegionCount() + 1;
                FundControlNumber = RegionControlNumber + 1;
                BudgetControlNumber = FundControlNumber + 1; 
            }
        }

        public ControlNumber(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                Region = "R6";
                BFY = Table.AsEnumerable().Select(c => c.Field<string>("BFY")).First();
                RegionControlNumber = GetRegionCount() + 1;
                FundControlNumber = RegionControlNumber + 1;
                BudgetControlNumber = FundControlNumber + 1;
            }
        }

        public ControlNumber(string fundCode, string division) : this()
        {
            FundCode = fundCode;
            Division = division;
            Input = GetParameter(FundCode, Division);
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                Region = "R6";
                BFY = Table.AsEnumerable().Select(p => p.Field<string>("BFY")).First();
                RegionControlNumber = GetRegionCount() + 1;
                FundControlNumber = RegionControlNumber + 1;
                BudgetControlNumber = FundControlNumber + 1; 
            }
        }

        public ControlNumber(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Region = "R6";
            BFY = Table.AsEnumerable().Select(p => p.Field<string>("BFY")).First();
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = RegionControlNumber + 1;
            BudgetControlNumber = FundControlNumber + 1;
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public static string Region { get; set; }

        public int ID { get; set; }

        public string BFY { get; }

        public int RegionControlNumber { get; set; }

        public string FundCode { get; set; }

        public int FundControlNumber { get; set; }

        public string Division { get; set; }

        public string DivisionControlNumber { get; set; }

        public int BudgetControlNumber { get; set; }

        public Dictionary<string, object> Input { get; set; }

        // METHODS

        public Dictionary<string, object> GetParameter(string fund, string divisionid)
        {
            try
            {
                return new Dictionary<string, object> { ["FundCode"] = fund, ["DivisionID"] = divisionid };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertionColumns(Dictionary<string, object> param)
        {
            try
            {
                new ControlNumber(param["FundCode"].ToString(), param["DivisionID"].ToString());

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Fund Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Fund Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return new StringBuilder($"{BFY}={Region}-{RegionControlNumber}-{FundCode}-{FundControlNumber}-{Division}-{BudgetControlNumber}").ToString();
        }

        internal string[] GetColumnNames()
        {
            try
            {
                return Table.GetColumnNames();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal int GetFundCount(string fundcode)
        {
            try
            {
                return Table.AsEnumerable()
                            .Where(p => p.Field<string>("Fund").Equals(fundcode))
                            .Select(p => p).Count();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal int GetDivisionCount(int divisionId)
        {
            try
            {
                return Table.AsEnumerable()
                            .Where(p => p.Field<int>("ID").Equals(divisionId))
                            .Select(p => p)
                            .Count();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal int GetRegionCount()
        {
            try
            {
                return DbData.Table.Rows.Count;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }


        DataTable IDataBuilder.GetDataTable()
        {
            try
            {
                Query query = DbData.Query;
                DataSet ds = new DataSet("R6");
                ds.DataSetName = "R6";
                DataTable dt = new DataTable();
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                query.DataAdapter.Fill(ds, dt.TableName);
                return dt;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }


        DataRow[] IDataBuilder.GetRecords(DataTable table)
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

        string[] IDataBuilder.GetUniqueValues(DataTable table, string column)
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

        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
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

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
