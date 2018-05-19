using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {

        //Properties
        Query DataQuery { get; }
        DataSet DataSet { get; }
        DataTable DataTable { get; }
        DataRow[] DataRecords { get; }

        //Methods
        DataSet GetDataSet();
        DataTable GetDataTable();
        DataRow[] GetRecords(DataTable table);
    }
        
}