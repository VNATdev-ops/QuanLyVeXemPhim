namespace QuanLyVeXemPhim.Views
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            panel_Left = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel_Top = new Panel();
            label1 = new Label();
            splitContainer_Body = new Panel();
            panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = SystemColors.ControlLight;
            panel_Left.Controls.Add(pictureBox1);
            panel_Left.Controls.Add(panel2);
            panel_Left.Controls.Add(button7);
            panel_Left.Controls.Add(button6);
            panel_Left.Controls.Add(button5);
            panel_Left.Controls.Add(button4);
            panel_Left.Controls.Add(button3);
            panel_Left.Controls.Add(button2);
            panel_Left.Controls.Add(button1);
            panel_Left.Location = new Point(7, 18);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(279, 817);
            panel_Left.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(278, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 757);
            panel2.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(3, 632);
            button7.Name = "button7";
            button7.Size = new Size(273, 67);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 559);
            button6.Name = "button6";
            button6.Size = new Size(273, 67);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 486);
            button5.Name = "button5";
            button5.Size = new Size(273, 67);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 413);
            button4.Name = "button4";
            button4.Size = new Size(273, 67);
            button4.TabIndex = 5;
            button4.Text = "Chọn Suất";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 340);
            button3.Name = "button3";
            button3.Size = new Size(273, 67);
            button3.TabIndex = 4;
            button3.Text = "Lịch Sử tích điểm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 267);
            button2.Name = "button2";
            button2.Size = new Size(273, 67);
            button2.TabIndex = 3;
            button2.Text = "Vé Xem Phim";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 194);
            button1.Name = "button1";
            button1.Size = new Size(273, 67);
            button1.TabIndex = 2;
            button1.Text = "Quản lý thành viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = SystemColors.ControlLight;
            panel_Top.Controls.Add(label1);
            panel_Top.Location = new Point(288, 18);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(323, 63);
            panel_Top.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // splitContainer_Body
            // 
            splitContainer_Body.Location = new Point(292, 87);
            splitContainer_Body.Name = "splitContainer_Body";
            splitContainer_Body.Size = new Size(1654, 748);
            splitContainer_Body.TabIndex = 2;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2080, 937);
            Controls.Add(splitContainer_Body);
            Controls.Add(panel_Top);
            Controls.Add(panel_Left);
            Name = "fAdmin";
            Text = "fAdmin";
            Load += fAdmin_Load;
            panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Left;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel_Top;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel splitContainer_Body;
    }
}