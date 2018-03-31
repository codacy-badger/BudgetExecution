#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Metric 
            {
                #region Properties
                public IAuthority Data { get; }
                public DataTable Table { get; set; }
                public Dictionary<string, decimal> FundTotals{ get; }
                public Dictionary<string, decimal[]> FundMetrics { get; }
                public Dictionary<string, decimal> BocTotals { get; set; }
                public Dictionary<string, decimal[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> NpmTotals { get; set; }
                public Dictionary<string, decimal[]> NpmMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramAreaTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramAreaMetrics { get; set; }
                public Dictionary<string, decimal> GoalTotals { get; set; }
                public Dictionary<string, decimal[]> GoalMetrics { get; set; }
                public Dictionary<string, decimal> ObjectiveTotals { get; set; }
                public Dictionary<string, decimal[]> ObjectiveMetrics { get; set; }
                #endregion Properties

                #region Constructors
                public Metric()
                {
                }

                public Metric(IAuthority data)
                {
                    Data = data;
                    Table = Data.Table;
                    FundTotals = GetTotals(Data.AllocationData.Item1, "FundName");
                    FundMetrics = GetMetrics(Data.Table, "FundName");
                }
                
                #endregion

                #region Methods

                public Dictionary<string, decimal> GetTotals(DataTable table, string column)
                {
                    try
                    {
                        var info = new Dictionary<string, decimal>();
                        if (Data.DataElement.Keys.Contains(column))
                        {
                            foreach(string filter in Data.DataElement[column])
                            {
                                var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                    .Select(p => p.Field<decimal>("Amount")).Sum();
                                if (query > 0)
                                    info.Add(filter, query);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                public Dictionary<string, decimal[]> GetMetrics(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        if(Data.DataElement.Keys.Contains(column))
                        {
                            foreach (string filter in Data.DataElement[column])
                            {
                                decimal[] stat = new decimal[4];
                                stat[0] = Data.GetTotal(table);
                                stat[1] = (decimal)Data.GetCount(table);
                                stat[2] = stat[0] / stat[1];
                                stat[3] = (stat[0] / Data.Total) * 100;
                                info.Add(filter, stat);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                #endregion
            }
        }
    }
}
