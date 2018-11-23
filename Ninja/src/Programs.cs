// <copyright file="Programs.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Programs" />
    /// </summary>
    public class Programs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Programs"/> class.
        /// </summary>
        public Programs()
        {
            Source = Source.Programs;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
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

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the Columns
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Gets or sets the Records
        /// </summary>
        public DataRow[] Records { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public DataRow Data { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the RpioName
        /// </summary>
        public string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        public Fund Fund { get; set; }

        /// <summary>
        /// Gets or sets the FundName
        /// </summary>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the AH
        /// </summary>
        public string AH { get; set; }

        /// <summary>
        /// Gets or sets the AllowanceHolderName
        /// </summary>
        public string AllowanceHolderName { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public Org Org { get; set; }

        /// <summary>
        /// Gets or sets the DivisionName
        /// </summary>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectCode
        /// </summary>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectName
        /// </summary>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the BocName
        /// </summary>
        public string BocName { get; set; }

        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return ProgramProjectName;
        }
    }
}
