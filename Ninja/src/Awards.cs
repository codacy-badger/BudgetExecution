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
        public Awards() : base()
        {
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Awards", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Awards(Provider provider = Provider.SQLite) : base(provider)
        {
            Provider = provider;
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Awards", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public Awards(Provider provider, Dictionary<string, object> p) : this()
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Awards", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Awards"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public Awards(DataRow data) : this()
        {
            Data = data;
        }

        // PROPERTIES
        

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
