namespace QuanLyVeXemPhim.Views
{
    partial class FVeXemPhim
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            s = new GroupBox();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            phim = new Label();
            txtTimKiem = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            txtTongSo = new Button();
            txtIDsuatchieu = new Button();
            txtIDchongoi = new Button();
            label6 = new Label();
            txtIDve = new Button();
            txtGiaVe = new Button();
            txtIDnguoidung = new Button();
            txtIDphim = new Button();
            lsvVeXemPhim = new ListView();
            label8 = new Label();
            groupBox1.SuspendLayout();
            s.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIDphim);
            groupBox1.Controls.Add(txtIDnguoidung);
            groupBox1.Controls.Add(txtGiaVe);
            groupBox1.Controls.Add(txtIDve);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIDchongoi);
            groupBox1.Controls.Add(txtIDsuatchieu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vé xem phim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(350, 121);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 4;
            label5.Text = "ID Người Dùng";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(350, 61);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 3;
            label4.Text = "Giá Vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 175);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 2;
            label3.Text = "ID Chỗ Ngồi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 121);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 1;
            label2.Text = "ID Suất Chiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Vé";
            label1.Click += label1_Click;
            // 
            // s
            // 
            s.Controls.Add(lsvVeXemPhim);
            s.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s.Location = new Point(12, 309);
            s.Name = "s";
            s.Size = new Size(878, 228);
            s.TabIndex = 1;
            s.TabStop = false;
            s.Text = "Danh Sách Vé Xem Phim";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(946, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 5;
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
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(946, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 6;
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
            phim.Location = new Point(58, 36);
            phim.Name = "phim";
            phim.Size = new Size(89, 20);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm vé";
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
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTongSo);
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
            label7.Size = new Size(81, 20);
            label7.TabIndex = 1;
            label7.Text = "Tổng số vé";
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(6, 70);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(203, 40);
            txtTongSo.TabIndex = 0;
            txtTongSo.UseVisualStyleBackColor = true;
            // 
            // txtIDsuatchieu
            // 
            txtIDsuatchieu.Font = new Font("Segoe UI", 12F);
            txtIDsuatchieu.Location = new Point(170, 110);
            txtIDsuatchieu.Name = "txtIDsuatchieu";
            txtIDsuatchieu.Size = new Size(143, 50);
            txtIDsuatchieu.TabIndex = 6;
            txtIDsuatchieu.UseVisualStyleBackColor = true;
            // 
            // txtIDchongoi
            // 
            txtIDchongoi.Font = new Font("Segoe UI", 12F);
            txtIDchongoi.Location = new Point(170, 174);
            txtIDchongoi.Name = "txtIDchongoi";
            txtIDchongoi.Size = new Size(143, 48);
            txtIDchongoi.TabIndex = 7;
            txtIDchongoi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(350, 180);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 10;
            label6.Text = "ID Phim";
            label6.Click += label6_Click;
            // 
            // txtIDve
            // 
            txtIDve.Font = new Font("Segoe UI", 12F);
            txtIDve.Location = new Point(170, 50);
            txtIDve.Name = "txtIDve";
            txtIDve.Size = new Size(143, 50);
            txtIDve.TabIndex = 11;
            txtIDve.UseVisualStyleBackColor = true;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Font = new Font("Segoe UI", 12F);
            txtGiaVe.Location = new Point(523, 50);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(226, 50);
            txtGiaVe.TabIndex = 12;
            txtGiaVe.UseVisualStyleBackColor = true;
            // 
            // txtIDnguoidung
            // 
            txtIDnguoidung.Font = new Font("Segoe UI", 12F);
            txtIDnguoidung.Location = new Point(523, 110);
            txtIDnguoidung.Name = "txtIDnguoidung";
            txtIDnguoidung.Size = new Size(226, 50);
            txtIDnguoidung.TabIndex = 13;
            txtIDnguoidung.UseVisualStyleBackColor = true;
            // 
            // txtIDphim
            // 
            txtIDphim.Font = new Font("Segoe UI", 12F);
            txtIDphim.Location = new Point(523, 169);
            txtIDphim.Name = "txtIDphim";
            txtIDphim.Size = new Size(226, 50);
            txtIDphim.TabIndex = 14;
            txtIDphim.UseVisualStyleBackColor = true;
            // 
            // lsvVeXemPhim
            // 
            lsvVeXemPhim.Dock = DockStyle.Fill;
            lsvVeXemPhim.Location = new Point(3, 30);
            lsvVeXemPhim.Name = "lsvVeXemPhim";
            lsvVeXemPhim.Size = new Size(872, 195);
            lsvVeXemPhim.TabIndex = 0;
            lsvVeXemPhim.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(395, 13);
            label8.Name = "label8";
            label8.Size = new Size(286, 38);
            label8.TabIndex = 7;
            label8.Text = "Quản lý Vé Xem Phim";
            // 
            // FVeXemPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 560);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(s);
            Controls.Add(groupBox1);
            Name = "FVeXemPhim";
            Text = "FVeXemPhim";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            s.ResumeLayout(false);
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

        private GroupBox groupBox1;
        private GroupBox s;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private Button txtTimKiem;
        private GroupBox groupBox3;
        private Label label7;
        private Button txtTongSo;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button txtIDchongoi;
        private Button txtIDsuatchieu;
        private Button txtIDve;
        private Label label6;
        private Button txtIDphim;
        private Button txtIDnguoidung;
        private Button txtGiaVe;
        private ListView lsvVeXemPhim;
        private Label label8;
    }
}