
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
        public partial class FSuatChieu : Form
        {
            CtrlSuatChieu ctrSuatChieu = new CtrlSuatChieu();
            List<CSuatChieu> dsSuatChieu = new List<CSuatChieu>();
            CtrlPhim ctrPhim = new CtrlPhim();
            CtrlRapChieuPhim ctrRapChieuPhim = new CtrlRapChieuPhim();
            List<CRapChieuPhim> dsRapChieuPhim = new List<CRapChieuPhim>();

            CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();
            List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();


            public FSuatChieu()
            {
                InitializeComponent();
                int width = lsvSuatChieu.Width;
                lsvSuatChieu.Columns.Add("ID suất chiếu", 13 * width / 100);
                lsvSuatChieu.Columns.Add("ID phim", 10 * width / 100);
                lsvSuatChieu.Columns.Add("ID rạp", 10 * width / 100);
                lsvSuatChieu.Columns.Add("ID phòng", 10 * width / 100);
                lsvSuatChieu.Columns.Add("Số lượng vé", 14 * width / 100);
                lsvSuatChieu.Columns.Add("Thời gian chiếu", 22 * width / 100);
                lsvSuatChieu.Columns.Add("Số lượng còn lại", 10 * width / 100);
                lsvSuatChieu.Columns.Add("Trạng thái", 12 * width / 100);


                lsvSuatChieu.View = View.Details;
                lsvSuatChieu.FullRowSelect = true;
            }

            private void txtIDSuatChieu_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnThoat_Click(object sender, EventArgs e)
            {
                this.Dispose();
            }
            private void CapNhatSoLuongSuatChieu()
            {
                txtTongSo.Text = dsSuatChieu.Count + "";
            }
            private void FSuatChieu_Load(object sender, EventArgs e)
            {
                dsSuatChieu = ctrSuatChieu.findAll();
                foreach (CSuatChieu s in dsSuatChieu)
                {
                    string[] obj = { s.IDSuatChieu, s.Phim.IDPhim, s.Rap.IDRap, s.Phong.IDPhong, s.SoLuongVe + "", s.ThoiGianChieu + "", s.SoLuongConLai + "", s.TrangThai };
                    ListViewItem item = new ListViewItem(obj);
                    lsvSuatChieu.Items.Add(item);
                    item.SubItems[0].Text = s.IDSuatChieu;
                    item.SubItems[1].Text = s.Phim.IDPhim;
                    item.SubItems[2].Text = s.Rap.IDRap;
                    item.SubItems[3].Text = s.Phong.IDPhong;
                    item.SubItems[4].Text = s.SoLuongVe + "";
                    item.SubItems[5].Text = s.ThoiGianChieu + "";
                    item.SubItems[6].Text = s.SoLuongConLai + "";
                    item.SubItems[7].Text = s.TrangThai;
                    CapNhatSoLuongSuatChieu();
                }
                List<CPhim> dsPhim = new List<CPhim>();
                dsPhim = ctrPhim.findAll();
                cmbIDPhim.DataSource = dsPhim;
                List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();
                dsRap = ctrRapChieuPhim.findall();
                cmbIDRap.DataSource = dsRap;
                List<CPhongChieu> dsPhong = new List<CPhongChieu>();
                dsPhong = ctrPhongChieu.findAll();
                cmbIDPhong.DataSource = dsPhong;
            }

            private void lsvSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    ListViewItem item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu sc = new CSuatChieu();
                    sc.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(sc);
                    if (index < 0)
                        return;
                    sc = dsSuatChieu[index];
                    txtIDSuatChieu.Text = sc.IDSuatChieu;
                    cmbIDPhim.Text = sc.Phim.IDPhim;
                    cmbIDRap.Text = sc.Rap.IDRap;
                    cmbIDPhong.Text = sc.Phong.IDPhong;
                    txtSoLuongVe.Text = sc.SoLuongVe + "";
                    dtThoiGianChieu.Text = sc.ThoiGianChieu + "";
                    txtSoLuongConLai.Text = sc.SoLuongConLai + "";
                    txtTrangThai.Text = sc.TrangThai;

                }
                catch { }
            }

            private void btnNhapMoi_Click(object sender, EventArgs e)
            {
                txtIDSuatChieu.Text = string.Empty;
                cmbIDPhim.Text = string.Empty;
                cmbIDRap.Text = string.Empty;
                cmbIDPhong.Text = string.Empty;
                txtSoLuongVe.Text = string.Empty;
                dtThoiGianChieu.Text = string.Empty;
                txtSoLuongConLai.Text = string.Empty;
                txtTrangThai.Text = string.Empty;
            }

            private void btnThem_Click(object sender, EventArgs e)
            {
                try
                {
                    string idSC = txtIDSuatChieu.Text;

                    string idPhim = cmbIDPhim.Text;
                    string idRap = cmbIDRap.Text;
                    string idPhong = cmbIDPhong.Text;
                    CPhim phim = new CPhim();
                    CRapChieuPhim rap = new CRapChieuPhim();
                    CPhongChieu phongChieu = new CPhongChieu();

                    int slVe = int.Parse(txtSoLuongVe.Text);
                    DateTime timeChieu = dtThoiGianChieu.Value;
                    int slVeConLai = int.Parse(txtSoLuongConLai.Text);
                    string trangThai = txtTrangThai.Text;
                    CSuatChieu s = new CSuatChieu(idSC, phim, rap, phongChieu, slVe, timeChieu, slVeConLai, trangThai);
                    if (ctrSuatChieu.insert(s))
                    {
                        MessageBox.Show("Thêm thông tin suất chiếu thành công.");
                        string[] objsc = { idSC, idPhim, idRap, idPhong, slVe + "", timeChieu + "", slVeConLai + "", trangThai };
                        ListViewItem item = new ListViewItem(objsc);
                        lsvSuatChieu.Items.Add(item);
                        dsSuatChieu.Add(s);
                    }
                    else
                        MessageBox.Show("Thêm thông tin suất chiếu thất bại.");
                    CapNhatSoLuongSuatChieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm thông tin suất chiếu.\n" + ex.Message);
                }
            }

            private void cmbIDPhim_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                try
                {
                    ListViewItem item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu SC = new CSuatChieu();
                    SC.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(SC);
                    // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                    if (index < 0) { return; }

                    //
                    SC = dsSuatChieu[index];
                    if (ctrSuatChieu.delete(SC))
                    {
                        MessageBox.Show("Xóa thành công");
                        dsSuatChieu.Remove(SC);
                        lsvSuatChieu.Items.Remove(item);

                    }
                    else MessageBox.Show("Xóa thất bại!");

                }
                catch { }
            }

            private void btnCapNhat_Click(object sender, EventArgs e)
            {
                try
                {
                    ListViewItem item = lsvSuatChieu.SelectedItems[0];
                    CSuatChieu suatChieu = new CSuatChieu();
                    suatChieu.IDSuatChieu = item.SubItems[0].Text;
                    int index = dsSuatChieu.IndexOf(suatChieu);
                    // tìm kiếm phần tử được chọn ở vị trí nào trong ds
                    if (index < 0) { return; }

                    //
                    suatChieu = dsSuatChieu[index];
                    suatChieu.Phim.IDPhim = cmbIDPhim.Text;
                    suatChieu.Rap.IDRap = cmbIDRap.Text;
                    suatChieu.Phong.IDPhong = cmbIDPhong.Text;
                    suatChieu.SoLuongVe = int.Parse(txtSoLuongVe.Text);
                    suatChieu.ThoiGianChieu = dtThoiGianChieu.Value;
                    suatChieu.SoLuongConLai = int.Parse(txtSoLuongConLai.Text);
                    suatChieu.TrangThai = txtTrangThai.Text;

                    if (ctrSuatChieu.update(suatChieu))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        item.SubItems[1].Text = suatChieu.Phim.IDPhim;
                        item.SubItems[2].Text = suatChieu.Rap.IDRap;
                        item.SubItems[3].Text = suatChieu.Phong.IDPhong;
                        item.SubItems[3].Text = suatChieu.SoLuongVe + "";
                        item.SubItems[3].Text = suatChieu.ThoiGianChieu + "";
                        item.SubItems[3].Text = suatChieu.SoLuongConLai + "";
                        item.SubItems[3].Text = suatChieu.TrangThai;

                    }

                    else
                        MessageBox.Show("Cập nhật thất bại!!!");
                }
                catch
                {

                }
            }
        }
    }
}
}
