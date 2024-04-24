namespace QuanLyVeXemPhim.Views
{
    partial class FQuanLyVeXemPhim
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtTheLoaiPhim = new Button();
            txtDaoDien = new Button();
            txtNgayChieuPhim = new Button();
            txtTenPhim = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lsvPhim = new ListView();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            phim = new Label();
            txtTimKiemPhim = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            txtTongSoPhim = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 1;
            label2.Text = "Quản lý vé xem phim";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTheLoaiPhim);
            groupBox1.Controls.Add(txtDaoDien);
            groupBox1.Controls.Add(txtNgayChieuPhim);
            groupBox1.Controls.Add(txtTenPhim);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 224);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // txtTheLoaiPhim
            // 
            txtTheLoaiPhim.Location = new Point(228, 171);
            txtTheLoaiPhim.Name = "txtTheLoaiPhim";
            txtTheLoaiPhim.Size = new Size(477, 35);
            txtTheLoaiPhim.TabIndex = 7;
            txtTheLoaiPhim.UseVisualStyleBackColor = true;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Location = new Point(228, 122);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(477, 35);
            txtDaoDien.TabIndex = 6;
            txtDaoDien.UseVisualStyleBackColor = true;
            // 
            // txtNgayChieuPhim
            // 
            txtNgayChieuPhim.Location = new Point(228, 72);
            txtNgayChieuPhim.Name = "txtNgayChieuPhim";
            txtNgayChieuPhim.Size = new Size(477, 35);
            txtNgayChieuPhim.TabIndex = 5;
            txtNgayChieuPhim.UseVisualStyleBackColor = true;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Location = new Point(228, 26);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(477, 35);
            txtTenPhim.TabIndex = 4;
            txtTenPhim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 178);
            label6.Name = "label6";
            label6.Size = new Size(157, 31);
            label6.TabIndex = 3;
            label6.Text = "Thể Loại Phim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 129);
            label5.Name = "label5";
            label5.Size = new Size(108, 31);
            label5.TabIndex = 2;
            label5.Text = "Đạo Diễn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 79);
            label4.Name = "label4";
            label4.Size = new Size(188, 31);
            label4.TabIndex = 1;
            label4.Text = "Ngày chiếu phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 32);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 0;
            label3.Text = "Phim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvPhim);
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 224);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục phim";
            // 
            // lsvPhim
            // 
            lsvPhim.Dock = DockStyle.Fill;
            lsvPhim.Location = new Point(3, 39);
            lsvPhim.Name = "lsvPhim";
            lsvPhim.Size = new Size(730, 182);
            lsvPhim.TabIndex = 0;
            lsvPhim.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(792, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(36, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(36, 134);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(154, 32);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(36, 96);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(154, 32);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(36, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 32);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(36, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(792, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phim);
            groupBox4.Controls.Add(txtTimKiemPhim);
            groupBox4.Location = new Point(3, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 125);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(58, 36);
            phim.Name = "phim";
            phim.Size = new Size(108, 20);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm phim";
            // 
            // txtTimKiemPhim
            // 
            txtTimKiemPhim.Location = new Point(6, 70);
            txtTimKiemPhim.Name = "txtTimKiemPhim";
            txtTimKiemPhim.Size = new Size(203, 40);
            txtTimKiemPhim.TabIndex = 1;
            txtTimKiemPhim.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTongSoPhim);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 36);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 1;
            label7.Text = "Tổng số phim";
            // 
            // txtTongSoPhim
            // 
            txtTongSoPhim.Location = new Point(6, 70);
            txtTongSoPhim.Name = "txtTongSoPhim";
            txtTongSoPhim.Size = new Size(203, 40);
            txtTongSoPhim.TabIndex = 0;
            txtTongSoPhim.UseVisualStyleBackColor = true;
            // 
            // FQuanLyVeXemPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 578);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FQuanLyVeXemPhim";
            Text = "FQuanLyVeXemPhim";
            Load += FQuanLyVeXemPhim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private Button txtTheLoaiPhim;
        private Button txtDaoDien;
        private Button txtNgayChieuPhim;
        private Button txtTenPhim;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lsvPhim;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label phim;
        private Button txtTimKiemPhim;
        private Label label7;
        private Button txtTongSoPhim;
    }
}