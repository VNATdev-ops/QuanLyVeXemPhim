namespace QuanLyVeXemPhim.Views
{
    partial class FPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenForm = new Label();
            lblTenPhim = new Label();
            lblTheLoai = new Label();
            lblDaoDien = new Label();
            txtSoLuongPhim = new TextBox();
            groupBox1 = new GroupBox();
            rtbMoTa = new RichTextBox();
            cbDinhDang = new ComboBox();
            txtDoDai = new TextBox();
            cbTrangThai = new ComboBox();
            dtNgayPH = new DateTimePicker();
            txtDaoDien = new TextBox();
            txtHinhAnh = new TextBox();
            txtIDPhim = new TextBox();
            txtTenPhim = new TextBox();
            txtTheLoai = new TextBox();
            lblDinhDang = new Label();
            lblTrangThai = new Label();
            lblMoTa = new Label();
            lblDoDai = new Label();
            lblNgayPH = new Label();
            lblHinhAnh = new Label();
            lblIDPhim = new Label();
            lsvDSPhim = new ListView();
            groupBox4 = new GroupBox();
            btnThoat = new Button();
            btnNhapMoi = new Button();
            bthXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            groupBox5 = new GroupBox();
            lblSoLuongDangChieu = new Label();
            txtSoLuongDangChieu = new TextBox();
            lblSoLuongPhim = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Location = new Point(476, 55);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(134, 25);
            lblTenForm.TabIndex = 0;
            lblTenForm.Text = "QUẢN LÝ PHIM";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Location = new Point(31, 97);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(84, 25);
            lblTenPhim.TabIndex = 1;
            lblTenPhim.Text = "Tên phim";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Location = new Point(31, 144);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(73, 25);
            lblTheLoai.TabIndex = 1;
            lblTheLoai.Text = "Thể loại";
            // 
            // lblDaoDien
            // 
            lblDaoDien.AutoSize = true;
            lblDaoDien.Location = new Point(31, 194);
            lblDaoDien.Name = "lblDaoDien";
            lblDaoDien.Size = new Size(84, 25);
            lblDaoDien.TabIndex = 1;
            lblDaoDien.Text = "Đạo diễn";
            // 
            // txtSoLuongPhim
            // 
            txtSoLuongPhim.Enabled = false;
            txtSoLuongPhim.Location = new Point(316, 43);
            txtSoLuongPhim.Name = "txtSoLuongPhim";
            txtSoLuongPhim.Size = new Size(150, 31);
            txtSoLuongPhim.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbMoTa);
            groupBox1.Controls.Add(cbDinhDang);
            groupBox1.Controls.Add(txtDoDai);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(dtNgayPH);
            groupBox1.Controls.Add(txtDaoDien);
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(txtIDPhim);
            groupBox1.Controls.Add(txtTenPhim);
            groupBox1.Controls.Add(txtTheLoai);
            groupBox1.Controls.Add(lblDinhDang);
            groupBox1.Controls.Add(lblTheLoai);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(lblMoTa);
            groupBox1.Controls.Add(lblDoDai);
            groupBox1.Controls.Add(lblNgayPH);
            groupBox1.Controls.Add(lblHinhAnh);
            groupBox1.Controls.Add(lblIDPhim);
            groupBox1.Controls.Add(lblDaoDien);
            groupBox1.Controls.Add(lblTenPhim);
            groupBox1.Location = new Point(33, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1069, 585);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // rtbMoTa
            // 
            rtbMoTa.BorderStyle = BorderStyle.None;
            rtbMoTa.Location = new Point(194, 349);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(804, 206);
            rtbMoTa.TabIndex = 7;
            rtbMoTa.Text = "";
            // 
            // cbDinhDang
            // 
            cbDinhDang.FormattingEnabled = true;
            cbDinhDang.Location = new Point(791, 291);
            cbDinhDang.Name = "cbDinhDang";
            cbDinhDang.Size = new Size(207, 33);
            cbDinhDang.TabIndex = 6;
            // 
            // txtDoDai
            // 
            txtDoDai.Location = new Point(791, 241);
            txtDoDai.Name = "txtDoDai";
            txtDoDai.Size = new Size(207, 31);
            txtDoDai.TabIndex = 2;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(194, 291);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(390, 33);
            cbTrangThai.TabIndex = 6;
            // 
            // dtNgayPH
            // 
            dtNgayPH.Location = new Point(194, 241);
            dtNgayPH.Name = "dtNgayPH";
            dtNgayPH.Size = new Size(390, 31);
            dtNgayPH.TabIndex = 5;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Location = new Point(194, 188);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(804, 31);
            txtDaoDien.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(791, 42);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(207, 31);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDPhim
            // 
            txtIDPhim.Location = new Point(194, 42);
            txtIDPhim.Name = "txtIDPhim";
            txtIDPhim.Size = new Size(390, 31);
            txtIDPhim.TabIndex = 2;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Location = new Point(194, 91);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(804, 31);
            txtTenPhim.TabIndex = 2;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Location = new Point(194, 138);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(804, 31);
            txtTheLoai.TabIndex = 2;
            // 
            // lblDinhDang
            // 
            lblDinhDang.AutoSize = true;
            lblDinhDang.Location = new Point(644, 299);
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(95, 25);
            lblDinhDang.TabIndex = 1;
            lblDinhDang.Text = "Định dạng";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(31, 299);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(89, 25);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(31, 345);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 25);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Mô tả";
            // 
            // lblDoDai
            // 
            lblDoDai.AutoSize = true;
            lblDoDai.Location = new Point(644, 247);
            lblDoDai.Name = "lblDoDai";
            lblDoDai.Size = new Size(117, 25);
            lblDoDai.TabIndex = 1;
            lblDoDai.Text = "Độ dài (phút)";
            // 
            // lblNgayPH
            // 
            lblNgayPH.AutoSize = true;
            lblNgayPH.Location = new Point(31, 247);
            lblNgayPH.Name = "lblNgayPH";
            lblNgayPH.Size = new Size(139, 25);
            lblNgayPH.TabIndex = 1;
            lblNgayPH.Text = "Ngày phát hành";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(644, 48);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(83, 25);
            lblHinhAnh.TabIndex = 1;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Location = new Point(31, 48);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(76, 25);
            lblIDPhim.TabIndex = 1;
            lblIDPhim.Text = "ID phim";
            // 
            // lsvDSPhim
            // 
            lsvDSPhim.Location = new Point(31, 44);
            lsvDSPhim.Name = "lsvDSPhim";
            lsvDSPhim.Size = new Size(1576, 248);
            lsvDSPhim.TabIndex = 0;
            lsvDSPhim.UseCompatibleStateImageBehavior = false;
            lsvDSPhim.SelectedIndexChanged += lsvDSPhim_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnNhapMoi);
            groupBox4.Controls.Add(bthXoa);
            groupBox4.Controls.Add(btnCapNhat);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(1150, 225);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(527, 286);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(65, 196);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(401, 56);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(65, 115);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(169, 56);
            btnNhapMoi.TabIndex = 0;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // bthXoa
            // 
            bthXoa.Location = new Point(297, 115);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(169, 56);
            bthXoa.TabIndex = 0;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(297, 43);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(169, 56);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(65, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 56);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1150, 160);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(527, 31);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1150, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongPhim);
            groupBox5.Controls.Add(lblSoLuongPhim);
            groupBox5.Location = new Point(1150, 535);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(527, 157);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            // 
            // lblSoLuongDangChieu
            // 
            lblSoLuongDangChieu.AutoSize = true;
            lblSoLuongDangChieu.Location = new Point(38, 97);
            lblSoLuongDangChieu.Name = "lblSoLuongDangChieu";
            lblSoLuongDangChieu.Size = new Size(223, 25);
            lblSoLuongDangChieu.TabIndex = 1;
            lblSoLuongDangChieu.Text = "Số lượng phim đang chiếu";
            // 
            // txtSoLuongDangChieu
            // 
            txtSoLuongDangChieu.Enabled = false;
            txtSoLuongDangChieu.Location = new Point(316, 94);
            txtSoLuongDangChieu.Name = "txtSoLuongDangChieu";
            txtSoLuongDangChieu.Size = new Size(150, 31);
            txtSoLuongDangChieu.TabIndex = 2;
            // 
            // lblSoLuongPhim
            // 
            lblSoLuongPhim.AutoSize = true;
            lblSoLuongPhim.Location = new Point(38, 43);
            lblSoLuongPhim.Name = "lblSoLuongPhim";
            lblSoLuongPhim.Size = new Size(131, 25);
            lblSoLuongPhim.TabIndex = 1;
            lblSoLuongPhim.Text = "Số lượng phim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSPhim);
            groupBox2.Location = new Point(33, 718);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1644, 320);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phim";
            // 
            // FPhim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1758, 1087);
            Controls.Add(groupBox5);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Name = "FPhim";
            Text = "FPhim";
            Load += FPhim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenForm;
        private Label lblTenPhim;
        private Label lblTheLoai;
        private Label lblDaoDien;
        private TextBox txtSoLuongPhim;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox txtDaoDien;
        private TextBox txtTheLoai;
        private Label lblMoTa;
        private Label lblNgayPH;
        private RichTextBox richTextBox1;
        private TextBox textBox5;
        private Label lblDoDai;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label lblDinhDang;
        private Label lblTrangThai;
        private ListView lsvDSPhim;
        private DateTimePicker dtNgayPH;
        private ComboBox cbDinhDang;
        private ComboBox cbTrangThai;
        private GroupBox groupBox4;
        private Button bthXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnNhapMoi;
        private RichTextBox rtbMoTa;
        private TextBox txtTimKiem;
        private Label label2;
        private Button btnThoat;
        private TextBox txtTenPhim;
        private GroupBox groupBox5;
        private Label lblSoLuongDangChieu;
        private TextBox txtSoLuongDangChieu;
        private Label lblSoLuongPhim;
        private TextBox txtDoDai;
        private GroupBox groupBox2;
        private TextBox txtIDPhim;
        private Label lblIDPhim;
        private TextBox txtHinhAnh;
        private Label lblHinhAnh;
    }
}