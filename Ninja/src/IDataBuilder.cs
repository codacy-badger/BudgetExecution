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

        DataRow[] DbRecords { get; }

        // METHODS
        DataTable GetDataTable();

        DataRow[] GetDataRecords(DataTable table);
    }
}