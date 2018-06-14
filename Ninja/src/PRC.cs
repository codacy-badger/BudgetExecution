// <copyright file="PRC.cs" company="PlaceholderCompany">
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

    public class PRC : IPRC, IAccount
    {
        private DataRow data;

        // CONSTRUCTORS
        public PRC()
        {
        }

        public PRC(Source source, Provider provider, Dictionary<string, object> param)
        {
            data = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
            ID = int.Parse(data["ID"].ToString());
            BudgetLevel = data["BudgetLevel"].ToString();
            RPIO = data["RPIO"].ToString();
            BFY = data["BFY"].ToString();
            Fund = new Fund(data["Fund"].ToString(), data["BFY"].ToString());
            Org = new Org(data["Org"].ToString());
            RC = new RC(data["RC"].ToString());
            Account = new Account(Source.Account, Provider.SQLite, Fund.Code, data["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(data["BOC"].ToString());
            Parameter = GetParamData();
            Amount = decimal.Parse(data["Amount"].ToString());
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
            Account = new Account(Source.Account, Provider.SQLite, Fund.Code, code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Parameter = GetParamData();
            Amount = amount;
        }

        public PRC(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            BudgetLevel = row["BudgetLevel"].ToString();
            RPIO = row["RPIO"].ToString();
            BFY = row["BFY"].ToString();
            Fund = new Fund(row["Fund"].ToString(), row["BFY"].ToString());
            Org = new Org(row["Org"].ToString());
            RC = new RC(row["RC"].ToString());
            Account = new Account(Source.Account, Provider.SQLite, Fund.Code, row["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(row["BOC"].ToString());
            Parameter = GetParamData();
            Amount = decimal.Parse(row["Amount"].ToString());
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
        internal Dictionary<string, object> GetParamData()
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

        internal DataRow GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
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
                Dictionary<string, object> prc = GetParamData();

                return prc.Keys.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }

        internal object[] GetFieldValues()
        {
            try
            {
                Dictionary<string, object> param = GetParamData();

                return param.Values.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
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