USE [master]
GO
/****** Object:  Database [PrestamoCDB]    Script Date: 8/11/2020 23:11:57 ******/
CREATE DATABASE [PrestamoCDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PrestamoCDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PrestamoCDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PrestamoCDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PrestamoCDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PrestamoCDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PrestamoCDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PrestamoCDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PrestamoCDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PrestamoCDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PrestamoCDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PrestamoCDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PrestamoCDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PrestamoCDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PrestamoCDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PrestamoCDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PrestamoCDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PrestamoCDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PrestamoCDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PrestamoCDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PrestamoCDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PrestamoCDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PrestamoCDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PrestamoCDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PrestamoCDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PrestamoCDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PrestamoCDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PrestamoCDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PrestamoCDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PrestamoCDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PrestamoCDB] SET  MULTI_USER 
GO
ALTER DATABASE [PrestamoCDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PrestamoCDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PrestamoCDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PrestamoCDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PrestamoCDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PrestamoCDB] SET QUERY_STORE = OFF
GO
USE [PrestamoCDB]
GO
/****** Object:  Table [dbo].[login]    Script Date: 8/11/2020 23:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[username] [nchar](10) NULL,
	[password] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loginAdmin]    Script Date: 8/11/2020 23:12:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loginAdmin](
	[username] [nchar](10) NOT NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_loginAdmin] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loginCoordis]    Script Date: 8/11/2020 23:12:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loginCoordis](
	[username] [nchar](10) NULL,
	[password] [nchar](10) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [PrestamoCDB] SET  READ_WRITE 
GO
