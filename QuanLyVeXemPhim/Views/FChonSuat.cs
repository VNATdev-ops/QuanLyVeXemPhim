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
    public partial class FChonSuat : Form
    {
        CtrlChonSuat ctrlChonSuat = new CtrlChonSuat();
        List<CChonSuat> dsChonSuat = new List<CChonSuat>();
        public FChonSuat()
        {
            InitializeComponent();
            int width = lsvDSCS.Width;
            lsvDSCS.Columns.Add("Mã phim", 33 * width / 100);
            lsvDSCS.Columns.Add("Mã rạp", 33 * width / 100);
            lsvDSCS.Columns.Add("Mã suất chiếu", 33 * width / 100);

            lsvDSCS.View = View.Details;
            lsvDSCS.FullRowSelect = true;
        }

        private void FChonSuat_Load(object sender, EventArgs e)
        {
            dsChonSuat = ctrlChonSuat.findall();
            foreach (CChonSuat s in dsChonSuat)
            {
                string[] obj = { s.Rap.IDRap, s.Rap.IDRap, s.SuatChieu.IDSuatChieu };
                ListViewItem item = new ListViewItem(obj);
                lsvDSCS.Items.Add(item);
            }
            txtTongSo.Text = lsvDSCS.Items.Count.ToString();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void lsvDSCS_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ListViewItem item = lsvDSCS.SelectedItems[0];
                CChonSuat chonSuat = new CChonSuat();
                chonSuat.Rap.IDRap = item.SubItems[0].Text;
                int index = dsChonSuat.IndexOf(chonSuat);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                chonSuat = dsChonSuat[index];

                txtIDphim.Text = chonSuat.Phim.IDPhim;
                txtIDrap.Text = chonSuat.Rap.IDRap;
                txtIDsuatchieu.Text = chonSuat.SuatChieu.IDSuatChieu;
            }
            catch { }
        }
    }
}
