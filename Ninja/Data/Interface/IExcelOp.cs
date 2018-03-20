#region Using Directives

using System;
using Excel = Microsoft.Office.Interop.Excel;

#endregion

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

                string GetFile( );

                string GetConnectionString( );

                Excel.Application GetApplication( );

                Excel.Workbook GetWorkbook(Excel.Application excel, string filepath);

                void SaveWorkBook(Excel.Workbook wb);

                void ReleaseObject(object obj);

                #endregion
            }
        }
    }
}