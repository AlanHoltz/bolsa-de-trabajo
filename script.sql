USE [master]
GO
/****** Object:  Database [BolsaTrabajo13]    Script Date: 7/11/2022 13:58:58 ******/
CREATE DATABASE [BolsaTrabajo13]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BolsaTrabajo13', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BolsaTrabajo13.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BolsaTrabajo13_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BolsaTrabajo13_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BolsaTrabajo13] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BolsaTrabajo13].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BolsaTrabajo13] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET ARITHABORT OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BolsaTrabajo13] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BolsaTrabajo13] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BolsaTrabajo13] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BolsaTrabajo13] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BolsaTrabajo13] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET RECOVERY FULL 
GO
ALTER DATABASE [BolsaTrabajo13] SET  MULTI_USER 
GO
ALTER DATABASE [BolsaTrabajo13] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BolsaTrabajo13] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BolsaTrabajo13] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BolsaTrabajo13] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BolsaTrabajo13] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BolsaTrabajo13] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BolsaTrabajo13', N'ON'
GO
ALTER DATABASE [BolsaTrabajo13] SET QUERY_STORE = OFF
GO
USE [BolsaTrabajo13]
GO
/****** Object:  User [fiido]    Script Date: 7/11/2022 13:58:58 ******/
CREATE USER [fiido] FOR LOGIN [fiido] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CareerJobProfile]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CareerJobProfile](
	[CareersId] [int] NOT NULL,
	[JobProfilesId] [int] NOT NULL,
 CONSTRAINT [PK_CareerJobProfile] PRIMARY KEY CLUSTERED 
(
	[CareersId] ASC,
	[JobProfilesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Careers]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Careers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Careers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Name] [nvarchar](max) NOT NULL,
	[ProvinceId] [int] NOT NULL,
	[ZipCode] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[ZipCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Cuit] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[CityZipCode] [nvarchar](450) NOT NULL,
	[ReferenceName] [nvarchar](max) NULL,
	[ReferencePhone] [nvarchar](max) NULL,
	[ReferenceEmail] [nvarchar](max) NULL,
	[ReferenceArea] [nvarchar](max) NULL,
	[ReferenceWorkingOnCompany] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Internships]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Internships](
	[Id] [int] NOT NULL,
	[Agreement] [bit] NOT NULL,
	[Duration] [int] NOT NULL,
	[Starting] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Internships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobProfilePerson]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobProfilePerson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobProfilesId] [int] NOT NULL,
	[PersonsId] [int] NOT NULL,
	[Observations] [nvarchar](100) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_JobProfilePerson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobProfiles]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobProfiles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailReceptor] [nvarchar](max) NOT NULL,
	[StartingDate] [datetime2](7) NOT NULL,
	[EndingDate] [datetime2](7) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Capacity] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_JobProfiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Cv] [nvarchar](max) NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relationships]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relationships](
	[Id] [int] NOT NULL,
	[WorkdayTime] [int] NOT NULL,
 CONSTRAINT [PK_Relationships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/11/2022 13:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mail] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[SignupDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_CareerJobProfile_JobProfilesId]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_CareerJobProfile_JobProfilesId] ON [dbo].[CareerJobProfile]
(
	[JobProfilesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cities_ProvinceId]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_Cities_ProvinceId] ON [dbo].[Cities]
(
	[ProvinceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Companies_CityZipCode]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_Companies_CityZipCode] ON [dbo].[Companies]
(
	[CityZipCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_JobProfilePerson_JobProfilesId]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_JobProfilePerson_JobProfilesId] ON [dbo].[JobProfilePerson]
(
	[JobProfilesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_JobProfilePerson_PersonsId]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_JobProfilePerson_PersonsId] ON [dbo].[JobProfilePerson]
(
	[PersonsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_JobProfiles_CompanyId]    Script Date: 7/11/2022 13:58:58 ******/
CREATE NONCLUSTERED INDEX [IX_JobProfiles_CompanyId] ON [dbo].[JobProfiles]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cities] ADD  DEFAULT (N'') FOR [ZipCode]
GO
ALTER TABLE [dbo].[JobProfiles] ADD  CONSTRAINT [DF__JobProfil__Creat__59063A47]  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedAt]
GO
ALTER TABLE [dbo].[JobProfiles] ADD  CONSTRAINT [DF_JobProfiles_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[CareerJobProfile]  WITH CHECK ADD  CONSTRAINT [FK_CareerJobProfile_Careers_CareersId] FOREIGN KEY([CareersId])
REFERENCES [dbo].[Careers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CareerJobProfile] CHECK CONSTRAINT [FK_CareerJobProfile_Careers_CareersId]
GO
ALTER TABLE [dbo].[CareerJobProfile]  WITH CHECK ADD  CONSTRAINT [FK_CareerJobProfile_JobProfiles_JobProfilesId] FOREIGN KEY([JobProfilesId])
REFERENCES [dbo].[JobProfiles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CareerJobProfile] CHECK CONSTRAINT [FK_CareerJobProfile_JobProfiles_JobProfilesId]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Provinces_ProvinceId] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[Provinces] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Provinces_ProvinceId]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [FK_Companies_Cities_CityZipCode] FOREIGN KEY([CityZipCode])
REFERENCES [dbo].[Cities] ([ZipCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [FK_Companies_Cities_CityZipCode]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [FK_Companies_Users_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [FK_Companies_Users_Id]
GO
ALTER TABLE [dbo].[Internships]  WITH CHECK ADD  CONSTRAINT [FK_Internships_JobProfiles_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[JobProfiles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Internships] CHECK CONSTRAINT [FK_Internships_JobProfiles_Id]
GO
ALTER TABLE [dbo].[JobProfilePerson]  WITH CHECK ADD  CONSTRAINT [FK_JobProfilePerson_JobProfiles_JobProfilesId] FOREIGN KEY([JobProfilesId])
REFERENCES [dbo].[JobProfiles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JobProfilePerson] CHECK CONSTRAINT [FK_JobProfilePerson_JobProfiles_JobProfilesId]
GO
ALTER TABLE [dbo].[JobProfilePerson]  WITH CHECK ADD  CONSTRAINT [FK_JobProfilePerson_Persons_PersonsId] FOREIGN KEY([PersonsId])
REFERENCES [dbo].[Persons] ([Id])
GO
ALTER TABLE [dbo].[JobProfilePerson] CHECK CONSTRAINT [FK_JobProfilePerson_Persons_PersonsId]
GO
ALTER TABLE [dbo].[JobProfiles]  WITH CHECK ADD  CONSTRAINT [FK_JobProfiles_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JobProfiles] CHECK CONSTRAINT [FK_JobProfiles_Companies_CompanyId]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Users_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Users_Id]
GO
ALTER TABLE [dbo].[Relationships]  WITH CHECK ADD  CONSTRAINT [FK_Relationships_JobProfiles_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[JobProfiles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Relationships] CHECK CONSTRAINT [FK_Relationships_JobProfiles_Id]
GO
USE [master]
GO
ALTER DATABASE [BolsaTrabajo13] SET  READ_WRITE 
GO
