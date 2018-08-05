CREATE TABLE 'DivisionObligations' 
IF NOT EXISTS
AS SELECT ID, BFY, Fund, FundName, Org, RC, DivisionName, Code, ProgramProjectCode, ProgramProjectName,
    SubProject, ProgramArea, ProgramAreaName, DCN, BOC, BocName, FOC, FocName, System, PurchaseRequest, SiteProjectCode,
    SiteProjectName, CommitmentDate, sum(Obligations) AS Obligations 
FROM Obligations
WHERE BOC NOT LIKE '1%'
GROUP BY BFY, Fund, Code, Org, RC, BOC