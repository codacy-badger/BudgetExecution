
CREATE TABLE "WQ" ( 
    "ID" INTEGER NOT NULL UNIQUE,
    "BudgetLevel" TEXT DEFAULT "8", 
    "RPIO" TEXT DEFAULT "06",
    "BFY" TEXT,
    "Fund" TEXT,
    "FundName" TEXT,
    "BOC" TEXT,
    "BocName" TEXT,
    "Org" TEXT,
    "RC" TEXT DEFAULT "06K",
    "DivisionName" TEXT,
    "Code" TEXT,
    "Amount" NUMERIC, 
    "SubProject" TEXT, 
    "NPM" TEXT, 
    "NpmCode" TEXT, 
    "ProgramProjectCode" TEXT, 
    "ProgramProjectName" TEXT, 
    "ProgramArea" TEXT, 
    "ProgramAreaName" TEXT, 
    "Goal" TEXT, 
    "GoalName" TEXT, 
    "Objective" TEXT, 
    "ObjectiveName" TEXT
    FOREIGN KEY("ID") REFERENCES "PRC"("ID"),
    PRIMARY KEY("ID") ); 