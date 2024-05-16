namespace QuanLyVeXemPhim.Views
{
    partial class FRapChieuPhim
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
            txtTimKiem = new TextBox();
            phim = new Label();
            groupBox3 = new GroupBox();
            txtTongSo = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtSoLuongPhong = new TextBox();
            txtLogo = new TextBox();
            txtDiaChi = new TextBox();
            txtTenRap = new TextBox();
            txtIDRap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDSRap = new ListView();
            label6 = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Roboto", 10F);
            panel2.Location = new Point(1341, 595);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 325);
            panel2.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(phim);
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
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Roboto", 10F);
            txtTimKiem.Location = new Point(18, 92);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(231, 32);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Font = new Font("Roboto", 10F);
            phim.Location = new Point(18, 49);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(231, 24);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm rạp chiếu phim";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Controls.Add(label9);
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
            // txtTongSo
            // 
            txtTongSo.Font = new Font("Roboto", 10F);
            txtTongSo.Location = new Point(23, 85);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(220, 32);
            txtTongSo.TabIndex = 10;
            txtTongSo.TextChanged += txtTimKiem_TextChanged;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
            groupBox1.Controls.Add(txtSoLuongPhong);
            groupBox1.Controls.Add(txtLogo);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenRap);
            groupBox1.Controls.Add(txtIDRap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Roboto", 12F);
            groupBox1.Location = new Point(74, 142);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1187, 246);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin rạp chiếu phim";
            // 
            // txtSoLuongPhong
            // 
            txtSoLuongPhong.Font = new Font("Roboto", 10F);
            txtSoLuongPhong.Location = new Point(896, 47);
            txtSoLuongPhong.Margin = new Padding(4);
            txtSoLuongPhong.Name = "txtSoLuongPhong";
            txtSoLuongPhong.Size = new Size(231, 32);
            txtSoLuongPhong.TabIndex = 9;
            // 
            // txtLogo
            // 
            txtLogo.Font = new Font("Roboto", 10F);
            txtLogo.Location = new Point(896, 102);
            txtLogo.Margin = new Padding(4);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(231, 32);
            txtLogo.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Roboto", 10F);
            txtDiaChi.Location = new Point(199, 161);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(928, 32);
            txtDiaChi.TabIndex = 7;
            // 
            // txtTenRap
            // 
            txtTenRap.Font = new Font("Roboto", 10F);
            txtTenRap.Location = new Point(199, 102);
            txtTenRap.Margin = new Padding(4);
            txtTenRap.Name = "txtTenRap";
            txtTenRap.Size = new Size(420, 32);
            txtTenRap.TabIndex = 6;
            // 
            // txtIDRap
            // 
            txtIDRap.Font = new Font("Roboto", 10F);
            txtIDRap.Location = new Point(199, 46);
            txtIDRap.Margin = new Padding(4);
            txtIDRap.Name = "txtIDRap";
            txtIDRap.Size = new Size(420, 32);
            txtIDRap.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10F);
            label5.Location = new Point(795, 105);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 4;
            label5.Text = "Logo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10F);
            label4.Location = new Point(701, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 3;
            label4.Text = "Số lượng phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10F);
            label3.Location = new Point(77, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10F);
            label2.Location = new Point(77, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "Tên rạp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10F);
            label1.Location = new Point(77, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "ID Rạp";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSRap);
            groupBox2.Font = new Font("Roboto", 12F);
            groupBox2.Location = new Point(74, 443);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1187, 481);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục rạp chiếu phim";
            // 
            // lsvDSRap
            // 
            lsvDSRap.Dock = DockStyle.Fill;
            lsvDSRap.Font = new Font("Roboto", 10F);
            lsvDSRap.Location = new Point(4, 33);
            lsvDSRap.Margin = new Padding(4);
            lsvDSRap.Name = "lsvDSRap";
            lsvDSRap.Size = new Size(1179, 444);
            lsvDSRap.TabIndex = 0;
            lsvDSRap.UseCompatibleStateImageBehavior = false;
            lsvDSRap.SelectedIndexChanged += lsvDSRap_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 24F);
            label6.Location = new Point(74, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(596, 58);
            label6.TabIndex = 15;
            label6.Text = "QUẢN LÝ RẠP CHIẾU PHIM";
            label6.TextAlign = ContentAlignment.TopRight;
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
            panel1.TabIndex = 16;
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
            // FRapChieuPhim
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1678, 1144);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FRapChieuPhim";
            Text = "FRapChieuPhim";
            Load += FRapChieuPhim_Load;
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private GroupBox groupBox3;
        private Label label9;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView lsvDSRap;
        private Label label6;
        private TextBox txtSoLuongPhong;
        private TextBox txtLogo;
        private TextBox txtDiaChi;
        private TextBox txtTenRap;
        private TextBox txtIDRap;
        private TextBox txtTimKiem;
        private TextBox txtTongSo;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
    }
}