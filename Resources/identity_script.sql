USE [KAROLL_PULSE]
GO
/****** Object:  User [fima]    Script Date: 2017-11-29 6:09:52 PM ******/
CREATE USER [fima] FOR LOGIN [fima] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [fima]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [fima]
GO
/****** Object:  Table [dbo].[FimaClaims]    Script Date: 2017-11-29 6:09:52 PM ******/
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
/****** Object:  Table [dbo].[FimaLogins]    Script Date: 2017-11-29 6:09:52 PM ******/
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
/****** Object:  Table [dbo].[FimaRoles]    Script Date: 2017-11-29 6:09:52 PM ******/
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
/****** Object:  Table [dbo].[FimaUserRoles]    Script Date: 2017-11-29 6:09:52 PM ******/
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
/****** Object:  Table [dbo].[FimaUsers]    Script Date: 2017-11-29 6:09:52 PM ******/
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
	[AccessFailedCount] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FimaRoles] ON 

INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (1, N'администратор')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (2, N'гост')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (3, N'фронт офис')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (4, N'бек офис')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (5, N'счетоводител')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (6, N'управление на портфейл')
INSERT [dbo].[FimaRoles] ([Id], [Name]) VALUES (7, N'управление на риска')
SET IDENTITY_INSERT [dbo].[FimaRoles] OFF
INSERT [dbo].[FimaUserRoles] ([UserId], [RoleId]) VALUES (39, 2)
INSERT [dbo].[FimaUserRoles] ([UserId], [RoleId]) VALUES (41, 2)
INSERT [dbo].[FimaUserRoles] ([UserId], [RoleId]) VALUES (50, 2)
INSERT [dbo].[FimaUserRoles] ([UserId], [RoleId]) VALUES (66, 3)
INSERT [dbo].[FimaUserRoles] ([UserId], [RoleId]) VALUES (67, 1)
SET IDENTITY_INSERT [dbo].[FimaUsers] ON 

INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (35, N'blago1', N'blago02sof', N'F', N'БЛАГОВЕСТ КРАЧЕВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (36, N'krasi2', N'02krru', N'F', N'КРАСИМИР ЦОЛЕВ', N'СОФИЯ', N'RU82', N'Фронт Офис Специалист', N'РУСЕ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (37, N'Tania', N'tp02sof', N'A', N'ТАНЯ ПЕНКОВА', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (38, N'Hristo3', N'hristo3', N'F', N'ХРИСТО РАЙКОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (39, N'stoika', N'st02sof', N'B', N'СТОЙКА ПАПРАТИЛОВА', N'СОФИЯ', N'AM99', N'Бекофис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (40, N'kati', N'kati', N'P', N'КАТЕРИНА АТАНАСОВА', N'СОФИЯ', N'AM99', N'ПОРТФЕЙЛЕН МЕНИДЖЪР', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (41, N'ceco', N'1234', N'F', N'ЦВЕТАН ДИМИТРОВ ИВАНОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (42, N'velislav', N'velislav', N'F', N'ВЕЛИСЛАВ ЦЕКОВ', N'ВАРНА', N'VA52', N'Фронт Офис Специалист', N'ВАРНА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (43, N'gio', N'gio', N'P', N'ГЕОРГИ ГЕОРГИЕВ', N'СОФИЯ', N'AM99', N'ПОРТФЕЙЛЕН МЕНИДЖЪР', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (44, N'tonia', N'tonia', N'F', N'АНТОНИЯ КОЛЕВА', N'СТАРА ЗАГОРА', N'SZ42', N'Фронт Офис Специалист', N'СТАРА ЗАГОРА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (45, N'pvmaria', N'pvmaria', N'F', N'МАРИЯ ПЕТРОВА', N'ПЛОВДИВ', N'PL32', N'Фронт Офис Специалист', N'ПЛОВДИВ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (47, N'katia', N'K02sof', N'A', N'Катя Каврошилова', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (48, N'plamen', N'plamen', N'A', N'Пламен Григоров', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (49, N'zori', N'zori123', N'A', N'Зорница Колева', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (50, N'mineva', N'mineva123', N'F', N'Тихомира Минева Неделчева', N'СТАРА ЗАГОРА', N'SZ42', N'Фронт Офис Специалист', N'СТАРА ЗАГОРА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (51, N'mariq', N'mariq', N'A', N'Мария Ангелова Иванова', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (55, N'kristina', N'luk4eto', N'A', N'Кристина Балева', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (56, N'aneliq', N'ani 1234', N'A', N'Анелия Вълкова', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (58, N'asen', N'asen369', N'A', N'Асен Георгиев', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (63, N'yana1', N'yana1234', N'F', N'ЯНА ЧУТУРКОВА', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (64, N'joro', N'1234qwer', N'Admin', N'Георги Ганчев', N'СОФИЯ', N'AM99', N'Администратор', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (65, N'niki_0603', N'791220', N'A', N'Николай Такиев', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (46, N'stefka', N'stefka', N'F', N'СТЕФКА ИГНАТОВА', N'РУСЕ', N'RU82', N'Фронт Офис Специалист', N'РУСЕ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (57, N'eva', N'eva1224', N'A', N'Ева Стойнова', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (1, N'Ivo', N'ivo123', N'F', N'ИВО МАРЧОКОВ', N'СОФИЯ', N'AM99', N'Администратор', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (2, N'Sonia', N'sonia', N'A', N'СТОЙКА КОРИТАРОВА', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'Pepi', N'pepi', N'F', N'ПЕТЪР КЕТЕНЕВ', N'СОФИЯ', N'AM99', N'Администратор', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (4, N'Hristo', N'Hristo', N'A', N'ХРИСТО РАЙКОВ', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (9, N'iliana1', N'inikolova', N'F', N'ИЛИЯНА НИКОЛОВА', N'БУРГАС', N'BU56', N'Фронт Офис Специалист', N'БУРГАС', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (6, N'Georgi', N'georgi', N'B', N'ГЕОРГИ АНГЕЛОВ', N'СОФИЯ', N'AM99', N'Бекофис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (22, N'nikolay', N'02nksof', N'F', N'НИКОЛАЙ ПЕТЕВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (8, N'sa', N'12345678', N'Admin', N'ХРИСТО РАЙКОВ', N'СОФИЯ', N'AM99', N'Администратор', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (10, N'Petar', N'63ptpl', N'F', N'ПЕТЪР АТАНАСОВ', N'ПЛОВДИВ', N'PL32', N'Фронт Офис Специалист', N'ПЛОВДИВ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (20, N'ivo1', N'ivo123', N'B', N'ИВО МАРЧОКОВ', N'СОФИЯ', N'AM99', N'Бекофис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (21, N'ivo2', N'ivo123', N'A', N'ИВО МАРЧОКОВ', N'СОФИЯ', N'AM99', N'Счетоводител', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (23, N'Boris2', N'99btvt', N'F', N'ХРИСТО ТОМОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (24, N'Rali', N'rali123', N'F', N'РАЛИЦА ДУДЕВА', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (25, N'dani', N'dani123', N'P', N'ДАНИЕЛ ГАНЕВ', N'СОФИЯ', N'AM99', N'ПОРТФЕЙЛЕН МЕНИДЖЪР', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (26, N'anikolov', N'alex123', N'P', N'АЛЕКСАНДЪР НИКОЛОВ', N'СОФИЯ', N'AM99', N'ПОРТФЕЙЛЕН МЕНИДЖЪР', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (27, N'Krasi', N'02krsof', N'F', N'КРАСИМИР АЛЕКСАНДРОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (28, N'Krisi', N'02krsof', N'F', N'КРИСТИНА ДОНЧЕВА', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (30, N'Bobi', N'bobi123', N'F', N'БОРИСЛАВ ЯНКОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (31, N'didi', N'didi123', N'F', N'ДИАНА САВОВА', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (12, N'Emil', N'62emsz', N'F', N'ЕМИЛ НИКОЛОВ', N'СТАРА ЗАГОРА', N'SZ42', N'Фронт Офис Специалист', N'СТАРА ЗАГОРА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (13, N'Diana', N'61dnvn', N'F', N'ДИАНА ПЕТКОВА', N'ВАРНА', N'VA52', N'Фронт Офис Специалист', N'ВАРНА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (14, N'Doichin', N'82dnru', N'F', N'ДОЙЧИН БОЯДЖИЕВ', N'РУСЕ', N'RU82', N'Фронт Офис Специалист', N'РУСЕ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (15, N'Vania', N'09vnvr', N'F', N'ВАНЯ КРЪСТЕВА', N'ВРАЦА', N'VR92', N'Фронт Офис Специалист', N'ВРАЦА', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (18, N'Hristo2', N'02hrsof', N'F', N'ХРИСТО ТОМОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (32, N'kalin', N'kalin123', N'F', N'КАЛИН ЙОРДАНОВ', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (33, N'bistra', N'bs02sof', N'F', N'БИСТРА КОЦЕВА', N'СОФИЯ', N'AM99', N'Фронт Офис Специалист', N'СОФИЯ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (66, N'zach', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'AIlNRqQiyWqjT/fXSFHRdobqONFCbdHVEgdKoa+gstamxStalCGFCkGmUn24Euo8OQ==', N'zahari_d@mail.bg', 0, N'737d8986-2391-4ca7-b87d-2f32f71e44a8', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[FimaUsers] ([Id], [UserName], [strEmpPassword], [strAccess], [strName], [strTown], [strIndex], [EmpFunction], [emptown], [PasswordHash], [Email], [EmailConfirmed], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (67, N'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'ACldRS884Oec5LiYWFIn6gdlkxj1x8qP1GMoAL7rAsRNg3rRF9qoomREzmSrFV39uw==', N'admin@fima.win', 0, N'94d2091a-d32a-4e2c-b03a-168511c1088c', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[FimaUsers] OFF
/****** Object:  Index [aaaaatblEmployees_PK]    Script Date: 2017-11-29 6:09:52 PM ******/
ALTER TABLE [dbo].[FimaUsers] ADD  CONSTRAINT [aaaaatblEmployees_PK] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
