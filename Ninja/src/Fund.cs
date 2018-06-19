﻿// <copyright file="Fund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public class Fund : IFund
    {
        private Source Source;
        private Provider Provider;

        // CONSTRUCTORS
        public Fund()
        {
        }
        public Fund(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
        }

        public Fund(string code, string bfy) : this(Source.Funds, Provider.SQLite)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetFundParameter(Code, FiscalYear);
            Table = GetData(Source, Provider, Parameter);
            Data = Table.Rows[0];
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(Source source, Provider provider, string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetFundParameter(Code, FiscalYear);
            Table = GetData(Source.Funds, Provider.SQLite, Parameter);
            Data = Table.AsEnumerable().First();
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
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
        public int ID { get; set; }

        public string Code { get; }

        public string FiscalYear { get; }

        public Dictionary<string, object> Parameter { get; }

        public string Name { get; }

        public string Title { get; }

        public string TreasurySymbol { get; }

        public DataTable Table { get; set; }

        public DataRow Data { get; set; }

        // METHODS
        public Dictionary<string, object> GetFundParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["FiscalYear"] = bfy };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public Dictionary<string, object> GetFundProgramData(string code)
        {
            try
            {
                var dr = GetData(Source.Funds, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public DataTable GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}