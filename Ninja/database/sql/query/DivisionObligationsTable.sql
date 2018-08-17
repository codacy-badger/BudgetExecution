CREATE VIEW "DivisionTravelObligations" AS
SELECT *
FROM TravelObligations
GROUP BY BFY, Fund, Code, Org, RC, BOC, FOC