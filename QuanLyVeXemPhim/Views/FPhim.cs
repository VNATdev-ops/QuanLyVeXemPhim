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
    public partial class FPhim : Form
    {
        CtrlPhim ctrPhim = new CtrlPhim();
        List<CPhim> dsPhim = new List<CPhim>();
        public FPhim()
        {
            InitializeComponent();
            int width = lsvDSPhim.Width;
            lsvDSPhim.Columns.Add("Mã phim", 5 * width / 100);
            lsvDSPhim.Columns.Add("Tên phim", 20 * width / 100);
            lsvDSPhim.Columns.Add("Thể loại", 8 * width / 100);
            lsvDSPhim.Columns.Add("Đạo diễn", 15 * width / 100);
            lsvDSPhim.Columns.Add("Mô tả", 5 * width / 100);
            lsvDSPhim.Columns.Add("Hình ảnh", 7 * width / 100);
            lsvDSPhim.Columns.Add("Ngày phát hành", 15 * width / 100);
            lsvDSPhim.Columns.Add("Độ dài (phút)", 8 * width / 100);
            lsvDSPhim.Columns.Add("Trạng thái", 10 * width / 100);
            lsvDSPhim.Columns.Add("Định dạng", 7 * width / 100);

            lsvDSPhim.View = View.Details;
            lsvDSPhim.FullRowSelect = true;
        }

        private void CapNhatSoLuongPhim()
        {
            int count = 0;
            foreach (CPhim s in dsPhim)
            {
                if (s.TrangThai == "Đang chiếu")
                    count++;
            }
            txtSoLuongPhim.Text = dsPhim.Count + "";
            txtSoLuongDangChieu.Text = count + "";
        }

        private void FPhim_Load(object sender, EventArgs e)
        {
            dsPhim = ctrPhim.findAll();
            int count = 0;
            foreach (CPhim s in dsPhim)
            {
                string[] obj = {s.IDPhim, s.TenPhim, s.TheLoai, s.DaoDien, s.MoTa,
                s.HinhAnh, s.NgayPH +"", s.DoDai +"", s.TrangThai,s.DinhDang};
                ListViewItem item = new ListViewItem(obj);
                lsvDSPhim.Items.Add(item);
                item.SubItems[0].Text = s.IDPhim;
                item.SubItems[1].Text = s.TenPhim;
                item.SubItems[2].Text = s.TheLoai;
                item.SubItems[3].Text = s.DaoDien;
                item.SubItems[4].Text = s.MoTa;
                item.SubItems[5].Text = s.HinhAnh;
                item.SubItems[6].Text = s.NgayPH.ToString();
                item.SubItems[7].Text = s.DoDai.ToString();
                item.SubItems[8].Text = s.TrangThai;
                item.SubItems[9].Text = s.DinhDang;
            }
            CapNhatSoLuongPhim();

            //combobox
            List<string> dsTrangThai = new List<string> { "Đang chiếu", "Sắp chiếu", "Ngừng chiếu" };
            cbTrangThai.DataSource = dsTrangThai;
            List<string> dsDinhDang = new List<string> { "2D", "3D", "IMAX" };
            cbDinhDang.DataSource = dsDinhDang;

            //txtHinhAnh.Text = "None";
            txtIDPhim.Clear();
            txtIDPhim.Focus();
        }

        private void lsvDSPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSPhim.SelectedItems.Count == 0) { return; }
                ListViewItem item = lsvDSPhim.SelectedItems[0];
                CPhim phim = new CPhim();
                phim.IDPhim = item.SubItems[0].Text;
                int index = dsPhim.IndexOf(phim);
                if (index < 0)
                    return;
                phim = dsPhim[index];

                txtIDPhim.Text = phim.IDPhim;
                txtTenPhim.Text = phim.TenPhim;
                txtTheLoai.Text = phim.TheLoai;
                txtDaoDien.Text = phim.DaoDien;
                rtbMoTa.Text = phim.MoTa;
                txtHinhAnh.Text = phim.HinhAnh ?? "";
                dtNgayPH.Text = phim.NgayPH + "";
                txtDoDai.Text = phim.DoDai + "";
                cbTrangThai.Text = phim.TrangThai;
                cbDinhDang.Text = phim.DinhDang;
                CapNhatSoLuongPhim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idphim = txtIDPhim.Text;
                string tenphim = txtTenPhim.Text;
                string theloai = txtTheLoai.Text;
                string daodien = txtDaoDien.Text;
                string mota = rtbMoTa.Text;
                string? hinhanh = txtHinhAnh.Text ?? null;
                DateTime ngayphathanh = dtNgayPH.Value;
                int dodai = int.Parse(txtDoDai.Text);
                string trangthai = cbTrangThai.Text;
                string dinhdang = cbDinhDang.Text;

                CPhim s = new CPhim(idphim, tenphim, theloai, daodien, mota, hinhanh, ngayphathanh, dodai, trangthai, dinhdang);
                if (ctrPhim.insert(s))
                {
                    MessageBox.Show("Thêm thông tin phim thành công!");
                    string[] objphim = { idphim, tenphim, theloai, daodien, mota, hinhanh, ngayphathanh + "", dodai + "", trangthai, dinhdang };
                    ListViewItem item = new ListViewItem(objphim);
                    lsvDSPhim.Items.Add(item);
                    dsPhim.Add(s);
                }
                else
                    MessageBox.Show("Thêm thông tin phim thất bại!");
                CapNhatSoLuongPhim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm thông tin phim: \n" + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSPhim.SelectedItems[0];
                CPhim phim = new CPhim();
                phim.IDPhim = item.SubItems[0].Text;
                int index = dsPhim.IndexOf(phim);
                if (index < 0)
                    return;
                phim = dsPhim[index];
                //
                phim.IDPhim = txtIDPhim.Text;
                phim.TenPhim = txtTenPhim.Text;
                phim.TheLoai = txtTheLoai.Text;
                phim.DaoDien = txtDaoDien.Text;
                phim.MoTa = rtbMoTa.Text;
                phim.HinhAnh = txtHinhAnh.Text ?? null;
                phim.NgayPH = dtNgayPH.Value;
                phim.DoDai = int.Parse(txtDoDai.Text);
                phim.TrangThai = cbTrangThai.Text;
                phim.DinhDang = cbDinhDang.Text;
                dsPhim[index] = phim;

                //
                if (ctrPhim.update(phim))
                {
                    MessageBox.Show("Cập nhật thông tin phim thành công!");
                    item.SubItems[1].Text = phim.TenPhim;
                    item.SubItems[2].Text = phim.TheLoai;
                    item.SubItems[3].Text = phim.DaoDien;
                    item.SubItems[4].Text = phim.MoTa;
                    item.SubItems[5].Text = phim.HinhAnh;
                    item.SubItems[6].Text = phim.NgayPH.ToString();
                    item.SubItems[7].Text = phim.DoDai.ToString();
                    item.SubItems[8].Text = phim.TrangThai;
                    item.SubItems[9].Text = phim.DinhDang;
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin phim thất bại!");
                    return;
                }
                CapNhatSoLuongPhim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật thông tin phim: \n" + ex.Message);
            }
        }

        private void bthXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSPhim.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDSPhim.SelectedItems[0];
                    CPhim phim = new CPhim();
                    phim.IDPhim = item.SubItems[0].Text;
                    int index = dsPhim.IndexOf(phim);
                    if (index < 0)
                        return;
                    phim = dsPhim[index];
                    if (ctrPhim.delete(phim))
                    {
                        MessageBox.Show("Xóa thông tin phim thành công!");
                        dsPhim.Remove(phim);
                        lsvDSPhim.Items.RemoveAt(index);
                    }
                    else
                        MessageBox.Show("Xóa thông tin phim thất bại!");
                }
                else
                    MessageBox.Show("Vui lòng chọn thông tin phim cần xóa.");
                CapNhatSoLuongPhim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin phim: \n" + ex.Message);
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDPhim.Clear();
            txtTenPhim.Clear();
            txtTheLoai.Clear();
            txtDaoDien.Clear();
            rtbMoTa.Clear();
            txtHinhAnh.Clear();
            dtNgayPH.Value = DateTime.Now;
            txtDoDai.Clear();
            cbTrangThai.SelectedItem = null;
            cbDinhDang.SelectedItem = null;
            //
            txtIDPhim.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkTim = txtTimKiem.Text;
                dsPhim = ctrPhim.findCriteria(dkTim);
                lsvDSPhim.Items.Clear();
                foreach (CPhim s in dsPhim)
                {
                    string[] obj = {s.IDPhim, s.TenPhim, s.TheLoai, s.DaoDien, s.MoTa,
                s.HinhAnh, s.NgayPH +"", s.DoDai +"", s.TrangThai,s.DinhDang};
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSPhim.Items.Add(item);
                    item.SubItems[0].Text = s.IDPhim;
                    item.SubItems[1].Text = s.TenPhim;
                    item.SubItems[2].Text = s.TheLoai;
                    item.SubItems[3].Text = s.DaoDien;
                    item.SubItems[4].Text = s.MoTa;
                    item.SubItems[5].Text = s.HinhAnh;
                    item.SubItems[6].Text = s.NgayPH.ToString();
                    item.SubItems[7].Text = s.DoDai.ToString();
                    item.SubItems[8].Text = s.TrangThai;
                    item.SubItems[9].Text = s.DinhDang;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
