// <copyright file="DivisionAuthority.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="DivisionAuthority" />
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
        /// <param name="source">The source<see cref="Source"/></param>
        public DivisionAuthority(Source source)
        {
            TableFilter = (table, col, filter) => DataBuilder.Filter(table, col, filter);
            DbData = new DataBuilder(source);
            R6 = DbData.R6;
            Table = DbData.Table;
            ProgramElements = DbData.ProgramElements;
            Metric = new PrcMetric(DbData);
            Division = new Division(source);
            CurrentYear = Metric.CurrentYear;
            CarryOver = Metric.CarryOver;
            Records = DbData.Records;
            if(ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(Table);
            }
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Division
        /// </summary>
        public Division Division { get; }

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
        /// Gets or sets the Appropriation
        /// </summary>
        public Appropriation[] Appropriation { get; set; }

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

        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; }

        /// <summary>
        /// Gets the Table
        /// </summary>
        public DataTable Table { get; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        // METHODS
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
        /// The GetDataValues
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        /// <returns>The <see cref="Tuple{DataTable, PRC[], decimal, int}"/></returns>
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

        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal[]"/></returns>
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

        /// <summary>
        /// The GetPrcArray
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="PRC[]"/></returns>
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

        /// <summary>
        /// The GetTotal
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal"/></returns>
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

        /// <summary>
        /// The GetEPM
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetEPM(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("B")).Select(a => a).CopyToDataTable();
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
        /// The GetSTAG
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetSTAG(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("E"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("E")).Select(a => a).CopyToDataTable();
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
        /// The GetOIL
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetOIL(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("H"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("H")).Select(a => a).CopyToDataTable();
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
        /// The GetLUST
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetLUST(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("F"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("F")).Select(a => a).CopyToDataTable();
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
        /// The GetSF6A
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetSF6A(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").Equals("T")).Where(a => a.Field<string>("Org").StartsWith("6A")).Select(a => a).CopyToDataTable();
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
        /// The GetTR
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetTR(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("TR"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("TR")).Select(a => a).CopyToDataTable();
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
        /// The GetSUPERFUND
        /// </summary>
        /// <param name="approp">The approp<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        internal DataTable GetSUPERFUND(DataTable approp)
        {
            if(GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").Equals("T")).Where(p => p.Field<string>("Org").StartsWith("6A")).Select(a => a).CopyToDataTable();
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
