// <copyright file="NPM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    public struct NPM
    {
        public NPM(string code)
        {
            Code = code;
            Name = Info.GetNpm(code);
            RPIO = Info.GetNpmRpio(code);
            Title = Info.GetNpmTitle(code);
        }

        public string Code { get; }

        public string Name { get; set; }

        public string RPIO { get; set; }

        public string Title { get; set; }

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
