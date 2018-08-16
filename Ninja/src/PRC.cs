// <copyright file="PRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public class PRC : IPRC, IAccount
    {
        // CONSTRUCTORS
        public PRC()
        {
        }

        public PRC(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider);
            DbRow = DbData.DbTable.AsEnumerable().Select(p => p).First();
            ID = int.Parse(DbRow["ID"].ToString());
            BudgetLevel = DbRow["BudgetLevel"].ToString();
            RPIO = DbRow["RPIO"].ToString();
            AH = DbRow["AH"].ToString();
            BFY = DbRow["BFY"].ToString();
            Fund = new Fund(DbRow["Fund"].ToString(), DbRow["BFY"].ToString());
            Org = new Org(DbRow["Org"].ToString());
            BOC = new BOC(DbRow["BOC"].ToString());
            RC = new RC(DbRow["RC"].ToString());
            Account = new Account(Source.Accounts, Provider.SQLite, Fund.Code, DbRow["Code"].ToString());
            Code = Account.Code;
            Amount = decimal.Parse(DbRow["Amount"].ToString());
            Parameter = GetDataFields();
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        public PRC(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider, param);
            DbRow = DbData.DbTable.AsEnumerable().Select(p => p).First();
            ID = int.Parse(DbRow["ID"].ToString());
            BudgetLevel = DbRow["BudgetLevel"].ToString();
            RPIO = DbRow["RPIO"].ToString();
            AH = DbRow["AH"].ToString();
            BFY = DbRow["BFY"].ToString();
            Fund = new Fund(DbRow["Fund"].ToString(), DbRow["BFY"].ToString());
            Org = new Org(DbRow["Org"].ToString());
            RC = new RC(DbRow["RC"].ToString());
            Account = new Account(Source.Accounts, Provider.SQLite, Fund.Code, DbRow["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(DbRow["BOC"].ToString());
            Parameter = GetDataFields();
            Amount = decimal.Parse(DbRow["Amount"].ToString());
            Parameter = GetDataFields();
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        public PRC(int id, string bl, string rpio, string bfy, string fund, string ah, string org, string rc, string code, string boc, decimal amount)
        {
            BudgetLevel = bl;
            ID = id;
            RPIO = rpio;
            AH = ah;
            BFY = bfy;
            Fund = new Fund(Source.Funds, Provider.SQLite, fund, bfy);
            RC = new RC(rc);
            Org = new Org(org);
            Account = new Account(Source.Accounts, Provider.SQLite, Fund.Code, code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Parameter = GetDataFields();
            Amount = amount;
            Parameter = GetDataFields();
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        public PRC(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            BudgetLevel = row["BudgetLevel"].ToString();
            RPIO = row["RPIO"].ToString();
            AH = row["AH"].ToString();
            BFY = row["BFY"].ToString();
            Fund = new Fund(row["Fund"].ToString(), row["BFY"].ToString());
            Org = new Org(row["Org"].ToString());
            RC = new RC(row["RC"].ToString());
            Account = new Account(Source.Accounts, Provider.SQLite, Fund.Code, row["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(row["BOC"].ToString());
            Parameter = GetDataFields();
            Amount = decimal.Parse(row["Amount"].ToString());
            Parameter = GetDataFields();
            ProgramProjectCode = Account.ProgramProjectCode;
            ProgramProjectName = Account.ProgramProjectName;
            ProgramArea = Account.ProgramArea;
            NPM = Account.NPM;
            NpmCode = Account.NpmCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public string BudgetLevel { get; set; }

        public string RPIO { get; set; }

        public string BFY { get; set; }

        public Fund Fund { get; }

        public string AH { get; }

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

        internal Dictionary<string, object> Parameter { get; set; }

        // METHODS
        internal Dictionary<string, object> GetDataFields()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>() { ["ID"] = ID, ["BudgetLevel"] = BudgetLevel, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = Account.Code, };
                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataRow GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

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
            return Account.Code;
        }

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
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
                DialogResult _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static PRC Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new PRC(datarow);
            }
            catch (Exception ex)
            {
                DialogResult _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Dictionary<string, object> p)
        {
            try
            {
                InsertData insert = Info.Insert;
                insert(Source.PRC, Provider.SQLite, p);
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
                InsertData update = new InsertData(Info.Insert);
                update(Source.PRC, Provider.SQLite, p);
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
                InsertData update = new InsertData(Info.Insert);
                update(Source.PRC, Provider.SQLite, p);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}