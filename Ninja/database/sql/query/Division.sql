

CREATE TABLE "Division " (
	"ID" INTEGER NOT NULL UNIQUE AUTOINCREMENT ID,
	"RC"	TEXT,
	"Title"	TEXT,
	"AllowanceHolderOrg"	TEXT,
	"Org"	TEXT,
	"Code"	TEXT,
	"Name"	TEXT,
    PRIMARY KEY ("ID")
);