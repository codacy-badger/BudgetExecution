using System.Data;

namespace Budget.Ninja.Data
{
    public interface IDataBuilder
    {

        //Properties
        Query DataQuery { get; }
        DataSet DataSet { get; }
        DataTable QueryTable { get; }
        DataRow[] DataRecords { get; }

        //Methods
        decimal GetQueryAverage(DataTable table);
        int GetQueryCount(DataTable table);
        decimal[] GetQueryMetrics(DataTable table);
        DataSet GetDataSet();
        decimal GetQueryTotal(DataTable table);
        DataRow[] GetRecords(DataTable table);
    }
        
}