USE [master]
GO
/****** Object:  Database [RestaurantManagement]    Script Date: 9/30/2020 7:42:33 PM ******/
CREATE DATABASE [RestaurantManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RestaurantManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RestaurantManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RestaurantManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RestaurantManagement] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantManagement] SET QUERY_STORE = OFF
GO
USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[Tax] [float] NULL,
	[Status] [bit] NULL,
	[CheckoutDate] [smalldatetime] NOT NULL,
	[Account] [nvarchar](100) NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'Lê Gia Công', N'conglg@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Thị Thanh Nga', N'ngatt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Thái Duy Quý', N'quytt@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttpling', N'tranthiphuonglinh', N'Trần thị Phương LINg', N'lingttp@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 3, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (3, 1, 5, 3)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (4, 1, 6, 2)
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Hóa Đơn Thanh Toán', 5, 150000, 0.05, 0, 0, CAST(N'2020-02-10T00:00:00' AS SmallDateTime), N'tdquy')
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai Vị', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Hải Sản', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Gà', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Cơm', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Thịt', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (7, N'Canh', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Lẩu', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'Bia', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Nước Ngọt', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'Cà Phê', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'Trà Đá', 0)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Cơm Chiên Dương Châu', N'Đĩa Nhỏ', 4, 40000, N'3 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Cơm Chiên Dương Châu', N'Đĩa Lớn', 4, 45000, N'5 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Ếch chui Rơm', N'Đĩa', 2, 75000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Càng cua hấp', N'Đĩa ', 2, 100000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Canh Cải', N'Tô', 8, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'Gà nướng muối ớt', N'Con', 3, 180000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Bia 333', N'Chai', 10, 12000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Bia Heniken', N'Chai ', 10, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Súp Cua', N'Tô', 1, 15000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (12, N'Thịt Kho', N'Đĩa', 5, 25000, N'Theo Thời Giá')
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'AD', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Kế Toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nhân Viên Thanh toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nhân Viên Phục Vụ', NULL, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'pttnga', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'ttpling', 1, NULL)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'01', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'02', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (3, N'03', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'04', 0, 6)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'05', 0, 8)
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Food] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Food]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_Category] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_Category]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO
/****** Object:  StoredProcedure [dbo].[Account_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Account_delete] (@AccountName NVARCHAR(1000))
as
begin
	delete from Account
	where AccountName=@AccountName
end
GO
/****** Object:  StoredProcedure [dbo].[Account_e]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Account_e] (@Password NVARCHAR(200), @Fullname NVARCHAR(1000),@Email NVARCHAR(1000),@Tell NVARCHAR(200), @AccountName NVARCHAR(100))
as
begin
	insert into Account (AccountName,Password,FullName,Email,Tell)
		values (@AccountName,@Password,@Fullname,@Email,@Tell)
end





	

GO
/****** Object:  StoredProcedure [dbo].[Account_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Account_GetAll]
As
begin
	select*from Account
end
GO
/****** Object:  StoredProcedure [dbo].[Account_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Account_GetByID] (@AccountName NVARCHAR(100))
As
begin 
	Select*from Account where AccountName = @AccountName
end
GO
/****** Object:  StoredProcedure [dbo].[Account_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Account_Update] (@AccountName NVARCHAR(100), @Password NVARCHAR(200), @FullName NVARCHAR(1000),@Email NVARCHAR(1000),@Tell NVARCHAR(200),@DateCreate SMALLDATETIME)
as
begin
	update	Account
	set [Password]=@Password,[FullName]=@FullName,[Email]=@Email,[Tell]=@Tell,[DateCreated]=@DateCreate
	where AccountName=@AccountName
end
GO
/****** Object:  StoredProcedure [dbo].[Bill_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Bill_delete] (@ID INT)
as
begin 
	delete from Bills
	where ID =@ID
 end
GO
/****** Object:  StoredProcedure [dbo].[Bill_insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Bill_insert] (@Name NVARCHAR(1000), @TableID INT, @Amount INT, @Discount FLOAT, @Tax FLOAT,@Status Bit, @CheckoutDate SMALLDATETIME, @Account NVARCHAR(100))
as
begin
	if (NOT EXISTS (select Name from Bills where Name=@Name))
		Insert into Bills(Name,TableID,Amount,Discount,Tax,Status,CheckoutDate)
					values (@Name,@TableID,@Amount,@Discount,@Tax,@Status,@CheckoutDate)
end
GO
/****** Object:  StoredProcedure [dbo].[Bill_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Bill_Update] (@ID INT, @Name NVARCHAR(1000),@TableID INT, @Amount INT, @Discount FLOAT, @Tax FLOAT, @Status BIT,@CheckoutDate SMALLDATETIME,@Account NVARCHAR(100))
as
begin
	update Bills
	Set [Name]=@Name,[TableID]=@TableID,[Amount]=@Amount,[Discount]=@Discount,[Tax]=@Tax,[Status]=@Status,[CheckoutDate]=@CheckoutDate,[Account]=@Account
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[BillDetail_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BillDetail_Update] (@ID INT,@InvoiceID INT, @FoodID INT, @Quantity INT)
as
begin
	update BillDetails 
	set [InvoiceID]=@InvoiceID,[FoodID]=@FoodID,[Quantity]=@Quantity
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[BillDetails_delete] (@ID INT )
 as 
 begin
	delete from BillDetails
	where ID =@ID
end 
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[BillDetails_GetAll]
As 
Begin
	Select*from BillDetails
End
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BillDetails_GetByID] (@ID INT)
As
begin	
	Select*from BillDetails where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BillDetails_Insert] (@InvoiceID INT, @FoodID INT, @Quantity INT)
as
begin
	insert into BillDetails (InvoiceID,FoodID,Quantity)
		values (@InvoiceID,@FoodID,@Quantity)
end
GO
/****** Object:  StoredProcedure [dbo].[Bills_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Bills_GetAll]
As
Begin
	Select*from Bills
End
GO
/****** Object:  StoredProcedure [dbo].[Bills_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Bills_GetByID] (@ID INT)
AS
begin
	select*from Bills where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[category_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[category_delete] (@ID INT )
as 
begin
	DELETE FROM Category
	Where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Category_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----Xuất ra bảng trong bảng cột có giá trị
--Select*from[Table] where Capacity = 5
--go
----Thêm giá trị vào một bảng
--Insert into [Table] values ('6','Bàn 6','0','6')
---- Cập nhật dữ liệu 
--Update Food set Name = N'Gà Kho Xã Ớt' where Name = 'Gà Kho Xã';
----Xóa dữ liệu 
--Delete from Category;
--GO
Create procedure [dbo].[Category_GetAll]
As
Begin 
	Select*from Category
End
GO
/****** Object:  StoredProcedure [dbo].[Category_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Category_GetByID] (@ID INT)
AS
begin
	select*from Category where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Category_Insert] ( @Name NVARCHAR(1000),@Type INT)
as
begin
	if(NOT EXISTS (Select Name From Category where Name= @Name))
		Insert into Category (Name,Type)
					VALUES(@Name,@Type)
end
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Category_Update] (@ID INT, @Name NVARCHAR(1000), @TYPE INT )
as
begin
	Update Category
	SET [Name] =@Name, [Type] = @TYPE
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Food_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Food_delete] (@ID INT )
as 
begin
	delete from Food
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Food_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Food_GetAll]
As
Begin 
	Select*from Food 
end
GO
/****** Object:  StoredProcedure [dbo].[Food_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Food_GetByID] (@ID INT)
As
begin 
	Select*from Food where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[Food_Insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Food_Insert] (@Name NVARCHAR(1000), @Unit NVARCHAR(100), @FoodCatagoryID INT,@Price INT, @Notes NVARCHAR(3000))
as
begin
	If (NOT EXISTS (select Name from Food Where Name =@Name))
		Insert into Food (Name,Unit,FoodCategoryID,Price,Notes)
			values (@Name,@Unit,@FoodCatagoryID,@Price,@Notes)
end
GO
/****** Object:  StoredProcedure [dbo].[Food_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Food_Update] (@ID INT, @Name NVARCHAR(1000),@Unit NVARCHAR(100),@Foodcategory INT,@Price INT,@Note NVARCHAR(3000))
as
begin
	update Food
	set	[Name]=@Name,[Unit]=@Unit,[FoodCategoryID]=@Foodcategory,[Price]=@Price,[Notes]=@Note
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Role_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Role_delete] (@ID INT )
as
begin 
	delete from [Role]
end
GO
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Role_GetAll]
as
begin	
	Select*from [Role]
end
GO
/****** Object:  StoredProcedure [dbo].[Role_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Role_GetByID] (@ID INT)
as
begin
	Select*from [Role] where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Role_insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Role_insert] (@RoleName NVARCHAR(1000), @Path NVARCHAR(3000),@Notes NVARCHAR(3000))
as
begin	
	insert into [Role] (RoleName,path,Notes)
		values (@RoleName,@Path,@Notes)
end
GO
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Role_Update] (@ID INT, @RoleName NVARCHAR(1000),@Path NVARCHAR(3000),@Notes NVARCHAR(3000))
as
begin
	update [Role]
	set [RoleName]=@RoleName,[Path]=@Path,[Notes]=@Notes
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RoleAccount_delete] (@RoleID INT)
as
begin
	delete from RoleAccount
	where RoleID=@RoleID
end
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[RoleAccount_GetAll]
As
Begin
	Select*from RoleAccount
end
GO
/****** Object:  StoredProcedure [dbo].[Roleaccount_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Roleaccount_GetByID] (@RoleID INT , @Accountname NVARCHAR(100))
as
begin
	Select*from RoleAccount where RoleID=@RoleID and AccountName=@Accountname
end
GO
/****** Object:  StoredProcedure [dbo].[RoleAccout_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RoleAccout_Update] (@RoleID INT, @AccountName NVARCHAR(100), @Actived BIT,@Notes NVARCHAR(3000))
as
begin
	update RoleAccount
	set [AccountName]=@AccountName,[Actived]=@Actived,[Notes]=@Notes
	where RoleID=@RoleID
end
GO
/****** Object:  StoredProcedure [dbo].[table_delete]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[table_delete] ( @ID INT )
as
begin
	delete from [Table]
	where ID =@ID
end 
GO
/****** Object:  StoredProcedure [dbo].[Table_GetAll]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Table_GetAll]
As
Begin
	Select*from [Table]
end
GO
/****** Object:  StoredProcedure [dbo].[Table_GetByID]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Table_GetByID] (@ID INT )
As
begin
	Select*from [Table] where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[Table_Insert]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Table_Insert] ( @Name NVARCHAR(1000), @Status INT, @Capacity INT )
as
begin
	if(NOT EXISTS (select Name From [Table] where Name =@Name))
		Insert into [Table] (Name,Status,Capacity)
				VALUES (@Name,@Status,@Capacity)
end
GO
/****** Object:  StoredProcedure [dbo].[Table_Update]    Script Date: 9/30/2020 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Table_Update] (@ID INT, @Name NVARCHAR(1000), @Status INT, @Capacity INT )
as
begin
	Update [Table]
	Set	[Name] = @Name , [Status]=@Status,[Capacity]=@Capacity
	where ID=@ID
end
GO
USE [master]
GO
ALTER DATABASE [RestaurantManagement] SET  READ_WRITE 
GO
