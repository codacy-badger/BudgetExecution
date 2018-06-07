

CREATE TABLE "FTE" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"BudgetLevel"	TEXT,
	"RPIO"	TEXT DEFAULT '06',
	"BFY"	TEXT,
	"Fund"	TEXT,
	"FundName"	TEXT,
	"BOC"	TEXT DEFAULT '17',
	"BocName"	TEXT DEFAULT 'FTE',
	"Org"	TEXT,
	"RC"	TEXT,
	"DivisionName"	TEXT,
	"Code"	TEXT,
	"Amount"	NUMERIC,
	"SubProject"	TEXT,
	"NPM"	TEXT,
	"NpmCode"	TEXT,
	"ProgramProjectCode"	TEXT,
	"ProgramProjectName"	TEXT,
	"ProgramArea"	TEXT,
	"ProgramAreaName"	TEXT,
	"Goal"	TEXT,
	"GoalName"	TEXT,
	"Objective"	TEXT,
	"ObjectiveName"	TEXT,
	FOREIGN KEY("ID") REFERENCES "PRC"("ID")
);