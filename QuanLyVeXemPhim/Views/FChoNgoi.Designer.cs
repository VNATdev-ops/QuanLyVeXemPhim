namespace QuanLyVeXemPhim.Views
{
    partial class FChoNgoi
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            phim = new Label();
            txtTimKiem = new Button();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtTongSo = new Button();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIDchongoi = new Button();
            txtIDphong = new Button();
            txtLoaiChoNgoi = new Button();
            txtVitri = new Button();
            txtTrangThai = new Button();
            lsvDanhSach = new ListView();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTrangThai);
            groupBox1.Controls.Add(txtVitri);
            groupBox1.Controls.Add(txtLoaiChoNgoi);
            groupBox1.Controls.Add(txtIDphong);
            groupBox1.Controls.Add(txtIDchongoi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chỗ ngồi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSach);
            groupBox2.Location = new Point(12, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(646, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chỗ ngồi";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(676, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 14;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phim);
            groupBox4.Controls.Add(txtTimKiem);
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
            phim.Location = new Point(33, 44);
            phim.Name = "phim";
            phim.Size = new Size(151, 23);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm chỗ ngồi";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 70);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(203, 40);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 44);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(6, 70);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(203, 40);
            txtTongSo.TabIndex = 0;
            txtTongSo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(676, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 13;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(35, 45);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "ID chỗ ngồi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(35, 103);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "ID phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(35, 172);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Loại chỗ ngồi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(338, 176);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(338, 52);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 4;
            label5.Text = "Vị trí";
            // 
            // txtIDchongoi
            // 
            txtIDchongoi.Location = new Point(157, 37);
            txtIDchongoi.Name = "txtIDchongoi";
            txtIDchongoi.Size = new Size(148, 40);
            txtIDchongoi.TabIndex = 5;
            txtIDchongoi.UseVisualStyleBackColor = true;
            // 
            // txtIDphong
            // 
            txtIDphong.Location = new Point(157, 96);
            txtIDphong.Name = "txtIDphong";
            txtIDphong.Size = new Size(424, 40);
            txtIDphong.TabIndex = 6;
            txtIDphong.UseVisualStyleBackColor = true;
            // 
            // txtLoaiChoNgoi
            // 
            txtLoaiChoNgoi.Location = new Point(157, 164);
            txtLoaiChoNgoi.Name = "txtLoaiChoNgoi";
            txtLoaiChoNgoi.Size = new Size(148, 40);
            txtLoaiChoNgoi.TabIndex = 7;
            txtLoaiChoNgoi.UseVisualStyleBackColor = true;
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(433, 37);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(148, 40);
            txtVitri.TabIndex = 8;
            txtVitri.UseVisualStyleBackColor = true;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(433, 164);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(148, 40);
            txtTrangThai.TabIndex = 9;
            txtTrangThai.UseVisualStyleBackColor = true;
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Dock = DockStyle.Fill;
            lsvDanhSach.Location = new Point(3, 23);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(640, 245);
            lsvDanhSach.TabIndex = 0;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(332, 20);
            label6.Name = "label6";
            label6.Size = new Size(161, 28);
            label6.TabIndex = 15;
            label6.Text = "Quản lý chỗ ngồi";
            // 
            // FChoNgoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 582);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FChoNgoi";
            Text = "FChoNgoi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button txtTrangThai;
        private Button txtVitri;
        private Button txtLoaiChoNgoi;
        private Button txtIDphong;
        private Button txtIDchongoi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private Button txtTimKiem;
        private GroupBox groupBox3;
        private Label label9;
        private Button txtTongSo;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ListView lsvDanhSach;
        private Label label6;
    }
}