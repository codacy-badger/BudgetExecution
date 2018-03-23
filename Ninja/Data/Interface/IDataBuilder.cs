#region Using Directives

using System;
using System.Data;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IDataBuilder
            {
                #region Properties

                DataRow[] Records { get; }
                DataSet Data { get; }
                PRC[] Accounts { get; }
                Tuple<DataTable, PRC[], decimal, int> PrcData { get; }
                Query Query { get; }
                Tuple<DataTable, DataRow[], decimal, int> SqlData { get; }
                DataTable Table { get; }
                decimal Total { get; }

                #endregion

                #region Methods

                DataSet GetDataSet( );

                DataRow[] GetArray( );

                decimal GetAverage(DataTable table);

                int GetCount(DataTable table);

                decimal[] GetMetrics(DataTable table);

                Tuple<DataTable, DataRow[], decimal, int> GetSqlData( );

                decimal GetTotal(DataTable table);

                #endregion
            }
        }
    }
}