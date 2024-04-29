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
            lblNhanVien = new Label();
            btnThoat = new Button();
            btnTaoHD = new Button();
            btnHuy = new Button();
            btnCapNhat = new Button();
            btnLuu = new Button();
            groupBox4 = new GroupBox();
            lsvChiTietHD = new ListView();
            label9 = new Label();
            lstSanPham = new ListBox();
            txtSoLuong = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            dTimeNgayHD = new DateTimePicker();
            cmbKhachHang = new ComboBox();
            txtTriGiaHD = new TextBox();
            txtSoHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 27);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 4;
            label10.Text = "Nhân viên";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblNhanVien);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(1221, 606);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(242, 150);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(110, 70);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(20, 25);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "''";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(54, 358);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(135, 58);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new Point(54, 286);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(135, 58);
            btnTaoHD.TabIndex = 15;
            btnTaoHD.Text = "Tạo HĐ mới";
            btnTaoHD.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(54, 206);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(135, 58);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy HĐ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(54, 131);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(135, 58);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập nhật HĐ";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(54, 57);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(135, 58);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu Hóa đơn";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnTaoHD);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(btnCapNhat);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Location = new Point(1221, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(242, 455);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // lsvChiTietHD
            // 
            lsvChiTietHD.Location = new Point(65, 606);
            lsvChiTietHD.Name = "lsvChiTietHD";
            lsvChiTietHD.Size = new Size(1026, 146);
            lsvChiTietHD.TabIndex = 20;
            lsvChiTietHD.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 578);
            label9.Name = "label9";
            label9.Size = new Size(139, 25);
            label9.TabIndex = 19;
            label9.Text = "Chi tiết hóa đơn";
            // 
            // lstSanPham
            // 
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 25;
            lstSanPham.Location = new Point(31, 33);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(948, 79);
            lstSanPham.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(752, 41);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(83, 31);
            txtSoLuong.TabIndex = 13;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(417, 41);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(225, 31);
            txtTenSP.TabIndex = 12;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(108, 41);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(150, 31);
            txtMaSP.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(867, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 48);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstSanPham);
            groupBox3.Location = new Point(65, 438);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1026, 132);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 44);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 10;
            label8.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 44);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 8;
            label6.Text = "Mã sp";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtTenSP);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(65, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1026, 104);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 44);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 9;
            label7.Text = "Tên sản phẩm";
            // 
            // dTimeNgayHD
            // 
            dTimeNgayHD.Location = new Point(695, 36);
            dTimeNgayHD.Name = "dTimeNgayHD";
            dTimeNgayHD.Size = new Size(300, 31);
            dTimeNgayHD.TabIndex = 11;
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(154, 85);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(509, 33);
            cmbKhachHang.TabIndex = 10;
            // 
            // txtTriGiaHD
            // 
            txtTriGiaHD.Location = new Point(154, 137);
            txtTriGiaHD.Name = "txtTriGiaHD";
            txtTriGiaHD.Size = new Size(351, 31);
            txtTriGiaHD.TabIndex = 9;
            // 
            // txtSoHD
            // 
            txtSoHD.Location = new Point(154, 36);
            txtSoHD.Name = "txtSoHD";
            txtSoHD.Size = new Size(351, 31);
            txtSoHD.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 39);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 7;
            label5.Text = "Ngày tạo HĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 140);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Trị giá HĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 88);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 5;
            label3.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Số HĐ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dTimeNgayHD);
            groupBox1.Controls.Add(cmbKhachHang);
            groupBox1.Controls.Add(txtTriGiaHD);
            groupBox1.Controls.Add(txtSoHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(65, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 225);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 15;
            label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // FHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 790);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(lsvChiTietHD);
            Controls.Add(label9);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FHoaDon";
            Text = "FHoaDon";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private GroupBox groupBox5;
        private Label lblNhanVien;
        private Button btnThoat;
        private Button btnTaoHD;
        private Button btnHuy;
        private Button btnCapNhat;
        private Button btnLuu;
        private GroupBox groupBox4;
        private ListView lsvChiTietHD;
        private Label label9;
        private ListBox lstSanPham;
        private TextBox txtSoLuong;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Button btnThem;
        private GroupBox groupBox3;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private DateTimePicker dTimeNgayHD;
        private ComboBox cmbKhachHang;
        private TextBox txtTriGiaHD;
        private TextBox txtSoHD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
    }
}