// <copyright file="Fund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;

    public class Fund : IFund
    {

        // CONSTRUCTORS
        public Fund()
        {
        }
        public Fund(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).DbTable;
        }

        public Fund(string code, string bfy) : this(Source.Funds, Provider.SQLite)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetDataFields(Code, FiscalYear);
            Table = GetData(Source, Provider, Parameter);
            Data = Table.Rows[0];
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(Source source, string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetDataFields(Code, FiscalYear);
            Table = GetData(source, Provider.SQLite, Parameter);
            Data = Table.AsEnumerable().First();
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(Source source, Provider provider, string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetDataFields(Code, FiscalYear);
            Table = GetData(Source.Funds, Provider.SQLite, Parameter);
            Data = Table.AsEnumerable().First();
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public string Code { get; }

        public string FiscalYear { get; }

        public Dictionary<string, object> Parameter { get; }

        public string Name { get; }

        public string Title { get; }

        public string TreasurySymbol { get; }

        public DataTable Table { get; set; }

        public DataRow Data { get; set; }

        // METHODS
        public Dictionary<string, object> GetDataFields(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["FiscalYear"] = bfy };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, object> GetFundData(string code)
        {
            try
            {
                var dr = GetData(Source.Funds, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DataTable GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.DbTable;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string[] GetFields(Source source, Provider provider)
        {
            try
            {
                Dictionary<string, object> prc = GetDataFields(Source.ToString(), Provider.ToString());

                return prc.Keys.ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal object[] GetFieldValues()
        {
            try
            {
                Dictionary<string, object> param = GetDataFields(Source.ToString(), Provider.ToString());

                return param.Values.ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var account = new Fund(source, provider, param["FiscalYear"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("Name") || param["Name"] == null)
                {
                    param["Name"] = account.Name;
                }


                if (!param.ContainsKey("TreasurySymbol") || param["TreasurySymbol"] == null)
                {
                    param["TreasurySymbol"] = account.TreasurySymbol;
                }

                if (!param.ContainsKey("Title") || param["Title"] == null)
                {
                    param["Title"] = account.Title;
                }

                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Source source, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertionColumns(source, Provider.SQLite, p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new SQLiteQuery(source, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertionColumns(source, provider, p);
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
            }
        }
    }
}