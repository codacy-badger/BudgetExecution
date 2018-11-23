// <copyright file="PrcMetric.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="PrcMetric" />
    /// </summary>
    public class PrcMetric
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="PrcMetric"/> class.
        /// </summary>
        public PrcMetric()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrcMetric"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        public PrcMetric(DataBuilder data)
        {
            DbData = data;
            Table = DbData.Table;
            CarryOver = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2018")).Select(p => p).CopyToDataTable();
            CurrentYear = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2019")).Select(p => p).CopyToDataTable();
            ProgramElements = DbData.ProgramElements;
            Total = GetTotals(Table);
            CarryOverTotal = GetTotals(CarryOver);
            CurrentYearTotal = GetTotals(CurrentYear);
            Count = Table.Rows.Count;
            CarryOverCount = CarryOver.Rows.Count;
            CurrentYearCount = CurrentYear.Rows.Count;
            Metrics = GetMetrics(Table);
            CarryOverMetrics = GetMetrics(CarryOver);
            CurrentYearMetrics = GetMetrics(CurrentYear);
            FundTotals = GetDataTotals(Table, Field.FundName);
            FundMetrics = GetMetrics(Table, Field.FundName);
            BocTotals = GetDataTotals(Table, Field.BocName);
            BocMetrics = GetMetrics(Table, Field.BocName);
            NpmTotals = GetDataTotals(Table, Field.NPM);
            NpmMetrics = GetMetrics(Table, Field.NPM);
            ProgramProjectTotals = GetDataTotals(Table, Field.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, Field.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, Field.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, Field.ProgramArea);
            GoalTotals = GetDataTotals(Table, Field.GoalName);
            GoalMetrics = GetMetrics(Table, Field.GoalName);
            ObjectiveTotals = GetDataTotals(Table, Field.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, Field.ObjectiveName);
            if(DbData.Source == Source.DivisionAccounts &&
               DbData.Input == null)
            {
                DivisionTotals = GetDataTotals(Table, Field.RC);
                DivisionMetrics = GetMetrics(Table, Field.RC);
            }

            if(DbData.Source == Source.PRC)
            {
                DataTable table = new DivisionAuthority().Table;
                DivisionTotals = GetDataTotals(table, Field.RC);
                DivisionMetrics = GetMetrics(table, Field.RC);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrcMetric"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        /// <param name="column">The column<see cref="Field"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        public PrcMetric(DataBuilder data, Field column, string filter)
        {
            DbData = data;
            Table = Info.FilterRows(DbData.Table, column, filter);
            CarryOver = Info.FilterRows(DbData.Table, column, filter).AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2018")).Select(p => p).CopyToDataTable();
            CurrentYear = Info.FilterRows(DbData.Table, column, filter).AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2019")).Select(p => p).CopyToDataTable();
            ProgramElements = GetProgramElements(Table);
            Total = GetTotals(Table);
            CarryOverTotal = GetTotals(CarryOver);
            CurrentYearTotal = GetTotals(CurrentYear);
            Count = Table.Rows.Count;
            CarryOverCount = CarryOver.Rows.Count;
            CurrentYearCount = CurrentYear.Rows.Count;
            Average = GetAverage(Table);
            Metrics = GetMetrics(Table);
            FundTotals = GetDataTotals(Table, Field.FundName);
            FundMetrics = GetMetrics(Table, Field.FundName);
            BocTotals = GetDataTotals(Table, Field.BocName);
            BocMetrics = GetMetrics(Table, Field.BocName);
            NpmTotals = GetDataTotals(Table, Field.NPM);
            NpmMetrics = GetMetrics(Table, Field.NPM);
            ProgramProjectTotals = GetDataTotals(Table, Field.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, Field.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, Field.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, Field.ProgramArea);
            GoalTotals = GetDataTotals(Table, Field.GoalName);
            GoalMetrics = GetMetrics(Table, Field.GoalName);
            ObjectiveTotals = GetDataTotals(Table, Field.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, Field.ObjectiveName);
            if(DbData.Source == Source.DivisionAccounts)
            {
                DivisionTotals = GetDataTotals(DbData.Table, Field.RC);
                DivisionMetrics = GetMetrics(DbData.Table, Field.RC);
            }
            else
            {
                DataTable table = new DivisionAuthority().Table;
                DivisionTotals = GetDataTotals(table, Field.RC);
                DivisionMetrics = GetMetrics(table, Field.RC);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrcMetric"/> class.
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="Field"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        public PrcMetric(DataTable table, Field column, string filter)
        {
            Table = table;
            ProgramElements = GetProgramElements(Table);
            Total = GetTotals(Table);
            Count = Table.Rows.Count;
            Average = GetAverage(Table);
            Metrics = GetMetrics(Table);
            FundTotals = GetDataTotals(Table, Field.FundName);
            FundMetrics = GetMetrics(Table, Field.FundName);
            BocTotals = GetDataTotals(Table, Field.BocName);
            BocMetrics = GetMetrics(Table, Field.BocName);
            NpmTotals = GetDataTotals(Table, Field.NPM);
            NpmMetrics = GetMetrics(Table, Field.NPM);
            ProgramProjectTotals = GetDataTotals(Table, Field.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, Field.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, Field.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, Field.ProgramArea);
            GoalTotals = GetDataTotals(Table, Field.GoalName);
            GoalMetrics = GetMetrics(Table, Field.GoalName);
            ObjectiveTotals = GetDataTotals(Table, Field.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, Field.ObjectiveName);
        }

        // PROPERTIES
        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets or sets the Average
        /// </summary>
        public decimal Average { get; set; }

        /// <summary>
        /// Gets or sets the CarryOverAverage
        /// </summary>
        public decimal CarryOverAverage { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYearAverage
        /// </summary>
        public decimal CurrentYearAverage { get; set; }

        /// <summary>
        /// Gets the Count
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets the CarryOverCount
        /// </summary>
        public int CarryOverCount { get; }

        /// <summary>
        /// Gets the CurrentYearCount
        /// </summary>
        public int CurrentYearCount { get; }

        /// <summary>
        /// Gets the Metrics
        /// </summary>
        public double[] Metrics { get; }

        /// <summary>
        /// Gets the CurrentYearMetrics
        /// </summary>
        public double[] CurrentYearMetrics { get; }

        /// <summary>
        /// Gets the CarryOverMetrics
        /// </summary>
        public double[] CarryOverMetrics { get; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the CarryOver
        /// </summary>
        public DataTable CarryOver { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYear
        /// </summary>
        public DataTable CurrentYear { get; set; }

        /// <summary>
        /// Gets the Total
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Gets the CarryOverTotal
        /// </summary>
        public decimal CarryOverTotal { get; }

        /// <summary>
        /// Gets the CurrentYearTotal
        /// </summary>
        public decimal CurrentYearTotal { get; }

        /// <summary>
        /// Gets or sets the BocMetrics
        /// </summary>
        public Dictionary<string, double[]> BocMetrics { get; set; }

        /// <summary>
        /// Gets the BocTotals
        /// </summary>
        public Dictionary<string, decimal> BocTotals { get; }

        /// <summary>
        /// Gets or sets the DivisionMetrics
        /// </summary>
        public Dictionary<string, double[]> DivisionMetrics { get; set; }

        /// <summary>
        /// Gets or sets the DivisionTotals
        /// </summary>
        public Dictionary<string, decimal> DivisionTotals { get; set; }

        /// <summary>
        /// Gets or sets the FundMetrics
        /// </summary>
        public Dictionary<string, double[]> FundMetrics { get; set; }

        /// <summary>
        /// Gets or sets the FundTotals
        /// </summary>
        public Dictionary<string, decimal> FundTotals { get; set; }

        /// <summary>
        /// Gets or sets the GoalMetrics
        /// </summary>
        public Dictionary<string, double[]> GoalMetrics { get; set; }

        /// <summary>
        /// Gets or sets the GoalTotals
        /// </summary>
        public Dictionary<string, decimal> GoalTotals { get; set; }

        /// <summary>
        /// Gets or sets the NpmMetrics
        /// </summary>
        public Dictionary<string, double[]> NpmMetrics { get; set; }

        /// <summary>
        /// Gets or sets the NpmTotals
        /// </summary>
        public Dictionary<string, decimal> NpmTotals { get; set; }

        /// <summary>
        /// Gets or sets the ObjectiveMetrics
        /// </summary>
        public Dictionary<string, double[]> ObjectiveMetrics { get; set; }

        /// <summary>
        /// Gets or sets the ObjectiveTotals
        /// </summary>
        public Dictionary<string, decimal> ObjectiveTotals { get; set; }

        /// <summary>
        /// Gets or sets the ProgramAreaMetrics
        /// </summary>
        public Dictionary<string, double[]> ProgramAreaMetrics { get; set; }

        /// <summary>
        /// Gets or sets the ProgramAreaTotals
        /// </summary>
        public Dictionary<string, decimal> ProgramAreaTotals { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectMetrics
        /// </summary>
        public Dictionary<string, double[]> ProgramProjectMetrics { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectTotals
        /// </summary>
        public Dictionary<string, decimal> ProgramProjectTotals { get; set; }

        // METHODS
        /// <summary>
        /// The GetAverage
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal"/></returns>
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
        /// The GetTotals
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        public decimal GetTotals(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0).Sum(p => p.Field<decimal>("Amount"));
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
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <returns>The <see cref="string[]"/></returns>
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
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] GetMetrics(DataTable table)
        {
            return new[] { (double)GetTotals(table), GetCount(table), (double)GetAverage(table), (double)GetTotals(table) / (double)Total };
        }

        /// <summary>
        /// The GetProgramElements
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="Dictionary{string, string[]}"/></returns>
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

                if(data.ContainsKey("P6_ID"))
                {
                    data.Remove("P6_ID");
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
        /// The GetCount
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="int"/></returns>
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
        /// The GetDataTotals
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="prcfilter">The prcfilter<see cref="Field"/></param>
        /// <returns>The <see cref="Dictionary{string, decimal}"/></returns>
        public Dictionary<string, decimal> GetDataTotals(DataTable table, Field prcfilter)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string filter in GetCodes(table, prcfilter.ToString()))
                {
                    DataTable query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if(GetTotals(query) > 0)
                    {
                        info.Add(filter, GetTotals(query));
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
        /// The GetChartMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="prcfilter">The prcfilter<see cref="Field"/></param>
        /// <returns>The <see cref="Dictionary{string, double[]}"/></returns>
        internal Dictionary<string, double[]> GetChartMetrics(DataTable table, Field prcfilter)
        {
            try
            {
                Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                foreach(string filter in GetCodes(table, prcfilter.ToString()))
                {
                    DataTable query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if(GetTotals(query) > 0)
                    {
                        info.Add(filter, GetMetrics(query));
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
        /// The GetChartTotals
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="prcfilter">The prcfilter<see cref="Field"/></param>
        /// <returns>The <see cref="Dictionary{string, double}"/></returns>
        internal Dictionary<string, double> GetChartTotals(DataTable table, Field prcfilter)
        {
            try
            {
                Dictionary<string, double> doubledata = new Dictionary<string, double>();
                foreach(string filter in GetCodes(table, prcfilter.ToString()))
                {
                    DataTable query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if(GetTotals(query) > 0)
                    {
                        doubledata.Add(filter, (double)GetTotals(query));
                    }
                }

                return doubledata;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="prcfilter">The prcfilter<see cref="Field"/></param>
        /// <returns>The <see cref="Dictionary{string, double[]}"/></returns>
        private Dictionary<string, double[]> GetMetrics(DataTable table, Field prcfilter)
        {
            try
            {
                Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                foreach(string filter in GetCodes(table, prcfilter.ToString()))
                {
                    DataTable query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if(GetTotals(query) > 0)
                    {
                        info.Add(filter, new[] { (double)GetTotals(query) });
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
