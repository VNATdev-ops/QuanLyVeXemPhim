using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
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
    public partial class FQuanLyVeXemPhim : Form
    {
        CtrlPhim ctrPhim = new CtrlPhim();
        List<CPhim> dsPhim = new List<CPhim>();

        public FQuanLyVeXemPhim()
        {
            InitializeComponent();

            int width = lsvPhim.Width;
            lsvPhim.Columns.Add("Mã phim", 20 * width / 100);
            lsvPhim.Columns.Add("Tên phim", 20 * width / 100);
            lsvPhim.Columns.Add("Ngày chiếu phim", 20 * width / 100);
            lsvPhim.Columns.Add("Đạo diễn", 20 * width / 100);
            lsvPhim.Columns.Add("Thể loại phim", 20 * width / 100);


            lsvPhim.View = View.Details;
            lsvPhim.FullRowSelect = true;
        }

        private void FQuanLyVeXemPhim_Load(object sender, EventArgs e)
        {
            dsPhim = ctrPhim.findAll();
            foreach (CPhim s in dsPhim)
            {
                string[] obj = { s.TenPhim, s.DaoDien, s.TheLoaiPhim, s.PhimID + "" };
                ListViewItem item = new ListViewItem(obj);
                lsvPhim.Items.Add(item);
            }
            txtTongSoPhim.Text = dsPhim.Count + "";
        }
    }
}
