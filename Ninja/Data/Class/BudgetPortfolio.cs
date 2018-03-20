#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class BudgetPortfolio
            {
                #region Properties

                public Query DocumentQuery { get; set; }
                public Tuple<DataTable, List<DocInfo>> SqlDocumentData { get; internal set; }
                public Tuple<DataTable, DataRow[], decimal, int> BudgetCollection { get; set; }
                public List<string> BudgetList { get; set; }

                #endregion Properties

                #region Contructors

                public BudgetPortfolio( )
                {
                }

                public BudgetPortfolio(Dictionary<string, object> param)
                {
                    DocumentQuery = new Query(Source.B6, param);
                    BudgetCollection = new DataBuilder(Source.B6).SqlData;
                }

                #endregion Contructors

                #region Methods

                internal SQLiteConnection GetSqlConnection( )
                {
                    try
                    {
                        return DocumentQuery.Connection;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString( ) + "  GetSqlConnection() Error!");
                        return null;
                    }
                }

                internal OleDbConnection GetExcelConnection( )
                {
                    try
                    {
                        string excelString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\EPA\database\Budgets.xlsx;
                            Extended Properties=\'Excel 12.0 Xml; HDR = YES;\';";
                        OleDbConnection connection = new OleDbConnection(excelString);
                        return connection;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString( ));
                        return null;
                    }
                }

                #endregion Methods
            }
        }
    }
}