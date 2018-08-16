// <copyright file="PayrollObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Linq;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class PayrollObligation
    {
        // CONSTRUCTORS
        public PayrollObligation()
        {
        }

        public PayrollObligation(string rpio, string bfy, string fund, string org, string rc, string code, string progproj, string progprojname, string hoc, string wc, string wcn, decimal amount, decimal ybp, double ybh, decimal yotp, double yoth)
        {
            RPIO = rpio;
            BFY = bfy;
            Fund = new Fund(fund, bfy);
            Org = new Org(org);
            RC = new RC(rc);
            Code = code;
            ProgramProjectCode = progproj;
            ProgramProjectName = progprojname;
            HrOrgCode = hoc;
            WorkCode = wc;
            WorkCodeName = wcn;
            Amount = amount;
            Hours = ybh;
            YearBasePay = ybp;
            YearBaseHours = ybh;
            YearOverTimePay = yotp;
            YearOverTimeHours = yoth;
        }

        public PayrollObligation(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            DbTable = DbData.DbTable;
            DbRow = DbTable.AsEnumerable().Select(prc => prc).First();
            RPIO = DbRow["RPIO"].ToString();
            BFY = DbRow["BFY "].ToString();
            Fund = new Fund(DbRow["Fund"].ToString(), BFY);
            Org = new Org(DbRow["Org"].ToString());
            RC = new RC(DbRow["RC"].ToString());
            Code = DbRow["Code"].ToString();
            ProgramProjectCode = DbRow["ProgramProjectCode"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            HrOrgCode = DbRow["HrOrgCode"].ToString();
            WorkCode = DbRow["WorkCode"].ToString();
            WorkCodeName = DbRow["WorkCodeName"].ToString();
            Amount = decimal.Parse(DbRow["Amount"].ToString());
            Hours = double.Parse(DbRow["Hours"].ToString());
            YearBasePay = decimal.Parse(DbRow["YearBasePay"].ToString());
            YearBaseHours = double.Parse(DbRow["YearBaseHours"].ToString());
            YearOverTimePay = decimal.Parse(DbRow["YearOverTimePay"].ToString());
            YearOverTimeHours = double.Parse(DbRow["YearOverTimeHours"].ToString());
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
            Amount = decimal.Parse(dr["Amount"].ToString());
            Hours = double.Parse(dr["Hours"].ToString());
            YearBasePay = decimal.Parse(dr["YearBasePay"].ToString());
            YearBaseHours = double.Parse(dr["YearBaseHours"].ToString());
            YearOverTimePay = decimal.Parse(dr["YearOverTimePay"].ToString());
            YearOverTimeHours = double.Parse(dr["YearOverTimeHours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public decimal Amount { get; }

        public string BFY { get; }

        public string Code { get; }

        public Fund Fund { get; }

        public double Hours { get; }

        public string HrOrgCode { get; }

        public Org Org { get; }

        public string ProgramProjectCode { get; }

        public string ProgramProjectName { get; }

        public RC RC { get; }

        public string RPIO { get; }

        public string WorkCode { get; }

        public string WorkCodeName { get; }

        public double YearBaseHours { get; }

        public decimal YearBasePay { get; }

        public double YearOverTimeHours { get; }

        public decimal YearOverTimePay { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["BFY"] = bfy };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}