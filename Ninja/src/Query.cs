using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;

namespace BudgetExecution
{
    public class Query
    {
        //Constructors
        public Query()
        {
        }
        public Query(Source source)
        {
            Source = source;
            Provider = Provider.SQLite;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            DataConnection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            Adapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }
        public Query(Source source, Provider provider, Dictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            DataConnection = GetConnection(provider);
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            Adapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }
        public Query(Source source, Dictionary<string, object> param)
        {
            DataConnection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
            Source = source;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSqlStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            Adapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }
        public Query(Provider provider, string sourcePath, Dictionary<string, object> param)
        {
            TableName = sourcePath;
            Parameter = param;
            switch (provider)
            {
                case (Provider.SQLite):
                    DataConnection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
                    break;
                case (Provider.SqlCe):
                    DataConnection = new SqlConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
                    break;
                case (Provider.SqlServer):
                    DataConnection = new SQLiteConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlServer\R6.mdf;Integrated Security=True;Connect Timeout=30");
                    break;
                case (Provider.OleDb):
                    DataConnection = new OleDbConnection(@"Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.accdb");
                    break;
            }
            SelectStatement = GetSqlStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            Adapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        //Properties
        public Source Source { get; }
        public Provider Provider { get; }
        public Command SqlCommand { get; set; }
        public AppSettingsReader Settings { get; }
        public DbConnection DataConnection { get; }
        public Dictionary<string, object> Parameter { get; }
        public string TableName { get; }
        public Dictionary<string, string> SqlStatement { get; set; }
        public string SelectStatement { get; set; }
        public DbCommand SelectCommand { get; }
        public DbDataReader DataReader { get; set; }
        public DbDataAdapter Adapter { get; set; }
        public DbCommandBuilder CommandBuilder { get; internal set; }
        public DbCommand DeleteCommand { get; }
        public DbCommand InsertCommand { get; }
        public DbCommand UpdateCommand { get; }

        //Methods
        private string GetParamSelectString(Dictionary<string, object> param)
        {
            try
            {
                string vals = "";
                foreach (KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{ kvp.Key } = '{(kvp.Value).ToString()}' AND ";
                }
                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public string GetSqlStatement(string table, Dictionary<string, object> param)
        {
            try
            {
                if(param.ContainsKey("ID"))
                    return $"SELECT * FROM {table} WHERE ID = { (int)param["ID"] }";
                else
                    return $"SELECT * FROM {table} WHERE {GetParamSelectString(param)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public string GetSqlStatement(string table, string sql)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {sql}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public string GetSqlStatement(string sql)
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {sql}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        internal DbCommand GetSelectCommand(string select, IDbConnection connection)
        {
            try
            {
                if (connection is SQLiteConnection)
                {
                    SelectStatement = select;
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }
                if (connection is OleDbConnection)
                {
                    SelectStatement = select;
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }
                if (connection is SqlConnection)
                {
                    SelectStatement = select;
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        internal DbCommand GetSelectCommand(Dictionary<string, object> param, IDbConnection connection)
        {
            try
            {
                if (connection is SQLiteConnection)
                {
                    SelectStatement = GetParamSelectString(param);
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }
                if (connection is OleDbConnection)
                {
                    SelectStatement = GetParamSelectString(param);
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }
                if (connection is SqlConnection)
                {
                    SelectStatement = GetParamSelectString(param);
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        internal DbConnection GetConnection(Provider provider)
        {
            try
            {
                switch (provider)
                {
                    case (Provider.SQLite):
                        return new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
                    case (Provider.SqlCe):
                        return new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
                    case (Provider.SqlServer):
                        return new SQLiteConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlServer\R6.mdf;Integrated Security=True;Connect Timeout=30");
                    case (Provider.OleDb):
                        return new SQLiteConnection(@"Data Source = C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.accdb");
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public DbDataAdapter GetDataAdapter(IDbCommand command)
        {
            try
            {
                if (command is SQLiteCommand)
                    return new SQLiteDataAdapter((SQLiteCommand)command);
                if (command is OleDbCommand)
                    return new OleDbDataAdapter((OleDbCommand)command);
                if (command is SqlCommand)
                    return new SqlDataAdapter((SqlCommand)command);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter)
        {
            try
            {
                if(adapter is SQLiteDataAdapter)
                {
                    CommandBuilder = new SQLiteCommandBuilder(adapter as SQLiteDataAdapter);
                    return CommandBuilder;
                }
                if (adapter is OleDbDataAdapter)
                {
                    CommandBuilder = new OleDbCommandBuilder(adapter as OleDbDataAdapter);
                    return CommandBuilder;
                }
                if (adapter is SqlDataAdapter)
                {
                    CommandBuilder = new SqlCommandBuilder(adapter as SqlDataAdapter);
                    return CommandBuilder;
                }
                if (adapter is SqlDataAdapter)
                {
                    CommandBuilder = new SqlCommandBuilder(adapter as SqlDataAdapter);
                    return CommandBuilder;
                }

                return null;
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
    }
}