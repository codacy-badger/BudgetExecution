CREATE VIEW `EPM` AS SELECT * FROM P6 WHERE FUND LIKE 'B%' Group by BFY, Fund, Org, Code, BOC, Amount Order by BFY, Fund, Org, Code, BOC, BudgetLevel asc