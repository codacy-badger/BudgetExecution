// <copyright file="Awards.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Awards" />
    /// </summary>
    public class Awards
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        public Awards()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Awards(Provider provider = Provider.SQLite)
        {
            Source = Source.Awards;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public Awards(Provider provider, Dictionary<string, object> p)
        {
            Source = Source.Awards;
            Provider = provider;
            Table = new DataBuilder(Source, Provider, p).GetDataTable();
            Records = Table.AsEnumerable().Select(r => r).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Type = Data["Type"].ToString();
                RC = Data["RC"].ToString();
                DivisionName = Data["DivisionName"].ToString();
                FundCode = Data["FundCode"].ToString();
                BFY = Data["BFY"].ToString();
                Amount = decimal.Parse(Data["Amount"].ToString());
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public Awards(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Type = Data["Type"].ToString();
            RC = Data["RC"].ToString();
            DivisionName = Data["DivisionName"].ToString();
            FundCode = Data["FundCode"].ToString();
            BFY = Data["BFY"].ToString();
            Amount = decimal.Parse(Data["Amount"].ToString());
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
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public string RC { get; set; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets or sets the FundCode
        /// </summary>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public string BOC { get; set; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        // METHODS
        /// <summary>
        /// The Insert
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Awards, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.InsertCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Awards, provider, Sql.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Awards, provider, Sql.DELETE, p);
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
