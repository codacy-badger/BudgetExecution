// <copyright file="ExcelDocument.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Microsoft.Office.Interop.Excel;
    using Syncfusion.Windows.Forms.Diagram;
    using Syncfusion.XlsIO.Implementation.Collections;
    using DataTable = System.Data.DataTable;
    using Excel = Microsoft.Office.Interop.Excel.Application;

    public class ExcelDocument
    {
        private readonly string path = @"C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\Report\BudgetControlTemplate.xlsx";

        // CONSTRUCTORS
        public ExcelDocument()
        {
            BudgetTemplate = path;
        }

        public ExcelDocument(string filepath)
        {
            ExternalFilePath = filepath;
            Query = new ExcelQuery(Source.External);
            ConnectionString = GetConnectionString(ExternalFilePath);
        }

        public ExcelDocument(Source source)
        {
            Source = source;
            Provider = Provider.SQLite;
            Sheet = Sheet.Budget;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
        }

        public ExcelDocument(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            RC = GetDivisionInfo(Source);
            Division = new Division(Source);
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public Sheet Sheet { get; }

        public ExcelQuery Query { get; set; }

        public DivisionAuthority D6 { get; set; }

        public DataBuilder DbData { get; set; }

        public Division Division { get; set; }

        public DataRow[] Authority { get; set; }

        public DataTable Table { get; set; }

        public string RC { get; set; }

        public string ExternalFilePath { get; set; }

        public string InternalFilePath { get; set; }

        public string Report { get; set; }

        public string BudgetTemplate { get; set; }

        public Excel Excel { get; }

        public Workbook Workbook { get; set; }

        public Worksheet PRC { get; set; }

        internal string ConnectionString { get; set; }

        private DocInfo AccountingInfo { get; set; }

        // METHODS
        private string GetFilePath(Sheet sheet)
        {
            try
            {
                switch (sheet)
                {
                    case Sheet.Budget:
                        return BudgetTemplate = GetInternalFilePath();
                    case Sheet.Internal:
                        return BudgetTemplate = GetInternalFilePath();
                    case Sheet.External:
                        return ExternalFilePath = GetExternalFilePath();
                    case Sheet.Report:
                        return Report = GetInternalFilePath();
                    default:
                        return BudgetTemplate = GetInternalFilePath();
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private string GetDivisionInfo(Source source)
        {
            try
            {
                switch (Source)
                {
                    case Source.WSA:
                    case Source.EJ:
                    case Source.EN:
                    case Source.MD:
                    case Source.MM:
                    case Source.RA:
                    case Source.RC:
                    case Source.SF:
                    case Source.WQ:
                    case Source.WCF:
                    case Source.XA:
                    {
                        var division = new Division(source);
                        return division.RC;
                    }

                    default:
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private void InitialBudgetWorksheets()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetInternalFilePath()
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetExternalFilePath()
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetConnectionString(string filepath)
        {
            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{filepath}';Extended Properties='Excel 12.0 Macro;HDR=YES;IMEX=1'";
        }

        internal void LoadInternalData()
        {
        }

        internal Workbook ExportData(DataTable table)
        {
            try
            {
                Workbook WorkBook = Excel.Workbooks.Open(path);
                int tr = table.Rows.Count;
                Worksheet WorkSheet = (Worksheet)WorkBook.Sheets[1];
                WorkSheet.Name = table.TableName;
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    WorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        WorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }

                Excel.Visible = true;
                return WorkBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Workbook.Close(true);
                Excel.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(Excel);
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
            finally
            {
                Workbook.Close(true);
                Excel.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(Excel);
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
            finally
            {
                Workbook.Close(true);
                Excel.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(Excel);
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
            finally
            {
                Workbook.Close(true);
                Excel.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(Excel);
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
            finally
            {
                Workbook.Close(true);
                Excel.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(Excel);
            }
        }

        internal void Close(Workbook wb)
        {
            if (wb != null)
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
                finally
                {
                    Workbook.Close(true);
                    ReleaseObject(Workbook);
                    ReleaseObject(Excel);
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
            finally
            {
                ReleaseObject(Excel);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
