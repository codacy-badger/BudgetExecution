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
                string Objective { get; }
                string NpmCode { get; }
                string ProgramProjectCode { get; }

                #endregion properties

                #region Methods

                string GetGoal( );

                string GetGoalName(string code);

                string GetObjective( );

                string GetObjectiveName(string code);

                string GetNpmCode( );

                string GetCode( );

                string GetProgramProjectCode( );

                #endregion Methods
            }
        }
    }
}