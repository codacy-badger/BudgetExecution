// <copyright file="Query.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Windows.Forms;

    public class Query : IQuery
    {
        // CONSTRUCTORS
        public Query()
        {
        }

        public Query(Source source, Provider provider)
        {
            Provider = provider;
            Source = source;
            DataConnection = GetConnection(provider);
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public Query(Source source, Provider provider, Dictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Parameter = param;
            DataConnection = GetConnection(provider);
            TableName = source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            Settings = new AppSettingsReader();
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public AppSettingsReader Settings { get; }

        public DbConnection DataConnection { get; }

        public Dictionary<string, object> Parameter { get; }

        public string TableName { get; }

        public string SqlStatement { get; set; }

        public string SelectStatement { get; set; }

        public DbCommand SelectCommand { get; }

        public DbDataReader DataReader { get; set; }

        public DbDataAdapter DataAdapter { get; set; }

        public DbCommandBuilder CommandBuilder { get; internal set; }

        public DbCommand DataCommand { get; set; }

        public DbCommand DeleteCommand { get; set; }

        public DbCommand InsertCommand { get; set; }

        public DbCommand UpdateCommand { get; set; }

        // METHODS
        public DbConnection GetConnection(Provider provider)
        {
            try
            {
                switch (provider)
                {
                    case Provider.SQLite:
                        return new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.db");

                    case Provider.SqlCe:
                        return new SqlConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SqlCe\R6.sdf");

                    case Provider.SqlServer:
                        return new SqlConnection(@"DbData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\SqlServerQuery\R6.mdf;Integrated Security=True;Connect Timeout=30");
                    case Provider.OleDb:
                        return new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; DbData Source =| DataDirectory |\database\OleDb\R6.accdb");
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetParameterStrings(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                SQLiteParameter[] sqlparameter = GetDbParameters(param);
                foreach (SQLiteParameter p in sqlparameter)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectStatement(string table, Dictionary<string, object> param)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {GetSelectParamString(param)}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectStatement(string tableName, string sql)
        {
            try
            {
                return $"SELECT * FROM {tableName} WHERE {sql}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbCommand GetDataCommand(string sql, IDbConnection connection)
        {
            try
            {
                if (connection is SQLiteConnection)
                {
                    SelectStatement = sql;
                    return new SQLiteCommand(sql, (SQLiteConnection)connection);
                }

                if (connection is OleDbConnection)
                {
                    SelectStatement = sql;
                    return new OleDbCommand(sql, (OleDbConnection)connection);
                }

                if (connection is SqlConnection)
                {
                    SelectStatement = sql;
                    return new SqlCommand(sql, (SqlConnection)connection);
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteParameter[] GetDbParameters(Dictionary<string, object> param)
        {
            try
            {
                SQLiteParameter[] val = new SQLiteParameter[param.Count];
                for (int i = 0; i < param.Count; i++)
                {
                    foreach (KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new SQLiteParameter(kvp.Key, kvp.Value);
                        val[i].SourceColumn = kvp.Key;
                        if (kvp.Key.Equals("ID"))
                        {
                            val[i].DbType = DbType.Int64;
                        }

                        if (kvp.Key.Equals("Obligations"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("Commitments"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("LeaveHours"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("WorkHours"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("Amount"))
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach (SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetUpdateStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                int pid = 0;
                foreach (SQLiteParameter p in param)
                {
                    if (p.SourceColumn == "ID")
                    {
                        pid = (int)p.Value;
                    }

                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"UPDATE {source.ToString()} SET {vals} WHERE ID = '{pid.ToString()}'";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetInsertStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string cols = string.Empty;
                string vals = string.Empty;
                foreach (SQLiteParameter p in param)
                {
                    cols += $"{p.SourceColumn}, ";
                    vals += $"{p.Value}, ";
                }

                cols = cols.Trim().Substring(0, cols.Length - 2);
                vals = vals.Trim().Substring(0, vals.Length - 2);
                return $"INSERT INTO {source.ToString()} ({cols}) VALUES ({vals})";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetDeleteStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach (SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"DELETE * FROM {source.ToString()} WHERE {vals}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetSelectCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    string sql = GetSelectStatement(source, pmr);
                    SQLiteCommand select = new SQLiteCommand(sql, connection);
                    foreach (SQLiteParameter p in pmr)
                    {
                        select.Parameters.Add(p);
                    }

                    return select;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetUpdateCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    string sql = GetUpdateStatement(source, pmr);
                    var update = new SQLiteCommand(sql, connection);
                    foreach (SQLiteParameter p in pmr)
                    {
                        update.Parameters.Add(p);
                    }

                    return update;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetInsertCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    string sql = GetInsertStatement(source, pmr);
                    var insert = new SQLiteCommand(sql, connection);
                    foreach (SQLiteParameter p in pmr)
                    {
                        insert.Parameters.Add(p);
                    }

                    return insert;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetDeleteCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    string sql = GetDeleteStatement(source, pmr);
                    var delete = new SQLiteCommand(sql, connection);
                    foreach (SQLiteParameter p in pmr)
                    {
                        delete.Parameters.Add(p);
                    }

                    return delete;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetDataCommand(Source source, Provider provider, Sql cmd, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                switch (cmd)
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
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbDataAdapter GetDataAdapter(IDbCommand command)
        {
            try
            {
                if (command is SQLiteCommand)
                {
                    return new SQLiteDataAdapter((SQLiteCommand)command);
                }

                if (command is OleDbCommand)
                {
                    return new OleDbDataAdapter((OleDbCommand)command);
                }

                if (command is SqlCommand)
                {
                    return new SqlDataAdapter((SqlCommand)command);
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbDataReader GetDataReader(IDbCommand command)
        {
            try
            {
                if (command is SQLiteCommand)
                {
                    return ((SQLiteCommand)command).ExecuteReader();
                }

                if (command is OleDbCommand)
                {
                    return ((OleDbCommand)command).ExecuteReader();
                }

                if (command is SqlCommand)
                {
                    return ((SqlCommand)command).ExecuteReader();
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbCommandBuilder GetCommandBuilder(IDbDataAdapter adapter)
        {
            try
            {
                if (adapter is SQLiteDataAdapter)
                {
                    CommandBuilder = new SQLiteCommandBuilder(adapter as SQLiteDataAdapter);
                    return CommandBuilder;
                }

                if (adapter is OleDbDataAdapter)
                {
                    CommandBuilder = new OleDbCommandBuilder(adapter as OleDbDataAdapter);
                    return CommandBuilder;
                }

                if (adapter is SqlDataAdapter)
                {
                    CommandBuilder = new SqlCommandBuilder(adapter as SqlDataAdapter);
                    return CommandBuilder;
                }

                return null;
            }
            catch (SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DbCommand GetSelectCommand(string select, IDbConnection connection)
        {
            try
            {
                if (connection is SQLiteConnection)
                {
                    SelectStatement = select;
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }

                if (connection is OleDbConnection)
                {
                    SelectStatement = select;
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }

                if (connection is SqlConnection)
                {
                    SelectStatement = select;
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DbCommand GetSelectCommand(Dictionary<string, object> param, IDbConnection connection)
        {
            try
            {
                if (connection is SQLiteConnection)
                {
                    SelectStatement = GetSelectParamString(param);
                    return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);
                }

                if (connection is OleDbConnection)
                {
                    SelectStatement = GetSelectParamString(param);
                    return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                }

                if (connection is SqlConnection)
                {
                    SelectStatement = GetSelectParamString(param);
                    return new SqlCommand(SelectStatement, (SqlConnection)connection);
                }

                return null;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach (KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string GetSelectParamString(SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach (SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}