﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class ExcelQuery
    {
        //Constructors
        public ExcelQuery()
        {
        }
        public ExcelQuery(Source source)
        {
            Source = source;
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
        public ExcelQuery(Provider xls, Source source, Dictionary<string, object> param)
        {
            Source = source;
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

        //Properties
        public OleDbDataAdapter Adapter { get; set; }
        public OleDbCommandBuilder CommandBuilder { get; }
        public OleDbConnection Connection { get; }
        public OleDbCommand DeleteCommand { get; }
        public OleDbCommand InsertCommand { get; }
        public Dictionary<string, object> Parameter { get; }
        public OleDbDataReader Reader { get; set; }
        public OleDbCommand SelectCommand { get; }
        public string SelectStatement { get; }
        public Source Source { get; }
        public Command Sql { get; set; }
        public Dictionary<string, string> SqlStatement { get; }
        public string TableName { get; }
        public OleDbCommand UpdateCommand { get; }

        //Methods
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
                string vals = "";
                foreach (KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{ kvp.Key } = '{(kvp.Value).ToString()}' AND ";
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
        public string GetSqlStatement(string sql)
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