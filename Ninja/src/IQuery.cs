using System.Data;
using System.Data.Common;

namespace BudgetExecution
{
    public interface IQuery
    {
        // PROPERTIES
        Source Source { get; }

        Provider Provider { get; }

        DbDataAdapter DataAdapter { get; set; }

        DbCommand DataCommand { get; set; }

        DbConnection DataConnection { get; }

        DbDataReader DataReader { get; set; }

        string SqlStatement { get; set; }

        // METHODS
        DbCommandBuilder GetCommandBuilder(DbDataAdapter adapter);

        DbConnection GetDataConnection(Provider connection);

        DbDataAdapter GetDataAdapter(IDbCommand command);

        DbCommand GetDataCommand(string sql, DbConnection dataConnection);

        DbDataReader GetDataReader(IDbCommand command);

        string GetSqlStatement(string sqlStatement);
    }
}
