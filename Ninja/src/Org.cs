using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class Org
    {
        // CONSTRUCTORS
        public Org()
        {

        }
        public Org(string code)
        {
            Code = code;
            Name = Info.DivisionName(code);
            ID = Info.GetDivisionMailCode(code);
        }

        // PROPERTIES
        public string Code { get; }
        public string ID { get; }
        public string Name { get; }

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