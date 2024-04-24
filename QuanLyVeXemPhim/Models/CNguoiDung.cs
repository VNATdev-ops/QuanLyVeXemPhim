using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CNguoiDung
    {
        private int nguoiDungID;
        private string ten;
        private string matKhau;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string khuVuc;
        private string email;
        private string loaiTaiKhoan;

        public CNguoiDung()
        {
        }

        public CNguoiDung(int nguoiDungID, string ten, string matKhau, DateTime ngaySinh, string gioiTinh, string khuVuc, string email, string loaiTaiKhoan)
        {
            this.nguoiDungID = nguoiDungID;
            this.ten = ten;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.khuVuc = khuVuc;
            this.email = email;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }

        public override bool Equals(object? obj)
        {
            return obj is CNguoiDung dung &&
                   nguoiDungID == dung.nguoiDungID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nguoiDungID);
        }
    }
}
