CREATE VIEW `SUPERFUND` AS SELECT * FROM P6 WHERE FUND LIKE 'T%' Group by BFY, Fund, Org, Code, BOC, Amount Order by BFY, Fund, Org, Code, BOC, BudgetLevel asc