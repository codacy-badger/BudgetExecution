// <copyright file="ExcelQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public class ExcelQuery
    {
        // Constructors
        public ExcelQuery()
        {
        }

        public ExcelQuery(Source source)
        {
            Source = source;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            Connection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlServer\R6.mdf");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        public ExcelQuery(Source source, Dictionary<string, object> param)
        {
            Source = source;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSqlStatement();
            Connection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\sqlclient\R6.mdf");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        // Properties
        public OleDbDataAdapter Adapter { get; set; }

        public OleDbCommandBuilder CommandBuilder { get; }

        public OleDbConnection Connection { get; }

        public Dictionary<string, object> Parameter { get; }

        public OleDbDataReader Reader { get; set; }

        public OleDbCommand SelectCommand { get; }

        public string SelectStatement { get; }

        public Source Source { get; }

        public Provider Provider { get; set; }

        public Dictionary<string, string> SqlStatement { get; }

        public string TableName { get; }

        public OleDbCommand UpdateCommand { get; }

        public OleDbCommand InsertCommand { get; }

        public OleDbCommand DeleteCommand { get; }

        // Methods
        private OleDbCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        private OleDbDataAdapter GetDataAdapter()
        {
            try
            {
                return new OleDbDataAdapter(SelectCommand);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        private string GetParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach (KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value.ToString()}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        private OleDbCommand GetSelectCommand()
        {
            try
            {
                return new OleDbCommand(SelectStatement, Connection);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        internal OleDbDataAdapter GetDataAdapter(string sql)
        {
            try
            {
                return new OleDbDataAdapter(sql, Connection);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommandBuilder GetCommandBuilder(OleDbDataAdapter adapter)
        {
            try
            {
                return new OleDbCommandBuilder(adapter);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbDataAdapter GetDataAdapter(OleDbCommand command)
        {
            try
            {
                return new OleDbDataAdapter(command.CommandText, command.Connection);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetDeleteCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetDeleteCommand();
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetInsertCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetInsertCommand();
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetSelectCommand(string select)
        {
            try
            {
                return new OleDbCommand(select, Connection);
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlStatement()
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {GetParamString(Parameter)}";
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
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
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetUpdateCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}