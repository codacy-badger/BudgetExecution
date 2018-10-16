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

        public Query(Source source = Source.PRC, Provider provider = Provider.SQLite, Sql cmb = Sql.SELECT)
        {
            Provider = provider;
            Source = source;
            CommandType = cmb;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand, CommandType);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public Query(Source source, Provider provider, Sql command, Dictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Parameters = GetDataParameters(param);            
            CommandType = command;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SqlStatement = GetSqlStatement(Source, DataConnection, Parameters, CommandType);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand, CommandType);
            Settings = new AppSettingsReader();
        }

        // PROPERTIES
        public Sql CommandType { get; }

        public Dictionary<string, object> Parameter { get; }

        public string TableName { get; }

        public AppSettingsReader Settings { get; }

        public DbParameter[] Parameters { get; set; }

        public string SelectStatement { get; set; }

        public string UpdateStatement { get; set; }

        public string InsertStatement { get; set; }

        public string DeleteStatement { get; set; }

        public DbCommand SelectCommand { get; set; }

        public DbCommand DeleteCommand { get; internal set; }

        public DbCommand InsertCommand { get; internal set; }

        public DbCommand UpdateCommand { get; internal set; }

        public DbCommandBuilder CommandBuilder { get; internal set; }

        public Source Source { get; }

        public Provider Provider { get; }

        public DbConnection DataConnection { get; }

        public string SqlStatement { get; set; }

        public DbCommand DataCommand { get; set; }

        public DbDataReader DataReader { get; set; }

        public DbDataAdapter DataAdapter { get; set; }

        /* STRING METHODS----------------------------------------------------------------
        -------------------------------------------------------------------------------*/

        /// <summary>
        ///     Gets the connection.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
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
        ///     Gets the select parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal string GetSelectParamString(DbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(DbParameter p in param)
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
                    switch(Provider)
                    {
                        case Provider.Access:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new OleDbParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case Provider.Excel:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new OleDbParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case Provider.SQLite:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SQLiteParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case Provider.SqlCe:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SqlCeParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case Provider.SqlServer:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SqlParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
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

        /// <summary>
        ///     Gets the data parameters.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public DbParameter[] GetDataParameters(DbConnection connection, Dictionary<string, object> input)
        {
            try
            {
                DbParameter[] val = new DbParameter[input.Count];
                for(int i = 0; i < input.Count; i++)
                {
                    switch(connection)
                    {
                        case OleDbConnection _:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new OleDbParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case SQLiteConnection _:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SQLiteParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case SqlCeConnection _:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SqlCeParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
                        }

                        case SqlConnection _:
                        {
                            foreach(KeyValuePair<string, object> kvp in input)
                            {
                                val[i] = new SqlParameter();
                                val[i].SourceColumn = kvp.Key;
                                val[i].Value = kvp.Value;
                            }

                            break;
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

        /// <summary>
        ///     Gets the SQL statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="p">The p.</param>
        /// <param name="cmd">The command.</param>
        /// <returns></returns>
        public string GetSqlStatement(Source source, DbConnection connection, Dictionary<string, object> p, Sql cmd)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        DbParameter[] select = GetDataParameters(connection, p);
                        SelectStatement = GetSelectStatement(source, select);
                        return SelectStatement;

                    case Sql.UPDATE:
                        DbParameter[] update = GetDataParameters(connection, p);
                        UpdateStatement = GetUpdateStatement(source, update);
                        return UpdateStatement;

                    case Sql.INSERT:
                        DbParameter[] insert = GetDataParameters(connection, p);
                        InsertStatement = GetInsertStatement(source, insert);
                        return InsertStatement;

                    case Sql.DELETE:
                        DbParameter[] delete = GetDataParameters(connection, p);
                        DeleteStatement = GetDeleteStatement(source, delete);
                        return DeleteStatement;

                    default:
                        DbParameter[] def = GetDataParameters(connection, p);
                        return GetSelectStatement(source, def);
                }
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
        /// <param name="source">The source.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="p">The p.</param>
        /// <param name="cmd">The command.</param>
        /// <returns></returns>
        public string GetSqlStatement(Source source, DbConnection connection, DbParameter[] p, Sql cmd)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        SelectStatement = GetSelectStatement(source, p);
                        return SelectStatement;

                    case Sql.UPDATE:
                        UpdateStatement = GetUpdateStatement(source, p);
                        return UpdateStatement;

                    case Sql.INSERT:
                        InsertStatement = GetInsertStatement(source, p);
                        return InsertStatement;

                    case Sql.DELETE:
                        DeleteStatement = GetDeleteStatement(source, p);
                        return DeleteStatement;

                    default:
                        return GetSelectStatement(source, p);
                }
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
                        pid = (int)p.Value;
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
        /// Gets the data connection.
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
                        return new SQLiteConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\sqlite\R6.db;foreign keys=True;datetime kind=Local;default database type=String");

                    case Provider.SqlCe:
                        return new SqlCeConnection(@"Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\sqlce\R6.sdf");

                    case Provider.SqlServer:
                        return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\sqlserver\R6.mdf;Integrated Security=True;Connect Timeout=30");

                    case Provider.Access:
                        return new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\ninja\database\oledb\R6.accdb");

                    case Provider.OleDb:
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

        // COMMAND METHODS----------------------------------------------------------------
        // -------------------------------------------------------------------------------

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
        ///     Gets the data command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="cmd">The command.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DbCommand GetDataCommand(Sql cmd, DbParameter[] pmr, DbConnection connection)
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
                        return GetDeleteCommand(pmr, connection);

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
        ///     Gets the delete command.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        public DbCommand GetDeleteCommand(DbParameter[] pmr, DbConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetDeleteStatement(source, pmr);
                    DbCommand delete = GetDataCommand(sql, connection);
                    delete.CommandText = sql;
                    delete.Connection = connection;
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
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }

                if(connection is OleDbConnection)
                {
                    SelectStatement = select;
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }

                if(connection is SqlConnection)
                {
                    SelectStatement = select;
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
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
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }

                if(connection is OleDbConnection)
                {
                    SelectStatement = GetSelectParamString(GetDataParameters(param));
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }

                if(connection is SqlConnection)
                {
                    SelectStatement = GetSelectParamString(GetDataParameters(param));
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
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
        /// <param name="pmr">The PMR.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public DbCommand GetSelectCommand(DbParameter[] pmr, DbConnection connection, Source source = Source.PRC)
        {
            try
            {
                if(pmr.Length > 0 && connection != null)
                {
                    string sql = GetSelectStatement(source, pmr);
                    DbCommand select = GetDataCommand(sql, connection);
                    select.CommandText = sql;
                    select.Connection = connection;
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
                    update.CommandText = sql;
                    update.Connection = connection;
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
                    insert.CommandText = sql;
                    insert.Connection = connection;
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

        // ADAPTER METHODS----------------------------------------------------------------
        // -------------------------------------------------------------------------------
        /// <summary>
        ///     Gets the data adapter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DbDataAdapter GetDataAdapter(DbCommand command, Sql cmd)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        if(command is SQLiteCommand)
                        {
                            SQLiteDataAdapter sqliteselect = new SQLiteDataAdapter((SQLiteCommand)command);
                            sqliteselect.SelectCommand = (SQLiteCommand)command;
                            SQLiteCommandBuilder builder = (SQLiteCommandBuilder)GetCommandBuilder(sqliteselect);
                            return sqliteselect;
                        }

                        if(command is OleDbCommand)
                        {
                            OleDbDataAdapter oledbselect = new OleDbDataAdapter((OleDbCommand)command);
                            oledbselect.SelectCommand = (OleDbCommand)command;
                            OleDbCommandBuilder builder = (OleDbCommandBuilder)GetCommandBuilder(oledbselect);
                            oledbselect.InsertCommand = builder.GetInsertCommand();
                            oledbselect.UpdateCommand = builder.GetUpdateCommand();
                            oledbselect.DeleteCommand = builder.GetDeleteCommand();
                            return oledbselect;
                        }

                        if(command is SqlCeCommand)
                        {
                            SqlCeDataAdapter sqlceselect = new SqlCeDataAdapter((SqlCeCommand)command);
                            sqlceselect.SelectCommand = (SqlCeCommand)command;
                            SqlCeCommandBuilder builder = (SqlCeCommandBuilder)GetCommandBuilder(sqlceselect);
                            sqlceselect.InsertCommand = builder.GetInsertCommand();
                            sqlceselect.UpdateCommand = builder.GetUpdateCommand();
                            sqlceselect.DeleteCommand = builder.GetDeleteCommand();
                            return sqlceselect;
                        }

                        if(command is SqlCommand)
                        {
                            SqlDataAdapter sqlselect = new SqlDataAdapter((SqlCommand)command);
                            sqlselect.SelectCommand = (SqlCommand)command;
                            SqlCommandBuilder builder = (SqlCommandBuilder)GetCommandBuilder(sqlselect);
                            sqlselect.InsertCommand = builder.GetInsertCommand();
                            sqlselect.UpdateCommand = builder.GetUpdateCommand();
                            sqlselect.DeleteCommand = builder.GetDeleteCommand();
                            return sqlselect;
                        }

                        break;

                    case Sql.UPDATE:
                        if(command is SQLiteCommand)
                        {
                            SQLiteDataAdapter update = new SQLiteDataAdapter((SQLiteCommand)command);
                            update.UpdateCommand = (SQLiteCommand)command;
                            return update;
                        }

                        if(command is OleDbCommand)
                        {
                            OleDbDataAdapter update = new OleDbDataAdapter((OleDbCommand)command);
                            update.UpdateCommand = (OleDbCommand)command;
                            return update;
                        }

                        if(command is SqlCeCommand)
                        {
                            SqlCeDataAdapter update = new SqlCeDataAdapter((SqlCeCommand)command);
                            update.UpdateCommand = (SqlCeCommand)command;
                            return update;
                        }

                        if(command is SqlCommand)
                        {
                            SqlDataAdapter update = new SqlDataAdapter((SqlCommand)command);
                            update.UpdateCommand = (SqlCommand)command;
                            return update;
                        }

                        break;

                    case Sql.INSERT:
                        if(command is SQLiteCommand)
                        {
                            SQLiteDataAdapter insert = new SQLiteDataAdapter((SQLiteCommand)command);
                            insert.InsertCommand = (SQLiteCommand)command;
                            return insert;
                        }

                        if(command is OleDbCommand)
                        {
                            OleDbDataAdapter insert = new OleDbDataAdapter((OleDbCommand)command);
                            insert.InsertCommand = (OleDbCommand)command;
                            return insert;
                        }

                        if(command is SqlCeCommand)
                        {
                            SqlCeDataAdapter insert = new SqlCeDataAdapter((SqlCeCommand)command);
                            insert.InsertCommand = (SqlCeCommand)command;
                            return insert;
                        }

                        if(command is SqlCommand)
                        {
                            SqlDataAdapter insert = new SqlDataAdapter((SqlCommand)command);
                            insert.InsertCommand = (SqlCommand)command;
                            return insert;
                        }

                        break;

                    case Sql.DELETE:
                        if(command is SQLiteCommand)
                        {
                            SQLiteDataAdapter delete = new SQLiteDataAdapter((SQLiteCommand)command);
                            delete.DeleteCommand = (SQLiteCommand)command;
                            return delete;
                        }

                        if(command is OleDbCommand)
                        {
                            OleDbDataAdapter delete = new OleDbDataAdapter((OleDbCommand)command);
                            delete.DeleteCommand = (OleDbCommand)command;
                            return delete;
                        }

                        if(command is SqlCeCommand)
                        {
                            SqlCeDataAdapter delete = new SqlCeDataAdapter((SqlCeCommand)command);
                            delete.DeleteCommand = (SqlCeCommand)command;
                            return delete;
                        }

                        if(command is SqlCommand)
                        {
                            SqlDataAdapter delete = new SqlDataAdapter((SqlCommand)command);
                            delete.DeleteCommand = (SqlCommand)command;
                            return delete;
                        }

                        break;

                    default:
                        SQLiteDataAdapter select = new SQLiteDataAdapter((SQLiteCommand)command);
                        select.SelectCommand = (SQLiteCommand)command;
                        return select;
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbDataAdapter GetDataAdapter(IDbCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
