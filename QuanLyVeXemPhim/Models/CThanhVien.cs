using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CThanhVien
    {
        private string iDThanhVien;
        private string tenThanhVien;
        private string matKhau;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string khuVuc;
        private string email;

        public string IDThanhVien { get => iDThanhVien; set => iDThanhVien = value; }
        public string TenThanhVien { get => tenThanhVien; set => tenThanhVien = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string Email { get => email; set => email = value; }

        public CThanhVien(string iDThanhVien, string tenThanhVien, string matKhau, DateTime ngaySinh, string gioiTinh, string khuVuc, string email)
        {
            this.iDThanhVien = iDThanhVien;
            this.tenThanhVien = tenThanhVien;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.khuVuc = khuVuc;
            this.email = email;
        }

        public CThanhVien()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CThanhVien vien &&
                   iDThanhVien == vien.iDThanhVien;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDThanhVien);
        }
        

    }
}
