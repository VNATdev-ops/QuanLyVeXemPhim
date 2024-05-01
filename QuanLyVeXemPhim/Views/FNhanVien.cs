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
    public partial class FNhanVien : Form
    {
        CtrlNhanVien ctrlNhanVien = new CtrlNhanVien();
        List<CNhanVien> dsNhanVien = new List<CNhanVien>();
        public FNhanVien()
        {
            InitializeComponent();
            int width = lsvNhanVien.Width;
            lsvNhanVien.Columns.Add("Mã NV", 10 * width / 100);
            lsvNhanVien.Columns.Add("Họ Tên", 13 * width / 100);
            lsvNhanVien.Columns.Add("Mật khẩu", 12 * width / 100);
            lsvNhanVien.Columns.Add("Ngày sinh", 12 * width / 100);
            lsvNhanVien.Columns.Add("Giới tính", 10 * width / 100);
            lsvNhanVien.Columns.Add("Email", 14 * width / 100);
            lsvNhanVien.Columns.Add("Chức vụ", 12 * width / 100);
            lsvNhanVien.Columns.Add("Số điện thoại", 12 * width / 100);

            lsvNhanVien.View = View.Details;
            lsvNhanVien.FullRowSelect = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtIDNhanVien.Text;
                string tenNV = txtTenNhanVien.Text;
                string matKhau = txtMatKhau.Text;
                DateTime ngaySinh = txtNgaySinh.Value;
                string gioiTinh = txtGioiTinh.Text;
                string sdt = txtEmail.Text;
                string email = txtChucVu.Text;
                string chucVu = txtSoDienThoai.Text;

                CNhanVien nhanVien = new CNhanVien(maNV, tenNV, matKhau, ngaySinh, gioiTinh, sdt, email, chucVu);
                if (ctrlNhanVien.insert(nhanVien))
                {
                    MessageBox.Show("Thêm thành công!");
                    string[] objsp = {maNV, tenNV, matKhau, ngaySinh.ToString(), gioiTinh, sdt.ToString(), email, chucVu};
                    ListViewItem item = new ListViewItem(objsp);
                    lsvNhanVien.Items.Add(item);
                    dsNhanVien.Add(nhanVien);
                    txtTongSo.Text = lsvNhanVien.Items.Count.ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            catch { }
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            dsNhanVien = ctrlNhanVien.findall();
            foreach (CNhanVien s in dsNhanVien)
            {
                string[] obj = { s.IDNhanVien, s.TenNV, s.MatKhau, s.NgaySinh.ToString(), s.GioiTinh, s.Sdt.ToString(), s.Email, s.ChucVu };
                ListViewItem item = new ListViewItem(obj);
                lsvNhanVien.Items.Add(item);
                txtTongSo.Text = lsvNhanVien.Items.Count.ToString();
            }
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvNhanVien.SelectedItems[0];
                CNhanVien nhanVien = new CNhanVien();
                nhanVien.IDNhanVien = item.SubItems[0].Text;
                int index = dsNhanVien.IndexOf(nhanVien);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }
                {
                    //
                    nhanVien = dsNhanVien[index];
                    //hiển thị lên form

                    txtIDNhanVien.Text = nhanVien.IDNhanVien;
                    txtTenNhanVien.Text = nhanVien.TenNV;
                    txtMatKhau.Text = nhanVien.MatKhau;
                    txtNgaySinh.Value = nhanVien.NgaySinh;
                    txtGioiTinh.Text = nhanVien.GioiTinh;
                    txtEmail.Text = nhanVien.Sdt;
                    txtChucVu.Text = nhanVien.Email;
                    txtSoDienThoai.Text = nhanVien.ChucVu;
                }

            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvNhanVien.SelectedItems[0];
                CNhanVien nhanVien = new CNhanVien();
                nhanVien.IDNhanVien = item.SubItems[0].Text;
                int index = dsNhanVien.IndexOf(nhanVien);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }

                //
                nhanVien = dsNhanVien[index];
                if (ctrlNhanVien.delete(nhanVien))
                {
                    MessageBox.Show("Xóa thành công");
                    dsNhanVien.Remove(nhanVien);
                    lsvNhanVien.Items.Remove(item);
                    txtTongSo.Text = lsvNhanVien.Items.Count.ToString();

                }
                else MessageBox.Show("Xóa thất bại!");

            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvNhanVien.SelectedItems[0];
                CNhanVien nhanVien = new CNhanVien();
                nhanVien.IDNhanVien = item.SubItems[0].Text;
                int index = dsNhanVien.IndexOf(nhanVien);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }

                //
                nhanVien = dsNhanVien[index];
                nhanVien.IDNhanVien = txtIDNhanVien.Text;
                nhanVien.TenNV = txtTenNhanVien.Text;
                nhanVien.MatKhau = txtMatKhau.Text;
                nhanVien.NgaySinh = txtNgaySinh.Value;
                nhanVien.GioiTinh = txtGioiTinh.Text;
                nhanVien.Sdt = txtEmail.Text;
                nhanVien.Email = txtChucVu.Text;
                nhanVien.ChucVu = txtSoDienThoai.Text;

                if (ctrlNhanVien.update(nhanVien))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    item.SubItems[1].Text = nhanVien.TenNV;
                    item.SubItems[2].Text = nhanVien.MatKhau;
                    item.SubItems[3].Text = nhanVien.NgaySinh.ToString();
                    item.SubItems[4].Text = nhanVien.GioiTinh;
                    item.SubItems[5].Text = nhanVien.Sdt;
                    item.SubItems[6].Text = nhanVien.Email;
                    item.SubItems[7].Text = nhanVien.ChucVu;
                }
                else
                    MessageBox.Show("Cập nhật thất bại!!!");
            }
            catch { }
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkFind = txtTimKiemNV.Text;
                dsNhanVien = ctrlNhanVien.findCriteria(dkFind);

                //xóa listview
                lsvNhanVien.Items.Clear();
                foreach (CNhanVien s in dsNhanVien)
                {
                    string[] obj = { s.IDNhanVien, s.TenNV, s.MatKhau, s.NgaySinh.ToString(), s.GioiTinh, s.Sdt.ToString(), s.Email, s.ChucVu };
                    ListViewItem item = new ListViewItem(obj);
                    lsvNhanVien.Items.Add(item);

                }
                txtTongSo.Text = lsvNhanVien.Items.Count.ToString();
            }

            catch { }
        }
    }
}
