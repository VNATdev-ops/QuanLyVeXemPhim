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
        CtrlThucAnDoUong ctrThucAnDoUong = new CtrlThucAnDoUong();
        List<CThucAnDoUong> dsSanPham = new List<CThucAnDoUong>();
        public FSanPham()
        {
            InitializeComponent();
            int width = lsvDSSP.Width;
            lsvDSSP.Columns.Add("ID Sản phẩm", 15 * width / 100);
            lsvDSSP.Columns.Add("Loại sản phẩm", 15 * width / 100);
            lsvDSSP.Columns.Add("Tên sản phẩm", 30 * width / 100);
            lsvDSSP.Columns.Add("Giá tiền", 20 * width / 100);
            lsvDSSP.Columns.Add("Hình ảnh", 19 * width / 100);

            lsvDSSP.View = View.Details;
            lsvDSSP.FullRowSelect = true;
        }

        private void CapNhatSoLuongSP()
        {
            txtSoLuongSP.Text = dsSanPham.Count + "";
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            dsSanPham = ctrThucAnDoUong.findAll();
            foreach (CThucAnDoUong s in dsSanPham)
            {
                string[] obj = { s.IDSanPham, s.Loai, s.TenSanPham, s.Gia + "", s.Hinh };
                ListViewItem item = new ListViewItem(obj);
                lsvDSSP.Items.Add(item);
                item.SubItems[0].Text = s.IDSanPham;
                item.SubItems[1].Text = s.Loai;
                item.SubItems[2].Text = s.TenSanPham;
                item.SubItems[3].Text = s.Gia.ToString();
                item.SubItems[4].Text = s.Hinh;
            }
            CapNhatSoLuongSP();

            //combobox
            List<string> dsLoaiSP = new List<string> { "Thức ăn", "Nước uống" };
            cbLoaiSP.DataSource = dsLoaiSP;
            cbLoaiSP.SelectedItem = null;
        }

        private void lsvDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDSSP.SelectedItems[0];
                CThucAnDoUong sp = new CThucAnDoUong();
                sp.IDSanPham = item.SubItems[0].Text;
                int index = dsSanPham.IndexOf(sp);
                if (index < 0)
                    return;
                sp = dsSanPham[index];

                txtIDSP.Text = sp.IDSanPham;
                cbLoaiSP.Text = sp.Loai;
                txtTenSP.Text = sp.TenSanPham;
                txtGia.Text = sp.Gia + "";
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
                string hinh = txtHinhAnh.Text ?? null;

                CThucAnDoUong s = new CThucAnDoUong(idsanpham, loai, tensanpham, gia, hinh);
                if (ctrThucAnDoUong.insert(s))
                {
                    MessageBox.Show("Thêm thông tin sản phẩm thành công.");
                    string[] objsp = { idsanpham, loai, tensanpham, gia.ToString(), hinh };
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
                CThucAnDoUong sp = new CThucAnDoUong();
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
                sp.Hinh = txtHinhAnh.Text ?? null;
                //
                if (ctrThucAnDoUong.update(sp))
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công.");
                    item.SubItems[1].Text = sp.Loai;
                    item.SubItems[2].Text = sp.TenSanPham;
                    item.SubItems[3].Text = sp.Gia.ToString();
                    item.SubItems[4].Text = sp.Hinh;
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
                    CThucAnDoUong sp = new CThucAnDoUong();
                    sp.IDSanPham = item.SubItems[0].Text;
                    int index = dsSanPham.IndexOf(sp);
                    if (index < 0)
                        return;
                    sp = dsSanPham[index];
                    if (ctrThucAnDoUong.delete(sp))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtIDSP.Clear();
            cbLoaiSP.SelectedItem = null;
            txtTenSP.Clear();
            txtGia.Clear();
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
                dsSanPham = ctrThucAnDoUong.findCriteria(dkTim);
                lsvDSSP.Items.Clear();
                foreach (CThucAnDoUong s in dsSanPham)
                {
                    string[] obj = { s.IDSanPham, s.Loai, s.TenSanPham, s.Gia.ToString(), s.Hinh };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDSSP.Items.Add(item);
                    item.SubItems[0].Text = s.IDSanPham;
                    item.SubItems[1].Text = s.Loai;
                    item.SubItems[2].Text = s.TenSanPham;
                    item.SubItems[3].Text = s.Gia.ToString();
                    item.SubItems[4].Text = s.Hinh;
                }
            }
            catch
            {

            }
        }
    }
}
