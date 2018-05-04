namespace BudgetExecution
{
    public class Fund
    {
        //Constructors
        public Fund(string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Name = Info.GetAppropriationName(code);
            Title = Info.GetAppropriationTitle(code);
            TreasurySymbol = Info.GetTreasurySymbol(code);
        }

        //Properties
        public string Code { get; }
        public string FiscalYear { get; }
        public string Name { get; }
        public string Title { get; }
        public string TreasurySymbol { get; }

        //Methods
        public override string ToString()
        {
            return Code;
        }
    }
}