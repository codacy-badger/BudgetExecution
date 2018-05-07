using System;
using System.Collections.Generic;
using System.Data;


namespace BudgetExecution
{
    
    public interface IBudgetAuthority
    {
        PrcMetric Metric { get; }

        Dictionary<string, string[]> ProgramElements { get; }

        //Properties
        DataTable Table { get; }

        //Methods
        DataTable FilterTable(DataTable table, string column, string filter);

        string[] GetCodes(DataTable table, string column);

        Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

        decimal[] GetMetrics(DataTable table);

        PRC[] GetPrcArray(DataTable table);

        Dictionary<string, string[]> GetProgramElements(DataTable table);

        decimal GetTotal(DataTable table);
    }
    
}