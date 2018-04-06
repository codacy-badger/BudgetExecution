namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IAccount
            {
                #region Properties

                string Code { get; }
                string Goal { get; }
                string NpmCode { get; }
                string Objective { get; }
                string ProgramProjectCode { get; }

                #endregion properties

                #region Methods

                string GetCode();

                string GetGoal();

                string GetGoalName(string code);

                string GetNpmCode();

                string GetObjective();

                string GetObjectiveName(string code);

                string GetProgramProjectCode();

                #endregion Methods
            }
        }
    }
}