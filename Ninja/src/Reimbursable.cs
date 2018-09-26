// <copyright file="Reimbursable.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;

    public class Reimbursable
    {
        // CONSTRUCTORS
        public Reimbursable()
        {
        }

        public Reimbursable(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            DbTable = DbData.Table;
            DbRow = DbTable.Rows[0];
        }

        public Reimbursable(string fund, string bfy, string org, string code, string spc, string an, decimal auth, decimal amout)
        {
            Source = Source.Reimbursables;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            DbTable = DbData.Table;
            DbRow = DbTable.Rows[0];
            BFY = bfy;
            Fund = new Fund(fund, bfy);
            OrgCode = org;
            Account = new Account(fund, code);
            SiteProjectCode = spc;
            AgreementNumber = an;
            Obligations = auth;
            Commitments = amout;
        }

        public Reimbursable(DataRow dr)
        {
            ID = int.Parse(dr["ID"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            OrgCode = dr["OrgCode"].ToString();
            Account = new Account(dr["Fund"].ToString(), dr["Code"].ToString());
            SiteProjectCode = dr["SiteProjectCode"].ToString();
            AgreementNumber = dr["Agreement"].ToString();
            Commitments = decimal.Parse(dr["Commitments"].ToString());
            Obligations = decimal.Parse(dr["Obligations"].ToString());
            DbRow = dr;
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public int ID { get; }

        public string BFY { get; }

        public Fund Fund { get; }

        public Account Account { get; }

        public string AgreementNumber { get; }

        public string DocumentNumber { get; }

        public string SiteProjectCode { get; }

        public string OrgCode { get; }

        public string Code { get; }

        public BOC BOC { get; }

        public string FOC { get; }

        public decimal Obligations { get; }

        public decimal Commitments { get; }

        public Dictionary<string, object> ReimbParam { get; }

        // METHODS
        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                Reimbursable account = new Reimbursable(source, Provider.SQLite);
                if (!param.ContainsKey("AgreementNumber") || param["AgreementNumber"] == null)
                {
                    param["AgreementNumber"] = account.AgreementNumber;
                }

                if (!param.ContainsKey("OrgCode") || param["OrgCode"] == null)
                {
                    param["OrgCode"] = account.OrgCode;
                }

                if (!param.ContainsKey("SiteProjectCode") || param["SiteProjectCode"] == null)
                {
                    param["SiteProjectCode"] = account.SiteProjectCode;
                }

                if (!param.ContainsKey("DocumentNumber") || param["DocumentNumber"] == null)
                {
                    param["DocumentNumber"] = account.DocumentNumber;
                }

                if (!param.ContainsKey("FOC") || param["FOC"] == null)
                {
                    param["FOC"] = account.FOC;
                }

                if (!param.ContainsKey("BOC") || param["BOC"] == null)
                {
                    param["BOC"] = account.BOC;
                }

                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Reimbursable Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Reimbursable(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Reimbursable Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Reimbursable(datarow);
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
                Dictionary<string, object> param = GetInsertFields(source, p);
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
                Dictionary<string, object> param = GetInsertFields(source, p);
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

        private Dictionary<string, object> GetColumnValues(string bfy, string fund)
        {
            try
            {
                return new Dictionary<string, object>() { ["BFY"] = bfy, ["Fund"] = fund };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}