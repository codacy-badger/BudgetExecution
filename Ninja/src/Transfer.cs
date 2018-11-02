﻿// <copyright file="Transfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Transfer
    {
        // CONSTRUCTORS
        public Transfer()
        {
            Source = Source.Transfers;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            TransId = int.Parse(DbRow["ID"].ToString());
        }

        public Transfer(Source source = Source.Transfers, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            TransId = int.Parse(DbRow["ID"].ToString());
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
            Account = new Account(BFY, fund, code, Source.Accounts, 0);
            NpmCode = Account.NPM;
            FromTo = fromto;
            BOC = new BOC(boc);
            Amount = amount;
        }

        public Transfer(DataRow dr)
        {
            TransId = int.Parse(dr["ID"].ToString());
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
            Account = new Account(BFY, Fund.Code, Code);
            NpmCode = Account.NPM;
            FromTo = dr["FromTo"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            Amount = decimal.Parse(dr["Amount"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public int TransId { get; }

        public DataRow DbRow { get; }

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

        /// <summary>
        ///     Gets the insertion columns.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Fund account = new Fund(source, provider, param);
                if (!param.ContainsKey("Name")
                   || param["Name"] == null)
                {
                    param["Name"] = account.Name;
                }

                if (!param.ContainsKey("TreasurySymbol")
                   || param["TreasurySymbol"] == null)
                {
                    param["TreasurySymbol"] = account.TreasurySymbol;
                }

                if (!param.ContainsKey("Title")
                   || param["Title"] == null)
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

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
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

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
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

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
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
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
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
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
