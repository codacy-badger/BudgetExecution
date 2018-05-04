using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;



namespace BudgetExecution
{
    public class BudgetPortfolio
    {
        #region Properties

        public List<string> BudgetList { get; set; }
        public Query DocumentQuery { get; set; }
        public Tuple<DataTable, List<DocInfo>> SqlDocumentData { get; internal set; }

        #endregion Properties

        public BudgetPortfolio()
        {
        }

        public BudgetPortfolio(Dictionary<string, object> param)
        {
            DocumentQuery = new Query(Source.BudgetDocument, param);
        }

        #region Methods

        internal OleDbConnection GetExcelConnection()
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
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        internal SQLiteConnection GetSqlConnection()
        {
            try
            {
                return DocumentQuery.Connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "  GetSqlConnection() Error!");
                return null;
            }
        }

        #endregion Methods
    }
}
    
