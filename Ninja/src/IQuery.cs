﻿// <copyright file="IQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
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
        DbCommandBuilder GetCommandBuilder(DbDataAdapter adapter);

        DbConnection GetDataConnection(Provider connection);

        string GetSqlStatement(string sqlStatement);

        DbCommand GetDataCommand(string sql, DbConnection dataConnection);

        DbDataAdapter GetDataAdapter(DbCommand command, Sql cmd);

        DbDataReader GetDataReader(DbCommand command);
    }
}
