CREATE TABLE "Award" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Type"	TEXT,
	"RC"	TEXT,
	"DivisionName"	TEXT,
	"Fund"	TEXT,
	"FundName"	TEXT,
	"BFY"	TEXT,
	"BOC"	TEXT,
	"BocName"	TEXT,
	"Amount"	NUMERIC,
	"Time"	TEXT
);