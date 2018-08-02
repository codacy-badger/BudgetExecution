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

        public Obligation()
        {
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbRow = new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param, string rpio, string fy, string fund, string org, string rc, string code, string boc, string foc, string focname, string doctype, string system, string prn, string dcnprefix, string grantnumber, string siteprojcode, string siteprojname, string dcn, decimal c, decimal o)
        {
            Source = source;
            Provider = provider;
            DbRow = new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
            ID = int.Parse(DbRow["ID"].ToString());
            RPIO = rpio;
            BFY = fy;
            Fund = new Fund(source, provider, fund, fy);
            Org = new Org(org);
            RC = new RC(rc);
            ProgramProjectCode = DbRow["ProgramProjectCode"].ToString();
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
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

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
        internal Dictionary<string, object> GetDataFields()
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertColumns(Source source, Provider provider, Dictionary<string, object> param)
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
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Obligation Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, Provider.SQLite, p).DbTable.AsEnumerable().Select(prc => prc).First();
                return new Obligation(datarow);
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Obligation Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var query = new DataBuilder(source, provider, param).DbTable.AsEnumerable().Select(p => p).First();
                return new Obligation(query);
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Source source, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertColumns(source, Provider.SQLite, p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new SQLiteQuery(source, param);
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var insert = query.InsertCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertColumns(source, provider, p);
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn);
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Dictionary<string, object> p)
        {
            try
            {
                var query = new SQLiteQuery(source, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using (conn)
                {
                    var delete = query.GetDataCommand(cmd, conn);
                    delete.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

    }


}
