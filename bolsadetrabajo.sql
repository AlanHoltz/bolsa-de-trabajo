USE [master]
GO
/****** Object:  Database [bolsadetrabajo]    Script Date: 12/5/2022 16:29:51 ******/
CREATE DATABASE [bolsadetrabajo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bolsadetrabajo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bolsadetrabajo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bolsadetrabajo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bolsadetrabajo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bolsadetrabajo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bolsadetrabajo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bolsadetrabajo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET ARITHABORT OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bolsadetrabajo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bolsadetrabajo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bolsadetrabajo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bolsadetrabajo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET RECOVERY FULL 
GO
ALTER DATABASE [bolsadetrabajo] SET  MULTI_USER 
GO
ALTER DATABASE [bolsadetrabajo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bolsadetrabajo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bolsadetrabajo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bolsadetrabajo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bolsadetrabajo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bolsadetrabajo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bolsadetrabajo', N'ON'
GO
ALTER DATABASE [bolsadetrabajo] SET QUERY_STORE = OFF
GO
USE [bolsadetrabajo]
GO
/****** Object:  Table [dbo].[application_emp]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[application_emp](
	[person_id] [int] NOT NULL,
	[job_profile_id] [int] NOT NULL,
	[application_emp_status] [tinyint] NOT NULL,
	[application_emp_obs] [text] NOT NULL,
	[application_emp_cv] [varchar](50) NOT NULL,
	[application_emp_created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_application_emp_1] PRIMARY KEY CLUSTERED 
(
	[person_id] ASC,
	[job_profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[careers]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[careers](
	[career_id] [int] IDENTITY(1,1) NOT NULL,
	[career_name] [varchar](30) NOT NULL,
 CONSTRAINT [PK_careers] PRIMARY KEY CLUSTERED 
(
	[career_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[city_zip_code] [varchar](25) NOT NULL,
	[city_name] [varchar](30) NOT NULL,
	[province_id] [int] NOT NULL,
 CONSTRAINT [PK_cities] PRIMARY KEY CLUSTERED 
(
	[city_zip_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[companies]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[companies](
	[company_id] [int] NOT NULL,
	[company_name] [varchar](25) NOT NULL,
	[company_cuit] [varchar](15) NOT NULL,
	[company_category] [varchar](25) NOT NULL,
	[company_address] [varchar](25) NOT NULL,
	[company_city_zip_code] [varchar](25) NOT NULL,
	[company_reference_name] [varchar](25) NOT NULL,
	[company_reference_phone] [varchar](25) NOT NULL,
	[company_reference_email] [varchar](50) NOT NULL,
	[company_reference_area] [varchar](25) NOT NULL,
	[company_reference_working_on_company] [tinyint] NOT NULL,
	[company_photo] [varchar](45) NULL,
 CONSTRAINT [PK_companies] PRIMARY KEY CLUSTERED 
(
	[company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[internships]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[internships](
	[internship_id] [int] NOT NULL,
	[internship_agreement] [varchar](50) NOT NULL,
	[internship_duration] [int] NOT NULL,
	[internship_starting] [datetime] NOT NULL,
 CONSTRAINT [PK_internships] PRIMARY KEY CLUSTERED 
(
	[internship_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[job_profiles]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[job_profiles](
	[job_profile_id] [int] IDENTITY(1,1) NOT NULL,
	[job_profile_mail_receptor] [varchar](50) NOT NULL,
	[job_profile_starting_date] [datetime] NOT NULL,
	[job_profile_ending_date] [datetime] NOT NULL,
	[job_profile_address] [varchar](35) NOT NULL,
	[job_profile_capacity] [int] NOT NULL,
	[job_profile_description_name] [text] NOT NULL,
	[job_profile_position_name] [varchar](30) NOT NULL,
	[company_id] [int] NOT NULL,
 CONSTRAINT [PK_job_profiles] PRIMARY KEY CLUSTERED 
(
	[job_profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[job_profiles_careers]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[job_profiles_careers](
	[job_profile_id] [int] NOT NULL,
	[career_id] [int] NOT NULL,
 CONSTRAINT [PK_job_profiles_careers] PRIMARY KEY CLUSTERED 
(
	[job_profile_id] ASC,
	[career_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[person_id] [int] NOT NULL,
	[person_name] [varchar](25) NOT NULL,
	[person_surname] [varchar](25) NOT NULL,
	[person_photo] [varchar](45) NULL,
	[person_cv] [varchar](45) NULL,
	[person_is_admin] [tinyint] NOT NULL,
	[person_birth_date] [datetime] NOT NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provinces]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provinces](
	[province_id] [int] IDENTITY(1,1) NOT NULL,
	[province_name] [varchar](25) NOT NULL,
 CONSTRAINT [PK_provinces] PRIMARY KEY CLUSTERED 
(
	[province_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[relationships]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[relationships](
	[relationship_id] [int] NOT NULL,
	[relationship_workday_time] [int] NOT NULL,
 CONSTRAINT [PK_relationships] PRIMARY KEY CLUSTERED 
(
	[relationship_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/5/2022 16:29:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_mail] [varchar](50) NOT NULL,
	[user_password] [varchar](50) NOT NULL,
	[user_status] [tinyint] NOT NULL,
	[user_signup_date] [datetime] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_mail]    Script Date: 12/5/2022 16:29:52 ******/
CREATE UNIQUE NONCLUSTERED INDEX [uq_mail] ON [dbo].[users]
(
	[user_mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[application_emp]  WITH CHECK ADD  CONSTRAINT [FK_application_emp_job_profiles] FOREIGN KEY([job_profile_id])
REFERENCES [dbo].[job_profiles] ([job_profile_id])
GO
ALTER TABLE [dbo].[application_emp] CHECK CONSTRAINT [FK_application_emp_job_profiles]
GO
ALTER TABLE [dbo].[application_emp]  WITH CHECK ADD  CONSTRAINT [FK_application_emp_persons] FOREIGN KEY([person_id])
REFERENCES [dbo].[persons] ([person_id])
GO
ALTER TABLE [dbo].[application_emp] CHECK CONSTRAINT [FK_application_emp_persons]
GO
ALTER TABLE [dbo].[cities]  WITH CHECK ADD  CONSTRAINT [FK_cities_provinces] FOREIGN KEY([province_id])
REFERENCES [dbo].[provinces] ([province_id])
GO
ALTER TABLE [dbo].[cities] CHECK CONSTRAINT [FK_cities_provinces]
GO
ALTER TABLE [dbo].[companies]  WITH CHECK ADD  CONSTRAINT [FK_companies_users] FOREIGN KEY([company_city_zip_code])
REFERENCES [dbo].[cities] ([city_zip_code])
GO
ALTER TABLE [dbo].[companies] CHECK CONSTRAINT [FK_companies_users]
GO
ALTER TABLE [dbo].[internships]  WITH CHECK ADD  CONSTRAINT [FK_job_profiles_internships] FOREIGN KEY([internship_id])
REFERENCES [dbo].[job_profiles] ([job_profile_id])
GO
ALTER TABLE [dbo].[internships] CHECK CONSTRAINT [FK_job_profiles_internships]
GO
ALTER TABLE [dbo].[job_profiles]  WITH CHECK ADD  CONSTRAINT [FK_job_profiles_companies] FOREIGN KEY([company_id])
REFERENCES [dbo].[companies] ([company_id])
GO
ALTER TABLE [dbo].[job_profiles] CHECK CONSTRAINT [FK_job_profiles_companies]
GO
ALTER TABLE [dbo].[job_profiles_careers]  WITH CHECK ADD  CONSTRAINT [FK_job_profiles_careers_careers] FOREIGN KEY([career_id])
REFERENCES [dbo].[careers] ([career_id])
GO
ALTER TABLE [dbo].[job_profiles_careers] CHECK CONSTRAINT [FK_job_profiles_careers_careers]
GO
ALTER TABLE [dbo].[job_profiles_careers]  WITH CHECK ADD  CONSTRAINT [FK_job_profiles_careers_job_profiles] FOREIGN KEY([job_profile_id])
REFERENCES [dbo].[job_profiles] ([job_profile_id])
GO
ALTER TABLE [dbo].[job_profiles_careers] CHECK CONSTRAINT [FK_job_profiles_careers_job_profiles]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [FK_persons_users] FOREIGN KEY([person_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [FK_persons_users]
GO
ALTER TABLE [dbo].[relationships]  WITH CHECK ADD  CONSTRAINT [FK_job_profiles_relationships] FOREIGN KEY([relationship_id])
REFERENCES [dbo].[job_profiles] ([job_profile_id])
GO
ALTER TABLE [dbo].[relationships] CHECK CONSTRAINT [FK_job_profiles_relationships]
GO
USE [master]
GO
ALTER DATABASE [bolsadetrabajo] SET  READ_WRITE 
GO
