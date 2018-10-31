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

        public Reimbursable(Source source = Source.Reimbursables, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
        }

        public Reimbursable(string fund, string bfy, string org, string code, string spc, string an, decimal auth, decimal amout)
        {
            Source = Source.Reimbursables;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            BFY = bfy;
            Fund = new Fund(fund, bfy);
            OrgCode = org;
            Account = new Account(bfy, fund, code);
            SiteProjectCode = spc;
            AgreementNumber = an;
            Obligations = auth;
            Commitments = amout;
        }

        public Reimbursable(Dictionary<string, object> p)
        {
            Source = Source.Reimbursables;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            ReimbId = int.Parse(DbRow["ID"].ToString());
            BFY = p["BFY"].ToString();
            Fund = new Fund(p["Fund"].ToString(), p["Fund"].ToString());
            OrgCode = p["OrgCode"].ToString();
            Account = new Account(BFY, Fund.Code, p[Account.Code].ToString(), Source.Accounts, 0);
            SiteProjectCode = p["SiteProjectCode"].ToString();
            AgreementNumber = p["AgreementNumber"].ToString();
            Obligations = decimal.Parse(p["Obligations"].ToString());
            Commitments = decimal.Parse(p["Commitments"].ToString());
        }

        public Reimbursable(DataRow dr)
        {
            DbRow = dr;
            ReimbId = int.Parse(dr["ID"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            OrgCode = dr["OrgCode"].ToString();
            Account = new Account(BFY, dr["Fund"].ToString(), dr["Code"].ToString());
            SiteProjectCode = dr["SiteProjectCode"].ToString();
            AgreementNumber = dr["Agreement"].ToString();
            Commitments = decimal.Parse(dr["Commitments"].ToString());
            Obligations = decimal.Parse(dr["Obligations"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow DbRow { get; }

        public int ReimbId { get; }

        public string BFY { get; }

        public Fund Fund { get; }

        public Account Account { get; }

        public string AgreementNumber { get; }

        public string DocumentNumber { get; set; }

        public string SiteProjectCode { get; }

        public string OrgCode { get; }

        public string Code { get; set; }

        public BOC BOC { get; set; }

        public string FOC { get; set; }

        public decimal Obligations { get; }

        public decimal Commitments { get; }

        public Dictionary<string, object> ReimbParam { get; set; }

        // METHODS

        /// <summary>
        ///     Gets the insert fields.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                Reimbursable account = new Reimbursable(source);
                if (!param.ContainsKey("AgreementNumber")
                   || param["AgreementNumber"] == null)
                {
                    param["AgreementNumber"] = account.AgreementNumber;
                }

                if (!param.ContainsKey("OrgCode")
                   || param["OrgCode"] == null)
                {
                    param["OrgCode"] = account.OrgCode;
                }

                if (!param.ContainsKey("SiteProjectCode")
                   || param["SiteProjectCode"] == null)
                {
                    param["SiteProjectCode"] = account.SiteProjectCode;
                }

                if (!param.ContainsKey("DocumentNumber")
                   || param["DocumentNumber"] == null)
                {
                    param["DocumentNumber"] = account.DocumentNumber;
                }

                if (!param.ContainsKey("FOC")
                   || param["FOC"] == null)
                {
                    param["FOC"] = account.FOC;
                }

                if (!param.ContainsKey("BOC")
                   || param["BOC"] == null)
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

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Reimbursable Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.Rows[0];
                return new Reimbursable(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Reimbursable Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.Rows[0];
                return new Reimbursable(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                Dictionary<string, object> param = GetInsertFields(source, p);
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
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

        /// <summary>
        ///     Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Dictionary<string, object> param = GetInsertFields(source, p);
                string[] fields = param.Keys.ToArray();
                object[] vals = param.Values.ToArray();
                Query query = new Query(source, provider, Sql.INSERT, param);
                string cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        public static void Update(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
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

        /// <summary>
        ///     Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.UPDATE, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     Deletes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
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

        /// <summary>
        ///     Deletes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.DELETE, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
