using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FHoaDon : Form
    {
        CtrlHoaDon ctrHoaDon = new CtrlHoaDon();
        CtrlCTHDVe ctrCTHDVe = new CtrlCTHDVe();
        CtrlNhanVien ctrNhanVien = new CtrlNhanVien();
        CtrlThanhVien ctrThanhVien = new CtrlThanhVien();
        CtrlVeXemPhim ctrVeXemPhim = new CtrlVeXemPhim();
        CtrlThucAnDoUong ctrThucAnDoUong = new CtrlThucAnDoUong();
        CtrlCTHDThucAnDoUong ctrCTHDSanPham = new CtrlCTHDThucAnDoUong();
        List<CHoaDon> dsHoaDon = new List<CHoaDon>();
        List<CCTHDVe> dscthdVe = new List<CCTHDVe>();
        List<CNhanVien> dsNhanVien = new List<CNhanVien>();
        List<CThanhVien> dsThanhVien = new List<CThanhVien>();
        List<CCTHDThucAnDoUong> dscthdSanPham = new List<CCTHDThucAnDoUong>();
        List<CPhim> dsPhim = new List<CPhim>();
        List<CVeXemPhim> dsVe = new List<CVeXemPhim>();
        List<CThucAnDoUong> dsSanPham = new List<CThucAnDoUong>();
        public FHoaDon()
        {
            InitializeComponent();
            //khai bao cot chi tiet hoa don
            int widthCT = lsvChiTietHD.Width;
            lsvChiTietHD.Columns.Add("ID sản phẩm", 10 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Tên sản phẩm", 30 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Giá bán", 10 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Số lượng", 19 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Thành tiền", 20 * widthCT / 100);
            lsvChiTietHD.View = View.Details;
            lsvChiTietHD.FullRowSelect = true;

            //khai bao cot danh sach hoa don
            int widthDS = lsvDanhSachHD.Width;
            lsvDanhSachHD.Columns.Add("ID hóa đơn", 30 * widthDS / 100);
            lsvDanhSachHD.Columns.Add("Ngày xuất hóa đơn", 30 * widthDS / 100);
            lsvDanhSachHD.Columns.Add("ID Nhân viên", 20 * widthDS / 100);
            lsvDanhSachHD.Columns.Add("ID Thành viên", 20 * widthDS / 100);
            lsvDanhSachHD.View = View.Details;
            lsvDanhSachHD.FullRowSelect = true;

        }
        private void CapNhatSoLuongHD()
        {
            txtSoLuongHD.Text = dsHoaDon.Count.ToString();
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            dsNhanVien = ctrNhanVien.findall();
            dsThanhVien = ctrThanhVien.findall();
            dsVe = ctrVeXemPhim.findall();
            dsSanPham = ctrThucAnDoUong.findAll();

            //hien thi so hoa don
            txtSoHD.Text = TaoSoHD().ToString();
            dTimeNgayHD.Value = DateTime.Today;
            txtTriGiaHD.Text = "0";
            txtSoLuong.Text = 1 + "";

            //hien thi danh sach khach hang
            List<CThanhVien> dstv = new List<CThanhVien>();
            dstv = ctrThanhVien.findall();
            cbTheThanhVien.DataSource = dstv;

            dsHoaDon = ctrHoaDon.findAll();
            foreach (CHoaDon s in dsHoaDon)
            {
                string[] obj = { s.IDHoaDon, s.NgayXuatHD.ToString(), s.NhanVien != null ? s.NhanVien.IDNhanVien : "", s.ThanhVien != null ? s.ThanhVien.IDThanhVien : "" };

                ListViewItem item = new ListViewItem(obj);
                lsvDanhSachHD.Items.Add(item);
                item.SubItems[0].Text = s.IDHoaDon;
                item.SubItems[1].Text = s.NgayXuatHD.ToString();
                item.SubItems[2].Text = s.NhanVien != null ? s.NhanVien.IDNhanVien : "N/A";
                item.SubItems[3].Text = s.ThanhVien != null ? s.ThanhVien.IDThanhVien : "N/A";

            }
            CapNhatSoLuongHD();
        }
        private int TaoSoHD()
        {
            string str = string.Format("{0:MMddhhmmss}", DateTime.Now);
            return int.Parse(str);
        }
        private void lsvDanhSachHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachHD.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lsvDanhSachHD.SelectedItems[0];
                    string selectedHoaDonID = selectedItem.SubItems[0].Text;
                    CHoaDon hd = new CHoaDon();
                    hd.IDHoaDon = selectedHoaDonID;

                    int index = dsHoaDon.IndexOf(hd);
                    if (index < 0)
                        return;
                    hd = dsHoaDon[index];

                    txtSoHD.Text = hd.IDHoaDon;
                    dTimeNgayHD.Value = hd.NgayXuatHD;
                    if (hd.ThanhVien != null)
                    {
                        cbTheThanhVien.Text = hd.ThanhVien.IDThanhVien;
                    }
                    else
                    {
                        cbTheThanhVien.SelectedItem = null;
                    }
                    if (hd.NhanVien != null)
                    {
                        txtNVXuatHD.Text = hd.NhanVien.IDNhanVien;
                    }
                    else
                    {
                        txtNVXuatHD.Text = "N/A";
                    }

                    // Xóa các lựa chọn trước đó trong danh sách chi tiết hóa đơn
                    lsvChiTietHD.Items.Clear();

                    // Lấy danh sách chi tiết hóa đơn từ CtrlCTHDSanPham
                    List<CCTHDThucAnDoUong> dscthdSanPham = ctrCTHDSanPham.findCriteria(selectedHoaDonID);
                    foreach (CCTHDThucAnDoUong chiTietSanPham in dscthdSanPham)
                    {
                        string[] obj = {
                    chiTietSanPham.SanPham.IDSanPham,
                    chiTietSanPham.SanPham.TenSanPham,
                    chiTietSanPham.SanPham.Gia.ToString(),
                    chiTietSanPham.SoLuong.ToString(),
                    (chiTietSanPham.SoLuong * chiTietSanPham.SanPham.Gia).ToString()
                };
                        ListViewItem item = new ListViewItem(obj);
                        lsvChiTietHD.Items.Add(item);
                    }

                    // Cập nhật tổng giá trị hóa đơn
                    CapNhatTongGiaTriHoaDon();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void CapNhatTongGiaTriHoaDon()
        {
            // Khởi tạo tổng giá trị hóa đơn
            decimal tongGiaTriHoaDon = 0;

            // Lặp qua từng mục trong ListView chi tiết hóa đơn để tính tổng giá trị
            foreach (ListViewItem item in lsvChiTietHD.Items)
            {
                // Lấy giá trị thành tiền từ cột cuối cùng
                decimal thanhTien = decimal.Parse(item.SubItems[item.SubItems.Count - 1].Text);
                tongGiaTriHoaDon += thanhTien;
            }

            // Hiển thị tổng giá trị hóa đơn trên TextBox
            txtTriGiaHD.Text = tongGiaTriHoaDon.ToString();
        }


        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            List<CVeXemPhim> dsVeXemPhim = new List<CVeXemPhim>();
            dsVeXemPhim = ctrVeXemPhim.findCriteria(txtTenSP.Text);

            List<CThucAnDoUong> dsThucAnDoUong = new List<CThucAnDoUong>();
            dsThucAnDoUong = ctrThucAnDoUong.findCriteria(txtTenSP.Text);

            if (dsVeXemPhim.Count > 0 || dsThucAnDoUong.Count > 0)
            {
                lstSanPham.Items.Clear();
                foreach (CVeXemPhim veXemPhim in dsVeXemPhim)
                {
                    // Thêm dữ liệu từ CVeXemPhim vào danh sách
                    lstSanPham.Items.Add(veXemPhim);
                }

                foreach (CThucAnDoUong thucAnDoUong in dsThucAnDoUong)
                {
                    // Thêm dữ liệu từ CThucAnDoUong vào danh sách
                    lstSanPham.Items.Add(thucAnDoUong);
                }
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            List<CVeXemPhim> dsVeXemPhim = new List<CVeXemPhim>();
            dsVeXemPhim = ctrVeXemPhim.findCriteria(txtMaSP.Text);

            List<CThucAnDoUong> dsThucAnDoUong = new List<CThucAnDoUong>();
            dsThucAnDoUong = ctrThucAnDoUong.findCriteria(txtMaSP.Text);

            if (dsVeXemPhim.Count > 0 || dsThucAnDoUong.Count > 0)
            {
                lstSanPham.Items.Clear();
                foreach (CVeXemPhim veXemPhim in dsVeXemPhim)
                {
                    // Thêm dữ liệu từ CVeXemPhim vào danh sách
                    lstSanPham.Items.Add(veXemPhim);
                }

                foreach (CThucAnDoUong thucAnDoUong in dsThucAnDoUong)
                {
                    // Thêm dữ liệu từ CThucAnDoUong vào danh sách
                    lstSanPham.Items.Add(thucAnDoUong);
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn sản phẩm hay chưa
            if (lstSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.");
                return;
            }

            // Lấy thông tin sản phẩm từ danh sách
            if (lstSanPham.SelectedItem is CVeXemPhim)
            {
                // Lấy thông tin vé xem phim
                CVeXemPhim sp = (CVeXemPhim)lstSanPham.SelectedItem;
                CCTHDVe cthdVe = new CCTHDVe();
                CHoaDon hd = new CHoaDon();
                hd.IDHoaDon = txtSoHD.Text;
                hd.NgayXuatHD = dTimeNgayHD.Value;

                // Lấy thông tin thành viên từ combobox thành viên
                CThanhVien tv = null;
                CNhanVien nv = null;

                if (cbTheThanhVien.SelectedItem != null)
                {
                    tv = (CThanhVien)cbTheThanhVien.SelectedItem;
                }

                if (!string.IsNullOrEmpty(txtIDNhanVien.Text))
                {
                    nv = dsNhanVien.FirstOrDefault(nv => nv.IDNhanVien == txtIDNhanVien.Text);
                }

                hd.ThanhVien = tv;
                hd.NhanVien = nv;

                cthdVe.HoaDon = hd;
                cthdVe.Ve = sp;
                cthdVe.SoLuong = int.Parse(txtSoLuong.Text);

                // Nếu sản phẩm chưa có trong chi tiết hóa đơn vé, thêm vào danh sách chi tiết hóa đơn vé
                if (!dscthdVe.Contains(cthdVe))
                {
                    dscthdVe.Add(cthdVe);

                    string[] obj = { sp.IDVe, sp.Phim.TenPhim, sp.GiaVe.ToString(), cthdVe.SoLuong.ToString(), (cthdVe.SoLuong * sp.GiaVe).ToString() };
                    ListViewItem item = new ListViewItem(obj);
                    lsvChiTietHD.Items.Add(item);

                    txtTriGiaHD.Text = (int.Parse(txtTriGiaHD.Text) + cthdVe.SoLuong * sp.GiaVe).ToString();
                }
                else // Đã được chọn trong chi tiết hóa đơn vé
                {
                    int index = dscthdVe.IndexOf(cthdVe);
                    ListViewItem item = lsvChiTietHD.Items[index];
                    cthdVe = dscthdVe[index];
                    cthdVe.SoLuong += int.Parse(txtSoLuong.Text);

                    txtTriGiaHD.Text = (int.Parse(txtTriGiaHD.Text)) + (int.Parse(txtSoLuong.Text) * sp.GiaVe).ToString();

                    item.SubItems[3].Text = cthdVe.SoLuong.ToString();
                    item.SubItems[4].Text = (cthdVe.SoLuong * sp.GiaVe).ToString();
                }
            }
            else if (lstSanPham.SelectedItem is CThucAnDoUong)
            {
                CThucAnDoUong sp = (CThucAnDoUong)lstSanPham.SelectedItem;
                CCTHDThucAnDoUong cthdSanPham = new CCTHDThucAnDoUong();

                CHoaDon hd = new CHoaDon();
                hd.IDHoaDon = txtSoHD.Text;
                hd.NgayXuatHD = dTimeNgayHD.Value;

                CThanhVien tv = null;
                CNhanVien nv = null;

                if (cbTheThanhVien.SelectedItem != null)
                {
                    tv = (CThanhVien)cbTheThanhVien.SelectedItem;
                }

                if (!string.IsNullOrEmpty(txtIDNhanVien.Text))
                {
                    nv = dsNhanVien.FirstOrDefault(nv => nv.IDNhanVien == txtIDNhanVien.Text);
                }

                hd.ThanhVien = tv;
                hd.NhanVien = nv;

                cthdSanPham.HoaDon = hd;
                cthdSanPham.SanPham = sp;
                try
                {
                    cthdSanPham.SoLuong = int.Parse(txtSoLuong.Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm.");
                    txtSoLuong.Focus();
                }

                // Nếu sản phẩm chưa có trong chi tiết hóa đơn sản phẩm, thêm vào danh sách chi tiết hóa đơn sản phẩm
                if (!dscthdSanPham.Contains(cthdSanPham))
                {
                    dscthdSanPham.Add(cthdSanPham);

                    string[] obj = { sp.IDSanPham, sp.TenSanPham, sp.Gia.ToString(), cthdSanPham.SoLuong.ToString(), (cthdSanPham.SoLuong * sp.Gia).ToString() };
                    ListViewItem item = new ListViewItem(obj);
                    lsvChiTietHD.Items.Add(item);

                    txtTriGiaHD.Text = ((decimal.Parse(txtTriGiaHD.Text) + cthdSanPham.SoLuong * sp.Gia)).ToString();
                }
                else // Đã được chọn trong chi tiết hóa đơn sản phẩm
                {
                    int index = dscthdSanPham.IndexOf(cthdSanPham);
                    ListViewItem item = lsvChiTietHD.Items[index];
                    cthdSanPham = dscthdSanPham[index];
                    cthdSanPham.SoLuong += int.Parse(txtSoLuong.Text);

                    txtTriGiaHD.Text = ((decimal.Parse(txtTriGiaHD.Text)) + (int.Parse(txtSoLuong.Text) * sp.Gia)).ToString();

                    item.SubItems[3].Text = cthdSanPham.SoLuong.ToString();
                    item.SubItems[4].Text = (cthdSanPham.SoLuong * sp.Gia).ToString();
                }
            }
        }

        private void lsvChiTietHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvChiTietHD.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvChiTietHD.SelectedItems[0];
                    string selectedID = item.SubItems[0].Text;

                    foreach (CCTHDVe cthdVe in dscthdVe)
                    {
                        if (cthdVe.Ve.IDVe == selectedID)
                        {
                            txtMaSP.Text = cthdVe.Ve.IDVe;
                            txtTenSP.Text = cthdVe.Ve.Phim.TenPhim;
                            txtSoLuong.Text = cthdVe.SoLuong.ToString();
                            return;
                        }
                    }

                    foreach (CCTHDThucAnDoUong cthdSanPham in dscthdSanPham)
                    {
                        if (cthdSanPham.SanPham.IDSanPham == selectedID)
                        {
                            txtMaSP.Text = cthdSanPham.SanPham.IDSanPham;
                            txtTenSP.Text = cthdSanPham.SanPham.TenSanPham;
                            txtSoLuong.Text = cthdSanPham.SoLuong.ToString();
                            return;
                        }
                    }
                }
            }
            catch { }
        }



        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có sản phẩm hoặc vé trong hóa đơn
            if (dscthdVe.Count > 0 || dscthdSanPham.Count > 0)
            {
                // Lưu thông tin hóa đơn
                string idhoadon = txtSoHD.Text;
                DateTime ngayxuathd = dTimeNgayHD.Value;

                // Lấy thông tin nhân viên từ ID nhập vào
                CNhanVien nhanvien = null;
                if (!string.IsNullOrEmpty(txtIDNhanVien.Text))
                {
                    nhanvien = dsNhanVien.FirstOrDefault(nv => nv.IDNhanVien == txtIDNhanVien.Text);
                    if (nhanvien == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên có ID này. Vui lòng nhập lại.");
                        txtIDNhanVien.Clear();
                        txtIDNhanVien.Focus();
                        return;
                    }
                }

                // Lấy thông tin thành viên từ combobox
                CThanhVien thanhvien = null;
                if (cbTheThanhVien.SelectedItem != null)
                {
                    thanhvien = (CThanhVien)cbTheThanhVien.SelectedItem;
                }

                // Tạo hóa đơn
                CHoaDon hd = new CHoaDon(idhoadon, ngayxuathd, nhanvien, thanhvien);

                // Lưu hóa đơn
                if (ctrHoaDon.insert(hd))
                {
                    // Lưu chi tiết hóa đơn vé
                    foreach (CCTHDVe cthdVe in dscthdVe)
                    {
                        cthdVe.HoaDon = hd;

                        if (ctrCTHDVe.insert(cthdVe))
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn vé thành công.");
                            btnThemSP.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn vé thất bại.");
                        }
                    }

                    // Lưu chi tiết hóa đơn sản phẩm
                    foreach (CCTHDThucAnDoUong cthdSanPham in dscthdSanPham)
                    {
                        cthdSanPham.HoaDon = hd;
                        if (ctrCTHDSanPham.insert(cthdSanPham))
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn sản phẩm thành công.");
                            btnThemSP.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn sản phẩm thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn thất bại.");
                }

                // Hiển thị thông tin hóa đơn đã lưu
                string nhanVienID = nhanvien != null ? nhanvien.IDNhanVien : "N/A";
                string thanhVienID = thanhvien != null ? thanhvien.IDThanhVien : "N/A";
                string[] objsp = { idhoadon, ngayxuathd.ToString(), nhanVienID, thanhVienID };
                ListViewItem item = new ListViewItem(objsp);
                lsvDanhSachHD.Items.Add(item);
                dsHoaDon.Add(hd);
                CapNhatSoLuongHD();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào được thêm vào hóa đơn.");
            }
        }


        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            btnThemSP.Enabled = true;
            // xoa du lieu trong listbox, listview
            lstSanPham.Items.Clear();
            lsvChiTietHD.Items.Clear();
            //tao so hd moi
            txtSoHD.Text = TaoSoHD() + "";
            dTimeNgayHD.Value = DateTime.Now;
            cbTheThanhVien.SelectedItem = null;
            txtTriGiaHD.Text = "0";
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Text = 1 + "";
            txtNVXuatHD.Clear();
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvChiTietHD.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lsvChiTietHD.SelectedItems[0];
                    int index = selectedItem.Index;
                    string selectedID = selectedItem.SubItems[0].Text;

                    foreach (CCTHDVe cthdVe in dscthdVe)
                    {
                        if (cthdVe.Ve.IDVe == selectedID)
                        {
                            if (ctrCTHDVe.delete(cthdVe))
                            {
                                MessageBox.Show("Xóa thông tin sản phẩm thành công.");
                                dscthdVe.Remove(cthdVe);
                                lsvChiTietHD.Items.RemoveAt(index);

                                // Kiểm tra nếu danh sách đã rỗng sau khi xóa
                                if (lsvChiTietHD.Items.Count == 0)
                                {
                                    // Reset giá trị tổng tiền hóa đơn
                                    txtTriGiaHD.Text = "0";
                                }

                                return;
                            }
                            else
                            {
                                MessageBox.Show("Xóa thông tin sản phẩm thất bại.");
                            }
                        }
                    }

                    foreach (CCTHDThucAnDoUong cthdSanPham in dscthdSanPham)
                    {
                        if (cthdSanPham.SanPham.IDSanPham == selectedID)
                        {
                            if (ctrCTHDSanPham.delete(cthdSanPham))
                            {
                                MessageBox.Show("Xóa thông tin sản phẩm thành công.");
                                dscthdSanPham.Remove(cthdSanPham);
                                lsvChiTietHD.Items.RemoveAt(index);

                                // Kiểm tra nếu danh sách đã rỗng sau khi xóa
                                if (lsvChiTietHD.Items.Count == 0)
                                {
                                    // Reset giá trị tổng tiền hóa đơn
                                    txtTriGiaHD.Text = "0";
                                }

                                return;
                            }
                            else
                            {
                                MessageBox.Show("Xóa thông tin sản phẩm thất bại.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin sản phẩm: " + ex.Message);
            }
        }



        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachHD.SelectedItems.Count > 0)
                {
                    ListViewItem item = lsvDanhSachHD.SelectedItems[0];
                    string selectedID = item.SubItems[0].Text;
                    CHoaDon hd = new CHoaDon();
                    hd.IDHoaDon = selectedID;

                    if (ctrHoaDon.delete(hd))
                    {
                        MessageBox.Show("Xóa thông tin hóa đơn thành công.");
                        dsHoaDon.Remove(hd);
                        lsvDanhSachHD.Items.Remove(item);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin hóa đơn thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
                }
                CapNhatSoLuongHD();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin hóa đơn.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
