INSERT INTO NhanVien(IDNhanVien, TenNhanVien, MatKhau, NgaySinh, GioiTinh, Sdt, Email, ChucVu)
VALUES
(10001, N'Văn Mai Hương', N'10012002', '2000-01-10', N'Nữ', N'5251100339', N'vanmaihuowng1001@gmail.com', N'Quản lý'),
(10002, N'Hoàng Minh Nhật', N'11092003', '2003-09-11', N'Nam', N'1866770335', N'hoangminhnhat1109@gmail.com', N'Nhân viên'),
(10003, N'Phạm Minh Cường', N'12051999', '1999-05-12', N'Nam', N'7383230337', N'phamminhcuong1205@gmail.com', N'Nhân viên'),
(10004, N'Hồ Mai Thy', N'27022005', '2005-02-27', N'Nữ', N'1638239205', N'homaithy2702@gmail.com', N'Nhân viên'),
(10005, N'Lê Ngọc Ánh', N'19022005', '2005-02-19', N'Nữ', N'1238745364', N'lengocanh1902@gmail.com', N'Nhân viên');

INSERT INTO ThanhVien(IDThanhVien, TenThanhVien, MatKhau, NgaySinh, GioiTinh, KhuVuc, Email)
VALUES
('TV001', N'Đỗ Nhật Cường', '22012003', '2003-01-22', N'Nam', N'Gò Vấp', N'donhatcuong2201@gmail.com'),
('TV002', N'Mai Hồng Ngọc', '19022001', '2001-02-19', N'Nữ', N'Bình Thạnh', N'maihongngoc19022001@gmail.com'),
('TV003', N'Nhật Kim Anh', '10102005', '2005-10-10', N'Nữ', N'Thủ Đức', N'nhatkhimanh1010@gmail.com');

INSERT INTO ThucAnDoUong(IDSanPham, Loai, TenSanPham, Gia, Hinh)
VALUES
('A1BCRM', N'Thức ăn', N'Bắp Caramel', 68000, NULL),
('A1BPM', N'Thức ăn', N'Bắp Phô Mai', 74000, NULL),
('B1CCML', N'Đồ uống', N'Cacao Milo', 51000, NULL),
('B1CCCL', N'Đồ uống', N'Coca cola', 19000, NULL),
('B1SD', N'Đồ uống', N'Soda trái cây', 25000, NULL);

INSERT INTO Phim(IDPhim, TenPhim, TheLoai, DaoDien, MoTa, HinhAnh, NgayPhatHanh, DoDai, TrangThai, DinhDang)
VALUES
('MV01', N'The Shawshank Redemption', N'Drama', N'Frank Darabont', N'Bộ phim khắc họa nhân vật Andy sống gần hai thập kỷ trong Nhà tù Shawshank cấp tiểu bang, một nhà tù hư cấu tại Maine, và tình bạn của anh với Red, một người bạn tù. Bộ phim này là một thí dụ điển hình cho khoảng cách tiềm ẩn giữa thành công bước đầu tại các rạp chiếu phim và sự nổi tiếng rực rỡ.', NULL, '1994-10-14', 142, N'Đang chiếu', N'3D'),
('MV02', N'The Godfather', N'Crim, Drama', N'Francis Ford Coppola', N'Một ngày hè ở New York năm 1945, "Bố già" Don Vito Corleone (Marlon Brando) đón nhận nhiều niềm vui trong đời. Ông tổ chức đám cưới cho con gái độc nhất thì cậu con út Michael (Al Pacino) cũng trở về nhà sau Thế chiến thứ hai. Giữa bữa tiệc, Michael không ngừng kể cho bạn gái Kay Adams (Diane Keaton) về những tội ác của bố - trùm mafia, hứa rằng mình không như ông. Chẳng bao lâu, Don Vito bị kẻ thù ám sát giữa đường, may mắn không chết nhưng đẩy gia đình rơi vào trận chiến với các băng nhóm khác. Lúc này, Michael không còn cách nào khác phải cùng anh cả Sonny (James Caan) thay cha gánh vác trọng trách.', NULL, '1972-03-24', 175, N'Đang chiếu', N'3D'),
('MV03', N'Inception', N'Action, Adventuer, Sci-Fi', N'Christopher Nolan', N'"Inception” là bộ phim khoa học viễn tưởng về một thế giới, nơi một số rất ít người có được khả năng kiểm soát giấc mơ. Siêu trộm Dom Cobb (Leonardo DiCaprio) là người như vậy. Trong phim, Leonardo DiCaprio trong vai Dom Cobb là một người có khả năng đi vào giấc mơ của người khác và đánh cắp bí mật cũng như ý tưởng của họ. Khả năng kì lạ của Dom giúp anh nổi tiếng và được rất nhiều tổ chức gián điệp để ý tới. Nhưng chính điều đó cũng khiến anh phải trả giá đắt. Cuộc sống của anh bị xáo trộn và không còn bình yên nữa.', NULL, '2010-07-08', 148, N'Đang chiếu', N'3D');

INSERT INTO RapChieuPhim(IDRap, TenRap, DiaChi, SoLuongPhong, Logo)
VALUES
('CC01', N'Cineplex Cinema', N'123 Main Street Cityville', 1, NULL),
('MC02', N'MegaPlex Cinema', N'456 Broadway, Townsville', 1, NULL),
('CGV01', N'CGV', N'561A Đ. Điện Biên Phủ, Phường 25, Bình Thạnh, Thành phố Hồ Chí Minh 700000', 1, NULL);

INSERT INTO PhongChieu(IDPhong, IDRap, TenPhong, LoaiPhong, SoLuongGhe)
VALUES
('R01', 'CC01', N'Room 1', N'3D', 10),
('R02', 'MC02', N'Room 2', N'3D', 20),
('R03', 'CGV01', N'Room 3', N'3D', 15);

INSERT INTO ChoNgoi(IDChoNgoi, IDPhong, LoaiChoNgoi, ViTri, TrangThai)
VALUES
('R0101', 'R01', N'Ghế VIP', N'A01', N'Trống'),
('R0102', 'R01', N'Ghế VIP', N'A02', N'Trống'),
('R0103', 'R01', N'Ghế VIP', N'A03', N'Trống'),
('R0104', 'R01', N'Ghế VIP', N'A04', N'Trống'),
('R0105', 'R01', N'Ghế VIP', N'A05', N'Đã đặt'),
('R0106', 'R01', N'Ghế Thường', N'B06', N'Đã đặt'),
('R0107', 'R01', N'Ghế Thường', N'B07', N'Trống'),
('R0108', 'R01', N'Ghế Thường', N'B08', N'Trống'),
('R0109', 'R01', N'Ghế Thường', N'B09', N'Trống'),
('R0110', 'R01', N'Ghế Thường', N'B10', N'Đã đặt'),
('R0201', 'R02', N'Ghế VIP', N'L01', N'Trống'),
('R0202', 'R02', N'Ghế VIP', N'L02', N'Trống'),
('R0203', 'R02', N'Ghế VIP', N'L03', N'Trống'),
('R0204', 'R02', N'Ghế VIP', N'L04', N'Trống'),
('R0205', 'R02', N'Ghế VIP', N'L05', N'Trống'),
('R0206', 'R02', N'Ghế VIP', N'L06', N'Trống'),
('R0207', 'R02', N'Ghế VIP', N'L07', N'Trống'),
('R0208', 'R02', N'Ghế VIP', N'L08', N'Đã đặt'),
('R0209', 'R02', N'Ghế VIP', N'L09', N'Đã đặt'),
('R0210', 'R02', N'Ghế VIP', N'L10', N'Trống'),
('R0211', 'R02', N'Ghế VIP', N'L11', N'Trống'),
('R0212', 'R02', N'Ghế VIP', N'L12', N'Trống'),
('R0213', 'R02', N'Ghế Thường', N'H13', N'Trống'),
('R0214', 'R02', N'Ghế Thường', N'H14', N'Đã đặt'),
('R0215', 'R02', N'Ghế Thường', N'H15', N'Đã đặt'),
('R0216', 'R02', N'Ghế Thường', N'H16', N'Trống'),
('R0217', 'R02', N'Ghế Thường', N'H17', N'Trống'),
('R0218', 'R02', N'Ghế Thường', N'H18', N'Trống'),
('R0219', 'R02', N'Ghế Thường', N'H19', N'Trống'),
('R0220', 'R02', N'Ghế Thường', N'H20', N'Đã đặt'),
('R0301', 'R03', N'Ghế VIP', N'E01', N'Trống'),
('R0302', 'R03', N'Ghế VIP', N'E02', N'Trống'),
('R0303', 'R03', N'Ghế VIP', N'E03', N'Đã đặt'),
('R0304', 'R03', N'Ghế VIP', N'E04', N'Trống'),
('R0305', 'R03', N'Ghế VIP', N'E05', N'Trống'),
('R0306', 'R03', N'Ghế Thường', N'F06', N'Trống'),
('R0307', 'R03', N'Ghế Thường', N'F07', N'Trống'),
('R0308', 'R03', N'Ghế Thường', N'F08', N'Trống'),
('R0309', 'R03', N'Ghế Thường', N'F09', N'Trống'),
('R0310', 'R03', N'Ghế Thường', N'F10', N'Trống'),
('R0311', 'R03', N'Ghế Sweetbox', N'G11', N'Trống'),
('R0312', 'R03', N'Ghế Sweetbox', N'G12', N'Đã đặt'),
('R0313', 'R03', N'Ghế Sweetbox', N'G13', N'Đã đặt'),
('R0314', 'R03', N'Ghế Sweetbox', N'G14', N'Trống'),
('R0315', 'R03', N'Ghế Sweetbox', N'G15', N'Trống');

INSERT INTO SuatChieu(IDSuatChieu, IDPhim, IDRap, IDPhong, SoLuongVe, ThoiGianChieu, SoLuongConLai, TrangThai)
VALUES
('F01', 'MV01', 'CGV01', 'R03', 15, '2024-04-13 18:00:00', 3, N'Còn Trống'),
('F02', 'MV02', 'CC01', 'R01', 10, '2024-04-13 20:00:00', 5, N'Còn Trống'),
('F03', 'MV03', 'MC02', 'R02', 20, '2024-04-12 15:00:00', 4, N'Còn Trống');

INSERT INTO ChonSuat(IDPhim, IDRap, IDSuatChieu)
VALUES
('MV01', 'CGV01', 'F01'),
('MV02', 'CC01', 'F02'),
('MV03', 'MC02', 'F03');

INSERT INTO LichSuTichDiem(IDLichSu, SoDiemTichLuy, ThoiGianTichLuy, TongDiemTichLuy, IDThanhVien)
VALUES
('DTL01', 20, '2024-04-01', 20, 'TV001'),
('DTL02', 50, '2024-04-10', 70, 'TV001'),
('DTL03', 30, '2024-04-20', 100, 'TV001'),
('DTL04', 20, '2024-04-26', 120, 'TV001'),
('DTL05', 50, '2024-04-27', 170, 'TV001');