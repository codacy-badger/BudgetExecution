// <copyright file="FTE.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="FTE" />
    /// </summary>
    public class FTE : PRC, IPRC
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FTE"/> class.
        /// </summary>
        public FTE()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FTE"/> class.
        /// </summary>
        /// <param name="datarow">The datarow<see cref="DataRow"/></param>
        public FTE(DataRow datarow) : base(datarow)
        {
            FteParameter = AsDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FTE"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public FTE(Provider provider, Dictionary<string, object> param) : base(provider, param)
        {
            DbData = base.DbData;
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
            BOC = new BOC("17");
        }

        // PROPERTIES
        /// <summary>
        /// Gets the DbData
        /// </summary>
        private new DataBuilder DbData { get; }

        /// <summary>
        /// Gets or sets the Metric
        /// </summary>
        private PrcMetric Metric { get; set; }

        /// <summary>
        /// Gets the FteParameter
        /// </summary>
        private Dictionary<string, object> FteParameter { get; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        BOC IPRC.BOC { get; set; }

        // METHODS
        /// <summary>
        /// The FilterTable
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
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
        /// The GetCount
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="int"/></returns>
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

        /// <summary>
        /// The GetDataElements
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="Dictionary{string, string[]}"/></returns>
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
            int count = GetCount(table);
            return new[] { GetTotal(table), count, GetAverage(table) };
        }

        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="list">The list<see cref="string[]"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, decimal[]}"/></returns>
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

        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, decimal[]}"/></returns>
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

        /// <summary>
        /// The GetPrcArray
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="PRC[]"/></returns>
        private PRC[] GetPrcArray(DataTable table)
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
        /// The GetTotal
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal"/></returns>
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

        /// <summary>
        /// The GetTotals
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, decimal}"/></returns>
        public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
        {
            try
            {
                string[] list = GetCodes(table, column);
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string ftr in list)
                {
                    decimal query = table.AsEnumerable()
                                         .Where(p => p.Field<string>(column).Equals(filter))
                                         .Where(p => p.Field<decimal>("Amount") != 0m)
                                         .Sum(p => p.Field<decimal>("Amount"));
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
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="filters">The filters<see cref="string[]"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, decimal}"/></returns>
        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach(string filter in filters)
                {
                    decimal query = table.AsEnumerable()
                                         .Where(p => p.Field<string>(column).Equals(filter))
                                         .Where(p => p.Field<decimal>("Amount") != 0m)
                                         .Sum(p => p.Field<decimal>("Amount"));
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
