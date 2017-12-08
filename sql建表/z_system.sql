USE [djk_qg]
GO

/****** Object:  Table [dbo].[z_system]    Script Date: 2017/12/7 17:50:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[z_system](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[属性] [int] NOT NULL CONSTRAINT [DF_z_system_属性]  DEFAULT ((0)),
	[值] [int] NOT NULL CONSTRAINT [DF_z_system_值]  DEFAULT ((0)),
	[摘要] [nchar](100) NULL,
 CONSTRAINT [PK_z_system] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

