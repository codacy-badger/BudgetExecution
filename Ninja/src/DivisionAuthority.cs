// <copyright file="DivisionAuthority.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class DivisionAuthority : IBudgetAuthority
    {
        // CONSTRUCTORS
        public DivisionAuthority()
        {
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite);
            Metric = new PrcMetric(DbData);
            DataRecords = DbData.DbRow;
            DbTable = DbData.DbTable;
            PrcAllocation = GetPrcArray(DbTable);
            Total = Metric.Total;
            Count = Metric.Count;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(DbTable);
            FundData = Metric.FundTotals;
            BocData = Metric.BocTotals;
            NpmData = Metric.NpmTotals;
            GoalData = Metric.GoalTotals;
            ProgramAreaData = Metric.ProgramAreaTotals;
            ProjectData = Metric.ProgramProjectTotals;
            if (ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(DbData.DbTable);
            }

            TableFilter = DataBuilder.FilterTable;
        }

        public DivisionAuthority(string rc)
        {
            RC = new RC(rc);
            Org = new Org(RC.Code);
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, new Dictionary<string, object> { ["RC"] = rc });
            Metric = new PrcMetric(DbData);
            DbTable = DbData.DbTable;
            DataRecords = DbData.DbRow;
            PrcAllocation = GetPrcArray(DbTable);
            Total = Metric.Total;
            Count = Metric.Count;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(DbTable);
            FundData = Metric.FundTotals;
            BocData = Metric.BocTotals;
            NpmData = Metric.NpmTotals;
            GoalData = Metric.GoalTotals;
            ProgramAreaData = Metric.ProgramAreaTotals;
            ProjectData = Metric.ProgramProjectTotals;
            if (ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(DbTable);
            }

            TableFilter = DataBuilder.FilterTable;
        }

        // PROPERTIES
        public static string FiscalYear { get; set; } = "2018";

        public RC RC { get; }

        public Org Org { get; }

        public DataRow[] DataRecords { get; }

        public PRC[] PrcAllocation { get; }

        public DataBuilder DbData { get; set; }

        public PrcMetric Metric { get; }

        public DataTable DbTable { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public decimal Amount { get; set; }

        public decimal Total { get; }

        public int Count { get; }

        public decimal Average { get; }

        public DataFilter TableFilter { get; }

        public Dictionary<string, decimal> ProgramData { get; set; }

        public FTE[] FTE { get; }

        public Dictionary<string, decimal> BocData { get; set; }

        public Dictionary<string, decimal> FundData { get; set; }

        public Dictionary<string, decimal> GoalData { get; set; }

        public Dictionary<string, decimal> NpmData { get; set; }

        public Dictionary<string, decimal> ProgramAreaData { get; set; }

        public Dictionary<string, decimal> ProjectData { get; set; }

        // METHODS
        public decimal GetAverage(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal[] GetMetrics(DataTable table)
        {
            try
            {
                var count = GetCount(table);
                return new decimal[] { GetTotal(table), (decimal)table.Rows.Count, GetAverage(table) };
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                var data = new Dictionary<string, string[]>();
                foreach (DataColumn dc in table.Columns)
                {
                    if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount"))
                    {
                        continue;
                    }

                    data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
                }

                if (data.ContainsKey("ID"))
                {
                    data.Remove("ID");
                }

                if (data.ContainsKey("Amount"))
                {
                    data.Remove("Amount");
                }

                return data;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Sum(p => p.Field<decimal>("Amount"));
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        internal FTE[] GetFTE(DataTable table)
        {
            try
            {
                var fteTable = table.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable();
                var fteArray = new FTE[fteTable.Rows.Count];
                for (int i = 0; i < fteTable.Rows.Count; i++)
                {
                    fteArray[i] = new FTE(fteTable.Rows[i]);
                }

                return fteArray;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

    }
}