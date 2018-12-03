// <copyright file="Awards.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Overtime : Supplemental, IDataBuilder
    {
        // CONSTRUCTORS
        public Overtime()
        {
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        public Overtime(Provider provider = Provider.SQLite) : base(provider)
        {
            Provider = provider;
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        public Overtime(Provider provider, Dictionary<string, object> p) : base(provider, p)
        {
            Provider = provider;
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        public Overtime(DataRow data) : base(data)
        {
            Data = data;
        }

        public Overtime(Dictionary<string, object> p) : base(p)
        {
            Input = p;
            DbData = new DataBuilder(Source, Provider, Input);
            Table = DbData.Table.AsEnumerable()
                          .Where(a => a.Field<string>("Type").Equals("Overtime", StringComparison.CurrentCultureIgnoreCase))
                          .Select(a => a).CopyToDataTable();
        }

        // PROPERTIES


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
    }
}
