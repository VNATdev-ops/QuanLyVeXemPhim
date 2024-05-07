namespace QuanLyVeXemPhim.Views
{
    partial class FThanhVien
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
            label8 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnNhapMoi = new Button();
            btnCapNhat = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtTongSo = new Button();
            groupBox4 = new GroupBox();
            txtTimKiem = new TextBox();
            lblTim = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtKhuVuc = new TextBox();
            txtGioiTinh = new TextBox();
            txtMatKhau = new TextBox();
            txtTenThanhVien = new TextBox();
            txtIDThanhVien = new TextBox();
            txtNgaySinh = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDanhSachTV = new ListView();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(578, 32);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(212, 32);
            label8.TabIndex = 14;
            label8.Text = "Quản lí thành viên";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(45, 25);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(192, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(45, 85);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(192, 40);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(45, 150);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(192, 40);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(45, 211);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(192, 40);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(45, 274);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(192, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1329, 71);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 334);
            panel1.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Location = new Point(4, 4);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(269, 156);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 55);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 30);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(8, 88);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(254, 50);
            txtTongSo.TabIndex = 0;
            txtTongSo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(lblTim);
            groupBox4.Location = new Point(4, 179);
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
            txtTimKiem.Location = new Point(8, 111);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(253, 35);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(41, 68);
            lblTim.Margin = new Padding(4, 0, 4, 0);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(201, 30);
            lblTim.TabIndex = 2;
            lblTim.Text = "Tìm kiếm thành viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1329, 450);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 339);
            panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtKhuVuc);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenThanhVien);
            groupBox1.Controls.Add(txtIDThanhVien);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 71);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1302, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thành viên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(742, 276);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(465, 39);
            txtEmail.TabIndex = 20;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKhuVuc
            // 
            txtKhuVuc.Location = new Point(742, 204);
            txtKhuVuc.Margin = new Padding(4);
            txtKhuVuc.Name = "txtKhuVuc";
            txtKhuVuc.Size = new Size(465, 39);
            txtKhuVuc.TabIndex = 19;
            txtKhuVuc.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(742, 44);
            txtGioiTinh.Margin = new Padding(4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(465, 39);
            txtGioiTinh.TabIndex = 18;
            txtGioiTinh.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(164, 204);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(465, 39);
            txtMatKhau.TabIndex = 17;
            txtMatKhau.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTenThanhVien
            // 
            txtTenThanhVien.Location = new Point(168, 115);
            txtTenThanhVien.Margin = new Padding(4);
            txtTenThanhVien.Name = "txtTenThanhVien";
            txtTenThanhVien.Size = new Size(1040, 39);
            txtTenThanhVien.TabIndex = 16;
            txtTenThanhVien.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIDThanhVien
            // 
            txtIDThanhVien.Location = new Point(168, 44);
            txtIDThanhVien.Margin = new Padding(4);
            txtIDThanhVien.Name = "txtIDThanhVien";
            txtIDThanhVien.Size = new Size(465, 39);
            txtIDThanhVien.TabIndex = 15;
            txtIDThanhVien.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(164, 278);
            txtNgaySinh.Margin = new Padding(4);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(469, 39);
            txtNgaySinh.TabIndex = 14;
            txtNgaySinh.ValueChanged += txtNgaySinh_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(641, 292);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 30);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(641, 218);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 30);
            label6.TabIndex = 5;
            label6.Text = "Khu vực";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(641, 58);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(52, 290);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(54, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(8, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên thành viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Mã thành viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSachTV);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 450);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1302, 345);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thành viên";
            // 
            // lsvDanhSachTV
            // 
            lsvDanhSachTV.Dock = DockStyle.Fill;
            lsvDanhSachTV.Location = new Point(4, 36);
            lsvDanhSachTV.Margin = new Padding(4);
            lsvDanhSachTV.Name = "lsvDanhSachTV";
            lsvDanhSachTV.Size = new Size(1294, 305);
            lsvDanhSachTV.TabIndex = 0;
            lsvDanhSachTV.UseCompatibleStateImageBehavior = false;
            lsvDanhSachTV.SelectedIndexChanged += lsvDanhSachTV_SelectedIndexChanged;
            // 
            // FThanhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 814);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "FThanhVien";
            Text = "FThanhVien";
            Load += FThanhVien_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btnThem;
        private Button btnXoa;
        private Button btnNhapMoi;
        private Button btnCapNhat;
        private Button btnThoat;
        private Panel panel1;
        private GroupBox groupBox3;
        private Label label9;
        private Button txtTongSo;
        private GroupBox groupBox4;
        private TextBox txtTimKiem;
        private Label lblTim;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtKhuVuc;
        private TextBox txtGioiTinh;
        private TextBox txtMatKhau;
        private TextBox txtTenThanhVien;
        private TextBox txtIDThanhVien;
        private DateTimePicker txtNgaySinh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView lsvDanhSachTV;
    }
}