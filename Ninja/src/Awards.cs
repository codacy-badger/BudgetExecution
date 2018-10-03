using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace BudgetExecution
{
    public class Awards
    {
        // CONSTRUCTORS
        public Awards()
        {
        }

        public Awards(Source source = Source.Awards, Provider provider = Provider.SQLite)
        {
            Source = source;
            Provider = provider;
            Table = new DataBuilder(source, provider).GetDataTable();
        }

        // PROPERTIES
        public Source Source { get; set; } 

        public Provider Provider { get; set; }

        public DataTable Table { get; set; }

        // METHODS
    }

}
