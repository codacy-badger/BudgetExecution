CREATE VIEW `OIL` AS SELECT * FROM P6 WHERE FUND LIKE 'H%' Group by BFY, Fund, Org, Code, BOC, Amount Order by BFY, Fund, Org, Code, BOC, BudgetLevel asc