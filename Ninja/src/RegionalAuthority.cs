// <copyright file="RegionalAuthority.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="RegionalAuthority" />
    /// </summary>
    public class RegionalAuthority : IBudgetAuthority
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalAuthority"/> class.
        /// </summary>
        public RegionalAuthority()
        {
            DbData = new DataBuilder(Source.RegionalAccounts, Provider.SQLite, new Dictionary<string, object> { ["BFY"] = FiscalYear });
            TableFilter = (table, col, filter) => DataBuilder.Filter(table, col, filter);
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
        /// <summary>
        /// Gets or sets the FiscalYear
        /// </summary>
        public static string FiscalYear { get; set; } = "2018";

        /// <summary>
        /// Gets the Total
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Gets or sets the Average
        /// </summary>
        public decimal Average { get; set; }

        /// <summary>
        /// Gets the BocData
        /// </summary>
        public Dictionary<string, decimal> BocData { get; }

        /// <summary>
        /// Gets the Count
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        /// Gets the TableFilter
        /// </summary>
        public TableDelegate TableFilter { get; }

        /// <summary>
        /// Gets the FTE
        /// </summary>
        public FTE[] FTE { get; }

        /// <summary>
        /// Gets the FundData
        /// </summary>
        public Dictionary<string, decimal> FundData { get; }

        /// <summary>
        /// Gets the GoalData
        /// </summary>
        public Dictionary<string, decimal> GoalData { get; }

        /// <summary>
        /// Gets the Metrics
        /// </summary>
        public decimal[] Metrics { get; }

        /// <summary>
        /// Gets the NpmData
        /// </summary>
        public Dictionary<string, decimal> NpmData { get; }

        /// <summary>
        /// Gets the ObjectiveData
        /// </summary>
        public Dictionary<string, decimal> ObjectiveData { get; }

        /// <summary>
        /// Gets the PrcData
        /// </summary>
        public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }

        /// <summary>
        /// Gets the ProgramData
        /// </summary>
        public Dictionary<string, decimal> ProgramData { get; }

        /// <summary>
        /// Gets the ProjectData
        /// </summary>
        public Dictionary<string, decimal> ProjectData { get; }

        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets the Metric
        /// </summary>
        public PrcMetric Metric { get; }

        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; }

        /// <summary>
        /// Returns array of strings consisting of unique values within a columns
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns>The <see cref="string[]"/></returns>
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

        /// <summary>
        /// Gets the data values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the metrics.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public decimal[] GetMetrics(DataTable table)
        {
            try
            {
                int count = GetCount(table);
                return new[] { GetTotal(table), count, GetAverage(table) };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return new[] { -1m };
            }
        }

        /// <summary>
        /// Gets the PRC array.
        /// </summary>
        /// <param name="table">The table.</param>
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
        /// Gets the program elements.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Filters the table.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <param name="filter">The filter.</param>
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
        /// Gets the average.
        /// </summary>
        /// <param name="table">The table.</param>
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
        /// Gets the codes.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="table">The table.</param>
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
        /// Gets the ratio.
        /// </summary>
        /// <param name="t1">The t1.</param>
        /// <param name="t2">The t2.</param>
        /// <returns></returns>
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

        /// <summary>
        /// The GetFTE
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="FTE[]"/></returns>
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
