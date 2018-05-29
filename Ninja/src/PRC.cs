﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class PRC : IAccount
    {
        //Constructors
        public PRC()
        {
        }
        public PRC(int id, string bl, string rpio, string bfy, string fund, string org, string rc, string code, string boc, decimal amount)
        {
            BudgetLevel = bl;
            ID = id;
            RPIO = rpio;
            BFY = bfy;
            Fund = new Fund(fund, bfy);
            RC = new RC(rc);
            Org = org;
            Account = new Account(code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Parameter = GetDataParameter();
            Amount = amount;
        }
        public PRC(DataRow datarow)
        {
            ID = int.Parse(datarow["Id"].ToString());
            BudgetLevel = datarow["BudgetLevel"].ToString();
            RPIO = datarow["RPIO"].ToString();
            BFY = datarow["BFY"].ToString();
            Fund = new Fund(datarow["Fund"].ToString(), datarow["BFY"].ToString());
            Org = datarow["Org"].ToString();
            RC = new RC(datarow["RC"].ToString());
            Account = new Account(datarow["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(datarow["BOC"].ToString());
            Parameter = GetDataParameter();
            Amount = decimal.Parse(datarow["Amount"].ToString());
        }

        //Properties
        public int ID { get; set; }
        public string BudgetLevel { get; set; }
        public string RPIO { get; set; }
        public string BFY { get; set; }
        public Fund Fund { get; }
        public string Org { get; }
        public RC RC { get; }
        public string Code { get; set; }
        public Account Account { get; }
        public decimal Amount { get; set; }
        public BOC BOC { get; }
        public FTE FTE { get; set; }
        public string NPM { get; set; }
        public string NpmName { get; set; }
        public string ProgramProjectCode { get; }
        public string ProgramProjectName { get; set; }
        public string ProgramArea { get; set; }
        public string Goal { get; }
        public string GoalName { get; }
        public string Objective { get; }
        public string ObjectiveName { get; }
        private Dictionary<string, object> Parameter { get; set; }
        public string[] DataFields { get; }
        public object[] DataObjects { get; }

        //Methods
        internal Dictionary<string, object> GetDataParameter()
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
        public DataRow GetProgramData()
        {
            try
            {
                var pp = GetProgramProjectCode();
                var sql = new Dictionary<string, object>();
                sql.Add("ProgramProjectCode", pp);
                DataRow p = new DataBuilder(Source.Account, sql).Table.Rows[0];
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }
        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }
        public override string ToString()
        {
            return Account.Code;
        }
        internal Dictionary<string, object> GetFields()
        {
            try
            {
                Dictionary<string, object> prc = GetDataParameter();

                return prc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }
        internal Dictionary<string, object> GetDataObjects()
        {
            try
            {
                Dictionary<string, object> param = GetDataParameter();

                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }
        internal PrcParameter GetPrcParameter()
        {
            return new PrcParameter(ID, BudgetLevel, RPIO, BFY, Fund.Code, Org, RC.Code, BOC.Code, Account.Code);
        }
        internal decimal Reprogram(decimal amount)
        {
            try
            {
                this.Amount += amount;
                return Amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1;
            }
        }
    }
}