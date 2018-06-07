CREATE TABLE "BudgetDocument" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"FiscalYear"	TEXT DEFAULT 2018,
	"Region"	TEXT DEFAULT 'R06',
	"AH"	TEXT DEFAULT 06,
	"RegionControlNumber"	TEXT,
	"Fund"	TEXT,
	"FundControlNumber"	TEXT,
	"Month"	TEXT,
	"Day"	TEXT,
	"DivisionID"	TEXT,
	"BudgetControlNumber"	INTEGER
);