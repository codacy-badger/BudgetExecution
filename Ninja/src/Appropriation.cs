// <copyright file="Appropriation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Appropriation" />
    /// </summary>
    public class Appropriation : IBudgetAuthority
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Appropriation"/> class.
        /// </summary>
        public Appropriation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appropriation"/> class.
        /// </summary>
        /// <param name="fundcode">The fundcode<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
        public Appropriation(string fundcode, string bfy)
        {
            Code = fundcode;
            Fund = new Fund(Source.Funds, Provider.SQLite, new Dictionary<string, object> { ["Code"] = fundcode, ["BFY"] = bfy });
            FiscalYear = bfy;
            Name = Fund.Name;
            Title = Fund.Title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appropriation"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="fundcode">The fundcode<see cref="string"/></param>
        /// <param name="bfy">The bfy<see cref="string"/></param>
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
        /// <summary>
        /// Gets the Fund
        /// </summary>
        public Fund Fund { get; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the Title
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets or sets the Allocation
        /// </summary>
        public PRC[] Allocation { get; set; }

        /// <summary>
        /// Gets the Average
        /// </summary>
        public decimal Average { get; }

        /// <summary>
        /// Gets the BocCodes
        /// </summary>
        public string[] BocCodes { get; }

        /// <summary>
        /// Gets or sets the BocData
        /// </summary>
        public Dictionary<string, decimal> BocData { get; set; }

        /// <summary>
        /// Gets the Count
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets the FiscalYear
        /// </summary>
        public string FiscalYear { get; }

        /// <summary>
        /// Gets the FTE
        /// </summary>
        public FTE[] FTE { get; }

        /// <summary>
        /// Gets or sets the GoalData
        /// </summary>
        public Dictionary<string, decimal> GoalData { get; set; }

        /// <summary>
        /// Gets or sets the NpmData
        /// </summary>
        public Dictionary<string, decimal> NpmData { get; set; }

        /// <summary>
        /// Gets or sets the ObjectiveData
        /// </summary>
        public Dictionary<string, decimal> ObjectiveData { get; set; }

        /// <summary>
        /// Gets or sets the PrcData
        /// </summary>
        public Tuple<DataTable, PRC[], decimal, int> PrcData { get; set; }

        /// <summary>
        /// Gets or sets the ProgramData
        /// </summary>
        public Dictionary<string, decimal> ProgramData { get; set; }

        /// <summary>
        /// Gets the Project
        /// </summary>
        public string[] Project { get; }

        /// <summary>
        /// Gets or sets the ProjectData
        /// </summary>
        public Dictionary<string, decimal> ProjectData { get; set; }

        /// <summary>
        /// Gets the Total
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Gets the Data
        /// </summary>
        internal DataRow[] Data { get; }

        /// <summary>
        /// Gets the Metric
        /// </summary>
        public PrcMetric Metric { get; }

        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; }

        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <summary>
        /// Gets the Amount
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// The GetCodes
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
        /// The GetDataValues
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
        /// The GetMetrics
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public decimal[] GetMetrics(DataTable table)
        {
            int count = GetCount(table);
            return new[] { GetTotal(table), count, GetAverage(table) };
        }

        /// <summary>
        /// The GetPrcArray
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
        /// The GetProgramElements
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
        /// The GetTotal
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
        /// The FilterTable
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
        /// The GetAverage
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
        /// The GetCodes
        /// </summary>
        /// <returns></returns>
        public Tuple<string[], string[], string[], string[], string[]> GetCodes()
        {
            return new Tuple<string[], string[], string[], string[], string[]>(ProgramElements["BOC"], ProgramElements["Code"], ProgramElements["NPM"], ProgramElements["ProgramArea"], ProgramElements["ProgramProjectCode"]);
        }

        /// <summary>
        /// The GetCount
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
        /// The GetDataValues
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
        /// The GetFteTotal
        /// </summary>
        /// <returns></returns>
        public decimal GetFteTotal()
        {
            return PrcData.Item1.AsEnumerable().Select(p => p).Sum(p => p.Field<decimal>("Amount"));
        }

        /// <summary>
        /// The GetMetrics
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
        /// The GetMetrics
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
        /// The GetTotals
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
        /// The GetTotals
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
        /// The GetFTE
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
