USE [master]
GO
/****** Object:  Database [LoginDB]    Script Date: 10/09/2017 4:23:45 PM ******/
CREATE DATABASE [LoginDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoginDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LoginDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LoginDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LoginDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LoginDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoginDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoginDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoginDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoginDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoginDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoginDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoginDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoginDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoginDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoginDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoginDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoginDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoginDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoginDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoginDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoginDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoginDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoginDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoginDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoginDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoginDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoginDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoginDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoginDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LoginDB] SET  MULTI_USER 
GO
ALTER DATABASE [LoginDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoginDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoginDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoginDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LoginDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LoginDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/09/2017 4:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](30) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([Username], [Password]) VALUES (N'admin', N'admin')
INSERT [dbo].[Account] ([Username], [Password]) VALUES (N'do', N'do')
USE [master]
GO
ALTER DATABASE [LoginDB] SET  READ_WRITE 
GO
