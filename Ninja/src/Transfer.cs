// <copyright file="Reprogramming.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;

    public class Transfer
    {
        // CONSTRUCTORS
        public Transfer()
        {
        }

        public Transfer(string bl, string docType, string rpio, string org, string rc, string bfy, string fund, string tcn, string qtr, string date, string code, string progproj, string ppn, string npmcode, string fromto, string boc, decimal amount)
        {
            BudgetLevel = bl;
            DocType = docType;
            RPIO = rpio;
            Org = new Org(org);
            RC = new RC(rc);
            BFY = bfy;
            Fund = new Fund(fund, BFY);
            TCN = tcn;
            Qtr = qtr;
            Date = date;
            Code = code;
            Account = new Account(fund, code);
            NpmCode = Account.NPM;
            FromTo = fromto;
            BOC = new BOC(boc);
            Amount = amount;
        }

        public Transfer(DataRow dr)
        {
            BudgetLevel = dr["BudgetLevel"].ToString();
            DocType = dr["DocType"].ToString();
            RPIO = dr["RPIO"].ToString();
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            TCN = dr["TCN"].ToString();
            Qtr = dr["Qtr"].ToString();
            Date = dr["Date"].ToString();
            Code = dr["Code"].ToString();
            Account = new Account(dr["Code"].ToString(), Code);
            NpmCode = Account.NPM;
            FromTo = dr["FromTo"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            Amount = decimal.Parse(dr["Amount"].ToString());
        }

        // PROPERTIES
        public DataBuilder DbData { get; }

        public DataRow DbTable { get; }

        public DataRow DbRow { get; }

        public Source Source { get; }

        public Provider Provider { get; }

        public Account Account { get; }

        public decimal Amount { get; }

        public string BFY { get; }

        public BOC BOC { get; }

        public string BudgetLevel { get; }

        public string Code { get; }

        public string Date { get; }

        public string DocType { get; }

        public string FromTo { get; }

        public Fund Fund { get; }

        public string NpmCode { get; }

        public Org Org { get; }

        public string Qtr { get; }

        public RC RC { get; }

        public string RPIO { get; }

        public string TCN { get; }

        // METHODS
        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Fund account = new Fund(source, provider, param["FiscalYear"].ToString(), param["Code"].ToString());
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

        public static Transfer Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Transfer(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Transfer Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Transfer(datarow);
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
                Dictionary<string, object> param = GetInsertionColumns(source, Provider.SQLite, p);
                string[] fields = param.Keys.ToArray();
                object[] vals = param.Values.ToArray();
                SQLiteQuery query = new SQLiteQuery(source, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    SQLiteCommand insert = query.InsertCommand;
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
                Dictionary<string, object> param = GetInsertionColumns(source, provider, p);
                string[] fields = param.Keys.ToArray();
                object[] vals = param.Values.ToArray();
                Query query = new Query(source, provider, param);
                string cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
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
                SQLiteQuery query = new SQLiteQuery(source, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn);
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
                Query query = new Query(source, provider, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
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
                SQLiteQuery query = new SQLiteQuery(source, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    SQLiteCommand delete = query.GetDataCommand(cmd, conn);
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
                Query query = new Query(source, provider, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
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