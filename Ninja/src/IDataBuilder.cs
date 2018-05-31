﻿using System.Data;

namespace BudgetExecution
{
    public interface IDataBuilder
    {

        //Properties
        Query Query { get; }
        DataTable Table { get; }
        DataRow[] DataRecords { get; }

        //Methods
        DataTable GetDataTable();
        DataRow[] GetDataRecords(DataTable table);
    }
        
}