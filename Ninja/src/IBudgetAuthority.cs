// <copyright file="IBudgetAuthority.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Defines the <see cref="IBudgetAuthority" />
    /// </summary>
    public interface IBudgetAuthority
    {
        // PROPERTIES
        /// <summary>
        /// Gets the Table
        /// </summary>
        DataTable Table { get; }

        /// <summary>
        /// Gets the Amount
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// Gets the ProgramElements
        /// </summary>
        Dictionary<string, string[]> ProgramElements { get; }

        // METHODS
        /// <summary>
        /// The GetCodes
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <returns>The <see cref="string[]"/></returns>
        string[] GetCodes(DataTable table, string column);

        /// <summary>
        /// The GetDataValues
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="column">The column<see cref="string"/></param>
        /// <param name="filter">The filter<see cref="string"/></param>
        /// <returns>The <see cref="Tuple{DataTable, PRC[], decimal, int}"/></returns>
        Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

        /// <summary>
        /// The GetMetrics
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal[]"/></returns>
        decimal[] GetMetrics(DataTable table);

        /// <summary>
        /// The GetPrcArray
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="PRC[]"/></returns>
        PRC[] GetPrcArray(DataTable table);

        /// <summary>
        /// The GetProgramElements
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="Dictionary{string, string[]}"/></returns>
        Dictionary<string, string[]> GetProgramElements(DataTable table);

        /// <summary>
        /// The GetTotal
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        decimal GetTotal(DataTable table);
    }
}
