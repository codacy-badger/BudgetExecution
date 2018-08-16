// <copyright file="SQLiteQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SQLite;

    public class SQLiteQuery : Query
    {
        // CONSTRUCTORS
        public SQLiteQuery() : base()
        {
        }

        public SQLiteQuery(Source source) : base(source, Provider.SQLite)
        {
            Provider = base.Provider;
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
            Settings = new AppSettingsReader();
        }

        public SQLiteQuery(Source source, Dictionary<string, object> param)
        {
            Provider = Provider.SQLite;
            Source = source;
            Parameter = param;
            Parameters = GetParameter(param);
            DataConnection = GetConnection(Provider);
            TableName = source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public SQLiteQuery(Source source, SQLiteParameter[] param)
        {
            Provider = Provider.SQLite;
            Source = source;
            Parameters = param;
            DataConnection = GetConnection(Provider);
            TableName = source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public SQLiteQuery(Source source, Provider provider, Dictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Parameters = GetParameter(param);
            DataConnection = GetConnection(Provider);
            TableName = source.ToString();
            SelectStatement = GetSelectStatement(TableName, Parameter);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        // PROPERTIES
        public new Source Source { get; }

        public new Provider Provider { get; }

        public new AppSettingsReader Settings { get; }

        public new SQLiteConnection DataConnection { get; }

        public new Dictionary<string, object> Parameter { get; }

        public SQLiteParameter[] Parameters { get; set; }

        public new string TableName { get; }

        public new string SqlStatement { get; set; }

        public new string SelectStatement { get; set; }

        public new SQLiteCommand SelectCommand { get; }

        public new SQLiteDataReader DataReader { get; set; }

        public new SQLiteDataAdapter DataAdapter { get; set; }

        public new SQLiteCommandBuilder CommandBuilder { get; internal set; }

        public new SQLiteCommand DeleteCommand { get; set; }

        public new SQLiteCommand InsertCommand { get; set; }

        public new SQLiteCommand UpdateCommand { get; set; }

        // METHODS
        public new string GetParameterStrings(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach (SQLiteParameter p in GetParameter(param))
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

        public SQLiteParameter[] GetParameter(DataRow dr)
        {
            try
            {
                SQLiteParameter[] val = new SQLiteParameter[dr.ItemArray.Length];
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val[i] = new SQLiteParameter(dr.Table.Columns[i].ColumnName, dr[i]);
                }

                return val;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public List<SQLiteParameter> GetParameters(DataRow dr)
        {
            try
            {
                List<SQLiteParameter> val = new List<SQLiteParameter>();
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val.Add(new SQLiteParameter(dr.Table.Columns[i].ColumnName, dr[i]));
                }

                return val;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public List<SQLiteParameter[]> GetParameter(DataTable table)
        {
            try
            {
                List<SQLiteParameter[]> val = new List<SQLiteParameter[]>();
                foreach (DataRow dr in table.Rows)
                {
                    val.Add(GetParameter(dr));
                }

                return val;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteParameter[] GetParameter(Dictionary<string, object> param)
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

                        if (kvp.Key.Equals("Amount"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("LeaveHours"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("Commitments"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("Obligations"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("DollarAmount"))
                        {
                            val[i].DbType = DbType.Decimal;
                        }

                        if (kvp.Key.Equals("WorkHours"))
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

        public string GetSqlString(DataTable table, string sql)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {sql}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public new SQLiteConnection GetConnection(Provider provider)
        {
            try
            {
                return new SQLiteConnection(@"datasource=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\SQLite\R6.SQLite");
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public new string GetSelectStatement(Source source, SQLiteParameter[] param)
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

        public new string GetUpdateStatement(Source source, SQLiteParameter[] param)
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

        public new string GetInsertStatement(Source source, SQLiteParameter[] param)
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

        public new string GetDeleteStatement(Source source, SQLiteParameter[] param)
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

        public new SQLiteCommand GetSelectCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
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

        public new SQLiteCommand GetUpdateCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
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

        public new SQLiteCommand GetInsertCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
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

        public new SQLiteCommand GetDeleteCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
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

        public new SQLiteCommand GetDataCommand(Source source, Provider provider, Sql cmd, SQLiteParameter[] pmr, SQLiteConnection connection)
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

        public SQLiteCommand GetDataCommand(string select, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SQLiteCommand(select, connection);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteDataAdapter GetDataAdapter(SQLiteCommand command)
        {
            try
            {
                return new SQLiteDataAdapter(command);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteDataReader GetDataReader(SQLiteCommand command)
        {
            try
            {
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteCommandBuilder GetCommandBuilder(SQLiteDataAdapter adapter)
        {
            try
            {
                return new SQLiteCommandBuilder(adapter);
            }
            catch (SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal SQLiteCommand GetSelectCommand(string select, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = select;
                return new SQLiteCommand(SelectStatement, connection);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal SQLiteCommand GetSelectCommand(Dictionary<string, object> param, SQLiteConnection connection)
        {
            try
            {
                SelectStatement = GetParameterStrings(param);
                return new SQLiteCommand(SelectStatement, connection);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}