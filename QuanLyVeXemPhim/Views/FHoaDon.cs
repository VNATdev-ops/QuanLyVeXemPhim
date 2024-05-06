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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            lsvChiTietHD.Columns.Add("ID", 16 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Tên sản phẩm", 30 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Giá bán", 18 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Số lượng", 18 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Thành tiền", 18 * widthCT / 100);
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
        private int TaoSoHD()
        {
            string str = string.Format("{0:MMddhhmmss}", DateTime.Now);
            return int.Parse(str);
        }
        private void CapNhatSoLuongHD()
        {
            txtSoLuongHD.Text = dsHoaDon.Count.ToString();
        }
        private decimal TriGiaHoaDon(System.Windows.Forms.ListView lsvChiTietHD)
        {
            decimal total = 0;
            foreach (ListViewItem item in lsvChiTietHD.Items)
            {
                total += decimal.Parse(item.SubItems[4].Text);
            }
            return total;
        }
        private void ClearTextBoxSanPham()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Text = 1 + "";
        }
        private void LockSPButton()
        {
            btnThemSP.Enabled = false;
            btnCapNhatSoLuong.Enabled = false;
            btnHuy.Enabled = false;
            btnXoaCTHD.Enabled = false;
            btnLuuHD.Enabled = false;
            txtSoHD.ReadOnly = true;
            cbTheThanhVien.Enabled = false;
            dTimeNgayHD.Enabled = false;
        }
        private void UnlockSPButton()
        {
            btnThemSP.Enabled = true;
            btnCapNhatSoLuong.Enabled = true;
            btnHuy.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnLuuHD.Enabled = true;
            txtSoHD.ReadOnly = false;
            cbTheThanhVien.Enabled = true;
            dTimeNgayHD.Enabled = true;
        }
        private void FHoaDon_Load(object sender, EventArgs e)
        {
            dsNhanVien = ctrNhanVien.findall();
            dsThanhVien = ctrThanhVien.findall();
            dsVe = ctrVeXemPhim.findall();
            dsSanPham = ctrThucAnDoUong.findAll();
            dscthdSanPham = ctrCTHDSanPham.findAll();
            dscthdVe = ctrCTHDVe.findAll();
            dsHoaDon = ctrHoaDon.findAll();
            dsSanPham = ctrThucAnDoUong.findAll();

            //hien thi so hoa don
            txtSoHD.Text = TaoSoHD().ToString();
            dTimeNgayHD.Value = DateTime.Today;
            txtTriGiaHD.Text = "0";
            txtSoLuong.Text = 1 + "";

            //hien thi danh sach khach hang
            cbTheThanhVien.DataSource = dsThanhVien;

            foreach (CHoaDon s in dsHoaDon)
            {
                if (s.NhanVien == null) s.NhanVien = new CNhanVien();
                if (s.ThanhVien == null) s.ThanhVien = new CThanhVien();

                string[] obj = { s.IDHoaDon, s.NgayXuatHD.ToString(), s.NhanVien.IDNhanVien, s.ThanhVien.IDThanhVien };

                ListViewItem item = new ListViewItem(obj);
                lsvDanhSachHD.Items.Add(item);
                //item.SubItems[0].Text = s.IDHoaDon;
                //item.SubItems[1].Text = s.NgayXuatHD.ToString();
                //item.SubItems[2].Text = s.NhanVien.IDNhanVien;
                //item.SubItems[3].Text = s.ThanhVien.IDThanhVien;

            }
            CapNhatSoLuongHD();
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
                        cbTheThanhVien.Text = hd.ThanhVien.ToString();
                    }
                    else
                    {
                        cbTheThanhVien.SelectedItem = null;
                    }
                    if (hd.NhanVien != null)
                    {
                        txtNVXuatHD.Text = hd.NhanVien.ToString();
                    }
                    else
                    {
                        txtNVXuatHD.Text = "N/A";
                    }

                    lsvChiTietHD.Items.Clear();
                    List<CCTHDThucAnDoUong> dscthdSanPham = ctrCTHDSanPham.findCriteria(hd.IDHoaDon);
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
                    LockSPButton();

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
                CThanhVien tv = new CThanhVien();
                CNhanVien nv = new CNhanVien();

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

                    //txtTriGiaHD.Text = (int.Parse(txtTriGiaHD.Text) + cthdVe.SoLuong * sp.GiaVe).ToString();
                    txtTriGiaHD.Text = (TriGiaHoaDon(lsvChiTietHD)).ToString();
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

                CThanhVien tv = new CThanhVien();
                CNhanVien nv = new CNhanVien();

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
                    cthdSanPham = dscthdSanPham[index];
                    cthdSanPham.SoLuong += int.Parse(txtSoLuong.Text);
                    foreach (ListViewItem item in lsvChiTietHD.Items)
                    {
                        if (item.SubItems[0].Text == cthdSanPham.SanPham.IDSanPham)
                        {
                            item.SubItems[3].Text = cthdSanPham.SoLuong.ToString();
                            item.SubItems[4].Text = (cthdSanPham.SoLuong * sp.Gia).ToString();
                        }
                    }
                    dscthdSanPham[index] = cthdSanPham;
                    txtTriGiaHD.Text = ((decimal.Parse(txtTriGiaHD.Text)) + (int.Parse(txtSoLuong.Text) * sp.Gia)).ToString();
                }
                lstSanPham.ClearSelected();
            }

            ClearTextBoxSanPham();
        }

        private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvChiTietHD.SelectedItems.Count == 1)
                {
                    if (int.Parse(txtSoLuong.Text) > 0)
                    {
                        ListViewItem item = lsvChiTietHD.SelectedItems[0];
                        int index = lsvChiTietHD.Items.IndexOf(item);
                        item.SubItems[3].Text = txtSoLuong.Text;

                        // Cập nhật số lương trong danh sách chi tiết hóa đơn
                        foreach (CCTHDVe cthd in dscthdVe)
                        {
                            if (cthd.HoaDon.IDHoaDon == txtSoHD.Text && cthd.Ve.IDVe == item.SubItems[0].Text)
                            {
                                cthd.SoLuong = int.Parse(txtSoLuong.Text);
                                item.SubItems[3].Text = cthd.SoLuong.ToString();
                                item.SubItems[4].Text = (cthd.SoLuong * cthd.Ve.GiaVe).ToString();
                                break;
                            }
                        }
                        foreach (CCTHDThucAnDoUong cthd in dscthdSanPham)
                        {
                            if (cthd.HoaDon.IDHoaDon == txtSoHD.Text && cthd.SanPham.IDSanPham == item.SubItems[0].Text)
                            {
                                cthd.SoLuong = int.Parse(txtSoLuong.Text);
                                item.SubItems[3].Text = cthd.SoLuong.ToString();
                                item.SubItems[4].Text = (cthd.SoLuong * cthd.SanPham.Gia).ToString();
                                break;
                            }
                        }
                        // Cập nhật trong listview
                        lsvChiTietHD.Items[index] = item;
                        txtTriGiaHD.Text = TriGiaHoaDon(lsvChiTietHD).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng sản phẩm.");
                        txtSoLuong.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
                }
            }
            catch { }
        }

        private void lsvChiTietHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvChiTietHD.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = lsvChiTietHD.SelectedItems[0];
            string selectedID = selectedItem.SubItems[0].Text;
            string selectedHoaDonID = txtSoHD.Text;

            HandleCCTHDVeSelection(selectedHoaDonID, selectedID);
            HandleCCTHDThucAnDoUongSelection(selectedHoaDonID, selectedID);
        }

        private void HandleCCTHDVeSelection(string hoaDonID, string selectedID)
        {
            foreach (CCTHDVe cthdVe in dscthdVe)
            {
                CCTHDVe selectedItem = dscthdVe.FirstOrDefault(x => x.HoaDon.IDHoaDon == hoaDonID && x.Ve.IDVe == selectedID);
                if (selectedItem != null)
                {
                    txtMaSP.Text = selectedItem.Ve.IDVe;
                    txtTenSP.Text = selectedItem.Ve.Phim.TenPhim;
                    txtSoLuong.Text = selectedItem.SoLuong.ToString();
                }
                else
                {
                    ClearTextBoxSanPham();
                }
            }
        }

        private void HandleCCTHDThucAnDoUongSelection(string hoaDonID, string selectedID)
        {
            CCTHDThucAnDoUong selectedItem = dscthdSanPham.FirstOrDefault(x => x.HoaDon.IDHoaDon == hoaDonID && x.SanPham.IDSanPham == selectedID);
            if (selectedItem != null)
            {
                txtMaSP.Text = selectedItem.SanPham.IDSanPham;
                txtTenSP.Text = selectedItem.SanPham.TenSanPham;
                txtSoLuong.Text = selectedItem.SoLuong.ToString();
            }
            else
            {
                ClearTextBoxSanPham();
            }
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
                CNhanVien nhanvien = new CNhanVien();
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
                else
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên.");
                    txtIDNhanVien.Focus();
                    return;
                }

                // Lấy thông tin thành viên từ combobox
                CThanhVien thanhvien = new CThanhVien();
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
                        if (cthdVe.HoaDon.IDHoaDon == idhoadon)
                        {
                            cthdVe.HoaDon = hd;
                            if (ctrCTHDVe.insert(cthdVe))
                            {
                                MessageBox.Show("Lưu chi tiết hóa đơn vé thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Lưu chi tiết hóa đơn vé thất bại.");
                            }
                        }
                    }

                    // Lưu chi tiết hóa đơn sản phẩm
                    foreach (CCTHDThucAnDoUong cthdSanPham in dscthdSanPham)
                    {
                        if (cthdSanPham.HoaDon.IDHoaDon == idhoadon)
                        {
                            cthdSanPham.HoaDon = hd;
                            if (ctrCTHDSanPham.insert(cthdSanPham))
                            {
                                MessageBox.Show("Lưu chi tiết hóa đơn sản phẩm thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Lưu chi tiết hóa đơn sản phẩm thất bại.");
                            }
                        }
                    }

                    LockSPButton();
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn thất bại.");
                    return;
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
            UnlockSPButton();
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
                // Tạo một danh sách tạm thời để lưu các mục cần xóa
                List<ListViewItem> itemsToRemove = new List<ListViewItem>();
                if (lsvChiTietHD.SelectedItems.Count > 0)
                {
                    // Lặp qua các mục được chọn trong ListView
                    foreach (ListViewItem selectedItem in lsvChiTietHD.SelectedItems)
                    {
                        int index = selectedItem.Index;
                        string selectedID = selectedItem.SubItems[0].Text;

                        // Xác định xem mục cần xóa thuộc danh sách loại sản phẩm nào
                        foreach (CCTHDVe cthdVe in dscthdVe)
                        {
                            if (cthdVe.Ve.IDVe == selectedID && cthdVe.HoaDon.IDHoaDon == txtSoHD.Text)
                            {
                                dscthdVe.Remove(cthdVe);
                                itemsToRemove.Add(selectedItem);
                                MessageBox.Show("Đã xóa khỏi danh sách chi tiết sản phẩm.");
                                break;
                            }
                        }

                        foreach (CCTHDThucAnDoUong cthdSanPham in dscthdSanPham)
                        {
                            if (cthdSanPham.HoaDon.IDHoaDon == txtSoHD.Text && cthdSanPham.SanPham.IDSanPham == selectedID)
                            {
                                dscthdSanPham.Remove(cthdSanPham);
                                itemsToRemove.Add(selectedItem);
                                MessageBox.Show("Đã xóa khỏi danh sách chi tiết sản phẩm.");
                                break;
                            }
                        }
                    }

                    // Xóa các mục được chọn khỏi ListView
                    foreach (ListViewItem itemToRemove in itemsToRemove)
                    {
                        lsvChiTietHD.Items.Remove(itemToRemove);
                        MessageBox.Show("Xóa thông tin sản phẩm thành công.");
                    }

                    ClearTextBoxSanPham();

                    // Kiểm tra nếu danh sách đã rỗng sau khi xóa
                    if (lsvChiTietHD.Items.Count == 0)
                    {
                        // Reset giá trị tổng tiền hóa đơn
                        txtTriGiaHD.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
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
                    // Tạo một danh sách tạm thời để lưu các mục cần xóa từ ListView
                    List<ListViewItem> itemsToRemove = new List<ListViewItem>();
                    foreach (ListViewItem item in lsvDanhSachHD.SelectedItems)
                    {
                        //ListViewItem item = lsvDanhSachHD.SelectedItems[0];
                        string selectedID = item.SubItems[0].Text;


                        // Xóa hóa đơn khỏi ds hóa đơn
                        foreach (CHoaDon hd in dsHoaDon)
                        {
                            //lặp đến khi tìm được hóa đơn cần xóa trong danh sách
                            if (hd.IDHoaDon == selectedID)
                            {
                                itemsToRemove.Add(item);
                                // Xóa chi tiết hóa đơn sản phẩm của hóa đơn được chọn
                                foreach (CCTHDThucAnDoUong cthdSP in dscthdSanPham)
                                {
                                    if (cthdSP.HoaDon.IDHoaDon == selectedID)
                                    {
                                        try
                                        {
                                            // Xóa chi tiết hóa đơn từ danh sách và ListView
                                            ctrCTHDSanPham.delete_bySingleID(selectedID);
                                            MessageBox.Show("Xóa chi tiết hóa đơn sản phẩm của hóa đơn thành công.");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn sản phẩm: " + ex.Message);
                                        }
                                    }
                                }

                                // Xóa chi tiết hóa đơn vé của hóa đơn được chọn
                                foreach (CCTHDVe cthdVe in dscthdVe)
                                {
                                    if (cthdVe.HoaDon.IDHoaDon == selectedID)
                                    {
                                        try
                                        {
                                            // Xóa chi tiết hóa đơn từ danh sách và ListView
                                            ctrCTHDVe.delete(selectedID);
                                            MessageBox.Show("Xóa chi tiết hóa đơn vé của hóa đơn thành công.");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn vé: " + ex.Message);
                                        }
                                    }
                                }

                                dsHoaDon.Remove(hd);
                                break;
                            }

                        }

                        // Xóa hóa đơn từ danh sách
                        try
                        {
                            ctrHoaDon.delete(selectedID);
                            MessageBox.Show("Xóa thông tin hóa đơn thành công.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa thông tin hóa đơn: " + ex.Message);
                        }

                    }

                    // Xóa các mục đã được chọn khỏi ListView
                    foreach (ListViewItem itemToRemove in itemsToRemove)
                    {
                        lsvDanhSachHD.Items.Remove(itemToRemove);
                    }

                    // Cập nhật lại số lượng hóa đơn
                    CapNhatSoLuongHD();
                    // xoa du lieu 
                    lstSanPham.Items.Clear();
                    lsvChiTietHD.Items.Clear();
                    txtSoHD.Text = "";
                    dTimeNgayHD.Value = DateTime.Now;
                    cbTheThanhVien.SelectedItem = null;
                    txtTriGiaHD.Text = "0";
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    txtSoLuong.Text = "";
                    txtNVXuatHD.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin hóa đơn: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstSanPham.SelectedItem != null)
        //    {
        //        if (lstSanPham.SelectedItem is CThucAnDoUong)
        //        {
        //            CThucAnDoUong item = (CThucAnDoUong)lstSanPham.SelectedItem;
        //            txtMaSP.Text = item.IDSanPham;
        //            txtTenSP.Text = item.TenSanPham;

        //        }
        //        else if (lstSanPham.SelectedItem is CVeXemPhim)
        //        {
        //            CVeXemPhim item = (CVeXemPhim)lstSanPham.SelectedItem;
        //            txtMaSP.Text = item.IDVe;
        //            txtTenSP.Text = item.Phim.TenPhim;
        //        }
        //        if (lstSanPham.Items.Count == 1)
        //        {
        //            lstSanPham.Focus();
        //            lstSanPham.Select();
        //        }
        //    }
        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxSanPham();
        }

    }
}
