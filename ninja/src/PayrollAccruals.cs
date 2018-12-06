// <copyright file="PayrollAccruals.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class PayrollAccruals : IDataBuilder
    {
        // CONSTRUCTORS
        public PayrollAccruals()
        {
            Source = Source.PayAccruals;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public PayrollAccruals(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
        }

        public PayrollAccruals(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
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
        }

        public PayrollAccruals(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
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
        }

        public PayrollAccruals(DataRow data) : this()
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
            PayPeriod = Data["PayPeriod"].ToString();
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
                Query query = new Query(Source.PayAccruals, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.PayAccruals, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.PayAccruals, provider, SQL.INSERT, p);
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
