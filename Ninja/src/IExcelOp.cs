// <copyright file="IExcelOp.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using Microsoft.Office.Interop.Excel;

namespace BudgetExecution
{
    public interface IExcelOp
    {
        // PROPERTIES
        Tuple<string, string> ConnectionString { get; set; }

        string ExcelFile { get; set; }

        // METHODS
        Microsoft.Office.Interop.Excel.Application GetApplication();

        string GetConnectionString();

        string GetFile();

        Workbook GetWorkbook(Microsoft.Office.Interop.Excel.Application excel, string filepath);

        void ReleaseObject(object obj);

        void SaveWorkBook(Workbook wb);
    }
}
