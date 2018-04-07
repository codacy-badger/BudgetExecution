using System;
using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IDataBuilder
            {

                Query Query { get; }
                DataSet BudgetData { get; }
                DataTable BudgetTable { get; }
                DataRow[] Records { get; }
                PRC[] Accounts { get; }
                Tuple<DataTable, DataRow[], decimal, int> SqlData { get; }

                decimal GetAverage(DataTable table);

                int GetCount(DataTable table);

                DataSet GetDataSet();

                decimal[] GetMetrics(DataTable table);

                DataRow[] GetRecords(DataTable table);

                Tuple<DataTable, DataRow[], decimal, int> GetSqlData();

                decimal GetTotal(DataTable table);

            }
        }
    }
}