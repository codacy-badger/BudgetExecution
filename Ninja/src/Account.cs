// <copyright file="Account.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Windows.Forms;

    public class Account : IAccount
    {
        private DataRow Data;
        private Source Source;
        private Provider Provider;

        // CONSTRUCTORS
        public Account()
        {
        }


        public Account(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            Table = GetAccountData(Source, Provider);
        }

        public Account(string fund, string code) : this(Source.Accounts, Provider.SQLite)
        {
            Code = code;
            Parameter = GetAccountParameter(fund, code);
            Table = GetAccountData(Source.Accounts, Provider.SQLite, Parameter);
            Data = Table.AsEnumerable().First();
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Org = Data["Org"].ToString();
            Fund = Data["Fund"].ToString();
            FundName = Data["FundName"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            ID = int.Parse(Data["ID"].ToString());
            NPM = Data["NPM"].ToString();
            ObjectiveName = Data["ObjectiveName"].ToString();
            GoalName = Data["GoalName"].ToString();
            ProgramArea = Data["ProgramArea"].ToString();
            ProgramAreaName = Data["ProgramAreaName"].ToString();
        }

        public Account(Source source, Provider provider, string fund, string code)
        {
            Fund = fund;
            Code = code;
            Parameter = GetAccountParameter(fund, code);
            Table = GetAccountData(source, provider, Parameter);
            Data = Table.AsEnumerable().First();
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Org = Data["Org"].ToString();
            Fund = Data["Fund"].ToString();
            FundName = Data["FundName"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            ID = int.Parse(Data["ID"].ToString());
            NPM = Data["NPM"].ToString();
            ObjectiveName = Data["ObjectiveName"].ToString();
            GoalName = Data["GoalName"].ToString();
            ProgramArea = Data["ProgramArea"].ToString();
            ProgramAreaName = Data["ProgramAreaName"].ToString();
        }

        public Account(DataRow data)
        {
            Data = data;
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Fund = Data["Fund"].ToString();
            FundName = Data["FundName"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            ID = int.Parse(Data["ID"].ToString());
            NPM = Data["NPM"].ToString();
            ObjectiveName = Data["ObjectiveName"].ToString();
            GoalName = Data["GoalName"].ToString();
            ProgramArea = Data["ProgramArea"].ToString();
            ProgramAreaName = Data["ProgramAreaName"].ToString();
        }


        // PROPERTIES
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

        public DataTable Table { get; set; }

        // METHODS
        internal Dictionary<string, object> GetAccountParameter(string fund, string code)
        {
            try
            {
                return new Dictionary<string, object>()
                {
                    ["Fund"] = fund,
                    ["Code"] = code
                };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal Dictionary<string, object> GetAccountProgramData(string code)
        {
            try
            {
                var data = GetAccountData(Source.Accounts, Provider.SQLite, Parameter);
                var dr = data.Rows[0];
                GoalName = dr["GoalName"].ToString();
                ObjectiveName = dr["ObjectiveName"].ToString();
                ProgramProjectName = dr["ProgramProjectName"].ToString();
                Parameter.Add("GoalName", dr["GoalName"].ToString());
                Parameter.Add("ObjectiveName", dr["ObjectiveName"].ToString());
                Parameter.Add("ProgramProjectName", dr["ProgramProjectName"].ToString());
                return Parameter;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Provider provider)
        {
            try
            {
                var data = new DataBuilder(source, provider);
                return data.Table;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public string GetCode()
        {
            return Code;
        }

        public string GetGoal()
        {
            var goal = Code.Substring(0, 1).ToCharArray();
            return goal.ToString();
        }

        public string GetGoalName(string code)
        {
            return Info.GetGoalName(code);
        }

        public string GetNpmCode()
        {
            var npm = Code.Substring(2, 1).ToCharArray();
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

        public static Dictionary<string, object> GetInsertFields(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var account = new Account(source, provider, param["Fund"].ToString(), param["Code"].ToString());
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
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static PRC Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var query = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
                return new PRC(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertFields(source, provider, p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new Query(source, provider, param);
                var cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var query = new Query(source, provider, param);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)param["Amount"]} WHERE ID = {(int)param["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var query = new Query(source, provider, param);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)param["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}