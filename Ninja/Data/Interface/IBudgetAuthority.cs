using System;
using System.Collections.Generic;
using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IBudgetAuthority
            {
                #region Properties

                decimal Average { get; }
                int Count { get; }
                Dictionary<string, string[]> DataElement { get; }
                DataSet E6 { get; }
                decimal[] Metrics { get; }
                Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                DataTable Table { get; }
                decimal Total { get; }

                #endregion Properties

                #region Methods

                DataTable FilterTable(DataTable table, string column, string filter);

                decimal GetAverage(DataTable table);

                string[] GetCodes(DataTable table, string column);

                int GetCount(DataTable table);

                Dictionary<string, string[]> GetDataElements(DataTable table);

                Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

                decimal[] GetMetrics(DataTable table);

                Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] codes, string field);

                PRC[] GetPrcArray(DataTable table);

                decimal GetTotal(DataTable table);

                Dictionary<string, decimal> GetTotals(DataTable table, string[] codes, string field);

                #endregion
            }
        }
    }
}