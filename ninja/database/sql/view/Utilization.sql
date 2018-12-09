CREATE VIEW `Utilization` AS SELECT ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, Org, OrgName, RC, 
CASE 
WHEN RC = '06A' THEN 'REGIONAL ADMINISTRATOR' 
WHEN RC = '06C' THEN 'MANAGEMENT DIVISION' 
WHEN RC = '06D' THEN 'REGIONAL COUNSEL' 
WHEN RC = '06L' THEN 'SUPERFUND DIVISION' 
WHEN RC = '06J' THEN 'MULTIMEDIA DIVISION' 
WHEN RC = '06M' THEN 'ENFORCEMENT DIVISION' 
WHEN RC = '06K' THEN 'WATER DIVISION' 
WHEN RC = '06N' THEN 'WORKFORCE SUPPORT' 
WHEN RC = '06G' THEN 'WORKING CAPTIAL FUND' 
WHEN RC = '06F' THEN 'ENFORCEMENT DIVISION' 
WHEN RC = '06X' THEN 'EXTERNAL AFFAIRS' 
WHEN RC = '06R' THEN 'REGIONAL RESERVE' 
END DivisionName, Code, ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName, 
    Authority, Budgeted, Posted, CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance 
FROM NoYearFunds 
WHERE RC IS NOT NULL 
UNION ALL 
SELECT ID, BudgetLevel, RPIO, BFY, FundCode, FundName, NpmCode, NPM, AH, AhName, Org, OrgName, RC, DivisionName, Code,
     ProgramProjectCode, ProgramProjectName, ProgramArea, ProgramAreaName, BOC, BocName, Authority, Budgeted, Posted, 
     CarryIn, CarryOut, Commitments, OpenCommitments, Obligations, ULO, Balance 
FROM ExpiringFunds;