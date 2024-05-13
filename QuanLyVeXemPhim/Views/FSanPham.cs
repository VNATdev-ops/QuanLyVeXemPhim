using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FSanPham : Form
    {
        CtrlSanPham ctrSanPham = new CtrlSanPham();
        List<CSanPham> dsSanPham = new List<CSanPham>();
        public FSanPham()
        {
            InitializeComponent();
            int width = lsvDSSP.Width;
            lsvDSSP.Columns.Add("ID Sản phẩm", 10 * width / 100);
            lsvDSSP.Columns.Add("Loại sản phẩm", 10 * width / 100);
            lsvDSSP.Columns.Add("Tên sản phẩm", 24 * width / 100);
            lsvDSSP.Columns.Add("Giá tiền", 15 * width / 100);
            lsvDSSP.Columns.Add("Đơn vị tính", 20 * width / 100);
            lsvDSSP.Columns.Add("Số lượng", 10 * width / 100);
            lsvDSSP.Columns.Add("Hình ảnh", 10 * width / 100);

            lsvDSSP.View = View.Details;
            lsvDSSP.FullRowSelect = true;
        }

        private void CapNhatSoLuongSP()
        {
            txtSoLuongSP.Text = dsSanPham.Count + "";
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            dsSanPham = ctrSanPham.findAll();
            foreach (CSanPham s in dsSanPham)
            {
                string[] obj = { s.IDSanPham, s.Loai, s.TenSanPham, s.Gia + "", s.DonViTinh, s.SoLuong + "", s.Hinh };
                ListViewItem item = new ListViewItem(obj);
                lsvDSSP.Items.Add(item);
                item.SubItems[0].Text = s.IDSanPham;
                item.SubItems[1].Text = s.Loai;
                item.SubItems[2].Text = s.TenSanPham;
                item.SubItems[3].Text = s.Gia.ToString();
                item.SubItems[4].Text = s.DonViTinh;
                item.SubItems[5].Text = s.SoLuong.ToString();
                item.SubItems[6].Text = s.Hinh;
            }
            CapNhatSoLuongSP();

            //combobox
            List<string> dsLoaiSP = new List<string> { "Thức ăn", "Nước uống", "Vé xem phim" };
            cbLoaiSP.DataSource = dsLoaiSP;
            cbLoaiSP.SelectedItem = null;
        }

        private void lsvDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSSP.SelectedItems[0];
                CSanPham sp = new CSanPham();
                sp.IDSanPham = item.SubItems[0].Text;
                int index = dsSanPham.IndexOf(sp);
                if (index < 0)
                    return;
                sp = dsSanPham[index];

                txtIDSP.Text = sp.IDSanPham;
                cbLoaiSP.Text = sp.Loai;
                txtTenSP.Text = sp.TenSanPham;
                txtGia.Text = sp.Gia.ToString();
                txtDonViTinh.Text = sp.DonViTinh;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtHinhAnh.Text = sp.Hinh;
                CapNhatSoLuongSP();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idsanpham = txtIDSP.Text;
                string loai = cbLoaiSP.Text;
                string tensanpham = txtTenSP.Text;
                decimal gia = Decimal.Parse(txtGia.Text);
                string donvitinh = txtDonViTinh.Text;
                int soluong = int.Parse(txtSoLuong.Text);
                string hinh = txtHinhAnh.Text ?? null;

                CSanPham s = new CSanPham(idsanpham, loai, tensanpham, gia, donvitinh, soluong, hinh);
                if (ctrSanPham.insert(s))
                {
                    MessageBox.Show("Thêm thông tin sản phẩm thành công.");
                    string[] objsp = { idsanpham, loai, tensanpham, gia.ToString(), donvitinh, soluong.ToString(), hinh };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvDSSP.Items.Add(item);
                    dsSanPham.Add(s);
                }
                else
                    MessageBox.Show("Thêm thông tin sản phẩm thất bại.");
                CapNhatSoLuongSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm thông tin sản phẩm.\n" + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSSP.SelectedItems[0];
                CSanPham sp = new CSanPham();
                sp.IDSanPham = item.SubItems[0].Text;
                int index = dsSanPham.IndexOf(sp);
                if (index < 0)
                    return;
                sp = dsSanPham[index];
                //
                sp.IDSanPham = txtIDSP.Text;
                sp.Loai = cbLoaiSP.Text;
                sp.TenSanPham = txtTenSP.Text;
                sp.Gia = Decimal.Parse(txtGia.Text);
                sp.DonViTinh = txtDonViTinh.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.Hinh = txtHinhAnh.Text ?? null;
                //
                if (ctrSanPham.update(sp))
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công.");
                    item.SubItems[1].Text = sp.Loai;
                    item.SubItems[2].Text = sp.TenSanPham;
                    item.SubItems[3].Text = sp.Gia.ToString();
                    item.SubItems[4].Text = sp.DonViTinh;
                    item.SubItems[5].Text = sp.SoLuong.ToString();
                    item.SubItems[6].Text = sp.Hinh;
                }
                else
                    MessageBox.Show("Cập nhật thông tin sản phẩm thất bại.");
                CapNhatSoLuongSP();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật thông tin sản phẩm.");
            }
        }

        private void bthXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDSSP.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDSSP.SelectedItems[0];
                    CSanPham sp = new CSanPham();
                    sp.IDSanPham = item.SubItems[0].Text;
                    int index = dsSanPham.IndexOf(sp);
                    if (index < 0)
                        return;
                    sp = dsSanPham[index];
                    if (ctrSanPham.delete(sp))
                    {
                        MessageBox.Show("Xóa thông tin sản phẩm thành công.");
                        dsSanPham.Remove(sp);
                        lsvDSSP.Items.RemoveAt(index);
                    }
                    else
                        MessageBox.Show("Xóa thông tin sản phẩm thất bại.");
                }
                else
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                CapNhatSoLuongSP();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin sản phẩm.");
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDSP.Clear();
            cbLoaiSP.SelectedItem = null;
            txtTenSP.Clear();
            txtGia.Clear();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtHinhAnh.Clear();
            //
            txtIDSP.Focus();
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
                dsSanPham = ctrSanPham.findCriteria(dkTim);
                lsvDSSP.Items.Clear();
                foreach (CSanPham s in dsSanPham)
                {
                    string[] obj = { s.IDSanPham, s.Loai, s.TenSanPham, s.Gia.ToString(), s.DonViTinh, s.SoLuong.ToString(), s.Hinh };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSSP.Items.Add(item);
                    item.SubItems[0].Text = s.IDSanPham;
                    item.SubItems[1].Text = s.Loai;
                    item.SubItems[2].Text = s.TenSanPham;
                    item.SubItems[3].Text = s.Gia.ToString();
                    item.SubItems[4].Text = s.DonViTinh;
                    item.SubItems[5].Text = s.SoLuong.ToString();
                    item.SubItems[6].Text = s.Hinh;
                }
            }
            catch
            {

            }
        }
    }
}
