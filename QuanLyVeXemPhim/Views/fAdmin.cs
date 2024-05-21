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


        private void btnThanhVien_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FThanhVien());

            // Cập nhật label nếu cần
            //label1.Text = "Quản lý vé xem phim";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            //label1.Text = "";
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FVeXemPhim());
            //label1.Text = button2.Text;

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPhim());
            //label1.Text = button3.Text;
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThanhVien());

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FSanPham());
            //label1.Text = button3.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanVien());
        }

        private void btnSuatChieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FSuatChieu());
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPhongChieu());
        }

        private void btnChoNgoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FChoNgoi());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FHoaDon());
        }

        private void btnRapChieuPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRapChieuPhim());
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
