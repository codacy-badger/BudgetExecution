// <copyright file="BOC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="BOC" />
    /// </summary>
    public struct BOC
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref=""/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        public BOC(string code)
        {
            Code = code;
            Name = Info.GetBocName(code);
            Value = 0m;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=""/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        /// <param name="amount">The amount<see cref="decimal"/></param>
        public BOC(string code, decimal amount)
        {
            Code = code;
            Name = Info.GetBocName(code);
            Value = amount;
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the Value
        /// </summary>
        public decimal Value { get; }

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
        /// The GetValue
        /// </summary>
        /// <param name="prc">The prc<see cref="PRC"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        public decimal GetValue(PRC prc)
        {
            return prc.Amount;
        }

        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return Code;
        }
    }
}
