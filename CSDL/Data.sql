CREATE DATABASE QuanLyNhaSach
GO
USE QuanLyNhaSach
GO
-----Tao cac 
GO
CREATE TABLE NhanVien
(
	MaNV		CHAR(5) PRIMARY KEY,
	TenNV		NVARCHAR(100) NOT NULL,
	Gioitinh	Bit NOT NULL,
	NgaySinh    DATETIME NOT NULL,	
	ChucVuNV	NVARCHAR(50) NOT NULL,
	DiaChiNV	NVARCHAR(200) NOT NULL,
	DienThoai	NVARCHAR(20)
)
select * from NhanVien
GO
CREATE TABLE TheLoaiSach
(
	MaTL		CHAR(5) PRIMARY KEY,
	TenTL		NVARCHAR(200) NOT NULL
)
select * from TheLoaiSach
Go
CREATE TABLE Sach
(
	MaSach		CHAR(5) PRIMARY KEY,
	MaTL		CHAR(5) REFERENCES TheLoaiSach(MaTL),
	TenSach		NVARCHAR(200) NOT NULL,
	TacGia		NVARCHAR(50) NOT NULL,
	NXB			NVARCHAR(200)NOT NULL,
	NgayMua		DATETIME NOT NULL,
	TonKho		INT NOT NULL,
	SoLanMuon	INT NOT NULL
)
select * from Sach
Go
GO
CREATE TABLE NhapSach
(
	MaPN		CHAR(5) PRIMARY KEY,
	MaSach		CHAR(5) REFERENCES Sach(MaSach),	
	SoLuong		INT NOT NULL,
	GiaSach		CHAR(5) NOT NULL,
	MaNV		CHAR(5) REFERENCES NhanVien(MaNV),
	NgayNhap	DATETIME NOT NULL
) 
select * from NhapSach
GO
CREATE TABLE DocGia
(
	MaDG		CHAR(5) PRIMARY KEY,
	TenDG		NVARCHAR(50) NOT NULL,
	GioitinhDG	Bit NOT NULL,
	NgaySinhDG	DATETIME NOT NULL,
	DienThoaiDG	NVARCHAR(20),
	EmailDG		NVARCHAR(50),
	DiaChiDG	NVARCHAR(200)
) 
select * from DocGia
Go
CREATE TABLE MuonSach
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaDG		CHAR(5) REFERENCES DocGia(MaDG),
	MaSach		CHAR(5) REFERENCES Sach(MaSach),
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
	MaSach		CHAR(5) REFERENCES Sach(MaSach),
	MaĐG		CHAR(5) REFERENCES DocGia(MaDG),
	NgayMuon	DATETIME NOT NULL,
	ThanhToan	INT NOT NULL
) 
select * from TraSach
Go
CREATE TABLE PhieuThuTien
(
	MaPT		CHAR(5) PRIMARY KEY,
	MaDG		CHAR(5) REFERENCES DocGia(MaDG),
	NgayThu		DATETIME NOT NULL,
	SoTien	INT NOT NULL
) 
select * from PhieuThuTien
--xem bang
select * from NhanVien
select * from TheLoaiSach
select * from Sach
select * from NhapSach
select * from DocGia
select * from MuonSach
select * from TraSach
select * from PhieuThuTien