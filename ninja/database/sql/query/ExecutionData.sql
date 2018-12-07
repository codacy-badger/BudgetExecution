SELECT  ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, Org, OrgName, RC,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Budgeted, Posted, CarryIn, CarryOut,  Commitments, OpenCommitments, Obligations, ULO, Balance
FROM NoYearFunds
WHERE RC IS NOT NULL
UNION ALL
SELECT ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, Org, OrgName, RC,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Budgeted, Posted, CarryIn, CarryOut,  Commitments, OpenCommitments, Obligations, ULO, Balance
FROM ExpiringFunds