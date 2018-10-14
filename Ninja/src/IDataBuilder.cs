using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {
        // PROPERTIES
        Query Query { get; }

        DataTable Table { get; }

        DataRow[] Records { get; }

        // METHODS
        DataTable GetDataTable();

        DataRow[] GetRecords(DataTable table);
    }
}
