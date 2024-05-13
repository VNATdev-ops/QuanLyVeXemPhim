using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CSanPham
    {
        private string iDSanPham;
        private string loai;
        private string tenSanPham;
        private decimal gia;
        private string hinh;

        public string IDSanPham { get => iDSanPham; set => iDSanPham = value; }
        public string Loai { get => loai; set => loai = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string Hinh { get => hinh; set => hinh = value; }

        public CSanPham(string iDSanPham, string loai, string tenSanPham, decimal gia, string hinh)
        {
            this.iDSanPham = iDSanPham;
            this.loai = loai;
            this.tenSanPham = tenSanPham;
            this.gia = gia;
            this.hinh = hinh;
        }

        public CSanPham()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CSanPham thucAnDoUong &&
                   iDSanPham == thucAnDoUong.iDSanPham;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDSanPham);
        }

        public override string ToString()
        {
            return tenSanPham + " (" + gia + ")";
        }
    }
}
