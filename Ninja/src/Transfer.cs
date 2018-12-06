// <copyright file="Transfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Transfer : IDataBuilder
    {
        // CONSTRUCTORS
        public Transfer()
        {
            Source = Source.Transfers;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
        }

        public Transfer(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
        }

        public Transfer(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            Data = DbData.Data;
            TransId = int.Parse(Data["ID"].ToString());
            BudgetLevel = Data["BudgetLevel"].ToString();
            DocType = Data["DocType"].ToString();
            RPIO = Data["RPIO"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            TCN = Data["TCN"].ToString();
            Qtr = Data["Qtr"].ToString();
            Date = Data["Date"].ToString();
            Code = Data["Code"].ToString();
            Account = new Account(Provider.SQLite, BFY, Fund.Code, Code);
            FundCode = Account.FundCode;
            NpmCode = Account.NPM;
            FromTo = Data["FromTo"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            Amount = decimal.Parse(Data["Amount"].ToString());
        }

        public Transfer(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            Data = DbData.Data;
            TransId = int.Parse(Data["ID"].ToString());
            BudgetLevel = Data["BudgetLevel"].ToString();
            DocType = Data["DocType"].ToString();
            RPIO = Data["RPIO"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            TCN = Data["TCN"].ToString();
            Qtr = Data["Qtr"].ToString();
            Date = Data["Date"].ToString();
            Code = Data["Code"].ToString();
            Account = new Account(Provider.SQLite, BFY, Fund.Code, Code);
            FundCode = Account.FundCode;
            NpmCode = Account.NPM;
            FromTo = Data["FromTo"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            Amount = decimal.Parse(Data["Amount"].ToString());
        }

        public Transfer(DataRow dr) : this()
        {
            Data = dr;
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public Dictionary<string, object> Input { get; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public int TransId { get; }
        
        public Account Account { get; }

        public decimal Amount { get; }

        public string BFY { get; }

        public BOC BOC { get; }

        public string BudgetLevel { get; }

        public string Code { get; }

        public string Date { get; }

        public string DocType { get; }

        public string FromTo { get; }

        public Fund Fund { get; }

        public string FundCode { get; }

        public string NpmCode { get; }

        public Org Org { get; }

        public string Qtr { get; }

        public RC RC { get; }

        public string RPIO { get; }

        public string TCN { get; }

        // METHODS

        DataTable IDataBuilder.GetDataTable()
        {
            try
            {
                return new DataBuilder(Source, Provider).Table;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
        {
            try
            {
                return (Dictionary<string, string[]>)DbData.ProgramElements;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
        DataRow[] IDataBuilder.GetRecords(DataTable table)
        {
            try
            {
                return DbData.Records;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        string[] IDataBuilder.GetUniqueValues(DataTable table, string col)
        {
            try
            {
                return DbData.GetUniqueValues(table, col);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return TCN;
        }

        public static Transfer Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Transfer(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Transfer Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Transfer(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, SQL.INSERT, p);
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

        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, SQL.INSERT, p);
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

        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Transfers, provider, SQL.INSERT, p);
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
