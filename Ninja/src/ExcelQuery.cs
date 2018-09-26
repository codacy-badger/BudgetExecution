// <copyright file="ExcelQuery.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BudgetExecution
{
    public class ExcelQuery : Query, IQuery
    {
        // Constructors
        public ExcelQuery(Dictionary<string, object> parameter) : base(Source.PRC, Provider.OleDb)
        {
            Parameter = parameter;
        }

        public ExcelQuery(Source source, Dictionary<string, object> parameter) : base(source, Provider.OleDb)
        {
            Settings = new AppSettingsReader();
            Source = source;
            Parameter = parameter;
            Provider = base.Provider;
            TableName = source.ToString();
            SelectStatement = $"SELECT * FROM {source.ToString()}";
            Connection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.xlsx");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        public ExcelQuery(Source source, Dictionary<string, object> param, Dictionary<string, object> parameter)
        {
            Settings = new AppSettingsReader();
            Source = source;
            Parameter = parameter;
            Provider = Provider.OleDb;
            TableName = source.ToString();
            Parameters = GetParameter(param);
            SelectStatement = GetSqlStatement();
            Connection = new OleDbConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\database\OleDb\R6.xlsx");
            SelectCommand = new OleDbCommand(SelectStatement, Connection);
            Adapter = new OleDbDataAdapter(SelectCommand);
            CommandBuilder = GetCommandBuilder(Adapter);
            InsertCommand = CommandBuilder.GetInsertCommand();
            UpdateCommand = CommandBuilder.GetUpdateCommand();
            DeleteCommand = CommandBuilder.GetDeleteCommand();
        }

        // Properties
        public OleDbDataAdapter Adapter { get; set; }

        public new OleDbCommandBuilder CommandBuilder { get; set; }

        public OleDbConnection Connection { get; }

        public new Dictionary<string, object> Parameter { get; }

        public OleDbParameter[] Parameters { get; set; }

        public new OleDbDataReader DataReader { get; set; }

        public new OleDbCommand SelectCommand { get; }

        public new string SelectStatement { get; }

        public new Source Source { get; }

        public new Provider Provider { get; set; }

        public new string TableName { get; }

        public new OleDbCommand UpdateCommand { get; }

        public new OleDbCommand InsertCommand { get; }

        public new OleDbCommand DeleteCommand { get; }

        public new AppSettingsReader Settings { get; set; }

        // Methods
        public OleDbParameter[] GetParameter(DataRow dr)
        {
            try
            {
                OleDbParameter[] val = new OleDbParameter[dr.ItemArray.Length];
                for(int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val[i] = new OleDbParameter(dr.Table.Columns[i].ColumnName, dr[i]);
                }

                return val;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbParameter[] GetParameter(Dictionary<string, object> param)
        {
            try
            {
                OleDbParameter[] val = new OleDbParameter[param.Count];
                for(int i = 0; i < param.Count; i++)
                {
                    foreach(KeyValuePair<string, object> kvp in param)
                    {
                        val[i] = new OleDbParameter(kvp.Key, kvp.Value);
                        val[i].SourceColumn = kvp.Key;
                        if(kvp.Key.Equals("ID"))
                        {
                            val[i].DbType = DbType.Int64;
                        }

                        if(kvp.Key.Equals("Amount"))
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public List<OleDbParameter> GetParameters(DataRow dr)
        {
            try
            {
                List<OleDbParameter> val = new List<OleDbParameter>();
                for(int i = 0; i < dr.ItemArray.Length; i++)
                {
                    val.Add(new OleDbParameter(dr.Table.Columns[i].ColumnName, dr[i]));
                }

                return val;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public List<OleDbParameter[]> GetParameter(DataTable table)
        {
            try
            {
                List<OleDbParameter[]> val = new List<OleDbParameter[]>();
                foreach(DataRow dr in table.Rows)
                {
                    val.Add(GetParameter(dr));
                }

                return val;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal new string GetSelectParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
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

        internal string GetSelectParamString(OleDbParameter[] param)
        {
            try
            {
                string vals = string.Empty;
                foreach(OleDbParameter p in param)
                {
                    vals += $"{p.SourceColumn} = '{p.Value}' AND ";
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

        private OleDbCommandBuilder GetCommandBuilder()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private OleDbDataAdapter GetDataAdapter()
        {
            try
            {
                return new OleDbDataAdapter(SelectCommand);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private string GetParamString(Dictionary<string, object> param)
        {
            try
            {
                string vals = string.Empty;
                foreach(KeyValuePair<string, object> kvp in param)
                {
                    vals += $"{kvp.Key} = '{kvp.Value}' AND ";
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

        private OleDbCommand GetSelectCommand()
        {
            try
            {
                return new OleDbCommand(SelectStatement, Connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal OleDbDataAdapter GetDataAdapter(string sql)
        {
            try
            {
                return new OleDbDataAdapter(sql, Connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommandBuilder GetCommandBuilder(OleDbDataAdapter adapter)
        {
            try
            {
                return new OleDbCommandBuilder(adapter);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbDataAdapter GetDataAdapter(OleDbCommand command)
        {
            try
            {
                return new OleDbDataAdapter(command.CommandText, command.Connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetDeleteCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetDeleteCommand();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetInsertCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetInsertCommand();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetSelectCommand(string select)
        {
            try
            {
                return new OleDbCommand(select, Connection);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public string GetSqlStatement()
        {
            try
            {
                return$"SELECT * FROM {TableName} WHERE {GetParamString(Parameter)}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public new string GetSqlStatement(string sql)
        {
            try
            {
                return$"SELECT * FROM {TableName} WHERE {sql}";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public OleDbCommand GetUpdateCommand()
        {
            try
            {
                return new OleDbCommandBuilder(Adapter).GetUpdateCommand();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
