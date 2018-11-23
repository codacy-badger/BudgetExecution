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

    /// <summary>
    /// Defines the <see cref="Reimbursable" />
    /// </summary>
    public class Reimbursable
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursable"/> class.
        /// </summary>
        public Reimbursable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursable"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Reimbursable(Source source = Source.Reimbursables, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursable"/> class.
        /// </summary>
        /// <param name="fund">The fund<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
        /// <param name="org">The org<see cref="string"/></param>
        /// <param name="code">The code<see cref="string"/></param>
        /// <param name="spc">The spc<see cref="string"/></param>
        /// <param name="an">The an<see cref="string"/></param>
        /// <param name="auth">The auth<see cref="decimal"/></param>
        /// <param name="amout">The amout<see cref="decimal"/></param>
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
            Account = new Account(Provider.SQLite, bfy, fund, code);
            SiteProjectCode = spc;
            AgreementNumber = an;
            Obligations = auth;
            Commitments = amout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursable"/> class.
        /// </summary>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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
            Account = new Account(0, BFY, Fund.Code, p[Account.Code].ToString());
            SiteProjectCode = p["SiteProjectCode"].ToString();
            AgreementNumber = p["AgreementNumber"].ToString();
            Obligations = decimal.Parse(p["Obligations"].ToString());
            Commitments = decimal.Parse(p["Commitments"].ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursable"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        public Reimbursable(DataRow dr)
        {
            DbRow = dr;
            ReimbId = int.Parse(dr["ID"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            OrgCode = dr["OrgCode"].ToString();
            Account = new Account(Provider.SQLite, BFY, dr["Fund"].ToString(), dr["Code"].ToString());
            SiteProjectCode = dr["SiteProjectCode"].ToString();
            AgreementNumber = dr["Agreement"].ToString();
            Commitments = decimal.Parse(dr["Commitments"].ToString());
            Obligations = decimal.Parse(dr["Obligations"].ToString());
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <summary>
        /// Gets the DbRow
        /// </summary>
        public DataRow DbRow { get; }

        /// <summary>
        /// Gets the ReimbId
        /// </summary>
        public int ReimbId { get; }

        /// <summary>
        /// Gets the BFY
        /// </summary>
        public string BFY { get; }

        /// <summary>
        /// Gets the Fund
        /// </summary>
        public Fund Fund { get; }

        /// <summary>
        /// Gets the Account
        /// </summary>
        public Account Account { get; }

        /// <summary>
        /// Gets the AgreementNumber
        /// </summary>
        public string AgreementNumber { get; }

        /// <summary>
        /// Gets or sets the DocumentNumber
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets the SiteProjectCode
        /// </summary>
        public string SiteProjectCode { get; }

        /// <summary>
        /// Gets the OrgCode
        /// </summary>
        public string OrgCode { get; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the FOC
        /// </summary>
        public string FOC { get; set; }

        /// <summary>
        /// Gets the Obligations
        /// </summary>
        public decimal Obligations { get; }

        /// <summary>
        /// Gets the Commitments
        /// </summary>
        public decimal Commitments { get; }

        /// <summary>
        /// Gets or sets the ReimbParam
        /// </summary>
        public Dictionary<string, object> ReimbParam { get; set; }

        /// <summary>
        /// Gets the insert fields.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                Reimbursable account = new Reimbursable(source);
                if(!param.ContainsKey("AgreementNumber") ||
                   param["AgreementNumber"] == null)
                {
                    param["AgreementNumber"] = account.AgreementNumber;
                }

                if(!param.ContainsKey("OrgCode") ||
                   param["OrgCode"] == null)
                {
                    param["OrgCode"] = account.OrgCode;
                }

                if(!param.ContainsKey("SiteProjectCode") ||
                   param["SiteProjectCode"] == null)
                {
                    param["SiteProjectCode"] = account.SiteProjectCode;
                }

                if(!param.ContainsKey("DocumentNumber") ||
                   param["DocumentNumber"] == null)
                {
                    param["DocumentNumber"] = account.DocumentNumber;
                }

                if(!param.ContainsKey("FOC") ||
                   param["FOC"] == null)
                {
                    param["FOC"] = account.FOC;
                }

                if(!param.ContainsKey("BOC") ||
                   param["BOC"] == null)
                {
                    param["BOC"] = account.BOC;
                }

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Selects the specified source.
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Selects the specified source.
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        /// <param name="p">The p.</param>
        public static void Insert(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                Dictionary<string, object> param = GetInsertFields(source, p);
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

        /// <summary>
        /// Inserts the specified source.
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
                using(conn)
                {
                    SQLiteCommand insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert?.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        /// <param name="p">The p.</param>
        public static void Update(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
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

        /// <summary>
        /// Updates the specified source.
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
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Deletes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        /// <param name="p">The p.</param>
        public static void Delete(Source source, Provider provider, Sql sql, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, provider, sql, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
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

        /// <summary>
        /// Deletes the specified source.
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
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
