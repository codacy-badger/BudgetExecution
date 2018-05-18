﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;

namespace BudgetExecution
{
    public class Query
    {
        //Constructors
        public Query()
        {
        }
        public Query(Source source)
        {
            Source = source;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            Connection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
            SelectCommand = new SQLiteCommand(SelectStatement, Connection);
            Adapter = new SQLiteDataAdapter(SelectCommand);
        }
        public Query(Source source, Provider provider)
        {
            switch (provider)
            {
                case (Provider.SQLite):
                    Source = source;
                    TableName = source.ToString();
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    Connection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
                    SelectCommand = new SQLiteCommand(SelectStatement, Connection);
                    Adapter = new SQLiteDataAdapter(SelectCommand);
                    break;
                case (Provider.SqlCe):
                    Source = source;
                    TableName = source.ToString();
                    Connection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    break;
                case (Provider.SqlServer):
                    Source = source;
                    TableName = source.ToString();
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    Connection = new SQLiteConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlServer\R6.mdf;Integrated Security=True;Connect Timeout=30");
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    break;
                case (Provider.OleDb):

                    Source = source;
                    TableName = source.ToString(); 
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    Connection = new SQLiteConnection(@"Data Source = C: \Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.accdb");
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    break;
            }
        }
        public Query(Source source, Dictionary<string, object> param)
        {
            Source = source;
            TableName = source.ToString();
            Parameter = param;
            SelectStatement = GetSqlStatement();
            Connection = new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");
            SelectCommand = new SQLiteCommand(SelectStatement, Connection);
            Adapter = new SQLiteDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetInsertCommand();
        }

        //Properties
        public SQLiteDataAdapter Adapter { get; set; }
        public SQLiteCommandBuilder CommandBuilder { get; }
        public SQLiteConnection Connection { get; }
        public SQLiteCommand DeleteCommand { get; }
        public SQLiteCommand InsertCommand { get; }
        public Dictionary<string, object> Parameter { get; }
        public SQLiteDataReader DataReader { get; set; }
        public SQLiteCommand SelectCommand { get; }
        public string SelectStatement { get; }
        public Source Source { get; }
        public Provider Provider { get; }
        public Command Sql { get; set; }
        public Dictionary<string, string> SqlStatement { get; }
        public string TableName { get; }
        public SQLiteCommand UpdateCommand { get; }

        //Methods
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
        public SQLiteCommandBuilder GetCommandBuilder(SQLiteDataAdapter adapter)
        {
            try
            {
                return new SQLiteCommandBuilder(adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public SQLiteDataAdapter GetDataAdapter(SQLiteCommand command)
        {
            try
            {
                return new SQLiteDataAdapter(command.CommandText, command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public SQLiteCommand GetDeleteCommand()
        {
            try
            {
                return new SQLiteCommandBuilder(Adapter).GetDeleteCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public SQLiteCommand GetInsertCommand()
        {
            try
            {
                return new SQLiteCommandBuilder(Adapter).GetInsertCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public SQLiteCommand GetSelectCommand(string select)
        {
            try
            {
                return new SQLiteCommand(select, Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        public SQLiteCommand GetUpdateCommand()
        {
            try
            {
                return new SQLiteCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        internal SQLiteDataAdapter GetDataAdapter(string sql)
        {
            try
            {
                return new SQLiteDataAdapter(sql, Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        internal SQLiteDataAdapter GetDataAdapter(Command cmd, string sql)
        {
            try
            {
                return new SQLiteDataAdapter(sql, Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        private SQLiteCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new SQLiteCommandBuilder(Adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n\n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
        private SQLiteDataAdapter GetDataAdapter()
        {
            try
            {
                return new SQLiteDataAdapter(SelectCommand);
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
        private SQLiteCommand GetSelectCommand()
        {
            try
            {
                return new SQLiteCommand(SelectStatement, Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }
    }
}