SELECT ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpMCode, NPM, AH, AhName, RC, DivisionName, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority,  Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM BudgetLevels
WHERE BOC NOT IN ('10', '17') AND 
	BudgetLevel = '8' AND 
	FundCode IN ('B', 'T', 'F', 'H', 'ZL') AND 
	Authority > 0
GROUP BY  ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpMCode, NPM, AH, AhName, RC, DivisionName, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority,  Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance