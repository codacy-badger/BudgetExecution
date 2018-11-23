// <copyright file="Transfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
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
            Account = new Account(0, BFY, fund, code);
            FundCode = Account.FundCode;
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
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

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

        public string FundCode { get; }

        public string NpmCode { get; }

        public Org Org { get; }

        public string Qtr { get; }

        public RC RC { get; }

        public string RPIO { get; }

        public string TCN { get; }

        // METHODS

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return TCN;
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Inserts the specified source.
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
        ///     Updates the specified source.
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
        ///     Deletes the specified source.
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
