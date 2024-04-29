namespace QuanLyVeXemPhim.Views
{
    partial class FPhim
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
            lblTenPhim = new Label();
            lblTheLoai = new Label();
            lblDaoDien = new Label();
            txtTenPhim = new TextBox();
            groupBox1 = new GroupBox();
            cbDinhDang = new ComboBox();
            cbTrangThai = new ComboBox();
            dtNgayPH = new DateTimePicker();
            txtDaoDien = new TextBox();
            txtTheLoai = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblNgayPH = new Label();
            groupBox2 = new GroupBox();
            lsvDSPhim = new ListView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 64);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHIM";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Location = new Point(47, 58);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(84, 25);
            lblTenPhim.TabIndex = 1;
            lblTenPhim.Text = "Tên phim";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Location = new Point(47, 105);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(73, 25);
            lblTheLoai.TabIndex = 1;
            lblTheLoai.Text = "Thể loại";
            // 
            // lblDaoDien
            // 
            lblDaoDien.AutoSize = true;
            lblDaoDien.Location = new Point(47, 155);
            lblDaoDien.Name = "lblDaoDien";
            lblDaoDien.Size = new Size(84, 25);
            lblDaoDien.TabIndex = 1;
            lblDaoDien.Text = "Đạo diễn";
            // 
            // txtTenPhim
            // 
            txtTenPhim.Location = new Point(210, 52);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(804, 31);
            txtTenPhim.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(cbDinhDang);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(dtNgayPH);
            groupBox1.Controls.Add(txtDaoDien);
            groupBox1.Controls.Add(txtTheLoai);
            groupBox1.Controls.Add(txtTenPhim);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblTheLoai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblNgayPH);
            groupBox1.Controls.Add(lblDaoDien);
            groupBox1.Controls.Add(lblTenPhim);
            groupBox1.Location = new Point(33, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1069, 554);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // cbDinhDang
            // 
            cbDinhDang.FormattingEnabled = true;
            cbDinhDang.Location = new Point(838, 252);
            cbDinhDang.Name = "cbDinhDang";
            cbDinhDang.Size = new Size(176, 33);
            cbDinhDang.TabIndex = 6;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(210, 252);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(390, 33);
            cbTrangThai.TabIndex = 6;
            // 
            // dtNgayPH
            // 
            dtNgayPH.Location = new Point(210, 202);
            dtNgayPH.Name = "dtNgayPH";
            dtNgayPH.Size = new Size(390, 31);
            dtNgayPH.TabIndex = 5;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Location = new Point(210, 149);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(804, 31);
            txtDaoDien.TabIndex = 2;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Location = new Point(210, 99);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(804, 31);
            txtTheLoai.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(714, 260);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 1;
            label9.Text = "Định dạng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 260);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 306);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 1;
            label6.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 208);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 1;
            label7.Text = "Độ dài";
            // 
            // lblNgayPH
            // 
            lblNgayPH.AutoSize = true;
            lblNgayPH.Location = new Point(47, 208);
            lblNgayPH.Name = "lblNgayPH";
            lblNgayPH.Size = new Size(139, 25);
            lblNgayPH.TabIndex = 1;
            lblNgayPH.Text = "Ngày phát hành";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDSPhim);
            groupBox2.Location = new Point(33, 718);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 316);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phim";
            // 
            // lsvDSPhim
            // 
            lsvDSPhim.Location = new Point(51, 35);
            lsvDSPhim.Name = "lsvDSPhim";
            lsvDSPhim.Size = new Size(963, 248);
            lsvDSPhim.TabIndex = 0;
            lsvDSPhim.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(1150, 120);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(527, 150);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "TÌm kiếm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(1150, 292);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(527, 483);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(202, 281);
            button4.Name = "button4";
            button4.Size = new Size(112, 56);
            button4.TabIndex = 0;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(202, 204);
            button3.Name = "button3";
            button3.Size = new Size(112, 56);
            button3.TabIndex = 0;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(202, 125);
            button2.Name = "button2";
            button2.Size = new Size(112, 56);
            button2.TabIndex = 0;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(202, 49);
            button1.Name = "button1";
            button1.Size = new Size(112, 56);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(210, 310);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(804, 206);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // FPhim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1758, 1087);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FPhim";
            Text = "FPhim";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTenPhim;
        private Label lblTheLoai;
        private Label lblDaoDien;
        private TextBox txtTenPhim;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox txtDaoDien;
        private TextBox txtTheLoai;
        private Label label6;
        private Label lblNgayPH;
        private RichTextBox richTextBox1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private GroupBox groupBox2;
        private ListView lsvDSPhim;
        private DateTimePicker dtNgayPH;
        private ComboBox cbDinhDang;
        private ComboBox cbTrangThai;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private RichTextBox richTextBox2;
    }
}