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
            lsvDSRap.Columns.Add("Mã Rạp", 15 * width / 100);
            lsvDSRap.Columns.Add("Tên rạp", 25 * width / 100);
            lsvDSRap.Columns.Add("SDT", 20 * width / 100);
            lsvDSRap.Columns.Add("Địa chỉ", 20 * width / 100);
            lsvDSRap.Columns.Add("Số lượng phòng", 20 * width / 100);
            lsvDSRap.Columns.Add("Logo", 20 * width / 100);

            lsvDSRap.View = View.Details;
            lsvDSRap.FullRowSelect = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idRap = txtIDRap.Text;
                string tenrap = txtTenRap.Text;
                string diachi = txtDiaChi.Text;
                int soLuongPhong = int.Parse(txtSoLuongPhong.Text);
                string logo = txtLogo.Text;

                CRapChieuPhim rapChieuPhim = new CRapChieuPhim(idRap, tenrap, diachi, soLuongPhong, logo);
                if (ctrlRapChieuPhim.insert(rapChieuPhim))
                {
                    MessageBox.Show("Thêm thành công!");
                    string[] objsp = { idRap, tenrap, diachi, soLuongPhong + "", logo };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvDSRap.Items.Add(item);
                    dsRapChieuPhim.Add(rapChieuPhim);
                    txtTongSo.Text = lsvDSRap.Items.Count.ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại!");


            }
            catch { }
        }

        private void FRapChieuPhim_Load(object sender, EventArgs e)
        {
            dsRapChieuPhim = ctrlRapChieuPhim.findall();
            foreach (CRapChieuPhim s in dsRapChieuPhim)
            {
                string[] obj = { s.IDRap, s.TenRap, s.SoLuongPhong.ToString(), s.Logo };
                ListViewItem item = new ListViewItem(obj);
                lsvDSRap.Items.Add(item);
                txtTongSo.Text = lsvDSRap.Items.Count.ToString();
            }

        }

        private void lsvDSRap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSRap.SelectedItems[0];
                CRapChieuPhim rapChieuPhim = new CRapChieuPhim();
                rapChieuPhim.IDRap = item.SubItems[0].Text;
                int index = dsRapChieuPhim.IndexOf(rapChieuPhim);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }

                //
                rapChieuPhim = dsRapChieuPhim[index];
                if (ctrlRapChieuPhim.delete(rapChieuPhim))
                {
                    MessageBox.Show("Xóa thành công");
                    dsRapChieuPhim.Remove(rapChieuPhim);
                    lsvDSRap.Items.Remove(item);
                    txtTongSo.Text = lsvDSRap.Items.Count.ToString();

                }
                else MessageBox.Show("Xóa thất bại!");

            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
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
                rapChieuPhim.SoLuongPhong = int.Parse(txtSoLuongPhong.Text);
                rapChieuPhim.DiaChi = txtDiaChi.Text;
                rapChieuPhim.Logo = txtLogo.Text;

                if (ctrlRapChieuPhim.update(rapChieuPhim))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    item.SubItems[1].Text = rapChieuPhim.IDRap;
                    item.SubItems[2].Text = rapChieuPhim.TenRap;
                    item.SubItems[3].Text = rapChieuPhim.SoLuongPhong + "";
                    item.SubItems[2].Text = rapChieuPhim.DiaChi;
                    item.SubItems[2].Text = rapChieuPhim.Logo;

                }
                else
                    MessageBox.Show("Cập nhật thất bại!!!");
            }
            catch
            {

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkFind = txtTimKiem.Text;
                dsRapChieuPhim = ctrlRapChieuPhim.findCriteria(dkFind);

                //xóa listview
                lsvDSRap.Items.Clear();
                foreach (CRapChieuPhim s in dsRapChieuPhim)
                {
                    string[] obj = { s.IDRap, s.TenRap, s.SoLuongPhong.ToString(), s.Logo };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSRap.Items.Add(item);



                }
                txtTongSo.Text = lsvDSRap.Items.Count.ToString();
            }

            catch { }

        }
    }
}
