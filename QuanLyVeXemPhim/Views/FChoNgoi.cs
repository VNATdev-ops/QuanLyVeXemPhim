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
    public partial class FChoNgoi : Form
    {
        CtrlChoNgoi ctrChoNgoi = new CtrlChoNgoi();
        List<CChoNgoi> dsChoNgoi = new List<CChoNgoi>();
        public FChoNgoi()
        {
            InitializeComponent();
            int width = lsvDanhSachCN.Width;
            lsvDanhSachCN.Columns.Add("ID Ghế", 15 * width / 100);
            lsvDanhSachCN.Columns.Add("ID Phòng", 15 * width / 100);
            lsvDanhSachCN.Columns.Add("Loại ghế", 35 * width / 100);
            lsvDanhSachCN.Columns.Add("Vị trí", 35 * width / 100);

            lsvDanhSachCN.View = View.Details;
            lsvDanhSachCN.FullRowSelect = true;
        }

        private void FChoNgoi_Load(object sender, EventArgs e)
        {
            dsChoNgoi = ctrChoNgoi.findAll();
            foreach (CChoNgoi s in dsChoNgoi)
            {
                string[] obj = { s.IDChoNgoi, s.Phong.IDPhong, s.LoaiChoNgoi, s.ViTri };
                ListViewItem item = new ListViewItem(obj);
                lsvDanhSachCN.Items.Add(item);
            }

            txtTongSo.Text = lsvDanhSachCN.Items.Count.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dkFind = txtTimKiem.Text;
                dsChoNgoi = ctrChoNgoi.findCriteria(dkFind);

                //xóa listview
                lsvDanhSachCN.Items.Clear();
                foreach (CChoNgoi s in dsChoNgoi)
                {
                    string[] obj = { s.IDChoNgoi, s.Phong.IDPhong, s.LoaiChoNgoi, s.ViTri };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDanhSachCN.Items.Add(item);
                }
            }
            catch { }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maCN = txtIDchongoi.Text;
            string maPhong = txtIDphong.Text;
            string loaiChoNgoi = txtLoaiChoNgoi.Text;
            string viTri = txtVitri.Text;
            CChoNgoi choNgoi = new CChoNgoi();
            choNgoi.IDChoNgoi = maCN;
            choNgoi.Phong = new CPhongChieu();
            choNgoi.Phong.IDPhong = maPhong;
            choNgoi.LoaiChoNgoi = loaiChoNgoi;
            choNgoi.ViTri = viTri;
            if (ctrChoNgoi.insert(choNgoi))
            {
                string[] objCN = { maCN, maPhong, loaiChoNgoi, viTri };
                ListViewItem item = new ListViewItem(objCN);
                lsvDanhSachCN.Items.Add(item);
                dsChoNgoi.Add(choNgoi);
                txtTongSo.Text = lsvDanhSachCN.Items.Count.ToString();
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            {
                try
                {

                    ListViewItem item = lsvDanhSachCN.SelectedItems[0];
                    CChoNgoi choNgoi = new CChoNgoi();
                    choNgoi.IDChoNgoi = item.SubItems[0].Text;
                    int index = dsChoNgoi.IndexOf(choNgoi);
                    if (index < 0)
                    {
                        return;
                    }
                    choNgoi = dsChoNgoi[index];
                    if (ctrChoNgoi.delete(choNgoi))
                    {
                        dsChoNgoi.Remove(choNgoi);
                        lsvDanhSachCN.Items.Remove(item);
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else
                    {

                        MessageBox.Show("Xóa Thất Bại.");
                    }

                    txtTongSo.Text = lsvDanhSachCN.Items.Count.ToString();
                }
                catch
                {

                }
            }
        }

        private void lsvDanhSachCN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDanhSachCN.SelectedItems[0];
                CChoNgoi choNgoi = new CChoNgoi();
                choNgoi.IDChoNgoi = item.SubItems[0].Text;
                int index = dsChoNgoi.IndexOf(choNgoi);
                if (index < 0)
                {
                    return;
                }
                choNgoi = dsChoNgoi[index];

                txtIDchongoi.Text = choNgoi.IDChoNgoi;
                txtIDphong.Text = choNgoi.Phong.IDPhong;
                txtLoaiChoNgoi.Text = choNgoi.LoaiChoNgoi;
                txtVitri.Text = choNgoi.ViTri;

            }
            catch
            {

            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDchongoi.Text = string.Empty;
            txtIDphong.Text = string.Empty;
            txtLoaiChoNgoi.Text = string.Empty;
            txtVitri.Text = string.Empty;
            txtTongSo.Text = lsvDanhSachCN.Items.Count.ToString();

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = lsvDanhSachCN.SelectedItems[0];
            CChoNgoi choNgoi = new CChoNgoi();
            choNgoi.IDChoNgoi = item.SubItems[0].Text;
            int index = dsChoNgoi.IndexOf(choNgoi);
            if (index < 0)
            {
                return;
            }
            choNgoi = dsChoNgoi[index];
            choNgoi.Phong = new CPhongChieu();
            choNgoi.Phong.IDPhong = txtIDphong.Text;
            choNgoi.LoaiChoNgoi = txtLoaiChoNgoi.Text;
            choNgoi.ViTri = txtVitri.Text;
            if (ctrChoNgoi.update(choNgoi))
            {
                item.SubItems[1].Text = choNgoi.Phong.IDPhong;
                item.SubItems[2].Text = choNgoi.LoaiChoNgoi;
                item.SubItems[3].Text = choNgoi.ViTri;
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show(" cập nhật thất bại");
            }
        }
    }
}