USE [djk_qg]
GO

/****** Object:  Table [dbo].[z_menu]    Script Date: 2017/12/7 17:50:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[z_menu](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[上级ID] [bigint] NOT NULL,
	[名称] [nchar](50) NULL,
	[表单] [nchar](100) NULL,
	[最大化] [decimal](1, 0) NULL CONSTRAINT [DF_z_menu_最大化]  DEFAULT ((0)),
 CONSTRAINT [PK_z_menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

