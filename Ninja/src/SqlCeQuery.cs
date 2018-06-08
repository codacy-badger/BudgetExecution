// <copyright file="SqlCeQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
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

        public SqlCeQuery(Source source) : base(source, Provider.SqlCe)
        {
            Source = source;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            Connection = new SqlConnection(@"Data Source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
            SelectCommand = new SqlCommand(SelectStatement, Connection);
            Adapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        public SqlCeQuery(Source source, Dictionary<string, object> param) : base(source, Provider.SqlCe, param)
        {
            Source = source;
            Provider = Provider.SqlCe;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSqlStatement();
            Connection = new SqlConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\SqlCe\R6.sdf");
            SelectCommand = new SqlCommand(SelectStatement, Connection);
            Adapter = new SqlDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        // PROPERTIES
        public new Source Source { get; }

        public new Provider Provider { get; set; }

        public new string TableName { get; }

        public SqlConnection Connection { get; }

        public new Dictionary<string, object> Parameter { get; }

        public new string SelectStatement { get; }

        public new SqlCommand SelectCommand { get; }

        public SqlDataAdapter Adapter { get; set; }

        public DbDataReader Reader { get; set; }

        public new Dictionary<string, string> SqlStatement { get; }

        public new SqlCommandBuilder CommandBuilder { get; }

        public new SqlCommand UpdateCommand { get; }

        public new SqlCommand InsertCommand { get; }

        public new SqlCommand DeleteCommand { get; }

        // METHODS
        public SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(@"Data Source = C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\Sql\R6.accdb");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        private SqlCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new SqlCommandBuilder(Adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        private SqlDataAdapter GetDataAdapter()
        {
            try
            {
                return new SqlDataAdapter(SelectCommand);
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

        private SqlCommand GetSelectCommand()
        {
            try
            {
                return new SqlCommand(SelectStatement, Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        internal SqlDataAdapter GetDataAdapter(string sql)
        {
            try
            {
                return new SqlDataAdapter(sql, Connection);
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
                if (command is SqlCommand)
                {
                    return (SqlDataReader)command.ExecuteReader();
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public SqlCommandBuilder GetCommandBuilder(SqlDataAdapter adapter)
        {
            try
            {
                return new SqlCommandBuilder(adapter);
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
                return new SqlDataAdapter(command.CommandText, command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlCommand GetDeleteCommand()
        {
            try
            {
                return new SqlCommandBuilder(Adapter).GetDeleteCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlCommand GetInsertCommand()
        {
            try
            {
                return new SqlCommandBuilder(Adapter).GetInsertCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        public SqlCommand GetSelectCommand(string select)
        {
            try
            {
                return new SqlCommand(select, Connection);
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

        public SqlCommand GetUpdateCommand()
        {
            try
            {
                return new SqlCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
    }
}