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
                DataTable Table { get; }
                DataMetric BudgetMetric { get; }
                Dictionary<string, string[]> ProgramElements { get; }

                DataTable FilterTable(DataTable table, string column, string filter);
                

                string[] GetCodes(DataTable table, string column);

                Dictionary<string, string[]> GetProgramElements(DataTable table);

                Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

                decimal[] GetMetrics(DataTable table);

                PRC[] GetPrcArray(DataTable table);

                decimal GetTotal(DataTable table);

            }
        }
    }
}