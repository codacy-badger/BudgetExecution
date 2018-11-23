// <copyright file="Fund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Fund : IFund
    {
        // CONSTRUCTORS
        public Fund()
        {
        }

        public Fund(Provider provider = Provider.SQLite)
        {
            Source = Source.Funds;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
        }

        public Fund(string code, string bfy) : this(Provider.SQLite)
        {
            Code = code;
            BFY = bfy;
            Parameter = GetParameter(Code, BFY);
            Table = GetData(Source, Provider, Parameter);
            Data = Table.AsEnumerable().Select(prc => prc).Single();
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(Source source, string code, string bfy)
        {
            Code = code;
            BFY = bfy;
            Parameter = GetParameter(Code, BFY);
            Table = GetData(source, Provider.SQLite, Parameter);
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(prc => prc).Single();
                ID = int.Parse(Data["ID"].ToString());
                Name = Data["Name"].ToString();
                Title = Data["Title"].ToString();
                TreasurySymbol = Data["TreasurySymbol"].ToString();
            }
        }

        public Fund(Source source, Provider provider, Dictionary<string, object> p)
        {
            Code = p["Code"].ToString();
            BFY = p["BFY"].ToString();
            Parameter = GetParameter(Code, BFY);
            Table = GetData(source, provider, Parameter);
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(prc => prc).Single();
                ID = int.Parse(Data["ID"].ToString());
                Name = Data["Name"].ToString();
                Title = Data["Title"].ToString();
                TreasurySymbol = Data["TreasurySymbol"].ToString();
            }
        }

        public Fund(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
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

        public string Code { get; }

        public string BFY { get; }

        public Dictionary<string, object> Parameter { get; }

        public string Name { get; }

        public string Title { get; }

        public string TreasurySymbol { get; }

        // METHODS
        /// <summary>
        ///     Gets the data fields.
        /// </summary>
        /// <param name="fundcode">The code.</param>
        /// <param name="bfy">The bfy.</param>
        /// <returns></returns>
        public Dictionary<string, object> GetParameter(string fundcode, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = fundcode, ["FiscalYear"] = bfy };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the fund data.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public Dictionary<string, object> GetFundData(string code)
        {
            try
            {
                GetData(Source.Funds, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public DataTable GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataBuilder data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        ///     Gets the insertion columns.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static string[] GetColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(source, provider, param).Columns;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Fund Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Fund Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Funds, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.Funds, provider, Sql.UPDATE, p);
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
                Query query = new Query(Source.Funds, provider, Sql.DELETE, p);
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
