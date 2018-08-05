CREATE TABLE "Account" (
	"ID"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Fund"	TEXT,
	"FundName"	TEXT,
	"Org"	TEXT,
	"Code"	TEXT,
	"ProgramProjectCode"	TEXT,
	"ProgramProjectName"	TEXT,
	"ProgramArea"	TEXT,
	"ProgramAreaName"	TEXT,
	"Goal"	TEXT,
	"GoalName"	TEXT,
	"Objective"	TEXT,
	"ObjectiveName"	TEXT
);