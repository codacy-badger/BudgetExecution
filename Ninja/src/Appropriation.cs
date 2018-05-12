using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class Appropriation : IBudgetAuthority
    {
        //Constructors
        public Appropriation()
        {
        }
        public Appropriation(string fundcode, string bfy)
        {
            Fund = new Fund(fundcode, bfy);
            FiscalYear = Fund.FiscalYear;
        }
        public Appropriation(Source source, string fundcode, string bfy) : this(fundcode, bfy)
        {
            Data = new DataBuilder(source, new Dictionary<string, object> { ["Fund"] = fundcode, ["BFY"] = bfy });
            Metric = new PrcMetric(Data);
            Table = Data.QueryTable;
            Total = Metric.Total;
            Average = Metric.Average;
            ProgramElements = GetProgramElements(Table);
            BocCodes = ProgramElements["BOC"];
            BOC = ProgramElements["BocName"];
            NPM = ProgramElements["NPM"];
            Program = ProgramElements["ProgramAreaName"];
            Goal = ProgramElements["GoalName"];
            Count = PrcData.Item1.Rows.Count;
            BocData = Metric.BocTotals;
            if (BocCodes.Contains("17"))
            {
                FTE = new FTE(Table);
            }
            NpmData = Metric.NpmTotals;
            ProgramData = Metric.ProgramAreaTotals;
            GoalData = Metric.GoalTotals;
        }

        //Properties
        public decimal Amount { get; }
        public decimal Average { get; }
        public string[] BOC { get; }
        public string[] BocCodes { get; }
        public Dictionary<string, decimal> BocData { get; set; }
        public PrcMetric Metric { get; }
        public int Count { get; }
        public string FiscalYear { get; }
        public FTE FTE { get; }
        public Fund Fund { get; }
        public string[] Goal { get; }
        public Dictionary<string, decimal> GoalData { get; set; }
        public decimal[] Metrics { get; }
        public string[] NPM { get; }
        public Dictionary<string, decimal> NpmData { get; set; }
        public Dictionary<string, decimal> ObjectiveData { get; set; }
        public Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
        public string[] Program { get; }
        public Dictionary<string, decimal> ProgramData { get; set; }
        public Dictionary<string, string[]> ProgramElements { get; }
        public string[] Project { get; }
        public Dictionary<string, decimal> ProjectData { get; set; }
        public DataTable Table { get; }
        public decimal Total { get; }
        private DataBuilder Data { get; }

        //Methods
        public DataTable FilterTable(DataTable table, string column, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
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
        public Tuple<string[], string[], string[], string[], string[]> GetCodes()
        {
            return new Tuple<string[], string[], string[], string[], string[]>(ProgramElements["BOC"],
                ProgramElements["Code"], ProgramElements["NPM"], ProgramElements["ProgramArea"], ProgramElements["ProgramProjectCode"]);
        }
        public int GetCount(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<decimal>("Amount") > 0m).Select(p => p).Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                return -1;
            }
        }
        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter)
        {
            try
            {
                var qtable = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                    .Select(p => p).CopyToDataTable();
                return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string[] list, string column)
        {
            foreach (string filter in list)
            {
                try
                {
                    var qtable = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
                    return new Tuple<DataTable, PRC[], decimal, int>(qtable, GetPrcArray(qtable), GetTotal(qtable), GetCount(qtable));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                    return null;
                }
            }
            return null;
        }
        public decimal GetFTE()
        {
            return PrcData.Item1.AsEnumerable().Where(p => p.Field<string>("BOC").Equals("17")).Select(p => p).Sum(p => p.Field<decimal>("Amount"));
        }
        public decimal[] GetMetrics(DataTable table)
        {
            var count = GetCount(table);
            return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
        }
        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] list, string column)
        {
            try
            {
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach (string filter in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = (stat[0] / Total) * 100;
                    info.Add(filter, stat);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column, string filter)
        {
            try
            {
                var list = GetCodes(table, column);
                Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                foreach (string ftr in list)
                {
                    decimal[] stat = new decimal[4];
                    stat[0] = GetDataValues(table, column, filter).Item3;
                    stat[1] = (decimal)GetDataValues(table, column, filter).Item4;
                    stat[2] = stat[0] / stat[1];
                    stat[3] = (stat[0] / Total) * 100;
                    info.Add(filter, stat);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            var data = new Dictionary<string, string[]>();
            foreach (DataColumn dc in table.Columns)
            {
                if (dc.ColumnName.Equals("Id") || dc.ColumnName.Equals("Amount"))
                    continue;
                data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
            }
            if (data.ContainsKey("Id")) data.Remove("Id");
            if (data.ContainsKey("Amount")) data.Remove("Amount");
            if (data.ContainsKey("P6_Id")) data.Remove("P6_Id");
            return data;
        }
        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>("BOC") != "17").Sum(p => p.Field<decimal>("Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                return -1M;
            }
        }
        public Dictionary<string, decimal> GetTotals(DataTable table, string column, string filter)
        {
            try
            {
                var list = GetCodes(table, column);
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string ftr in list)
                {
                    var query = PrcData.Item1.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                        .Sum(p => p.Field<decimal>("Amount"));
                    if (query > 0)
                        info.Add(filter, query);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                return null;
            }
        }
        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string f in filters)
                {
                    if (GetTotal(table) > 0)
                        info.Add(f, GetTotal(table));
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                return null;
            }
        }
        internal Bitmap GetImageFile()
        {
            DirectoryInfo imgfolder = new DirectoryInfo(@"C:\Users\terry\Documents\Visual Studio 2015\Projects\Budget\Resources\fundlabel");
            var files = imgfolder.GetFiles("*.png");
            foreach (var f in files)
            {
                string imgname = Path.GetFileNameWithoutExtension(f.FullName);
                if (imgname.Equals(Fund.Code))
                    return new Bitmap(f.FullName);
            }
            return null;
        }
    }
}