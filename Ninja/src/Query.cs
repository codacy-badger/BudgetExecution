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
                var sqlparameter = this.GetDbParameters(param);
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
                var val = new SQLiteParameter[param.Count];
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

        public DbCommand GetDataCommand(Command cmd, DbParameter[] pmr, IDbConnection connection)
        {
            try
            {
                switch (cmd)
                {
                    case Command.Select:
                        var sql = $"SELECT * FROM {Source.ToString()} WHERE {pmr[0].SourceColumn} = '{pmr[0].Value}";
                        var select = new SQLiteCommand(sql, connection as SQLiteConnection);
                        foreach (var p in pmr) select.Parameters.Add(p);
                        DataAdapter = new SQLiteDataAdapter(select);
                        return select;
                    case Command.Update:
                        var upd = $"UPDATE {Source.ToString()} SET WHERE {pmr[0].SourceColumn} = '{pmr[0].Value}'";
                        var update = new SQLiteCommand(upd, connection as SQLiteConnection);
                        foreach (var p in pmr) update.Parameters.Add(p);
                        return update;
                    case Command.Insert:
                        var ins = $"UPDATE {Source.ToString()} SET WHERE {pmr[0].SourceColumn} = '{pmr[0].Value}'";
                        var insert = new SQLiteCommand(ins, connection as SQLiteConnection);
                        foreach (var p in pmr) insert.Parameters.Add(p);
                        return insert;
                    case Command.Delete:
                        var del = $"UPDATE {Source.ToString()} SET WHERE {pmr[0].SourceColumn} = '{pmr[0].Value}'";
                        var delete = new SQLiteCommand(del, connection as SQLiteConnection);
                        foreach (var p in pmr) delete.Parameters.Add(p);
                        return delete;
                    default:
                        var dft = $"SELECT * FROM {Source.ToString()} WHERE {pmr[0].SourceColumn} = '{pmr[0].Value}";
                        var def = new SQLiteCommand(dft, connection as SQLiteConnection);
                        foreach (var p in pmr) def.Parameters.Add(p);
                        return def;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetSelectCommand(Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {

                    var sql = $"SELECT * FROM {Source} WHERE {GetSelectParamString(pmr)}";
                    var select = new SQLiteCommand(sql, connection);
                    foreach (var p in pmr) select.Parameters.Add(p);
                    DataAdapter = new SQLiteDataAdapter(select);
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

        public SQLiteCommand GetUpdateCommand(Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    var update = GetSelectCommand(provider, pmr, connection);
                    var adapter = new SQLiteDataAdapter(update);
                    return adapter.UpdateCommand;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetInsertCommand(Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if (provider == Provider.SQLite)
                {
                    var insert = GetSelectCommand(provider, pmr, connection);
                    var adapter = new SQLiteDataAdapter(insert);
                    return adapter.InsertCommand;
                }

                return null;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
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
                var _ = new Error(ex).ShowDialog();
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
                var _ = new Error(ex).ShowDialog();
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
                var _ = new Error(ex).ShowDialog();
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
                foreach (var p in param)
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