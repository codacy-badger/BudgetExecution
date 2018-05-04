using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class DataMetric
    {
        //Constructors
        public DataMetric()
        {
        }
        public DataMetric(Source source)
        {
            Data = new DataBuilder(source);
            BaseTable = Data.QueryTable;
            ProgramElements = Data.GetProgramElements(BaseTable);
            BaseSet = Data.DataSet;
            Total = GetBaseMetrics(BaseTable);
            Count = BaseTable.Rows.Count;
            Average = GetBaseAverage(BaseTable);
            Metrics = GetMetrics(BaseTable);
            FundTotals = GetTotals(BaseTable, PrcField.FundName);
            FundMetrics = GetMetrics(BaseTable, PrcField.FundName);
            BocTotals = GetTotals(BaseTable, PrcField.BocName);
            BocMetrics = GetMetrics(BaseTable, PrcField.BocName);
            NpmTotals = GetTotals(BaseTable, PrcField.NPM);
            NpmMetrics = GetMetrics(BaseTable, PrcField.NPM);
            ProgramProjectTotals = GetTotals(BaseTable, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(BaseTable, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetTotals(BaseTable, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(BaseTable, PrcField.ProgramArea);
            GoalTotals = GetTotals(BaseTable, PrcField.GoalName);
            GoalMetrics = GetMetrics(BaseTable, PrcField.GoalName);
            ObjectiveTotals = GetTotals(BaseTable, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(BaseTable, PrcField.ObjectiveName);
            if (source == Source.DivisionAccount && Data.Parameter == null)
            {
                DivisionTotals = GetTotals(BaseTable, PrcField.Division);
                DivisionMetrics = GetMetrics(BaseTable, PrcField.Division);
            }
            if(source == Source.PRC)
            {
                var table = new DivisionAuthority().Table;
                DivisionTotals = GetTotals(table, PrcField.Division);
                DivisionMetrics = GetMetrics(table, PrcField.Division);
            }
        }
        public DataMetric(DataBuilder data)
        {
            Data = data;
            BaseTable = Data.QueryTable;
            ProgramElements = Data.GetProgramElements(BaseTable);
            BaseSet = BaseTable.DataSet;
            Total = GetBaseMetrics(BaseTable);
            Count = BaseTable.Rows.Count;
            Average = GetBaseAverage(BaseTable);
            Metrics = GetMetrics(BaseTable);
            FundTotals = GetTotals(BaseTable, PrcField.FundName);
            FundMetrics = GetMetrics(BaseTable, PrcField.FundName);
            BocTotals = GetTotals(BaseTable, PrcField.BocName);
            BocMetrics = GetMetrics(BaseTable, PrcField.BocName);
            NpmTotals = GetTotals(BaseTable, PrcField.NPM);
            NpmMetrics = GetMetrics(BaseTable, PrcField.NPM);
            ProgramProjectTotals = GetTotals(BaseTable, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(BaseTable, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetTotals(BaseTable, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(BaseTable, PrcField.ProgramArea);
            GoalTotals = GetTotals(BaseTable, PrcField.GoalName);
            GoalMetrics = GetMetrics(BaseTable, PrcField.GoalName);
            ObjectiveTotals = GetTotals(BaseTable, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(BaseTable, PrcField.ObjectiveName);
            if (Data.Source == Source.DivisionAccount && Data.Parameter == null)
            {
                DivisionTotals = GetTotals(Data.QueryTable, PrcField.Division);
                DivisionMetrics = GetMetrics(Data.QueryTable, PrcField.Division);
            }
        }
        public DataMetric(DataBuilder data, PrcField prcfilter, string filter)
        {
            Data = data;
            BaseSet = data.DataSet;
            BaseTable = FilterTable(data.QueryTable, prcfilter, filter);
            ProgramElements = GetProgramElements(BaseTable);
            Total = GetBaseMetrics(BaseTable);
            Count = BaseTable.Rows.Count;
            Average = GetBaseAverage(BaseTable);
            Metrics = GetMetrics(BaseTable);
            FundTotals = GetTotals(BaseTable, PrcField.FundName);
            FundMetrics = GetMetrics(BaseTable, PrcField.FundName);
            BocTotals = GetTotals(BaseTable, PrcField.BocName);
            BocMetrics = GetMetrics(BaseTable, PrcField.BocName);
            NpmTotals = GetTotals(BaseTable, PrcField.NPM);
            NpmMetrics = GetMetrics(BaseTable, PrcField.NPM);
            ProgramProjectTotals = GetTotals(BaseTable, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(BaseTable, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetTotals(BaseTable, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(BaseTable, PrcField.ProgramArea);
            GoalTotals = GetTotals(BaseTable, PrcField.GoalName);
            GoalMetrics = GetMetrics(BaseTable, PrcField.GoalName);
            ObjectiveTotals = GetTotals(BaseTable, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(BaseTable, PrcField.ObjectiveName);
            if (Data.Source == Source.DivisionAccount)
            {
                DivisionTotals = GetTotals(Data.QueryTable, PrcField.Division);
                DivisionMetrics = GetMetrics(Data.QueryTable, PrcField.Division);
            }
            if (Data.Source == Source.PRC)
            {
                var table = new DivisionAuthority().Table;
                DivisionTotals = GetTotals(table, PrcField.Division);
                DivisionMetrics = GetMetrics(table, PrcField.Division);
            }
        }
        public DataMetric(DataTable table, PrcField prcfilter, string filter)
        {
            BaseTable = FilterTable(table, prcfilter, filter);
            ProgramElements = GetProgramElements(BaseTable);
            Total = GetBaseMetrics(BaseTable);
            Count = BaseTable.Rows.Count;
            Average = GetBaseAverage(BaseTable);
            Metrics = GetMetrics(BaseTable);
            FundTotals = GetTotals(BaseTable, PrcField.FundName);
            FundMetrics = GetMetrics(BaseTable, PrcField.FundName);
            BocTotals = GetTotals(BaseTable, PrcField.BocName);
            BocMetrics = GetMetrics(BaseTable, PrcField.BocName);
            NpmTotals = GetTotals(BaseTable, PrcField.NPM);
            NpmMetrics = GetMetrics(BaseTable, PrcField.NPM);
            ProgramProjectTotals = GetTotals(BaseTable, PrcField.ProgramProjectCode);
            ProgramProjectMetrics = GetMetrics(BaseTable, PrcField.ProgramProjectCode);
            ProgramAreaTotals = GetTotals(BaseTable, PrcField.ProgramArea);
            ProgramAreaMetrics = GetMetrics(BaseTable, PrcField.ProgramArea);
            GoalTotals = GetTotals(BaseTable, PrcField.GoalName);
            GoalMetrics = GetMetrics(BaseTable, PrcField.GoalName);
            ObjectiveTotals = GetTotals(BaseTable, PrcField.ObjectiveName);
            ObjectiveMetrics = GetMetrics(BaseTable, PrcField.ObjectiveName);
            DivisionTotals = GetTotals(table, PrcField.Division);
            DivisionMetrics = GetMetrics(table, PrcField.Division);
        }

        //Properties
        public DataBuilder Data { get; }
        public decimal Average { get; set; }
        public int Count { get; }
        public double[] Metrics { get; }
        public DataSet BaseSet { get; }
        public DataTable BaseTable { get; set; }
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
        public DataTable FilterTable(DataTable table, PrcField prcfilter, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter))
                    .Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
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
        public decimal GetBaseMetrics(DataTable table)
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
            return new double[] { (double)GetBaseMetrics(table), (double)GetBaseCount(table), (double)GetBaseAverage(table), (double)GetBaseMetrics(table) / (double)Data.QueryTotal };
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
        public int GetBaseCount(DataTable table)
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
        public Dictionary<string, decimal> GetTotals(DataTable table, PrcField prcfilter)
        {
            try
            {
                var info = new Dictionary<string, decimal>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if (GetBaseMetrics(query) > 0)
                        info.Add(filter, GetBaseMetrics(query));
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
                    if (GetBaseMetrics(query) > 0)
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
                    if (GetBaseMetrics(query) > 0)
                        doubledata.Add(filter, (double)GetBaseMetrics(query));
                }
                return doubledata;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        private Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
        {
            return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetBaseMetrics(table), GetBaseCount(table));
        }
        private Dictionary<string, double[]> GetMetrics(DataTable table, PrcField prcfilter)
        {
            try
            {
                var info = new Dictionary<string, double[]>();
                foreach (string filter in GetCodes(table, prcfilter.ToString()))
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(prcfilter.ToString()).Equals(filter)).Select(p => p).CopyToDataTable();
                    if (GetBaseMetrics(query) > 0)
                        info.Add(filter, new double[] { (double)GetBaseMetrics(query) });
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        private Dictionary<string, decimal>[] GetTotals()
        {
            return new Dictionary<string, decimal>[] {FundTotals, BocTotals, NpmTotals, GoalTotals,
            ObjectiveTotals, ProgramAreaTotals, ProgramProjectTotals};
        }
    }
}