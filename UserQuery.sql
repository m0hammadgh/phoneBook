USE [Contact_DB]
GO

/****** Object:  Table [dbo].[User]    Script Date: 7/22/2019 12:55:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[LastName] [nvarchar](150) NOT NULL,
	[NationalCode] [varchar](150) NULL,
	[BirthDate] [date] NULL,
	[Address] [varchar](250) NULL,
	[HomeNumber] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[ProfilePic] [varchar](150) NULL,
	[CityCode] [varchar](150) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

