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
    public class RC
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="RC"/> class.
        /// </summary>
        public RC()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RC"/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        public RC(string code)
        {
            Code = code;
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
