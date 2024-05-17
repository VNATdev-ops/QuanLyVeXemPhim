namespace QuanLyVeXemPhim.Views
{
    partial class FSanPham
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
            txtSoLuongSP = new TextBox();
            lblSoLuongSP = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            lsvDSSP = new ListView();
            lblTenForm = new Label();
            groupBox1 = new GroupBox();
            cbLoaiSP = new ComboBox();
            txtSoLuong = new TextBox();
            txtDonViTinh = new TextBox();
            txtGia = new TextBox();
            txtHinhAnh = new TextBox();
            txtIDSP = new TextBox();
            txtTenSP = new TextBox();
            lblLoaiSP = new Label();
            lblSoLuong = new Label();
            lblHinhAnh = new Label();
            lblDonViTinh = new Label();
            lblIDSanPham = new Label();
            lblGia = new Label();
            lblTenSanPham = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSoLuongSP
            // 
            txtSoLuongSP.Enabled = false;
            txtSoLuongSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongSP.Location = new Point(1425, 432);
            txtSoLuongSP.Name = "txtSoLuongSP";
            txtSoLuongSP.ReadOnly = true;
            txtSoLuongSP.Size = new Size(282, 30);
            txtSoLuongSP.TabIndex = 2;
            // 
            // lblSoLuongSP
            // 
            lblSoLuongSP.AutoSize = true;
            lblSoLuongSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongSP.Location = new Point(1218, 437);
            lblSoLuongSP.Name = "lblSoLuongSP";
            lblSoLuongSP.Size = new Size(181, 25);
            lblSoLuongSP.TabIndex = 1;
            lblSoLuongSP.Text = "Số lượng sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 14;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(149, 38);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1545, 30);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuongSP);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lsvDSSP);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(lblSoLuongSP);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(74, 660);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1737, 485);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // lsvDSSP
            // 
            lsvDSSP.Font = new Font("Microsoft Sans Serif", 10F);
            lsvDSSP.Location = new Point(0, 88);
            lsvDSSP.Name = "lsvDSSP";
            lsvDSSP.Size = new Size(1737, 326);
            lsvDSSP.TabIndex = 0;
            lsvDSSP.UseCompatibleStateImageBehavior = false;
            lsvDSSP.SelectedIndexChanged += lsvDSSP_SelectedIndexChanged;
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTenForm.Location = new Point(73, 74);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(515, 55);
            lblTenForm.TabIndex = 9;
            lblTenForm.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(txtIDSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(lblLoaiSP);
            groupBox1.Controls.Add(lblSoLuong);
            groupBox1.Controls.Add(lblHinhAnh);
            groupBox1.Controls.Add(lblDonViTinh);
            groupBox1.Controls.Add(lblIDSanPham);
            groupBox1.Controls.Add(lblGia);
            groupBox1.Controls.Add(lblTenSanPham);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(73, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1336, 429);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(850, 44);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(430, 33);
            cbLoaiSP.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuong.Location = new Point(227, 246);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(1053, 30);
            txtSoLuong.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            txtDonViTinh.Location = new Point(227, 197);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(1053, 30);
            txtDonViTinh.TabIndex = 2;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft Sans Serif", 10F);
            txtGia.Location = new Point(227, 147);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(1053, 30);
            txtGia.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            txtHinhAnh.Location = new Point(227, 297);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(1053, 30);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDSP
            // 
            txtIDSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDSP.Location = new Point(227, 47);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.Size = new Size(373, 30);
            txtIDSP.TabIndex = 2;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenSP.Location = new Point(227, 97);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(1053, 30);
            txtTenSP.TabIndex = 2;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblLoaiSP.Location = new Point(670, 52);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(140, 25);
            lblLoaiSP.TabIndex = 1;
            lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuong.Location = new Point(47, 255);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(90, 25);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            lblHinhAnh.Location = new Point(49, 305);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(90, 25);
            lblHinhAnh.TabIndex = 1;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            lblDonViTinh.Location = new Point(47, 205);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(103, 25);
            lblDonViTinh.TabIndex = 1;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // lblIDSanPham
            // 
            lblIDSanPham.AutoSize = true;
            lblIDSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDSanPham.Location = new Point(47, 55);
            lblIDSanPham.Name = "lblIDSanPham";
            lblIDSanPham.Size = new Size(122, 25);
            lblIDSanPham.TabIndex = 1;
            lblIDSanPham.Text = "ID sản phẩm";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Microsoft Sans Serif", 10F);
            lblGia.Location = new Point(47, 155);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(78, 25);
            lblGia.TabIndex = 1;
            lblGia.Text = "Giá tiền";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblTenSanPham.Location = new Point(47, 105);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(138, 25);
            lblTenSanPham.TabIndex = 1;
            lblTenSanPham.Text = "Tên sản phẩm";
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
            panel1.Location = new Point(1516, 199);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 429);
            panel1.TabIndex = 19;
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
            btnXoa.Click += bthXoa_Click;
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
            // FSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FSanPham";
            Load += FSanPham_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSoLuongSP;
        private Label lblSoLuongSP;
        private Label label2;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private ListView lsvDSSP;
        private Label lblTenForm;
        private GroupBox groupBox1;
        private ComboBox cbLoaiSP;
        private TextBox txtGia;
        private TextBox txtIDSP;
        private TextBox txtTenSP;
        private Label lblLoaiSP;
        private Label lblIDSanPham;
        private Label lblGia;
        private Label lblTenSanPham;
        private TextBox txtHinhAnh;
        private Label lblHinhAnh;
        private TextBox txtDonViTinh;
        private Label lblDonViTinh;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
    }
}