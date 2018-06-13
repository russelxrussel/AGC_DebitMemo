USE [AGC]
GO

/****** Object:  Table [UTIL].[Reports_RF]    Script Date: 06/13/2018 12:04:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [UTIL].[Reports_RF](
	[reportID] [int] IDENTITY(1,1) NOT NULL,
	[reportDescription] [nvarchar](100) NOT NULL,
	[reportFileName] [nvarchar](100) NULL,
	[reportGroup] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Reports_RF] PRIMARY KEY CLUSTERED 
(
	[reportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


