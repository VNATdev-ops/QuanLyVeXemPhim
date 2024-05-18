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
            txtTongSo = new TextBox();
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
            panel3 = new Panel();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label6.Location = new Point(73, 74);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(527, 55);
            label6.TabIndex = 20;
            label6.Text = "QUẢN LÝ NHÂN VIÊN";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvNhanVien);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(73, 681);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1331, 462);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // lsvNhanVien
            // 
            lsvNhanVien.Dock = DockStyle.Fill;
            lsvNhanVien.Font = new Font("Microsoft Sans Serif", 10F);
            lsvNhanVien.Location = new Point(4, 32);
            lsvNhanVien.Margin = new Padding(4);
            lsvNhanVien.Name = "lsvNhanVien";
            lsvNhanVien.Size = new Size(1323, 426);
            lsvNhanVien.TabIndex = 0;
            lsvNhanVien.UseCompatibleStateImageBehavior = false;
            lsvNhanVien.SelectedIndexChanged += lsvNhanVien_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.Location = new Point(104, 51);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.Location = new Point(4, 4);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(286, 156);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // txtTongSo
            // 
            txtTongSo.Font = new Font("Microsoft Sans Serif", 10F);
            txtTongSo.Location = new Point(44, 90);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.ReadOnly = true;
            txtTongSo.Size = new Size(200, 30);
            txtTongSo.TabIndex = 16;
            txtTongSo.TextChanged += txtTimKiemNV_TextChanged;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Font = new Font("Microsoft Sans Serif", 10F);
            phim.Location = new Point(53, 58);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(181, 25);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiemNV);
            groupBox4.Controls.Add(phim);
            groupBox4.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox4.Location = new Point(4, 179);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(286, 156);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiemNV.Location = new Point(22, 99);
            txtTimKiemNV.Margin = new Padding(4);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(246, 30);
            txtTimKiemNV.TabIndex = 16;
            txtTimKiemNV.TextChanged += txtTimKiemNV_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Roboto", 10F);
            panel2.Location = new Point(49, 675);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 339);
            panel2.TabIndex = 17;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F);
            btnThoat.Location = new Point(48, 341);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(204, 60);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhat.Location = new Point(48, 105);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(204, 60);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Font = new Font("Microsoft Sans Serif", 10F);
            btnNhapMoi.Location = new Point(48, 183);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(204, 60);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoa.Location = new Point(48, 261);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 10F);
            btnThem.Location = new Point(48, 31);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 87);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(49, 199);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 429);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(73, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(73, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(73, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(73, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(771, 59);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(73, 199);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1331, 429);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Font = new Font("Microsoft Sans Serif", 10F);
            txtNgaySinh.Location = new Point(250, 150);
            txtNgaySinh.Margin = new Padding(4);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(1023, 30);
            txtNgaySinh.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10F);
            txtEmail.Location = new Point(250, 355);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1023, 30);
            txtEmail.TabIndex = 15;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoDienThoai.Location = new Point(250, 301);
            txtSoDienThoai.Margin = new Padding(4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(1023, 30);
            txtSoDienThoai.TabIndex = 14;
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new Font("Microsoft Sans Serif", 10F);
            txtChucVu.Location = new Point(250, 200);
            txtChucVu.Margin = new Padding(4);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(1023, 30);
            txtChucVu.TabIndex = 13;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Font = new Font("Microsoft Sans Serif", 10F);
            txtGioiTinh.Location = new Point(895, 51);
            txtGioiTinh.Margin = new Padding(4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(378, 30);
            txtGioiTinh.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F);
            label10.Location = new Point(73, 361);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 7;
            label10.Text = "Email";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 10F);
            txtMatKhau.Location = new Point(250, 250);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(1023, 30);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenNhanVien.Location = new Point(250, 101);
            txtTenNhanVien.Margin = new Padding(4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(1023, 30);
            txtTenNhanVien.TabIndex = 9;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDNhanVien.Location = new Point(250, 51);
            txtIDNhanVien.Margin = new Padding(4);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Size = new Size(448, 30);
            txtIDNhanVien.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.Location = new Point(73, 206);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 6;
            label8.Text = "Chức vụ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.Location = new Point(73, 307);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 5;
            label7.Text = "Số điện thoại";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1454, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 1194);
            panel3.TabIndex = 21;
            // 
            // FNhanVien
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1900, 1250);
            Name = "FNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
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
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private ListView lsvNhanVien;
        private Label label9;
        private GroupBox groupBox3;
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
        private TextBox txtTongSo;
        private Panel panel3;
    }
}