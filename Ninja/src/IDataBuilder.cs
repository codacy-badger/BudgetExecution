using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {

        // PROPERTIES
        Query Query { get; }
        DataTable Table { get; }
        DataRow[] DataRecords { get; }

        // METHODS
        DataTable GetDataTable();
        DataRow[] GetDataRecords(DataTable table);
    }
        
}