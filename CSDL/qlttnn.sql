USE [master]
GO
/****** Object:  Database [QLTTTiengAnh]    Script Date: 7/4/2024 12:18:23 AM ******/
CREATE DATABASE [QLTTTiengAnh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTTTiengAnh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTTTiengAnh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTTTiengAnh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTTTiengAnh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTTTiengAnh] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTTTiengAnh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTTTiengAnh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTTTiengAnh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTTTiengAnh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTTTiengAnh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTTTiengAnh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTTTiengAnh] SET  MULTI_USER 
GO
ALTER DATABASE [QLTTTiengAnh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTTTiengAnh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTTTiengAnh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTTTiengAnh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTTTiengAnh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTTTiengAnh] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTTTiengAnh', N'ON'
GO
ALTER DATABASE [QLTTTiengAnh] SET QUERY_STORE = OFF
GO
USE [QLTTTiengAnh]
GO
/****** Object:  Table [dbo].[Assessment]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assessment](
	[ID] [int] NOT NULL,
	[IDTeacherAss] [int] NOT NULL,
	[Name] [char](10) NOT NULL,
	[Date] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[AttentCount] [char](10) NOT NULL,
	[Note] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Assessment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [nchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[StartDay] [date] NULL,
	[EndDay] [date] NULL,
	[TimeLearning] [nchar](10) NULL,
	[Fee] [int] NULL,
	[IDRoom] [int] NULL,
	[IDTeacher] [int] NULL,
	[Curriculum] [nvarchar](50) NULL,
	[Number] [int] NULL,
	[An] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCourse] [int] NOT NULL,
	[IDStudent] [int] NOT NULL,
	[DateRegis] [date] NULL,
	[TTHP] [nchar](10) NULL,
	[An] [int] NULL,
 CONSTRAINT [PK_Students_Courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ID] [int] NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[StartDay] [date] NOT NULL,
	[EndDay] [date] NOT NULL,
	[DayLearning] [char](10) NOT NULL,
	[Teacher1] [char](10) NOT NULL,
	[Teacher2] [char](10) NOT NULL,
	[DuringTime] [int] NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[LastName] [nchar](10) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Date] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nchar](10) NOT NULL,
	[Sex] [nchar](10) NOT NULL,
	[An] [int] NULL,
	[TTAcc] [int] NULL,
 CONSTRAINT [PK_Student_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[LastName] [nchar](10) NULL,
	[Name] [nchar](10) NULL,
	[Sex] [nchar](10) NULL,
	[Description] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[Qualification] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](200) NOT NULL,
	[Type] [nchar](10) NOT NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Room] FOREIGN KEY([IDRoom])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Room]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([IDTeacher])
REFERENCES [dbo].[Teacher] ([ID])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Register]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses_Course] FOREIGN KEY([IDCourse])
REFERENCES [dbo].[Course] ([ID])
GO
ALTER TABLE [dbo].[Register] CHECK CONSTRAINT [FK_Students_Courses_Course]
GO
ALTER TABLE [dbo].[Register]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses_Student1] FOREIGN KEY([IDStudent])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Register] CHECK CONSTRAINT [FK_Students_Courses_Student1]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([UserName])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_User]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([UserName])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_User]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ACCOUNT]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--store
CREATE PROC [dbo].[ADD_ACCOUNT]
--@HoLot NVARCHAR(100),@Ten NVARCHAR(100),@DiaChi NVARCHAR(200),@GioiTinh NVARCHAR(5),@NamSinh DATE,@Sdt NVARCHAR(20), @IdCV int
						@Username NVARCHAR(50),
						@Password NVARCHAR(200),
						@Type NCHAR(10)

AS
BEGIN
	--INSERT INTO NhanVien VALUES(@HoLot, @Ten, @DiaChi, @GioiTinh, @NamSinh, @Sdt, @IdCV, 0)
	INSERT INTO [User]
    VALUES 
          ( 
						@Username,
						@Password,
						@Type
						
          ) 
END
GO
/****** Object:  StoredProcedure [dbo].[ADD_COURSE]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--store
CREATE PROC [dbo].[ADD_COURSE]
		@CourseCode NCHAR(10),
		@Name NVARCHAR(50),
		@StartDay DATE,
		@EndDay DATE,
		@TimeLearning CHAR(10),
		@Fee INT,
		@IDRoom INT,
		@IDTeacher INT,
		@Curriculum NVARCHAR(50),
		@Number INT
AS
BEGIN
	INSERT INTO Course
	VALUES(	
			@CourseCode,
			@Name,
			@StartDay,
			@EndDay,
			@TimeLearning,
			@Fee,
			@IDRoom,
			@IDTeacher,
			@Curriculum,
			@Number, 0
			)
END
GO
/****** Object:  StoredProcedure [dbo].[ADD_REGISTER]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--store
CREATE PROC [dbo].[ADD_REGISTER]
		@IDCourse INT,
		@IDStudent INT,
		@DateRegis date,
		@TTHP NCHAR(10)
AS
BEGIN
	INSERT INTO Register
	VALUES(	
			@IDCourse,
			@IDStudent,
			@DateRegis,
			@TTHP,0
			)
END
GO
/****** Object:  StoredProcedure [dbo].[ADD_STUDENT]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--store
CREATE PROC [dbo].[ADD_STUDENT]
--@HoLot NVARCHAR(100),@Ten NVARCHAR(100),@DiaChi NVARCHAR(200),@GioiTinh NVARCHAR(5),@NamSinh DATE,@Sdt NVARCHAR(20), @IdCV int
						@LastName NCHAR(10),
						@Name NCHAR(10),
						@Date DATE,
						@Email NVARCHAR(50),
						@Address NVARCHAR(50),
						@PhoneNumber NCHAR(10),
						@Sex NCHAR(10)
AS
BEGIN
	--INSERT INTO NhanVien VALUES(@HoLot, @Ten, @DiaChi, @GioiTinh, @NamSinh, @Sdt, @IdCV, 0)
	INSERT INTO Student
    VALUES 
          ( 
						NULL,
						@LastName,
						@Name,
						@Date,
						@Email,
						@Address,
						@PhoneNumber,
						@Sex, 
						0,
						0
          ) 
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_COURSE]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[UPDATE_COURSE]
			@Id int,
			@CourseCode NCHAR(10),
			@Name NVARCHAR(50),
			@StartDay DATE,
			@EndDay DATE,
			@TimeLearning CHAR(10),
			@Fee INT,
			@IDRoom INT,
			@IDTeacher INT,
			@Curriculum NVARCHAR(50),
			@Number INT
AS
BEGIN
	UPDATE Course SET		CourseCode = @CourseCode,
							Name = @Name,
							StartDay = @StartDay,
							EndDay = @EndDay,
							TimeLearning = @TimeLearning,
							Fee = @Fee,
							Curriculum = @Curriculum,
							Number = @Number
							WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_HOCVIEN]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[UPDATE_HOCVIEN]
			@Id int,
			@Username NVARCHAR(50),
			@LastName NCHAR(10),
			@Name NCHAR(10),
			@Date DATE,
			@Email NVARCHAR(50),
			@Address NVARCHAR(50),
			@PhoneNumber NVARCHAR(10),
			@Sex NCHAR(10)
AS
BEGIN
	UPDATE Student SET		Username = @Username,
							LastName= @LastName, 
							Name=@Name, 
							Date=@Date, 
							Email=@Email, 
							Address=@Address,
							PhoneNumber=@PhoneNumber,
							Sex = @Sex
							WHERE ID = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_REGIS]    Script Date: 7/4/2024 12:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[UPDATE_REGIS]
			@Id int,
			@IdCourse int,
			@IdStudent int,
			@DateRegis date,
			@TTHP nchar(10)
AS
BEGIN
	UPDATE Register SET		IDCourse = @IdCourse,
							IDStudent = @IdStudent,
							DateRegis = @DateRegis,
							TTHP = @TTHP
							WHERE ID = @Id
END
GO
USE [master]
GO
ALTER DATABASE [QLTTTiengAnh] SET  READ_WRITE 
GO
