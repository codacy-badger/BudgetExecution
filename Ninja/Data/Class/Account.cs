using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public class Account : IAccount
    {
        //Constructors
        public Account(string code)
        {
            Code = code;
            Goal = Code.Substring(0);
            GoalName = Info.GetGoalName(Goal);
            Objective = Code.Substring(1, 2);
            ObjectiveName = Info.GetObjectiveName(Objective);
            NpmCode = Code.Substring(2);
            ProgramProjectCode = Code.Substring(3, 2);
        }

        //Properties
        public string Code { get; }
        public string Goal { get; }
        public string GoalName { get; }
        public string NpmCode { get; }
        public string Objective { get; }
        public string ObjectiveName { get; }
        public string ProgramProjectCode { get; }

        //Methods
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
        public DataRow GetProgramData(string code)
        {
            var pp = GetProgramProjectCode();
            var sql = new Dictionary<string, object>();
            sql.Add("ProgramProjectCode", pp);
            DataRow p = new DataBuilder(Source.A6, sql).QueryTable.Rows[0];
            return p;
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