using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FVeXemPhim : Form
    {
        CtrlVeXemPhim ctrlVeXemPhim = new CtrlVeXemPhim();
        CtrlThanhVien ctrlThanhVien = new CtrlThanhVien();
        CtrlPhim ctrPhim = new CtrlPhim();
        CtrlSuatChieu ctrSuatChieu = new CtrlSuatChieu();
        CtrlChoNgoi ctrlChoNgoi = new CtrlChoNgoi();

        List<CVeXemPhim> dsVeXemPhim = new List<CVeXemPhim>();
        public FVeXemPhim()
        {
            InitializeComponent();
            int width = lsvVeXemPhim.Width;
            lsvVeXemPhim.Columns.Add("Mã vé", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã suất chiếu", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã chỗ ngồi", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Tình trạng", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Giá vé", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã thành viên", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã phim", 14 * width / 100);


            lsvVeXemPhim.View = View.Details;
            lsvVeXemPhim.FullRowSelect = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FVeXemPhim_Load(object sender, EventArgs e)
        {
            dsVeXemPhim = ctrlVeXemPhim.findall();
            foreach (CVeXemPhim s in dsVeXemPhim)
            {
                string[] obj = { s.IDVe, s.ThanhVien.TenThanhVien, s.Phim.IDPhim, s.SuatChieu.IDSuatChieu, s.ChoNgoi.IDChoNgoi, s.GiaVe + "", s.TinhTrang };
                ListViewItem item = new ListViewItem(obj);
                lsvVeXemPhim.Items.Add(item);
            }
            txtTongSo.Text = lsvVeXemPhim.Items.Count.ToString();

        }
    }
}
