﻿using QuanLyVeXemPhim.Controller;
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
        CtrlNhanVien ctrNhanVien = new CtrlNhanVien();
        CtrlThanhVien ctrThanhVien = new CtrlThanhVien();
        CtrlVeXemPhim ctrVeXemPhim = new CtrlVeXemPhim();
        CtrlSanPham ctrSanPham = new CtrlSanPham();
        CtrlCTHD ctrCTHD = new CtrlCTHD();
        List<CHoaDon> dsHoaDon = new List<CHoaDon>();
        List<CNhanVien> dsNhanVien = new List<CNhanVien>();
        List<CThanhVien> dsThanhVien = new List<CThanhVien>();
        List<CCTHD> dscthdSanPham = new List<CCTHD>();
        List<CPhim> dsPhim = new List<CPhim>();
        List<CVeXemPhim> dsVe = new List<CVeXemPhim>();
        List<CSanPham> dsSanPham = new List<CSanPham>();

        public FHoaDon()
        {
            InitializeComponent();

            //khai bao cot chi tiet hoa don
            int widthCT = lsvChiTietHD.Width;
            lsvChiTietHD.Columns.Add("ID", 15 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Tên sản phẩm", 30 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Giá bán", 18 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Số lượng", 18 * widthCT / 100);
            lsvChiTietHD.Columns.Add("Thành tiền", 18 * widthCT / 100);
            lsvChiTietHD.View = View.Details;
            lsvChiTietHD.FullRowSelect = true;

            //khai bao cot danh sach hoa don
            int widthDS = lsvDanhSachHD.Width;
            lsvDanhSachHD.Columns.Add("ID hóa đơn", 29 * widthDS / 100);
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
            dsSanPham = ctrSanPham.findAll();
            dscthdSanPham = ctrCTHD.findAll();
            dsHoaDon = ctrHoaDon.findAll();
            dsSanPham = ctrSanPham.findAll();
            dsVe = ctrVeXemPhim.findall();

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
                    List<CCTHD> dscthdSanPham = ctrCTHD.findCriteria(hd.IDHoaDon);
                    foreach (CCTHD chiTietSanPham in dscthdSanPham)
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
            List<CSanPham> dsThucAnDoUong = new List<CSanPham>();
            dsThucAnDoUong = ctrSanPham.findCriteria(txtTenSP.Text);

            if (dsThucAnDoUong.Count > 0)
            {
                lstSanPham.Items.Clear();
                foreach (CSanPham thucAnDoUong in dsThucAnDoUong)
                {
                    // Thêm dữ liệu từ CThucAnDoUong vào danh sách
                    lstSanPham.Items.Add(thucAnDoUong);
                }
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            List<CSanPham> dsThucAnDoUong = new List<CSanPham>();
            dsThucAnDoUong = ctrSanPham.findCriteria(txtMaSP.Text);

            if (dsThucAnDoUong.Count > 0)
            {
                lstSanPham.Items.Clear();
                foreach (CSanPham thucAnDoUong in dsThucAnDoUong)
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
            if (lstSanPham.SelectedItem is CSanPham)
            {
                CSanPham sp = (CSanPham)lstSanPham.SelectedItem;
                CCTHD cthdSanPham = new CCTHD();

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
                        foreach (CCTHD cthd in dscthdSanPham)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxSanPham();
        }

        private void lsvChiTietHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvChiTietHD.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = lsvChiTietHD.SelectedItems[0];
            string selectedID = selectedItem.SubItems[0].Text;
            string selectedHoaDonID = txtSoHD.Text;
            HandleCCTHDThucAnDoUongSelection(selectedHoaDonID, selectedID);
        }

        private void HandleCCTHDThucAnDoUongSelection(string hoaDonID, string selectedID)
        {
            CCTHD selectedItem = dscthdSanPham.FirstOrDefault(x => x.HoaDon.IDHoaDon == hoaDonID && x.SanPham.IDSanPham == selectedID);
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
            if (dscthdSanPham.Count > 0)
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
                    // Lưu chi tiết hóa đơn sản phẩm
                    foreach (CCTHD cthdSanPham in dscthdSanPham)
                    {
                        if (cthdSanPham.HoaDon.IDHoaDon == idhoadon)
                        {
                            cthdSanPham.HoaDon = hd;
                            if (ctrCTHD.insert(cthdSanPham))
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

                        foreach (CCTHD cthdSanPham in dscthdSanPham)
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
                                foreach (CCTHD cthdSP in dscthdSanPham)
                                {
                                    if (cthdSP.HoaDon.IDHoaDon == selectedID)
                                    {
                                        try
                                        {
                                            // Xóa chi tiết hóa đơn từ danh sách và ListView
                                            ctrCTHD.delete_bySingleID(selectedID);
                                            MessageBox.Show("Xóa chi tiết hóa đơn sản phẩm của hóa đơn thành công.");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn sản phẩm: " + ex.Message);
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

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedItem != null)
            {
                if (lstSanPham.SelectedItem is CSanPham)
                {
                    // Temporarily disable event handlers
                    txtMaSP.TextChanged -= txtMaSP_TextChanged;
                    txtTenSP.TextChanged -= txtTenSP_TextChanged;

                    CSanPham item = (CSanPham)lstSanPham.SelectedItem;
                    txtMaSP.Text = item.IDSanPham;
                    txtTenSP.Text = item.TenSanPham;

                    // Re-enable event handlers
                    txtMaSP.TextChanged += txtMaSP_TextChanged;
                    txtTenSP.TextChanged += txtTenSP_TextChanged;
                }
            }
        }
    }
}
