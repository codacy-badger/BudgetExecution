USE [C:\USERS\TERRY\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\BUDGETEXECUTION\NINJA\SQLSERVER\R6.MDF]
GO

/****** Object:  Table [dbo].[T7]    Script Date: 4/17/2018 10:26:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T7](
	[BudgetLevel] [text] NULL,
	[DocType] [text] NULL,
	[RPIO] [text] NULL,
	[AH] [text] NULL,
	[BBFY] [text] NULL,
	[Fund] [text] NULL,
	[Org] [text] NULL,
	[RC] [text] NULL,
	[TransferControlNumber] [text] NULL,
	[Quarter] [text] NULL,
	[Date] [text] NULL,
	[Purpose] [text] NULL,
	[From/To] [text] NULL,
	[ProgramProjectCode] [text] NULL,
	[ProgramProjectName] [text] NULL,
	[NpmCode] [text] NULL,
	[BOC] [text] NULL,
	[Amount] [decimal](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

