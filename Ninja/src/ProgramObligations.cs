using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetExecution
{
    public class ProgramObligations
    {
        // CONSRTUCTORS
        public ProgramObligations()
        {
            Source = Source.ProgramObligations;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        public ProgramObligations(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Records = Table.AsEnumerable().Select(o => o).ToArray();
            DbRow = Records[0];
        }

        public ProgramObligations(DataRow dr)
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
            Obligations = decimal.Parse(dr["Obligations"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow[] Records { get; set; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public PRC PRC { get; set; }

        public string BFY { get; set; }

        public BOC BOC { get; set; }

        public string ProgramProjectCode { get; set; }

        public string DCN { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public Fund Fund { get; set; }

        public decimal Amount { get; set; }

        public Org Org { get; set; }

        public RC RC { get; set; }

        public string RPIO { get; set; }

        public decimal DollarAmount { get; set; }

        public decimal OpenCommitments { get; set; }

        public decimal Obligations { get; set; }

        // METHODS
        internal Dictionary<string, object> GetDataFields()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object> { ["ID"] = ID, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = ProgramProjectCode };
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DataRow GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                return new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
            }
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                Account account = new Account(source, provider, param["Fund"].ToString(), param["Code"].ToString());
                if(!param.ContainsKey("FundName") ||
                   param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if(!param.ContainsKey("Org") ||
                   param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if(!param.ContainsKey("ProgramProject") ||
                   param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if(!param.ContainsKey("ProgramArea") ||
                   param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if(!param.ContainsKey("Goal") ||
                   param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if(!param.ContainsKey("Objective") ||
                   param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Obligation Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Obligation(datarow);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static Obligation Select(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                DataRow query = new DataBuilder(source, provider, param).Table.AsEnumerable().Select(p => p).First();
                return new Obligation(query);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(p, source, provider, Sql.INSERT);
                string cmd = query.InsertStatement;
                SQLiteConnection conn = (SQLiteConnection) query.GetDataConnection(Provider.SQLite);
                conn.Open();
                using(conn)
                {
                    SQLiteCommand insert = (SQLiteCommand) query.GetDataCommand(cmd, conn);
                    insert.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, Provider.SQLite, Sql.UPDATE, p);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal) p["Amount"]} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn);
                    update.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(p, source, provider, Sql.UPDATE);
                string cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal) p["Amount"]} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Dictionary<string, object> p)
        {
            try
            {
                SQLiteQuery query = new SQLiteQuery(source, Provider.SQLite, Sql.DELETE, p);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.DataConnection;
                using(conn)
                {
                    SQLiteCommand delete = query.GetDataCommand(cmd, conn);
                    delete.ExecuteNonQuery();
                }
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
                Query query = new Query(p, source, provider, Sql.DELETE);
                string cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int) p["ID"]};";
                SQLiteConnection conn = query.GetDataConnection(Provider.SQLite) as SQLiteConnection;
                using(conn)
                {
                    SQLiteCommand update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update?.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
