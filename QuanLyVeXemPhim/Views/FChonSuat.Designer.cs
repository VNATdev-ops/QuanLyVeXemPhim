﻿namespace QuanLyVeXemPhim.Views
{
    partial class FChonSuat
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDphim = new Button();
            txtIDrap = new Button();
            txtIDsuatchieu = new Button();
            listView1 = new ListView();
            label4 = new Label();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(794, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 271);
            panel2.TabIndex = 11;
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
            phim.Location = new Point(43, 44);
            phim.Name = "phim";
            phim.Size = new Size(132, 23);
            phim.TabIndex = 2;
            phim.Text = "Tìm kiếm lịch sử";
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
            panel1.Location = new Point(794, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 224);
            panel1.TabIndex = 10;
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(txtIDsuatchieu);
            groupBox1.Controls.Add(txtIDrap);
            groupBox1.Controls.Add(txtIDphim);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 204);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chọn suất";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 268);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục chọn suất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(44, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Rạp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(44, 163);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 2;
            label3.Text = "ID Suất chiếu";
            // 
            // txtIDphim
            // 
            txtIDphim.Location = new Point(175, 33);
            txtIDphim.Name = "txtIDphim";
            txtIDphim.Size = new Size(264, 45);
            txtIDphim.TabIndex = 3;
            txtIDphim.UseVisualStyleBackColor = true;
            // 
            // txtIDrap
            // 
            txtIDrap.Location = new Point(175, 87);
            txtIDrap.Name = "txtIDrap";
            txtIDrap.Size = new Size(264, 45);
            txtIDrap.TabIndex = 4;
            txtIDrap.UseVisualStyleBackColor = true;
            // 
            // txtIDsuatchieu
            // 
            txtIDsuatchieu.Location = new Point(175, 143);
            txtIDsuatchieu.Name = "txtIDsuatchieu";
            txtIDsuatchieu.Size = new Size(264, 45);
            txtIDsuatchieu.TabIndex = 5;
            txtIDsuatchieu.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(770, 242);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(359, 23);
            label4.Name = "label4";
            label4.Size = new Size(197, 31);
            label4.TabIndex = 14;
            label4.Text = "Quản lý chọn suất";
            // 
            // FChonSuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 580);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FChonSuat";
            Text = "FChonSuat";
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private GroupBox groupBox1;
        private Button txtIDsuatchieu;
        private Button txtIDrap;
        private Button txtIDphim;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Label label4;
    }
}