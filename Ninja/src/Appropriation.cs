// <copyright file="Appropriation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Appropriation : IBudgetAuthority
    {
        // CONSTRUCTORS
        public Appropriation()
        {
        }

        public Appropriation(string fundcode, string bfy)
        {
            Code = fundcode;
            Fund = new Fund(Source.Funds, Provider.SQLite, new Dictionary<string, object> { ["Code"] = fundcode, ["BFY"] = bfy });
            FiscalYear = bfy;
            Name = Fund.Name;
            Title = Fund.Title;
        }

        public Appropriation(Source source, Provider provider, string fundcode, string bfy) : this(fundcode, bfy)
        {
            DbData = new DataBuilder(source, provider, new Dictionary<string, object> { ["Fund"] = Fund.Code, ["BFY"] = bfy });
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
            Allocation = GetPrcArray(Table);
            Total = Metric.Total;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(Table);
            BocCodes = ProgramElements["BOC"];
            if(BocCodes.Contains("17"))
            {
                FTE = GetFTE(Table);
            }

            Count = Table.Rows.Count;
            BocData = Metric.BocTotals;
            NpmData = Metric.NpmTotals;
            ProgramData = Metric.ProgramAreaTotals;
            GoalData = Metric.GoalTotals;
        }

        // PROPERTIES
        public Fund Fund { get; }

        public string Code { get; }

        public string Name { get; }

        public string Title { get; }

        public DataBuilder DbData { get; }

        public PRC[] Allocation { get; set; }

        public decimal Average { get; }

        public string[] BocCodes { get; }

        public Dictionary<string, decimal> BocData { get; set; }

        public int Count { get; }

        public string FiscalYear { get; }

        public FTE[] FTE { get; }

        public Dictionary<string, decimal> GoalData { get; set; }

        public Dictionary<string, decimal> NpmData { get; set; }

        public Dictionary<string, decimal> ObjectiveData { get; set; }

        public Tuple<DataTable, PRC[], decimal, int> PrcData { get; set; }

        public Dictionary<string, decimal> ProgramData { get; set; }

        public string[] Project { get; }

        public Dictionary<string, decimal> ProjectData { get; set; }

        public decimal Total { get; }

        internal DataRow[] Data { get; }

        public PrcMetric Metric { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public DataTable Table { get; }

        public decimal Amount { get; }

        // METHODS

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
        {
            try
            {
                DataTable qtable = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public decimal[] GetMetrics(DataTable table)
        {
            int count = GetCount(table);
            return new[] { GetTotal(table), count, GetAverage(table) };
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach(DataColumn dc in table.Columns)
            {
                if(dc.ColumnName.Equals("Id") ||
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Sum(p => p.Field<decimal>("Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Tuple<string[], string[], string[], string[], string[]> GetCodes()
        {
            return new Tuple<string[], string[], string[], string[], string[]>(ProgramElements["BOC"], ProgramElements["Code"], ProgramElements["NPM"], ProgramElements["ProgramArea"], ProgramElements["ProgramProjectCode"]);
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="list"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string[] list, string column)
        {
            foreach(string filter in list)
            {
                try
                {
                    DataTable qtable = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                    return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public decimal GetFteTotal()
        {
            return PrcData.Item1.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="list"></param>
        /// <param name="column"></param>
        /// <returns></returns>
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
                    stat[3] = stat[0] / Total * 100;
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
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
                    stat[3] = stat[0] / Total * 100;
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <param name="filters"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string f in filters)
                {
                    if(GetTotal(table) > 0)
                    {
                        info.Add(f, GetTotal(table));
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

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public FTE[] GetFTE(DataTable table)
        {
            if(table.Rows.Count > 0 &&
               BocCodes.Contains("17"))
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

            return null;
        }
    }
}
