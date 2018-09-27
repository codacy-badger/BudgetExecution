// <copyright file="RC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BudgetExecution
{
    public class RC
    {
        // CONSTRUCTORS
        public RC() { }

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

        private SQLiteParameter[] GetParameter(Dictionary<string, object> p)
        {
            try
            {
                SQLiteParameter[] parms = new SQLiteParameter[p.Count];
                for(int i = 0; i < p.Count; i++)
                {
                    foreach(KeyValuePair<string, object> kvp in p)
                    {
                        parms[i] = new SQLiteParameter(kvp.Key, kvp.Value);
                    }
                }

                return parms;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}
