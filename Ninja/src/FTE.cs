using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace BudgetExecution
{
    public class FTE : IPRC
    {
        public FTE()
        {
        }

        public FTE(DataRow datarow)
        {
            ID = int.Parse(datarow["ID"].ToString());
            BudgetLevel = datarow["BudgetLevel"].ToString();
            RPIO = datarow["RPIO"].ToString();
            BFY = datarow["BFY"].ToString();
            Fund = new Fund(datarow["Fund"].ToString(), datarow["BFY"].ToString());
            RC = new RC(datarow["RC"].ToString());
            Org = new Org(datarow["Org"].ToString());
            Account = new Account(datarow["Code"].ToString());
            Code = Account.Code;
            BOC = new BOC(datarow["BOC"].ToString());
            Amount = decimal.Parse(datarow["Amount"].ToString());
            NpmCode = Account.NPM;
            ProgramProjectCode = Account.ProgramProjectCode;
            Goal = Account.Goal;
            GoalName = Account.GoalName;
            Objective = Account.Objective;
            ObjectiveName = Account.ObjectiveName;
            FteParameter = GetParameter();
        }
        public FTE(Source source, Provider provider, Dictionary<string, object> param)
        {
            DbData = new DataBuilder(source, provider, param);
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
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
        public string NpmCode { get; }
        public string ProgramProjectCode { get; }
        public string Goal { get; }
        public string GoalName { get; }
        public string Objective { get; }
        public string ObjectiveName { get; }
        DataBuilder DbData { get; }
        PrcMetric Metric { get; }
        public DataTable Table { get; }
        public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }
        public PRC[] Data { get; }
        public Dictionary<string, string[]> DataElement { get; }
        public DataSet E6 { get; }
        public Dictionary<string, decimal> FundData { get; }
        public Dictionary<string, decimal> GoalInfo { get; }
        public Dictionary<string, decimal> NpmData { get; }
        public Dictionary<string, decimal> ObjectiveData { get; }
        public Dictionary<string, decimal> ProgramData { get; }
        public Dictionary<string, decimal> ProjectData { get; }
        BOC IPRC.BOC { get; }
        private Dictionary<string, object> FteParameter { get; set; }

        // METHODS
        Dictionary<string, object> GetParameter()
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
        public DataTable FilterTable(DataTable table, string column, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public decimal GetAverage(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }
        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public int GetCount(DataTable table)
        {
            try
            {
                return table.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1;
            }
        }
        public Dictionary<string, string[]> GetDataElements(DataTable table)
        {
            var data = new Dictionary<string, string[]>();
            foreach (DataColumn dc in table.Columns)
            {
                if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount"))
                    continue;
                data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
            }
            if (data.ContainsKey("ID")) data.Remove("ID");
            if (data.ContainsKey("Amount")) data.Remove("Amount");
            return data;
        }
        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
        {
            try
            {
                var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                return new Tuple<DataTable, PRC[], decimal, int>(query, GetPrcArray(query), GetTotal(query), GetCount(query));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public decimal[] GetMetrics(DataTable table)
        {
            var count = GetCount(table);
            return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
        }
        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
        {
            try
            {
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach (string filter in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = (stat[0] / stat[1]) * 100;
                    info.Add(filter, stat);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column, string filter)
        {
            try
            {
                string[] list = GetCodes(table, column);
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach (string ftr in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = (stat[0] / stat[1]) * 100;
                    info.Add(filter, stat);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => new PRC()).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }
        public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
        {
            try
            {
                var list = GetCodes(table, column);
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string ftr in list)
                {
                    var query = table.AsEnumerable()
                        .Where(p => p.Field<string>(column).Equals(filter))
                        .Sum(p => p.Field<decimal>("Amount"));
                    if (query > 0)
                        info.Add(filter, query);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string filter in filters)
                {
                    var query = table.AsEnumerable()
                        .Where(p => p.Field<string>(column).Equals(filter))
                        .Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    if (query > 0)
                        info.Add(filter, query);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
    }
}
    
