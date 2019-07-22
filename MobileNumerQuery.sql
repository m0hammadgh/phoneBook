USE [Contact_DB]
GO

/****** Object:  Table [dbo].[MobileNumbers]    Script Date: 7/22/2019 12:55:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MobileNumbers](
	[NumberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Number] [varchar](150) NULL
) ON [PRIMARY]
GO

