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
            groupBox5 = new GroupBox();
            txtSoLuongSP = new TextBox();
            lblSoLuongSP = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            groupBox4 = new GroupBox();
            btnThoat = new Button();
            btnHuy = new Button();
            bthXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lsvDSSP = new ListView();
            lblTenForm = new Label();
            groupBox1 = new GroupBox();
            cbLoaiSP = new ComboBox();
            txtGia = new TextBox();
            txtHinhAnh = new TextBox();
            txtIDSP = new TextBox();
            txtTenSP = new TextBox();
            lblLoaiSP = new Label();
            lblHinhAnh = new Label();
            lblIDSanPham = new Label();
            lblGia = new Label();
            lblTenSanPham = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtSoLuongSP);
            groupBox5.Controls.Add(lblSoLuongSP);
            groupBox5.Location = new Point(1184, 561);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(527, 157);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            // 
            // txtSoLuongSP
            // 
            txtSoLuongSP.Enabled = false;
            txtSoLuongSP.Location = new Point(65, 91);
            txtSoLuongSP.Name = "txtSoLuongSP";
            txtSoLuongSP.Size = new Size(401, 31);
            txtSoLuongSP.TabIndex = 2;
            // 
            // lblSoLuongSP
            // 
            lblSoLuongSP.AutoSize = true;
            lblSoLuongSP.Location = new Point(172, 46);
            lblSoLuongSP.Name = "lblSoLuongSP";
            lblSoLuongSP.Size = new Size(168, 25);
            lblSoLuongSP.TabIndex = 1;
            lblSoLuongSP.Text = "Số lượng sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1184, 146);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 14;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1184, 186);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(527, 31);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(bthXoa);
            groupBox4.Controls.Add(btnCapNhat);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(1184, 251);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(527, 286);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(65, 196);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(401, 56);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(65, 115);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(169, 56);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // bthXoa
            // 
            bthXoa.Location = new Point(297, 115);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(169, 56);
            bthXoa.TabIndex = 0;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            bthXoa.Click += bthXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(297, 43);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(169, 56);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(65, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 56);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSSP);
            groupBox2.Location = new Point(67, 500);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 320);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // lsvDSSP
            // 
            lsvDSSP.Location = new Point(29, 46);
            lsvDSSP.Name = "lsvDSSP";
            lsvDSSP.Size = new Size(1006, 248);
            lsvDSSP.TabIndex = 0;
            lsvDSSP.UseCompatibleStateImageBehavior = false;
            lsvDSSP.SelectedIndexChanged += lsvDSSP_SelectedIndexChanged;
            // 
            // lblTenForm
            // 
            lblTenForm.AutoSize = true;
            lblTenForm.Location = new Point(510, 81);
            lblTenForm.Name = "lblTenForm";
            lblTenForm.Size = new Size(181, 25);
            lblTenForm.TabIndex = 9;
            lblTenForm.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(txtIDSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(lblLoaiSP);
            groupBox1.Controls.Add(lblHinhAnh);
            groupBox1.Controls.Add(lblIDSanPham);
            groupBox1.Controls.Add(lblGia);
            groupBox1.Controls.Add(lblTenSanPham);
            groupBox1.Location = new Point(67, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1069, 319);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(207, 147);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(804, 33);
            cbLoaiSP.TabIndex = 6;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(207, 195);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(804, 31);
            txtGia.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(207, 241);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(804, 31);
            txtHinhAnh.TabIndex = 2;
            // 
            // txtIDSP
            // 
            txtIDSP.Location = new Point(207, 53);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.Size = new Size(804, 31);
            txtIDSP.TabIndex = 2;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(207, 102);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(804, 31);
            txtTenSP.TabIndex = 2;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Location = new Point(44, 155);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(127, 25);
            lblLoaiSP.TabIndex = 1;
            lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(45, 244);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(83, 25);
            lblHinhAnh.TabIndex = 1;
            lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblIDSanPham
            // 
            lblIDSanPham.AutoSize = true;
            lblIDSanPham.Location = new Point(44, 59);
            lblIDSanPham.Name = "lblIDSanPham";
            lblIDSanPham.Size = new Size(113, 25);
            lblIDSanPham.TabIndex = 1;
            lblIDSanPham.Text = "ID sản phẩm";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(44, 201);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(71, 25);
            lblGia.TabIndex = 1;
            lblGia.Text = "Giá tiền";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new Point(44, 108);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(121, 25);
            lblTenSanPham.TabIndex = 1;
            lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // FSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1144);
            Controls.Add(groupBox5);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(lblTenForm);
            Controls.Add(groupBox1);
            Name = "FSanPham";
            Text = "FSanPham";
            Load += FSanPham_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private TextBox txtSoLuongSP;
        private Label lblSoLuongSP;
        private Label label2;
        private TextBox txtTimKiem;
        private GroupBox groupBox4;
        private Button btnThoat;
        private Button btnHuy;
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
    }
}