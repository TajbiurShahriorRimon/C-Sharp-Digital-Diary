USE [master]
GO
/****** Object:  Database [DigitalDiary]    Script Date: 9/17/2020 8:43:11 PM ******/
CREATE DATABASE [DigitalDiary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DigitalDiary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DigitalDiary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DigitalDiary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DigitalDiary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DigitalDiary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DigitalDiary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DigitalDiary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DigitalDiary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DigitalDiary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DigitalDiary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DigitalDiary] SET ARITHABORT OFF 
GO
ALTER DATABASE [DigitalDiary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DigitalDiary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DigitalDiary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DigitalDiary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DigitalDiary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DigitalDiary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DigitalDiary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DigitalDiary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DigitalDiary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DigitalDiary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DigitalDiary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DigitalDiary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DigitalDiary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DigitalDiary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DigitalDiary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DigitalDiary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DigitalDiary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DigitalDiary] SET RECOVERY FULL 
GO
ALTER DATABASE [DigitalDiary] SET  MULTI_USER 
GO
ALTER DATABASE [DigitalDiary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DigitalDiary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DigitalDiary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DigitalDiary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DigitalDiary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DigitalDiary', N'ON'
GO
ALTER DATABASE [DigitalDiary] SET QUERY_STORE = OFF
GO
USE [DigitalDiary]
GO
/****** Object:  Table [dbo].[UserEvents]    Script Date: 9/17/2020 8:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEvents](
	[event_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[event] [varchar](50) NOT NULL,
	[story] [text] NULL,
	[created_date] [datetime] NULL,
	[modified_date] [datetime] NULL,
	[priority] [varchar](50) NULL,
	[photo] [image] NULL,
 CONSTRAINT [PK_UserEvents] PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/17/2020 8:43:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NULL,
	[user_password] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserEvents] ON 

INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (3, 5, N'taj', N'c', N'grg', CAST(N'2020-12-09T13:28:17.000' AS DateTime), CAST(N'2020-12-09T13:28:29.000' AS DateTime), N'', 0x53797374656D2E427974655B5D)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (4, 5, N'taj', N'vf', N'hrthr', CAST(N'2020-12-09T13:33:00.000' AS DateTime), CAST(N'2020-12-09T13:33:21.000' AS DateTime), N'High', 0x53797374656D2E427974655B5D)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (5, 5, N'taj', N'e', N'grdgrd', CAST(N'2020-12-09T20:04:02.000' AS DateTime), CAST(N'2020-12-09T20:04:28.000' AS DateTime), N'Moderate', 0x53797374656D2E427974655B5D)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (42, 5, N'taj', N'dvd', N'fweg', CAST(N'2020-09-16T13:48:37.000' AS DateTime), CAST(N'2020-09-16T13:48:45.000' AS DateTime), N'High', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (44, 5, N'taj', N'dsc', N'berg', CAST(N'2020-09-16T14:39:28.000' AS DateTime), CAST(N'2020-09-16T14:39:35.000' AS DateTime), N'Moderate', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (46, 5, N'taj', N'df', N'hello orld', CAST(N'2020-09-16T16:00:23.000' AS DateTime), CAST(N'2020-09-16T16:01:17.000' AS DateTime), N'Moderate', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (48, 5, N'taj', N'df123', N'c+++', CAST(N'2020-09-16T16:00:23.000' AS DateTime), CAST(N'2020-09-16T16:02:27.000' AS DateTime), N'Less Important', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (50, 13, N'df', N'scdc', N'kiufbg', CAST(N'2020-09-16T16:06:09.000' AS DateTime), CAST(N'2020-09-16T16:07:16.000' AS DateTime), N'High', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (51, 15, N'lo', N'bgbt', N'vsv', CAST(N'2020-09-17T20:33:20.000' AS DateTime), CAST(N'2020-09-17T20:33:28.000' AS DateTime), N'High', NULL)
INSERT [dbo].[UserEvents] ([event_id], [user_id], [user_name], [event], [story], [created_date], [modified_date], [priority], [photo]) VALUES (52, 5, N'taj', N'rtyhrt', N'vdfb', CAST(N'2020-09-17T20:34:14.000' AS DateTime), CAST(N'2020-09-17T20:34:22.000' AS DateTime), N'Moderate', NULL)
SET IDENTITY_INSERT [dbo].[UserEvents] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (1, N'User Name', N'Password')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (2, N'User Name', N'Password')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (3, N'User Name', N'Password')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (4, N'User Name', N'Password')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (5, N'taj', N'asd')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (6, N'er', N'zx')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (7, N'df', N'fd')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (8, N'q', N'a')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (9, N'Arif', N'12')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (10, N'w', N'e')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (11, N'r', N'r')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (12, N't', N'12')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (13, N'df', N'df')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (14, N'oi', N'hj')
INSERT [dbo].[Users] ([user_id], [user_name], [user_password]) VALUES (15, N'lo', N'po')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [DigitalDiary] SET  READ_WRITE 
GO
