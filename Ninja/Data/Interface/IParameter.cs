namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IParameter
            {
                string RPIO { get; }
                string BFY { get; }
                string Fund { get; }
                string Org { get; }
                string RC { get; }
                string BOC { get; }
                string Code { get; }
            }
        }
    }
}