namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;

    public class Query : IQuery
    {
        // CONSTRUCTORS
        public Query()
        {
        }

        public Query(Source source = Source.PRC, Provider provider = Provider.SQLite)
        {
            Provider = provider;
            Source = source;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public Query(Source source, Provider provider, Dictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Parameter = param;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            Settings = new AppSettingsReader();
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        // PROPERTIES
        public AppSettingsReader Settings { get; }

        public Dictionary<string, object> Parameter { get; }

        public DbParameter[] Parameters { get; set; }

        public string TableName { get; }

        public string SelectStatement { get; set; }

        public DbCommand SelectCommand { get; }

        public DbCommandBuilder CommandBuilder { get; internal set; }

        public DbCommand DeleteCommand { get; internal set; }

        public DbCommand InsertCommand { get; internal set; }

        public DbCommand UpdateCommand { get; internal set; }

        public Source Source { get; }

        public Provider Provider { get; }

        public DbConnection DataConnection { get; }

        public string SqlStatement { get; set; }

        public DbDataReader DataReader { get; set; }

        public DbDataAdapter DataAdapter { get; set; }

        public DbCommand DataCommand { get; set; }

        // METHODS
        /// <summary>
        ///     Gets the connection.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public DbConnection GetDataConnection(Provider provider)
        {
            try
            {
                switch(provider)
                {
                    case Provider.SQLite:
                        return new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\sqlite\R6.db");

                    case Provider.SqlCe:
                        return new SqlCeConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\sqlce\R6.sdf");

                    case Provider.SqlServer:
                        return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\sqlserver\R6.mdf;Integrated Security=True;Connect Timeout=30");
                    
                    case Provider.OleDb:
                        return new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; DbData Source =| DataDirectory |\database\oledb\R6.accdb");
                    
                    case Provider.Access:
                        return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\oledb\R6.mdb;Persist Security Info=True");
                    
                    case Provider.Excel:
                        return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\oledb\R6.mdb;Persist Security Info=True");
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
        ///     Gets the SQL statement.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public string GetSqlStatement(string sql)
        {
            try
            {
                return$"SELECT * FROM {TableName} WHERE {sql}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data command.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        public DbCommand GetDataCommand(string sql, DbConnection connection)
        {
            try
            {
                switch(connection)
                {
                    case SQLiteConnection liteConnection:
                        SqlStatement = sql;
                        return new SQLiteCommand(SqlStatement, liteConnection);
                    case OleDbConnection dbConnection:
                        SqlStatement = sql;
                        return new OleDbCommand(SqlStatement, dbConnection);
                    case SqlCeConnection sqlceConnection:
                        SqlStatement = sql;
                        return new SqlCeCommand(SqlStatement, sqlceConnection);
                    case SqlConnection sqlConnection:
                        SqlStatement = sql;
                        return new SqlCommand(SqlStatement, sqlConnection);
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data adapter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public DbDataAdapter GetDataAdapter(IDbCommand command)
        {
            try
            {
                switch(command)
                {
                    case SQLiteCommand liteCommand:
                        return new SQLiteDataAdapter(liteCommand);
                    case OleDbCommand dbCommand:
                        return new OleDbDataAdapter(dbCommand);
                    case SqlCeCommand sqlCommand:
                        return new SqlCeDataAdapter(sqlCommand);
                    case SqlCommand sqlCommand:
                        return new SqlDataAdapter(sqlCommand);
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data reader.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public DbDataReader GetDataReader(IDbCommand command)
        {
            try
            {
                switch(command)
                {
                    case SQLiteCommand liteCommand:
                        return liteCommand.ExecuteReader();
                    case OleDbCommand dbCommand:
                        return dbCommand.ExecuteReader();
                    case SqlCommand sqlCommand:
                        return sqlCommand.ExecuteReader();
                    case SqlCeCommand sqlceCommand:
                        return sqlceCommand.ExecuteReader();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the command builder.
        /// </summary>
        /// <param name="adapter">The adapter.</param>
        /// <returns></returns>
        public DbCommandBuilder GetCommandBuilder(DbDataAdapter adapter)
        {
            try
            {
                switch(adapter)
                {
                    case SQLiteDataAdapter _:
                        CommandBuilder = new SQLiteCommandBuilder(adapter as SQLiteDataAdapter);
                        return CommandBuilder;
                    case OleDbDataAdapter _:
                        CommandBuilder = new OleDbCommandBuilder(adapter as OleDbDataAdapter);
                        return CommandBuilder;
                    case SqlCeDataAdapter _:
                        CommandBuilder = new SqlCeCommandBuilder(adapter as SqlCeDataAdapter);
                        return CommandBuilder;
                    case SqlDataAdapter _:
                        CommandBuilder = new SqlCommandBuilder(adapter as SqlDataAdapter);
                        return CommandBuilder;
                    default:
                        return null;
                }
            }
            catch(SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the parameter strings.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSqlParameterString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                DbParameter[] sqlparameter = GetDataParameters(param);
                foreach(DbParameter p in sqlparameter)
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

        /// <summary>
        ///     Gets the select statement.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSelectStatement(string table, Dictionary<string, object> param)
        {
            try
            {
                return$"SELECT * FROM {table} WHERE {GetSqlParameterString(param)}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the select statement.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public string GetSelectStatement(string tableName, string sql)
        {
            try
            {
                return$"SELECT * FROM {tableName} WHERE {sql}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the database parameters.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public DbParameter[] GetDataParameters(Dictionary<string, object> input)
        {
            try
            {
                DbParameter[] val = new DbParameter[input.Count];
                for(int i = 0; i < input.Count; i++)
                {
                    foreach(KeyValuePair<string, object> kvp in input)
                    {
                        val[i] = new SQLiteParameter(kvp.Key, kvp.Value);
                        val[i].SourceColumn = kvp.Key;
                        if(kvp.Key.Equals("ID"))
                        {
                            val[i].DbType = DbType.Int64;
                        }

                        if(kvp.Key.Equals("Obligations"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if(kvp.Key.Equals("Commitments"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if(kvp.Key.Equals("LeaveHours"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if(kvp.Key.Equals("WorkHours"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        val[i].DbType = kvp.Key.Equals("Amount") ? DbType.Decimal : DbType.String;
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

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSelectStatement(Source source, DbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(DbParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the select statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSelectStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return$"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the update statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="update">The update.</param>
        /// <returns></returns>
        public string GetUpdateStatement(Source source, DbParameter[] update)
        {
            try
            {
                string vals = string.Empty;
                int pid = 0;
                foreach(DbParameter p in update)
                {
                    if(p.SourceColumn == "ID")
                    {
                        pid = (int) p.Value;
                    }

                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return$"UPDATE {source.ToString()} SET {vals} WHERE ID = '{pid.ToString()}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the insert statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetInsertStatement(Source source, DbParameter[] param)
        {
            try
            {
                string cols = string.Empty;
                string vals = string.Empty;
                foreach(DbParameter p in param)
                {
                    cols += $"{p.SourceColumn}, ";
                    vals += $"{p.Value}, ";
                }

                cols = cols.Trim().Substring(0, cols.Length - 2);
                vals = vals.Trim().Substring(0, vals.Length - 2);
                return$"INSERT INTO {source.ToString()} ({cols}) VALUES ({vals})";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the delete statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetDeleteStatement(Source source, DbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(DbParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return$"DELETE * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the select command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public DbCommand GetSelectCommand(DbParameter[] pmr, DbConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetSelectStatement(source, pmr);
                    DbCommand select = GetDataCommand(sql, connection);
                    foreach(DbParameter p in pmr)
                    {
                        select.Parameters.Add(p);
                    }

                    return select;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the select command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public SQLiteCommand GetSelectCommand(SQLiteParameter[] pmr, SQLiteConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetSelectStatement(source, pmr);
                    SQLiteCommand select = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
                    {
                        select.Parameters.Add(p);
                    }

                    return select;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the update command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DbCommand GetUpdateCommand(DbParameter[] pmr, DbConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetUpdateStatement(source, pmr);
                    DbCommand update = GetDataCommand(sql, connection);
                    foreach(DbParameter p in pmr)
                    {
                        update.Parameters.Add(p);
                    }

                    return update;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the insert command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DbCommand GetInsertCommand(DbParameter[] pmr, DbConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetInsertStatement(source, pmr);
                    DbCommand insert = GetDataCommand(sql, connection);
                    foreach(DbParameter p in pmr)
                    {
                        insert.Parameters.Add(p);
                    }

                    return insert;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the delete command.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        public DbCommand GetDeleteCommand(Source source, DbParameter[] pmr, DbConnection connection)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetDeleteStatement(source, pmr);
                    DbCommand delete = GetDataCommand(sql, connection);
                    foreach(DbParameter p in pmr)
                    {
                        delete.Parameters.Add(p);
                    }

                    return delete;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the data command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="cmd">The command.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DbCommand GetDataCommand(DbParameter[] pmr, DbConnection connection, Sql cmd, Source source = Source.PRC)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        return GetSelectCommand(pmr, connection);

                    case Sql.UPDATE:
                        return GetUpdateCommand(pmr, connection);

                    case Sql.INSERT:
                        return GetInsertCommand(pmr, connection);

                    case Sql.DELETE:
                        return GetDeleteCommand(source, pmr, connection);

                    default:
                        return GetSelectCommand(pmr, connection);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the select command.
        /// </summary>
        /// <param name="select">The select.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        internal DbCommand GetSelectCommand(string select, IDbConnection connection)
        {
            try
            {
                if(connection is SQLiteConnection)
                {
                    SelectStatement = select;
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection) connection);
                }

                if(connection is OleDbConnection)
                {
                    SelectStatement = select;
                    return new OleDbCommand(SelectStatement, (OleDbConnection) connection);
                }

                if(connection is SqlConnection)
                {
                    SelectStatement = select;
                    return new SqlCommand(SelectStatement, (SqlConnection) connection);
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
        ///     Gets the select command.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        internal DbCommand GetSelectCommand(Dictionary<string, object> param, IDbConnection connection)
        {
            try
            {
                if(connection is SQLiteConnection)
                {
                    SelectStatement = GetSelectParamString(GetDataParameters(param));
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection) connection);
                }

                if(connection is OleDbConnection)
                {
                    SelectStatement = GetSelectParamString(GetDataParameters(param));
                    return new OleDbCommand(SelectStatement, (OleDbConnection) connection);
                }

                if(connection is SqlConnection)
                {
                    SelectStatement = GetSelectParamString(GetDataParameters(param));
                    return new SqlCommand(SelectStatement, (SqlConnection) connection);
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
        ///     Gets the select parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal string GetSelectParamString(DbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(var p in param)
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
    }
}
