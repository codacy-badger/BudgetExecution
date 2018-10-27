using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BudgetExecution
{
    public class SqlServerQuery : Query
    {
        // CONSTRUCTORS
        public SqlServerQuery()
        {
        }

        public SqlServerQuery(Source source) : base(source, Provider.SqlServer)
        {
            Source = source;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            DataConnection = new SqlConnection(@"Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.mdf");
            SelectCommand = new SqlCommand(SelectStatement, DataConnection);
            DataAdapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        public SqlServerQuery(Source source, Dictionary<string, object> param) : base(param, source, Provider.SqlServer, Sql.SELECT)
        {
            Source = source;
            Provider = Provider.SqlServer;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSelectStatement(TableName, Parameter);
            DataConnection = new SqlConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\SqlCe\R6.mdf");
            SelectCommand = new SqlCommand(SelectStatement, DataConnection);
            DataAdapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        // PROPERTIES
        public new Source Source { get; }

        public new Provider Provider { get; }

        public new AppSettingsReader Settings { get; set; }

        public new SqlConnection DataConnection { get; set; }

        public Dictionary<string, object> Parameter { get; set; }

        public new string TableName { get; set; }

        public new string SqlStatement { get; set; }

        public new string SelectStatement { get; set; }

        public new SqlCommand SelectCommand { get; set; }

        public new SqlDataReader DataReader { get; set; }

        public new SqlDataAdapter DataAdapter { get; set; }

        public new SqlCommandBuilder CommandBuilder { get; internal set; }

        public new SqlCommand DataCommand { get; set; }

        public new SqlCommand DeleteCommand { get; set; }

        public new SqlCommand InsertCommand { get; set; }

        public new SqlCommand UpdateCommand { get; set; }

        // METHODS
        public new string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                SqlParameter[] sqlparameter = GetParameter(param);
                foreach(SqlParameter p in sqlparameter)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectParamString(SqlParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(SqlParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlParameter[] GetParameter(Dictionary<string, object> param)
        {
            try
            {
                SqlParameter[] val = new SqlParameter[param.Count];
                for(int i = 0; i < param.Count; i++)
                {
                    foreach(KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new SqlParameter(kvp.Key, kvp.Value);
                        val[i].SourceColumn = kvp.Key;
                        if(kvp.Key.Equals("ID"))
                        {
                            val[i].DbType = DbType.Int64;
                        }

                        if(kvp.Key.Equals("Amount"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }
                        else
                        {
                            val[i].DbType = DbType.String;
                        }
                    }
                }

                return val;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public new string GetSelectStatement(string table, Dictionary<string, object> param)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {GetSelectParamString(param)}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlStatement(string table, string sql)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {sql}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public new string GetSqlStatement(string sql)
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {sql}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlConnection GetConnection(Provider provider)
        {
            try
            {
                return new SqlConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlCommand GetDataCommand(string select, SqlConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SqlCommand(select, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlDataAdapter GetDataAdapter(SqlCommand command)
        {
            try
            {
                return new SqlDataAdapter(command);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlDataReader GetDataReader(SqlCommand command)
        {
            try
            {
                return command.ExecuteReader();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlCommandBuilder GetCommandBuilder(SqlDataAdapter adapter)
        {
            try
            {
                return new SqlCommandBuilder(adapter);
            }
            catch(SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlCommand GetSelectCommand(string select, SqlConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SqlCommand(SelectStatement, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SqlCommand GetSelectCommand(Dictionary<string, object> param, SqlConnection connection)
        {
            try
            {
                SelectStatement = GetSelectParamString(param);
                return new SqlCommand(SelectStatement, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
