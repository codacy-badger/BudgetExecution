// <copyright file="IDataBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Defines the <see cref="IDataBuilder" />
    /// </summary>
    public interface IDataBuilder
    {
        // PROPERTIES
        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        string[] Columns { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        DataTable Table { get; set; }

        /// <summary>
        /// Gets the Records
        /// </summary>
        DataRow[] Records { get; set; }

        /// <summary>
        /// Gets the Data
        /// </summary>
        DataRow Data { get; set; }

        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        Dictionary<string, string[]> ProgramElements { get; set; }

        // METHODS
        /// <summary>
        /// The GetDataTable
        /// </summary>
        /// <returns>The <see cref="DataTable"/></returns>
        DataTable GetDataTable();

        /// <summary>
        /// The GetRecords
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="DataRow[]"/></returns>
        DataRow[] GetRecords(DataTable table);

        /// <summary>
        /// The GetUniqueValues
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <returns>The <see cref="string[]"/></returns>
        string[] GetUniqueValues(DataTable table, string column);

        /// <summary>
        /// The GetProgramElements
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="Dictionary{string, string[]}"/></returns>
        Dictionary<string, string[]> GetProgramElements(DataTable table);
    }
}
