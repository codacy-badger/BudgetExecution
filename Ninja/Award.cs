using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BudgetExecution;

namespace BudgetExecution
{
    public class Award : IAward
    {
        // CONSTRUCTORS
        public Award()
        {

        }


        //PROPERTIES

        public decimal Awards { get; set; }
        public decimal OverTime { get; set; }
        public int TimeOffAwards { get; set; }

    }
}
