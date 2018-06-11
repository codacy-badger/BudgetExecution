// <copyright file="AccessQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public class AccessQuery : Query
    {
        // CONSTRUCTORS
        public AccessQuery()
        {
        }

        public AccessQuery(Source source) : base(source, Provider.OleDb)
        {
            Source = source;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            Connection = new OleDbConnection(@"Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.accdb");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        public AccessQuery(Source source, Dictionary<string, object> param) : base(source, Provider.OleDb, param)
        {
            Source = source;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSqlStatement();
            Connection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\OleDb\R6.accdb");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        // PROPERTIES
        public new Source Source { get; }

        public new Provider Provider { get; set; }

        public new string TableName { get; }

        public OleDbConnection Connection { get; }

        public new Dictionary<string, object> Parameter { get; }

        public new string SelectStatement { get; }

        public new OleDbCommand SelectCommand { get; }

        public OleDbDataAdapter Adapter { get; set; }

        public DbDataReader Reader { get; set; }

        public new Dictionary<string, string> SqlStatement { get; }

        public new OleDbCommandBuilder CommandBuilder { get; }

        public new OleDbCommand UpdateCommand { get; }

        public new OleDbCommand InsertCommand { get; }

        public new OleDbCommand DeleteCommand { get; }

        // METHODS
        public OleDbConnection GetConnection()
        {
            try
            {
                return new OleDbConnection(@"Data Source = C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.accdb");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        private OleDbCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        internal OleDbParameter[] GetParameter(Dictionary<string, object> param)
        {
            try
            {
                var val = new OleDbParameter[param.Count];
                for (int i = 0; i < param.Count; i++)
                {
                    foreach (KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new OleDbParameter(kvp.Key.ToString(), (object)kvp.Value);
                        val[i].SourceColumn = kvp.Key.ToString();
                        if (kvp.Key.ToString().Equals("ID"))
                        {
                            val[i].DbType = DbType.Int64;
                        }

                        if (kvp.Key.ToString().Equals("Amount"))
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public new DbDataReader GetDataReader(IDbCommand command)
        {
            try
            {
                if (command is OleDbCommand)
                {
                    return (OleDbDataReader)command.ExecuteReader();
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
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
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public new string GetSqlStatement(string sql)
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

        public OleDbCommand GetUpdateCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
    }
}