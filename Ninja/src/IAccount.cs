
namespace BudgetExecution
{
    public interface IAccount
    {
        //Properties
        string Code { get; }

        string Goal { get; }
        string NpmCode { get; }
        string Objective { get; }
        string ProgramProjectCode { get; }

        //Methods
        string GetCode();

        string GetGoal();

        string GetGoalName(string code);

        string GetNpmCode();

        string GetObjective();

        string GetObjectiveName(string code);

        string GetProgramProjectCode();
    }
        
    
}