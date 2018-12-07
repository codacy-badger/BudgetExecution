// <copyright file="BudgetLevel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Linq;

    public class Utilization : IDataBuilder
    {
        public Utilization(Source source = Source.Utilization, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }
        
        public Utilization(Provider provider, IDictionary<string, object> param) 
        {
            Source = Source.Utilization;
            Provider = provider;
            Input = param;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
            ID = int.Parse(Data["ID"].ToString());
            RPIO = Data["RPIO "].ToString();
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            AH = Data["AH"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            FOC = Data["FOC"].ToString();
            FocName = Data["FocName"].ToString();
            Authority = decimal.Parse(Data["Authority"].ToString());
            Budgeted = decimal.Parse(Data["Budgeted"].ToString());
            Posted = decimal.Parse(Data["Posted"].ToString());
            CarryIn = decimal.Parse(Data["CarryIn"].ToString());
            CarryOut = decimal.Parse(Data["CarryOut"].ToString());
            Commitments = decimal.Parse(Data["Commitments"].ToString());
            OpenCommitments = decimal.Parse(Data["OpenCommitments"].ToString());
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            ULO = decimal.Parse(Data["ULO"].ToString());
        }

        public Utilization(DataRow dr) : this()
        {
            Data = dr;
            ID = int.Parse(Data["ID"].ToString());
            RPIO = Data["RPIO "].ToString();
            BFY = Data["BFY"].ToString();
            Fund = new Fund(Data["FundCode"].ToString(), BFY);
            AH = Data["AH"].ToString();
            Org = new Org(Data["Org"].ToString());
            RC = new RC(Data["RC"].ToString());
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            BOC = new BOC(Data["BOC"].ToString());
            FOC = Data["FOC"].ToString();
            FocName = Data["FocName"].ToString();
            Authority = decimal.Parse(Data["Authority"].ToString());
            Budgeted = decimal.Parse(Data["Budgeted"].ToString());
            Posted = decimal.Parse(Data["Posted"].ToString());
            CarryIn = decimal.Parse(Data["CarryIn"].ToString());
            CarryOut = decimal.Parse(Data["CarryOut"].ToString());
            Commitments = decimal.Parse(Data["Commitments"].ToString());
            OpenCommitments = decimal.Parse(Data["OpenCommitments"].ToString());
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            ULO = decimal.Parse(Data["ULO"].ToString());
        }

        // Properties
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public IDictionary<string, object> Input { get; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public string AH { get; set; }

        public string AhName { get; set; }

        public int ID { get; set; }

        public string BFY { get; set; }

        public BOC BOC { get; set; }

        public string BudgetLevel { get; set; }

        public string BocName { get; set; }

        public string ProgramProjectCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string ProgramArea { get; set; }

        public string ProgramAreaName { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public Fund Fund { get; set; }

        public string FundCode { get; set; }

        public string FundName { get; set; }

        public decimal Amount { get; set; }

        public Org Org { get; set; }

        public string OrgName { get; set; }

        public RC RC { get; set; }

        public string Division { get; set; }

        public string RPIO { get; set; }

        public decimal Authority { get; set; }

        public decimal Budgeted { get; set; }

        public decimal Posted { get; set; }

        public decimal CarryIn { get; set; }

        public decimal CarryOut { get; set; }

        public decimal Commitments { get; set; }

        public decimal OpenCommitments { get; set; }

        public decimal Obligations { get; set; }

        public decimal ULO { get; set; }

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

        internal Dictionary<string, object> GetDataFields()
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object> { ["ID"] = ID, ["RPIO"] = RPIO, ["BFY"] = BFY, ["Fund"] = Fund.Code, ["RC"] = RC, ["BOC"] = BOC.Code, ["Code"] = ProgramProjectCode };
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal string[] GetFields()
        {
            try
            {
                Dictionary<string, object> prc = GetDataFields();

                return prc.Keys.ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal object[] GetValues()
        {
            try
            {
                Dictionary<string, object> param = GetDataFields();
                return param.Values.ToArray();
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
                Query query = new Query(source, provider, SQL.INSERT, p);
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
                Query query = new Query(source, provider, SQL.INSERT, p);
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
                Query query = new Query(source, provider, SQL.INSERT, p);
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
