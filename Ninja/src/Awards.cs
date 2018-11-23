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

        public Awards(Provider provider = Provider.SQLite)
        {
            Source = Source.Awards;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        public Awards(Provider provider, Dictionary<string, object> p)
        {
            Source = Source.Awards;
            Provider = provider;
            Table = new DataBuilder(Source, Provider, p).GetDataTable();
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

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public int ID { get; set; }

        public string Type { get; set; }

        public string RC { get; set; }

        public string DivisionName { get; set; }

        public string FundCode { get; set; }

        public string BFY { get; set; }

        public string BOC { get; set; }

        public decimal Amount { get; set; }

        // METHODS

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Awards, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.Awards, provider, Sql.UPDATE, p);
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
                Query query = new Query(Source.Awards, provider, Sql.DELETE, p);
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
