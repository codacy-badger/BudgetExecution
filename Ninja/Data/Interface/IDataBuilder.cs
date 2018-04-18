using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IDataBuilder
            {
                PRC[] Accounts { get; }

                //Properties
                Query Query { get; }

                DataSet QuerySet { get; }
                DataTable QueryTable { get; }
                DataRow[] Records { get; }

                //Methods
                decimal GetQueryAverage(DataTable table);

                int GetQueryCount(DataTable table);

                decimal[] GetQueryMetrics(DataTable table);

                DataSet GetQuerySet();

                decimal GetQueryTotal(DataTable table);

                DataRow[] GetRecords(DataTable table);
            }
        }
    }
}