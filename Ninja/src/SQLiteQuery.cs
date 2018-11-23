// <copyright file="SQLiteQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;

    /// <summary>
    /// Defines the <see cref="SQLiteQuery" />
    /// </summary>
    public class SQLiteQuery : Query, IQuery
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        public SQLiteQuery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        public SQLiteQuery(Source source) : base(source)
        {
            Provider = base.Provider;
            Source = base.Source;
            SqlCmd = Sql.SELECT;
            DataConnection = GetConnection();
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="sqlcmd">The sqlcmd<see cref="Sql"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public SQLiteQuery(Source source, Sql sqlcmd, Dictionary<string, object> p) : base(source, Provider.SQLite, sqlcmd, p)
        {
            Provider = base.Provider;
            Source = source;
            SqlCmd = sqlcmd;
            DataConnection = GetConnection();
            TableName = Source.ToString();
            SqlStatement = GetSqlStatement(Source, SqlCmd, p);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        public SQLiteQuery(Source source, Provider provider, Sql sql) : base(source, provider, sql)
        {
            Provider = provider;
            Source = source;
            SqlCmd = sql;
            DataConnection = GetConnection();
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="sql">The sql<see cref="Sql"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public SQLiteQuery(Source source, Provider provider, Sql sql, Dictionary<string, object> param) : base(source, provider, sql, param)
        {
            Provider = base.Provider;
            Source = base.Source;
            SqlCmd = Sql;
            Parameter = param;
            DataConnection = GetConnection();
            TableName = source.ToString();
            SqlStatement = GetSqlStatement(Source, SqlCmd, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter((SQLiteCommand) DataCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        // PROPERTIES
        /// <summary>
        /// Gets the DataConnection
        /// </summary>
        public new SQLiteConnection DataConnection { get; }

        /// <summary>
        /// Gets the Parameter
        /// </summary>
        public Dictionary<string, object> Parameter { get; }

        /// <summary>
        /// Gets the TableName
        /// </summary>
        public new string TableName { get; }

        /// <summary>
        /// Gets or sets the SqlCmd
        /// </summary>
        public Sql SqlCmd { get; set; }

        /// <summary>
        /// Gets or sets the SelectStatement
        /// </summary>
        public new string SelectStatement { get; set; }

        /// <summary>
        /// Gets the SelectCommand
        /// </summary>
        public new SQLiteCommand SelectCommand { get; }

        /// <summary>
        /// Gets or sets the DataReader
        /// </summary>
        public new SQLiteDataReader DataReader { get; set; }

        /// <summary>
        /// Gets or sets the DataAdapter
        /// </summary>
        public new SQLiteDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets the CommandBuilder
        /// </summary>
        public new SQLiteCommandBuilder CommandBuilder { get; internal set; }

        /// <summary>
        /// Gets or sets the DeleteCommand
        /// </summary>
        public new SQLiteCommand DeleteCommand { get; set; }

        /// <summary>
        /// Gets or sets the InsertCommand
        /// </summary>
        public new SQLiteCommand InsertCommand { get; set; }

        /// <summary>
        /// Gets or sets the UpdateCommand
        /// </summary>
        public new SQLiteCommand UpdateCommand { get; set; }

        /// <summary>
        /// Gets the Source
        /// </summary>
        public new Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public new Provider Provider { get; }

        /// <summary>
        /// Gets or sets the SqlStatement
        /// </summary>
        public new string SqlStatement { get; set; }

        // METHODS
        /// <summary>
        /// The GetParameterStrings
        /// </summary>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetParameterStrings(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> p in param)
                {
                    vals += $"{p.Key} = '{p.Value}' AND ";
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
        /// The GetSqlString
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="sql">The sql<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetSqlString(DataTable table, string sql)
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

        /// <summary>
        /// The GetConnection
        /// </summary>
        /// <returns>The <see cref="SQLiteConnection"/></returns>
        public SQLiteConnection GetConnection()
        {
            try
            {
                return (SQLiteConnection) base.DataConnection;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetSelectStatement
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="SQLiteParameter[]"/></param>
        /// <returns>The <see cref="string"/></returns>
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
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetUpdateStatement
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="SQLiteParameter[]"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetUpdateStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                int pid = 0;
                foreach(SQLiteParameter p in param)
                {
                    if(p.SourceColumn == "ID")
                    {
                        pid = (int) p.Value;
                    }

                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"UPDATE {source.ToString()} SET {vals} WHERE ID = '{pid.ToString()}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetInsertStatement
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="SQLiteParameter[]"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetInsertStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string cols = string.Empty;
                string vals = string.Empty;
                foreach(SQLiteParameter p in param)
                {
                    cols += $"{p.SourceColumn}, ";
                    vals += $"{p.Value}, ";
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
        /// The GetDeleteStatement
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="SQLiteParameter[]"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetDeleteStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"DELETE * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetSelectCommand
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="pmr">The pmr<see cref="SQLiteParameter[]"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetSelectCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
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
        /// The GetUpdateCommand
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="pmr">The pmr<see cref="SQLiteParameter[]"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetUpdateCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetUpdateStatement(source, pmr);
                    SQLiteCommand update = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
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
        /// The GetInsertCommand
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="pmr">The pmr<see cref="SQLiteParameter[]"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetInsertCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetInsertStatement(source, pmr);
                    SQLiteCommand insert = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
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
        /// The GetDeleteCommand
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="pmr">The pmr<see cref="SQLiteParameter[]"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetDeleteCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetDeleteStatement(source, pmr);
                    SQLiteCommand delete = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
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
        /// The GetDataCommand
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="cmd">The cmd<see cref="Sql"/></param>
        /// <param name="pmr">The pmr<see cref="SQLiteParameter[]"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetDataCommand(Source source, Provider provider, Sql cmd, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                switch(cmd)
                {
                    case Sql.SELECT:
                        return GetSelectCommand(source, provider, pmr, connection);

                    case Sql.UPDATE:
                        return GetUpdateCommand(source, provider, pmr, connection);

                    case Sql.INSERT:
                        return GetInsertCommand(source, provider, pmr, connection);

                    case Sql.DELETE:
                        return GetDeleteCommand(source, provider, pmr, connection);

                    default:
                        return GetSelectCommand(source, provider, pmr, connection);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDataCommand
        /// </summary>
        /// <param name="select">The select<see cref="string"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        public SQLiteCommand GetDataCommand(string select, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SQLiteCommand(select, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDataAdapter
        /// </summary>
        /// <param name="command">The command<see cref="SQLiteCommand"/></param>
        /// <returns>The <see cref="SQLiteDataAdapter"/></returns>
        public SQLiteDataAdapter GetDataAdapter(SQLiteCommand command)
        {
            try
            {
                return new SQLiteDataAdapter(command);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDataReader
        /// </summary>
        /// <param name="command">The command<see cref="SQLiteCommand"/></param>
        /// <returns>The <see cref="SQLiteDataReader"/></returns>
        public SQLiteDataReader GetDataReader(SQLiteCommand command)
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

        /// <summary>
        /// The GetCommandBuilder
        /// </summary>
        /// <param name="adapter">The adapter<see cref="SQLiteDataAdapter"/></param>
        /// <returns>The <see cref="SQLiteCommandBuilder"/></returns>
        public SQLiteCommandBuilder GetCommandBuilder(SQLiteDataAdapter adapter)
        {
            try
            {
                return new SQLiteCommandBuilder(adapter);
            }
            catch(SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetSelectCommand
        /// </summary>
        /// <param name="select">The select<see cref="string"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        internal SQLiteCommand GetSelectCommand(string select, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SQLiteCommand(SelectStatement, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetSelectCommand
        /// </summary>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <param name="connection">The connection<see cref="SQLiteConnection"/></param>
        /// <returns>The <see cref="SQLiteCommand"/></returns>
        internal SQLiteCommand GetSelectCommand(Dictionary<string, object> param, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = GetParameterStrings(param);
                return new SQLiteCommand(SelectStatement, connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
