CREATE TABLE 'DivisionTransfers' AS SELECT BFY, DocType, Fund, Date, RC, TransferControlNumber, ProgramProjectCode, BOC, FromTo, sum(Amount) as Amount
FROM Transfers
WHERE BudgetLevel = '8'
GROUP BY  BFY, Fund, Date, TransferControlNumber, RC, ProgramProjectCode, BOC, FromTo, Amount