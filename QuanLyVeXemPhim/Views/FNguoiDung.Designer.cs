﻿namespace QuanLyVeXemPhim.Views
{
    partial class FNguoiDung
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtIDNguoiDung = new Button();
            this.txtTen = new Button();
            this.txtMatKhau = new Button();
            this.txtNgaySinh = new Button();
            this.txtGioiTinh = new Button();
            this.txtKhuVuc = new Button();
            this.txtEmail = new Button();
            this.txtLoaiTaiKhoan = new Button();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lsvNguoiDung = new ListView();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            phim = new Label();
            txtTimKiem = new Button();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtTongSo = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.txtLoaiTaiKhoan);
            groupBox1.Controls.Add(this.txtEmail);
            groupBox1.Controls.Add(this.txtKhuVuc);
            groupBox1.Controls.Add(this.txtGioiTinh);
            groupBox1.Controls.Add(this.txtNgaySinh);
            groupBox1.Controls.Add(this.txtMatKhau);
            groupBox1.Controls.Add(this.txtTen);
            groupBox1.Controls.Add(txtIDNguoiDung);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Người Dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 188);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 44);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 92);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 5;
            label6.Text = "Khu vực";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 140);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(494, 188);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 7;
            label8.Text = "Loại tài khoản";
            // 
            // txtIDNguoiDung
            // 
            txtIDNguoiDung.Location = new Point(205, 38);
            txtIDNguoiDung.Name = "txtIDNguoiDung";
            txtIDNguoiDung.Size = new Size(256, 40);
            txtIDNguoiDung.TabIndex = 8;
            txtIDNguoiDung.UseVisualStyleBackColor = true;
            txtIDNguoiDung.Click += button1_Click;
            // 
            // txtTen
            // 
            this.txtTen.Location = new Point(205, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new Size(256, 40);
            this.txtTen.TabIndex = 9;
            this.txtTen.UseVisualStyleBackColor = true;
            this.txtTen.Click += this.button2_Click;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new Point(205, 134);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new Size(256, 40);
            this.txtMatKhau.TabIndex = 10;
            this.txtMatKhau.UseVisualStyleBackColor = true;
            this.txtMatKhau.Click += this.button3_Click;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new Point(205, 182);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new Size(256, 40);
            this.txtNgaySinh.TabIndex = 11;
            this.txtNgaySinh.UseVisualStyleBackColor = true;
            this.txtNgaySinh.Click += this.button4_Click;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new Point(647, 38);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new Size(256, 40);
            this.txtGioiTinh.TabIndex = 12;
            this.txtGioiTinh.UseVisualStyleBackColor = true;
            this.txtGioiTinh.Click += this.button5_Click;
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new Point(647, 86);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new Size(256, 40);
            this.txtKhuVuc.TabIndex = 13;
            this.txtKhuVuc.UseVisualStyleBackColor = true;
            this.txtKhuVuc.Click += this.button6_Click;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(647, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(256, 40);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.UseVisualStyleBackColor = true;
            this.txtEmail.Click += this.button7_Click;
            // 
            // txtLoaiTaiKhoan
            // 
            this.txtLoaiTaiKhoan.Location = new Point(647, 180);
            this.txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            this.txtLoaiTaiKhoan.Size = new Size(256, 40);
            this.txtLoaiTaiKhoan.TabIndex = 15;
            this.txtLoaiTaiKhoan.UseVisualStyleBackColor = true;
            this.txtLoaiTaiKhoan.Click += this.button8_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1007, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(36, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(36, 134);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(154, 32);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(36, 96);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(154, 32);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(36, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 32);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(36, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvNguoiDung);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(959, 243);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách người dùng";
            // 
            // lsvNguoiDung
            // 
            lsvNguoiDung.Dock = DockStyle.Fill;
            lsvNguoiDung.Location = new Point(3, 30);
            lsvNguoiDung.Name = "lsvNguoiDung";
            lsvNguoiDung.Size = new Size(953, 210);
            lsvNguoiDung.TabIndex = 0;
            lsvNguoiDung.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1007, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phim);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Location = new Point(3, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 125);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(24, 44);
            phim.Name = "phim";
            phim.Size = new Size(173, 23);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm người dùng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 70);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(203, 40);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 44);
            label9.Name = "label9";
            label9.Size = new Size(165, 23);
            label9.TabIndex = 1;
            label9.Text = "Tổng số người dùng";
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(6, 70);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(203, 40);
            txtTongSo.TabIndex = 0;
            txtTongSo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(431, 20);
            label10.Name = "label10";
            label10.Size = new Size(219, 31);
            label10.TabIndex = 8;
            label10.Text = "Quản lý người dùng";
            // 
            // FNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 585);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FNguoiDung";
            Text = "FNguoiDung";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button txtIDNguoiDung;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private ListView lsvNguoiDung;
        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private Button txtTimKiem;
        private GroupBox groupBox3;
        private Label label9;
        private Button txtTongSo;
        private Label label10;
    }
}