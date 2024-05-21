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
            lblTenForm.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTenForm.Location = new Point(73, 74);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(380, 55);
            lblTenForm.TabIndex = 0;
            lblTenForm.Text = "QUẢN LÝ PHIM";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Microsoft Sans Serif", 10F);
            lblTenPhim.Location = new Point(56, 103);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(94, 25);
            lblTenPhim.TabIndex = 0;
            lblTenPhim.Text = "Tên phim";
            lblTenPhim.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Microsoft Sans Serif", 10F);
            lblTheLoai.Location = new Point(56, 151);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(82, 25);
            lblTheLoai.TabIndex = 0;
            lblTheLoai.Text = "Thể loại";
            lblTheLoai.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDaoDien
            // 
            lblDaoDien.AutoSize = true;
            lblDaoDien.Font = new Font("Microsoft Sans Serif", 10F);
            lblDaoDien.Location = new Point(56, 201);
            lblDaoDien.Name = "lblDaoDien";
            lblDaoDien.Size = new Size(90, 25);
            lblDaoDien.TabIndex = 0;
            lblDaoDien.Text = "Đạo diễn";
            lblDaoDien.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSoLuongPhim
            // 
            txtSoLuongPhim.Enabled = false;
            txtSoLuongPhim.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongPhim.Location = new Point(181, 30);
            txtSoLuongPhim.Name = "txtSoLuongPhim";
            txtSoLuongPhim.ReadOnly = true;
            txtSoLuongPhim.Size = new Size(90, 30);
            txtSoLuongPhim.TabIndex = 17;
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(73, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1358, 583);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // rtbMoTa
            // 
            rtbMoTa.BorderStyle = BorderStyle.None;
            rtbMoTa.Font = new Font("Microsoft Sans Serif", 10F);
            rtbMoTa.Location = new Point(251, 355);
            rtbMoTa.Margin = new Padding(5);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(1035, 190);
            rtbMoTa.TabIndex = 10;
            rtbMoTa.Text = "";
            // 
            // cbDinhDang
            // 
            cbDinhDang.Font = new Font("Microsoft Sans Serif", 10F);
            cbDinhDang.FormattingEnabled = true;
            cbDinhDang.Location = new Point(891, 298);
            cbDinhDang.Margin = new Padding(5);
            cbDinhDang.Name = "cbDinhDang";
            cbDinhDang.Size = new Size(395, 33);
            cbDinhDang.TabIndex = 9;
            // 
            // txtDoDai
            // 
            txtDoDai.Font = new Font("Microsoft Sans Serif", 10F);
            txtDoDai.Location = new Point(891, 248);
            txtDoDai.Margin = new Padding(5);
            txtDoDai.Name = "txtDoDai";
            txtDoDai.Size = new Size(395, 30);
            txtDoDai.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Font = new Font("Microsoft Sans Serif", 10F);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(251, 297);
            cbTrangThai.Margin = new Padding(5);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(427, 33);
            cbTrangThai.TabIndex = 8;
            // 
            // dtNgayPH
            // 
            dtNgayPH.Font = new Font("Microsoft Sans Serif", 10F);
            dtNgayPH.Location = new Point(251, 247);
            dtNgayPH.Name = "dtNgayPH";
            dtNgayPH.Size = new Size(427, 30);
            dtNgayPH.TabIndex = 6;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Font = new Font("Microsoft Sans Serif", 10F);
            txtDaoDien.Location = new Point(251, 194);
            txtDaoDien.Margin = new Padding(5);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(1035, 30);
            txtDaoDien.TabIndex = 5;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            txtHinhAnh.Location = new Point(891, 49);
            txtHinhAnh.Margin = new Padding(5);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(395, 30);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDPhim
            // 
            txtIDPhim.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDPhim.Location = new Point(251, 48);
            txtIDPhim.Margin = new Padding(5);
            txtIDPhim.Name = "txtIDPhim";
            txtIDPhim.Size = new Size(427, 30);
            txtIDPhim.TabIndex = 1;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenPhim.Location = new Point(251, 97);
            txtTenPhim.Margin = new Padding(5);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(1035, 30);
            txtTenPhim.TabIndex = 3;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Microsoft Sans Serif", 10F);
            txtTheLoai.Location = new Point(251, 144);
            txtTheLoai.Margin = new Padding(5);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(1035, 30);
            txtTheLoai.TabIndex = 4;
            // 
            // lblDinhDang
            // 
            lblDinhDang.AutoSize = true;
            lblDinhDang.Font = new Font("Microsoft Sans Serif", 10F);
            lblDinhDang.Location = new Point(758, 305);
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(101, 25);
            lblDinhDang.TabIndex = 0;
            lblDinhDang.Text = "Định dạng";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 10F);
            lblTrangThai.Location = new Point(56, 305);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 25);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Microsoft Sans Serif", 10F);
            lblMoTa.Location = new Point(56, 352);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(61, 25);
            lblMoTa.TabIndex = 0;
            lblMoTa.Text = "Mô tả";
            lblMoTa.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDoDai
            // 
            lblDoDai.AutoSize = true;
            lblDoDai.Font = new Font("Microsoft Sans Serif", 10F);
            lblDoDai.Location = new Point(734, 253);
            lblDoDai.Name = "lblDoDai";
            lblDoDai.Size = new Size(125, 25);
            lblDoDai.TabIndex = 0;
            lblDoDai.Text = "Độ dài (phút)";
            // 
            // lblNgayPH
            // 
            lblNgayPH.AutoSize = true;
            lblNgayPH.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgayPH.Location = new Point(56, 253);
            lblNgayPH.Name = "lblNgayPH";
            lblNgayPH.Size = new Size(150, 25);
            lblNgayPH.TabIndex = 0;
            lblNgayPH.Text = "Ngày phát hành";
            lblNgayPH.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            lblHinhAnh.Location = new Point(769, 54);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(90, 25);
            lblHinhAnh.TabIndex = 0;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDPhim.Location = new Point(56, 54);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(87, 25);
            lblIDPhim.TabIndex = 0;
            lblIDPhim.Text = "Mã phim";
            lblIDPhim.TextAlign = ContentAlignment.TopCenter;
            // 
            // lsvDSPhim
            // 
            lsvDSPhim.Font = new Font("Microsoft Sans Serif", 10F);
            lsvDSPhim.Location = new Point(0, 85);
            lsvDSPhim.MultiSelect = false;
            lsvDSPhim.Name = "lsvDSPhim";
            lsvDSPhim.Size = new Size(1738, 264);
            lsvDSPhim.TabIndex = 0;
            lsvDSPhim.UseCompatibleStateImageBehavior = false;
            lsvDSPhim.SelectedIndexChanged += lsvDSPhim_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(226, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1488, 30);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(31, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongDangChieu);
            groupBox5.Controls.Add(txtSoLuongPhim);
            groupBox5.Controls.Add(lblSoLuongPhim);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox5.Location = new Point(1516, 650);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(295, 132);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            // 
            // lblSoLuongDangChieu
            // 
            lblSoLuongDangChieu.AutoSize = true;
            lblSoLuongDangChieu.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongDangChieu.Location = new Point(25, 81);
            lblSoLuongDangChieu.Name = "lblSoLuongDangChieu";
            lblSoLuongDangChieu.Size = new Size(111, 25);
            lblSoLuongDangChieu.TabIndex = 0;
            lblSoLuongDangChieu.Text = "Đang chiếu";
            // 
            // txtSoLuongDangChieu
            // 
            txtSoLuongDangChieu.Enabled = false;
            txtSoLuongDangChieu.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongDangChieu.Location = new Point(181, 76);
            txtSoLuongDangChieu.Name = "txtSoLuongDangChieu";
            txtSoLuongDangChieu.ReadOnly = true;
            txtSoLuongDangChieu.Size = new Size(90, 30);
            txtSoLuongDangChieu.TabIndex = 18;
            // 
            // lblSoLuongPhim
            // 
            lblSoLuongPhim.AutoSize = true;
            lblSoLuongPhim.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongPhim.Location = new Point(25, 35);
            lblSoLuongPhim.Name = "lblSoLuongPhim";
            lblSoLuongPhim.Size = new Size(137, 25);
            lblSoLuongPhim.TabIndex = 0;
            lblSoLuongPhim.Text = "Số lượng phim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSPhim);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(73, 812);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1738, 349);
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
            panel1.Font = new Font("Microsoft Sans Serif", 10F);
            panel1.Location = new Point(1516, 199);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 429);
            panel1.TabIndex = 34;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F);
            btnThoat.Location = new Point(48, 341);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(204, 60);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Font = new Font("Microsoft Sans Serif", 10F);
            btnNhapMoi.Location = new Point(48, 183);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(204, 60);
            btnNhapMoi.TabIndex = 14;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 10F);
            btnThem.Location = new Point(48, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // bthXoa
            // 
            bthXoa.Font = new Font("Microsoft Sans Serif", 10F);
            bthXoa.Location = new Point(48, 261);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(204, 60);
            bthXoa.TabIndex = 15;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhat.Location = new Point(48, 105);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(204, 60);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // FPhim
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(panel1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1900, 1250);
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