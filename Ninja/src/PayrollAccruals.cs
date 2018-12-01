// <copyright file="PayrollAccruals.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="PayrollAccruals" />
    /// </summary>
    public class PayrollAccruals : IDataBuilder
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollAccruals"/> class.
        /// </summary>
        public PayrollAccruals()
        {
            Source = Source.PayAccruals;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollAccruals"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        public PayrollAccruals(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollAccruals"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public PayrollAccruals(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
        }

        public PayrollAccruals(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollAccruals"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public PayrollAccruals(DataRow data) : this()
        {
            Data = data;
        }

        // PROPERTIES
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

        public Dictionary<string, object> Input { get; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the EmployeeID
        /// </summary>
        public string EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the StartDate
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets the EndDate
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets the ReportingCode
        /// </summary>
        public string ReportingCode { get; set; }

        /// <summary>
        /// Gets or sets the ReportingCodeName
        /// </summary>
        public string ReportingCodeName { get; set; }

        /// <summary>
        /// Gets or sets the ApprovalDate
        /// </summary>
        public string ApprovalDate { get; set; }

        /// <summary>
        /// Gets the Hours
        /// </summary>
        public decimal Hours { get; }

        /// <summary>
        /// Gets the HrOrgCode
        /// </summary>
        public string HrOrgCode { get; }

        /// <summary>
        /// Gets or sets the HrOrgCodeName
        /// </summary>
        public string HrOrgCodeName { get; set; }

        /// <summary>
        /// Gets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; }

        /// <summary>
        /// Gets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets the WorkCode
        /// </summary>
        public string WorkCode { get; }

        /// <summary>
        /// Gets or sets the PayPeriod
        /// </summary>
        public string PayPeriod { get; set; }

        /// <summary>
        /// Gets the WorkCodeName
        /// </summary>
        public string WorkCodeName { get; }

        // METHODS
        /// <inheritdoc />
        /// <summary>
        /// Explicit implementation of the IDataBuilder method 
        /// Gets the primary data source using the DbData attribute.
        /// </summary>
        /// <returns></returns>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// 
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Collections.Generic.Dictionary`2" /></returns>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
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
        /// <summary>
        /// The GetParameter
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
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

        /// <summary>
        /// The Insert
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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
