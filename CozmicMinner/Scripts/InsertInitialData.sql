USE [master]
GO

/****** Object:  Database [CozmicDataBase]    Script Date: 1/11/2018 8:02:00 PM ******/
DROP DATABASE [CozmicDataBase]
GO

/****** Object:  Database [CozmicDataBase]    Script Date: 1/11/2018 8:02:00 PM ******/
CREATE DATABASE [CozmicDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CozmicDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL04\MSSQL\DATA\CozmicDataBase.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CozmicDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL04\MSSQL\DATA\CozmicDataBase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [CozmicDataBase] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CozmicDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CozmicDataBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CozmicDataBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CozmicDataBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CozmicDataBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CozmicDataBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [CozmicDataBase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CozmicDataBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CozmicDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CozmicDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CozmicDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CozmicDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CozmicDataBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CozmicDataBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CozmicDataBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CozmicDataBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CozmicDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CozmicDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CozmicDataBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CozmicDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CozmicDataBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CozmicDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CozmicDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CozmicDataBase] SET RECOVERY FULL 
GO

ALTER DATABASE [CozmicDataBase] SET  MULTI_USER 
GO

ALTER DATABASE [CozmicDataBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CozmicDataBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CozmicDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CozmicDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [CozmicDataBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CozmicDataBase] SET  READ_WRITE 
GO


USE [CozmicMining]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerRegions]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers] DROP CONSTRAINT [FK_MiningServers_ServerRegions]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerMinerTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers] DROP CONSTRAINT [FK_MiningServers_ServerMinerTypes]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerRegion_RegionLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ServerRegions] DROP CONSTRAINT [DF_ServerRegion_RegionLastUpdate]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerRegion_RegionID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ServerRegions] DROP CONSTRAINT [DF_ServerRegion_RegionID]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_MiningServer_ServerLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MiningServers] DROP CONSTRAINT [DF_MiningServer_ServerLastUpdate]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_MiningServer_ServerID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MiningServers] DROP CONSTRAINT [DF_MiningServer_ServerID]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerMinerTypes_RegionLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MinerTypes] DROP CONSTRAINT [DF_ServerMinerTypes_RegionLastUpdate]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerMinerTypes_MinerID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MinerTypes] DROP CONSTRAINT [DF_ServerMinerTypes_MinerID]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Bookmarks__Bookm__4BAC3F29]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Bookmarks] DROP CONSTRAINT [DF__Bookmarks__Bookm__4BAC3F29]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Bookmarks__Bookm__4AB81AF0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Bookmarks] DROP CONSTRAINT [DF__Bookmarks__Bookm__4AB81AF0]
END

GO
/****** Object:  Table [dbo].[ServerRegions]    Script Date: 1/13/2018 9:20:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServerRegions]') AND type in (N'U'))
DROP TABLE [dbo].[ServerRegions]
GO
/****** Object:  Table [dbo].[MiningServers]    Script Date: 1/13/2018 9:20:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MiningServers]') AND type in (N'U'))
DROP TABLE [dbo].[MiningServers]
GO
/****** Object:  Table [dbo].[MinerTypes]    Script Date: 1/13/2018 9:20:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MinerTypes]') AND type in (N'U'))
DROP TABLE [dbo].[MinerTypes]
GO
/****** Object:  Table [dbo].[Bookmarks]    Script Date: 1/13/2018 9:20:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookmarks]') AND type in (N'U'))
DROP TABLE [dbo].[Bookmarks]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MinerTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MinerTypes](
	[MinerID] [uniqueidentifier] NOT NULL,
	[MinerTypeID] [int] NULL,
	[MinerName] [nvarchar](max) NULL,
	[MinerDescription] [nvarchar](max) NULL,
	[MinerStatus] [int] NULL,
	[MinerCreateDate] [datetime] NULL,
	[MinerLastUpdate] [datetime] NULL,
 CONSTRAINT [PK_ServerMinerTypes] PRIMARY KEY CLUSTERED 
(
	[MinerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MiningServers]    Script Date: 1/13/2018 9:20:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MiningServers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MiningServers](
	[ServerID] [uniqueidentifier] NOT NULL,
	[RegionID] [uniqueidentifier] NULL,
	[MinerID] [uniqueidentifier] NULL,
	[ServerName] [nvarchar](250) NULL,
	[ServerDescription] [nvarchar](max) NULL,
	[ServerPort] [int] NULL,
	[ServerAddress] [nvarchar](300) NULL,
	[ServerStatus] [int] NULL,
	[ServerCreateDate] [datetime] NULL,
	[ServerLastUpdate] [datetime] NULL,
 CONSTRAINT [PK_MiningServer] PRIMARY KEY CLUSTERED 
(
	[ServerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ServerRegions]    Script Date: 1/13/2018 9:20:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServerRegions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ServerRegions](
	[RegionID] [uniqueidentifier] NOT NULL,
	[RegionTypeID] [int] NULL,
	[RegionName] [nvarchar](max) NULL,
	[RegionDescription] [nvarchar](max) NULL,
	[RegionStatus] [int] NULL,
	[RegionCreateDate] [datetime] NULL,
	[RegionLastUpdate] [datetime] NULL,
 CONSTRAINT [PK_ServerRegion] PRIMARY KEY CLUSTERED 
(
	[RegionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
INSERT [dbo].[MinerTypes] ([MinerID], [MinerTypeID], [MinerName], [MinerDescription], [MinerStatus], [MinerCreateDate], [MinerLastUpdate]) VALUES (N'd900dff9-78a1-4b04-b92e-9d534893d4a0', 1, N'EthMiner', N'Eth Miner', 1, CAST(N'2018-01-11 20:01:30.310' AS DateTime), CAST(N'2018-01-11 20:01:30.310' AS DateTime))
GO
INSERT [dbo].[MinerTypes] ([MinerID], [MinerTypeID], [MinerName], [MinerDescription], [MinerStatus], [MinerCreateDate], [MinerLastUpdate]) VALUES (N'bd315d76-5d1e-4a2d-9fd7-df8b2afddba6', 2, N'ClaymoresMiner', N' Claymores Miner', 1, CAST(N'2018-01-11 20:01:30.313' AS DateTime), CAST(N'2018-01-11 20:01:30.313' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'a81794ea-c275-41af-b05b-1cb60dad28e3', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a122211', N'a', 444, N'asia1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:28:01.203' AS DateTime), CAST(N'2018-01-12 21:28:01.527' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'e9518dfb-6a8e-4b08-b141-5a2e855d3df1', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a12', N'a12', 444, N'eu1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:31:29.220' AS DateTime), CAST(N'2018-01-12 21:31:29.220' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'b6edabcb-cfd7-47e8-8457-66ddaca9f0d2', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'BNNNMM', N'a123', 444, N'asia1.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:32:11.097' AS DateTime), CAST(N'2018-01-12 21:32:11.097' AS DateTime))
GO
INSERT [dbo].[MiningServers] ([ServerID], [RegionID], [MinerID], [ServerName], [ServerDescription], [ServerPort], [ServerAddress], [ServerStatus], [ServerCreateDate], [ServerLastUpdate]) VALUES (N'26dc648f-642b-4fe7-b1a5-b5ba6f38157c', N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', N'd900dff9-78a1-4b04-b92e-9d534893d4a0', N'a1', N'a1', 444, N'us2.ethermine.org.org:444', 1, CAST(N'2018-01-12 21:29:49.603' AS DateTime), CAST(N'2018-01-12 21:29:49.603' AS DateTime))
GO
INSERT [dbo].[ServerRegions] ([RegionID], [RegionTypeID], [RegionName], [RegionDescription], [RegionStatus], [RegionCreateDate], [RegionLastUpdate]) VALUES (N'a87f8ac0-60df-4ff5-9dc7-6230ecb105e2', 1, N'Asia', N'Asia', 1, CAST(N'2018-01-11 20:01:30.313' AS DateTime), CAST(N'2018-01-11 20:01:30.313' AS DateTime))
GO
INSERT [dbo].[ServerRegions] ([RegionID], [RegionTypeID], [RegionName], [RegionDescription], [RegionStatus], [RegionCreateDate], [RegionLastUpdate]) VALUES (N'1882d77b-4f52-4dfc-9912-aadc6785c15d', 2, N'NorthEastAmerica', N'North America (East)', 1, CAST(N'2018-01-11 20:01:30.323' AS DateTime), CAST(N'2018-01-11 20:01:30.323' AS DateTime))
GO
INSERT [dbo].[ServerRegions] ([RegionID], [RegionTypeID], [RegionName], [RegionDescription], [RegionStatus], [RegionCreateDate], [RegionLastUpdate]) VALUES (N'b31e8e62-e408-41be-861b-b873dab15c17', 3, N'NorthWestAmerica', N'North America (West)', 1, CAST(N'2018-01-11 20:01:30.327' AS DateTime), CAST(N'2018-01-11 20:01:30.327' AS DateTime))
GO
INSERT [dbo].[ServerRegions] ([RegionID], [RegionTypeID], [RegionName], [RegionDescription], [RegionStatus], [RegionCreateDate], [RegionLastUpdate]) VALUES (N'b77e9e4b-2c52-4af4-be17-e6feb6345a34', 4, N'Europe', N'France', 1, CAST(N'2018-01-11 20:01:30.327' AS DateTime), CAST(N'2018-01-11 20:01:30.327' AS DateTime))
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Bookmarks__Bookm__4AB81AF0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Bookmarks] ADD  DEFAULT (newid()) FOR [BookmarkID]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Bookmarks__Bookm__4BAC3F29]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Bookmarks] ADD  DEFAULT (getdate()) FOR [BookmarkLastUpdate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerMinerTypes_MinerID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MinerTypes] ADD  CONSTRAINT [DF_ServerMinerTypes_MinerID]  DEFAULT (newid()) FOR [MinerID]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerMinerTypes_RegionLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MinerTypes] ADD  CONSTRAINT [DF_ServerMinerTypes_RegionLastUpdate]  DEFAULT (getdate()) FOR [MinerLastUpdate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_MiningServer_ServerID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MiningServers] ADD  CONSTRAINT [DF_MiningServer_ServerID]  DEFAULT (newid()) FOR [ServerID]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_MiningServer_ServerLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MiningServers] ADD  CONSTRAINT [DF_MiningServer_ServerLastUpdate]  DEFAULT (getdate()) FOR [ServerLastUpdate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerRegion_RegionID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ServerRegions] ADD  CONSTRAINT [DF_ServerRegion_RegionID]  DEFAULT (newid()) FOR [RegionID]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ServerRegion_RegionLastUpdate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ServerRegions] ADD  CONSTRAINT [DF_ServerRegion_RegionLastUpdate]  DEFAULT (getdate()) FOR [RegionLastUpdate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerMinerTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers]  WITH CHECK ADD  CONSTRAINT [FK_MiningServers_ServerMinerTypes] FOREIGN KEY([MinerID])
REFERENCES [dbo].[MinerTypes] ([MinerID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerMinerTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers] CHECK CONSTRAINT [FK_MiningServers_ServerMinerTypes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerRegions]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers]  WITH CHECK ADD  CONSTRAINT [FK_MiningServers_ServerRegions] FOREIGN KEY([RegionID])
REFERENCES [dbo].[ServerRegions] ([RegionID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MiningServers_ServerRegions]') AND parent_object_id = OBJECT_ID(N'[dbo].[MiningServers]'))
ALTER TABLE [dbo].[MiningServers] CHECK CONSTRAINT [FK_MiningServers_ServerRegions]
GO
