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
                string Name { get; }
                string ID { get; }

                #endregion

                #region Methods

                string ToString( );

                #endregion
            }
        }
    }
}