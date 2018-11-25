// <copyright file="DivisionAuthority.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines the <see cref="T:BudgetExecution.DivisionAuthority" />
    /// </summary>
    public class DivisionAuthority : IBudgetAuthority
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionAuthority"/> class.
        /// </summary>
        public DivisionAuthority()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionAuthority"/> class.
        /// </summary>
        /// <param name="source">The source MD, RA, RC, EJ, EN, WQ, WSA, MDR, MCF, MM, XA, SF<see cref="Source"/></param>
        public DivisionAuthority(Source source)
        {
            TableFilter = (table, col, filter) => DataBuilder.Filter(table, col, filter);
            DbData = new DataBuilder(source);
            R6 = DbData.R6;
            Table = DbData.Table;
            Records = DbData.Records;
            PRC = GetPrcArray(Table);
            ProgramElements = DbData.ProgramElements;
            Metric = new PrcMetric(DbData);
            CurrentYear = Metric.CurrentYear;
            CarryOver = Metric.CarryOver;
            if(ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(Table);
            }
        }

        // PROPERTIES

        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets the Records
        /// </summary>
        public DataRow[] Records { get; }

        /// <summary>
        /// Gets the PRC
        /// </summary>
        public PRC[] PRC { get; }

        /// <summary>
        /// Gets the TableFilter
        /// </summary>
        public TableDelegate TableFilter { get; }

        /// <summary>
        /// Gets the FTE
        /// </summary>
        public DataTable FTE { get; }

        /// <summary>
        /// Gets or sets the R6
        /// </summary>
        public DataSet R6 { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYear
        /// </summary>
        public DataTable CurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the CarryOver
        /// </summary>
        public DataTable CarryOver { get; set; }

        /// <summary>
        /// Gets or sets the Budget
        /// </summary>
        public ExcelDocument Budget { get; set; }

        /// <summary>
        /// Gets or sets the Metric
        /// </summary>
        public PrcMetric Metric { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        // METHODS
        /// <inheritdoc />
        /// <summary>
        /// The GetCodes
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <param name="column">The column<see cref="T:System.String" /></param>
        /// <returns>The <see cref="T:System.String" /></returns>
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

        /// <inheritdoc />
        /// <summary>
        /// The GetDataValues
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <param name="column">The column<see cref="T:System.String" /></param>
        /// <param name="filter">The filter<see cref="T:System.String" /></param>
        /// <returns>The <see cref="T:System.Tuple`2" /></returns>
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

        /// <inheritdoc />
        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Decimal" /></returns>
        public decimal[] GetMetrics(DataTable table)
        {
            try
            {
                return new[] { GetTotal(table), table.Rows.Count, GetAverage(table) };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// The GetPrcArray
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="P:BudgetExecution.DivisionAuthority.PRC" /></returns>
        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => new PRC(p)).ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// The GetProgramElements
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Collections.Generic.Dictionary`2" /></returns>
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                foreach(DataColumn dc in table.Columns)
                {
                    if(dc.ColumnName.Equals("ID") ||
                       dc.ColumnName.Equals("Amount") ||
                       dc.ColumnName.Equals("Obligations") ||
                       dc.ColumnName.Equals("Commitments") ||
                       dc.ColumnName.Equals("OpenCommitments") ||
                       dc.ColumnName.Equals("ULO") ||
                       dc.ColumnName.Equals("Hours") ||
                       dc.ColumnName.Equals("Authority") ||
                       dc.ColumnName.Equals("Budgeted") ||
                       dc.ColumnName.Equals("Posted") ||
                       dc.ColumnName.Equals("CarryIn") ||
                       dc.ColumnName.Equals("CarryOut") ||
                       dc.ColumnName.Equals("Balance"))
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// The GetTotal
        /// </summary>
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Decimal" /></returns>
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
        /// The GetFTE
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetFTE(DataTable table)
        {
            if(GetCodes(table, "BOC").Contains("17"))
            {
                try
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable();
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
