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
            public interface IAuthority : IMetrics
            {
                #region Properties

                DataSet E6 { get; }

                Dictionary<string, string[]> DataElement { get; }

                Tuple<DataTable, PRC[], decimal, int> AllocationData { get; }

                #endregion Properties

                #region Methods

                string[] GetCodeElements(DataTable table, string column);

                DataTable FilterTable(DataTable table, string column, string filter);

                Dictionary<string, string[]> GetDataElements(DataTable table);

                PRC[] GetPrcArray(DataTable table);

                Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

                Dictionary<string, decimal> GetDataTotals(DataTable table, string[] codes, string field);

                Dictionary<string, decimal[]> GetDataMetrics(DataTable table, string[] codes, string field);

                #endregion
            }
        }
    }
}