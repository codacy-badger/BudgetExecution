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
            TableFilter = DataBuilder.FilterRecords;
            DbData = new DataBuilder(Source.DivisionAccounts);
            Metric = new PrcMetric(DbData);
            Table = DbData.Table;
            DataRecords = DbData.Records;
            PRC = GetPrcArray(Table);
            Total = Metric.Total;
            Count = Metric.Count;
            Average = Metric.Average;
            ProgramElements = DbData.ProgramElements;
            if (ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(DbData.Table);
            }
        }

        public DivisionAuthority(Source source)
        {
            TableFilter = DataBuilder.FilterRecords;
            DbData = new DataBuilder(source);
            Table = DbData.Table;
            ProgramElements = DbData.ProgramElements;
            Metric = new PrcMetric(DbData);
            Division = new Division(source);
            CurrentYear = Metric.CurrentYear;
            CarryOver = Metric.CarryOver;
            DataRecords = DbData.Records;
            if (ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(Table);
            }
        }

        // PROPERTIES
        public Division Division { get; }

        public DataBuilder DbData { get; }

        public DataRow[] DataRecords { get; }

        public PRC[] PRC { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public TableDelegate TableFilter { get; }

        public DataTable FTE { get; }

        public Appropriation[] Appropriation { get; set; }

        public DataSet R6 { get; set; }

        public DataTable CurrentYear { get; set; }

        public DataTable CarryOver { get; set; }
        
        public decimal Total { get; }

        public int Count { get; }

        public decimal Average { get; }

        public Dictionary<string, decimal> BocAuthority { get; set; }

        public Dictionary<string, decimal> FundAuthority { get; set; }

        public Dictionary<string, decimal> GoalAuthority { get; set; }

        public Dictionary<string, decimal> NpmAuthority { get; set; }

        public Dictionary<string, decimal> ProgramAreaAuthority { get; set; }

        public Dictionary<string, decimal> ProgramProjectAuthority { get; set; }

        public ExcelDocument Budget { get; set; }

        public DataTable Table { get; }

        public PrcMetric Metric { get; set; }

        public decimal Amount { get; set; }

        // METHODS
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
                return new[] { GetTotal(table), table.Rows.Count, GetAverage(table) };
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
                    if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount") || dc.ColumnName.Equals("Obligations") ||
                        dc.ColumnName.Equals("Commitments") || dc.ColumnName.Equals("OpenCommitments") || 
                        dc.ColumnName.Equals("ULO") || dc.ColumnName.Equals("Hours") || dc.ColumnName.Equals("Authority") || 
                        dc.ColumnName.Equals("Budgeted")|| dc.ColumnName.Equals("Posted") || dc.ColumnName.Equals("CarryIn") || 
                        dc.ColumnName.Equals("CarryOut") || dc.ColumnName.Equals("Balance"))
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
    }
}
