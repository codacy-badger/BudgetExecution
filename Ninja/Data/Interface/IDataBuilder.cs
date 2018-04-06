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
                #region Properties

                PRC[] Accounts { get; }
                DataSet E6 { get; }
                Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                Query Query { get; }
                DataRow[] Records { get; }
                Tuple<DataTable, DataRow[], decimal, int> SqlData { get; }
                DataTable Table { get; }

                #endregion

                #region Methods

                decimal GetAverage(DataTable table);

                int GetCount(DataTable table);

                DataSet GetDataSet();

                decimal[] GetMetrics(DataTable table);

                DataRow[] GetRecords();

                Tuple<DataTable, DataRow[], decimal, int> GetSqlData();

                decimal GetTotal(DataTable table);

                #endregion
            }
        }
    }
}