CREATE DATABASE QL_Rap_Chieu_Phim;

USE QL_Rap_Chieu_Phim;

CREATE TABLE ThanhVien (
    IDThanhVien NVARCHAR(50) PRIMARY KEY,
    TenThanhVien NVARCHAR(255) NOT NULL,
	MatKhau NVARCHAR(20) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(50),
    KhuVuc NVARCHAR(255),
    Email NVARCHAR(255)
);

CREATE TABLE LichSuTichDiem (
    IDLichSu NVARCHAR(50) PRIMARY KEY,
    SoDiemTichLuy INT,
    ThoiGianTichLuy DATETIME,
    IDThanhVien NVARCHAR(50),
    FOREIGN KEY (IDThanhVien) REFERENCES ThanhVien(IDThanhVien)
);

CREATE TABLE NhanVien(
	IDNhanVien NVARCHAR(50) PRIMARY KEY,
	TenNhanVien NVARCHAR(255) NOT NULL,
	MatKhau NVARCHAR(20) NOT NULL,
	NgaySinh DATE,
	GioiTinh NVARCHAR(10),
	Sdt VARCHAR(10),
	Email NVARCHAR(100),
	ChucVu NVARCHAR(50)
);

CREATE TABLE Phim (
    IDPhim NVARCHAR(50) PRIMARY KEY,
    TenPhim NVARCHAR(255),
    TheLoai NVARCHAR(255),
    DaoDien NVARCHAR(255),
    MoTa NVARCHAR(MAX),
    HinhAnh NVARCHAR(MAX),
    NgayPhatHanh DATE,
    DoDai INT,
    TrangThai NVARCHAR(50),
    DinhDang NVARCHAR(50)
);

CREATE TABLE RapChieuPhim (
    IDRap NVARCHAR(50) PRIMARY KEY,
    TenRap NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoLuongPhong INT,
    Logo NVARCHAR(MAX)
);

CREATE TABLE PhongChieu (
    IDPhong NVARCHAR(50) PRIMARY KEY,
    IDRap NVARCHAR(50),
    TenPhong NVARCHAR(255),
    LoaiPhong NVARCHAR(255),
    SoLuongGhe INT,
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap)
);

CREATE TABLE ChoNgoi (
    IDChoNgoi NVARCHAR(50) PRIMARY KEY,
    IDPhong NVARCHAR(50),
    LoaiChoNgoi NVARCHAR(255),
    ViTri NVARCHAR(255),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (IDPhong) REFERENCES PhongChieu(IDPhong)
);

CREATE TABLE SuatChieu (
    IDSuatChieu NVARCHAR(50) PRIMARY KEY,
    IDPhim NVARCHAR(50),
    IDRap NVARCHAR(50),
	IDPhong NVARCHAR(50),
    SoLuongVe INT,
    ThoiGianChieu DATETIME,
    SoLuongConLai INT,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap),
	FOREIGN KEY (IDPhong) REFERENCES PhongChieu(IDPhong)
);

CREATE TABLE ChonSuat (
    IDPhim NVARCHAR(50),
    IDRap NVARCHAR(50),
    IDSuatChieu NVARCHAR(50),
    PRIMARY KEY (IDPhim, IDRap, IDSuatChieu),
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap),
    FOREIGN KEY (IDSuatChieu) REFERENCES SuatChieu(IDSuatChieu)
);

CREATE TABLE VeXemPhim (
    IDVe NVARCHAR(50) PRIMARY KEY,
    IDThanhVien NVARCHAR(50),
    IDPhim NVARCHAR(50),
    IDSuatChieu NVARCHAR(50),
    IDChoNgoi NVARCHAR(50),
    GiaVe DECIMAL,
    TinhTrang NVARCHAR(50),
    FOREIGN KEY (IDThanhVien) REFERENCES ThanhVien(IDThanhVien),
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
    FOREIGN KEY (IDSuatChieu) REFERENCES SuatChieu(IDSuatChieu),
    FOREIGN KEY (IDChoNgoi) REFERENCES ChoNgoi(IDChoNgoi)
);

CREATE TABLE SanPham (
    IDSanPham NVARCHAR(50) PRIMARY KEY,
    Loai NVARCHAR(50),
    TenSanPham NVARCHAR(255),
    Gia DECIMAL(10, 2),
    DonViTinh NVARCHAR(50),
    SoLuong INT,
    Hinh NVARCHAR(MAX) 
);

CREATE TABLE HoaDon (
	IDHoaDon NVARCHAR(50) PRIMARY KEY,
	NgayXuatHD DATETIME,
	IDNhanVien NVARCHAR(50),
	IDThanhVien NVARCHAR(50),
	FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien),
	FOREIGN KEY (IDThanhVien) REFERENCES ThanhVien(IDThanhVien)
);

CREATE TABLE CTHD (
	IDHoaDon NVARCHAR(50),
	IDSanPham NVARCHAR(50),
	SoLuong INT,
	FOREIGN KEY (IDHoaDon) REFERENCES HoaDon(IDHoaDon),
	FOREIGN KEY (IDSanPham) REFERENCES SanPham(IDSanPham)
);