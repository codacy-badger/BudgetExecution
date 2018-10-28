using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BudgetExecution
{
    [ SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty") ]
    public class FTE : PRC, IPRC
    {
        public FTE()
        {
        }

        public FTE(DataRow datarow) : base(datarow)
        {
            FteParameter = GetDataDictionary();
        }

        public FTE(Source source, Provider provider, Dictionary<string, object> param)
        {
            DbData = new DataBuilder(source, provider, param);
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
        }

        // PROPERTIES
        public DataTable Table { get; }

        public Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }

        public new PRC[] Data { get; }

        public Dictionary<string, string[]> DataElement { get; }

        public DataSet E6 { get; }

        public Dictionary<string, decimal> FundData { get; }

        public Dictionary<string, decimal> GoalInfo { get; }

        public Dictionary<string, decimal> NpmData { get; }

        public Dictionary<string, decimal> ObjectiveData { get; }

        public Dictionary<string, decimal> ProgramData { get; }

        public Dictionary<string, decimal> ProjectData { get; }

        private new DataBuilder DbData { get; }

        private PrcMetric Metric { get; }

        private Dictionary<string, object> FteParameter { get; }

        BOC IPRC.BOC { get; }

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

        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
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
                return table.Rows.Count;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        public Dictionary<string, string[]> GetDataElements(DataTable table)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach(DataColumn dc in table.Columns)
            {
                if(dc.ColumnName.Equals("ID") ||
                   dc.ColumnName.Equals("Amount"))
                {
                    continue;
                }

                data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
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

        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
        {
            try
            {
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                return new Tuple<DataTable, PRC[], decimal, int>(query, GetPrcArray(query), GetTotal(query), GetCount(query));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal[] GetMetrics(DataTable table)
        {
            int count = GetCount(table);
            return new[]
            {
                GetTotal(table),
                count,
                GetAverage(table)
            };
        }

        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
        {
            try
            {
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach(string filter in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = stat[0] / stat[1] * 100;
                    info.Add(filter, stat);
                }

                return info;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column, string filter)
        {
            try
            {
                string[] list = GetCodes(table, column);
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach(string ftr in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = stat[0] / stat[1] * 100;
                    info.Add(filter, stat);
                }

                return info;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
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

        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
        {
            try
            {
                string[] list = GetCodes(table, column);
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string ftr in list)
                {
                    decimal query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Sum(p => p.Field<decimal>("Amount"));
                    if(query > 0)
                    {
                        info.Add(filter, query);
                    }
                }

                return info;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string filter in filters)
                {
                    decimal query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    if(query > 0)
                    {
                        info.Add(filter, query);
                    }
                }

                return info;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
