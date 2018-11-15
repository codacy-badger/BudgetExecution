// <copyright file="ExcelQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BudgetExecution
{
    public class ExcelQuery : Query, IQuery
    {
        // Constructors
        public ExcelQuery(Source source)
                : base(source)
        {
            Provider = base.Provider;
            Source = source;
            DataConnection = GetDataConnection(Provider) as OleDbConnection;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection) as OleDbCommand;
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter) as OleDbCommandBuilder;
            UpdateCommand = CommandBuilder?.GetUpdateCommand();
            InsertCommand = CommandBuilder?.GetInsertCommand();
            DeleteCommand = CommandBuilder?.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public ExcelQuery(Source source, Dictionary<string, object> parameter)
                : base(source, Provider.OleDb)
        {
            Settings = new AppSettingsReader();
            Source = source;
            Parameter = parameter;
            Provider = base.Provider;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            DataConnection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.xlsx");
            SelectCommand = new OleDbCommand(SelectStatement, DataConnection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        public ExcelQuery(Source source, Dictionary<string, object> param, Dictionary<string, object> parameter)
        {
            Settings = new AppSettingsReader();
            Source = source;
            Parameter = parameter;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            Parameters = GetParameter(param);
            SelectStatement = GetSqlStatement();
            DataConnection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.xlsx");
            SelectCommand = new OleDbCommand(SelectStatement, DataConnection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        // Properties
        public OleDbDataAdapter Adapter { get; set; }

        public new OleDbCommandBuilder CommandBuilder { get; internal set; }

        public new OleDbConnection DataConnection { get; }

        public Dictionary<string, object> Parameter { get; }

        public new OleDbParameter[] Parameters { get; set; }

        public new OleDbDataReader DataReader { get; set; }

        public new OleDbCommand SelectCommand { get; }

        public new string SelectStatement { get; }

        public new string TableName { get; }

        public new OleDbCommand UpdateCommand { get; }

        public new OleDbCommand InsertCommand { get; }

        public new OleDbCommand DeleteCommand { get; }

        public AppSettingsReader Settings { get; set; }

        public new Source Source { get; }

        public new Provider Provider { get; set; }

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

        // Methods

        /// <summary>
        ///     Gets the parameter.
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
        ///     Gets the parameter.
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
        ///     Gets the parameters.
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
        ///     Gets the parameter.
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
        ///     Gets the select parameter string.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        internal new string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
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
        internal string GetSelectParamString(OleDbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(OleDbParameter p in param)
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
        ///     Gets the command builder.
        /// </summary>
        /// <returns></returns>
        private OleDbCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter);
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
        /// <returns></returns>
        private OleDbDataAdapter GetDataAdapter()
        {
            try
            {
                return new OleDbDataAdapter(SelectCommand);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the parameter string.
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
        ///     Gets the select command.
        /// </summary>
        /// <returns></returns>
        private OleDbCommand GetSelectCommand()
        {
            try
            {
                return new OleDbCommand(SelectStatement, DataConnection);
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
        ///     Gets the command builder.
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
        ///     Gets the data adapter.
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
        ///     Gets the delete command.
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
        ///     Gets the insert command.
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
        ///     Gets the select command.
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
        ///     Gets the SQL statement.
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
        ///     Gets the update command.
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
