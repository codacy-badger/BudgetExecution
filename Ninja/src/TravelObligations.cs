// <copyright file="TravelObligations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    // CONSTRUCTORS
    public class TravelObligations
    {
        public TravelObligations()
        {
        }

        public TravelObligations(Source source = Source.TravelObligations, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        public TravelObligations(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Sql Sql { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow[] Records { get; set; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public string RPIO { get; set; }

        public string BFY { get; set; }

        public string AH { get; set; }

        public string AllowanceHolderName { get; set; }

        public string RC { get; set; }

        public string DivisionName { get; set; }

        public string Org { get; set; }

        public string OrgName { get; set; }

        public string NPM { get; set; }

        public string NpmName { get; set; }

        public string Code { get; set; }

        public string ProgramProjectCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string ProgramAreaName { get; set; }

        public string SiteProjectCode { get; set; }

        public string SiteSpillID { get; set; }

        public string TravelStartDate { get; set; }

        public string TravelType { get; set; }

        public string TicketNumber { get; set; }

        public string DateProcessed { get; set; }

        public string TravellerName { get; set; }

        public string ModificationDate { get; set; }

        public string DCN { get; set; }

        public string Destination { get; set; }

        public string TravelAuthorizationNumber { get; set; }

        public string SiteProjectName { get; set; }

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
