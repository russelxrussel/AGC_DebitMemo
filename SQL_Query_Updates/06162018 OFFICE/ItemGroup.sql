USE [AGC]
GO

/****** Object:  Table [UTIL].[ItemGroup_RF]    Script Date: 6/16/2018 10:43:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [UTIL].[ItemGroup_RF](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[groupCode] [nvarchar](3) NOT NULL,
	[groupName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ItemGroup_RF] PRIMARY KEY CLUSTERED 
(
	[groupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


