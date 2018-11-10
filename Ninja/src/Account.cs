// <copyright file="Account.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

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

        public Account(Provider provider, string bfy, string fund, string code)
                : this(provider)
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
                Org = Table.Rows[0]["Org"].ToString();
                BFY = Table.Rows[0]["BFY"].ToString();
                Fund = Table.Rows[0]["Fund"].ToString();
                ProgramProjectName = Data["ProgramProjectName"].ToString();
                NPM = Table.Rows[0]["NPM"].ToString();
                ObjectiveName = Table.Rows[0]["ObjectiveName"].ToString();
                GoalName = Table.Rows[0]["GoalName"].ToString();
                ProgramArea = Table.Rows[0]["ProgramArea"].ToString();
                ProgramAreaName = Table.Rows[0]["ProgramAreaName"].ToString();
            }
        }

        public Account(Provider provider, Dictionary<string, object> p)
                : this(provider)
        {
            if(p.ContainsKey("BFY"))
            {
                BFY = p["BFY"].ToString();
            }

            if(p.ContainsKey("Fund"))
            {
                Fund = p["Fund"].ToString();
            }

            if(p.ContainsKey("Code"))
            {
                Code = p["Code"].ToString();
            }

            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = p;
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
            Table = DbData.Table;
            if (Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Goal = Code.Substring(0, 1);
                Objective = Code.Substring(1, 2);
                NpmCode = Code.Substring(3, 1);
                Org = Data["Org"].ToString();
                BFY = Data["BFY"].ToString();
                Fund = Data["Fund"].ToString();
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
            Fund = data["Fund"].ToString();
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

        public DataTable Table { get; }

        public DataRow Data { get; }

        public int ID { get; set; }

        public string BFY { get; set; }

        public string Fund { get; set; }

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
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(Provider.SQLite, param["BFY"].ToString(), param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("Fund")
                    || param["Fund"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org")
                    || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProjectCode")
                    || param["ProgramProjectCode"] == null)
                {
                    param["ProgramProjectCode"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea")
                    || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal")
                    || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective")
                    || param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the insert fields.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertFields(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(provider, param["BFY"].ToString(), param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("FundName")
                    || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org")
                    || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProject")
                    || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea")
                    || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal")
                    || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective")
                    || param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch (Exception ex)
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
                return new Dictionary<string, object> { ["BFY"] = bfy, ["Fund"] = fund,
                    ["ProgramProjectCode"] = code};
            }
            catch (Exception ex)
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
        internal Dictionary<string, object> GetAccountProgramData(string bfy, string fund, string code)
        {
            try
            {
                Dictionary<string, object> param = GetAccountParameter(bfy, fund, code);
                GoalName = Data["GoalName"].ToString();
                ObjectiveName = Data["ObjectiveName"].ToString();
                ProgramProjectName = Data["ProgramProjectName"].ToString();
                param.Add("GoalName", GoalName);
                param.Add("ObjectiveName", ObjectiveName);
                param.Add("ProgramProjectName", ProgramProjectName);
                return param;
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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.InsertCommand;
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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.UpdateCommand;
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
                Query query = new Query(source, provider, Sql.INSERT, p);
                System.Data.Common.DbConnection conn = query.DataConnection;
                System.Data.Common.DbCommand command = query.DeleteCommand;
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
