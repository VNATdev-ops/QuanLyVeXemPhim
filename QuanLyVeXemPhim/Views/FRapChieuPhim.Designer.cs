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
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            txtTimKiem = new TextBox();
            phim = new Label();
            groupBox3 = new GroupBox();
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
            txtTongSo = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            panel1.Location = new Point(1164, 61);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 280);
            panel1.TabIndex = 11;
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
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1164, 349);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 339);
            panel2.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(phim);
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
            txtTimKiem.Location = new Point(22, 111);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(210, 35);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(12, 55);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(242, 30);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm rạp chiếu phim";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Controls.Add(label9);
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
            // groupBox1
            // 
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
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 61);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1120, 280);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin rạp chiếu phim";
            // 
            // txtSoLuongPhong
            // 
            txtSoLuongPhong.Location = new Point(815, 49);
            txtSoLuongPhong.Margin = new Padding(4);
            txtSoLuongPhong.Name = "txtSoLuongPhong";
            txtSoLuongPhong.Size = new Size(210, 36);
            txtSoLuongPhong.TabIndex = 9;
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(815, 122);
            txtLogo.Margin = new Padding(4);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(210, 36);
            txtLogo.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(181, 209);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(844, 36);
            txtDiaChi.TabIndex = 7;
            // 
            // txtTenRap
            // 
            txtTenRap.Location = new Point(181, 128);
            txtTenRap.Margin = new Padding(4);
            txtTenRap.Name = "txtTenRap";
            txtTenRap.Size = new Size(382, 36);
            txtTenRap.TabIndex = 6;
            // 
            // txtIDRap
            // 
            txtIDRap.Location = new Point(181, 46);
            txtIDRap.Margin = new Padding(4);
            txtIDRap.Name = "txtIDRap";
            txtIDRap.Size = new Size(382, 36);
            txtIDRap.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(728, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 4;
            label5.Text = "Logo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(621, 51);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 3;
            label4.Text = "Số lượng phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(70, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(70, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên rạp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(70, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 0;
            label1.Text = "ID Rạp";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSRap);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 352);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1120, 335);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục rạp chiếu phim";
            // 
            // lsvDSRap
            // 
            lsvDSRap.Dock = DockStyle.Fill;
            lsvDSRap.Location = new Point(4, 33);
            lsvDSRap.Margin = new Padding(4);
            lsvDSRap.Name = "lsvDSRap";
            lsvDSRap.Size = new Size(1112, 298);
            lsvDSRap.TabIndex = 0;
            lsvDSRap.UseCompatibleStateImageBehavior = false;
            lsvDSRap.SelectedIndexChanged += lsvDSRap_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(359, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(307, 38);
            label6.TabIndex = 15;
            label6.Text = "Quản lý rạp chiếu phim";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(22, 89);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(210, 35);
            txtTongSo.TabIndex = 10;
            txtTongSo.TextChanged += txtTimKiem_TextChanged;
            // 
            // FRapChieuPhim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 729);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "FRapChieuPhim";
            Text = "FRapChieuPhim";
            Load += FRapChieuPhim_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
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
    }
}