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
            btnThoat = new Button();
            btnNhapMoi = new Button();
            bthXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
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
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSoLuongSP
            // 
            txtSoLuongSP.Enabled = false;
            txtSoLuongSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongSP.Location = new Point(1238, 476);
            txtSoLuongSP.Name = "txtSoLuongSP";
            txtSoLuongSP.ReadOnly = true;
            txtSoLuongSP.Size = new Size(282, 30);
            txtSoLuongSP.TabIndex = 2;
            // 
            // lblSoLuongSP
            // 
            lblSoLuongSP.AutoSize = true;
            lblSoLuongSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongSP.Location = new Point(1035, 484);
            lblSoLuongSP.Name = "lblSoLuongSP";
            lblSoLuongSP.Size = new Size(181, 25);
            lblSoLuongSP.TabIndex = 1;
            lblSoLuongSP.Text = "Số lượng sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(27, 54);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 14;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(149, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1371, 30);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F);
            btnThoat.Location = new Point(44, 327);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(187, 58);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Font = new Font("Microsoft Sans Serif", 10F);
            btnNhapMoi.Location = new Point(44, 176);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(187, 58);
            btnNhapMoi.TabIndex = 0;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // bthXoa
            // 
            bthXoa.Font = new Font("Microsoft Sans Serif", 10F);
            bthXoa.Location = new Point(44, 251);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(187, 58);
            bthXoa.TabIndex = 0;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhat.Location = new Point(44, 101);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(187, 58);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 10F);
            btnThem.Location = new Point(44, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(187, 58);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoLuongSP);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lsvDSSP);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(lblSoLuongSP);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(74, 604);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1550, 534);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // lsvDSSP
            // 
            lsvDSSP.Font = new Font("Microsoft Sans Serif", 10F);
            lsvDSSP.Location = new Point(0, 101);
            lsvDSSP.Name = "lsvDSSP";
            lsvDSSP.Size = new Size(1550, 357);
            lsvDSSP.TabIndex = 0;
            lsvDSSP.UseCompatibleStateImageBehavior = false;
            lsvDSSP.SelectedIndexChanged += lsvDSSP_SelectedIndexChanged;
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Font = new Font("Microsoft Sans Serif", 24F);
            lblTenForm.Location = new Point(74, 50);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(499, 55);
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
            groupBox1.Location = new Point(74, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 412);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(782, 52);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(330, 33);
            cbLoaiSP.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuong.Location = new Point(228, 251);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(884, 30);
            txtSoLuong.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            txtDonViTinh.Location = new Point(228, 202);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(884, 30);
            txtDonViTinh.TabIndex = 2;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft Sans Serif", 10F);
            txtGia.Location = new Point(228, 152);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(884, 30);
            txtGia.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            txtHinhAnh.Location = new Point(228, 302);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(884, 30);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDSP
            // 
            txtIDSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDSP.Location = new Point(228, 52);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.Size = new Size(300, 30);
            txtIDSP.TabIndex = 2;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenSP.Location = new Point(228, 102);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(884, 30);
            txtTenSP.TabIndex = 2;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblLoaiSP.Location = new Point(602, 60);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(140, 25);
            lblLoaiSP.TabIndex = 1;
            lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuong.Location = new Point(48, 260);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(90, 25);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            lblHinhAnh.Location = new Point(50, 310);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(90, 25);
            lblHinhAnh.TabIndex = 1;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            lblDonViTinh.Location = new Point(48, 210);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(103, 25);
            lblDonViTinh.TabIndex = 1;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // lblIDSanPham
            // 
            lblIDSanPham.AutoSize = true;
            lblIDSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDSanPham.Location = new Point(48, 60);
            lblIDSanPham.Name = "lblIDSanPham";
            lblIDSanPham.Size = new Size(122, 25);
            lblIDSanPham.TabIndex = 1;
            lblIDSanPham.Text = "ID sản phẩm";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Microsoft Sans Serif", 10F);
            lblGia.Location = new Point(48, 160);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(78, 25);
            lblGia.TabIndex = 1;
            lblGia.Text = "Giá tiền";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblTenSanPham.Location = new Point(48, 110);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(138, 25);
            lblTenSanPham.TabIndex = 1;
            lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 87);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(bthXoa);
            panel1.Controls.Add(btnCapNhat);
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1353, 142);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 412);
            panel1.TabIndex = 33;
            // 
            // FSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1678, 1194);
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
        private Button btnThoat;
        private Button btnNhapMoi;
        private Button bthXoa;
        private Button btnCapNhat;
        private Button btnThem;
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
    }
}