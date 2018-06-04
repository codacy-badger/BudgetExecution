﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BudgetExecution;

namespace BudgetExecution
{
    public class Account : IAccount
    {
        // CONSTRUCTORS
        public Account()
        {

        }
        public Account(string code)
        {
            Code = code;      
            Parameter = GetAccountParameter(code);
            Data = GetDataRecords(Source.Account, Provider.SQLite, Parameter);
            DataRecord = Data.AsEnumerable().First();
            Goal = Code.Substring(0, 1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Org = DataRecord["Org"].ToString();
            Fund = DataRecord["Fund"].ToString();
            FundName = DataRecord["FundName"].ToString();
            ProgramProjectName = DataRecord["ProgramProjectName"].ToString();
            ID = int.Parse(DataRecord["ID"].ToString());
            NPM = DataRecord["NPM"].ToString();
            ObjectiveName = DataRecord["ObjectiveName"].ToString();
            GoalName = DataRecord["GoalName"].ToString();
            ProgramArea = DataRecord["ProgramArea"].ToString();
            ProgramAreaName = DataRecord["ProgramAreaName"].ToString();
        }

        public Account(Source source, Provider provider, string code)
        {
            Code = code;
            Parameter = GetAccountParameter(code);
            Data = GetDataRecords(source, provider, Parameter);
            DataRecord = Data.AsEnumerable().First();
            Goal = Code.Substring(0,1);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(3, 1);
            ProgramProjectCode = Code.Substring(4, 2);
            Org = DataRecord["Org"].ToString();
            Fund = DataRecord["Fund"].ToString();
            FundName = DataRecord["FundName"].ToString();
            ProgramProjectName = DataRecord["ProgramProjectName"].ToString();
            ID = int.Parse(DataRecord["ID"].ToString());
            NPM = DataRecord["NPM"].ToString();
            ObjectiveName = DataRecord["ObjectiveName"].ToString();
            GoalName = DataRecord["GoalName"].ToString();
            ProgramArea = DataRecord["ProgramArea"].ToString();
            ProgramAreaName = DataRecord["ProgramAreaName"].ToString();
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
        public DataTable Data { get; set; }
        public DataRow DataRecord { get; set; }

        // METHODS
        internal Dictionary<string, object> GetAccountParameter(string code)
        {
            try
            {
                return new Dictionary<string, object>()
                {
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
                var data = GetDataRecords(Source.Account, Provider.SQLite, Parameter);
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
        internal DataTable GetDataRecords(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch(System.Exception ex)
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
    }       
}