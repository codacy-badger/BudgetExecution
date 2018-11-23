// <copyright file="IAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the <see cref="IAccount" />
    /// </summary>
    public interface IAccount
    {
        // PROPERTIES
        /// <summary>
        /// Gets the Code
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Goal
        /// </summary>
        string Goal { get; }

        /// <summary>
        /// Gets the NPM
        /// </summary>
        string NPM { get; }

        /// <summary>
        /// Gets the Objective
        /// </summary>
        string Objective { get; }

        /// <summary>
        /// Gets the ProgramProjectCode
        /// </summary>
        string ProgramProjectCode { get; }

        // METHODS
        /// <summary>
        /// The GetCode
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetCode();

        /// <summary>
        /// The GetGoal
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetGoal();

        /// <summary>
        /// The GetGoalName
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        string GetGoalName(string code);

        /// <summary>
        /// The GetNpmCode
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetNpmCode();

        /// <summary>
        /// The GetObjective
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetObjective();

        /// <summary>
        /// The GetObjectiveName
        /// </summary>
        /// <param name="code">The code<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        string GetObjectiveName(string code);

        /// <summary>
        /// The GetProgramProjectCode
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetProgramProjectCode();
    }
}
