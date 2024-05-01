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
            //dsRapChieuPhim = ctrlRapChieuPhim.findall();
            foreach (CChonSuat s in dsChonSuat)
            {
                string[] obj = { s.Phim.IDPhim, s.Rap.IDRap, s.SuatChieu.IDSuatChieu };
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
                //if (item != null) { return; }
                if (lsvDSCS.SelectedItems.Count == 0)

                chonSuat.Rap.IDRap = item.SubItems[1].Text;
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

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            lsvDSCS.Items.Clear();
            txtTongSo.Text = lsvDSCS.Items.Count.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSCS.SelectedItems[0];
                CChonSuat chonSuat = new CChonSuat();
                chonSuat.Phim.IDPhim = item.SubItems[0].Text;
                int index = dsChonSuat.IndexOf(chonSuat);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                chonSuat = dsChonSuat[index];
                //gọi function kiểm tra dữ liệu hợp lệ
                // cập nhật thông tin
                chonSuat.Phim.IDPhim = txtIDphim.Text;
                chonSuat.Rap.IDRap = txtIDrap.Text;
                chonSuat.SuatChieu.IDSuatChieu = txtIDsuatchieu.Text;
                if (ctrlChonSuat.update(chonSuat))
                {
                    item.SubItems[1].Text = chonSuat.Phim.IDPhim;
                    item.SubItems[2].Text = chonSuat.Rap.IDRap;
                    item.SubItems[3].Text = chonSuat.SuatChieu.IDSuatChieu;
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show(" cập nhật thất bại");
                }
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSCS.SelectedItems[0];
                CChonSuat chonSuat = new CChonSuat();
                chonSuat.Phim.IDPhim = item.SubItems[0].Text;
                int index = dsChonSuat.IndexOf(chonSuat);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                chonSuat = dsChonSuat[index];
                if (ctrlChonSuat.delete(chonSuat))
                {
                    dsChonSuat.Remove(chonSuat);
                    lsvDSCS.Items.RemoveAt(index);
                    txtTongSo.Text = lsvDSCS.Items.Count.ToString();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại.");

                }
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string maPhim = txtIDphim.Text;
                string maRap = txtIDrap.Text;
                string maSuatChieu = txtIDsuatchieu.Text;
                // Tạo các đối tượng phim, rạp và suất chiếu
                CPhim phim = new CPhim();
                phim.IDPhim = maPhim;

                CRapChieuPhim rap = new CRapChieuPhim();
                rap.IDRap = maRap;

                CSuatChieu suatChieu = new CSuatChieu();
                suatChieu.IDSuatChieu = maSuatChieu;

                // Khởi tạo đối tượng ChonSuat với các đối tượng đã tạo
                CChonSuat s = new CChonSuat(phim, rap, suatChieu);
                //CChonSuat s = new CChonSuat (maPhim, maRap, maSuatChieu);
                if (ctrlChonSuat.insert(s))
                {
                    string[] objsp = { maPhim, maRap, maSuatChieu };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvDSCS.Items.Add(item);
                    dsChonSuat.Add(s);
                    txtTongSo.Text = lsvDSCS.Items.Count.ToString();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch { }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkTim = txtTimKiem.Text;
                dsChonSuat = ctrlChonSuat.findCriteria(dkTim);
                //xóa lsv
                lsvDSCS.Items.Clear();
                foreach (CChonSuat s in dsChonSuat)
                {
                    string[] obj = { s.Phim.IDPhim, s.Rap.IDRap, s.SuatChieu.IDSuatChieu };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSCS.Items.Add(item);
                }
                txtTongSo.Text = lsvDSCS.Items.Count.ToString();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
