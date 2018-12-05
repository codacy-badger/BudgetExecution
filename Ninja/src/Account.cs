// <copyright file="Account.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Account : IDataBuilder, IAccount
    {
        public Account()
        {
            Source = Source.Accounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Account(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Account(Provider provider, string bfy, string fund, string code) : this()
        {
            Code = code;
            Provider = provider;
            ProgramProjectCode = Code.Substring(4, 2);
            Parameter = GetAccountParameter(bfy, fund, code);
            DbData = new DataBuilder(Source.Accounts, provider, Parameter);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
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
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
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

        public Account(DataRow data) : this()
        {
            Data = data;
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

        public Account(Dictionary<string, object> data) : this()
        {
            Parameter = data;
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
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

        
        // METHODS

        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

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

        public string[] Columns { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        // METHODS

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

        string IAccount.GetCode()
        {
            return Code;
        }

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

        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
        {
            try
            {
                return (Dictionary<string, string[]>)DbData.ProgramElements;
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

        public string GetCode()
        {
            return Code;
        }

        public override string ToString()
        {
            return Code;
        }

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
