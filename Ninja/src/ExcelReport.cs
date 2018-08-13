﻿// <copyright file="ExcelReport.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Security.Policy;
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
            Excel = Create();
        }

        public ExcelReport(DataTable data)
        {
            Table = data;
            Excel = Create();
        }
        
        public ExcelReport(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            Excel = Create();
        }
                
        public ExcelReport(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.DbTable;
            Excel = Create();
        }

        public ExcelReport(DataBuilder data)
        {
            DbData = data;
            Table = DbData.DbTable;
            Excel = Create();
        }

        // PROPERTIES
        public Source Source { get;set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; }

        public string FilePath { get; }

        internal string ConnectionString { get; set; }

        private DocInfo AccountingInfo { get; set; }

        private Excel Excel { get; }

        // METHODS
        public string GetConnectionString(string filepath)
        {
            return $@"Provider=Microsoft.ACE.OLEDB.12.0;DbData Source='{filepath}';Extended Properties='Excel 12.0 Macro;HDR=YES;IMEX=1'";
        }

        internal string GetExternalFile()
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

        internal Workbook ExportData(DataTable table)
        {
            try
            {
                Excel excel = Create();
                Workbook excelWorkBook = excel.Workbooks.Open(path);
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
            catch (Exception ex)
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
                Workbook excelWorkBook = excel.Workbooks.Open(filepath);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal Workbook OpenFile(string filepath)
        {
            try
            {
                Workbook excelWorkBook = Excel.Workbooks.Open(filepath);
                return excelWorkBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
                return null;
            }
        }

        internal Workbook OpenWorkbook()
        {
            try
            {
                Workbook excelWorkBook = Excel.Workbooks.Add();
                return excelWorkBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.StackTrace);
                return null;
            }
        }

        internal void SaveWorkbook(Workbook wb, string filepath)
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