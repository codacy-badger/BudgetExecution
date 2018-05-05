using System.Data;
using System.Data.Common;



namespace BudgetExecution
{
    public interface IQuery
    {
        //Properties
        Command Command { get; }
        Source Table { get; set; }
        Provider Connection { get; }
        string ConnectionString { get; set; }
        IDbDataAdapter DataAdapter { get; set; }
        IDbCommand DataCommand { get; set; }
        IDbConnection DataConnection { get; set; }
        IDataReader Reader { get; set; }
        string SqlStatement { get; set; }

        //Methods
        DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter);
        IDbConnection GetConnection(Provider connection, string connectionString);
        string GetConnectionString(string connectionString);
        IDbDataAdapter GetDataAdapter(IDbCommand command);
        IDbCommand GetDataCommand(IDbConnection dataConnection, string sql);
        IDataReader GetDataReader(IDbDataAdapter adapter);
        string GetSqlStatement(Command command, string sqlStatement);
    }
}
    