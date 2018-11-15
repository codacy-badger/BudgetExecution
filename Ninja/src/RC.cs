// <copyright file="RC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace BudgetExecution
{
    public class RC
    {
        // CONSTRUCTORS
        public RC()
        {
        }

        public RC(string code)
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
