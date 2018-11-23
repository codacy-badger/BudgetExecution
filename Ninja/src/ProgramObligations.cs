// <copyright file="ProgramObligations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="ProgramObligations" />
    /// </summary>
    public class ProgramObligations
    {
        // CONSRTUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramObligations"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public ProgramObligations(Provider provider = Provider.SQLite)
        {
            Source = Source.ProgramObligations;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramObligations"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public ProgramObligations(Provider provider, Dictionary<string, object> param)
        {
            Source = Source.ProgramObligations;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramObligations"/> class.
        /// </summary>
        /// <param name="dr">The dr<see cref="DataRow"/></param>
        public ProgramObligations(DataRow dr)
        {
            ID = int.Parse(dr["ID"].ToString());
            RPIO = dr["RPIO "].ToString();
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["FundCode"].ToString(), BFY);
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            ProgramProjectCode = dr["ProgramProjectCode"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            FOC = dr["FOC"].ToString();
            FocName = dr["FocName"].ToString();
            Obligations = decimal.Parse(dr["Obligations"].ToString());
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <summary>
        /// Gets the DbRow
        /// </summary>
        public DataRow DbRow { get; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the PRC
        /// </summary>
        public PRC PRC { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the DCN
        /// </summary>
        public string DCN { get; set; }

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
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public Org Org { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public RC RC { get; set; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the DollarAmount
        /// </summary>
        public decimal DollarAmount { get; set; }

        /// <summary>
        /// Gets or sets the OpenCommitments
        /// </summary>
        public decimal OpenCommitments { get; set; }

        /// <summary>
        /// Gets or sets the Obligations
        /// </summary>
        public decimal Obligations { get; set; }

        // METHODS
        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return DCN;
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <returns></returns>
        internal Dictionary<string, object> GetSchema()
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
        /// Gets the data.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal DataRow GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
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
        internal string[] GetColumnNames()
        {
            try
            {
                Dictionary<string, object> prc = GetSchema();

                return prc.Keys.ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns></returns>
        internal object[] GetValues()
        {
            try
            {
                Dictionary<string, object> param = GetSchema();
                return param.Values.ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the insert columns.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(provider, param["BFY"].ToString(), param["Fund"].ToString(), param["Code"].ToString());
                if(!param.ContainsKey("FundName") ||
                   param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if(!param.ContainsKey("Org") ||
                   param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if(!param.ContainsKey("ProgramProject") ||
                   param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if(!param.ContainsKey("ProgramArea") ||
                   param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if(!param.ContainsKey("Goal") ||
                   param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if(!param.ContainsKey("Objective") ||
                   param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Obligation Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Obligation(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Obligation Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataRow query = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
                return new Obligation(query);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.ProgramObligations, provider, Sql.INSERT, p);
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
        /// Updates the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.ProgramObligations, provider, Sql.INSERT, p);
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
        /// Deletes the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.ProgramObligations, provider, Sql.INSERT, p);
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
