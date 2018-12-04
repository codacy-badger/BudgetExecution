// <copyright file="PRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class PRC : IDataBuilder, IPRC, IAccount
    {
        // CONSTRUCTORS
        public PRC()
        {
            Source = Source.PRC;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
        }

        public PRC(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
        }

        public PRC(Provider provider, Dictionary<string, object> param) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source.PRC, Provider, param);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            Data = DbData.Data;
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

        public PRC(DataRow row) : this()
        {
            Data = row;
        }

        public PRC(Dictionary<string, object> data) : this()
        {
            Parameter = data;
            DbData = new DataBuilder(Source.PRC, Parameter);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Records;
            Data = DbData.Data;
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

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public string[] Columns { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public int ID { get; set; }

        public string BudgetLevel { get; set; }

        public string RPIO { get; set; }

        public string BFY { get; set; }

        public Fund Fund { get; set; }

        public string FundCode { get; }

        public Org Org { get; }

        public RC RC { get; }

        public Account Account { get; set; }

        public decimal Amount { get; set; }

        public BOC BOC { get; set; }

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

        public string GetProgramProjectCode()
        {
            return Code.Substring(5, 2);
        }

        public Dictionary<string, object> AsDictionary()
        {
            try
            {
                return new Dictionary<string, object> { ["ID"] = ID, ["BudgetLevel"] = BudgetLevel, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["AH"] = AH, ["Org"] = Org, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = Code };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
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
