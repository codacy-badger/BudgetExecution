﻿// <copyright file="WorkCode.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace BudgetExecution
{
    public class WorkCode
    {
        // CONSTRUCTORS
        public WorkCode()
        {
        }

        public WorkCode(Source source = Source.WorkCodes, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.WorkCodes, Provider);
        }

        public WorkCode(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source.WorkCodes, Provider, p);
            Table = DbData.Table;
            Data = DbData.Table.AsEnumerable().Select(prc => prc).First();
            ID = int.Parse(Data["ID"].ToString());
            PayPeriod = Data["PayPeriod"].ToString();
            BFY = Data["BFY"].ToString();
            Org = Data["StartDate"].ToString();
            FundCode = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            Project = Data["ProgramProjectCode"].ToString();
            Code = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Description = Data["FirstName"].ToString();
        }

        public WorkCode(DataRow data)
        {
            ID = int.Parse(data["ID"].ToString());
            PayPeriod = data["PayPeriod"].ToString();
            BFY = data["BFY"].ToString();
            Org = data["StartDate"].ToString();
            FundCode = data["FundCode"].ToString();
            ApprovalDate = data["ApprovalDate"].ToString();
            Project = data["ProgramProjectCode"].ToString();
            Code = data["WorkCode"].ToString();
            PayPeriod = data["PayPeriod"].ToString();
            Description = data["FirstName"].ToString();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public Sql Sql { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow Data { get; }

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

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.UPDATE, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.DELETE, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
