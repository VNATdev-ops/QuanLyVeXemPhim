USE QL_Rap_Chieu_Phim;

INSERT INTO NhanVien(IDNhanVien, TenNhanVien, MatKhau, NgaySinh, GioiTinh, Sdt, Email, ChucVu)
VALUES
('NV10001', N'Văn Mai Hương', '10012002', '2000-01-10', N'Nữ', '5251100339', 'vanmaihuowng1001@gmail.com', N'Quản lý'),
('NV10002', N'Hoàng Minh Nhật', '11092003', '2003-09-11', N'Nam', '1866770335', 'hoangminhnhat1109@gmail.com', N'Nhân viên'),
('NV10003', N'Phạm Minh Cường', '12051999', '1999-05-12', N'Nam', '7383230337', 'phamminhcuong1205@gmail.com', N'Nhân viên'),
('NV10004', N'Hồ Mai Thy', '27022005', '2005-02-27', N'Nữ', '1638239205', 'homaithy2702@gmail.com', N'Nhân viên'),
('NV10005', N'Lê Ngọc Ánh', '19022005', '2005-02-19', N'Nữ', '1238745364', 'lengocanh1902@gmail.com', N'Nhân viên');

INSERT INTO ThanhVien(IDThanhVien, TenThanhVien, MatKhau, NgaySinh, GioiTinh, KhuVuc, Email)
VALUES
('TV001', N'Đỗ Nhật Cường', '22012003', '2003-01-22', N'Nam', N'Gò Vấp', N'donhatcuong2201@gmail.com'),
('TV002', N'Mai Hồng Ngọc', '19022001', '2001-02-19', N'Nữ', N'Bình Thạnh', N'maihongng,oc19022001@gmail.com'),
('TV003', N'Nhật Kim Anh', '10102005', '2005-10-10', N'Nữ', N'Thủ Đức', N'nhatkhimanh1010@gmail.com');

INSERT INTO SanPham(IDSanPham, Loai, TenSanPham, Gia, DonViTinh, SoLuong, Hinh)
VALUES
('A1BCRM', N'Thức ăn', N'Bắp Caramel', 68000, N'Hộp', 40, NULL),
('A1BPM', N'Thức ăn', N'Bắp Phô Mai', 74000, N'Hộp', 40, NULL),
('B1CCML', N'Đồ uống', N'Cacao Milo', 51000, N'Ly', 100, NULL),
('B1CCCL', N'Đồ uống', N'Coca cola', 19000, N'Ly', 100, NULL),
('B1SD', N'Đồ uống', N'Soda trái cây', 25000, N'Ly', 100, NULL),
('V1IN3D', N'Vé xem phim', N'Inception (3D)', 100000, N'Vé', 100, NULL),
('V1TG3D', N'Vé xem phim', N'The Godfather (3D)', 100000, N'Vé', 100, NULL),
('V1TSR3D', N'Vé xem phim', N'The Shawshank Redemption (3D)', 100000, N'Vé', 100, NULL);

INSERT INTO Phim(IDPhim, TenPhim, TheLoai, DaoDien, MoTa, HinhAnh, NgayPhatHanh, DoDai, TrangThai, DinhDang)
VALUES
('MV01', N'The Shawshank Redemption', N'Drama', N'Frank Darabont', N'Bộ phim khắc họa nhân vật Andy sống gần hai thập kỷ trong Nhà tù Shawshank cấp tiểu bang, một nhà tù hư cấu tại Maine, và tình bạn của anh với Red, một người bạn tù. Bộ phim này là một thí dụ điển hình cho khoảng cách tiềm ẩn giữa thành công bước đầu tại các rạp chiếu phim và sự nổi tiếng rực rỡ.', NULL, '1994-10-14', 142, N'Đang chiếu', N'3D'),
('MV02', N'The Godfather', N'Crim, Drama', N'Francis Ford Coppola', N'Một ngày hè ở New York năm 1945, "Bố già" Don Vito Corleone (Marlon Brando) đón nhận nhiều niềm vui trong đời. Ông tổ chức đám cưới cho con gái độc nhất thì cậu con út Michael (Al Pacino) cũng trở về nhà sau Thế chiến thứ hai. Giữa bữa tiệc, Michael không ngừng kể cho bạn gái Kay Adams (Diane Keaton) về những tội ác của bố - trùm mafia, hứa rằng mình không như ông. Chẳng bao lâu, Don Vito bị kẻ thù ám sát giữa đường, may mắn không chết nhưng đẩy gia đình rơi vào trận chiến với các băng nhóm khác. Lúc này, Michael không còn cách nào khác phải cùng anh cả Sonny (James Caan) thay cha gánh vác trọng trách.', NULL, '1972-03-24', 175, N'Đang chiếu', N'3D'),
('MV03', N'Inception', N'Action, Adventuer, Sci-Fi', N'Christopher Nolan', N'"Inception” là bộ phim khoa học viễn tưởng về một thế giới, nơi một số rất ít người có được khả năng kiểm soát giấc mơ. Siêu trộm Dom Cobb (Leonardo DiCaprio) là người như vậy. Trong phim, Leonardo DiCaprio trong vai Dom Cobb là một người có khả năng đi vào giấc mơ của người khác và đánh cắp bí mật cũng như ý tưởng của họ. Khả năng kì lạ của Dom giúp anh nổi tiếng và được rất nhiều tổ chức gián điệp để ý tới. Nhưng chính điều đó cũng khiến anh phải trả giá đắt. Cuộc sống của anh bị xáo trộn và không còn bình yên nữa.', NULL, '2010-07-08', 148, N'Đang chiếu', N'3D');

INSERT INTO RapChieuPhim(IDRap, TenRap, DiaChi, SoLuongPhong, Logo)
VALUES
('C01', N'Prime Cinema Central', N'123 Lê Lợi, Quận 1, Thành phố Hồ Chí Minh', 6, NULL),
('C02', N'Prime Cinema Riverside', N'456 Nguyễn Huệ, Quận 1, Thành phố Hồ Chí Minh', 5, NULL),
('C03', N'Prime Cinema Skyline', N'789 Đinh Tiên Hoàng, Quận Bình Thạnh, Thành phố Hồ Chí Minh', 4, NULL),
('C04', N'Prime Cinema Paradise', N'101 Nguyễn Thị Minh Khai, Quận 3, Thành phố Hồ Chí Minh', 5, NULL);

INSERT INTO PhongChieu(IDPhong, IDRap, TenPhong, LoaiPhong, SoLuongGhe)
VALUES
('C01P01', 'C01', N'Phòng 1', N'VIP', 80),
('C01P02', 'C01', N'Phòng 2', N'Normal', 100),
('C01P03', 'C01', N'Phòng 3', N'VIP', 70),
('C02P01', 'C02', N'Phòng 1', N'Deluxe', 90),
('C02P02', 'C02', N'Phòng 2', N'Normal', 110),
('C02P03', 'C02', N'Phòng 3', N'VIP', 80),
('C03P01', 'C03', N'Phòng 1', N'Normal', 120),
('C03P02', 'C03', N'Phòng 2', N'Deluxe', 100),
('C03P03', 'C03', N'Phòng 3', N'VIP', 100),
('C03P04', 'C03', N'Phòng 4', N'Normal', 100),
('C04P01', 'C04', N'Phòng 1', N'VIP', 70),
('C04P02', 'C04', N'Phòng 2', N'Normal', 80),
('C04P03', 'C04', N'Phòng 3', N'Normal', 90),
('C04P04', 'C04', N'Phòng 4', N'Deluxe', 110),
('C04P05', 'C04', N'Phòng 5', N'VIP', 60);

INSERT INTO ChoNgoi(IDChoNgoi, IDPhong, LoaiChoNgoi, ViTri, TrangThai)
VALUES
('C01P01A1', 'C01P01', N'VIP', N'A1', N'Trống'),
('C01P01A2', 'C01P01', N'VIP', N'A2', N'Trống'),
('C01P01A3', 'C01P01', N'VIP', N'A3', N'Đã đặt'),
('C01P01A4', 'C01P01', N'VIP', N'A4', N'Đã đặt'),
('C01P01A5', 'C01P01', N'VIP', N'A5', N'Trống'),
('C01P02A1', 'C01P02', N'VIP', N'A1', N'Trống'),
('C01P02A2', 'C01P02', N'VIP', N'A2', N'Đã đặt'),
('C01P02A3', 'C01P02', N'VIP', N'A3', N'Trống'),
('C01P02A4', 'C01P02', N'VIP', N'A4', N'Đã đặt'),
('C01P02A5', 'C01P02', N'VIP', N'A5', N'Trống'),
('C01P03A1', 'C01P03', N'VIP', N'A1', N'Đã đặt'),
('C01P03A2', 'C01P03', N'VIP', N'A2', N'Trống'),
('C01P03A3', 'C01P03', N'VIP', N'A3', N'Trống'),
('C01P03A4', 'C01P03', N'VIP', N'A4', N'Đã đặt'),
('C02P01A1', 'C02P01', N'Normal', N'A1', N'Trống'),
('C02P01A2', 'C02P01', N'Normal', N'A2', N'Đã đặt'),
('C02P01A3', 'C02P01', N'Normal', N'A3', N'Đã đặt'),
('C02P02A1', 'C02P02', N'Normal', N'A1', N'Trống'),
('C02P02A2', 'C02P02', N'Normal', N'A2', N'Đã đặt'),
('C02P02A3', 'C02P02', N'Normal', N'A3', N'Trống'),
('C03P01A1', 'C03P01', N'Deluxe', N'A1', N'Trống'),
('C03P01A2', 'C03P01', N'Deluxe', N'A2', N'Trống'),
('C03P01A3', 'C03P01', N'Deluxe', N'A3', N'Đã đặt'),
('C03P01A4', 'C03P01', N'Deluxe', N'A4', N'Đã đặt'),
('C03P01A5', 'C03P01', N'Deluxe', N'A5', N'Trống'),
('C03P02A1', 'C03P02', N'Deluxe', N'A1', N'Trống'),
('C03P02A2', 'C03P02', N'Deluxe', N'A2', N'Đã đặt'),
('C03P02A3', 'C03P02', N'Deluxe', N'A3', N'Trống'),
('C03P02A4', 'C03P02', N'Deluxe', N'A4', N'Đã đặt'),
('C03P02A5', 'C03P02', N'Deluxe', N'A5', N'Trống'),
('C03P03A1', 'C03P03', N'Deluxe', N'A1', N'Trống'),
('C03P03A2', 'C03P03', N'Deluxe', N'A2', N'Đã đặt'),
('C03P03A3', 'C03P03', N'Deluxe', N'A3', N'Trống'),
('C03P03A4', 'C03P03', N'Deluxe', N'A4', N'Đã đặt'),
('C03P03A5', 'C03P03', N'Deluxe', N'A5', N'Trống'),
('C03P04A1', 'C03P04', N'Deluxe', N'A1', N'Trống'),
('C03P04A2', 'C03P04', N'Deluxe', N'A2', N'Đã đặt'),
('C03P04A3', 'C03P04', N'Deluxe', N'A3', N'Trống'),
('C03P04A4', 'C03P04', N'Deluxe', N'A4', N'Đã đặt'),
('C03P04A5', 'C03P04', N'Deluxe', N'A5', N'Trống'),
('C04P01A1', 'C04P01', N'VIP', N'A1', N'Trống'),
('C04P01A2', 'C04P01', N'VIP', N'A2', N'Đã đặt'),
('C04P01A3', 'C04P01', N'VIP', N'A3', N'Trống'),
('C04P01A4', 'C04P01', N'VIP', N'A4', N'Trống'),
('C04P01A5', 'C04P01', N'VIP', N'A5', N'Trống'),
('C04P02A1', 'C04P02', N'VIP', N'A1', N'Trống'),
('C04P02A2', 'C04P02', N'VIP', N'A2', N'Trống'),
('C04P02A3', 'C04P02', N'VIP', N'A3', N'Trống'),
('C04P02A4', 'C04P02', N'VIP', N'A4', N'Đã đặt'),
('C04P02A5', 'C04P02', N'VIP', N'A5', N'Đã đặt'),
('C04P03A1', 'C04P03', N'VIP', N'A1', N'Trống'),
('C04P03A2', 'C04P03', N'VIP', N'A2', N'Đã đặt'),
('C04P03A3', 'C04P03', N'VIP', N'A3', N'Đã đặt'),
('C04P03A4', 'C04P03', N'VIP', N'A4', N'Trống'),
('C04P03A5', 'C04P03', N'VIP', N'A5', N'Trống');

INSERT INTO SuatChieu(IDSuatChieu, IDPhim, IDRap, IDPhong, SoLuongVe, ThoiGianChieu, SoLuongConLai, TrangThai)
VALUES
('C01P01SC001', 'MV01', 'C01', 'C01P01', 50, '2024-05-08 09:00:00', 50, N'Còn vé'),
('C01P02SC001', 'MV01', 'C01', 'C01P02', 60, '2024-05-08 11:00:00', 60, N'Còn vé'),
('C01P03SC001', 'MV01', 'C01', 'C01P03', 70, '2024-05-08 13:00:00', 70, N'Còn vé'),
('C01P01SC002', 'MV02', 'C01', 'C01P01', 50, '2024-05-08 10:00:00', 50, N'Còn vé'),
('C01P02SC002', 'MV02', 'C01', 'C01P02', 60, '2024-05-08 12:00:00', 60, N'Còn vé'),
('C01P03SC002', 'MV02', 'C01', 'C01P03', 70, '2024-05-08 14:00:00', 70, N'Còn vé');


INSERT INTO ChonSuat(IDPhim, IDRap, IDSuatChieu)
VALUES
('MV01', 'C01', 'C01P01SC001'),
('MV01', 'C01', 'C01P02SC001'),
('MV01', 'C01', 'C01P03SC001'),
('MV02', 'C01', 'C01P01SC002'),
('MV02', 'C01', 'C01P02SC002'),
('MV02', 'C01', 'C01P03SC002');

INSERT INTO VeXemPhim(IDVe, IDThanhVien, IDPhim, IDSuatChieu, IDChoNgoi, GiaVe, TinhTrang)
VALUES
('V001', 'TV001', 'MV01', 'C01P01SC001', 'C01P01A1', 80000, N'Đã thanh toán'),
('V002', 'TV002', 'MV01', 'C01P02SC001', 'C01P02A2', 95000, N'Đã thanh toán'),
('V003', 'TV003', 'MV01', 'C01P03SC001', 'C01P03A3', 105000, N'Đã thanh toán'),
('V004', 'TV001', 'MV02', 'C01P01SC002', 'C01P01A4', 80000, N'Chưa thanh toán'),
('V005', 'TV002', 'MV02', 'C01P02SC002', 'C01P02A5', 95000, N'Chưa thanh toán'),
('V006', 'TV003', 'MV02', 'C01P03SC002', 'C01P03A1', 105000, N'Chưa thanh toán');

INSERT INTO HoaDon (IDHoaDon, NgayXuatHD, IDNhanVien, IDThanhVien)
VALUES
('HD001', '2024-05-08 09:20:00', 'NV10001', NULL),
('HD002', '2024-05-08 11:30:00', 'NV10001', NULL),
('HD003', '2024-05-08 13:40:00', 'NV10001', NULL),
('HD004', '2024-05-08 10:10:00', 'NV10001', 'TV001'),
('HD005', '2024-05-08 12:20:00', 'NV10001', 'TV002'),
('HD006', '2024-05-08 14:30:00', 'NV10001', 'TV003');

INSERT INTO CTHD (IDHoaDon, IDSanPham, SoLuong)
VALUES
('HD004', 'A1BCRM', 2),
('HD004', 'B1CCML', 1),
('HD005', 'A1BPM', 2),
('HD005', 'B1CCCL', 1),
('HD006', 'B1SD', 3);

INSERT INTO LichSuTichDiem(IDLichSu, SoDiemTichLuy, ThoiGianTichLuy, IDThanhVien)
VALUES
('DTL01', 20, '2024-04-01', 'TV001'),
('DTL02', 50, '2024-04-10', 'TV001'),
('DTL03', 30, '2024-04-20', 'TV001'),
('DTL04', 20, '2024-04-26', 'TV001'),
('DTL05', 50, '2024-04-27', 'TV001');