// <copyright file="BudgetLevel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class BudgetLevel
    {
        public BudgetLevel()
        {
        }

        public BudgetLevel(Source source = Source.BudgetLevels, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider);
            Table = DbData.Table;
            Data = Table.Rows[0];
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        public BudgetLevel(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider, param);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(p => p).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                RPIO = Data["RPIO "].ToString();
                BFY = Data["BFY"].ToString();
                Fund = new Fund(Data["Fund"].ToString(), BFY);
                Org = new Org(Data["Org"].ToString());
                RC = new RC(Data["RC"].ToString());
                ProgramProjectCode = Data["ProgramProjectCode"].ToString();
                BOC = new BOC(Data["BOC"].ToString());
                FOC = Data["FOC"].ToString();
                FocName = Data["FocName"].ToString();
                Amount = decimal.Parse(Data["Obligations"].ToString());
            }
        }

        public BudgetLevel(DataRow dr)
        {
            Data = dr;
            ID = int.Parse(Data["ID"].ToString());
            RPIO = Data["RPIO "].ToString();
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["Fund"].ToString(), BFY);
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            FOC = Data["FOC"].ToString();
            FocName = Data["FocName"].ToString();
            Amount = decimal.Parse(Data["Obligations"].ToString());
        }

        // Properties
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow[] Records { get; }

        public DataRow Data { get; }

        public string AH { get; set; }

        public string AhName { get; set; }

        public int ID { get; set; }

        public string BFY { get; set; }

        public BOC BOC { get; set; }

        public string Level { get; set; }

        public string BocName { get; set; }

        public string ProgramProjectCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string ProgramAreaName { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public Fund Fund { get; set; }

        public string FundName { get; set; }

        public decimal Amount { get; set; }

        public Org Org { get; set; }

        public string OrgName { get; set; }

        public RC RC { get; set; }

        public string Division { get; set; }

        public string RPIO { get; set; }

        public decimal Authority { get; set; }

        public decimal Budgeted { get; set; }

        public decimal Posted { get; set; }

        public decimal CarryIn { get; set; }

        public decimal CarryOut { get; set; }

        public decimal Commitments { get; set; }

        public decimal OpenCommitments { get; set; }

        public decimal Obligations { get; set; }

        public decimal ULO { get; set; }

        // METHODS
        internal Dictionary<string, object> GetDataFields()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object> { ["ID"] = ID, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = ProgramProjectCode };
                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string[] GetDataFields(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                try
                {
                    return table.GetColumnNames();
                }
                catch (SystemException ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataRow[] GetDataRecords(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                return new DataBuilder(source, provider, p).Table.AsEnumerable().Select(o => o).ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string[] GetFields()
        {
            try
            {
                Dictionary<string, object> prc = GetDataFields();

                return prc.Keys.ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal object[] GetValues()
        {
            try
            {
                Dictionary<string, object> param = GetDataFields();
                return param.Values.ToArray();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(source, provider, param["BFY"].ToString(), param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("FundName")
                    || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org")
                    || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProject")
                    || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea")
                    || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal")
                    || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective")
                    || param["Objective"] == null)
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

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.InsertCommand;
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
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.DeleteCommand;
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
