namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class NPM
    {
        // CONSTRUCTORS
        public NPM(HQ code)
        {
            Code = code.ToString();
        }

        public NPM(string code)
        {
            Code = code;
        }

        // PROPERTIES
        public string Code { get; }

        public string Name { get; set; }

        public string RPIO { get; set; }

        public string Title { get; set; }

        // METHODS
        Dictionary<string, object> GetParameter(string code)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}