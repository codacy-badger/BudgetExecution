using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IExcelOp
            {
                #region Properties

                Tuple<string, string> ConnectionString { get; set; }
                string ExcelFile { get; set; }

                #endregion

                #region Methods

                Excel.Application GetApplication();

                string GetConnectionString();

                string GetFile();

                Excel.Workbook GetWorkbook(Excel.Application excel, string filepath);

                void ReleaseObject(object obj);

                void SaveWorkBook(Excel.Workbook wb);

                #endregion
            }
        }
    }
}