USE [master]
GO
/****** Object:  Database [Test]    Script Date: 4/8/2018 8:46:36 PM ******/
CREATE DATABASE [Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Test1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Test.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Test_log1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Test_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Test] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Test] SET  MULTI_USER 
GO
ALTER DATABASE [Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Test] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Test] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Test', N'ON'
GO
ALTER DATABASE [Test] SET QUERY_STORE = OFF
GO
USE [Test]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Test]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[name] [varchar](50) NULL,
	[author] [varchar](250) NULL,
	[transType] [int] NULL,
	[valid_from] [datetime] NULL,
	[valid_to] [datetime] NULL,
	[trans_from] [datetime] NULL,
	[trans_to] [datetime] NULL,
	[commitID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch_id] [int] NULL,
	[branch_name] [varchar](50) NULL,
	[transType] [int] NULL,
	[valid_from] [date] NULL,
	[valid_to] [date] NULL,
	[trans_from] [date] NULL,
	[trans_to] [date] NULL,
	[commitPreviousID] [int] NULL,
	[branchPrevious] [varchar](50) NULL,
	[branchHash] [varchar](50) NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commits]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commits](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[date] [datetime] NULL,
	[branchID] [int] NULL,
	[commitPrevious] [varchar](50) NULL,
	[commitHash] [varchar](50) NULL,
 CONSTRAINT [PK_Commits] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NULL,
	[name] [varchar](50) NULL,
	[location] [varchar](250) NULL,
	[transType] [int] NULL,
	[valid_from] [datetime] NULL,
	[valid_to] [datetime] NULL,
	[trans_from] [datetime] NULL,
	[trans_to] [datetime] NULL,
	[commitID] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person_Read]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person_Read](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[person_id] [int] NULL,
	[transType] [int] NULL,
	[valid_from] [datetime] NULL,
	[valid_to] [datetime] NULL,
	[trans_from] [datetime] NULL,
	[trans_to] [datetime] NULL,
	[commitID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionTypes]    Script Date: 4/8/2018 8:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transName] [varchar](50) NULL,
 CONSTRAINT [PK_TransactionTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([id], [book_id], [name], [author], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (1, 1, N'Book 1', N'Author 1', 1, CAST(N'2018-04-08T17:09:10.200' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-08T17:10:06.600' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[Books] ([id], [book_id], [name], [author], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (2, 2, N'Book 2', N'Author 1', 1, CAST(N'2018-04-08T17:09:18.373' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-08T17:10:06.607' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 18)
INSERT [dbo].[Books] ([id], [book_id], [name], [author], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (3, 3, N'Book 3', N'Author 2', 1, CAST(N'2018-04-08T17:09:26.237' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-08T17:10:06.607' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 18)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Branches] ON 

INSERT [dbo].[Branches] ([id], [branch_id], [branch_name], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitPreviousID], [branchPrevious], [branchHash]) VALUES (1, 1, N'master', 1, CAST(N'2018-03-15' AS Date), CAST(N'9999-12-30' AS Date), CAST(N'2018-03-15' AS Date), CAST(N'9999-12-30' AS Date), NULL, N'Null', N'FD2589DA-7202-4CF8-961C-0E1B4DEEFC18')
INSERT [dbo].[Branches] ([id], [branch_id], [branch_name], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitPreviousID], [branchPrevious], [branchHash]) VALUES (2, 2, N'Branch 1', 1, CAST(N'2018-03-24' AS Date), CAST(N'9999-12-30' AS Date), CAST(N'2018-03-24' AS Date), CAST(N'9999-12-30' AS Date), 4, N'FD2589DA-7202-4CF8-961C-0E1B4DEEFC18', N'123459DA-1232-4CF8-961C-0E1B4DEEFC18')
INSERT [dbo].[Branches] ([id], [branch_id], [branch_name], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitPreviousID], [branchPrevious], [branchHash]) VALUES (3, 3, N'Branch 2', 1, CAST(N'2018-04-07' AS Date), CAST(N'9999-12-30' AS Date), CAST(N'2018-04-07' AS Date), CAST(N'9999-12-30' AS Date), 11, N'123459DA-1232-4CF8-961C-0E1B4DEEFC18', N'OO2589DA-7202-4CF8-961C-0E1B4DEEFC18')
INSERT [dbo].[Branches] ([id], [branch_id], [branch_name], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitPreviousID], [branchPrevious], [branchHash]) VALUES (4, 4, N'Branch 3', 1, CAST(N'2018-04-07' AS Date), CAST(N'9999-12-30' AS Date), CAST(N'2018-04-07' AS Date), CAST(N'9999-12-30' AS Date), 7, N'FD2589DA-7202-4CF8-961C-0E1B4DEEFC18', N'4EDA7B27-E4E4-42FB-84D2-8CB804EBA692
')
SET IDENTITY_INSERT [dbo].[Branches] OFF
SET IDENTITY_INSERT [dbo].[Commits] ON 

INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (1, N'Commit 1', CAST(N'2018-04-05T16:13:34.277' AS DateTime), 1, NULL, N'98298AF9-A2CF-43EA-90B6-7396610650DF')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (3, N'Commit 2', CAST(N'2018-04-05T18:39:17.480' AS DateTime), 1, N'98298AF9-A2CF-43EA-90B6-7396610650DF', N'2F6BD958-1FC2-4228-B9BA-6DB0C1537CB9')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (4, N'Commit 3', CAST(N'2018-04-05T18:40:03.900' AS DateTime), 1, N'2F6BD958-1FC2-4228-B9BA-6DB0C1537CB9', N'2440F908-426B-47C1-AA51-B93F7D8CA176')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (5, N'Commit 4', CAST(N'2018-04-05T18:42:10.637' AS DateTime), 1, N'2440F908-426B-47C1-AA51-B93F7D8CA176', N'454DB4CE-1684-4D60-8066-C2EE73BB4669')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (6, N'Commit 5', CAST(N'2018-04-05T20:16:49.343' AS DateTime), 1, N'454DB4CE-1684-4D60-8066-C2EE73BB4669', N'DD003F53-0942-479C-9CBB-C082C252EC2D')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (7, N'Commit 6', CAST(N'2018-04-05T23:47:09.837' AS DateTime), 1, N'DD003F53-0942-479C-9CBB-C082C252EC2D', N'3BB32B73-2BD4-40E2-822E-B2C1C618F07D')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (11, N'Commit 7', CAST(N'2018-04-06T17:42:09.050' AS DateTime), 2, N'2440F908-426B-47C1-AA51-B93F7D8CA176', N'242B760A-8E3B-48E1-8A18-ADEE976B9198')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (13, N'Commit 8', CAST(N'2018-04-06T18:04:34.207' AS DateTime), 2, N'242B760A-8E3B-48E1-8A18-ADEE976B9198', N'E04CEE1B-BF83-46D3-ABB6-18A9879755E4')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (14, N'Commit 9', CAST(N'2018-04-07T12:59:09.300' AS DateTime), 3, N'242B760A-8E3B-48E1-8A18-ADEE976B9198', N'28C8894D-4D28-4090-93AC-A1F496E7FD57')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (15, N'Commit 10', CAST(N'2018-04-07T13:47:51.510' AS DateTime), 3, N'28C8894D-4D28-4090-93AC-A1F496E7FD57', N'119CA6C5-A9BC-45DD-A2FC-A1B68CF50BB9')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (16, N'Commit 11', CAST(N'2018-04-07T15:34:21.233' AS DateTime), 4, N'3BB32B73-2BD4-40E2-822E-B2C1C618F07D', N'51521C2B-C88E-4EAE-ADC4-04280986AE76')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (17, N'Commit 12', CAST(N'2018-04-07T15:40:55.637' AS DateTime), 3, N'119CA6C5-A9BC-45DD-A2FC-A1B68CF50BB9', N'A3C72F8F-9DE9-4A11-9BF8-6A3FFA91773A')
INSERT [dbo].[Commits] ([id], [name], [date], [branchID], [commitPrevious], [commitHash]) VALUES (18, N'Commit 13', CAST(N'2018-04-08T17:10:06.617' AS DateTime), 1, N'3BB32B73-2BD4-40E2-822E-B2C1C618F07D', N'DC0F01BB-35A4-4B29-995A-D61605773183')
SET IDENTITY_INSERT [dbo].[Commits] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (1, 1, N'ismail', N'Turkey', 1, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T16:13:34.270' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), 1)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (2, 2, N'Marek', N'Slovakia', 1, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T16:13:34.270' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), 1)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (3, 1, N'ismail', N'Turkey', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (4, 1, N'ismail', N'aaa', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), CAST(N'2018-04-05T18:40:03.893' AS DateTime), 3)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (5, 2, N'Marek', N'Slovakia', 2, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (6, 2, N'Marek', N'bbbb', 2, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T18:39:17.473' AS DateTime), CAST(N'2018-04-05T18:42:10.630' AS DateTime), 3)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (7, 1, N'ismail', N'aaa', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-05T18:40:03.893' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (8, 1, N'ismail', N'ddd', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T18:40:03.893' AS DateTime), CAST(N'2018-04-06T17:35:23.313' AS DateTime), 4)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (11, 2, N'Marek', N'bbbb', 2, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'2018-04-05T18:42:10.630' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (12, 2, N'Marek', N'Fransa', 2, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T18:42:10.630' AS DateTime), CAST(N'2018-04-05T23:47:09.823' AS DateTime), 5)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (13, 1, N'ismail', N'ddd', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-05T18:42:10.633' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (14, 1, N'ismail', N'İspanya', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T18:42:10.633' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (15, 3, N'Gamze', N'Eskisehir', 1, CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-05T20:16:49.340' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (16, 2, N'Marek', N'Fransa', 3, CAST(N'2010-02-02T16:13:12.000' AS DateTime), CAST(N'2018-04-05T23:47:09.827' AS DateTime), CAST(N'2018-04-05T23:47:09.827' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (28, 4, N'Kamil', N'Fransa', 1, CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-06T17:42:09.030' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 11)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (29, 1, N'ismail', N'İspanya', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-05T18:42:10.633' AS DateTime), CAST(N'2018-04-06T17:42:09.040' AS DateTime), 11)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (30, 1, N'ismail', N'İspanya', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-06T17:42:09.040' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 11)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (31, 1, N'ismail', N'Erzurum', 2, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-06T17:42:09.040' AS DateTime), CAST(N'2018-04-06T18:04:34.200' AS DateTime), 11)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (33, 1, N'ismail', N'Erzurum', 3, CAST(N'1994-07-21T16:12:53.000' AS DateTime), CAST(N'2018-04-06T18:04:34.200' AS DateTime), CAST(N'2018-04-06T18:04:34.200' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 13)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (34, 4, N'Kamil', N'Fransa', 2, CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'2018-04-06T17:42:09.030' AS DateTime), CAST(N'2018-04-07T12:59:09.290' AS DateTime), 14)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (35, 4, N'Kamil', N'Fransa', 2, CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'2018-04-07T12:59:09.290' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 14)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (36, 4, N'Kamil', N'Ceska', 2, CAST(N'2018-04-06T17:41:55.170' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-07T12:59:09.290' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 14)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (37, 5, N'Esra', N'Izmir', 1, CAST(N'2018-04-07T13:47:28.193' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-07T13:47:51.433' AS DateTime), CAST(N'2018-04-07T15:40:55.630' AS DateTime), 15)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (38, 3, N'Gamze', N'Eskisehir', 2, CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'2018-04-05T20:16:49.340' AS DateTime), CAST(N'2018-04-07T15:34:21.223' AS DateTime), 16)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (39, 3, N'Gamze', N'Eskisehir', 2, CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'2018-04-07T15:34:21.223' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 16)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (40, 3, N'Gamze', N'Istanbul', 2, CAST(N'2018-04-05T20:16:15.900' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-07T15:34:21.223' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 16)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (41, 5, N'Esra', N'Izmir', 2, CAST(N'2018-04-07T13:47:28.193' AS DateTime), CAST(N'2018-04-07T13:47:28.193' AS DateTime), CAST(N'2018-04-07T15:40:55.630' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 17)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (42, 5, N'Esra', N'Aydın', 2, CAST(N'2018-04-07T13:47:28.193' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-07T15:40:55.630' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 17)
INSERT [dbo].[Person] ([id], [person_id], [name], [location], [transType], [valid_from], [valid_to], [trans_from], [trans_to], [commitID]) VALUES (43, 6, N'Test Person', N'Test Location', 1, CAST(N'2018-04-08T17:09:39.317' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), CAST(N'2018-04-08T17:10:06.597' AS DateTime), CAST(N'9999-12-30T00:00:00.000' AS DateTime), 18)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[TransactionTypes] ON 

INSERT [dbo].[TransactionTypes] ([id], [transName]) VALUES (1, N'Insert')
INSERT [dbo].[TransactionTypes] ([id], [transName]) VALUES (2, N'Update')
INSERT [dbo].[TransactionTypes] ([id], [transName]) VALUES (3, N'Delete')
SET IDENTITY_INSERT [dbo].[TransactionTypes] OFF
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_valid_to]  DEFAULT (((12)/(30))/(9999)) FOR [valid_to]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_trans_to]  DEFAULT (((12)/(30))/(9999)) FOR [trans_to]
GO
ALTER TABLE [dbo].[Branches]  WITH CHECK ADD  CONSTRAINT [FK_Branches_TransactionTypes] FOREIGN KEY([transType])
REFERENCES [dbo].[TransactionTypes] ([id])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_TransactionTypes]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Commits] FOREIGN KEY([commitID])
REFERENCES [dbo].[Commits] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Commits]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_TransactionTypes] FOREIGN KEY([transType])
REFERENCES [dbo].[TransactionTypes] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_TransactionTypes]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddBook]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_AddBook] @bookName VARCHAR(50),
                                @author   VARCHAR(250),
                                @Valid_from DATETIME
AS
    DECLARE @ID INT

    SET @ID = (SELECT TOP 1 book_id
               FROM   books
               ORDER  BY book_id DESC)

    IF ( @ID IS NULL )
      BEGIN
          SET @ID =0;
      END

    SET @ID= ( @ID + 1 )

    INSERT INTO books
                (book_id,
                 NAME,
                 author,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@ID,
                 @bookName,
                 @author,
                 @Valid_from,
                 '12/30/9999',
                 Getdate(),
                 '12/30/9999',
                 1)  
GO
/****** Object:  StoredProcedure [dbo].[sp_AddBranch]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_AddBranch] @BranchName       VARCHAR(50),
                                @Valid_from       DATETIME,
                                @TransType        INT,
                                @branchPrevious   VARCHAR(50),
                                @branchHash       VARCHAR(50),
                                @commitPreviousID INT
AS
    DECLARE @ID INT

    SET @ID = (SELECT TOP 1 branch_id
               FROM   branches
               ORDER  BY branch_id DESC)
    SET @ID= ( @ID + 1 )

    INSERT INTO branches
                (branch_id,
                 branch_name,
                 transType,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 commitPreviousID,
                 branchPrevious,
                 branchHash)
    VALUES      (@ID,
                 @BranchName,
                 @TransType,
                 @Valid_from,
                 '12/30/9999',
                 Getdate(),
                 '12/30/9999',
                 @commitPreviousID,
                 @branchPrevious,
                 @branchHash)  
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_AddPerson] @PersonName VARCHAR(50),
                                @Location   VARCHAR(250),
                                @Valid_from DATETIME
AS
    DECLARE @ID INT

    SET @ID = (SELECT TOP 1 person_id
               FROM   person
               ORDER  BY person_id DESC)

    IF ( @ID IS NULL )
      BEGIN
          SET @ID =0;
      END

    SET @ID= ( @ID + 1 )

    INSERT INTO person
                (person_id,
                 NAME,
                 location,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@ID,
                 @PersonName,
                 @Location,
                 @Valid_from,
                 '12/30/9999',
                 Getdate(),
                 '12/30/9999',
                 1)  
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBook]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_DeleteBook] @ID       INT,
                                   @BranchID DATETIME
AS
    DECLARE @book_ID INT
    DECLARE @old_validDate DATETIME
    DECLARE @old_author VARCHAR(250)
    DECLARE @old_name VARCHAR(250)
    DECLARE @Trans_from DATETIME

    SELECT @book_ID = book_id,
           @old_validDate = valid_from,
           @old_author = author,
           @old_name = NAME,
           @Trans_from = trans_from
    FROM   Books
    WHERE  id = @ID

    IF NOT EXISTS (SELECT *
                   FROM   Books AS p
                          INNER JOIN commits AS c
                                  ON c.id = p.commitID
                   WHERE  c.branchID = @BranchID)
      BEGIN
          INSERT INTO Books
                      (book_id,
                       NAME,
                       author,
                       valid_from,
                       valid_to,
                       trans_from,
                       trans_to,
                       transType)
          VALUES      (@book_ID,
                       @old_name,
                       @old_author,
                       @old_validDate,
                       '12/30/9999',
                       @Trans_from,
                       '12/30/9999',
                       2)

          SET @ID = Ident_current('book')
      END

    UPDATE Books
    SET    trans_to = Getdate()
    WHERE  id = @ID

    -- Insert For old data
    INSERT INTO Books
                (book_id,
                 NAME,
                 author,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@book_ID,
                 @old_name,
                 @old_author,
                 @old_validDate,
                 Getdate(),
                 Getdate(),
                 '12/30/9999',
                 3)  
GO
/****** Object:  StoredProcedure [dbo].[sp_DeletePerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeletePerson] @ID       INT,
                                   @BranchID DATETIME
AS
    DECLARE @Person_ID INT
    DECLARE @old_validDate DATETIME
    DECLARE @old_location VARCHAR(250)
    DECLARE @old_name VARCHAR(250)
    DECLARE @Trans_from DATETIME

    SELECT @Person_ID = person_id,
           @old_validDate = valid_from,
           @old_location = location,
           @old_name = NAME,
           @Trans_from = trans_from
    FROM   person
    WHERE  id = @ID

    IF NOT EXISTS (SELECT *
                   FROM   person AS p
                          INNER JOIN commits AS c
                                  ON c.id = p.commitID
                   WHERE  c.branchID = @BranchID)
      BEGIN
          INSERT INTO person
                      (person_id,
                       NAME,
                       location,
                       valid_from,
                       valid_to,
                       trans_from,
                       trans_to,
                       transType)
          VALUES      (@Person_ID,
                       @old_name,
                       @old_location,
                       @old_validDate,
                       '12/30/9999',
                       @Trans_from,
                       '12/30/9999',
                       2)

          SET @ID = Ident_current('Person')
      END

    UPDATE person
    SET    trans_to = Getdate()
    WHERE  id = @ID

    -- Insert For old data
    INSERT INTO person
                (person_id,
                 NAME,
                 location,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@Person_ID,
                 @old_name,
                 @old_location,
                 @old_validDate,
                 Getdate(),
                 Getdate(),
                 '12/30/9999',
                 3)  
GO
/****** Object:  StoredProcedure [dbo].[sp_doCommit]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_doCommit] @CommitName VARCHAR(50),
                               @BranchID   INT
AS
    DECLARE @commitPreviousHash VARCHAR(250)
    DECLARE @randomString VARCHAR(36)

    SELECT @randomString = CONVERT(VARCHAR(255), Newid())

    SELECT TOP 1 @commitPreviousHash = commitHash
    FROM   commits
    WHERE  branchID = @BranchID
    ORDER  BY date DESC

    IF ( @commitPreviousHash IS NULL )
      BEGIN
          SET @commitPreviousHash = (select Commits.commitHash from commits where commits.id in (SELECT TOP 1 commitPreviousID
                                     FROM   branches
                                     WHERE  branch_id = @BranchID))
      END

    INSERT INTO commits
                (NAME,
                 date,
                 branchID,
                 commitPrevious,
                 commitHash)
    VALUES      (@CommitName,
                 Getdate(),
                 @BranchID,
                 @commitPreviousHash,
                 @randomString);

    DECLARE @CommitID INT

    SELECT @CommitID = Ident_current('Commits')

    UPDATE person
    SET    commitID = @CommitID
    WHERE  commitID IS NULL  
GO
/****** Object:  StoredProcedure [dbo].[sp_EditBook]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_EditBook] @bookName VARCHAR(50),
                                 @author   VARCHAR(250),
                                 @Valid_from DATETIME,
                                 @ID         INT,
                                 @BranchID   DATETIME
AS
    DECLARE @book_ID INT
    DECLARE @old_validDate DATETIME
    DECLARE @old_author VARCHAR(250)
    DECLARE @old_name VARCHAR(250)
    DECLARE @Trans_from DATETIME

    SELECT @book_ID = book_id,
           @old_validDate = valid_from,
           @old_author = author,
           @old_name = NAME,
           @Trans_from = trans_from
    FROM   Books
    WHERE  id = @ID

    IF NOT EXISTS (SELECT *
                   FROM   Books AS p
                          INNER JOIN commits AS c
                                  ON c.id = p.commitID
                   WHERE  c.branchID = @BranchID)
      BEGIN
          INSERT INTO Books
                      (book_id,
                       NAME,
                       author,
                       valid_from,
                       valid_to,
                       trans_from,
                       trans_to,
                       transType)
          VALUES      (@book_ID,
                       @old_name,
                       @old_author,
                       @old_validDate,
                       @Valid_from,
                       @Trans_from,
                       '12/30/9999',
                       2)

          SET @ID = Ident_current('book')
      END

    UPDATE Books
    SET    trans_to = Getdate()
    WHERE  id = @ID

    -- Insert For old data
    INSERT INTO Books
                (book_id,
                 NAME,
                 author,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@book_ID,
                 @old_name,
                 @old_author,
                 @old_validDate,
                 @Valid_from,
                 Getdate(),
                 '12/30/9999',
                 2)

    -- Insert For new data
    INSERT INTO Books
                (book_id,
                 NAME,
                 author,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@book_ID,
                 @bookName,
                 @author,
                 @Valid_from,
                 '12/30/9999',
                 Getdate(),
                 '12/30/9999',
                 2)  
GO
/****** Object:  StoredProcedure [dbo].[sp_EditPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_EditPerson] @PersonName VARCHAR(50),
                                 @Location   VARCHAR(250),
                                 @Valid_from DATETIME,
                                 @ID         INT,
                                 @BranchID   DATETIME
AS
    DECLARE @Person_ID INT
    DECLARE @old_validDate DATETIME
    DECLARE @old_location VARCHAR(250)
    DECLARE @old_name VARCHAR(250)
    DECLARE @Trans_from DATETIME

    SELECT @Person_ID = person_id,
           @old_validDate = valid_from,
           @old_location = location,
           @old_name = NAME,
           @Trans_from = trans_from
    FROM   person
    WHERE  id = @ID

    IF NOT EXISTS (SELECT *
                   FROM   person AS p
                          INNER JOIN commits AS c
                                  ON c.id = p.commitID
                   WHERE  c.branchID = @BranchID)
      BEGIN
          INSERT INTO person
                      (person_id,
                       NAME,
                       location,
                       valid_from,
                       valid_to,
                       trans_from,
                       trans_to,
                       transType)
          VALUES      (@Person_ID,
                       @old_name,
                       @old_location,
                       @old_validDate,
                       @Valid_from,
                       @Trans_from,
                       '12/30/9999',
                       2)

          SET @ID = Ident_current('Person')
      END

    UPDATE person
    SET    trans_to = Getdate()
    WHERE  id = @ID

    -- Insert For old data
    INSERT INTO person
                (person_id,
                 NAME,
                 location,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@Person_ID,
                 @old_name,
                 @old_location,
                 @old_validDate,
                 @Valid_from,
                 Getdate(),
                 '12/30/9999',
                 2)

    -- Insert For new data
    INSERT INTO person
                (person_id,
                 NAME,
                 location,
                 valid_from,
                 valid_to,
                 trans_from,
                 trans_to,
                 transType)
    VALUES      (@Person_ID,
                 @PersonName,
                 @Location,
                 @Valid_from,
                 '12/30/9999',
                 Getdate(),
                 '12/30/9999',
                 2)  
GO
/****** Object:  StoredProcedure [dbo].[sp_getActualBookOnSelectedCommit]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[sp_getActualBookOnSelectedCommit] @CommitID INT
AS
    DECLARE @foo TABLE
      (
         id         INT,
         book_id  INT,
         NAME       VARCHAR(50),
         author   VARCHAR(50),
         transtype  INT,
         valid_from DATETIME,
         valid_to   DATETIME,
         trans_from DATETIME,
         trans_to   DATETIME
      )

    INSERT @foo
    EXEC sp_getBookOnMaster_New2   --Insert first commit's datas on commit's branch to variable 
      @CommitID

    DECLARE @commitPreviousID INT

    SET @commitPreviousID=(SELECT b.commitPreviousID	--set @commitPreviousID for next branch 
						   FROM   branches AS b
                           WHERE  b.branch_id IN (SELECT c.branchID
                                                  FROM   commits AS c
                                                  WHERE  c.id = @CommitID))

    WHILE ( @commitPreviousID IS NOT NULL )
      BEGIN
          INSERT @foo
          EXEC sp_getBookOnMaster_New2
            @commitPreviousID

          SET @commitPreviousID=(SELECT b.commitPreviousID
                                 FROM   branches AS b
                                 WHERE  b.branch_id IN
                                        (SELECT c.branchID
                                         FROM   commits AS c
                                         WHERE  c.id = @commitPreviousID))
      END

    SELECT *
    FROM   @foo AS f
           INNER JOIN (SELECT p.book_id,
                              Max(p.trans_from) trans_from
                       FROM   @foo AS p
                       GROUP  BY p.book_id) t2
                   ON t2.book_id = f.book_id
                      AND t2.trans_from = f.trans_from  
GO
/****** Object:  StoredProcedure [dbo].[sp_getActualPersonOnSelectedCommit]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[sp_getActualPersonOnSelectedCommit] @CommitID INT
AS
    DECLARE @foo TABLE
      (
         id         INT,
         person_id  INT,
         NAME       VARCHAR(50),
         location   VARCHAR(50),
         transtype  INT,
         valid_from DATETIME,
         valid_to   DATETIME,
         trans_from DATETIME,
         trans_to   DATETIME
      )

    INSERT @foo
    EXEC Sp_getpersononmaster_new2   --Insert first commit's datas on commit's branch to variable 
      @CommitID

    DECLARE @commitPreviousID INT

    SET @commitPreviousID=(SELECT b.commitPreviousID	--set @commitPreviousID for next branch 
						   FROM   branches AS b
                           WHERE  b.branch_id IN (SELECT c.branchID
                                                  FROM   commits AS c
                                                  WHERE  c.id = @CommitID))

    WHILE ( @commitPreviousID IS NOT NULL )
      BEGIN
          INSERT @foo
          EXEC Sp_getpersononmaster_new2
            @commitPreviousID

          SET @commitPreviousID=(SELECT b.commitPreviousID
                                 FROM   branches AS b
                                 WHERE  b.branch_id IN
                                        (SELECT c.branchID
                                         FROM   commits AS c
                                         WHERE  c.id = @commitPreviousID))
      END

    SELECT f.id,f.person_id,f.NAME,f.location,t.transName,f.valid_from,f.valid_to,f.trans_from,f.trans_to
    FROM   @foo AS f
           INNER JOIN (SELECT p.person_id,
                              Max(p.trans_from) trans_from
                       FROM   @foo AS p
                       GROUP  BY p.person_id) t2
                   ON t2.person_id = f.person_id
                      AND t2.trans_from = f.trans_from
					  
					  inner join TransactionTypes as t on t.id=f.transtype  
					  where f.person_id not in (select ff.person_id from @foo ff where ff.transtype=3 )
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllBook]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_getAllBook]
AS
    SELECT *
    FROM   Books  
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllBookChangesOnCommit]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_getAllBookChangesOnCommit] @commitID INT
AS
    SELECT dbo.books.id,
           dbo.books.book_id,
           dbo.books.NAME,
           dbo.books.author,
           t.transName,
           dbo.books.valid_from,
           dbo.books.valid_to,
           dbo.books.trans_from,
           dbo.books.trans_to
    FROM   dbo.commits
           INNER JOIN dbo.books
                   ON dbo.commits.id = dbo.books.commitID
           LEFT JOIN transactiontypes AS t
                  ON books.transType = t.id
    WHERE  ( dbo.commits.id = @commitID )  
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllChangesForPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getAllChangesForPerson]
 
AS
  SELECT DISTINCT
    person_id
  FROM Person
  WHERE commitID IS NULL
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllCommits]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getAllCommits] 
as
select * from Commits order by date
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllCommitsOnBranch]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getAllCommitsOnBranch] 
@BranchID int
as
select * from Commits where branchID=@BranchID order by date desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getAllPerson]
AS
    SELECT *
    FROM   person  
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllPersonChangesOnCommit]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getAllPersonChangesOnCommit] @commitID INT
AS
    SELECT dbo.person.id,
           dbo.person.person_id,
           dbo.person.NAME,
           dbo.person.location,
           t.transName,
           dbo.person.valid_from,
           dbo.person.valid_to,
           dbo.person.trans_from,
           dbo.person.trans_to
    FROM   dbo.commits
           INNER JOIN dbo.person
                   ON dbo.commits.id = dbo.person.commitID
           LEFT JOIN transactiontypes AS t
                  ON person.transType = t.id
    WHERE  ( dbo.commits.id = @commitID )  
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllValidBranches]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getAllValidBranches]
AS

  SELECT
    *
  FROM Branches
  WHERE Valid_To > GETDATE()
  AND Trans_To > GETDATE()
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookOnMaster_New2]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_getBookOnMaster_New2] @CommitID int
  
AS
declare @BranchID int
declare @CommitDate Datetime
   select @BranchID=branchID,@CommitDate=date from commits where id=@CommitID  

    SELECT DISTINCT dbo.Books.id,
                    dbo.Books.book_id,
                    dbo.Books.NAME,
                    Books.author,
                    dbo.Books.transtype,
                    dbo.Books.valid_from,
                    dbo.Books.valid_to,
                    dbo.Books.trans_from,
                    dbo.Books.trans_to
    FROM   dbo.Books
           INNER JOIN dbo.commits
                   ON dbo.Books.commitId = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.Books.transtype = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchId = dbo.branches.id
           INNER JOIN (SELECT p.book_id,
                              Max(p.trans_from) trans_from
                       FROM   Books AS p
                       WHERE  ( p.valid_to > Getdate() )
                              AND ( ( p.trans_to <= Getdate() )
                                     OR p.trans_to > Getdate() )
                              AND p.trans_from <= @CommitDate
                              AND p.book_id NOT IN (SELECT book_id
                                                      FROM   Books AS pp
                                  INNER JOIN commits AS c
                                          ON
                                  c.id = pp.commitID
                                                      WHERE  transtype = 3
                                                             AND c.branchId = @BranchID
                                                             AND pp.trans_from <= @CommitDate )
                       GROUP  BY p.book_id) t2
                   ON t2.book_id = Books.book_id
                      AND t2.trans_from = Books.trans_from
    WHERE  ( dbo.Books.valid_to > Getdate() )
           AND ( ( dbo.Books.trans_to < Getdate() )
                  OR Books.trans_to > Getdate() )
           AND ( dbo.branches.branch_id = @BranchID )  
GO
/****** Object:  StoredProcedure [dbo].[sp_getChangesForAPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getChangesForAPerson] @person_id int



AS
  SELECT
    *
  FROM Person
  WHERE commitID IS NULL
  AND person_id = @person_id
GO
/****** Object:  StoredProcedure [dbo].[sp_getPersonOnBranch]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getPersonOnBranch] @Branch_id INT
AS
    SELECT dbo.person.id,
           dbo.person.person_id,
           dbo.person.NAME,
           location,
           dbo.person.transType,
           dbo.person.valid_from,
           dbo.person.valid_to,
           dbo.person.trans_from,
           dbo.person.trans_to
    FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitID = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transType = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchID = dbo.branches.id
    WHERE  ( dbo.person.valid_to > Getdate() )
           AND ( dbo.person.trans_to > Getdate() )
           AND ( dbo.branches.branch_id = @Branch_id )
    UNION
    SELECT dbo.person.id,
           dbo.person.person_id,
           dbo.person.NAME,
           location,
           dbo.person.transType,
           dbo.person.valid_from,
           dbo.person.valid_to,
           dbo.person.trans_from,
           dbo.person.trans_to
    FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitID = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transType = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchID = dbo.branches.id
    WHERE  ( dbo.person.valid_to > Getdate() )
           AND ( dbo.person.trans_to > Getdate() )
           AND ( dbo.commits.branchID = 1 )
           AND ( dbo.commits.date <= (SELECT date
                                      FROM   commits AS c
                                             INNER JOIN branches AS b
                                                     ON
                                             b.commitPreviousID = c.id
                                      WHERE  b.branch_id = @Branch_id) )  
GO
/****** Object:  StoredProcedure [dbo].[sp_getPersonOnMaster]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getPersonOnMaster]
AS
    SELECT dbo.person.id,
           dbo.person.person_id,
           dbo.person.NAME,
           location,
           dbo.person.transType,
           dbo.person.valid_from,
           dbo.person.valid_to,
           dbo.person.trans_from,
           dbo.person.trans_to
    FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitID = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transType = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchID = dbo.branches.id
    WHERE  ( dbo.person.valid_to > Getdate() )
           AND ( dbo.person.trans_to > Getdate() )
           AND ( dbo.branches.branch_id = 1 )
    UNION
    SELECT id,
           person_id,
           NAME,
           location,
           transType,
           valid_from,
           valid_to,
           trans_from,
           '9999-12-30 00:00:00.000'
    FROM   person
    WHERE  commitID IN (SELECT c.id
                        FROM   commits AS c
                               INNER JOIN branches AS b
                                       ON c.branchID = b.branch_id
                        WHERE  b.branch_id = 1)
           AND ( dbo.person.valid_to > Getdate() )
           AND person_id IN (SELECT p.person_id
                             FROM   person AS p
                                    INNER JOIN commits AS c
                                            ON p.commitID = c.id
                                    INNER JOIN branches AS b
                                            ON c.branchID = b.branch_id
                             WHERE  b.branch_id <> 1)
           AND person_id NOT IN (SELECT dbo.person.person_id
                                 FROM   dbo.person
                                        INNER JOIN dbo.commits
                                                ON dbo.person.commitID =
                                                   dbo.commits.id
                                        LEFT JOIN dbo.transactiontypes
                                               ON dbo.person.transType =
                                                  dbo.transactiontypes.id
                                        INNER JOIN dbo.branches
                                                ON dbo.commits.branchID =
                                                   dbo.branches.id
                                 WHERE  ( dbo.person.valid_to > Getdate() )
                                        AND ( dbo.person.trans_to > Getdate() )
                                        AND ( dbo.branches.branch_id = 1 ))  
GO
/****** Object:  StoredProcedure [dbo].[sp_getPersonOnMaster_New]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getPersonOnMaster_New] @CommitDate DATETIME
AS
    SELECT DISTINCT dbo.person.id,
                    dbo.person.person_id,
                    dbo.person.NAME,
                    location,
                    dbo.person.transtype,
                    dbo.person.valid_from,
                    dbo.person.valid_to,
                    dbo.person.trans_from,
                    dbo.person.trans_to
    FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitId = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transtype = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchId = dbo.branches.id
           INNER JOIN (SELECT p.person_id,
                              Max(p.trans_from) trans_from
                       FROM   person AS p
                       WHERE  ( p.valid_to > Getdate() )
                              AND ( ( p.trans_to <= Getdate() )
                                     OR p.trans_to > Getdate() )
                              AND p.trans_from <= @CommitDate
                              AND p.person_id NOT IN (SELECT person_id
                                                      FROM   person AS pp
                                  INNER JOIN commits AS c
                                          ON
                                  c.id = pp.commitID
                                                      WHERE  transtype = 3
                                                             AND c.branchId = 1
                                                             AND pp.trans_from <= @CommitDate )
                       GROUP  BY p.person_id) t2
                   ON t2.person_id = person.person_id
                      AND t2.trans_from = person.trans_from
    WHERE  ( dbo.person.valid_to > Getdate() )
           AND ( ( dbo.person.trans_to < Getdate() )
                  OR person.trans_to > Getdate() )
           AND ( dbo.branches.branch_id = 1 )  
GO
/****** Object:  StoredProcedure [dbo].[sp_getPersonOnMaster_New2]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getPersonOnMaster_New2] @CommitID int
  
AS
declare @BranchID int
declare @CommitDate Datetime
   select @BranchID=branchID,@CommitDate=date from commits where id=@CommitID  

    SELECT DISTINCT dbo.person.id,
                    dbo.person.person_id,
                    dbo.person.NAME,
                    location,
                    dbo.Person.transType,
                    dbo.person.valid_from,
                    dbo.person.valid_to,
                    dbo.person.trans_from,
                    dbo.person.trans_to
    FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitId = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transtype = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchId = dbo.branches.id
           INNER JOIN (SELECT p.person_id,
                              Max(p.trans_to) trans_to,Max(p.trans_from) trans_from
                       FROM   person AS p
                       WHERE  ( p.valid_to > Getdate() )
                              AND ( ( p.trans_to <= Getdate() )
                                     OR p.trans_to > Getdate() )
                              AND p.trans_from <= @CommitDate
                              AND p.person_id NOT IN (SELECT person_id
                                                      FROM   person AS pp
                                  INNER JOIN commits AS c
                                          ON
                                  c.id = pp.commitID
                                                      WHERE  transtype = 3
                                                             AND c.branchId = @BranchID
                                                             AND pp.trans_from <= @CommitDate )
                       GROUP  BY p.person_id) t2
                   ON t2.person_id = person.person_id
                      AND( t2.trans_to = person.trans_to
					  or t2.trans_from=person.trans_from
					  )
    WHERE  ( dbo.person.valid_to > Getdate() )
           AND ( ( dbo.person.trans_to < Getdate() )
                  OR person.trans_to > Getdate() )
           AND ( dbo.branches.branch_id = @BranchID )  

union

select DISTINCT dbo.person.id,
                    dbo.person.person_id,
                    dbo.person.NAME,
                    location,
                    dbo.Person.transType,
                    dbo.person.valid_from,
                    dbo.person.valid_to,
                    dbo.person.trans_from,
                    dbo.person.trans_to
					FROM   dbo.person
           INNER JOIN dbo.commits
                   ON dbo.person.commitId = dbo.commits.id
           LEFT JOIN dbo.transactiontypes
                  ON dbo.person.transtype = dbo.transactiontypes.id
           INNER JOIN dbo.branches
                   ON dbo.commits.branchId = dbo.branches.id
				   where  dbo.branches.branch_id = @BranchID and  person.transType=3
				  and   ( dbo.person.valid_to < Getdate() )
           AND ( ( dbo.person.trans_from < @CommitDate)
           )
GO
/****** Object:  StoredProcedure [dbo].[sp_getValidBook]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_getValidBook]
AS

  SELECT
    *
  FROM Books
  WHERE Valid_To > GETDATE()
  AND Trans_To > GETDATE()
GO
/****** Object:  StoredProcedure [dbo].[sp_getValidPerson]    Script Date: 4/8/2018 8:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getValidPerson]
AS

  SELECT
    *
  FROM Person
  WHERE Valid_To > GETDATE()
  AND Trans_To > GETDATE()
GO
USE [master]
GO
ALTER DATABASE [Test] SET  READ_WRITE 
GO
