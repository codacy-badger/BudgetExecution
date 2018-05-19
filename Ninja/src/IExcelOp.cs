using System;
using Excel = Microsoft.Office.Interop.Excel;



namespace BudgetExecution
{
    public interface IExcelOp
    {
        //Properties
        Tuple<string, string> ConnectionString { get; set; }
        string ExcelFile { get; set; }

        //Methods
        Excel.Application GetApplication();
        string GetConnectionString();
        string GetFile();
        Excel.Workbook GetWorkbook(Excel.Application excel, string filepath);
        void ReleaseObject(object obj);
        void SaveWorkBook(Excel.Workbook wb);

    }
}