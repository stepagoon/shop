USE [master]
GO
/****** Object:  Database [mindalDB]    Script Date: 01.06.2022 1:44:55 ******/
CREATE DATABASE [mindalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kolesnikov', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSTEPA\MSSQL\DATA\kolesnikov.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kolesnikov_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSTEPA\MSSQL\DATA\kolesnikov_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE Cyrillic_General_CI_AS
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mindalDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mindalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mindalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mindalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mindalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mindalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mindalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [mindalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mindalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mindalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mindalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mindalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mindalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mindalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mindalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mindalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mindalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mindalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mindalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mindalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mindalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mindalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mindalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mindalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mindalDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mindalDB] SET  MULTI_USER 
GO
ALTER DATABASE [mindalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mindalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mindalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mindalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mindalDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mindalDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mindalDB', N'ON'
GO
ALTER DATABASE [mindalDB] SET QUERY_STORE = OFF
GO
USE [mindalDB]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Name] [varchar](50) COLLATE Cyrillic_General_CI_AS NOT NULL,
	[Count] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Providers] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[UserID] [int] NOT NULL,
	[IsAccepted] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersParts]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersParts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_OrdersParts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) COLLATE Cyrillic_General_CI_AS NOT NULL,
	[Address] [nvarchar](100) COLLATE Cyrillic_General_CI_AS NOT NULL,
	[Phone] [nvarchar](11) COLLATE Cyrillic_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01.06.2022 1:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
	[LastName] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
	[PhoneNumber] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
	[Login] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
	[Password] [varchar](50) COLLATE Cyrillic_General_CI_AS NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 

INSERT [dbo].[Cart] ([ID], [UserID], [ItemID], [Count]) VALUES (56, 3, 4, 3)
INSERT [dbo].[Cart] ([ID], [UserID], [ItemID], [Count]) VALUES (57, 3, 5, 2)
INSERT [dbo].[Cart] ([ID], [UserID], [ItemID], [Count]) VALUES (61, 1, 3, 1)
INSERT [dbo].[Cart] ([ID], [UserID], [ItemID], [Count]) VALUES (62, 1, 1, 20)
INSERT [dbo].[Cart] ([ID], [UserID], [ItemID], [Count]) VALUES (63, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (1, CAST(N'2021-03-25T00:00:00.000' AS DateTime), N'Блузка HM', 50, CAST(1500.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (2, CAST(N'2021-03-21T00:00:00.000' AS DateTime), N'Шорты TNF', 70, CAST(1500.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (3, CAST(N'2021-03-11T00:00:00.000' AS DateTime), N'Футболка Nike', 30, CAST(1500.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (4, CAST(N'2021-03-30T00:00:00.000' AS DateTime), N'Джинсы Levis', 15, CAST(5000.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (5, CAST(N'2021-03-01T00:00:00.000' AS DateTime), N'Толстовка HM', 30, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([ID], [DateTime], [Name], [Count], [Price], [Providers]) VALUES (6, CAST(N'2022-05-24T00:00:00.000' AS DateTime), N'fffffff', 1, CAST(0.01 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [DateTime], [UserID], [IsAccepted]) VALUES (26, CAST(N'2022-06-01T00:25:21.187' AS DateTime), 1, 0)
INSERT [dbo].[Orders] ([ID], [DateTime], [UserID], [IsAccepted]) VALUES (27, CAST(N'2022-06-01T00:25:53.920' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdersParts] ON 

INSERT [dbo].[OrdersParts] ([ID], [OrderID], [ItemID], [Count], [UserID]) VALUES (52, 26, 3, 1, 1)
INSERT [dbo].[OrdersParts] ([ID], [OrderID], [ItemID], [Count], [UserID]) VALUES (53, 26, 1, 30, 1)
INSERT [dbo].[OrdersParts] ([ID], [OrderID], [ItemID], [Count], [UserID]) VALUES (54, 27, 3, 1, 1)
INSERT [dbo].[OrdersParts] ([ID], [OrderID], [ItemID], [Count], [UserID]) VALUES (55, 27, 1, 20, 1)
INSERT [dbo].[OrdersParts] ([ID], [OrderID], [ItemID], [Count], [UserID]) VALUES (56, 27, 2, 1, 1)
SET IDENTITY_INSERT [dbo].[OrdersParts] OFF
GO
INSERT [dbo].[Providers] ([id], [Name], [Address], [Phone]) VALUES (1, N'ООО "HM"', N'г. Москва, Пулковское шоссе 12', N'89190033411')
INSERT [dbo].[Providers] ([id], [Name], [Address], [Phone]) VALUES (2, N'ООО "Nike"', N'г. Москва, Гражданский проспект 12В', N'89183551567')
INSERT [dbo].[Providers] ([id], [Name], [Address], [Phone]) VALUES (3, N'ООО "TNF"', N'г. Москва, Садоводская 63Г', N'89583147568')
INSERT [dbo].[Providers] ([id], [Name], [Address], [Phone]) VALUES (4, N'123', N'123', N'123')
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [Role]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([id], [Role]) VALUES (2, N'Менеджер')
INSERT [dbo].[Roles] ([id], [Role]) VALUES (3, N'Покупатель')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [FirstName], [LastName], [PhoneNumber], [Login], [Password], [Role]) VALUES (1, N'Степан', N'Колесников', N'+7919923856', N'stepagoon', N'1234', 1)
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [PhoneNumber], [Login], [Password], [Role]) VALUES (2, N'Максим', N'Фрундин', N'+7599390021', N'whitener', N'12345', 2)
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [PhoneNumber], [Login], [Password], [Role]) VALUES (3, N'Пикалов', N'Ярослав', N'+7904589789', N'yara', N'123456', 3)
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [PhoneNumber], [Login], [Password], [Role]) VALUES (9, N'a', N'a', N'a', N'a', N'a', 3)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Items]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Users]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Providers] FOREIGN KEY([Providers])
REFERENCES [dbo].[Providers] ([id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Providers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[OrdersParts]  WITH CHECK ADD  CONSTRAINT [FK_OrdersParts_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdersParts] CHECK CONSTRAINT [FK_OrdersParts_Items]
GO
ALTER TABLE [dbo].[OrdersParts]  WITH CHECK ADD  CONSTRAINT [FK_OrdersParts_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdersParts] CHECK CONSTRAINT [FK_OrdersParts_Orders]
GO
ALTER TABLE [dbo].[OrdersParts]  WITH CHECK ADD  CONSTRAINT [FK_OrdersParts_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[OrdersParts] CHECK CONSTRAINT [FK_OrdersParts_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role])
REFERENCES [dbo].[Roles] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [mindalDB] SET  READ_WRITE 
GO
