#region Using Directives

using System.Collections.Generic;
using System.Data;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IMetric
            {
                #region Properties

                decimal Total { get; }

                int Count { get; }

                decimal Average { get; }

                decimal[] Metrics { get; }

                #endregion Properties

                #region Methods

                decimal GetTotal(DataTable table);

                int GetCount(DataTable table);

                decimal GetAverage(DataTable table);

                decimal[] GetMetrics(DataTable table);

                Dictionary<string, decimal> GetDataTotals(DataTable table, string[] codes, string field);

                Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string[] codes, string field);

                #endregion
            }
        }
    }
}