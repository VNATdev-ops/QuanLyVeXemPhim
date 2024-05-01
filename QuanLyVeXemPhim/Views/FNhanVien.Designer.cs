namespace QuanLyVeXemPhim.Views
{
    partial class FNhanVien
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
            lsvNhanVien = new ListView();
            label9 = new Label();
            groupBox3 = new GroupBox();
            txtTongSo = new Button();
            phim = new Label();
            groupBox4 = new GroupBox();
            txtTimKiemNV = new TextBox();
            panel2 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtChucVu = new TextBox();
            txtGioiTinh = new TextBox();
            label10 = new Label();
            txtMatKhau = new TextBox();
            txtTenNhanVien = new TextBox();
            txtIDNhanVien = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(553, 26);
            label6.Name = "label6";
            label6.Size = new Size(197, 31);
            label6.TabIndex = 20;
            label6.Text = "Quản lý nhân viên";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvNhanVien);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1119, 268);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // lsvNhanVien
            // 
            lsvNhanVien.Dock = DockStyle.Fill;
            lsvNhanVien.Location = new Point(3, 27);
            lsvNhanVien.Name = "lsvNhanVien";
            lsvNhanVien.Size = new Size(1113, 238);
            lsvNhanVien.TabIndex = 0;
            lsvNhanVien.UseCompatibleStateImageBehavior = false;
            lsvNhanVien.SelectedIndexChanged += lsvNhanVien_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 44);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
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
            // txtTongSo
            // 
            txtTongSo.Location = new Point(6, 70);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(203, 40);
            txtTongSo.TabIndex = 0;
            txtTongSo.UseVisualStyleBackColor = true;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(33, 43);
            phim.Name = "phim";
            phim.Size = new Size(159, 23);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiemNV);
            groupBox4.Controls.Add(phim);
            groupBox4.Location = new Point(3, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 125);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Location = new Point(0, 79);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(215, 30);
            txtTimKiemNV.TabIndex = 16;
            txtTimKiemNV.TextChanged += txtTimKiemNV_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1137, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 17;
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
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(36, 96);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(154, 32);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(36, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 32);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(36, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
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
            panel1.Location = new Point(1137, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(56, 108);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(56, 171);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(346, 40);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(346, 108);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(txtIDNhanVien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1119, 224);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(445, 40);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(293, 31);
            txtNgaySinh.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(886, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 31);
            txtEmail.TabIndex = 15;
            txtEmail.TextChanged += textBox8_TextChanged;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(886, 97);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(213, 31);
            txtSoDienThoai.TabIndex = 14;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(886, 40);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(213, 31);
            txtChucVu.TabIndex = 13;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(445, 105);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(293, 31);
            txtGioiTinh.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(763, 168);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 7;
            label10.Text = "Email";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(180, 165);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(558, 31);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(180, 105);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(160, 31);
            txtTenNhanVien.TabIndex = 9;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(180, 37);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Size = new Size(160, 31);
            txtIDNhanVien.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(760, 45);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 6;
            label8.Text = "Chức vụ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(763, 105);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 5;
            label7.Text = "Số điện thoại";
            // 
            // FNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 590);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FNhanVien";
            Text = "FNhanVien";
            Load += FNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private ListView lsvNhanVien;
        private Label label9;
        private GroupBox groupBox3;
        private Button txtTongSo;
        private Label phim;
        private GroupBox groupBox4;
        private Panel panel2;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label10;
        private Label label8;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtChucVu;
        private TextBox txtGioiTinh;
        private TextBox txtMatKhau;
        private TextBox txtTenNhanVien;
        private TextBox txtIDNhanVien;
        private TextBox txtTimKiemNV;
        private DateTimePicker txtNgaySinh;
    }
}