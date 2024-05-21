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
    public partial class FRapChieuPhim : Form
    {
        CtrlRapChieuPhim ctrlRapChieuPhim = new CtrlRapChieuPhim();
        List<CRapChieuPhim> dsRapChieuPhim = new List<CRapChieuPhim>();
        public FRapChieuPhim()
        {
            InitializeComponent();
            int width = lsvDSRap.Width;
            lsvDSRap.Columns.Add("Mã rạp", 10 * width / 100);
            lsvDSRap.Columns.Add("Tên rạp", 24 * width / 100);
            lsvDSRap.Columns.Add("Địa chỉ", 40 * width / 100);
            lsvDSRap.Columns.Add("Số lượng phòng", 15 * width / 100);
            lsvDSRap.Columns.Add("Logo", 10 * width / 100);

            lsvDSRap.View = View.Details;
            lsvDSRap.FullRowSelect = true;
        }
        private void FRapChieuPhim_Load(object sender, EventArgs e)
        {
            txtIDRap.Focus();
            dsRapChieuPhim = ctrlRapChieuPhim.findall();
            foreach (CRapChieuPhim s in dsRapChieuPhim)
            {
                string logo = s.Logo ?? "";
                string[] obj = { s.IDRap, s.TenRap, s.DiaChi, s.SoLuongPhong.ToString(), s.Logo };
                ListViewItem item = new ListViewItem(obj);
                lsvDSRap.Items.Add(item);
                txtTongSo.Text = lsvDSRap.Items.Count.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDRap.Text == "" || txtTenRap.Text == "" || txtDiaChi.Text == "" || txtSoLuongPhong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                string idRap = txtIDRap.Text;
                string tenrap = txtTenRap.Text;
                string diachi = txtDiaChi.Text;
                int soLuongPhong = 0;
                try
                {
                    soLuongPhong = int.Parse(txtSoLuongPhong.Text);
                }
                catch
                {
                    MessageBox.Show("Số lượng phòng phải là số nguyên dương.");
                    txtSoLuongPhong.Focus();
                    return;
                }
                string logo = txtLogo.Text ?? "";

                CRapChieuPhim rapChieuPhim = new CRapChieuPhim(idRap, tenrap, diachi, soLuongPhong, logo);
                if (ctrlRapChieuPhim.insert(rapChieuPhim))
                {
                    MessageBox.Show("Thêm thông tin rạp chiếu phim thành công!");
                    string[] objsp = { idRap, tenrap, diachi, soLuongPhong + "", logo };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvDSRap.Items.Add(item);
                    dsRapChieuPhim.Add(rapChieuPhim);
                    txtTongSo.Text = lsvDSRap.Items.Count.ToString();
                }
                else
                    MessageBox.Show("Thêm thông tin rạp chiếu phim thất bại!");
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhập thông tin rạp chiếu phim.");
                txtIDRap.Focus();
            }
        }


        private void lsvDSRap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSRap.SelectedItems.Count == 0) { return; }
                ListViewItem item = lsvDSRap.SelectedItems[0];
                CRapChieuPhim rapChieuPhim = new CRapChieuPhim();
                rapChieuPhim.IDRap = item.SubItems[0].Text;
                int index = dsRapChieuPhim.IndexOf(rapChieuPhim);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }
                {
                    //
                    rapChieuPhim = dsRapChieuPhim[index];
                    //hiển thị lên form
                    txtIDRap.Text = rapChieuPhim.IDRap;
                    txtTenRap.Text = rapChieuPhim.TenRap;
                    txtDiaChi.Text = rapChieuPhim.DiaChi;
                    txtSoLuongPhong.Text = rapChieuPhim.SoLuongPhong.ToString();
                    txtLogo.Text = rapChieuPhim.Logo;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSRap.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDSRap.SelectedItems[0];
                    CRapChieuPhim rapChieuPhim = new CRapChieuPhim();
                    rapChieuPhim.IDRap = item.SubItems[0].Text;

                    int index = dsRapChieuPhim.IndexOf(rapChieuPhim);
                    if (index >= 0)
                    {
                        rapChieuPhim = dsRapChieuPhim[index];
                        if (ctrlRapChieuPhim.delete(rapChieuPhim))
                        {
                            MessageBox.Show("Xóa thông tin rạp chiếu phim thành công!");
                            dsRapChieuPhim.Remove(rapChieuPhim);
                            lsvDSRap.Items.Remove(item);
                            txtTongSo.Text = lsvDSRap.Items.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin rạp chiếu phim thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin rạp chiếu phim cần xóa.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSRap.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDSRap.SelectedItems[0];
                    CRapChieuPhim rapChieuPhim = new CRapChieuPhim();
                    rapChieuPhim.IDRap = item.SubItems[0].Text;
                    int index = dsRapChieuPhim.IndexOf(rapChieuPhim);
                    // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                    if (index < 0) { return; }

                    //
                    rapChieuPhim = dsRapChieuPhim[index];
                    rapChieuPhim.IDRap = txtIDRap.Text;
                    rapChieuPhim.TenRap = txtTenRap.Text;
                    rapChieuPhim.DiaChi = txtDiaChi.Text;
                    rapChieuPhim.SoLuongPhong = int.Parse(txtSoLuongPhong.Text);
                    rapChieuPhim.Logo = txtLogo.Text;

                    if (ctrlRapChieuPhim.update(rapChieuPhim))
                    {
                        MessageBox.Show("Cập nhật thông tin rạp chiếu phim thành công!");
                        item.SubItems[0].Text = rapChieuPhim.IDRap;
                        item.SubItems[1].Text = rapChieuPhim.TenRap;
                        item.SubItems[2].Text = rapChieuPhim.DiaChi;
                        item.SubItems[3].Text = rapChieuPhim.SoLuongPhong + "";
                        item.SubItems[4].Text = rapChieuPhim.Logo;

                    }
                    else
                        MessageBox.Show("Cập nhật thông tin rạp chiếu phim thất bại!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin rạp chiếu phim cần cập nhật.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkFind = txtTimKiem.Text;
                dsRapChieuPhim = ctrlRapChieuPhim.findCriteria(dkFind);

                lsvDSRap.Items.Clear();
                foreach (CRapChieuPhim s in dsRapChieuPhim)
                {
                    string logo = s.Logo ?? "";
                    string[] obj = { s.IDRap, s.TenRap, s.DiaChi, s.SoLuongPhong.ToString(), logo };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSRap.Items.Add(item);
                }
                txtTongSo.Text = lsvDSRap.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDRap.Clear();
            txtTenRap.Clear();
            txtSoLuongPhong.Clear();
            txtDiaChi.Clear();
            txtLogo.Clear();
            txtTimKiem.Clear();
            txtIDRap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
