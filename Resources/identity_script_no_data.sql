USE [KAROLL_PULSE]
GO
/****** Object:  User [fima]    Script Date: 2017-11-29 6:07:28 PM ******/
CREATE USER [fima] FOR LOGIN [fima] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [fima]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [fima]
GO
/****** Object:  Table [dbo].[FimaClaims]    Script Date: 2017-11-29 6:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FimaClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_FimaClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FimaLogins]    Script Date: 2017-11-29 6:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FimaLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_FimaLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FimaRoles]    Script Date: 2017-11-29 6:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FimaRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_FimaRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FimaUserRoles]    Script Date: 2017-11-29 6:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FimaUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_FimaUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FimaUsers]    Script Date: 2017-11-29 6:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FimaUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[strEmpPassword] [varchar](50) NULL,
	[strAccess] [varchar](50) NULL,
	[strName] [varchar](50) NULL,
	[strTown] [varchar](50) NULL,
	[strIndex] [varchar](50) NULL,
	[EmpFunction] [varchar](50) NULL,
	[emptown] [varchar](50) NULL,
	[PasswordHash] [varchar](max) NULL,
	[Email] [varchar](256) NULL,
	[EmailConfirmed] [bit] NULL,
	[SecurityStamp] [varchar](max) NULL,
	[PhoneNumber] [varchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NULL,
	[TwoFactorEnabled] [bit] NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NULL,
	[AccessFailedCount] [int] NULL,
 CONSTRAINT [aaaaatblEmployees_PK] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[FimaClaims]  WITH CHECK ADD  CONSTRAINT [FK_FimaClaims_FimaUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FimaUsers] ([Id])
GO
ALTER TABLE [dbo].[FimaClaims] CHECK CONSTRAINT [FK_FimaClaims_FimaUsers]
GO
ALTER TABLE [dbo].[FimaLogins]  WITH CHECK ADD  CONSTRAINT [FK_FimaLogins_FimaUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FimaUsers] ([Id])
GO
ALTER TABLE [dbo].[FimaLogins] CHECK CONSTRAINT [FK_FimaLogins_FimaUsers]
GO
ALTER TABLE [dbo].[FimaUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_FimaUserRoles_FimaRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[FimaRoles] ([Id])
GO
ALTER TABLE [dbo].[FimaUserRoles] CHECK CONSTRAINT [FK_FimaUserRoles_FimaRoles]
GO
ALTER TABLE [dbo].[FimaUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_FimaUserRoles_FimaUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FimaUsers] ([Id])
GO
ALTER TABLE [dbo].[FimaUserRoles] CHECK CONSTRAINT [FK_FimaUserRoles_FimaUsers]
GO
