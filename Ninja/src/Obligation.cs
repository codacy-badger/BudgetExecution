using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Obligation : IObligation
    {
        public Obligation()
        {
        }

        public Obligation(Source source = Source.ProgramObligations, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider, param);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        public Obligation(Source source, Provider provider, Dictionary<string, object> param, string rpio, string fy, string fund, string org, string rc, string code, string boc, string foc, string focname, string doctype, string system, string prn, string dcnprefix, string grantnumber, string siteprojcode, string siteprojname, string dcn, decimal c, decimal o)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider, param);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            Records = Table.AsEnumerable().Select(p => p).ToArray();
            ID = int.Parse(Records[0]["ID"].ToString());
            RPIO = rpio;
            BFY = fy;
            Fund = new Fund(source, provider, fund, fy);
            Org = new Org(org);
            RC = new RC(rc);
            ProgramProjectCode = Records[0]["ProgramProjectCode"].ToString();
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

        // Properties
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow[] Records { get; }

        public DataRow DbRow { get; }

        public int ID { get; set; }

        public PRC[] PRC { get; set; }

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
                Dictionary<string, object> param = new Dictionary<string, object> { ["ID"] = ID, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = ProgramProjectCode };
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string[] GetDataFields(DataTable table)
        {
            if(table.Rows.Count > 0)
            {
                try
                {
                    return table.GetColumnNames();
                }
                catch(SystemException ex)
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
                if(!param.ContainsKey("FundName") || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if(!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if(!param.ContainsKey("ProgramProject") || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if(!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if(!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if(!param.ContainsKey("Objective") || param["Objective"] == null)
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

        public static Obligation Select(Dictionary<string, object> param, Source source = Source.ProgramObligations, Provider provider = Provider.SQLite)
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

        public static void Insert(Dictionary<string, object> p)
        {
            try
            {
                Insert insert = Info.Insert;
                insert(Source.ProgramObligations, Provider.SQLite, p);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Dictionary<string, object> p)
        {
            try
            {
                Insert update = Info.Update;
                update(Source.ProgramObligations, Provider.SQLite, p);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Dictionary<string, object> p)
        {
            try
            {
                Insert delete = Info.Delete;
                delete(Source.ProgramObligations, Provider.SQLite, p);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
