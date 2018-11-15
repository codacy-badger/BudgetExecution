﻿// <copyright file="PayrollObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class PayrollObligation
    {
        // CONSTRUCTORS
        public PayrollObligation()
        {
        }

        public PayrollObligation(Source source = Source.PayrollObligations, Provider provider = Provider.SQLite, Sql sql = Sql.SELECT)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider);
        }

        public PayrollObligation(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider, p);
            Table = DbData.Table;
            Data = DbData.Table.AsEnumerable().Select(prc => prc).First();
            RPIO = Data["RPIO"].ToString();
            BFY = Data["BFY "].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            Org = new Org(Data["Org"].ToString());
            OrgName = Org.Name;
            RC = new RC(Data["RC"].ToString());
            Code = Data["Code"].ToString();
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            HrOrgCode = Data["HrOrgCode"].ToString();
            WorkCode = Data["WorkCode"].ToString();
            WorkCodeName = Data["WorkCodeName"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            Hours = decimal.Parse(Data["Hours"].ToString());
        }

        public PayrollObligation(DataRow dr)
        {
            Data = dr;
            RPIO = Data["RPIO"].ToString();
            BFY = Data["BFY "].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            Code = Data["Code"].ToString();
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            HrOrgCode = Data["HrOrgCode"].ToString();
            WorkCode = Data["WorkCode"].ToString();
            WorkCodeName = Data["WorkCodeName"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            Hours = decimal.Parse(Data["Hours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Sql Sql { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow Data { get; }

        public int ID { get; set; }

        public string TreasurySymbol { get; set; }

        public string AH { get; set; }

        public string AhName { get; set; }

        public string OrgName { get; set; }

        public decimal Obligations { get; }

        public string BFY { get; }

        public string Code { get; }

        public Fund Fund { get; }

        public string FundCode { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public decimal Hours { get; }

        public string HrOrgCode { get; }

        public Org Org { get; }

        public string ProgramProjectCode { get; }

        public string ProgramProjectName { get; }

        public RC RC { get; }

        public string DivisionName { get; set; }

        public string RPIO { get; }

        public string WorkCode { get; }

        public string PayPeriod { get; set; }

        public string WorkCodeName { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code, ["BFY"] = bfy };
            }
            catch(Exception ex)
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
