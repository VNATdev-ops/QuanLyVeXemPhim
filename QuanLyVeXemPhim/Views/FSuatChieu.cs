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
        CtrlSuatChieu ctrSuatChieu = new CtrlSuatChieu();

        List<CPhim> dsPhim = new List<CPhim>();
        CtrlPhim ctrlPhim = new CtrlPhim();

        List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();
        CtrlRapChieuPhim ctrRap = new CtrlRapChieuPhim();

        List<CPhongChieu> dsPhongChieu = new List<CPhongChieu>();
        CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();

        public FSuatChieu()
        {
            InitializeComponent();

            int width = lsvSuatChieu.Width;
            lsvSuatChieu.Columns.Add("Mã suất chiếu", 12 * width / 100);
            lsvSuatChieu.Columns.Add("Phim", 24 * width / 100);
            lsvSuatChieu.Columns.Add("Rạp", 18 * width / 100);
            lsvSuatChieu.Columns.Add("Phòng", 8 * width / 100);
            lsvSuatChieu.Columns.Add("SL vé", 6 * width / 100);
            lsvSuatChieu.Columns.Add("Thời gian chiếu", 15 * width / 100);
            lsvSuatChieu.Columns.Add("SL còn lại", 7 * width / 100);
            lsvSuatChieu.Columns.Add("Trạng thái", 9 * width / 100);

            lsvSuatChieu.View = View.Details;
            lsvSuatChieu.FullRowSelect = true;
        }
        private void CapNhatSoLuongSuatChieu()
        {
            txtTongSo.Text = dsSuatChieu.Count + "";
        }
        private void ResetListViewSuatChieu()
        {
            dsSuatChieu = ctrSuatChieu.findAll();
            foreach (CSuatChieu sc in dsSuatChieu)
            {
                string[] obj = { sc.IDSuatChieu, sc.Phim.TenPhim, sc.Rap.TenRap, sc.Phong.TenPhong, sc.SoLuongVe.ToString(), sc.ThoiGianChieu.ToString(), sc.SoLuongConLai.ToString(), sc.TrangThai };
                ListViewItem item = new ListViewItem(obj);
                lsvSuatChieu.Items.Add(item);
            }
        }

        private void FSuatChieu_Load(object sender, EventArgs e)
        {
            txtIDSuatChieu.Focus();
            dsSuatChieu = ctrSuatChieu.findAll();
            dsPhim = ctrlPhim.findAll();
            dsRap = ctrRap.findall();
            dsPhongChieu = ctrPhongChieu.findAll();

            cmbPhim.DataSource = dsPhim;
            cmbRap.DataSource = dsRap;
            cmbPhong.DataSource = dsPhongChieu;
            List<string> dsTrangThai = new List<string> { "Còn vé", "Hết vé" };
            cmbTrangThai.DataSource = dsTrangThai;

            foreach (CSuatChieu sc in dsSuatChieu)
            {
                string[] obj = { sc.IDSuatChieu, sc.Phim.TenPhim, sc.Rap.TenRap, sc.Phong.TenPhong, sc.SoLuongVe.ToString(), sc.ThoiGianChieu.ToString(), sc.SoLuongConLai.ToString(), sc.TrangThai };
                ListViewItem item = new ListViewItem(obj);
                lsvSuatChieu.Items.Add(item);
            }
            CapNhatSoLuongSuatChieu();
        }

        private void lsvSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSuatChieu.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem item = new ListViewItem();
                    item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu sc = new CSuatChieu();
                    sc.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(sc);

                    if (index < 0 || index >= dsSuatChieu.Count)
                        return;
                    sc = dsSuatChieu[index];

                    txtIDSuatChieu.Text = sc.IDSuatChieu;
                    cmbPhim.Text = sc.Phim.ToString();
                    cmbRap.Text = sc.Rap.ToString();
                    cmbPhong.Text = sc.Phong.ToString();
                    txtSoLuongVe.Text = sc.SoLuongVe.ToString();
                    dtThoiGianChieu.Value = sc.ThoiGianChieu;
                    txtSoLuongConLai.Text = sc.SoLuongConLai.ToString();
                    cmbTrangThai.Text = sc.TrangThai;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
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

                CSuatChieu sc = new CSuatChieu();
                sc.Phim = new CPhim();
                sc.Rap = new CRapChieuPhim();
                sc.Phong = new CPhongChieu();

                sc.IDSuatChieu = txtIDSuatChieu.Text;
                if (cmbPhim.SelectedItem != null)
                {
                    sc.Phim = (CPhim)cmbPhim.SelectedItem;
                }
                if (cmbRap.SelectedItem != null)
                {
                    sc.Rap = (CRapChieuPhim)cmbRap.SelectedItem;
                }
                if (cmbPhong.SelectedItem != null)
                {
                    sc.Phong = (CPhongChieu)cmbPhong.SelectedItem;
                }
                sc.ThoiGianChieu = dtThoiGianChieu.Value;
                try
                {
                    sc.SoLuongVe = int.Parse(txtSoLuongVe.Text);
                }
                catch 
                {
                    MessageBox.Show("Số lượng vé phải là số nguyên dương.");
                    txtSoLuongVe.Focus();
                    return;
                }
                try
                {
                    sc.SoLuongConLai = int.Parse(txtSoLuongConLai.Text);
                }
                catch
                {
                    MessageBox.Show("Số lượng còn lại phải là số nguyên dương.");
                    txtSoLuongConLai.Focus();
                    return;
                }
                sc.TrangThai = cmbTrangThai.Text;

                //kiểm tra trùng lặp
                if (dsSuatChieu.Any(existingSC => existingSC.Rap.IDRap == sc.Rap.IDRap &&
                                                  existingSC.Phong.IDPhong == sc.Phong.IDPhong &&
                                                  existingSC.ThoiGianChieu == sc.ThoiGianChieu))
                {
                    MessageBox.Show("Suất chiếu đã tồn tại với cùng rạp, phòng và thời gian. Vui lòng chọn thời gian khác.");
                    return;
                }

                if (ctrSuatChieu.insert(sc))
                {
                    MessageBox.Show("Thêm thông tin suất chiếu thành công!");
                    string[] obj = { sc.IDSuatChieu, sc.Phim.TenPhim, sc.Rap.TenRap, sc.Phong.TenPhong,
                        sc.SoLuongVe.ToString(), sc.ThoiGianChieu.ToString(), sc.SoLuongConLai.ToString(), sc.TrangThai };
                    ListViewItem item = new ListViewItem(obj);
                    lsvSuatChieu.Items.Add(item);
                    dsSuatChieu.Add(sc);
                }
                else
                {
                    MessageBox.Show("Thêm thông tin suất chiếu thất bại!");
                    return;
                }
                CapNhatSoLuongSuatChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
            txtIDSuatChieu.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvSuatChieu.SelectedItems.Count > 0)
            {
                try
                {
                    if (cmbPhim.SelectedItem == null || cmbRap.SelectedItem == null || cmbPhong.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ phim, rạp chiếu và phòng chiếu.");
                        return;
                    }

                    ListViewItem item = new ListViewItem();
                    item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu sc = new CSuatChieu();
                    sc.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(sc);

                    if (index < 0 || index >= dsSuatChieu.Count)
                        return;
                    sc = dsSuatChieu[index];

                    sc.Phim = new CPhim();
                    sc.Rap = new CRapChieuPhim();
                    sc.Phong = new CPhongChieu();

                    sc = dsSuatChieu[index];
                    sc.Phim = (CPhim)cmbPhim.SelectedItem;
                    sc.Rap = (CRapChieuPhim)cmbRap.SelectedItem;
                    sc.Phong = (CPhongChieu)cmbPhong.SelectedItem;
                    sc.SoLuongVe = int.Parse(txtSoLuongVe.Text);
                    sc.ThoiGianChieu = dtThoiGianChieu.Value;
                    sc.SoLuongConLai = int.Parse(txtSoLuongConLai.Text);
                    sc.TrangThai = cmbTrangThai.Text;

                    // Kiểm tra trùng lặp rạp, phòng và thời gian
                    if (dsSuatChieu.Any(existingSC => existingSC.IDSuatChieu != sc.IDSuatChieu &&
                                                      existingSC.Rap.IDRap == sc.Rap.IDRap &&
                                                      existingSC.Phong.IDPhong == sc.Phong.IDPhong &&
                                                      existingSC.ThoiGianChieu == sc.ThoiGianChieu))
                    {
                        MessageBox.Show("Suất chiếu đã tồn tại với cùng rạp, phòng và thời gian. Vui lòng chọn thời gian khác.");
                        return;
                    }

                    dsSuatChieu[index] = sc;

                    if (ctrSuatChieu.update(sc))
                    {
                        MessageBox.Show("Cập nhật thông tin suất chiếu thành công!");
                        item.SubItems[1].Text = sc.Phim.TenPhim;
                        item.SubItems[2].Text = sc.Rap.TenRap;
                        item.SubItems[3].Text = sc.Phong.TenPhong;
                        item.SubItems[4].Text = sc.SoLuongVe.ToString();
                        item.SubItems[5].Text = sc.ThoiGianChieu.ToString();
                        item.SubItems[6].Text = sc.SoLuongConLai.ToString();
                        item.SubItems[7].Text = sc.TrangThai;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin suất chiếu thất bại!");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin suất chiếu cần cập nhật.");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSuatChieu.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem item = new ListViewItem();
                    item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu sc = new CSuatChieu();
                    sc.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(sc);

                    if (index < 0 || index >= dsSuatChieu.Count)
                        return;
                    sc = dsSuatChieu[index];

                    if (ctrSuatChieu.delete(sc))
                    {
                        MessageBox.Show("Xóa thông tin suất chiếu thành công!");
                        dsSuatChieu.Remove(sc);
                        lsvSuatChieu.Items.Remove(item);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin suất chiếu thất bại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                CapNhatSoLuongSuatChieu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin suất chiếu cần xóa.");
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
                List<CSuatChieu> dsSuatChieuTim = new List<CSuatChieu>();
                dsSuatChieuTim = ctrSuatChieu.findCriteria(dkTim);
                if (dsSuatChieuTim.Count > 0)
                {
                    lsvSuatChieu.Items.Clear();
                    foreach (CSuatChieu sc in dsSuatChieuTim)
                    {
                        string[] obj = { sc.IDSuatChieu, sc.Phim.TenPhim, sc.Rap.TenRap, sc.Phong.TenPhong,
                        sc.SoLuongVe.ToString(), sc.ThoiGianChieu.ToString(), sc.SoLuongConLai.ToString(), sc.TrangThai };
                        ListViewItem item = new ListViewItem(obj);
                        lsvSuatChieu.Items.Add(item);
                    }
                }
                CapNhatSoLuongSuatChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}


