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
    public partial class FPhongChieu : Form
    {
        CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();
        CtrlRapChieuPhim ctrRapChieuPhim = new CtrlRapChieuPhim();
        List<CPhongChieu> dsPhongChieu = new List<CPhongChieu>();
        List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();
        public FPhongChieu()
        {
            InitializeComponent();
            int width = lsvDanhSachPC.Width;
            lsvDanhSachPC.Columns.Add("ID Phòng", 19 * width / 100);
            lsvDanhSachPC.Columns.Add("ID Rạp", 20 * width / 100);
            lsvDanhSachPC.Columns.Add("Tên phòng", 20 * width / 100);
            lsvDanhSachPC.Columns.Add("Loại phòng", 20 * width / 100);
            lsvDanhSachPC.Columns.Add("Số lượng ghế", 20 * width / 100);

            lsvDanhSachPC.View = View.Details;
            lsvDanhSachPC.FullRowSelect = true;
        }
        private void CapNhatSoLuongPhong()
        {
            txtTongSo.Text = dsPhongChieu.Count.ToString();
        }

        private void FPhongChieu_Load(object sender, EventArgs e)
        {
            try
            {
                dsPhongChieu = ctrPhongChieu.findAll();
                foreach (CPhongChieu s in dsPhongChieu)
                {
                    string[] obj = { s.IDPhong, s.Rap.IDRap, s.TenPhong, s.LoaiPhong, s.SoLuongGhe.ToString() };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDanhSachPC.Items.Add(item);
                    item.SubItems[0].Text = s.IDPhong;
                    item.SubItems[1].Text = s.Rap.IDRap;
                    item.SubItems[2].Text = s.TenPhong;
                    item.SubItems[3].Text = s.LoaiPhong;
                    item.SubItems[4].Text = s.SoLuongGhe.ToString();
                }
                CapNhatSoLuongPhong();
            }
            catch { }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDanhSachPC.SelectedItems[0];
                CPhongChieu pc = new CPhongChieu();
                pc.IDPhong = item.SubItems[0].Text;
                int index = dsPhongChieu.IndexOf(pc);
                if (index < 0)
                    return;
                pc = dsPhongChieu[index];

                txtIDphong.Text = pc.IDPhong;
                txtIDrap.Text = pc.Rap.IDRap;
                txtTenPhong.Text = pc.TenPhong;
                txtLoaiPhong.Text = pc.LoaiPhong;
                txtSoLuongGhe.Text = pc.SoLuongGhe.ToString();

                CapNhatSoLuongPhong();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idphong = txtIDphong.Text;
                string idrap = txtIDrap.Text;
                string tenphong = txtTenPhong.Text;
                string loaiphong = txtLoaiPhong.Text;
                int soluongghe = int.Parse(txtSoLuongGhe.Text);

                //
                dsRap = ctrRapChieuPhim.findall();
                CRapChieuPhim rap = dsRap.FirstOrDefault(r => r.IDRap == idrap);
                if (txtIDrap.Text != null && txtIDrap.Text != "")
                {
                    rap = dsRap.FirstOrDefault(r => r.IDRap == txtIDrap.Text);
                    if (rap == null)
                    {
                        MessageBox.Show("Không tìm thấy rạp chiếu phim này.");
                        txtIDrap.Clear();
                        txtIDrap.Focus();
                        return;
                    }
                }
                else
                {
                    // Xử lý trường hợp giá trị null hoặc rỗng của txtIDrap.Text
                    MessageBox.Show("Vui lòng nhập ID rạp chiếu phim.");
                    txtIDrap.Focus();
                    return;
                }



                CPhongChieu s = new CPhongChieu(idphong, rap, tenphong, loaiphong, soluongghe);
                if (ctrPhongChieu.insert(s))
                {
                    MessageBox.Show("Thêm thông tin phòng chiếu thành công.");
                    string[] objpc = { idphong, rap.IDRap, tenphong, loaiphong, soluongghe.ToString() };
                    ListViewItem item = new ListViewItem(objpc);
                    lsvDanhSachPC.Items.Add(item);
                    dsPhongChieu.Add(s);
                }
                else
                    MessageBox.Show("Thêm thông tin phòng chiếu thất bại.");
                CapNhatSoLuongPhong();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm thông tin phòng chiếu.");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvDanhSachPC.SelectedItems[0];
                CPhongChieu pc = new CPhongChieu();
                pc.IDPhong = item.SubItems[0].Text;
                int index = dsPhongChieu.IndexOf(pc);
                if (index < 0)
                    return;
                pc = dsPhongChieu[index];
                //
                dsRap = ctrRapChieuPhim.findall();
                pc.IDPhong = txtIDphong.Text;
                CRapChieuPhim rap = new CRapChieuPhim();
                rap = dsRap.FirstOrDefault(r => r.IDRap == txtIDrap.Text);
                pc.Rap = rap;
                pc.TenPhong = txtTenPhong.Text;
                pc.LoaiPhong = txtLoaiPhong.Text;
                pc.SoLuongGhe = int.Parse(txtSoLuongGhe.Text);

                if (ctrPhongChieu.update(pc))
                {
                    MessageBox.Show("Cập nhật thông tin phòng chiếu thành công.");
                    item.SubItems[1].Text = pc.Rap.IDRap;
                    item.SubItems[2].Text = pc.TenPhong;
                    item.SubItems[3].Text = pc.LoaiPhong;
                    item.SubItems[4].Text = pc.SoLuongGhe.ToString();
                }
                else
                    MessageBox.Show("Cập nhật thông tin phòng chiếu thất bại.");
                CapNhatSoLuongPhong();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật thông tin phòng chiếu.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachPC.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDanhSachPC.SelectedItems[0];
                    CPhongChieu pc = new CPhongChieu();
                    pc.IDPhong = item.SubItems[0].Text;
                    int index = dsPhongChieu.IndexOf(pc);
                    if (index < 0)
                        return;
                    pc = dsPhongChieu[index];
                    if (ctrPhongChieu.delete(pc))
                    {
                        MessageBox.Show("Xóa thông tin phòng chiếu thành công.");
                        dsPhongChieu.Remove(pc);
                        lsvDanhSachPC.Items.RemoveAt(index);
                    }
                    else
                        MessageBox.Show("Xóa thông tin phòng chiếu thất bại.");
                }
                else
                    MessageBox.Show("Vui lòng chọn một phòng chiếu để xóa.");
                CapNhatSoLuongPhong();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin phòng chiếu.");
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtIDphong.Clear();
            txtIDrap.Clear();
            txtTenPhong.Clear();
            txtLoaiPhong.Clear();
            txtSoLuongGhe.Clear();
            txtTimKiem.Clear();
            txtIDrap.Focus();
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
                dsPhongChieu = ctrPhongChieu.findCriteria(dkTim);
                lsvDanhSachPC.Items.Clear();
                foreach (CPhongChieu s in dsPhongChieu)
                {
                    string[] obj = { s.IDPhong, s.Rap.IDRap, s.TenPhong, s.LoaiPhong, s.SoLuongGhe.ToString() };
                    ListViewItem item = new ListViewItem(obj);
                    lsvDanhSachPC.Items.Add(item);
                    item.SubItems[0].Text = s.IDPhong;
                    item.SubItems[1].Text = s.Rap.IDRap;
                    item.SubItems[2].Text = s.TenPhong;
                    item.SubItems[3].Text = s.LoaiPhong;
                    item.SubItems[4].Text = s.SoLuongGhe.ToString();
                }
            }
            catch
            {

            }
        }
    }
}