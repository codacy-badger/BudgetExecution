// <copyright file="Query.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;

    public class Query : IQuery
    {
        // CONSTRUCTORS
        public Query()
        {
        }

        public Query(Source source = Source.PRC, Provider provider = Provider.SQLite, SQL cmb = SQL.SELECT)
        {
            Provider = provider;
            Source = source;
            Sql = cmb;
            DataConnection = GetDataConnection(Provider);
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand, Sql);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        public Query(Tuple<Provider, Source, SQL> queryTuple, IDictionary<string, object> param)
        {
            Provider = queryTuple.Item1;
            Source = queryTuple.Item2;
            Sql = queryTuple.Item3;
            TableName = Source.ToString();
            DataConnection = GetDataConnection(Provider);
            SqlStatement = GetSqlStatement(Source, Sql, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand, Sql);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            UpdateStatement = UpdateCommand.CommandText;
            InsertCommand = CommandBuilder.GetInsertCommand();
            InsertStatement = InsertCommand.CommandText;
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            DeleteStatement = DeleteCommand.CommandText;
        }

        public Query(Source source, Provider provider, SQL command, IDictionary<string, object> param)
        {
            Provider = provider;
            Source = source;
            Sql = command;
            TableName = Source.ToString();
            DataConnection = GetDataConnection(Provider);
            SqlStatement = GetSqlStatement(Source, Sql, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand, Sql);
        }


        // PROPERTIES


        public Source Source { get; }

        public Provider Provider { get; }

        public SQL Sql { get; }

        public string TableName { get; }

        public string SelectStatement { get; set; }

        public string UpdateStatement { get; set; }

        public string InsertStatement { get; set; }

        public string DeleteStatement { get; set; }

        public DbCommand SelectCommand { get; set; }

        public DbCommand DeleteCommand { get; internal set; }

        public DbCommand InsertCommand { get; internal set; }

        public DbCommand UpdateCommand { get; internal set; }

        public DbCommandBuilder CommandBuilder { get; internal set; }

        public DbConnection DataConnection { get; set; }

        public string SqlStatement { get; set; }

        public DbCommand DataCommand { get; set; }

        public DbDataReader DataReader { get; set; }

        public DbDataAdapter DataAdapter { get; set; }

        // METHODS

        public DbConnection GetDataConnection(Provider provider)
        {
            try
            {
                ConnectionStringSettingsCollection connectionString = ConfigurationManager.ConnectionStrings;
                switch(provider)
                {
                    case Provider.SQLite:
                        return new SQLiteConnection(connectionString["SQLite"].ConnectionString);

                    case Provider.SqlCe:
                        return new SqlCeConnection(connectionString["SqlCe"].ConnectionString);

                    case Provider.SqlServer:
                        return new SqlConnection(connectionString["SqlServer"].ConnectionString);

                    case Provider.Access:
                        return new OleDbConnection(connectionString["Access"].ConnectionString);

                    case Provider.OleDb:
                        return new OleDbConnection(connectionString["OleDb"].ConnectionString);

                    case Provider.Excel:
                        return new OleDbConnection(connectionString["Excel"].ConnectionString);
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlStatement(string sqlWhere)
        {
            try
            {
                return $"SELECT * FROM {TableName} WHERE {sqlWhere}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbCommand GetDataCommand(string sql, DbConnection connection)
        {
            try
            {
                switch(connection)
                {
                    case SQLiteConnection sqLiteConnection:
                        SqlStatement = sql;
                        return new SQLiteCommand(SqlStatement, sqLiteConnection);
                    case OleDbConnection oleDbConnection:
                        SqlStatement = sql;
                        return new OleDbCommand(SqlStatement, oleDbConnection);
                    case SqlCeConnection sqlceConnection:
                        SqlStatement = sql;
                        return new SqlCeCommand(SqlStatement, sqlceConnection);
                    case SqlConnection sqlConnection:
                        SqlStatement = sql;
                        return new SqlCommand(SqlStatement, sqlConnection);
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbDataAdapter GetDataAdapter(DbCommand command, SQL cmd)
        {
            try
            {
                switch(cmd)
                {
                    case SQL.SELECT:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter adapter = new SQLiteDataAdapter((SQLiteCommand)command);
                                adapter.SelectCommand = (SQLiteCommand)command;
                                return adapter;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter oledbselect = new OleDbDataAdapter((OleDbCommand)command);
                                oledbselect.SelectCommand = (OleDbCommand)command;
                                return oledbselect;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter sqlceselect = new SqlCeDataAdapter((SqlCeCommand)command);
                                sqlceselect.SelectCommand = (SqlCeCommand)command;
                                return sqlceselect;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter sqlselect = new SqlDataAdapter((SqlCommand)command);
                                sqlselect.SelectCommand = (SqlCommand)command;
                                return sqlselect;
                            }
                        }

                        break;

                    case SQL.UPDATE:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter update = new SQLiteDataAdapter((SQLiteCommand)command);
                                update.UpdateCommand = (SQLiteCommand)command;
                                return update;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter update = new OleDbDataAdapter((OleDbCommand)command);
                                update.UpdateCommand = (OleDbCommand)command;
                                return update;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter update = new SqlCeDataAdapter((SqlCeCommand)command);
                                update.UpdateCommand = (SqlCeCommand)command;
                                return update;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter update = new SqlDataAdapter((SqlCommand)command);
                                update.UpdateCommand = (SqlCommand)command;
                                return update;
                            }
                        }

                        break;

                    case SQL.INSERT:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter insert = new SQLiteDataAdapter((SQLiteCommand)command);
                                insert.InsertCommand = (SQLiteCommand)command;
                                return insert;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter insert = new OleDbDataAdapter((OleDbCommand)command);
                                insert.InsertCommand = (OleDbCommand)command;
                                return insert;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter insert = new SqlCeDataAdapter((SqlCeCommand)command);
                                insert.InsertCommand = (SqlCeCommand)command;
                                return insert;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter insert = new SqlDataAdapter((SqlCommand)command);
                                insert.InsertCommand = (SqlCommand)command;
                                return insert;
                            }
                        }

                        break;

                    case SQL.DELETE:
                        switch(command)
                        {
                            case SQLiteCommand _:
                            {
                                SQLiteDataAdapter delete = new SQLiteDataAdapter((SQLiteCommand)command);
                                delete.DeleteCommand = (SQLiteCommand)command;
                                return delete;
                            }

                            case OleDbCommand _:
                            {
                                OleDbDataAdapter delete = new OleDbDataAdapter((OleDbCommand)command);
                                delete.DeleteCommand = (OleDbCommand)command;
                                return delete;
                            }

                            case SqlCeCommand _:
                            {
                                SqlCeDataAdapter delete = new SqlCeDataAdapter((SqlCeCommand)command);
                                delete.DeleteCommand = (SqlCeCommand)command;
                                return delete;
                            }

                            case SqlCommand _:
                            {
                                SqlDataAdapter delete = new SqlDataAdapter((SqlCommand)command);
                                delete.DeleteCommand = (SqlCommand)command;
                                return delete;
                            }
                        }

                        break;

                    default:
                        SQLiteDataAdapter select = new SQLiteDataAdapter((SQLiteCommand)command);
                        select.SelectCommand = (SQLiteCommand)command;
                        return select;
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbDataReader GetDataReader(DbCommand command)
        {
            try
            {
                switch(command)
                {
                    case SQLiteCommand liteCommand:
                        return liteCommand.ExecuteReader();
                    case OleDbCommand dbCommand:
                        return dbCommand.ExecuteReader();
                    case SqlCommand sqlCommand:
                        return sqlCommand.ExecuteReader();
                    case SqlCeCommand sqlceCommand:
                        return sqlceCommand.ExecuteReader();
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbCommandBuilder GetCommandBuilder(DbDataAdapter adapter)
        {
            try
            {
                switch(adapter)
                {
                    case SQLiteDataAdapter _:
                        CommandBuilder = new SQLiteCommandBuilder(adapter as SQLiteDataAdapter);
                        return CommandBuilder;
                    case OleDbDataAdapter _:
                        CommandBuilder = new OleDbCommandBuilder(adapter as OleDbDataAdapter);
                        return CommandBuilder;
                    case SqlCeDataAdapter _:
                        CommandBuilder = new SqlCeCommandBuilder(adapter as SqlCeDataAdapter);
                        return CommandBuilder;
                    case SqlDataAdapter _:
                        CommandBuilder = new SqlCommandBuilder(adapter as SqlDataAdapter);
                        return CommandBuilder;
                    default:
                        return null;
                }
            }
            catch(SystemException ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlParameterString(IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND";
                }

                return vals.Trim().Substring(0, vals.Length - 4);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string GetSelectParamString(IDictionary<string, object> p)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in p)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                return vals.Trim().Substring(0, vals.Length - 4);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlStatement(Source source, SQL cmd, IDictionary<string, object> p)
        {
            try
            {
                switch(cmd)
                {
                    case SQL.SELECT:
                        SelectStatement = GetSelectStatement(source, p);
                        return SelectStatement;

                    case SQL.UPDATE:
                        UpdateStatement = GetUpdateStatement(source, p);
                        return UpdateStatement;

                    case SQL.INSERT:
                        InsertStatement = GetInsertStatement(source, p);
                        return InsertStatement;

                    case SQL.DELETE:
                        DeleteStatement = GetDeleteStatement(source, p);
                        return DeleteStatement;

                    default:
                        return GetSelectStatement(source, p);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectStatement(string table, IDictionary<string, object> param)
        {
            try
            {
                return $"SELECT * FROM {table} WHERE {GetSqlParameterString(param)}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSelectStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                vals = vals.TrimEnd().Substring(0, vals.Length - 4);
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetUpdateStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                int id = int.Parse(param["ID"].ToString());

                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"UPDATE {source.ToString()} SET {vals} WHERE ID = '{id}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetInsertStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                string cols = string.Empty;
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    cols += $"{kvp.Key}, ";
                    vals += $"{kvp.Value}, ";
                }

                cols = cols.Trim().Substring(0, cols.Length - 2);
                vals = vals.Trim().Substring(0, vals.Length - 2);
                return $"INSERT INTO {source.ToString()} ({cols}) VALUES ({vals})";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetDeleteStatement(Source source, IDictionary<string, object> param)
        {
            try
            {
                int id = int.Parse(param["ID"].ToString());
                return $"DELETE * FROM {source.ToString()} WHERE ID = '{id}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal DbCommand GetSelectCommand(string select, DbConnection connection)
        {
            try
            {
                switch(connection)
                {
                    case SQLiteConnection _:
                        SelectStatement = select;
                        return new SQLiteCommand(SelectStatement, (SQLiteConnection)connection);            
                    case OleDbConnection _:
                        SelectStatement = select;
                        return new OleDbCommand(SelectStatement, (OleDbConnection)connection);
                    case SqlCeConnection _:
                        SelectStatement = select;
                        return new SqlCeCommand(SelectStatement, (SqlCeConnection)connection);
                    case SqlConnection _:
                        SelectStatement = select;
                        return new SqlCommand(SelectStatement, (SqlConnection)connection);
                    default:
                        return null;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public DbCommand GetUpdateCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetUpdateStatement(Source, pmr);
                DbCommand update = GetDataCommand(sql, DataConnection);
                update.CommandText = sql;
                update.Connection = DataConnection;
                return update;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DbCommand GetInsertCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetInsertStatement(Source, pmr);
                DbCommand insert = GetDataCommand(sql, DataConnection);
                insert.CommandText = sql;
                insert.Connection = DataConnection;
                return insert;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DbCommand GetDeleteCommand(IDictionary<string, object> pmr)
        {
            try
            {
                string sql = GetDeleteStatement(Source, pmr);
                DbCommand deleteCommand = GetDataCommand(sql, DataConnection);
                deleteCommand.CommandText = sql;
                deleteCommand.Connection = DataConnection;
                return deleteCommand;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public DbCommand GetDataCommand(SQL cmd, IDictionary<string, object> pmr)
        {
            try
            {
                switch(cmd)
                {
                    case SQL.SELECT:
                        return GetSelectCommand(GetSelectParamString(pmr), DataConnection);

                    case SQL.UPDATE:
                        return GetUpdateCommand(pmr);

                    case SQL.INSERT:
                        return GetInsertCommand(pmr);

                    case SQL.DELETE:
                        return GetDeleteCommand(pmr);

                    default:
                        return GetSelectCommand(GetSelectParamString(pmr), DataConnection);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
