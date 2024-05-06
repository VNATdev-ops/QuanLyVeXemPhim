using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;

        private void OpenChildForm(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;

            splitContainer_Body.Controls.Add(childFrom);
            splitContainer_Body.Tag = childFrom;
            childFrom.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FThanhVien());

            // Cập nhật label nếu cần
            label1.Text = "Quản lý vé xem phim";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FVeXemPhim());
            label1.Text = button2.Text;

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuTichDiem());
            label1.Text = button3.Text;
        }

        private void lịchSửTíchĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuTichDiem());
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThanhVien());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FChonSuat());
            label1.Text = button3.Text;
        }
    }
}
