USE [C:\USERS\TERRY\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\BUDGETEXECUTION\NINJA\SQLSERVER\R6.MDF]
GO

/****** Object:  Table [dbo].[B6]    Script Date: 4/17/2018 10:23:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[B6](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ControlNumber] [text] NULL,
	[DivsionName] [text] NULL,
	[FiscalYear] [text] NULL,
	[DivisionId] [text] NULL,
	[Awards] [text] NULL,
	[Org] [text] NULL,
	[OverTime] [text] NULL,
	[TimeOffAwards] [text] NULL,
	[Training] [text] NULL,
	[Purpose] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

