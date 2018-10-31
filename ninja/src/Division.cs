// <copyright file="Division.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Division
    {
        // CONSTRUCTORS
        public Division()
        {
        }

        public Division(Source source)
        {
            Name = source.ToString();
            Data = new DataBuilder(source).Table.AsEnumerable().Where(d => d.Field<string>("Source").Equals(source.ToString())).Select(d => d).First();
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        public Division(Dictionary<string, object> p)
        {
            Data = new DataBuilder(Source.Divisions, Provider.SQLite, p).Table.AsEnumerable().Where(d => d.Field<string>("Source").Equals(Source.Divisions.ToString())).Select(d => d).First();
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        // PROPERTIES
        public string Title { get; set; }

        public string Code { get; }

        public string ID { get; }

        public string RC { get; }

        public string Name { get; }

        public DataRow Data { get; set; }

        // METHODS
        public override string ToString()
        {
            return Code;
        }

        private Dictionary<string, object> GetParameter()
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = Code };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
