USE [djk_qg]
GO

/****** Object:  Table [dbo].[city]    Script Date: 2017/12/7 17:49:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[city](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[顺序号] [int] NULL,
	[城市名称] [nchar](50) NOT NULL,
	[拼音] [nchar](50) NULL,
	[国家ID] [nchar](10) NOT NULL,
	[国内编号] [char](20) NOT NULL,
	[纬度] [float] NULL CONSTRAINT [DF_city_纬度]  DEFAULT ((0)),
	[经度] [float] NULL CONSTRAINT [DF_city_经度]  DEFAULT ((0)),
	[省份ID] [nchar](10) NULL,
 CONSTRAINT [PK_city] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

