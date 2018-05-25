using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {

        //Properties
        Query Query { get; }
        DataTable Table { get; }
        DataRow[] DataRecords { get; }

        //Methods
        DataSet GetDataSet();
        DataTable GetDataTable();
        DataRow[] GetRecords(DataTable table);
    }
        
}