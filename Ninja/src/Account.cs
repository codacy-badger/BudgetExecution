// <copyright file="Account.cs" company="PlaceholderCompany">
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
    /// Defines the <see cref="T:BudgetExecution.Account" />
    /// </summary>
    public class Account : IDataBuilder, IAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
            Source = Source.Accounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            if(Records.Length == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Code = Data["Code"].ToString();
                Goal = Code.Substring(0, 1);
                Objective = Code.Substring(1, 2);
                NpmCode = Code.Substring(3, 1);
                Org = Data["Org"].ToString();
                BFY = Data["BFY"].ToString();
                FundCode = Data["FundCode"].ToString();
                ProgramProjectName = Data["ProgramProjectName"].ToString();
                NPM = Table.Rows[0]["NPM"].ToString();
                ObjectiveName = Table.Rows[0]["ObjectiveName"].ToString();
                GoalName = Table.Rows[0]["GoalName"].ToString();
                ProgramArea = Table.Rows[0]["ProgramArea"].ToString();
                ProgramAreaName = Table.Rows[0]["ProgramAreaName"].ToString();
                Parameter = GetAccountParameter(BFY, FundCode, Code);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.Account" /> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="P:BudgetExecution.Account.Provider" /></param>
        public Account(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.Account" /> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="P:BudgetExecution.Account.Provider" /></param>
        /// <param name="bfy">The bfy<see cref="T:System.String" /></param>
        /// <param name="fund">The fund<see cref="T:System.String" /></param>
        /// <param name="code">The code<see cref="T:System.String" /></param>
        public Account(Provider provider, string bfy, string fund, string code) : this()
        {
            Code = code;
            Provider = provider;
            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = GetAccountParameter(bfy, fund, code);
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.Account" /> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="P:BudgetExecution.Account.Provider" /></param>
        /// <param name="p">The p<see cref="T:System.Collections.Generic.Dictionary`2" /></param>
        public Account(Provider provider, Dictionary<string, object> p) : this() 
        {
            Provider = provider;
            if(p.ContainsKey("BFY"))
            {
                BFY = p["BFY"].ToString();
            }

            if(p.ContainsKey("FundCode"))
            {
                FundCode = p["FundCode"].ToString();
            }

            if(p.ContainsKey("Code"))
            {
                Code = p["Code"].ToString();
                ProgramProjectCode = Code.Substring(4, 2);
            }

            Parameter = p;
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public Account(DataRow data) : this()
        {
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, object}"/></param>
        public Account(Dictionary<string, object> data) : this()
        {
            Parameter = data;
        }

        
        // METHODS

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
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the FundCode
        /// </summary>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the FundName
        /// </summary>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public string Org { get; set; }

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
        /// Gets or sets the ProgramAreaName
        /// </summary>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the GoalName
        /// </summary>
        public string GoalName { get; set; }

        /// <summary>
        /// Gets or sets the ObjectiveName
        /// </summary>
        public string ObjectiveName { get; set; }

        /// <summary>
        /// Gets the Parameter
        /// </summary>
        public Dictionary<string, object> Parameter { get; }

        /// <inheritdoc cref="" />
        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }

        /// <inheritdoc cref="" />
        /// <summary>
        /// Gets or sets the NPM
        /// </summary>
        public string NPM { get; set; }

        /// <inheritdoc cref="" />
        /// <summary>
        /// Gets or sets the Goal
        /// </summary>
        public string Goal { get; set; }

        /// <inheritdoc cref="" />
        /// <summary>
        /// Gets or sets the Objective
        /// </summary>
        public string Objective { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Data
        /// Gets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        // METHODS

        /// <inheritdoc />
        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns></returns>
        public string GetGoal()
        {
            char[] goal = Code.Substring(0, 1).ToCharArray();
            return goal.ToString();
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the name of the goal.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetGoalName(string code)
        {
            return Info.GetGoalName(code);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the NPM code.
        /// </summary>
        /// <returns></returns>
        public string GetNpmCode()
        {
            char[] npm = Code.Substring(2, 1).ToCharArray();
            return npm.ToString();
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the objective.
        /// </summary>
        /// <returns></returns>
        public string GetObjective()
        {
            return Code.Substring(1, 2);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the name of the objective.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetObjectiveName(string code)
        {
            return Info.GetObjectiveName(code);
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <returns></returns>
        string IAccount.GetCode()
        {
            return Code;
        }

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
        /// Gets the code.
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            return Code;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        /// Gets the insert fields.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetColumns(Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(Provider.SQLite, param["BFY"].ToString(), param["FundCode"].ToString(), param["Code"].ToString());
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
        /// Gets the account parameter.
        /// </summary>
        /// <param name="bfy">The bfy.</param>
        /// <param name="fund">The fund.</param>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        internal Dictionary<string, object> GetAccountParameter(string bfy, string fund, string code)
        {
            try
            {
                return new Dictionary<string, object> { ["BFY"] = bfy, ["FundCode"] = fund, ["ProgramProjectCode"] = code };
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
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Accounts, provider, Sql.INSERT, p);
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
                Query query = new Query(Source.Accounts, provider, Sql.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.UpdateCommand.Dispose();
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
                Query query = new Query(Source.Accounts, provider, Sql.DELETE, p);
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
