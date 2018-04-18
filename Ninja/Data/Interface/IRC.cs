namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IRC
            {
                //Properties
                string Code { get; }

                string ID { get; }
                string Name { get; }

                //Methods
                string ToString();
            }
        }
    }
}