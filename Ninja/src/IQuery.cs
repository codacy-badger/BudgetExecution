using System.Data;
using System.Data.Common;



namespace BudgetExecution
{
    public interface IQuery 
    {
        //Properties
        Source Source { get; }
        Provider Provider { get; }
        DbDataAdapter DataAdapter { get; set; }
        DbCommand DataCommand { get; set; }
        DbConnection DataConnection { get; }
        DbDataReader DataReader { get; set; }
        string SqlStatement { get; set; }

        //Methods
        DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter);
        DbConnection GetConnection(Provider connection);
        DbDataAdapter GetDataAdapter(IDbCommand command);
        DbCommand GetDataCommand(string sql, IDbConnection dataConnection);
        DbDataReader GetDataReader(IDbCommand command);
        string GetSqlStatement(string sqlStatement);
    }
}
    