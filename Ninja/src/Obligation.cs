// <copyright file="Obligation.cs" company="PlaceholderCompany">
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

    public class Obligation : IObligation
    {
        private DataRow Data;
        private Source Source;
        private Provider Provider;

        public Obligation()
        {
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            Data = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param, string rpio, string fy, string fund, string org, string rc, string code, string boc, string foc, string focname, string doctype, string system, string prn, string dcnprefix, string grantnumber, string siteprojcode, string siteprojname, string dcn, decimal c, decimal o)
        {
            Source = source;
            Provider = provider;
            Data = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
            ID = int.Parse(Data["ID"].ToString());
            RPIO = rpio;
            BFY = fy;
            Fund = new Fund(source, provider, fund, fy);
            Org = new Org(org);
            RC = new RC(rc);
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            BOC = new BOC(boc);
            FOC = foc;
            FocName = focname;
            Amount = o;
        }

        public Obligation(DataRow dr)
        {
            ID = int.Parse(dr["ID"].ToString());
            RPIO = dr["RPIO "].ToString();
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            ProgramProjectCode = dr["ProgramProjectCode"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            FOC = dr["FOC"].ToString();
            FocName = dr["FocName"].ToString();
            Amount = decimal.Parse(dr["ObligationAmount"].ToString());
        }

        //Properties
        public int ID { get; set; }

        public PRC PRC { get; set; }

        public string BFY { get; set; }

        public BOC BOC { get; set; }

        public string ProgramProjectCode { get; set; }

        public string DocumentControlNumber { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public Fund Fund { get; set; }

        public decimal Amount { get; set; }

        public Org Org { get; set; }

        public RC RC { get; set; }

        public string RPIO { get; set; }

        // METHODS
        internal Dictionary<string, object> GetParamData()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>()
                {
                    ["ID"] = ID,
                    ["RPIO"] = RPIO,
                    ["BFY"] = BFY,
                    ["Fund"] = Fund.Code,
                    ["RC"] = RC,
                    ["BOC"] = BOC.Code,
                    ["Code"] = ProgramProjectCode
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

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
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

        public static PRC Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new PRC(datarow);
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
                var param = GetInsertionColumns(source, provider, p);
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

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
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

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
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
