// <copyright file="IQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data.Common;

    /// <summary>
    /// Defines the <see cref="IQuery" />
    /// </summary>
    public interface IQuery
    {
        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        Provider Provider { get; }

        /// <summary>
        /// Gets or sets the DataAdapter
        /// </summary>
        DbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets the DataCommand
        /// </summary>
        DbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets the DataConnection
        /// </summary>
        DbConnection DataConnection { get; }

        /// <summary>
        /// Gets or sets the DataReader
        /// </summary>
        DbDataReader DataReader { get; set; }

        /// <summary>
        /// Gets or sets the SqlStatement
        /// </summary>
        string SqlStatement { get; set; }

        // METHODS
        /// <summary>
        /// The GetCommandBuilder
        /// </summary>
        /// <param name="adapter">The adapter<see cref="DbDataAdapter"/></param>
        /// <returns>The <see cref="DbCommandBuilder"/></returns>
        DbCommandBuilder GetCommandBuilder(DbDataAdapter adapter);

        /// <summary>
        /// The GetDataConnection
        /// </summary>
        /// <param name="connection">The connection<see cref="Provider"/></param>
        /// <returns>The <see cref="DbConnection"/></returns>
        DbConnection GetDataConnection(Provider connection);

        /// <summary>
        /// The GetSqlStatement
        /// </summary>
        /// <param name="sqlStatement">The sqlStatement<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        string GetSqlStatement(string sqlStatement);

        /// <summary>
        /// The GetDataCommand
        /// </summary>
        /// <param name="sql">The sql<see cref="string"/></param>
        /// <param name="dataConnection">The dataConnection<see cref="DbConnection"/></param>
        /// <returns>The <see cref="DbCommand"/></returns>
        DbCommand GetDataCommand(string sql, DbConnection dataConnection);

        /// <summary>
        /// The GetDataAdapter
        /// </summary>
        /// <param name="command">The command<see cref="DbCommand"/></param>
        /// <param name="cmd">The cmd<see cref="Sql"/></param>
        /// <returns>The <see cref="DbDataAdapter"/></returns>
        DbDataAdapter GetDataAdapter(DbCommand command, Sql cmd);

        /// <summary>
        /// The GetDataReader
        /// </summary>
        /// <param name="command">The command<see cref="DbCommand"/></param>
        /// <returns>The <see cref="DbDataReader"/></returns>
        DbDataReader GetDataReader(DbCommand command);
    }
}
