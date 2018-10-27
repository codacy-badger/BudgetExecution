SELECT ID, BudgetLevel, RPIO, BFY, Fund, FundName, NPM, NpmName, AH, AhName, RC, DivisionName, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM BudgetLevels
WHERE BOC NOT IN ('10', '17') AND BudgetLevel = '8' AND Fund = 'B' AND Authority > '.1'
GROUP BY BFY, Fund, Org, Code, BOC, RC;