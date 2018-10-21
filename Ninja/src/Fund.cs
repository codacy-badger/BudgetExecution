using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetExecution
{
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
            Table = new DataBuilder(Source, Provider).Table;
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

        public int ID { get; set; }

        public DataRow Data { get; set; }

        public string Code { get; }

        public string FiscalYear { get; }

        public Dictionary<string, object> Parameter { get; }

        public string Name { get; }

        public string Title { get; }

        public string TreasurySymbol { get; }

        public DataTable Table { get; set; }

        // METHODS
        public Dictionary<string, object> GetDataFields(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code, ["FiscalYear"] = bfy };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, object> GetFundData(string code)
        {
            try
            {
                DataTable dr = GetData(Source.Funds, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DataTable GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataBuilder data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Fund account = new Fund(source, provider, param["FiscalYear"].ToString(), param["Code"].ToString());
                if(!param.ContainsKey("Name") || param["Name"] == null)
                {
                    param["Name"] = account.Name;
                }

                if(!param.ContainsKey("TreasurySymbol") || param["TreasurySymbol"] == null)
                {
                    param["TreasurySymbol"] = account.TreasurySymbol;
                }

                if(!param.ContainsKey("Title") || param["Title"] == null)
                {
                    param["Title"] = account.Title;
                }

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

        public static void Insert(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                Dictionary<string, object> param = GetInsertionColumns(source, Provider.SQLite, p);
                string[] fields = param.Keys.ToArray();
                object[] vals = param.Values.ToArray();
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
                SQLiteConnection conn = query.DataConnection;
                using(conn)
                {
                    SQLiteCommand insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Dictionary<string, object> param = GetInsertionColumns(source, provider, p);
                string[] fields = param.Keys.ToArray();
                object[] vals = param.Values.ToArray();
                Query query = new Query(source, provider, Sql.INSERT, param);
                string cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using(conn)
                {
                    SQLiteCommand insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal) p["Amount"]} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn);
                    update.ExecuteNonQuery();
                }
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
                Query query = new Query(source, provider, Sql.UPDATE, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal) p["Amount"]} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using(conn)
                {
                    SQLiteCommand delete = query.GetDataCommand(cmd, conn);
                    delete.ExecuteNonQuery();
                }
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
                Query query = new Query(source, provider, Sql.DELETE, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
