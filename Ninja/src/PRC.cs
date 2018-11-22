// <copyright file="PRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IPRC" />
    /// <seealso cref="BudgetExecution.IAccount" />
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

        public PRC(Provider provider, Dictionary<string, object> param)
        {
            Source = Source.PRC;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Allocation = DbData.Records;
            if(DbData.Table.Rows.Count == 1)
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
            Parameter = AsDictionary();
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
            Parameter = AsDictionary();
            Amount = decimal.Parse(row["Amount"].ToString());
            Parameter = AsDictionary();
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
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            try
            {
                return Code;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns></returns>
        public string GetGoal()
        {
            try
            {
                char[] goal = Code.Substring(0, 1).ToCharArray();
                return goal.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the name of the goal.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetGoalName(string code)
        {
            try
            {
                return Info.GetGoalName(code);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the NPM code.
        /// </summary>
        /// <returns></returns>
        public string GetNpmCode()
        {
            try
            {
                char[] npm = Code.Substring(2, 1).ToCharArray();
                return npm.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the objective.
        /// </summary>
        /// <returns></returns>
        public string GetObjective()
        {
            try
            {
                return Code.Substring(1, 2);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the name of the objective.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetObjectiveName(string code)
        {
            try
            {
                return Info.GetObjectiveName(code);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <returns></returns>
        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }

        /// <summary>
        /// Gets the data dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> AsDictionary()
        {
            try
            {
                return new Dictionary<string, object> { ["ID"] = ID, ["BudgetLevel"] = BudgetLevel, ["RPIO"] = RPIO,
                    ["BFY"] = BFY, ["Fund"] = Fund.Code, ["AH"] = AH, ["Org"] = Org, ["RC"] = RC,
                    ["BOC"] = BOC.Code, ["Code"] = Account.Code };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal DataRow GetData(Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(Source, Provider, param).Table.AsEnumerable().Select(p => p).First();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            try
            {
                return Account.Code;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return string.Empty;
            }
        }

        /// <summary>
        /// Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static PRC Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new PRC(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PRC, provider, Sql.INSERT, p);
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

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PRC, provider, Sql.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Deletes the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.PRC, provider, Sql.DELETE, p);
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
