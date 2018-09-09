// <copyright file="IDataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public interface IDataBuilder
    {
        // PROPERTIES
        Query DbQuery { get; }

        DataTable DbTable { get; }

        DataRow[] Records { get; }

        // METHODS
        DataTable GetDataTable();

        DataRow[] GetRecords(DataTable table);
    }
}