// <copyright file="Org.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace BudgetExecution
{
    public class Org
    {
        // CONSTRUCTORS
        public Org() { }

        public Org(string code)
        {
            Code = code;
            Name = Info.DivisionName(code);
            ID = Info.GetDivisionMailCode(code);
        }

        // PROPERTIES
        public string Code { get; }

        public string ID { get; }

        public string Name { get; }

        // METHODS
        private Dictionary<string, object> GetParameter(string code)
        {
            try
            {
                return new Dictionary<string, object> { ["Code"] = code };
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}
