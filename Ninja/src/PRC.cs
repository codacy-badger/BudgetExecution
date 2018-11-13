// <copyright file="PRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Linq;

    public class PRC : IPRC, IAccount
    {
        // CONSTRUCTORS
        public PRC()
        {
        }

        public PRC(Provider provider = Provider.SQLite)
        {
            Source = Source.PRC;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Allocation = DbData.Records;
        }

        public PRC(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider, param);
            Allocation = DbData.Records;
            if (DbData.Table.Rows.Count == 1)
            {
                Data = DbData.Table.AsEnumerable().Select(p => p).Single();
                ID = int.Parse(Data["ID"].ToString());
                BudgetLevel = Data["BudgetLevel"].ToString();
                RPIO = Data["RPIO"].ToString();
                AH = Data["AH"].ToString();
                BFY = Data["BFY"].ToString();
                Fund = new Fund(Data["FundCode"].ToString(), Data["BFY"].ToString());
                Org = new Org(Data["Org"].ToString());
                RC = new RC(Data["RC"].ToString());
                Account = new Account(Provider.SQLite, BFY, Fund.Code, Data["Code"].ToString());
                Code = Account.Code;
                BOC = new BOC(Data["BOC"].ToString());
                Amount = decimal.Parse(Data["Amount"].ToString());
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
        }

        public PRC(int id, string bl, string rpio, string bfy, string fund, string ah, string org, string rc, string code, string boc, decimal amount)
        {
            ID = id;
            BudgetLevel = bl;
            RPIO = rpio;
            BFY = bfy;
            Fund = new Fund(Source.Funds, Provider.SQLite, new Dictionary<string, object> { ["BFY"] = bfy, ["Code"] = fund });
            FundCode = Fund.Code;
            AH = ah;
            RC = new RC(rc);
            Org = new Org(org);
            Account = new Account(Provider.SQLite, BFY, Fund.Code, code);
            Code = Account.Code;
            BOC = new BOC(boc, amount);
            Amount = amount;
            Parameter = GetDataDictionary();
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
            Fund = new Fund(row["FundCode"].ToString(), row["BFY"].ToString());
            FundCode = Fund.Code;
            Org = new Org(row["Org"].ToString());
            RC = new RC(row["RC"].ToString());
            Account = new Account(Provider.SQLite, BFY, Fund.Code, row["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(row["BOC"].ToString());
            Parameter = GetDataDictionary();
            Amount = decimal.Parse(row["Amount"].ToString());
            Parameter = GetDataDictionary();
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

        public DataRow[] Allocation { get; }

        public DataRow Data { get; }

        public int ID { get; set; }

        public string BudgetLevel { get; set; }

        public string RPIO { get; set; }

        public string BFY { get; set; }

        public Fund Fund { get; }

        public string FundCode { get; }

        public Org Org { get; }

        public RC RC { get; }

        public Account Account { get; }

        public decimal Amount { get; set; }

        public BOC BOC { get; }

        public string AH { get; }

        public FTE FTE { get; set; }

        public string NpmCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string GoalName { get; }

        public string ObjectiveName { get; }

        internal Dictionary<string, object> Parameter { get; set; }

        public string Code { get; set; }

        public string NPM { get; set; }

        public string ProgramProjectCode { get; }

        public string Goal { get; }

        public string Objective { get; }

        // METHODS
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

        internal Dictionary<string, object> GetDataDictionary()
        {
            try
            {
                return new Dictionary<string, object> { ["ID"] = ID, ["BudgetLevel"] = BudgetLevel, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["AH"] = AH, ["Org"] = Org, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = Account.Code };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataRow GetData(Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(Source, Provider, param).Table.AsEnumerable().Select(p => p).First();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return Account.Code;
        }

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(provider, param["BFY"].ToString(), param["Fund"].ToString(), param["Code"].ToString());
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

                if (!param.ContainsKey("Goal")|| param["Goal"] == null)
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static PRC Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new PRC(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
