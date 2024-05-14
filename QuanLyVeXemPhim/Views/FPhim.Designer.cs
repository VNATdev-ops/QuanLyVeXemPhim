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
            txtTimKiem = new TextBox();
            label2 = new Label();
            groupBox5 = new GroupBox();
            lblSoLuongDangChieu = new Label();
            txtSoLuongDangChieu = new TextBox();
            lblSoLuongPhim = new Label();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            btnThoat = new Button();
            btnNhapMoi = new Button();
            btnThem = new Button();
            bthXoa = new Button();
            btnCapNhat = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Font = new Font("Roboto", 24F);
            lblTenForm.Location = new Point(68, 50);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(345, 58);
            lblTenForm.TabIndex = 0;
            lblTenForm.Text = "QUẢN LÝ PHIM";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Roboto", 10F);
            lblTenPhim.Location = new Point(28, 93);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(93, 24);
            lblTenPhim.TabIndex = 1;
            lblTenPhim.Text = "Tên phim";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Roboto", 10F);
            lblTheLoai.Location = new Point(28, 139);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(81, 24);
            lblTheLoai.TabIndex = 1;
            lblTheLoai.Text = "Thể loại";
            // 
            // lblDaoDien
            // 
            lblDaoDien.AutoSize = true;
            lblDaoDien.Font = new Font("Roboto", 10F);
            lblDaoDien.Location = new Point(28, 187);
            lblDaoDien.Name = "lblDaoDien";
            lblDaoDien.Size = new Size(88, 24);
            lblDaoDien.TabIndex = 1;
            lblDaoDien.Text = "Đạo diễn";
            // 
            // txtSoLuongPhim
            // 
            txtSoLuongPhim.Enabled = false;
            txtSoLuongPhim.Location = new Point(178, 49);
            txtSoLuongPhim.Name = "txtSoLuongPhim";
            txtSoLuongPhim.ReadOnly = true;
            txtSoLuongPhim.Size = new Size(87, 32);
            txtSoLuongPhim.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
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
            groupBox1.Font = new Font("Roboto", 12F);
            groupBox1.Location = new Point(68, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1193, 595);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // rtbMoTa
            // 
            rtbMoTa.BorderStyle = BorderStyle.None;
            rtbMoTa.Font = new Font("Roboto", 10F);
            rtbMoTa.Location = new Point(207, 335);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(925, 197);
            rtbMoTa.TabIndex = 7;
            rtbMoTa.Text = "";
            // 
            // cbDinhDang
            // 
            cbDinhDang.Font = new Font("Roboto", 10F);
            cbDinhDang.FormattingEnabled = true;
            cbDinhDang.Location = new Point(864, 279);
            cbDinhDang.Name = "cbDinhDang";
            cbDinhDang.Size = new Size(268, 32);
            cbDinhDang.TabIndex = 6;
            // 
            // txtDoDai
            // 
            txtDoDai.Font = new Font("Roboto", 10F);
            txtDoDai.Location = new Point(864, 231);
            txtDoDai.Name = "txtDoDai";
            txtDoDai.Size = new Size(268, 32);
            txtDoDai.TabIndex = 2;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Font = new Font("Roboto", 10F);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(207, 279);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(429, 32);
            cbTrangThai.TabIndex = 6;
            // 
            // dtNgayPH
            // 
            dtNgayPH.Font = new Font("Roboto", 10F);
            dtNgayPH.Location = new Point(207, 231);
            dtNgayPH.Name = "dtNgayPH";
            dtNgayPH.Size = new Size(429, 32);
            dtNgayPH.TabIndex = 5;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Font = new Font("Roboto", 10F);
            txtDaoDien.Location = new Point(207, 180);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(925, 32);
            txtDaoDien.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Roboto", 10F);
            txtHinhAnh.Location = new Point(864, 40);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(268, 32);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDPhim
            // 
            txtIDPhim.Font = new Font("Roboto", 10F);
            txtIDPhim.Location = new Point(207, 40);
            txtIDPhim.Name = "txtIDPhim";
            txtIDPhim.Size = new Size(429, 32);
            txtIDPhim.TabIndex = 2;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Roboto", 10F);
            txtTenPhim.Location = new Point(207, 87);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(925, 32);
            txtTenPhim.TabIndex = 2;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Roboto", 10F);
            txtTheLoai.Location = new Point(207, 132);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(925, 32);
            txtTheLoai.TabIndex = 2;
            // 
            // lblDinhDang
            // 
            lblDinhDang.AutoSize = true;
            lblDinhDang.Font = new Font("Roboto", 10F);
            lblDinhDang.Location = new Point(702, 287);
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(99, 24);
            lblDinhDang.TabIndex = 1;
            lblDinhDang.Text = "Định dạng";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Roboto", 10F);
            lblTrangThai.Location = new Point(28, 287);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 24);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Roboto", 10F);
            lblMoTa.Location = new Point(28, 332);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(61, 24);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Mô tả";
            // 
            // lblDoDai
            // 
            lblDoDai.AutoSize = true;
            lblDoDai.Font = new Font("Roboto", 10F);
            lblDoDai.Location = new Point(702, 237);
            lblDoDai.Name = "lblDoDai";
            lblDoDai.Size = new Size(125, 24);
            lblDoDai.TabIndex = 1;
            lblDoDai.Text = "Độ dài (phút)";
            // 
            // lblNgayPH
            // 
            lblNgayPH.AutoSize = true;
            lblNgayPH.Font = new Font("Roboto", 10F);
            lblNgayPH.Location = new Point(28, 237);
            lblNgayPH.Name = "lblNgayPH";
            lblNgayPH.Size = new Size(149, 24);
            lblNgayPH.TabIndex = 1;
            lblNgayPH.Text = "Ngày phát hành";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Roboto", 10F);
            lblHinhAnh.Location = new Point(702, 46);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(89, 24);
            lblHinhAnh.TabIndex = 1;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Font = new Font("Roboto", 10F);
            lblIDPhim.Location = new Point(28, 46);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(78, 24);
            lblIDPhim.TabIndex = 1;
            lblIDPhim.Text = "ID phim";
            // 
            // lsvDSPhim
            // 
            lsvDSPhim.Font = new Font("Roboto", 10F);
            lsvDSPhim.Location = new Point(0, 105);
            lsvDSPhim.Name = "lsvDSPhim";
            lsvDSPhim.Size = new Size(1542, 275);
            lsvDSPhim.TabIndex = 0;
            lsvDSPhim.UseCompatibleStateImageBehavior = false;
            lsvDSPhim.SelectedIndexChanged += lsvDSPhim_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Roboto", 10F);
            txtTimKiem.Location = new Point(207, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1286, 32);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10F);
            label2.Location = new Point(28, 52);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongPhim);
            groupBox5.Controls.Add(lblSoLuongPhim);
            groupBox5.Location = new Point(1313, 565);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(297, 172);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            // 
            // lblSoLuongDangChieu
            // 
            lblSoLuongDangChieu.AutoSize = true;
            lblSoLuongDangChieu.Location = new Point(19, 104);
            lblSoLuongDangChieu.Name = "lblSoLuongDangChieu";
            lblSoLuongDangChieu.Size = new Size(109, 24);
            lblSoLuongDangChieu.TabIndex = 1;
            lblSoLuongDangChieu.Text = "Đang chiếu";
            // 
            // txtSoLuongDangChieu
            // 
            txtSoLuongDangChieu.Enabled = false;
            txtSoLuongDangChieu.Location = new Point(178, 98);
            txtSoLuongDangChieu.Name = "txtSoLuongDangChieu";
            txtSoLuongDangChieu.ReadOnly = true;
            txtSoLuongDangChieu.Size = new Size(87, 32);
            txtSoLuongDangChieu.TabIndex = 2;
            // 
            // lblSoLuongPhim
            // 
            lblSoLuongPhim.AutoSize = true;
            lblSoLuongPhim.Location = new Point(19, 55);
            lblSoLuongPhim.Name = "lblSoLuongPhim";
            lblSoLuongPhim.Size = new Size(138, 24);
            lblSoLuongPhim.TabIndex = 1;
            lblSoLuongPhim.Text = "Số lượng phim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSPhim);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Roboto", 12F);
            groupBox2.Location = new Point(68, 766);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1542, 380);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phim";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 87);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(bthXoa);
            panel1.Controls.Add(btnCapNhat);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(1313, 142);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 396);
            panel1.TabIndex = 34;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(42, 314);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(206, 56);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(42, 169);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(206, 56);
            btnNhapMoi.TabIndex = 0;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(42, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(206, 56);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // bthXoa
            // 
            bthXoa.Location = new Point(42, 241);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(206, 56);
            bthXoa.TabIndex = 0;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(42, 97);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(206, 56);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // FPhim
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1678, 1194);
            Controls.Add(panel1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FPhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPhim";
            Load += FPhim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
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
        private RichTextBox rtbMoTa;
        private TextBox txtTimKiem;
        private Label label2;
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
        private Panel panel1;
        private Button btnThoat;
        private Button btnNhapMoi;
        private Button btnThem;
        private Button bthXoa;
        private Button btnCapNhat;
    }
}