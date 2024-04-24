using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CThucAnDoUong
    {
        private int iDMon;
        private string loai;
        private string tenSanPham;
        private decimal gia;
        private string hinh;

        public int IDMon { get => iDMon; set => iDMon = value; }
        public string Loai { get => loai; set => loai = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string Hinh { get => hinh; set => hinh = value; }

        public CThucAnDoUong(int iDMon, string loai, string tenSanPham, decimal gia, string hinh)
        {
            this.IDMon = iDMon;
            this.Loai = loai;
            this.TenSanPham = tenSanPham;
            this.Gia = gia;
            this.Hinh = hinh;
        }
        public CThucAnDoUong()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CThucAnDoUong thucAnDoUong &&
                   iDMon == thucAnDoUong.iDMon;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDMon);
        }
    }
}
