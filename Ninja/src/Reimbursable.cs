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
    using System.Windows.Forms;

    public class Reimbursable
    {
        private Source Source;
        private Provider Provider;
        private DataTable Table;

        // CONSTRUCTORS
        public Reimbursable()
        {
        }

        public Reimbursable(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            DbRow = Table.Rows[0];
        }

        public Reimbursable(string fund, string bfy, string org, string code, string spc, string an, decimal auth, decimal amout)
        {
            Source = Source.Reimbursables;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            DbRow = Table.Rows[0];
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
        public int ID { get; }

        public DataRow DbRow { get; set; }

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

        public string BFY { get; }

        public DataRow Data { get; }

        public DataBuilder DbData { get; }

        public Fund Fund { get; }

        Dictionary<string, object> ReimbParam { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string bfy, string fund)
        {
            try
            {
                return new Dictionary<string, object>() { ["BFY"] = bfy, ["Fund"] = fund };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                var account = new Reimbursable(source, Provider.SQLite);
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
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Reimbursable Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, Provider.SQLite, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new Reimbursable(datarow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Reimbursable Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, provider, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new Reimbursable(datarow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static void Insert(Source source, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertFields(source, p);
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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertFields(source, p);
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