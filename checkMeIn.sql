USE [master]
GO
/****** Object:  Database [checkMeInDB]     ******/
CREATE DATABASE [checkMeInDB]
 GO
ALTER DATABASE [checkMeInDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [checkMeInDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [checkMeInDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [checkMeInDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [checkMeInDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [checkMeInDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [checkMeInDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [checkMeInDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [checkMeInDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [checkMeInDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [checkMeInDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [checkMeInDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [checkMeInDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [checkMeInDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [checkMeInDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [checkMeInDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [checkMeInDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [checkMeInDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [checkMeInDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [checkMeInDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [checkMeInDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [checkMeInDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [checkMeInDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [checkMeInDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [checkMeInDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [checkMeInDB] SET  MULTI_USER 
GO
ALTER DATABASE [checkMeInDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [checkMeInDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [checkMeInDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [checkMeInDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [checkMeInDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [checkMeInDB] SET QUERY_STORE = OFF
GO
USE [checkMeInDB]
GO
/****** Object:  Table [dbo].[Bookings]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guest_FK] [int] NULL,
	[rooms_FK] [int] NULL,
	[roomStatus_FK] [int] NULL,
	[payment_FK] [int] NULL,
	[checkInDate] [datetime] NULL,
	[checkOutDate] [datetime] NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deptId] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[empNumber] [nvarchar](50) NULL,
	[department_FK] [int] NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guests]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[homeAddress] [nvarchar](50) NULL,
	[country] [nvarchar](50) NULL,
	[telephoneNum] [nvarchar](50) NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roomNum] [int] NULL,
	[type] [nvarchar](50) NULL,
	[cost] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomStatus]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [nvarchar](50) NULL,
	[abbreviation] [nvarchar](50) NULL,
 CONSTRAINT [PK_RoomStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([id], [guest_FK], [rooms_FK], [roomStatus_FK], [payment_FK], [checkInDate], [checkOutDate]) VALUES (1, 1, 20, 2, 5, CAST(N'2020-04-01T00:00:00.000' AS DateTime), CAST(N'2020-04-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Bookings] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (1, N'HK', N'House Keeping')
INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (2, N'FD', N'Front Desk')
INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (3, N'Maint', N'Maintenance')
INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (4, N'IT', N'InfoTech')
INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (5, N'FB', N'Food And Beverage')
INSERT [dbo].[Departments] ([id], [deptId], [name]) VALUES (6, N'Ev', N'Events')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (1, N'Clive', N'Griffiths', N'1050JA', 2, N'password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (2, N'Tim', N'Redwood', N'1051KA', 4, N'Password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (3, N'Ken', N'Booth', N'3478JA', 6, N'Password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (4, N'Ken', N'Booth', N'3478JA', 1, N'Password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (5, N'Ken', N'Booth', N'3478JA', 3, N'Password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (6, N'Ken', N'Booth', N'3478JA', 5, N'Password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (7, N'Clive', N'Griffiths', N'1050JA', 2, N'password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (8, N'Clive', N'Griffiths', N'1050JA', 6, N'password')
INSERT [dbo].[Employees] ([id], [firstName], [lastName], [empNumber], [department_FK], [password]) VALUES (9, N'Clive', N'Griffiths', N'1050JA', 2, N'password')
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([id], [firstName], [lastName], [gender], [homeAddress], [country], [telephoneNum]) VALUES (1, N'Mario', N'Thomas', N'M', N' Home', N'Manhattan', N'876-00000000')
SET IDENTITY_INSERT [dbo].[Guests] OFF
SET IDENTITY_INSERT [dbo].[PaymentMethod] ON 

INSERT [dbo].[PaymentMethod] ([id], [type]) VALUES (1, N'Credit Card')
INSERT [dbo].[PaymentMethod] ([id], [type]) VALUES (2, N'Cash')
INSERT [dbo].[PaymentMethod] ([id], [type]) VALUES (3, N'Cash & Credit')
INSERT [dbo].[PaymentMethod] ([id], [type]) VALUES (4, N'Check')
INSERT [dbo].[PaymentMethod] ([id], [type]) VALUES (5, N'Comp')
SET IDENTITY_INSERT [dbo].[PaymentMethod] OFF
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (1, 101, N'single', N'1500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (2, 102, N'single', N'1500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (3, 103, N'single', N'1500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (4, 104, N'single', N'1500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (5, 105, N'single', N'1500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (6, 106, N'double', N'2000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (7, 107, N'double', N'2000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (8, 108, N'double', N'2000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (9, 109, N'double', N'2000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (10, 110, N'double', N'2000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (11, 201, N'quad', N'3750')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (12, 202, N'quad', N'3750')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (13, 203, N'quad', N'3750')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (14, 204, N'king', N'5500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (15, 205, N'king', N'5500')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (16, 206, N'queen', N'5000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (17, 207, N'queen', N'5000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (18, 208, N'studio', N'8000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (19, 209, N'studio', N'8000')
INSERT [dbo].[Rooms] ([id], [roomNum], [type], [cost]) VALUES (20, 210, N'studio', N'8000')
SET IDENTITY_INSERT [dbo].[Rooms] OFF
SET IDENTITY_INSERT [dbo].[RoomStatus] ON 

INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (1, N'vacant and empty', N'VE')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (2, N'occupied', N'O')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (3, N'Out of Order', N'OOO')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (4, N'StayOver', N'SO')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (5, N'Skipper', N'SKIP')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (6, N'Do Not Disturb', N'DnD')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (7, N'Complimentary ', N'Comp')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (8, N'Sleep out', N'SO')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (9, N'Check out', N'CO')
INSERT [dbo].[RoomStatus] ([id], [status], [abbreviation]) VALUES (10, N'Late Check out', N'LT-CO')
SET IDENTITY_INSERT [dbo].[RoomStatus] OFF
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Guests] FOREIGN KEY([guest_FK])
REFERENCES [dbo].[Guests] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Guests]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_PaymentMethod] FOREIGN KEY([payment_FK])
REFERENCES [dbo].[PaymentMethod] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_PaymentMethod]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Rooms] FOREIGN KEY([rooms_FK])
REFERENCES [dbo].[Rooms] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Rooms]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_RoomStatus] FOREIGN KEY([roomStatus_FK])
REFERENCES [dbo].[RoomStatus] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_RoomStatus]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments] FOREIGN KEY([department_FK])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments]
GO
USE [master]
GO
ALTER DATABASE [checkMeInDB] SET  READ_WRITE 
GO
