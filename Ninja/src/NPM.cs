// <copyright file="NPM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="NPM" />
    /// </summary>
    public class NPM
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="NPM"/> class.
        /// </summary>
        public NPM()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NPM"/> class.
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        public NPM(string code)
        {
            Code = code;
            Name = Info.GetNpm(code);
            RPIO = Info.GetNpmRpio(code);
            Title = Info.GetNpmTitle(code);
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

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
            return Code;
        }
    }
}
