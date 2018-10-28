﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class WorkCode
    {
        // CONSTRUCTORS
        public WorkCode()
        {
        }

        public WorkCode(Source source = Source.WorkCodes, Provider provider = Provider.SQLite, Sql sql = Sql.SELECT)
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
            ID = int.Parse(Data["ID"].ToString());
            PayPeriod = Data["PayPeriod"].ToString();
            BFY = Data["BFY"].ToString();
            Org = Data["StartDate"].ToString();
            Fund = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            Project = Data["ProgramProjectCode"].ToString();
            Code = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Description = Data["FirstName"].ToString();
        }

        public WorkCode(DataRow Data)
        {
            ID = int.Parse(Data["ID"].ToString());
            PayPeriod = Data["PayPeriod"].ToString();
            BFY = Data["BFY"].ToString();
            Org = Data["StartDate"].ToString();
            Fund = Data["EndDate"].ToString();
            ApprovalDate = Data["ApprovalDate"].ToString();
            Project = Data["ProgramProjectCode"].ToString();
            Code = Data["WorkCode"].ToString();
            PayPeriod = Data["PayPeriod"].ToString();
            Description = Data["FirstName"].ToString();
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; }

        public DataRow Data { get; }

        public int ID { get; set; }

        public string ApprovalDate { get; set; }

        public string Org { get; }

        public string Fund { get; }

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
    }
}