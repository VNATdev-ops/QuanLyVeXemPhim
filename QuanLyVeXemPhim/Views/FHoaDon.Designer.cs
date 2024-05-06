namespace QuanLyVeXemPhim.Views
{
    partial class FHoaDon
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
            label10 = new Label();
            groupBox5 = new GroupBox();
            txtIDNhanVien = new TextBox();
            btnThoat = new Button();
            btnTaoHD = new Button();
            btnXoaHD = new Button();
            btnLuuHD = new Button();
            groupBox4 = new GroupBox();
            lsvChiTietHD = new ListView();
            label9 = new Label();
            lstSanPham = new ListBox();
            txtSoLuong = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            btnThemSP = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnCapNhatSoLuong = new Button();
            label7 = new Label();
            dTimeNgayHD = new DateTimePicker();
            cbTheThanhVien = new ComboBox();
            txtTriGiaHD = new TextBox();
            txtSoHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtNVXuatHD = new TextBox();
            lblNVXuatHD = new Label();
            lblTenForm = new Label();
            btnXoaCTHD = new Button();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            lsvDanhSachHD = new ListView();
            txtSoLuongHD = new TextBox();
            lblSoLuongHD = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(66, 47);
            label10.Name = "label10";
            label10.Size = new Size(118, 25);
            label10.TabIndex = 4;
            label10.Text = "Mã nhân viên";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtIDNhanVien);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(1468, 635);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(242, 159);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(28, 89);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Size = new Size(194, 31);
            txtIDNhanVien.TabIndex = 13;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(28, 325);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(194, 74);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new Point(28, 228);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(194, 74);
            btnTaoHD.TabIndex = 15;
            btnTaoHD.Text = "Tạo hóa đơn mới";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // btnXoaHD
            // 
            btnXoaHD.Location = new Point(28, 133);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(194, 74);
            btnXoaHD.TabIndex = 14;
            btnXoaHD.Text = "Xóa hóa đơn";
            btnXoaHD.UseVisualStyleBackColor = true;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // btnLuuHD
            // 
            btnLuuHD.Location = new Point(28, 42);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(194, 74);
            btnLuuHD.TabIndex = 12;
            btnLuuHD.Text = "Lưu hóa đơn";
            btnLuuHD.UseVisualStyleBackColor = true;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnTaoHD);
            groupBox4.Controls.Add(btnXoaHD);
            groupBox4.Controls.Add(btnLuuHD);
            groupBox4.Location = new Point(1468, 120);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(242, 431);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // lsvChiTietHD
            // 
            lsvChiTietHD.Location = new Point(31, 47);
            lsvChiTietHD.Name = "lsvChiTietHD";
            lsvChiTietHD.Size = new Size(549, 315);
            lsvChiTietHD.TabIndex = 20;
            lsvChiTietHD.UseCompatibleStateImageBehavior = false;
            lsvChiTietHD.SelectedIndexChanged += lsvChiTietHD_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 758);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 19;
            // 
            // lstSanPham
            // 
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 25;
            lstSanPham.Location = new Point(31, 40);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(549, 154);
            lstSanPham.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(173, 123);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(407, 31);
            txtSoLuong.TabIndex = 13;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(173, 82);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(407, 31);
            txtTenSP.TabIndex = 12;
            txtTenSP.TextChanged += txtTenSP_TextChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(173, 40);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(407, 31);
            txtMaSP.TabIndex = 10;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(397, 172);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(183, 38);
            btnThemSP.TabIndex = 11;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstSanPham);
            groupBox3.Location = new Point(835, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(606, 221);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 123);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 10;
            label8.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 51);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 8;
            label6.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(btnCapNhatSoLuong);
            groupBox2.Controls.Add(btnThemSP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(835, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(606, 241);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // btnCapNhatSoLuong
            // 
            btnCapNhatSoLuong.Location = new Point(173, 172);
            btnCapNhatSoLuong.Name = "btnCapNhatSoLuong";
            btnCapNhatSoLuong.Size = new Size(183, 38);
            btnCapNhatSoLuong.TabIndex = 11;
            btnCapNhatSoLuong.Text = "Cập nhật số lượng";
            btnCapNhatSoLuong.UseVisualStyleBackColor = true;
            btnCapNhatSoLuong.Click += btnCapNhatSoLuong_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 88);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 9;
            label7.Text = "Tên sản phẩm";
            // 
            // dTimeNgayHD
            // 
            dTimeNgayHD.Location = new Point(267, 128);
            dTimeNgayHD.Name = "dTimeNgayHD";
            dTimeNgayHD.Size = new Size(428, 31);
            dTimeNgayHD.TabIndex = 11;
            // 
            // cbTheThanhVien
            // 
            cbTheThanhVien.FormattingEnabled = true;
            cbTheThanhVien.Location = new Point(267, 81);
            cbTheThanhVien.Name = "cbTheThanhVien";
            cbTheThanhVien.Size = new Size(428, 33);
            cbTheThanhVien.TabIndex = 10;
            // 
            // txtTriGiaHD
            // 
            txtTriGiaHD.Enabled = false;
            txtTriGiaHD.Location = new Point(267, 174);
            txtTriGiaHD.Name = "txtTriGiaHD";
            txtTriGiaHD.Size = new Size(428, 31);
            txtTriGiaHD.TabIndex = 9;
            // 
            // txtSoHD
            // 
            txtSoHD.Location = new Point(267, 40);
            txtSoHD.Name = "txtSoHD";
            txtSoHD.Size = new Size(428, 31);
            txtSoHD.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 133);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 7;
            label5.Text = "Ngày tạo hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 179);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 6;
            label4.Text = "Trị giá hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 88);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 5;
            label3.Text = "Thẻ thành viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 42);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "Số hóa đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dTimeNgayHD);
            groupBox1.Controls.Add(cbTheThanhVien);
            groupBox1.Controls.Add(txtNVXuatHD);
            groupBox1.Controls.Add(txtTriGiaHD);
            groupBox1.Controls.Add(txtSoHD);
            groupBox1.Controls.Add(lblNVXuatHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(62, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 286);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtNVXuatHD
            // 
            txtNVXuatHD.Enabled = false;
            txtNVXuatHD.Location = new Point(267, 219);
            txtNVXuatHD.Name = "txtNVXuatHD";
            txtNVXuatHD.Size = new Size(428, 31);
            txtNVXuatHD.TabIndex = 9;
            // 
            // lblNVXuatHD
            // 
            lblNVXuatHD.AutoSize = true;
            lblNVXuatHD.Location = new Point(31, 224);
            lblNVXuatHD.Name = "lblNVXuatHD";
            lblNVXuatHD.Size = new Size(201, 25);
            lblNVXuatHD.TabIndex = 6;
            lblNVXuatHD.Text = "Nhân viên xuất hóa đơn";
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Location = new Point(594, 39);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(191, 25);
            lblTenForm.TabIndex = 15;
            lblTenForm.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnXoaCTHD
            // 
            btnXoaCTHD.Location = new Point(445, 382);
            btnXoaCTHD.Name = "btnXoaCTHD";
            btnXoaCTHD.Size = new Size(135, 46);
            btnXoaCTHD.TabIndex = 14;
            btnXoaCTHD.Text = "Xóa";
            btnXoaCTHD.UseVisualStyleBackColor = true;
            btnXoaCTHD.Click += btnXoaCTHD_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnXoaCTHD);
            groupBox6.Controls.Add(lsvChiTietHD);
            groupBox6.Location = new Point(835, 635);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(606, 452);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi tiết hóa đơn";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lsvDanhSachHD);
            groupBox7.Controls.Add(txtSoLuongHD);
            groupBox7.Controls.Add(lblSoLuongHD);
            groupBox7.Location = new Point(62, 429);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(723, 658);
            groupBox7.TabIndex = 18;
            groupBox7.TabStop = false;
            groupBox7.Text = "Danh sách hóa đơn";
            // 
            // lsvDanhSachHD
            // 
            lsvDanhSachHD.Location = new Point(31, 48);
            lsvDanhSachHD.Name = "lsvDanhSachHD";
            lsvDanhSachHD.Size = new Size(664, 520);
            lsvDanhSachHD.TabIndex = 20;
            lsvDanhSachHD.UseCompatibleStateImageBehavior = false;
            lsvDanhSachHD.SelectedIndexChanged += lsvDanhSachHD_SelectedIndexChanged;
            // 
            // txtSoLuongHD
            // 
            txtSoLuongHD.Enabled = false;
            txtSoLuongHD.Location = new Point(220, 593);
            txtSoLuongHD.Name = "txtSoLuongHD";
            txtSoLuongHD.Size = new Size(475, 31);
            txtSoLuongHD.TabIndex = 9;
            // 
            // lblSoLuongHD
            // 
            lblSoLuongHD.AutoSize = true;
            lblSoLuongHD.Location = new Point(31, 599);
            lblSoLuongHD.Name = "lblSoLuongHD";
            lblSoLuongHD.Size = new Size(157, 25);
            lblSoLuongHD.TabIndex = 6;
            lblSoLuongHD.Text = "Số lượng hóa đơn";
            // 
            // FHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1778, 1144);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(label9);
            Controls.Add(groupBox7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox6);
            ForeColor = SystemColors.ControlText;
            Name = "FHoaDon";
            Text = "FHoaDon";
            Load += FHoaDon_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private GroupBox groupBox5;
        private Button btnThoat;
        private Button btnTaoHD;
        private Button btnXoaHD;
        private Button btnLuuHD;
        private GroupBox groupBox4;
        private ListView lsvChiTietHD;
        private Label label9;
        private ListBox lstSanPham;
        private TextBox txtSoLuong;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Button btnThemSP;
        private GroupBox groupBox3;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private DateTimePicker dTimeNgayHD;
        private ComboBox cbTheThanhVien;
        private TextBox txtTriGiaHD;
        private TextBox txtSoHD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTenForm;
        private Button btnXoaCTHD;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private ListView lsvDanhSachHD;
        private TextBox txtIDNhanVien;
        private TextBox txtSoLuongHD;
        private Label lblSoLuongHD;
        private TextBox txtNVXuatHD;
        private Label lblNVXuatHD;
        private Button btnCapNhatSoLuong;
    }
}