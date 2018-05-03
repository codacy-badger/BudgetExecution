namespace Budget.Ninja.Data
{
    public class Org
    {
        //Constructors
        public Org()
        {

        }
        public Org(string code)
        {
            Code = code;
            Name = Info.DivisionName(code);
            ID = Info.GetDivisionMailCode(code);
        }

        //Properties
        public string Code { get; }
        public string ID { get; }
        public string Name { get; }

        //Methods
        public override string ToString()
        {
            return Code;
        }

    }
}