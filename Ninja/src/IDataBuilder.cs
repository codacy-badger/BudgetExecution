// <copyright file="IDataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {
        // PROPERTIES
        string[] Columns { get; set; }

        DataTable Table { get; set; }

        DataRow[] Records { get; }

        DataRow Data { get; }

        Dictionary<string, string[]> ProgramElements { get; }

        // METHODS
        DataTable GetDataTable();

        DataRow[] GetRecords(DataTable table);

        string[] GetUniqueValues(DataTable table, string column);

        Dictionary<string, string[]> GetProgramElements(DataTable table);
    }
}
