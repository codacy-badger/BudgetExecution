// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class Employee : IEmployee
    {
        // CONSTRUCTORS
        public Employee()
        {
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        public Employee(Source source = Source.Personnel, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        public Employee(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(a => a).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(r => r).Single();
                Section = Data["Section"].ToString();
                FirstName = Data["FirstName"].ToString();
                LastName = Data["LastName"].ToString();
                Office = Data["Office"].ToString();
                Phone = Data["Phone"].ToString();
                Cell = Data["Cell"].ToString();
                Email = Data["Email"].ToString();
                Status = Data["Status"].ToString();
                RC = new RC(Data["RC"].ToString());
                Division = new Division(source);
            }
        }

        public Employee(DataRow data)
        {
            Data = data;
            Section = Data["Section"].ToString();
            FirstName = Data["FirstName"].ToString();
            LastName = Data["LastName"].ToString();
            Office = Data["Office"].ToString();
            Phone = Data["Phone"].ToString();
            Cell = Data["Cell"].ToString();
            Email = Data["Email"].ToString();
            Status = Data["Status"].ToString();
            RC = new RC(Data["RC"].ToString());
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public int ID { get; set; }

        public string Section { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Division Division { get; set; }

        public RC RC { get; set; }

        public string Office { get; set; }

        public string Phone { get; set; }

        public string Cell { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
