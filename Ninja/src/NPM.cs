// <copyright file="NPM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace BudgetExecution
{
    public class NPM
    {
        // CONSTRUCTORS
        public NPM(HQ code)
        {
            Code = code.ToString();
        }

        public NPM(string code)
        {
            Code = code;
        }

        // PROPERTIES
        public string Code { get; }

        public string Name { get; set; }

        public string RPIO { get; set; }

        public string Title { get; set; }

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
