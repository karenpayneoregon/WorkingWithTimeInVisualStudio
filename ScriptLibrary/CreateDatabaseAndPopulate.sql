
USE [master]
GO

/****** Object:  Database [DateTimeDatabase]    Script Date: 12/1/2018 8:44:07 AM ******/
CREATE DATABASE [DateTimeDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DateTimeDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DateTimeDatabase.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DateTimeDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DateTimeDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [DateTimeDatabase] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DateTimeDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DateTimeDatabase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET ARITHABORT OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [DateTimeDatabase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DateTimeDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DateTimeDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [DateTimeDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DateTimeDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET RECOVERY FULL 
GO

ALTER DATABASE [DateTimeDatabase] SET  MULTI_USER 
GO

ALTER DATABASE [DateTimeDatabase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DateTimeDatabase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DateTimeDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DateTimeDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [DateTimeDatabase] SET  READ_WRITE 
GO




USE [DateTimeDatabase]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 12/2/2018 7:00:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TimeTable]    Script Date: 12/2/2018 7:00:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
 CONSTRAINT [PK_TimeTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Events] ON 

GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (1, CAST(N'2017-01-01 06:34:12.000' AS DateTime), CAST(N'2007-01-01 12:45:34.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (2, CAST(N'2017-01-02 09:23:08.000' AS DateTime), CAST(N'2007-01-02 09:45:34.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (3, CAST(N'2017-01-03 09:30:08.000' AS DateTime), CAST(N'2007-01-02 13:45:34.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (4, CAST(N'2017-01-04 11:02:00.000' AS DateTime), CAST(N'2007-01-04 14:53:21.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (5, CAST(N'2017-01-05 07:52:55.000' AS DateTime), CAST(N'2007-01-05 09:08:48.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (6, CAST(N'2017-01-06 19:59:11.000' AS DateTime), CAST(N'2007-01-07 01:23:11.000' AS DateTime))
GO
INSERT [dbo].[Events] ([EventID], [StartDate], [EndDate]) VALUES (7, CAST(N'2017-01-07 03:12:23.000' AS DateTime), CAST(N'2007-01-07 20:02:25.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[TimeTable] ON 

GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (1, N'Jeanine', N'Abbott', CAST(N'09:00:00' AS Time), CAST(N'10:00:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (2, N'Lester', N'Lam', CAST(N'08:00:00' AS Time), CAST(N'11:00:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (3, N'Claire', N'Cowan', CAST(N'15:45:00' AS Time), CAST(N'19:45:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (4, N'Shannon', N'Bentley', CAST(N'00:30:00' AS Time), CAST(N'08:30:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (5, N'Valerie', N'Berger', CAST(N'03:00:00' AS Time), CAST(N'04:15:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (6, N'Ty', N'Keith', CAST(N'12:45:00' AS Time), CAST(N'16:00:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (7, N'Roy', N'Finley', CAST(N'06:15:00' AS Time), CAST(N'05:15:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (8, N'Ashley', N'Howard', CAST(N'13:00:00' AS Time), CAST(N'13:45:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (9, N'Forrest', N'Rich', CAST(N'17:00:00' AS Time), CAST(N'17:30:00' AS Time))
GO
INSERT [dbo].[TimeTable] ([id], [FirstName], [LastName], [StartTime], [EndTime]) VALUES (10, N'Ron', N'Martin', CAST(N'08:00:00' AS Time), CAST(N'07:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[TimeTable] OFF
GO


