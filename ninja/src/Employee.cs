﻿using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BudgetExecution
{
    public class Employee : IEmployee
    {
        // CONSTRUCTORS
        public Employee()
        {
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        public Employee(Source source = Source.Personnel, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
        }

        public Employee(Source source, Provider provider, Dictionary<string, object> p)
        {
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.Table;
            Records = DbData.Table.AsEnumerable().Select(a => a).ToArray();
            if(Table.Rows.Count == 1)
            {
                Data = Records[0];
                Section = Data["Section"].ToString();
                FirstName = Data["FirstName"].ToString();
                LastName = Data["LastName"].ToString();
                Office = Data["Office"].ToString();
                Phone = Data["Phone"].ToString();
                Cell = Data["Cell"].ToString();
                Email = Data["Email"].ToString();
                Status = Data["Status"].ToString();
                RC = new RC(Data["RC"].ToString());
                Division = new Division(new Dictionary<string, object> { ["RC"] = RC.Code });
            }
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow Data { get; set; }

        public int ID { get; set; }

        public string Section { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Division Division { get; set; }

        public RC RC { get; set; }

        public string Office { get; set; }

        public string Phone { get; set; }

        public string Cell { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }
    }
}