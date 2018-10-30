// <copyright file="PayrollObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

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
            DbRow = DbData.Table.AsEnumerable().Select(prc => prc).First();
            RPIO = DbRow["RPIO"].ToString();
            BFY = DbRow["BFY "].ToString();
            Fund = new Fund(DbRow["Fund"].ToString(), BFY);
            Org = new Org(DbRow["Org"].ToString());
            OrgName = Org.Name;
            RC = new RC(DbRow["RC"].ToString());
            Code = DbRow["Code"].ToString();
            ProgramProjectCode = DbRow["ProgramProjectCode"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            HrOrgCode = DbRow["HrOrgCode"].ToString();
            WorkCode = DbRow["WorkCode"].ToString();
            WorkCodeName = DbRow["WorkCodeName"].ToString();
            PayPeriod = DbRow["PayPeriod"].ToString();
            Obligations = decimal.Parse(DbRow["Obligations"].ToString());
            Hours = decimal.Parse(DbRow["Hours"].ToString());
        }

        public PayrollObligation(DataRow dr)
        {
            RPIO = dr["RPIO"].ToString();
            BFY = dr["BFY "].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            Code = dr["Code"].ToString();
            ProgramProjectCode = dr["ProgramProjectCode"].ToString();
            ProgramProjectName = dr["ProgramProjectName"].ToString();
            HrOrgCode = dr["HrOrgCode"].ToString();
            WorkCode = dr["WorkCode"].ToString();
            WorkCodeName = dr["WorkCodeName"].ToString();
            PayPeriod = dr["PayPeriod"].ToString();
            Amount = decimal.Parse(dr["Amount"].ToString());
            Hours = decimal.Parse(dr["Hours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Sql Sql { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public string TreasurySymbol { get; set; }

        public string AH { get; set; }

        public string AhName { get; set; }

        public string OrgName { get; set; }

        public decimal Amount { get; }

        public string BFY { get; }

        public string Code { get; }

        public Fund Fund { get; }

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

        public decimal Obligations { get; set; }

        public string WorkCodeName { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code, ["BFY"] = bfy };
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
