// <copyright file="Org.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Org" />
    /// </summary>
    public class Org
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="Org"/> class.
        /// </summary>
        public Org()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Org"/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        public Org(string code)
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
        /// The GetParameter
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
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

        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return ID;
        }
    }
}
