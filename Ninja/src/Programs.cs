﻿// <copyright file="Programs.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;

    public class Programs 
    {
        // CONSTRUCTORS
        public Programs()
        {
            Source = Source.Programs;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            Records = DbData.DbTable.AsEnumerable().Select(a => a).ToArray();
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        public DataRow[] Records { get; set; }

        public DataRow DbRow { get; set; }

        public int ID { get; set;}

        public string RpioName { get; set; } 

        public string RPIO { get; set; } 

        public string BFY { get; set; }

        public Fund Fund { get; set; }

        public string FundName { get; set; }

        public string AH { get; set; }

        public string AllowanceHolderName { get; set; }
        
        public Org Org { get; set; }

        public string DivisionName { get; set; }

        public string ProgramProjectCode { get; set; } 

        public string ProgramProjectName { get; set; }

        public BOC BOC { get; set; }

        public string BocName { get; set; }
    }
}