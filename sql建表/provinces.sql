USE [djk_qg]
GO

/****** Object:  Table [dbo].[provinces]    Script Date: 2017/12/7 17:50:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[provinces](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[国家ID] [bigint] NULL,
	[省份] [nchar](50) NULL,
	[拼音] [nchar](50) NULL,
 CONSTRAINT [PK_provinces] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

