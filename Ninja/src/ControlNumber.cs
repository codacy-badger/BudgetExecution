// <copyright file="ControlNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Text;

    public class ControlNumber
    {
        // CONSTRUCTORS
        public ControlNumber()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ControlNumber" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ControlNumber(Source source = Source.ControlNumbers, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            ID = int.Parse(DbRow["ID"].ToString());
            Region = "R6";
            FiscalYear = Table.AsEnumerable().Select(p => p).First().Field<string>("FiscalYear");
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = RegionControlNumber + 1;
            BudgetControlNumber = FundControlNumber + 1;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ControlNumber" /> class.
        /// </summary>
        /// <param name="fund">The fund.</param>
        /// <param name="division">The division.</param>
        public ControlNumber(string fund, string division)
        {
            Source = Source.ControlNumbers;
            Provider = Provider.SQLite;
            Fund = fund;
            Division = division;
            DbData = new DataBuilder(Source, Provider, GetParamData(fund, division));
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            ID = int.Parse(DbRow["ID"].ToString());
            FiscalYear = DbRow["FiscalYear"].ToString();
            Region = "R6";
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = GetFundCount(fund) + 1;
            BudgetControlNumber = GetDivisionCount(division) + 1;
        }

        // PROPERTIES
        public static string Region { get; set; }

        public int ID { get; set; }

        public DataRow DbRow { get; set; }

        public DataBuilder DbData { get; set; }

        public string FiscalYear { get; }

        public int RegionControlNumber { get; set; }

        public string Fund { get; set; }

        public int FundControlNumber { get; set; }

        public string Division { get; set; }

        public string DivisionControlNumber { get; set; }

        public int BudgetControlNumber { get; set; }

        public Dictionary<string, object> Parameter { get; set; }

        private Source Source { get; }

        private Provider Provider { get; }

        private DataTable Table { get; }

        // METHODS

        /// <summary>
        ///     Gets the parameter data.
        /// </summary>
        /// <param name="fund">The fund.</param>
        /// <param name="divisionid">The divisionid.</param>
        /// <returns>  </returns>
        public Dictionary<string, object> GetParamData(string fund, string divisionid)
        {
            try
            {
                return new Dictionary<string, object> { ["Fund"] = fund, ["DivisionID"] = divisionid };
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the insertion columns.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetInsertionColumns(Dictionary<string, object> param)
        {
            try
            {
                ControlNumber account = new ControlNumber(param["Fund"].ToString(), param["DivisionID"].ToString());

                return param;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="p">The p.</param>
        /// <returns>returns a Fund object</returns>
        public static Fund Select(Source source, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, Provider.SQLite, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Selects the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        /// <returns>returns a Fund object</returns>
        public static Fund Select(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                DataRow datarow = new DataBuilder(source, provider, p).Table.AsEnumerable().Select(prc => prc).First();
                return new Fund(datarow);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return new StringBuilder($"{FiscalYear}={Region}-{RegionControlNumber}-{Fund}-{FundControlNumber}-{Division}-{BudgetControlNumber}").ToString();
        }

        /// <summary>
        ///     Gets the column names.
        /// </summary>
        /// <returns></returns>
        internal string[] GetColumnNames()
        {
            try
            {
                return Table.GetColumnNames();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the fund count.
        /// </summary>
        /// <param name="fund">The fund.</param>
        /// <returns></returns>
        internal int GetFundCount(string fund)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("Fund").Equals(fund)).Select(p => p).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        ///     Gets the division count.
        /// </summary>
        /// <param name="divisionid">The divisionid.</param>
        /// <returns></returns>
        internal int GetDivisionCount(string divisionId)
        {
            try
            {
                return Table.AsEnumerable().Where(p => p.Field<string>("DivisionID").Equals(divisionId)).Select(p => p).Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        ///     Gets the region count.
        /// </summary>
        /// <returns>return integer representing the number of records</returns>
        internal int GetRegionCount()
        {
            try
            {
                return DbData.Table.AsEnumerable().Count();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        internal void Calculate(string fund, string divisionid)
        {
            int reg = GetRegionCount() + 1;
            int fd = GetFundCount(fund) + 1;
            int dc = GetDivisionCount(divisionid) + 1;
        }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
