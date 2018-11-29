// <copyright file="Awards.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MoreLinq;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines the <see cref="Awards" />
    /// </summary>
    public class Awards : Supplemental, IDataBuilder
    {
        // CONSTRUCTORS
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        public Awards()
        {
            Source = Source.Supplemental;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Columns = DbData.Columns;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Awards(Provider provider = Provider.SQLite)
        {
            Source = Source.Supplemental;
            Provider = provider;
            Table = new DataBuilder(Source, Provider).Table.AsEnumerable()
                                                     .Where(p => p.Field<string>("Type").Equals("Awards", StringComparison.CurrentCultureIgnoreCase))
                                                     .Select(p => p).CopyToDataTable();
            Records = Table.AsEnumerable().Select(p => p).ToArray();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public Awards(Provider provider, Dictionary<string, object> p)
        {
            Source = Source.Supplemental;
            Provider = provider;
            Table = new DataBuilder(Source, Provider, p).GetDataTable();
            Records = Table.AsEnumerable().Select(r => r).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Table.AsEnumerable().Select(d => d).Single();
                ID = int.Parse(Data["ID"].ToString());
                Type = Data["Type"].ToString();
                RC = Data["RC"].ToString();
                DivisionName = Data["DivisionName"].ToString();
                FundCode = Data["FundCode"].ToString();
                BFY = Data["BFY"].ToString();
                Amount = decimal.Parse(Data["Amount"].ToString());
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public Awards(DataRow data)
        {
            Data = data;
            ID = int.Parse(Data["ID"].ToString());
            Type = Data["Type"].ToString();
            RC = Data["RC"].ToString();
            DivisionName = Data["DivisionName"].ToString();
            FundCode = Data["FundCode"].ToString();
            BFY = Data["BFY"].ToString();
            Amount = decimal.Parse(Data["Amount"].ToString());
        }

        // PROPERTIES
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public new Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public new Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public new DataBuilder DbData { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public new DataTable Table { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public new string[] Columns { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public new DataRow[] Records { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public new DataRow Data { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public new Dictionary<string, string[]> ProgramElements { get; set; }
        

        // METHODS


        /// <inheritdoc />
        /// <summary>
        /// Explicit implementation of the IDataBuilder method 
        /// Gets the primary data source using the DbData attribute.
        /// </summary>
        /// <returns></returns>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// 
        /// <param name="table">The table<see cref="T:System.Data.DataTable" /></param>
        /// <returns>The <see cref="T:System.Collections.Generic.Dictionary`2" /></returns>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
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

        /// <inheritdoc />
        /// <summary> Explicit implementation of the IDataBuilder method </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
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
    }
}
