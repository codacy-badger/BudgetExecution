using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class RegionalAuthority : IBudgetAuthority
    {
        // CONSTRUCTORS
        public RegionalAuthority()
        {
            DbData = new DataBuilder(Source.RegionalAccounts, Provider.SQLite, new Dictionary<string, object> { ["BFY"] = FiscalYear });
            TableFilter = DataBuilder.FilterRecords;
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
            Total = Metric.Total;
            Count = Metric.Count;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(Table);
            FundData = Metric.FundTotals;
            BocData = Metric.BocTotals;
            NpmData = Metric.NpmTotals;
            GoalData = Metric.GoalTotals;
            ProgramData = Metric.ProgramAreaTotals;
            ProjectData = Metric.ProgramProjectTotals;
            if(ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(Table);
            }
        }

        // PROPERTIES
        public static string FiscalYear { get; set; } = "2018";

        public decimal Total { get; }

        public decimal Average { get; set; }

        public Dictionary<string, decimal> BocData { get; }

        public int Count { get; }

        public DataBuilder DbData { get; set; }

        public TableDelegate TableFilter { get; }

        public FTE[] FTE { get; }

        public Dictionary<string, decimal> FundData { get; }

        public Dictionary<string, decimal> GoalData { get; }

        public decimal[] Metrics { get; }

        public Dictionary<string, decimal> NpmData { get; }

        public Dictionary<string, decimal> ObjectiveData { get; }

        public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }

        public Dictionary<string, decimal> ProgramData { get; }

        public Dictionary<string, decimal> ProjectData { get; }

        public DataTable Table { get; }

        public decimal Amount { get; set; }

        public PrcMetric Metric { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        // METHODS
        /// <summary>
        ///     Returns array of strings consisting of unique values within a columns
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <returns>string[]</returns>
        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                string[] list = table.AsEnumerable().Select(p => p.Field<string>(column)).ToArray();
                return list.Select(p => p).Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
        {
            try
            {
                DataTable qtable = FilterTable(table, column, filter);
                return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal[] GetMetrics(DataTable table)
        {
            try
            {
                int count = GetCount(table);
                return new[]
                {
                    GetTotal(table),
                    count,
                    GetAverage(table)
                };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return new[]
                {
                    -1m
                };
            }
        }

        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => new PRC()).ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                foreach(DataColumn dc in table.Columns)
                {
                    if(dc.ColumnName.Equals("ID") ||
                       dc.ColumnName.Equals("Amount"))
                    {
                        continue;
                    }

                    data.Add(dc.ColumnName, GetCodes(dc.ColumnName));
                }

                if(data.ContainsKey("ID"))
                {
                    data.Remove("ID");
                }

                if(data.ContainsKey("Amount"))
                {
                    data.Remove("Amount");
                }

                return data;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Select(p => p).Sum(p => p.Field<decimal>("Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        // METHODS
        public DataTable FilterTable(DataTable table, string column, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal GetAverage(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        public string[] GetCodes(string filter)
        {
            try
            {
                return DbData.Table.AsEnumerable().Select(p => p.Field<string>(filter)).Distinct().ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public int GetCount(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal decimal GetRatio(decimal t1, decimal t2)
        {
            try
            {
                return t1 / t2;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        internal Dictionary<string, object> GetSupplemental(int time, decimal awards, decimal ot, PRC training)
        {
            try
            {
                Dictionary<string, object> allocation = new Dictionary<string, object>();
                allocation.Add("TimeOff", time);
                allocation.Add("Awards", awards);
                allocation.Add("OverTime", ot);
                allocation.Add("Training", training);
                return allocation;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal void UpdateAmount(Source source, DataRow row, decimal amount2)
        {
            try
            {
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("ID", row["ID"]);
                parameter.Add("Amount", amount2);
                Query query = new Query(parameter, source, Provider.SQLite, Sql.UPDATE);
                DbCommand update = query.UpdateCommand;
                update.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void UpdateAmount(Dictionary<string, object> p, decimal amount2)
        {
            try
            {
                if(p.ContainsKey("Amount"))
                {
                    p.Remove("Amount");
                }

                p.Add("Amount", amount2);
                Query query = new Query(p, Source.PRC, Provider.SQLite, Sql.UPDATE);
                DbCommand update = query.UpdateCommand;
                update.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal int VerifyDataRow(DataTable table, Dictionary<string, object> p)
        {
            try
            {
                DataTable query = table.AsEnumerable().Where(r => r.Field<string>("BFY").Equals(p["BFY"])).Where(r => r.Field<string>("Fund").Equals(p["Fund"])).Where(r => r.Field<string>("Code").Equals(p["Code"])).Where(r => r.Field<string>("Org").Equals(p["Org"])).Where(r => r.Field<string>("BOC").Equals(p["BOC"])).Select(r => r).CopyToDataTable();
                DataRow row = query.Rows[0];
                return (int) row["Id"];
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal FTE[] GetFTE(DataTable table)
        {
            try
            {
                DataTable fteTable = table.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable();
                FTE[] fteArray = new FTE[fteTable.Rows.Count];
                for(int i = 0; i < fteTable.Rows.Count; i++)
                {
                    fteArray[i] = new FTE(fteTable.Rows[i]);
                }

                return fteArray;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
