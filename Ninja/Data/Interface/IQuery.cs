using System.Data;
using System.Data.Common;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IQuery
            {
                #region Properties

                Source Table { get; set; }
                Connection Connection { get; }
                Command Command { get; }
                string SqlStatement { get; set; }
                string ConnectionString { get; set; }
                IDbConnection DataConnection { get; set; }
                IDbDataAdapter DataAdapter { get; set; }
                IDataReader Reader { get; set; }
                IDbCommand DataCommand { get; set; }

                #endregion

                #region Methods

                string GetConnectionString(string connectionString);

                string GetSqlStatement(Command command, string sqlStatement);

                IDbConnection GetConnection(Connection connection, string connectionString);

                IDbCommand GetDataCommand(IDbConnection dataConnection, string sql);

                IDbDataAdapter GetDataAdapter(IDbCommand command);

                DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter);

                IDataReader GetDataReader(IDbDataAdapter adapter);

                #endregion
            }
        }
    }
}