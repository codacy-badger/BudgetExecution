// <copyright file="Query.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Linq;
    using System.Windows.Forms;

    public class ControlNumber
    {
        private Source Source;
        private Provider Provider;
        private DataTable Table;

        // CONSTRUCTORS
        public ControlNumber()
        {

        }

        public ControlNumber(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            ID = int.Parse(Table.AsEnumerable().First().Field<string>("ID"));
            FiscalYear = Table.AsEnumerable().First().Field<string>("FiscalYear");
            RegionControlNumber = GetRegionCount();
            FundControlNumber = RegionControlNumber;
            BudgetControlNumber = FundControlNumber;
        }

        public ControlNumber(string fund, string division)
        {
            Source = Source.BudgetDocuments;
            Provider = Provider.SQLite;
            Fund = fund;
            DivisionID = division;
            DbData = new DataBuilder(Source, Provider, GetParamData(fund, division));
            Table = DbData.Table;
            ID = int.Parse(Table.AsEnumerable().First().Field<string>("ID"));
            FiscalYear = Table.AsEnumerable().First().Field<string>("FiscalYear");
            RegionControlNumber = GetRegionCount();
            FundControlNumber = GetFundCount(fund);
            BudgetControlNumber = GetDivisionCount(division);
        }


        // PROPERTIES
        public int ID { get; set; }

        public DataBuilder DbData { get; set; }

        public string FiscalYear { get; }

        public string Region { get; set; }

        public int RegionControlNumber { get; set; }

        public string Fund { get; set; }

        public int FundControlNumber { get; set; }

        public string DivisionID { get; set; }

        public int BudgetControlNumber { get; set; }

        public Dictionary<string, object> Parameter { get; }

        // METHODS
        public Dictionary<string, object> GetParamData(string fund, string divisionid)
        {
            try
            {
                return new Dictionary<string, object>() { ["Fund"] = fund, ["DivisionID"] = divisionid };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal string[] GetColumnNames()
        {
            try
            {
                return Table.GetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }

        internal int GetFundCount(string fund)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("Fund").Equals(fund)).Select(p => p).Count();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return -1;
            }
        }

        internal int GetDivisionCount(string divisionid)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("RC").Equals(divisionid)).Select(p => p).Count();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return -1;
            }
        }

        internal int GetRegionCount()
        {
            try
            {
                return DbData.Table.AsEnumerable().Count();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return -1;
            }
        }

        internal void Calculate(string fund, string divisionid)
        {
            int reg = GetRegionCount() + 1;
            int fd = GetFundCount(fund) + 1;
            int dc = GetDivisionCount(divisionid) + 1;

        }

        public static Dictionary<string, object> GetInsertionColumns(Dictionary<string, object> param)
        {
            try
            {
                var account = new ControlNumber(param["Fund"].ToString(), param["DivisionID"].ToString());

                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Fund Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Fund Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static void Insert(Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertionColumns(p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new SQLiteQuery(Source.BudgetDocuments, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertionColumns(p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new Query(source, provider, param);
                var cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Update(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn);
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Delete(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var delete = query.GetDataCommand(cmd, conn);
                    delete.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
