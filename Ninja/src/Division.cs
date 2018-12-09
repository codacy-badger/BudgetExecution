// <copyright file="Division.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class Division : IDataBuilder
    {
        public Division()
        {
            Source = Source.Divisions;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Division(Source source, Provider provider = Provider.SQLite) : this()
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public Division(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
            ID = Data["ID"].ToString();
            RC = new RC(Data["RC"].ToString());
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        public Division(DataRow data) : this()
        {
            Data = data;
            ID = Data["ID"].ToString();
            RC = new RC(Data["RC"].ToString());
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        public Division(Dictionary<string, object> data) : this()
        {
            Input = data;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
            ID = Data["ID"].ToString();
            RC = new RC(Data["RC"].ToString());
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public Dictionary<string, object> Input { get; set; }

        public string Title { get; set; }

        public string Code { get; }

        public string ID { get; }

        public RC RC { get; }

        public string Name { get; }

        public Dictionary<string, object> Parameter { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        // METHODS

        DataTable IDataBuilder.GetDataTable()
        {
            try
            {
                return new DataBuilder(Source, Provider).Table;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
        {
            try
            {
                return DbData.ProgramElements;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        DataRow[] IDataBuilder.GetRecords(DataTable table)
        {
            try
            {
                return DbData.Records;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        string[] IDataBuilder.GetUniqueValues(DataTable table, string column)
        {
            try
            {
                return DbData.GetUniqueValues(table, column);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return RC.Code;
        }

        private Dictionary<string, object> GetParameter()
        {
            try
            {
                return new Dictionary<string, object>
                {
                    ["RC"] = RC.Code, ["Name"] = Name,
                    ["Code"] = Code
                };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, SQL.INSERT, p);
                query.DataConnection.Open();
                query.InsertCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, SQL.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, SQL.DELETE, p);
                query.DataConnection.Open();
                query.DeleteCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.DeleteCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
