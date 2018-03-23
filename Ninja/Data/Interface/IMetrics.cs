#region Using Directives

using System.Data;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IMetrics
            {
                #region Properties

                decimal Total { get; }

                int Count { get; }

                decimal Average { get; }

                decimal[] FundMetrics { get; }

                #endregion Properties

                #region Methods

                decimal GetTotal(DataTable table);

                int GetCount(DataTable table);

                decimal GetAverage(DataTable table);

                decimal[] GetMetrics(DataTable table);

                #endregion
            }
        }
    }
}