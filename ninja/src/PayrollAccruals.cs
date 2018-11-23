// <copyright file="PayrollAccruals.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class PayrollAccruals
    {
        // CONSTRUCTORS
        public PayrollAccruals()
        {
        }

        public PayrollAccruals(Source source = Source.PayAccruals, Provider provider = Provider.SQLite, Sql sql = Sql.SELECT)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayAccruals, Provider);
        }

        public PayrollAccruals(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider, p);
            Table = DbData.Table;
            Data = DbData.Table.AsEnumerable().Select(prc => prc).First();
            ID = int.Parse(Data["ID"].ToString());
            FirstName = Data["FirstName"].ToString();
            EmployeeID = Data["EmployeeID"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            StartDate = Data["StartDate"].ToString();
            EndDate = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            HrOrgCode = Data["HrOrgCode"].ToString();
            WorkCode = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Hours = decimal.Parse(Data["Hours"].ToString());
        }

        public PayrollAccruals(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            FirstName = Data["FirstName"].ToString();
            EmployeeID = Data["EmployeeID"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            StartDate = Data["StartDate"].ToString();
            EndDate = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            HrOrgCode = Data["HrOrgCode"].ToString();
            WorkCode = Data["WorkCode"].ToString();
            ReportingCodeName = Data["ReportingCodeName"].ToString();
            ReportingCode = Data["ReportingCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            HrOrgCodeName = Data["HrOrgCodeName"].ToString();
            Hours = decimal.Parse(Data["Hours"].ToString());
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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmployeeID { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string ReportingCode { get; set; }

        public string ReportingCodeName { get; set; }

        public string ApprovalDate { get; set; }

        public decimal Hours { get; }

        public string HrOrgCode { get; }

        public string HrOrgCodeName { get; set; }

        public string ProgramProjectCode { get; }

        public string ProgramProjectName { get; }

        public string DivisionName { get; set; }

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

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PayAccruals, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.PayAccruals, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.PayAccruals, provider, Sql.INSERT, p);
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
