// <copyright file="Query.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Text;

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
            Table = DbData.DbTable;
            DbRow = Table.Rows[0];
            ID = int.Parse(DbRow["ID"].ToString());
            Region = "R6";
            FiscalYear = Table.AsEnumerable().Select(p => p).First().Field<string>("FiscalYear");
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = RegionControlNumber + 1;
            BudgetControlNumber = FundControlNumber + 1;
        }

        public ControlNumber(string fund, string division)
        {
            Source = Source.ControlNumbers;
            Provider = Provider.SQLite;
            Fund = fund;
            DivisionID = division;
            DbData = new DataBuilder(Source, Provider, GetParamData(fund, division));
            Table = DbData.DbTable;
            DbRow = Table.Rows[0];
            ID = int.Parse(DbRow["ID"].ToString());
            FiscalYear = DbRow["FiscalYear"].ToString();
            Region = "R6";
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = GetFundCount(fund) + 1;
            BudgetControlNumber = GetDivisionCount(division) + 1;
        }


        // PROPERTIES
        public static string Region { get; set; }

        public int ID { get; set; }

        public DataRow DbRow { get; set; }

        public DataBuilder DbData { get; set; }

        public string FiscalYear { get; }

        public int RegionControlNumber { get; set; }

        public string Fund { get; set; }

        public int FundControlNumber { get; set; }

        public string DivisionID { get; set; }

        public string DivisionControlNumber { get; set; }

        public int BudgetControlNumber { get; set; }

        public Dictionary<string, object> Parameter { get; }

        // METHODS
        public Dictionary<string, object> GetParamData(string fund, string divisionid)
        {
            try
            {
                return new Dictionary<string, object>() { ["Fund"] = fund, ["DivisionID"] = divisionid };
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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

                var  _ = new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal int GetDivisionCount(string divisionid)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("DivisionID").Equals(divisionid)).Select(p => p).Count();
            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal int GetRegionCount()
        {
            try
            {
                return DbData.DbTable.AsEnumerable().Count();
            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Fund Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, Provider.SQLite, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Fund Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, provider, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
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
                var query = new SQLiteQuery(Source.ControlNumbers, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

        public override string ToString()
        {
            return new StringBuilder($"{FiscalYear}={Region}-{RegionControlNumber}-{Fund}-{FundControlNumber}-{DivisionID}-{BudgetControlNumber}").ToString();
        }
    }
}
