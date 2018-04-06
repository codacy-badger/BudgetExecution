namespace Budget
{
    namespace Ninja.Data
    {
        internal interface IControlDocument : ISupplementalAllocation
        {
            #region Properties

            string ControlNumber { get; set; }
            string DateIssued { get; set; }
            string DivisionID { get; set; }
            string Name { get; set; }
            string Purpose { get; set; }

            #endregion

            #region Methods

            string GetDocumentControlNumber();

            int GetNewDocNumber();

            #endregion
        }
    }
}