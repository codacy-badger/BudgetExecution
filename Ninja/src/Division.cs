// <copyright file="Division.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    ///     Defines the <see cref="T:BudgetExecution.Division" />
    /// </summary>
    public class Division : IDataBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Division"/> class.
        /// </summary>
        public Division()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Division"/> class.
        /// </summary>
        /// <param name="source">The source MD, RA, RC, EJ, EN, WQ, WSA, MDR, MCF, MM, XA, SF <see cref="Source" /></param>
        /// <param name="provider">The provider<see cref="Provider" /></param>
        public Division(Source source, Provider provider = Provider.SQLite)
        {
            DbData = new DataBuilder(source, provider);
            Records = DbData.Table.AsEnumerable().Select(p => p).ToArray();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Division"/> class.
        /// </summary>
        /// <param name="source">The source MD, RA, RC, EJ, EN, WQ, WSA, MDR, MCF, MM, XA, SF <see cref="Source" /></param>
        /// <param name="provider">The provider<see cref="Provider" /></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}" /></param>
        public Division(Source source, Provider provider, Dictionary<string, object> p)
        {
            DbData = new DataBuilder(source, provider, p);
            Records = DbData.Table.AsEnumerable().Select(r => r).ToArray();
            if(Records.Length == 1)
            {
                Data = DbData.Table.AsEnumerable()
                             .Where(d => d.Field<string>("Source").Equals(source.ToString(), StringComparison.CurrentCultureIgnoreCase))
                             .Select(d => d)
                             .Single();
                ID = Data["ID"].ToString();
                RC = Data["RC"].ToString();
                Title = Data["Title"].ToString();
                Code = Data["Code"].ToString();
                Name = Data["Name"].ToString();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Division"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataRow" /></param>
        public Division(DataRow data)
        {
            Data = data;
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        /// <summary>
        ///Default args Source = Source.Divisions and Provider = Provider.SQLite are passed
        /// to the DataBuilder attribute. This constructor initializes a new instance of the <see cref="Division"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, object}"/></param>
        public Division(Dictionary<string, object> data)
        {
            Parameter = data;
            Data = new DataBuilder(Source.Divisions, Provider.SQLite, Parameter).Data;
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
            Title = Data["Title"].ToString();
            Code = Data["Code"].ToString();
            Name = Data["Name"].ToString();
        }

        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        public DivisionAuthority D6 { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the ID
        /// </summary>
        public string ID { get; }

        /// <summary>
        /// Gets the RC
        /// </summary>
        public string RC { get; }

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the Parameter
        /// </summary>
        public Dictionary<string, object> Parameter { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <summary>
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        // METHODS

        /// <inheritdoc />
        /// <summary>
        ///     Explicit implementation of the IDataBuilder method
        ///     Gets the primary data source using the DbData attribute.
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

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>The <see cref="string" /></returns>
        public override string ToString()
        {
            return RC;
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, object> GetParameter()
        {
            try
            {
                return new Dictionary<string, object> { ["RC"] = RC };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Inserts the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Insert(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, Sql.INSERT, p);
                query.DataConnection.Open();
                query.InsertCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Update(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, Sql.UPDATE, p);
                query.DataConnection.Open();
                query.UpdateCommand.ExecuteNonQuery();
                query.DataConnection.Close();
                query.InsertCommand.Dispose();
                query.DataConnection.Dispose();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Deletes the specified source.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="p">The p.</param>
        public static void Delete(Provider provider, Dictionary<string, object> p)
        {
            try
            {
                Query query = new Query(Source.Divisions, provider, Sql.DELETE, p);
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
