using System.Data;
using System.Data.Common;



namespace BudgetExecution
{
    public interface IQuery
    {
        //Properties
        Command Command { get; }
        Source Table { get; set; }
        Provider Provider { get; }
        string ConnectionString { get; set; }
        DbDataAdapter DataAdapter { get; set; }
        DbCommand DataCommand { get; set; }
        DbConnection DataConnection { get; set; }
        DbDataReader DataReader { get; set; }
        string SqlStatement { get; set; }

        //Methods
        DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter);
        DbConnection GetConnection(Provider connection, string connectionString);
        string GetConnectionString(string connectionString);
        DbDataAdapter GetDataAdapter(IDbCommand command);
        DbCommand GetDataCommand(IDbConnection dataConnection, string sql);
        DbDataReader GetDataReader(IDbDataAdapter adapter);
        string GetSqlStatement(Command command, string sqlStatement);
    }
}
    