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
            dTimeNgayHD = new DateTimePicker();
            txtTriGiaHD = new TextBox();
            txtSoHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtMaSP = new TextBox();
            txtNVXuatHD = new TextBox();
            lblNVXuatHD = new Label();
            txtTenSP = new TextBox();
            cbTheThanhVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            lblTenForm = new Label();
            btnXoaCTHD = new Button();
            groupBox7 = new GroupBox();
            lsvDanhSachHD = new ListView();
            txtSoLuongHD = new TextBox();
            lblSoLuongHD = new Label();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            groupBox6 = new GroupBox();
            lsvChiTietHD = new ListView();
            txtSoLuong = new TextBox();
            btnCapNhatSoLuong = new Button();
            groupBox5 = new GroupBox();
            txtIDNhanVien = new TextBox();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            lstSanPham = new ListBox();
            btnThemSP = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnXoaHD = new Button();
            btnTaoHD = new Button();
            btnLuuHD = new Button();
            panelRight = new Panel();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // dTimeNgayHD
            // 
            dTimeNgayHD.CustomFormat = "";
            dTimeNgayHD.Font = new Font("Microsoft Sans Serif", 10F);
            dTimeNgayHD.Location = new Point(321, 147);
            dTimeNgayHD.Name = "dTimeNgayHD";
            dTimeNgayHD.Size = new Size(418, 30);
            dTimeNgayHD.TabIndex = 3;
            // 
            // txtTriGiaHD
            // 
            txtTriGiaHD.Font = new Font("Microsoft Sans Serif", 10F);
            txtTriGiaHD.Location = new Point(321, 199);
            txtTriGiaHD.Name = "txtTriGiaHD";
            txtTriGiaHD.ReadOnly = true;
            txtTriGiaHD.Size = new Size(418, 30);
            txtTriGiaHD.TabIndex = 4;
            // 
            // txtSoHD
            // 
            txtSoHD.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoHD.Location = new Point(321, 43);
            txtSoHD.Name = "txtSoHD";
            txtSoHD.Size = new Size(418, 30);
            txtSoHD.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(37, 157);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 0;
            label5.Text = "Ngày tạo hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(37, 209);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 0;
            label4.Text = "Trị giá hóa đơn";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtMaSP.Location = new Point(200, 43);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(429, 30);
            txtMaSP.TabIndex = 8;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // txtNVXuatHD
            // 
            txtNVXuatHD.Font = new Font("Microsoft Sans Serif", 10F);
            txtNVXuatHD.Location = new Point(321, 251);
            txtNVXuatHD.Name = "txtNVXuatHD";
            txtNVXuatHD.ReadOnly = true;
            txtNVXuatHD.Size = new Size(418, 30);
            txtNVXuatHD.TabIndex = 5;
            // 
            // lblNVXuatHD
            // 
            lblNVXuatHD.AutoSize = true;
            lblNVXuatHD.Font = new Font("Microsoft Sans Serif", 10F);
            lblNVXuatHD.Location = new Point(37, 261);
            lblNVXuatHD.Name = "lblNVXuatHD";
            lblNVXuatHD.Size = new Size(218, 25);
            lblNVXuatHD.TabIndex = 0;
            lblNVXuatHD.Text = "Nhân viên xuất hóa đơn";
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenSP.Location = new Point(200, 95);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(429, 30);
            txtTenSP.TabIndex = 9;
            txtTenSP.TextChanged += txtTenSP_TextChanged;
            // 
            // cbTheThanhVien
            // 
            cbTheThanhVien.Font = new Font("Microsoft Sans Serif", 10F);
            cbTheThanhVien.FormattingEnabled = true;
            cbTheThanhVien.Location = new Point(321, 95);
            cbTheThanhVien.Name = "cbTheThanhVien";
            cbTheThanhVien.Size = new Size(418, 33);
            cbTheThanhVien.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(37, 105);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 0;
            label3.Text = "Thẻ thành viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(37, 53);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 0;
            label2.Text = "Số hóa đơn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F);
            label10.Location = new Point(55, 40);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 0;
            label10.Text = "Mã nhân viên";
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenForm.Location = new Point(73, 74);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(760, 55);
            lblTenForm.TabIndex = 24;
            lblTenForm.Text = "QUẢN LÝ HÓA ĐƠN BÁN HÀNG";
            // 
            // btnXoaCTHD
            // 
            btnXoaCTHD.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoaCTHD.Location = new Point(500, 324);
            btnXoaCTHD.Name = "btnXoaCTHD";
            btnXoaCTHD.Size = new Size(129, 41);
            btnXoaCTHD.TabIndex = 14;
            btnXoaCTHD.Text = "Xóa";
            btnXoaCTHD.UseVisualStyleBackColor = true;
            btnXoaCTHD.Click += btnXoaCTHD_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lsvDanhSachHD);
            groupBox7.Controls.Add(txtSoLuongHD);
            groupBox7.Controls.Add(lblSoLuongHD);
            groupBox7.Controls.Add(txtTimKiem);
            groupBox7.Controls.Add(lblTimKiem);
            groupBox7.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox7.Location = new Point(73, 554);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(780, 606);
            groupBox7.TabIndex = 27;
            groupBox7.TabStop = false;
            groupBox7.Text = "Danh sách hóa đơn";
            // 
            // lsvDanhSachHD
            // 
            lsvDanhSachHD.Font = new Font("Microsoft Sans Serif", 10F);
            lsvDanhSachHD.Location = new Point(0, 108);
            lsvDanhSachHD.MultiSelect = false;
            lsvDanhSachHD.Name = "lsvDanhSachHD";
            lsvDanhSachHD.Size = new Size(780, 426);
            lsvDanhSachHD.TabIndex = 20;
            lsvDanhSachHD.UseCompatibleStateImageBehavior = false;
            lsvDanhSachHD.SelectedIndexChanged += lsvDanhSachHD_SelectedIndexChanged;
            // 
            // txtSoLuongHD
            // 
            txtSoLuongHD.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongHD.Location = new Point(648, 552);
            txtSoLuongHD.Name = "txtSoLuongHD";
            txtSoLuongHD.ReadOnly = true;
            txtSoLuongHD.Size = new Size(112, 30);
            txtSoLuongHD.TabIndex = 7;
            // 
            // lblSoLuongHD
            // 
            lblSoLuongHD.AutoSize = true;
            lblSoLuongHD.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongHD.Location = new Point(436, 554);
            lblSoLuongHD.Name = "lblSoLuongHD";
            lblSoLuongHD.Size = new Size(166, 25);
            lblSoLuongHD.TabIndex = 0;
            lblSoLuongHD.Text = "Số lượng hóa đơn";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(156, 48);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(583, 30);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            lblTimKiem.Location = new Point(37, 51);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(91, 25);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnXoaCTHD);
            groupBox6.Controls.Add(lsvChiTietHD);
            groupBox6.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox6.Location = new Point(898, 776);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(673, 384);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi tiết hóa đơn";
            // 
            // lsvChiTietHD
            // 
            lsvChiTietHD.Font = new Font("Microsoft Sans Serif", 10F);
            lsvChiTietHD.Location = new Point(0, 48);
            lsvChiTietHD.Name = "lsvChiTietHD";
            lsvChiTietHD.Size = new Size(673, 264);
            lsvChiTietHD.TabIndex = 20;
            lsvChiTietHD.UseCompatibleStateImageBehavior = false;
            lsvChiTietHD.SelectedIndexChanged += lsvChiTietHD_SelectedIndexChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuong.Location = new Point(200, 147);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(429, 30);
            txtSoLuong.TabIndex = 10;
            // 
            // btnCapNhatSoLuong
            // 
            btnCapNhatSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhatSoLuong.Location = new Point(351, 209);
            btnCapNhatSoLuong.Name = "btnCapNhatSoLuong";
            btnCapNhatSoLuong.Size = new Size(129, 41);
            btnCapNhatSoLuong.TabIndex = 12;
            btnCapNhatSoLuong.Text = "Cập nhật";
            btnCapNhatSoLuong.UseVisualStyleBackColor = true;
            btnCapNhatSoLuong.Click += btnCapNhatSoLuong_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtIDNhanVien);
            groupBox5.Controls.Add(label10);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox5.Location = new Point(28, 613);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(243, 146);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDNhanVien.Location = new Point(31, 79);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Size = new Size(185, 30);
            txtIDNhanVien.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(73, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 323);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Microsoft Sans Serif", 10F);
            btnHuy.Location = new Point(200, 209);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 41);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lstSanPham
            // 
            lstSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 25;
            lstSanPham.Location = new Point(0, 47);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(673, 154);
            lstSanPham.TabIndex = 0;
            lstSanPham.SelectedIndexChanged += lstSanPham_SelectedIndexChanged;
            // 
            // btnThemSP
            // 
            btnThemSP.Font = new Font("Microsoft Sans Serif", 10F);
            btnThemSP.Location = new Point(500, 209);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(129, 41);
            btnThemSP.TabIndex = 11;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstSanPham);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.Location = new Point(898, 554);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 202);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.Location = new Point(38, 157);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 0;
            label8.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(38, 53);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 0;
            label6.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(234, 219, 200);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(btnCapNhatSoLuong);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThemSP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(898, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 284);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.Location = new Point(38, 105);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 0;
            label7.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.Location = new Point(92, 802);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 87);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXoaHD);
            panel1.Controls.Add(btnTaoHD);
            panel1.Controls.Add(btnLuuHD);
            panel1.Font = new Font("Microsoft Sans Serif", 10F);
            panel1.Location = new Point(28, 199);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 359);
            panel1.TabIndex = 32;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F);
            btnThoat.Location = new Point(31, 273);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(185, 61);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoaHD
            // 
            btnXoaHD.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoaHD.Location = new Point(31, 106);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(185, 61);
            btnXoaHD.TabIndex = 16;
            btnXoaHD.Text = "Xóa hóa đơn";
            btnXoaHD.UseVisualStyleBackColor = true;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Font = new Font("Microsoft Sans Serif", 10F);
            btnTaoHD.Location = new Point(31, 190);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(185, 61);
            btnTaoHD.TabIndex = 17;
            btnTaoHD.Text = "Nhập mới";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // btnLuuHD
            // 
            btnLuuHD.Font = new Font("Microsoft Sans Serif", 10F);
            btnLuuHD.Location = new Point(31, 29);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(185, 61);
            btnLuuHD.TabIndex = 15;
            btnLuuHD.Text = "Lưu hóa đơn";
            btnLuuHD.UseVisualStyleBackColor = true;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // panelRight
            // 
            panelRight.BackgroundImageLayout = ImageLayout.None;
            panelRight.Controls.Add(panel1);
            panelRight.Controls.Add(groupBox5);
            panelRight.Dock = DockStyle.Right;
            panelRight.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelRight.Location = new Point(1577, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(301, 1194);
            panelRight.TabIndex = 33;
            // 
            // FHoaDon
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(panelRight);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            MinimumSize = new Size(1900, 1250);
            Name = "FHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FHoaDon";
            Load += FHoaDon_Load;
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dTimeNgayHD;
        private TextBox txtTriGiaHD;
        private TextBox txtSoHD;
        private Label label5;
        private Label label4;
        private TextBox txtMaSP;
        private TextBox txtNVXuatHD;
        private Label lblNVXuatHD;
        private TextBox txtTenSP;
        private ComboBox cbTheThanhVien;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label lblTenForm;
        private Button btnXoaCTHD;
        private GroupBox groupBox7;
        private ListView lsvDanhSachHD;
        private TextBox txtSoLuongHD;
        private Label lblSoLuongHD;
        private GroupBox groupBox6;
        private ListView lsvChiTietHD;
        private TextBox txtSoLuong;
        private Button btnCapNhatSoLuong;
        private GroupBox groupBox5;
        private TextBox txtIDNhanVien;
        private GroupBox groupBox1;
        private Button btnHuy;
        private ListBox lstSanPham;
        private Button btnThemSP;
        private GroupBox groupBox3;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private Label label9;
        private Panel panel1;
        private Button btnThoat;
        private Button btnXoaHD;
        private Button btnTaoHD;
        private Button btnLuuHD;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Panel panelRight;
    }
}