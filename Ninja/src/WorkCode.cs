// <copyright file="WorkCode.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class WorkCode : IDataBuilder
    {
        // CONSTRUCTORS
        public WorkCode()
        {
            Source = Source.WorkCodes;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public WorkCode(Provider provider = Provider.SQLite) : this()
        {
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public WorkCode(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                PayPeriod = Data["PayPeriod"].ToString();
                BFY = Data["BFY"].ToString();
                Org = Data["StartDate"].ToString();
                FundCode = Data["FundCode"].ToString();
                ApprovalDate = Data["ApprovalDate"].ToString();
                Project = Data["ProgramProjectCode"].ToString();
                Code = Data["WorkCode"].ToString();
                PayPeriod = Data["PayPeriod"].ToString();
                Description = Data["FirstName"].ToString();
            }
        }

        public WorkCode(Dictionary<string, object> p) : this()
        {
            Input = p;
            DbData = new DataBuilder(Source, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            if(Table.Rows.Count == 1)
            {
                Data = DbData.Data;
                ID = int.Parse(Data["ID"].ToString());
                PayPeriod = Data["PayPeriod"].ToString();
                BFY = Data["BFY"].ToString();
                Org = Data["StartDate"].ToString();
                FundCode = Data["FundCode"].ToString();
                ApprovalDate = Data["ApprovalDate"].ToString();
                Project = Data["ProgramProjectCode"].ToString();
                Code = Data["WorkCode"].ToString();
                PayPeriod = Data["PayPeriod"].ToString();
                Description = Data["FirstName"].ToString();
            }
        }

        public WorkCode(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            PayPeriod = Data["PayPeriod"].ToString();
            BFY = Data["BFY"].ToString();
            Org = Data["StartDate"].ToString();
            FundCode = Data["FundCode"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            Project = Data["ProgramProjectCode"].ToString();
            Code = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Description = Data["FirstName"].ToString();
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public Dictionary<string, object> Input { get; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public int ID { get; set; }

        public string ApprovalDate { get; set; }

        public string Org { get; }

        public string FundCode { get; }

        public string BFY { get; set; }

        public string Project { get; }

        public string DivisionName { get; set; }

        public string Code { get; }

        public string PayPeriod { get; set; }

        public string Description { get; }

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
                return (Dictionary<string, string[]>)DbData.ProgramElements;
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

        string[] IDataBuilder.GetUniqueValues(DataTable table, string col)
        {
            try
            {
                return DbData.GetUniqueValues(table, col);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return Code;
        }

        private Dictionary<string, object> GetParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code, ["BFY"] = bfy };
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
                Query query = new Query(Source.WorkCodes, provider, SQL.INSERT, p);
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

        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.WorkCodes, provider, SQL.UPDATE, p);
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

        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.WorkCodes, provider, SQL.DELETE, p);
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
