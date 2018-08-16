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
            TableFilter = DataBuilder.FilterTable;
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, new Dictionary<string, object> { ["BFY"] = FiscalYear });
            Metric = new PrcMetric(DbData);
            DataRecords = DbData.DbRow;
            DbTable = DbData.DbTable;
            PRC = GetPrcArray(DbTable);
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

            Awards = new DataBuilder(Source.Awards, Provider.SQLite, new Dictionary<string, object> { ["BFY"] = FiscalYear }).DbTable;
            TableFilter = DataBuilder.FilterTable;
        }

        public DivisionAuthority(string rc)
        {
            TableFilter = DataBuilder.FilterTable;
            RC = new RC(rc);
            Org = new Org(RC.Code);
            DbData = new DataBuilder(Source.DivisionAccounts, Provider.SQLite, new Dictionary<string, object> { ["RC"] = RC.Code, ["BFY"] = FiscalYear });
            Metric = new PrcMetric(DbData);
            DbTable = DbData.DbTable;
            DataRecords = DbData.DbRow;
            PRC = GetPrcArray(DbTable);
            Total = Metric.Total;
            Count = Metric.Count;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(DbTable);
            Appropriation = GetAppropriation(ProgramElements["Fund"]);
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

            EPM = GetEPM(DbTable);
            LUST = GetLUST(DbTable);
            STAG = GetSTAG(DbTable);
            SUPERFUND = GetSUPERFUND(DbTable);
            SF6A = GetSF6A(DbTable);
            TR = GetTR(DbTable);
            OIL = GetOIL(DbTable);
            Awards = new DataBuilder(Source.Awards, Provider.SQLite, new Dictionary<string, object> { ["RC"] = RC.Code, ["BFY"] = FiscalYear }).DbTable;
        }

        // PROPERTIES
        public static string FiscalYear { get; set; } = "2018";

        public RC RC { get; }

        public Org Org { get; }

        public DataRow[] DataRecords { get; }

        public PRC[] PRC { get; }

        public Appropriation[] Appropriation { get; set; }

        public DataBuilder DbData { get; set; }

        public DataSet Allocation { get; set; }

        public PrcMetric Metric { get; }

        public DataTable DbTable { get; }

        public DataTable EPM { get; set; }

        public DataTable SUPERFUND { get; set; }

        public DataTable LUST { get; set; }

        public DataTable STAG { get; set; }

        public DataTable OIL { get; set; }

        public DataTable TR { get; set; }

        public DataTable SF6A { get; set; }

        public DataTable DWH { get; set; }

        public DataTable TS3 { get; set; }

        public DataTable FS3 { get; set; }

        public DataTable Awards { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public decimal Amount { get; set; }

        public decimal Total { get; }

        public int Count { get; }

        public decimal Average { get; }

        public DataFilter TableFilter { get; }

        public DataTable FTE { get; }

        public Dictionary<string, decimal> BocData { get; set; }

        public Dictionary<string, decimal> FundData { get; set; }

        public Dictionary<string, decimal> GoalData { get; set; }

        public Dictionary<string, decimal> NpmData { get; set; }

        public Dictionary<string, decimal> ProgramAreaData { get; set; }

        public Dictionary<string, decimal> ProjectData { get; set; }

        public ExcelReport Budget { get; set; }

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
                DataTable query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
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
                int count = GetCount(table);
                return new decimal[] { GetTotal(table), table.Rows.Count, GetAverage(table) };
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
                Dictionary<string, string[]> data = new Dictionary<string, string[]>();
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

        internal DataTable GetFTE(DataTable table)
        {
            if (GetCodes(table, "BOC").Contains("17"))
            {
                try
                {
                    return table.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetEPM(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("B")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetSTAG(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("E"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("E")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetOIL(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("H"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("H")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetLUST(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("F"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("F")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetSF6A(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").Equals("T")).Where(a => a.Field<string>("Org").StartsWith("6A")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetTR(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("TR"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").StartsWith("TR")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal DataTable GetSUPERFUND(DataTable approp)
        {
            if (GetCodes(approp, "Fund").Contains("T"))
            {
                try
                {
                    return approp.AsEnumerable().Where(a => a.Field<string>("Fund").Equals("T")).Where(p => p.Field<string>("Org").StartsWith("6A")).Select(a => a).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        internal Appropriation[] GetAppropriation(string[] funds)
        {
            if (funds.Length > 0)
            {
                try
                {
                    Appropriation[] approp = new Appropriation[funds.Length];
                    for (int i = 0; i < funds.Length; i++)
                    {
                        approp[i] = new Appropriation(funds[i], FiscalYear);
                    }

                    return approp;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }
    }
}