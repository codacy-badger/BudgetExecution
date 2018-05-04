USE [C:\USERS\TERRY\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\BUDGETEXECUTION\NINJA\SQLSERVER\R6.MDF]
GO

/****** Object:  Table [dbo].[P6]    Script Date: 4/17/2018 10:16:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[P6](
	[ID] [bigint] NOT NULL,
	[BudgetLevel] [text] NULL,
	[RPIO] [text] NULL,
	[BFY] [text] NULL,
	[Fund] [text] NULL,
	[FundName] [text] NULL,
	[BOC] [text] NULL,
	[BocName] [text] NULL,
	[Org] [text] NULL,
	[RC] [text] NULL,
	[DivisionName] [text] NULL,
	[Code] [text] NULL,
	[Amount] [decimal](18, 0) NULL,
	[SubProject] [text] NULL,
	[NPM] [text] NULL,
	[NpmCode] [text] NULL,
	[ProgramProjectCode] [text] NULL,
	[ProgramProjectName] [text] NULL,
	[ProgramArea] [text] NULL,
	[ProgramAreaName] [text] NULL,
	[Goal] [text] NULL,
	[GoalName] [text] NULL,
	[Objective] [text] NULL,
	[ObjectiveName] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


