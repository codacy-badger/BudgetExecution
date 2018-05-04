USE [C:\USERS\TERRY\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\BUDGETEXECUTION\NINJA\SQLSERVER\R6.MDF]
GO

/****** Object:  Table [dbo].[O6]    Script Date: 4/17/2018 10:25:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[O6](
	[BudgetLevel] [text] NULL,
	[RPIO] [text] NULL,
	[BFY] [text] NULL,
	[Fund] [text] NULL,
	[Org] [text] NULL,
	[RC] [text] NULL,
	[NPM] [text] NULL,
	[NpmName] [text] NULL,
	[Code] [text] NULL,
	[ProgramProjectCode] [text] NULL,
	[ProgramProjectName] [text] NULL,
	[ProgramArea] [text] NULL,
	[ProgramAreaName] [text] NULL,
	[BOC] [text] NULL,
	[Authority] [decimal](18, 0) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

