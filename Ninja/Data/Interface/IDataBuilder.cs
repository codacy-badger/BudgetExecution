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
                //Properties
                Query Query { get; }
                DataSet QuerySet { get; }
                DataTable QueryTable { get; }
                DataRow[] Records { get; }
                PRC[] Accounts { get; }

                //Methods
                decimal GetQueryAverage(DataTable table);
                int GetQueryCount(DataTable table);
                DataSet GetQuerySet();
                decimal[] GetQueryMetrics(DataTable table);
                DataRow[] GetRecords(DataTable table);
                decimal GetQueryTotal(DataTable table);

            }
        }
    }
}