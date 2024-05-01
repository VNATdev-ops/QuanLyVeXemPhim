namespace QuanLyVeXemPhim.Views
{
    partial class FLichSuTichDiem
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
            txtSoDiemTichLuy = new TextBox();
            txtIDThanhVien = new TextBox();
            txtTongDiemTichLuy = new TextBox();
            txtThoiGianTichLuy = new TextBox();
            txtIDLichSu = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lsvLichSuTichDiem = new ListView();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            txtTimKiem = new TextBox();
            phim = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtTongSo = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoDiemTichLuy);
            groupBox1.Controls.Add(txtIDThanhVien);
            groupBox1.Controls.Add(txtTongDiemTichLuy);
            groupBox1.Controls.Add(txtThoiGianTichLuy);
            groupBox1.Controls.Add(txtIDLichSu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(964, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lịch sử tích điểm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtSoDiemTichLuy
            // 
            txtSoDiemTichLuy.Location = new Point(197, 147);
            txtSoDiemTichLuy.Name = "txtSoDiemTichLuy";
            txtSoDiemTichLuy.Size = new Size(666, 31);
            txtSoDiemTichLuy.TabIndex = 9;
            // 
            // txtIDThanhVien
            // 
            txtIDThanhVien.Location = new Point(617, 94);
            txtIDThanhVien.Name = "txtIDThanhVien";
            txtIDThanhVien.Size = new Size(246, 31);
            txtIDThanhVien.TabIndex = 8;
            // 
            // txtTongDiemTichLuy
            // 
            txtTongDiemTichLuy.Location = new Point(617, 44);
            txtTongDiemTichLuy.Name = "txtTongDiemTichLuy";
            txtTongDiemTichLuy.Size = new Size(246, 31);
            txtTongDiemTichLuy.TabIndex = 7;
            // 
            // txtThoiGianTichLuy
            // 
            txtThoiGianTichLuy.Location = new Point(197, 94);
            txtThoiGianTichLuy.Name = "txtThoiGianTichLuy";
            txtThoiGianTichLuy.Size = new Size(246, 31);
            txtThoiGianTichLuy.TabIndex = 6;
            // 
            // txtIDLichSu
            // 
            txtIDLichSu.Location = new Point(197, 47);
            txtIDLichSu.Name = "txtIDLichSu";
            txtIDLichSu.Size = new Size(246, 31);
            txtIDLichSu.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 153);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Số điểm tích lũy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 50);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 4;
            label5.Text = "Tổng điểm tích lũy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 100);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 3;
            label4.Text = "Mã thành viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 100);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 2;
            label3.Text = "Thời gian tích lũy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã lịch sử";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnNhapMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1009, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 7;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(36, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(36, 134);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(154, 32);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(36, 96);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(154, 32);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(36, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 32);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvLichSuTichDiem);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(964, 210);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lịch sử tích điểm";
            // 
            // lsvLichSuTichDiem
            // 
            lsvLichSuTichDiem.Dock = DockStyle.Fill;
            lsvLichSuTichDiem.Location = new Point(3, 27);
            lsvLichSuTichDiem.Name = "lsvLichSuTichDiem";
            lsvLichSuTichDiem.Size = new Size(958, 180);
            lsvLichSuTichDiem.TabIndex = 0;
            lsvLichSuTichDiem.UseCompatibleStateImageBehavior = false;
            lsvLichSuTichDiem.SelectedIndexChanged += lsvLichSuTichDiem_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1009, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(phim);
            groupBox4.Location = new Point(3, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 125);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(0, 82);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(218, 30);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Location = new Point(43, 44);
            phim.Name = "phim";
            phim.Size = new Size(132, 23);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm lịch sử";
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
            txtTongSo.Click += txtTongSo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(298, 20);
            label6.Name = "label6";
            label6.Size = new Size(225, 28);
            label6.TabIndex = 10;
            label6.Text = "Quản lý lịch sử tích điểm";
            // 
            // FLichSuTichDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 535);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FLichSuTichDiem";
            Text = "FLichSuTichDiem";
            Load += FLichSuTichDiem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private Panel panel2;
        private GroupBox groupBox4;
        private Label phim;
        private GroupBox groupBox3;
        private Label label9;
        private Button txtTongSo;
        private ListView lsvLichSuTichDiem;
        private Label label6;
        private TextBox txtSoDiemTichLuy;
        private TextBox txtIDThanhVien;
        private TextBox txtTongDiemTichLuy;
        private TextBox txtThoiGianTichLuy;
        private TextBox txtIDLichSu;
        private Label label2;
        private TextBox txtTimKiem;
    }
}