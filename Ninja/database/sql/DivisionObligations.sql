CREATE TABLE 'DivisionObligations' AS SELECT BFY, Fund, FundName, Org, RC, DivisionName, Code, ProgramProjectCode, ProgramProjectName, DCN, BOC, BocName, FOC, FocName, CommitmentDate, sum(Obligation) as TotalObligations
FROM Obligations
GROUP BY BFY, Fund, Org, RC, DCN, Code, BOC, FOC