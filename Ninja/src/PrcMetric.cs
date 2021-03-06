﻿// <copyright file="PrcMetric.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class PrcMetric
    {
        // CONSTRUCTORS
        public PrcMetric()
        {
        }

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
        
        public PrcMetric(DataTable data, Field column, string filter)
        {
            Table = data;
            CarryOver = Info.FilterRows(Table, column, filter).AsEnumerable()
                            .Where(p => p.Field<string>("BFY").Equals("2018"))
                            .Select(p => p).CopyToDataTable();
            CurrentYear = Info.FilterRows(Table, column, filter).AsEnumerable()
                              .Where(p => p.Field<string>("BFY").Equals("2019"))
                              .Select(p => p).CopyToDataTable();
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
        
        // PROPERTIES
        public DataBuilder DbData { get; }

        public decimal Average { get; set; }

        public decimal CarryOverAverage { get; set; }

        public decimal CurrentYearAverage { get; set; }

        public int Count { get; }

        public int CarryOverCount { get; }

        public int CurrentYearCount { get; }

        public string[] BFY { get; set; }

        public double[] Metrics { get; }

        public double[] CurrentYearMetrics { get; }

        public double[] CarryOverMetrics { get; }

        public DataTable Table { get; set; }

        public DataTable CarryOver { get; set; }

        public DataTable CurrentYear { get; set; }

        public decimal Total { get; }

        public decimal CarryOverTotal { get; }

        public decimal CurrentYearTotal { get; }

        public Dictionary<string, double[]> BocMetrics { get; set; }

        public Dictionary<string, decimal> BocTotals { get; }

        public Dictionary<string, double[]> DivisionMetrics { get; set; }

        public Dictionary<string, decimal> DivisionTotals { get; set; }

        public Dictionary<string, double[]> FundMetrics { get; set; }

        public Dictionary<string, decimal> FundTotals { get; set; }

        public Dictionary<string, double[]> GoalMetrics { get; set; }

        public Dictionary<string, decimal> GoalTotals { get; set; }

        public Dictionary<string, double[]> NpmMetrics { get; set; }

        public Dictionary<string, decimal> NpmTotals { get; set; }

        public Dictionary<string, double[]> ObjectiveMetrics { get; set; }

        public Dictionary<string, decimal> ObjectiveTotals { get; set; }

        public Dictionary<string, double[]> ProgramAreaMetrics { get; set; }

        public Dictionary<string, decimal> ProgramAreaTotals { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public Dictionary<string, double[]> ProgramProjectMetrics { get; set; }

        public Dictionary<string, decimal> ProgramProjectTotals { get; set; }

        // METHODS
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

        public decimal GetTotals(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") != 0)
                            .Sum(p => p.Field<decimal>("Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1M;
            }
        }

        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<string>(column))
                            .Distinct().ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public double[] GetMetrics(DataTable table)
        {
            return new[] { (double)GetTotals(table), GetCount(table), (double)GetAverage(table), (double)GetTotals(table) / (double)Total };
        }

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
