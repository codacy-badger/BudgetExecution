// <copyright file="SqlCeQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class SqlCeQuery : Query
    {
        // CONSTRUCTORS
        public SqlCeQuery()
        {
        }

        public SqlCeQuery(Source source)
        {
            Provider = Provider.SQLite;
            Source = source;
            DataConnection = GetConnection(Provider);
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        public SqlCeQuery(Source source, Dictionary<string, object> param)
        {
            Provider = Provider.SQLite;
            Source = source;
            Parameter = param;
            DataConnection = GetConnection(Provider);
            TableName = source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        // PROPERTIES
        public new Source Source { get; }

        public new Provider Provider { get; }

        public new AppSettingsReader Settings { get; }

        public new SqlConnection DataConnection { get; }

        public new Dictionary<string, object> Parameter { get; }

        public new string TableName { get; }

        public new string SqlStatement { get; set; }

        public new string SelectStatement { get; set; }

        public new SqlCommand SelectCommand { get; }

        public new SqlDataReader DataReader { get; set; }

        public new SqlDataAdapter DataAdapter { get; set; }

        public new SqlCommandBuilder CommandBuilder { get; internal set; }

        public new SqlCommand DataCommand { get; set; }

        public new SqlCommand DeleteCommand { get; set; }

        public new SqlCommand InsertCommand { get; set; }

        public new SqlCommand UpdateCommand { get; set; }

        // METHODS
        public new SqlConnection GetConnection(Provider provider)
        {
            try
            {
                return new SqlConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public new string GetSelectParameterString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                var sqlparameter = GetParameter(param);
                foreach (SqlParameter p in sqlparameter)
                {
                    vals += $"{p.SourceColumn.ToString()} = '{p.Value}' AND ";
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

        public SqlParameter[] GetParameter(Dictionary<string, object> param)
        {
            try
            {
                var val = new SqlParameter[param.Count];
                for (int i = 0; i < param.Count; i++)
                {
                    foreach (KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new SqlParameter(kvp.Key.ToString(), (object)kvp.Value);
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

        public new string GetSelectStatement(string table, Dictionary<string, object> param)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {GetSelectParameterString(param)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public new string GetSqlStatement(string table, string sql)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {sql}";
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

        public SqlCommand GetDataCommand(string sql, SqlConnection connection)
        {
            try
            {
                SelectStatement = sql;
                return new SqlCommand(sql, connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlDataAdapter GetDataAdapter(SqlCommand command)
        {
            try
            {
               return new SqlDataAdapter(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlDataReader GetDataReader(SqlCommand command)
        {
            try
            {
               return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlCommandBuilder GetCommandBuilder(SqlDataAdapter adapter)
        {
            try
            {
                return new SqlCommandBuilder(adapter);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public SqlCommand GetSelectCommand(string sql, SqlConnection connection)
        {
            try
            {
                SelectStatement = sql;
                return new SqlCommand(SelectStatement, connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlCommand GetSelectCommand(Dictionary<string, object> param, SqlConnection connection)
        {
            try
            {
                SelectStatement = GetSelectParameterString(param);
                return new SqlCommand(SelectStatement, connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
    }
}