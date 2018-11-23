// <copyright file="IExcelOp.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// Defines the <see cref="IExcelOp" />
    /// </summary>
    public interface IExcelOp
    {
        // PROPERTIES
        /// <summary>
        /// Gets or sets the ConnectionString
        /// </summary>
        Tuple<string, string> ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the ExcelFile
        /// </summary>
        string ExcelFile { get; set; }

        // METHODS
        /// <summary>
        /// The GetApplication
        /// </summary>
        /// <returns>The <see cref="Microsoft.Office.Interop.Excel.Application"/></returns>
        Microsoft.Office.Interop.Excel.Application GetApplication();

        /// <summary>
        /// The GetConnectionString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetConnectionString();

        /// <summary>
        /// The GetFile
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetFile();

        /// <summary>
        /// The GetWorkbook
        /// </summary>
        /// <param name="excel">The excel<see cref="Microsoft.Office.Interop.Excel.Application"/></param>
        /// <param name="filepath">The filepath<see cref="string"/></param>
        /// <returns>The <see cref="Workbook"/></returns>
        Workbook GetWorkbook(Microsoft.Office.Interop.Excel.Application excel, string filepath);

        /// <summary>
        /// The ReleaseObject
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/></param>
        void ReleaseObject(object obj);

        /// <summary>
        /// The SaveWorkBook
        /// </summary>
        /// <param name="wb">The wb<see cref="Workbook"/></param>
        void SaveWorkBook(Workbook wb);
    }
}
