// <copyright file="IQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;
    using System.Data.Common;

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
        DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter);

        DbConnection GetConnection(Provider connection);

        DbDataAdapter GetDataAdapter(IDbCommand command);

        DbCommand GetDataCommand(string sql, IDbConnection dataConnection);

        DbDataReader GetDataReader(IDbCommand command);

        string GetSqlStatement(string sqlStatement);
    }
}
