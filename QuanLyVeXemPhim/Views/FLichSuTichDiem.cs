using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FLichSuTichDiem : Form
    {
        CtrlLichSuTichDiem ctrlLichSuTichDiem = new CtrlLichSuTichDiem();
        List<CLichSuTichDiem> dsLichSuTichDiem = new List<CLichSuTichDiem>();
        public FLichSuTichDiem()
        {
            InitializeComponent();
            int width = lsvLichSuTichDiem.Width;
            lsvLichSuTichDiem.Columns.Add("Mã lịch sử", 15 * width / 100);
            lsvLichSuTichDiem.Columns.Add("Thời gian tích lũy", 20 * width / 100);
            lsvLichSuTichDiem.Columns.Add("Số điểm tích lũy", 20 * width / 100);
            //lsvLichSuTichDiem.Columns.Add("Tổng điểm tích lũy", 20 * width / 100);
            lsvLichSuTichDiem.Columns.Add("Mã người dùng", 20 * width / 100);

            lsvLichSuTichDiem.View = View.Details;
            lsvLichSuTichDiem.FullRowSelect = true;
        }

        private void FLichSuTichDiem_Load(object sender, EventArgs e)
        {
            dsLichSuTichDiem = ctrlLichSuTichDiem.findall();
            foreach (CLichSuTichDiem s in dsLichSuTichDiem)
            {
                string[] obj = { s.IDLichSu, s.ThoiGianTichLuy.ToString(), s.SoDiemTichLuy.ToString(), s.ThanhVien.IDThanhVien };
                ListViewItem item = new ListViewItem(obj);
                lsvLichSuTichDiem.Items.Add(item);
            }
            txtTongSo.Text = lsvLichSuTichDiem.Items.Count.ToString();
        }

        private void txtSoDiemTichLuy_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lsvLichSuTichDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvLichSuTichDiem.SelectedItems[0];
                CLichSuTichDiem lichSuTichDiem = new CLichSuTichDiem();
                lichSuTichDiem.IDLichSu = item.SubItems[0].Text;
                int index = dsLichSuTichDiem.IndexOf(lichSuTichDiem);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                lichSuTichDiem = dsLichSuTichDiem[index];
                //hien thi len form
                txtIDLichSu.Text = lichSuTichDiem.IDLichSu;
                txtThoiGianTichLuy.Text = lichSuTichDiem.ThoiGianTichLuy.ToString();
                txtSoDiemTichLuy.Text = lichSuTichDiem.SoDiemTichLuy.ToString();
                //txtTongDiemTichLuy.Text = lichSuTichDiem.TongDiemTichLuy.ToString();
                txtIDThanhVien.Text = lichSuTichDiem.ThanhVien.IDThanhVien.ToString();

            }
            catch { }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            lsvLichSuTichDiem.Items.Clear();
            txtTongSo.Text = lsvLichSuTichDiem.Items.Count.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvLichSuTichDiem.SelectedItems[0];
                CLichSuTichDiem lichSuTichDiem = new CLichSuTichDiem();
                lichSuTichDiem.IDLichSu = item.SubItems[0].Text;
                int index = dsLichSuTichDiem.IndexOf(lichSuTichDiem);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                lichSuTichDiem = dsLichSuTichDiem[index];
                //gọi function kiểm tra dữ liệu hợp lệ
                // cập nhật thông tin
                lichSuTichDiem.IDLichSu = txtIDLichSu.Text;
                lichSuTichDiem.ThoiGianTichLuy = DateTime.Parse(txtThoiGianTichLuy.Text);
                lichSuTichDiem.SoDiemTichLuy = int.Parse(txtSoDiemTichLuy.Text);
                //lichSuTichDiem.TongDiemTichLuy = int.Parse(txtTongDiemTichLuy.Text);
                lichSuTichDiem.ThanhVien.IDThanhVien = lichSuTichDiem.ThanhVien.IDThanhVien;
                //cập nhật xuống dữ liệu
                if (ctrlLichSuTichDiem.update(lichSuTichDiem))
                {

                    //cập nhật dữ liệu trong lsv
                    item.SubItems[1].Text = lichSuTichDiem.IDLichSu;
                    item.SubItems[2].Text = lichSuTichDiem.ThoiGianTichLuy.ToString();
                    item.SubItems[3].Text = lichSuTichDiem.SoDiemTichLuy.ToString();
                    //item.SubItems[4].Text = lichSuTichDiem.TongDiemTichLuy.ToString();
                    item.SubItems[5].Text = lichSuTichDiem.ThanhVien.IDThanhVien;
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

                ListViewItem item = lsvLichSuTichDiem.SelectedItems[0];
                CLichSuTichDiem lichSuTichDiem = new CLichSuTichDiem();
                lichSuTichDiem.IDLichSu = item.SubItems[0].Text;
                int index = dsLichSuTichDiem.IndexOf(lichSuTichDiem);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                lichSuTichDiem = dsLichSuTichDiem[index];
                if (ctrlLichSuTichDiem.delete(lichSuTichDiem))
                {
                    dsLichSuTichDiem.Remove(lichSuTichDiem);
                    lsvLichSuTichDiem.Items.Remove(item);
                    txtTongSo.Text = lsvLichSuTichDiem.Items.Count.ToString();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {

                    MessageBox.Show("Xóa Thất Bại.");
                }
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //ktra tính hợp lệ của dữ liệu
                CLichSuTichDiem s = new CLichSuTichDiem(); 
                s.IDLichSu = txtIDLichSu.Text;
                s.ThoiGianTichLuy = DateTime.Parse(txtThoiGianTichLuy.Text);
                s.SoDiemTichLuy = int.Parse(txtSoDiemTichLuy.Text);
                //s.TongDiemTichLuy = int.Parse(txtTongDiemTichLuy.Text);
                s.ThanhVien = new CThanhVien();
                s.ThanhVien.IDThanhVien = txtIDThanhVien.Text;

                if (ctrlLichSuTichDiem.insert(s))
                {
                    string[] objsp = { s.IDLichSu, s.ThoiGianTichLuy.ToString(), s.SoDiemTichLuy.ToString(), s.ThanhVien.IDThanhVien };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvLichSuTichDiem.Items.Add(item);
                    dsLichSuTichDiem.Add(s);
                    txtTongSo.Text = lsvLichSuTichDiem.Items.Count.ToString();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkTim = txtTimKiem.Text;
                dsLichSuTichDiem = ctrlLichSuTichDiem.findCriteria(dkTim);
                //xóa lsv
                lsvLichSuTichDiem.Items.Clear();
                foreach (CLichSuTichDiem s in dsLichSuTichDiem)
                {
                    string[] obj = { s.IDLichSu, s.SoDiemTichLuy.ToString(), s.ThoiGianTichLuy.ToString(), s.ThanhVien.IDThanhVien };
                    ListViewItem item = new ListViewItem(obj);
                    lsvLichSuTichDiem.Items.Add(item);
                }
                txtTongSo.Text = lsvLichSuTichDiem.Items.Count.ToString();
            }
            catch
            {

            }
        }

        private void txtTongSo_Click(object sender, EventArgs e)
        {

        }
    }
}
