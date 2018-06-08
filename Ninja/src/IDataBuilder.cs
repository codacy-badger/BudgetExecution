namespace BudgetExecution
{
    using System.Data;

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