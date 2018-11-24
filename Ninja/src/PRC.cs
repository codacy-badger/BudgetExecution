﻿// <copyright file="PRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <inheritdoc cref="" />
    /// <summary>
    /// Defines the <see cref="T:BudgetExecution.PRC" />
    /// </summary>
    public class PRC : IDataBuilder, IPRC, IAccount
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        public PRC()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public PRC(Provider provider = Provider.SQLite)
        {
            Source = Source.PRC;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public PRC(Provider provider, Dictionary<string, object> param)
        {
            Source = Source.PRC;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            if(DbData.Table.Rows.Count == 1)
            {
                Data = DbData.Table.AsEnumerable().Select(p => p).Single();
                ID = int.Parse(Data["ID"].ToString());
                BudgetLevel = Data["BudgetLevel"].ToString();
                RPIO = Data["RPIO"].ToString();
                AH = Data["AH"].ToString();
                BFY = Data["BFY"].ToString();
                Fund = new Fund(Data["FundCode"].ToString(), Data["BFY"].ToString());
                Org = new Org(Data["Org"].ToString());
                RC = new RC(Data["RC"].ToString());
                Account = new Account(Provider.SQLite, BFY, Fund.Code, Data["Code"].ToString());
                Code = Account.Code;
                BOC = new BOC(Data["BOC"].ToString());
                Amount = decimal.Parse(Data["Amount"].ToString());
                ProgramProjectCode = Account.ProgramProjectCode;
                ProgramProjectName = Account.ProgramProjectName;
                ProgramArea = Account.ProgramArea;
                NPM = Account.NPM;
                NpmCode = Account.NpmCode;
                Goal = Account.Goal;
                GoalName = Account.GoalName;
                Objective = Account.Objective;
                ObjectiveName = Account.ObjectiveName;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <param name="bl">The bl<see cref="string"/></param>
        /// <param name="rpio">The rpio<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
        /// <param name="fund">The fund<see cref="string"/></param>
        /// <param name="ah">The ah<see cref="string"/></param>
        /// <param name="org">The org<see cref="string"/></param>
        /// <param name="rc">The rc<see cref="string"/></param>
        /// <param name="code">The code<see cref="string"/></param>
        /// <param name="boc">The boc<see cref="string"/></param>
        /// <param name="amount">The amount<see cref="decimal"/></param>
        public PRC(int id, string bl, string rpio, string bfy, string fund, string ah, string org, string rc, string code, string boc, decimal amount)
        {
            ID = id;
            BudgetLevel = bl;
            RPIO = rpio;
            BFY = bfy;
            Fund = new Fund(Provider.SQLite, new Dictionary<string, object> { ["BFY"] = bfy, ["Code"] = fund });
            FundCode = Fund.Code;
            AH = ah;
            RC = new RC(rc);
            Org = new Org(org);
            Account = new Account(Provider.SQLite, BFY, Fund.Code, code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Amount = amount;
            Parameter = AsDictionary();
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="row">The row<see cref="DataRow"/></param>
        public PRC(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            BudgetLevel = row["BudgetLevel"].ToString();
            RPIO = row["RPIO"].ToString();
            AH = row["AH"].ToString();
            BFY = row["BFY"].ToString();
            Fund = new Fund(row["FundCode"].ToString(), row["BFY"].ToString());
            FundCode = Fund.Code;
            Org = new Org(row["Org"].ToString());
            RC = new RC(row["RC"].ToString());
            Account = new Account(Provider.SQLite, BFY, Fund.Code, row["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(row["BOC"].ToString());
            Parameter = AsDictionary();
            Amount = decimal.Parse(row["Amount"].ToString());
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        /// <summary></summary>
        /// <param name="data"></param>
        public PRC(Dictionary<string, object> data)
        {
            Parameter = data;
            Data = new DataBuilder(Source.PRC, Provider.SQLite, Parameter).Data;
            ID = int.Parse(Data["ID"].ToString());
            BudgetLevel = Data["BudgetLevel"].ToString();
            RPIO = Data["RPIO"].ToString();
            AH = Data["AH"].ToString();
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), Data["BFY"].ToString());
            FundCode = Fund.Code;
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            Account = new Account(Provider.SQLite, BFY, Fund.Code, Data["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(Data["BOC"].ToString());
            Amount = decimal.Parse(Data["Amount"].ToString());
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
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

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BudgetLevel
        /// </summary>
        public string BudgetLevel { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        public Fund Fund { get; set; }

        /// <summary>
        /// Gets the FundCode
        /// </summary>
        public string FundCode { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Org
        /// </summary>
        public Org Org { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the RC
        /// </summary>
        public RC RC { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Account
        /// </summary>
        public Account Account { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public BOC BOC { get; set; }

        /// <summary>
        /// Gets the AH
        /// </summary>
        public string AH { get; }

        /// <summary>
        /// Gets or sets the FTE
        /// </summary>
        public FTE FTE { get; set; }

        /// <summary>
        /// Gets or sets the NpmCode
        /// </summary>
        public string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the ProgramArea
        /// </summary>
        public string ProgramArea { get; set; }

        /// <summary>
        /// Gets the GoalName
        /// </summary>
        public string GoalName { get; }

        /// <summary>
        /// Gets the ObjectiveName
        /// </summary>
        public string ObjectiveName { get; }

        /// <summary>
        /// Gets or sets the Parameter
        /// </summary>
        internal Dictionary<string, object> Parameter { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the NPM
        /// </summary>
        public string NPM { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Goal
        /// </summary>
        public string Goal { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Objective
        /// </summary>
        public string Objective { get; }

        // METHODS

        /// <inheritdoc />
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            try
            {
                return Code;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns></returns>
        public string GetGoal()
        {
            try
            {
                char[] goal = Code.Substring(0, 1).ToCharArray();
                return goal.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the name of the goal.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetGoalName(string code)
        {
            try
            {
                return Info.GetGoalName(code);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the NPM code.
        /// </summary>
        /// <returns></returns>
        public string GetNpmCode()
        {
            try
            {
                char[] npm = Code.Substring(2, 1).ToCharArray();
                return npm.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the objective.
        /// </summary>
        /// <returns></returns>
        public string GetObjective()
        {
            try
            {
                return Code.Substring(1, 2);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the name of the objective.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetObjectiveName(string code)
        {
            try
            {
                return Info.GetObjectiveName(code);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <returns></returns>
        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }

        /// <summary>
        /// Gets the data dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> AsDictionary()
        {
            try
            {
                return new Dictionary<string, object> { ["ID"] = ID, ["BudgetLevel"] = BudgetLevel, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["AH"] = AH, ["Org"] = Org, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = Code };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data.
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
        /// <summary>The GetProgramElements</summary>
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

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            try
            {
                return Account.Code;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PRC, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.InsertCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
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
                Query query = new Query(Source.PRC, provider, Sql.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
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
                Query query = new Query(Source.PRC, provider, Sql.DELETE, p);
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
