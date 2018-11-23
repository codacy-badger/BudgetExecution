// <copyright file="Personnel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Defines the <see cref="Personnel" />
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Personnel"/> class.
        /// </summary>
        /// <param name="dbRow">The dbRow<see cref="DataRow"/></param>
        public Personnel(DataRow dbRow)
        {
            DbRow = dbRow;
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source);
            DbTable = DbData.Table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Personnel"/> class.
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <param name="eid">The eid<see cref="string"/></param>
        /// <param name="hoc">The hoc<see cref="string"/></param>
        /// <param name="hon">The hon<see cref="string"/></param>
        /// <param name="wc">The wc<see cref="string"/></param>
        /// <param name="f">The f<see cref="string"/></param>
        /// <param name="l">The l<see cref="string"/></param>
        /// <param name="lvt">The lvt<see cref="string"/></param>
        /// <param name="leave">The leave<see cref="double"/></param>
        /// <param name="dbRow">The dbRow<see cref="DataRow"/></param>
        public Personnel(int id, string eid, string hoc, string hon, string wc, string f, string l, string lvt, double leave, DataRow dbRow)
        {
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source);
            DbTable = DbData.Table;
            ID = id;
            Email = eid;
            MailCode = hoc;
            Office = hon;
            WorkCode = wc;
            FirstName = f;
            LastName = l;
            Cell = lvt;
            Phone = leave;
            DbRow = dbRow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Personnel"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        /// <param name="dbRow">The dbRow<see cref="DataRow"/></param>
        public Personnel(DataRow dr, DataRow dbRow)
        {
            DbRow = dbRow;
            ID = int.Parse(dr["ID"].ToString());
            Email = dr["EmployId"].ToString();
            MailCode = dr["HrOrgCode"].ToString();
            Office = dr["HrOrgName"].ToString();
            WorkCode = dr["WorkCode"].ToString();
            FirstName = dr["First"].ToString();
            LastName = dr["Last"].ToString();
            Cell = dr["LeaveType"].ToString();
            Phone = double.Parse(dr["LeaveHours"].ToString());
        }

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
        /// Gets or sets the DbTable
        /// </summary>
        public DataTable DbTable { get; set; }

        /// <summary>
        /// Gets or sets the DbRow
        /// </summary>
        public DataRow DbRow { get; set; }

        /// <summary>
        /// Gets the ID
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the MailCode
        /// </summary>
        public string MailCode { get; set; }

        /// <summary>
        /// Gets or sets the Office
        /// </summary>
        public string Office { get; set; }

        /// <summary>
        /// Gets or sets the LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public double Phone { get; set; }

        /// <summary>
        /// Gets or sets the Cell
        /// </summary>
        public string Cell { get; set; }

        /// <summary>
        /// Gets or sets the WorkCode
        /// </summary>
        public string WorkCode { get; set; }

        /// <summary>
        /// Gets or sets the Contractor
        /// </summary>
        public string Contractor { get; set; }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, Sql.INSERT, p);
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
        /// Updates the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, Sql.UPDATE, p);
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
        /// Deletes the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, Sql.DELETE, p);
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
