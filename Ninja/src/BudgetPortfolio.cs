namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public class BudgetPortfolio
    {

        public BudgetPortfolio()
        {
        }

        public BudgetPortfolio(Dictionary<string, object> param)
        {
            DocumentQuery = new Query(Source.BudgetDocument, Provider.SQLite, param);
        }


        public List<string> BudgetList { get; set; }

        public Query DocumentQuery { get; set; }

        public Tuple<DataTable, List<DocInfo>> SqlDocumentData { get; internal set; }

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

        internal IDbConnection GetSqlConnection()
        {
            try
            {
                return DocumentQuery.DataConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "  GetSqlConnection() Error!");
                return null;
            }
        }

    }
}

