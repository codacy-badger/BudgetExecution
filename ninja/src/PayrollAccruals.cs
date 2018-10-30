// <copyright file="PayrollAccruals.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class PayrollAccruals
    {
        // CONSTRUCTORS
        public PayrollAccruals()
        {
        }

        public PayrollAccruals(Source source = Source.PayrollObligations, Provider provider = Provider.SQLite, Sql sql = Sql.SELECT)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider);
        }

        public PayrollAccruals(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider, p);
            Table = DbData.Table;
            DbRow = DbData.Table.AsEnumerable().Select(prc => prc).First();
            ID = int.Parse(DbRow["ID"].ToString());
            FirstName = DbRow["FirstName"].ToString();
            EmployeeID = DbRow["EmployeeID"].ToString();
            PayPeriod = DbRow["PayPeriod"].ToString();
            StartDate = DbRow["StartDate"].ToString();
            EndDate = DbRow["EndDate"].ToString();
            ApprovalDate = DbRow["ApprovalDate"].ToString();
            ProgramProjectCode = DbRow["ProgramProjectCode"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            HrOrgCode = DbRow["HrOrgCode"].ToString();
            WorkCode = DbRow["WorkCode"].ToString();
            PayPeriod = DbRow["PayPeriod"].ToString();
            Hours = decimal.Parse(DbRow["Hours"].ToString());
        }

        public PayrollAccruals(DataRow DbRow)
        {
            ID = int.Parse(DbRow["ID"].ToString());
            FirstName = DbRow["FirstName"].ToString();
            EmployeeID = DbRow["EmployeeID"].ToString();
            PayPeriod = DbRow["PayPeriod"].ToString();
            StartDate = DbRow["StartDate"].ToString();
            EndDate = DbRow["EndDate"].ToString();
            ApprovalDate = DbRow["ApprovalDate"].ToString();
            ProgramProjectCode = DbRow["ProgramProjectCode"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            HrOrgCode = DbRow["HrOrgCode"].ToString();
            WorkCode = DbRow["WorkCode"].ToString();
            ReportingCodeName = DbRow["ReportingCodeName"].ToString();
            ReportingCode = DbRow["ReportingCode"].ToString();
            PayPeriod = DbRow["PayPeriod"].ToString();
            HrOrgCodeName = DbRow["HrOrgCodeName"].ToString();
            Hours = decimal.Parse(DbRow["Hours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow DbRow { get; }

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
