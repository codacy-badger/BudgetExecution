// <copyright file="SqlServerQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Defines the <see cref="SqlServerQuery" />
    /// </summary>
    public class SqlServerQuery : Query
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerQuery"/> class.
        /// </summary>
        public SqlServerQuery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        public SqlServerQuery(Source source) : base(source, Provider.SqlServer)
        {
            Source = source;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            DataConnection = base.DataConnection as SqlConnection;
            SelectCommand = new SqlCommand(SelectStatement, DataConnection);
            DataAdapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        public SqlServerQuery(Source source, Dictionary<string, object> param) : base(source, Provider.SqlServer, SQL.SELECT, param)
        {
            Source = source;
            Provider = Provider.SqlServer;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSelectStatement(TableName, Parameter);
            DataConnection = base.DataConnection as SqlConnection;
            SelectCommand = new SqlCommand(SelectStatement, DataConnection);
            DataAdapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        public new Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public new Provider Provider { get; }

        /// <summary>
        /// Gets or sets the Settings
        /// </summary>
        public AppSettingsReader Setting { get; set; }

        /// <summary>
        /// Gets or sets the DataConnection
        /// </summary>
        public new SqlConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the Parameter
        /// </summary>
        public Dictionary<string, object> Parameter { get; set; }

        /// <summary>
        /// Gets or sets the TableName
        /// </summary>
        public new string TableName { get; set; }

        /// <summary>
        /// Gets or sets the SqlStatement
        /// </summary>
        public new string SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the SelectStatement
        /// </summary>
        public new string SelectStatement { get; set; }

        /// <summary>
        /// Gets or sets the SelectCommand
        /// </summary>
        public new SqlCommand SelectCommand { get; set; }

        /// <summary>
        /// Gets or sets the DataReader
        /// </summary>
        public new SqlDataReader DataReader { get; set; }

        /// <summary>
        /// Gets or sets the DataAdapter
        /// </summary>
        public new SqlDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets the CommandBuilder
        /// </summary>
        public new SqlCommandBuilder CommandBuilder { get; internal set; }

        /// <summary>
        /// Gets or sets the DataCommand
        /// </summary>
        public new SqlCommand DataCommand { get; set; }

        /// <summary>
        /// Gets or sets the DeleteCommand
        /// </summary>
        public new SqlCommand DeleteCommand { get; set; }

        /// <summary>
        /// Gets or sets the InsertCommand
        /// </summary>
        public new SqlCommand InsertCommand { get; set; }

        /// <summary>
        /// Gets or sets the UpdateCommand
        /// </summary>
        public new SqlCommand UpdateCommand { get; set; }

        // METHODS
        /// <summary>
        /// The GetSelectParamString
        /// </summary>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                SqlParameter[] sqlparameter = GetParameter(param);
                foreach(SqlParameter p in sqlparameter)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
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
        /// The GetSelectParamString
        /// </summary>
        /// <param name="param">The param<see cref="SqlParameter[]"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetSelectParamString(SqlParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(SqlParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
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
        /// The GetParameter
        /// </summary>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <returns>The <see cref="SqlParameter[]"/></returns>
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

        /// <summary>
        /// The GetSelectStatement
        /// </summary>
        /// <param name="table">The table<see cref="string"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetSelectStatement(string table, Dictionary<string, object> param)
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

        /// <summary>
        /// The GetSqlStatement
        /// </summary>
        /// <param name="table">The table<see cref="string"/></param>
        /// <param name="sql">The sql<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
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

        /// <summary>
        /// The GetSqlStatement
        /// </summary>
        /// <param name="sql">The sql<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
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

        /// <summary>
        /// The GetDataCommand
        /// </summary>
        /// <param name="select">The select<see cref="string"/></param>
        /// <param name="connection">The connection<see cref="SqlConnection"/></param>
        /// <returns>The <see cref="SqlCommand"/></returns>
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

        /// <summary>
        /// The GetDataAdapter
        /// </summary>
        /// <param name="command">The command<see cref="SqlCommand"/></param>
        /// <returns>The <see cref="SqlDataAdapter"/></returns>
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

        /// <summary>
        /// The GetDataReader
        /// </summary>
        /// <param name="command">The command<see cref="SqlCommand"/></param>
        /// <returns>The <see cref="SqlDataReader"/></returns>
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

        /// <summary>
        /// The GetCommandBuilder
        /// </summary>
        /// <param name="adapter">The adapter<see cref="SqlDataAdapter"/></param>
        /// <returns>The <see cref="SqlCommandBuilder"/></returns>
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

        /// <summary>
        /// The GetSelectCommand
        /// </summary>
        /// <param name="select">The select<see cref="string"/></param>
        /// <param name="connection">The connection<see cref="SqlConnection"/></param>
        /// <returns>The <see cref="SqlCommand"/></returns>
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

        /// <summary>
        /// The GetSelectCommand
        /// </summary>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <param name="connection">The connection<see cref="SqlConnection"/></param>
        /// <returns>The <see cref="SqlCommand"/></returns>
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
