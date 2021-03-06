CREATE TABLE "TravelObligations" ( 
    "ID" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
    "RPIO" TEXT, 
    "BFY" TEXT, 
    "AH" TEXT, 
    "AllowanceHolderName" TEXT, 
    "RC" TEXT, 
    "DivisionName" TEXT, 
    "Org" TEXT, 
    "OrgName" TEXT, 
    "NPM" TEXT, 
    "NpmName" TEXT, 
    "Code" TEXT, 
    "ProgramProjectCode" TEXT, 
    "ProgramProjectName" TEXT, 
    "ProgramArea" TEXT, 
    "ProgramAreaName" TEXT, 
    "SiteProjectCode" TEXT, 
    "SiteSpillID" TEXT, 
    "TravelStartDate" TEXT, 
    "TravelType" TEXT, 
    "TicketNumber" TEXT, 
    "DateProcessed" TEXT, 
    "TravellerName" TEXT, 
    "ModificationDate" TEXT, 
    "DCN" TEXT, 
    "Destination" TEXT, 
    "TravelAuthorizationNumber" TEXT, 
    "SiteProjectName" TEXT, 
    "Amount" NUMERIC );