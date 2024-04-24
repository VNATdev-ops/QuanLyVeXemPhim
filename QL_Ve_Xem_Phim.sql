CREATE DATABASE QL_Ve_Xem_Phim;
USE QL_Ve_Xem_Phim;

CREATE TABLE ThucAnDoUong (
    IDMon INT PRIMARY KEY,
    Loai NVARCHAR(50),
    TenSanPham NVARCHAR(255),
    Gia DECIMAL(10, 2),
    Hinh NVARCHAR(MAX) 
);

CREATE TABLE NguoiDung (
    IDNguoiDung INT PRIMARY KEY,
    Ten NVARCHAR(255),
    MatKhau NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(50),
    KhuVuc NVARCHAR(255),
    Email NVARCHAR(255),
    LoaiTaiKhoan NVARCHAR(50)
);

CREATE TABLE Phim (
    IDPhim INT PRIMARY KEY,
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
    IDRap INT PRIMARY KEY,
    TenRap NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoLuongPhong INT,
    Logo NVARCHAR(MAX)
);

CREATE TABLE PhongChieu (
    IDPhong INT PRIMARY KEY,
    IDRap INT,
    TenPhong NVARCHAR(255),
    LoaiPhong NVARCHAR(255),
    SoLuongGhe INT,
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap)
);

CREATE TABLE SuatChieu (
    IDSuatChieu INT PRIMARY KEY,
    IDPhim INT,
    IDRap INT,
    SoLuongVe INT,
    ThoiGianChieu DATETIME,
    SoLuongConLai INT,
    TrangThai NVARCHAR(50),
    IDPhong INT, 
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap)
);

CREATE TABLE ChoNgoi (
    IDChoNgoi INT PRIMARY KEY,
    IDPhong INT,
    LoaiChoNgoi NVARCHAR(255),
    ViTri NVARCHAR(255),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (IDPhong) REFERENCES PhongChieu(IDPhong)
);

CREATE TABLE VeXemPhim (
    IDVe INT PRIMARY KEY,
    SuatChieuID INT,
    ChoNgoiID INT,
    GiaVe FLOAT,
    TinhTrang NVARCHAR(50),
    IDNguoiDung INT,
    IDPhim INT,
    FOREIGN KEY (SuatChieuID) REFERENCES SuatChieu(IDSuatChieu),
    FOREIGN KEY (ChoNgoiID) REFERENCES ChoNgoi(IDChoNgoi),
    FOREIGN KEY (IDNguoiDung) REFERENCES NguoiDung(IDNguoiDung),
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim)
);

CREATE TABLE MuaKem (
    IDVe INT,
    IDMon INT,
    PRIMARY KEY (IDVe, IDMon),
    FOREIGN KEY (IDMon) REFERENCES ThucAnDoUong(IDMon),
	FOREIGN KEY (IDVe) REFERENCES VeXemPhim(IDVe)
);

CREATE TABLE LichSuTichDiem (
    IDLichSu INT PRIMARY KEY,
    SoDiemTichLuy INT,
    ThoiGianTichLuy DATETIME,
    TongDiemTichLuy INT,
    IDNguoiDung INT,
    FOREIGN KEY (IDNguoiDung) REFERENCES NguoiDung(IDNguoiDung)
);

CREATE TABLE ChonSuat (
    IDPhim INT,
    IDRap INT,
    IDSuatChieu INT,
    PRIMARY KEY (IDPhim, IDRap, IDSuatChieu),
    FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
    FOREIGN KEY (IDRap) REFERENCES RapChieuPhim(IDRap),
    FOREIGN KEY (IDSuatChieu) REFERENCES SuatChieu(IDSuatChieu)
);
