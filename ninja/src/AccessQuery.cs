// <copyright file="AccessQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// Defines the <see cref="AccessQuery" />
    /// </summary>
    public class AccessQuery : Query, IQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessQuery"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        public AccessQuery(Source source) : base(source, Provider.Access)
        {
            Provider = base.Provider;
            Source = source;
            DataConnection = base.DataConnection as OleDbConnection;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection) as OleDbCommand;
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter) as OleDbCommandBuilder;
            UpdateCommand = CommandBuilder?.GetUpdateCommand();
            UpdateStatement = UpdateCommand?.CommandText;
            InsertCommand = CommandBuilder?.GetInsertCommand();
            InsertStatement = InsertCommand?.CommandText;
            DeleteCommand = CommandBuilder?.GetDeleteCommand();
            DeleteStatement = DeleteCommand?.CommandText;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.AccessQuery" /> class.
        /// </summary>
        /// <param name="source">The source<see cref="P:BudgetExecution.AccessQuery.Source" /></param>
        /// <param name="parameter">The parameter<see cref="T:System.Collections.Generic.Dictionary`2" /></param>
        public AccessQuery(Source source, Dictionary<string, object> parameter) : base(source, Provider.Access, Sql.SELECT, parameter)
        {
            Source = source;
            Parameter = parameter;
            Provider = base.Provider;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            DataConnection = base.DataConnection as OleDbConnection;
            SelectCommand = new OleDbCommand(SelectStatement, DataConnection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.AccessQuery" /> class.
        /// </summary>
        /// <param name="source">The source<see cref="P:BudgetExecution.AccessQuery.Source" /></param>
        /// <param name="param">The param<see cref="T:System.Collections.Generic.Dictionary`2" /></param>
        /// <param name="parameter">The parameter<see cref="T:System.Collections.Generic.Dictionary`2" /></param>
        public AccessQuery(Source source, Dictionary<string, object> param, Dictionary<string, object> parameter)
        {
            Source = source;
            Parameter = parameter;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            Parameters = GetParameter(param);
            SelectStatement = GetSqlStatement();
            DataConnection = base.DataConnection as OleDbConnection;
            SelectCommand = new OleDbCommand(SelectStatement, DataConnection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        /// <summary>
        /// Gets or sets the Adapter
        /// </summary>
        public OleDbDataAdapter Adapter { get; set; }

        /// <summary>
        /// Gets or sets the CommandBuilder
        /// </summary>
        public new OleDbCommandBuilder CommandBuilder { get; internal set; }

        /// <summary>
        /// Gets the DataConnection
        /// </summary>
        public new OleDbConnection DataConnection { get; }

        /// <summary>
        /// Gets the Parameter
        /// </summary>
        public Dictionary<string, object> Parameter { get; }

        /// <summary>
        /// Gets or sets the Parameters
        /// </summary>
        public OleDbParameter[] Parameters { get; set; }

        /// <summary>
        /// Gets or sets the DataReader
        /// </summary>
        public new OleDbDataReader DataReader { get; set; }

        /// <summary>
        /// Gets the SelectCommand
        /// </summary>
        public new OleDbCommand SelectCommand { get; }

        /// <summary>
        /// Gets the SelectStatement
        /// </summary>
        public new string SelectStatement { get; }

        /// <summary>
        /// Gets the TableName
        /// </summary>
        public new string TableName { get; }

        /// <summary>
        /// Gets the UpdateCommand
        /// </summary>
        public new OleDbCommand UpdateCommand { get; }

        /// <summary>
        /// Gets the InsertCommand
        /// </summary>
        public new OleDbCommand InsertCommand { get; }

        /// <summary>
        /// Gets the DeleteCommand
        /// </summary>
        public new OleDbCommand DeleteCommand { get; }

        /// <summary>
        /// Gets or sets the Settings
        /// </summary>
        public AppSettingsReader Settings { get; set; }

        /// <summary>
        /// Gets the Source
        /// </summary>
        public new Source Source { get; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public new Provider Provider { get; set; }

        /// <summary>
        /// The GetSqlStatement
        /// </summary>
        /// <param name="sqlStatement">The sql<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public new string GetSqlStatement(string sqlStatement)
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {sqlStatement}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <param name="dr">The dr.</param>
        /// <returns></returns>
        public OleDbParameter[] GetParameter(DataRow dr)
        {
            try
            {
                OleDbParameter[] val = new OleDbParameter[dr.ItemArray.Length];
                for(int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val[i] = new OleDbParameter(dr.Table.Columns[i].ColumnName, dr[i]);
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
        /// Gets the parameter.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public OleDbParameter[] GetParameter(Dictionary<string, object> param)
        {
            try
            {
                OleDbParameter[] val = new OleDbParameter[param.Count];
                for(int i = 0; i < param.Count; i++)
                {
                    foreach(KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new OleDbParameter(kvp.Key, kvp.Value);
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
        /// Gets the parameters.
        /// </summary>
        /// <param name="dr">The dr.</param>
        /// <returns></returns>
        public List<OleDbParameter> GetParameters(DataRow dr)
        {
            try
            {
                List<OleDbParameter> val = new List<OleDbParameter>();
                for(int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val.Add(new OleDbParameter(dr.Table.Columns[i].ColumnName, dr[i]));
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
        /// Gets the parameter.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public List<OleDbParameter[]> GetParameter(DataTable table)
        {
            try
            {
                List<OleDbParameter[]> val = new List<OleDbParameter[]>();
                foreach(DataRow dr in table.Rows)
                {
                    val.Add(GetParameter(dr));
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
        /// Gets the select parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
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
        /// Gets the select parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal string GetSelectParamString(OleDbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(OleDbParameter p in param)
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
        /// Gets the parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        private string GetParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
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
        /// Gets the data adapter.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        internal OleDbDataAdapter GetDataAdapter(string sql)
        {
            try
            {
                return new OleDbDataAdapter(sql, DataConnection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the command builder.
        /// </summary>
        /// <param name="adapter">The adapter.</param>
        /// <returns></returns>
        public OleDbCommandBuilder GetCommandBuilder(OleDbDataAdapter adapter)
        {
            try
            {
                return new OleDbCommandBuilder(adapter);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the data adapter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public OleDbDataAdapter GetDataAdapter(OleDbCommand command)
        {
            try
            {
                return new OleDbDataAdapter(command.CommandText, command.Connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <returns></returns>
        public OleDbCommand GetDeleteCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetDeleteCommand();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Gets the insert command.
        /// </summary>
        /// <returns></returns>
        public OleDbCommand GetInsertCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetInsertCommand();
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
        /// <returns></returns>
        public OleDbCommand GetSelectCommand(string select)
        {
            try
            {
                return new OleDbCommand(select, DataConnection);
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
        /// <returns></returns>
        public string GetSqlStatement()
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {GetParamString(Parameter)}";
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
        /// <returns></returns>
        public OleDbCommand GetUpdateCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
