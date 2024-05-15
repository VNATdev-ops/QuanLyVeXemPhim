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
            panel2.Font = new Font("Roboto", 10F);
            panel2.Location = new Point(1341, 599);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 325);
            panel2.TabIndex = 16;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phim);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Font = new Font("Roboto", 10F);
            groupBox4.Location = new Point(4, 172);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(262, 150);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Font = new Font("Roboto", 10F);
            phim.Location = new Point(29, 46);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(207, 24);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm phòng chiếu";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Roboto", 10F);
            txtTimKiem.Location = new Point(29, 89);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(207, 32);
            txtTimKiem.TabIndex = 20;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Font = new Font("Roboto", 10F);
            groupBox3.Location = new Point(4, 4);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(262, 150);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 10F);
            label9.Location = new Point(88, 42);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 24);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // txtTongSo
            // 
            txtTongSo.Font = new Font("Roboto", 10F);
            txtTongSo.Location = new Point(29, 84);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(207, 32);
            txtTongSo.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 87);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Roboto", 10F);
            panel1.Location = new Point(1341, 142);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 412);
            panel1.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Roboto", 10F);
            btnThoat.Location = new Point(44, 327);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(187, 58);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Roboto", 10F);
            btnCapNhat.Location = new Point(44, 101);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(187, 58);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Font = new Font("Roboto", 10F);
            btnNhapMoi.Location = new Point(44, 176);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(187, 58);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Roboto", 10F);
            btnXoa.Location = new Point(44, 251);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(187, 58);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Roboto", 10F);
            btnThem.Location = new Point(44, 30);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(187, 58);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
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
            groupBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(74, 142);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1187, 246);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng chiếu";
            // 
            // txtTenPhong
            // 
            txtTenPhong.Font = new Font("Roboto", 10F);
            txtTenPhong.Location = new Point(208, 107);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(373, 32);
            txtTenPhong.TabIndex = 20;
            // 
            // txtSoLuongGhe
            // 
            txtSoLuongGhe.Font = new Font("Roboto", 10F);
            txtSoLuongGhe.Location = new Point(208, 164);
            txtSoLuongGhe.Name = "txtSoLuongGhe";
            txtSoLuongGhe.Size = new Size(373, 32);
            txtSoLuongGhe.TabIndex = 20;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Font = new Font("Roboto", 10F);
            txtLoaiPhong.Location = new Point(772, 107);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(373, 32);
            txtLoaiPhong.TabIndex = 20;
            // 
            // txtIDphong
            // 
            txtIDphong.Font = new Font("Roboto", 10F);
            txtIDphong.Location = new Point(208, 51);
            txtIDphong.Name = "txtIDphong";
            txtIDphong.Size = new Size(373, 32);
            txtIDphong.TabIndex = 20;
            // 
            // txtIDrap
            // 
            txtIDrap.Font = new Font("Roboto", 10F);
            txtIDrap.Location = new Point(772, 50);
            txtIDrap.Name = "txtIDrap";
            txtIDrap.Size = new Size(373, 32);
            txtIDrap.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10F);
            label5.Location = new Point(46, 172);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 4;
            label5.Text = "Số lượng ghế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10F);
            label4.Location = new Point(640, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 3;
            label4.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10F);
            label3.Location = new Point(46, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 2;
            label3.Text = "Tên phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10F);
            label2.Location = new Point(640, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 1;
            label2.Text = "ID Rạp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10F);
            label1.Location = new Point(46, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 0;
            label1.Text = "ID Phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSachPC);
            groupBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(74, 443);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1187, 481);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng chiếu";
            // 
            // lsvDanhSachPC
            // 
            lsvDanhSachPC.Dock = DockStyle.Fill;
            lsvDanhSachPC.Font = new Font("Roboto", 10F);
            lsvDanhSachPC.Location = new Point(4, 33);
            lsvDanhSachPC.Margin = new Padding(4);
            lsvDanhSachPC.Name = "lsvDanhSachPC";
            lsvDanhSachPC.Size = new Size(1179, 444);
            lsvDanhSachPC.TabIndex = 0;
            lsvDanhSachPC.UseCompatibleStateImageBehavior = false;
            lsvDanhSachPC.SelectedIndexChanged += lsvDanhSach_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 24F);
            label6.Location = new Point(74, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(538, 58);
            label6.TabIndex = 19;
            label6.Text = "QUẢN LÝ PHÒNG CHIẾU";
            // 
            // FPhongChieu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1678, 1144);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
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