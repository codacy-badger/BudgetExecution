// <copyright file="ExcelReport.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Excel = Microsoft.Office.Interop.Excel.Application;
    using Workbook = Microsoft.Office.Interop.Excel.Workbook;
    using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

    public class ExcelReport
    {
        private string path = @"C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\Report\BudgetControlTemplate.xlsx";

        // CONSTRUCTORS
        public ExcelReport()
        {
        }

        public ExcelReport(string filepath)
        {
            FilePath = filepath;
            ConnectionString = GetConnectionString(FilePath);
        }

        public ExcelReport(DataTable data)
        {
            Table = data;
        }
        public ExcelReport(DataBuilder data)
        {
            DbData = data;
            Table = DbData.Table;
        }


        // PROPERTIES
        public DataBuilder DbData { get; set; }

        public DataTable Table { get; }

        public string FilePath { get; }

        internal string ConnectionString { get; set; }

        private DocInfo AccountingInfo { get; set; }

        private Excel Excel { get; }

        // METHODS
        internal string GetExternalExcelFile()
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Excel Files | *.xls; * .xlsx";
                DialogResult dr = od.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    return od.SafeFileName;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return null;
            }
        }

        public string GetConnectionString(string filepath)
        {
            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{filepath}';Extended Properties='Excel 12.0 Macro;HDR=YES;IMEX=1'";
        }

        internal Workbook ExportData(DataTable table)
        {
            try
            {
                Excel excel = Create();
                var excelWorkBook = excel.Workbooks.Open(path);
                int tr = table.Rows.Count;
                Worksheet excelWorkSheet = (Worksheet)excelWorkBook.Sheets[1];
                excelWorkSheet.Name = table.TableName;
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }

                excel.Visible = true;
                return excelWorkBook;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal Workbook ExportData(string filepath, DataTable table)
        {
            try
            {
                Excel excel = Create();
                var excelWorkBook = excel.Workbooks.Open(filepath);
                int tr = table.Rows.Count;
                Worksheet excelWorkSheet = (Worksheet)excelWorkBook.Sheets[1];
                excelWorkSheet.Name = table.TableName;
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }

                excel.Visible = true;
                return excelWorkBook;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal Workbook OpenFile(string filepath)
        {
            try
            {
                Excel excel = Create();
                var excelWorkBook = excel.Workbooks.Open(filepath);
                return excelWorkBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
                return null;
            }
        }

        internal Workbook OpenNew()
        {
            try
            {
                Excel excel = Create();
                var excelWorkBook = excel.Workbooks.Add();
                return excelWorkBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
                return null;
            }
        }

        internal void SaveAs(Workbook wb, string filepath)
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                wb.SaveAs(filepath);
                wb.Close();
                Marshal.ReleaseComObject(wb.Worksheets);
                Marshal.ReleaseComObject(wb);
                wb.Application.Quit();
                Marshal.ReleaseComObject(wb.Application);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
            }
        }

        internal void Close(Workbook wb)
        {
            if(wb != null)
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (wb.Worksheets != null)
                    {
                        Marshal.ReleaseComObject(wb.Worksheets);
                    }

                    Marshal.ReleaseComObject(wb);
                    wb.Close();
                    wb.Application.Quit();
                    Marshal.ReleaseComObject(wb.Application);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!" + ex.StackTrace);
                }
            }
        }

        private Excel Create()
        {
            try
            {
                return new Excel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
                return null;
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}