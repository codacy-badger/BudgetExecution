// <copyright file="Division.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
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
            if(Records.Length == 1)
            {
                Data = DbData.Table.AsEnumerable()
                             .Where(d => d.Field<string>("Source").Equals(source.ToString(), StringComparison.CurrentCultureIgnoreCase))
                             .Select(d => d)
                             .Single();
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
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return RC;
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, object> GetParameter()
        {
            try
            {
                return new Dictionary<string, object> {["RC"] = RC};
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
                Query query = new Query(Source.Divisions, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.Divisions, provider, Sql.UPDATE, p);
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
                Query query = new Query(Source.Divisions, provider, Sql.DELETE, p);
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
