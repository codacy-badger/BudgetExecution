
#region Using DIrectives

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class SqlQuery
            {
                #region Properties

                public Source Source { get; }
                public Command Sql { get; set; }
                public string TableName { get; }
                public SqlConnection Connection { get; }
                public Dictionary<string, object> Parameter { get; }
                public string SelectStatement { get; }
                public SqlCommand SelectCommand { get; }
                public SqlCommand InsertCommand { get; }
                public SqlCommand UpdateCommand { get; }
                public SqlCommand DeleteCommand { get; }
                public Dictionary<string, string> SqlStatement { get; }
                public SqlDataAdapter Adapter { get; set; }
                public SqlDataReader Reader { get; set; }
                public SqlCommandBuilder CommandBuilder { get; }

                #endregion Properties

                #region Constructors

                public SqlQuery()
                {
                }

                public SqlQuery(Source source)
                {
                    Source = source;
                    TableName = source.ToString();
                    SelectStatement = $"SELECT * FROM {source.ToString()}";
                    Connection = new SqlConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\sqlce\R6.sdf");
                    SelectCommand = new SqlCommand(SelectStatement, Connection);
                    Adapter = new SqlDataAdapter(SelectCommand);
                    CommandBuilder = GetCommandBuilder(Adapter);
                    InsertCommand = CommandBuilder.GetInsertCommand();
                    UpdateCommand = CommandBuilder.GetInsertCommand();
                    DeleteCommand = CommandBuilder.GetInsertCommand();
                }

                public SqlQuery(Source source, Dictionary<string, object> param)
                {
                    Source = source;
                    TableName = source.ToString();
                    Parameter = param;
                    SelectStatement = GetSqlStatement();
                    Connection = new SqlConnection(@"data source=C:\Users\terry\Documents\Visual Studio 2017\Projects\Budget\database\sqlce\R6.db");
                    SelectCommand = new SqlCommand(SelectStatement, Connection);
                    Adapter = new SqlDataAdapter(SelectCommand);
                    CommandBuilder = GetCommandBuilder(Adapter);
                    InsertCommand = CommandBuilder.GetInsertCommand();
                    UpdateCommand = CommandBuilder.GetInsertCommand();
                    DeleteCommand = CommandBuilder.GetInsertCommand();
                }

                #endregion Constructors

                #region Methods

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

                #endregion Methods
            }
        }
    }
}