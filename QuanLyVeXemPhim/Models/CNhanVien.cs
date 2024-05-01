using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CNhanVien
    {
        private string iDNhanVien;
        private string tenNV;
        private string matKhau;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;  // Sửa kiểu dữ liệu từ int sang string
        private string email;
        private string chucVu;

        public string IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }  // Sửa getter và setter
        public string Email { get => email; set => email = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public CNhanVien(string iDNhanVien, string tenNV, string matKhau, DateTime ngaySinh, string gioiTinh, string sdt, string email, string chucVu)
        {
            this.iDNhanVien = iDNhanVien;
            this.tenNV = tenNV;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;  // Cập nhật tham số sdt
            this.email = email;
            this.chucVu = chucVu;
        }

        public CNhanVien()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CNhanVien vien && iDNhanVien == vien.iDNhanVien;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDNhanVien);
        }
    }
}
