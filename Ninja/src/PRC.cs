using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class PRC : IPRC, IAccount
    {
        // CONSTRUCTORS
        public PRC()
        {
        }
        public PRC(int id, string bl, string rpio, string bfy, string fund, string org, string rc, string code, string boc, decimal amount)
        {
            BudgetLevel = bl;
            ID = id;
            RPIO = rpio;
            BFY = bfy;
            Fund = new Fund(Source.Fund, Provider.SQLite, fund, bfy);
            RC = new RC(rc);
            Org = new Org(org);
            Account = new Account(Source.Account, Provider.SQLite, code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Parameter = GetParameter();
            Amount = amount;
        }
        public PRC(DataRow datarow)
        {
            ID = int.Parse(datarow["ID"].ToString());
            BudgetLevel = datarow["BudgetLevel"].ToString();
            RPIO = datarow["RPIO"].ToString();
            BFY = datarow["BFY"].ToString();
            Fund = new Fund(datarow["Fund"].ToString(), datarow["BFY"].ToString());
            Org = new Org(datarow["Org"].ToString());
            RC = new RC(datarow["RC"].ToString());
            Account = new Account(Source.Account, Provider.SQLite, datarow["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(datarow["BOC"].ToString());
            Parameter = GetParameter();
            Amount = decimal.Parse(datarow["Amount"].ToString());
        }

        // PROPERTIES
        public int ID { get; set; }
        public string BudgetLevel { get; set; }
        public string RPIO { get; set; }
        public string BFY { get; set; }
        public Fund Fund { get; }
        public Org Org { get; }
        public RC RC { get; }
        public string Code { get; set; }
        public Account Account { get; }
        public decimal Amount { get; set; }
        public BOC BOC { get; }
        public FTE FTE { get; set; }
        public string NPM { get; set; }
        public string NpmCode { get; set; }
        public string ProgramProjectCode { get; }
        public string ProgramProjectName { get; set; }
        public string ProgramArea { get; set; }
        public string Goal { get; }
        public string GoalName { get; }
        public string Objective { get; }
        public string ObjectiveName { get; }
        private Dictionary<string, object> Parameter { get; set; }
        public string[] DataFields { get; }
        public object[] DataValues { get; }

        // METHODS
        internal Dictionary<string, object> GetParameter()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>()
                {
                    ["ID"] = ID,
                    ["BudgetLevel"] = BudgetLevel,
                    ["RPIO"] = RPIO,
                    ["BFY"] = BFY,
                    ["Fund"] = Fund.Code,
                    ["RC"] = RC,
                    ["BOC"] = BOC.Code,
                    ["Code"] = Account.Code,
                };
                return param;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        internal DataRow GetData(Source source, Provider provider)
        {
            try
            {
                var param = GetParameter();
                return new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
            }
            catch (Exception ex)
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
            return Account.Code;
        }
        internal string[] GetFields()
        {
            try
            {
                Dictionary<string, object> prc = GetParameter();

                return prc.Keys.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }
        internal Dictionary<string, object> GetFieldValues()
        {
            try
            {
                Dictionary<string, object> param = GetParameter();

                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }
    }
}