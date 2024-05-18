namespace QuanLyVeXemPhim.Views
{
    partial class FSuatChieu
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
            phim = new Label();
            txtTimKiem = new TextBox();
            txtTongSo = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dtThoiGianChieu = new DateTimePicker();
            cmbTrangThai = new ComboBox();
            cmbPhong = new ComboBox();
            cmbRap = new ComboBox();
            cmbPhim = new ComboBox();
            txtSoLuongConLai = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            lsvSuatChieu = new ListView();
            lblTrangThai = new Label();
            lblSoLuongConLai = new Label();
            lblIDPhong = new Label();
            txtSoLuongVe = new TextBox();
            txtIDSuatChieu = new TextBox();
            lblIDRap = new Label();
            lblThoiGianChieu = new Label();
            lblIDPhim = new Label();
            lblIDSuatChieu = new Label();
            groupBox1 = new GroupBox();
            lblSoLuongVe = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
            btnNhapMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // phim
            // 
            phim.AutoSize = true;
            phim.Font = new Font("Microsoft Sans Serif", 10F);
            phim.Location = new Point(49, 54);
            phim.Margin = new Padding(4, 0, 4, 0);
            phim.Name = "phim";
            phim.Size = new Size(91, 25);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10F);
            txtTimKiem.Location = new Point(182, 46);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1105, 30);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // txtTongSo
            // 
            txtTongSo.Font = new Font("Microsoft Sans Serif", 10F);
            txtTongSo.Location = new Point(31, 89);
            txtTongSo.Margin = new Padding(4);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.ReadOnly = true;
            txtTongSo.Size = new Size(239, 30);
            txtTongSo.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.Location = new Point(111, 50);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 1;
            label9.Text = "Tổng số ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSo);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.Location = new Point(62, 675);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(295, 149);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // dtThoiGianChieu
            // 
            dtThoiGianChieu.CustomFormat = "HH:mm dd/MM/yyyy";
            dtThoiGianChieu.Font = new Font("Microsoft Sans Serif", 10F);
            dtThoiGianChieu.Location = new Point(230, 291);
            dtThoiGianChieu.Name = "dtThoiGianChieu";
            dtThoiGianChieu.Size = new Size(517, 30);
            dtThoiGianChieu.TabIndex = 17;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.Font = new Font("Microsoft Sans Serif", 10F);
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Location = new Point(1009, 170);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(278, 33);
            cmbTrangThai.TabIndex = 16;
            // 
            // cmbPhong
            // 
            cmbPhong.Font = new Font("Microsoft Sans Serif", 10F);
            cmbPhong.FormattingEnabled = true;
            cmbPhong.Location = new Point(230, 232);
            cmbPhong.Name = "cmbPhong";
            cmbPhong.Size = new Size(517, 33);
            cmbPhong.TabIndex = 16;
            // 
            // cmbRap
            // 
            cmbRap.Font = new Font("Microsoft Sans Serif", 10F);
            cmbRap.FormattingEnabled = true;
            cmbRap.Location = new Point(230, 170);
            cmbRap.Name = "cmbRap";
            cmbRap.Size = new Size(517, 33);
            cmbRap.TabIndex = 16;
            // 
            // cmbPhim
            // 
            cmbPhim.Font = new Font("Microsoft Sans Serif", 10F);
            cmbPhim.FormattingEnabled = true;
            cmbPhim.Location = new Point(230, 112);
            cmbPhim.Name = "cmbPhim";
            cmbPhim.Size = new Size(517, 33);
            cmbPhim.TabIndex = 16;
            // 
            // txtSoLuongConLai
            // 
            txtSoLuongConLai.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongConLai.Location = new Point(1009, 112);
            txtSoLuongConLai.Margin = new Padding(4);
            txtSoLuongConLai.Name = "txtSoLuongConLai";
            txtSoLuongConLai.Size = new Size(278, 30);
            txtSoLuongConLai.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label6.Location = new Point(73, 74);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(557, 55);
            label6.TabIndex = 21;
            label6.Text = "QUẢN LÝ SUẤT CHIẾU";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(lsvSuatChieu);
            groupBox2.Controls.Add(phim);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(74, 651);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1340, 476);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách suất chiếu";
            // 
            // lsvSuatChieu
            // 
            lsvSuatChieu.Font = new Font("Microsoft Sans Serif", 10F);
            lsvSuatChieu.Location = new Point(0, 114);
            lsvSuatChieu.Name = "lsvSuatChieu";
            lsvSuatChieu.Size = new Size(1340, 362);
            lsvSuatChieu.TabIndex = 0;
            lsvSuatChieu.UseCompatibleStateImageBehavior = false;
            lsvSuatChieu.SelectedIndexChanged += lsvSuatChieu_SelectedIndexChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 10F);
            lblTrangThai.Location = new Point(826, 179);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 25);
            lblTrangThai.TabIndex = 13;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblSoLuongConLai
            // 
            lblSoLuongConLai.AutoSize = true;
            lblSoLuongConLai.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongConLai.Location = new Point(826, 121);
            lblSoLuongConLai.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongConLai.Name = "lblSoLuongConLai";
            lblSoLuongConLai.Size = new Size(151, 25);
            lblSoLuongConLai.TabIndex = 12;
            lblSoLuongConLai.Text = "Số lượng còn lại";
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDPhong.Location = new Point(58, 241);
            lblIDPhong.Margin = new Padding(4, 0, 4, 0);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(69, 25);
            lblIDPhong.TabIndex = 10;
            lblIDPhong.Text = "Phòng";
            // 
            // txtSoLuongVe
            // 
            txtSoLuongVe.Font = new Font("Microsoft Sans Serif", 10F);
            txtSoLuongVe.Location = new Point(1009, 60);
            txtSoLuongVe.Margin = new Padding(4);
            txtSoLuongVe.Name = "txtSoLuongVe";
            txtSoLuongVe.Size = new Size(278, 30);
            txtSoLuongVe.TabIndex = 7;
            // 
            // txtIDSuatChieu
            // 
            txtIDSuatChieu.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDSuatChieu.Location = new Point(230, 56);
            txtIDSuatChieu.Margin = new Padding(4);
            txtIDSuatChieu.Name = "txtIDSuatChieu";
            txtIDSuatChieu.Size = new Size(517, 30);
            txtIDSuatChieu.TabIndex = 5;
            // 
            // lblIDRap
            // 
            lblIDRap.AutoSize = true;
            lblIDRap.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDRap.Location = new Point(58, 179);
            lblIDRap.Margin = new Padding(4, 0, 4, 0);
            lblIDRap.Name = "lblIDRap";
            lblIDRap.Size = new Size(47, 25);
            lblIDRap.TabIndex = 1;
            lblIDRap.Text = "Rạp";
            // 
            // lblThoiGianChieu
            // 
            lblThoiGianChieu.AutoSize = true;
            lblThoiGianChieu.Font = new Font("Microsoft Sans Serif", 10F);
            lblThoiGianChieu.Location = new Point(58, 297);
            lblThoiGianChieu.Margin = new Padding(4, 0, 4, 0);
            lblThoiGianChieu.Name = "lblThoiGianChieu";
            lblThoiGianChieu.Size = new Size(145, 25);
            lblThoiGianChieu.TabIndex = 3;
            lblThoiGianChieu.Text = "Thời gian chiếu";
            // 
            // lblIDPhim
            // 
            lblIDPhim.AutoSize = true;
            lblIDPhim.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDPhim.Location = new Point(58, 121);
            lblIDPhim.Margin = new Padding(4, 0, 4, 0);
            lblIDPhim.Name = "lblIDPhim";
            lblIDPhim.Size = new Size(56, 25);
            lblIDPhim.TabIndex = 2;
            lblIDPhim.Text = "Phim";
            // 
            // lblIDSuatChieu
            // 
            lblIDSuatChieu.AutoSize = true;
            lblIDSuatChieu.Font = new Font("Microsoft Sans Serif", 10F);
            lblIDSuatChieu.Location = new Point(58, 60);
            lblIDSuatChieu.Margin = new Padding(4, 0, 4, 0);
            lblIDSuatChieu.Name = "lblIDSuatChieu";
            lblIDSuatChieu.Size = new Size(129, 25);
            lblIDSuatChieu.TabIndex = 0;
            lblIDSuatChieu.Text = "ID Suất chiếu";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(234, 219, 200);
            groupBox1.Controls.Add(dtThoiGianChieu);
            groupBox1.Controls.Add(cmbTrangThai);
            groupBox1.Controls.Add(cmbPhong);
            groupBox1.Controls.Add(cmbRap);
            groupBox1.Controls.Add(cmbPhim);
            groupBox1.Controls.Add(txtSoLuongConLai);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(lblSoLuongConLai);
            groupBox1.Controls.Add(lblIDPhong);
            groupBox1.Controls.Add(txtSoLuongVe);
            groupBox1.Controls.Add(txtIDSuatChieu);
            groupBox1.Controls.Add(lblIDRap);
            groupBox1.Controls.Add(lblSoLuongVe);
            groupBox1.Controls.Add(lblThoiGianChieu);
            groupBox1.Controls.Add(lblIDPhim);
            groupBox1.Controls.Add(lblIDSuatChieu);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(73, 199);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1340, 412);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin suất chiếu";
            // 
            // lblSoLuongVe
            // 
            lblSoLuongVe.AutoSize = true;
            lblSoLuongVe.Font = new Font("Microsoft Sans Serif", 10F);
            lblSoLuongVe.Location = new Point(826, 64);
            lblSoLuongVe.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongVe.Name = "lblSoLuongVe";
            lblSoLuongVe.Size = new Size(121, 25);
            lblSoLuongVe.TabIndex = 4;
            lblSoLuongVe.Text = "Số lượng vé ";
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
            panel1.Location = new Point(62, 199);
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
            btnXoa.Click += btnXoa_Click;
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
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1454, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 1194);
            panel2.TabIndex = 22;
            // 
            // FSuatChieu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(254, 250, 246);
            ClientSize = new Size(1878, 1194);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1900, 1250);
            Name = "FSuatChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FSuatChieu";
            Load += FSuatChieu_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label phim;
        private TextBox txtTimKiem;
        private TextBox txtTongSo;
        private Label label9;
        private GroupBox groupBox3;
        private DateTimePicker dtThoiGianChieu;
        private ComboBox cmbTrangThai;
        private ComboBox cmbPhong;
        private ComboBox cmbRap;
        private ComboBox cmbPhim;
        private TextBox txtSoLuongConLai;
        private Label label6;
        private GroupBox groupBox2;
        private ListView lsvSuatChieu;
        private Label lblTrangThai;
        private Label lblSoLuongConLai;
        private Label lblIDPhong;
        private TextBox txtSoLuongVe;
        private TextBox txtIDSuatChieu;
        private Label lblIDRap;
        private Label lblThoiGianChieu;
        private Label lblIDPhim;
        private Label lblIDSuatChieu;
        private GroupBox groupBox1;
        private Label lblSoLuongVe;
        private Panel panel1;
        private Button btnThoat;
        private Button btnCapNhat;
        private Button btnNhapMoi;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
    }
}