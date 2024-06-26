﻿using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FVeXemPhim : Form
    {
        CtrlVeXemPhim ctrlVeXemPhim = new CtrlVeXemPhim();
        CtrlThanhVien ctrlThanhVien = new CtrlThanhVien();
        CtrlPhim ctrPhim = new CtrlPhim();
        CtrlSuatChieu ctrSuatChieu = new CtrlSuatChieu();
        CtrlChoNgoi ctrlChoNgoi = new CtrlChoNgoi();

        List<CVeXemPhim> dsVeXemPhim = new List<CVeXemPhim>();
        public FVeXemPhim()
        {
            InitializeComponent();
            int width = lsvVeXemPhim.Width;
            lsvVeXemPhim.Columns.Add("Mã vé", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã thành viên", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã phim", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã suất chiếu", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Mã chỗ ngồi", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Giá vé", 14 * width / 100);
            lsvVeXemPhim.Columns.Add("Tình trạng", 14 * width / 100);


            lsvVeXemPhim.View = View.Details;
            lsvVeXemPhim.FullRowSelect = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIDVe.Text == "" || txtIDThanhVien.Text == "" || txtIDPhim.Text == "" || txtIDSuatChieu.Text == "" || txtIDChoNgoi.Text == "" || txtGiaVe.Text == "" || txtTinhTrang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin vé!");
                    return;
                }

                //ktra tính hợp lệ của dữ liệu
                string idve = txtIDVe.Text;
                string idthanhvien = txtIDThanhVien.Text;
                string idphim = txtIDPhim.Text;
                string idsuatchieu = txtIDSuatChieu.Text;
                string idchongoi = txtIDChoNgoi.Text;
                int giave = int.Parse(txtGiaVe.Text);
                string tinhtrang = txtTinhTrang.Text;
                //tạo sp
                CVeXemPhim s = new CVeXemPhim(
                        idve,
                        idthanhvien,
                        idphim,
                        idsuatchieu,
                        idchongoi,
                        giave.ToString(),
                        tinhtrang
                    );
                if (ctrlVeXemPhim.insert(s))
                {
                    string[] objsp = {
                        idve,
                        idthanhvien,
                        idphim,
                        idsuatchieu,
                        idchongoi,
                        giave.ToString(),
                        tinhtrang };
                    ListViewItem item = new ListViewItem(objsp);
                    lsvVeXemPhim.Items.Add(item);
                    dsVeXemPhim.Add(s);
                    txtTongSo.Text = lsvVeXemPhim.Items.Count.ToString();
                    MessageBox.Show("Thêm thông tin vé thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin vé thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FVeXemPhim_Load(object sender, EventArgs e)
        {
            txtIDVe.Focus();
            dsVeXemPhim = ctrlVeXemPhim.findall();
            foreach (CVeXemPhim s in dsVeXemPhim)
            {
                string[] obj = {
                    s.IDVe,
                    s.ThanhVien.IDThanhVien,
                    s.Phim.IDPhim,
                    s.SuatChieu.IDSuatChieu,
                    s.ChoNgoi.IDChoNgoi,
                    s.GiaVe.ToString(),
                    s.TinhTrang
                };
                ListViewItem item = new ListViewItem(obj);
                lsvVeXemPhim.Items.Add(item);
            }

            txtTongSo.Text = lsvVeXemPhim.Items.Count.ToString();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkTim = txtTimKiem.Text;
                dsVeXemPhim = ctrlVeXemPhim.findCriteria(dkTim);
                //xóa lsv
                lsvVeXemPhim.Items.Clear();
                foreach (CVeXemPhim s in dsVeXemPhim)
                {
                    string[] obj = {
                        s.IDVe,
                        s.ThanhVien.IDThanhVien,
                        s.Phim.IDPhim,
                        s.SuatChieu.IDSuatChieu,
                        s.ChoNgoi.IDChoNgoi,
                        s.GiaVe.ToString(),
                        s.TinhTrang
                    };
                    ListViewItem item = new ListViewItem(obj);
                    lsvVeXemPhim.Items.Add(item);
                }
                txtTongSo.Text = lsvVeXemPhim.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }   
        }

        private void lsvVeXemPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvVeXemPhim.SelectedItems.Count > 0)
            {
                CVeXemPhim veXemPhim = new CVeXemPhim();
                try
                {
                    ListViewItem item = lsvVeXemPhim.SelectedItems[0];
                    veXemPhim.IDVe = item.SubItems[0].Text;
                    int index = dsVeXemPhim.IndexOf(veXemPhim);
                    if (index < 0)
                    {
                        return;
                    }

                    veXemPhim = dsVeXemPhim[index];

                    txtIDVe.Text = veXemPhim.IDVe;
                    txtIDThanhVien.Text = veXemPhim.ThanhVien.IDThanhVien;
                    txtIDPhim.Text = veXemPhim.Phim.IDPhim;
                    txtIDSuatChieu.Text = veXemPhim.SuatChieu.IDSuatChieu;
                    txtIDChoNgoi.Text = veXemPhim.ChoNgoi.IDChoNgoi;
                    txtGiaVe.Text = veXemPhim.GiaVe.ToString();
                    txtTinhTrang.Text = veXemPhim.TinhTrang;

                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Lỗi: " + ex.Message); 
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(lsvVeXemPhim.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin vé cần cập nhật.");
                return;
            }
            CVeXemPhim veXemPhim = new CVeXemPhim();
            try
            {
                ListViewItem item = lsvVeXemPhim.SelectedItems[0];
                veXemPhim.IDVe = item.SubItems[0].Text;
                int index = dsVeXemPhim.IndexOf(veXemPhim);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                veXemPhim = dsVeXemPhim[index];
                //gọi function kiểm tra dữ liệu hợp lệ
                // cập nhật thông tin
                veXemPhim.IDVe = txtIDVe.Text;
                veXemPhim.ThanhVien.IDThanhVien = txtIDThanhVien.Text;
                veXemPhim.Phim.IDPhim = txtIDPhim.Text;
                veXemPhim.SuatChieu.IDSuatChieu = txtIDSuatChieu.Text;
                veXemPhim.ChoNgoi.IDChoNgoi = txtIDChoNgoi.Text;
                veXemPhim.GiaVe = decimal.Parse(txtGiaVe.Text);
                veXemPhim.TinhTrang = txtTinhTrang.Text;
                //cập nhật xuống dữ liệu
                if (ctrlVeXemPhim.update(veXemPhim))
                {
                    //cập nhật dữ liệu trong lsv
                    item.SubItems[1].Text = veXemPhim.ThanhVien.IDThanhVien;
                    item.SubItems[2].Text = veXemPhim.Phim.IDPhim;
                    item.SubItems[3].Text = veXemPhim.SuatChieu.IDSuatChieu;
                    item.SubItems[4].Text = veXemPhim.GiaVe.ToString();
                    item.SubItems[5].Text = veXemPhim.ChoNgoi.IDChoNgoi;
                    item.SubItems[6].Text = veXemPhim.TinhTrang;
                    MessageBox.Show("Cập nhật thông tin vé thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin vé thất bại!");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Lỗi: " + ex.Message); 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvVeXemPhim.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin vé cần xóa.");
                return;
            }
            CVeXemPhim veXemPhim = new CVeXemPhim();
            try
            {
                ListViewItem item = lsvVeXemPhim.SelectedItems[0];
                veXemPhim.IDVe = item.SubItems[0].Text;
                int index = dsVeXemPhim.IndexOf(veXemPhim);
                // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                if (index < 0)
                {
                    return;
                }
                veXemPhim = dsVeXemPhim[index];
                if (ctrlVeXemPhim.delete(veXemPhim))
                {
                    dsVeXemPhim.Remove(veXemPhim);
                    lsvVeXemPhim.Items.Remove(item);
                    txtTongSo.Text = lsvVeXemPhim.Items.Count.ToString();
                    MessageBox.Show("Xóa thông tin vé thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thông tin vé thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e) 
        {
            txtIDVe.Text = "";
            txtIDThanhVien.Text = "";
            txtIDPhim.Text = "";
            txtIDSuatChieu.Text = "";
            txtIDChoNgoi.Text = "";
            txtGiaVe.Text = "";
            txtTinhTrang.Text = "";
            txtIDVe.Focus();
        }
    }
}
