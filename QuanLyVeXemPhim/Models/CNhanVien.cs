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
        private DateTime ngaySinh;
        private int sdt;
        private string email;
        private string chucVu;

        public string IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public CNhanVien(string iDNhanVien, string tenNV, DateTime ngaySinh, int sdt, string email, string chucVu)
        {
            this.iDNhanVien = iDNhanVien;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
            this.chucVu = chucVu;
        }

        public CNhanVien()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CNhanVien vien &&
                   iDNhanVien == vien.iDNhanVien;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDNhanVien);
        }
    }
}
