USE [Students_]
GO
/****** Object:  Table [dbo].[groups]    Script Date: 31.10.2018 14:15:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[group_id] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Studs]    Script Date: 31.10.2018 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Studs](
	[stud_id] [int] IDENTITY(1,1) NOT NULL,
	[stud_name] [varchar](200) NULL,
	[group_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[stud_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[groups] ON 

INSERT [dbo].[groups] ([group_id], [group_name]) VALUES (1, N'group1')
INSERT [dbo].[groups] ([group_id], [group_name]) VALUES (2, N'group2')
INSERT [dbo].[groups] ([group_id], [group_name]) VALUES (3, N'group3')
INSERT [dbo].[groups] ([group_id], [group_name]) VALUES (4, N'group4')
SET IDENTITY_INSERT [dbo].[groups] OFF
SET IDENTITY_INSERT [dbo].[Studs] ON 

INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (1, N'Ivanov H.T', 1)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (2, N'Petrov G.K.', 2)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (3, N'Sokolov D.T.', 3)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (4, N'Shek H.T.', 4)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (5, N'Rezkov H.T', 1)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (6, N'Rutkov B.K.', 2)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (7, N'Smirnov M.T.', 3)
INSERT [dbo].[Studs] ([stud_id], [stud_name], [group_id]) VALUES (8, N'Kurochkin H.T', 4)
SET IDENTITY_INSERT [dbo].[Studs] OFF
ALTER TABLE [dbo].[Studs]  WITH CHECK ADD  CONSTRAINT [fk_groups_id] FOREIGN KEY([group_id])
REFERENCES [dbo].[groups] ([group_id])
GO
ALTER TABLE [dbo].[Studs] CHECK CONSTRAINT [fk_groups_id]
GO
