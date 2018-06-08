namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;


    public interface IBudgetAuthority
    {

        // PROPERTIES
        DataTable Table { get; }

        PrcMetric Metric { get; }

        decimal Amount { get; }

        Dictionary<string, string[]> ProgramElements { get; }

        // METHODS
        DataTable FilterTable(DataTable table, string column, string filter);

        string[] GetCodes(DataTable table, string column);

        Tuple<DataTable, PRC[], decimal, int> GetDataValues(DataTable table, string column, string filter);

        decimal[] GetMetrics(DataTable table);

        PRC[] GetPrcArray(DataTable table);

        Dictionary<string, string[]> GetProgramElements(DataTable table);

        decimal GetTotal(DataTable table);
    }

}