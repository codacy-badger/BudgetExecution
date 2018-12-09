// <copyright file="PayrollObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class PayrollObligation : IDataBuilder
    {
        // CONSTRUCTORS
        public PayrollObligation()
        {
            Source = Source.PayrollObligations;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public PayrollObligation(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
        }

        public PayrollObligation(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
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

        public PayrollObligation(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
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

        public PayrollObligation(DataRow dr) : this()
        {
            Data = dr;
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

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PayrollObligations, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.PayrollObligations, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.PayrollObligations, provider, SQL.INSERT, p);
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
