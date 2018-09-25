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

        public Account(Source source)
        {
            Source = source;
            Provider = Provider.SQLite;
            DbTable = GetAccountData(Source, Provider);
        }

        public Account(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbTable = GetAccountData(Source, Provider);
        }

        public Account(string fund, string code) : this(Source.Accounts, Provider.SQLite)
        {
            Code = code;
            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = GetAccountParameter(fund, code);
            DbTable = GetAccountData(Source.Accounts, Provider.SQLite, Parameter);
            DbRow = DbTable.AsEnumerable().First();
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Org = DbRow["Org"].ToString();
            Fund = DbRow["Fund"].ToString();
            FundName = DbRow["FundName"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            ID = int.Parse(DbRow["ID"].ToString());
            NPM = DbRow["NPM"].ToString();
            ObjectiveName = DbRow["ObjectiveName"].ToString();
            GoalName = DbRow["GoalName"].ToString();
            ProgramArea = DbRow["ProgramArea"].ToString();
            ProgramAreaName = DbRow["ProgramAreaName"].ToString();
        }

        public Account(Source source, Provider provider, string fund, string code)
        {
            Fund = fund;
            Code = code;
            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = GetAccountParameter(fund, code);
            DbTable = GetAccountData(source, provider, Parameter);
            DbRow = DbTable.AsEnumerable().First();
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            Org = DbRow["Org"].ToString();
            Fund = DbRow["Fund"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            ID = int.Parse(DbRow["ID"].ToString());
            NPM = DbRow["NPM"].ToString();
            ObjectiveName = DbRow["ObjectiveName"].ToString();
            GoalName = DbRow["GoalName"].ToString();
            ProgramArea = DbRow["ProgramArea"].ToString();
            ProgramAreaName = DbRow["ProgramAreaName"].ToString();
        }

        public Account(DataRow data)
        {
            DbRow = data;
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Fund = DbRow["Fund"].ToString();
            FundName = DbRow["FundName"].ToString();
            ProgramProjectName = DbRow["ProgramProjectName"].ToString();
            ID = int.Parse(DbRow["ID"].ToString());
            NPM = DbRow["NPM"].ToString();
            ObjectiveName = DbRow["ObjectiveName"].ToString();
            GoalName = DbRow["GoalName"].ToString();
            ProgramArea = DbRow["ProgramArea"].ToString();
            ProgramAreaName = DbRow["ProgramAreaName"].ToString();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public string Code { get; set; }

        public string Fund { get; set; }

        public string FundName { get; set; }

        public string Org { get; set; }

        public string NpmCode { get; set; }

        public string NPM { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string ProgramAreaName { get; set; }

        public string Goal { get; set; }

        public string GoalName { get; set; }

        public string Objective { get; set; }

        public string ObjectiveName { get; set; }

        public string ProgramProjectCode { get; }

        public Dictionary<string, object> Parameter { get; }

        // METHODS
        public string GetCode()
        {
            return Code;
        }

        public string GetGoal()
        {
            char[] goal = Code.Substring(0, 1).ToCharArray();
            return goal.ToString();
        }

        public string GetGoalName(string code)
        {
            return Info.GetGoalName(code);
        }

        public string GetNpmCode()
        {
            char[] npm = Code.Substring(2, 1).ToCharArray();
            return npm.ToString();
        }

        public string GetObjective()
        {
            return Code.Substring(1, 2);
        }

        public string GetObjectiveName(string code)
        {
            return Info.GetObjectiveName(code);
        }

        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }

        public override string ToString()
        {
            return Code;
        }

        string IAccount.GetCode()
        {
            return Code;
        }

        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(source, Provider.SQLite, param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("Fund") || param["Fund"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProjectCode") || param["ProgramProjectCode"] == null)
                {
                    param["ProgramProjectCode"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective") || param["Objective"] == null)
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

        public static Dictionary<string, object> GetInsertFields(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(source, provider, param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("FundName") || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProject") || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective") || param["Objective"] == null)
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

        public static Account Select(Source source, Dictionary<string, object> param)
        {
            try
            {
                DataRow query = new DataBuilder(source, Provider.SQLite, param).DbTable.AsEnumerable().Select(p => p).First();
                return new Account(query);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Account Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataRow query = new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
                return new Account(query);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Dictionary<string, object> p)
        {
            try
            {
                Insert insert = new Insert(Info.Insert);
                insert(Source.Accounts, Provider.SQLite, p);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Dictionary<string, object> p)
        {
            try
            {
                Insert update = new Insert(Info.Update);
                update(Source.Accounts, Provider.SQLite, p);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Dictionary<string, object> p)
        {
            try
            {
                Insert delete = new Insert(Info.Insert);
                delete(Source.Accounts, Provider.SQLite, p);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal Dictionary<string, object> GetAccountParameter(string fund, string code)
        {
            try
            {
                return new Dictionary<string, object>() { ["Fund"] = fund, ["ProgramProjectCode"] = Code.Substring(4, 2) };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal Dictionary<string, object> GetAccountProgramData(string fund, string code)
        {
            try
            {
                Dictionary<string, object> param = GetAccountParameter(fund, code);
                DataTable data = GetAccountData(Source.Accounts, Provider.SQLite, param);
                DataRow dr = data.Rows[0];
                GoalName = dr["GoalName"].ToString();
                ObjectiveName = dr["ObjectiveName"].ToString();
                ProgramProjectName = dr["ProgramProjectName"].ToString();
                param.Add("GoalName", dr["GoalName"].ToString());
                param.Add("ObjectiveName", dr["ObjectiveName"].ToString());
                param.Add("ProgramProjectName", dr["ProgramProjectName"].ToString());
                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Provider provider)
        {
            try
            {
                DataBuilder data = new DataBuilder(source, provider);
                return data.DbTable;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Dictionary<string, object> param)
        {
            try
            {
                DataBuilder data = new DataBuilder(source, Provider.SQLite, param);
                return data.DbTable;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataBuilder data = new DataBuilder(source, provider, param);
                return data.DbTable;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}