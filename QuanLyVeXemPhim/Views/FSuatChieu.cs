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
    public partial class FSuatChieu : Form
    {
        List<CSuatChieu> dsSuatChieu = new List<CSuatChieu>();
        List<CPhim> dsPhim = new List<CPhim>();
        List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();
        List<CPhongChieu> dsPhong = new List<CPhongChieu>();

        CtrlSuatChieu ctrSuatChieu = new CtrlSuatChieu();
        CtrlPhim ctrPhim = new CtrlPhim();
        CtrlRapChieuPhim ctrRapChieuPhim = new CtrlRapChieuPhim();
        CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();

        public FSuatChieu()
        {
            InitializeComponent();
            int width = lsvSuatChieu.Width;
            lsvSuatChieu.Columns.Add("ID Suất chiếu", 13 * width / 100);
            lsvSuatChieu.Columns.Add("Phim", 10 * width / 100);
            lsvSuatChieu.Columns.Add("Rạp", 10 * width / 100);
            lsvSuatChieu.Columns.Add("Phòng", 10 * width / 100);
            lsvSuatChieu.Columns.Add("Số lượng vé", 14 * width / 100);
            lsvSuatChieu.Columns.Add("Thời gian chiếu", 22 * width / 100);
            lsvSuatChieu.Columns.Add("Số lượng còn lại", 10 * width / 100);
            lsvSuatChieu.Columns.Add("Trạng thái", 12 * width / 100);

            lsvSuatChieu.View = View.Details;
            lsvSuatChieu.FullRowSelect = true;
        }
        private void CapNhatSoLuongSuatChieu()
        {
            txtTongSo.Text = dsSuatChieu.Count + "";
        }
        private void FSuatChieu_Load(object sender, EventArgs e)
        {
            dsSuatChieu = ctrSuatChieu.findAll();
            dsPhim = ctrPhim.findAll();
            dsRap = ctrRapChieuPhim.findall();
            dsPhong = ctrPhongChieu.findAll();

            // Tạo DataSource cho combobox
            cmbPhim.DataSource = dsPhim;
            cmbRap.DataSource = dsRap;
            cmbPhong.DataSource = dsPhong;
            List<string> dsTrangThai = new List<string> { "Còn Trống", "Hết Vé" };
            cmbTrangThai.DataSource = dsTrangThai;

            if (!string.IsNullOrEmpty(txtSoLuongConLai.Text))
            {
                if (int.Parse(txtSoLuongConLai.Text) == 0)
                {
                    cmbTrangThai.Text = "Hết Vé";
                }
            }

            lsvSuatChieu.Items.Clear();
            foreach (CSuatChieu s in dsSuatChieu)
            {
                string[] obj = { s.IDSuatChieu, s.Phim.TenPhim, s.Rap.TenRap, s.Phong.TenPhong, s.SoLuongVe + "", s.ThoiGianChieu + "", s.SoLuongConLai + "", s.TrangThai };
                ListViewItem item = new ListViewItem(obj);
                lsvSuatChieu.Items.Add(item);
                //item.SubItems[0].Text = s.IDSuatChieu;
                //item.SubItems[1].Text = s.Phim.TenPhim;
                //item.SubItems[2].Text = s.Rap.TenRap;
                //item.SubItems[3].Text = s.Phong.TenPhong;
                //item.SubItems[4].Text = s.SoLuongVe + "";
                //item.SubItems[5].Text = s.ThoiGianChieu + "";
                //item.SubItems[6].Text = s.SoLuongConLai + "";
                //item.SubItems[7].Text = s.TrangThai;
            }
            CapNhatSoLuongSuatChieu();
        }

        private void lsvSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị thông tin của item lên 
                ListViewItem item = lsvSuatChieu.SelectedItems[0];
                CSuatChieu sc = new CSuatChieu();
                sc.IDSuatChieu = item.SubItems[0].Text;
                int index = dsSuatChieu.IndexOf(sc);
                if (index < 0)
                    return;
                sc = dsSuatChieu[index];

                txtIDSuatChieu.Text = sc.IDSuatChieu;
                cmbPhim.Text = sc.Phim.ToString();
                cmbRap.Text = sc.Rap.ToString();
                cmbPhong.Text = sc.Phong.ToString();
                txtSoLuongVe.Text = sc.SoLuongVe + "";
                dtThoiGianChieu.Value = sc.ThoiGianChieu;
                txtSoLuongConLai.Text = sc.SoLuongConLai + "";
                cmbTrangThai.Text = sc.TrangThai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhim.SelectedItem == null || cmbRap.SelectedItem == null || cmbPhong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn phim, rạp chiếu và phòng chiếu trước khi thêm suất chiếu mới.");
                    return;
                }
                //
                string idSC = txtIDSuatChieu.Text;
                CPhim phim = new CPhim();
                if (cmbPhim.SelectedItem != null)
                {
                    phim = (CPhim)cmbPhim.SelectedItem;
                    string idPhim = phim.IDPhim;
                }
                CRapChieuPhim rap = new CRapChieuPhim();
                if (cmbRap.SelectedItem != null)
                {
                    rap = (CRapChieuPhim)cmbRap.SelectedItem;
                    string idRap = rap.IDRap;
                }
                CPhongChieu phongChieu = new CPhongChieu();
                if (cmbPhong.SelectedItem != null)
                {
                    phongChieu = (CPhongChieu)cmbPhong.SelectedItem;
                    string idPhong = phongChieu.IDPhong;
                }
                int slVe = int.Parse(txtSoLuongVe.Text);
                DateTime timeChieu = dtThoiGianChieu.Value;
                int slVeConLai = int.Parse(txtSoLuongConLai.Text);
                string trangThai = cmbTrangThai.Text;

                // 
                CSuatChieu s = new CSuatChieu(idSC, phim, rap, phongChieu, slVe, timeChieu, slVeConLai, trangThai);
                if (ctrSuatChieu.insert(s))
                {
                    MessageBox.Show("Thêm thông tin suất chiếu thành công.");
                    string[] objsc = { idSC, phim.TenPhim, rap.TenRap, phongChieu.TenPhong, slVe + "", timeChieu + "", slVeConLai + "", trangThai };
                    ListViewItem item = new ListViewItem(objsc);
                    lsvSuatChieu.Items.Add(item);
                    dsSuatChieu.Add(s);
                }
                else
                {
                    MessageBox.Show("Thêm thông tin suất chiếu thất bại.");
                    return;
                }
                CapNhatSoLuongSuatChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm thông tin suất chiếu.\n" + ex.Message);
                return;
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDSuatChieu.Clear();
            cmbPhim.SelectedItem = null;
            cmbRap.SelectedItem = null;
            cmbPhong.SelectedItem = null;
            txtSoLuongVe.Clear();
            dtThoiGianChieu.Value = DateTime.Now;
            txtSoLuongConLai.Clear();
            cmbTrangThai.SelectedItem = null;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhim.SelectedItem == null || cmbRap.SelectedItem == null || cmbPhong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn phim, rạp chiếu và phòng chiếu trước khi cập nhật suất chiếu.");
                    return;
                }

                ListViewItem item = lsvSuatChieu.SelectedItems[0];
                CSuatChieu suatChieu = new CSuatChieu();
                suatChieu.IDSuatChieu = item.SubItems[0].Text;
                int index = dsSuatChieu.IndexOf(suatChieu);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }

                //
                suatChieu.Phim = new CPhim();
                suatChieu.Rap = new CRapChieuPhim();
                suatChieu.Phong = new CPhongChieu();

                suatChieu = dsSuatChieu[index];
                suatChieu.Phim = (CPhim)cmbPhim.SelectedItem;
                suatChieu.Rap = (CRapChieuPhim)cmbRap.SelectedItem;
                suatChieu.Phong = (CPhongChieu)cmbPhong.SelectedItem;
                suatChieu.SoLuongVe = int.Parse(txtSoLuongVe.Text);
                suatChieu.ThoiGianChieu = dtThoiGianChieu.Value;
                suatChieu.SoLuongConLai = int.Parse(txtSoLuongConLai.Text);
                suatChieu.TrangThai = cmbTrangThai.Text;

                if (ctrSuatChieu.update(suatChieu))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    item.SubItems[1].Text = suatChieu.Phim.TenPhim;
                    item.SubItems[2].Text = suatChieu.Rap.TenRap;
                    item.SubItems[3].Text = suatChieu.Phong.TenPhong;
                    item.SubItems[4].Text = suatChieu.SoLuongVe + "";
                    item.SubItems[5].Text = suatChieu.ThoiGianChieu + "";
                    item.SubItems[6].Text = suatChieu.SoLuongConLai + "";
                    item.SubItems[7].Text = suatChieu.TrangThai;
                }

                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvSuatChieu.SelectedItems[0];
                CSuatChieu SC = new CSuatChieu();
                SC.IDSuatChieu = item.SubItems[0].Text;
                int index = dsSuatChieu.IndexOf(SC);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }

                //
                SC = dsSuatChieu[index];
                if (ctrSuatChieu.delete(SC))
                {
                    MessageBox.Show("Xóa thành công.");
                    dsSuatChieu.Remove(SC);
                    lsvSuatChieu.Items.Remove(item);

                }
                else MessageBox.Show("Xóa thất bại!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
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
                dsSuatChieu = ctrSuatChieu.findCriteria(dkTim);
                lsvSuatChieu.Items.Clear();
                foreach (CSuatChieu s in dsSuatChieu)
                {
                    string[] obj = { s.IDSuatChieu, s.Phim.TenPhim, s.Rap.TenRap, s.Phong.TenPhong, s.SoLuongVe + "", s.ThoiGianChieu + "", s.SoLuongConLai + "", s.TrangThai };
                    ListViewItem item = new ListViewItem(obj);
                    lsvSuatChieu.Items.Add(item);
                    // Cập nhật số lượng suất chiếu sau mỗi lần thay đổi
                    CapNhatSoLuongSuatChieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}