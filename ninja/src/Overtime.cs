// <copyright file="Awards.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Overtime />
    /// </summary>
    public class Overtime : Supplemental, IDataBuilder
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Overtime"/> class.
        /// </summary>
        public Overtime()
        {
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Overtime"/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public Overtime(Provider provider = Provider.SQLite) : base(provider)
        {
            Provider = provider;
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=""/> class.
        /// </summary>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public Overtime(Provider provider, Dictionary<string, object> p) : base(provider, p)
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Overtime"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow"/></param>
        public Overtime(DataRow data) : base(data)
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
