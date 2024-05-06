namespace QuanLyVeXemPhim.Views
{
    partial class FSuatChieu
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
            label6 = new Label();
            groupBox2 = new GroupBox();
            lsvSuatChieu = new ListView();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            dtThoiGianChieu = new DateTimePicker();
            cmbTrangThai = new ComboBox();
            cmbPhong = new ComboBox();
            cmbRap = new ComboBox();
            cmbPhim = new ComboBox();
            txtSoLuongConLai = new TextBox();
            lblTrangThai = new Label();
            lblSoLuongConLai = new Label();
            lblIDPhong = new Label();
            txtSoLuongVe = new TextBox();
            txtIDSuatChieu = new TextBox();
            lblIDRap = new Label();
            lblSoLuongVe = new Label();
            lblThoiGianChieu = new Label();
            lblIDPhim = new Label();
            lblIDSuatChieu = new Label();
            groupBox3 = new GroupBox();
            txtTongSo = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            txtTimKiem = new TextBox();
            phim = new Label();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(455, 49);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(213, 32);
            label6.TabIndex = 15;
            label6.Text = "Quản lý suất chiếu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvSuatChieu);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(63, 506);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1205, 419);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách suất chiếu";
            // 
            // lsvSuatChieu
            // 
            lsvSuatChieu.Location = new Point(46, 57);
            lsvSuatChieu.Name = "lsvSuatChieu";
            lsvSuatChieu.Size = new Size(1101, 321);
            lsvSuatChieu.TabIndex = 0;
            lsvSuatChieu.UseCompatibleStateImageBehavior = false;
            lsvSuatChieu.SelectedIndexChanged += lsvSuatChieu_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1387, 136);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 395);
            panel1.TabIndex = 12;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(52, 312);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 50);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(52, 175);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(180, 50);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(52, 242);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(180, 50);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(52, 103);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(180, 50);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(52, 31);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(180, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtThoiGianChieu);
            groupBox1.Controls.Add(cmbTrangThai);
            groupBox1.Controls.Add(cmbPhong);
            groupBox1.Controls.Add(cmbRap);
            groupBox1.Controls.Add(cmbPhim);
            groupBox1.Controls.Add(txtSoLuongConLai);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(lblSoLuongConLai);
            groupBox1.Controls.Add(lblIDPhong);
            groupBox1.Controls.Add(txtSoLuongVe);
            groupBox1.Controls.Add(txtIDSuatChieu);
            groupBox1.Controls.Add(lblIDRap);
            groupBox1.Controls.Add(lblSoLuongVe);
            groupBox1.Controls.Add(lblThoiGianChieu);
            groupBox1.Controls.Add(lblIDPhim);
            groupBox1.Controls.Add(lblIDSuatChieu);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(50, 128);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1218, 327);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin suất chiếu";
            // 
            // dtThoiGianChieu
            // 
            dtThoiGianChieu.CustomFormat = "HH:mm dd/MM/yyyy";
            dtThoiGianChieu.Location = new Point(854, 56);
            dtThoiGianChieu.Name = "dtThoiGianChieu";
            dtThoiGianChieu.Size = new Size(300, 36);
            dtThoiGianChieu.TabIndex = 17;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Location = new Point(854, 253);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(306, 38);
            cmbTrangThai.TabIndex = 16;
            // 
            // cmbPhong
            // 
            cmbPhong.FormattingEnabled = true;
            cmbPhong.Location = new Point(246, 253);
            cmbPhong.Name = "cmbPhong";
            cmbPhong.Size = new Size(306, 38);
            cmbPhong.TabIndex = 16;
            // 
            // cmbRap
            // 
            cmbRap.FormattingEnabled = true;
            cmbRap.Location = new Point(246, 183);
            cmbRap.Name = "cmbRap";
            cmbRap.Size = new Size(306, 38);
            cmbRap.TabIndex = 16;
            // 
            // cmbPhim
            // 
            cmbPhim.FormattingEnabled = true;
            cmbPhim.Location = new Point(246, 117);
            cmbPhim.Name = "cmbPhim";
            cmbPhim.Size = new Size(306, 38);
            cmbPhim.TabIndex = 16;
            // 
            // txtSoLuongConLai
            // 
            txtSoLuongConLai.Location = new Point(854, 188);
            txtSoLuongConLai.Margin = new Padding(4);
            txtSoLuongConLai.Name = "txtSoLuongConLai";
            txtSoLuongConLai.Size = new Size(306, 36);
            txtSoLuongConLai.TabIndex = 14;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(648, 250);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(108, 30);
            lblTrangThai.TabIndex = 13;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblSoLuongConLai
            // 
            lblSoLuongConLai.AutoSize = true;
            lblSoLuongConLai.Location = new Point(648, 188);
            lblSoLuongConLai.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongConLai.Name = "lblSoLuongConLai";
            lblSoLuongConLai.Size = new Size(168, 30);
            lblSoLuongConLai.TabIndex = 12;
            lblSoLuongConLai.Text = "Số lượng còn lại";
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Location = new Point(59, 256);
            lblIDPhong.Margin = new Padding(4, 0, 4, 0);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(75, 30);
            lblIDPhong.TabIndex = 10;
            lblIDPhong.Text = "Phòng";
            // 
            // txtSoLuongVe
            // 
            txtSoLuongVe.Location = new Point(854, 122);
            txtSoLuongVe.Margin = new Padding(4);
            txtSoLuongVe.Name = "txtSoLuongVe";
            txtSoLuongVe.Size = new Size(306, 36);
            txtSoLuongVe.TabIndex = 7;
            // 
            // txtIDSuatChieu
            // 
            txtIDSuatChieu.Location = new Point(246, 59);
            txtIDSuatChieu.Margin = new Padding(4);
            txtIDSuatChieu.Name = "txtIDSuatChieu";
            txtIDSuatChieu.Size = new Size(306, 36);
            txtIDSuatChieu.TabIndex = 5;
            // 
            // lblIDRap
            // 
            lblIDRap.AutoSize = true;
            lblIDRap.Location = new Point(59, 191);
            lblIDRap.Margin = new Padding(4, 0, 4, 0);
            lblIDRap.Name = "lblIDRap";
            lblIDRap.Size = new Size(50, 30);
            lblIDRap.TabIndex = 1;
            lblIDRap.Text = "Rạp";
            // 
            // lblSoLuongVe
            // 
            lblSoLuongVe.AutoSize = true;
            lblSoLuongVe.Location = new Point(648, 122);
            lblSoLuongVe.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongVe.Name = "lblSoLuongVe";
            lblSoLuongVe.Size = new Size(135, 30);
            lblSoLuongVe.TabIndex = 4;
            lblSoLuongVe.Text = "Số lượng vé ";
            // 
            // lblThoiGianChieu
            // 
            lblThoiGianChieu.AutoSize = true;
            lblThoiGianChieu.Location = new Point(648, 59);
            lblThoiGianChieu.Margin = new Padding(4, 0, 4, 0);
            lblThoiGianChieu.Name = "lblThoiGianChieu";
            lblThoiGianChieu.Size = new Size(159, 30);
            lblThoiGianChieu.TabIndex = 3;
            lblThoiGianChieu.Text = "Thời gian chiếu";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Location = new Point(59, 125);
            lblIDPhim.Margin = new Padding(4, 0, 4, 0);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(61, 30);
            lblIDPhim.TabIndex = 2;
            lblIDPhim.Text = "Phim";
            // 
            // lblIDSuatChieu
            // 
            lblIDSuatChieu.AutoSize = true;
            lblIDSuatChieu.Location = new Point(59, 62);
            lblIDSuatChieu.Margin = new Padding(4, 0, 4, 0);
            lblIDSuatChieu.Name = "lblIDSuatChieu";
            lblIDSuatChieu.Size = new Size(139, 30);
            lblIDSuatChieu.TabIndex = 0;
            lblIDSuatChieu.Text = "ID Suất chiếu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(1387, 740);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(269, 156);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(39, 89);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(193, 31);
            txtTongSo.TabIndex = 10;
            txtTongSo.TextChanged += txtTimKiem_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 50);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(phim);
            groupBox4.Location = new Point(1387, 576);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(269, 156);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(39, 97);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 31);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(62, 48);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(139, 25);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm lịch sử";
            // 
            // FSuatChieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1144);
            Controls.Add(groupBox4);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "FSuatChieu";
            Text = "FSuatChieu";
            Load += FSuatChieu_Load;
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtSoLuongVe;
        private TextBox txtIDSuatChieu;
        private Label lblIDRap;
        private Label lblSoLuongVe;
        private Label lblThoiGianChieu;
        private Label lblIDPhim;
        private Label lblIDSuatChieu;
        private TextBox txtSoLuongConLai;
        private Label lblTrangThai;
        private Label lblSoLuongConLai;
        private Label lblIDPhong;
        private GroupBox groupBox3;
        private Label label9;
        private GroupBox groupBox4;
        private TextBox txtTimKiem;
        private ListView lsvSuatChieu;
        private ComboBox cmbPhim;
        private ComboBox cmbPhong;
        private ComboBox cmbRap;
        private ComboBox cmbTrangThai;
        private DateTimePicker dtThoiGianChieu;
        private Label phim;
        private TextBox txtTongSo;
    }
}