CREATE DATABASE QuanLyNhaSach
GO
USE QuanLyNhaSach
GO
-----Tao cac 
GO
CREATE TABLE NHANVIEN
(
	MaNV		CHAR(5) PRIMARY KEY,
	TenNV		NVARCHAR(100) NOT NULL,
	Gioitinh	Bit NOT NULL,
	NgaySinh    DATETIME NOT NULL,	
	ChucVuNV	NVARCHAR(50) NOT NULL,
	DiaChiNV	NVARCHAR(200) NOT NULL,
	DienThoai	NVARCHAR(20)
)
select * from NHANVIEN
GO
CREATE TABLE TheLoaiSach
(
	MaTL		CHAR(5) PRIMARY KEY,
	TenTL		NVARCHAR(200) NOT NULL
)
select * from TheLoaiSach
Go
CREATE TABLE SACH
(
	MaSach		CHAR(5) PRIMARY KEY,
	MaTL		NVARCHAR(50) NOT NULL,
	TenSach		NVARCHAR(200) NOT NULL,
	TacGia		NVARCHAR(50) NOT NULL,
	NXB			NVARCHAR(200)NOT NULL,
	NgayMua		DATETIME NOT NULL,
	TonKho		INT NOT NULL,
	SoLanMuon	INT NOT NULL
)
select * from SACH
Go
GO
CREATE TABLE NhapSach
(
	MaPN		CHAR(5) PRIMARY KEY,
	MaSach		CHAR(5) NOT NULL,	
	SoLuong		INT NOT NULL,
	GiaSach		CHAR(5) NOT NULL,
	MaNV		CHAR(5) NOT NULL,
	NgayNhap	DATETIME NOT NULL
) 
select * from NhapSach
GO
CREATE TABLE DocGia
(
	MaĐG		CHAR(5) PRIMARY KEY,
	TenĐG		NVARCHAR(50) NOT NULL,
	GioitinhĐG	Bit NOT NULL,
	NgaySinhĐG	DATETIME NOT NULL,
	DienThoaiĐG	NVARCHAR(20),
	EmailĐG		NVARCHAR(50),
	DiaChiĐG	NVARCHAR(200)
) 
select * from DocGia
Go
CREATE TABLE MuonSach
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaĐG		CHAR(5),
	NgayMuon	DATETIME NOT NULL,
	NgayTra		DATETIME NOT NULL,
	CocTien		INT NOT NULL,
	GiaThue		INT NOT NULL
	
) 
select * from MuonSach
Go
CREATE TABLE TraSach
(
	MaPT		CHAR(5) PRIMARY KEY,
	MaĐG		CHAR(5),
	NgayMuon	DATETIME NOT NULL,
	ThanhToan	INT NOT NULL
) 
select * from TraSach
Go
CREATE TABLE PhieuThuTien
(
	MaPT		CHAR(5) PRIMARY KEY,
	MaĐG		CHAR(5),
	NgayThu		DATETIME NOT NULL,
	SoTien	INT NOT NULL
) 
select * from PhieuThuTien
--xem bang
select * from NHANVIEN
select * from TheLoaiSach
select * from SACH
select * from NhapSach
select * from DocGia
select * from MuonSach
select * from TraSach
select * from PhieuThuTien