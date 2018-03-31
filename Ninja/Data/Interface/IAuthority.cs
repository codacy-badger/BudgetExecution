#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IAuthority 
            {
                #region Properties

                DataSet E6 { get; }

                DataTable Table { get; }

                decimal Total { get; }

                int Count { get; }

                decimal Average { get; }

                Dictionary<string, string[]> DataElement { get; }

                decimal[] Metrics { get; }

                Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }

                #endregion Properties

                #region Methods

                DataTable FilterTable(DataTable table, string column, string filter);

                PRC[] GetPrcArray(DataTable table);

                Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

                string[] GetCodeElements(DataTable table, string column);

                Dictionary<string, string[]> GetDataElements(DataTable table);

                decimal GetTotal(DataTable table);

                int GetCount(DataTable table);

                decimal GetAverage(DataTable table);

                decimal[] GetMetrics(DataTable table);

                Dictionary<string, decimal> GetTotal(DataTable table, string[] codes, string field);

                Dictionary<string, decimal[]> GetMetrics(DataTable table, string[] codes, string field);

                #endregion
            }
        }
    }
}