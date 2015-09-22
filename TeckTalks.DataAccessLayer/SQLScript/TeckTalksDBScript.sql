USE [master]
GO
/****** Object:  Database [TTDB]    Script Date: 09/22/2015 17:01:37 ******/
CREATE DATABASE [TTDB] ON  PRIMARY 
( NAME = N'TTDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TTDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TTDB_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TTDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TTDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TTDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TTDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TTDB] SET ARITHABORT OFF
GO
ALTER DATABASE [TTDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TTDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TTDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TTDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TTDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TTDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TTDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TTDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TTDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TTDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TTDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [TTDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TTDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TTDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TTDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TTDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TTDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TTDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TTDB] SET  READ_WRITE
GO
ALTER DATABASE [TTDB] SET RECOVERY FULL
GO
ALTER DATABASE [TTDB] SET  MULTI_USER
GO
ALTER DATABASE [TTDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TTDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'TTDB', N'ON'
GO
USE [TTDB]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 09/22/2015 17:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[USER_ID] [int] IDENTITY(1,1) NOT NULL,
	[LOGIN_NAME] [varchar](50) NULL,
	[DISPLAY_NAME] [varchar](50) NULL,
	[TITLE] [varchar](50) NULL,
	[FIRST_NAME] [varchar](50) NULL,
	[LAST_NAME] [varchar](50) NULL,
	[EMAIL] [varchar](100) NULL,
	[STATUS] [int] NULL,
	[LAST_SUCCESS_LOGIN] [datetime] NULL,
	[LAST_FAIL_LOGIN] [datetime] NULL,
	[TOTAL_FAIL_LOGIN] [int] NULL,
	[CRTE_DT] [datetime] NULL,
	[CRTE_BY] [varchar](32) NULL,
	[UPD_DT] [datetime] NULL,
	[UPD_BY] [varchar](32) NULL,
	[DEL_FLG] [bit] NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAGS]    Script Date: 09/22/2015 17:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAGS](
	[TAG_ID] [int] IDENTITY(1,1) NOT NULL,
	[TEXT] [varchar](50) NOT NULL,
	[CRTE_DT] [datetime] NULL,
	[CRTE_BY] [varchar](32) NULL,
	[UPD_DT] [datetime] NULL,
	[UPD_BY] [varchar](32) NULL,
	[DEL_FLG] [bit] NULL,
 CONSTRAINT [PK_TAGS] PRIMARY KEY CLUSTERED 
(
	[TAG_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POSTS]    Script Date: 09/22/2015 17:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POSTS](
	[POST_ID] [int] IDENTITY(1,1) NOT NULL,
	[TITLE] [varchar](50) NOT NULL,
	[CONTENT] [varchar](1000) NOT NULL,
	[USER_ID] [int] NOT NULL,
	[CRTE_DT] [datetime] NULL,
	[CRTE_BY] [varchar](32) NULL,
	[UPD_DT] [datetime] NULL,
	[UPD_BY] [varchar](32) NULL,
	[DEL_FLG] [bit] NULL,
 CONSTRAINT [PK_POSTS] PRIMARY KEY CLUSTERED 
(
	[POST_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RATINGS]    Script Date: 09/22/2015 17:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RATINGS](
	[RATING_ID] [int] IDENTITY(1,1) NOT NULL,
	[STAR_RATING] [int] NOT NULL,
	[USER_ID] [int] NOT NULL,
	[POST_ID] [int] NOT NULL,
	[CRTE_DT] [datetime] NULL,
	[CRTE_BY] [varchar](32) NULL,
	[UPD_DT] [datetime] NULL,
	[UPD_BY] [varchar](32) NULL,
	[DEL_FLG] [bit] NULL,
 CONSTRAINT [PK_RATINGS] PRIMARY KEY CLUSTERED 
(
	[RATING_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POST_TAGS]    Script Date: 09/22/2015 17:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POST_TAGS](
	[POST_TAG_ID] [int] IDENTITY(1,1) NOT NULL,
	[POST_ID] [int] NOT NULL,
	[TAG_ID] [int] NOT NULL,
	[CRTE_DT] [datetime] NULL,
	[CRTE_BY] [varchar](32) NULL,
	[UPD_DT] [datetime] NULL,
	[UPD_BY] [varchar](32) NULL,
	[DEL_FLG] [bit] NULL,
 CONSTRAINT [PK_POST_TAGS] PRIMARY KEY CLUSTERED 
(
	[POST_TAG_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_POSTS_POSTS]    Script Date: 09/22/2015 17:01:38 ******/
ALTER TABLE [dbo].[POSTS]  WITH CHECK ADD  CONSTRAINT [FK_POSTS_POSTS] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[POSTS] CHECK CONSTRAINT [FK_POSTS_POSTS]
GO
/****** Object:  ForeignKey [FK_RATINGS_POSTS]    Script Date: 09/22/2015 17:01:38 ******/
ALTER TABLE [dbo].[RATINGS]  WITH CHECK ADD  CONSTRAINT [FK_RATINGS_POSTS] FOREIGN KEY([POST_ID])
REFERENCES [dbo].[POSTS] ([POST_ID])
GO
ALTER TABLE [dbo].[RATINGS] CHECK CONSTRAINT [FK_RATINGS_POSTS]
GO
/****** Object:  ForeignKey [FK_RATINGS_USERS]    Script Date: 09/22/2015 17:01:38 ******/
ALTER TABLE [dbo].[RATINGS]  WITH CHECK ADD  CONSTRAINT [FK_RATINGS_USERS] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[RATINGS] CHECK CONSTRAINT [FK_RATINGS_USERS]
GO
/****** Object:  ForeignKey [FK_POST_TAGS_POSTS]    Script Date: 09/22/2015 17:01:38 ******/
ALTER TABLE [dbo].[POST_TAGS]  WITH CHECK ADD  CONSTRAINT [FK_POST_TAGS_POSTS] FOREIGN KEY([POST_ID])
REFERENCES [dbo].[POSTS] ([POST_ID])
GO
ALTER TABLE [dbo].[POST_TAGS] CHECK CONSTRAINT [FK_POST_TAGS_POSTS]
GO
/****** Object:  ForeignKey [FK_POST_TAGS_TAGS]    Script Date: 09/22/2015 17:01:38 ******/
ALTER TABLE [dbo].[POST_TAGS]  WITH CHECK ADD  CONSTRAINT [FK_POST_TAGS_TAGS] FOREIGN KEY([TAG_ID])
REFERENCES [dbo].[TAGS] ([TAG_ID])
GO
ALTER TABLE [dbo].[POST_TAGS] CHECK CONSTRAINT [FK_POST_TAGS_TAGS]
GO
