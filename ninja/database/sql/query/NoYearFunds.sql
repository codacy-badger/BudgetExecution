SELECT ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, AH AS Org, AhName AS OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName,BOC, BocName, 
	CASE
	WHEN FundCode LIKE 'E%' AND 
		ProgramProjectCode in ("04", "05", "09", "10", "11", "12", "13", "17", "H4") THEN "06J"	
	WHEN FundCode LIKE "E%" AND 
		NpmCode = "B" THEN "06K"
	WHEN FundCode LIKE 'E%' AND 
		ProgramProjectCode in ("24", "79") THEN "06L"
	WHEN FundCode = "T" AND 
		Org LIKE "6A%" OR 
		AH LIKE "6A%" THEN "06L"
	WHEN FundCode LIKE 'TR%' THEN '06L'
	WHEN FundCode LIKE "E%" AND 
		ProgramProjectCode = "14" THEN "06M"
	WHEN FundCode LIKE 'E%' AND 
	ProgramProjectCode = "15" THEN '06F'
	END RC,
	Authority, Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM BudgetLevels
WHERE BudgetLevel = 7 AND 
	BOC NOT IN ('10', '17', '21', '28') AND 
	FundCode NOT IN ("B", "C", "F", "FS3", "H", "ZL", "HD") AND
	Authority > 0 
GROUP BY ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, Org, OrgName,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName, RC,
	Authority, Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance
HAVING RC IS NOT NULL
ORDER BY RC;