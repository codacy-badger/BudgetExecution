SELECT ID, BudgetLevel, RPIO, BFY, Fund, FundName, NpmCode, NPM, AH, AhName, AH AS Org, AhName AS OrgName,
	CASE
	WHEN Org LIKE "6A%" THEN "06L"
	WHEN Org = "06A" THEN Org
	WHEN Org = "06J" THEN Org
	WHEN Org = "06C" THEN Org
	WHEN Org = "06M" THEN Org
	WHEN Org = "06D" THEN Org
	WHEN Org = "06F" THEN Org
	WHEN Org = "06G" THEN Org
	WHEN Org = "06R" THEN Org
	WHEN Org = "06K" THEN Org
	WHEN Org = "06L" THEN Org
	WHEN Org LIKE "06LA%" THEN "06L"
	WHEN Org = "06X" THEN Org
	WHEN Org = "06N" THEN Org	
	WHEN Org LIKE "06_K%" THEN "06K"
	WHEN Org LIKE "06K0X%" THEN "06K"
	WHEN Org LIKE "06K%" THEN "06K"
	WHEN Org LIKE "065K" THEN "06K"
	WHEN Org LIKE "06J%" THEN "06J"
	WHEN Org LIKE "0600%" THEN "06L"
	WHEN Org LIKE "06_Z" AND 
		ProgramProjectCode in ("14", "11", "04", "05", "08", "09", "10") AND 
		Fund LIKE 'E%' THEN "06J"
	WHEN Org LIKE "06_Z" AND 
		ProgramProjectCode in ("01", "03", "06", "07") AND 
		Fund LIKE 'E%' THEN "06K"
	WHEN NpmCode IN ("A", "C") AND 
		Fund LIKE 'E%' THEN "06J"
	WHEN Fund LIKE 'E%' AND 
		ProgramProjectCode in ("14", "11", "04", "05", "08", "09", "10") AND 
		Fund LIKE 'E%' THEN "06J"
	WHEN Fund LIKE 'E%' AND 
		ProgramProjectCode in ("24", "79") THEN "06L"
	WHEN Fund LIKE 'T%' AND 
		AH LIKE "6A%" OR NPM = "D" THEN "06L"
	WHEN Fund LIKE "ZL" THEN "06K"
	WHEN NpmCode = "E" AND 
		ProgramProjectCode = "14" AND
		Fund LIKE 'E%' THEN "06M"
	WHEN NpmCode = 'E' AND 
		ProgramProjectCode = "12" AND
		Fund LIKE 'E%' THEN "06J"
	WHEN Fund LIKE "E%" AND 
		NpmCode = "B" THEN "06K"
	WHEN Fund LIKE 'E%' AND
		NpmCode IN ("A", "C") THEN '06J'
	WHEN Fund LIKE 'TR%' THEN '06L'
	WHEN Fund LIKE 'F%' THEN '06J'
	WHEN BOC = '38' THEN '06G'
	WHEN Fund LIKE 'H%' AND 
		BOC != '21' THEN '06L'
	WHEN Fund LIKE 'T%' AND 
		BOC != '21' AND 
		NpmCode = 'D' THEN '06L'
	WHEN Fund LIKE 'E%' AND 
	NpmCode = "L" THEN '06F'
	END RC,
	Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName,
	Authority, Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance
FROM BudgetLevels
WHERE BOC NOT IN ('10', '17', '21', '28') AND 
	BudgetLevel = 7 AND 
	Fund != 'B' AND
	Authority != 0
GROUP BY BFY, Fund, RC, Org, Code, BOC
ORDER BY Code;