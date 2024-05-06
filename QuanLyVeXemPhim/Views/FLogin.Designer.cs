namespace QuanLyVeXemPhim.Views
{
    partial class FLogin
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
            btnDangNhap = new Button();
            panel1 = new Panel();
            btnThoat = new Button();
            panel3 = new Panel();
            txtMatKhau = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtDangNhap = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(649, 143);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 186);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(752, 143);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 64);
            panel3.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(191, 16);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(609, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDangNhap);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 64);
            panel2.TabIndex = 0;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(191, 16);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(609, 27);
            txtDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 9);
            label3.Name = "label3";
            label3.Size = new Size(166, 38);
            label3.TabIndex = 2;
            label3.Text = "Đăng Nhập";
            // 
            // FLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = btnThoat;
            ClientSize = new Size(868, 248);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLogin";
            FormClosing += FLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private Panel panel1;
        private Button btnThoat;
        private Panel panel3;
        private TextBox txtMatKhau;
        private Label label2;
        private Panel panel2;
        private TextBox txtDangNhap;
        private Label label1;
        private Label label3;
    }
}