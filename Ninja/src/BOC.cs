namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class BOC
    {
        // CONSTRUCTORS
        public BOC(string code)
        {
            Code = code;
            Name = Info.GetBocName(code);
            Value = 0m;
        }

        public BOC(string code, decimal amount)
        {
            Code = code;
            Name = Info.GetBocName(code);
            Value = amount;
        }

        // PROPERTIES
        public string Code { get; }

        public string Name { get; }

        public decimal Value { get; }

        // METHODS
        Dictionary<string, object> GetParameter(string code)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code };
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public decimal GetValue(PRC prc)
        {
            return prc.Amount;
        }

        public override string ToString()
        {
            return Code;
        }
    }
}