using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetExecution
{
    public class Division
    {
        // CONSTRUCTORS
        public Division()
        {
        }

        public Division(Source source)
        {
            Name = source.ToString();
            Data = new DataBuilder(Source.Divisions).Table.AsEnumerable()
                                                    .Where(d => d.Field<string>("Source").Equals(source.ToString()))
                                                    .Select(d => d).First();
            ID = Data["ID"].ToString();
            RC = Data["RC"].ToString();
        }

        // PROPERTIES
        public string Title { get; set; }

        public string Code { get; }

        public string ID { get; }

        public string RC { get; }

        public string Name { get; }

        public DataRow Data { get; set; }

        // METHODS
        public override string ToString()
        {
            return Code;
        }

        private Dictionary<string, object> GetParameter()
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = Code };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
