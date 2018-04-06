namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IRC
            {
                #region Properties

                string Code { get; }
                string ID { get; }
                string Name { get; }

                #endregion

                #region Methods

                string ToString();

                #endregion
            }
        }
    }
}