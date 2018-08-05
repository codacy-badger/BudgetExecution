

CREATE TABLE "FTE" (
    "ID" INTEGER NOT NULL UNIQUE,
	"BudgetLevel"	TEXT,
    "AH" TEXT DEFAULT "06",
	"RPIO"	TEXT DEFAULT "06",
	"BFY"	TEXT,
	"Fund"	TEXT,
	"FundName"	TEXT,
	"BOC"	TEXT DEFAULT "17"
	"BocName"	TEXT DEFAULT "FTE",
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
    FOREIGN KEY("ID") REFERENCES "PRC"("ID"),
    PRIMARY KEY("ID") ); 
);