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

        public Division(Source source = Source.Divisions, Provider provider = Provider.SQLite)
        {
            DbData = new DataBuilder(source, provider);
            Records = DbData.Table.AsEnumerable().Select(p => p).ToArray();
        }

        public Division(Source source, Provider provider, Dictionary<string, object> p)
        {
            DbData = new DataBuilder(source, provider, p);
            Records = DbData.Table.AsEnumerable().Select(r => r).ToArray();
            if (DbData.Table.Rows.Count == 1)
            {
                Data = DbData.Table.AsEnumerable()
                             .Where(d => d.Field<string>("Source").Equals(source.ToString(), StringComparison.CurrentCultureIgnoreCase))
                             .Select(d => d).First();
                ID = Data["ID"].ToString();
                RC = Data["RC"].ToString();
                Title = Data["Title"].ToString();
                Code = Data["Code"].ToString();
                Name = Data["Name"].ToString();
            }
        }

        public Division(DataRow data)
        {
            Data = data;
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public string Title { get; set; }

        public string Code { get; }

        public string ID { get; }

        public string RC { get; }

        public string Name { get; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.InsertCommand;
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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.UpdateCommand;
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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.DeleteCommand;
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
