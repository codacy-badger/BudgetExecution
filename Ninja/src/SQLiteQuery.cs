using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace BudgetExecution
{
    public class SQLiteQuery : Query, IQuery
    {
        // CONSTRUCTORS
        public SQLiteQuery()
        {
        }

        public SQLiteQuery(Source source) : base(source)
        {
            Provider = base.Provider;
            Source = base.Source;
            SqlCmd = Sql.SELECT;
            DataConnection = GetConnection();
            TableName = Source.ToString();
            SelectStatement = $"SELECT * FROM {TableName}";
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public SQLiteQuery(Source source, Dictionary<string, object> p, Sql sqlcmd = Sql.SELECT) : base(source)
        {
            Provider = base.Provider;
            Source = source;
            SqlCmd = sqlcmd;
            DataConnection = GetConnection();
            TableName = Source.ToString();
            SqlStatement = GetSqlStatement(Source, SqlCmd, p);
            SelectCommand = GetSelectCommand(SelectStatement, DataConnection);
            DataAdapter = GetDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        public SQLiteQuery(Source source, Provider provider, Sql sql) : base(source, provider, sql)
        {
            Provider = provider;
            Source = source;
            SqlCmd = sql;
            DataConnection = GetConnection();
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

        public SQLiteQuery(Source source, Provider provider, Sql sql, Dictionary<string, object> param) : base(param, source, provider, sql)
        {
            Provider = base.Provider;
            Source = base.Source;
            SqlCmd = CommandType;
            Parameter = param;
            DataConnection = GetConnection();
            TableName = source.ToString();
            SqlStatement = GetSqlStatement(Source, SqlCmd, param);
            DataCommand = GetDataCommand(SqlStatement, DataConnection);
            DataAdapter = GetDataAdapter(DataCommand as SQLiteCommand);
            CommandBuilder = GetCommandBuilder(DataAdapter);
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            InsertCommand = CommandBuilder.GetInsertCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
            Settings = new AppSettingsReader();
        }

        // PROPERTIES
        public new AppSettingsReader Settings { get; }

        public new SQLiteConnection DataConnection { get; }

        public Dictionary<string, object> Parameter { get; }

        public new string TableName { get; }

        public Sql SqlCmd { get; set; }

        public new string SelectStatement { get; set; }

        public new SQLiteCommand SelectCommand { get; }

        public new SQLiteDataReader DataReader { get; set; }

        public new SQLiteDataAdapter DataAdapter { get; set; }

        public new SQLiteCommandBuilder CommandBuilder { get; internal set; }

        public new SQLiteCommand DeleteCommand { get; set; }

        public new SQLiteCommand InsertCommand { get; set; }

        public new SQLiteCommand UpdateCommand { get; set; }

        public new Source Source { get; }

        public new Provider Provider { get; }

        public new string SqlStatement { get; set; }

        // METHODS
        public string GetParameterStrings(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> p in param)
                {
                    vals += $"{p.Key} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return vals;
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteConnection GetConnection()
        {
            try
            {
                return (SQLiteConnection) base.DataConnection;
            }
            catch(Exception ex)
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
                foreach(SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"SELECT * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
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
                foreach(SQLiteParameter p in param)
                {
                    if(p.SourceColumn == "ID")
                    {
                        pid = (int) p.Value;
                    }

                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"UPDATE {source.ToString()} SET {vals} WHERE ID = '{pid.ToString()}'";
            }
            catch(Exception ex)
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
                foreach(SQLiteParameter p in param)
                {
                    cols += $"{p.SourceColumn}, ";
                    vals += $"{p.Value}, ";
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

        public string GetDeleteStatement(Source source, SQLiteParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(SQLiteParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
                }

                vals = vals.Trim().Substring(0, vals.Length - 4);
                return $"DELETE * FROM {source.ToString()} WHERE {vals}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetSelectCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetSelectStatement(source, pmr);
                    SQLiteCommand select = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
                    {
                        select.Parameters.Add(p);
                    }

                    return select;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetUpdateCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetUpdateStatement(source, pmr);
                    SQLiteCommand update = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
                    {
                        update.Parameters.Add(p);
                    }

                    return update;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetInsertCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetInsertStatement(source, pmr);
                    SQLiteCommand insert = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
                    {
                        insert.Parameters.Add(p);
                    }

                    return insert;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetDeleteCommand(Source source, Provider provider, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                if(provider == Provider.SQLite)
                {
                    string sql = GetDeleteStatement(source, pmr);
                    SQLiteCommand delete = new SQLiteCommand(sql, connection);
                    foreach(SQLiteParameter p in pmr)
                    {
                        delete.Parameters.Add(p);
                    }

                    return delete;
                }

                return null;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        public SQLiteCommand GetDataCommand(Source source, Provider provider, Sql cmd, SQLiteParameter[] pmr, SQLiteConnection connection)
        {
            try
            {
                switch(cmd)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(SystemException ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
