// <copyright file="TravelObligations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    // CONSTRUCTORS
    public class TravelObligations : IDataBuilder
    {
        public TravelObligations()
        {
        }

        public TravelObligations(Provider provider = Provider.SQLite)
        {
            Source = Source.TravelObligations;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
        }

        public TravelObligations(Provider provider, Dictionary<string, object> param)
        {
            Source = Source.TravelObligations;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, param);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Data = DbData.Data;
            ID = int.Parse(Data["ID"].ToString());
            RPIO = Data["RPIO"].ToString();
            BFY = Data["BFY"].ToString();
            AH = Data["AH"].ToString();
            AllowanceHolderName = Data["AllowanceHolderName"].ToString();
            RC = Data["RC"].ToString();
            DivisionName = Data["DivisionName"].ToString();
            Org = Data["Org"].ToString();
            OrgName = Data["OrgName"].ToString();
            Code = Data["Code"].ToString();
            FOC = Data["FOC"].ToString();
            FocName = Data["FocName"].ToString();
            ProgramProjectCode = Data["ProgramProjectCode"].ToString();
            ProgramProjectName = Data["ProgramProjectName"].ToString();
            TravelBeginDate = Data["TravelBeginDate"].ToString();
            TravelEndDate = Data["TravelEndDate"].ToString();
            TravelType = Data["TravelType"].ToString();
            TravelerName = Data["TravelerName"].ToString();
            DCN = Data["DCN"].ToString();
            OpenCommitments = decimal.Parse(Data["OpenCommitments"].ToString());
            Obligations = decimal.Parse(Data["Obligations"].ToString());
            ULO = decimal.Parse(Data["ULO "].ToString());
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public string[] Columns { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public int ID { get; set; }

        public string RPIO { get; set; }

        public string BFY { get; set; }

        public string AH { get; set; }

        public string AllowanceHolderName { get; set; }

        public string RC { get; set; }

        public string DivisionName { get; set; }

        public string Org { get; set; }

        public string OrgName { get; set; }

        public string Code { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public string ProgramProjectCode { get; set; }

        public string ProgramProjectName { get; set; }

        public string TravelBeginDate { get; set; }

        public string TravelEndDate { get; set; }

        public string TravelType { get; set; }

        public string ObligationType { get; set; }

        public string TravelerName { get; set; }

        public string DCN { get; set; }

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

        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.TravelObligations, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.TravelObligations, provider, SQL.INSERT, p);
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
                Query query = new Query(Source.TravelObligations, provider, SQL.INSERT, p);
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
