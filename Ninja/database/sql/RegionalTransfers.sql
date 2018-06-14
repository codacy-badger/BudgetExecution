CREATE TABLE "RegionalTransfers" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"BudgetLevel"	TEXT,
	"DocType"	TEXT,
	"RPIO"	TEXT,
	"AH"	TEXT,
	"BFY"	TEXT,
	"Fund"	TEXT,
	"RC"	TEXT,
	"TCN"	TEXT,
	"Qtr"	TEXT,
	"Date"	TEXT,
	"ProgramProjectCode"	TEXT,
	"NPM"	TEXT,
	"FromTo"	TEXT,
	"BOC"	TEXT,
	"Amount"	NUMERIC
);