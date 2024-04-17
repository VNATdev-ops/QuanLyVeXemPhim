CREATE DATABASE QuanLyVeXemPhim
USE QuanLyVeXemPhim

CREATE TABLE Phim (
    PhimID INT PRIMARY KEY,
    TenPhim VARCHAR(255) NOT NULL,
    NgayChieuPhim DATE,
    DaoDien VARCHAR(255),
    TheLoaiPhim VARCHAR(100)	
);

CREATE TABLE RapChieuPhim (
    RapChieuPhimID INT PRIMARY KEY,
    TenRapChieuPhim VARCHAR(255) NOT NULL,
    DiaChi VARCHAR(255)
);

CREATE TABLE LichChieuPhim (
    ThoiGianChieuID INT PRIMARY KEY,
    PhimID INT,
    RapChieuPhimID INT,
    ThoiGianChieuPhim DATETIME,
    FOREIGN KEY (PhimID) REFERENCES Phim(PhimID),
    FOREIGN KEY (RapChieuPhimID) REFERENCES RapChieuPhim(RapChieuPhimID)
);

CREATE TABLE LoaiVeXemPhim (
    LoaiVeXemPhimID INT PRIMARY KEY,
    TenLoaiVeXemPhim VARCHAR(50),
    GiaVe DECIMAL(10,2)
);

-- B?ng cho thông tin vé ?ã bán
CREATE TABLE VeXemPhim (
    VeXemPhimID INT PRIMARY KEY,
    ThoiGianChieuID INT,
    LoaiVeXemPhimID INT,
    Quantity INT,
    FOREIGN KEY (ThoiGianChieuID) REFERENCES LichChieuPhim(ThoiGianChieuID),
    FOREIGN KEY (LoaiVeXemPhimID) REFERENCES LoaiVeXemPhim(LoaiVeXemPhimID)
);

-- B?ng cho thông tin ng??i xem
CREATE TABLE KhachHang (
    KhachHangID INT PRIMARY KEY,
    TenKH VARCHAR(255),
    Email VARCHAR(255),
    Phone VARCHAR(20)
);

-- B?ng liên k?t gi?a vé và ng??i xem
CREATE TABLE VeXemPhimChuaBan (
    VeXemPhimChuaBan INT PRIMARY KEY,
    VeXemPhimID INT,
    KhachHangID INT,
    NgayBanVe DATE,
    FOREIGN KEY (VeXemPhimID) REFERENCES VeXemPhim(VeXemPhimID),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);

INSERT INTO Phim(PhimID, TenPhim, NgayChieuPhim, DaoDien, TheLoaiPhim)
VALUES 
(1, N'The Shawshank Redemption', '1994-10-14', N'Frank Darabont', N'Drama'),
(2, N'The Godfather', '1972-03-24', N'Francis Ford Coppola', N'Crime, Drama'),
(3, N'Inception', '2010-07-16', N'Christopher Nolan', N'Action, Adventure, Sci-Fi');

INSERT INTO RapChieuPhim (RapChieuPhimID, TenRapChieuPhim, DiaChi)
VALUES 
(1, N'Cineplex Cinema', N'123 Main Street, Cityville'),
(2, N'MegaPlex Cinemas', N'456 Broadway, Townsville');

INSERT INTO LichChieuPhim (ThoiGianChieuID, PhimID, RapChieuPhimID, ThoiGianChieuPhim)
VALUES 
(1, 1, 1, '2024-04-13 18:00:00'),
(2, 2, 1, '2024-04-13 20:00:00'),
(3, 3, 2, '2024-04-14 15:00:00');

INSERT INTO LoaiVeXemPhim (LoaiVeXemPhimID, TenLoaiVeXemPhim, GiaVe)
VALUES 
(1, N'Adult', 10.00),
(2, N'Child', 5.00),
(3, N'Senior', 7.50);

INSERT INTO VeXemPhim (VeXemPhimID, ThoiGianChieuID, LoaiVeXemPhimID, Quantity) -- Quantity so luong
VALUES 
(1, 1, 1, 2),
(2, 1, 2, 1),
(3, 2, 1, 3);

INSERT INTO KhachHang(KhachHangID, TenKH, Email, Phone)
VALUES 
(1, N'John Doe', N'john@example.com', N'123-456-7890'),
(2, N'Jane Smith', N'jane@example.com', N'987-654-3210');

INSERT INTO VeXemPhimChuaBan (VeXemPhimChuaBan,  VeXemPhimID, KhachHangID, NgayBanVe)
VALUES 
(1, 1, 1, '2024-04-13'),
(2, 2, 2, '2024-04-13'),
(3, 3, 1, '2024-04-13');












