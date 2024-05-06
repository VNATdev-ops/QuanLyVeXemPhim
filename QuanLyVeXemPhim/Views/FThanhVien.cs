using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{

    public partial class FThanhVien : Form
    {
        CtrlThanhVien ctrlThanhVien = new CtrlThanhVien();
        List<CThanhVien> dsThanhVien = new List<CThanhVien>();

        private CtrlLichSuTichDiem ctrlLichSuTichDiem = new CtrlLichSuTichDiem();


        // 

        public FThanhVien()
        {
            InitializeComponent();
            int width = lsvDanhSachTV.Width;
            lsvDanhSachTV.Columns.Add("Mã TV", width / 100);
            lsvDanhSachTV.Columns.Add("Tên thành viên", width / 100);
            lsvDanhSachTV.Columns.Add("Mật khẩu", width / 100);
            lsvDanhSachTV.Columns.Add("Ngày sinh", width / 100);
            lsvDanhSachTV.Columns.Add("Giới tính", width / 100);
            lsvDanhSachTV.Columns.Add("Khu vực", width / 100);
            lsvDanhSachTV.Columns.Add("Email", width / 100);            

        

            lsvDanhSachTV.View = View.Details;
            lsvDanhSachTV.FullRowSelect = true;

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idTV = txtIDThanhVien.Text;
                string tenThanhVien = txtTenThanhVien.Text;
                string matKhau = txtMatKhau.Text;
                DateTime ngaySinh = txtNgaySinh.Value;
                string gioiTinh = txtGioiTinh.Text;
                string khuVuc = txtKhuVuc.Text;
                string email = txtEmail.Text;

                CThanhVien thanhVien = new CThanhVien(idTV, tenThanhVien,
                    matKhau, ngaySinh, gioiTinh, khuVuc, email);
                if (ctrlThanhVien.insert(thanhVien))
                {
                    MessageBox.Show("Thêm thành công!");
                    string[] objsp = { idTV, tenThanhVien, matKhau, ngaySinh + "", gioiTinh, khuVuc, email + "" };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvDanhSachTV.Items.Add(item);
                    dsThanhVien.Add(thanhVien);
                    txtTongSo.Text = lsvDanhSachTV.Items.Count.ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            catch { }
        }

        private void FThanhVien_Load(object sender, EventArgs e)
        {
            dsThanhVien = ctrlThanhVien.findall();
            foreach (CThanhVien s in dsThanhVien)
            {
                string[] obj = { s.IDThanhVien, s.TenThanhVien, s.MatKhau, s.NgaySinh + "",
                s.GioiTinh, s.KhuVuc, s.Email};
                ListViewItem item = new ListViewItem(obj);
                lsvDanhSachTV.Items.Add(item);
                txtTongSo.Text = lsvDanhSachTV.Items.Count.ToString();
            }
        }

        private void lsvDanhSachTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lsvDanhSachTV.SelectedItems.Count == 0)
                    return;

                ListViewItem item = lsvDanhSachTV.SelectedItems[0];
                CThanhVien thanhVien = new CThanhVien();
                thanhVien.IDThanhVien = item.SubItems[0].Text;
                int index = dsThanhVien.IndexOf(thanhVien);

                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }
                {
                    thanhVien = dsThanhVien[index];
                    //hiển thị lên form
                    txtIDThanhVien.Text = thanhVien.IDThanhVien;
                    txtTenThanhVien.Text = thanhVien.TenThanhVien;
                    txtMatKhau.Text = thanhVien.MatKhau;
                    txtNgaySinh.Value = thanhVien.NgaySinh;
                    txtGioiTinh.Text = thanhVien.GioiTinh;
                    txtKhuVuc.Text = thanhVien.KhuVuc;
                    txtEmail.Text = thanhVien.Email;

                    // Load the loyalty point history for the selected member
                    //LoadLichSuTichDiem(idThanhVien);
                }
            }
            catch { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDanhSachTV.SelectedItems[0];
                CThanhVien thanhVien = new CThanhVien();
                thanhVien.IDThanhVien = item.SubItems[0].Text;
                int index = dsThanhVien.IndexOf(thanhVien);

                if (index < 0) { return; }

                thanhVien = dsThanhVien[index];
                thanhVien.IDThanhVien = txtIDThanhVien.Text;
                thanhVien.TenThanhVien = txtTenThanhVien.Text;
                thanhVien.MatKhau = txtMatKhau.Text;
                thanhVien.NgaySinh = txtNgaySinh.Value;
                thanhVien.GioiTinh = txtGioiTinh.Text;
                thanhVien.KhuVuc = txtKhuVuc.Text;
                thanhVien.Email = txtEmail.Text;

                if (ctrlThanhVien.update(thanhVien))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    item.SubItems[1].Text = thanhVien.TenThanhVien;
                    item.SubItems[2].Text = thanhVien.MatKhau;
                    item.SubItems[3].Text = thanhVien.NgaySinh + "";
                    item.SubItems[4].Text = thanhVien.GioiTinh;
                    item.SubItems[5].Text = thanhVien.KhuVuc;
                    item.SubItems[6].Text = thanhVien.Email;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch { }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDanhSachTV.SelectedItems[0];
                CThanhVien thanhVien = new CThanhVien();
                thanhVien.IDThanhVien = item.SubItems[0].Text;
                int index = dsThanhVien.IndexOf(thanhVien);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0) { return; }
                //
                thanhVien = dsThanhVien[index];
                if (ctrlThanhVien.delete(thanhVien))
                {
                    MessageBox.Show("Xóa thành công");
                    dsThanhVien.Remove(thanhVien);
                    lsvDanhSachTV.Items.Remove(item);
                    txtTongSo.Text = lsvDanhSachTV.Items.Count.ToString();

                }
                else MessageBox.Show("Xóa thất bại!");

            }
            catch { }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkFind = txtTimKiem.Text;
                dsThanhVien = ctrlThanhVien.findCriteria(dkFind);

                // xóa listview
                lsvDanhSachTV.Items.Clear();
                foreach (CThanhVien s in dsThanhVien)
                {
                    string[] obj = { s.IDThanhVien, s.TenThanhVien, s.MatKhau, s.NgaySinh + "", s.GioiTinh, s.KhuVuc, s.Email };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDanhSachTV.Items.Add(item);
                }
                txtTongSo.Text = lsvDanhSachTV.Items.Count.ToString();
            }
            catch { }
        }

        private void txtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvLichSuTichDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
