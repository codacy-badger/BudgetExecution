using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BudgetExecution;

namespace BudgetExecution
{
    public class Account : IAccount
    {
        //Constructors
        public Account()
        {

        }
        public Account(string code)
        {
            Code = code;
            Parameter = GetAccountParameter(code);
            DataRecord = GetAccountDataRecord(Source.Account, Parameter);
            Goal = Code.Substring(0);
            Objective = Code.Substring(1, 2);
            NpmCode = Code.Substring(2);
            ProgramProjectCode = Code.Substring(3, 2);
            ObjectiveName = DataRecord["ObjectiveName"].ToString();
            GoalName = DataRecord["GoalName"].ToString();
            ProgramArea = DataRecord["ProgramArea"].ToString();
            ProgramAreaName = DataRecord["ProgramAreaName"].ToString();
        }

        //Properties
        public string Code { get; }
        public Dictionary<string, object> Parameter { get; }
        public string Goal { get; }
        public string GoalName { get; set; }
        public string NpmCode { get; }
        public string Objective { get; }
        public string ObjectiveName { get; set; }
        public string ProgramProjectCode { get; }
        public string ProgramProjectName { get; set; }
        public string ProgramArea { get; set; }
        public string ProgramAreaName { get; set; }
        public DataRow DataRecord { get; set; }

        //Methods
        internal Dictionary<string, object> GetAccountParameter(string code)
        {
            try
            {
                return new Dictionary<string, object>()
                {
                    ["Code"] = code,
                    ["Goal"] = Goal,
                    ["Objective"] = Objective,
                    ["ProgramProjectCode"] = ProgramProjectCode
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
                var dr = GetAccountDataRecord(Source.Account, Parameter);
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
        internal DataRow GetAccountDataRecord(Source source, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, param).GetDataTable();
                return data.Rows[0];
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