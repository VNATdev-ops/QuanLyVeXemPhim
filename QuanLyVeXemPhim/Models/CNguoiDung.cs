using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CNguoiDung
    {
        private int idNguoidung;
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

        public int IdNguoidung { get => idNguoidung; set => idNguoidung = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string Email { get => email; set => email = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        public override bool Equals(object? obj)
        {
            return obj is CNguoiDung dung &&
                   idNguoidung == dung.idNguoidung;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idNguoidung);
        }
    }
}
