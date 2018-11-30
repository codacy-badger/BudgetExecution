// <copyright file="BudgetLevel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Utilization" />
    /// </summary>
    public class Utilization : IDataBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Utilization"/> class.
        /// </summary>
        public Utilization()
        {
            Source = Source.Utilization;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = Table.AsEnumerable().Select(p => p).ToArray();
            Data = Table.AsEnumerable().Select(p => p).First();
            ID = int.Parse(Data["ID"].ToString());
            RPIO = Data["RPIO "].ToString();
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["Fund"].ToString(), BFY);
            AH = Data["AH"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            FOC = Data["FOC"].ToString();
            FocName = Data["FocName"].ToString();
            Authority = decimal.Parse(Data["Authority"].ToString());
            Budgeted = decimal.Parse(Data["Budgeted"].ToString());
            Posted = decimal.Parse(Data["Posted"].ToString());
            CarryIn = decimal.Parse(Data["CarryIn"].ToString());
            CarryOut = decimal.Parse(Data["CarryOut"].ToString());
            Commitments = decimal.Parse(Data["Commitments"].ToString());
            OpenCommitments = decimal.Parse(Data["OpenCommitments"].ToString());
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            ULO = decimal.Parse(Data["ULO"].ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Utilization"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public Utilization(Provider provider, Dictionary<string, object> param) : this()
        {
            Provider = provider;
            Input = param;
            DbData = new DataBuilder(Source, provider, Input);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Utilization"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        public Utilization(DataRow dr) : this()
        {
            Data = dr;
        }

        // Properties
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
        /// Gets or sets the AH
        /// </summary>
        public string AH { get; set; }

        /// <summary>
        /// Gets or sets the AhName
        /// </summary>
        public string AhName { get; set; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the BudgetLevel
        /// </summary>
        public string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the BocName
        /// </summary>
        public string BocName { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the ProgramArea
        /// </summary>
        public string ProgramArea { get; set; }

        /// <summary>
        /// Gets or sets the ProgramAreaName
        /// </summary>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the FOC
        /// </summary>
        public string FOC { get; set; }

        /// <summary>
        /// Gets or sets the FocName
        /// </summary>
        public string FocName { get; set; }

        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        public Fund Fund { get; set; }

        /// <summary>
        /// Gets or sets the FundCode
        /// </summary>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the FundName
        /// </summary>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public Org Org { get; set; }

        /// <summary>
        /// Gets or sets the OrgName
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public RC RC { get; set; }

        /// <summary>
        /// Gets or sets the Division
        /// </summary>
        public string Division { get; set; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the Authority
        /// </summary>
        public decimal Authority { get; set; }

        /// <summary>
        /// Gets or sets the Budgeted
        /// </summary>
        public decimal Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the Posted
        /// </summary>
        public decimal Posted { get; set; }

        /// <summary>
        /// Gets or sets the CarryIn
        /// </summary>
        public decimal CarryIn { get; set; }

        /// <summary>
        /// Gets or sets the CarryOut
        /// </summary>
        public decimal CarryOut { get; set; }

        /// <summary>
        /// Gets or sets the Commitments
        /// </summary>
        public decimal Commitments { get; set; }

        /// <summary>
        /// Gets or sets the OpenCommitments
        /// </summary>
        public decimal OpenCommitments { get; set; }

        /// <summary>
        /// Gets or sets the Obligations
        /// </summary>
        public decimal Obligations { get; set; }

        /// <summary>
        /// Gets or sets the ULO
        /// </summary>
        public decimal ULO { get; set; }

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
        /// The GetDataFields
        /// </summary>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
        internal Dictionary<string, object> GetDataFields()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object> { ["ID"] = ID, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = ProgramProjectCode };
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        internal string[] GetFields()
        {
            try
            {
                Dictionary<string, object> prc = GetDataFields();

                return prc.Keys.ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetValues
        /// </summary>
        /// <returns>The <see cref="object[]"/></returns>
        internal object[] GetValues()
        {
            try
            {
                Dictionary<string, object> param = GetDataFields();
                return param.Values.ToArray();
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
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
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
