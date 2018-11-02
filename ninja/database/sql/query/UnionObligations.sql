SELECT ID, BudgetLevel, RPIO, BFY, Fund, FundName, NpMCode, NPM, AH, AhName, RC, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM ExpiringFunds
UNION
SELECT ID, BudgetLevel, RPIO, BFY, Fund, FundName, NpmCode, NPM, AH, AhName, AH AS Org, AhName AS OrgName,
	RC, Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM NoYearFunds;