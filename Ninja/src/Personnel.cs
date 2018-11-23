﻿// <copyright file="Personnel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public class Personnel
    {
        // CONSTRUCTORS
        public Personnel(DataRow dbRow)
        {
            DbRow = dbRow;
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source);
            DbTable = DbData.Table;
        }

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

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; set; }

        public DataRow DbRow { get; set; }

        public int ID { get; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string MailCode { get; set; }

        public string Office { get; set; }

        public string LastName { get; set; }

        public double Phone { get; set; }

        public string Cell { get; set; }

        public string WorkCode { get; set; }

        public string Contractor { get; set; }

        /// <summary>
        ///     Inserts the specified source.
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
        ///     Updates the specified source.
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
        ///     Deletes the specified source.
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
