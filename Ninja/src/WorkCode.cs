// <copyright file="WorkCode.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="WorkCode" />
    /// </summary>
    public class WorkCode
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkCode"/> class.
        /// </summary>
        public WorkCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkCode"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public WorkCode(Source source = Source.WorkCodes, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.WorkCodes, Provider);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkCode"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public WorkCode(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.WorkCodes, Provider, p);
            Table = DbData.Table;
            Data = DbData.Table.AsEnumerable().Select(prc => prc).First();
            ID = int.Parse(Data["ID"].ToString());
            PayPeriod = Data["PayPeriod"].ToString();
            BFY = Data["BFY"].ToString();
            Org = Data["StartDate"].ToString();
            FundCode = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            Project = Data["ProgramProjectCode"].ToString();
            Code = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Description = Data["FirstName"].ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkCode"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public WorkCode(DataRow data)
        {
            ID = int.Parse(data["ID"].ToString());
            PayPeriod = data["PayPeriod"].ToString();
            BFY = data["BFY"].ToString();
            Org = data["StartDate"].ToString();
            FundCode = data["FundCode"].ToString();
            ApprovalDate = data["ApprovalDate"].ToString();
            Project = data["ProgramProjectCode"].ToString();
            Code = data["WorkCode"].ToString();
            PayPeriod = data["PayPeriod"].ToString();
            Description = data["FirstName"].ToString();
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
        /// Gets or sets the ApprovalDate
        /// </summary>
        public string ApprovalDate { get; set; }

        /// <summary>
        /// Gets the Org
        /// </summary>
        public string Org { get; }

        /// <summary>
        /// Gets the FundCode
        /// </summary>
        public string FundCode { get; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets the Project
        /// </summary>
        public string Project { get; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets or sets the PayPeriod
        /// </summary>
        public string PayPeriod { get; set; }

        /// <summary>
        /// Gets the Description
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="bfy">The bfy.</param>
        /// <returns></returns>
        private Dictionary<string, object> GetParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code, ["BFY"] = bfy };
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
                Query query = new Query(Source.WorkCodes, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.WorkCodes, provider, Sql.UPDATE, p);
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
                Query query = new Query(Source.WorkCodes, provider, Sql.DELETE, p);
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
