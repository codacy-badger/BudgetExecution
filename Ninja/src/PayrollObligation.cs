// <copyright file="PayrollObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="PayrollObligation" />
    /// </summary>
    public class PayrollObligation : IDataBuilder
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollObligation"/> class.
        /// </summary>
        public PayrollObligation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollObligation"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        public PayrollObligation(Source source = Source.PayrollObligations, Provider provider = Provider.SQLite, Sql sql = Sql.SELECT)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.PayrollObligations, Provider);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollObligation"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollObligation"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
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
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

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
        /// Gets or sets the TreasurySymbol
        /// </summary>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the AH
        /// </summary>
        public string AH { get; set; }

        /// <summary>
        /// Gets or sets the AhName
        /// </summary>
        public string AhName { get; set; }

        /// <summary>
        /// Gets or sets the OrgName
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// Gets the Obligations
        /// </summary>
        public decimal Obligations { get; }

        /// <summary>
        /// Gets the BFY
        /// </summary>
        public string BFY { get; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the Fund
        /// </summary>
        public Fund Fund { get; }

        /// <summary>
        /// Gets or sets the FundCode
        /// </summary>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the FOC
        /// </summary>
        public string FOC { get; set; }

        /// <summary>
        /// Gets or sets the FocName
        /// </summary>
        public string FocName { get; set; }

        /// <summary>
        /// Gets the Hours
        /// </summary>
        public decimal Hours { get; }

        /// <summary>
        /// Gets the HrOrgCode
        /// </summary>
        public string HrOrgCode { get; }

        /// <summary>
        /// Gets the Org
        /// </summary>
        public Org Org { get; }

        /// <summary>
        /// Gets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; }

        /// <summary>
        /// Gets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; }

        /// <summary>
        /// Gets the RC
        /// </summary>
        public RC RC { get; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets the RPIO
        /// </summary>
        public string RPIO { get; }

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
                return DbData.ProgramElements;
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
                Query query = new Query(Source.PayrollObligations, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.PayrollObligations, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.PayrollObligations, provider, Sql.INSERT, p);
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
