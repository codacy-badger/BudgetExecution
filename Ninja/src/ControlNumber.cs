// <copyright file="ControlNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace BudgetExecution
{
    public class ControlNumber : IDataBuilder
    {
        // CONSTRUCTORS
        public ControlNumber()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ControlNumber" /> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public ControlNumber(Provider provider = Provider.SQLite)
        {
            Source = Source.ControlNumbers;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Records;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ControlNumber" /> class.
        /// </summary>
        /// <param name="division">The division.</param>
        public ControlNumber(string fundCode, string division)
        {
            Source = Source.ControlNumbers;
            Provider = Provider.SQLite;
            FundCode = fundCode;
            Division = division;
            DbData = new DataBuilder(Source, Provider, GetParamData(FundCode, division));
            Table = DbData.Table;
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Region = "R6";
                BFY = Table.AsEnumerable().Select(p => p.Field<string>("BFY")).First();
                RegionControlNumber = GetRegionCount() + 1;
                FundControlNumber = RegionControlNumber + 1;
                BudgetControlNumber = FundControlNumber + 1;
            }
        }

        public ControlNumber(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Region = "R6";
            BFY = Table.AsEnumerable().Select(p => p.Field<string>("BFY")).First();
            RegionControlNumber = GetRegionCount() + 1;
            FundControlNumber = RegionControlNumber + 1;
            BudgetControlNumber = FundControlNumber + 1;
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

        public static string Region { get; set; }

        public int ID { get; set; }

        public string BFY { get; }

        public int RegionControlNumber { get; set; }

        public string FundCode { get; set; }

        public int FundControlNumber { get; set; }

        public string Division { get; set; }

        public string DivisionControlNumber { get; set; }

        public int BudgetControlNumber { get; set; }

        public Dictionary<string, object> Parameter { get; set; }

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
                return new Dictionary<string, object> { ["FundCode"] = fund, ["DivisionID"] = divisionid };
            }
            catch(Exception ex)
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
                new ControlNumber(param["FundCode"].ToString(), param["DivisionID"].ToString());

                return param;
            }
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            return new StringBuilder($"{BFY}={Region}-{RegionControlNumber}-{FundCode}-{FundControlNumber}-{Division}-{BudgetControlNumber}").ToString();
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        ///     Gets the fund count.
        /// </summary>
        /// <param name="fundcode">The fund.</param>
        /// <returns></returns>
        internal int GetFundCount(string fundcode)
        {
            try
            {
                return Table.AsEnumerable()
                            .Where(p => p.Field<string>("Fund").Equals(fundcode))
                            .Select(p => p).Count();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        ///     Gets the division count.
        /// </summary>
        /// <returns></returns>
        internal int GetDivisionCount(int divisionId)
        {
            try
            {
                return Table.AsEnumerable()
                            .Where(p => p.Field<int>("ID").Equals(divisionId))
                            .Select(p => p)
                            .Count();
            }
            catch(Exception ex)
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
                return DbData.Table.Rows.Count;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }


        /// <inheritdoc />
        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        DataTable IDataBuilder.GetDataTable()
        {
            try
            {
                Query query = DbData.Query;
                DataSet ds = new DataSet("R6");
                ds.DataSetName = "R6";
                DataTable dt = new DataTable();
                dt.TableName = Source.ToString();
                ds.Tables.Add(dt);
                query.DataAdapter.Fill(ds, dt.TableName);
                return dt;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }


        /// <inheritdoc />
        /// <summary>
        /// Gets the records in the table as an Array of DataRows.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        DataRow[] IDataBuilder.GetRecords(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p).ToArray();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the unique values.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        string[] IDataBuilder.GetUniqueValues(DataTable table, string column)
        {
            try
            {
                if(table.GetColumnNames().Contains(column))
                {
                    return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the program elements.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        Dictionary<string, string[]> IDataBuilder.GetProgramElements(DataTable table)
        {
            if(table != null)
            {
                try
                {
                    Dictionary<string, string[]> data = new Dictionary<string, string[]>();
                    foreach(DataColumn dc in table.Columns)
                    {
                        if(dc.ColumnName.Equals("ID") ||
                           dc.ColumnName.Equals("Amount") ||
                           dc.ColumnName.Equals("Hours") ||
                           dc.ColumnName.Contains("OpenCommitments") ||
                           dc.ColumnName.Contains("ULO") ||
                           dc.ColumnName.Equals("Obligations") ||
                           dc.ColumnName.Equals("Commitments") ||
                           dc.ColumnName.Equals("Authority") ||
                           dc.ColumnName.Equals("Budgeted") ||
                           dc.ColumnName.Equals("Posted") ||
                           dc.ColumnName.Equals("CarryIn") ||
                           dc.ColumnName.Equals("CarryOut") ||
                           dc.ColumnName.Equals("Balance"))
                        {
                            continue;
                        }

                        data.Add(dc.ColumnName, table.AsEnumerable().Select(p => p.Field<string>(dc)).Distinct().ToArray());
                    }

                    if(data.ContainsKey("ID"))
                    {
                        data.Remove("ID");
                    }

                    if(data.ContainsKey("Amount"))
                    {
                        data.Remove("Amount");
                    }

                    return data;
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        /// <summary>
        ///     Inserts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
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
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        ///     Deletes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(source, provider, Sql.INSERT, p);
                DbConnection conn = query.DataConnection;
                DbCommand command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
