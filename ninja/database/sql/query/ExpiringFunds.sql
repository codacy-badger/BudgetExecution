SELECT ID, BudgetLevel, RPIO, BFY, Fund, FundName, NpMCode, NPM, AH, AhName, RC, DivisionName, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority,  Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM BudgetLevels
WHERE BOC NOT IN ('10', '17') AND BudgetLevel = '8' AND Authority > '.1'
GROUP BY BFY, Fund, Org, Code, BOC, RC;