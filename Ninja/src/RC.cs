// <copyright file="RC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="RC" />
    /// </summary>
    public struct RC
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RC"/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        public RC(string code)
        {
            Code = code;
            Input = GetParameter(code);
            Name = Info.DivisionName(code);
            ID = Info.GetDivisionMailCode(code);
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the ID
        /// </summary>
        public string ID { get; }

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name { get; }

        public Dictionary<string, object> Input { get; set; }

        // METHODS
        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        /// The GetParameter
        /// </summary>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
        public static Dictionary<string, object> GetParameter(string code)
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
    }
}
