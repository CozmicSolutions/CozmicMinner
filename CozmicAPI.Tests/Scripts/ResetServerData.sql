USE [CozmicMining]
GO
/****** Object:  Table [dbo].[MiningServers]    Script Date: 1/13/2018 9:20:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MiningServers]') AND type in (N'U'))
BEGIN
    TRUNCATE TABLE [dbo].[MiningServers]
END
GO
/****** Object:  Table [dbo].[Bookmarks]    Script Date: 1/13/2018 9:20:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookmarks]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Bookmarks](
	[BookmarkID] [uniqueidentifier] NOT NULL,
	[Bookmark] [nvarchar](max) NULL,
	[BookmarkDescription] [nvarchar](max) NULL,
	[BookmarkIndex] [int] NULL,
	[BookmarkStatus] [int] NULL,
	[BookmarkCreateDate] [datetime] NULL,
	[BookmarkLastUpdate] [datetime] NULL,
 CONSTRAINT [PK_Bookmarks] PRIMARY KEY CLUSTERED 
(
	[BookmarkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MinerTypes]    Script Date: 1/13/2018 9:20:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'a81794ea-c275-41af-b05b-1cb60dad28e3', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a122211', N'a', 444, N'asia1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:28:01.203' AS DateTime), CAST(N'2018-01-12 21:28:01.527' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'e9518dfb-6a8e-4b08-b141-5a2e855d3df1', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a12', N'a12', 444, N'eu1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:31:29.220' AS DateTime), CAST(N'2018-01-12 21:31:29.220' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'b6edabcb-cfd7-47e8-8457-66ddaca9f0d2', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'BNNNMM', N'a123', 444, N'asia1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:32:11.097' AS DateTime), CAST(N'2018-01-12 21:32:11.097' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'26dc648f-642b-4fe7-b1a5-b5ba6f38157c', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a1', N'a1', 444, N'us2.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:29:49.603' AS DateTime), CAST(N'2018-01-12 21:29:49.603' AS DateTime))
GO
