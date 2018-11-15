// <copyright file="Awards.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class Awards
    {
        // CONSTRUCTORS
        public Awards()
        {
        }

        public Awards(Source source = Source.Awards, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(source, provider).Table;
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        public Awards(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(source, provider, p).GetDataTable();
            Records = Table.AsEnumerable().Select(r => r).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Type = Data["Type"].ToString();
                RC = Data["RC"].ToString();
                DivisionName = Data["DivisionName"].ToString();
                FundCode = Data["FundCode"].ToString();
                BFY = Data["BFY"].ToString();
                Amount = decimal.Parse(Data["Amount"].ToString());
            }
        }

        public Awards(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Type = Data["Type"].ToString();
            RC = Data["RC"].ToString();
            DivisionName = Data["DivisionName"].ToString();
            FundCode = Data["FundCode"].ToString();
            BFY = Data["BFY"].ToString();
            Amount = decimal.Parse(Data["Amount"].ToString());
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public int ID { get; set; }

        public string Type { get; set; }

        public string RC { get; set; }

        public string DivisionName { get; set; }

        public string FundCode { get; set; }

        public string BFY { get; set; }

        public string BOC { get; set; }

        public decimal Amount { get; set; }

        // METHODS

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
