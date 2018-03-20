using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    namespace Ninja.Data
    {
        interface IControlDocument : ISupplementalAllocation
        {
            #region Properties

            string Name { get; set; }
            string DivisionID { get; set; }
            string ControlNumber { get; set; }
            string DateIssued { get; set; }
            string Purpose { get; set; }

            #endregion

            #region Methods

            string GetDocumentControlNumber( );
            int GetNewDocNumber( );

            #endregion
        }
    }

}
