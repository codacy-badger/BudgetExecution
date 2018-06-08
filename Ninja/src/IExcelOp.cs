namespace BudgetExecution
{
    using System;
    using Excel = Microsoft.Office.Interop.Excel;

    public interface IExcelOp
    {
        // PROPERTIES
        Tuple<string, string> ConnectionString { get; set; }

        string ExcelFile { get; set; }

        // METHODS
        Excel.Application GetApplication();

        string GetConnectionString();

        string GetFile();

        Excel.Workbook GetWorkbook(Excel.Application excel, string filepath);

        void ReleaseObject(object obj);

        void SaveWorkBook(Excel.Workbook wb);

    }
}