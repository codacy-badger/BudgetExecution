// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Employee : IEmployee
    {
        // CONSTRUCTORS
        public Employee()
        {
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Employee(Source source = Source.Personnel, Provider provider = Provider.SQLite) : this()
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Employee(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                Section = Data["Section"].ToString();
                FirstName = Data["FirstName"].ToString();
                LastName = Data["LastName"].ToString();
                Office = Data["Office"].ToString();
                Phone = Data["Phone"].ToString();
                Cell = Data["Cell"].ToString();
                Email = Data["Email"].ToString();
                Status = Data["Status"].ToString();
                RC = new RC(Data["RC"].ToString());
                Division = new Division(Source);
            }
        }

        public Employee(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                Section = Data["Section"].ToString();
                FirstName = Data["FirstName"].ToString();
                LastName = Data["LastName"].ToString();
                Office = Data["Office"].ToString();
                Phone = Data["Phone"].ToString();
                Cell = Data["Cell"].ToString();
                Email = Data["Email"].ToString();
                Status = Data["Status"].ToString();
                RC = new RC(Data["RC"].ToString());
                Division = new Division(Source); 
            }
        }

        public Employee(DataRow data) : this()
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
            Division = new Division(Source);
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

        public Dictionary<string, object> Input { get; }

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

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, SQL.INSERT, p);
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

        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, SQL.UPDATE, p);
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

        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Personnel, provider, SQL.DELETE, p);
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
