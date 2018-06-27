// <copyright file="Reimbursable.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    public class Reimbursable
    {
        private Source Source;
        private Provider Provider;
        private DataTable Table;

        // CONSTRUCTORS
        public Reimbursable()
        {
        }
        public Reimbursable(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
        }


        public Reimbursable(string fund, string bfy, string org, string code, string an, decimal auth, decimal amout, decimal avail)
        {
            BFY = bfy;
            Fund = new Fund(fund, bfy);
            OrgCode = org;
            Account = new Account(fund, code);
            AgreementNumber = an;
            Authority = auth;
            Amount = amout;
            Available = avail;
        }

        public Reimbursable(DataRow dr)
        {
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            OrgCode = dr["OrgCode"].ToString();
            Account = new Account(dr["Fund"].ToString(), dr["Code"].ToString());
            AgreementNumber = dr["Agreement"].ToString();
            Authority = decimal.Parse(dr["Authority"].ToString());
            Amount = decimal.Parse(dr["Amount"].ToString());
            Available = decimal.Parse(dr["Available"].ToString());
        }

        // PROPERTIES
        public Account Account { get; }

        public string AgreementNumber { get; }

        public string SiteProjectCode { get; }

        public string OrgCode { get; }

        public string Code { get; }

        public BOC BOC { get; }

        public decimal Amount { get; }

        public decimal Authority { get; }

        public decimal Available { get; }

        public string BFY { get; }

        public DataBuilder Data { get; }

        public Fund Fund { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string bfy, string fund, string org, string code, string an)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["BFY"] = bfy, ["Fund"] = fund,
                    ["AgreementNumber"] = an, ["OrgCode"] = org };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                var account = new Account(source, Provider.SQLite, param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("Fund") || param["Fund"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProjectCode") || param["ProgramProjectCode"] == null)
                {
                    param["ProgramProjectCode"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective") || param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

    }
}