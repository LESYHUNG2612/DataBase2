CREATE DATABASE QuanLyNhaSach
GO
USE QuanLyNhaSach
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [char](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[Gioitinh] [Bit] NULL,
	[NgaySinh] [DATETIME] NULL,
	[DiaChiNV] [nvarchar](50) NULL,
	[DIENTHOAI] [nvarchar](50) NULL,
	
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [NgaySinh], [DiaChiNV], [DIENTHOAI]) 
VALUES (N'NV1', N'Lê Phong', '1', '21/02/1999', N'Bac Ninh', N'0906876130')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [NgaySinh], [DiaChiNV], [DIENTHOAI]) 
VALUES (N'NV2', N'Thái Vũ', '1', '29/02/1999', N'Quang Nam', N'081324567')
--===========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[tblTheLoaiSach](
	[MaTL] [char](5) NOT NULL,
	[TenTL] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
INSERT [dbo].[tblTheLoaiSach] ([MaTL], [TenTL]) 
VALUES (N'TL1', N'Truyện tranh')
INSERT [dbo].[tblTheLoaiSach] ([MaTL], [TenTL]) 
VALUES (N'TL2', N'Giáo Trình')

GO
--===========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[MASACH] [nvarchar](50) NOT NULL,
	[TENSACH] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NXB] [nvarchar](200) NULL,
	[MaTL] [char](5) NULL,
	[NgayMua] [DateTime] NULL,
	[TonKho] [int] NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblSach] ([MASACH], [TENSACH], [TacGia], [NXB], [MaTL], [NgayMua], [TonKho], [SOLUONG])
 VALUES ('MS01', N'Toán 1', N'Ngô A', N'Thái Bảo', N'TL01', N'Kim Dong','12/02/2014', 50, 4)
INSERT [dbo].[tblSach] ([MASACH], [TENSACH], [TacGia], [NXB], [MaTL], [NgayMua], [TonKho], [SOLUONG])
 VALUES ('MS02', N'toán 9', N'Kim Long', N'Thái Bảo', N'TL02', N'2012', '12/02/2014', 62, 12)
--===========================================================
Go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[tblNhapSach](
	[MAPN] [char](5) NOT NULL,
	[MaSach] [char](5) NULL,
	[SoLuong] [int] NULL,
	[GiaSach] [int] NULL,
	[MANV] [char](5) NOT NULL,
	[NgayNhap] [DATETIME] NULL,
 CONSTRAINT [PK_tbltblNhapSach] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblNhapSach] ([MAPN], [MaSach], [SoLuong], [GiaSach], [MANV], [NgayNhap])
 VALUES ('MP1', 'MS01','2', N'20.000', N'NV1','12/02/2014')
 INSERT [dbo].[tblNhapSach] ([MAPN], [MaSach], [SoLuong], [GiaSach], [MANV], [NgayNhap])
 VALUES ('MP20', 'MS02','4', N'80.000', N'NV1','12/02/2014')
--===========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[MADG] [nvarchar](5) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[GIOITINH] [nvarchar](5) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MADG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblDocGia] ([MADG], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [EMAIL], [SDT]) 
VALUES (N'DG01', N'Dư', CAST(0x0000A2EB00000000 AS DateTime), N'Nu', N'12a3', N'Hoa An', N'Caobang.com', '0987654321')
INSERT [dbo].[tblDocGia] ([MADG], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [EMAIL], [SDT]) 
VALUES (N'DG02', N'Gà', CAST(0x0000A2ED00000000 AS DateTime), N'Nu', N'12', N'city Bac Ninh', N'Congacon.com', '0897456324')
--===========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[tblMuonSach](
	[MAPM] [char](5) NOT NULL,
	[MaDG] [char](5) NULL,
	[MaSach] [char](5) NULL,
	[NgayMuon] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[CocTien] [int] NULL,
	[GiaThue] [int] NULL,
 CONSTRAINT [PK_tblMuonSach] PRIMARY KEY CLUSTERED 
(
	[MAPM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblMuonSach] ([MAPM], [MaDG], [MaSach], [NgayMuon], [NgayTra], [CocTien], [GiaThue]) 
VALUES (N'PM1', N'DG01','MS1', CAST(0x0000A2EB00000000 AS DateTime),CAST(0x0000A2EB00000000 AS DateTime),'20000','50000')
INSERT [dbo].[tblMuonSach] ([MAPM], [MaDG], [MaSach], [NgayMuon], [NgayTra], [CocTien], [GiaThue])
 VALUES (N'PM2', N'DG02','MS2', CAST(0x0000A2ED00000000 AS DateTime),CAST(0x0000A2EB00000000 AS DateTime),'20000','50000')
--===========================================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[tblTraSach](
	[MAPT] [char](5) NOT NULL,
	[MaDG] [char](5) NULL,
	[MaSach] [char](5) NULL,
	[NgayMuon] [datetime] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_tblTraSach] PRIMARY KEY CLUSTERED 
(
	[MAPT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblTraSach] ([MAPT], [MaDG], [MaSach], [NgayMuon], [ThanhToan]) 
VALUES (N'PT1', N'DG01','MS1', CAST(0x0000A2EB00000000 AS DateTime),'30000')
INSERT [dbo].[tblTraSach] ([MAPT], [MaDG], [MaSach], [NgayMuon], [ThanhToan])
 VALUES (N'PT2', N'DG02','MS2', CAST(0x0000A2ED00000000 AS DateTime),'30000')
--===========================================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[tblPhieuThuTien](
	[MAPT] [char](5) NOT NULL,
	[MaDG] [char](5) NULL,
	[NgayThu] [datetime] NULL,
	[SoTien] [int] NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[MAPT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PhieuThuTien] ([MAPT], [MaDG], [NgayThu], [SoTien]) 
VALUES (N'PT1', N'DG01', CAST(0x0000A2EB00000000 AS DateTime),'30000')
INSERT [dbo].[PhieuThuTien] ([MAPT], [MaDG], [NgayThu], [SoTien])
 VALUES (N'PT2', N'DG02', CAST(0x0000A2ED00000000 AS DateTime),'30000')
Go
