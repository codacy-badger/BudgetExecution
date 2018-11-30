// <copyright file="Transfer.cs" company="PlaceholderCompany">
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
    public class Transfer : IDataBuilder
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
            Data = Table.AsEnumerable().Select(t => t).First();
            TransId = int.Parse(Data["ID"].ToString());
            BudgetLevel = Data["BudgetLevel"].ToString();
            DocType = Data["DocType"].ToString();
            RPIO = Data["RPIO"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            TCN = Data["TCN"].ToString();
            Qtr = Data["Qtr"].ToString();
            Date = Data["Date"].ToString();
            Code = Data["Code"].ToString();
            Account = new Account(Provider.SQLite, BFY, Fund.Code, Code);
            FundCode = Account.FundCode;
            NpmCode = Account.NPM;
            FromTo = Data["FromTo"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            Amount = decimal.Parse(Data["Amount"].ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Transfer(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
        }

        public Transfer(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
        }

        public Transfer(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        public Transfer(DataRow dr) : this()
        {
            Data = dr;
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

        public Dictionary<string, object> Input { get; }

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

        // METHODS

        /// <inheritdoc />
        /// <summary>
        /// Explicit implementation of the IDataBuilder method 
        /// Gets the primary data source using the DbData attribute.
        /// </summary>
        /// <returns></returns>
        DataTable IDataBuilder.GetDataTable()
        {
            try
            {
                return new DataBuilder(Source, Provider).Table;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// 
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Collections.Generic.Dictionary`2" /></returns>
        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
        {
            try
            {
                return DbData.ProgramElements;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
        DataRow[] IDataBuilder.GetRecords(DataTable table)
        {
            try
            {
                return DbData.Records;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        string[] IDataBuilder.GetUniqueValues(DataTable table, string col)
        {
            try
            {
                return DbData.GetUniqueValues(table, col);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

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
