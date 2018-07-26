CREATE TABLE IF NOT EXISTS 'DivisionObligations'
AS SELECT BFY, Fund, FundName, Org, RC, DivisionName, Code, ProgramProjectCode, ProgramProjectName, DCN, BOC, BocName, FOC, FocName, CommitmentDate, sum(Obligations) as Obligations
FROM Obligations
WHERE BOC <> '10' 
GROUP BY BFY, Fund, Org, RC, DCN, Code, BOC, FOC