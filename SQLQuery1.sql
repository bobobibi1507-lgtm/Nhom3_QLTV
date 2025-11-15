Create database QLTV;
Use QLTV;
go
-- Tao bang tac gia
create table TacGia (
	MaTG char(10) primary key,
	TenTG nvarchar(50) not null,
	NamSinh char(4)
);
go
-- Tao bang trang thai
create table TrangThai (
    MaTT char(10) primary key check (MaTT in ('Bor','UnA', 'Av','LibOnly')) ,
	TenTT nvarchar(50) not null
	);
go
-- Tao bang loai tai lieu
create table LoaiTL (
    MaTheLoai char(4) primary key,
	TenTheloai nvarchar(30) not null
	);
go
-- Tao bang DMTL
create table DMTL (
    MaDMTL char(8) primary key,
	TenDMTL nvarchar(50) not null,
	MaTheloai char(4) foreign key references LoaiTL(MaTheloai)
	);
go
-- Tao bang DMTL_TG
    create table DMTL_TG (
	MaDMTL char(8) foreign key references DMTL(MaDMTL),
	MaTG char(10) foreign key references TacGia(MaTG),
	primary key (MaDMTL,MaTG)
	);
go
-- Tao bang Tai lieu
    Create table TaiLieu (
	MaTL char(10) primary key,
	MaDMTL char(8) foreign key references DMTL(MaDMTL),
	MaTT char(10) foreign key references TrangThai(MaTT)
	);
go
-- Tao bang hinh thuc muon
    Create table HinhThucMuon (
	MaKM char(8) primary key check (MaKM in ('MV', 'TC')),
	TenKM nvarchar(30) not null
	);
go
-- Tao bang chuc vu
    Create table ChucVu (
	MaCV char(8) primary key check (MaCV in ('SV', 'GV')),
	TenCV nvarchar(30) not null
	);
go
-- Tao bang doc gia
    Create table DocGia (
	SoThe char(8) primary key,
	TenDG nvarchar(50) not null,
	NgayCap date not null,
	MaCV char(8) foreign key references ChucVu(MaCV)
	);
go
-- Tao bang thu thu
    Create table ThuThu (
	MaThuThu char(8) primary key,
	TenThuThu nvarchar(50) not null,
	SĐT char(10)
	);
go
-- Tao bang phieu muon
    Create table PhieuMuon (
	MaPM char(8) primary key,
	SoThe char(8) foreign key references DocGia(SoThe) not null,
	MaThuThu char(8) foreign key references ThuThu(MaThuThu) not null,
	MaKM char(8) foreign key references HinhThucMuon(MaKM) not null,
	NgayMuon date not null,
	HanTra as (
               case
                when MaKM ='MV' then Dateadd (Day,7,NgayMuon)
                when MaKM ='TC' then NgayMuon
               end
              ),
	);
go
-- Tao bang CTPM
    Create table CTPM (
	MaPM char(8) foreign key references PhieuMuon(MaPM),
	MaTL char(10) foreign key references TaiLieu(MaTL),
	primary key (MaPM, MaTL),
	NgayThucTra Date,
	GhiChu nvarchar(100)
	);
go
-- Kiểm tra ngày thực trả
	CREATE TRIGGER CheckNgThucTra_CTPM
    ON CTPM
    AFTER INSERT
    AS
    BEGIN
      SET NOCOUNT ON;
       IF EXISTS (
         SELECT 1 
         FROM inserted i 
         JOIN PhieuMuon pm ON i.MaPM = pm.MaPM 
         WHERE i.NgayThucTra IS NOT NULL AND i.NgayThucTra < pm.NgayMuon
       )
    BEGIN
         PRINT N'Ngày thực trả không thể nhỏ hơn ngày mượn!';
         ROLLBACK TRANSACTION;
         RETURN;
    END;
    END;
go
