﻿// <copyright file="Transfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Transfer" />
    /// </summary>
    public class Transfer
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        public Transfer()
        {
            Source = Source.Transfers;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            TransId = int.Parse(DbRow["ID"].ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Transfer(Source source = Source.Transfers, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            TransId = int.Parse(DbRow["ID"].ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="bl">The bl<see cref="string"/></param>
        /// <param name="docType">The docType<see cref="string"/></param>
        /// <param name="rpio">The rpio<see cref="string"/></param>
        /// <param name="org">The org<see cref="string"/></param>
        /// <param name="rc">The rc<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
        /// <param name="fund">The fund<see cref="string"/></param>
        /// <param name="tcn">The tcn<see cref="string"/></param>
        /// <param name="qtr">The qtr<see cref="string"/></param>
        /// <param name="date">The date<see cref="string"/></param>
        /// <param name="code">The code<see cref="string"/></param>
        /// <param name="progproj">The progproj<see cref="string"/></param>
        /// <param name="ppn">The ppn<see cref="string"/></param>
        /// <param name="npmcode">The npmcode<see cref="string"/></param>
        /// <param name="fromto">The fromto<see cref="string"/></param>
        /// <param name="boc">The boc<see cref="string"/></param>
        /// <param name="amount">The amount<see cref="decimal"/></param>
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
            Account = new Account(0, BFY, fund, code);
            FundCode = Account.FundCode;
            NpmCode = Account.NPM;
            FromTo = fromto;
            BOC = new BOC(boc);
            Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        public Transfer(DataRow dr)
        {
            TransId = int.Parse(dr["ID"].ToString());
            BudgetLevel = dr["BudgetLevel"].ToString();
            DocType = dr["DocType"].ToString();
            RPIO = dr["RPIO"].ToString();
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["FundCode"].ToString(), BFY);
            TCN = dr["TCN"].ToString();
            Qtr = dr["Qtr"].ToString();
            Date = dr["Date"].ToString();
            Code = dr["Code"].ToString();
            Account = new Account(Provider.SQLite, BFY, Fund.Code, Code);
            FundCode = Account.FundCode;
            NpmCode = Account.NPM;
            FromTo = dr["FromTo"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            Amount = decimal.Parse(dr["Amount"].ToString());
        }

        // PROPERTIES
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets the TransId
        /// </summary>
        public int TransId { get; }

        /// <summary>
        /// Gets the DbRow
        /// </summary>
        public DataRow DbRow { get; }

        /// <summary>
        /// Gets the Account
        /// </summary>
        public Account Account { get; }

        /// <summary>
        /// Gets the Amount
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// Gets the BFY
        /// </summary>
        public string BFY { get; }

        /// <summary>
        /// Gets the BOC
        /// </summary>
        public BOC BOC { get; }

        /// <summary>
        /// Gets the BudgetLevel
        /// </summary>
        public string BudgetLevel { get; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the Date
        /// </summary>
        public string Date { get; }

        /// <summary>
        /// Gets the DocType
        /// </summary>
        public string DocType { get; }

        /// <summary>
        /// Gets the FromTo
        /// </summary>
        public string FromTo { get; }

        /// <summary>
        /// Gets the Fund
        /// </summary>
        public Fund Fund { get; }

        /// <summary>
        /// Gets the FundCode
        /// </summary>
        public string FundCode { get; }

        /// <summary>
        /// Gets the NpmCode
        /// </summary>
        public string NpmCode { get; }

        /// <summary>
        /// Gets the Org
        /// </summary>
        public Org Org { get; }

        /// <summary>
        /// Gets the Qtr
        /// </summary>
        public string Qtr { get; }

        /// <summary>
        /// Gets the RC
        /// </summary>
        public RC RC { get; }

        /// <summary>
        /// Gets the RPIO
        /// </summary>
        public string RPIO { get; }

        /// <summary>
        /// Gets the TCN
        /// </summary>
        public string TCN { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return TCN;
        }

        /// <summary>
        /// Selects the specified source.
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
        public static Transfer Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Transfer(datarow);
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
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.DeleteCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.DeleteCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.DeleteCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.DeleteCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Deletes the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.DeleteCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.DeleteCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
