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
            txtSoLuongSP.Location = new Point(1527, 431);
            txtSoLuongSP.Name = "txtSoLuongSP";
            txtSoLuongSP.ReadOnly = true;
            txtSoLuongSP.Size = new Size(167, 30);
            txtSoLuongSP.TabIndex = 8;
            // 
            // lblSoLuongSP
            // 
            lblSoLuongSP.AutoSize = true;
            lblSoLuongSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongSP.Location = new Point(1328, 436);
            lblSoLuongSP.Name = "lblSoLuongSP";
            lblSoLuongSP.Size = new Size(181, 25);
            lblSoLuongSP.TabIndex = 0;
            lblSoLuongSP.Text = "Số lượng sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(50, 48);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(162, 43);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1517, 30);
            txtTimKiem.TabIndex = 8;
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
            groupBox2.Location = new Point(73, 677);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1726, 479);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // lsvDSSP
            // 
            lsvDSSP.Font = new Font("Microsoft Sans Serif", 10F);
            lsvDSSP.Location = new Point(0, 92);
            lsvDSSP.MultiSelect = false;
            lsvDSSP.Name = "lsvDSSP";
            lsvDSSP.Size = new Size(1726, 323);
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
            groupBox1.Size = new Size(1312, 447);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(913, 46);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(340, 33);
            cbLoaiSP.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuong.Location = new Point(248, 256);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(1005, 30);
            txtSoLuong.TabIndex = 6;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            txtDonViTinh.Location = new Point(248, 205);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(1005, 30);
            txtDonViTinh.TabIndex = 5;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft Sans Serif", 10F);
            txtGia.Location = new Point(248, 153);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(1005, 30);
            txtGia.TabIndex = 4;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            txtHinhAnh.Location = new Point(248, 309);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(1005, 30);
            txtHinhAnh.TabIndex = 7;
            // 
            // txtIDSP
            // 
            txtIDSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDSP.Location = new Point(248, 49);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.Size = new Size(407, 30);
            txtIDSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Microsoft Sans Serif", 10F);
            txtTenSP.Location = new Point(248, 101);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(1005, 30);
            txtTenSP.TabIndex = 3;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Font = new Font("Microsoft Sans Serif", 10F);
            lblLoaiSP.Location = new Point(717, 54);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(140, 25);
            lblLoaiSP.TabIndex = 0;
            lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuong.Location = new Point(51, 266);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(90, 25);
            lblSoLuong.TabIndex = 0;
            lblSoLuong.Text = "Số lượng";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Microsoft Sans Serif", 10F);
            lblHinhAnh.Location = new Point(53, 318);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(90, 25);
            lblHinhAnh.TabIndex = 0;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Microsoft Sans Serif", 10F);
            lblDonViTinh.Location = new Point(51, 214);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(103, 25);
            lblDonViTinh.TabIndex = 0;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // lblIDSanPham
            // 
            lblIDSanPham.AutoSize = true;
            lblIDSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDSanPham.Location = new Point(51, 57);
            lblIDSanPham.Name = "lblIDSanPham";
            lblIDSanPham.Size = new Size(131, 25);
            lblIDSanPham.TabIndex = 0;
            lblIDSanPham.Text = "Mã sản phẩm";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Microsoft Sans Serif", 10F);
            lblGia.Location = new Point(51, 161);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(78, 25);
            lblGia.TabIndex = 0;
            lblGia.Text = "Giá tiền";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Font = new Font("Microsoft Sans Serif", 10F);
            lblTenSanPham.Location = new Point(51, 109);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(138, 25);
            lblTenSanPham.TabIndex = 0;
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
            panel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1477, 199);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 447);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F);
            btnThoat.Location = new Point(52, 355);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(223, 62);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhat.Location = new Point(52, 109);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(223, 62);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Font = new Font("Microsoft Sans Serif", 10F);
            btnNhapMoi.Location = new Point(52, 191);
            btnNhapMoi.Margin = new Padding(4);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(223, 62);
            btnNhapMoi.TabIndex = 11;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoa.Location = new Point(52, 272);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(223, 62);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += bthXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 10F);
            btnThem.Location = new Point(52, 30);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(223, 62);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FSanPham
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1900, 1250);
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