// <copyright file="Benefits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Benefits
    {
        // CONSTRUCTORS
        public Benefits()
        {
            Source = Source.Benefits;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        public Benefits(Source source, Provider provider)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
            DbRow = Records[0];
        }

        public Benefits(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
            DbRow = Records[0];
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow DbRow { get; set; }

        public int ID { get; set; }

        public string EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ServiceDate { get; set; }

        public string HireDate { get; set; }

        public string JobTitle { get; set; }

        public string OccupationalSeries { get; set; }

        public string HROrgCode { get; set; }

        public string HROrgCodeName { get; set; }

        public string Grade { get; set; }

        public string Step { get; set; }

        public string GradeEntryDate { get; set; }

        public string StepEntry { get; set; }

        public string WigiDueDate { get; set; }

        public string AppointmentAuthority { get; set; }

        public string AppointmentType { get; set; }

        public string BargainingUnit { get; set; }

        public string EmployeeStatus { get; set; }

        public string RetirementPlan { get; set; }

        public decimal CompensationRate { get; set; }
    }
}
