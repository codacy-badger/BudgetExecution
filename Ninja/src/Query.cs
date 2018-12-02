// <copyright file="Query.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>



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

    /// <summary>
    /// Defines the <see cref="Query" />
    /// </summary>
    public class Query : IQuery
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        public Query()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="cmb">The cmb<see cref="Sql"/></param>
        public Query(Source source = Source.PRC, Provider provider = Provider.SQLite, Sql cmb = Sql.SELECT)
        {
            Provider = provider;
            Source = source;
            Sql = cmb;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand, Sql);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        public Query(Tuple<Provider, Source, Sql> queryTuple, IDictionary<string, object> param)
        {
            Provider = queryTuple.Item1;
            Source = queryTuple.Item2;
            Sql = queryTuple.Item3;
            TableName = Source.ToString();
            DataConnection = GetDataConnection(Provider);
            SqlStatement = GetSqlStatement(Source, Sql, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand, Sql);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="command">The command<see cref="Sql"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public Query(Source source, Provider provider, Sql command, IDictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Sql = command;
            TableName = Source.ToString();
            DataConnection = GetDataConnection(Provider);
            SqlStatement = GetSqlStatement(Source, Sql, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand, Sql);
        }


        // PROPERTIES


        /// <inheritdoc />
        /// <summary>
        /// Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// Gets the Sql
        /// </summary>
        public Sql Sql { get; }

        /// <summary>
        /// Gets the TableName
        /// </summary>
        public string TableName { get; }

        /// <summary>
        /// Gets or sets the SelectStatement
        /// </summary>
        public string SelectStatement { get; set; }

        /// <summary>
        /// Gets or sets the UpdateStatement
        /// </summary>
        public string UpdateStatement { get; set; }

        /// <summary>
        /// Gets or sets the InsertStatement
        /// </summary>
        public string InsertStatement { get; set; }

        /// <summary>
        /// Gets or sets the DeleteStatement
        /// </summary>
        public string DeleteStatement { get; set; }

        /// <summary>
        /// Gets or sets the SelectCommand
        /// </summary>
        public DbCommand SelectCommand { get; set; }

        /// <summary>
        /// Gets or sets the DeleteCommand
        /// </summary>
        public DbCommand DeleteCommand { get; internal set; }

        /// <summary>
        /// Gets or sets the InsertCommand
        /// </summary>
        public DbCommand InsertCommand { get; internal set; }

        /// <summary>
        /// Gets or sets the UpdateCommand
        /// </summary>
        public DbCommand UpdateCommand { get; internal set; }

        /// <summary>
        /// Gets or sets the CommandBuilder
        /// </summary>
        public DbCommandBuilder CommandBuilder { get; internal set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the DataConnection
        /// </summary>
        public DbConnection DataConnection { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the SqlStatement
        /// </summary>
        public string SqlStatement { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the DataCommand
        /// </summary>
        public DbCommand DataCommand { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the DataReader
        /// </summary>
        public DbDataReader DataReader { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the DataAdapter
        /// </summary>
        public DbDataAdapter DataAdapter { get; set; }

        // METHODS

        /// <inheritdoc />
        /// <summary>
        /// Gets the data connection.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public DbConnection GetDataConnection(Provider provider)
        {
            try
            {
                ConnectionStringSettingsCollection connectionString = ConfigurationManager.ConnectionStrings;
                switch(provider)
                {
                    case Provider.SQLite:
                        return new SQLiteConnection(connectionString["SQLite"].ConnectionString);

                    case Provider.SqlCe:
                        return new SqlCeConnection(connectionString["SqlCe"].ConnectionString);

                    case Provider.SqlServer:
                        return new SqlConnection(connectionString["SqlServer"].ConnectionString);

                    case Provider.Access:
                        return new OleDbConnection(connectionString["Access"].ConnectionString);

                    case Provider.OleDb:
                        return new OleDbConnection(connectionString["OleDb"].ConnectionString);

                    case Provider.Excel:
                        return new OleDbConnection(connectionString["Excel"].ConnectionString);
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public string GetSqlStatement(string sql)
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the data command.
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the data adapter.
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
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter adapter = new SQLiteDataAdapter((SQLiteCommand)command);
                                adapter.SelectCommand = (SQLiteCommand)command;
                                return adapter;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter oledbselect = new OleDbDataAdapter((OleDbCommand)command);
                                oledbselect.SelectCommand = (OleDbCommand)command;
                                return oledbselect;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter sqlceselect = new SqlCeDataAdapter((SqlCeCommand)command);
                                sqlceselect.SelectCommand = (SqlCeCommand)command;
                                return sqlceselect;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter sqlselect = new SqlDataAdapter((SqlCommand)command);
                                sqlselect.SelectCommand = (SqlCommand)command;
                                return sqlselect;
                            }
                        }

                        break;

                    case Sql.UPDATE:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter update = new SQLiteDataAdapter((SQLiteCommand)command);
                                update.UpdateCommand = (SQLiteCommand)command;
                                return update;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter update = new OleDbDataAdapter((OleDbCommand)command);
                                update.UpdateCommand = (OleDbCommand)command;
                                return update;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter update = new SqlCeDataAdapter((SqlCeCommand)command);
                                update.UpdateCommand = (SqlCeCommand)command;
                                return update;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter update = new SqlDataAdapter((SqlCommand)command);
                                update.UpdateCommand = (SqlCommand)command;
                                return update;
                            }
                        }

                        break;

                    case Sql.INSERT:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter insert = new SQLiteDataAdapter((SQLiteCommand)command);
                                insert.InsertCommand = (SQLiteCommand)command;
                                return insert;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter insert = new OleDbDataAdapter((OleDbCommand)command);
                                insert.InsertCommand = (OleDbCommand)command;
                                return insert;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter insert = new SqlCeDataAdapter((SqlCeCommand)command);
                                insert.InsertCommand = (SqlCeCommand)command;
                                return insert;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter insert = new SqlDataAdapter((SqlCommand)command);
                                insert.InsertCommand = (SqlCommand)command;
                                return insert;
                            }
                        }

                        break;

                    case Sql.DELETE:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter delete = new SQLiteDataAdapter((SQLiteCommand)command);
                                delete.DeleteCommand = (SQLiteCommand)command;
                                return delete;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter delete = new OleDbDataAdapter((OleDbCommand)command);
                                delete.DeleteCommand = (OleDbCommand)command;
                                return delete;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter delete = new SqlCeDataAdapter((SqlCeCommand)command);
                                delete.DeleteCommand = (SqlCeCommand)command;
                                return delete;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter delete = new SqlDataAdapter((SqlCommand)command);
                                delete.DeleteCommand = (SqlCommand)command;
                                return delete;
                            }
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the data reader.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public DbDataReader GetDataReader(DbCommand command)
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the command builder.
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
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        /// <summary>
        ///     Gets the parameter strings.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSqlParameterString(IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND";
                }

                return vals.Trim().Substring(0, vals.Length - 4);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the select parameter string.
        /// </summary>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        /// <returns></returns>
        internal string GetSelectParamString(IDictionary<string, object> p)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in p)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                return vals.Trim().Substring(0, vals.Length - 4);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="cmd">The command.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public string GetSqlStatement(Source source, Sql cmd, IDictionary<string, object> p)
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
        /// Gets the select statement.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetSelectStatement(string table, IDictionary<string, object> param)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {GetSqlParameterString(param)}";
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
        public string GetSelectStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                vals = vals.TrimEnd().Substring(0, vals.Length - 4);
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <returns></returns>
        public string GetUpdateStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                int id = int.Parse(param["ID"].ToString());

                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"UPDATE {source.ToString()} SET {vals} WHERE ID = '{id}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetInsertStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string cols = string.Empty;
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    cols += $"{kvp.Key}, ";
                    vals += $"{kvp.Value}, ";
                }

                cols = cols.Trim().Substring(0, cols.Length - 2);
                vals = vals.Trim().Substring(0, vals.Length - 2);
                return $"INSERT INTO {source.ToString()} ({cols}) VALUES ({vals})";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public string GetDeleteStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                int id = int.Parse(param["ID"].ToString());
                return $"DELETE * FROM {source.ToString()} WHERE ID = '{id}'";
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
        /// <param name="select">The select.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        internal DbCommand GetSelectCommand(string select, DbConnection connection)
        {
            try
            {
                switch(connection)
                {
                    case SQLiteConnection _:
                        SelectStatement = select;
                        return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);            
                    case OleDbConnection _:
                        SelectStatement = select;
                        return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                    case SqlCeConnection _:
                        SelectStatement = select;
                        return new SqlCeCommand(SelectStatement, (SqlCeConnection)connection);
                    case SqlConnection _:
                        SelectStatement = select;
                        return new SqlCommand(SelectStatement, (SqlConnection)connection);
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
        /// Gets the update command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        public DbCommand GetUpdateCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetUpdateStatement(Source, pmr);
                DbCommand update = GetDataCommand(sql, DataConnection);
                update.CommandText = sql;
                update.Connection = DataConnection;
                return update;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the insert command.
        /// </summary>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        public DbCommand GetInsertCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetInsertStatement(Source, pmr);
                DbCommand insert = GetDataCommand(sql, DataConnection);
                insert.CommandText = sql;
                insert.Connection = DataConnection;
                return insert;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDeleteCommand
        /// </summary>
        /// <param name="pmr">The pmr<see cref="Dictionary{string, object}"/></param>
        /// <returns>The <see cref="DbCommand"/></returns>
        public DbCommand GetDeleteCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetDeleteStatement(Source, pmr);
                DbCommand deleteCommand = GetDataCommand(sql, DataConnection);
                deleteCommand.CommandText = sql;
                deleteCommand.Connection = DataConnection;
                return deleteCommand;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the data command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <param name="pmr">The PMR.</param>
        /// <returns></returns>
        public DbCommand GetDataCommand(Sql cmd, IDictionary<string, object> pmr)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        return GetSelectCommand(GetSelectParamString(pmr), DataConnection);

                    case Sql.UPDATE:
                        return GetUpdateCommand(pmr);

                    case Sql.INSERT:
                        return GetInsertCommand(pmr);

                    case Sql.DELETE:
                        return GetDeleteCommand(pmr);

                    default:
                        return GetSelectCommand(GetSelectParamString(pmr), DataConnection);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
