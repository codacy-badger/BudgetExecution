namespace Budget.Ninja.Data
{
    public class NPM
    {
        //Constructors
        public NPM(HQ code)
        {
            Code = code.ToString();
        }
        public NPM(string code)
        {
            Code = code;
        }

        //Properties
        public string Code { get; }
        public string Name { get; set; }
        public string RPIO { get; set; }
        public string Title { get; set; }

        //Methods
        public override string ToString()
        {
            return Code;
        }
    }
}