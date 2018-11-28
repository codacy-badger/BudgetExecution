// <copyright file="ExcelDocument.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using OfficeOpenXml;

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Microsoft.Office.Interop.Excel;
    using DataTable = System.Data.DataTable;

    /// <summary>
    /// Defines the <see cref="ExcelDocument" />
    /// </summary>
    public class ExcelDocument
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDocument"/> class.
        /// </summary>
        public ExcelDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDocument"/> class.
        /// </summary>
        /// <param name="filepath">The filepath<see cref="string"/></param>
        public ExcelDocument(string filepath)
        {
            ExternalFilePath = filepath;
            Query = new ExcelQuery(Source.External);
            ConnectionString = GetConnectionString(ExternalFilePath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDocument"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        public ExcelDocument(Source source)
        {
            Source = source;
            Provider = Provider.SQLite;
            Excel = Excel.Budget;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDocument"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
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
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets the Sheet
        /// </summary>
        public Excel Excel { get; }

        /// <summary>
        /// Gets or sets the Query
        /// </summary>
        public ExcelQuery Query { get; set; }

        /// <summary>
        /// Gets or sets the Authority
        /// </summary>
        public DivisionAuthority Authority { get; set; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        /// Gets or sets the Division
        /// </summary>
        public Division Division { get; set; }

        /// <summary>
        /// Gets or sets the Allocation
        /// </summary>
        public DataRow[] Allocation { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public string RC { get; set; }

        /// <summary>
        /// Gets or sets the FilePath
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the ExternalFilePath
        /// </summary>
        public string ExternalFilePath { get; set; }

        /// <summary>
        /// Gets or sets the InternalFilePath
        /// </summary>
        public string InternalFilePath { get; set; }

        /// <summary>
        /// Gets or sets the Report
        /// </summary>
        public string Report { get; set; }

        /// <summary>
        /// Gets or sets the BudgetTemplate
        /// </summary>
        public string BudgetTemplate { get; set; }

        /// <summary>
        /// Gets or sets the Excel
        /// </summary>
        public Microsoft.Office.Interop.Excel.Application ExcelApplication { get; set; }

        /// <summary>
        /// Gets or sets the Workbook
        /// </summary>
        public Workbook Workbook { get; set; }

        /// <summary>
        /// Gets or sets the PRC
        /// </summary>
        public Worksheet PRC { get; set; }

        /// <summary>
        /// Gets or sets the excel package.
        /// </summary>
        /// <value>
        /// The excel package.
        /// </value>
        public ExcelPackage ExcelPackage { get; set; }

        /// <summary>
        /// Gets or sets the ConnectionString
        /// </summary>
        internal string ConnectionString { get; set; }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="Excel">The sheet.</param>
        /// <returns></returns>
        private string GetFilePath(Excel Excel)
        {
            try
            {
                switch(Excel)
                {
                    case Excel.Budget:
                        return BudgetTemplate = GetFilePathBrowser();
                    case Excel.Internal:
                        return BudgetTemplate = GetFilePathBrowser();
                    case Excel.External:
                        return ExternalFilePath = GetExternalFilePath();
                    case Excel.Report:
                        return Report = GetFilePathBrowser();
                    default:
                        return BudgetTemplate = GetFilePathBrowser();
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the division information.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private string GetDivisionInfo(Source source)
        {
            try
            {
                switch(Source)
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
                        Division division = new Division(source);
                        return division.RC;
                    }

                    default:
                    {
                        return null;
                    }
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the internal file path.
        /// </summary>
        /// <returns></returns>
        public string GetInternalFilePath()
        {
            try
            {
                return ConfigurationManager.AppSettings["Report"];
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the file path browser.
        /// </summary>
        /// <returns></returns>
        public string GetFilePathBrowser()
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Excel Files | *.xls; * .xlsx";
                DialogResult dr = od.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    return od.SafeFileName;
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the external file path.
        /// </summary>
        /// <returns></returns>
        public string GetExternalFilePath()
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Excel Files | *.xls; * .xlsx";
                DialogResult dr = od.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    return od.SafeFileName;
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the connection string using the ConfigurationManager class and
        ///     the GetInternalFilePath method.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        public string GetConnectionString(string filepath)
        {
            try
            {
                ConnectionStringSettingsCollection connectionString = ConfigurationManager.ConnectionStrings;
                string connectionstring = connectionString["Excel"].ConnectionString;
                return connectionstring.Replace($"{filepath}", GetInternalFilePath());
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetBudgetReport
        /// </summary>
        public void GetBudgetReport()
        {
        }

        /// <summary>
        /// Loads the internal data.
        /// </summary>
        internal void LoadFromDatabase()
        {
        }

        /// <summary>
        /// Exports the data.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        internal Workbook ExportData(DataTable table)
        {
            try
            {
                Workbook WorkBook = ExcelApplication.Workbooks.Open(GetInternalFilePath());
                Worksheet WorkSheet = (Worksheet)WorkBook.Sheets[1];
                WorkSheet.Name = table.TableName;
                for(int i = 1; i < table.Columns.Count + 1; i++)
                {
                    WorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for(int j = 0; j < table.Rows.Count; j++)
                {
                    for(int k = 0; k < table.Columns.Count; k++)
                    {
                        WorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }

                ExcelApplication.Visible = true;
                return WorkBook;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
            finally
            {
                Workbook.Close(true);
                ExcelApplication.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Exports the data.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        internal Workbook ExportData(string filepath, DataTable table)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = Create();
                Workbook excelWorkBook = excel.Workbooks.Open(filepath);
                Worksheet excelWorkSheet = (Worksheet)excelWorkBook.Sheets[1];
                excelWorkSheet.Name = table.TableName;
                for(int i = 1; i <= table.Columns.Count; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for(int j = 0; j < table.Rows.Count; j++)
                {
                    for(int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }

                excel.Visible = true;
                return excelWorkBook;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
            finally
            {
                Workbook.Close(true);
                ExcelApplication.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        internal Workbook OpenFile(string filepath)
        {
            try
            {
                Workbook excelWorkBook = ExcelApplication.Workbooks.Open(filepath);
                return excelWorkBook;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
            finally
            {
                Workbook.Close(true);
                ExcelApplication.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Opens the workbook.
        /// </summary>
        /// <returns></returns>
        internal Workbook OpenWorkbook()
        {
            try
            {
                Workbook excelWorkBook = ExcelApplication.Workbooks.Add();
                return excelWorkBook;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
            finally
            {
                Workbook.Close(true);
                ExcelApplication.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Saves the workbook.
        /// </summary>
        /// <param name="wb">The wb.</param>
        /// <param name="filepath">The filepath.</param>
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
            finally
            {
                Workbook.Close(true);
                ExcelApplication.Quit();
                ReleaseObject(Workbook);
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Closes the specified wb.
        /// </summary>
        /// <param name="wb">The wb.</param>
        internal void Close(Workbook wb)
        {
            if(wb != null)
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if(wb.Worksheets != null)
                    {
                        Marshal.ReleaseComObject(wb.Worksheets);
                    }

                    Marshal.ReleaseComObject(wb);
                    wb.Close();
                    wb.Application.Quit();
                    Marshal.ReleaseComObject(wb.Application);
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                }
                finally
                {
                    Workbook.Close(true);
                    ReleaseObject(Workbook);
                    ReleaseObject(ExcelApplication);
                }
            }
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        private Microsoft.Office.Interop.Excel.Application Create()
        {
            try
            {
                return new Microsoft.Office.Interop.Excel.Application();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
            finally
            {
                ReleaseObject(ExcelApplication);
            }
        }

        /// <summary>
        /// Releases the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
