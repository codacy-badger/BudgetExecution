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
        internal Dictionary<string, object> GetAccountParameter(string fund, string code)
        {
            try
            {
                return new Dictionary<string, object>()
                {
                    ["Fund"] = fund,
                    ["ProgramProjectCode"] = Code.Substring(4, 2)
                };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal Dictionary<string, object> GetAccountProgramData(string fund, string code)
        {
            try
            {
                var param = GetAccountParameter(fund, code);
                var data = GetAccountData(Source.Accounts, Provider.SQLite, param);
                var dr = data.Rows[0];
                GoalName = dr["GoalName"].ToString();
                ObjectiveName = dr["ObjectiveName"].ToString();
                ProgramProjectName = dr["ProgramProjectName"].ToString();
                param.Add("GoalName", dr["GoalName"].ToString());
                param.Add("ObjectiveName", dr["ObjectiveName"].ToString());
                param.Add("ProgramProjectName", dr["ProgramProjectName"].ToString());
                return param;
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
                return data.DbTable;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal DataTable GetAccountData(Source source, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, Provider.SQLite, param);
                return data.DbTable;
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
                return data.DbTable;
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

        public static Dictionary<string, object> GetInsertFields(Source source, Dictionary<string, object> param)
        {
            try
            {
                var account = new Account(source, Provider.SQLite, param["Fund"].ToString(), param["Code"].ToString());
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
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
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

        public static Account Select(Source source, Dictionary<string, object> param)
        {
            try
            {
                var query = new DataBuilder(source, Provider.SQLite, param).DbTable.AsEnumerable().Select(p => p).First();
                return new Account(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static Account Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var query = new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
                return new Account(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static void Insert(Source source, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertFields(source, Provider.SQLite, p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new SQLiteQuery(source, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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

        public static void Update(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn);
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
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

        public static void Delete(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var delete = query.GetDataCommand(cmd, conn);
                    delete.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
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