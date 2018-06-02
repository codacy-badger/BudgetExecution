using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public interface IFund
    {
        // PROPERTIES
        string Code { get; }
        DataTable Data { get; set; }
        string FiscalYear { get; }
        string Name { get; }
        Dictionary<string, object> Parameter { get; }
        string Title { get; }
        string TreasurySymbol { get; }

        // METHODS
        DataTable GetFundDataRecord(Source source, Provider provider, Dictionary<string, object> param);
        Dictionary<string, object> GetFundParameter(string code, string bfy);
        Dictionary<string, object> GetFundProgramData(string code);
        string ToString();
    }
}