using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class PrcMetric
    {
        //Constructors
        public PrcMetric()
        {
        }
        public PrcMetric(DataBuilder data)
        {
            Data = data;
            DataSet = Data.DataSet;
            Table = Data.GetDataTable();
            ProgramElements = Data.GetProgramElements(Table);
            Total = GetTotals(Table);
            Count = Table.Rows.Count;
            Average = GetBaseAverage(Table);
            Metrics = GetMetrics(Table);
            FundTotals = GetDataTotals(Table, PrcField.FundName);
            FundMetrics = GetMetrics(Table, PrcField.FundName);
            BocTotals = GetDataTotals(Table, PrcField.BocName);
            BocMetrics = GetMetrics(Table, PrcField.BocName);
            NpmTotals = GetDataTotals(Table, PrcField.NPM);
            NpmMetrics = GetMetrics(Table, PrcField.NPM);
            ProgramProjectTotals = GetDataTotals(Table, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, PrcField.ProgramArea);
            GoalTotals = GetDataTotals(Table, PrcField.GoalName);
            GoalMetrics = GetMetrics(Table, PrcField.GoalName);
            ObjectiveTotals = GetDataTotals(Table, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, PrcField.ObjectiveName);
            if (Data.Source == Source.DivisionAccount && Data.Parameter == null)
            {
                DivisionTotals = GetDataTotals(Table, PrcField.RC);
                DivisionMetrics = GetMetrics(Table, PrcField.RC);
            }
            if (Data.Source == Source.PRC)
            {
                var table = new DivisionAuthority().Table;
                DivisionTotals = GetDataTotals(table, PrcField.RC);
                DivisionMetrics = GetMetrics(table, PrcField.RC);
            }
        }
        public PrcMetric(DataBuilder data, PrcField prcfilter, string filter)
        {
            Data = data;
            DataSet = data.DataSet;
            Table = Info.FilterTable(Data.DataTable, prcfilter, filter);
            ProgramElements = GetProgramElements(Table);
            Total = GetTotals(Table);
            Count = Table.Rows.Count;
            Average = GetBaseAverage(Table);
            Metrics = GetMetrics(Table);
            FundTotals = GetDataTotals(Table, PrcField.FundName);
            FundMetrics = GetMetrics(Table, PrcField.FundName);
            BocTotals = GetDataTotals(Table, PrcField.BocName);
            BocMetrics = GetMetrics(Table, PrcField.BocName);
            NpmTotals = GetDataTotals(Table, PrcField.NPM);
            NpmMetrics = GetMetrics(Table, PrcField.NPM);
            ProgramProjectTotals = GetDataTotals(Table, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, PrcField.ProgramArea);
            GoalTotals = GetDataTotals(Table, PrcField.GoalName);
            GoalMetrics = GetMetrics(Table, PrcField.GoalName);
            ObjectiveTotals = GetDataTotals(Table, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, PrcField.ObjectiveName);
            if (Data.Source == Source.DivisionAccount)
            {
                DivisionTotals = GetDataTotals(Data.DataTable, PrcField.RC);
                DivisionMetrics = GetMetrics(Data.DataTable, PrcField.RC);
            }
            if (Data.Source == Source.PRC)
            {
                var table = new DivisionAuthority().Table;
                DivisionTotals = GetDataTotals(table, PrcField.RC);
                DivisionMetrics = GetMetrics(table, PrcField.RC);
            }
        }
        public PrcMetric(DataTable table, PrcField prcfilter, string filter)
        {
            Table = Info.FilterTable(table, prcfilter, filter);
            ProgramElements = GetProgramElements(Table);
            Total = GetTotals(Table);
            Count = Table.Rows.Count;
            Average = GetBaseAverage(Table);
            Metrics = GetMetrics(Table);
            FundTotals = GetDataTotals(Table, PrcField.FundName);
            FundMetrics = GetMetrics(Table, PrcField.FundName);
            BocTotals = GetDataTotals(Table, PrcField.BocName);
            BocMetrics = GetMetrics(Table, PrcField.BocName);
            NpmTotals = GetDataTotals(Table, PrcField.NPM);
            NpmMetrics = GetMetrics(Table, PrcField.NPM);
            ProgramProjectTotals = GetDataTotals(Table, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(Table, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetDataTotals(Table, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(Table, PrcField.ProgramArea);
            GoalTotals = GetDataTotals(Table, PrcField.GoalName);
            GoalMetrics = GetMetrics(Table, PrcField.GoalName);
            ObjectiveTotals = GetDataTotals(Table, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(Table, PrcField.ObjectiveName);
        }

        //Properties
        public DataBuilder Data { get; }
        public decimal Average { get; set; }
        public int Count { get; }
        public double[] Metrics { get; }
        public DataSet DataSet { get; }
        public DataTable Table { get; set; }
        public decimal Total { get; }
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

        //Methods
        public decimal GetBaseAverage(DataTable table)
        {
            try
            {
                if(Count > 0d)
                    return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                return 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }
        public decimal GetTotals(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public double[] GetMetrics(DataTable table)
        {
            return new double[] { (double)GetTotals(table), (double)GetCount(table), (double)GetBaseAverage(table), (double)GetTotals(table) / (double)Data.QueryTotal };
        }
        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => new PRC()).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            var data = new Dictionary<string, string[]>();
            foreach (DataColumn dc in table.Columns)
            {
                if (dc.ColumnName.Equals("ID") || dc.ColumnName.Equals("Amount"))
                    continue;
                data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
            }
            if (data.ContainsKey("ID")) data.Remove("ID");
            if (data.ContainsKey("Amount")) data.Remove("Amount");
            if (data.ContainsKey("P6_ID")) data.Remove("P6_ID");
            return data;
        }
        public int GetCount(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1;
            }
        }
        public Dictionary<string, decimal> GetDataTotals(DataTable table, PrcField prcfilter)
        {
            try
            {
                var info = new Dictionary<string, decimal>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if (GetTotals(query) > 0)
                        info.Add(filter, GetTotals(query));
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        internal Dictionary<string, double[]> GetChartMetrics(DataTable table, PrcField prcfilter)
        {
            try
            {
                var info = new Dictionary<string, double[]>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if (GetTotals(query) > 0)
                        info.Add(filter,  GetMetrics(query));
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        internal Dictionary<string, double> GetChartTotals(DataTable table, PrcField prcfilter)
        {
            try
            {
                var doubledata = new Dictionary<string, double>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                        .Select(p => p).CopyToDataTable();
                    if (GetTotals(query) > 0)
                        doubledata.Add(filter, (double)GetTotals(query));
                }
                return doubledata;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        private Dictionary<string, double[]> GetMetrics(DataTable table, PrcField prcfilter)
        {
            try
            {
                var info = new Dictionary<string, double[]>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if (GetTotals(query) > 0)
                        info.Add(filter, new double[] { (double)GetTotals(query) });
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
    }
}