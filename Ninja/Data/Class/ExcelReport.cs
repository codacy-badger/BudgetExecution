using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel.Application;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class ExcelOp
            {
                internal string P7path = @"C:\Users\terry\Documents\Visual Studio 2015\Projects\Budget\Report\Templates\Budget.xlsx";

                //Constructors
                public ExcelOp()
                {
                }

                public ExcelOp(string filepath)
                {
                    FilePath = filepath;
                    ConnectionString = GetConnectionString(FilePath);
                }

                public ExcelOp(DataTable data)
                {
                    FilePath = P7path;
                    ConnectionString = GetConnectionString(FilePath);
                    Data = data;
                }

                //Properties
                public DataTable Data { get; }

                public string FilePath { get; }
                internal string ConnectionString { get; set; }
                private DocInfo AccountingInfo { get; set; }
                private Excel Excel { get; }

                //Methods
                public string GetConnectionString(string filepath)
                {
                    return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{filepath}';Extended Properties='Excel 12.0 Macro;HDR=YES;IMEX=1'";
                }

                internal Workbook ExportData(DataTable table)
                {
                    try
                    {
                        Excel excel = Create();
                        var excelWorkBook = excel.Workbooks.Open(P7path);
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

                internal string GetExternalFile()
                {
                    try
                    {
                        OpenFileDialog od = new OpenFileDialog();
                        od.Filter = "Excel Files | *.xls; * .xlsx";
                        DialogResult dr = od.ShowDialog();
                        if (dr == DialogResult.OK)
                            return od.SafeFileName;
                        return null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
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

                internal void Save(Workbook wb)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        wb.Save();
                        wb.Close();
                        Marshal.ReleaseComObject(wb.Worksheets);
                        Marshal.ReleaseComObject(wb);
                        wb.Application.Quit();
                        Marshal.ReleaseComObject(wb.Application);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!" + ex.StackTrace); ;
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
                        MessageBox.Show("ERROR!" + ex.StackTrace); ;
                    }
                }

                private Excel Create()
                {
                    try
                    {
                        Excel excel = new Excel();
                        return excel;
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
    }
}