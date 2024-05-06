namespace QuanLyVeXemPhim.Views
{
    partial class FPhongChieu
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
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            phim = new Label();
            txtTimKiem = new TextBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtTongSo = new TextBox();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            txtTenPhong = new TextBox();
            txtSoLuongGhe = new TextBox();
            txtLoaiPhong = new TextBox();
            txtIDphong = new TextBox();
            txtIDrap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDanhSachPC = new ListView();
            label6 = new Label();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1168, 384);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 339);
            panel2.TabIndex = 16;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phim);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Location = new Point(4, 179);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(269, 156);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(26, 41);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(219, 30);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm phòng chiếu";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(24, 85);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(221, 35);
            txtTimKiem.TabIndex = 20;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
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
            txtTongSo.Location = new Point(24, 99);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(221, 35);
            txtTongSo.TabIndex = 20;
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
            panel1.Location = new Point(1168, 96);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 280);
            panel1.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(45, 215);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(192, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(45, 168);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(192, 40);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(45, 120);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(192, 40);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(45, 72);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(192, 40);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenPhong);
            groupBox1.Controls.Add(txtSoLuongGhe);
            groupBox1.Controls.Add(txtLoaiPhong);
            groupBox1.Controls.Add(txtIDphong);
            groupBox1.Controls.Add(txtIDrap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 96);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1145, 280);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng chiếu";
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(159, 209);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(349, 36);
            txtTenPhong.TabIndex = 20;
            // 
            // txtSoLuongGhe
            // 
            txtSoLuongGhe.Location = new Point(701, 215);
            txtSoLuongGhe.Name = "txtSoLuongGhe";
            txtSoLuongGhe.Size = new Size(349, 36);
            txtSoLuongGhe.TabIndex = 20;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Location = new Point(701, 130);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(349, 36);
            txtLoaiPhong.TabIndex = 20;
            // 
            // txtIDphong
            // 
            txtIDphong.Location = new Point(159, 133);
            txtIDphong.Name = "txtIDphong";
            txtIDphong.Size = new Size(349, 36);
            txtIDphong.TabIndex = 20;
            // 
            // txtIDrap
            // 
            txtIDrap.Location = new Point(159, 51);
            txtIDrap.Name = "txtIDrap";
            txtIDrap.Size = new Size(390, 36);
            txtIDrap.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 220);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 30);
            label5.TabIndex = 4;
            label5.Text = "Số lượng ghế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 136);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 30);
            label4.TabIndex = 3;
            label4.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 2;
            label3.Text = "Tên phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 1;
            label2.Text = "ID Rạp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 0;
            label1.Text = "ID phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSachPC);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 384);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1145, 339);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng chiếu";
            // 
            // lsvDanhSachPC
            // 
            lsvDanhSachPC.Dock = DockStyle.Fill;
            lsvDanhSachPC.Location = new Point(4, 33);
            lsvDanhSachPC.Margin = new Padding(4);
            lsvDanhSachPC.Name = "lsvDanhSachPC";
            lsvDanhSachPC.Size = new Size(1137, 302);
            lsvDanhSachPC.TabIndex = 0;
            lsvDanhSachPC.UseCompatibleStateImageBehavior = false;
            lsvDanhSachPC.SelectedIndexChanged += lsvDanhSach_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(548, 46);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(239, 32);
            label6.TabIndex = 19;
            label6.Text = "Quản lý phòng chiếu";
            // 
            // FPhongChieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 740);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "FPhongChieu";
            Text = "FPhongChieu";
            Load += FPhongChieu_Load;
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private GroupBox groupBox3;
        private Label label9;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lsvDanhSachPC;
        private Label label6;
        private TextBox txtIDrap;
        private TextBox txtIDphong;
        private TextBox txtTenPhong;
        private TextBox txtSoLuongGhe;
        private TextBox txtLoaiPhong;
        private TextBox txtTimKiem;
        private TextBox txtTongSo;
    }
}