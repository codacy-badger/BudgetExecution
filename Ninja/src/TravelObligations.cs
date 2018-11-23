// <copyright file="TravelObligations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    // CONSTRUCTORS
    /// <summary>
    /// Defines the <see cref="TravelObligations" />
    /// </summary>
    public class TravelObligations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelObligations"/> class.
        /// </summary>
        public TravelObligations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelObligations"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public TravelObligations(Source source = Source.TravelObligations, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            Data = Records[0];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelObligations"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public TravelObligations(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            Data = Records[0];
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
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the AH
        /// </summary>
        public string AH { get; set; }

        /// <summary>
        /// Gets or sets the AllowanceHolderName
        /// </summary>
        public string AllowanceHolderName { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public string RC { get; set; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public string Org { get; set; }

        /// <summary>
        /// Gets or sets the OrgName
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the NPM
        /// </summary>
        public string NPM { get; set; }

        /// <summary>
        /// Gets or sets the NpmName
        /// </summary>
        public string NpmName { get; set; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the ProgramArea
        /// </summary>
        public string ProgramArea { get; set; }

        /// <summary>
        /// Gets or sets the ProgramAreaName
        /// </summary>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the SiteProjectCode
        /// </summary>
        public string SiteProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the SiteSpillID
        /// </summary>
        public string SiteSpillID { get; set; }

        /// <summary>
        /// Gets or sets the TravelStartDate
        /// </summary>
        public string TravelStartDate { get; set; }

        /// <summary>
        /// Gets or sets the TravelType
        /// </summary>
        public string TravelType { get; set; }

        /// <summary>
        /// Gets or sets the TicketNumber
        /// </summary>
        public string TicketNumber { get; set; }

        /// <summary>
        /// Gets or sets the DateProcessed
        /// </summary>
        public string DateProcessed { get; set; }

        /// <summary>
        /// Gets or sets the TravellerName
        /// </summary>
        public string TravellerName { get; set; }

        /// <summary>
        /// Gets or sets the ModificationDate
        /// </summary>
        public string ModificationDate { get; set; }

        /// <summary>
        /// Gets or sets the DCN
        /// </summary>
        public string DCN { get; set; }

        /// <summary>
        /// Gets or sets the Destination
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the TravelAuthorizationNumber
        /// </summary>
        public string TravelAuthorizationNumber { get; set; }

        /// <summary>
        /// Gets or sets the SiteProjectName
        /// </summary>
        public string SiteProjectName { get; set; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.TravelObligations, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.TravelObligations, provider, Sql.INSERT, p);
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
        /// The Delete
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.TravelObligations, provider, Sql.INSERT, p);
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
