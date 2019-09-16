ALTER TABLE [dbo].[ts_PageVersions] DROP CONSTRAINT [FK_ts_PageVersions_ts_Pages]
GO
ALTER TABLE [dbo].[ts_PageVersionNotes] DROP CONSTRAINT [FK_ts_PageVersionNotes_ts_PageVersions]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [FK_ts_Pages_ts_PageTypes]
GO
ALTER TABLE [dbo].[lkpProvinces] DROP CONSTRAINT [FK_lkpProvinces_lkpCountry]
GO
ALTER TABLE [dbo].[linkSurveysQuestions] DROP CONSTRAINT [FK_linkSurveysQuestions_datSurveys]
GO
ALTER TABLE [dbo].[linkSurveysQuestions] DROP CONSTRAINT [FK_linkSurveysQuestions_datSurveyQuestions]
GO
ALTER TABLE [dbo].[jncUsersToPeople] DROP CONSTRAINT [FK_jncUsersToPeople_datPerson]
GO
ALTER TABLE [dbo].[jncUsersToPeople] DROP CONSTRAINT [FK_jncUsersToPeople_AspNetUsers]
GO
ALTER TABLE [dbo].[jncSectionPages] DROP CONSTRAINT [FK_jncCurriculumSection_ts_Pages]
GO
ALTER TABLE [dbo].[jncSectionPages] DROP CONSTRAINT [FK_jncCurriculumSection_datCurriculum]
GO
ALTER TABLE [dbo].[jncCoachClasses] DROP CONSTRAINT [FK_jncCoachClasses_datCoach]
GO
ALTER TABLE [dbo].[jncCoachClasses] DROP CONSTRAINT [FK_jncCoachClasses_datClass]
GO
ALTER TABLE [dbo].[jncClassStudents] DROP CONSTRAINT [FK_jncClassStudents_datClient]
GO
ALTER TABLE [dbo].[jncClassStudents] DROP CONSTRAINT [FK_jncClassStudents_datClass]
GO
ALTER TABLE [dbo].[jncClassForum] DROP CONSTRAINT [FK_jncClassForum_datForums]
GO
ALTER TABLE [dbo].[jncClassForum] DROP CONSTRAINT [FK_jncClassForum_datClass]
GO
ALTER TABLE [dbo].[datSurveyQuestions] DROP CONSTRAINT [FK_datSurveyQuestions_lkpSurveyQuestionTypes]
GO
ALTER TABLE [dbo].[datQuestionOptions] DROP CONSTRAINT [FK_datQuestionOptions_datSurveyQuestions]
GO
ALTER TABLE [dbo].[datPosts] DROP CONSTRAINT [FK_datPosts_datPosts]
GO
ALTER TABLE [dbo].[datPosts] DROP CONSTRAINT [FK_datPosts_datForums]
GO
ALTER TABLE [dbo].[datPerson] DROP CONSTRAINT [FK_datPerson_lkpProvinces]
GO
ALTER TABLE [dbo].[datPerson] DROP CONSTRAINT [FK_datPerson_lkpGender]
GO
ALTER TABLE [dbo].[datCourseSections] DROP CONSTRAINT [FK_datCurriculum_datCourse]
GO
ALTER TABLE [dbo].[datCoach] DROP CONSTRAINT [FK_datCoach_lkpDesignation]
GO
ALTER TABLE [dbo].[datCoach] DROP CONSTRAINT [FK_datCoach_datPerson]
GO
ALTER TABLE [dbo].[datClientToSurvey] DROP CONSTRAINT [FK_datClientToSurvey_datClient]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] DROP CONSTRAINT [FK_datClientSurveyAnswer_datClientToSurvey1]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] DROP CONSTRAINT [FK_datClientSurveyAnswer_datClientSurveyQuestion]
GO
ALTER TABLE [dbo].[datClientSocialMedia] DROP CONSTRAINT [FK_datClientSocialMedia_lkpSocialMedia]
GO
ALTER TABLE [dbo].[datClientSocialMedia] DROP CONSTRAINT [FK_datClientSocialMedia_datClient]
GO
ALTER TABLE [dbo].[datClientResponsesText] DROP CONSTRAINT [FK_datClientResponsesText_linkSurveysQuestions]
GO
ALTER TABLE [dbo].[datClientResponsesText] DROP CONSTRAINT [FK_datClientResponsesText_datClientResponsesMain]
GO
ALTER TABLE [dbo].[datClientResponsesOptions] DROP CONSTRAINT [FK_datClientResponsesOptions_linkSurveysQuestions]
GO
ALTER TABLE [dbo].[datClientResponsesOptions] DROP CONSTRAINT [FK_datClientResponsesOptions_datQuestionOptions]
GO
ALTER TABLE [dbo].[datClientResponsesOptions] DROP CONSTRAINT [FK_datClientResponsesOptions_datClientResponsesMain]
GO
ALTER TABLE [dbo].[datClient] DROP CONSTRAINT [FK_datClient_datPerson]
GO
ALTER TABLE [dbo].[datClass] DROP CONSTRAINT [FK_datClass_datCourse1]
GO
ALTER TABLE [dbo].[AspNetUserTokens] DROP CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims] DROP CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[ts_PageVersions] DROP CONSTRAINT [DF_ts_PageVersions_ViewCount]
GO
ALTER TABLE [dbo].[ts_PageVersions] DROP CONSTRAINT [DF_datPageVersions_IsApproved]
GO
ALTER TABLE [dbo].[ts_PageVersions] DROP CONSTRAINT [DF_datPageVersions_PageID]
GO
ALTER TABLE [dbo].[ts_PageTypes] DROP CONSTRAINT [DF_ts_PageTypes_IsUsed]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_ts_Pages_PageType]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_ts_Pages_IsSecure]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_datPages_IsActive]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_datPages_EffectiveDate]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_datPages_ExpiryDate]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_datPages_IsDefault]
GO
ALTER TABLE [dbo].[ts_Pages] DROP CONSTRAINT [DF_datPages_IsSystemRequiredPage]
GO
ALTER TABLE [dbo].[lkpSurveyQuestionTypes] DROP CONSTRAINT [DF_lkpQuestionTypes_isActive]
GO
ALTER TABLE [dbo].[lkpSocialMedia] DROP CONSTRAINT [DF_lkpSocialMedia_isActive]
GO
ALTER TABLE [dbo].[jncClassStudents] DROP CONSTRAINT [DF_jncClassStudents_hasCompleted]
GO
ALTER TABLE [dbo].[jncClassStudents] DROP CONSTRAINT [DF_jncClassStudents_hasStarted]
GO
ALTER TABLE [dbo].[jncClassStudents] DROP CONSTRAINT [DF_jncClassStudents_Marks]
GO
ALTER TABLE [dbo].[datSurveys] DROP CONSTRAINT [DF_datSurveys_reqToPass]
GO
ALTER TABLE [dbo].[datSurveys] DROP CONSTRAINT [DF_datSurveys_dtExpiry]
GO
ALTER TABLE [dbo].[datSurveys] DROP CONSTRAINT [DF_datSurveys_dtEffective]
GO
ALTER TABLE [dbo].[datSurveys] DROP CONSTRAINT [DF_datSurveys_isActive]
GO
ALTER TABLE [dbo].[datSurveyQuestions] DROP CONSTRAINT [DF_datSurveyQuestions_hasOtherOption]
GO
ALTER TABLE [dbo].[datQuestionOptions] DROP CONSTRAINT [DF_datQuestionOptions_isCorrect]
GO
ALTER TABLE [dbo].[datQuestionOptions] DROP CONSTRAINT [DF_datQuestionOptions_defaultOption]
GO
ALTER TABLE [dbo].[datPosts] DROP CONSTRAINT [DF_datPosts_IsApproved]
GO
ALTER TABLE [dbo].[datPosts] DROP CONSTRAINT [DF_datPosts_IsActive]
GO
ALTER TABLE [dbo].[datPosts] DROP CONSTRAINT [DF_datPosts_PostedDate]
GO
ALTER TABLE [dbo].[datForums] DROP CONSTRAINT [DF__datForums__Creat__22751F6C]
GO
ALTER TABLE [dbo].[datForums] DROP CONSTRAINT [DF_datForums_IsPrivate]
GO
ALTER TABLE [dbo].[datForums] DROP CONSTRAINT [DF_datForums_IsSticky]
GO
ALTER TABLE [dbo].[datForums] DROP CONSTRAINT [DF_datForums_IsApproved]
GO
ALTER TABLE [dbo].[datForums] DROP CONSTRAINT [DF_datForums_IsActive]
GO
ALTER TABLE [dbo].[datCourse] DROP CONSTRAINT [DF_datCourse_isActive]
GO
ALTER TABLE [dbo].[datCourse] DROP CONSTRAINT [DF__datCourse__Creat__52593CB8]
GO
ALTER TABLE [dbo].[datCoach] DROP CONSTRAINT [DF_datCoach_CoachID]
GO
ALTER TABLE [dbo].[datClientToSurvey] DROP CONSTRAINT [DF_datClientToSurvey_Date]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] DROP CONSTRAINT [DF_datClientSurveyAnswer_SurveyID]
GO
ALTER TABLE [dbo].[datClientSocialMedia] DROP CONSTRAINT [DF_datClientSocialMedia_isActive]
GO
ALTER TABLE [dbo].[datClientSocialMedia] DROP CONSTRAINT [DF_datClientSocialMedia_clientID]
GO
ALTER TABLE [dbo].[datClientResponsesMain] DROP CONSTRAINT [DF_datClientResponsesMain_isActive]
GO
ALTER TABLE [dbo].[datClientResponsesMain] DROP CONSTRAINT [DF_datClientResponsesMain_dtStarted]
GO
ALTER TABLE [dbo].[datClient] DROP CONSTRAINT [DF_datClient_ClientID]
GO
ALTER TABLE [dbo].[datClass] DROP CONSTRAINT [DF_datClass_isActive]
GO
ALTER TABLE [dbo].[datClass] DROP CONSTRAINT [DF_datClass_CreatedDate]
GO
/****** Object:  Table [dbo].[ts_PageVersionNotes]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[ts_PageVersionNotes]
GO
/****** Object:  Table [dbo].[ts_PageTypes]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[ts_PageTypes]
GO
/****** Object:  Table [dbo].[ts_Pages]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[ts_Pages]
GO
/****** Object:  Table [dbo].[lkpSurveyQuestionTypes]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpSurveyQuestionTypes]
GO
/****** Object:  Table [dbo].[lkpSocialMedia]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpSocialMedia]
GO
/****** Object:  Table [dbo].[lkpProvinces]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpProvinces]
GO
/****** Object:  Table [dbo].[lkpGender]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpGender]
GO
/****** Object:  Table [dbo].[lkpDesignation]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpDesignation]
GO
/****** Object:  Table [dbo].[lkpCountry]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[lkpCountry]
GO
/****** Object:  Table [dbo].[linkSurveysQuestions]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[linkSurveysQuestions]
GO
/****** Object:  Table [dbo].[jncUsersToPeople]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[jncUsersToPeople]
GO
/****** Object:  Table [dbo].[jncSectionPages]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[jncSectionPages]
GO
/****** Object:  Table [dbo].[jncCoachClasses]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[jncCoachClasses]
GO
/****** Object:  Table [dbo].[jncClassStudents]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[jncClassStudents]
GO
/****** Object:  Table [dbo].[jncClassForum]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[jncClassForum]
GO
/****** Object:  Table [dbo].[datSurveys]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datSurveys]
GO
/****** Object:  Table [dbo].[datSurveyQuestions]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datSurveyQuestions]
GO
/****** Object:  Table [dbo].[datQuestionOptions]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datQuestionOptions]
GO
/****** Object:  Table [dbo].[datPosts]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datPosts]
GO
/****** Object:  Table [dbo].[datPerson]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datPerson]
GO
/****** Object:  Table [dbo].[datForums]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datForums]
GO
/****** Object:  Table [dbo].[datCourseSections]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datCourseSections]
GO
/****** Object:  Table [dbo].[datCourse]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datCourse]
GO
/****** Object:  Table [dbo].[datCoach]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datCoach]
GO
/****** Object:  Table [dbo].[datClientToSurvey]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientToSurvey]
GO
/****** Object:  Table [dbo].[datClientSurveyQuestion]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientSurveyQuestion]
GO
/****** Object:  Table [dbo].[datClientSurveyAnswer]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientSurveyAnswer]
GO
/****** Object:  Table [dbo].[datClientSocialMedia]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientSocialMedia]
GO
/****** Object:  Table [dbo].[datClientResponsesText]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientResponsesText]
GO
/****** Object:  Table [dbo].[datClientResponsesOptions]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientResponsesOptions]
GO
/****** Object:  Table [dbo].[datClientResponsesMain]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClientResponsesMain]
GO
/****** Object:  Table [dbo].[datClient]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClient]
GO
/****** Object:  Table [dbo].[datClass]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[datClass]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetUserTokens]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[AspNetRoleClaims]
GO
/****** Object:  View [dbo].[viewPageViewCount]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP VIEW [dbo].[viewPageViewCount]
GO
/****** Object:  Table [dbo].[ts_PageVersions]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP TABLE [dbo].[ts_PageVersions]
GO
/****** Object:  Database [WOM_SalesCoach]    Script Date: 2019-08-28 4:26:37 PM ******/
DROP DATABASE [WOM_SalesCoach]
GO
/****** Object:  Database [WOM_SalesCoach]    Script Date: 2019-08-28 4:26:37 PM ******/
CREATE DATABASE [WOM_SalesCoach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WOM_SalesCoach', FILENAME = N'C:\Users\dhara\OneDrive\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WOM_SalesCoach.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WOM_SalesCoach_log', FILENAME = N'C:\Users\dhara\OneDrive\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WOM_SalesCoach_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WOM_SalesCoach] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WOM_SalesCoach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WOM_SalesCoach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET ARITHABORT OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WOM_SalesCoach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WOM_SalesCoach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WOM_SalesCoach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WOM_SalesCoach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET RECOVERY FULL 
GO
ALTER DATABASE [WOM_SalesCoach] SET  MULTI_USER 
GO
ALTER DATABASE [WOM_SalesCoach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WOM_SalesCoach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WOM_SalesCoach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WOM_SalesCoach] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WOM_SalesCoach] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WOM_SalesCoach', N'ON'
GO
ALTER DATABASE [WOM_SalesCoach] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[ts_PageVersions]    Script Date: 2019-08-28 4:26:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ts_PageVersions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PageID] [int] NULL,
	[PageContent] [nvarchar](max) NULL,
	[MetaKeywords] [nvarchar](500) NULL,
	[MetaDescription] [nvarchar](500) NULL,
	[EffectiveDate] [datetime] NULL,
	[IsApproved] [bit] NULL,
	[VersionTitle] [nvarchar](50) NULL,
	[ViewCount] [int] NULL,
 CONSTRAINT [PK_datPageVersions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewPageViewCount]    Script Date: 2019-08-28 4:26:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewPageViewCount]
AS
SELECT     PageID, SUM(ViewCount) AS SumOfViewCount
FROM         dbo.ts_PageVersions
GROUP BY PageID
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2019-08-28 4:26:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClass]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClass](
	[ClassCode] [nvarchar](10) NOT NULL,
	[CourseCode] [nvarchar](10) NOT NULL,
	[ClassName] [nvarchar](100) NOT NULL,
	[ClassDescription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_datClass] PRIMARY KEY CLUSTERED 
(
	[ClassCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClient]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClient](
	[ClientID] [int] NOT NULL,
	[CompanyName] [nvarchar](30) NULL,
	[CompanyDetail] [nvarchar](max) NULL,
	[WebsiteName] [nvarchar](70) NULL,
	[RegisterDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ProfileLink] [nvarchar](50) NULL,
	[BusinessType] [nvarchar](30) NULL,
 CONSTRAINT [PK_datClient] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientResponsesMain]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientResponsesMain](
	[clientResponseID] [int] NOT NULL,
	[clientID] [int] NULL,
	[dtStarted] [datetime] NULL,
	[isActive] [bit] NULL,
	[numberCorrect] [int] NULL,
 CONSTRAINT [PK_datClientResponsesMain] PRIMARY KEY CLUSTERED 
(
	[clientResponseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientResponsesOptions]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientResponsesOptions](
	[responseID] [int] IDENTITY(1,1) NOT NULL,
	[clientResponseID] [int] NULL,
	[SurveyQuestionID] [int] NULL,
	[optionID] [int] NULL,
 CONSTRAINT [PK_datClientResponsesOptions] PRIMARY KEY CLUSTERED 
(
	[responseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientResponsesText]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientResponsesText](
	[responseID] [int] IDENTITY(1,1) NOT NULL,
	[clientResponseID] [int] NULL,
	[surveyQuestionID] [int] NULL,
	[responseText] [nvarchar](250) NULL,
 CONSTRAINT [PK_datClientResponsesText] PRIMARY KEY CLUSTERED 
(
	[responseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientSocialMedia]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientSocialMedia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[clientID] [int] NULL,
	[smTypeID] [int] NULL,
	[URLstring] [nvarchar](150) NULL,
	[isActive] [bit] NULL,
	[DisplayOrder] [tinyint] NULL,
 CONSTRAINT [PK_datClientSocialMedia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientSurveyAnswer]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientSurveyAnswer](
	[AnswerToQuestionID] [int] IDENTITY(0,1) NOT NULL,
	[QuestionIndex] [int] NOT NULL,
	[AnswerText] [nvarchar](max) NULL,
	[SurveyID] [int] NOT NULL,
 CONSTRAINT [PK_datClientSurveyQuestions] PRIMARY KEY CLUSTERED 
(
	[AnswerToQuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientSurveyQuestion]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientSurveyQuestion](
	[QuestionIndex] [int] NOT NULL,
	[QuestionText] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_datClientSurveyQuestion] PRIMARY KEY CLUSTERED 
(
	[QuestionIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datClientToSurvey]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datClientToSurvey](
	[ClientToSurveyID] [int] IDENTITY(0,1) NOT NULL,
	[SurveyID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_datClientToSurvey_1] PRIMARY KEY CLUSTERED 
(
	[SurveyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datCoach]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datCoach](
	[CoachID] [int] NOT NULL,
	[DesignationID] [nvarchar](3) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_datCoach] PRIMARY KEY CLUSTERED 
(
	[CoachID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datCourse]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datCourse](
	[CourseCode] [nvarchar](10) NOT NULL,
	[CourseName] [nvarchar](100) NOT NULL,
	[CourseDescription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_datCourse] PRIMARY KEY CLUSTERED 
(
	[CourseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datCourseSections]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datCourseSections](
	[SectionID] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [nvarchar](10) NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_datCurriculum] PRIMARY KEY CLUSTERED 
(
	[SectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datForums]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datForums](
	[ForumID] [int] IDENTITY(1,1) NOT NULL,
	[ForumName] [nvarchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[IsSticky] [bit] NOT NULL,
	[IsPrivate] [bit] NOT NULL,
	[UserCreated] [nvarchar](25) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ExpiryDate] [datetime] NULL,
 CONSTRAINT [PK_datForums] PRIMARY KEY CLUSTERED 
(
	[ForumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datPerson]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datPerson](
	[PersonID] [int] IDENTITY(0,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Gender] [char](1) NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[StreetAddress] [nvarchar](50) NULL,
	[StreetAddress2] [nvarchar](50) NULL,
	[City] [nchar](10) NULL,
	[Prov] [nvarchar](2) NULL,
	[PostalCode] [nvarchar](6) NOT NULL,
	[DateOfBirth] [datetime] NULL,
 CONSTRAINT [PK_datPerson] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datPosts]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datPosts](
	[PostID] [int] IDENTITY(0,1) NOT NULL,
	[ForumID] [int] NOT NULL,
	[ParentID] [int] NULL,
	[SubjectLine] [nvarchar](max) NULL,
	[PostedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[PersonID] [int] NULL,
 CONSTRAINT [PK_datPosts] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datQuestionOptions]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datQuestionOptions](
	[optionID] [int] NOT NULL,
	[questionID] [int] NOT NULL,
	[optionText] [nvarchar](150) NOT NULL,
	[displayOrder] [int] NOT NULL,
	[defaultOption] [int] NULL,
	[isCorrect] [bit] NOT NULL,
 CONSTRAINT [PK_datQuestionOptions] PRIMARY KEY CLUSTERED 
(
	[optionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datSurveyQuestions]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datSurveyQuestions](
	[questionID] [int] IDENTITY(1,1) NOT NULL,
	[questionType] [nvarchar](2) NOT NULL,
	[questionText] [nvarchar](250) NOT NULL,
	[hasOtherOption] [bit] NOT NULL,
 CONSTRAINT [PK_datSurveyQuestions] PRIMARY KEY CLUSTERED 
(
	[questionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datSurveys]    Script Date: 2019-08-28 4:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datSurveys](
	[surveyID] [int] IDENTITY(1,1) NOT NULL,
	[surveyName] [nvarchar](15) NULL,
	[isActive] [bit] NULL,
	[dtEffective] [datetime] NULL,
	[dtExpiry] [datetime] NULL,
	[reqToPass] [int] NULL,
 CONSTRAINT [PK_datSurveys] PRIMARY KEY CLUSTERED 
(
	[surveyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jncClassForum]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jncClassForum](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ForumID] [int] NOT NULL,
	[ClassCode] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_jncClassForum_1] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jncClassStudents]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jncClassStudents](
	[StudentProgressID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ClassCode] [nvarchar](10) NOT NULL,
	[Marks] [tinyint] NOT NULL,
	[hasStarted] [bit] NULL,
	[hasCompleted] [bit] NULL,
 CONSTRAINT [PK_jncClassStudents] PRIMARY KEY CLUSTERED 
(
	[StudentProgressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jncCoachClasses]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jncCoachClasses](
	[TeachingID] [int] IDENTITY(1,1) NOT NULL,
	[CoachID] [int] NOT NULL,
	[ClassCode] [nvarchar](10) NOT NULL,
	[Role] [nvarchar](25) NULL,
 CONSTRAINT [PK_jncCoachClasses] PRIMARY KEY CLUSTERED 
(
	[TeachingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jncSectionPages]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jncSectionPages](
	[SectionPageID] [int] IDENTITY(1,1) NOT NULL,
	[SectionID] [int] NOT NULL,
	[PageID] [int] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
 CONSTRAINT [PK_jncCurriculumSection] PRIMARY KEY CLUSTERED 
(
	[SectionPageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jncUsersToPeople]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jncUsersToPeople](
	[id] [nvarchar](450) NOT NULL,
	[personID] [int] NULL,
 CONSTRAINT [PK_jncUsersToPeople] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[linkSurveysQuestions]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[linkSurveysQuestions](
	[surveyQuestionID] [int] IDENTITY(1,1) NOT NULL,
	[surveyID] [int] NULL,
	[questionID] [int] NULL,
	[displayOrder] [int] NULL,
 CONSTRAINT [PK_linkSurveysQuestions] PRIMARY KEY CLUSTERED 
(
	[surveyQuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpCountry]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpCountry](
	[CountryID] [nvarchar](3) NOT NULL,
	[CountryName] [nvarchar](30) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
 CONSTRAINT [PK_lkpCountry] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpDesignation]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpDesignation](
	[DesignationID] [nvarchar](3) NOT NULL,
	[DesignationName] [nvarchar](25) NOT NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_lkpDesignation] PRIMARY KEY CLUSTERED 
(
	[DesignationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpGender]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpGender](
	[GenderID] [char](1) NOT NULL,
	[GenderName] [nvarchar](10) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
 CONSTRAINT [PK_lkpGender] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpProvinces]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpProvinces](
	[ProvinceCode] [nvarchar](2) NOT NULL,
	[ProvinceName] [nvarchar](30) NOT NULL,
	[CountryID] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_lkpProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpSocialMedia]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpSocialMedia](
	[smID] [int] IDENTITY(1,1) NOT NULL,
	[smName] [nvarchar](25) NULL,
	[smIconURL] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_lkpSocialMedia] PRIMARY KEY CLUSTERED 
(
	[smID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lkpSurveyQuestionTypes]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lkpSurveyQuestionTypes](
	[questionType] [nvarchar](2) NOT NULL,
	[qtDescription] [nvarchar](25) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_lkpSurveyQuestionTypes] PRIMARY KEY CLUSTERED 
(
	[questionType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ts_Pages]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ts_Pages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[parentID] [int] NULL,
	[pageTitle] [nvarchar](100) NULL,
	[pageName] [nvarchar](75) NOT NULL,
	[IsSystemRequiredPage] [bit] NULL,
	[IsDefault] [bit] NULL,
	[ExpiryDate] [datetime] NULL,
	[EffectiveDate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[MasterPage] [nvarchar](50) NULL,
	[Theme] [nvarchar](50) NULL,
	[IsSecure] [bit] NULL,
	[PageType] [int] NULL,
 CONSTRAINT [PK_datPages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ts_PageTypes]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ts_PageTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PageType] [nvarchar](50) NULL,
	[IsUsed] [bit] NULL,
 CONSTRAINT [PK_ts_PageTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ts_PageVersionNotes]    Script Date: 2019-08-28 4:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ts_PageVersionNotes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[versionID] [int] NULL,
	[userName] [nvarchar](50) NULL,
	[dtAdded] [datetime] NULL,
	[Note] [ntext] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_datPageVersionNotes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'089645fb-880c-40d0-978f-8bd9dc4af729', N'Coach', N'COACH', N'6204f671-280c-4de2-9491-feff4ff1c91c')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8f59ef02-218f-4426-b63e-bc3e4da785f0', N'Client', N'CLIENT', N'04c23c9f-4f70-4022-b39a-866ec11141b6')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'db5c6ebf-c1dd-47b7-b421-a9f2479ebf18', N'Admin', N'ADMIN', N'4cac45bb-017f-4544-bf01-773f2f8e616c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3cbe996a-872c-489a-b3a7-ef11c75bd3c5', N'db5c6ebf-c1dd-47b7-b421-a9f2479ebf18')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ddec924-9743-425a-be3e-f4ca42f7d57f', N'089645fb-880c-40d0-978f-8bd9dc4af729')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ddec924-9743-425a-be3e-f4ca42f7d57f', N'8f59ef02-218f-4426-b63e-bc3e4da785f0')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ddec924-9743-425a-be3e-f4ca42f7d57f', N'db5c6ebf-c1dd-47b7-b421-a9f2479ebf18')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd0fcabe-70e2-45cd-9c0e-0b86502f89f8', N'089645fb-880c-40d0-978f-8bd9dc4af729')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dc49e2ab-aa94-4599-978f-a70526e5b043', N'8f59ef02-218f-4426-b63e-bc3e4da785f0')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3cbe996a-872c-489a-b3a7-ef11c75bd3c5', N'sobanfarhan@gmail.com', N'SOBANFARHAN@GMAIL.COM', N'sobanfarhan@gmail.com', N'SOBANFARHAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHKQNR0kOp3kXrWVZooLbDigo0dKs5s9t1D5uDet2o+4kRUh1Lr4EsBQYsW+5rkQNw==', N'AU7XNMO3IIPH5S3CR6MT6AE2LFGHBIMN', N'2e4d9d30-9869-4341-8a67-1101ea6a0a45', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9ddec924-9743-425a-be3e-f4ca42f7d57f', N'heather.gamble@womenonthemove.club', N'HEATHER.GAMBLE@WOMENONTHEMOVE.CLUB', N'heather.gamble@womenonthemove.club', N'HEATHER.GAMBLE@WOMENONTHEMOVE.CLUB', 0, N'AQAAAAEAACcQAAAAEJfOpX01pIGzxDvS3aAR7gc2V8+NosDXh1v0WhBF6ICkAR/tTGtMO0O61VYp+riBPQ==', N'3XVS4NZYBK4EE3BIRUDQWS3VALKC6A6C', N'81ebb6ee-5e49-487a-abbf-d28e3c53ae2f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'bd0fcabe-70e2-45cd-9c0e-0b86502f89f8', N'jodi.moore@womenonthemove.club', N'JODI.MOORE@WOMENONTHEMOVE.CLUB', N'jodi.moore@womenonthemove.club', N'JODI.MOORE@WOMENONTHEMOVE.CLUB', 0, N'AQAAAAEAACcQAAAAENk3LkrguYZm77yPAtxmBFMYySyiOJFNRJ/0DCt3SEZO2Xp9poEnt5XkXWrnmm/vYw==', N'6V2UQ4422GYFXZ2DS33HDVIOT2UJE7RY', N'0d85afed-7a0e-4ffb-9fe9-59febe64b26c', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'dc49e2ab-aa94-4599-978f-a70526e5b043', N'dhara.savaliya@dcmail.ca', N'DHARA.SAVALIYA@DCMAIL.CA', N'dhara.savaliya@dcmail.ca', N'DHARA.SAVALIYA@DCMAIL.CA', 0, N'AQAAAAEAACcQAAAAEP7qZ/P4++LP6lkNZEtWLOXhlNlYwmwHMoy3vAouea2ElT/b4eEf3VM60vWRuyHLJA==', N'GZ7CQWKAQN6WCCU3Y4HPCJMCOVCMK2QO', N'ae2d250a-f8fb-4c66-968d-7c105be73f3f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'ACCT 1200', N'BACT', N'Accounting I', N'This course introduces students to fundamental accounting concepts. With these concepts students learn how to keep a simple set of books for a small business; including: journalizing, posting, trial balance, adjusting entries and the preparation of financial statements. Other topics include petty cash, bank reconciliations, internal control and payroll liabilities.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'COMM 3201', N'CPA', N'Communications I For It', N'This course focuses on essential oral and written communication skills for college and career success. Students will be able to practice and apply the principles of effective communication by writing business correspondence using a variety of formats. Effective oral presentation techniques will be examined and applied.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'COMP 1209', N'BACT', N'Business Computer Applications I', N'This course will introduce students to computer skills that are required in businesses today. It provides first year business student with the necessary skills in word processing, presentation creation and spreadsheet to be successful in the business community. Students will develop skills that will be helpful when they are preparing and formatting professional research paper and other documents. They will learn how to develop and enhance presentations; as well as how to prepare and format spreadsheets. This introductory course will prepare students for further study in Excel applications as they continue in their areas of study.

', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'CSYS 1122', N'CPA', N'Computer Systems-Hardware', N'This course introduces the student to the hardware aspect of computer systems. Using hands-on labs, active learning, and lectures, students learn how to identify and describe computer components and peripherals. Students will also learn how to build and troubleshoot systems from a hardware perspective. This course assists students in preparing to service PCs and related equipment and assists in preparing for the CompTIA A+ hardware certification exam. This course prepares students to continue their computer systems education in the CSYS 2122 course in semester 2, focusing on operating systems.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'DBAS 1201', N'CPA', N'Intro To Databases
', N'This course will introduce the students to relational databases to automate data management. The students will be taught: database design emphasizing table relationships; building tables with different data types; form design for data collection; and creating queries and reports; using MS-Access databases. The course will also introduce Structured Query Language (SQL) utilizing data definition as well as manipulation scripts. The laboratory assignments and final project will provide the student with the knowledge needed to design and implement a database for day-to-day business processes and tracking.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'DCOM 1100', N'CPA', N'Data Communications & Networking I ', N'DCOM1100 is the first of four courses that helps prepare the student towards many of the objectives of the Cisco Certified Network Associate (CCNA) accreditation. This course provides students with a knowledge of the principles and topologies used in data communications today by instructing students in introductory network concepts, network devices and protocols. Current market analysis indicates networking and more specifically internetworking is in very large demand. From corporations to small office sites and even into "smart" homes there is a growing need to interconnect computerized equipment. This course gives programming students a base knowledge in networking and prepares systems students to continue their network systems education in the DCOM 2100 course in semester 2.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'HRM 1200', N'BACT', N'Human Resource Management I ', N'This course introduces students to the management aspects of Human Resources in preparation for advanced, specialized studies in the second and third years of the HR program. Specific focus is on the factors that affect the overall atmosphere in the workplace and which contribute to an environment conducive to maximum productivity. Students will be introduced to effective strategies for hiring, motivating, managing, and retaining staff. Students will study the following topics: the strategic importance of Human Resources and the role of the H.R. Manager; competitive challenges facing Human Resources; job analysis and design; Human Resources planning; recruitment and selection; health and safety; and employee rights and discipline. Successful completion of this course and HRM 2200 (with a minimum combined grade of 65%) will qualify as an approved credit towards the academic component of the Certified Human Resources Professionals designation(CHRP) designation granted by the Human Resources Professionals Association (HRPA). Please visit www.hrpa.ca for full details.', CAST(N'2019-05-23T13:45:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'MATH 1110', N'CPA', N'Mathematics For I.T.', N'This course introduces the students the business math and logic fundamentals required in the information Technology (IT) industry. Practical problems in Mathematics for IT to build a solid foundation in the Mathematical skills that are used in the number of Areas such as Networking, Systems Administration, Programming, Database Management, Web Programming and Computer Repair. The main topics covered in this course are listed below: •	Course Outline and SALS (Student Academic Learning Services) •	Mathematics fundamentals (Review of Arithmetic, Algebra, Ratio and Proportion) •	Computer Math (Number Systems: Decimal, Binary, Octal and Hexadecimal; Binary Codes: BCD, ASCII, EBCDIC and UNICODE; Digital Technology Metrics: Bits, Bytes, KB, MB, GB and TB and Binary Arithmetic) •	Business Management (Averages, GPA, CGPA and Simple Interest) •	Financial Management (Payroll, Taxes, Exchange Rates, Discounts, Invoice with Payment Terms, Markup, Markdown, Compound Interest, Mortgages, Loans, Amortization and Cost Management) •	Other topics (Arithmetic and Geometric Sequences, Functions, Graphs, Factorial, Recursion and Statistics) •	Computer Logic (Truth Tables, Basic Logic gates, Boolean Expressions and Boolean Algebra) ¬This course emphasizes problems in Business, Digital and Information Technology. The students are taught how to solve the Mathematical problems with the use of Electronic Calculator and Electronic Spreadsheet (Microsoft Excel). The students connect to SALS (Student Academic Learning Services) to review and improve basic Math skills.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'MGMT 1209', N'BACT', N'Introduction To Business Management', N'This course will cover a wide variety of introductory topics that relate to the management of a company or other organization. The course will focus on the factors that affect the success of businesses in Canada. It will review the entrepreneurial spirit and character it takes for individuals to start their own business. It will explore different kinds of business types and the way they compete in the global economy today. The course introduces management techniques, business planning, as well as ethical business practices. There will be brief coverage of the successful management of financial resources.', CAST(N'2019-05-23T13:45:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'MKTG 1200', N'BACT', N'Marketing I', N'This foundational business course is aimed at giving students a practical introduction and understanding of the marketing process and the activities of marketers. The material covered will teach the student the basis of marketing planning and principles which are necessary for any type of successful business decision and enterprise—product or service, large or small, profit or not-for-profit. The creation of customer value, an analysis of the changing business environment and its impact, identification of the customer and an understanding of their decision making, as well as marketing research methods and their linkage to effective marketing strategies will be examined and applied.', CAST(N'2019-05-23T13:51:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'PROG 1205', N'CPA', N'Introduction To Programming', N'This is an introduction to the general principles of computer programming. Topics will include the selection of basic data types, basic I/O, operators, repetition, flow control, decisions, and the use of single-dimension arrays. This course provides and nurtures a collaborative learning environment to allow students to build the appropriate skills sets for planning, designing and coding computer programs, using a high level language, to solve typical business problems. A structured programming approach is taken for the majority of the course with an introduction to event-driven principles and program design also included. The C# programming language has been selected as the language vehicle for the course.', CAST(N'2018-05-22T13:17:00.000' AS DateTime), CAST(N'2019-05-22T13:17:00.000' AS DateTime), CAST(N'2019-06-22T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClass] ([ClassCode], [CourseCode], [ClassName], [ClassDescription], [CreatedDate], [StartDate], [EndDate], [isActive]) VALUES (N'SCMT 1200', N'BACT', N'Supply Chain Management', N'SCMT1200 introduces students to the important contribution that supply chain managers make to the success of any organization. In the increasingly global economy, every organization relies upon very coordinated support from supply chain partners in order to be successful. Depending upon the nature of the business, a supply chain manager''s job can involve interacting with suppliers, managing transportation of goods, overseeing the day-to-day activities involved in the production of goods and services, solving problems, and working with customers – all with an eye toward meeting quality and efficiency goals. SCMT1200 introduces students to some of the areas of supply chain responsibility, and examines the tools and tradeoffs that supply chain managers consider when making important decisions. Supply chain management is a growing field of employment in the Canadian economy, but is an area that is not widely understood by many students who are beginning their business education. Through this course, some students may discover that supply chain management is well suited to their skills and interests, and may continue their studies in one of the Supply Chain & Operations diploma programs. For students who pursue other areas of business studies, this course will prepare them to interact effectively with the supply chain managers in their own organization when cross-functional decisions are being made.', CAST(N'2019-05-23T13:52:00.000' AS DateTime), CAST(N'2019-01-01T13:17:00.000' AS DateTime), CAST(N'2019-01-31T13:17:00.000' AS DateTime), 1)
INSERT [dbo].[datClient] ([ClientID], [CompanyName], [CompanyDetail], [WebsiteName], [RegisterDate], [IsActive], [ProfileLink], [BusinessType]) VALUES (2, N'ABC Consulting', N'ABC Consulting provides expertise in search marketing solutions for businesses worldwide.', N'www.abcconsulting.com', CAST(N'2018-02-13T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[datClient] ([ClientID], [CompanyName], [CompanyDetail], [WebsiteName], [RegisterDate], [IsActive], [ProfileLink], [BusinessType]) VALUES (3, N'XYZ Company', N'XYZ Company specializing in customer service.', N'www.xyzcompany.com', CAST(N'2017-02-19T00:00:00.000' AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[datClientSocialMedia] ON 

INSERT [dbo].[datClientSocialMedia] ([ID], [clientID], [smTypeID], [URLstring], [isActive], [DisplayOrder]) VALUES (1, 2, NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[datClientSocialMedia] OFF
SET IDENTITY_INSERT [dbo].[datClientSurveyAnswer] ON 

INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (2, 1, N'Dhara', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (3, 2, N'Patel', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (4, 3, N'12/12/1985', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (5, 4, N'Female', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (6, 5, N'dhara@gmail.com', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (7, 6, N'dhara@gmail.com', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (8, 7, N'4164164160', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (9, 8, N'www.dhara.com', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (10, 9, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (11, 10, N'abc street', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (12, 11, N'12', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (13, 12, N'Whitby', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (14, 13, N'ON', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (15, 14, N'L1T4U3', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (16, 15, N'Canada', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (17, 16, N'DAP Consulting', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (18, 17, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (19, 18, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (20, 19, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (21, 20, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (22, 21, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (23, 22, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (24, 23, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (25, 24, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (26, 25, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (27, 26, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (28, 27, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (29, 28, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (30, 29, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (31, 30, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (32, 31, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (33, 32, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (34, 33, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (35, 34, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (36, 35, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (37, 36, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (38, 37, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (39, 38, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (40, 39, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (41, 40, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (42, 41, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (43, 42, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (44, 43, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (45, 44, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (46, 45, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (47, 46, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (48, 47, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (49, 48, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (50, 49, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (51, 50, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (52, 51, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (53, 52, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (54, 53, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (55, 54, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (56, 55, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (57, 56, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (58, 57, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (59, 58, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (60, 59, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (61, 60, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (62, 61, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (63, 62, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (64, 63, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (65, 64, N'', 1)
INSERT [dbo].[datClientSurveyAnswer] ([AnswerToQuestionID], [QuestionIndex], [AnswerText], [SurveyID]) VALUES (66, 65, N'', 1)
SET IDENTITY_INSERT [dbo].[datClientSurveyAnswer] OFF
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (0, N'Survey Question')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (1, N'First Name')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (2, N'Last Name')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (3, N'Date Of Birth')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (4, N'Gender')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (5, N'Email Address')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (6, N'Confirm Email Address')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (7, N'Phone Number')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (8, N'Website')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (9, N'Profile Link')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (10, N'Street Address')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (11, N'Apt / Suite / Other')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (12, N'City')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (13, N'Province')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (14, N'Postal Code')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (15, N'Country')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (16, N'Venture Name')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (17, N'Type of Venture')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (18, N'Industry /Support')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (19, N'Stage of Venture')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (20, N'Venture Website')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (21, N'Date of Founding')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (22, N'How did you hear about AI sales coaching program?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (23, N'Which programs are you actively engaged with to help your drive sales?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (24, N'Do you have a working prototype or MVP?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (25, N'Do you have any paying customers?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (26, N'Do you have any non-paying users/customers?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (27, N'Do you have any patents filed/ granted?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (28, N'No. of patents filed?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (29, N'No. of patents granted?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (30, N'What is your annual revenue for the past year?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (31, N'Please describe the ownership of the patents.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (32, N'Have you received any external funding?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (33, N'Please provide the details of the funding you''ve received.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (34, N'Is your start-up an extension of, or a spin-off from another business/organization?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (35, N'Provide the name of your parent organization?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (36, N'Briefly describe your venture - 25 words.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (37, N'Describe how does your product or service work - 100 words.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (38, N'Describe who are your target customers - 100 words')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (39, N'Describe how does your venture generate revenue - 100 words')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (40, N'Describe who are your current competitors and your future anticipated competitors - 100 words')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (41, N'Explain what differentiates you from your competitors - 100 words.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (42, N'Explain how you plan to protect your venture from imitators - 100 words')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (43, N'How do you think the AI Sales Coaching Program can help you succeed?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (44, N'What is the social mission for your not-for-profit/social enterprise/co-operative?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (45, N'Describe how your venture is going to fulfill your social mission and how will you know you are successful')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (46, N'Describe how your venture is going to fulfill your social mission and how will you know you are successful')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (47, N'Include any employees, and contractors. Do NOT include co-founders, mentors, volunteers or advisors.')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (48, N'Who is responsible for selling?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (49, N'What is their level of professional sales experience?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (50, N'What are the major sales challenges?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (51, N'How long is the sales cycle?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (52, N'Who is responsible for selling?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (53, N'What is the average revenue per sale?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (54, N'How much client “live” conversation is involved in your pre-sales activities?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (55, N'Do you sell directly over the phone?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (56, N'Do you sell directly in face to face settings?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (57, N'What are the titles of your primary decision makers?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (58, N'How many prospects does the salesperson manage?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (59, N'Do you use a CRM solution?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (60, N'What are the main steps in your sales process?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (61, N'What are your annual sales targets?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (62, N'How often do you meet or exceed your monthly sales targets?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (63, N'How often do you meet or exceed your annual sales targets?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (64, N'How much do you wish to grow your sales by?')
INSERT [dbo].[datClientSurveyQuestion] ([QuestionIndex], [QuestionText]) VALUES (65, N'Waiver')
SET IDENTITY_INSERT [dbo].[datClientToSurvey] ON 

INSERT [dbo].[datClientToSurvey] ([ClientToSurveyID], [SurveyID], [ClientID], [Date]) VALUES (1, 1, 2, CAST(N'2019-08-28T16:08:34.053' AS DateTime))
INSERT [dbo].[datClientToSurvey] ([ClientToSurveyID], [SurveyID], [ClientID], [Date]) VALUES (2, 2, 3, CAST(N'2019-08-28T16:08:45.980' AS DateTime))
SET IDENTITY_INSERT [dbo].[datClientToSurvey] OFF
INSERT [dbo].[datCoach] ([CoachID], [DesignationID], [StartDate], [EndDate], [IsActive]) VALUES (8, N'FM', CAST(N'2017-01-01T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[datCoach] ([CoachID], [DesignationID], [StartDate], [EndDate], [IsActive]) VALUES (10, N'HR', CAST(N'2017-05-01T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'AIDI', N'Artificial Intelligence Analysis, Design and Implementation', N'Analyze, design, and implement artificial intelligence (AI) systems through the application of systematic approaches and methodologies to meet organizational needs.', CAST(N'2019-05-22T12:13:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'ARHY', N'Architectural Technology', N'This program, designed to prepare you for an exciting career in architectural technology, will appeal to your creative and analytical side with instruction in freehand sketching; sustainability and green technology; history of architecture; renovation and restoration; site planning; and technical communications.', CAST(N'2019-05-22T12:18:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'BACT', N'Accounting – Business Administration', N'Used in a variety of organizations, accounting involves measuring business activities; processing information into financial reports and statements; and communicating information to the appropriate decision-makers.', CAST(N'2019-05-22T12:15:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'CPA', N'Computer Programmer Analyst', N'This program offers comprehensive study in information technology, systems methodologies and application programming, built on a solid foundation of business expertise. The curriculum includes in-depth instruction and the practical application of structured, mainframe and object-oriented programming languages.', CAST(N'2019-05-22T12:08:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'CSK', N'Culinary Skills', N'Students in this program will benefit from working and learning in Bistro ’67, a full-service, green-certified teaching and learning restaurant operated by staff and students.', CAST(N'2019-05-22T12:20:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'CWBD', N'Contemporary Web Design', N'This program will prepare you for an exciting career in the field of web design. Contemporary web design is the intersection of corporate appearance and technical functionality. You will become a highly competent designer, able to deliver dynamic, cross-media content in a complex and competitive business environment.', CAST(N'2019-05-22T12:19:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'ELEC', N'Electrical Techniques', N'The Electrical Techniques program focuses on residential installations and will provide you with the basic skills to successfully install grounding/bonding for a specified number of applications.', CAST(N'2019-05-22T12:21:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'FINC', N'Finance – Business', N'The Finance – Business program will provide students with the skills and training required to work in a variety of areas within financial services including, firms dealing with pension plans, scholarships, educational savings plans, and investments funds. In addition to a foundation in business, learning will be focused on a range of areas including, personal financial management, tax and retirement planning, investments and estate planning, with an emphasis on training in financial services. Graduates of this program will have skills such as financial analysis, planning and control.', CAST(N'2019-05-22T12:21:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'HRTU', N'', N'HR professionals work in partnership with business managers to take care of a company’s largest asset – its people. To help a business run, HR staff provide advice to department supervisors on a range of employee relations issues, design and deliver a range of programs and services focused on individual and team needs, and create company policies that support and promote a workplace culture based on fairness, equity and personal and professional growth.', CAST(N'2019-05-22T12:27:00.000' AS DateTime), 1)
INSERT [dbo].[datCourse] ([CourseCode], [CourseName], [CourseDescription], [CreatedDate], [isActive]) VALUES (N'JOMM', N'Journalism – Mass Media/Journalism', N'This program embraces the broad changes occurring in the media landscape and offers a progressive curriculum that will allow you to focus on development of journalism, social media skills and content creation on all platforms – online, print and broadcast.', CAST(N'2019-05-22T12:28:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[datForums] ON 

INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (0, N'default', 1, 1, 0, 0, N'0', CAST(N'2019-04-24T15:18:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (1, N'Test', 1, 1, 0, 0, N'2', CAST(N'2019-05-27T10:12:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (2, N'Test1', 1, 1, 0, 0, N'2', CAST(N'2019-05-27T10:18:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (4, N'Test2', 1, 1, 0, 0, N'2', CAST(N'2019-05-27T10:18:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (5, N'Test3', 1, 1, 0, 0, N'2', CAST(N'2019-05-27T10:19:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (6, N'Test4', 1, 1, 0, 0, N'2', CAST(N'2019-05-27T10:19:00.000' AS DateTime), NULL)
INSERT [dbo].[datForums] ([ForumID], [ForumName], [IsActive], [IsApproved], [IsSticky], [IsPrivate], [UserCreated], [CreatedDate], [ExpiryDate]) VALUES (7, N'Test5', 1, 1, 0, 0, N'0', CAST(N'2019-05-27T10:19:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[datForums] OFF
SET IDENTITY_INSERT [dbo].[datPerson] ON 

INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (0, N'Test', N'Test1', N'F', N'416-555-5555', N'123, Street 123', N'Street 2 123', N'Whitby    ', N'ON', N'L1R2V6', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (2, N'Dhara', N'Savaliya', N'F', N'416-666-6666', N'111 Street', N'Street 111', N'Oshawa    ', N'ON', N'L1T5U4', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (3, N'Soban', N'Farhan', N'M', N'416-661-6661', N'121 Street ', N'Street 121', N'Oshawa    ', N'ON', N'L1U4R2', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (6, N'Avindi', N'Premaratne', N'F', N'416-662-6622', N'22 Street', N'Street 22', N'Whitby    ', N'ON', N'L1R1A1', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (8, N'Heather', N'Gamble', N'F', N'416-111-1111', N'21 Street', N'Street 21', N'Toronto   ', N'ON', N'M9V3U3', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (9, N'Karen', N'Snow', N'F', N'416-121-1112', N'20 Street', N'Street 20', N'Toronto   ', N'ON', N'M6Y5R3', NULL)
INSERT [dbo].[datPerson] ([PersonID], [FirstName], [LastName], [Gender], [PhoneNumber], [StreetAddress], [StreetAddress2], [City], [Prov], [PostalCode], [DateOfBirth]) VALUES (10, N'Jodi', N'Moore', N'F', N'416-661-1111', N'19 Street', N'Street 19', N'Vaughan   ', N'ON', N'M6I4E3', NULL)
SET IDENTITY_INSERT [dbo].[datPerson] OFF
SET IDENTITY_INSERT [dbo].[datPosts] ON 

INSERT [dbo].[datPosts] ([PostID], [ForumID], [ParentID], [SubjectLine], [PostedDate], [IsActive], [IsApproved], [PersonID]) VALUES (0, 0, 0, N'Test', CAST(N'2019-04-24T15:20:00.000' AS DateTime), 1, 1, 0)
INSERT [dbo].[datPosts] ([PostID], [ForumID], [ParentID], [SubjectLine], [PostedDate], [IsActive], [IsApproved], [PersonID]) VALUES (1, 1, 0, N'Test1', CAST(N'2019-05-27T10:14:00.000' AS DateTime), 1, 1, 2)
INSERT [dbo].[datPosts] ([PostID], [ForumID], [ParentID], [SubjectLine], [PostedDate], [IsActive], [IsApproved], [PersonID]) VALUES (2, 1, 1, N'Test2', CAST(N'2019-05-27T10:15:00.000' AS DateTime), 1, 1, 2)
SET IDENTITY_INSERT [dbo].[datPosts] OFF
SET IDENTITY_INSERT [dbo].[jncClassForum] ON 

INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (0, 0, N'ACCT 1200')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (1, 1, N'COMP 1209')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (2, 2, N'ACCT 1200')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (3, 4, N'CSYS 1122')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (4, 5, N'CSYS 1122')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (5, 6, N'MGMT 1209')
INSERT [dbo].[jncClassForum] ([ItemID], [ForumID], [ClassCode]) VALUES (6, 7, N'PROG 1205')
SET IDENTITY_INSERT [dbo].[jncClassForum] OFF
SET IDENTITY_INSERT [dbo].[jncClassStudents] ON 

INSERT [dbo].[jncClassStudents] ([StudentProgressID], [ClientID], [ClassCode], [Marks], [hasStarted], [hasCompleted]) VALUES (1, 2, N'SCMT 1200', 100, 1, 1)
INSERT [dbo].[jncClassStudents] ([StudentProgressID], [ClientID], [ClassCode], [Marks], [hasStarted], [hasCompleted]) VALUES (2, 2, N'MATH 1110', 95, 1, 1)
INSERT [dbo].[jncClassStudents] ([StudentProgressID], [ClientID], [ClassCode], [Marks], [hasStarted], [hasCompleted]) VALUES (3, 2, N'DBAS 1201', 85, 1, 0)
INSERT [dbo].[jncClassStudents] ([StudentProgressID], [ClientID], [ClassCode], [Marks], [hasStarted], [hasCompleted]) VALUES (4, 2, N'PROG 1205', 95, 1, 0)
SET IDENTITY_INSERT [dbo].[jncClassStudents] OFF
SET IDENTITY_INSERT [dbo].[jncCoachClasses] ON 

INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (3, 8, N'ACCT 1200', N'FM')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (4, 10, N'COMM 3201', N'HR')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (5, 8, N'DBAS 1201', N'FM')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (6, 8, N'MKTG 1200', N'FM')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (7, 8, N'MGMT 1209', N'FM')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (8, 8, N'MATH 1110', N'FM')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (9, 10, N'COMP 1209', N'HR')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (10, 10, N'CSYS 1122', N'HR')
INSERT [dbo].[jncCoachClasses] ([TeachingID], [CoachID], [ClassCode], [Role]) VALUES (11, 10, N'SCMT 1200', N'HR')
SET IDENTITY_INSERT [dbo].[jncCoachClasses] OFF
INSERT [dbo].[jncUsersToPeople] ([id], [personID]) VALUES (N'3cbe996a-872c-489a-b3a7-ef11c75bd3c5', 3)
INSERT [dbo].[jncUsersToPeople] ([id], [personID]) VALUES (N'9ddec924-9743-425a-be3e-f4ca42f7d57f', 8)
INSERT [dbo].[jncUsersToPeople] ([id], [personID]) VALUES (N'bd0fcabe-70e2-45cd-9c0e-0b86502f89f8', 10)
INSERT [dbo].[jncUsersToPeople] ([id], [personID]) VALUES (N'dc49e2ab-aa94-4599-978f-a70526e5b043', 2)
INSERT [dbo].[lkpCountry] ([CountryID], [CountryName], [DisplayOrder]) VALUES (N'CAN', N'Canada', 2)
INSERT [dbo].[lkpCountry] ([CountryID], [CountryName], [DisplayOrder]) VALUES (N'CHL', N'Chile', 10)
INSERT [dbo].[lkpCountry] ([CountryID], [CountryName], [DisplayOrder]) VALUES (N'CHN', N'China', 10)
INSERT [dbo].[lkpCountry] ([CountryID], [CountryName], [DisplayOrder]) VALUES (N'ITA', N'Italy', 10)
INSERT [dbo].[lkpCountry] ([CountryID], [CountryName], [DisplayOrder]) VALUES (N'USA', N'United States of America', 1)
INSERT [dbo].[lkpDesignation] ([DesignationID], [DesignationName], [DisplayOrder]) VALUES (N'FM', N'Financial Management', 2)
INSERT [dbo].[lkpDesignation] ([DesignationID], [DesignationName], [DisplayOrder]) VALUES (N'HR', N'Human Resources', 1)
INSERT [dbo].[lkpDesignation] ([DesignationID], [DesignationName], [DisplayOrder]) VALUES (N'LM', N'Leadership and Management', 10)
INSERT [dbo].[lkpDesignation] ([DesignationID], [DesignationName], [DisplayOrder]) VALUES (N'SM', N'Sales and Marketing', 10)
INSERT [dbo].[lkpDesignation] ([DesignationID], [DesignationName], [DisplayOrder]) VALUES (N'SP', N'Strategic Planning', 10)
INSERT [dbo].[lkpGender] ([GenderID], [GenderName], [DisplayOrder]) VALUES (N'F', N'Female', 1)
INSERT [dbo].[lkpGender] ([GenderID], [GenderName], [DisplayOrder]) VALUES (N'M', N'Male', 2)
INSERT [dbo].[lkpGender] ([GenderID], [GenderName], [DisplayOrder]) VALUES (N'O', N'Others', 10)
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AB', N'Alberta', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AE', N'APO - Europe', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AK', N'Alaska', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AL', N'Alabama', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AP', N'APO - Pacific', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AR', N'Arkansas', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AS', N'American Samoa', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'AZ', N'Arizona', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'BC', N'British Columbia', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'CA', N'California', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'CO', N'Colorado', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'CT', N'Connecticut', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'DC', N'District of Columbia', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'DE', N'Delaware', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'FL', N'Florida', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'FM', N'Fed states - Micronesia', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'GA', N'Georgia', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'GU', N'Guam', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'HI', N'Hawaii', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'IA', N'Iowa', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'ID', N'Idaho', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'IL', N'Illinois', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'IN', N'Indiana', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'KS', N'Kansas', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'KY', N'Kentucky', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'LA', N'Louisiana', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MA', N'Massachusetts', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MB', N'Manitoba', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MD', N'Maryland', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'ME', N'Maine', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MH', N'Marshall Islands', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MI', N'Michigan', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MN', N'Minnesota', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MO', N'Missouri', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MP', N'N Mariana Islands', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MS', N'Mississippi', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'MT', N'Montana', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NB', N'New Brunswick', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NC', N'North Carolina', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'ND', N'North Dakota', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NE', N'Nebraska', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NH', N'New Hampshire', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NJ', N'New Jersey', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NL', N'Newfoundland & Labrador', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NM', N'New Mexico', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NS', N'Nova Scotia', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NT', N'Northwest Territories', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NU', N'Nunavut', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NV', N'Nevada', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'NY', N'New York', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'OH', N'Ohio', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'OK', N'Oklahoma', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'ON', N'Ontario', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'OR', N'Oregon', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'PA', N'Pennsylvania', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'PE', N'Prince Edward Island', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'PR', N'Puerto Rico', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'PW', N'Palau', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'QC', N'Provence de Québec', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'RI', N'Rhode Island', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'SC', N'South Carolina', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'SD', N'South Dakota', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'SK', N'Saskatchewan', N'CAN')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'TN', N'Tennessee', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'TX', N'Texas', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'UT', N'Utah', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'VA', N'Virginia', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'VI', N'Virgin Islands', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'VT', N'Vermont', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'WA', N'Washington', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'WI', N'Wisconsin', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'WV', N'West Virginia', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'WY', N'Wyoming', N'USA')
INSERT [dbo].[lkpProvinces] ([ProvinceCode], [ProvinceName], [CountryID]) VALUES (N'YT', N'Yukon Territory', N'CAN')
SET IDENTITY_INSERT [dbo].[lkpSocialMedia] ON 

INSERT [dbo].[lkpSocialMedia] ([smID], [smName], [smIconURL], [isActive]) VALUES (1, N'Facebook', NULL, 1)
INSERT [dbo].[lkpSocialMedia] ([smID], [smName], [smIconURL], [isActive]) VALUES (2, N'Twitter', NULL, 1)
INSERT [dbo].[lkpSocialMedia] ([smID], [smName], [smIconURL], [isActive]) VALUES (3, N'Linked In', NULL, 1)
INSERT [dbo].[lkpSocialMedia] ([smID], [smName], [smIconURL], [isActive]) VALUES (4, N'Instagram', NULL, 1)
INSERT [dbo].[lkpSocialMedia] ([smID], [smName], [smIconURL], [isActive]) VALUES (5, N'Snapchat', NULL, 1)
SET IDENTITY_INSERT [dbo].[lkpSocialMedia] OFF
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'CA', N'Choose All That Apply', 1)
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'LA', N'Long Answer', 1)
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'MA', N'Match', 1)
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'MC', N'Multiple Choice', 1)
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'NA', N'Not Applicable', 1)
INSERT [dbo].[lkpSurveyQuestionTypes] ([questionType], [qtDescription], [isActive]) VALUES (N'SA', N'Short Answer', 1)
ALTER TABLE [dbo].[datClass] ADD  CONSTRAINT [DF_datClass_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[datClass] ADD  CONSTRAINT [DF_datClass_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[datClient] ADD  CONSTRAINT [DF_datClient_ClientID]  DEFAULT ((1)) FOR [ClientID]
GO
ALTER TABLE [dbo].[datClientResponsesMain] ADD  CONSTRAINT [DF_datClientResponsesMain_dtStarted]  DEFAULT (getdate()) FOR [dtStarted]
GO
ALTER TABLE [dbo].[datClientResponsesMain] ADD  CONSTRAINT [DF_datClientResponsesMain_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[datClientSocialMedia] ADD  CONSTRAINT [DF_datClientSocialMedia_clientID]  DEFAULT ((0)) FOR [clientID]
GO
ALTER TABLE [dbo].[datClientSocialMedia] ADD  CONSTRAINT [DF_datClientSocialMedia_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] ADD  CONSTRAINT [DF_datClientSurveyAnswer_SurveyID]  DEFAULT ((1)) FOR [SurveyID]
GO
ALTER TABLE [dbo].[datClientToSurvey] ADD  CONSTRAINT [DF_datClientToSurvey_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[datCoach] ADD  CONSTRAINT [DF_datCoach_CoachID]  DEFAULT ((1)) FOR [CoachID]
GO
ALTER TABLE [dbo].[datCourse] ADD  CONSTRAINT [DF__datCourse__Creat__52593CB8]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[datCourse] ADD  CONSTRAINT [DF_datCourse_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[datForums] ADD  CONSTRAINT [DF_datForums_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[datForums] ADD  CONSTRAINT [DF_datForums_IsApproved]  DEFAULT ((1)) FOR [IsApproved]
GO
ALTER TABLE [dbo].[datForums] ADD  CONSTRAINT [DF_datForums_IsSticky]  DEFAULT ((0)) FOR [IsSticky]
GO
ALTER TABLE [dbo].[datForums] ADD  CONSTRAINT [DF_datForums_IsPrivate]  DEFAULT ((0)) FOR [IsPrivate]
GO
ALTER TABLE [dbo].[datForums] ADD  CONSTRAINT [DF__datForums__Creat__22751F6C]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[datPosts] ADD  CONSTRAINT [DF_datPosts_PostedDate]  DEFAULT (getdate()) FOR [PostedDate]
GO
ALTER TABLE [dbo].[datPosts] ADD  CONSTRAINT [DF_datPosts_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[datPosts] ADD  CONSTRAINT [DF_datPosts_IsApproved]  DEFAULT ((1)) FOR [IsApproved]
GO
ALTER TABLE [dbo].[datQuestionOptions] ADD  CONSTRAINT [DF_datQuestionOptions_defaultOption]  DEFAULT ((0)) FOR [defaultOption]
GO
ALTER TABLE [dbo].[datQuestionOptions] ADD  CONSTRAINT [DF_datQuestionOptions_isCorrect]  DEFAULT ((0)) FOR [isCorrect]
GO
ALTER TABLE [dbo].[datSurveyQuestions] ADD  CONSTRAINT [DF_datSurveyQuestions_hasOtherOption]  DEFAULT ((1)) FOR [hasOtherOption]
GO
ALTER TABLE [dbo].[datSurveys] ADD  CONSTRAINT [DF_datSurveys_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[datSurveys] ADD  CONSTRAINT [DF_datSurveys_dtEffective]  DEFAULT (getdate()) FOR [dtEffective]
GO
ALTER TABLE [dbo].[datSurveys] ADD  CONSTRAINT [DF_datSurveys_dtExpiry]  DEFAULT (getdate()+(3650)) FOR [dtExpiry]
GO
ALTER TABLE [dbo].[datSurveys] ADD  CONSTRAINT [DF_datSurveys_reqToPass]  DEFAULT ((0)) FOR [reqToPass]
GO
ALTER TABLE [dbo].[jncClassStudents] ADD  CONSTRAINT [DF_jncClassStudents_Marks]  DEFAULT ((0)) FOR [Marks]
GO
ALTER TABLE [dbo].[jncClassStudents] ADD  CONSTRAINT [DF_jncClassStudents_hasStarted]  DEFAULT ((0)) FOR [hasStarted]
GO
ALTER TABLE [dbo].[jncClassStudents] ADD  CONSTRAINT [DF_jncClassStudents_hasCompleted]  DEFAULT ((0)) FOR [hasCompleted]
GO
ALTER TABLE [dbo].[lkpSocialMedia] ADD  CONSTRAINT [DF_lkpSocialMedia_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[lkpSurveyQuestionTypes] ADD  CONSTRAINT [DF_lkpQuestionTypes_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_datPages_IsSystemRequiredPage]  DEFAULT ((0)) FOR [IsSystemRequiredPage]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_datPages_IsDefault]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_datPages_ExpiryDate]  DEFAULT (getdate()) FOR [ExpiryDate]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_datPages_EffectiveDate]  DEFAULT (getdate()) FOR [EffectiveDate]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_datPages_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_ts_Pages_IsSecure]  DEFAULT ((0)) FOR [IsSecure]
GO
ALTER TABLE [dbo].[ts_Pages] ADD  CONSTRAINT [DF_ts_Pages_PageType]  DEFAULT ((1)) FOR [PageType]
GO
ALTER TABLE [dbo].[ts_PageTypes] ADD  CONSTRAINT [DF_ts_PageTypes_IsUsed]  DEFAULT ((1)) FOR [IsUsed]
GO
ALTER TABLE [dbo].[ts_PageVersions] ADD  CONSTRAINT [DF_datPageVersions_PageID]  DEFAULT ((0)) FOR [PageID]
GO
ALTER TABLE [dbo].[ts_PageVersions] ADD  CONSTRAINT [DF_datPageVersions_IsApproved]  DEFAULT ((1)) FOR [IsApproved]
GO
ALTER TABLE [dbo].[ts_PageVersions] ADD  CONSTRAINT [DF_ts_PageVersions_ViewCount]  DEFAULT ((0)) FOR [ViewCount]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[datClass]  WITH CHECK ADD  CONSTRAINT [FK_datClass_datCourse1] FOREIGN KEY([CourseCode])
REFERENCES [dbo].[datCourse] ([CourseCode])
GO
ALTER TABLE [dbo].[datClass] CHECK CONSTRAINT [FK_datClass_datCourse1]
GO
ALTER TABLE [dbo].[datClient]  WITH CHECK ADD  CONSTRAINT [FK_datClient_datPerson] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datPerson] ([PersonID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[datClient] CHECK CONSTRAINT [FK_datClient_datPerson]
GO
ALTER TABLE [dbo].[datClientResponsesOptions]  WITH CHECK ADD  CONSTRAINT [FK_datClientResponsesOptions_datClientResponsesMain] FOREIGN KEY([clientResponseID])
REFERENCES [dbo].[datClientResponsesMain] ([clientResponseID])
GO
ALTER TABLE [dbo].[datClientResponsesOptions] CHECK CONSTRAINT [FK_datClientResponsesOptions_datClientResponsesMain]
GO
ALTER TABLE [dbo].[datClientResponsesOptions]  WITH CHECK ADD  CONSTRAINT [FK_datClientResponsesOptions_datQuestionOptions] FOREIGN KEY([optionID])
REFERENCES [dbo].[datQuestionOptions] ([optionID])
GO
ALTER TABLE [dbo].[datClientResponsesOptions] CHECK CONSTRAINT [FK_datClientResponsesOptions_datQuestionOptions]
GO
ALTER TABLE [dbo].[datClientResponsesOptions]  WITH CHECK ADD  CONSTRAINT [FK_datClientResponsesOptions_linkSurveysQuestions] FOREIGN KEY([SurveyQuestionID])
REFERENCES [dbo].[linkSurveysQuestions] ([surveyQuestionID])
GO
ALTER TABLE [dbo].[datClientResponsesOptions] CHECK CONSTRAINT [FK_datClientResponsesOptions_linkSurveysQuestions]
GO
ALTER TABLE [dbo].[datClientResponsesText]  WITH CHECK ADD  CONSTRAINT [FK_datClientResponsesText_datClientResponsesMain] FOREIGN KEY([clientResponseID])
REFERENCES [dbo].[datClientResponsesMain] ([clientResponseID])
GO
ALTER TABLE [dbo].[datClientResponsesText] CHECK CONSTRAINT [FK_datClientResponsesText_datClientResponsesMain]
GO
ALTER TABLE [dbo].[datClientResponsesText]  WITH CHECK ADD  CONSTRAINT [FK_datClientResponsesText_linkSurveysQuestions] FOREIGN KEY([surveyQuestionID])
REFERENCES [dbo].[linkSurveysQuestions] ([surveyQuestionID])
GO
ALTER TABLE [dbo].[datClientResponsesText] CHECK CONSTRAINT [FK_datClientResponsesText_linkSurveysQuestions]
GO
ALTER TABLE [dbo].[datClientSocialMedia]  WITH CHECK ADD  CONSTRAINT [FK_datClientSocialMedia_datClient] FOREIGN KEY([clientID])
REFERENCES [dbo].[datClient] ([ClientID])
GO
ALTER TABLE [dbo].[datClientSocialMedia] CHECK CONSTRAINT [FK_datClientSocialMedia_datClient]
GO
ALTER TABLE [dbo].[datClientSocialMedia]  WITH CHECK ADD  CONSTRAINT [FK_datClientSocialMedia_lkpSocialMedia] FOREIGN KEY([smTypeID])
REFERENCES [dbo].[lkpSocialMedia] ([smID])
GO
ALTER TABLE [dbo].[datClientSocialMedia] CHECK CONSTRAINT [FK_datClientSocialMedia_lkpSocialMedia]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer]  WITH CHECK ADD  CONSTRAINT [FK_datClientSurveyAnswer_datClientSurveyQuestion] FOREIGN KEY([QuestionIndex])
REFERENCES [dbo].[datClientSurveyQuestion] ([QuestionIndex])
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] CHECK CONSTRAINT [FK_datClientSurveyAnswer_datClientSurveyQuestion]
GO
ALTER TABLE [dbo].[datClientSurveyAnswer]  WITH CHECK ADD  CONSTRAINT [FK_datClientSurveyAnswer_datClientToSurvey1] FOREIGN KEY([SurveyID])
REFERENCES [dbo].[datClientToSurvey] ([SurveyID])
GO
ALTER TABLE [dbo].[datClientSurveyAnswer] CHECK CONSTRAINT [FK_datClientSurveyAnswer_datClientToSurvey1]
GO
ALTER TABLE [dbo].[datClientToSurvey]  WITH CHECK ADD  CONSTRAINT [FK_datClientToSurvey_datClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClient] ([ClientID])
GO
ALTER TABLE [dbo].[datClientToSurvey] CHECK CONSTRAINT [FK_datClientToSurvey_datClient]
GO
ALTER TABLE [dbo].[datCoach]  WITH CHECK ADD  CONSTRAINT [FK_datCoach_datPerson] FOREIGN KEY([CoachID])
REFERENCES [dbo].[datPerson] ([PersonID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[datCoach] CHECK CONSTRAINT [FK_datCoach_datPerson]
GO
ALTER TABLE [dbo].[datCoach]  WITH CHECK ADD  CONSTRAINT [FK_datCoach_lkpDesignation] FOREIGN KEY([DesignationID])
REFERENCES [dbo].[lkpDesignation] ([DesignationID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[datCoach] CHECK CONSTRAINT [FK_datCoach_lkpDesignation]
GO
ALTER TABLE [dbo].[datCourseSections]  WITH CHECK ADD  CONSTRAINT [FK_datCurriculum_datCourse] FOREIGN KEY([CourseCode])
REFERENCES [dbo].[datCourse] ([CourseCode])
GO
ALTER TABLE [dbo].[datCourseSections] CHECK CONSTRAINT [FK_datCurriculum_datCourse]
GO
ALTER TABLE [dbo].[datPerson]  WITH CHECK ADD  CONSTRAINT [FK_datPerson_lkpGender] FOREIGN KEY([Gender])
REFERENCES [dbo].[lkpGender] ([GenderID])
GO
ALTER TABLE [dbo].[datPerson] CHECK CONSTRAINT [FK_datPerson_lkpGender]
GO
ALTER TABLE [dbo].[datPerson]  WITH CHECK ADD  CONSTRAINT [FK_datPerson_lkpProvinces] FOREIGN KEY([Prov])
REFERENCES [dbo].[lkpProvinces] ([ProvinceCode])
GO
ALTER TABLE [dbo].[datPerson] CHECK CONSTRAINT [FK_datPerson_lkpProvinces]
GO
ALTER TABLE [dbo].[datPosts]  WITH CHECK ADD  CONSTRAINT [FK_datPosts_datForums] FOREIGN KEY([ForumID])
REFERENCES [dbo].[datForums] ([ForumID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[datPosts] CHECK CONSTRAINT [FK_datPosts_datForums]
GO
ALTER TABLE [dbo].[datPosts]  WITH CHECK ADD  CONSTRAINT [FK_datPosts_datPosts] FOREIGN KEY([ParentID])
REFERENCES [dbo].[datPosts] ([PostID])
GO
ALTER TABLE [dbo].[datPosts] CHECK CONSTRAINT [FK_datPosts_datPosts]
GO
ALTER TABLE [dbo].[datQuestionOptions]  WITH CHECK ADD  CONSTRAINT [FK_datQuestionOptions_datSurveyQuestions] FOREIGN KEY([questionID])
REFERENCES [dbo].[datSurveyQuestions] ([questionID])
GO
ALTER TABLE [dbo].[datQuestionOptions] CHECK CONSTRAINT [FK_datQuestionOptions_datSurveyQuestions]
GO
ALTER TABLE [dbo].[datSurveyQuestions]  WITH CHECK ADD  CONSTRAINT [FK_datSurveyQuestions_lkpSurveyQuestionTypes] FOREIGN KEY([questionType])
REFERENCES [dbo].[lkpSurveyQuestionTypes] ([questionType])
GO
ALTER TABLE [dbo].[datSurveyQuestions] CHECK CONSTRAINT [FK_datSurveyQuestions_lkpSurveyQuestionTypes]
GO
ALTER TABLE [dbo].[jncClassForum]  WITH CHECK ADD  CONSTRAINT [FK_jncClassForum_datClass] FOREIGN KEY([ClassCode])
REFERENCES [dbo].[datClass] ([ClassCode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[jncClassForum] CHECK CONSTRAINT [FK_jncClassForum_datClass]
GO
ALTER TABLE [dbo].[jncClassForum]  WITH CHECK ADD  CONSTRAINT [FK_jncClassForum_datForums] FOREIGN KEY([ForumID])
REFERENCES [dbo].[datForums] ([ForumID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[jncClassForum] CHECK CONSTRAINT [FK_jncClassForum_datForums]
GO
ALTER TABLE [dbo].[jncClassStudents]  WITH CHECK ADD  CONSTRAINT [FK_jncClassStudents_datClass] FOREIGN KEY([ClassCode])
REFERENCES [dbo].[datClass] ([ClassCode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[jncClassStudents] CHECK CONSTRAINT [FK_jncClassStudents_datClass]
GO
ALTER TABLE [dbo].[jncClassStudents]  WITH CHECK ADD  CONSTRAINT [FK_jncClassStudents_datClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClient] ([ClientID])
GO
ALTER TABLE [dbo].[jncClassStudents] CHECK CONSTRAINT [FK_jncClassStudents_datClient]
GO
ALTER TABLE [dbo].[jncCoachClasses]  WITH CHECK ADD  CONSTRAINT [FK_jncCoachClasses_datClass] FOREIGN KEY([ClassCode])
REFERENCES [dbo].[datClass] ([ClassCode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[jncCoachClasses] CHECK CONSTRAINT [FK_jncCoachClasses_datClass]
GO
ALTER TABLE [dbo].[jncCoachClasses]  WITH CHECK ADD  CONSTRAINT [FK_jncCoachClasses_datCoach] FOREIGN KEY([CoachID])
REFERENCES [dbo].[datCoach] ([CoachID])
GO
ALTER TABLE [dbo].[jncCoachClasses] CHECK CONSTRAINT [FK_jncCoachClasses_datCoach]
GO
ALTER TABLE [dbo].[jncSectionPages]  WITH CHECK ADD  CONSTRAINT [FK_jncCurriculumSection_datCurriculum] FOREIGN KEY([SectionID])
REFERENCES [dbo].[datCourseSections] ([SectionID])
GO
ALTER TABLE [dbo].[jncSectionPages] CHECK CONSTRAINT [FK_jncCurriculumSection_datCurriculum]
GO
ALTER TABLE [dbo].[jncSectionPages]  WITH CHECK ADD  CONSTRAINT [FK_jncCurriculumSection_ts_Pages] FOREIGN KEY([PageID])
REFERENCES [dbo].[ts_Pages] ([ID])
GO
ALTER TABLE [dbo].[jncSectionPages] CHECK CONSTRAINT [FK_jncCurriculumSection_ts_Pages]
GO
ALTER TABLE [dbo].[jncUsersToPeople]  WITH CHECK ADD  CONSTRAINT [FK_jncUsersToPeople_AspNetUsers] FOREIGN KEY([id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[jncUsersToPeople] CHECK CONSTRAINT [FK_jncUsersToPeople_AspNetUsers]
GO
ALTER TABLE [dbo].[jncUsersToPeople]  WITH CHECK ADD  CONSTRAINT [FK_jncUsersToPeople_datPerson] FOREIGN KEY([personID])
REFERENCES [dbo].[datPerson] ([PersonID])
GO
ALTER TABLE [dbo].[jncUsersToPeople] CHECK CONSTRAINT [FK_jncUsersToPeople_datPerson]
GO
ALTER TABLE [dbo].[linkSurveysQuestions]  WITH CHECK ADD  CONSTRAINT [FK_linkSurveysQuestions_datSurveyQuestions] FOREIGN KEY([questionID])
REFERENCES [dbo].[datSurveyQuestions] ([questionID])
GO
ALTER TABLE [dbo].[linkSurveysQuestions] CHECK CONSTRAINT [FK_linkSurveysQuestions_datSurveyQuestions]
GO
ALTER TABLE [dbo].[linkSurveysQuestions]  WITH CHECK ADD  CONSTRAINT [FK_linkSurveysQuestions_datSurveys] FOREIGN KEY([surveyID])
REFERENCES [dbo].[datSurveys] ([surveyID])
GO
ALTER TABLE [dbo].[linkSurveysQuestions] CHECK CONSTRAINT [FK_linkSurveysQuestions_datSurveys]
GO
ALTER TABLE [dbo].[lkpProvinces]  WITH CHECK ADD  CONSTRAINT [FK_lkpProvinces_lkpCountry] FOREIGN KEY([CountryID])
REFERENCES [dbo].[lkpCountry] ([CountryID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[lkpProvinces] CHECK CONSTRAINT [FK_lkpProvinces_lkpCountry]
GO
ALTER TABLE [dbo].[ts_Pages]  WITH CHECK ADD  CONSTRAINT [FK_ts_Pages_ts_PageTypes] FOREIGN KEY([PageType])
REFERENCES [dbo].[ts_PageTypes] ([ID])
GO
ALTER TABLE [dbo].[ts_Pages] CHECK CONSTRAINT [FK_ts_Pages_ts_PageTypes]
GO
ALTER TABLE [dbo].[ts_PageVersionNotes]  WITH CHECK ADD  CONSTRAINT [FK_ts_PageVersionNotes_ts_PageVersions] FOREIGN KEY([versionID])
REFERENCES [dbo].[ts_PageVersions] ([ID])
GO
ALTER TABLE [dbo].[ts_PageVersionNotes] CHECK CONSTRAINT [FK_ts_PageVersionNotes_ts_PageVersions]
GO
ALTER TABLE [dbo].[ts_PageVersions]  WITH CHECK ADD  CONSTRAINT [FK_ts_PageVersions_ts_Pages] FOREIGN KEY([PageID])
REFERENCES [dbo].[ts_Pages] ([ID])
GO
ALTER TABLE [dbo].[ts_PageVersions] CHECK CONSTRAINT [FK_ts_PageVersions_ts_Pages]
GO
ALTER DATABASE [WOM_SalesCoach] SET  READ_WRITE 
GO
