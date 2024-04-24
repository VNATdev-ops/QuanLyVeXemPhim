namespace QuanLyVeXemPhim.Views
{
    partial class FNguoiDung
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtIDNguoiDung = new Button();
            this.txtTen = new Button();
            this.txtMatKhau = new Button();
            this.txtNgaySinh = new Button();
            this.txtGioiTinh = new Button();
            this.txtKhuVuc = new Button();
            this.txtEmail = new Button();
            this.txtLoaiTaiKhoan = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.txtLoaiTaiKhoan);
            groupBox1.Controls.Add(this.txtEmail);
            groupBox1.Controls.Add(this.txtKhuVuc);
            groupBox1.Controls.Add(this.txtGioiTinh);
            groupBox1.Controls.Add(this.txtNgaySinh);
            groupBox1.Controls.Add(this.txtMatKhau);
            groupBox1.Controls.Add(this.txtTen);
            groupBox1.Controls.Add(txtIDNguoiDung);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Người Dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 188);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 44);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 92);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 5;
            label6.Text = "Khu vực";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 140);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(494, 188);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 7;
            label8.Text = "Loại tài khoản";
            // 
            // txtIDNguoiDung
            // 
            txtIDNguoiDung.Location = new Point(205, 38);
            txtIDNguoiDung.Name = "txtIDNguoiDung";
            txtIDNguoiDung.Size = new Size(256, 40);
            txtIDNguoiDung.TabIndex = 8;
            txtIDNguoiDung.UseVisualStyleBackColor = true;
            txtIDNguoiDung.Click += button1_Click;
            // 
            // txtTen
            // 
            this.txtTen.Location = new Point(205, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new Size(256, 40);
            this.txtTen.TabIndex = 9;
            this.txtTen.UseVisualStyleBackColor = true;
            this.txtTen.Click += this.button2_Click;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new Point(205, 134);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new Size(256, 40);
            this.txtMatKhau.TabIndex = 10;
            this.txtMatKhau.UseVisualStyleBackColor = true;
            this.txtMatKhau.Click += this.button3_Click;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new Point(205, 182);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new Size(256, 40);
            this.txtNgaySinh.TabIndex = 11;
            this.txtNgaySinh.UseVisualStyleBackColor = true;
            this.txtNgaySinh.Click += this.button4_Click;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new Point(647, 38);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new Size(256, 40);
            this.txtGioiTinh.TabIndex = 12;
            this.txtGioiTinh.UseVisualStyleBackColor = true;
            this.txtGioiTinh.Click += this.button5_Click;
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new Point(647, 86);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new Size(256, 40);
            this.txtKhuVuc.TabIndex = 13;
            this.txtKhuVuc.UseVisualStyleBackColor = true;
            this.txtKhuVuc.Click += this.button6_Click;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(647, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(256, 40);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.UseVisualStyleBackColor = true;
            this.txtEmail.Click += this.button7_Click;
            // 
            // txtLoaiTaiKhoan
            // 
            this.txtLoaiTaiKhoan.Location = new Point(647, 180);
            this.txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            this.txtLoaiTaiKhoan.Size = new Size(256, 40);
            this.txtLoaiTaiKhoan.TabIndex = 15;
            this.txtLoaiTaiKhoan.UseVisualStyleBackColor = true;
            this.txtLoaiTaiKhoan.Click += this.button8_Click;
            // 
            // FNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 450);
            Controls.Add(groupBox1);
            Name = "FNguoiDung";
            Text = "FNguoiDung";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button txtIDNguoiDung;
    }
}