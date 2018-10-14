namespace BudgetExecution
{
    public interface IAccount
    {
        // PROPERTIES
        string Code { get; }

        string Goal { get; }

        string NPM { get; }

        string Objective { get; }

        string ProgramProjectCode { get; }

        // METHODS
        string GetCode();

        string GetGoal();

        string GetGoalName(string code);

        string GetNpmCode();

        string GetObjective();

        string GetObjectiveName(string code);

        string GetProgramProjectCode();
    }
}
