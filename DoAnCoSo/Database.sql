﻿CREATE DATABASE QuanLyNhaSach
     PRIMARY (NAME = QLThuVien_Data, 
	 -----luu file dang ky vao day
     FILENAME = 'C:\Users\Admin\Desktop\Project_CSDL2\DoAnCoSo1\QLThuVien_Data.MDF' , 
     SIZE = 50MB , 
     MAXSIZE = 200MB , 
     FILEGROWTH = 10MB) 
LOG ON (NAME = QLThuVien_Log , 
	-----luu file dang nhap vao day
     FILENAME = 'C:\Users\Admin\Desktop\Project_CSDL2\DoAnCoSo1\QLThuVien_Log.LDB' , 
     SIZE = 10MB, 
     FILEGROWTH = 5MB) 
GO
USE QuanLyNhaSach
GO
-----Tao cac bang
GO
CREATE TABLE NHANVIEN
(
	MaNV		CHAR(5) PRIMARY KEY,
	TenNV		NVARCHAR(100) NOT NULL,
	Gioitinh	Bit NOT NULL,
	NgaySinh    DATETIME NOT NULL,
	DiaChiNV	NVARCHAR(200) NOT NULL,
	DienThoai	NVARCHAR(20)
)
select * from NHANVIEN
GO
CREATE TABLE THELOAISACH
(
	MaTL		CHAR(5) PRIMARY KEY,
	TenTL		NVARCHAR(100) NOT NULL
)
select * from THELOAISACH
GO
CREATE TABLE SACH
(
	MaSach		CHAR(5) PRIMARY KEY,
	MaTL		CHAR(5) REFERENCES THELOAISACH(MaTL),
	TenSach		NVARCHAR(200) NOT NULL,
	TacGia		NVARCHAR(50) NOT NULL,
	NXB			NVARCHAR(200)NOT NULL,
	TonKho		INT
)
select * from SACH
GO
CREATE TABLE NHAPSACH
(
	MaPN		CHAR(5) PRIMARY KEY,
	MaSach		CHAR(5) REFERENCES SACH(MaSach),
	MaNV		CHAR(5) REFERENCES NHANVIEN(MaNV),
	SoLuong		INT NOT NULL,
	GiaSach		INT NOT NULL
)
select * from NHAPSACH
GO

CREATE TABLE DOCGIA
(
	MaDG		CHAR(5) PRIMARY KEY,
	TenDG		NVARCHAR(100) NOT NULL,
	Gioitinh	Bit NOT NULL,
	NgaySinh	DATETIME,
	DiaChiDG	NVARCHAR(200) NOT NULL,
	DienThoaiDG NVARCHAR(20),
	EmailDG		NVARCHAR(20)
)
select * from DOCGIA
GO
CREATE TABLE MUONSACH
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaDG		CHAR(5) REFERENCES DOCGIA(MaDG),
	MaSach		CHAR(5) REFERENCES SACH(MaSach),
	NgayMuon		DATETIME NOT NULL,
	NgayTra		DATETIME NOT NULL,
	SoLuong		INT NOT NULL,
	CocTien		INT NOT NULL,
	GiaThue		INT NOT NULL
) 
select * from MUONSACH
GO
CREATE TABLE TraSach
(
	MaPT		CHAR(5) PRIMARY KEY,
	MaDG		CHAR(5) REFERENCES DOCGIA(MaDG),
	MaSach		CHAR(5) REFERENCES SACH(MaSach),
	DonGiaPhat	INT NOT NULL,
	SoLuong		INT NOT NULL,
	NgayMuon	DATETIME NOT NULL,
	CanThanhToan	INT NOT NULL,
)
select * from TraSach
GO
CREATE TABLE PHIEUTHUTIEN
(
	MaPTT		CHAR(5)PRIMARY KEY,
	MaDG		CHAR(5) REFERENCES DOCGIA(MaDG),
	NgayThu		DATETIME NOT NULL,
	SoTien		INT NOT NULL,
)
select * from PHIEUTHUTIEN
------================Xong tạo bảng ràng buộc khóa ngoại=============
Go
select * from THELOAISACH
select * from SACH
select * from NHAPSACH
select * from NHANVIEN
select * from DOCGIA
select * from MUONSACH
select * from TRASACH
select * from PHIEUTHUTIEN
------================xong xem bảng=============
USE QuanLyNhaSach
GO
---TẠO RÀNG BUỘC KHÓA NGOẠI
--GO 
--ALTER TABLE NHAPSACH ADD CONSTRAINT FRK_SACH_NHAPSACH FOREIGN KEY(MaSach) REFERENCES PHIEUMUON(MaSach)
--ALTER TABLE NHAPSACH ADD CONSTRAINT FRK_NHAPSACH_NHANVIEN FOREIGN KEY(MaNV) REFERENCES SACH(MaNV) 

--ALTER TABLE SACH ADD CONSTRAINT FRK_SACH_MUONSACH FOREIGN KEY(MaSach) REFERENCES MUONSACH(MaSACH) 
---ALTER TABLE SACH ADD CONSTRAINT FRK_SACH_TRASACH FOREIGN KEY(MaSach) REFERENCES TRASACH(MaSach)  

--ALTER TABLE THELOAISACH ADD CONSTRAINT FRK_THELOAISACH_SACH FOREIGN KEY(MaTL) REFERENCES SACH(MaTL)  


--ALTER TABLE DOCGIA ADD CONSTRAINT FRK_DOCGIA_MUONSACH FOREIGN KEY(MaDG) REFERENCES MUONSACH(MaDG) 
--ALTER TABLE DOCGIA ADD CONSTRAINT FRK_DOCGIA_TRASACH FOREIGN KEY(MaDG) REFERENCES TRASACH(MaDG)

-------------------------Tao cac rang buoc-------------	
--ALTER TABLE SACH ADD CONSTRAINT DEF_SACH_TonKho  CHECK(TonKho>=0)
--ALTER TABLE NHANVIEN ADD CONSTRAINT UNQ_NHANVIEN_TenNV_DiaChiNV UNIQUE(TenNV,DiaChiNV),
--	CONSTRAINT DEF_NHANVIEN_NgaySinh DEFAULT(GETDATE()) FOR NgaySinh,
--CONSTRAINT DEF_NHANVIEN_DienThoai DEFAULT(N'Chua có') FOR DienThoai

--GO

-------------------truy vấn dữ liệu SACH-------------------
			--^^^^^^^^^^^^xong^^^^^^^^^^^
GO
CREATE PROC sp_LOADSACH
AS
	BEGIN
		SELECT * FROM SACH
	END
GO
CREATE PROC sp_SUASACH
@MaSach		CHAR(5),
@TenSach	NVARCHAR(200),
@MaTL	CHAR(5) ,
@TonKho		INT,
@NXB		NVARCHAR(200),
@TacGia		NVARCHAR(200)
AS
	BEGIN
		IF NOT EXISTS(SELECT MaSach FROM SACH WHERE MaSach=@MaSach)
			RETURN 1---KO TON TAI SACH
		ELSE
		UPDATE SACH
		SET TenSach=@TenSach,MaTL=@MaTL,TonKho=@TonKho,NXB=@NXB,TacGia=@TacGia
		WHERE MaSach=@MaSach
	END
GO
CREATE PROC sp_LUUSACH
@MaSach		CHAR(5),
@TenSach	NVARCHAR(200),
@MaTL	CHAR(5) ,
@TonKho		INT,
@NXB		NVARCHAR(200),
@TacGia		NVARCHAR(200)
AS
	BEGIN
		IF EXISTS(SELECT * FROM SACH WHERE MaSach=@MaSach)
			RETURN 1---TON TAI SACH
		INSERT INTO SACH VALUES (@MaSach,@TenSach,@MaTL,@TonKho,@NXB,@TacGia)
	END
GO
CREATE PROC sp_XOASACH
@MASACH CHAR(5)
AS
	BEGIN
		IF EXISTS(SELECT * FROM MUONSACH WHERE MaSach=@MaSach)
			RETURN 1---TON TAI MASACH TRONG PMUON
		IF EXISTS(SELECT * FROM TraSach WHERE MaSach=@MaSach)
			RETURN 2---TON TAI MASACH TRONG PNHACTRA
		IF EXISTS(SELECT * FROM NHAPSACH WHERE MaSach=@MaSach)
			RETURN 3---TON TAI MASACH TRONG PNHACTRA
		DELETE FROM SACH
		WHERE MaSach=@MASACH
	END
GO
-----------------truy vấn dữ liệu NHAP SACH

CREATE PROC sp_LOADNHAPSACH
AS
	BEGIN
		SELECT MaPN,MaSach,MaNV,SoLuong GiaSach FROM NHAPSACH
	END
GO
select * from NHAPSACH
GO
CREATE PROC sp_SUANHAPSACH
	@MaPN		CHAR(5),
	@MaSach		CHAR(5),
	@MaNV		CHAR(5),
	@SoLuong		INT ,
	@GiaSach		INT 
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM NHAPSACH WHERE MaPN=@MaPN)
			RETURN 1---ton tai ma PN
		UPDATE NHAPSACH
		SET MaSach=@MaSach,MaNV=@MaNV,SoLuong=@SoLuong,GiaSach=@GiaSach
		WHERE MaPN=@MaPN AND MaSach=@MaSach
	END
GO
CREATE PROC sp_LUUPHIEUNHAPSACH
	@MaPN		CHAR(5),
	@MaSach		CHAR(5),
	@MaNV		CHAR(5),
	@SoLuong		INT ,
	@GiaSach		INT 
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM
		
		 SACH WHERE MaSach=@MaSach)
			RETURN 1---KO TON TAI SACH
		IF NOT EXISTS(SELECT * FROM NHAPSACH WHERE MaPN=@MaPN)
			RETURN 2---TON TAI PHIEU NHAP
		INSERT INTO NHAPSACH VALUES (@MaPN,@MaSach,@MaNV,@SoLuong,@GiaSach)
	END
GO
CREATE PROC sp_XOAPHIEUNHAPSACH
@MaPN CHAR(5),
@MASACH CHAR(5)
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM NHAPSACH WHERE MaPN=@MAPN)
			RETURN 1---TON TAI MA PMUON
		IF NOT EXISTS(SELECT * FROM NHAPSACH WHERE MaSach=@MaSach)
			RETURN 2---TON TAI MASACH 
		DELETE FROM NHAPSACH
		WHERE @MaPN=MaPN AND @MASACH=MaSach
	END
GO
SELECT * FROM SACH
SELECT * FROM NHAPSACH
-----------------truy vấn dữ liệu NHANVIEN
GO

CREATE PROC sp_LOADNHANVIEN
AS
	BEGIN
		SELECT MaNV,TenNV,CASE WHEN Gioitinh=1 THEN 'Nam' ELSE N'NỮ' END AS Gioitinh,CONVERT(CHAR(10),NgaySinh,103) as NgaySinh,DiaChiNV,DienThoai FROM NHANVIEN
	END
GO
CREATE PROC sp_SUANHANVIEN
	@MaNV		CHAR(5) ,
	@TenNV		NVARCHAR(100),
	@Gioitinh	Bit,
	@NgaySinh    DATETIME ,
	@DiaChiNV	NVARCHAR(200),
	@DienThoai	NVARCHAR(20)
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM NHANVIEN WHERE MaNV=@MaNV)
			RETURN 1----KO TON TAI MANV
		UPDATE NHANVIEN
		SET TenNV=@TenNV,Gioitinh=@Gioitinh,NgaySinh=@NgaySinh,DiaChiNV=@DiaChiNV,DienThoai=@DienThoai
		WHERE MaNV=@MaNV
	END
GO
CREATE PROC sp_LUUNHANVIEN
	@MaNV		CHAR(5) ,
	@TenNV		NVARCHAR(100),
	@Gioitinh	Bit,
	@NgaySinh    DATETIME ,
	@DiaChiNV	NVARCHAR(200),
	@DienThoai	NVARCHAR(20)
AS
	BEGIN
		IF EXISTS(SELECT * FROM NHANVIEN WHERE MaNV=@MaNV)
			RETURN 1----TON TAI MANV
		INSERT INTO NHANVIEN VALUES (@MaNV,@TenNV,@Gioitinh,@NgaySinh,@DiaChiNV,@DienThoai)
	END
GO
CREATE PROC sp_XOANHANVIEN
@MANV CHAR(5)
AS
	BEGIN
	IF EXISTS(SELECT * FROM NHANVIEN WHERE MaNV=@MANV)
			RETURN 1----TON TAI MANV
		DELETE FROM NHANVIEN
		WHERE @MANV=MaNV
	END
GO
-----------------truy vấn dữ liệu THETHUVI
GO

GO
CREATE PROC sp_SUADOCGIA	
	@MaDG		CHAR(5),
	@TenDG		NVARCHAR(100),
	@Gioitinh	Bit,
	@NgaySinh	DATETIME,
	@DiaChiDG	NVARCHAR(200),
	@DienThoaiDG NVARCHAR(20),
	@EmailDG	NVARCHAR(20)	
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 1---KO TON TAI doc gia
		UPDATE DOCGIA
		SET TenDG=@TenDG,Gioitinh=@Gioitinh,NgaySinh=@NgaySinh,DiaChiDG=@DiaChiDG,DienThoaiDG=@DienThoaiDG,EmailDG=@EmailDG
		WHERE MaDG=@MaDG
	END
GO
CREATE PROC sp_LUUDOCGIA
	@MaDG		CHAR(5),
	@TenDG		NVARCHAR(100),
	@Gioitinh	Bit,
	@NgaySinh	DATETIME,
	@DiaChiDG	NVARCHAR(200),
	@DienThoaiDG NVARCHAR(20),
	@EmailDG		NVARCHAR(20)
AS
	BEGIN
		IF  EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 1
		INSERT INTO DOCGIA VALUES (@MaDG,@TenDG,@Gioitinh,@NgaySinh,@DiaChiDG,@DienThoaiDG,@EmailDG)
	END
GO
CREATE PROC sp_XOADOCGIA
@MaDG CHAR(5)
AS
	BEGIN
		IF EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 1---TON TAI DOCGIA
		DELETE FROM DOCGIA
		WHERE @MaDG=MaDG
	END
GO

-----------------truy vấn dữ liệu PHIEUMUON
CREATE PROC sp_MUONSACH
AS
	BEGIN
		SELECT MaPM,MaDG,MaSach,CONVERT(CHAR(10),NgayMuon,103) as NgayMuon,
		CONVERT(CHAR(10),NgayTra,103) as NgayTra,
		SoLuong,CocTien,GiaThue FROM MUONSACH
	END
GO
CREATE PROC sp_SUAPHIEUMUONSACH
	@MaPM		CHAR(5),
	@MaDG		CHAR(5),
	@MaSach		CHAR(5),
	@NgayMuon		DATETIME,
	@NgayTra		DATETIME,
	@SoLuong		INT,
	@CocTien		INT,
	@GiaThue		INT
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM MUONSACH WHERE MaPM=@MaPM)
			RETURN 1----KO TON TAI mapm
		IF NOT EXISTS(SELECT * FROM SACH WHERE MaSach=@MaSach)
			RETURN 2----KO TON TAI masach
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 3----KO TON TAI mathe
		UPDATE MUONSACH
		SET MaDG=@MaDG,MaSach=@MaSach,NgayMuon=@NgayMuon,NgayTra=@NgayTra,SoLuong=@SoLuong,
		CocTien=@CocTien,GiaThue=@GiaThue
		WHERE MaPM=@MaPM
	END
GO
CREATE PROC sp_LUUPHIEUMUONSACH
	@MaPM		CHAR(5),
	@MaDG		CHAR(5),
	@MaSach		CHAR(5),
	@NgayMuon		DATETIME,
	@NgayTra		DATETIME,
	@SoLuong		INT,
	@CocTien		INT,
	@GiaThue		INT
AS
	BEGIN	
		IF EXISTS(SELECT * FROM MUONSACH WHERE MaPM=@MaPM)
			RETURN 1----TON TAI mapm
		IF NOT EXISTS(SELECT * FROM SACH WHERE MaSach=@MaSach)
			RETURN 2----KO TON TAI masach
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 3----KO TON TAI Ma DG
		INSERT INTO MUONSACH VALUES (@MaPM,@MaDG,@MaSach,@NgayMuon,@NgayTra,@SoLuong,@CocTien,@GiaThue)
	END
GO
CREATE PROC sp_XOAPHIEUMUON
@MAPM CHAR(5)
AS
	BEGIN
		IF EXISTS(SELECT * FROM MUONSACH WHERE MaPM=@MaPM)
			RETURN 1----TON TAI mapm trong sachmuon
		DELETE FROM MUONSACH
		WHERE @MAPM=MaPM
	END
GO

-----------------truy vấn dữ liệu PHIEUNHACTRA
CREATE PROC sp_RELOADPHIEUTRASACH
AS
	BEGIN
		SELECT MaPT,MaDG,MaSach,DonGiaPhat,SoLuong,CONVERT(CHAR(10),NgayMuon,103)as NgayMuon,CanThanhToan FROM TraSach
	END
GO
CREATE PROC sp_SUAPHIEUNHACTRA
	@MaPT		CHAR(5),
	@MaDG		CHAR(5),
	@MaSach		CHAR(5),
	@DonGiaPhat		INT ,
	@SoLuong		INT,
	@NgayMuon	DATETIME,
	@CanThanhToan	INT
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TraSach WHERE MaPT=@MaPT)
			RETURN 1----KO TON TAI mapNT
		IF NOT EXISTS(SELECT * FROM SACH WHERE MaSach=@MaSach)
			RETURN 2----KO TON TAI maSach
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 3----KO TON TAI maDG
		UPDATE TraSach
		SET MaDG=@MaDG,MaSach=@MaSach,DonGiaPhat=@DonGiaPhat,SoLuong=@SoLuong,CanThanhToan=@CanThanhToan
		WHERE MaPT=@MaPT
	END
GO
CREATE PROC sp_LUUPHIEUNHACTRA
	@MaPT		CHAR(5),
	@MaDG		CHAR(5),
	@MaSach		CHAR(5),
	@DonGiaPhat		INT ,
	@SoLuong		INT,
	@NgayMuon	DATETIME,
	@CanThanhToan	INT
	
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TraSach WHERE MaPT=@MaPT)
			RETURN 1----KO TON TAI mapNT
		IF NOT EXISTS(SELECT * FROM SACH WHERE MaSach=@MaSach)
			RETURN 2----KO TON TAI maSach
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
			RETURN 3----KO TON TAI maDG
		INSERT INTO TraSach VALUES (@MaPT,@MaDG,@MaSach,@DonGiaPhat,@SoLuong,@NgayMuon,@CanThanhToan)
	END
GO
CREATE PROC sp_XOAPHIEUTRASACH
@MAPT CHAR(5)
AS
	BEGIN
		DELETE FROM TraSach
		WHERE @MAPT=MaPT
	END
GO
-----------------truy vấn dữ liệu PHIEUNHACTRA
select*from PHIEUTHUTIEN
CREATE PROC sp_RELOADPHIEUTHUTIEN
AS
	BEGIN
		SELECT MaPTT,MaDG,CONVERT(CHAR(10),NgayThu,103)as NgayThu,SoTien FROM PHIEUTHUTIEN
	END
GO
CREATE PROC sp_SUAPHIEUTHUTIEN
	@MaPTT		CHAR(5),
	@MaDG		CHAR(5),
	@NgayThu		DATETIME,
	@SoTien		INT
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM PHIEUTHUTIEN WHERE MaPTT=@MaPTT)
		RETURN 1----KO TON TAI maPTT
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
		RETURN 2----KO TON TAI maDG
		UPDATE PHIEUTHUTIEN
		SET MaDG=@MaDG,NgayThu=@NgayThu,SoTien=@SoTien
		WHERE MaPTT=@MaPTT
	END
GO
CREATE PROC sp_LUUPHIEUTHUTIEN
	@MaPTT		CHAR(5),
	@MaDG		CHAR(5),
	@NgayThu		DATETIME,
	@SoTien		INT
	
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM DOCGIA WHERE MaDG=@MaDG)
		RETURN 1----KO TON TAI maDG
		IF NOT EXISTS(SELECT * FROM PHIEUTHUTIEN WHERE MaPTT=@MaPTT)
		RETURN 2----KO TON TAI maPTT
		INSERT INTO PHIEUTHUTIEN VALUES (@MaPTT,@MaDG,@NgayThu,@SoTien)
	END
GO
CREATE PROC sp_XOAPHIEUTHUTIEN
@MAPTT CHAR(5)
AS
	BEGIN
		DELETE FROM PHIEUTHUTIEN
		WHERE @MAPTT=MaPTT
	END
GO
------------------Xong-----------------------------
GO
CREATE TABLE TAIKHOAN
(
	tendn nvarchar(100)not null primary key,
	mk nvarchar(100)not null,
	nhmk nvarchar(100) not null,
)
go
create proc sp_doctk
@tendn nvarchar(100),
@mk nvarchar(100)
as
	begin
		select TAIKHOAN.tendn,mk from TAIKHOAN where tendn=@tendn 
	end
GO	
create proc sp_luutk
@tendn nvarchar(100),
@mk nvarchar(100),
@nhmk nvarchar(100)
as
	begin
		insert into TAIKHOAN values (@tendn,@mk,@nhmk) 
	end
	--==========================xong^^^^^^^^^^^^^^^^^+=====--==========



