// <copyright file="Account.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Account : IAccount
    {
        // CONSTRUCTORS
        public Account()
        {
        }

        public Account(Provider provider = Provider.SQLite)
        {
            Source = Source.Accounts;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
        }

        public Account(Provider provider, string bfy, string fund, string code) : this(provider)
        {
            Code = code;
            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = GetAccountParameter(bfy, fund, code);
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
            Table = DbData.Table;
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
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
            }
        }

        public Account(Provider provider, Dictionary<string, object> p) : this(provider)
        {
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
            }

            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = p;
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
            Table = DbData.Table;
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Goal = Code.Substring(0, 1);
                Objective = Code.Substring(1, 2);
                NpmCode = Code.Substring(3, 1);
                Org = Data["Org"].ToString();
                BFY = Data["BFY"].ToString();
                FundCode = Data["FundCode"].ToString();
                ProgramProjectName = Data["ProgramProjectName"].ToString();
                NPM = Data["NPM"].ToString();
                ObjectiveName = Data["ObjectiveName"].ToString();
                GoalName = Data["GoalName"].ToString();
                ProgramArea = Data["ProgramArea"].ToString();
                ProgramAreaName = Data["ProgramAreaName"].ToString();
            }
        }

        public Account(DataRow data)
        {
            Data = data;
            ID = int.Parse(data["ID"].ToString());
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            BFY = data["BFY"].ToString();
            FundCode = data["Fund"].ToString();
            FundName = data["FundName"].ToString();
            ProgramProjectName = data["ProgramProjectName"].ToString();
            NPM = data["NPM"].ToString();
            ObjectiveName = data["ObjectiveName"].ToString();
            GoalName = data["GoalName"].ToString();
            ProgramArea = data["ProgramArea"].ToString();
            ProgramAreaName = data["ProgramAreaName"].ToString();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public string[] Columns { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public int ID { get; set; }

        public string BFY { get; set; }

        public string FundCode { get; set; }

        public string FundName { get; set; }

        public string Org { get; set; }

        public string NpmCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string ProgramAreaName { get; set; }

        public string GoalName { get; set; }

        public string ObjectiveName { get; set; }

        public Dictionary<string, object> Parameter { get; }

        public string Code { get; set; }

        public string NPM { get; set; }

        public string Goal { get; set; }

        public string Objective { get; set; }

        public string ProgramProjectCode { get; }

        // METHODS

        /// <summary>
        ///     Gets the goal.
        /// </summary>
        /// <returns></returns>
        public string GetGoal()
        {
            char[] goal = Code.Substring(0, 1).ToCharArray();
            return goal.ToString();
        }

        /// <summary>
        ///     Gets the name of the goal.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetGoalName(string code)
        {
            return Info.GetGoalName(code);
        }

        /// <summary>
        ///     Gets the NPM code.
        /// </summary>
        /// <returns></returns>
        public string GetNpmCode()
        {
            char[] npm = Code.Substring(2, 1).ToCharArray();
            return npm.ToString();
        }

        /// <summary>
        ///     Gets the objective.
        /// </summary>
        /// <returns></returns>
        public string GetObjective()
        {
            return Code.Substring(1, 2);
        }

        /// <summary>
        ///     Gets the name of the objective.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetObjectiveName(string code)
        {
            return Info.GetObjectiveName(code);
        }

        /// <summary>
        ///     Gets the program project code.
        /// </summary>
        /// <returns></returns>
        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }

        /// <summary>
        ///     Gets the code.
        /// </summary>
        /// <returns></returns>
        string IAccount.GetCode()
        {
            return Code;
        }

        /// <summary>
        ///     Gets the code.
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            return Code;
        }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        ///     Gets the insert fields.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetColumns(Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(Provider.SQLite, param["BFY"].ToString(), param["FundCode"].ToString(), param["Code"].ToString());
                if(!param.ContainsKey("FundName") || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if(!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if(!param.ContainsKey("ProgramProject") || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if(!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if(!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if(!param.ContainsKey("Objective") || param["Objective"] == null)
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
        ///     Gets the account parameter.
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
        ///     Gets the account program data.
        /// </summary>
        /// <param name="fund">The fund.</param>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        internal Dictionary<string, object> GetAccountProgramData(string bfy, string fundcode, string code)
        {
            try
            {
                Dictionary<string, object> param = GetAccountParameter(bfy, fundcode, code);
                GoalName = Data["GoalName"].ToString();
                ObjectiveName = Data["ObjectiveName"].ToString();
                ProgramProjectName = Data["ProgramProjectName"].ToString();
                param.Add("GoalName", GoalName);
                param.Add("ObjectiveName", ObjectiveName);
                param.Add("ProgramProjectName", ProgramProjectName);
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
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
        ///     Updates the specified source.
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
        ///     Deletes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
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
