

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class DivisionAuthority : IBudgetAuthority
    {
        //CONSTRUCTORS

        public DivisionAuthority()
        {
        }

        public DivisionAuthority(Source source)
        {
            Source = source;
            DbData = new DataBuilder(Source);
            Filter = (table, col, filter) => DataBuilder.Filter(table, col, filter);
            R6 = DbData.GetDataSet(Source);
            R6.DataSetName = "R6";
            Table = DbData.Table;
            Table.TableName = Source.ToString();
            ProgramElements = DbData.ProgramElements;
            BFY = ProgramElements["BFY"];
            RC = ProgramElements["RC"].AsEnumerable().Select(s => s).First();
            Metric = new PrcMetric(DbData);
            if(ProgramElements["BOC"].Contains("17"))
            {
                FTE = GetFTE(Table);
            }

            Fund = GetFunds();
            Authority = Filter(Table, Field.BFY, BFY[1]);
            CarryOver = Filter(Table, Field.BFY, BFY[0]);
            Awards = Filter(new Awards(new Dictionary<string, object>{["RC"] = RC}).Table, Field.RC, RC);
            Overtime = Filter(new Overtime(new Dictionary<string, object>{["RC"] = RC}).Table, Field.RC, RC);
            BCN = new ControlNumber(new Dictionary<string, object>(){["Division"] = Table.TableName});
        }

        // PROPERTIES
        public Source Source { get; }

        public string[] BFY { get; set; }

        public Fund[] Fund { get; set; }

        public string RC { get; set; }

        public DataBuilder DbData { get; }

        public DataRow[] Records { get; }

        public PRC[] PRC { get; }

        public TableDelegate Filter { get; }

        public ControlNumber BCN { get; set; }

        public DataTable FTE { get; }

        public DataSet R6 { get; set; }

        public DataTable Authority { get; set; }

        public DataTable CarryOver { get; set; }

        public DataTable Awards { get; set; }

        public DataTable Overtime { get; set; }

        public ExcelDocument Budget { get; set; }

        public PrcMetric Metric { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public DataTable Table { get; }

        public decimal Amount { get; set; }

        // METHODS

        private Fund[] GetFunds()
        {
            try
            {
                var bfy = ProgramElements["BFY"];
                var fcodes = ProgramElements["FundCode"];
                var fund = new Fund[fcodes.Length];
                foreach(string yr in bfy)
                {
                    for(int i = 0; i < fcodes.Length; i++)
                    {
                        var d = new Dictionary<string, object> { ["BFY"] = yr, ["Code"] = fcodes[i] };
                        fund[i] = new Fund(d);
                    }
                }

                return fund;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
     
        private DataTable GetAwards()
        {
            try
            {
                switch(Source)
                {
                    case Source.EJ:
                    case Source.EN:
                    case Source.RA:
                    case Source.RC:
                    case Source.SF:
                    case Source.MD:
                    case Source.WQ:
                    case Source.XA:
                        return new Awards().Table.AsEnumerable()
                                           .Where(a => a.Field<string>("BFY").Equals(BFY[0]))
                                           .Where(a => a.Field<string>("RC").Equals(RC))
                                           .Select(a => a).CopyToDataTable();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private DataTable GetOverTime()
        {
            try
            {
                switch(Source)
                {
                    case Source.EJ:
                    case Source.EN:
                    case Source.RA:
                    case Source.RC:
                    case Source.SF:
                    case Source.MD:
                    case Source.WQ:
                    case Source.XA:
                        return new Awards().Table.AsEnumerable()
                                           .Where(a => a.Field<string>("BFY").Equals(BFY[0]))
                                           .Where(a => a.Field<string>("RC").Equals(RC))
                                           .Select(a => a).CopyToDataTable();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

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

        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                var rows = table.AsEnumerable().Select(p => p).ToArray();
                var prc = new PRC[rows.Length];
                for(int i = 0; i < rows.Length; i++)
                {
                    prc[i] = new PRC(rows[i]);
                }

                return prc;
            }
            catch(Exception ex)
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
