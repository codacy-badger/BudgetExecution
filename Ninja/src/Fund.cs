// <copyright file="Fund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Windows.Forms;

    public class Fund : IFund
    {
        private Source Source;
        private Provider Provider;

        // CONSTRUCTORS
        public Fund()
        {
        }
        public Fund(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table;
        }

        public Fund(string code, string bfy) : this(Source.Funds, Provider.SQLite)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetParamData(Code, FiscalYear);
            Table = GetData(Source, Provider, Parameter);
            Data = Table.Rows[0];
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(Source source, Provider provider, string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetParamData(Code, FiscalYear);
            Table = GetData(Source.Funds, Provider.SQLite, Parameter);
            Data = Table.AsEnumerable().First();
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        public Fund(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Name = Data["Name"].ToString();
            Title = Data["Title"].ToString();
            TreasurySymbol = Data["TreasurySymbol"].ToString();
        }

        // PROPERTIES
        public int ID { get; set; }

        public string Code { get; }

        public string FiscalYear { get; }

        public Dictionary<string, object> Parameter { get; }

        public string Name { get; }

        public string Title { get; }

        public string TreasurySymbol { get; }

        public DataTable Table { get; set; }

        public DataRow Data { get; set; }

        // METHODS
        public Dictionary<string, object> GetParamData(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["FiscalYear"] = bfy };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public Dictionary<string, object> GetFundData(string code)
        {
            try
            {
                var dr = GetData(Source.Funds, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public DataTable GetData(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        internal string[] GetFields(Source source, Provider provider)
        {
            try
            {
                Dictionary<string, object> prc = GetParamData(this.Source.ToString(), this.Provider.ToString());

                return prc.Keys.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }

        internal object[] GetFieldValues()
        {
            try
            {
                Dictionary<string, object> param = GetParamData(this.Source.ToString(), this.Provider.ToString());

                return param.Values.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                return null;
            }
        }

        public static Dictionary<string, object> GetInsertionColumns(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var account = new Account(source, provider, param["Fund"].ToString(), param["Code"].ToString());
                if (!param.ContainsKey("FundName") || param["FundName"] == null)
                {
                    param["FundName"] = account.FundName;
                }

                if (!param.ContainsKey("Org") || param["Org"] == null)
                {
                    param["Org"] = account.Org;
                }

                if (!param.ContainsKey("ProgramProject") || param["ProgramProject"] == null)
                {
                    param["ProgramProject"] = account.ProgramProjectCode;
                    param["ProgramProjectName"] = account.ProgramProjectName;
                }

                if (!param.ContainsKey("ProgramArea") || param["ProgramArea"] == null)
                {
                    param["ProgramArea"] = account.ProgramArea;
                    param["ProgramAreaName"] = account.ProgramAreaName;
                }

                if (!param.ContainsKey("Goal") || param["Goal"] == null)
                {
                    param["Goal"] = account.Goal;
                    param["GoalName"] = account.GoalName;
                }

                if (!param.ContainsKey("Objective") || param["Objective"] == null)
                {
                    param["Objective"] = account.Objective;
                    param["ObjectiveName"] = account.ObjectiveName;
                }

                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static PRC Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new PRC(datarow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var param = GetInsertionColumns(source, provider, p);
                var fields = param.Keys.ToArray();
                var vals = param.Values.ToArray();
                var query = new Query(source, provider, param);
                var cmd = $"INSERT INTO {source.ToString()} {fields} VALUES {vals};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var insert = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"UPDATE {source.ToString()} SET Amount = {(decimal)p["Amount"]} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, p);
                var cmd = $"DELETE ALL FROM {source.ToString()} WHERE ID = {(int)p["ID"]};";
                SQLiteConnection conn = query.GetConnection(Provider.SQLite) as SQLiteConnection;
                using (conn)
                {
                    var update = query.GetDataCommand(cmd, conn) as SQLiteCommand;
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}